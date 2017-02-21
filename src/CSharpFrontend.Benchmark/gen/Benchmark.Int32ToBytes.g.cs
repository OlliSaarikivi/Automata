using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class Int32ToBytes : Transducer<int, byte>
    {
        public static IEnumerable<Byte> Transduce(IEnumerable<Int32> input)
        {
            unchecked
            {
                IEnumerator<Int32> ie = input.GetEnumerator();
                object s = new object ();
                Int32 i;
                M0:
                {
                    if (!ie.MoveNext())
                        goto F0;
                    i = ie.Current;
                    {
                        var temp0 = ((uint)(((int)((uint)(i))) >> (int)((uint)((uint)24U))));
                        yield return (Byte)(((byte)((uint)(temp0))));
                        var temp1 = ((uint)(((int)((uint)(i))) >> (int)((uint)((uint)16U))));
                        yield return (Byte)(((byte)((uint)(temp1))));
                        var temp2 = ((uint)(((int)((uint)(i))) >> (int)((uint)((uint)8U))));
                        yield return (Byte)(((byte)((uint)(temp2))));
                        yield return (Byte)(((byte)((uint)(i))));
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