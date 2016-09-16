using Microsoft.Automata.CSharpFrontend;
using Microsoft.Automata.Z3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimizationBenchmark
{
    class Program
    {

        static void Benchmark(string name, string source)
        {
            var ctx = new Z3Provider();
            var watch = Stopwatch.StartNew();
            var transducers = CSharpParser.FromString(ctx, source, false).ToList();
            var top = transducers[transducers.Count - 1];
            var min = top.Minimize();
            Console.WriteLine($"{name}: {watch.Elapsed.TotalSeconds} seconds");
            Console.WriteLine($"{top.Name}: removed {top.StateCount - min.StateCount} remaining {min.StateCount}");
        }

        static void Main(string[] args)
        {
            Benchmark(nameof(Transducers.Huffman), Transducers.Huffman);
            Benchmark(nameof(Transducers.Base64_delta), Transducers.Base64_delta);
            Benchmark(nameof(Transducers.CSV_max), Transducers.CSV_max);
            Benchmark(nameof(Transducers.Base64_avg), Transducers.Base64_avg);
            Benchmark(nameof(Transducers.UTF8_lines), Transducers.UTF8_lines);
            Benchmark(nameof(Transducers.CC_id), Transducers.CC_id);
            Benchmark(nameof(Transducers.CHSI_cancer), Transducers.CHSI_cancer);
            Benchmark(nameof(Transducers.CHSI_births), Transducers.CHSI_births);
            Benchmark(nameof(Transducers.CHSI_deaths), Transducers.CHSI_deaths);
            Benchmark(nameof(Transducers.SBO_employees), Transducers.SBO_employees);
            Benchmark(nameof(Transducers.SBO_receipts), Transducers.SBO_receipts);
            Benchmark(nameof(Transducers.SBO_payroll), Transducers.SBO_payroll);
            Benchmark(nameof(Transducers.TPC_DI_SQL), Transducers.TPC_DI_SQL);
            Benchmark(nameof(Transducers.PIR_proteins), Transducers.PIR_proteins);
            Benchmark(nameof(Transducers.DBLP_oldest), Transducers.DBLP_oldest);
            Benchmark(nameof(Transducers.MONDIAL_pop), Transducers.MONDIAL_pop);

            var line = Console.ReadLine();
        }
    }
}
