using Microsoft.Automata.CSharpFrontend.Runtime.Transducer;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime
{
    public interface IHadoopStreamingRecordParser<T>
    {
        int RecordSize { get; }
        IEnumerable<T> Parse(byte[] bytes);
    }
    public interface IHadoopStreamingOutputFormatter<T>
    {
        void Format(Stream sink, T output);
    }

    public static class HadoopStreamingUtils
    {
        static IEnumerable<Tuple<byte[], int>> BlockingEnumeration(BlockingCollection<Tuple<byte[], int>> entries)
        {
            while (true)
            {
                var entry = entries.Take();
                if (entry.Item2 > 0)
                {
                    yield return entry;
                }
                else
                {
                    yield break;
                }
            }
        }

        //static IEnumerable<Tuple<T, T>> PairUp<T>(IEnumerable<T> xs) where T : class
        //{
        //    T previous = null;
        //    foreach (var x in xs)
        //    {
        //        if (previous != null)
        //        {
        //            yield return Tuple.Create(previous, x);
        //        }
        //        else
        //        {
        //            previous = x;
        //        }
        //    }
        //    if (previous != null)
        //    {
        //        yield return Tuple.Create<T, T>(previous, null);
        //    }
        //}

        public static async Task Mapper<Input, State, Output>(Stream input, Stream output, Implementation<Input, Output, State> transducer,
            IHadoopStreamingRecordParser<Input> parser, int batchSize = 16384)
        {
            if (batchSize % parser.RecordSize != 0)
            {
                throw new ArgumentException("Batch size must be a multiple of record size");
            }

            var buffers = new ConcurrentBag<byte[]>();
            var pending = new BlockingCollection<Tuple<byte[], int>>(Environment.ProcessorCount);

            var summaries = BlockingEnumeration(pending).AsParallel().AsOrdered().Select(x =>
            {
                var summary = parser.Parse(x.Item1).GetSummary(transducer);
                buffers.Add(x.Item1);
                return summary;
            });

            var outputTask = Task.Factory.StartNew(async () =>
            {
                var mem = new MemoryStream();
                var bf = new BinaryFormatter();
                foreach (var summary in summaries)
                {
                    bf.Serialize(mem, summary);
                    var size = BitConverter.GetBytes(mem.Length);
                    await output.WriteAsync(size, 0, size.Length);
                    mem.WriteTo(output);
                    mem.Seek(0, SeekOrigin.Begin);
                    mem.SetLength(0);
                }
            });

            var inputTask = Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    byte[] buffer;
                    if (!buffers.TryTake(out buffer))
                    {
                        buffer = new byte[batchSize];
                    }
                    int read = input.Read(buffer, 0, buffer.Length);
                    if (read == 0)
                    {
                        pending.Add(Tuple.Create<byte[], int>(null, 0));
                        break;
                    }
                    pending.Add(Tuple.Create(buffer, read));
                }
            });

            await inputTask;
            await outputTask;
        }

        public static async Task Reducer<Input, State, Output>(Stream input, Stream output, Implementation<Input, Output, State> transducer,
            IHadoopStreamingOutputFormatter<Output> formatter)
        {
            var bf = new BinaryFormatter();

            var headerBuffer = new byte[sizeof(long)];
            while (true)
            {
                int totalRead = 0;

                int read = await input.ReadAsync(headerBuffer, 0, headerBuffer.Length);
                if (read == 0)
                {
                    break;
                }

            }

            // TODO
        }
    }
}
