using Microsoft.Automata.CSharpFrontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    // The byte order is big-endian
    partial class BytesToInt32 : Transducer<byte, int>
    {
        byte b1, b2, b3;
        int read = 0;

        public override IEnumerable<int> Update(byte c)
        {
            if (read == 0)
            {
                b1 = c;
            }
            else if (read == 1)
            {
                b2 = c;
            }
            else if (read == 2)
            {
                b3 = c;
            }
            else
            {
                yield return (b1 << 24) + (b2 << 16) + (b3 << 8) + c;
                b1 = (byte)0;
                b2 = (byte)0;
                b3 = (byte)0;
            }
            //++read;
            //if (read == 4)
            //{
            //    read = 0;
            //}

            if (read == 0)
            {
                read = 1;
            }
            else if (read == 1)
            {
                read = 2;
            }
            else if (read == 2)
            {
                read = 3;
            }
            else if (read == 3)
            {
                read = 0;
            }
        }
    }

    class ProcessBytesToInt32
    {
        public static IEnumerable<int> Process(IEnumerable<byte> input)
        {
            byte b1 = 0, b2 = 0, b3 = 0;
            int read = 0;
            foreach (var c in input)
            {
                if (read == 0)
                {
                    b1 = c;
                }
                else if (read == 1)
                {
                    b2 = c;
                }
                else if (read == 2)
                {
                    b3 = c;
                }
                else
                {
                    yield return (b1 << 24) + (b2 << 16) + (b3 << 8) + c;
                    b1 = (byte)0;
                    b2 = (byte)0;
                    b3 = (byte)0;
                }
                //++read;
                //if (read == 4)
                //{
                //    read = 0;
                //}

                if (read == 0)
                {
                    read = 1;
                }
                else if (read == 1)
                {
                    read = 2;
                }
                else if (read == 2)
                {
                    read = 3;
                }
                else if (read == 3)
                {
                    read = 0;
                }
            }
        }
    }

    // The byte order is big-endian
    partial class Int32ToBytes : Transducer<int, byte>
    {
        public override IEnumerable<byte> Update(int c)
        {
            yield return (byte)(c >> 24);
            yield return (byte)(c >> 16);
            yield return (byte)(c >> 8);
            yield return (byte)(c);
        }
    }

    class ProcessInt32ToBytes
    {
        public static IEnumerable<byte> Process(IEnumerable<int> input)
        {
            foreach (var c in input)
            {
                yield return (byte)(c >> 24);
                yield return (byte)(c >> 16);
                yield return (byte)(c >> 8);
                yield return (byte)(c & 0xFF);
            }
        }
    }

    partial class FormatInt32Lines : Transducer<int, char>
    {
        int NumDigits(long x)
        {
            int digits = 10;
            for (int i = 999999999; i > 0; i /= 10, --digits)
            {
                if (x > i)
                {
                    return digits;
                }
            }
            return digits;
        }

        int DigitAt(long x, int i)
        {
            int power10 = 1;
            for (int j = 0; j < i; ++j)
            {
                power10 *= 10;
                if (power10 == 1000000000)
                    break;
            }
            return (int)((x / power10) % 10);
        }

        public override IEnumerable<char> Update(int c)
        {
            if (c == 0)
            {
                yield return '0';
                yield break;
            }

            long sign = 1L;
            if (c < 0)
            {
                yield return '-';
                sign = -1L;
            }


            int digits = NumDigits(sign * c);
            int divisor = 1;
            for (int i = 0; i < digits - 1; ++i)
            {
                divisor *= 10;
            }
            for (int i = 0; i < digits; ++i)
            {
                var digit = (c / divisor) % 10;
                yield return (char)(sign * digit + '0');
                divisor /= 10;
            }

            //int digits = NumDigits(sign * c);
            //int digits = 10;
            //for (int i = 999999999; i > 0; i /= 10, --digits)
            //{
            //    if (sign * c > i)
            //    {
            //        break;
            //    }
            //}

            //for (int i = digits - 1; i >= 0; --i)
            //{
            //    yield return (char)(DigitAt(sign * digits, i) + '0');
            //}

            //bool started = false;
            //for (int i = 1000000000; i > 0; i /= 10)
            //{
            //    var digit = (c / i) % 10;
            //    if (digit != 0 | started)
            //    {
            //        started = true;
            //        yield return (char)(sign * digit + '0');
            //    }
            //}

            yield return '\n';
        }

        //public override IEnumerable<char> Update(int c)
        //{
        //    if (c == 0)
        //    {
        //        yield return '0';
        //        yield break;
        //    }

        //    long sign = 1L;
        //    if (c < 0)
        //    {
        //        yield return '-';
        //        sign = -1L;
        //    }

        //    int digits = 1;
        //    long limit = 9;
        //    while (sign * ((long)c) > limit)
        //    {
        //        digits += 1;
        //        limit = 10 * limit + 9;
        //    }

        //    while (digits > 0)
        //    {
        //        int m = Power10(digits - 1);
        //        int digit = c / m;
        //        yield return (char)(sign * digit + '0');
        //        c -= digit * m;
        //        digits -= 1;
        //    }

        //    yield return '\n';
        //}
    }

    class ProcessFormatInt32Lines
    {
        int Power10(int x)
        {
            int result = 1;
            for (int i = 0; i < x; ++i)
            {
                result *= 10;
            }
            return result;
        }

        public static IEnumerable<char> Process(IEnumerable<int> input)
        {
            foreach (var c in input)
            {
                if (c == 0)
                {
                    yield return '0';
                    yield break;
                }

                long sign = 1L;
                if (c < 0)
                {
                    yield return '-';
                    sign = -1L;
                }

                bool started = false;
                for (int i = 1000000000; i > 0; i /= 10)
                {
                    var digit = (c / i) % 10;
                    if (digit != 0 | started)
                    {
                        started = true;
                        yield return (char)(sign * digit + '0');
                    }
                }

                yield return '\n';
            }
        }
    }


    partial class SQLInsertInt32 : Transducer<int, char>
    {
        int NumDigits(long x)
        {
            int digits = 10;
            for (int i = 999999999; i > 0; i /= 10, --digits)
            {
                if (x > i)
                {
                    return digits;
                }
            }
            return digits;
        }

        int DigitAt(long x, int i)
        {
            int power10 = 1;
            for (int j = 0; j < i; ++j)
            {
                power10 *= 10;
                if (power10 == 1000000000)
                    break;
            }
            return (int)((x / power10) % 10);
        }

        public override IEnumerable<char> Update(int c)
        {
            yield return 'I';
            yield return 'N';
            yield return 'S';
            yield return 'E';
            yield return 'R';
            yield return 'T';
            yield return ' ';
            yield return 'I';
            yield return 'N';
            yield return 'T';
            yield return 'O';
            yield return ' ';
            yield return 'A';
            yield return 'c';
            yield return 'c';
            yield return 'o';
            yield return 'u';
            yield return 'n';
            yield return 't';
            yield return 's';
            yield return '\n';
            yield return 'V';
            yield return 'A';
            yield return 'L';
            yield return 'U';
            yield return 'E';
            yield return 'S';
            yield return ' ';
            yield return '(';

            if (c == 0)
            {
                yield return '0';
                yield break;
            }

            long sign = 1L;
            if (c < 0)
            {
                yield return '-';
                sign = -1L;
            }
            
            int digits = NumDigits(sign * c);
            int divisor = 1;
            for (int i = 0; i < digits - 1; ++i)
            {
                divisor *= 10;
            }
            for (int i = 0; i < digits; ++i)
            {
                var digit = (c / divisor) % 10;
                yield return (char)(sign * digit + '0');
                divisor /= 10;
            }

            yield return ')';
            yield return ';';
            yield return '\n';
        }
    }
}
