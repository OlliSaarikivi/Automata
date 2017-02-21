using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class Minimum : Transducer<int, int>
    {
        static UInt32 Fun0(UInt32 v0, UInt32 v1)
        {
            return (UInt32)(((((int)((uint)(v1)) <= (int)((uint)(v0)))) ? ((uint)(v1)) : ((uint)(v0))));
        }

        public static IEnumerable<Int32> Transduce(IEnumerable<Int32> input)
        {
            unchecked
            {
                IEnumerator<Int32> ie = input.GetEnumerator();
                UInt32 s = (uint)2147483647U;
                Int32 i;
                M0:
                {
                    if (!ie.MoveNext())
                        goto F0;
                    i = ie.Current;
                    {
                        var temp0 = Fun0(((uint)(i)), ((uint)(s)));
                        s = (uint)(temp0);
                        goto M0;
                    }
                }

                F0:
                {
                    yield return (Int32)(s);
                    yield break;
                }
            }
        }
    }
}