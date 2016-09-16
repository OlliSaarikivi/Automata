using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimizationBenchmark
{
    static partial class Transducers
    {
        public const string UTF8ToUTF16 = @"
partial class UTF8ToUTF16 : Transducer<byte, char>
{
    int state;
    char r;

    char Fuse(char r, char c)
    {
        return (char)((r << 6) | (c & 0x3F));
    }

    public override IEnumerable<char> Update(byte c)
    {
        if (state == 0)
        {
            if ((0 <= c) & (c <= 0x7F))
            {
                yield return (char)c;
            }
            else if ((0xC2 <= c) & (c <= 0xDF))
            {
                state = 2;
                r = (char)(c & 0x1F);
            }
            else if (c == 0xE0)
            {
                state = 4;
                r = (char)(c & 0x0F);
            }
            else if (c == 0xED)
            {
                state = 5;
                r = (char)(c & 0x0F);
            }
            else if ((0xE1 <= c) & (c <= 0xEF))
            {
                state = 3;
                r = (char)(c & 0x0F);
            }
            else
            {
                throw new Exception();
            }
        }
        else if (state == 2)
        {
            if ((0x80 <= c) & (c <= 0xBF))
            {
                yield return Fuse(r, (char)c);
                state = 0;
                r = (char)0;
            }
            else
            {
                throw new Exception();
            }
        }
        else if (state == 3)
        {
            if ((0x80 <= c) & (c <= 0xBF))
            {
                state = 2;
                r = Fuse(r, (char)c);
            }
            else
            {
                throw new Exception();
            }
        }
        else if (state == 4)
        {
            if ((0xA0 <= c) & (c <= 0xBF))
            {
                state = 2;
                r = Fuse(r, (char)c);
            }
            else
            {
                throw new Exception();
            }
        }
        else if (state == 5)
        {
            if ((0x80 <= c) & (c <= 0x9F))
            {
                state = 2;
                r = Fuse(r, (char)c);
            }
            else
            {
                throw new Exception();
            }
        }
    }
}";
        public const string LineCount = @"
partial class LineCount : Transducer<char, int>
{
    int count = 0;

    public override IEnumerable<int> Update(char c)
    {
        if (c == '\n')
        {
            count += 1;
        }
        yield break;
    }

    public override IEnumerable<int> Finish()
    {
        yield return count;
    }
}";
        public const string Delta = @"
partial class Delta : Transducer<int, int>
{
    int previous = 0;

    public override IEnumerable<int> Update(int c)
    {
        yield return c - previous;
        previous = c;
    }
}";
        public const string FormatInt32Lines = @"
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

        yield return '\n';
    }
}";
        public const string UTF16ToUTF8 = @"
partial class UTF16ToUTF8 : Transducer<char, byte>
{
    bool wasHigh = false;
    byte highBits;

    public override IEnumerable<byte> Update(char c)
    {
        if (wasHigh)
        {
            if ((0xDC00 <= c) & (c <= 0xDFFF))
            {//low surrogate
                wasHigh = false;
                highBits = 0;
                yield return (byte)((0x80 | (highBits << 4)) | ((c >> 6) & 0xF));
                yield return (byte)(0x80 | (c & 0x3F));
            }
            else
            {
                throw new Exception();
            }
        }
        else
        {
            if ((0 <= c) & (c <= 0x7F))
            {
                yield return (byte)c;
            }
            else if ((0x7F < c) & (c <= 0x7FF))
            {
                yield return (byte)(0xC0 | ((c >> 6) & 0x1F));
                yield return (byte)(0x80 | (c & 0x3F));
            }
            else if ((0x7FF < c) & (c <= 0xFFFF) & ((c < 0xD800) | (c > 0xDFFF)))
            {
                yield return (byte)(0xE0 | ((c >> 12) & 0xF));
                yield return (byte)(0x80 | ((c >> 6) & 0x3F));
                yield return (byte)(0x80 | (c & 0x3F));
            }
            else if ((0xD800 <= c) & (c <= 0xDBFF))
            {//high surrogate
                wasHigh = true;
                highBits = (byte)(c & 3);
                yield return (byte)(0xF0 | (((1 + ((c >> 6) & 0xF)) >> 2) & 7));
                yield return (byte)((0x80 | (((1 + ((c >> 6) & 0xF)) & 3) << 4)) | ((c >> 2) & 0xF));
            }
            else
            {
                throw new Exception();
            }
        }
    }

    public override IEnumerable<byte> Finish()
    {
        if (wasHigh)
        {
            throw new Exception();
        }
        yield break;
    }
}";
        public const string Maximum = @"
partial class Maximum : Transducer<int, int>
{
    int m = -1;

    int Max(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    public override IEnumerable<int> Update(int c)
    {
        //if (c >= m)
        //{
        //    m = c;
        //}
        m = Max(c, m);
        yield break;
    }

    public override IEnumerable<int> Finish()
    {
        yield return m;
    }
}";
        public const string Minimum = @"
partial class Minimum : Transducer<int, int>
{
    int m = 2147483647;

    int Min(int a, int b)
    {
        if (a < b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    public override IEnumerable<int> Update(int c)
    {
        m = Min(c, m);
        yield break;
    }

    public override IEnumerable<int> Finish()
    {
        yield return m;
    }
}";
        public const string Average = @"
partial class Average : Transducer<int, int>
{
    long sum = 0L;
    int count = 0;

    public override IEnumerable<int> Update(int datum)
    {
        sum += datum;
        ++count;
        yield break;
    }

    public override IEnumerable<int> Finish()
    {
        if (count == 0)
            yield return 0;
        else
            yield return (int)(sum / count);
    }
}";
        public const string Base64Encoder = @"partial class Base64Encoder : Transducer<byte, byte>
{
    byte previous;
    int indexInGroup = 0;

    byte EncodeIndex(int index)
    {
        if (0 <= index & index <= 25)
        {
            return (byte)('A' + index);
        }
        else if (26 <= index & index <= 51)
        {
            return (byte)('a' + (index - 26));
        }
        else if (52 <= index & index <= 61)
        {
            return (byte)('0' + (index - 52));
        }
        else if (index == 62)
        {
            return (byte)'+';
        }
        else
        {
            return (byte)'/';
        }
    }

    public override IEnumerable<byte> Update(byte c)
    {
        int index;
        if (indexInGroup == 0)
        {
            index = (c >> 2) & 0x3f;
        }
        else if (indexInGroup == 1)
        {
            index = ((previous & 0x3) << 4) | ((c >> 4) & 0xf);
        }
        else
        {
            index = ((previous & 0xf) << 2) | ((c >> 6) & 0x3);
        }

        //indexInGroup = (indexInGroup + 1) % 3;

        if (indexInGroup == 0)
            indexInGroup = 1;
        else if (indexInGroup == 1)
            indexInGroup = 2;
        else if (indexInGroup == 2)
            indexInGroup = 0;

        previous = c;

        yield return EncodeIndex(index);

        if (indexInGroup == 0)
        {
            index = c & 0x3f;
            yield return EncodeIndex(index);
            previous = 0;
        }
    }

    public override IEnumerable<byte> Finish()
    {
        int index;
        if (indexInGroup == 0)
        {
            yield break;
        }
        else if (indexInGroup == 1)
        {
            index = (previous & 0x3) << 4;
        }
        else
        {
            index = ((previous & 0xf) << 2);
        }

        yield return EncodeIndex(index);

        // Add padding
        if (indexInGroup == 1)
        {
            yield return (byte)'=';
            yield return (byte)'=';
        }
        else
        {
            yield return (byte)'=';
        }
    }
}";
        public const string Base64Decoder = @"
partial class Base64Decoder : Transducer<byte, byte>
{
    byte previousValue;
    int bitsNeeded = 0;
    bool ending = false;
    bool morePaddingExpected;

    int DecodeValue(byte c)
    {
        if ('A' <= c & c <= 'Z')
        {
            return c - 'A';
        }
        else if ('a' <= c & c <= 'z')
        {
            return 26 + (c - 'a');
        }
        else if ('0' <= c & c <= '9')
        {
            return 52 + (c - '0');
        }
        else if (c == '+')
        {
            return 62;
        }
        else
        {
            return 63;
        }
    }

    public override IEnumerable<byte> Update(byte c)
    {
        if (c == '=')
        {
            if (!ending)
            {
                ending = true;
                if (bitsNeeded == 0 | bitsNeeded == 2)
                {
                    throw new Exception();
                }
                else
                {
                    morePaddingExpected = (bitsNeeded == 4);
                }
            }
            else
            {
                if (!morePaddingExpected)
                {
                    throw new Exception();
                }
                morePaddingExpected = false;
            }
        }
        else
        {
            if (ending)
            {
                throw new Exception();
            }

            int value = DecodeValue(c);

            if (bitsNeeded != 0)
            {
                yield return (byte)((previousValue << bitsNeeded) | (value >> (6 - bitsNeeded)));
            }
            previousValue = (byte)value;

            //bitsNeeded = (bitsNeeded + 2) % 8;

            if (bitsNeeded == 0)
                bitsNeeded = 2;
            else if (bitsNeeded == 2)
                bitsNeeded = 4;
            else if (bitsNeeded == 4)
                bitsNeeded = 6;
            else if (bitsNeeded == 6)
            {
                bitsNeeded = 0;
                previousValue = 0;
            }
        }
    }

    public override IEnumerable<byte> Finish()
    {
        if (morePaddingExpected)
        {
            throw new Exception();
        }
        yield break;
    }
}";
        public const string WindowedAverage10 = @"
partial class WindowedAverage10 : Transducer<int, int>
{
    long v0, v1, v2, v3, v4, v5, v6, v7, v8, v9;
    int offset;

    public override IEnumerable<int> Update(int c)
    {
        if (offset == 0)
        {
            v0 = c;
            offset = 1;
        }
        else if (offset == 1)
        {
            v1 = c;
            offset = 2;
        }
        else if (offset == 2)
        {
            v2 = c;
            offset = 3;
        }
        else if (offset == 3)
        {
            v3 = c;
            offset = 4;
        }
        else if (offset == 4)
        {
            v4 = c;
            offset = 5;
        }
        else if (offset == 5)
        {
            v5 = c;
            offset = 6;
        }
        else if (offset == 6)
        {
            v6 = c;
            offset = 7;
        }
        else if (offset == 7)
        {
            v7 = c;
            offset = 8;
        }
        else if (offset == 8)
        {
            v8 = c;
            offset = 9;
        }
        else
        {
            v9 = c;
            offset = 0;
        }
        //offset = (offset + 1) % 10;
        yield return (int)(v0 + v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8 + v9) / 10;
    }
}";
        public const string SQLInsertInt32 = @"
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
}";
        public const string BytesToInt32 = @"
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
}";
        public const string Int32ToBytes = @"
partial class Int32ToBytes : Transducer<int, byte>
{
    public override IEnumerable<byte> Update(int c)
    {
        yield return (byte)(c >> 24);
        yield return (byte)(c >> 16);
        yield return (byte)(c >> 8);
        yield return (byte)(c);
    }
}";
    }
}
