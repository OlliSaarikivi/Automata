using Microsoft.Automata;
using Microsoft.Automata.Z3;
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

    class CodeGenerator
    {
        ParasailCodeGenerator _parasailCG;
        ConcreteCodeGenerator _concreteCG;

        public CodeGenerator(Compilation compilation)
        {
            _parasailCG = new ParasailCodeGenerator(compilation);
            _concreteCG = new ConcreteCodeGenerator(compilation);
        }

        public SyntaxTree Generate(TransducerCompilation source)
        {
            var stb = source.Transducer;

            var sourceNamespace = source.DeclarationType.ContainingNamespace.DeclaringSyntaxReferences[0].GetSyntax() as NamespaceDeclarationSyntax;
            if (sourceNamespace == null)
            {
                throw new CodeGenerationException("Containing namespace declaration not found for " + source.DeclarationType);
            }

            // Follow the declaration of the original (partial) class
            var classDecl = source.DeclarationType.DeclaringSyntaxReferences.Select(r => r.GetSyntax()).OfType<ClassDeclarationSyntax>().FirstOrDefault()
                .WithLeadingTrivia().WithTrailingTrivia() // Strip any trivia
                .WithMembers(SF.List<MemberDeclarationSyntax>())
                .WithAttributeLists(SF.List<AttributeListSyntax>());
            if (classDecl == null)
            {
                throw new Exception("Class declaration for " + source.DeclarationType + " not found");
            }

            //classDecl = _parasailCG.Generate(source, stb, classDecl);
            classDecl = _concreteCG.Generate(source, stb, classDecl);

            var riseNamespace = SF.IdentifierName("Microsoft").Qualified(SF.IdentifierName("Research")).Qualified(SF.IdentifierName("RiSE"));
            var root = SF.CompilationUnit()
                .WithUsings(SF.List(new[]
                {
                    SF.UsingDirective(SF.IdentifierName("System")),
                    SF.UsingDirective(SF.IdentifierName("System").Qualified(SF.IdentifierName("IO"))),
                    SF.UsingDirective(SF.IdentifierName("System").Qualified(SF.IdentifierName("Collections")).Qualified(SF.IdentifierName("Generic"))),
                    SF.UsingDirective(riseNamespace),
                    SF.UsingDirective(riseNamespace.Qualified(SF.IdentifierName("Transducer"))),
                }))
                .WithMembers(SF.SingletonList((MemberDeclarationSyntax)SF.NamespaceDeclaration(sourceNamespace.Name)
                    .WithMembers(SF.SingletonList((MemberDeclarationSyntax)classDecl))));
            var normalized = root.NormalizeWhitespace();
            return SF.SyntaxTree(normalized);
        }

        public static string CreateName(INamedTypeSymbol containing, string prefix)
        {
            int i = 0;
            string postFix = "";
            while (containing.GetMembers(prefix + postFix).Length != 0)
            {
                postFix = "_" + (++i);
            }
            return prefix + postFix;
        }
    }
}
