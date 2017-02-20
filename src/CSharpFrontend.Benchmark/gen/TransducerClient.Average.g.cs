using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class Average : Transducer<int, int>
    {
        struct DTStruct0
        {
            public UInt64 _0;
            public UInt32 _1;
            public DTStruct0(UInt64 v0, UInt32 v1)
            {
                _0 = v0;
                _1 = v1;
            }
        }

        public static IEnumerable<Int32> Transduce(IEnumerable<Int32> input)
        {
            unchecked
            {
                IEnumerator<Int32> ie = input.GetEnumerator();
                DTStruct0 s = new DTStruct0(((ulong)((ulong)0UL)), ((uint)((uint)0U)));
                Int32 i;
                M0:
                {
                    if (!ie.MoveNext())
                        goto F0;
                    i = ie.Current;
                    {
                        var temp7 = ((uint)(((uint)((uint)1U)) + ((uint)((s)._1))));
                        s._1 = ((uint)(temp7));
                        var temp8 = ((byte)(((uint)(i)) >> 31));
                        var temp9 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 1) | (ulong)((byte)(temp8 & 1L)) << 32) | (ulong)((uint)(i));
                        var temp10 = ((ulong)(((ulong)((s)._0)) + ((ulong)(temp9))));
                        s._0 = ((ulong)(temp10));
                        goto M0;
                    }
                }

                F0:
                {
                    var temp0 = (((uint)((s)._1)) == ((uint)((uint)0U)));
                    if (temp0)
                    {
                        yield return (Int32)((uint)0U);
                        yield break;
                    }
                    else
                    {
                        var temp1 = ((byte)(((uint)((s)._1)) >> 31));
                        var temp2 = (((byte)(temp1 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp3 = ((temp0) && (temp2));
                        var temp4 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 32) | (ulong)((uint)((s)._1));
                        var temp5 = ((ulong)((long)((ulong)((s)._0)) / (long)((ulong)(temp4))));
                        var temp6 = ((temp3) ? ((uint)(((uint)((ulong)(((ulong)((s)._0))))))) : ((uint)(((uint)((ulong)(temp5))))));
                        yield return (Int32)(temp6);
                        yield break;
                    }
                }
            }
        }
    }
}