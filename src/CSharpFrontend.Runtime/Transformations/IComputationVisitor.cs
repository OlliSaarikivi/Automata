using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime
{
    public interface IComputationVisitor<Domain, T>
    {
        T Visit<Range>(Constant<Domain, Range> constant);
        T Visit(Identity<Domain> identity);
        T Visit<ElementRange>(ListComputation<Domain, ElementRange> list);
        T Visit<ElementRange>(Append<Domain, ElementRange> append);
        T Visit(IntLinear<Domain> linear);
        T Visit(InInterval<Domain> inInterval);
        T Visit<Enum>(Equals<Domain, Enum> equals) where Enum : struct;
        T Visit(IntEquals<Domain> equals);
        T Visit<Tuple>(TupleConstructorN<Domain, Tuple> constructor);
        T Visit<Tuple, Field>(ProjectionN<Domain, Tuple, Field> projection);

        T Visit(Ite<Domain> ite);
        T Visit(Switch<Domain> switchComp);
        T Visit(Undefined<Domain> undefined);
        T Visit(ContextualSimplificationBoundary<Domain> boundary);

    }
}
