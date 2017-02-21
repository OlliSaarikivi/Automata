using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class Delta : Transducer<int, int>
    {
        public static IEnumerable<Int32> Transduce(IEnumerable<Int32> input)
        {
            unchecked
            {
                IEnumerator<Int32> ie = input.GetEnumerator();
                UInt32 s = (uint)0U;
                Int32 i;
                M0:
                {
                    if (!ie.MoveNext())
                        goto F0;
                    i = ie.Current;
                    {
                        var temp0 = ((uint)(((uint)((uint)4294967295U)) * ((uint)(s))));
                        var temp1 = ((uint)(((uint)(i)) + ((uint)(temp0))));
                        yield return (Int32)(temp1);
                        s = (uint)(i);
                        goto M0;
                    }
                }

                F0:
                {
                    yield break;
                }
            }
        }
    }
}