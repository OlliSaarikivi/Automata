using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime
{
    public interface IComputation<Domain, Range>
    {
        bool Apply(Domain argument, out Range result);
        T Accept<T>(IComputationVisitor<Domain, T> visitor);
        IComputation<Domain, Range> ComposeAndSimplify(Func<TotalComputation<Domain, Range>, IComputation<Domain, Range>> createOuter);
        IComputation<Domain, Range> SpecializeToContext(Context<Domain> context);
    }

    [Serializable]
    public abstract class TotalComputation<Domain, Range> : IComputation<Domain, Range>
    {
        public abstract Range Apply(Domain argument);
        public bool Apply(Domain argument, out Range result)
        {
            result = Apply(argument);
            return true;
        }

        public virtual void AddAssertions(Context<Domain> context, bool negate)
        {
        }

        public virtual TotalComputation<Domain, Range> Simplify(Context<Domain> context)
        {
            return this;
        }

        public IComputation<Domain, Range> ComposeAndSimplify(Func<TotalComputation<Domain, Range>, IComputation<Domain, Range>> createOuter)
        {
            throw new NotImplementedException();
            return createOuter(this);
        }

        public IComputation<Domain, Range> SpecializeToContext(Context<Domain> context)
        {
            var casted = this as TotalComputation<Domain, Domain>;
            if (casted != null)
            {
                return (IComputation<Domain, Range>)new ContextualSimplificationBoundary<Domain>(casted.Simplify(context), context);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public abstract T Accept<T>(IComputationVisitor<Domain, T> visitor);
    }

    [Serializable]
    public class Identity<Domain> : TotalComputation<Domain, Domain>
    {
        public static readonly Identity<Domain> Instance = new Identity<Domain>();

        Identity() { }

        public override Domain Apply(Domain argument)
        {
            return argument;
        }

        public override string ToString()
        {
            return "(λx.x)";
        }

        public override T Accept<T>(IComputationVisitor<Domain, T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    [Serializable]
    public class Undefined<Domain> : IComputation<Domain, Domain>
    {
        public static readonly Undefined<Domain> Instance = new Undefined<Domain>();

        Undefined() { }

        public bool Apply(Domain argument, out Domain result)
        {
            result = default(Domain);
            return false;
        }

        public override string ToString()
        {
            return "(λx.⊥)";
        }

        public IComputation<Domain, Domain> ComposeAndSimplify(Func<TotalComputation<Domain, Domain>, IComputation<Domain, Domain>> createOuter)
        {
            return this;
        }

        public IComputation<Domain, Domain> SpecializeToContext(Context<Domain> context)
        {
            return this;
        }

        public T Accept<T>(IComputationVisitor<Domain, T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    [Serializable]
    public class Constant<Domain, Range> : TotalComputation<Domain, Range>
    {
        public Range Value { get; private set; }

        public Constant(Range value)
        {
            Value = value;
        }

        public override Range Apply(Domain argument)
        {
            return Value;
        }

        public override string ToString()
        {
            return "(λx.“" + Value + "”)";
        }

        public override bool Equals(object obj)
        {
            if (obj == this) return true;
            var casted = obj as Constant<Domain, Range>;
            if (casted != null)
            {
                return Value.Equals(casted.Value);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override T Accept<T>(IComputationVisitor<Domain, T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public static class Constants<Domain>
    {
        public static readonly Constant<Domain, bool> True = new Constant<Domain, bool>(true);
        public static readonly Constant<Domain, bool> False = new Constant<Domain, bool>(false);
    }

    public static class Constants<Domain, Range>
    {
        public static readonly Constant<Domain, IEnumerable<Range>> EmptyEnumeration = new Constant<Domain, IEnumerable<Range>>(new Range[0]);
    }
}
