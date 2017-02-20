using Microsoft.Automata.CSharpFrontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    [SuppressCodeGeneration()]
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
    }

    public class ProcessBase64Decoder
    {
        static int DecodeValue(byte c)
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

        public static IEnumerable<byte> Process(IEnumerable<byte> input)
        {
            byte previousValue = 0;
            int bitsNeeded = 0;
            bool ending = false;
            bool morePaddingExpected = true;

            foreach (var c in input)
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
            if (morePaddingExpected)
            {
                throw new Exception();
            }
        }
    }

    [SuppressCodeGeneration()]
    partial class Base64Encoder : Transducer<byte, byte>
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
    }

    public class ProcessBase64Encoder
    {

        static byte EncodeIndex(int index)
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

        public static IEnumerable<byte> Process(IEnumerable<byte> input)
        {
            byte previous = 0;
            int indexInGroup = 0;

            foreach (var c in input)
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
        }
    }
}
