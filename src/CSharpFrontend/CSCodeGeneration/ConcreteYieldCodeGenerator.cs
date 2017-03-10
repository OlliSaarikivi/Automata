using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
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

    interface ConcreteYieldCodeGenerator
    {
        TypeSyntax GetReturnType();
        IEnumerable<ParameterSyntax> GetParameters();
        IEnumerable<StatementSyntax> GetInitialization();

        IEnumerable<StatementSyntax> GetYields(IEnumerable<ExpressionSyntax> yields, int numYields);

        IEnumerable<StatementSyntax> GetFinalization();
    }

    class StreamYieldCodeGenerator : ConcreteYieldCodeGenerator
    {
        const int BufferSize = 16384;

        INamedTypeSymbol _stream;
        SyntaxToken outputParameter = SF.Identifier("output");
        SyntaxToken outputBuffer = SF.Identifier("oBuf");
        SyntaxToken outputIndex = SF.Identifier("oIndex");

        public StreamYieldCodeGenerator(Compilation compilation)
        {
            _stream = compilation.GetTypeByMetadataName(typeof(Stream).FullName);
        }

        public TypeSyntax GetReturnType()
        {
            return SF.PredefinedType(SF.Token(SyntaxKind.VoidKeyword));
        }

        public IEnumerable<ParameterSyntax> GetParameters()
        {
            return new[] { SF.Parameter(outputParameter).WithType(_stream.CreateSyntax()) };
        }

        public IEnumerable<StatementSyntax> GetInitialization()
        {
            var bufferType = SF.ArrayType(SH.PredefinedType(SyntaxKind.ByteKeyword),
                SF.SingletonList(SF.ArrayRankSpecifier(SF.SingletonSeparatedList((ExpressionSyntax)SH.Literal(BufferSize)))));
            yield return SH.LocalDeclaration(SF.IdentifierName("var"), outputBuffer,
                SF.ArrayCreationExpression(bufferType));
            yield return SH.LocalDeclaration(SH.PredefinedType(SyntaxKind.IntKeyword), outputIndex, SH.Literal(0));
        }

        public IEnumerable<StatementSyntax> GetYields(IEnumerable<ExpressionSyntax> yields, int numYields)
        {
            if (numYields == 0)
            {
                yield break;
            }
            if (numYields > BufferSize)
            {
                throw new NotImplementedException();
            }
            yield return SF.IfStatement(SF.BinaryExpression(SyntaxKind.GreaterThanExpression, SF.IdentifierName(outputIndex), SH.Literal(BufferSize - numYields)),
                SF.Block(
                    SF.ExpressionStatement(SF.IdentifierName(outputParameter).Dot("Write").Invoke(SF.IdentifierName(outputBuffer), SH.Literal(0), SF.IdentifierName(outputIndex))),
                    SH.Assignment(SF.IdentifierName(outputIndex), SH.Literal(0))));
            int index = 0;
            foreach (var yieldSyntax in yields)
            {
                yield return SH.Assignment(SF.ElementAccessExpression(SF.IdentifierName(outputBuffer), SF.BracketedArgumentList(SF.SingletonSeparatedList(SF.Argument(
                        SF.BinaryExpression(SyntaxKind.AddExpression, SF.IdentifierName(outputIndex), SH.Literal(index)))))),
                    yieldSyntax);
                ++index;
            }
            yield return SH.Assignment(SF.IdentifierName(outputIndex), SH.Literal(numYields), SyntaxKind.AddAssignmentExpression);
        }

        public IEnumerable<StatementSyntax> GetFinalization()
        {
            yield return SF.IfStatement(SF.BinaryExpression(SyntaxKind.GreaterThanExpression, SF.IdentifierName(outputIndex), SH.Literal(0)),
                                    SF.ExpressionStatement(SF.IdentifierName(outputParameter).Dot("Write").Invoke(SF.IdentifierName(outputBuffer), SH.Literal(0), SF.IdentifierName(outputIndex))));
            yield return SF.ReturnStatement();
        }
    }

    class StringYieldCodeGenerator : ConcreteYieldCodeGenerator
    {
        const int BufferSize = 16384;

        INamedTypeSymbol _stringBuilder;
        SyntaxToken output = SF.Identifier("output");
        SyntaxToken outputBuffer = SF.Identifier("oBuf");
        SyntaxToken outputIndex = SF.Identifier("oIndex");

        public StringYieldCodeGenerator(Compilation compilation)
        {
            _stringBuilder = compilation.GetTypeByMetadataName(typeof(StringBuilder).FullName);
        }

        public TypeSyntax GetReturnType()
        {
            return SF.PredefinedType(SF.Token(SyntaxKind.StringKeyword));
        }

        public IEnumerable<ParameterSyntax> GetParameters()
        {
            yield break;
        }

        public IEnumerable<StatementSyntax> GetInitialization()
        {
            yield return SH.LocalDeclaration(SF.IdentifierName("var"), output,
                SF.ObjectCreationExpression(_stringBuilder.CreateSyntax()));
            var bufferType = SF.ArrayType(SH.PredefinedType(SyntaxKind.CharKeyword),
                SF.SingletonList(SF.ArrayRankSpecifier(SF.SingletonSeparatedList((ExpressionSyntax)SH.Literal(BufferSize)))));
            yield return SH.LocalDeclaration(SF.IdentifierName("var"), outputBuffer,
                SF.ArrayCreationExpression(bufferType));
            yield return SH.LocalDeclaration(SH.PredefinedType(SyntaxKind.IntKeyword), outputIndex, SH.Literal(0));
        }

        public IEnumerable<StatementSyntax> GetYields(IEnumerable<ExpressionSyntax> yields, int numYields)
        {
            if (numYields == 0)
            {
                yield break;
            }
            if (numYields > BufferSize)
            {
                throw new NotImplementedException();
            }
            yield return SF.IfStatement(SF.BinaryExpression(SyntaxKind.GreaterThanExpression, SF.IdentifierName(outputIndex), SH.Literal(BufferSize - numYields)),
                SF.Block(
                    SF.ExpressionStatement(SF.IdentifierName(output).Dot("Append").Invoke(SF.IdentifierName(outputBuffer), SH.Literal(0), SF.IdentifierName(outputIndex))),
                    SH.Assignment(SF.IdentifierName(outputIndex), SH.Literal(0))));
            int index = 0;
            foreach (var yieldSyntax in yields)
            {
                yield return SH.Assignment(SF.ElementAccessExpression(SF.IdentifierName(outputBuffer), SF.BracketedArgumentList(SF.SingletonSeparatedList(SF.Argument(
                        SF.BinaryExpression(SyntaxKind.AddExpression, SF.IdentifierName(outputIndex), SH.Literal(index)))))),
                    yieldSyntax);
                ++index;
            }
            yield return SH.Assignment(SF.IdentifierName(outputIndex), SH.Literal(numYields), SyntaxKind.AddAssignmentExpression);
        }

        public IEnumerable<StatementSyntax> GetFinalization()
        {
            yield return SF.IfStatement(SF.BinaryExpression(SyntaxKind.GreaterThanExpression, SF.IdentifierName(outputIndex), SH.Literal(0)),
                                    SF.ExpressionStatement(SF.IdentifierName(output).Dot("Append").Invoke(SF.IdentifierName(outputBuffer), SH.Literal(0), SF.IdentifierName(outputIndex))));
            yield return SF.ReturnStatement(SF.IdentifierName(output).Dot("ToString").Invoke());
        }
    }

    class IEnumerableYieldCodeGenerator : ConcreteYieldCodeGenerator
    {
        TypeSyntax _outputType;
        INamedTypeSymbol _ienumerable;

        public IEnumerableYieldCodeGenerator(Compilation compilation, TypeSyntax outputType)
        {
            _outputType = outputType;
            _ienumerable = compilation.GetTypeByMetadataName(typeof(IEnumerable<>).FullName);
        }

        public TypeSyntax GetReturnType()
        {
            return _ienumerable.CreateGenericSyntax(_outputType);
        }

        public IEnumerable<ParameterSyntax> GetParameters()
        {
            yield break;
        }

        public IEnumerable<StatementSyntax> GetInitialization()
        {
            yield break;
        }

        public IEnumerable<StatementSyntax> GetYields(IEnumerable<ExpressionSyntax> yields, int numYields)
        {
            foreach (var value in yields)
            {
                yield return SF.YieldStatement(SyntaxKind.YieldReturnStatement, value);
            }
        }

        public IEnumerable<StatementSyntax> GetFinalization()
        {
            yield return SF.YieldStatement(SyntaxKind.YieldBreakStatement);
        }
    }
}
