using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Automata.Z3;
using Microsoft.Automata.CSharpFrontend;
using Microsoft.Automata.SimplificationSolver;
using Microsoft.Automata.SimplificationSolver.CodeGen;

namespace SimplificationSolver.Test
{
    [TestClass]
    public class BaseTests
    {
        [TestMethod]
        public void ExploreMaximumTest()
        {
            string program = @"
class Maximum : Transducer<int, int>
{
    int max = 0;

    public override IEnumerable<int> Update(int i)
    {
        if (i > max)
            max = i;
        yield break;
    }

    public override IEnumerable<int> Finish()
    {
        yield return max;
    }
}
";
            Z3Provider solver = new Z3Provider();
            var stbs = CSharpParser.FromString(solver, program);
            var stb = stbs.First();
            var res = Lifter.ToStateComputationSTb(stb);
            var cpp = CppGen.GenerateMultiCore(res.First, res.Second);
        }

        [TestMethod]
        public void ExploreGCDTest()
        {
            string program = @"
class Maximum : Transducer<uint, uint>
{
    bool first = true;
    uint gcd = 0;

    public override IEnumerable<uint> Update(uint i)
    {
        if (first) {
            first = false;
            gcd = i;
            yield break;
        }
        uint c;
        while ( gcd != 0 ) {
            c = gcd; gcd = i%gcd;  i = c;
        }
        yield break;
    }

    public override IEnumerable<uint> Finish()
    {
        yield return gcd;
    }
}
";
            Z3Provider solver = new Z3Provider();
            var stbs = CSharpParser.FromString(solver, program);
            var stb = stbs.First();
            var res = Lifter.ToStateComputationSTb(stb);
            var cpp = CppGen.GenerateMultiCore(res.First, res.Second);
        }

        [TestMethod]
        public void ExploreRegexesTest()
        {
            Z3Provider solver = new Z3Provider();
            var stb = RegexToTransducer.Convert(solver, "Hello");
            var res = Lifter.ToStateComputationSTb(stb);
            var cpp = CppGen.GenerateMultiCore(res.First, res.Second);
        }

        [TestMethod]
        public void ExploreWindowedAverage10Test()
        {
            string program = @"
class WindowedAverage10 : Transducer<int, int>
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
";
            Z3Provider solver = new Z3Provider();
            var stbs = CSharpParser.FromString(solver, program);
            var res = Lifter.ToStateComputationSTb(stbs.First());
            var cpp = CppGen.GenerateMultiCore(res.First, res.Second);
        }

        [TestMethod]
        public void ExploreBase64DecoderTest()
        {
            string program = @"
class Base64Decoder : Transducer<byte, byte>
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
                    //throw new Exception();
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
                    //throw new Exception();
                }
                morePaddingExpected = false;
            }
        }
        else
        {
            if (ending)
            {
                //throw new Exception();
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
";
            Z3Provider solver = new Z3Provider();
            var stbs = CSharpParser.FromString(solver, program);
            var res = Lifter.ToStateComputationSTb(stbs.First());
            var cpp = CppGen.GenerateMultiCore(res.First, res.Second);
        }

        [TestMethod]
        public void ExploreBase64EncoderTest()
        {
            string program = @"
class Base64Encoder : Transducer<byte, byte>
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
";
            Z3Provider solver = new Z3Provider();
            var stbs = CSharpParser.FromString(solver, program);
            var res = Lifter.ToStateComputationSTb(stbs.First());
            var cpp = CppGen.GenerateMultiCore(res.First, res.Second);
        }
    }
}
