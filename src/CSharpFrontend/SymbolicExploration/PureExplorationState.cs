using Microsoft.CodeAnalysis;
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
    class PureExplorationState : ExplorationState<Mutator>
    {
        SortMapping _returnType;

        public PureExplorationState(CompilationInfo info, BasicBlock programLocation, SortMapping returnType, IDictionary<ISymbol, Mutator> parameters, Expr[] boundVariables = null)
            : base(info, programLocation, parameters, boundVariables == null ? new Expr[0] : boundVariables)
        {
            _returnType = returnType;
        }

        public PureExplorationState(PureExplorationState toClone)
            : base(toClone)
        {
            _returnType = toClone._returnType;
        }

        protected override ExplorationState<Mutator> CreateClone()
        {
            return new PureExplorationState(this);
        }

        protected override Mutator HandleReturn()
        {
            throw new NotImplementedException();
        }

        protected override Mutator HandleReturn(AccessorOrMutator value)
        {
            return value.GetMutator(this).Cast(_returnType);
        }

        protected override Mutator HandleYieldBreak()
        {
            throw new NotImplementedException();
        }

        protected override Mutator HandleBranch(BoolExpr condition, Mutator ifTrueResult, Mutator ifFalseResult)
        {
            Expr ifTrueExpr = ifTrueResult.CreateUpdate();
            Expr ifFalseExpr = ifFalseResult.CreateUpdate();
            return ifTrueResult.WithValue(Ctx.MkITE(condition, ifTrueExpr, ifFalseExpr));
        }

        protected override Mutator HandleThrow()
        {
            throw new NotImplementedException();
        }

        protected override void HandleYield(AccessorOrMutator value)
        {
            throw new NotImplementedException();
        }

        public override Mutator WithAssignment(FieldAccessor accessor, Mutator value)
        {
            throw new NotImplementedException();
        }

        public override Mutator Extract(FieldAccessor accessor)
        {
            throw new NotImplementedException();
        }
    }
}
