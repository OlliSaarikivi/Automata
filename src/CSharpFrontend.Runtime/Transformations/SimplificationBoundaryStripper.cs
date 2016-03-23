using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime
{
    public class SimplificationBoundaryStripper<Domain> : IComputationVisitor<Domain, IComputation<Domain, Domain>>
    {
        public IComputation<Domain, Domain> Visit<Range>(Constant<Domain, Range> constant)
        {
            return constant as IComputation<Domain, Domain>;
        }

        public IComputation<Domain, Domain> Visit(Identity<Domain> identity)
        {
            return identity;
        }

        public IComputation<Domain, Domain> Visit<ElementRange>(ListComputation<Domain, ElementRange> list)
        {
            return list as IComputation<Domain, Domain>;
        }

        public IComputation<Domain, Domain> Visit<ElementRange>(Append<Domain, ElementRange> append)
        {
            return append as IComputation<Domain, Domain>;
        }

        public IComputation<Domain, Domain> Visit(IntLinear<Domain> linear)
        {
            return linear as IComputation<Domain, Domain>;
        }

        public IComputation<Domain, Domain> Visit(InInterval<Domain> inInterval)
        {
            return inInterval as IComputation<Domain, Domain>;
        }

        public IComputation<Domain, Domain> Visit<Enum>(Equals<Domain, Enum> equals) where Enum : struct
        {
            return equals as IComputation<Domain, Domain>;
        }

        public IComputation<Domain, Domain> Visit(IntEquals<Domain> equals)
        {
            return equals as IComputation<Domain, Domain>;
        }

        public IComputation<Domain, Domain> Visit<Tuple>(TupleConstructorN<Domain, Tuple> constructor)
        {
            return constructor as IComputation<Domain, Domain>;
        }

        public IComputation<Domain, Domain> Visit<Tuple, Field>(ProjectionN<Domain, Tuple, Field> projection)
        {
            return projection as IComputation<Domain, Domain>;
        }

        public IComputation<Domain, Domain> Visit(Ite<Domain> ite)
        {
            return InstructionSet<Domain>.Ite(ite.Condition, ite.IfTrue.Accept(this), ite.IfFalse.Accept(this));
        }

        public IComputation<Domain, Domain> Visit(Switch<Domain> switchComp)
        {
            return InstructionSet<Domain>.Switch(switchComp.Cases.Select(x => InstructionSet<Domain>.Case(x.Condition, x.Computation.Accept(this))).ToList());
        }

        public IComputation<Domain, Domain> Visit(Undefined<Domain> undefined)
        {
            return undefined;
        }

        public IComputation<Domain, Domain> Visit(ContextualSimplificationBoundary<Domain> boundary)
        {
            return boundary.Computation.Accept(this);
        }
    }
}
