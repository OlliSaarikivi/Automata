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
        public void Add(string name, double value) => Add(name, value.ToString());
        public void Add(string name, int value) => Add(name, value.ToString());

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
        int count = 0;
        double sum = 0;

        public HotAverage(Stats stats, string name) : base(stats, name)
        {
        }

        public void Add(double value)
        {
            if (count > 0)
                sum += value;
            count += 1;
        }

        public override string ToString()
        {
            return (sum / (count - 1)).ToString();
        }
    }

    class Exact : Stat
    {
        int? value;

        public Exact(Stats stats, string name) : base(stats, name)
        {
        }

        public void Add(int newValue)
        {
            if (value != null)
            {
                Debug.Assert(newValue == value);
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

                    using (var ncaSize = new Exact(stats, "|NCA|"))
                    using (var srToNCA = new HotAverage(stats, "SR->NCA (milliseconds)"))
                    using (var regexToSR = new HotAverage(stats, "regex->SR (milliseconds)"))
                        for (int i = 0; i <= SAMPLES; ++i)
                        {
                            sw.Restart();
                            var sr = ((SymbolicRegex<ulong>)new Regex(regex, RegexOptions.Singleline).Compile(true, false)).Pattern;
                            regexToSR.Add(sw.Elapsed.TotalMilliseconds);

                            sw.Restart();
                            var nca = sr.Explore();
                            srToNCA.Add(sw.Elapsed.TotalMilliseconds);

                            // TODO: add NCA->DCA benchmark

                            ncaSize.Add(nca.StateCount);
                            // TODO: add number of counters in DCA form
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

                    using (var minSize = new HotAverage(stats, "|min|"))
                    using (var dfaSize = new HotAverage(stats, "|DFA|"))
                    using (var nfaSize = new HotAverage(stats, "|NFA|"))
                    using (var dfaToMin = new HotAverage(stats, "DFA->min (milliseconds)"))
                    using (var nfaToDfa = new HotAverage(stats, "NFA->DFA (milliseconds)"))
                    using (var regexToNfa = new HotAverage(stats, "regex->NFA (milliseconds)"))
                        for (int i = 0; i <= SAMPLES; ++i)
                        {
                            sw.Restart();
                            var nfa = regexConverter.Convert(regex);
                            regexToNfa.Add(sw.Elapsed.TotalMilliseconds);

                            sw.Restart();
                            var dfa = nfa.Determinize();
                            nfaToDfa.Add(sw.Elapsed.TotalMilliseconds);

                            sw.Restart();
                            var min = dfa.Minimize();
                            dfaToMin.Add(sw.Elapsed.TotalMilliseconds);

                            nfaSize.Add(nfa.StateCount);
                            dfaSize.Add(dfa.StateCount);
                            minSize.Add(min.StateCount);
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

            return filtered.ToArray();
        }

        static void BenchmarkFile(string path)
        {
            var regexes = ReadRegexes(path).ToArray();
            var filtered = FilterRegexes(regexes);
            var filenameNoExtension = Path.GetFileNameWithoutExtension(path);
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
            var stats = Benchmark(filtered,
                runOur: !filenameNoExtension.Contains("NoCadet"),
                runClassical: !filenameNoExtension.Contains("NoClassical"));
            var outPath = $"{Path.GetFileNameWithoutExtension(path)}-results-{Guid.NewGuid()}.txt";
            stats.WriteTSV(outPath);
        }

        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.Error.WriteLine("Usage: CounterAutomataBench.exe <path-to-regexes-file>");
                System.Environment.Exit(1);
            }
            BenchmarkFile(args[0]);
        }
    }
}
