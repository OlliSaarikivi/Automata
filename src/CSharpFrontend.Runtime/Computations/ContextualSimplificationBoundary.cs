using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime
{
    public class Context<Domain>
    {
        public Dictionary<TotalComputation<Domain, int>, List<Interval>> Intervals { get; set; }
        Context<Domain> _parent;

        public List<Interval> TryGetInterval(TotalComputation<Domain, int> key)
        {
            if (Intervals != null)
            {
                List<Interval> result = null;
                Intervals.TryGetValue(key, out result);
                return result;
            }
            return null;
        }

        public Context<Domain> Push()
        {
            return new Context<Domain> { _parent = this };
        }

        T WalkUp<T>(Func<Context<Domain>, T> accessor)
            where T : class
        {
            var current = this;
            while (current != null)
            {
                var result = accessor(current);
                if (result != null)
                {
                    return result;
                }
                current = current._parent;
            }
            return null;
        }

        List<Interval> Unconstrained = new List<Interval>() { Interval.Unconstrained };
        List<Interval> GetIntervals(TotalComputation<Domain, int> key)
        {
            var intervals = WalkUp(c => c.TryGetInterval(key));
            return intervals != null ? intervals : Unconstrained;
        }

        public void Assert(TotalComputation<Domain, int> key, params Interval[] intervals)
        {
            Assert(key, (IEnumerable<Interval>)intervals);
        }
        public void Assert(TotalComputation<Domain, int> key, IEnumerable<Interval> intervals)
        {
            var currentIntervals = GetIntervals(key);

            var newIntervals = new List<Interval>(currentIntervals.Count);
            foreach (var currentInterval in currentIntervals)
            {
                foreach (var interval in intervals)
                {
                    var newInterval = currentInterval.Intersection(interval);
                    if (newInterval != null)
                    {
                        newIntervals.Add(newInterval.Value);
                    }
                }
            }

            if (Intervals == null)
            {
                Intervals = new Dictionary<TotalComputation<Domain, int>, List<Interval>>();
            }
            Intervals[key] = newIntervals;
        }

        // True means is implied. False means unknown.
        public bool IsImplied(TotalComputation<Domain, int> key, params Interval[] intervals)
        {
            return IsImplied(key, (IEnumerable<Interval>)intervals);
        }
        public bool IsImplied(TotalComputation<Domain, int> key, IEnumerable<Interval> intervals)
        {
            var knownIntervals = GetIntervals(key);

            foreach (var knownInterval in knownIntervals)
            {
                bool subsetOfAny = false;
                foreach (var interval in intervals)
                {
                    subsetOfAny |= knownInterval.IsSubset(interval);
                }
                if (!subsetOfAny)
                {
                    return false;
                }
            }
            return true;
        }
    }

    public class ContextualSimplificationBoundary<Domain> : IComputation<Domain, Domain>
    {

        public TotalComputation<Domain, Domain> Computation { get; private set; }

        Context<Domain> _context;

        public ContextualSimplificationBoundary(TotalComputation<Domain, Domain> computation, Context<Domain> context)
        {
            Computation = computation;
            _context = context;
        }

        public bool Apply(Domain argument, out Domain result)
        {
            return Computation.Apply(argument, out result);
        }

        public IComputation<Domain, Domain> ComposeAndSimplify(Func<TotalComputation<Domain, Domain>, IComputation<Domain, Domain>> createOuter)
        {
            var result = createOuter(Computation);
            return result.SpecializeToContext(_context);
        }


        public IComputation<Domain, Domain> SpecializeToContext(Context<Domain> context)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Computation.ToString();
        }

        public T Accept<T>(IComputationVisitor<Domain, T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
