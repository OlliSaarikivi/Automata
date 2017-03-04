using Microsoft.Automata.CSharpFrontend;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Globalization;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{

    class Program
    {
        static readonly string ResultsDir = @"results\";
        const bool CheckResults = false;

        static long SerializedSize(object obj)
        {
            var bf = new BinaryFormatter();
            var stream = new MemoryStream();
            bf.Serialize(stream, obj);
            return stream.Length;
        }

        static string Col(string s, int pos)
        {
            if (s.Length < pos)
            {
                s += new string(' ', pos - s.Length);
            }
            return s;
        }

        static double Throughput(long dataLength, double seconds)
        {
            return (dataLength / seconds) / 1048576;
        }

        static double Mean(List<double> data)
        {
            return data.Sum() / data.Count;
        }

        static double StDev(List<double> data)
        {
            double sumSqError = 0;
            double average = Mean(data);
            foreach (var datum in data)
            {
                sumSqError += Math.Pow(datum - average, 2);
            }
            double variance = sumSqError / data.Count;
            return Math.Sqrt(variance);
        }

        static double ConfidenceInterval95(List<double> data)
        {
            if (data.Count == 0)
                return double.MaxValue;

            return 1.96 * (StDev(data) / Math.Sqrt(data.Count));
        }

        static void ValidateOutput(byte[] input, byte[] output, Action<byte[], Stream> specification)
        {
            if (!CheckResults)
                return;

            var validStream = new MemoryStream();
            specification(input, validStream);
            var validOutput = validStream.ToArray();

            if (validOutput.Length != output.Length)
            {
                Console.WriteLine("WARNING: results lengths do not match: " + output.Length + " but should be " + validOutput.Length);
                foreach (byte c in output)
                {
                    Console.Write((int)c);
                    Console.Write(' ');
                }
                Console.WriteLine();
                foreach (byte c in validOutput)
                {
                    Console.Write((int)c);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            else
            {
                for (int j = 0; j < validOutput.Length; ++j)
                {
                    if (output[j] != validOutput[j])
                    {
                        Console.WriteLine("WARNING: results differ at index " + j);
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                    }
                }
            }
        }

        static void IterateBenchmark(string name, Func<bool, double> benchmark)
        {
            Console.WriteLine("Benchmarking " + name);

            var throughputs = new List<double>();

            benchmark(true);

            while ((ConfidenceInterval95(throughputs) >= 0.5 || throughputs.Count < 30) && throughputs.Count < 10000)
            //while(true)
            {
                var sample = benchmark(false);
                throughputs.Add(sample);
                Console.WriteLine("Sample: " + sample + " N: " + throughputs.Count + " Mean: " + Mean(throughputs) + "±" + ConfidenceInterval95(throughputs) + " MB/s");
            }

            var path = ResultsDir + name + " " + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";

            Directory.CreateDirectory(ResultsDir);
            using (var writer = new StreamWriter(File.OpenWrite(path)))
            {
                writer.WriteLine("N: " + throughputs.Count + " Mean: " + Mean(throughputs) + "±" + ConfidenceInterval95(throughputs) + " MB/s");
                writer.WriteLine("Samples:");
                foreach (var result in throughputs)
                {
                    writer.WriteLine(result);
                }
            }

            Console.WriteLine();
        }

        static void BenchmarkStream(Func<byte[]> dataProvider, Action<Stream, Stream> function, string name, Action<byte[], Stream> specification = null)
        {
            IterateBenchmark(name, validate =>
            {
                var input = new MemoryStream(dataProvider());

                // Warm up the cache
                function(input, new MemoryStream());
                input.Seek(0, SeekOrigin.Begin);

                var output = new MemoryStream();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                function(input, output);
                sw.Stop();
                if (specification != null && validate)
                {
                    ValidateOutput(input.ToArray(), output.ToArray(), specification);
                }
                return Throughput(input.Length, sw.Elapsed.TotalSeconds);
            });
        }

        static void BenchmarkArray(Func<byte[]> dataProvider, Action<byte[], Stream> function, string name, Action<byte[], Stream> specification = null)
        {
            IterateBenchmark(name, validate =>
            {
                var input = dataProvider();

                // Warm up the cache
                function(input, new MemoryStream());

                var output = new MemoryStream();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                function(input, output);
                sw.Stop();
                if (specification != null && validate)
                {
                    ValidateOutput(input.ToArray(), output.ToArray(), specification);
                }
                return Throughput(input.Length, sw.Elapsed.TotalSeconds);
            });
        }

        static double QuickBenchmarkStream(Func<byte[]> dataProvider, Action<Stream, Stream> function)
        {
            var input = new MemoryStream(dataProvider());

            // Warm up the cache
            function(input, new MemoryStream());
            input.Seek(0, SeekOrigin.Begin);

            var output = new MemoryStream();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            function(input, output);
            sw.Stop();
            return Throughput(input.Length, sw.Elapsed.TotalSeconds);
        }

        static double QuickBenchmarkArray(Func<byte[]> dataProvider, Action<byte[], Stream> function)
        {
            var input = dataProvider();

            // Warm up the cache
            function(input, new MemoryStream());

            var output = new MemoryStream();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            function(input, output);
            sw.Stop();
            return Throughput(input.Length, sw.Elapsed.TotalSeconds);
        }

        static void Main(string[] args)
        {
            var datasetsDir = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + @"\..\..\datasets\";
            Func<byte[]> bookProvider = (() => DataProviders.RepeatedFile($"{datasetsDir}pg2701.txt"));
            Func<byte[]> ccProvider = (() => DataProviders.SingleFile($"{datasetsDir}Consumer_Complaints.csv"));
            Func<byte[]> birthDeathProvider = (() => DataProviders.SingleFile($"{datasetsDir}MEASURESOFBIRTHANDDEATH.csv"));
            Func<byte[]> sboProviderEvenSmaller = (() => DataProviders.SingleFile($"{datasetsDir}pums_even_smaller.csv"));
            Func<byte[]> tpcdiCustomers = (() => DataProviders.SingleFile($"{datasetsDir}TPCDICustomerMgmt.xml"));
            Func<byte[]> proteins = (() => DataProviders.SingleFile($"{datasetsDir}psd7003.xml"));
            Func<byte[]> dblp = (() => DataProviders.SingleFile($"{datasetsDir}dblp.xml"));
            Func<byte[]> mondial = (() => DataProviders.SingleFile($"{datasetsDir}mondial-3.0.xml"));

            Action<byte[], Stream> nullSpec = null;

            var streamBenchmarks = new List<Tuple<string, Func<byte[]>, Action<Stream, Stream>, Action<byte[], Stream>>>
            {
                //Tuple.Create("Huffman", (Func<byte[]>)DataProviders.GenerateEncodedCSV, (Action<Stream, Stream>)HuffmanToLCBytes.TransduceFromStreamToStream, nullSpec),
                //Tuple.Create("Fibonacci", (Func<byte[]>)DataProviders.RandomBytes, (Action<Stream, Stream>)SafeFibonacciBytes.TransduceFromStreamToStream, nullSpec),
                //Tuple.Create("HTML decode", htmlProvider, (Action<Stream, Stream>)ASCIIHTMLLCBytes.TransduceFromStreamToStream, nullSpec),

                Tuple.Create("Base64-delta (Fused)", (Func<byte[]>)DataProviders.Base64RandomInts,
                    (Action<Stream, Stream>)B64FormattedDeltaUTF8.TransduceFromStreamToStream, (Action<byte[], Stream>)ManualB64FormattedDeltaUTF8.HandOptimized),
                Tuple.Create("CSV-max (Fused)", (Func<byte[]>)DataProviders.Base64RandomInts,
                    (Action<Stream, Stream>)UTF8MaxCol3IntB64.TransduceFromStreamToStream, (Action<byte[], Stream>)ManuaUTF8MaxCol3IntB64.HandOptimized),
                Tuple.Create("Base64-avg (Fused)", (Func<byte[]>)DataProviders.Base64RandomInts,
                    (Action<Stream, Stream>)B64ToWindowedAverageToB64.TransduceFromStreamToStream, (Action<byte[], Stream>)ManualB64ToWindowedAverageToB64.HandOptimized),
                Tuple.Create("UTF8-lines (Fused)", bookProvider,
                    (Action<Stream, Stream>)FormattedLineCount.TransduceFromStreamToStream, (Action<byte[], Stream>)ManualUTF8ToFormattedLineCount.HandOptimized),
                Tuple.Create("CHSI-cancer (Fused)", birthDeathProvider, (Action<Stream, Stream>)CSV4abc.TransduceFromStreamToStream, (Action<byte[], Stream>)ManuaCSV4abc.GeneratedStages),
                Tuple.Create("CHSI-births (Fused)", birthDeathProvider, (Action<Stream, Stream>)CSV2abc.TransduceFromStreamToStream, (Action<byte[], Stream>)ManuaCSV2abc.GeneratedStages),
                Tuple.Create("CHSI-deaths (Fused)", birthDeathProvider, (Action<Stream, Stream>)CSV3abc.TransduceFromStreamToStream, (Action<byte[], Stream>)ManuaCSV3abc.GeneratedStages),
                Tuple.Create("SBO-employees (Fused)", sboProviderEvenSmaller, (Action<Stream, Stream>)CSV5abc.TransduceFromStreamToStream, (Action<byte[], Stream>)ManuaCSV5abc.GeneratedStages),
                Tuple.Create("SBO-receipts (Fused)", sboProviderEvenSmaller, (Action<Stream, Stream>)CSV7abc.TransduceFromStreamToStream, (Action<byte[], Stream>)ManuaCSV7abc.GeneratedStages),
                Tuple.Create("SBO-payroll (Fused)", sboProviderEvenSmaller, (Action<Stream, Stream>)CSV6abc.TransduceFromStreamToStream, (Action<byte[], Stream>)ManuaCSV6abc.GeneratedStages),
                Tuple.Create("CC-id (Fused)", ccProvider, (Action<Stream, Stream>)CSV1abc.TransduceFromStreamToStream, (Action<byte[], Stream>)ManuaCSV1abc.GeneratedStages),
                Tuple.Create("TPC-DI customers SQL (Fused)", tpcdiCustomers, (Action<Stream, Stream>)XML1abc.TransduceFromStreamToStream, (Action<byte[], Stream>)ManualXML1abc.GeneratedStages),
                Tuple.Create("PIR protein lengths average (Fused)", proteins, (Action<Stream, Stream>)XML2abc.TransduceFromStreamToStream, (Action<byte[], Stream>)ManualXML2.GeneratedStages),
                Tuple.Create("DBLP oldest article (Fused)", dblp, (Action<Stream, Stream>)XML3abc.TransduceFromStreamToStream, (Action<byte[], Stream>)ManualXML3.GeneratedStages),
                Tuple.Create("Mondial largest population (Fused)", mondial, (Action<Stream, Stream>)XML4abc.TransduceFromStreamToStream, (Action<byte[], Stream>)ManualXML4.GeneratedStages),

                Tuple.Create("Base64-delta (Method call)", (Func<byte[]>)DataProviders.Base64RandomInts,
                    (Action<Stream, Stream>)TransducerBenchmarks.HandFused.B64FormattedDeltaUTF8.Run, (Action<byte[], Stream>)ManualB64FormattedDeltaUTF8.HandOptimized),
                Tuple.Create("CSV-max (Method call)", (Func<byte[]>)DataProviders.Base64RandomInts,
                    (Action<Stream, Stream>)(NS_UTF8MaxCol3IntB64.Runner.Run), (Action<byte[], Stream>)ManuaUTF8MaxCol3IntB64.HandOptimized),
                Tuple.Create("Base64-avg (Method call)", (Func<byte[]>)DataProviders.Base64RandomInts,
                    (Action<Stream, Stream>)TransducerBenchmarks.HandFused.B64ToWindowedAverageToB64.Run, (Action<byte[], Stream>)ManualB64ToWindowedAverageToB64.HandOptimized),
                Tuple.Create("UTF8-lines (Method call)", bookProvider,
                    (Action<Stream, Stream>)TransducerBenchmarks.HandFused.FormattedLineCount.Run, (Action<byte[], Stream>)ManualUTF8ToFormattedLineCount.HandOptimized),
                Tuple.Create("CHSI-cancer (Method call)", birthDeathProvider, (Action<Stream, Stream>)(NS_CSV4abc.Runner.Run), (Action<byte[], Stream>)ManuaCSV4abc.GeneratedStages),
                Tuple.Create("CHSI-births (Method call)", birthDeathProvider, (Action<Stream, Stream>)(NS_CSV2abc.Runner.Run), (Action<byte[], Stream>)ManuaCSV2abc.GeneratedStages),
                Tuple.Create("CHSI total deaths maximum (Method call)", birthDeathProvider, (Action<Stream, Stream>)(NS_CSV3abc.Runner.Run), (Action<byte[], Stream>)ManuaCSV3abc.GeneratedStages),
                Tuple.Create("SBO-employees (Method call)", sboProviderEvenSmaller, (Action<Stream, Stream>)(NS_CSV5abc.Runner.Run), (Action<byte[], Stream>)ManuaCSV5abc.GeneratedStages),
                Tuple.Create("SBO-receipts (Method call)", sboProviderEvenSmaller, (Action<Stream, Stream>)(NS_CSV7abc.Runner.Run), (Action<byte[], Stream>)ManuaCSV7abc.GeneratedStages),
                Tuple.Create("SBO-payroll (Method call)", sboProviderEvenSmaller, (Action<Stream, Stream>)(NS_CSV6abc.Runner.Run), (Action<byte[], Stream>)ManuaCSV6abc.GeneratedStages),
                Tuple.Create("CC-id (Method call)", ccProvider, (Action<Stream, Stream>)(NS_CSV1abc.Runner.Run), (Action<byte[], Stream>)ManuaCSV1abc.GeneratedStages),
                Tuple.Create("TPC-DI customers SQL (Method call)", tpcdiCustomers, (Action<Stream, Stream>)(NS_XML1abc.Runner.Run), (Action<byte[], Stream>)ManualXML1abc.GeneratedStages),
                Tuple.Create("PIR protein lengths average (Method call)", proteins, (Action<Stream, Stream>)(NS_XML2abc.Runner.Run), (Action<byte[], Stream>)ManualXML2.GeneratedStages),
                Tuple.Create("DBLP oldest article (Method call)", dblp, (Action<Stream, Stream>)(NS_XML3abc.Runner.Run), (Action<byte[], Stream>)ManualXML3.GeneratedStages),
                Tuple.Create("Mondial largest population (Method call)", mondial, (Action<Stream, Stream>)(NS_XML4abc.Runner.Run), (Action<byte[], Stream>)ManualXML4.GeneratedStages),

                Tuple.Create("TPC-DI customers SQL (XPathReader)", tpcdiCustomers, (Action<Stream, Stream>)ManualXML1abc.XPathReaderVersion, (Action<byte[], Stream>)ManualXML1abc.GeneratedStages),
                Tuple.Create("PIR protein lengths average (XPathReader)", proteins, (Action<Stream, Stream>)ManualXML2.XPathReaderVersion, (Action<byte[], Stream>)ManualXML2.GeneratedStages),
                Tuple.Create("DBLP oldest article (XPathReader)", dblp, (Action<Stream, Stream>)ManualXML3.XPathReaderVersion, (Action<byte[], Stream>)ManualXML3.GeneratedStages),
                Tuple.Create("Mondial largest population (XPathReader)", mondial, (Action<Stream, Stream>)ManualXML4.XPathReaderVersion, (Action<byte[], Stream>)ManualXML4.GeneratedStages),
            };

            var arrayBenchmarks = new List<Tuple<string, Func<byte[]>, Action<byte[], Stream>, Action<byte[], Stream>>>
            {
                Tuple.Create("Base64-delta (Hand-written)", (Func<byte[]>)DataProviders.Base64RandomInts,
                    (Action<byte[], Stream>)ManualB64FormattedDeltaUTF8.HandOptimized, (Action<byte[], Stream>)ManualB64FormattedDeltaUTF8.GeneratedStages),
                Tuple.Create("CSV-max (Hand-written)", (Func<byte[]>)DataProviders.Base64RandomInts,
                    (Action<byte[], Stream>)ManuaUTF8MaxCol3IntB64.HandOptimized, (Action<byte[], Stream>)ManuaUTF8MaxCol3IntB64.GeneratedStages),
                Tuple.Create("Base64-avg (Hand-written)", (Func<byte[]>)DataProviders.Base64RandomInts,
                    (Action<byte[], Stream>)ManualB64ToWindowedAverageToB64.HandOptimized, (Action<byte[], Stream>)ManualB64ToWindowedAverageToB64.GeneratedStages),
                Tuple.Create("UTF8-lines (Hand-written)", bookProvider,
                    (Action<byte[], Stream>)ManualUTF8ToFormattedLineCount.HandOptimized, (Action<byte[], Stream>)ManualUTF8ToFormattedLineCount.GeneratedStages),
                Tuple.Create("CHSI-cancer (Hand-written)", birthDeathProvider,
                    (Action<byte[], Stream>)ManuaCSV4abc.HandOptimized, (Action<byte[], Stream>)ManuaCSV4abc.GeneratedStages),
                Tuple.Create("CHSI-births (Hand-written)", birthDeathProvider,
                    (Action<byte[], Stream>)ManuaCSV2abc.HandOptimized, (Action<byte[], Stream>)ManuaCSV2abc.GeneratedStages),
                Tuple.Create("CHSI total deaths minimum (Hand-written)", birthDeathProvider,
                    (Action<byte[], Stream>)ManuaCSV3abc.HandOptimized, (Action<byte[], Stream>)ManuaCSV3abc.GeneratedStages),
                Tuple.Create("SBO-employees (Hand-written)", sboProviderEvenSmaller,
                    (Action<byte[], Stream>)ManuaCSV5abc.HandOptimized, (Action<byte[], Stream>)ManuaCSV5abc.GeneratedStages),
                Tuple.Create("SBO-receipts (Hand-written)", sboProviderEvenSmaller,
                    (Action<byte[], Stream>)ManuaCSV7abc.HandOptimized, (Action<byte[], Stream>)ManuaCSV7abc.GeneratedStages),
                Tuple.Create("SBO-payroll (Hand-written)", sboProviderEvenSmaller,
                    (Action<byte[], Stream>)ManuaCSV6abc.HandOptimized, (Action<byte[], Stream>)ManuaCSV6abc.GeneratedStages),
                Tuple.Create("CC-id (Hand-written)", ccProvider,
                    (Action<byte[], Stream>)ManuaCSV1abc.HandOptimized, (Action<byte[], Stream>)ManuaCSV1abc.GeneratedStages),

                Tuple.Create("Base64-delta (LINQ)", (Func<byte[]>)DataProviders.Base64RandomInts,
                    (Action<byte[], Stream>)ManualB64FormattedDeltaUTF8.GeneratedStages, nullSpec),
                Tuple.Create("CSV-max (LINQ)", (Func<byte[]>)DataProviders.Base64RandomInts,
                    (Action<byte[], Stream>)ManuaUTF8MaxCol3IntB64.GeneratedStages, nullSpec),
                Tuple.Create("Base64-avg (LINQ)", (Func<byte[]>)DataProviders.Base64RandomInts,
                    (Action<byte[], Stream>)ManualB64ToWindowedAverageToB64.GeneratedStages, nullSpec),
                Tuple.Create("UTF8-lines (LINQ)", bookProvider,
                    (Action<byte[], Stream>)ManualUTF8ToFormattedLineCount.GeneratedStages, nullSpec),
                Tuple.Create("CHSI-cancer (LINQ)", birthDeathProvider,
                    (Action<byte[], Stream>)ManuaCSV4abc.GeneratedStages, nullSpec),
                Tuple.Create("CHSI-births (LINQ)", birthDeathProvider,
                    (Action<byte[], Stream>)ManuaCSV2abc.GeneratedStages, nullSpec),
                Tuple.Create("CHSI total deaths maximum (LINQ)", birthDeathProvider,
                    (Action<byte[], Stream>)ManuaCSV3abc.GeneratedStages, nullSpec),
                Tuple.Create("SBO-employees (LINQ)", sboProviderEvenSmaller,
                    (Action<byte[], Stream>)ManuaCSV5abc.GeneratedStages, nullSpec),
                Tuple.Create("SBO-receipts (LINQ)", sboProviderEvenSmaller,
                    (Action<byte[], Stream>)ManuaCSV7abc.GeneratedStages, nullSpec),
                Tuple.Create("SBO-payroll (LINQ)", sboProviderEvenSmaller,
                    (Action<byte[], Stream>)ManuaCSV6abc.GeneratedStages, nullSpec),
                Tuple.Create("CC-id (LINQ)", ccProvider,
                    (Action<byte[], Stream>)ManuaCSV1abc.GeneratedStages, nullSpec),
                Tuple.Create("TPC-DI customers SQL (LINQ)", tpcdiCustomers,
                    (Action<byte[], Stream>)ManualXML1abc.GeneratedStages, nullSpec),
                Tuple.Create("PIR protein lengths average (LINQ)", proteins,
                    (Action<byte[], Stream>)ManualXML2.GeneratedStages, nullSpec),
                Tuple.Create("DBLP oldest article (LINQ)", dblp,
                    (Action<byte[], Stream>)ManualXML3.GeneratedStages, nullSpec),
                Tuple.Create("Mondial largest population (LINQ)", mondial,
                    (Action<byte[], Stream>)ManualXML4.GeneratedStages, nullSpec),

                Tuple.Create("TPC-DI customers SQL (XmlDocument)", tpcdiCustomers,
                    (Action<byte[], Stream>)ManualXML1abc.HandOptimized, (Action<byte[], Stream>)ManualXML1abc.GeneratedStages),
                Tuple.Create("PIR protein lengths average (XmlDocument)", proteins,
                    (Action<byte[], Stream>)ManualXML2.HandOptimized, (Action<byte[], Stream>)ManualXML2.GeneratedStages),
                Tuple.Create("DBLP oldest article (XmlDocument)", dblp,
                    (Action<byte[], Stream>)ManualXML3.HandOptimized, (Action<byte[], Stream>)ManualXML3.GeneratedStages),
                Tuple.Create("Mondial largest population (XmlDocument)", mondial,
                    (Action<byte[], Stream>)ManualXML4.HandOptimized, (Action<byte[], Stream>)ManualXML4.GeneratedStages),
            };

            if (args.Length > 0 && args[0] == "-fig9WithoutConfidence")
            {
                var fig9Path = ResultsDir + "Figure9_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";

                Directory.CreateDirectory(ResultsDir);

                var fig9Writer = new StreamWriter(File.OpenWrite(fig9Path));

                fig9Writer.WriteLine("sep=,"); // Recognized by Excel

                Func<int, StreamWriter, double> doStreamBenchmark = (index, output) =>
                {
                    var benchmark = streamBenchmarks[index];
                    return QuickBenchmarkStream(benchmark.Item2, benchmark.Item3);
                };
                Action<int, double, StreamWriter> commitStreamBenchmark = (index, throughput, output) =>
                {
                    var benchmark = streamBenchmarks[index];
                    Console.Write(benchmark.Item1 + ": ");
                    Console.WriteLine(throughput.ToString(CultureInfo.InvariantCulture));
                    output.WriteLine(benchmark.Item1 + "," + throughput.ToString(CultureInfo.InvariantCulture));
                    output.Flush();
                };
                Action<int, StreamWriter> addStreamBenchmark = (index, output) =>
                {
                    var benchmark = streamBenchmarks[index];
                    Console.Write(benchmark.Item1 + ": ");
                    var throughput = QuickBenchmarkStream(benchmark.Item2, benchmark.Item3);
                    Console.WriteLine(throughput.ToString(CultureInfo.InvariantCulture));
                    output.WriteLine(benchmark.Item1 + "," + throughput.ToString(CultureInfo.InvariantCulture));
                    output.Flush();
                };
                Action<int, StreamWriter> addArrayBenchmark = (index, output) =>
                {
                    var benchmark = arrayBenchmarks[index];
                    Console.Write(benchmark.Item1 + ": ");
                    var throughput = QuickBenchmarkArray(benchmark.Item2, benchmark.Item3);
                    Console.WriteLine(throughput.ToString(CultureInfo.InvariantCulture));
                    output.WriteLine(benchmark.Item1 + "," + throughput.ToString(CultureInfo.InvariantCulture));
                    output.Flush();
                };

                addArrayBenchmark(11, fig9Writer);
                addStreamBenchmark(15, fig9Writer);
                addArrayBenchmark(0, fig9Writer);
                addStreamBenchmark(0, fig9Writer);
                addArrayBenchmark(12, fig9Writer);
                addStreamBenchmark(16, fig9Writer);
                addArrayBenchmark(1, fig9Writer);
                addStreamBenchmark(1, fig9Writer);
                addArrayBenchmark(13, fig9Writer);
                addStreamBenchmark(17, fig9Writer);
                addArrayBenchmark(2, fig9Writer);
                addStreamBenchmark(2, fig9Writer);
                addArrayBenchmark(14, fig9Writer);
                addStreamBenchmark(18, fig9Writer);
                addArrayBenchmark(3, fig9Writer);
                addStreamBenchmark(3, fig9Writer);
                addArrayBenchmark(15, fig9Writer);
                addStreamBenchmark(19, fig9Writer);
                addArrayBenchmark(4, fig9Writer);
                addStreamBenchmark(4, fig9Writer);
                addArrayBenchmark(16, fig9Writer);
                addStreamBenchmark(20, fig9Writer);
                addArrayBenchmark(5, fig9Writer);
                addStreamBenchmark(5, fig9Writer);
                addArrayBenchmark(17, fig9Writer);
                addStreamBenchmark(21, fig9Writer);
                addStreamBenchmark(6, fig9Writer);
                addArrayBenchmark(6, fig9Writer);
                addArrayBenchmark(18, fig9Writer);
                addStreamBenchmark(22, fig9Writer);
                addArrayBenchmark(7, fig9Writer);
                addStreamBenchmark(7, fig9Writer);
                addArrayBenchmark(19, fig9Writer);
                addStreamBenchmark(23, fig9Writer);
                addArrayBenchmark(8, fig9Writer);
                addStreamBenchmark(8, fig9Writer);
                addArrayBenchmark(20, fig9Writer);
                addStreamBenchmark(24, fig9Writer);
                addArrayBenchmark(9, fig9Writer);
                addStreamBenchmark(9, fig9Writer);
                addArrayBenchmark(21, fig9Writer);
                addStreamBenchmark(25, fig9Writer);
                addArrayBenchmark(10, fig9Writer);
                addStreamBenchmark(10, fig9Writer);

                fig9Writer.Dispose();
                return;
            }

            if (args.Length > 0 && args[0] == "-fig10WithoutConfidence")
            {
                var fig10Path = ResultsDir + "Figure10_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";

                Directory.CreateDirectory(ResultsDir);
                
                var fig10Writer = new StreamWriter(File.OpenWrite(fig10Path));
                
                fig10Writer.WriteLine("sep=,"); // Recognized by Excel

                Func<int, StreamWriter, double> doStreamBenchmark = (index, output) =>
                {
                    var benchmark = streamBenchmarks[index];
                    return QuickBenchmarkStream(benchmark.Item2, benchmark.Item3);
                };
                Action<int, double, StreamWriter> commitStreamBenchmark = (index, throughput, output) =>
                {
                    var benchmark = streamBenchmarks[index];
                    Console.Write(benchmark.Item1 + ": ");
                    Console.WriteLine(throughput.ToString(CultureInfo.InvariantCulture));
                    output.WriteLine(benchmark.Item1 + "," + throughput.ToString(CultureInfo.InvariantCulture));
                    output.Flush();
                };
                Action<int, StreamWriter> addStreamBenchmark = (index, output) =>
                {
                    var benchmark = streamBenchmarks[index];
                    Console.Write(benchmark.Item1 + ": ");
                    var throughput = QuickBenchmarkStream(benchmark.Item2, benchmark.Item3);
                    Console.WriteLine(throughput.ToString(CultureInfo.InvariantCulture));
                    output.WriteLine(benchmark.Item1 + "," + throughput.ToString(CultureInfo.InvariantCulture));
                    output.Flush();
                };
                Action<int, StreamWriter> addArrayBenchmark = (index, output) =>
                {
                    var benchmark = arrayBenchmarks[index];
                    Console.Write(benchmark.Item1 + ": ");
                    var throughput = QuickBenchmarkArray(benchmark.Item2, benchmark.Item3);
                    Console.WriteLine(throughput.ToString(CultureInfo.InvariantCulture));
                    output.WriteLine(benchmark.Item1 + "," + throughput.ToString(CultureInfo.InvariantCulture));
                    output.Flush();
                };

                //var throughput31 = doStreamBenchmark(31, fig10Writer);
                
                addArrayBenchmark(26, fig10Writer);
                addStreamBenchmark(30, fig10Writer);
                addArrayBenchmark(22, fig10Writer);
                addStreamBenchmark(26, fig10Writer);
                addStreamBenchmark(11, fig10Writer);
                //addArrayBenchmark(27, fig10Writer);
                //commitStreamBenchmark(31, throughput31, fig10Writer);
                addStreamBenchmark(31, fig10Writer);
                addArrayBenchmark(23, fig10Writer);
                addStreamBenchmark(27, fig10Writer);
                addStreamBenchmark(12, fig10Writer);
                addArrayBenchmark(28, fig10Writer);
                addStreamBenchmark(32, fig10Writer);
                addArrayBenchmark(24, fig10Writer);
                addStreamBenchmark(28, fig10Writer);
                addStreamBenchmark(13, fig10Writer);
                addArrayBenchmark(29, fig10Writer);
                addStreamBenchmark(33, fig10Writer);
                addArrayBenchmark(25, fig10Writer);
                addStreamBenchmark(29, fig10Writer);
                addStreamBenchmark(14, fig10Writer);
                
                fig10Writer.Dispose();
                return;
            }

            while (true)
            {
                int[] selections = null;

                GET_SELECTION:
                for (int i = 0; i < streamBenchmarks.Count; ++i)
                {
                    Console.WriteLine((i + 1) + ": " + streamBenchmarks[i].Item1);
                }
                for (int i = 0; i < arrayBenchmarks.Count; ++i)
                {
                    Console.WriteLine((i + 1 + streamBenchmarks.Count) + ": " + arrayBenchmarks[i].Item1);
                }
                Console.Write("Select benchmarks (comma separated), or press Enter to run all: ");
                var answer = Console.ReadLine().Trim();
                if (answer == "")
                {
                    selections = Enumerable.Range(1, streamBenchmarks.Count + arrayBenchmarks.Count).ToArray();
                }
                else
                {
                    var numbers = answer.Split(',');
                    selections = new int[numbers.Length];
                    for (int i = 0; i < numbers.Length; ++i)
                    {
                        if (!int.TryParse(numbers[i].Trim(), out selections[i]))
                        {
                            goto GET_SELECTION;
                        }
                    }
                }

                foreach (var selection in selections)
                {
                    Console.WriteLine("Benchmark " + selection);
                    if (selection <= streamBenchmarks.Count)
                    {
                        var benchmark = streamBenchmarks[selection - 1];
                        BenchmarkStream(benchmark.Item2, benchmark.Item3, benchmark.Item1, benchmark.Item4);
                    }
                    else
                    {
                        var benchmark = arrayBenchmarks[selection - 1 - streamBenchmarks.Count];
                        BenchmarkArray(benchmark.Item2, benchmark.Item3, benchmark.Item1, benchmark.Item4);
                    }
                }
            }
        }
    }
}
