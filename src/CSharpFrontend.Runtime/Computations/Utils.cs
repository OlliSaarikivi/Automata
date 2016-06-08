using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Runtime
{
    static class Utils
    {
        public static int HashCombine(int seed, int hash)
        {
            // This technique is also used in the boost libraries
            return seed ^ (int)(hash + 0x9e3779b9 + (seed << 6) + (seed >> 2));
        }
    }
}
