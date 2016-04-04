using Microsoft.Automata;
using Microsoft.Automata.Z3;
using Microsoft.Automata.CSharpFrontend.Runtime;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Z3;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.CodeGeneration
{
    using SF = Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

    class ParasailCodeGenerator
    {
        Compilation _compilation;
        INamedTypeSymbol _ienumerable;
        INamedTypeSymbol _icomputation;
        INamedTypeSymbol _totalComputation;

        public ParasailCodeGenerator(Compilation compilation)
        {
            _compilation = compilation;
            _ienumerable = _compilation.GetTypeByMetadataName(typeof(IEnumerable<>).FullName);
            _icomputation = _compilation.GetTypeByMetadataName(typeof(IComputation<,>).FullName);
            _totalComputation = _compilation.GetTypeByMetadataName(typeof(TotalComputation<,>).FullName);
        }

        public ClassDeclarationSyntax Generate(TransducerCompilation source, STb<FuncDecl, Expr, Sort> stb, ClassDeclarationSyntax classDecl)
        {
            var members = new List<MemberDeclarationSyntax>();

            var ctx = ((Z3Provider)stb.Solver).Z3;
            var compTree = ComputationTreeTransformer.ToComputationTrees(stb, true);
            var silentCompTree = ComputationTreeTransformer.ToComputationTrees(stb, false);
            var stateSort = compTree.InitialState.Sort;
            var inputVar = stb.Solver.MkVar(0, stb.InputSort);

            // Construct types
            var inputType = ((INamedTypeSymbol)source.InputTypeSymbol).CreateSyntax();
            var outputType = ((INamedTypeSymbol)source.OutputTypeSymbol).CreateSyntax();
            var outputEnumerableType = _ienumerable.CreateGenericSyntax(outputType);
            var stateType = GetTypeForSort(stateSort);
            var outerComputationType = _icomputation.CreateGenericSyntax(stateType, stateType);
            var innerComputationType = _totalComputation.CreateGenericSyntax(stateType, stateType);
            var IS = SF.Identifier("InstructionSet").CreateGenericSyntax(stateType);

            int nextStaticExpressionVar = 0;
            Func<Expr, IdentifierNameSyntax> declareStatic = (term) =>
            {
                var type = _totalComputation.CreateGenericSyntax(stateType, GetTypeForSort(term.Sort));
                var name = CodeGenerator.CreateName(source.DeclarationType, "_e" + (nextStaticExpressionVar++));
                members.Add(SF.FieldDeclaration((SF.VariableDeclaration(type, SF.SingletonSeparatedList(SF.VariableDeclarator(name)
                    .WithInitializer(SF.EqualsValueClause(SF.LiteralExpression(SyntaxKind.NullLiteralExpression)))))))
                    .WithModifiers(SF.TokenList(SF.Token(SyntaxKind.StaticKeyword))));
                return SF.IdentifierName(name);
            };
            var cache = new Dictionary<Expr, Tuple<bool, ExpressionSyntax>>();

            // Expression generator
            var eg = new ParasailExpressionGenerator(ctx, inputVar, (decl, subs) => ConstructDatatype(decl, subs), stateType, cache, declareStatic);

            // Create move
            var inputParameter = SF.Identifier("i");
            var innerComputationParameter = SF.Identifier("c");
            eg.Variables[inputVar] = SF.IdentifierName(inputParameter);
            eg.Variables[stb.Solver.MkVar(2, stateSort)] = SF.IdentifierName(innerComputationParameter);
            var moveDecl = SF.MethodDeclaration(outerComputationType, CodeGenerator.CreateName(source.DeclarationType, "MoveComputation"))
                .WithModifiers(SF.TokenList(SF.Token(SyntaxKind.StaticKeyword)))
                .WithParameterList(SF.ParameterList(SF.SeparatedList(new[] { SF.Parameter(inputParameter).WithType(inputType), SF.Parameter(innerComputationParameter).WithType(innerComputationType) })))
                .WithBody(GenerateComputationMethodBody(compTree.Move, IS, eg, stateType));
            members.Add(moveDecl);

            // Create silent move
            var silentMoveDecl = SF.MethodDeclaration(outerComputationType, CodeGenerator.CreateName(source.DeclarationType, "SilentMoveComputation"))
                .WithModifiers(SF.TokenList(SF.Token(SyntaxKind.StaticKeyword)))
                .WithParameterList(SF.ParameterList(SF.SeparatedList(new[] { SF.Parameter(inputParameter).WithType(inputType), SF.Parameter(innerComputationParameter).WithType(innerComputationType) })))
                .WithBody(GenerateComputationMethodBody(silentCompTree.Move, IS, eg, stateType));
            members.Add(silentMoveDecl);

            // Create finish
            var finishDecl = SF.MethodDeclaration(outerComputationType, CodeGenerator.CreateName(source.DeclarationType, "FinishComputation"))
                .WithModifiers(SF.TokenList(SF.Token(SyntaxKind.StaticKeyword)))
                .WithParameterList(SF.ParameterList(SF.SingletonSeparatedList(SF.Parameter(innerComputationParameter).WithType(innerComputationType))))
                .WithBody(GenerateComputationMethodBody(compTree.Finish, IS, eg, stateType, isFinish: true));
            members.Add(finishDecl);

            // Create silent finish
            var silentFinishDecl = SF.MethodDeclaration(outerComputationType, CodeGenerator.CreateName(source.DeclarationType, "SilentFinishComputation"))
                .WithModifiers(SF.TokenList(SF.Token(SyntaxKind.StaticKeyword)))
                .WithParameterList(SF.ParameterList(SF.SingletonSeparatedList(SF.Parameter(innerComputationParameter).WithType(innerComputationType))))
                .WithBody(GenerateComputationMethodBody(silentCompTree.Finish, IS, eg, stateType, isFinish: true));
            members.Add(silentFinishDecl);

            // Create output projection
            var stateParameter = SF.Identifier("s");
            var outDecl = SF.MethodDeclaration(outputEnumerableType, CodeGenerator.CreateName(source.DeclarationType, "Out"))
                .WithModifiers(SF.TokenList(SF.Token(SyntaxKind.StaticKeyword)))
                .WithParameterList(SF.ParameterList(SF.SingletonSeparatedList(SF.Parameter(stateParameter).WithType(stateType))))
                .WithBody(SF.Block(SF.ReturnStatement(SF.IdentifierName(stateParameter).Dot("Item2"))));
            members.Add(outDecl);

            // Create output clear
            var clearDecl = SF.MethodDeclaration(outerComputationType, CodeGenerator.CreateName(source.DeclarationType, "ClearComputation"))
                .WithModifiers(SF.TokenList(SF.Token(SyntaxKind.StaticKeyword)))
                .WithParameterList(SF.ParameterList(SF.SingletonSeparatedList(SF.Parameter(innerComputationParameter).WithType(innerComputationType))))
                .WithBody(SF.Block(SF.ReturnStatement(IS.Call("MkTuple",
                    IS.Call("Proj1", SF.IdentifierName(innerComputationParameter)),
                    IS.Call("Constant", SF.CastExpression(outputEnumerableType, SF.ArrayCreationExpression(
                        SF.ArrayType(outputType, SF.SingletonList(SF.ArrayRankSpecifier(SF.SingletonSeparatedList((ExpressionSyntax)SF.LiteralExpression(SyntaxKind.NumericLiteralExpression, SF.Literal(0))))))))),
                    IS.Call("Proj3", SF.IdentifierName(innerComputationParameter))))));
            members.Add(clearDecl);

            // Create invoke
            //var dataParameter = SF.Identifier("data");
            //var invokeDecl = SF.MethodDeclaration(outputEnumerableType, CreateName(source.DeclarationType, "Invoke"))
            //    .WithModifiers(SF.TokenList(SF.Token(SyntaxKind.PublicKeyword), SF.Token(SyntaxKind.OverrideKeyword)))
            //    .WithParameterList(SF.ParameterList(SF.SingletonSeparatedList(SF.Parameter(dataParameter).WithType(_ienumerable.CreateGenericSyntax(inputType)))))
            //    .WithBody(SF.Block(SF.ReturnStatement(SF.InvocationExpression(SF.IdentifierName(dataParameter).Dot(SF.IdentifierName("PMap")),
            //        SF.ArgumentList(SF.SeparatedList(new[] {
            //            SF.Argument(SF.IdentifierName(moveDecl.Identifier)),
            //            SF.Argument(SF.InvocationExpression(SF.IdentifierName(finishDecl.Identifier), SF.ArgumentList())),
            //            SF.Argument(SF.InvocationExpression(SF.IdentifierName(clearDecl.Identifier), SF.ArgumentList())),
            //            SF.Argument(SF.IdentifierName(outDecl.Identifier)),
            //            SF.Argument(SF.IdentifierName(initialStateDecl.Identifier)) }))))));
            //members.Add(invokeDecl);


            // Create variable for the initial state
            var initialStateDecl = SF.VariableDeclarator(CodeGenerator.CreateName(source.DeclarationType, "_initialState"));
            members.Add(SF.FieldDeclaration(SF.VariableDeclaration(stateType,
                SF.SingletonSeparatedList(initialStateDecl))).WithModifiers(SF.TokenList(SF.Token(SyntaxKind.StaticKeyword), SF.Token(SyntaxKind.ReadOnlyKeyword))));

            var implementationType = SF.Identifier("Implementation").CreateGenericSyntax(inputType, outputType, stateType);
            var implementationDecl = SF.VariableDeclarator(CodeGenerator.CreateName(source.DeclarationType, "Implementation"));
            members.Add(SF.FieldDeclaration(SF.VariableDeclaration(implementationType,
                SF.SingletonSeparatedList(implementationDecl))).WithModifiers(SF.TokenList(SF.Token(SyntaxKind.PublicKeyword), SF.Token(SyntaxKind.StaticKeyword), SF.Token(SyntaxKind.ReadOnlyKeyword))));

            bool isComputation;
            Func<Expr, IdentifierNameSyntax> cachingNotPermitted = e => { throw new CodeGenerationException("Initial state constant expression generator tried to cache a computation"); };
            var staticConstructorDecl = SF.ConstructorDeclaration(classDecl.Identifier)
                .WithModifiers(SF.TokenList(SF.Token(SyntaxKind.StaticKeyword)))
                .WithBody(SF.Block(
                    SF.ExpressionStatement(SF.AssignmentExpression(SyntaxKind.SimpleAssignmentExpression, SF.IdentifierName(initialStateDecl.Identifier),
                        eg.GenerateExpression(compTree.InitialState, new Dictionary<Expr, Tuple<bool, ExpressionSyntax>>(), cachingNotPermitted, out isComputation))),
                    SF.ExpressionStatement(SF.AssignmentExpression(SyntaxKind.SimpleAssignmentExpression, SF.IdentifierName(implementationDecl.Identifier),
                        SF.ObjectCreationExpression(implementationType).WithArgumentList(SF.ArgumentList(SF.SeparatedList(new[] {
                            SF.Argument(SF.IdentifierName(moveDecl.Identifier)),
                            SF.Argument(SF.IdentifierName(silentMoveDecl.Identifier)),
                            SF.Argument(SF.IdentifierName(finishDecl.Identifier)),
                            SF.Argument(SF.IdentifierName(silentFinishDecl.Identifier)),
                            SF.Argument(SF.IdentifierName(clearDecl.Identifier)),
                            SF.Argument(SF.IdentifierName(outDecl.Identifier)),
                            SF.Argument(SF.IdentifierName(initialStateDecl.Identifier)) })))))));
            Debug.Assert(!isComputation);
            members.Add(staticConstructorDecl);

            return classDecl.AddMembers(members.ToArray());
        }

        #region Move and Finish
        BlockSyntax GenerateComputationMethodBody(ComputationNode comp, GenericNameSyntax IS, ParasailExpressionGenerator eg,
            TypeSyntax stateType, bool isFinish = false)
        {
            var statements = new List<StatementSyntax>();
            int nextLocalVar = 0;

            var cache = new Dictionary<Expr, Tuple<bool, ExpressionSyntax>>();

            Func<Expr, IdentifierNameSyntax> declareLocal = (term) =>
            {
                var type = _totalComputation.CreateGenericSyntax(stateType, GetTypeForSort(term.Sort));
                var name = "e" + (nextLocalVar++);
                statements.Add(SF.LocalDeclarationStatement(SF.VariableDeclaration(type, SF.SingletonSeparatedList(SF.VariableDeclarator(name)
                    .WithInitializer(SF.EqualsValueClause(SF.LiteralExpression(SyntaxKind.NullLiteralExpression)))))));
                return SF.IdentifierName(name);
            };

            statements.Add(SF.ReturnStatement(GenerateExpressionForNode(comp, IS, eg, cache, declareLocal)));
            return SF.Block(statements);
        }

        ExpressionSyntax GenerateExpressionForNode(ComputationNode comp, GenericNameSyntax IS, ParasailExpressionGenerator eg, Dictionary<Expr, Tuple<bool, ExpressionSyntax>> cache, Func<Expr, IdentifierNameSyntax> declareLocal)
        {
            var iteNode = comp as IteNode;
            if (iteNode != null)
            {
                bool isConditionComputation;
                var conditionSyntax = eg.GenerateExpression(iteNode.Condition, cache, declareLocal, out isConditionComputation);
                var ifTrueSyntax = GenerateExpressionForNode(iteNode.IfTrue, IS, eg, cache, declareLocal);
                var ifFalseSyntax = GenerateExpressionForNode(iteNode.IfFalse, IS, eg, cache, declareLocal);
                if (isConditionComputation)
                {
                    return IS.Call("Ite", conditionSyntax, ifTrueSyntax, ifFalseSyntax);
                }
                else
                {
                    return SF.ConditionalExpression(conditionSyntax, ifTrueSyntax, ifFalseSyntax);
                }
            }

            var switchNode = comp as SwitchNode;
            if (switchNode != null)
            {
                bool ignore;
                return IS.Call("Switch", switchNode.Cases.Zip(switchNode.Children, (guard, child) =>
                    IS.Call("Case", eg.GenerateExpression(guard, cache, declareLocal, out ignore), GenerateExpressionForNode(child, IS, eg, cache, declareLocal))));
            }

            var resultNode = comp as ResultNode;
            if (resultNode != null)
            {
                bool ignore;
                return eg.GenerateExpression(resultNode.Value, cache, declareLocal, out ignore);
            }

            var undefNode = comp as UndefinedNode;
            if (undefNode != null)
            {
                return IS.Call("Undef");
            }

            throw new CodeGenerationException("Unsupported computation node type");
        }
        #endregion

        INamedTypeSymbol GetTupleType(uint arity)
        {
            switch (arity)
            {
                case 0:
                    return _compilation.GetTypeByMetadataName(typeof(Tuple).FullName);
                case 1:
                    return _compilation.GetTypeByMetadataName(typeof(Tuple<>).FullName);
                case 2:
                    return _compilation.GetTypeByMetadataName(typeof(Tuple<,>).FullName);
                case 3:
                    return _compilation.GetTypeByMetadataName(typeof(Tuple<,,>).FullName);
                case 4:
                    return _compilation.GetTypeByMetadataName(typeof(Tuple<,,,>).FullName);
                case 5:
                    return _compilation.GetTypeByMetadataName(typeof(Tuple<,,,,>).FullName);
                case 6:
                    return _compilation.GetTypeByMetadataName(typeof(Tuple<,,,,,>).FullName);
                case 7:
                    return _compilation.GetTypeByMetadataName(typeof(Tuple<,,,,,,>).FullName);
                case 8:
                    return _compilation.GetTypeByMetadataName(typeof(Tuple<,,,,,,,>).FullName);
            }
            throw new CodeGenerationException("Support for tuples of length " + arity + " not implemented");
        }

        INamedTypeSymbol GetIntType(bool isSigned, uint size)
        {
            if (isSigned)
            {
                switch (size)
                {
                    case 8:
                        return _compilation.GetTypeByMetadataName(typeof(sbyte).FullName);
                    case 16:
                        return _compilation.GetTypeByMetadataName(typeof(short).FullName);
                    case 32:
                        return _compilation.GetTypeByMetadataName(typeof(int).FullName);
                    case 64:
                        return _compilation.GetTypeByMetadataName(typeof(long).FullName);
                }
            }
            else
            {
                switch (size)
                {
                    case 8:
                        return _compilation.GetTypeByMetadataName(typeof(byte).FullName);
                    case 16:
                        return _compilation.GetTypeByMetadataName(typeof(ushort).FullName);
                    case 32:
                        return _compilation.GetTypeByMetadataName(typeof(uint).FullName);
                    case 64:
                        return _compilation.GetTypeByMetadataName(typeof(ulong).FullName);
                }
            }
            throw new CodeGenerationException("No C# integer type exists for signed=" + isSigned + " size=" + size);
        }

        ExpressionSyntax ConstructDatatype(FuncDecl constructor, ExpressionSyntax[] subsyntaxes)
        {
            var datatypeSort = constructor.Range as DatatypeSort;
            if (datatypeSort != null)
            {
                if (datatypeSort.NumConstructors == 1)
                {
                    return SF.ObjectCreationExpression(GetTypeForSort(datatypeSort))
                        .WithArgumentList(SF.ArgumentList(SF.SeparatedList(subsyntaxes.Select(x => SF.Argument(x)))));
                }
                if (datatypeSort.Name.ToString() == "List" && constructor.Name.ToString() == "nil") // This seems dangerous. Maybe list types should be recorded somewhere.
                {
                    var elementType = GetTypeForSort(datatypeSort.Accessors[1][0].Range);
                    return SF.ArrayCreationExpression(SF.ArrayType(elementType, SF.SingletonList(SF.ArrayRankSpecifier(SF.SingletonSeparatedList((ExpressionSyntax)SF.LiteralExpression(SyntaxKind.NumericLiteralExpression, SF.Literal(0)))))));
                }
            }
            throw new CodeGenerationException("Unsupported Z3 constructor: " + constructor);
        }

        TypeSyntax GetTypeForSort(Sort sort)
        {
            switch (sort.SortKind)
            {
                case Z3_sort_kind.Z3_DATATYPE_SORT:
                    var datatypeSort = sort as DatatypeSort;
                    if (datatypeSort.NumConstructors == 1)
                    {
                        var fieldTypes = datatypeSort.Accessors[0].Select(a => GetTypeForSort(a.Range)).ToArray();
                        // TODO: don't use tuples but generate the IComputation classes for a custom struct and use that
                        return GetTupleType((uint)fieldTypes.Length).CreateGenericSyntax(fieldTypes);
                    }
                    if (datatypeSort.Name.ToString() == "List") // This seems dangerous. Maybe list types should be recorded somewhere.
                    {
                        var elementType = GetTypeForSort(datatypeSort.Accessors[1][0].Range);
                        return _ienumerable.CreateGenericSyntax(elementType);
                    }
                    break;
                case Z3_sort_kind.Z3_BV_SORT:
                    var bvSort = sort as BitVecSort;
                    return GetIntType(true, bvSort.Size).CreateSyntax(); // Assume all ints are signed
                case Z3_sort_kind.Z3_INT_SORT:
                    return GetIntType(true, 32).CreateSyntax(); // TODO: this is a semantic mismatch
                case Z3_sort_kind.Z3_BOOL_SORT:
                    return _compilation.GetTypeByMetadataName(typeof(bool).FullName).CreateSyntax();
            }
            throw new CodeGenerationException("Unsupported Z3 sort: " + sort);
        }
    }
}
