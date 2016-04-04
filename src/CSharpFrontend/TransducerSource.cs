using Microsoft.Automata;
using Microsoft.Automata.Z3;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Automata.CSharpFrontend.SymbolicExploration.ControlFlow;
using Microsoft.Automata.CSharpFrontend.SymbolicExploration;
using Microsoft.Automata.CSharpFrontend.SymbolicExploration.Mutators;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Automata.CSharpFrontend.Runtime.Transducer;

namespace Microsoft.Automata.CSharpFrontend
{
    class TransducerSource : TransducerCompilation
    {
        public override STb<FuncDecl, Expr, Sort> Transducer
        {
            get
            {
                if (_transducer == null)
                {
                    _transducer = GenerateSTb();
                }
                return _transducer;
            }
        }
        STb<FuncDecl, Expr, Sort> _transducer;

        public override IEnumerable<Tuple<FuncDecl, Expr, Expr[]>> FunctionBodies
        {
            get
            {
                return _info.InvocationExplorer.FunctionBodies;
            }
        }

        public override ITypeSymbol InputTypeSymbol { get { return _transducerType.TypeArguments[0]; } }
        public override ITypeSymbol OutputTypeSymbol { get { return _transducerType.TypeArguments[1]; } }

        Context Ctx { get { return _info.Ctx; } }
        TypeSymbolToSortMapper Mapper { get { return _info.Mapper; } }
        SemanticModel Model { get { return _info.Model; } }

        CompilationInfo _info;
        INamedTypeSymbol _transducerType;

        public TransducerSource(Z3Provider automataCtx, SemanticModel model, INamedTypeSymbol declarationType, INamedTypeSymbol transducerType)
            : base(declarationType)
        {
            Contract.Requires(!transducerType.IsUnboundGenericType);
            Contract.Requires(!declarationType.IsAbstract);

            if (declarationType.IsGenericType)
            {
                throw new SyntaxErrorException("");
            }

            _transducerType = transducerType;

            _info = new CompilationInfo
            {
                AutomataCtx = automataCtx,
                Model = model,
            };
            _info.Mapper = new TypeSymbolToSortMapper(_info, new ITypeSymbol[] { DeclarationType });
            _info.Lifter = new MethodLifter(_info);
            _info.InvocationExplorer = new InvocationExplorer(_info);
        }

        STb<FuncDecl, Expr, Sort> GenerateSTb()
        {
            var name = DeclarationType.ContainingNamespace.Name + "." +
                (DeclarationType.ContainingType == null ? "" : DeclarationType.ContainingType.Name + ".") + DeclarationType.Name;
            Console.WriteLine("Exploring " + name);

            Expr inputVar = _info.AutomataCtx.MkVar(0, Mapper.GetSortMapping(_transducerType.TypeArguments[0]).Sort);
            Expr registerVar = _info.AutomataCtx.MkVar(1, Mapper.GetSortMapping(DeclarationType).Sort);
            Mutator register = Mapper.GetSortMapping(DeclarationType).MutatorForValue(registerVar);

            var methods = DeclarationType.DeclaringSyntaxReferences.Select(r => r.GetSyntax())
                .SelectMany(s => s.DescendantNodes(n => !(n is MethodDeclarationSyntax)))
                .OfType<MethodDeclarationSyntax>().Select(Syntax => new { Syntax, Symbol = Model.GetDeclaredSymbol(Syntax) as IMethodSymbol })
                .Where(x => x.Symbol != null);

            // Find the Update function
            var updateMethods = methods.Where(x => x.Symbol.MetadataName == "Update" && x.Symbol.IsOverride
                && x.Symbol.Parameters.Length == 1 && x.Symbol.Parameters[0].Type == InputTypeSymbol).ToArray();
            if (updateMethods.Length == 0)
            {
                throw new SyntaxErrorException("No IEnumerable<" + OutputTypeSymbol + "> Update(" + InputTypeSymbol + ") method declared");
            }
            else if (updateMethods.Length > 1)
            {
                throw new SyntaxErrorException("Multiple Update methods declared");
            }
            var updateMethod = updateMethods[0];
            // Explore the Update function
            var updateCfg = new ControlFlowGraph(updateMethod.Syntax.Body, Model);
            Dictionary<ISymbol, Mutator> parameters = updateMethod.Symbol.Parameters
                .ToDictionary(p => (ISymbol)p, p => Mapper.GetSortMapping(_transducerType.TypeArguments[0]).MutatorForValue(inputVar));
            var updateEntryState = new MainExplorationState(_info, updateCfg.EntryPoint, register, parameters, new[] { inputVar, registerVar });
            var updateRule = updateEntryState.Explore();

            // Find the Finish function
            var finishMethods = methods.Where(x => x.Symbol.MetadataName == "Finish" && x.Symbol.IsOverride
                && x.Symbol.Parameters.Length == 0).ToArray();
            STbRule<Expr> finishRule;
            if (finishMethods.Length == 0)
            {
                finishRule = new BaseRule<Expr>(Sequence<Expr>.Empty, register.CreateUpdate(), 0);
            }
            else
            {
                if (finishMethods.Length > 1)
                {
                    throw new SyntaxErrorException("Multiple Finish methods declared");
                }
                var finishMethod = finishMethods[0];
                // Explore the Finish function
                var finishCfg = new ControlFlowGraph(finishMethod.Syntax.Body, Model);
                var finishEntryState = new MainExplorationState(_info, finishCfg.EntryPoint, register, new Dictionary<ISymbol, Mutator>(), new[] { registerVar });
                finishRule = finishEntryState.Explore();
            }

            var outputSort = Mapper.GetSortMapping(_transducerType.TypeArguments[1]).Sort;
            var stb = new STb<FuncDecl, Expr, Sort>(_info.AutomataCtx, DeclarationType.Name, inputVar.Sort, outputSort, registerVar.Sort,
                Mapper.GetSortMapping(DeclarationType).MutatorForDefaultValue().CreateUpdate().SafeSimplify(Ctx), 0);

            stb.AssignRule(0, updateRule);
            stb.AssignFinalRule(0, finishRule);

            if (ShowGraphStages.Contains(ShowGraph.Stage.UnSimplified)) { stb.ShowGraph(); }
            stb = stb.Flatten();
            if (ShowGraphStages.Contains(ShowGraph.Stage.Simplified)) { stb.ToST().ShowGraph(); }
            return stb;
        }
    }
}
