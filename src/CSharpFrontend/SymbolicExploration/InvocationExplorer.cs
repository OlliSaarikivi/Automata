using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Automata.CSharpFrontend.SymbolicExploration.ControlFlow;
using Microsoft.Automata.CSharpFrontend.SymbolicExploration.Mutators;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.SymbolicExploration
{
    class InvocationExplorer
    {
        public IEnumerable<Tuple<FuncDecl, Expr, Expr[]>> FunctionBodies
        {
            get
            {
                return _functionBodies;
            }
        }

        public List<Expr> Assertions = new List<Expr>();
        
        CompilationInfo _info;
        Dictionary<MethodDeclarationSyntax, ControlFlowGraph> _methods = new Dictionary<MethodDeclarationSyntax, ControlFlowGraph>();
        Dictionary<IMethodSymbol, FuncDecl> _assertedDeclarations = new Dictionary<IMethodSymbol, FuncDecl>();
        List<Tuple<FuncDecl, Expr, Expr[]>> _functionBodies = new List<Tuple<FuncDecl, Expr, Expr[]>>();

        public InvocationExplorer(CompilationInfo info)
        {
            _info = info;
        }

        ControlFlowGraph GetCFG(MethodDeclarationSyntax method)
        {
            return _methods.GetOrCreate(method, () => new ControlFlowGraph(method.Body, _info.Model));
        }

        ControlFlowGraph GetCFG(IMethodSymbol symbol)
        {
            if (symbol.DeclaringSyntaxReferences.Length != 1)
            {
                throw new SyntaxErrorException("Could not bind invocation to a single method declaration: " + symbol.Name);
            }
            var methodDeclaration = (MethodDeclarationSyntax)symbol.DeclaringSyntaxReferences[0].GetSyntax();
            return GetCFG(methodDeclaration);
        }

        public Mutator GetPureExpr(IMethodSymbol symbol, Mutator[] arguments, Expr[] boundVars)
        {
            var cfg = GetCFG(symbol);
            Dictionary<ISymbol, Mutator> parameters = symbol.Parameters
                .Zip(arguments, (Parameter, Mutator) => new { Parameter, Mutator })
                .ToDictionary(x => (ISymbol)x.Parameter, x => x.Mutator);
            var returnType = _info.Mapper.GetSortMapping(symbol.ReturnType);
            var invocationEntryState = new PureExplorationState(_info, cfg.EntryPoint, returnType, parameters, boundVars);
            return invocationEntryState.Explore();
        }

        public FuncDecl GetAndAssertPureDecl(IMethodSymbol symbol)
        {
            FuncDecl declaration;
            if (!_assertedDeclarations.TryGetValue(symbol, out declaration))
            {
                var ctx = _info.Ctx;

                var cfg = GetCFG(symbol);
                var parameterMappings = symbol.Parameters.Select(x => _info.Mapper.GetSortMapping(x.Type));
                var parameterVars = parameterMappings.Select((x, i) => ctx.MkBound((uint)i, x.Sort)).ToArray();
                var arguments = parameterMappings.Zip(parameterVars, (a, b) => a.MutatorForValue(b));
                Dictionary<ISymbol, Mutator> parameters = symbol.Parameters
                    .Zip(arguments, (Parameter, Mutator) => new { Parameter, Mutator })
                    .ToDictionary(x => (ISymbol)x.Parameter, x => x.Mutator);
                var returnType = _info.Mapper.GetSortMapping(symbol.ReturnType);
                var invocationEntryState = new PureExplorationState(_info, cfg.EntryPoint, returnType, parameters, parameterVars);
                var explored = invocationEntryState.Explore();
                var definition = explored.CreateUpdate();

                var domain = parameterMappings.Select(x => x.Sort).ToArray();
                var range = _info.Mapper.GetSortMapping(symbol.ReturnType).Sort;
                declaration = ctx.MkFuncDecl(symbol.Name, domain, range);
                var body = ctx.MkEq(ctx.MkApp(declaration, parameterVars), definition);
                var parameterSymbols = parameterMappings.Select((x, i) => ctx.MkSymbol(i));
                var forall = ctx.MkForall(parameterVars.Select(x => x.Sort).ToArray(), parameterSymbols.ToArray(), body);
                _info.AutomataCtx.Z3S.Assert(forall);

                Assertions.Add(forall);
                _assertedDeclarations.Add(symbol, declaration);
                _functionBodies.Add(Tuple.Create(declaration, definition, parameterVars));
            }
            return declaration;
        }
    }
}
