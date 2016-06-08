using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.Automata.CSharpFrontend.CodeGeneration
{
    using SF = Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

    static class SyntaxHelpers
    {
        public static LocalDeclarationStatementSyntax LocalDeclaration(TypeSyntax type, SyntaxToken identifier, ExpressionSyntax initializer = null)
        {
            if (initializer == null)
            {
                return SF.LocalDeclarationStatement(SF.VariableDeclaration(type, SF.SingletonSeparatedList(SF.VariableDeclarator(identifier))));
            }
            else
            {
                return SF.LocalDeclarationStatement(SF.VariableDeclaration(type, SF.SingletonSeparatedList(SF.VariableDeclarator(identifier)
                    .WithInitializer(SF.EqualsValueClause(initializer)))));
            }
        }

        public static TypeSyntax PredefinedType(SyntaxKind kind)
        {
            return SF.PredefinedType(SF.Token(kind));
        }

        public static LiteralExpressionSyntax Literal(int value)
        {
            return SF.LiteralExpression(SyntaxKind.NumericLiteralExpression, SF.Literal(value));
        }

        public static ExpressionStatementSyntax Assignment(ExpressionSyntax left, ExpressionSyntax right, SyntaxKind kind = SyntaxKind.SimpleAssignmentExpression)
        {
            return SF.ExpressionStatement(SF.AssignmentExpression(kind, left, right));
        }
    }
}
