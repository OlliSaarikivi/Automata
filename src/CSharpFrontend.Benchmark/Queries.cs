using Microsoft.Automata.CSharpFrontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
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
    }

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
    }

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
    }

    partial class Delta : Transducer<int, int>
    {
        int previous = 0;

        public override IEnumerable<int> Update(int c)
        {
            yield return c - previous;
            previous = c;
        }
    }

    class ProcessMaximum
    {
        public static IEnumerable<int> Process(IEnumerable<int> input)
        {
            int m = -1;
            foreach (var c in input)
            {
                if (c >= m)
                {
                    m = c;
                }
            }
            yield return m;
        }
    }

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
    }

    class ProcessLineCount
    {
        public static IEnumerable<int> Process(IEnumerable<char> input)
        {
            int count = 0;
            foreach (var c in input)
            {
                if (c == '\n')
                {
                    count += 1;
                }
            }
            yield return count;
        }
    }

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
    }

    class ProcessWindowedAverage10
    {
        public static IEnumerable<int> Process(IEnumerable<int> input)
        {
            int offset = 0;
            long v0 = 0, v1 = 0, v2 = 0, v3 = 0, v4 = 0, v5 = 0, v6 = 0, v7 = 0, v8 = 0, v9 = 0;
            foreach (var c in input)
            {
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
                yield return (int)(v0 + v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8 + v9) / 10;
            }
        }
    }

    public partial class FindMatch : Transducer<char, bool>
    {
        bool found = false;
        int matchLen = 0;
        public override IEnumerable<bool> Update(char c)
        {
            if (found)
            {
                yield break;
            }
            int fallback = 0;
            if (c == 'm')
            {
                fallback = 1;
            }

            if (matchLen == 0)
            {
                if (c == 'm')
                {
                    matchLen = 1;
                    yield break;
                }
            }
            else if (matchLen == 1)
            {
                if (c == 'a')
                {
                    matchLen = 2;
                    yield break;
                }
            }
            else if (matchLen == 2)
            {
                if (c == 't')
                {
                    matchLen = 3;
                    yield break;
                }
            }
            else if (matchLen == 3)
            {
                if (c == 'c')
                {
                    matchLen = 4;
                    yield break;
                }
            }
            else if (matchLen == 4)
            {
                if (c == 'h')
                {
                    matchLen = 0;
                    found = true;
                    yield return true;
                    yield break;
                }
            }
            matchLen = fallback;
        }
    }

    public class ProcessStreamingMeanVariance
    {
        public IEnumerable<Tuple<int, int>> MeanVar(IEnumerable<int> input)
        {
            long sum = 0;
            long varSum = 0;
            int count = 0;
            foreach (var x in input)
            {
                ++count;
                sum += x;
                int mean = (int)(sum / count);
                varSum += x - mean;
                int variance = (int)(varSum / count);
                yield return Tuple.Create(mean, variance);
            }
        }
    }

    partial class CRPositions : Transducer<char, int>
    {
        int line = 1;
        int column = 0;

        public override IEnumerable<int> Update(char c)
        {
            if (c == '\r')
            {
                yield return line + column;
            }
            ++column;
            if (c == '\n')
            {
                ++line;
                column = 1;
            }
        }
    }

    partial class ToUnixLineEndings : Transducer<char, char>
    {
        public override IEnumerable<char> Update(char c)
        {
            if (c != '\r')
                yield return c;
        }
    }

    partial class Minimizable : Transducer<byte, byte>
    {
        bool b = false;

        public override IEnumerable<byte> Update(byte datum)
        {
            yield return datum;
            b = !b;
        }
    }
}
