using Microsoft.Automata;
using Microsoft.Automata.Z3;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.Automata.CSharpFrontend.CodeGeneration;
using Microsoft.Automata.CSharpFrontend.SpecialTransducers;
using Microsoft.Automata.CSharpFrontend.Runtime.Transducer;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Microsoft.Automata.CSharpFrontend
{
    public static class CSharpParser
    {
        private static IEnumerable<TransducerCompilation> GetCompilations(Z3Provider ctx, Compilation compilation, IEnumerable<SyntaxTree> trees)
        {
            var transducers = new Dictionary<INamedTypeSymbol, TransducerCompilation>();
            var genericTransducerBaseType = compilation.GetTypeByMetadataName(typeof(Transducer<,>).FullName);
            var composedTransducerBaseType = compilation.GetTypeByMetadataName(typeof(Composition<,>).FullName);
            var specialTransducerBaseType = compilation.GetTypeByMetadataName(typeof(SpecialTransducer).FullName);
            var charType = compilation.GetTypeByMetadataName(typeof(Int32).FullName);
            foreach (var tree in trees)
            {
                var model = compilation.GetSemanticModel(tree);
                var root = tree.GetRoot();
                // Find all transducer declarations
                foreach (var declaration in root.DescendantNodes().OfType<ClassDeclarationSyntax>())
                {
                    var declarationType = model.GetDeclaredSymbol(declaration) as INamedTypeSymbol;
                    Debug.Assert(declarationType != null, "A class declaration's symbol is not an INamedTypeSymbol?!");
                    var attributes = declaration.AttributeLists.SelectMany(x => x.Attributes);

                    TransducerCompilation transducer = null;

                    // User defined transducers
                    var transducerType = GetConstructedBase(declarationType, genericTransducerBaseType);
                    if (transducerType != null && !declarationType.IsAbstract && !transducers.ContainsKey(declarationType))
                    {
                        transducer = new TransducerSource(ctx, model, declarationType, transducerType);
                    }
                    // Compositions
                    transducerType = GetConstructedBase(declarationType, composedTransducerBaseType);
                    if (transducerType != null && !declarationType.IsAbstract && !transducers.ContainsKey(declarationType))
                    {
                        transducer = new TransducerComposition(declarationType);
                    }
                    // Special transducers
                    transducerType = GetConstructedBase(declarationType, specialTransducerBaseType);
                    if (transducerType != null && !declarationType.IsAbstract)
                    {
                        if (transducers.ContainsKey(declarationType))
                        {
                            throw new TransducerCompilationException("SpecialTransducers must have only one declaration (even though they must be partial).");
                        }
                        transducer = GetSpecialCompilation(ctx, compilation, model, declarationType, attributes);
                    }
                    // Handle the [ShowGraph()] and [SuppressCodeGeneration()] attributes
                    if (transducer != null)
                    {
                        transducer.ShowGraphStages = GetShowGraphStages(compilation, model, attributes);
                        transducer.SuppressCodeGeneration = GetSuppressCodeGeneration(compilation, model, attributes);
                        transducers.Add(declarationType, transducer);
                    }
                }
            }

            // Resolve the arguments for compositions
            foreach (var composition in transducers.Values.OfType<TransducerComposition>())
            {
                var compositionType = GetConstructedBase(composition.DeclarationType, composedTransducerBaseType);
                var innerDecl = compositionType.TypeArguments[0] as INamedTypeSymbol;
                var outerDecl = compositionType.TypeArguments[1] as INamedTypeSymbol;
                TransducerCompilation inner, outer;
                if (!transducers.TryGetValue(innerDecl, out inner) || !transducers.TryGetValue(outerDecl, out outer))
                {
                    throw new TransducerCompilationException("The " + composition.DeclarationType.Name + " composition's type parameters must be other transducers");
                }
                composition.SetOperands(inner, outer);
            }

            return transducers.Values;
        }

        public static IEnumerable<STb<FuncDecl, Expr, Sort>> FromString(Z3Provider ctx, string sourceText)
        {
            var compilation = CSharpCompilation.Create("ToSTbTemporary");

            compilation = compilation.AddReferences(MetadataReference.CreateFromFile(typeof(IEnumerable<>).Assembly.Location));
            compilation = compilation.AddReferences(MetadataReference.CreateFromFile(typeof(Transducer<,>).Assembly.Location));

            var patchedText = @"using Microsoft.Automata.CSharpFrontend.Runtime.Transducer;
using System;
using System.Collections.Generic;
" + sourceText;

            var tree = CSharpSyntaxTree.ParseText(patchedText);
            compilation = compilation.AddSyntaxTrees(new SyntaxTree[] { tree });

            var transducers = GetCompilations(ctx, compilation, new SyntaxTree[] { tree });

            return from t in transducers
                   select t.Transducer;
        }

        public static void GenerateCodeForProject(string projectFileName, string outputDirectory, IEnumerable<string> onlyTypes = null)
        {

            var workspace = MSBuildWorkspace.Create();
            var project = workspace.OpenProjectAsync(projectFileName).Result;

            foreach (var document in project.Documents)
            {
                if (document.Name.EndsWith(".g.cs"))
                {
                    project = project.RemoveDocument(document.Id);
                }
            }

            var compilation = project.GetCompilationAsync().Result;

            // All transducers share this context
            var ctx = new Z3Provider(new Context());

            var toCompile = GetCompilations(ctx, compilation, from d in project.Documents select d.GetSyntaxTreeAsync().Result);
            if (onlyTypes != null)
            {
                toCompile = from c in toCompile
                            join n in onlyTypes on c.DeclarationType.Name equals n
                            select c;
            }
            else
            {
                toCompile = from c in toCompile
                            where !c.SuppressCodeGeneration
                            select c;
            }

            var codeGenerator = new CodeGenerator(compilation);
            foreach (var source in toCompile)
            {
                // Get the STb. For compositions this may recursively trigger the generation of other STbs.
                var stb = source.Transducer;

                // Generate code for the STb

                var declType = source.DeclarationType;
                var fileName = declType.ContainingNamespace.Name + "." +
                    (declType.ContainingType == null ? "" : declType.ContainingType.Name + ".") + declType.Name + ".g.cs";
                Console.WriteLine("Generating " + fileName);

                var codeTree = codeGenerator.Generate(source);
                codeTree = codeTree.WithFilePath(Path.Combine(outputDirectory, fileName));
                using (var writer = new StreamWriter(new FileStream(codeTree.FilePath, FileMode.Create)))
                {
                    codeTree.GetText().Write(writer);
                }
            }
        }

        // Find a base class that is a concrete instantiation of the desired generic base class
        static INamedTypeSymbol GetConstructedBase(ITypeSymbol derived, INamedTypeSymbol desiredBase)
        {
            var current = derived.BaseType;
            while (current != null)
            {
                if (current.ConstructedFrom == desiredBase)
                {
                    return current;
                }
                current = current.BaseType;
            }
            return null;
        }

        // Map SpecialTransducers to specific generators by looking at their attached annotations
        static TransducerCompilation GetSpecialCompilation(Z3Provider ctx, Compilation compilation, SemanticModel model, INamedTypeSymbol declarationType, IEnumerable<AttributeSyntax> attributes)
        {
            var huffmanDecoderAttribute = compilation.GetTypeByMetadataName(typeof(HuffmanDecoder).FullName);
            var huffmanEncoderAttribute = compilation.GetTypeByMetadataName(typeof(HuffmanEncoder).FullName);
            var parsingMatcherAttribute = compilation.GetTypeByMetadataName(typeof(ParsingMatcher).FullName);
            var xPathMatcherAttribute = compilation.GetTypeByMetadataName(typeof(XPathMatcher).FullName);

            var typeAttributes = attributes.Select(Syntax => new { Syntax, CtorSymbol = model.GetSymbolInfo(Syntax).Symbol as IMethodSymbol })
                .Where(x => x.CtorSymbol != null)
                .Where(x => x.CtorSymbol.ContainingType == huffmanDecoderAttribute ||
                    x.CtorSymbol.ContainingType == huffmanEncoderAttribute ||
                    x.CtorSymbol.ContainingType == parsingMatcherAttribute ||
                    x.CtorSymbol.ContainingType == xPathMatcherAttribute);
            if (typeAttributes.Count() == 0)
            {
                throw new TransducerCompilationException("SpecialTransducer must have an attribute specifying the type");
            }
            else if (typeAttributes.Count() > 1)
            {
                throw new TransducerCompilationException("A SpecialTransducer must have only one type attribute");
            }
            var typeAttribute = typeAttributes.First();

            if (typeAttribute.CtorSymbol.ContainingType == huffmanDecoderAttribute)
            {
                return new HuffmanGeneration(ctx, compilation, declarationType, typeAttribute.Syntax, true);
            }
            else if (typeAttribute.CtorSymbol.ContainingType == huffmanEncoderAttribute)
            {
                return new HuffmanGeneration(ctx, compilation, declarationType, typeAttribute.Syntax, false);
            }
            else if (typeAttribute.CtorSymbol.ContainingType == parsingMatcherAttribute)
            {
                return new ParsingMatcherGeneration(ctx, compilation, declarationType, typeAttribute.Syntax);
            }
            else if (typeAttribute.CtorSymbol.ContainingType == xPathMatcherAttribute)
            {
                return new XPathMatcherGeneration(ctx, compilation, declarationType, typeAttribute.Syntax);
            }
            throw new NotImplementedException("Unhandled type attribute case");
        }

        static HashSet<ShowGraph.Stage> GetShowGraphStages(Compilation compilation, SemanticModel model, IEnumerable<AttributeSyntax> attributes)
        {
            var result = new HashSet<ShowGraph.Stage>();

            var showGraphAttribute = compilation.GetTypeByMetadataName(typeof(ShowGraph).FullName);

            var showGraphAttributes = attributes.Select(Syntax => new { Syntax, CtorSymbol = model.GetSymbolInfo(Syntax).Symbol as IMethodSymbol })
                .Where(x => x.CtorSymbol != null)
                .Where(x => x.CtorSymbol.ContainingType == showGraphAttribute);
            foreach (var attribute in showGraphAttributes)
            {
                var argument = attribute.Syntax.ArgumentList.Arguments.FirstOrDefault();
                if (argument != null && argument.DescendantTokens().Any(x => x.Text == "UnSimplified")) // There is probably a better way to do this check
                {
                    result.Add(ShowGraph.Stage.UnSimplified);
                }
                else
                {
                    result.Add(ShowGraph.Stage.Simplified);
                }
            }

            return result;
        }

        static bool GetSuppressCodeGeneration(Compilation compilation, SemanticModel model, IEnumerable<AttributeSyntax> attributes)
        {
            var suppressCodeGenerationAttribute = compilation.GetTypeByMetadataName(typeof(SuppressCodeGeneration).FullName);
            var suppressCodeGenerationAttributes = attributes.Select(Syntax => new { Syntax, CtorSymbol = model.GetSymbolInfo(Syntax).Symbol as IMethodSymbol })
                .Where(x => x.CtorSymbol != null)
                .Where(x => x.CtorSymbol.ContainingType == suppressCodeGenerationAttribute);
            return suppressCodeGenerationAttributes.Any();
        }
    }
}
