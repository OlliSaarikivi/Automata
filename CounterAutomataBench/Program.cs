using Microsoft.Automata;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CounterAutomataBench
{
    class Stats
    {
        List<string> header = new List<string>();
        Dictionary<string, List<string>> columns = new Dictionary<string, List<string>>();

        public void Add(string name, string value)
        {
            List<string> column;
            if (!columns.TryGetValue(name, out column))
            {
                header.Add(name);
                column = new List<string>();
                columns[name] = column;
            }
            column.Add(value);
        }

        public void Validate()
        {
            if (header.Count > 0)
            {
                Debug.Assert(columns.Count == header.Count);
                Debug.Assert(header.All(x => columns.ContainsKey(x)));
                Debug.Assert(columns.All(x => x.Value.Count == columns[header[0]].Count));
            }
        }

        public void WriteTSV(string path)
        {
            Validate();

            using (var fout = new StreamWriter(new FileStream(path, FileMode.CreateNew)))
            {
                Func<string, string, string> csvJoin = (l, r) => $"{l}\t{r}";

                fout.WriteLine(header.Aggregate(csvJoin));

                var rows = header.Select(x => columns[x]).Aggregate((c1, c2) => c1.Zip(c2, csvJoin).ToList());
                foreach (var row in rows)
                {
                    fout.WriteLine(row);
                }
            }
        }
    }

    class Stat : IDisposable
    {
        Stats stats;
        String name;

        public Stat(Stats stats, string name)
        {
            this.stats = stats;
            this.name = name;
        }

        public void Dispose()
        {
            stats.Add(name, this.ToString());
        }
    }

    class HotAverage : Stat
    {
        List<double> samples = new List<double>();

        public HotAverage(Stats stats, string name) : base(stats, name)
        {
        }

        public void Add(double value)
        {
            samples.Add(value);
        }

        public override string ToString()
        {
            double average = double.NaN;
            if (samples.Count == 1)
            {
                average = samples[0];
            }
            else if (samples.Count > 1)
            {
                average = (samples.Sum() - samples[0]) / (samples.Count - 1);
            }
            return average.ToString();
        }
    }

    class Message : Stat
    {
        string message = "";

        public Message(Stats stats, string name) : base(stats, name)
        {
        }

        public void Add(string newMessage)
        {
            message += newMessage.Replace("\r", "\\r").Replace("\n", "\\n").Replace("\t", "\\t");
        }

        public override string ToString()
        {
            return message;
        }
    }

    class Exact<T> : Stat where T : struct, IEquatable<T>
    {
        T? value;

        public Exact(Stats stats, string name) : base(stats, name)
        {
        }

        public void Add(T newValue)
        {
            if (value != null)
            {
                Debug.Assert(newValue.Equals(value.Value));
            }
            value = newValue;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }

    class Program
    {
        const int SAMPLES = 10;
        const int TIMEOUT = 60000;

        static IEnumerable<string> ReadRegexes(string path)
        {
            using (var fin = new StreamReader(new FileStream(path, FileMode.Open)))
            {
                string regex;
                while ((regex = fin.ReadLine()) != null)
                {
                    yield return regex;
                }
            }
        }
        static void WriteRegexes(string path, string[] regexes)
        {
            using (var fout = new StreamWriter(new FileStream(path, FileMode.Create)))
            {
                foreach (var regex in regexes)
                {
                    fout.WriteLine(regex);
                }
            }
        }

        static Stats Benchmark(string[] regexes, bool runOur = true, bool runClassical = true)
        {
            var stats = new Stats();

            foreach (var regex in regexes)
            {
                stats.Add("pattern", regex);
            }
            
            // Our pipeline
            if (runOur)
            {
                Console.WriteLine("Our pipeline");
                int count = 0;
                foreach (var regex in regexes)
                {
                    ++count;
                    Console.WriteLine($"{count}/{regexes.Length}");
                    Stopwatch sw = new Stopwatch();

                    using (var exception = new Message(stats, "Our exception"))
                    using (var dcaSize = new Exact<int>(stats, "|DCA|"))
                    using (var ncaSize = new Exact<int>(stats, "|NCA|"))
                    using (var ncaToDca = new HotAverage(stats, "NCA->DCA (milliseconds)"))
                    using (var srToNca = new HotAverage(stats, "SR->NCA (milliseconds)"))
                    using (var regexToSR = new HotAverage(stats, "regex->SR (milliseconds)"))
                    {
                        try
                        {
                            for (int i = 0; i <= SAMPLES; ++i)
                            {
                                sw.Restart();
                                var sr = ((SymbolicRegex<ulong>)new Regex(regex, RegexOptions.Singleline).Compile(true, false)).Pattern;
                                regexToSR.Add(sw.Elapsed.TotalMilliseconds);

                                sw.Restart();
                                var nca = sr.Explore();
                                srToNca.Add(sw.Elapsed.TotalMilliseconds);
                                ncaSize.Add(nca.StateCount);

                                sw.Restart();
                                var dca = nca.DeterminizeCA(TIMEOUT);
                                ncaToDca.Add(sw.Elapsed.TotalMilliseconds);
                                dcaSize.Add(dca.StateCount);
                                // TODO: add number of counters in DCA form
                            }
                        }
                        catch (Exception e)
                        {
                            exception.Add(e.ToString());
                            Console.WriteLine(e);
                        }
                    }
                }
            }

            // Classical pipeline
            if (runClassical)
            {
                Console.WriteLine("Classical pipeline");
                var solver = new CharSetSolver();
                var regexConverter = new RegexToAutomatonConverter<BDD>(solver);

                int count = 0;
                foreach (var regex in regexes)
                {
                    ++count;
                    Console.WriteLine($"{count}/{regexes.Length}");
                    Stopwatch sw = new Stopwatch();

                    using (var exception = new Message(stats, "Classical exception"))
                    using (var minSize = new Exact<int>(stats, "|min|"))
                    using (var dfaSize = new Exact<int>(stats, "|DFA|"))
                    using (var nfaSize = new Exact<int>(stats, "|NFA|"))
                    using (var dfaToMin = new HotAverage(stats, "DFA->min (milliseconds)"))
                    using (var nfaToDfa = new HotAverage(stats, "NFA->DFA (milliseconds)"))
                    using (var regexToNfa = new HotAverage(stats, "regex->NFA (milliseconds)"))
                    {
                        try
                        {
                            for (int i = 0; i <= SAMPLES; ++i)
                            {
                                sw.Restart();
                                var nfa = regexConverter.Convert(regex);
                                regexToNfa.Add(sw.Elapsed.TotalMilliseconds);
                                nfaSize.Add(nfa.StateCount);

                                sw.Restart();
                                var dfa = nfa.Determinize(TIMEOUT);
                                nfaToDfa.Add(sw.Elapsed.TotalMilliseconds);
                                dfaSize.Add(dfa.StateCount);

                                sw.Restart();
                                var min = dfa.Minimize(TIMEOUT);
                                dfaToMin.Add(sw.Elapsed.TotalMilliseconds);
                                minSize.Add(min.StateCount);
                            }
                        }
                        catch (Exception e)
                        {
                            exception.Add(e.ToString());
                            Console.WriteLine(e);
                        }
                    }
                }
            }

            return stats;
        }

        static string[] FilterRegexes(string[] regexes)
        {
            Predicate<SymbolicRegexNode<ulong>> isNonMonadic = node =>
            {
                return (node.kind == SymbolicRegexKind.Loop &&
                        node.left.kind != SymbolicRegexKind.Singleton &&
                        !node.IsStar &&
                        !node.IsMaybe &&
                        !node.IsPlus);
            };

            Predicate<SymbolicRegexNode<ulong>> isCountingLoop = node =>
            {
                return (node.kind == SymbolicRegexKind.Loop &&
                        !node.IsStar &&
                        !node.IsMaybe &&
                        !node.IsPlus);
            };

            var filtered = new List<string>();

            foreach (var regex in regexes)
            {
                try
                {
                    var sr = new Regex(regex, RegexOptions.Singleline);
                    SymbolicRegexUInt64 m = null;
                    string reasonwhynot;
                    if (sr.IsCompileSupported(out reasonwhynot))
                    {
                        m = sr.Compile(false, false) as SymbolicRegexUInt64;
                        if (m.Pattern.ExistsNode(isCountingLoop) && !m.Pattern.ExistsNode(isNonMonadic))
                        {
                            filtered.Add(regex);
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"While processing {regex}", e);
                }
            }

            return filtered.ToArray();
        }

        static void BenchmarkFile(string path, bool runOur, bool runClassical)
        {
            var regexes = ReadRegexes(path).ToArray();
            var filtered = FilterRegexes(regexes);
            var filenameNoExtension = Path.GetFileNameWithoutExtension(path);
            Console.WriteLine("Benchmarking from " + path);

            if (filtered.Length < regexes.Length)
            {
                Console.WriteLine($"{filtered.Length}/{regexes.Length} regexes passed filter.");
                var filteredPath = $"{filenameNoExtension}-filtered.txt";
                Console.WriteLine($"Writing filtered set to {Path.GetFullPath(filteredPath)}");
                WriteRegexes(filteredPath, filtered);
            }
            else
            {
                Console.WriteLine("All regexes passed filter.");
            }
            var stats = Benchmark(filtered, runOur, runClassical);
            var outPath = $"{Path.GetFileNameWithoutExtension(path)}-results-{Guid.NewGuid()}.txt";
            stats.WriteTSV(outPath);
            Console.WriteLine("Wrote results to " + Path.GetFullPath(outPath));
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Error.WriteLine("Usage: CounterAutomataBench.exe <regexes-file1> [<regexes-file2> ...]");
                System.Environment.Exit(1);
            }
            bool runOur = false;
            bool runClassical = false;
            while (true)
            {
                Console.WriteLine("Choose pipelines to run: us, classical, both");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "us":
                        runOur = true;
                        goto BENCHMARK;
                    case "classical":
                        runClassical = true;
                        goto BENCHMARK;
                    case "both":
                        runOur = true;
                        runClassical = true;
                        goto BENCHMARK;
                    default:
                        Console.WriteLine("Invalid choice: " + choice);
                        break;
                }
            }

            BENCHMARK: foreach (var arg in args)
            {
                BenchmarkFile(arg, runOur, runClassical);
            }
            Console.WriteLine("Benchmarks finished, press enter to exit.");
            Console.ReadLine();
        }
    }
}
