using Microsoft.Automata.CSharpFrontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    public partial class FibonacciGenerator : Transducer<byte, int>
    {
        int f1 = 1, f2 = 1;

        public override IEnumerable<int> Update(byte ignore)
        {
            int f3 = f1 + f2;
            yield return f3;
            f1 = f2;
            f2 = f3;

            if (f3 < 0)
            {
                f1 = 1;
                f2 = 1;
            }
        }
    }

    public partial class OnlyFibonacci : Transducer<int, int>
    {
        bool IsFibonacci(int c)
        {
            if (c == 1)
            {
                return true;
            }
            int fpp = 1;
            int fp = 1;
            for (int i = 3; i < 47; ++i)
            {
                int f = fpp + fp;
                if (c == f)
                {
                    return true;
                }
                fpp = fp;
                fp = f;
            }
            return false;
        }

        public override IEnumerable<int> Update(int c)
        {
            if (IsFibonacci(c))
            {
                yield return c;
            }
        }
    }
}
