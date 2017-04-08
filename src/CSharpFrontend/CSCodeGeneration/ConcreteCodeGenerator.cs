using Microsoft.Automata;
using Microsoft.Automata.Z3;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Z3;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.CodeGeneration
{
    using SF = Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
    using SH = SyntaxHelpers;

    class ConcreteCodeGenerator
    {
        Compilation _compilation;

        ExpressionSyntax _trueSyntax = SF.LiteralExpression(SyntaxKind.TrueLiteralExpression, SF.Token(SyntaxKind.TrueKeyword));
        ExpressionSyntax _falseSyntax = SF.LiteralExpression(SyntaxKind.FalseLiteralExpression, SF.Token(SyntaxKind.FalseKeyword));

        public ConcreteCodeGenerator(Compilation compilation)
        {
            _compilation = compilation;
        }

        public ClassDeclarationSyntax Generate(TransducerCompilation source, STb<FuncDecl, Expr, Sort> stb, ClassDeclarationSyntax classDecl)
        {
            bool commonExpressionsInTemporaries = true;

            stb = stb.Flatten();

            Dictionary<FuncDecl, SyntaxToken> knownFunctions;
            classDecl = GenerateBackgroundFunctions(((Z3Provider)stb.Solver).Z3, source, classDecl, out knownFunctions, false);

            var inputType = ((INamedTypeSymbol)source.InputTypeSymbol).CreateSyntax();
            var outputType = ((INamedTypeSymbol)source.OutputTypeSymbol).CreateSyntax();

            classDecl = DoGenerate("", source, stb, classDecl, knownFunctions,
                new IEnumerableInputCodeGenerator(_compilation, inputType),
                new IEnumerableYieldCodeGenerator(_compilation, outputType),
                commonExpressionsInTemporaries);

            if ((source.InputTypeSymbol.SpecialType == SpecialType.System_Byte || source.InputTypeSymbol.SpecialType == SpecialType.System_Boolean) &&
                source.OutputTypeSymbol.SpecialType == SpecialType.System_Byte)
            {
                ConcreteInputCodeGenerator streamInputGen = new StreamInputCodeGenerator(_compilation);
                ConcreteInputCodeGenerator arrayInputGen = new ArrayInputCodeGenerator(SH.PredefinedType(SyntaxKind.ByteKeyword));
                var streamYieldGen = new StreamYieldCodeGenerator(_compilation);

                if (source.InputTypeSymbol.SpecialType == SpecialType.System_Boolean)
                {
                    streamInputGen = new BitwiseInputWrapperGenerator(streamInputGen);
                    arrayInputGen = new BitwiseInputWrapperGenerator(arrayInputGen);
                }

                classDecl = DoGenerate("FromStreamToStream", source, stb, classDecl, knownFunctions, streamInputGen, streamYieldGen, commonExpressionsInTemporaries);
                classDecl = DoGenerate("FromArrayToStream", source, stb, classDecl, knownFunctions, arrayInputGen, streamYieldGen, commonExpressionsInTemporaries);
            }

            return classDecl;
        }

        public ClassDeclarationSyntax GenerateBackgroundFunctions(Context ctx, TransducerCompilation source, ClassDeclarationSyntax classDecl, out Dictionary<FuncDecl, SyntaxToken> knownFunctions, bool commonExpressionsInTemporaries)
        {
            var members = new List<MemberDeclarationSyntax>();
            Action<MemberDeclarationSyntax> addMember = memberSyntax => members.Add(memberSyntax);
            var datatypeSyntaxes = new Dictionary<Sort, TypeSyntax>();

            knownFunctions = new Dictionary<FuncDecl, SyntaxToken>();

            int functionIndex = 0;
            foreach (var entry in source.FunctionBodies)
            {
                knownFunctions.Add(entry.Item1, SF.Identifier(CodeGenerator.CreateName(source.DeclarationType, "Fun" + functionIndex)));
                ++functionIndex;
            }

            foreach (var entry in source.FunctionBodies)
            {
                int nextTemp = 0;
                var cachedSubexpressions = new Dictionary<Expr, ExpressionSyntax>();
                var cacheTempDeclarations = new List<StatementSyntax>();
                Func<Expr, ExpressionSyntax, ExpressionSyntax> cacheSubexpression = (term, syntax) =>
                {
                    if (!commonExpressionsInTemporaries)
                    {
                        return syntax;
                    }
                    var identifier = SF.Identifier("temp" + nextTemp);
                    cacheTempDeclarations.Add(SH.LocalDeclaration(SF.IdentifierName("var"), identifier, syntax));
                    nextTemp += 1;
                    var identifierName = SF.IdentifierName(identifier);
                    cachedSubexpressions.Add(term, SF.IdentifierName(identifier));
                    return identifierName;
                };

                var decl = entry.Item1;
                var returnType = GetTypeForSort(decl.Range, source, addMember, datatypeSyntaxes);
                var parameterNames = entry.Item3.Select((Term, i) => new { Term, Identifier = SF.Identifier("v" + i) });
                var variables = parameterNames.ToDictionary(x => x.Term, x => (ExpressionSyntax)SF.IdentifierName(x.Identifier));
                var returnStatement = SF.ReturnStatement(SF.CastExpression(returnType,
                    GenerateConcreteExpression(ctx, entry.Item2, variables, source, addMember, datatypeSyntaxes, knownFunctions, cacheSubexpression, cachedSubexpressions).Parenthesize()));
                var method = SF.MethodDeclaration(returnType, knownFunctions[decl])
                    .WithParameterList(SF.ParameterList(SF.SeparatedList(parameterNames.Select(x => SF.Parameter(x.Identifier)
                        .WithType(GetTypeForSort(x.Term.Sort, source, addMember, datatypeSyntaxes))))))
                    .WithBody(SF.Block(cacheTempDeclarations).AddStatements(returnStatement))
                    .WithModifiers(SF.TokenList(SF.Token(SyntaxKind.StaticKeyword)));
                members.Add(method);
            }

            return classDecl.AddMembers(members.ToArray());
        }

        public ClassDeclarationSyntax DoGenerate(string namePostfix, TransducerCompilation source, STb<FuncDecl, Expr, Sort> stb, ClassDeclarationSyntax classDecl,
            Dictionary<FuncDecl, SyntaxToken> knownFunctions, ConcreteInputCodeGenerator inputGen, ConcreteYieldCodeGenerator yieldGen, bool useCommonSubexpressionElimination)
        {
            var members = new List<MemberDeclarationSyntax>();
            Action<MemberDeclarationSyntax> addMember = memberSyntax => members.Add(memberSyntax);
            var datatypeSyntaxes = new Dictionary<Sort, TypeSyntax>();

            var ctx = ((Z3Provider)stb.Solver).Z3;

            // Construct types
            var inputType = ((INamedTypeSymbol)source.InputTypeSymbol).CreateSyntax();
            var outputType = ((INamedTypeSymbol)source.OutputTypeSymbol).CreateSyntax();
            var stateType = GetTypeForSort(stb.RegisterSort, source, addMember, datatypeSyntaxes);

            MethodDeclarationSyntax transduceDecl;

            transduceDecl = SF.MethodDeclaration(yieldGen.GetReturnType(), CodeGenerator.CreateName(source.DeclarationType, "Transduce" + namePostfix))
                    .WithModifiers(SF.TokenList(SF.Token(SyntaxKind.PublicKeyword), SF.Token(SyntaxKind.StaticKeyword)))
                    .WithParameterList(SF.ParameterList(SF.SeparatedList(inputGen.GetParameters().Concat(yieldGen.GetParameters()))));

            var body = SF.Block();

            body = body.AddStatements(inputGen.GetInitialization().ToArray());
            body = body.AddStatements(yieldGen.GetInitialization().ToArray());

            var register = SF.Identifier("s");
            body = body.AddStatements(SH.LocalDeclaration(stateType, register,
                GenerateConcreteExpression(ctx, stb.InitialRegister, new Dictionary<Expr, ExpressionSyntax>(), source, addMember, datatypeSyntaxes, knownFunctions,
                    (term, syntax) => syntax, new Dictionary<Expr, ExpressionSyntax>())));

            var currentInput = SF.Identifier("i");
            body = body.AddStatements(SH.LocalDeclaration(inputType, currentInput));

            var variables = new Dictionary<Expr, ExpressionSyntax>();
            variables.Add(stb.Solver.MkVar(0, stb.InputSort), SF.IdentifierName(currentInput));
            var registerVar = stb.Solver.MkVar(1, stb.RegisterSort);
            variables.Add(registerVar, SF.IdentifierName(register));

            int nextTemp = 0;
            Func<STbRule<Expr>, bool, Dictionary<Expr, ExpressionSyntax>, StatementSyntax> generateTransition = null;
            generateTransition = (rule, isFinal, cachedByParent) =>
            {
                var cachedSubexpressions = new Dictionary<Expr, ExpressionSyntax>(cachedByParent);
                var transitionStatements = new List<StatementSyntax>();
                Func<Expr, ExpressionSyntax, ExpressionSyntax> cacheSubexpression = (term, syntax) =>
                {
                    if (!useCommonSubexpressionElimination)
                    {
                        return syntax;
                    }
                    var identifier = SF.Identifier("temp" + nextTemp);
                    transitionStatements.Add(SH.LocalDeclaration(SF.IdentifierName("var"), identifier, syntax));
                    nextTemp += 1;
                    var identifierName = SF.IdentifierName(identifier);
                    cachedSubexpressions.Add(term, SF.IdentifierName(identifier));
                    return identifierName;
                };

                StatementSyntax ruleSyntax;

                var iteRule = rule as IteRule<Expr>;
                if (iteRule != null)
                {
                    var conditionExpression = GenerateConcreteExpression(ctx, iteRule.Condition, variables, source, addMember, datatypeSyntaxes, knownFunctions, cacheSubexpression, cachedSubexpressions);
                    var trueNode = generateTransition(iteRule.TrueCase, isFinal, cachedSubexpressions);
                    var falseNode = generateTransition(iteRule.FalseCase, isFinal, cachedSubexpressions);
                    transitionStatements.Add(SF.IfStatement(conditionExpression, trueNode, SF.ElseClause(falseNode)));
                    return SF.Block(transitionStatements);
                }

                var baseRule = rule as BaseRule<Expr>;
                if (baseRule != null)
                {
                    foreach (var yieldStatement in yieldGen.GetYields(baseRule.Yields.Select(x =>
                        {
                            var valueExpr = GenerateConcreteExpression(ctx, x, variables, source, addMember, datatypeSyntaxes, knownFunctions, cacheSubexpression, cachedSubexpressions);
                            var castedExpr = SF.CastExpression(outputType, valueExpr.Parenthesize());
                            return castedExpr;
                        }), baseRule.Yields.Length))
                    {
                        transitionStatements.Add(yieldStatement);
                    }
                    if (isFinal)
                    {
                        transitionStatements.AddRange(yieldGen.GetFinalization());
                    }
                    else
                    {
                        var update = GenerateUpdate(baseRule.Register, variables, source, stb, addMember, datatypeSyntaxes, registerVar, SF.IdentifierName(register), knownFunctions, cacheSubexpression, cachedSubexpressions);
                        foreach (var statement in update)
                        {
                            transitionStatements.Add(statement);
                        }
                        transitionStatements.Add(SF.GotoStatement(SyntaxKind.GotoStatement, SF.IdentifierName("M" + baseRule.State)));
                    }
                    return SF.Block(transitionStatements);
                }

                var raiseRule = rule as UndefRule<Expr>;
                if (raiseRule != null)
                {
                    return SF.ThrowStatement(SF.ObjectCreationExpression(SF.IdentifierName("Exception")).WithArgumentList(SF.ArgumentList()));
                }

                throw new CodeGenerationException("Unsupported STb rule type");
            };

            var moveBlocks = new List<StatementSyntax>();
            var finalizeBlocks = new List<StatementSyntax>();
            foreach (var state in OptimizedStateOrder(stb))
            {
                StatementSyntax finalizeBlock;
                if (stb.IsFinalState(state))
                {
                    finalizeBlock = generateTransition(stb.GetFinalRuleFrom(state), true, new Dictionary<Expr, ExpressionSyntax>());
                }
                else
                {
                    finalizeBlock = SF.ThrowStatement(SF.ObjectCreationExpression(SF.IdentifierName("Exception")).WithArgumentList(SF.ArgumentList()));
                }
                var gotoFinalize = SF.GotoStatement(SyntaxKind.GotoStatement, SF.IdentifierName("F" + state));

                var moveBlock = SF.Block();
                moveBlock = moveBlock.AddStatements(inputGen.GetMoveNext(gotoFinalize).ToArray());
                moveBlock = moveBlock.AddStatements(SH.Assignment(SF.IdentifierName(currentInput), inputGen.GetInput()));

                moveBlock = moveBlock.AddStatements(generateTransition(stb.GetRuleFrom(state), false, new Dictionary<Expr, ExpressionSyntax>()));

                moveBlocks.Add(SF.LabeledStatement("M" + state, moveBlock));
                finalizeBlocks.Add(SF.LabeledStatement("F" + state, finalizeBlock));
            }
            body = body.AddStatements(moveBlocks.ToArray());
            body = body.AddStatements(finalizeBlocks.ToArray());

            members.Add(transduceDecl.WithBody(SF.Block(SF.CheckedStatement(SyntaxKind.UncheckedStatement, body))));
            return classDecl.AddMembers(members.ToArray());
        }

        IEnumerable<int> OptimizedStateOrder(STb<FuncDecl, Expr, Sort> stb)
        {
            var visitedStates = new HashSet<int>();
            var workStack = new Stack<int>();

            yield return stb.InitialState;
            visitedStates.Add(stb.InitialState);
            workStack.Push(stb.InitialState);

            while (workStack.Count > 0)
            {
                foreach (var child in BreadthFirstStates(stb.GetRuleFrom(workStack.Peek())))
                {
                    if (visitedStates.Add(child))
                    {
                        yield return child;
                        workStack.Push(child);
                        goto DESCEND;
                    }
                }
                workStack.Pop();
                DESCEND:;
            }
        }

        IEnumerable<int> BreadthFirstStates(STbRule<Expr> root)
        {
            var workQueue = new Queue<STbRule<Expr>>();
            workQueue.Enqueue(root);

            while (workQueue.Count > 0)
            {
                var rule = workQueue.Dequeue();
                switch (rule.RuleKind)
                {
                    case STbRuleKind.Ite:
                        workQueue.Enqueue(rule.TrueCase);
                        workQueue.Enqueue(rule.FalseCase);
                        break;
                    case STbRuleKind.Base:
                        yield return rule.State;
                        break;
                }
            }
        }

        IEnumerable<StatementSyntax> GenerateUpdate(Expr term, Dictionary<Expr, ExpressionSyntax> variables, TransducerCompilation source, STb<FuncDecl, Expr, Sort> stb, Action<MemberDeclarationSyntax> addMember, Dictionary<Sort, TypeSyntax> datatypeSyntaxes,
            Expr registerVar, ExpressionSyntax registerIdentifier, Dictionary<FuncDecl, SyntaxToken> knownFunctions, Func<Expr, ExpressionSyntax, ExpressionSyntax> cacheSubexpression, Dictionary<Expr, ExpressionSyntax> cachedSubexpressions)
        {
            if (term == registerVar)
            {
                yield break;
            }

            var ctx = ((Z3Provider)stb.Solver).Z3;

            if (term.ASTKind == Z3_ast_kind.Z3_APP_AST && term.FuncDecl.DeclKind == Z3_decl_kind.Z3_OP_DT_CONSTRUCTOR && ((DatatypeSort)term.FuncDecl.Range).NumConstructors == 1)
            {
                var range = term.FuncDecl.Range as DatatypeSort;

                var changedFields = term.Args.Select((Term, Index) => new { Term, Index })
                    .Where(x => !(x.Term.ASTKind == Z3_ast_kind.Z3_APP_AST &&
                        x.Term.FuncDecl.DeclKind == Z3_decl_kind.Z3_OP_DT_ACCESSOR &&
                        ((DatatypeSort)x.Term.FuncDecl.Domain[0]).Accessors[0].IndexOf(x.Term.FuncDecl) == x.Index)); // Filter out no-ops

                var subsyntaxes = changedFields.Select(x => new
                {
                    GetSyntax = (Func<ExpressionSyntax>)(() => NormalizeBitvecArgs(GenerateConcreteExpression(ctx, x.Term, variables, source, addMember, datatypeSyntaxes, knownFunctions, cacheSubexpression, cachedSubexpressions), x.Term, false)),
                    Term = x.Term,
                    Index = x.Index
                }).ToList();

                var commits = new List<StatementSyntax>();
                while (subsyntaxes.Count > 0)
                {
                    var x = subsyntaxes[subsyntaxes.Count - 1];
                    subsyntaxes.RemoveAt(subsyntaxes.Count - 1);

                    ExpressionSyntax fieldSyntax = x.GetSyntax();

                    var projection = ctx.MkApp(range.Accessors[0][x.Index], stb.RegVar);
                    if (subsyntaxes.Any(y => y.Term.Contains(projection)))
                    {
                        // Do update through temporary if any other update depends on this field;
                        yield return SF.LocalDeclarationStatement(SF.VariableDeclaration(GetTypeForSort(x.Term.Sort, source, addMember, datatypeSyntaxes),
                                SF.SingletonSeparatedList(SF.VariableDeclarator("t" + x.Index)
                            .WithInitializer(SF.EqualsValueClause(fieldSyntax)))));
                        commits.Add(SF.ExpressionStatement(SF.AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
                            registerIdentifier.Dot("_" + x.Index), SF.IdentifierName("t" + x.Index))));
                    }
                    else
                    {
                        yield return SF.ExpressionStatement(SF.AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
                            registerIdentifier.Dot("_" + x.Index), fieldSyntax));
                    }
                }
                foreach (var commit in commits)
                {
                    yield return commit;
                }
                yield break;
            }

            ExpressionSyntax value = GenerateConcreteExpression(ctx, term, variables, source, addMember, datatypeSyntaxes, knownFunctions, cacheSubexpression, cachedSubexpressions);
            if (term is BitVecExpr)
            {
                value = SF.CastExpression(SF.PredefinedType(SF.Token(GetSufficientIntTypeKeyword(false, ((BitVecExpr)term).SortSize))), value.Parenthesize());
            }
            yield return SF.ExpressionStatement(SF.AssignmentExpression(SyntaxKind.SimpleAssignmentExpression, registerIdentifier, value));
        }

        ExpressionSyntax GenerateConcreteExpression(Context ctx, Expr term, Dictionary<Expr, ExpressionSyntax> variables, TransducerCompilation source, Action<MemberDeclarationSyntax> addMember, Dictionary<Sort, TypeSyntax> datatypeSyntaxes,
            Dictionary<FuncDecl, SyntaxToken> knownFunctions, Func<Expr, ExpressionSyntax, ExpressionSyntax> cacheSubexpression, Dictionary<Expr, ExpressionSyntax> cachedSubexpressions)
        {
            return DoGenerateConcreteExpression(term.SafeSimplify(ctx), variables, source, addMember, datatypeSyntaxes, knownFunctions, cacheSubexpression, cachedSubexpressions);
        }

        ExpressionSyntax DoGenerateConcreteExpression(Expr term, Dictionary<Expr, ExpressionSyntax> variables, TransducerCompilation source, Action<MemberDeclarationSyntax> addMember, Dictionary<Sort, TypeSyntax> datatypeSyntaxes,
            Dictionary<FuncDecl, SyntaxToken> knownFunctions, Func<Expr, ExpressionSyntax, ExpressionSyntax> cacheSubexpression, Dictionary<Expr, ExpressionSyntax> cachedSubexpressions)
        {
            ExpressionSyntax variableSyntax;
            if (variables.TryGetValue(term, out variableSyntax))
            {
                return variableSyntax;
            }

            ExpressionSyntax cacheVar;
            if (cachedSubexpressions.TryGetValue(term, out cacheVar))
            {
                return cacheVar;
            }
            Func<ExpressionSyntax, ExpressionSyntax> doCache = x => cacheSubexpression(term, x);

            switch (term.ASTKind)
            {
                case Z3_ast_kind.Z3_NUMERAL_AST:
                    #region Numeric literals
                    var bitVec = term as BitVecNum;
                    if (bitVec != null)
                    {
                        ExpressionSyntax valueExpr = null;
                        if (bitVec.SortSize <= 32)
                        {
                            valueExpr = SF.LiteralExpression(SyntaxKind.NumericLiteralExpression, SF.Literal(bitVec.UInt));
                        }
                        else if (bitVec.SortSize <= 64)
                        {
                            valueExpr = SF.LiteralExpression(SyntaxKind.NumericLiteralExpression, SF.Literal(bitVec.UInt64));
                        }
                        else
                        {
                            throw new CodeGenerationException("Bitvector literals of over 64 bits are not supported");
                        }
                        var resultType = SF.PredefinedType(SF.Token(GetSufficientIntTypeKeyword(false, bitVec.SortSize)));
                        return SF.CastExpression(resultType, valueExpr);
                    }
                    var intNum = term as IntNum;
                    if (intNum != null)
                    {
                        return SF.LiteralExpression(SyntaxKind.NumericLiteralExpression, SF.Literal(intNum.Int));
                    }
                    #endregion
                    break;
                case Z3_ast_kind.Z3_VAR_AST:
                    throw new CodeGenerationException("Variable not found for " + term); // Should have been found at the beginning of this function
                case Z3_ast_kind.Z3_APP_AST:
                    var decl = term.FuncDecl;
                    var generated = Array.ConvertAll(term.Args, x => new
                    {
                        Term = x,
                        Syntax = DoGenerateConcreteExpression(x, variables, source, addMember, datatypeSyntaxes, knownFunctions, cacheSubexpression, cachedSubexpressions)
                    });
                    var args = Array.ConvertAll(generated, x => NormalizeBitvecArgs(x.Syntax, x.Term, false));
                    var maskedArgs = Array.ConvertAll(generated, x => NormalizeBitvecArgs(x.Syntax, x.Term, true));

                    var kind = decl.DeclKind;
                    // Fix up some uninterpreted functions introduced by Z3
                    if (kind == Z3_decl_kind.Z3_OP_UNINTERPRETED)
                    {
                        SyntaxToken nameSyntax;
                        if (knownFunctions.TryGetValue(decl, out nameSyntax))
                        {
                            return doCache(SF.InvocationExpression(SF.IdentifierName(nameSyntax), SF.ArgumentList(SF.SeparatedList(maskedArgs.Select(x => SF.Argument(x))))));
                        }

                        var name = decl.Name.ToString();
                        if (name == "bvsdiv_i")
                        {
                            kind = Z3_decl_kind.Z3_OP_BSDIV;
                        }
                        else if (name == "bvudiv_i")
                        {
                            kind = Z3_decl_kind.Z3_OP_BUDIV;
                        }
                        else if (name == "bvsrem_i")
                        {
                            kind = Z3_decl_kind.Z3_OP_BSREM;
                        }
                        else if (name == "bvurem_i")
                        {
                            kind = Z3_decl_kind.Z3_OP_BUREM;
                        }
                        else if (name == "bvsmod_i")
                        {
                            kind = Z3_decl_kind.Z3_OP_BSMOD;
                        }
                    }

                    // HUGE UGLY HACK INCOMING
                    switch(kind)
                    {
                        case Z3_decl_kind.Z3_OP_BSDIV0:
                        case Z3_decl_kind.Z3_OP_BSMOD0:
                        case Z3_decl_kind.Z3_OP_BSREM0:
                        case Z3_decl_kind.Z3_OP_BUDIV0:
                        case Z3_decl_kind.Z3_OP_BUREM0:
                            return args[0];
                    }

                    if (kind == Z3_decl_kind.Z3_OP_NOT)
                    {
                        return doCache(SF.PrefixUnaryExpression(SyntaxKind.LogicalNotExpression, args[0]));
                    }
                    if (kind == Z3_decl_kind.Z3_OP_AND || kind == Z3_decl_kind.Z3_OP_OR)
                    {
                        if (args.Length == 0)
                        {
                            return doCache((decl.DeclKind == Z3_decl_kind.Z3_OP_AND ? _trueSyntax : _falseSyntax));
                        }
                        else if (args.Length == 1)
                        {
                            return doCache(args[0]);
                        }
                        else
                        {
                            return doCache(args.Aggregate((lhs, rhs) => SF.BinaryExpression(GetBinaryExpressionKind(decl.DeclKind), lhs, rhs).Parenthesize()));
                        }
                    }
                    if (IsShift(kind))
                    {
                        if (args.Length < 2)
                        {
                            throw new CodeGenerationException("Binary operator with less than two operands encountered");
                        }
                        var argument = maskedArgs[0];
                        if (BitsDependOnlyOnLowerBits(kind))
                        {
                            argument = args[0];
                        }
                        if (kind == Z3_decl_kind.Z3_OP_BASHR)
                        {
                            var bvArg = term.Args[0] as BitVecExpr;
                            var signedType = SF.PredefinedType(SF.Token(GetIntTypeKeyword(true, bvArg.SortSize)));
                            argument = SF.CastExpression(signedType, argument).Parenthesize();
                        }
                        ExpressionSyntax result = SF.BinaryExpression(GetBinaryExpressionKind(kind), argument,
                            SF.CastExpression(SF.PredefinedType(SF.Token(SyntaxKind.IntKeyword)), maskedArgs[1])).Parenthesize();
                        var bvTerm = term as BitVecExpr;
                        var unsignedType = SF.PredefinedType(SF.Token(GetIntTypeKeyword(false, bvTerm.SortSize)));
                        result = SF.CastExpression(unsignedType, result).Parenthesize();
                        return doCache(result);
                    }
                    if (IsPrefixUnaryOperator(kind))
                    {
                        var subsyntaxes = maskedArgs;
                        if (BitsDependOnlyOnLowerBits(kind))
                        {
                            subsyntaxes = args;
                        }
                        if (subsyntaxes.Length != 1)
                        {
                            throw new CodeGenerationException("Unary operator with other than one operand encountered");
                        }
                        ExpressionSyntax argument = maskedArgs[0];
                        if (BitsDependOnlyOnLowerBits(kind))
                        {
                            argument = args[0];
                        }
                        if (IsSignedPrefixUnaryOperator(kind) && term is BitVecExpr)
                        {
                            var bvSubterm = term.Args[0] as BitVecExpr;
                            var signedType = SF.PredefinedType(SF.Token(GetIntTypeKeyword(true, bvSubterm.SortSize)));
                            argument = SF.CastExpression(signedType, argument);
                        }
                        ExpressionSyntax result = SF.PrefixUnaryExpression(GetPrefixUnaryExpressionKind(kind), argument);
                        if (term is BitVecExpr)
                        {
                            var bvTerm = term as BitVecExpr;
                            var unsignedType = SF.PredefinedType(SF.Token(GetIntTypeKeyword(false, bvTerm.SortSize)));
                            result = SF.CastExpression(unsignedType, result).Parenthesize();
                        }
                        return doCache(result);
                    }
                    if (IsBinaryOperator(kind))
                    {
                        var subsyntaxes = maskedArgs;
                        if (BitsDependOnlyOnLowerBits(kind))
                        {
                            subsyntaxes = args;
                        }
                        if (subsyntaxes.Length < 2)
                        {
                            throw new CodeGenerationException("Binary operator with less than two operands encountered");
                        }
                        if (IsSignedBinaryOperator(kind))
                        {
                            subsyntaxes = subsyntaxes.Zip(term.Args, (Syntax, Term) => new { Syntax, Term })
                                .Select(x =>
                                {
                                    // WARNING: to support bitvector widths for which there is no direct C# equivalent here we need to do sign extension instead of
                                    // simple casting. We should also check that the C# operations performed on wider types and then truncated after correspond to
                                    // Z3 semantics.

                                    var bvSubterm = x.Term as BitVecExpr;
                                    var signedType = SF.PredefinedType(SF.Token(GetIntTypeKeyword(true, bvSubterm.SortSize)));
                                    return SF.CastExpression(signedType, x.Syntax);
                                }).ToArray();
                        }
                        var result = subsyntaxes.Aggregate((lhs, rhs) => SF.BinaryExpression(GetBinaryExpressionKind(kind), lhs, rhs).Parenthesize());
                        if (term.IsBV)
                        {
                            var bvTerm = term as BitVecExpr;
                            var unsignedType = SF.PredefinedType(SF.Token(GetSufficientIntTypeKeyword(false, bvTerm.SortSize)));
                            result = SF.CastExpression(unsignedType, result).Parenthesize();
                        }
                        return doCache(result);
                    }
                    if (kind == Z3_decl_kind.Z3_OP_ITE)
                    {
                        return doCache(SF.ConditionalExpression(args[0], args[1], args[2]).Parenthesize());
                    }
                    if (kind == Z3_decl_kind.Z3_OP_CONCAT)
                    {
                        var bvTerm = term as BitVecExpr;
                        var resultType = SF.PredefinedType(SF.Token(GetSufficientIntTypeKeyword(false, bvTerm.SortSize)));
                        var seed = SF.CastExpression(resultType, args[0]);
                        var zipped = term.Args.Zip(maskedArgs, (t, s) => new { Term = (BitVecExpr)t, Syntax = SF.CastExpression(resultType, s) });
                        return doCache(zipped.Skip(1).Aggregate((ExpressionSyntax)zipped.First().Syntax, (x, y) =>
                        {
                            var result = (ExpressionSyntax)SF.BinaryExpression(SyntaxKind.LeftShiftExpression, x,
                                SF.LiteralExpression(SyntaxKind.NumericLiteralExpression, SF.Literal((int)y.Term.SortSize))).Parenthesize();
                            var bvNum = y.Term as BitVecNum;
                            if (bvNum == null || !bvNum.BigInteger.IsZero)
                            {
                                result = SF.BinaryExpression(SyntaxKind.BitwiseOrExpression, result, y.Syntax);
                            }
                            return result;
                        }));
                    }
                    if (kind == Z3_decl_kind.Z3_OP_ZERO_EXT || kind == Z3_decl_kind.Z3_OP_SIGN_EXT)
                    {
                        bool signed = kind == Z3_decl_kind.Z3_OP_SIGN_EXT;
                        if (term.NumArgs == 1 && decl.NumParameters == 1)
                        {
                            var operandSyntax = args[0]; // The high bits do matter, but the masking is specialized for extensions

                            var bvTerm = term as BitVecExpr;
                            var operandExpr = term.Args[0] as BitVecExpr;
                            if (bvTerm != null && operandExpr != null)
                            {
                                var operandTypeSize = GetSufficientIntTypeSize(operandExpr.SortSize);
                                var operandType = SF.PredefinedType(SF.Token(GetIntTypeKeyword(signed, operandTypeSize)));

                                ulong zeroExtensionMask = 0;
                                for (uint i = 0; i < operandExpr.SortSize; ++i)
                                {
                                    zeroExtensionMask = (zeroExtensionMask << 1) | 1;
                                }
                                var zeroMasked = SF.BinaryExpression(SyntaxKind.BitwiseAndExpression, operandSyntax,
                                    SF.LiteralExpression(SyntaxKind.NumericLiteralExpression, SF.Literal(zeroExtensionMask))).Parenthesize();

                                bool cache = false;
                                if (signed)
                                {
                                    if (operandTypeSize > operandExpr.SortSize)
                                    {
                                        ulong signExtensionMask = 0;
                                        for (uint i = operandExpr.SortSize; i < operandTypeSize; ++i)
                                        {
                                            signExtensionMask = (signExtensionMask << 1) | 1;
                                        }
                                        for (int i = 0; i < operandExpr.SortSize; ++i)
                                        {
                                            signExtensionMask = (signExtensionMask << 1);
                                        }

                                        ulong signBitMask = 1UL << ((int)operandExpr.SortSize - 1);

                                        // Simulate sign extension to the actual operand type size
                                        operandSyntax = SF.ConditionalExpression(
                                            SF.BinaryExpression(SyntaxKind.EqualsExpression,
                                                SF.BinaryExpression(SyntaxKind.BitwiseAndExpression,
                                                    operandSyntax,
                                                    SF.LiteralExpression(SyntaxKind.NumericLiteralExpression, SF.Literal(signBitMask))),
                                                SF.LiteralExpression(SyntaxKind.NumericLiteralExpression, SF.Literal(0))),
                                            SF.BinaryExpression(SyntaxKind.BitwiseOrExpression,
                                                operandSyntax,
                                                SF.LiteralExpression(SyntaxKind.NumericLiteralExpression, SF.Literal(signExtensionMask))),
                                            zeroMasked).Parenthesize();
                                        cache = true;
                                    }

                                    // Cast to the signed type to get the sign extension for the next cast
                                    operandSyntax = SF.CastExpression(operandType, operandSyntax).Parenthesize();
                                }
                                else
                                {
                                    if (operandTypeSize > operandExpr.SortSize)
                                    {
                                        operandSyntax = zeroMasked;
                                        cache = true;
                                    }
                                }

                                var resultType = SF.PredefinedType(SF.Token(GetSufficientIntTypeKeyword(false, bvTerm.SortSize)));
                                ExpressionSyntax result = SF.CastExpression(resultType, operandSyntax).Parenthesize();
                                if (cache)
                                {
                                    result = doCache(result);
                                }
                                return result;
                            }
                        }
                    }
                    if (kind == Z3_decl_kind.Z3_OP_EXTRACT)
                    {
                        if (term.NumArgs == 1 && decl.NumParameters == 2)
                        {
                            int high = decl.Parameters[0].Int;
                            int low = decl.Parameters[1].Int;

                            ulong mask = 0;
                            for (int i = low; i <= high; ++i)
                            {
                                mask = (mask << 1) | 1;
                            }

                            var bvTerm = term as BitVecExpr;
                            var operand = term.Args[0] as BitVecExpr;
                            if (bvTerm != null && operand != null)
                            {
                                ExpressionSyntax result = args[0];
                                bool cache = false;
                                if (low > 0)
                                {
                                    result = SF.BinaryExpression(SyntaxKind.RightShiftExpression, result,
                                        SF.LiteralExpression(SyntaxKind.NumericLiteralExpression, SF.Literal(low))).Parenthesize();
                                    cache = true;
                                }
                                if (high - low < bvTerm.SortSize)
                                {
                                    // The following isn't actually necessary. All other code generation has to not rely on high bits being zero.
                                    //result = SF.BinaryExpression(SyntaxKind.BitwiseAndExpression, result, SF.LiteralExpression(SyntaxKind.NumericLiteralExpression, SF.Literal(mask)));
                                    //cache = true;
                                }
                                var resultType = SF.PredefinedType(SF.Token(GetSufficientIntTypeKeyword(false, bvTerm.SortSize)));
                                result = SF.CastExpression(resultType, result).Parenthesize();
                                if (cache)
                                {
                                    result = doCache(result);
                                }
                                return result;
                            }
                        }
                    }
                    if (kind == Z3_decl_kind.Z3_OP_DT_CONSTRUCTOR)
                    {
                        var datatypeSort = (DatatypeSort)decl.Range;
                        if (datatypeSort.NumConstructors == 1)
                        {
                            return doCache(SF.ObjectCreationExpression(GetTypeForSort(datatypeSort, source, addMember, datatypeSyntaxes))
                                .WithArgumentList(SF.ArgumentList(SF.SeparatedList(args.Select(x => SF.Argument(x))))));
                        }
                    }
                    if (kind == Z3_decl_kind.Z3_OP_DT_ACCESSOR)
                    {
                        var domain = ((DatatypeSort)decl.Domain[0]);
                        if (domain.NumConstructors == 1)
                        {
                            var fieldIndex = domain.Accessors[0].IndexOf(decl);
                            if (fieldIndex < 0)
                            {
                                throw new CodeGenerationException("No field index found for " + decl);
                            }
                            return args[0].Dot(SF.IdentifierName("_" + fieldIndex));
                        }
                    }
                    if (kind == Z3_decl_kind.Z3_OP_FALSE)
                    {
                        return _falseSyntax;
                    }
                    if (kind == Z3_decl_kind.Z3_OP_TRUE)
                    {
                        return _trueSyntax;
                    }
                    break;
            }

            throw new CodeGenerationException("Unsupported term encountered: " + term);
        }


        int GetProjectionIndex(FuncDecl decl)
        {
            var parameters = decl.Domain;
            if (parameters.Length == 1)
            {
                var domain = parameters[0] as DatatypeSort;
                if (domain != null)
                {
                    foreach (var accessors in domain.Accessors)
                    {
                        var index = domain.Accessors[0].IndexOf(decl);
                        if (index >= 0)
                        {
                            return index;
                        }
                    }
                    throw new CodeGenerationException("Accessor not found in the accessors of its domain?!");
                }
            }
            throw new CodeGenerationException("Unsupported projection: " + decl);
        }

        ExpressionSyntax NormalizeBitvecArgs(ExpressionSyntax syntax, Expr term, bool maskHighBits)
        {
            if (term.Sort.SortKind == Z3_sort_kind.Z3_BV_SORT)
            {
                ExpressionSyntax masked = syntax;
                var size = ((BitVecSort)term.Sort).Size;
                if (maskHighBits)
                {
                    long mask = 0;
                    for (int i = 0; i < size; ++i)
                    {
                        mask = (mask << 1) | 1;
                    }
                    masked = SF.BinaryExpression(SyntaxKind.BitwiseAndExpression, syntax,
                        SF.LiteralExpression(SyntaxKind.NumericLiteralExpression, SF.Literal(mask)));
                }
                if (size < 8)
                {
                    size = 8;
                    syntax = masked;
                }
                else if (8 < size && size < 16)
                {
                    size = 16;
                    syntax = masked;
                }
                else if (16 < size && size < 32)
                {
                    size = 32;
                    syntax = masked;
                }
                else if (32 < size && size < 64)
                {
                    size = 64;
                    syntax = masked;
                }
                var targetType = SF.PredefinedType(SF.Token(GetIntTypeKeyword(false, size)));
                syntax = SF.CastExpression(targetType, syntax.Parenthesize());
            }
            return syntax.Parenthesize();
        }

        long GetSufficientIntTypeSize(long size)
        {
            if (size < 8)
            {
                size = 8;
            }
            else if (8 < size && size < 16)
            {
                size = 16;
            }
            else if (16 < size && size < 32)
            {
                size = 32;
            }
            else if (32 < size && size < 64)
            {
                size = 64;
            }
            return size;
        }

        SyntaxKind GetSufficientIntTypeKeyword(bool isSigned, long size)
        {
            size = GetSufficientIntTypeSize(size);
            return GetIntTypeKeyword(isSigned, size);
        }

        SyntaxKind GetIntTypeKeyword(bool isSigned, long size)
        {
            switch (size)
            {
                case 8:
                    return isSigned ? SyntaxKind.SByteKeyword : SyntaxKind.ByteKeyword;
                case 16:
                    return isSigned ? SyntaxKind.ShortKeyword : SyntaxKind.UShortKeyword;
                case 32:
                    return isSigned ? SyntaxKind.IntKeyword : SyntaxKind.UIntKeyword;
                case 64:
                    return isSigned ? SyntaxKind.LongKeyword : SyntaxKind.ULongKeyword;
                default:
                    throw new CodeGenerationException("Unsupported bitvector size: " + size);
            }
        }

        SyntaxKind GetPrefixUnaryExpressionKind(Z3_decl_kind declKind)
        {
            switch (declKind)
            {
                case Z3_decl_kind.Z3_OP_BNEG:
                    return SyntaxKind.UnaryMinusExpression;
                case Z3_decl_kind.Z3_OP_BNOT:
                    return SyntaxKind.BitwiseNotExpression;
            }
            throw new CodeGenerationException("Unsupported operator kind " + declKind);
        }


        SyntaxKind GetBinaryExpressionKind(Z3_decl_kind declKind)
        {
            switch (declKind)
            {
                case Z3_decl_kind.Z3_OP_OR:
                    return SyntaxKind.LogicalOrExpression;
                case Z3_decl_kind.Z3_OP_AND:
                    return SyntaxKind.LogicalAndExpression;
                case Z3_decl_kind.Z3_OP_GT:
                case Z3_decl_kind.Z3_OP_SGT:
                case Z3_decl_kind.Z3_OP_UGT:
                    return SyntaxKind.GreaterThanExpression;
                case Z3_decl_kind.Z3_OP_LT:
                case Z3_decl_kind.Z3_OP_SLT:
                case Z3_decl_kind.Z3_OP_ULT:
                    return SyntaxKind.LessThanExpression;
                case Z3_decl_kind.Z3_OP_LE:
                case Z3_decl_kind.Z3_OP_SLEQ:
                case Z3_decl_kind.Z3_OP_ULEQ:
                    return SyntaxKind.LessThanOrEqualExpression;
                case Z3_decl_kind.Z3_OP_GE:
                case Z3_decl_kind.Z3_OP_SGEQ:
                case Z3_decl_kind.Z3_OP_UGEQ:
                    return SyntaxKind.GreaterThanOrEqualExpression;
                case Z3_decl_kind.Z3_OP_EQ:
                    return SyntaxKind.EqualsExpression;
                case Z3_decl_kind.Z3_OP_ADD:
                case Z3_decl_kind.Z3_OP_BADD:
                    return SyntaxKind.AddExpression;
                case Z3_decl_kind.Z3_OP_SUB:
                case Z3_decl_kind.Z3_OP_BSUB:
                    return SyntaxKind.SubtractExpression;
                case Z3_decl_kind.Z3_OP_MUL:
                case Z3_decl_kind.Z3_OP_BMUL:
                    return SyntaxKind.MultiplyExpression;
                case Z3_decl_kind.Z3_OP_BAND:
                    return SyntaxKind.BitwiseAndExpression;
                case Z3_decl_kind.Z3_OP_BOR:
                    return SyntaxKind.BitwiseOrExpression;
                case Z3_decl_kind.Z3_OP_DIV:
                case Z3_decl_kind.Z3_OP_BSDIV:
                case Z3_decl_kind.Z3_OP_BUDIV:
                    return SyntaxKind.DivideExpression;
                case Z3_decl_kind.Z3_OP_REM:
                case Z3_decl_kind.Z3_OP_BSREM:
                case Z3_decl_kind.Z3_OP_BUREM:
                    return SyntaxKind.ModuloExpression;
                case Z3_decl_kind.Z3_OP_BLSHR:
                case Z3_decl_kind.Z3_OP_BASHR:
                    return SyntaxKind.RightShiftExpression;
                case Z3_decl_kind.Z3_OP_BSHL:
                    return SyntaxKind.LeftShiftExpression;
            }
            throw new CodeGenerationException("Unsupported operator kind " + declKind);
        }

        bool IsPrefixUnaryOperator(Z3_decl_kind declKind)
        {
            return IsSignedPrefixUnaryOperator(declKind) ||
                 declKind == Z3_decl_kind.Z3_OP_BNOT;
        }

        bool IsSignedPrefixUnaryOperator(Z3_decl_kind declKind)
        {
            return declKind == Z3_decl_kind.Z3_OP_BNEG;
        }

        bool IsBinaryOperator(Z3_decl_kind declKind)
        {
            return IsUnsignedOrAgnosticBinaryOperator(declKind) || IsSignedBinaryOperator(declKind);
        }

        // Shifts are handled separately from other binary operators
        bool IsShift(Z3_decl_kind declKind)
        {
            return
                (declKind == Z3_decl_kind.Z3_OP_BLSHR ||
                 declKind == Z3_decl_kind.Z3_OP_BSHL ||
                 declKind == Z3_decl_kind.Z3_OP_BASHR);
        }

        bool IsUnsignedOrAgnosticBinaryOperator(Z3_decl_kind declKind)
        {
            return
                (declKind == Z3_decl_kind.Z3_OP_GT ||
                 declKind == Z3_decl_kind.Z3_OP_GE ||
                 declKind == Z3_decl_kind.Z3_OP_LE ||
                 declKind == Z3_decl_kind.Z3_OP_LT ||
                 declKind == Z3_decl_kind.Z3_OP_UGT ||
                 declKind == Z3_decl_kind.Z3_OP_UGEQ ||
                 declKind == Z3_decl_kind.Z3_OP_ULEQ ||
                 declKind == Z3_decl_kind.Z3_OP_ULT ||
                 declKind == Z3_decl_kind.Z3_OP_EQ ||
                 declKind == Z3_decl_kind.Z3_OP_ADD ||
                 declKind == Z3_decl_kind.Z3_OP_BADD ||
                 declKind == Z3_decl_kind.Z3_OP_SUB ||
                 declKind == Z3_decl_kind.Z3_OP_BSUB ||
                 declKind == Z3_decl_kind.Z3_OP_MUL ||
                 declKind == Z3_decl_kind.Z3_OP_BMUL ||
                 declKind == Z3_decl_kind.Z3_OP_BAND ||
                 declKind == Z3_decl_kind.Z3_OP_BOR ||
                 declKind == Z3_decl_kind.Z3_OP_DIV ||
                 declKind == Z3_decl_kind.Z3_OP_BUDIV ||
                 declKind == Z3_decl_kind.Z3_OP_REM ||
                 declKind == Z3_decl_kind.Z3_OP_BUREM);
        }

        bool IsSignedBinaryOperator(Z3_decl_kind declKind)
        {
            return
                (declKind == Z3_decl_kind.Z3_OP_SGT ||
                 declKind == Z3_decl_kind.Z3_OP_SGEQ ||
                 declKind == Z3_decl_kind.Z3_OP_SLEQ ||
                 declKind == Z3_decl_kind.Z3_OP_SLT ||
                 declKind == Z3_decl_kind.Z3_OP_BSDIV ||
                 declKind == Z3_decl_kind.Z3_OP_BSREM ||
                 declKind == Z3_decl_kind.Z3_OP_BASHR);
        }

        bool BitsDependOnlyOnLowerBits(Z3_decl_kind declKind)
        {
            return
                (declKind == Z3_decl_kind.Z3_OP_BAND ||
                 declKind == Z3_decl_kind.Z3_OP_BOR ||
                 declKind == Z3_decl_kind.Z3_OP_BSUB ||
                 declKind == Z3_decl_kind.Z3_OP_BADD ||
                 declKind == Z3_decl_kind.Z3_OP_BSHL ||
                 declKind == Z3_decl_kind.Z3_OP_BNOT ||
                 declKind == Z3_decl_kind.Z3_OP_BNEG);
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

        int DTStructIndex = 0;
        TypeSyntax GetTypeForSort(Sort sort, TransducerCompilation source, Action<MemberDeclarationSyntax> addMember, Dictionary<Sort, TypeSyntax> datatypeSyntaxes)
        {
            switch (sort.SortKind)
            {
                case Z3_sort_kind.Z3_DATATYPE_SORT:
                    // Ugly code follows because TupleSort is not a DatatypeSort (although we handle both uniformly here)

                    uint numConstructors = 1;
                    var datatypeSort = sort as DatatypeSort;
                    if (datatypeSort != null)
                    {
                        numConstructors = datatypeSort.NumConstructors;
                    }

                    if (numConstructors == 1)
                    {
                        FuncDecl constructor;
                        if (sort is DatatypeSort)
                        {
                            constructor = datatypeSort.Constructors[0];
                        }
                        else
                        {
                            constructor = ((TupleSort)sort).MkDecl;
                        }
                        if (constructor.DomainSize == 0)
                        {
                            return SH.PredefinedType(SyntaxKind.ObjectKeyword);
                        }
                        FuncDecl[] accessors;
                        if (sort is DatatypeSort)
                        {
                            accessors = datatypeSort.Accessors[0];
                        }
                        else
                        {
                            accessors = ((TupleSort)sort).FieldDecls;
                        }
                        TypeSyntax result;
                        if (!datatypeSyntaxes.TryGetValue(sort, out result))
                        {
                            var fieldTypes = accessors.Select(a => GetTypeForSort(a.Range, source, addMember, datatypeSyntaxes));
                            var fieldDeclarations = fieldTypes.Select((x, i) => (MemberDeclarationSyntax)SF.FieldDeclaration(SF.VariableDeclaration(x,
                                SF.SingletonSeparatedList(SF.VariableDeclarator("_" + i))))
                                .WithModifiers(SF.TokenList(SF.Token(SyntaxKind.PublicKeyword))));
                            var datatypeStruct = SF.StructDeclaration(CodeGenerator.CreateName(source.DeclarationType, "DTStruct" + DTStructIndex++))
                                .WithMembers(SF.List(fieldDeclarations));
                            datatypeStruct = datatypeStruct.AddMembers(SF.ConstructorDeclaration(datatypeStruct.Identifier)
                                .WithModifiers(SF.TokenList(SF.Token(SyntaxKind.PublicKeyword)))
                                .WithParameterList(SF.ParameterList(SF.SeparatedList(fieldTypes.Select((x, i) => SF.Parameter(SF.Identifier("v" + i)).WithType(x)))))
                                .WithBody(SF.Block(fieldTypes.Select((x, i) => SF.ExpressionStatement(SF.AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
                                    SF.IdentifierName("_" + i), SF.IdentifierName("v" + i)))))));
                            addMember(datatypeStruct);
                            result = SF.IdentifierName(datatypeStruct.Identifier);
                            datatypeSyntaxes.Add(sort, result);
                        }
                        return result;
                    }
                    break;
                case Z3_sort_kind.Z3_BV_SORT:
                    var bvSort = sort as BitVecSort;
                    return GetIntType(false, bvSort.Size).CreateSyntax(); // Assume all ints are signed
                case Z3_sort_kind.Z3_INT_SORT:
                    return GetIntType(true, 32).CreateSyntax(); // TODO: this is a semantic mismatch
                case Z3_sort_kind.Z3_BOOL_SORT:
                    return _compilation.GetTypeByMetadataName(typeof(bool).FullName).CreateSyntax();
            }
            throw new CodeGenerationException("Unsupported Z3 sort: " + sort);
        }
    }
}
