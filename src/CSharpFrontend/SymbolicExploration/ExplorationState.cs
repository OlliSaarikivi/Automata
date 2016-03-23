using Microsoft.Automata;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Automata.CSharpFrontend.SymbolicExploration.ControlFlow;
using Microsoft.Automata.CSharpFrontend.SymbolicExploration.Mutators;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.SymbolicExploration
{
    abstract class ExplorationState<T> : ExpressionEvaluator
        where T : class
    {
        public List<BoolExpr> PathConstraint { get; private set; }

        List<BoolExpr> _pendingConstraints;
        Dictionary<ISymbol, Mutator> _locals;
        Queue<CSharpSyntaxNode> _nextNodes;
        Terminator _nextTerminator;
        Expr[] _boundVariables;

        public ExplorationState(CompilationInfo info, BasicBlock programLocation, IDictionary<ISymbol, Mutator> parameters, Expr[] boundVariables)
            : base(info)
        {
            PathConstraint = new List<BoolExpr>();
            _pendingConstraints = new List<BoolExpr>();
            _locals = new Dictionary<ISymbol, Mutator>(parameters);
            _boundVariables = boundVariables;
            SetProgramLocation(programLocation);
        }

        /// <summary>
        /// Copy constructor used for branching.
        /// </summary>
        /// <param name="toClone"></param>
        protected ExplorationState(ExplorationState<T> toClone)
            : base(toClone)
        {
            _nextNodes = new Queue<CSharpSyntaxNode>(toClone._nextNodes);
            _nextTerminator = toClone._nextTerminator;
            PathConstraint = new List<BoolExpr>(toClone.PathConstraint);
            _pendingConstraints = new List<BoolExpr>(toClone._pendingConstraints);
            _locals = new Dictionary<ISymbol, Mutator>(toClone._locals);
            _boundVariables = toClone._boundVariables;
        }

        protected abstract ExplorationState<T> CreateClone();
        protected abstract T HandleReturn();
        protected abstract T HandleReturn(AccessorOrMutator value);
        protected abstract T HandleYieldBreak();
        protected abstract T HandleBranch(BoolExpr condition, T ifTrueResult, T ifFalseResult);
        protected abstract T HandleThrow();
        protected abstract void HandleYield(AccessorOrMutator value);

        void AddBranchConstraint(BoolExpr constraint)
        {
            var simplified = (BoolExpr)constraint.SafeSimplify(Ctx);
            _pendingConstraints.Add(simplified);
        }

        public T Explore()
        {
            var solver = Ctx.MkSolver();
            return Explore(solver);
        }

        T Explore(Solver solver)
        {
            solver.Push();
            try
            {
                PathConstraint.AddRange(_pendingConstraints);
                // Subsitute uninterpreted constants for the bound variables for the purposes of solving the constraint
                solver.Assert(_pendingConstraints.Select(c => (BoolExpr)c.Substitute(_boundVariables, _boundVariables.Select((v, i) => Ctx.MkConst("#" + i, v.Sort)).ToArray())).ToArray());
                _pendingConstraints.Clear();
                solver.Push();
                try
                {
                    solver.Assert(Array.ConvertAll(InvocationExplorer.Assertions.ToArray(), x => (BoolExpr)x));
                    switch (solver.Check())
                    {
                        case Status.SATISFIABLE:
                        case Status.UNKNOWN: // Probably not good, but it is safe to keep going
                            break;
                        case Status.UNSATISFIABLE:
                            // If the new path constraint is unsatisfiable then this path is discarded.
                            return null;
                    }
                }
                finally
                {
                    solver.Pop();
                }
                    

                while (true)
                {
                    // Process all statements
                    while (_nextNodes.Count > 0)
                    {
                        Visit(_nextNodes.Dequeue());
                    }

                    // Process the terminator

                    var returnTerminator = _nextTerminator as ReturnTerminator;
                    if (returnTerminator != null)
                    {
                        if (returnTerminator.Value != null)
                        {
                            return HandleReturn(Visit(returnTerminator.Value));
                        }
                        else
                        {
                            return HandleReturn();
                        }
                    }

                    var yieldBreakTerminator = _nextTerminator as YieldBreakTerminator;
                    if (yieldBreakTerminator != null)
                    {
                        return HandleYieldBreak();
                    }

                    var jumpTerminator = _nextTerminator as JumpTerminator;
                    if (jumpTerminator != null)
                    {
                        SetProgramLocation(jumpTerminator.Target);
                        continue;
                    }

                    var branchTerminator = _nextTerminator as BranchTerminator;
                    if (branchTerminator != null)
                    {
                        var ifTrue = this;
                        var ifFalse = CreateClone();
                        ifTrue.SetProgramLocation(branchTerminator.IfTrue);
                        ifFalse.SetProgramLocation(branchTerminator.IfFalse);
                        var condition = Visit(branchTerminator.Condition).GetMutator(this).CreateUpdate() as BoolExpr;
                        if (condition == null)
                        {
                            throw new SymbolicExplorationException("A branch condition was not boolean");
                        }
                        ifTrue.AddBranchConstraint(condition);
                        ifFalse.AddBranchConstraint(Ctx.MkNot(condition));

                        // Recursively explore the branches
                        var ifTrueResult = ifTrue.Explore(solver);
                        var ifFalseResult = ifFalse.Explore(solver);

                        if (ifTrueResult == null)
                        {
                            if (ifFalseResult == null)
                            {
                                return null;
                            }
                            else
                            {
                                return ifFalseResult;
                            }
                        }
                        else
                        {
                            if (ifFalseResult == null)
                            {
                                return ifTrueResult;
                            }
                            else
                            {
                                return HandleBranch(condition, ifTrueResult, ifFalseResult);
                            }
                        }
                    }

                    var switchTerminator = _nextTerminator as SwitchTerminator;
                    if (switchTerminator != null)
                    {
                        throw new NotImplementedException();
                    }

                    var throwTerminator = _nextTerminator as ThrowTerminator;
                    if (throwTerminator != null)
                    {
                        return HandleThrow();
                    }

                    throw new NotImplementedException("Unhandled terminator");
                }
            }
            finally
            {
                solver.Pop();
            }
        }

        void SetProgramLocation(BasicBlock block)
        {
            _nextNodes = new Queue<CSharpSyntaxNode>(block.Nodes);
            _nextTerminator = block.Terminator;
        }

        #region Statements
        public override AccessorOrMutator VisitEmptyStatement(EmptyStatementSyntax node)
        {
            return null;
        }

        public override AccessorOrMutator VisitExpressionStatement(ExpressionStatementSyntax node)
        {
            Visit(node.Expression);
            return null;
        }

        public override AccessorOrMutator VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
        {
            Visit(node.Declaration);
            return null;
        }

        public override AccessorOrMutator VisitYieldStatement(YieldStatementSyntax node)
        {
            switch (node.Kind())
            {
                case SyntaxKind.YieldReturnStatement:
                    var yielded = Visit(node.Expression);
                    HandleYield(yielded);
                    break;
                case SyntaxKind.YieldBreakStatement:
                    throw new SymbolicExplorationException("YieldBreak encountered as normal statement but it should be a terminator");
                default:
                    throw new SyntaxErrorException("Unsupported syntax: " + node);
            }
            return null;
        }

        public override AccessorOrMutator VisitInvocationExpression(InvocationExpressionSyntax node)
        {
            var methodInfo = Model.GetSymbolInfo(node.Expression);
            var method = methodInfo.Symbol as IMethodSymbol;
            if (method != null)
            {
                // Keep function calls
                var arguments = node.ArgumentList.Arguments.Select(x => Visit(x.Expression).GetMutator(this).CreateUpdate()).ToArray();
                var decl = InvocationExplorer.GetAndAssertPureDecl(method);
                var valueMapping = Mapper.GetSortMapping(method.ReturnType);
                return valueMapping.MutatorForValue(decl.Apply(arguments));
                // Inline function calls
                //var arguments = node.ArgumentList.Arguments.Select(x => Visit(x.Expression).GetMutator(this)).ToArray();
                //return InvocationExplorer.GetPureExpr(method, arguments, _boundVariables);
            }
            throw new SyntaxErrorException("Unsupported syntax: " + node);
        }
        #endregion

        #region Other
        public override AccessorOrMutator VisitVariableDeclaration(VariableDeclarationSyntax node)
        {
            foreach (var declarator in node.Variables)
            {
                Visit(declarator);
            }
            return null;
        }
        public override AccessorOrMutator VisitVariableDeclarator(VariableDeclaratorSyntax node)
        {
            var localSymbol = Model.GetDeclaredSymbol(node) as ILocalSymbol;
            if (localSymbol != null)
            {
                // If there is no initialization then we do nothing. In C# local variables must be assigned before use.
                if (node.Initializer != null)
                {
                    _locals[localSymbol] = Visit(node.Initializer.Value).GetMutator(this);
                }
                return null;
            }
            throw new SyntaxErrorException("Unsupported syntax: " + node);
        }
        #endregion

        #region IAccessorVisitor
        public override Mutator WithAssignment(LocalAccessor accessor, Mutator value)
        {
            WithLocalOrParameterAssignment(accessor.Symbol, accessor.Next, value);
            return accessor.AcceptExtract(this);
        }

        public override Mutator WithAssignment(ParameterAccessor accessor, Mutator value)
        {
            WithLocalOrParameterAssignment(accessor.Symbol, accessor.Next, value);
            return accessor.AcceptExtract(this);
        }

        public void WithLocalOrParameterAssignment(ISymbol symbol, Accessor next, Mutator value)
        {
            Mutator localMutator;
            if (!_locals.TryGetValue(symbol, out localMutator))
            {
                if (next != null)
                {
                    throw new SymbolicExplorationException("Accessed uninitialized local variable");
                }
                localMutator = value;
            }
            else
            {
                localMutator = localMutator.WithAssignment(next, value);
            }
            _locals[symbol] = localMutator;
        }

        public override Mutator Extract(LocalAccessor accessor)
        {
            return ExtractLocalOrParameter(accessor.Symbol, accessor.Next);
        }

        public override Mutator Extract(ParameterAccessor accessor)
        {
            return ExtractLocalOrParameter(accessor.Symbol, accessor.Next);
        }

        Mutator ExtractLocalOrParameter(ISymbol symbol, Accessor next)
        {
            Mutator localMutator;
            if (!_locals.TryGetValue(symbol, out localMutator))
            {
                throw new SymbolicExplorationException("Accessed uninitialized local variable");
            }
            return localMutator.Extract(next);
        }
        #endregion
    }
}
