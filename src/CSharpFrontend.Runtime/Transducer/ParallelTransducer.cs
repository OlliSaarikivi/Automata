using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime.Transducer
{
    public class Implementation<TIn, TOut, State>
    {
        public Func<TIn, TotalComputation<State, State>, IComputation<State, State>> Move { get; private set; }
        public Func<TIn, TotalComputation<State, State>, IComputation<State, State>> SilentMove { get; private set; }
        public Func<TotalComputation<State, State>, IComputation<State, State>> Finish { get; private set; }
        public Func<TotalComputation<State, State>, IComputation<State, State>> SilentFinish { get; private set; }
        public Func<TotalComputation<State, State>, IComputation<State, State>> ClearOutput { get; private set; }
        public Func<State, IEnumerable<TOut>> ProjectOutput { get; private set; }
        public State InitialState { get; private set; }

        public Implementation(Func<TIn, TotalComputation<State, State>, IComputation<State, State>> move, Func<TIn, TotalComputation<State, State>, IComputation<State, State>> silentMove,
            Func<TotalComputation<State, State>, IComputation<State, State>> finish, Func<TotalComputation<State, State>, IComputation<State, State>> silentFinish,
            Func<TotalComputation<State, State>, IComputation<State, State>> clearOutput, Func<State, IEnumerable<TOut>> projectOutput, State initialState)
        {
            Move = move;
            SilentMove = silentMove;
            Finish = finish;
            SilentFinish = silentFinish;
            ClearOutput = clearOutput;
            ProjectOutput = projectOutput;
            InitialState = initialState;
        }
    }

    public abstract class Transducer<TIn, TOut>
    {
        public abstract IEnumerable<TOut> Update(TIn datum);
        public virtual IEnumerable<TOut> Finish() { yield break; }
    }

    public abstract class Composition<TInner, TOuter>
    {
    }

    public abstract class SpecialTransducer { }
}
