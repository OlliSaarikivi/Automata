using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime
{
    [Serializable]
    public class Equals<Domain, Enum> : UnaryComposition<Domain, Enum, bool>
        where Enum : struct
    {
        public static bool AreEqual(Enum lhs, Enum rhs)
        {
            //if (typeof(Enum).IsEnum)
            //{
            //    return (lhs as System.Enum).Equals(rhs as System.Enum);
            //}
            //else
            //{
            //    return lhs.Equals(rhs);
            //}
            return lhs.Equals(rhs);
        }

        public Enum Required { get; private set; }

        public Equals(TotalComputation<Domain, Enum> inner, Enum required)
            : base(inner)
        {
            Required = required;
        }

        public override TotalComputation<Domain, bool> WithInner(TotalComputation<Domain, Enum> newInner)
        {
            return InstructionSet<Domain>.Eq(newInner, Required);
        }

        public override bool ApplyOuter(Enum argument)
        {
            return AreEqual(argument, Required);
        }

        protected override string OuterToString()
        {
            return "(λx.x=" + Required + ")";
        }

        protected override bool OuterEquals(UnaryCompositionBase<Domain, Enum, bool> obj)
        {
            var casted = obj as Equals<Domain, Enum>;
            if (casted != null)
            {
                return AreEqual(Required, casted.Required);
            }
            return false;
        }

        protected override int OuterGetHashCode()
        {
            return Required.GetHashCode();
        }

        public override T Accept<T>(IComputationVisitor<Domain, T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    [Serializable]
    public class IntEquals<Domain> : UnaryComposition<Domain, int, bool>
    {
        public int Required { get; private set; }

        public IntEquals(TotalComputation<Domain, int> inner, int required)
            : base(inner)
        {
            Required = required;
        }

        public override TotalComputation<Domain, bool> WithInner(TotalComputation<Domain, int> newInner)
        {
            return InstructionSet<Domain>.Eq(newInner, Required);
        }

        public override bool ApplyOuter(int argument)
        {
            return argument == Required;
        }

        protected override string OuterToString()
        {
            return "(λx.x=" + Required + ")";
        }

        protected override bool OuterEquals(UnaryCompositionBase<Domain, int, bool> obj)
        {
            var casted = obj as IntEquals<Domain>;
            if (casted != null)
            {
                return Required == casted.Required;
            }
            return false;
        }

        protected override int OuterGetHashCode()
        {
            return Required.GetHashCode();
        }

        public override T Accept<T>(IComputationVisitor<Domain, T> visitor)
        {
            return visitor.Visit(this);
        }
    }


    public static partial class InstructionSet<Domain>
    {
        public static TotalComputation<Domain, bool> Eq<Enum>(TotalComputation<Domain, Enum> lhs, Enum rhs)
            where Enum : struct
        {
            var constant = lhs as Constant<Domain, Enum>;
            if (constant != null)
            {
                return InstructionSet<Domain>.Constant(Equals<Domain, Enum>.AreEqual(constant.Value, rhs));
            }
            var equals = lhs as Equals<Domain, Enum>;
            if (equals != null)
            {
                if (Equals<Domain, Enum>.AreEqual(rhs, equals.Required))
                {
                    return equals;
                }
                else
                {
                    return Constants<Domain>.False;
                }
            }
            return new Equals<Domain, Enum>(lhs, rhs);
        }

        // The following method (and associated class) is better for some and worse for other benchmarks.
        //public static TotalComputation<Domain, bool> Eq(TotalComputation<Domain, int> lhs, int rhs)
        //{
        //    var constant = lhs as Constant<Domain, int>;
        //    if (constant != null)
        //    {
        //        return InstructionSet<Domain>.Constant(constant.Value == rhs);
        //    }
        //    var equals = lhs as IntEquals<Domain>;
        //    if (equals != null)
        //    {
        //        if (rhs == equals.Required)
        //        {
        //            return equals;
        //        }
        //        else
        //        {
        //            return Constants<Domain>.False;
        //        }
        //    }
        //    return new IntEquals<Domain>(lhs, rhs);
        //}
    }
}
