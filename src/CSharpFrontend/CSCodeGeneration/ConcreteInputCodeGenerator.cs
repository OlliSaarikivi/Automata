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

    interface ConcreteInputCodeGenerator
    {
        IEnumerable<ParameterSyntax> GetParameters();
        IEnumerable<StatementSyntax> GetInitialization();
        IEnumerable<StatementSyntax> GetMoveNext(StatementSyntax finalizer);
        ExpressionSyntax GetInput();
    }

    class StreamInputCodeGenerator : ConcreteInputCodeGenerator
    {
        const int BufferSize = 16384;

        INamedTypeSymbol _stream;
        SyntaxToken inputParameter = SF.Identifier("input");
        SyntaxToken inputBuffer = SF.Identifier("iBuf");
        SyntaxToken inputIndex = SF.Identifier("iIndex");
        SyntaxToken read = SF.Identifier("read");

        public StreamInputCodeGenerator(Compilation compilation)
        {
            _stream = compilation.GetTypeByMetadataName(typeof(Stream).FullName);
        }

        public IEnumerable<ParameterSyntax> GetParameters()
        {
            return new[] { SF.Parameter(inputParameter).WithType(_stream.CreateSyntax()) };
        }

        public IEnumerable<StatementSyntax> GetInitialization()
        {
            var bufferType = SF.ArrayType(SH.PredefinedType(SyntaxKind.ByteKeyword),
                SF.SingletonList(SF.ArrayRankSpecifier(SF.SingletonSeparatedList((ExpressionSyntax)SH.Literal(BufferSize)))));
            yield return SH.LocalDeclaration(SF.IdentifierName("var"), inputBuffer,
                SF.ArrayCreationExpression(bufferType));
            yield return SH.LocalDeclaration(SH.PredefinedType(SyntaxKind.IntKeyword), inputIndex, SH.Literal(0));
            yield return SH.LocalDeclaration(SH.PredefinedType(SyntaxKind.IntKeyword), read, SH.Literal(0));
        }

        public IEnumerable<StatementSyntax> GetMoveNext(StatementSyntax finalizer)
        {
            yield return SF.IfStatement(SF.BinaryExpression(SyntaxKind.GreaterThanOrEqualExpression,
                SF.PrefixUnaryExpression(SyntaxKind.PreIncrementExpression, SF.IdentifierName(inputIndex)), SF.IdentifierName(read)), SF.Block(
                    SH.Assignment(SF.IdentifierName(read), SF.IdentifierName(inputParameter).Dot("Read").Invoke(SF.IdentifierName(inputBuffer), SH.Literal(0), SF.IdentifierName(inputBuffer).Dot("Length"))),
                    SF.IfStatement(SF.BinaryExpression(SyntaxKind.EqualsExpression, SF.IdentifierName(read), SH.Literal(0)), finalizer),
                    SH.Assignment(SF.IdentifierName(inputIndex), SH.Literal(0))
                ));
        }

        public ExpressionSyntax GetInput()
        {
            return SF.ElementAccessExpression(SF.IdentifierName(inputBuffer),
                        SF.BracketedArgumentList(SF.SingletonSeparatedList(SF.Argument(SF.IdentifierName(inputIndex)))));
        }
    }

    class ArrayInputCodeGenerator : ConcreteInputCodeGenerator
    {
        TypeSyntax _inputType;
        SyntaxToken inputParameter = SF.Identifier("input");
        SyntaxToken inputIndex = SF.Identifier("iIndex");

        public ArrayInputCodeGenerator(TypeSyntax inputType)
        {
            _inputType = inputType;
        }

        public IEnumerable<ParameterSyntax> GetParameters()
        {
            var inputArrayType = SF.ArrayType(_inputType, SF.SingletonList(SF.ArrayRankSpecifier()));
            return new[] { SF.Parameter(inputParameter).WithType(inputArrayType) };
        }

        public IEnumerable<StatementSyntax> GetInitialization()
        {
            yield return SH.LocalDeclaration(SH.PredefinedType(SyntaxKind.IntKeyword), inputIndex, SH.Literal(-1));
        }

        public IEnumerable<StatementSyntax> GetMoveNext(StatementSyntax finalizer)
        {
            yield return SF.IfStatement(SF.BinaryExpression(SyntaxKind.GreaterThanOrEqualExpression,
                    SF.PrefixUnaryExpression(SyntaxKind.PreIncrementExpression, SF.IdentifierName(inputIndex)), SF.IdentifierName(inputParameter).Dot("Length")),
                finalizer);
        }

        public ExpressionSyntax GetInput()
        {
            return SF.ElementAccessExpression(SF.IdentifierName(inputParameter),
                        SF.BracketedArgumentList(SF.SingletonSeparatedList(SF.Argument(SF.IdentifierName(inputIndex)))));
        }
    }

    class IEnumerableInputCodeGenerator : ConcreteInputCodeGenerator
    {
        TypeSyntax _inputType;
        INamedTypeSymbol _ienumerable;
        INamedTypeSymbol _ienumerator;
        SyntaxToken inputParameter = SF.Identifier("input");
        SyntaxToken enumerator = SF.Identifier("ie");

        public IEnumerableInputCodeGenerator(Compilation compilation, TypeSyntax inputType)
        {
            _inputType = inputType;
            _ienumerable = compilation.GetTypeByMetadataName(typeof(IEnumerable<>).FullName);
            _ienumerator = compilation.GetTypeByMetadataName(typeof(IEnumerator<>).FullName);
        }

        public IEnumerable<ParameterSyntax> GetParameters()
        {
            var inputEnumerableType = _ienumerable.CreateGenericSyntax(_inputType);
            return new[] { SF.Parameter(inputParameter).WithType(inputEnumerableType) };
        }


        public IEnumerable<StatementSyntax> GetInitialization()
        {
            var inputEnumeratorType = _ienumerator.CreateGenericSyntax(_inputType);
            yield return SH.LocalDeclaration(inputEnumeratorType, enumerator,
                SF.IdentifierName(inputParameter).Dot("GetEnumerator").Invoke());
        }


        public IEnumerable<StatementSyntax> GetMoveNext(StatementSyntax finalizer)
        {
            yield return SF.IfStatement(SF.PrefixUnaryExpression(SyntaxKind.LogicalNotExpression, SF.IdentifierName(enumerator).Dot("MoveNext").Invoke()), finalizer);
        }

        public ExpressionSyntax GetInput()
        {
            return SF.IdentifierName(enumerator).Dot("Current");
        }
    }

    class BitwiseInputWrapperGenerator : ConcreteInputCodeGenerator
    {
        ConcreteInputCodeGenerator _wrapped;
        SyntaxToken bitIndex = SF.Identifier("bitIndex");
        SyntaxToken cachedInput = SF.Identifier("cachedInput");

        public BitwiseInputWrapperGenerator(ConcreteInputCodeGenerator wrapped)
        {
            _wrapped = wrapped;
        }

        public IEnumerable<ParameterSyntax> GetParameters()
        {
            return _wrapped.GetParameters();
        }

        public IEnumerable<StatementSyntax> GetInitialization()
        {
            return _wrapped.GetInitialization().Concat(new[] {
                SH.LocalDeclaration(SH.PredefinedType(SyntaxKind.IntKeyword), bitIndex, SH.Literal(7)),
                SH.LocalDeclaration(SH.PredefinedType(SyntaxKind.ByteKeyword), cachedInput, SH.Literal(0))
            });
        }


        public IEnumerable<StatementSyntax> GetMoveNext(StatementSyntax finalizer)
        {
            yield return SF.IfStatement(SF.BinaryExpression(SyntaxKind.GreaterThanExpression,
                SF.PrefixUnaryExpression(SyntaxKind.PreIncrementExpression, SF.IdentifierName(bitIndex)), SH.Literal(7)),
                SF.Block(_wrapped.GetMoveNext(finalizer).Concat(new StatementSyntax[] {
                    SH.Assignment(SF.IdentifierName(cachedInput), _wrapped.GetInput()),
                    SH.Assignment(SF.IdentifierName(bitIndex), SH.Literal(0)) })),
                SF.ElseClause(SH.Assignment(SF.IdentifierName(cachedInput), SH.Literal(1), SyntaxKind.RightShiftAssignmentExpression)));
        }

        public ExpressionSyntax GetInput()
        {
            return SF.BinaryExpression(SyntaxKind.EqualsExpression,
                SF.BinaryExpression(SyntaxKind.BitwiseAndExpression,
                    SF.IdentifierName(cachedInput),
                    SH.Literal(1)).Parenthesize(),
                SH.Literal(1));
        }
    }
}
