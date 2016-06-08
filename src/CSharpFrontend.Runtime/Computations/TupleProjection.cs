using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime
{
    public static partial class InstructionSet<Domain>
    {
        public static TotalComputation<Domain, T1> Proj1<T1>(TotalComputation<Domain, Tuple<T1>> comp)
        {
            var constant = comp as Constant<Domain, Tuple<T1>>;
            if (constant != null)
            {
                return InstructionSet<Domain>.Constant(constant.Value.Item1);
            }
            var tuple = comp as TupleConstructor<Domain, T1>;
            if (tuple != null)
            {
                return tuple.Comp1;
            }
            return new Projection1<Domain, T1>(comp);
        }
        public static TotalComputation<Domain, T1> Proj1<T1, T2>(TotalComputation<Domain, Tuple<T1, T2>> comp)
        {
            var constant = comp as Constant<Domain, Tuple<T1, T2>>;
            if (constant != null)
            {
                return InstructionSet<Domain>.Constant(constant.Value.Item1);
            }
            var tuple = comp as TupleConstructor<Domain, T1, T2>;
            if (tuple != null)
            {
                return tuple.Comp1;
            }
            return new Projection1<Domain, T1, T2>(comp);
        }
        public static TotalComputation<Domain, T2> Proj2<T1, T2>(TotalComputation<Domain, Tuple<T1, T2>> comp)
        {
            var constant = comp as Constant<Domain, Tuple<T1, T2>>;
            if (constant != null)
            {
                return InstructionSet<Domain>.Constant(constant.Value.Item2);
            }
            var tuple = comp as TupleConstructor<Domain, T1, T2>;
            if (tuple != null)
            {
                return tuple.Comp2;
            }
            return new Projection2<Domain, T1, T2>(comp);
        }
        public static TotalComputation<Domain, T1> Proj1<T1, T2, T3>(TotalComputation<Domain, Tuple<T1, T2, T3>> comp)
        {
            var constant = comp as Constant<Domain, Tuple<T1, T2, T3>>;
            if (constant != null)
            {
                return InstructionSet<Domain>.Constant(constant.Value.Item1);
            }
            var tuple = comp as TupleConstructor<Domain, T1, T2, T3>;
            if (tuple != null)
            {
                return tuple.Comp1;
            }
            return new Projection1<Domain, T1, T2, T3>(comp);
        }
        public static TotalComputation<Domain, T2> Proj2<T1, T2, T3>(TotalComputation<Domain, Tuple<T1, T2, T3>> comp)
        {
            var constant = comp as Constant<Domain, Tuple<T1, T2, T3>>;
            if (constant != null)
            {
                return InstructionSet<Domain>.Constant(constant.Value.Item2);
            }
            var tuple = comp as TupleConstructor<Domain, T1, T2, T3>;
            if (tuple != null)
            {
                return tuple.Comp2;
            }
            return new Projection2<Domain, T1, T2, T3>(comp);
        }
        public static TotalComputation<Domain, T3> Proj3<T1, T2, T3>(TotalComputation<Domain, Tuple<T1, T2, T3>> comp)
        {
            var constant = comp as Constant<Domain, Tuple<T1, T2, T3>>;
            if (constant != null)
            {
                return InstructionSet<Domain>.Constant(constant.Value.Item3);
            }
            var tuple = comp as TupleConstructor<Domain, T1, T2, T3>;
            if (tuple != null)
            {
                return tuple.Comp3;
            }
            return new Projection3<Domain, T1, T2, T3>(comp);
        }
    }
    [Serializable]
    public abstract class ProjectionN<Domain, Tuple, Field> : UnaryComposition<Domain, Tuple, Field>
    {
        public ProjectionN(TotalComputation<Domain, Tuple> inner)
            : base(inner)
        {
        }

        protected override string OuterToString()
        {
            var type = GetType();
            return "π" + GetType().Name.Substring(10, 1); // Horrible hack
        }

        public override T Accept<T>(IComputationVisitor<Domain, T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    [Serializable]
    public class Projection1<Domain, T1> : ProjectionN<Domain, Tuple<T1>, T1>
    {
        public Projection1(TotalComputation<Domain, Tuple<T1>> inner)
            : base(inner)
        {
        }

        public override TotalComputation<Domain, T1> WithInner(TotalComputation<Domain, Tuple<T1>> newInner)
        {
            return InstructionSet<Domain>.Proj1(newInner);
        }

        public override T1 ApplyOuter(Tuple<T1> argument)
        {
            return argument.Item1;
        }

        protected override bool OuterEquals(UnaryCompositionBase<Domain, Tuple<T1>, T1> obj)
        {
            return obj is Projection1<Domain, T1>;
        }

        protected override int OuterGetHashCode()
        {
            return 1001;
        }
    }

    [Serializable]
    public class Projection1<Domain, T1, T2> : ProjectionN<Domain, Tuple<T1, T2>, T1>
    {
        public Projection1(TotalComputation<Domain, Tuple<T1, T2>> inner)
            : base(inner)
        {
        }

        public override TotalComputation<Domain, T1> WithInner(TotalComputation<Domain, Tuple<T1, T2>> newInner)
        {
            return InstructionSet<Domain>.Proj1(newInner);
        }

        public override T1 ApplyOuter(Tuple<T1, T2> argument)
        {
            return argument.Item1;
        }

        protected override bool OuterEquals(UnaryCompositionBase<Domain, Tuple<T1, T2>, T1> obj)
        {
            return obj is Projection1<Domain, T1, T2>;
        }

        protected override int OuterGetHashCode()
        {
            return 1002;
        }
    }

    [Serializable]
    public class Projection2<Domain, T1, T2> : ProjectionN<Domain, Tuple<T1, T2>, T2>
    {
        public Projection2(TotalComputation<Domain, Tuple<T1, T2>> inner)
            : base(inner)
        {
        }

        public override TotalComputation<Domain, T2> WithInner(TotalComputation<Domain, Tuple<T1, T2>> newInner)
        {
            return InstructionSet<Domain>.Proj2(newInner);
        }

        public override T2 ApplyOuter(Tuple<T1, T2> argument)
        {
            return argument.Item2;
        }

        protected override bool OuterEquals(UnaryCompositionBase<Domain, Tuple<T1, T2>, T2> obj)
        {
            return obj is Projection2<Domain, T1, T2>;
        }

        protected override int OuterGetHashCode()
        {
            return 2002;
        }
    }

    [Serializable]
    public class Projection1<Domain, T1, T2, T3> : ProjectionN<Domain, Tuple<T1, T2, T3>, T1>
    {
        public Projection1(TotalComputation<Domain, Tuple<T1, T2, T3>> inner)
            : base(inner)
        {
        }

        public override TotalComputation<Domain, T1> WithInner(TotalComputation<Domain, Tuple<T1, T2, T3>> newInner)
        {
            return InstructionSet<Domain>.Proj1(newInner);
        }

        public override T1 ApplyOuter(Tuple<T1, T2, T3> argument)
        {
            return argument.Item1;
        }

        protected override bool OuterEquals(UnaryCompositionBase<Domain, Tuple<T1, T2, T3>, T1> obj)
        {
            return obj is Projection1<Domain, T1, T2, T3>;
        }

        protected override int OuterGetHashCode()
        {
            return 1003;
        }
    }

    [Serializable]
    public class Projection2<Domain, T1, T2, T3> : ProjectionN<Domain, Tuple<T1, T2, T3>, T2>
    {
        public Projection2(TotalComputation<Domain, Tuple<T1, T2, T3>> inner)
            : base(inner)
        {
        }

        public override TotalComputation<Domain, T2> WithInner(TotalComputation<Domain, Tuple<T1, T2, T3>> newInner)
        {
            return InstructionSet<Domain>.Proj2(newInner);
        }

        public override T2 ApplyOuter(Tuple<T1, T2, T3> argument)
        {
            return argument.Item2;
        }

        protected override bool OuterEquals(UnaryCompositionBase<Domain, Tuple<T1, T2, T3>, T2> obj)
        {
            return obj is Projection2<Domain, T1, T2, T3>;
        }

        protected override int OuterGetHashCode()
        {
            return 2003;
        }
    }

    [Serializable]
    public class Projection3<Domain, T1, T2, T3> : ProjectionN<Domain, Tuple<T1, T2, T3>, T3>
    {
        public Projection3(TotalComputation<Domain, Tuple<T1, T2, T3>> inner)
            : base(inner)
        {
        }

        public override TotalComputation<Domain, T3> WithInner(TotalComputation<Domain, Tuple<T1, T2, T3>> newInner)
        {
            return InstructionSet<Domain>.Proj3(newInner);
        }

        public override T3 ApplyOuter(Tuple<T1, T2, T3> argument)
        {
            return argument.Item3;
        }

        protected override bool OuterEquals(UnaryCompositionBase<Domain, Tuple<T1, T2, T3>, T3> obj)
        {
            return obj is Projection3<Domain, T1, T2, T3>;
        }

        protected override int OuterGetHashCode()
        {
            return 3003;
        }
    }
}
