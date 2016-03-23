using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime
{
    [Serializable]
    public class Switch<Domain> : IComputation<Domain, Domain>
    {
        [Serializable]
        public struct Case
        {
            public TotalComputation<Domain, bool> Condition;
            public IComputation<Domain, Domain> Computation;

            public Case(TotalComputation<Domain, bool> condition, IComputation<Domain, Domain> computation)
            {
                Condition = condition;
                Computation = computation;
            }
        }

        public List<Case> Cases { get; private set; }

        public Switch(List<Case> cases)
        {
            Cases = cases;
        }

        public bool Apply(Domain argument, out Domain result)
        {
            foreach (var caseElement in Cases)
            {
                if (caseElement.Condition.Apply(argument))
                {
                    return caseElement.Computation.Apply(argument, out result);
                }
            }
            result = default(Domain);
            return false;
        }

        public override string ToString()
        {
            return "switch(" + Cases.Select(x => "\n" + x.Condition + "⇾" + x.Computation).ToSeparatedString().Indent() + ")";
        }

        public IComputation<Domain, Domain> ComposeAndSimplify(Func<TotalComputation<Domain, Domain>, IComputation<Domain, Domain>> createOuter)
        {
            for (int i = 0; i < Cases.Count; ++i)
            {
                var newComputation = Cases[i].Computation.ComposeAndSimplify(createOuter);
                Cases[i] = InstructionSet<Domain>.Case(Cases[i].Condition, newComputation);
            }
            return this;
        }

        public IComputation<Domain, Domain> SpecializeToContext(Context<Domain> context)
        {
            for (int i = Cases.Count - 1; i >= 0; --i)
            {
                var newCondition = Cases[i].Condition.Simplify(context);
                var constantCondition = newCondition as Constant<Domain, bool>;
                if (constantCondition != null)
                {
                    if (constantCondition.Value)
                    {
                        return Cases[i].Computation.SpecializeToContext(context);
                    }
                    else
                    {
                        Cases.RemoveAt(i);
                    }
                }
                else
                {
                    Cases[i] = InstructionSet<Domain>.Case(newCondition, Cases[i].Computation);
                }
            }
            if (Cases.Count == 0)
            {
                return InstructionSet<Domain>.Undef();
            }

            for (int i = 0; i < Cases.Count; ++i)
            {
                var caseContext = context.Push();
                Cases[i].Condition.AddAssertions(caseContext, false);
                var newComputation = Cases[i].Computation.SpecializeToContext(caseContext);
                Cases[i] = InstructionSet<Domain>.Case(Cases[i].Condition, newComputation);
            }
            return this;
        }

        public T Accept<T>(IComputationVisitor<Domain, T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public static partial class InstructionSet<Domain>
    {
        public static Switch<Domain>.Case Case(TotalComputation<Domain, bool> condition, IComputation<Domain, Domain> computation)
        {
            return new Switch<Domain>.Case(condition, computation);
        }
        public static IComputation<Domain, Domain> Switch(params Switch<Domain>.Case[] cases)
        {
            for (int i = 0; i < cases.Length; ++i)
            {
                var caseComp = cases[i];
                var constantCondition = caseComp.Condition as Constant<Domain, bool>;
                if (constantCondition != null)
                {
                    if (constantCondition.Value)
                    {
                        return caseComp.Computation;
                    }
                }
                cases[i] = InstructionSet<Domain>.Case(caseComp.Condition, caseComp.Computation);
            }
            return new Switch<Domain>(new List<Switch<Domain>.Case>(cases));
        }
        public static IComputation<Domain, Domain> Switch(List<Switch<Domain>.Case> cases)
        {
            for (int i = 0; i < cases.Count; ++i)
            {
                var caseComp = cases[i];
                var constantCondition = caseComp.Condition as Constant<Domain, bool>;
                if (constantCondition != null)
                {
                    if (constantCondition.Value)
                    {
                        return caseComp.Computation;
                    }
                }
                cases[i] = InstructionSet<Domain>.Case(caseComp.Condition, caseComp.Computation);
            }
            return new Switch<Domain>(cases);
        }
    }
}
