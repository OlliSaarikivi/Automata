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
            var auto = Automaton<TERM>.Create(stb.InitialState, new int[] { acceptingState }, moves);
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
            foreach (var state in stb.States)
            {
                representatives.Add(blocks[state].GetRepresentative());
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
