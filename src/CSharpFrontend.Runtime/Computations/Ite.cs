using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime
{
    [Serializable]
    public class Ite<Domain> : IComputation<Domain, Domain>
    {
        public TotalComputation<Domain, bool> Condition { get; private set; }
        public IComputation<Domain, Domain> IfTrue { get; private set; }
        public IComputation<Domain, Domain> IfFalse { get; private set; }

        public Ite(TotalComputation<Domain, bool> condition, IComputation<Domain, Domain> ifTrue, IComputation<Domain, Domain> ifFalse)
        {
            Condition = condition;
            IfTrue = ifTrue;
            IfFalse = ifFalse;
        }

        public bool Apply(Domain argument, out Domain result)
        {
            if (Condition.Apply(argument))
            {
                return IfTrue.Apply(argument, out result);
            }
            else
            {
                return IfFalse.Apply(argument, out result);
            }
        }

        public override string ToString()
        {
            return "ite(" + Condition + ",\n" + IfTrue.ToString().Indent() + ",\n" + IfFalse.ToString().Indent() + ")";
        }

        public IComputation<Domain, Domain> ComposeAndSimplify(Func<TotalComputation<Domain, Domain>, IComputation<Domain, Domain>> createOuter)
        {
            IfTrue = IfTrue.ComposeAndSimplify(createOuter);
            IfFalse = IfFalse.ComposeAndSimplify(createOuter);
            return this;
        }

        public IComputation<Domain, Domain> SpecializeToContext(Context<Domain> context)
        {
            Condition = Condition.Simplify(context);
            var constantCondition = Condition as Constant<Domain, bool>;
            if (constantCondition != null)
            {
                if (constantCondition.Value)
                {
                    return IfTrue.SpecializeToContext(context);
                }
                else
                {
                    return IfFalse.SpecializeToContext(context);
                }
            }

            var ifTrueContext = context.Push();
            Condition.AddAssertions(ifTrueContext, false);
            IfTrue = IfTrue.SpecializeToContext(ifTrueContext);

            var ifFalseContext = context.Push();
            Condition.AddAssertions(ifFalseContext, true);
            IfFalse = IfFalse.SpecializeToContext(ifFalseContext);

            return this;
        }

        public T Accept<T>(IComputationVisitor<Domain, T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public static partial class InstructionSet<Domain>
    {
        public static IComputation<Domain, Domain> Ite(TotalComputation<Domain, bool> condition, IComputation<Domain, Domain> ifTrue, IComputation<Domain, Domain> ifFalse)
        {
            var constantCondition = condition as Constant<Domain, bool>;
            if (constantCondition != null)
            {
                return constantCondition.Value ? ifTrue : ifFalse;
            }
            return new Ite<Domain>(condition, ifTrue, ifFalse);
        }
    }
}
