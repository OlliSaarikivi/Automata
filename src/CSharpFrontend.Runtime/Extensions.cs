using Microsoft.Automata.CSharpFrontend.Runtime.Transducer;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime
{
    public static class Extensions
    {

        //public static IQueryable<R> MapReduce<S, M, K, R>(
        //    this IQueryable<S> source,
        //    Expression<Func<S, IEnumerable<M>>> mapper,
        //    Expression<Func<M, K>> keySelector,
        //    Expression<Func<K, IEnumerable<M>, R>> reducer)
        //{
        //    return source.SelectMany(mapper).GroupBy(keySelector, reducer);
        //}

        public static IEnumerable<ReducerOutput> MapReduce<Input, MapperOutput, Key, ReducerOutput>(
            this IEnumerable<Input> source,
            Func<Input, IEnumerable<MapperOutput>> mapper,
            Func<MapperOutput, Key> keySelector,
            Func<Key, IEnumerable<MapperOutput>, ReducerOutput> reducer)
        {
            return source.SelectMany(mapper).GroupBy(keySelector, reducer);
        }

        public static IEnumerable<Output> Map<Input, Register, Output>(
            // source input
            this IEnumerable<Input> source,
            // a program that computes an intermediate state (register) and potentially an output (if defined)
            Func<Input, Register, Plute<Register, Output>> program,
            // the initial starting state of the program
            Register init)
            where Register : ISymbolic<Register>, new()
            where Output : ISymbolic<Output>, new()
        {
            // add initial state
            var states = new Powerset<Input, Register>(init);
            // fall through to symbolic case
            return source.Map(program, states);
        }

        public static IEnumerable<Output> Map<Input, Register, Output>(
            // source input
            this IEnumerable<Input> source,
            // a program that computes an intermediate state (register) and potentially an output (if defined)
            Func<Input, Register, Plute<Register, Output>> program,
            // the initial starting state of the program
            Powerset<Input, Register> states)
            where Register : ISymbolic<Register>, new()
            where Output : ISymbolic<Output>, new()
        {
            // for each input in the source enumerable
            foreach (var i in source)
            {
                // build next set of states
                var next = new Powerset<Input, Register>(new HashSet<ISet<Register>>());

                // for each state
                foreach (var state in states)
                {
                    // run the program on this input and register
                    // to produce a single output
                    var result = program(i, state);
                    // if that output is defined then the program
                    // wants to yield that output
                    if (result.Item2.IsDefined())
                    {
                        yield return result.Item2;
                    }

                    // add the result to next
                    next.Insert(result.Item1);
                }

                // update current set of states
                states = next;
            }
            yield break;
        }


        //public static IEnumerable<Output> PMap<Input, State, Output>(
        //    // source input
        //    this Input[] source,
        //    // a program that computes an intermediate state (register) and potentially an output (if defined)
        //    Implementation<Input, Output, State> transducer)
        //{
        //    // Compose computations for batches (parallel)
        //    var rangePartitioner = Partitioner.Create(0, source.Length);
        //    var partitions = rangePartitioner.GetOrderableDynamicPartitions().ToArray();
        //    var comps = new IComputation<State, State>[partitions.Length];
        //    partitions.AsParallel().ForAll(x =>
        //    {
        //        var simplifier = new OnlineContextualSimplifier<State>();

        //        var compIndex = x.Key;
        //        var range = x.Value;
        //        IComputation<State, State> batchCurrent = Identity<State>.Instance;
        //        for (int i = range.Item1; i < range.Item2; ++i)
        //        {
        //            batchCurrent = batchCurrent.ComposeAndSimplify(comp => transducer.Move(source[i], comp));
        //            batchCurrent = batchCurrent.ComposeAndSimplify(transducer.ClearOutput);
        //        }
        //        comps[compIndex] = batchCurrent;
        //    });

        //    // Propagate initial state through the batch computations to get batch starting states (sequential)
        //    var batchInitialStates = new State[partitions.Length];
        //    batchInitialStates[0] = transducer.InitialState;
        //    for (int i = 1; i < batchInitialStates.Length; ++i)
        //    {
        //        if (!comps[i - 1].Apply(batchInitialStates[i - 1], out batchInitialStates[i]))
        //        {
        //            throw new Exception();
        //        }
        //    }

        //    // Calculate output for each batch (parallel)
        //    var outputs = new IEnumerable<Output>[partitions.Length];
        //    partitions.AsParallel().ForAll(x =>
        //    {
        //        var simplifier = new OnlineContextualSimplifier<State>();

        //        var compIndex = x.Key;
        //        var range = x.Value;
        //        State latestState = batchInitialStates[compIndex];
        //        var output = new List<Output>();
        //        for (int i = range.Item1; i < range.Item2; ++i)
        //        {
        //            var step = InstructionSet<State>.Constant(latestState).ComposeAndSimplify(comp => transducer.Move(source[i], comp));
        //            State outputState;
        //            if (!step.Apply(latestState, out outputState))
        //            {
        //                throw new Exception();
        //            }
        //            output.AddRange(transducer.ProjectOutput(outputState));
        //            step = step.ComposeAndSimplify(transducer.ClearOutput);
        //            if (!step.Apply(latestState, out latestState))
        //            {
        //                throw new Exception();
        //            }
        //        }
        //        outputs[compIndex] = output;
        //    });

        //    // Concatenate the outputs (sequential)
        //    return outputs.Aggregate(Enumerable.Empty<Output>(), (a, b) => a.Concat(b));
        //}

        public static IEnumerable<Output> Map<Input, State, Output>(this IEnumerable<Input> source, Implementation<Input, Output, State> transducer)
        {
            IComputation<State, State> current = new ContextualSimplificationBoundary<State>(new Constant<State, State>(transducer.InitialState), new Context<State>());

            var cache = new Dictionary<Input, IComputation<State, State>>();

            foreach (var input in source)
            {
                current = current.ComposeAndSimplify(comp => transducer.Move(input, comp));
                State state;
                if (!current.Apply(default(State), out state))
                {
                    throw new Exception();
                }
                foreach (var output in transducer.ProjectOutput(state))
                {
                    yield return output;
                }
                current = current.ComposeAndSimplify(transducer.ClearOutput);
            }

            current = current.ComposeAndSimplify(transducer.Finish);
            State endState;
            if (!current.Apply(default(State), out endState))
            {
                throw new Exception();
            }
            foreach (var output in transducer.ProjectOutput(endState))
            {
                yield return output;
            }
        }


        public static IEnumerable<Output> SymbolicMap<Input, State, Output>(this IEnumerable<Input> source, Implementation<Input, Output, State> transducer)
        {
            IComputation<State, State> current = new ContextualSimplificationBoundary<State>(Identity<State>.Instance, new Context<State>());

            foreach (var input in source)
            {
                current = current.ComposeAndSimplify(comp => transducer.Move(input, comp));
                State outputState;
                if (!current.Apply(transducer.InitialState, out outputState))
                {
                    throw new Exception();
                }
                foreach (var output in transducer.ProjectOutput(outputState))
                {
                    yield return output;
                }
                current = current.ComposeAndSimplify(transducer.ClearOutput);
            }

            {
                current = current.ComposeAndSimplify(transducer.Finish);
                State outputState;
                if (!current.Apply(transducer.InitialState, out outputState))
                {
                    throw new Exception();
                }
                foreach (var output in transducer.ProjectOutput(outputState))
                {
                    yield return output;
                }
            }
        }

        
        public static IEnumerable<Output> Transduce<Input, State, Output>(this IEnumerable<Input> source, Implementation<Input, Output, State> transducer, IComputation<State, State> summary)
        {
            State endState;
            if (!summary.Apply(transducer.InitialState, out endState))
            {
                throw new Exception();
            }
            foreach (var output in transducer.ProjectOutput(endState))
            {
                yield return output;
            }
        }


        public static IComputation<State, State> GetSummary<Input, State, Output>(this IEnumerable<Input> source, Implementation<Input, Output, State> transducer)
        {
            IComputation<State, State> current = new ContextualSimplificationBoundary<State>(Identity<State>.Instance, new Context<State>());
            foreach (var input in source)
            {
                current = current.ComposeAndSimplify(comp => transducer.Move(input, comp));
            }
            current = current.ComposeAndSimplify(transducer.Finish);
            // Strip the contextual simplification helper nodes
            current = current.Accept(new SimplificationBoundaryStripper<State>());
            return current;
        }


        public static IComputation<State, State> GetSilentSummary<Input, State, Output>(this IEnumerable<Input> source, Implementation<Input, Output, State> transducer)
        {
            IComputation<State, State> current = new ContextualSimplificationBoundary<State>(Identity<State>.Instance, new Context<State>());
            foreach (var input in source)
            {
                current = current.ComposeAndSimplify(comp => transducer.SilentMove(input, comp));
            }
            current = current.ComposeAndSimplify(transducer.SilentFinish);
            // Strip the contextual simplification helper nodes
            current = current.Accept(new SimplificationBoundaryStripper<State>());
            return current;
        }


        public static IEnumerable<Output> ParallelTransduce<Input, State, Output>(this Input[] source, Implementation<Input, Output, State> transducer)
        {
            // Compose computations for batches (parallel)
            var rangePartitioner = Partitioner.Create(0, source.Length);
            var partitions = rangePartitioner.GetOrderableDynamicPartitions().ToArray();
            var comps = new IComputation<State, State>[partitions.Length];
            partitions.AsParallel().ForAll(x =>
            {
                var compIndex = x.Key;
                var range = x.Value;
                IComputation<State, State> batchCurrent = new ContextualSimplificationBoundary<State>(Identity<State>.Instance, new Context<State>());
                for (int i = range.Item1; i < range.Item2; ++i)
                {
                    batchCurrent = batchCurrent.ComposeAndSimplify(comp => transducer.SilentMove(source[i], comp));
                }
                comps[compIndex] = batchCurrent;
            });

            // Propagate initial state through the batch computations to get batch starting states (sequential)
            var batchInitialStates = new State[partitions.Length];
            batchInitialStates[0] = transducer.InitialState;
            for (int i = 1; i < batchInitialStates.Length; ++i)
            {
                if (!comps[i - 1].Apply(batchInitialStates[i - 1], out batchInitialStates[i]))
                {
                    throw new Exception();
                }
            }

            // Calculate output for each batch (parallel)
            var outputs = new IEnumerable<Output>[partitions.Length];
            partitions.AsParallel().ForAll(x =>
            {
                var compIndex = x.Key;
                var range = x.Value;
                State latestState = batchInitialStates[compIndex];
                IComputation<State, State> batchCurrent = new ContextualSimplificationBoundary<State>(InstructionSet<State>.Constant(latestState), new Context<State>());
                var output = new List<Output>();
                for (int i = range.Item1; i < range.Item2; ++i)
                {
                    batchCurrent = batchCurrent.ComposeAndSimplify(comp => transducer.Move(source[i], comp));
                    State outputState;
                    if (!batchCurrent.Apply(latestState, out outputState))
                    {
                        throw new Exception();
                    }
                    output.AddRange(transducer.ProjectOutput(outputState));
                    batchCurrent = batchCurrent.ComposeAndSimplify(transducer.ClearOutput);
                }
                outputs[compIndex] = output;
            });

            // Concatenate the outputs (sequential)
            return outputs.Aggregate(Enumerable.Empty<Output>(), (a, b) => a.Concat(b));
        }


        public static IComputation<State, State>[] ParallelSummary<Input, State, Output>(this Input[] source, Implementation<Input, Output, State> transducer)
        {
            // Compose computations for batches (parallel)
            var rangePartitioner = Partitioner.Create(0, source.Length);
            var partitions = rangePartitioner.GetOrderableDynamicPartitions().ToArray();
            var comps = new IComputation<State, State>[partitions.Length];
            partitions.AsParallel().ForAll(x =>
            {
                var compIndex = x.Key;
                var range = x.Value;
                IComputation<State, State> batchCurrent = new ContextualSimplificationBoundary<State>(Identity<State>.Instance, new Context<State>());
                for (int i = range.Item1; i < range.Item2; ++i)
                {
                    batchCurrent = batchCurrent.ComposeAndSimplify(comp => transducer.Move(source[i], comp));
                }
                batchCurrent = batchCurrent.Accept(new SimplificationBoundaryStripper<State>());
                comps[compIndex] = batchCurrent;
            });

            return comps;
        }


        public static IComputation<State, State>[] ParallelSilentSummary<Input, State, Output>(this Input[] source, Implementation<Input, Output, State> transducer)
        {
            // Compose computations for batches (parallel)
            var rangePartitioner = Partitioner.Create(0, source.Length);
            var partitions = rangePartitioner.GetOrderableDynamicPartitions().ToArray();
            var comps = new IComputation<State, State>[partitions.Length];
            partitions.AsParallel().ForAll(x =>
            {
                var compIndex = x.Key;
                var range = x.Value;
                IComputation<State, State> batchCurrent = new ContextualSimplificationBoundary<State>(Identity<State>.Instance, new Context<State>());
                for (int i = range.Item1; i < range.Item2; ++i)
                {
                    batchCurrent = batchCurrent.ComposeAndSimplify(comp => transducer.SilentMove(source[i], comp));
                }
                batchCurrent = batchCurrent.Accept(new SimplificationBoundaryStripper<State>());
                comps[compIndex] = batchCurrent;
            });

            return comps;
        }


        public static IEnumerable<State> Propagate<Input, State, Output>(this IEnumerable<IComputation<State, State>> source, Implementation<Input, Output, State> transducer)
        {
            // Propagate initial state through the batch computations to get batch starting states (sequential)
            State current = transducer.InitialState;
            return source.Select(x =>
            {
                State previous = current;
                x.Apply(previous, out current);
                return previous;
            });
        }


        // Run the EFSM on the input
        public static IEnumerable<Tuple<int, Register>> Transduce<Input, Register>(
            this IEnumerable<Input> source,
            EFSM<Input, Register> r,
            Register symbolicinit,
            Register concreteinit) where Register : ISemiring<Register>, new()
        {
            var loc = 0;
            var one = EFSM<Input, Register>.One;
            var zero = EFSM<Input, Register>.Zero;
            Register output;
            var re = r;
            foreach (var i in source)
            {
                // If this is the first input, shift in a symbolic mark
                // as we do not know how the EFSM was marked before this 
                // input character
                if (loc == 0)
                    re = re.Shift(symbolicinit, i, loc);
                else // else, shift in the concrete "init" value
                    re = re.Shift(concreteinit, i, loc);
                output = re.IsMatchFinal();

                //Console.WriteLine(String.Format("{0}: {1}", loc, re));

                // if the final state ever has a register which is
                // nonzero, yield that output and the current position.
                if (!EqualityComparer<Register>.Default.Equals(output, zero))
                {
                    yield return Tuple.Create(loc, output);
                }

                // increment counter.
                loc++;
            }
        }

        internal static Register Single<Input, Register>(this IEnumerable<Input> source, EFSM<Input, Register> re) where Register : ISemiring<Register>, new()
        {

            var one = EFSM<Input, Register>.One;
            var zero = EFSM<Input, Register>.Zero;
            var first = true;
            var loc = 0;
            foreach (var i in source)
            {
                if (first)
                {
                    re = re.Shift(one, i, loc);
                    first = false;
                }
                else
                    re = re.Shift(zero, i, loc);
                var output = re.IsMatchFinal();
                if (!EqualityComparer<Register>.Default.Equals(output, zero))
                    return output;
                loc++;
            }

            // does re match empty string?
            if (first)
            {
                return re.IsMatchEmpty();
            }

            return re.IsMatchFinal();
        }
    }
}
