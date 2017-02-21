using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class LineCount : Transducer<char, int>
    {
        public static IEnumerable<Int32> Transduce(IEnumerable<Char> input)
        {
            unchecked
            {
                IEnumerator<Char> ie = input.GetEnumerator();
                UInt32 s = (uint)0U;
                Char i;
                M0:
                {
                    if (!ie.MoveNext())
                        goto F0;
                    i = ie.Current;
                    {
                        var temp0 = (((ushort)(i)) == ((ushort)((ushort)10U)));
                        if (temp0)
                        {
                            var temp1 = ((uint)(((uint)((uint)1U)) + ((uint)(s))));
                            s = (uint)(temp1);
                            goto M0;
                        }
                        else
                        {
                            goto M0;
                        }
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