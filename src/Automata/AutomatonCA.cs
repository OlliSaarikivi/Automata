using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Microsoft.Automata
{
    public class AutomatonCA<T> : IAutomaton<T>
    {
        private Dictionary<int, List<Move<T>>> delta;
        private int initialState;
        private HashSet<int> finalStateSet;
        private List<int> states;
        // set of states
        Dictionary<int, string> nodes = new Dictionary<int, string>();
        Dictionary<int, string> edges = new Dictionary<int, string>();
        private IBooleanAlgebra<T> algebra;

        /// <summary>
        /// Solver for labels
        /// </summary>
        public IBooleanAlgebra<T> Algebra
        {
            get
            {
                return algebra;
            }
        }

        int IAutomaton<T>.InitialState
        {
            get
            {
                return 0;
            }
        }

        string IAutomaton<T>.DescribeLabel(T lab)
        {
            return "";
        }


        string IAutomaton<T>.DescribeStartLabel()
        {
            return "";
        }

        string IAutomaton<T>.DescribeState(int state)
        {
            return nodes[state];
        }

        //string IAutomaton<T>.DescribeEdge(int index)
        //{
        //    return edges[index];
        //}

        IEnumerable<Move<T>> IAutomaton<T>.GetMoves()
        {
            foreach (int state in states)
                foreach (Move<T> move in delta[state])
                    yield return move;
        }

        IEnumerable<int> IAutomaton<T>.GetStates()
        {
            return nodes.Keys;
        }

        bool IAutomaton<T>.IsFinalState(int state)
        {
            if (finalStateSet.Contains(state))
                return true;
            return false;
        }

        public int StateCount { get { return nodes.Count; } }


        /// <summary>
        /// Create a symbolic automaton.
        /// </summary>
        /// <param name="initialState">initial state</param>
        /// <param name="finalStates">final states</param>
        /// <param name="moves">moves</param>
        /// <returns></returns>
        public static AutomatonCA<T> Create(IBooleanAlgebra<T> algebra, int initialState, IEnumerable<int> finalStates, IEnumerable<Move<T>> moves, List<int> states, Dictionary<int, string> nodes, Dictionary<int, string> edges, Dictionary<int, string> mapFinalGuards)
        {
            var delta = new Dictionary<int, List<Move<T>>>();
            delta[initialState] = new List<Move<T>>();

            foreach (Move<T> move in moves)
            {
                if (!delta.ContainsKey(move.SourceState))
                    delta[move.SourceState] = new List<Move<T>>();
                if (!delta.ContainsKey(move.TargetState))
                    delta[move.TargetState] = new List<Move<T>>();
                delta[move.SourceState].Add(move);
            }
            HashSet<int> finalStateSet = new HashSet<int>(finalStates);
            finalStateSet.RemoveWhere(x => !delta.ContainsKey(x)); //remove irrelevant states          

            AutomatonCA<T> fsa = new AutomatonCA<T>();
            fsa.algebra = algebra;
            fsa.initialState = initialState;
            fsa.finalStateSet = finalStateSet;
            fsa.delta = delta;
            fsa.states = states;
            fsa.nodes = nodes.Values.Select((x, i) => new { x, i }).ToDictionary(a => a.i, a => a.x);
            for (int i = 0; i < fsa.nodes.Count(); i++)
            {
                if (fsa.finalStateSet.Contains(i))
                {
                    fsa.nodes[i] += "|" + Regex.Replace(mapFinalGuards[i], "<", "&lt;");
                }
            }
            fsa.edges = edges;
            return fsa;
        }

        public void ShowGraph(string name = "Automaton")
        {
            CharSetSolver css = this.algebra as CharSetSolver;
            if (css != null)
                css.ShowGraph(this as Automaton<BDD>, name);
            else
            {
                var pp = algebra as IPrettyPrinter<T>;
                if (pp != null)
                    DirectedGraphs.DgmlWriter.ShowGraph<T>(-1, this, name, pp.PrettyPrint);
                else
                    DirectedGraphs.DgmlWriter.ShowGraph<T>(-1, this, name);
            }
        }

        public string DescribeEdges(int state)
        {
            throw new NotImplementedException();
        }
    }
}
