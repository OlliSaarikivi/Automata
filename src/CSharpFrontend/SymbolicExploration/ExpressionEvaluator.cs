using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Automata.CSharpFrontend.SymbolicExploration.Mutators;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.SymbolicExploration
{
    /// <summary>
    /// Visits C# expressions to return <see cref="AccessorOrMutator"/> values. Assignment is implemented in derived classes.
    /// </summary>
    abstract class ExpressionEvaluator : CSharpSyntaxVisitor<AccessorOrMutator>, IAccessorVisitor
    {
        protected Context Ctx { get { return _info.Ctx; } }
        protected TypeSymbolToSortMapper Mapper { get { return _info.Mapper; } }
        protected SemanticModel Model { get { return _info.Model; } }
        protected MethodLifter Lifter { get { return _info.Lifter; } }
        protected InvocationExplorer InvocationExplorer { get { return _info.InvocationExplorer; } }

        protected CompilationInfo _info;

        public ExpressionEvaluator(CompilationInfo info)
        {
            _info = info;
        }

        public ExpressionEvaluator(ExpressionEvaluator toClone)
        {
            _info = toClone._info;
        }

        public override AccessorOrMutator Visit(SyntaxNode node)
        {
            if (node.IsMissing)
            {
                throw new SyntaxErrorException();
            }
            return base.Visit(node);
        }

        public override AccessorOrMutator DefaultVisit(SyntaxNode node)
        {
            throw new SyntaxErrorException("Unsupported syntax: " + node);
        }

        #region Expressions
        public override AccessorOrMutator VisitBinaryExpression(BinaryExpressionSyntax node)
        {
            // C# evaluates subexpressions from left to right and so do we
            var left = Visit(node.Left);
            var right = Visit(node.Right);

            switch (node.Kind())
            {
                case SyntaxKind.AddExpression:
                case SyntaxKind.SubtractExpression:
                case SyntaxKind.MultiplyExpression:
                case SyntaxKind.DivideExpression:
                case SyntaxKind.ModuloExpression:
                case SyntaxKind.BitwiseAndExpression:
                case SyntaxKind.BitwiseOrExpression:
                case SyntaxKind.ExclusiveOrExpression:
                case SyntaxKind.EqualsExpression:
                case SyntaxKind.NotEqualsExpression:
                case SyntaxKind.GreaterThanExpression:
                case SyntaxKind.LessThanExpression:
                case SyntaxKind.GreaterThanOrEqualExpression:
                case SyntaxKind.LessThanOrEqualExpression:
                case SyntaxKind.LeftShiftExpression:
                case SyntaxKind.RightShiftExpression:
                    {
                        var methodSymbol = Model.GetSymbolInfo(node).Symbol as IMethodSymbol;
                        if (methodSymbol != null)
                        {
                            return Lifter.LiftStaticNonVoidBinaryMethod(methodSymbol)(left.GetMutator(this), right.GetMutator(this));
                        }
                        break;
                    }
                case SyntaxKind.LogicalAndExpression:
                case SyntaxKind.LogicalOrExpression:
                    // TODO: Implement short cirquiting. This should probably be done as a transformation on 
                    // the CFG which makes sure that short cirquiting operations never end up here.
                    throw new SymbolicExplorationException("Short circuiting logical operators are not supported");

            }
            throw new SyntaxErrorException("Unsupported syntax: " + node);
        }

        public override AccessorOrMutator VisitAssignmentExpression(AssignmentExpressionSyntax node)
        {
            // C# evaluates subexpressions from left to right and so do we
            var left = Visit(node.Left);
            var right = Visit(node.Right);

            switch (node.Kind())
            {
                case SyntaxKind.SimpleAssignmentExpression:
                    {
                        var leftAccessor = left as Accessor;
                        if (leftAccessor != null)
                        {
                            return leftAccessor.AcceptAssignment(this, right.GetMutator(this));
                        }
                        break;
                    }
                case SyntaxKind.AddAssignmentExpression:
                case SyntaxKind.SubtractAssignmentExpression:
                case SyntaxKind.MultiplyAssignmentExpression:
                case SyntaxKind.DivideAssignmentExpression:
                case SyntaxKind.ModuloAssignmentExpression:
                case SyntaxKind.AndAssignmentExpression:
                case SyntaxKind.OrAssignmentExpression:
                    {
                        var leftAccessor = left as Accessor;
                        if (leftAccessor != null)
                        {
                            var methodSymbol = Model.GetSymbolInfo(node).Symbol as IMethodSymbol;
                            if (methodSymbol != null)
                            {
                                // The method symbols seem to always be the same as in the non-assignment case
                                var result = Lifter.LiftStaticNonVoidBinaryMethod(methodSymbol)(left.GetMutator(this), right.GetMutator(this));
                                return leftAccessor.AcceptAssignment(this, result);
                            }
                        }
                        break;
                    }
            }
            throw new SyntaxErrorException("Unsupported syntax: " + node);
        }

        public override AccessorOrMutator VisitCastExpression(CastExpressionSyntax node)
        {
            var operand = Visit(node.Expression);

            var operandMutator = operand.GetMutator(this);
            var resultTypeSymbol = Model.GetSymbolInfo(node.Type).Symbol;
            var resultType = Mapper.GetSortMapping(resultTypeSymbol);
            return operandMutator.Cast(resultType);
        }

        public override AccessorOrMutator VisitIdentifierName(IdentifierNameSyntax node)
        {
            var symbol = Model.GetSymbolInfo(node).Symbol;
            if (symbol != null)
            {
                switch (symbol.Kind)
                {
                    case SymbolKind.Local:
                        return new LocalAccessor((ILocalSymbol)symbol);
                    case SymbolKind.Field:
                        return new FieldAccessor((IFieldSymbol)symbol);
                    case SymbolKind.Parameter:
                        return new ParameterAccessor((IParameterSymbol)symbol);
                }
            }
            throw new SyntaxErrorException("Unsupported syntax: " + node);
        }

        public override AccessorOrMutator VisitLiteralExpression(LiteralExpressionSyntax node)
        {
            var typeSymbol = Model.GetTypeInfo(node).Type;
            switch (node.Kind())
            {
                case SyntaxKind.NumericLiteralExpression:
                    var mapping = Mapper.GetSortMapping(typeSymbol);
                    var intMapping = mapping as IntSortMapping;
                    if (intMapping != null)
                    {
                        var value = node.Token.Value;
                        if (value is int)
                        {
                            return mapping.MutatorForValue(Ctx.MkBV((int)value, intMapping.Sort.Size));
                        }
                        if (value is uint)
                        {
                            return mapping.MutatorForValue(Ctx.MkBV((uint)value, intMapping.Sort.Size));
                        }
                        if (value is long)
                        {
                            return mapping.MutatorForValue(Ctx.MkBV((long)value, intMapping.Sort.Size));
                        }
                        if (value is ulong)
                        {
                            return mapping.MutatorForValue(Ctx.MkBV((ulong)value, intMapping.Sort.Size));
                        }
                    }
                    var bigIntMapping = mapping as BigIntSortMapping;
                    if (bigIntMapping != null)
                    {
                        var value = node.Token.Value;
                        if (value is int)
                        {
                            return mapping.MutatorForValue(Ctx.MkInt((int)value));
                        }
                        if (value is uint)
                        {
                            return mapping.MutatorForValue(Ctx.MkInt((uint)value));
                        }
                        if (value is long)
                        {
                            return mapping.MutatorForValue(Ctx.MkInt((long)value));
                        }
                        if (value is ulong)
                        {
                            return mapping.MutatorForValue(Ctx.MkInt((ulong)value));
                        }
                    }
                    break;
                case SyntaxKind.TrueLiteralExpression:
                    return Mapper.BoolSortMapping.MutatorForValue(Ctx.MkBool(true));
                case SyntaxKind.FalseLiteralExpression:
                    return Mapper.BoolSortMapping.MutatorForValue(Ctx.MkBool(false));
                case SyntaxKind.CharacterLiteralExpression:
                    mapping = Mapper.GetSortMapping(typeSymbol);
                    intMapping = mapping as IntSortMapping;
                    if (intMapping != null)
                    {
                        var value = node.Token.Value;
                        if (value is char)
                        {
                            return mapping.MutatorForValue(Ctx.MkBV((char)value, intMapping.Sort.Size));
                        }
                    }
                    break;
            }
            throw new SyntaxErrorException("Unsupported syntax: " + node);
        }

        public override AccessorOrMutator VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
        {
            switch (node.Kind())
            {
                case SyntaxKind.SimpleMemberAccessExpression:
                    var left = Visit(node.Expression);
                    var rightAccessor = Visit(node.Name) as Accessor;
                    if (rightAccessor != null)
                    {
                        var leftAccessor = left as Accessor;
                        if (leftAccessor != null)
                        {
                            // Chain accessors to keep them assignable
                            leftAccessor.Append(rightAccessor);
                            return leftAccessor;
                        }
                        else
                        {
                            return left.GetMutator(this).Extract(rightAccessor);
                        }
                    }
                    break;
            }
            throw new SyntaxErrorException("Unsupported syntax: " + node);
        }

        public override AccessorOrMutator VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax node)
        {
            var operand = Visit(node.Operand);
            switch (node.Kind())
            {
                case SyntaxKind.PreIncrementExpression:
                case SyntaxKind.PreDecrementExpression:
                    {
                        var accessor = operand as Accessor;
                        if (accessor != null)
                        {
                            var methodSymbol = Model.GetSymbolInfo(node).Symbol as IMethodSymbol;
                            if (methodSymbol != null)
                            {
                                var result = Lifter.LiftInstanceNonVoidNullaryMethod(methodSymbol)(accessor.GetMutator(this));
                                accessor.AcceptAssignment(this, result.Item1);
                                return result.Item2;
                            }
                        }
                        break;
                    }
                case SyntaxKind.UnaryPlusExpression:
                case SyntaxKind.UnaryMinusExpression:
                case SyntaxKind.BitwiseNotExpression:
                case SyntaxKind.LogicalNotExpression:
                    {
                        var methodSymbol = Model.GetSymbolInfo(node).Symbol as IMethodSymbol;
                        if (methodSymbol != null)
                        {
                            return Lifter.LiftStaticNonVoidUnaryMethod(methodSymbol)(operand.GetMutator(this));
                        }
                        else if (node.Operand is LiteralExpressionSyntax)
                        {
                            var literalExpr = operand.GetMutator(this).CreateUpdate();
                            if (literalExpr is BitVecExpr)
                            {
                                return operand.GetMutator(this).WithValue(Ctx.MkBVNeg((BitVecExpr)literalExpr));
                            }
                            throw new SyntaxErrorException("Unsupported literal syntax: " + node);
                        }
                        break;
                    }
            }
            throw new SyntaxErrorException("Unsupported syntax: " + node);
        }

        public override AccessorOrMutator VisitPostfixUnaryExpression(PostfixUnaryExpressionSyntax node)
        {
            var operand = Visit(node.Operand);
            switch (node.Kind())
            {
                case SyntaxKind.PostIncrementExpression:
                case SyntaxKind.PostDecrementExpression:
                    {
                        var accessor = operand as Accessor;
                        if (accessor != null)
                        {
                            var methodSymbol = Model.GetSymbolInfo(node).Symbol as IMethodSymbol;
                            if (methodSymbol != null)
                            {
                                var value = operand.GetMutator(this);
                                var result = Lifter.LiftInstanceNonVoidNullaryMethod(methodSymbol)(accessor.GetMutator(this));
                                accessor.AcceptAssignment(this, result.Item1);
                                return value; // Return the value before the assignment
                            }
                        }
                        break;
                    }
            }
            throw new SyntaxErrorException("Unsupported syntax: " + node);
        }

        public override AccessorOrMutator VisitParenthesizedExpression(ParenthesizedExpressionSyntax node)
        {
            return Visit(node.Expression);
        }
        #endregion

        public abstract Mutator WithAssignment(FieldAccessor accessor, Mutator value);

        public abstract Mutator WithAssignment(LocalAccessor accessor, Mutator value);

        public abstract Mutator WithAssignment(ParameterAccessor accessor, Mutator value);

        public abstract Mutator Extract(FieldAccessor accessor);

        public abstract Mutator Extract(LocalAccessor accessor);

        public abstract Mutator Extract(ParameterAccessor accessor);
    }
}
