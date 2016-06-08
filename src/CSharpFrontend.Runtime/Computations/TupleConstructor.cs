using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime
{
    public static partial class InstructionSet<Domain>
    {
        public static TotalComputation<Domain, Tuple<T1>> MkTuple<T1>(TotalComputation<Domain, T1> comp1)
        {
            var const1 = comp1 as Constant<Domain, T1>;
            if (const1 != null)
            {
                return new Constant<Domain, Tuple<T1>>(Tuple.Create(const1.Value));
            }
            return new TupleConstructor<Domain, T1>(comp1);
        }
        public static TotalComputation<Domain, Tuple<T1, T2>> MkTuple<T1, T2>(TotalComputation<Domain, T1> comp1, TotalComputation<Domain, T2> comp2)
        {
            var const1 = comp1 as Constant<Domain, T1>;
            var const2 = comp2 as Constant<Domain, T2>;
            if (const1 != null && const2 != null)
            {
                return new Constant<Domain, Tuple<T1, T2>>(Tuple.Create(const1.Value, const2.Value));
            }
            return new TupleConstructor<Domain, T1, T2>(comp1, comp2);
        }
        public static TotalComputation<Domain, Tuple<T1, T2, T3>> MkTuple<T1, T2, T3>(TotalComputation<Domain, T1> comp1, TotalComputation<Domain, T2> comp2, TotalComputation<Domain, T3> comp3)
        {
            var const1 = comp1 as Constant<Domain, T1>;
            var const2 = comp2 as Constant<Domain, T2>;
            var const3 = comp2 as Constant<Domain, T3>;
            if (const1 != null && const2 != null && const3 != null)
            {
                return new Constant<Domain, Tuple<T1, T2, T3>>(Tuple.Create(const1.Value, const2.Value, const3.Value));
            }
            return new TupleConstructor<Domain, T1, T2, T3>(comp1, comp2, comp3);
        }
    }

    [Serializable]
    public abstract class TupleConstructorN<Domain, Tuple> : TotalComputation<Domain, Tuple>
    {
        public override void AddAssertions(Context<Domain> context, bool negate)
        {
        }

        public override T Accept<T>(IComputationVisitor<Domain, T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    [Serializable]
    public class TupleConstructor<Domain, T1> : TupleConstructorN<Domain, Tuple<T1>>
    {
        public TotalComputation<Domain, T1> Comp1 { get; private set; }

        public TupleConstructor(TotalComputation<Domain, T1> comp1)
        {
            Comp1 = comp1;
        }

        public override Tuple<T1> Apply(Domain argument)
        {
            return Tuple.Create(Comp1.Apply(argument));
        }

        public override TotalComputation<Domain, Tuple<T1>> Simplify(Context<Domain> context)
        {
            Comp1 = Comp1.Simplify(context);
            return this;
        }

        public override string ToString()
        {
            return "<" + Comp1 + ">";
        }
    }

    [Serializable]
    public class TupleConstructor<Domain, T1, T2> : TupleConstructorN<Domain, Tuple<T1, T2>>
    {
        public TotalComputation<Domain, T1> Comp1 { get; private set; }
        public TotalComputation<Domain, T2> Comp2 { get; private set; }

        public TupleConstructor(TotalComputation<Domain, T1> comp1, TotalComputation<Domain, T2> comp2)
        {
            Comp1 = comp1;
            Comp2 = comp2;
        }

        public override Tuple<T1, T2> Apply(Domain argument)
        {
            return Tuple.Create(Comp1.Apply(argument), Comp2.Apply(argument));
        }

        public override TotalComputation<Domain, Tuple<T1, T2>> Simplify(Context<Domain> context)
        {
            Comp1 = Comp1.Simplify(context);
            Comp2 = Comp2.Simplify(context);
            return this;
        }

        public override string ToString()
        {
            return "<" + Comp1 + "," + Comp2 + ">";
        }
    }

    [Serializable]
    public class TupleConstructor<Domain, T1, T2, T3> : TupleConstructorN<Domain, Tuple<T1, T2, T3>>
    {
        public TotalComputation<Domain, T1> Comp1 { get; private set; }
        public TotalComputation<Domain, T2> Comp2 { get; private set; }
        public TotalComputation<Domain, T3> Comp3 { get; private set; }

        public TupleConstructor(TotalComputation<Domain, T1> comp1, TotalComputation<Domain, T2> comp2, TotalComputation<Domain, T3> comp3)
        {
            Comp1 = comp1;
            Comp2 = comp2;
            Comp3 = comp3;
        }

        public override Tuple<T1, T2, T3> Apply(Domain argument)
        {
            return Tuple.Create(Comp1.Apply(argument), Comp2.Apply(argument), Comp3.Apply(argument));
        }

        public override TotalComputation<Domain, Tuple<T1, T2, T3>> Simplify(Context<Domain> context)
        {
            Comp1 = Comp1.Simplify(context);
            Comp2 = Comp2.Simplify(context);
            Comp3 = Comp3.Simplify(context);
            return this;
        }

        public override string ToString()
        {
            return "<" + Comp1 + "," + Comp2 + "," + Comp3 + ">";
        }
    }
}
