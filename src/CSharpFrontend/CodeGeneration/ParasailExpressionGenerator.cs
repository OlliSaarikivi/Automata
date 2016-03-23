using Microsoft.Automata.Z3;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.CodeGeneration
{
    using System.Diagnostics;
    using SF = Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

    class ParasailExpressionGenerator
    {
        public Dictionary<Expr, ExpressionSyntax> Variables { get; private set; }

        Context _ctx;
        Expr _inputVar;
        Func<FuncDecl, ExpressionSyntax[], ExpressionSyntax> _constructDatatype;
        Dictionary<Expr, Tuple<bool, ExpressionSyntax>> _staticCache;
        Func<Expr, IdentifierNameSyntax> _declareStatic;
        ExpressionSyntax _trueSyntax;
        ExpressionSyntax _falseSyntax;
        GenericNameSyntax IS;
        TypeSyntax _stateType;

        //Dictionary<FuncDecl, SimpleNameSyntax> _functions = new Dictionary<FuncDecl,SimpleNameSyntax>();
        //Dictionary<Z3_decl_kind, Tuple<FuncDecl, FuncDecl>> _registerGuardReplacements = new Dictionary<Z3_decl_kind,Tuple<FuncDecl,FuncDecl>>();

        public ParasailExpressionGenerator(Context ctx, Expr inputVar, Func<FuncDecl, ExpressionSyntax[], ExpressionSyntax> constructDatatype, TypeSyntax stateType, Dictionary<Expr, Tuple<bool, ExpressionSyntax>> staticCache, Func<Expr, IdentifierNameSyntax> declareStatic)
        {
            Variables = new Dictionary<Expr, ExpressionSyntax>();
            _ctx = ctx;
            _inputVar = inputVar;
            _constructDatatype = constructDatatype;
            _staticCache = staticCache;
            _declareStatic = declareStatic;
            _trueSyntax = SF.LiteralExpression(SyntaxKind.TrueLiteralExpression, SF.Token(SyntaxKind.TrueKeyword));
            _falseSyntax = SF.LiteralExpression(SyntaxKind.FalseLiteralExpression, SF.Token(SyntaxKind.FalseKeyword));
            IS = SF.Identifier("InstructionSet").CreateGenericSyntax(stateType);
            _stateType = stateType;
        }

        public ExpressionSyntax GenerateExpression(Expr term, Dictionary<Expr, Tuple<bool, ExpressionSyntax>> localCache, Func<Expr, IdentifierNameSyntax> declareLocal, out bool isResultComputation)
        {
            Func<Expr, ExpressionSyntax, ExpressionSyntax> doCaching = (term2, value) =>
            {
                if (!ContainsVar(term2, _inputVar))
                {
                    var variable = _declareStatic(term2);
                    return SF.AssignmentExpression(SyntaxKind.SimpleAssignmentExpression, variable,
                        SF.ConditionalExpression(SF.BinaryExpression(SyntaxKind.NotEqualsExpression, variable, SF.LiteralExpression(SyntaxKind.NullLiteralExpression)), variable, value))
                            .Parenthesize();
                }
                else
                {
                    return value;
                }
            };

            bool staticLifetime = false;
            Func<Tuple<bool, ExpressionSyntax>> create = () =>
            {
                bool isComputation = false;
                bool shouldCache = false;
                ExpressionSyntax value = null;
                switch (term.ASTKind)
                {
                    case Z3_ast_kind.Z3_NUMERAL_AST:
                        #region Numeric literals
                        var bitVec = term as BitVecNum;
                        if (bitVec != null)
                        {
                            if (bitVec.SortSize <= 32)
                            {
                                value = SF.LiteralExpression(SyntaxKind.NumericLiteralExpression, SF.Literal(bitVec.UInt));
                            }
                            else if (bitVec.SortSize <= 64)
                            {
                                value = SF.LiteralExpression(SyntaxKind.NumericLiteralExpression, SF.Literal(bitVec.UInt64));
                            }
                            else
                            {
                                throw new CodeGenerationException("Bitvector literals of over 64 bits are not supported");
                            }
                        }
                        var intNum = term as IntNum;
                        if (intNum != null)
                        {
                            value = SF.LiteralExpression(SyntaxKind.NumericLiteralExpression, SF.Literal(intNum.Int));
                        }
                        #endregion
                        break;
                    case Z3_ast_kind.Z3_VAR_AST:
                        isComputation = term != _inputVar;
                        value = Variables.GetOrCreate(term,
                            () => { throw new CodeGenerationException("Variable not found for " + term); });
                        break;
                    case Z3_ast_kind.Z3_APP_AST:
                        var decl = term.FuncDecl;
                        var subresults = Array.ConvertAll(term.Args, x =>
                        {
                            bool isSubcomputation;
                            var Subexpression = GenerateExpression(x, localCache, declareLocal, out isSubcomputation);
                            return new { Term = x, IsComputation = isSubcomputation, Subexpression, x.Sort };
                        });
                        if (subresults.All(x => !x.IsComputation) && decl.DeclKind != Z3_decl_kind.Z3_OP_UNINTERPRETED)
                        {
                            isComputation = false;
                            value = GenerateConcreteExpression(term, decl, subresults.Select(x => x.Subexpression).ToArray());
                        }
                        else
                        {
                            isComputation = true;
                            Func<ExpressionSyntax[]> subsAsComputations = () => subresults.Select(x => x.IsComputation ? x.Subexpression :
                                doCaching(x.Term, IS.Call("Constant", x.Subexpression))).ToArray();
                            var subsyntaxes = subresults.Select(x => x.Subexpression).ToArray();
                            value = GenerateComputationExpression(decl, subsyntaxes, subsAsComputations);
                        }
                        break;
                }
                if (value != null)
                {
                    value = value.Parenthesize();
                    return Tuple.Create(isComputation, value);
                }
                else
                {
                    throw new CodeGenerationException("Unsupported term encountered: " + term);
                }
            };
            Tuple<bool, ExpressionSyntax> entry;
            if (!localCache.TryGetValue(term, out entry) && !_staticCache.TryGetValue(term, out entry))
            {
                entry = create();
                if (staticLifetime)
                {
                    _staticCache[term] = entry;
                }
                else
                {
                    localCache[term] = entry;
                }
            }
            isResultComputation = entry.Item1;
            return entry.Item2;
        }

        static bool ContainsVar(Expr term, Expr var)
        {
            switch (term.ASTKind)
            {
                case Z3_ast_kind.Z3_VAR_AST:
                    return term.Equals(var);
                case Z3_ast_kind.Z3_APP_AST:
                    return term.Args.Any(x => ContainsVar(x, var));
                case Z3_ast_kind.Z3_NUMERAL_AST:
                    return false;
            }
            throw new CodeGenerationException("Unsupported term: " + term);
        }

        ExpressionSyntax GenerateConcreteExpression(Expr term, FuncDecl decl, ExpressionSyntax[] subsyntaxes)
        {
            subsyntaxes = subsyntaxes.Zip(term.Args, (s, t) =>
            {
                var bvTerm = t as BitVecExpr;
                return bvTerm != null ? EnsureUnsigned(s, bvTerm) : s;
            }).ToArray();

            var kind = decl.DeclKind;
            if (kind == Z3_decl_kind.Z3_OP_NOT)
            {
                return SF.PrefixUnaryExpression(SyntaxKind.LogicalNotExpression, subsyntaxes[0]);
            }
            if (kind == Z3_decl_kind.Z3_OP_AND || kind == Z3_decl_kind.Z3_OP_OR)
            {
                if (subsyntaxes.Length == 0)
                {
                    return (decl.DeclKind == Z3_decl_kind.Z3_OP_AND ? _trueSyntax : _falseSyntax);
                }
                else if (subsyntaxes.Length == 1)
                {
                    return subsyntaxes[0];
                }
                else
                {
                    return subsyntaxes.Aggregate((lhs, rhs) => SF.BinaryExpression(GetBinaryExpressionKind(decl.DeclKind), lhs, rhs).Parenthesize());
                }
            }
            if (IsBinaryOperator(kind))
            {
                if (subsyntaxes.Length < 2)
                {
                    throw new CodeGenerationException("Binary operator with less than two operands encountered");
                }
                if (IsSignedBinaryOperator(kind) && term is BitVecExpr)
                {
                    subsyntaxes = subsyntaxes.Zip(term.Args, (Syntax, Term) => new { Syntax, Term })
                        .Select(x =>
                        {
                            var bvTerm = x.Term as BitVecExpr;
                            var signedType = SF.PredefinedType(SF.Token(GetIntTypeKeyword(true, bvTerm.SortSize)));
                            return SF.CastExpression(signedType, x.Syntax);
                        }).ToArray();
                }
                var result = subsyntaxes.Aggregate((lhs, rhs) => SF.BinaryExpression(GetBinaryExpressionKind(kind), lhs, rhs).Parenthesize());
                if (IsSignedBinaryOperator(kind) && term is BitVecExpr)
                {
                    var bvTerm = term as BitVecExpr;
                    var unsignedType = SF.PredefinedType(SF.Token(GetIntTypeKeyword(false, bvTerm.SortSize)));
                    result = SF.CastExpression(unsignedType, result);
                }
                return result;
            }
            if (kind == Z3_decl_kind.Z3_OP_DT_CONSTRUCTOR)
            {
                return _constructDatatype(decl, subsyntaxes);
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
                    return subsyntaxes[0].Dot(SF.IdentifierName("Item" + (fieldIndex + 1)));
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
            throw new CodeGenerationException("Unsupported function encountered: " + decl);
        }

        ExpressionSyntax GenerateComputationExpression(FuncDecl decl, ExpressionSyntax[] subsyntaxes, Func<ExpressionSyntax[]> subsAsComputations)
        {
            switch (decl.DeclKind)
            {
                case Z3_decl_kind.Z3_OP_AND:
                    return IS.Call("And", subsyntaxes);
                case Z3_decl_kind.Z3_OP_OR:
                    return IS.Call("Or", subsyntaxes);
                case Z3_decl_kind.Z3_OP_ADD:
                    return IS.Call("Add", subsyntaxes);
                case Z3_decl_kind.Z3_OP_SUB:
                    return IS.Call("Sub", subsyntaxes);
                case Z3_decl_kind.Z3_OP_MUL:
                    return IS.Call("Mul", subsyntaxes);
                case Z3_decl_kind.Z3_OP_DIV:
                    return IS.Call("Div", subsyntaxes);
                case Z3_decl_kind.Z3_OP_REM:
                    return IS.Call("Rem", subsyntaxes);
                case Z3_decl_kind.Z3_OP_UMINUS:
                    return IS.Call("UnaryMinus", subsyntaxes);
                case Z3_decl_kind.Z3_OP_NOT:
                    return IS.Call("Not", subsyntaxes);
                case Z3_decl_kind.Z3_OP_EQ:
                    return IS.Call("Eq", subsyntaxes);
                case Z3_decl_kind.Z3_OP_GT:
                    return IS.Call("Gt", subsyntaxes);
                case Z3_decl_kind.Z3_OP_GE:
                    return IS.Call("Ge", subsyntaxes);
                case Z3_decl_kind.Z3_OP_LT:
                    return IS.Call("Lt", subsyntaxes);
                case Z3_decl_kind.Z3_OP_LE:
                    return IS.Call("Le", subsyntaxes);
                case Z3_decl_kind.Z3_OP_DT_ACCESSOR:
                    return IS.Call("Proj" + (GetProjectionIndex(decl) + 1), subsyntaxes);
                case Z3_decl_kind.Z3_OP_DT_CONSTRUCTOR:
                    return IS.Call("MkTuple", subsAsComputations());
                case Z3_decl_kind.Z3_OP_UNINTERPRETED:
                    return IS.Call(decl.Name.ToString(), subsAsComputations());
            }
            throw new CodeGenerationException("Unsupported function encountered: " + decl);
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

        ExpressionSyntax EnsureUnsigned(ExpressionSyntax syntax, Expr term)
        {
            var bitVecTerm = term as BitVecExpr;
            if (bitVecTerm != null)
            {
                var targetType = SF.PredefinedType(SF.Token(GetIntTypeKeyword(false, bitVecTerm.SortSize)));
                syntax = SF.CastExpression(targetType, syntax);
            }
            return syntax;
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

        bool IsBinaryOperator(Z3_decl_kind declKind)
        {
            return IsUnsignedOrAgnosticBinaryOperator(declKind) || IsSignedBinaryOperator(declKind);
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
                 declKind == Z3_decl_kind.Z3_OP_BUREM ||
                 declKind == Z3_decl_kind.Z3_OP_BLSHR ||
                 declKind == Z3_decl_kind.Z3_OP_BSHL);
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
    }
}
