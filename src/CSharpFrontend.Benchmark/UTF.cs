using Microsoft.Automata.CSharpFrontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
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
    }

    class ProcessUTF8ToUTF16
    {
        static byte Fuse(byte r, byte c)
        {
            return (byte)((r << 6) | (c & 0x3F));
        }

        public static IEnumerable<char> Process(IEnumerable<byte> input)
        {
            int state = 0;
            byte r = 0;
            foreach (var c in input)
            {
                switch (state)
                {
                    case 0:
                        if ((0 <= c) & (c <= 0x7F))
                        {
                            yield return (char)c;
                        }
                        else if ((0xC2 <= c) & (c <= 0xDF))
                        {
                            state = 2;
                            r = (byte)(c & 0x1F);
                        }
                        else if (c == 0xE0)
                        {
                            state = 4;
                            r = (byte)(c & 0x0F);
                        }
                        else if (c == 0xED)
                        {
                            state = 5;
                            r = (byte)(c & 0x0F);
                        }
                        else if ((0xE1 <= c) & (c <= 0xEF))
                        {
                            state = 3;
                            r = (byte)(c & 0x0F);
                        }
                        else
                        {
                            throw new Exception();
                        }
                        break;
                    case 2:
                        if ((0x80 <= c) & (c <= 0xBF))
                        {
                            yield return (char)Fuse(r, c);
                            state = 0;
                            r = 0;
                        }
                        else
                        {
                            throw new Exception();
                        }
                        break;
                    case 3:
                        if ((0x80 <= c) & (c <= 0xBF))
                        {
                            state = 2;
                            r = Fuse(r, c);
                        }
                        else
                        {
                            throw new Exception();
                        }
                        break;
                    case 4:
                        if ((0xA0 <= c) & (c <= 0xBF))
                        {
                            state = 2;
                            r = Fuse(r, c);
                        }
                        else
                        {
                            throw new Exception();
                        }
                        break;
                    case 5:
                        if ((0x80 <= c) & (c <= 0x9F))
                        {
                            state = 2;
                            r = Fuse(r, c);
                        }
                        else
                        {
                            throw new Exception();
                        }
                        break;
                }
            }
        }
    }

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
    }

    class ProcessUTF16ToUTF8
    {
        public static IEnumerable<byte> Process(IEnumerable<char> input)
        {
            bool wasHigh = false;
            byte highBits = 0;
            foreach (var c in input)
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
            if (wasHigh)
            {
                throw new Exception();
            }
        }
    }

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
    }



    class ProcessUTF16FixSurrogates
    {
        static bool isHigh(char c)
        {
            return 55296 <= c && c <= 56319;
        }
        static bool isLow(char c)
        {
            return 56320 <= c && c <= 57343;
        }
        const char replacementChar = '\xFFFD';

        public static IEnumerable<char> Process(IEnumerable<char> input)
        {
            var data = input.GetEnumerator();

        NotHigh:
            while (data.MoveNext())
            {
                if (isHigh(data.Current))
                {// Found a high surrogate. No replacement char if next is a low surrogate.
                    var previous = data.Current;
                    while (data.MoveNext())
                    {
                        if (isHigh(data.Current))
                        {// High after high
                            yield return replacementChar;
                        }
                        else if (isLow(data.Current))
                        {
                            yield return previous;
                            yield return data.Current;
                            goto NotHigh; // Return to normal processing.
                        }
                        else
                        {// Lone high surrogate.
                            yield return replacementChar;
                            yield return data.Current;
                            goto NotHigh; // Return to normal processing.
                        }
                    }
                    // If the string ends with a high surrogate output replacement.
                    yield return replacementChar;
                }
                else if (isLow(data.Current))
                {// Low without high
                    yield return replacementChar;
                }
                else
                {
                    yield return data.Current;
                }
            }
        }
    }


    partial class AssertLatin1 : Transducer<byte, char>
    {
        public override IEnumerable<char> Update(byte b)
        {
            if ((0x20 <= b & b <= 0x7E) | (0xA0 <= b & b <= 0xFF))
            {
                yield return (char)b;
            }
            throw new Exception();
        }
    }

    partial class AssumeSingleByteChars : Transducer<byte, char>
    {
        public override IEnumerable<char> Update(byte b)
        {
            yield return (char)b;
        }
    }
}
