using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    class ManualB64ToWindowedAverageToB64
    {
        public static void ProcessStages(byte[] input, Stream output)
        {
            var result = ProcessBase64Encoder.Process(ProcessInt32ToBytes.Process(ProcessWindowedAverage10.Process(ProcessBytesToInt32.Process(ProcessBase64Decoder.Process(input))))).ToArray();
            output.Write(result, 0, result.Length);
        }

        public static void GeneratedStages(byte[] input, Stream output)
        {
            var result = Base64Encoder.Transduce(Int32ToBytes.Transduce(WindowedAverage10.Transduce(BytesToInt32.Transduce(Base64Decoder.Transduce(input))))).ToArray();
            output.Write(result, 0, result.Length);
        }

        public static void HandOptimized(byte[] input, Stream output)
        {
            var chars = System.Text.Encoding.UTF8.GetChars(input);
            var bytes = Convert.FromBase64CharArray(chars, 0, chars.Length);
            var ints = new int[bytes.Length / 4];
            for (int i = 0; i < ints.Length; ++i)
            {
                var j = i * 4;
                ints[i] = bytes[j] << 24 | bytes[j + 1] << 16 | bytes[j + 2] << 8 | bytes[j + 3];
            }
            var averages = new int[ints.Length];
            int offset = 0;
            long v0 = 0, v1 = 0, v2 = 0, v3 = 0, v4 = 0, v5 = 0, v6 = 0, v7 = 0, v8 = 0, v9 = 0;
            for (int i = 0; i < ints.Length; ++i)
            {
                var c = ints[i];
                if (offset == 0)
                {
                    v0 = c;
                }
                else if (offset == 1)
                {
                    v1 = c;
                }
                else if (offset == 2)
                {
                    v2 = c;
                }
                else if (offset == 3)
                {
                    v3 = c;
                }
                else if (offset == 4)
                {
                    v4 = c;
                }
                else if (offset == 5)
                {
                    v5 = c;
                }
                else if (offset == 6)
                {
                    v6 = c;
                }
                else if (offset == 7)
                {
                    v7 = c;
                }
                else if (offset == 8)
                {
                    v8 = c;
                }
                else
                {
                    v9 = c;
                }
                offset = (offset + 1) % 10;
                averages[i] = (int)(v0 + v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8 + v9) / 10;
            }
            var resultBytes = new byte[averages.Length * 4];
            for (int i = 0; i < averages.Length; ++i)
            {
                var j = i * 4;
                resultBytes[j] = (byte)((averages[i] >> 24) & 0xFF);
                resultBytes[j + 1] = (byte)((averages[i] >> 16) & 0xFF);
                resultBytes[j + 2] = (byte)((averages[i] >> 8) & 0xFF);
                resultBytes[j + 3] = (byte)(averages[i] & 0xFF);
            }
            var encodedChars = Convert.ToBase64String(resultBytes);
            var utf8Bytes = System.Text.Encoding.UTF8.GetBytes(encodedChars);
            output.Write(utf8Bytes, 0, utf8Bytes.Length);
        }
    }

    class ManuaUTF8MaxCol3IntB64
    {
        public static void GeneratedStages(byte[] input, Stream output)
        {
            var result = UTF16ToUTF8.Transduce(FormatInt32Lines.Transduce(Maximum.Transduce(Col3Int.Transduce(UTF8ToUTF16.Transduce(input))))).ToArray();
            output.Write(result, 0, result.Length);
        }

        static readonly Regex regex = new Regex(@"(([^,\n]*,){3}(?<value>\d+)(\n|(,[^\n]*\n)))*", RegexOptions.Compiled);
        public static void HandOptimized(byte[] input, Stream output)
        {
            var asString = System.Text.Encoding.UTF8.GetString(input);
            var match = regex.Match(asString);
            var valueCaptures = match.Groups["value"].Captures;
            int m = -1;
            for (int i = 0; i < valueCaptures.Count; ++i)
            {
                if (int.Parse(valueCaptures[i].Value) > m)
                {
                    m = int.Parse(valueCaptures[i].Value);
                }
            }
            var formatted = System.Text.Encoding.UTF8.GetBytes(m.ToString() + '\n');
            output.Write(formatted, 0, formatted.Length);
        }
    }

    class ManualB64FormattedDeltaUTF8
    {
        public static void GeneratedStages(byte[] input, Stream output)
        {
            var result = UTF16ToUTF8.Transduce(FormatInt32Lines.Transduce(Delta.Transduce(BytesToInt32.Transduce(Base64Decoder.Transduce(input))))).ToArray();
            output.Write(result, 0, result.Length);
        }

        public static void HandOptimized(byte[] input, Stream output)
        {
            var chars = System.Text.Encoding.UTF8.GetChars(input);
            var bytes = Convert.FromBase64CharArray(chars, 0, chars.Length);
            var ints = new int[bytes.Length / 4];
            for (int i = 0; i < ints.Length; ++i)
            {
                var j = i * 4;
                ints[i] = bytes[j] << 24 | bytes[j + 1] << 16 | bytes[j + 2] << 8 | bytes[j + 3];
            }
            int previous = 0;
            for (int i = 0; i < ints.Length; ++i)
            {
                var formatted = System.Text.Encoding.UTF8.GetBytes((ints[i] - previous).ToString() + '\n');
                output.Write(formatted, 0, formatted.Length);
                previous = ints[i];
            }
        }
    }

    class ManualUTF8ToFormattedLineCount
    {
        public static void ProcessStages(byte[] input, Stream output)
        {
            var result = ProcessUTF16ToUTF8.Process(ProcessFormatInt32Lines.Process(ProcessLineCount.Process(ProcessUTF8ToUTF16.Process(input)))).ToArray();
            output.Write(result, 0, result.Length);
        }

        public static void GeneratedStages(byte[] input, Stream output)
        {
            var result = UTF16ToUTF8.Transduce(FormatInt32Lines.Transduce(LineCount.Transduce(UTF8ToUTF16.Transduce(input)))).ToArray();
            output.Write(result, 0, result.Length);
        }

        public static void HandOptimized(byte[] input, Stream output)
        {
            var asString = System.Text.Encoding.UTF8.GetString(input);
            int count = 0;
            foreach (var c in input)
            {
                if (c == '\n')
                {
                    count += 1;
                }
            }
            var formatted = System.Text.Encoding.UTF8.GetBytes(count.ToString() + '\n');
            output.Write(formatted, 0, formatted.Length);
        }
    }

    class ManualFixUTF16ToHTMLEncode
    {
        public static string HandOptimized(string input)
        {
            return System.Web.Security.AntiXss.AntiXssEncoder.HtmlEncode(input, false);
        }
    }
}
