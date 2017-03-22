using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata
{
    internal class STbMinimizer<FUNC, TERM, SORT>
    {
        STb<FUNC, TERM, SORT> stb;

        ST<FUNC, TERM, SORT> st;


        internal STbMinimizer(STb<FUNC, TERM, SORT> stb)
        {
            this.stb = stb;
            this.st = stb.ToST();
        }

        static string DummyVarMapping(TERM t)
        {
            return "x";
        }

        static double TermSize(TERM t, IContext<FUNC, TERM, SORT> s)
        {
            return s.PrettyPrintCS(t, DummyVarMapping).Length;
        }

        static double WeightedRuleSize(STbRule<TERM> r, IContext<FUNC,TERM,SORT> s)
        {
            switch (r.RuleKind)
            {
                case STbRuleKind.Undef:
                    return 0;
                case STbRuleKind.Base:
                    return r.Yields.Sum(x => TermSize(x, s)) + TermSize(r.Register, s);
                case STbRuleKind.Ite:
                    var t = WeightedRuleSize(r.TrueCase, s);
                    var f = WeightedRuleSize(r.FalseCase, s);
                    return TermSize(r.Condition, s)
                        + ((t + f) / 2); // Equal probability for branches is assumed
                default:
                    throw new NotImplementedException();
            }
        }

        public STb<FUNC, TERM, SORT> Minimize()
        {
            var s = stb.Solver;
            
            var alphaSort = s.MkOptionSort(stb.InputSort);
            var autoSort = s.MkTupleSort(alphaSort, stb.OutputListSort, stb.RegisterSort, stb.RegisterSort);
            var autoVar = s.MkVar(3, autoSort);

            var autoInput = s.MkProj(0, autoVar);
            var autoSomeInput = s.MkGetSomeValue(autoInput);
            var autoOutputList = s.MkProj(1, autoVar);
            var autoOldReg = s.MkProj(2, autoVar);
            var autoNewReg = s.MkProj(3, autoVar);

            Func<TERM, TERM> finalSubstitute = (t) => s.ApplySubstitution(t, stb.RegVar, autoOldReg);
            Func<TERM, TERM> nonFinalSubstitute = (t) => finalSubstitute(s.ApplySubstitution(t, stb.InputVar, autoSomeInput));

            int acceptingState = stb.States.Max() + 1;
            int errorState = stb.States.Max() + 2;
            var moves = new List<Move<TERM>>();
            foreach (var state in stb.States)
            {
                var nonFinalConds = new List<TERM>();
                foreach (var nonFinal in st.GetNonFinalMovesFrom(state))
                {
                    var rule = nonFinal.Label;
                    var conds = new List<TERM>();
                    conds.Add(s.MkIsSome(autoInput));
                    conds.Add(nonFinalSubstitute(rule.Guard));
                    var outputList = autoOutputList;
                    foreach (var yield in rule.Output)
                    {
                        conds.Add(s.MkIsCons(outputList));
                        conds.Add(s.MkEq(s.MkFirstOfList(outputList), nonFinalSubstitute(yield)));
                        outputList = s.MkRestOfList(outputList);
                    }
                    conds.Add(s.MkIsNil(outputList));
                    conds.Add(s.MkEq(autoNewReg, nonFinalSubstitute(rule.Update)));
                    var cond = s.MkAnd(conds);
                    moves.Add(Move<TERM>.Create(state, nonFinal.TargetState, cond));
                    nonFinalConds.Add(cond);
                }
                var finalConds = new List<TERM>();
                foreach (var rule in st.GetFinalRules(state))
                {
                    var conds = new List<TERM>();
                    conds.Add(s.MkIsNone(autoInput));
                    conds.Add(finalSubstitute(rule.Guard));
                    var outputList = autoOutputList;
                    foreach (var yield in rule.Output)
                    {
                        conds.Add(s.MkIsCons(outputList));
                        conds.Add(s.MkEq(s.MkFirstOfList(outputList), finalSubstitute(yield)));
                        outputList = s.MkRestOfList(outputList);
                    }
                    conds.Add(s.MkIsNil(outputList));
                    var cond = s.MkAnd(conds);
                    moves.Add(Move<TERM>.Create(state, acceptingState, cond));
                    finalConds.Add(cond);
                }

            }
            //moves.Add(Move<TERM>.Create(errorState, errorState, s.True));
            var auto = Automaton<TERM>.Create(stb.Solver, stb.InitialState, new int[] { acceptingState }, moves);
            auto.CheckDeterminism(stb.Solver);
            var blocks = auto.BookkeepingMinimize(stb.Solver);

            Func<STbRule<TERM>, STbRule<TERM>> redirect = null;
            redirect = r =>
            {
                switch (r.RuleKind)
                {
                    case STbRuleKind.Undef:
                        return r;
                    case STbRuleKind.Base:
                        return new BaseRule<TERM>(r.Yields, r.Register, blocks[r.State].GetRepresentative());
                    case STbRuleKind.Ite:
                        var t = redirect(r.TrueCase);
                        var f = redirect(r.FalseCase);
                        return new IteRule<TERM>(r.Condition, t, f);
                    default:
                        throw new NotImplementedException();
                }
            };

            var minimized = new STb<FUNC, TERM, SORT>(stb.Solver, stb.Name + "_min", stb.InputSort, stb.OutputSort, stb.RegisterSort, stb.InitialRegister,
                blocks[stb.InitialState].GetRepresentative());
            var representatives = new HashSet<int>();
            var weightedRuleSizes = stb.States.ToDictionary(x => x, x => WeightedRuleSize(stb.GetRuleFrom(x), s));
            foreach (var state in stb.States)
            {
                representatives.Add(blocks[state].GetRepresentative((set) =>
                    (from candidate in set
                     orderby weightedRuleSizes[candidate] ascending
                     select candidate).First()
                ));
            }
            foreach (var state in representatives)
            {
                minimized.AssignRule(state, redirect(stb.GetRuleFrom(state)).CollapseRedundantITEs(s));
                minimized.AssignFinalRule(state, redirect(stb.GetFinalRuleFrom(state)).CollapseRedundantITEs(s));
            }
            return minimized;
        }
    }
}
