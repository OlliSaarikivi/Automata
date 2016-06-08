using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime
{
    [Serializable]
    public struct Interval
    {
        public static readonly Interval Unconstrained = new Interval(int.MinValue, int.MaxValue);

        public int Lower, Upper;

        public Interval(int lower, int upper)
        {
            Lower = lower;
            Upper = upper;
        }

        public IEnumerable<Interval> Negation()
        {
            if (Lower != int.MinValue)
            {
                yield return new Interval(int.MinValue, Lower - 1);
            }
            if (Upper != int.MaxValue)
            {
                yield return new Interval(Upper + 1, int.MaxValue);
            }
        }

        public Interval? Intersection(Interval other)
        {
            if (IsEmpty() || other.IsEmpty())
            {
                return null;
            }
            Interval i1 = this, i2 = other;
            if (other.Lower < Lower)
            {
                i1 = other;
                i2 = this;
            }
            // At this point i1.lower <= i2.lower
            if (i1.IsInRange(i2.Lower))
            {
                if (i2.IsInRange(i2.Upper))
                {
                    return i2;
                }
                else
                {
                    return new Interval(i2.Lower, i1.Upper);
                }
            }
            else
            {
                if (i2.IsInRange(i2.Upper))
                {
                    return new Interval(i1.Lower, i2.Upper);
                }
                else
                {
                    return null;
                }
            }
        }

        public Interval? ContiguousUnion(Interval other)
        {
            if (IsEmpty())
            {
                return other;
            }
            if (other.IsEmpty())
            {
                return this;
            }
            if (Upper != int.MaxValue && Upper + 1 == other.Lower)
            {
                return new Interval(Lower, other.Upper);
            }
            if (Lower != int.MinValue && Lower - 1 == other.Upper)
            {
                return new Interval(other.Lower, Upper);
            }

            if (IsInRange(other.Lower))
            {
                if (IsInRange(other.Upper))
                {
                    return this;
                }
                else
                {
                    return new Interval(Lower, other.Upper);
                }
            }
            else
            {
                if (IsInRange(other.Upper))
                {
                    return new Interval(other.Lower, Upper);
                }
                else
                {
                    return null;
                }
            }
        }

        public bool IsEmpty()
        {
            return Lower > Upper;
        }

        public bool IsUnconstrained()
        {
            return Lower == int.MinValue && Upper == int.MaxValue;
        }

        public bool IsInRange(int value)
        {
            return Lower <= value && value <= Upper;
        }

        public bool IsSubset(Interval superSet)
        {
            return superSet.IsInRange(Lower) && superSet.IsInRange(Upper);
        }

        public Interval? Transpose(int m, int c)
        {
            if (m == 0)
            {
                return IsInRange(c) ? (Interval?)this : null;
            }
            else
            {
                long newLower = ((long)Lower - (long)c) / (long)m;
                long newUpper = ((long)Upper - (long)c) / (long)m;
                if (m < 0)
                {
                    var tmp = newLower;
                    newLower = newUpper;
                    newUpper = tmp;
                }
                if (newLower > int.MaxValue)
                {
                    return null;
                }
                newLower = newLower < int.MinValue ? int.MinValue : newLower;
                if (newUpper < int.MinValue)
                {
                    return null;
                }
                newUpper = newUpper > int.MaxValue ? int.MaxValue : newUpper;
                return new Interval((int)newLower, (int)newUpper);
            }
        }

        public override string ToString()
        {
            string l = Lower == int.MinValue ? "-∞" : Lower.ToString();
            string u = Upper == int.MaxValue ? "∞" : Upper.ToString();
            return "[" + l + "," + u + "]";
        }

        public bool Equals(Interval other)
        {
            return Lower == other.Lower && Upper == other.Upper;
        }

        public override int GetHashCode()
        {
            return Utils.HashCombine(Lower.GetHashCode(), Upper.GetHashCode());
        }
    }

    [Serializable]
    public class InInterval<Domain> : UnaryComposition<Domain, int, bool>
    {
        public Interval Interval { get; private set; }

        public InInterval(TotalComputation<Domain, int> inner, Interval interval)
            : base(inner)
        {
            Interval = interval;
        }

        public override TotalComputation<Domain, bool> WithInner(TotalComputation<Domain, int> newInner)
        {
            return InstructionSet<Domain>.InInterval(newInner, Interval);
        }

        internal TotalComputation<Domain, bool> Intersect(Interval interval)
        {
            var intersection = Interval.Intersection(interval);
            return intersection != null ? (TotalComputation<Domain, bool>)new InInterval<Domain>(Inner, intersection.Value) : Constants<Domain>.False;
        }

        public override bool ApplyOuter(int argument)
        {
            return Interval.IsInRange(argument);
        }

        protected override string OuterToString()
        {
            return "(λx.x∈" + Interval + ")";
        }

        protected override TotalComputation<Domain, bool> OuterSimplify(Context<Domain> context)
        {
            if (context.IsImplied(Inner, Interval))
            {
                return Constants<Domain>.True;
            }
            if (context.IsImplied(Inner, Interval.Negation()))
            {
                return Constants<Domain>.False;
            }
            return this;
        }

        public override void AddAssertions(Context<Domain> context, bool negate)
        {
            if (negate)
            {
                context.Assert(Inner, Interval.Negation());
            }
            else
            {
                context.Assert(Inner, Interval);
            }
        }

        protected override bool OuterEquals(UnaryCompositionBase<Domain, int, bool> obj)
        {
            var casted = obj as InInterval<Domain>;
            if (casted != null)
            {
                return Interval.Equals(casted.Interval);
            }
            return false;
        }

        protected override int OuterGetHashCode()
        {
            return Interval.GetHashCode();
        }

        public override T Accept<T>(IComputationVisitor<Domain, T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    [Serializable]
    public class IntLinear<Domain> : UnaryComposition<Domain, int, int>
    {
        public int M { get; private set; }
        public int C { get; private set; }

        public IntLinear(TotalComputation<Domain, int> inner, int m, int c)
            : base(inner)
        {
            M = m;
            C = c;
        }

        public override TotalComputation<Domain, int> WithInner(TotalComputation<Domain, int> newInner)
        {
            return InstructionSet<Domain>.Linear(newInner, M, C);
        }

        public override int ApplyOuter(int argument)
        {
            checked // TODO: How should be surface overflow?
            {
                return M * argument + C;
            }
        }

        protected override string OuterToString()
        {
            return "(λx." + M + "x+" + C + ")";
        }

        public override void AddAssertions(Context<Domain> context, bool negate)
        {
        }

        protected override bool OuterEquals(UnaryCompositionBase<Domain, int, int> obj)
        {
            var casted = obj as IntLinear<Domain>;
            if (casted != null)
            {
                return M == casted.M && C == casted.C;
            }
            return false;
        }

        protected override int OuterGetHashCode()
        {
            return Utils.HashCombine(M.GetHashCode(), C.GetHashCode());
        }

        public override T Accept<T>(IComputationVisitor<Domain, T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public static partial class InstructionSet<Domain>
    {
        public static TotalComputation<Domain, int> Linear(TotalComputation<Domain, int> inner, int m, int c)
        {
            checked
            {
                var constant = inner as Constant<Domain, int>;
                if (constant != null)
                {
                    return InstructionSet<Domain>.Constant(m * constant.Value + c);
                }
                var linear = inner as IntLinear<Domain>;
                if (linear != null)
                {
                    return new IntLinear<Domain>(linear.Inner, linear.M * m, linear.C * m + c);
                }
                return new IntLinear<Domain>(inner, m, c);
            }
        }

        public static TotalComputation<Domain, int> Add(TotalComputation<Domain, int> lhs, int rhs)
        {
            return Linear(lhs, 1, rhs);
        }
        public static TotalComputation<Domain, int> Add(int lhs, TotalComputation<Domain, int> rhs)
        {
            return Add(rhs, lhs);
        }
        public static TotalComputation<Domain, int> Sub(TotalComputation<Domain, int> lhs, int rhs)
        {
            return Add(lhs, -rhs);
        }
        public static TotalComputation<Domain, int> Sub(int lhs, TotalComputation<Domain, int> rhs)
        {
            return Linear(rhs, -1, lhs);
        }

        public static TotalComputation<Domain, bool> InInterval(TotalComputation<Domain, int> inner, Interval interval)
        {
            var constant = inner as Constant<Domain, int>;
            if (constant != null)
            {
                return InstructionSet<Domain>.Constant(interval.IsInRange(constant.Value));
            }
            var linear = inner as IntLinear<Domain>;
            if (linear != null)
            {
                var newInterval = interval.Transpose(linear.M, linear.C);
                return newInterval != null ? InInterval(linear.Inner, newInterval.Value) : Constants<Domain>.False;
            }
            return new InInterval<Domain>(inner, interval);
        }
        public static TotalComputation<Domain, bool> Le(TotalComputation<Domain, int> lhs, int rhs)
        {
            return InInterval(lhs, new Interval(int.MinValue, rhs));
        }
        public static TotalComputation<Domain, bool> Le(int lhs, TotalComputation<Domain, int> rhs)
        {
            return Ge(rhs, lhs);
        }
        public static TotalComputation<Domain, bool> Ge(TotalComputation<Domain, int> lhs, int rhs)
        {
            return InInterval(lhs, new Interval(rhs, int.MaxValue));
        }
        public static TotalComputation<Domain, bool> Ge(int lhs, TotalComputation<Domain, int> rhs)
        {
            return Le(rhs, lhs);
        }
        public static TotalComputation<Domain, bool> Lt(TotalComputation<Domain, int> lhs, int rhs)
        {
            return rhs == int.MinValue ? Constants<Domain>.False : Le(lhs, (rhs - 1));
        }
        public static TotalComputation<Domain, bool> Lt(int lhs, TotalComputation<Domain, int> rhs)
        {
            return Gt(rhs, lhs);
        }
        public static TotalComputation<Domain, bool> Gt(TotalComputation<Domain, int> lhs, int rhs)
        {
            return rhs == int.MaxValue ? Constants<Domain>.False : Ge(lhs, (rhs + 1));
        }
        public static TotalComputation<Domain, bool> Gt(int lhs, TotalComputation<Domain, int> rhs)
        {
            return Lt(rhs, lhs);
        }
    }
}
