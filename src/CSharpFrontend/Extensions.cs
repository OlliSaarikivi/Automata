using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Automata;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Z3;
using System.Diagnostics.Contracts;

namespace Microsoft.Automata.CSharpFrontend
{
    using SF = Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

    static class Extensions
    {
        public static V GetOrCreate<K, V>(this Dictionary<K, V> dict, K key, Func<V> creator)
        {
            V value;
            if (!dict.TryGetValue(key, out value))
            {
                value = creator();
                dict.Add(key, value);
            }
            return value;
        }

        #region syntax helpers
        public static TypeSyntax CreateSyntax(this INamedTypeSymbol symbol)
        {
            Contract.Requires(symbol.CanBeReferencedByName);
            if (symbol.IsGenericType)
            {
                return symbol.CreateGenericSyntax(symbol.TypeArguments.Select(s => (TypeSyntax)(((INamedTypeSymbol)s).CreateSyntax())).ToArray());
            }
            else
            {
                return SF.IdentifierName(SF.Identifier(symbol.Name));
            }
        }

        public static GenericNameSyntax CreateGenericSyntax(this INamedTypeSymbol symbol, params TypeSyntax[] parameters)
        {
            Contract.Requires(symbol.CanBeReferencedByName);
            return CreateGenericSyntax(SF.Identifier(symbol.Name), parameters);
        }

        public static GenericNameSyntax CreateGenericSyntax(this SyntaxToken identifier, params TypeSyntax[] parameters)
        {
            return SF.GenericName(identifier, SF.TypeArgumentList(SF.SeparatedList(parameters)));
        }

        public static MemberAccessExpressionSyntax Dot(this ExpressionSyntax expression, SimpleNameSyntax field)
        {
            return SF.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, expression, field);
        }

        public static MemberAccessExpressionSyntax Dot(this ExpressionSyntax expression, string field)
        {
            return SF.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, expression, SF.IdentifierName(field));
        }

        public static ExpressionSyntax Invoke(this ExpressionSyntax expression, params ExpressionSyntax[] arguments)
        {
            return SF.InvocationExpression(expression, SF.ArgumentList(SF.SeparatedList(
                    arguments.Select(x => SF.Argument(x)))));
        }

        public static ExpressionSyntax Call(this ExpressionSyntax expression, SimpleNameSyntax instruction, params ExpressionSyntax[] arguments)
        {
            return SF.InvocationExpression(expression.Dot(instruction), SF.ArgumentList(SF.SeparatedList(
                    arguments.Select(x => SF.Argument(x)))));
        }

        public static ExpressionSyntax Call(this ExpressionSyntax expression, SimpleNameSyntax instruction, IEnumerable<ExpressionSyntax> arguments)
        {
            return SF.InvocationExpression(expression.Dot(instruction), SF.ArgumentList(SF.SeparatedList(
                    arguments.Select(x => SF.Argument(x)))));
        }

        public static ExpressionSyntax Call(this ExpressionSyntax expression, string instruction, params ExpressionSyntax[] arguments)
        {
            return SF.InvocationExpression(expression.Dot(instruction), SF.ArgumentList(SF.SeparatedList(
                    arguments.Select(x => SF.Argument(x)))));
        }

        public static ExpressionSyntax Call(this ExpressionSyntax expression, string instruction, IEnumerable<ExpressionSyntax> arguments)
        {
            return SF.InvocationExpression(expression.Dot(instruction), SF.ArgumentList(SF.SeparatedList(
                    arguments.Select(x => SF.Argument(x)))));
        }

        public static QualifiedNameSyntax Qualified(this NameSyntax left, SimpleNameSyntax right)
        {
            return SF.QualifiedName(left, right);
        }

        public static ParenthesizedExpressionSyntax Parenthesize(this ExpressionSyntax expression)
        {
            return SF.ParenthesizedExpression(expression);
        }
        #endregion

        public static int IndexOf<T>(this T[] array, T value)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        // All calls to Expr.Simplify() should go through this.
        public static Expr SafeSimplify(this Expr expr, Context ctx)
        {
            var p = ctx.MkParams();
            p.Add("elim_sign_ext", false);
            p.Add("hi_div0", false);
            return expr.Simplify(p);
        }

        public static bool Contains(this Expr expr, Expr subexpr)
        {
            if (expr.Equals(subexpr))
            {
                return true;
            }
            switch (expr.ASTKind)
            {
                case Z3_ast_kind.Z3_VAR_AST:
                case Z3_ast_kind.Z3_NUMERAL_AST:
                    return false;
                case Z3_ast_kind.Z3_APP_AST:
                    return expr.Args.Any(x => x.Contains(subexpr));
            }
            return true;
        }

        // Flatten the register structure
        public static STb<FuncDecl, Expr, Sort> Flatten(this STb<FuncDecl, Expr, Sort> stb)
        {
            var boolDummy = new STb<FuncDecl, Expr, Sort>(stb.Solver, "BoolDummy", stb.OutputSort, stb.OutputSort, stb.Solver.BoolSort, stb.Solver.True, 0);
            boolDummy.AssignRule(0, new BaseRule<Expr>(new Sequence<Expr>(boolDummy.InputVar), boolDummy.RegVar, 0));
            boolDummy.AssignFinalRule(0, new BaseRule<Expr>(Sequence<Expr>.Empty, boolDummy.RegVar, 0));

            var composed = stb.Compose(boolDummy); // Compose with the "dummy" to ensure there is something to eliminate
            composed.Name = stb.Name;
            var explored = composed.ExploreBools(); // Explore bools will flatten when there is something to eliminate
            return explored;

            // TODO: implement in a less round about way
        }
    }
}
