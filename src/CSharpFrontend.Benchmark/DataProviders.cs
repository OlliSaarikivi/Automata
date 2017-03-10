using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    static class DataProviders
    {
        static Random Random = new Random();
        const int MB = 1048576;

        public static int BenchmarkSize = 100;

        public static byte[] RandomBytes()
        {
            byte[] data = new byte[MB * BenchmarkSize];
            Random.NextBytes(data);
            return data;
        }

        public static int[] RandomInts()
        {
            int[] data = new int[(MB * BenchmarkSize) / sizeof(int)];
            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = Random.Next(i)+1;
            }
            return data;
        }

        public static string RandomString()
        {
            char[] data = new char[(MB * BenchmarkSize) / sizeof(char)];
            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = (char)Random.Next(char.MinValue, char.MaxValue);
            }
            return new string(data);
        }

        public static byte[] RandomIntsAsBytes()
        {
            return Int32ToBytes.Transduce(RandomInts()).ToArray();
        }

        public static byte[] Base64RandomInts()
        {
            return ProcessBase64Encoder.Process(ProcessInt32ToBytes.Process(RandomInts())).ToArray();
            //return IntsToB64.Transduce(RandomInts()).ToArray();
        }

        public static byte[] RepeatedFile(string path)
        {
            var book = File.ReadAllBytes(path);
            long repeat = (long)Math.Round(((double)(MB * BenchmarkSize)) / book.LongLength);
            if (repeat == 0)
                repeat = 1;
            byte[] data = new byte[book.LongLength * repeat];
            for (long i = 0; i < data.LongLength; ++i)
            {
                data[i] = book[i % book.LongLength];
            }
            return data;
        }

        public static byte[] SingleFile(string path)
        {
            var book = File.ReadAllBytes(path);
            return book;
        }

        public static byte[] Base64RepeatedFile(string path)
        {
            return Base64Encoder.Transduce(RepeatedFile(path)).ToArray();
        }

        public static byte[] EnglishHuffmanRepeatedFile(string path)
        {
            var output = new MemoryStream();
            EnglishHuffmanEncoder.TransduceFromStreamToStream(new MemoryStream(RepeatedFile(path)), output);
            return output.ToArray();
        }

        static string[] StringFields = new[] { "Foo", "Bar", "Baz", "Foobar" };
        public static byte[] GenerateEncodedCSV()
        {
            var text = new StringBuilder();
            while (text.Length < MB * BenchmarkSize)
            {
                text.Append(Random.Next(-100, 100)).Append(",");
                text.Append(Random.Next(1, 9)).Append(",");
                text.Append(StringFields[Random.Next(StringFields.Length)]).Append(",");
                text.Append(Random.Next(1, 1000000));
                text.Append('\n');
            }
            var bytes = System.Text.Encoding.UTF8.GetBytes(text.ToString());
            var result = new MemoryStream();
            EnglishHuffmanEncoder.TransduceFromStreamToStream(new MemoryStream(bytes), result);
            var actual = new byte[result.Length - 1];
            Array.Copy(result.ToArray(), actual, result.Length - 1);
            return actual;
        }
    }
}
