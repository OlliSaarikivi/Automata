using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{

    //// Maximum ID
    //[ParsingMatcher("((?<value>\\d+)(,([^\\n,]*)|(\"[^\\n\"]*\")){12},([^\\n]*)\\n)*", "int")]
    //partial class CCCol1Int : SpecialTransducer { }
    //partial class CSV1a : Composition<AssumeSingleByteChars, CCCol1Int> { }
    //partial class CSV1ab : Composition<CSV1a, Maximum> { }
    //partial class CSV1abc : Composition<CSV1ab, Int32ToBytes> { }
    class ManuaCSV1abc
    {
        public static void GeneratedStages(byte[] input, Stream output)
        {
            var result = Int32ToBytes.Transduce(Maximum.Transduce(CCCol1Int.Transduce(UTF8ToUTF16.Transduce(input)))).ToArray();
            output.Write(result, 0, result.Length);
        }

        static readonly Regex regex = new Regex("(?<value>\\d+)(,([^\\n,]*)|(\"[^\\n\"]*\")){12},([^\\n]*)", RegexOptions.Compiled);
        public static void HandOptimized(byte[] input, Stream output)
        {
            var asString = System.Text.Encoding.UTF8.GetString(input);
            //var asString = new String(Array.ConvertAll(input, x => (char)x));
            var match = regex.Match(asString);
            var valueCaptures = match.Groups["value"].Captures;
            int max = -1;
            for (int i = 0; i < valueCaptures.Count; ++i)
            {
                if (int.Parse(valueCaptures[i].Value) > max)
                {
                    max = int.Parse(valueCaptures[i].Value);
                }
            }
            var bytes = BitConverter.GetBytes(max);
            output.Write(bytes, 0, bytes.Length);
        }

        //static readonly Regex regex = new Regex("(?<value>\\d+)(,([^\\n,]*)|(\"[^\\n\"]*\")){12},([^\\n]*)", RegexOptions.Compiled);
        //public static void HandOptimized(byte[] input, Stream output)
        //{
        //    var asString = new String(Array.ConvertAll(input, x => (char)x));
        //    var lines = asString.Split('\n');
        //    int max = -1;
        //    foreach (var line in lines)
        //    {
        //        try
        //        {
        //            var match = regex.Match(line);
        //            int x = int.Parse(match.Groups["value"].Value);
        //            if (x > max)
        //            {
        //                max = x;
        //            }
        //        }
        //        catch
        //        {
        //            break;
        //        }
        //    }
        //    var bytes = BitConverter.GetBytes(max);
        //    output.Write(bytes, 0, bytes.Length);
        //}
    }

    //// Minimum total births
    //[ParsingMatcher("(([^,]*,){138}-?(?<value>\\d+)(\\.\\d+)?,[^\\n]*\\n)*", "int")]
    //partial class CHSITotalBirths : SpecialTransducer { }
    //partial class CSV2a : Composition<AssumeSingleByteChars, CHSITotalBirths> { }
    //partial class CSV2ab : Composition<CSV2a, Minimum> { }
    //partial class CSV2abc : Composition<CSV2ab, Int32ToBytes> { }
    class ManuaCSV2abc
    {
        public static void GeneratedStages(byte[] input, Stream output)
        {
            var result = Int32ToBytes.Transduce(Minimum.Transduce(CHSITotalBirths.Transduce(UTF8ToUTF16.Transduce(input)))).ToArray();
            output.Write(result, 0, result.Length);
        }

        static readonly Regex regex = new Regex("(([^,]*,){138}-?(?<value>\\d+)(\\.\\d+)?,[^\\n]*\\n)*", RegexOptions.Compiled);
        public static void HandOptimized(byte[] input, Stream output)
        {
            var asString = System.Text.Encoding.UTF8.GetString(input);
            var match = regex.Match(asString);
            var valueCaptures = match.Groups["value"].Captures;
            int m = 2147483647;
            for (int i = 0; i < valueCaptures.Count; ++i)
            {
                if (int.Parse(valueCaptures[i].Value) < m)
                {
                    m = int.Parse(valueCaptures[i].Value);
                }
            }
            var bytes = BitConverter.GetBytes(m);
            output.Write(bytes, 0, bytes.Length);
        }

        //static readonly Regex regex = new Regex("([^,]*,){138}-?(?<value>\\d+)(\\.\\d+)?,[^\\n]*", RegexOptions.Compiled);
        //public static void HandOptimized(byte[] input, Stream output)
        //{
        //    var asString = new String(Array.ConvertAll(input, x => (char)x));
        //    var lines = asString.Split('\n');
        //    int m = 2147483647;
        //    foreach (var line in lines)
        //    {
        //        try
        //        {
        //            var match = regex.Match(line);
        //            int x = int.Parse(match.Groups["value"].Value);
        //            if (x < m)
        //            {
        //                m = x;
        //            }
        //        }
        //        catch
        //        {
        //            break;
        //        }
        //    }
        //    var bytes = BitConverter.GetBytes(m);
        //    output.Write(bytes, 0, bytes.Length);
        //}
    }

    //// Maximum deaths
    //[ParsingMatcher("(([^,]*,){139}-?(?<value>\\d+)(\\.\\d+)?,[^\\n]*\\n)*", "int")]
    //partial class CHSITotalDeaths : SpecialTransducer { }
    //partial class CSV3a : Composition<AssumeSingleByteChars, CHSITotalDeaths> { }
    //partial class CSV3ab : Composition<CSV3a, Maximum> { }
    //partial class CSV3abc : Composition<CSV3ab, Int32ToBytes> { }
    class ManuaCSV3abc
    {
        public static void GeneratedStages(byte[] input, Stream output)
        {
            var result = Int32ToBytes.Transduce(Maximum.Transduce(CHSITotalDeaths.Transduce(UTF8ToUTF16.Transduce(input)))).ToArray();
            output.Write(result, 0, result.Length);
        }

        static readonly Regex regex = new Regex("(([^,]*,){139}-?(?<value>\\d+)(\\.\\d+)?,[^\\n]*\\n)*", RegexOptions.Compiled);
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
            var bytes = BitConverter.GetBytes(m);
            output.Write(bytes, 0, bytes.Length);
        }

        //static readonly Regex regex = new Regex("([^,]*,){139}-?(?<value>\\d+)(\\.\\d+)?,[^\\n]*", RegexOptions.Compiled);
        //public static void HandOptimized(byte[] input, Stream output)
        //{
        //    var asString = new String(Array.ConvertAll(input, x => (char)x));
        //    var lines = asString.Split('\n');
        //    int m = -1;
        //    foreach (var line in lines)
        //    {
        //        try
        //        {
        //            var match = regex.Match(line);
        //            int x = int.Parse(match.Groups["value"].Value);
        //            if (x > m)
        //            {
        //                m = x;
        //            }
        //        }
        //        catch
        //        {
        //            break;
        //        }
        //    }
        //    var bytes = BitConverter.GetBytes(m);
        //    output.Write(bytes, 0, bytes.Length);
        //}
    }

    //// Average lung cancer
    //[ParsingMatcher("(([^,]*,){108}-?(?<value>\\d+)(\\.\\d+)?,[^\\n]*\\n)*", "int")]
    //partial class CHSILungCancer : SpecialTransducer { }
    //partial class CSV4a : Composition<AssumeSingleByteChars, CHSILungCancer> { }
    //partial class CSV4ab : Composition<CSV4a, Average> { }
    //partial class CSV4abc : Composition<CSV4ab, Int32ToBytes> { }
    class ManuaCSV4abc
    {
        public static void GeneratedStages(byte[] input, Stream output)
        {
            var result = Int32ToBytes.Transduce(Average.Transduce(CHSILungCancer.Transduce(UTF8ToUTF16.Transduce(input)))).ToArray();
            output.Write(result, 0, result.Length);
        }

        static readonly Regex regex = new Regex("(([^,]*,){108}-?(?<value>\\d+)(\\.\\d+)?,[^\\n]*\\n)*", RegexOptions.Compiled);
        public static void HandOptimized(byte[] input, Stream output)
        {
            var asString = System.Text.Encoding.UTF8.GetString(input);
            var match = regex.Match(asString);
            var valueCaptures = match.Groups["value"].Captures;
            long sum = 0L;
            int count = 0;
            for (int i = 0; i < valueCaptures.Count; ++i)
            {
                sum += int.Parse(valueCaptures[i].Value);
                ++count;
            }
            var bytes = BitConverter.GetBytes((int)(sum / count));
            output.Write(bytes, 0, bytes.Length);
        }

        //static readonly Regex regex = new Regex("([^,]*,){108}-?(?<value>\\d+)(\\.\\d+)?,[^\\n]*", RegexOptions.Compiled);
        //public static void HandOptimized(byte[] input, Stream output)
        //{
        //    var asString = new String(Array.ConvertAll(input, x => (char)x));
        //    var lines = asString.Split('\n');
        //    long sum = 0L;
        //    int count = 0;
        //    foreach (var line in lines)
        //    {
        //        try
        //        {
        //            var match = regex.Match(line);
        //            int x = int.Parse(match.Groups["value"].Value);
        //            sum += x;
        //            ++count;
        //        }
        //        catch
        //        {
        //            break;
        //        }
        //    }
        //    var bytes = BitConverter.GetBytes((int)(sum / count));
        //    output.Write(bytes, 0, bytes.Length);
        //}
    }

    ////Maximum american num employees
    //[ParsingMatcher("(([^,]*,){5}(?<value>\\d+),[^\\n]*\\n)*", "int")]
    //partial class SBOEmployees : SpecialTransducer { }
    //partial class CSV5a : Composition<AssumeSingleByteChars, SBOEmployees> { }
    //partial class CSV5ab : Composition<CSV5a, Maximum> { }
    //partial class CSV5abc : Composition<CSV5ab, Int32ToBytes> { }
    class ManuaCSV5abc
    {
        public static void GeneratedStages(byte[] input, Stream output)
        {
            var result = Int32ToBytes.Transduce(Maximum.Transduce(SBOEmployees.Transduce(UTF8ToUTF16.Transduce(input)))).ToArray();
            output.Write(result, 0, result.Length);
        }

        static readonly Regex regex = new Regex("(([^,]*,){5}(?<value>\\d+),[^\\n]*\\n)*", RegexOptions.Compiled);
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
            var bytes = BitConverter.GetBytes(m);
            output.Write(bytes, 0, bytes.Length);
        }

        //static readonly Regex regex = new Regex("([^,]*,){5}(?<value>\\d+),[^\\n]*", RegexOptions.Compiled);
        //public static void HandOptimized(byte[] input, Stream output)
        //{
        //    var asString = new String(Array.ConvertAll(input, x => (char)x));
        //    var lines = asString.Split('\n');
        //    int m = -1;
        //    foreach (var line in lines)
        //    {
        //        try
        //        {
        //            var match = regex.Match(line);
        //            int x = int.Parse(match.Groups["value"].Value);
        //            if (x > m)
        //            {
        //                m = x;
        //            }
        //        }
        //        catch
        //        {
        //            break;
        //        }
        //    }
        //    var bytes = BitConverter.GetBytes(m);
        //    output.Write(bytes, 0, bytes.Length);
        //}
    }

    ////Average american total payroll
    //[ParsingMatcher("(([^,]*,){6}(?<value>\\d+)(\\.\\d+)?,[^\\n]*\\n)*", "int")]
    //partial class SBOPayroll : SpecialTransducer { }
    //partial class CSV6a : Composition<AssumeSingleByteChars, SBOPayroll> { }
    //partial class CSV6ab : Composition<CSV6a, Average> { }
    //partial class CSV6abc : Composition<CSV6ab, Int32ToBytes> { }
    class ManuaCSV6abc
    {
        public static void GeneratedStages(byte[] input, Stream output)
        {
            var result = Int32ToBytes.Transduce(Average.Transduce(SBOPayroll.Transduce(UTF8ToUTF16.Transduce(input)))).ToArray();
            output.Write(result, 0, result.Length);
        }

        static readonly Regex regex = new Regex("(([^,]*,){6}(?<value>\\d+)(\\.\\d+)?,[^\\n]*\\n)*", RegexOptions.Compiled);
        public static void HandOptimized(byte[] input, Stream output)
        {
            var asString = System.Text.Encoding.UTF8.GetString(input);
            var match = regex.Match(asString);
            var valueCaptures = match.Groups["value"].Captures;
            long sum = 0L;
            int count = 0;
            for (int i = 0; i < valueCaptures.Count; ++i)
            {
                sum += int.Parse(valueCaptures[i].Value);
                ++count;
            }
            var bytes = BitConverter.GetBytes((int)(sum / count));
            output.Write(bytes, 0, bytes.Length);
        }

        //static readonly Regex regex = new Regex("([^,]*,){6}(?<value>\\d+)(\\.\\d+)?,[^\\n]*", RegexOptions.Compiled);
        //public static void HandOptimized(byte[] input, Stream output)
        //{
        //    var asString = new String(Array.ConvertAll(input, x => (char)x));
        //    var lines = asString.Split('\n');
        //    long sum = 0L;
        //    int count = 0;
        //    foreach (var line in lines)
        //    {
        //        try
        //        {
        //            var match = regex.Match(line);
        //            int x = int.Parse(match.Groups["value"].Value);
        //            sum += x;
        //            ++count;
        //        }
        //        catch
        //        {
        //            break;
        //        }
        //    }
        //    var bytes = BitConverter.GetBytes((int)(sum / count));
        //    output.Write(bytes, 0, bytes.Length);
        //}
    }

    ////Minimum american gross receipts
    //[ParsingMatcher("(([^,]*,){7}(?<value>\\d+)(\\.\\d+)?,[^\\n]*\\n)*", "int")]
    //partial class SBOGrossReceipts : SpecialTransducer { }
    //partial class CSV7a : Composition<AssumeSingleByteChars, SBOGrossReceipts> { }
    //partial class CSV7ab : Composition<CSV7a, Minimum> { }
    //partial class CSV7abc : Composition<CSV7ab, Int32ToBytes> { }
    class ManuaCSV7abc
    {
        public static void GeneratedStages(byte[] input, Stream output)
        {
            var result = Int32ToBytes.Transduce(Minimum.Transduce(SBOGrossReceipts.Transduce(UTF8ToUTF16.Transduce(input)))).ToArray();
            output.Write(result, 0, result.Length);
        }

        static readonly Regex regex = new Regex("(([^,]*,){7}(?<value>\\d+)(\\.\\d+)?,[^\\n]*\\n)*", RegexOptions.Compiled);
        public static void HandOptimized(byte[] input, Stream output)
        {
            var asString = System.Text.Encoding.UTF8.GetString(input);
            var match = regex.Match(asString);
            var valueCaptures = match.Groups["value"].Captures;
            int m = 2147483647;
            for (int i = 0; i < valueCaptures.Count; ++i)
            {
                if (int.Parse(valueCaptures[i].Value) < m)
                {
                    m = int.Parse(valueCaptures[i].Value);
                }
            }
            var bytes = BitConverter.GetBytes(m);
            output.Write(bytes, 0, bytes.Length);
        }

        //static readonly Regex regex = new Regex("([^,]*,){7}(?<value>\\d+)(\\.\\d+)?,[^\\n]*", RegexOptions.Compiled);
        //public static void HandOptimized(byte[] input, Stream output)
        //{
        //    var asString = new String(Array.ConvertAll(input, x => (char)x));
        //    var lines = asString.Split('\n');
        //    int m = 2147483647;
        //    foreach (var line in lines)
        //    {
        //        try
        //        {
        //            var match = regex.Match(line);
        //            int x = int.Parse(match.Groups["value"].Value);
        //            if (x < m)
        //            {
        //                m = x;
        //            }
        //        }
        //        catch
        //        {
        //            break;
        //        }
        //    }
        //    var bytes = BitConverter.GetBytes(m);
        //    output.Write(bytes, 0, bytes.Length);
        //}
    }
}
