using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    public partial class FibonacciGenerator : Transducer<byte, int>
    {
        struct DTStruct0
        {
            public UInt32 _0;
            public UInt32 _1;
            public DTStruct0(UInt32 v0, UInt32 v1)
            {
                _0 = v0;
                _1 = v1;
            }
        }

        public static IEnumerable<Int32> Transduce(IEnumerable<Byte> input)
        {
            unchecked
            {
                IEnumerator<Byte> ie = input.GetEnumerator();
                DTStruct0 s = new DTStruct0(((uint)((uint)1U)), ((uint)((uint)1U)));
                Byte i;
                M0:
                {
                    if (!ie.MoveNext())
                        goto F0;
                    i = ie.Current;
                    {
                        var temp0 = ((uint)(((uint)((s)._0)) + ((uint)((s)._1))));
                        var temp1 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp0)));
                        var temp2 = !(temp1);
                        if (temp2)
                        {
                            yield return (Int32)(temp0);
                            s._1 = ((uint)((uint)1U));
                            s._0 = ((uint)((uint)1U));
                            goto M0;
                        }
                        else
                        {
                            yield return (Int32)(temp0);
                            UInt32 t1 = ((uint)(temp0));
                            s._0 = ((uint)((s)._1));
                            s._1 = t1;
                            goto M0;
                        }
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