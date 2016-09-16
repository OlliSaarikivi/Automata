using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimizationBenchmark
{
    static partial class Transducers
    {
        public const string UTF8Fix = @"
partial class UTF8Fix : Transducer<byte, byte>
{
    byte b1, b2;
    bool read2;
    int state;

    public override IEnumerable<byte> Update(byte c)
    {
    START:
        if (state == 0)
        {
            if ((0 <= c) & (c <= 0x7F))
            {
                yield return c;
            }
            else if ((0xC2 <= c) & (c <= 0xDF))
            {
                state = 2;
                b1 = c;
            }
            else if (c == 0xE0)
            {
                state = 4;
                b1 = c;
            }
            else if (c == 0xED)
            {
                state = 5;
                b1 = c;
            }
            else if ((0xE1 <= c) & (c <= 0xEF))
            {
                state = 3;
                b1 = c;
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
                if (read2)
                {
                    yield return b1;
                    yield return b2;
                    yield return c;
                }
                else
                {
                    yield return b1;
                    yield return c;
                }
                state = 0;
                read2 = false;
            }
            else
            {
                yield return (byte)'?';
                state = 0;
                read2 = false;
                goto START;
            }
        }
        else if (state == 3)
        {
            if ((0x80 <= c) & (c <= 0xBF))
            {
                state = 2;
                read2 = true;
                b2 = c;
            }
            else
            {
                yield return (byte)'?';
                state = 0;
                goto START;
            }
        }
        else if (state == 4)
        {
            if ((0xA0 <= c) & (c <= 0xBF))
            {
                state = 2;
                read2 = true;
                b2 = c;
            }
            else
            {
                yield return (byte)'?';
                state = 0;
                goto START;
            }
        }
        else if (state == 5)
        {
            if ((0x80 <= c) & (c <= 0x9F))
            {
                state = 2;
                read2 = true;
                b2 = c;
            }
            else
            {
                yield return (byte)'?';
                state = 0;
                goto START;
            }
        }
    }
}";

        public const string SloppyUTF8ToUTF16 = @"
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
            if ((0xC2 <= c) & (c <= 0xDF))
            {
                state = 2;
                r = (char)(c & 0x1F);
            }
            else if ((0xE0 <= c) & (c <= 0xEF))
            {
                state = 3;
                r = (char)(c & 0x0F);
            }
            else
            {
                yield return (char)c;
            }
        }
        else if (state == 2)
        {
            yield return Fuse(r, (char)c);
            state = 0;
            r = (char)0;
        }
        else if (state == 3)
        {
            state = 2;
            r = Fuse(r, (char)c);
        }
    }
}";
        public const string UTF16FixSurrogates = @"
partial class UTF16FixSurrogates : Transducer<char, char>
{
    bool wasHigh = false;
    char previous;

    bool IsHigh(char c)
    {
        return 55296 <= c & c <= 56319;
    }

    bool IsLow(char c)
    {
        return 56320 <= c & c <= 57343;
    }

    public override IEnumerable<char> Update(char c)
    {
        if (wasHigh)
        {
            if (IsHigh(c))
            {
                yield return '\xFFFD';
                previous = c;
            }
            else
            {
                if (IsLow(c))
                {
                    yield return previous;
                }
                else
                {
                    yield return '\xFFFD';
                }
                yield return c;
                previous = (char)0;
                wasHigh = false;
            }
        }
        else
        {
            if (IsHigh(c))
            {
                previous = c;
                wasHigh = true;
            }
            else
            {
                if (IsLow(c))
                {
                    yield return '\xFFFD';
                }
                else
                {
                    yield return c;
                }
                previous = (char)0;
            }
        }
    }

    public override IEnumerable<char> Finish()
    {
        if (wasHigh)
        {
            yield return '\xFFFD';
        }
    }
}";
        public const string Exploding = EnglishHuffmanDecoder + UTF8Fix + SloppyUTF8ToUTF16 + UTF16FixSurrogates + @"
partial class C1 : Composition<EnglishHuffmanDecoder, UTF8Fix> { }
partial class C2 : Composition<C1, SloppyUTF8ToUTF16> { }
partial class C3 : Composition<C2, UTF16FixSurrogates> { }";
    }
}
