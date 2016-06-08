using Microsoft.Automata;
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
    class MainExplorationState : ExplorationState<STbRule<Expr>>
    {
        public List<Expr> Outputs { get; private set; }
        public Mutator Register { get; private set; }

        public MainExplorationState(CompilationInfo info, BasicBlock programLocation, Mutator register, IDictionary<ISymbol, Mutator> parameters, Expr[] boundVariables)
            : base(info, programLocation, parameters, boundVariables)
        {
            Outputs = new List<Expr>();
            Register = register;
        }

        public MainExplorationState(MainExplorationState toClone)
            : base(toClone)
        {
            Outputs = new List<Expr>(toClone.Outputs);
            Register = toClone.Register;
        }

        protected override ExplorationState<STbRule<Expr>> CreateClone()
        {
            return new MainExplorationState(this);
        }

        void AddOutput(Expr output)
        {
            Outputs.Add(output.SafeSimplify(Ctx));
        }

        BaseRule<Expr> CreateBaseRule()
        {
            var update = Register.CreateUpdate();
            return new BaseRule<Expr>(new Sequence<Expr>(Outputs.Select(x => x.SafeSimplify(Ctx))), update.SafeSimplify(Ctx), 0);
        }

        protected override STbRule<Expr> HandleReturn()
        {
            return CreateBaseRule();
        }

        protected override STbRule<Expr> HandleReturn(AccessorOrMutator value)
        {
            throw new NotImplementedException();
        }

        protected override STbRule<Expr> HandleYieldBreak()
        {
            return CreateBaseRule();
        }

        protected override STbRule<Expr> HandleBranch(BoolExpr condition, STbRule<Expr> ifTrueResult, STbRule<Expr> ifFalseResult)
        {
            return new IteRule<Expr>(condition, ifTrueResult, ifFalseResult);
        }

        protected override STbRule<Expr> HandleThrow()
        {
            return UndefRule<Expr>.Default;
        }

        protected override void HandleYield(AccessorOrMutator value)
        {
            AddOutput(value.GetMutator(this).CreateUpdate());
        }


        #region IAccessorVisitor
        public override Mutator WithAssignment(FieldAccessor accessor, Mutator value)
        {
            Register = Register.WithAssignment(accessor, value);
            return accessor.AcceptExtract(this);
        }

        public override Mutator Extract(FieldAccessor accessor)
        {
            return Register.Extract(accessor);
        }
        #endregion
    }
}
