using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimizationBenchmark
{
    static partial class Transducers
    {
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
        public const string Exploding = EnglishHuffmanDecoder + UTF8ToUTF16 + UTF16FixSurrogates + @"
partial class C1 : Composition<EnglishHuffmanDecoder, UTF8ToUTF16> { }
partial class C2 : Composition<C1, UTF16FixSurrogates> { }";
    }
}
