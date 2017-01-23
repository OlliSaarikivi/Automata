using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata
{
    public class QuasiDeterminizer
    {
        public static STb<FUNC, TERM, SORT> QuasiDeterminizeSTb<FUNC, TERM, SORT>(STb<FUNC, TERM, SORT> stb)
        {
            var stb1 = new STb<FUNC, TERM, SORT>(stb.Solver, $"{stb.Name}_qd",
                stb.InputSort, stb.OutputSort, stb.RegisterSort,
                stb.InitialRegister, stb.InitialState);
            foreach (var state in stb.States)
            {
                stb1.AssignRule(state, stb.GetRuleFrom(state));
                stb1.AssignFinalRule(state, stb.GetFinalRuleFrom(state));
            }
            var adapter = new STbQuasiDeterminizationAdapter<FUNC, TERM, SORT>(stb1);
            QuasiDeterminize(adapter);
            return adapter.stb;
        }
        
        private static void QuasiDeterminize<FUNC, TERM, SORT>(IQuasiDeterminizable<FUNC, TERM, SORT> target)
        {
            var dirty = new Stack<int>(target.States);

            while (dirty.Count > 0)
            {
                var state = dirty.Pop();
                var newDirty = target.MoveYields(state);
                foreach (var dirtyState in newDirty) dirty.Push(dirtyState);
            }
        }
    }
    
    interface IQuasiDeterminizable<FUNC, TERM, SORT>
    {
        IEnumerable<int> States { get; }

        /// <summary>
        /// Moves as many yields from outgoing transitions to incoming transitions as possible.
        /// </summary>
        /// <param name="state">The target state.</param>
        /// <returns>The states that have been modified in addition to the target state.</returns>
        IEnumerable<int> MoveYields(int state);
    }

    internal class STbQuasiDeterminizationAdapter<FUNC, TERM, SORT> : IQuasiDeterminizable<FUNC, TERM, SORT>
    {
        public STbQuasiDeterminizationAdapter(STb<FUNC, TERM, SORT> stb)
        {
            this.stb = stb;
            sourceStates = new Dictionary<int, HashSet<int>>();
            foreach (var state in stb.States)
            {
                ApplyToBaseRules(stb.GetRuleFrom(state), (rule) =>
                {
                    HashSet<int> sourceStateSet;
                    if (!sourceStates.TryGetValue(rule.State, out sourceStateSet))
                    {
                        sourceStateSet = new HashSet<int>();
                        sourceStates.Add(rule.State, sourceStateSet);
                    }
                    sourceStateSet.Add(state);
                });
            }
        }

        public STb<FUNC, TERM, SORT> stb { get; private set; }
        public IEnumerable<int> States { get { return stb.States; } }
        Dictionary<int, HashSet<int>> sourceStates { get; set; }

        public IEnumerable<int> MoveYields(int state)
        {
            if (stb.InitialState == state)
                return Enumerable.Empty<int>();

            var solver = stb.Solver;

            stb.GetRuleFrom(state);
            List<TERM> yieldsToMove = null;
            Action<BaseRule<TERM>> checkEquivalence = (rule) =>
            {
                if (null == yieldsToMove)
                {
                    yieldsToMove = new List<TERM>();
                    foreach (var yield in rule.Yields)
                    {
                        var substituted = solver.ApplySubstitution(yield, stb.InputVar, solver.MkVar(2, stb.InputSort));
                        if (solver.IsSatisfiable(solver.MkNeq(yield, substituted)))
                        {
                            break;
                        }
                        else
                        {
                            var inputRemoved = solver.ApplySubstitution(yield, stb.InputVar,
                                solver.MainSolver.FindAllMembers(solver.MkEq(stb.InputVar, stb.InputVar)).First().Value);
                            yieldsToMove.Add(inputRemoved);
                        }
                    }
                }
                else
                {
                    var yields = rule.Yields;
                    for (int i = 0; i < yieldsToMove.Count; ++i)
                    {
                        if (i >= yields.Length || !solver.AreEquivalent(yields[i], yieldsToMove[i]))
                        {
                            yieldsToMove.RemoveRange(i, yieldsToMove.Count - i);
                        }
                    }
                }
            };

            ApplyToBaseRules(stb.GetRuleFrom(state), checkEquivalence);
            ApplyToBaseRules(stb.GetFinalRuleFrom(state), checkEquivalence);

            if (null == yieldsToMove || yieldsToMove.Count == 0)
                return Enumerable.Empty<int>();

            Func<BaseRule<TERM>, BaseRule<TERM>> removePrefixUpdate = (rule) =>
                new BaseRule<TERM>(new Sequence<TERM>(rule.Yields.Skip(yieldsToMove.Count)), rule.Register, rule.State);

            stb.AssignRule(state, UpdateBaseRules(stb.GetRuleFrom(state), removePrefixUpdate));
            stb.AssignFinalRule(state, UpdateBaseRules(stb.GetFinalRuleFrom(state), removePrefixUpdate));

            Func<BaseRule<TERM>, BaseRule<TERM>> addPostfixUpdate = (rule) =>
            {
                if (rule.State == state)
                    return new BaseRule<TERM>(new Sequence<TERM>(
                        rule.Yields.Concat(yieldsToMove.Select(x => solver.ApplySubstitution(x, stb.RegVar, rule.Register)))),
                        rule.Register, rule.State);
                else
                    return rule;
            };

            foreach (var sourceState in sourceStates[state])
            {
                stb.AssignRule(sourceState, UpdateBaseRules(stb.GetRuleFrom(sourceState), addPostfixUpdate));
            }

            return sourceStates[state];
        }

        private void ApplyToBaseRules(STbRule<TERM> rule, Action<BaseRule<TERM>> action)
        {
            switch (rule.RuleKind)
            {
                case STbRuleKind.Undef:
                    break; // Ignore. If we're going to reject then any extra input won't matter.
                case STbRuleKind.Base:
                    action((BaseRule<TERM>)rule);
                    break;
                case STbRuleKind.Ite:
                    var iteRule = (IteRule<TERM>)rule;
                    ApplyToBaseRules(iteRule.TrueCase, action);
                    ApplyToBaseRules(iteRule.FalseCase, action);
                    break;
                case STbRuleKind.Switch:
                    throw new AutomataException("SwitchRules are not supported");
            }
        }

        private STbRule<TERM> UpdateBaseRules(STbRule<TERM> rule, Func<BaseRule<TERM>, BaseRule<TERM>> update)
        {
            switch (rule.RuleKind)
            {
                case STbRuleKind.Undef:
                    return rule;
                case STbRuleKind.Base:
                    return update((BaseRule<TERM>)rule);
                case STbRuleKind.Ite:
                    var iteRule = (IteRule<TERM>)rule;
                    var trueCase = UpdateBaseRules(iteRule.TrueCase, update);
                    var falseCase = UpdateBaseRules(iteRule.FalseCase, update);
                    if (trueCase != iteRule.TrueCase || falseCase != iteRule.FalseCase)
                        return new IteRule<TERM>(iteRule.Condition, trueCase, falseCase);
                    else
                        return rule;
                default:
                    throw new AutomataException($"Unsupported rule type");
            }
        }
    }
}
