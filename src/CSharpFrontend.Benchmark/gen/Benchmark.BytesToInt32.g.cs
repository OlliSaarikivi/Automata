using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class BytesToInt32 : Transducer<byte, int>
    {
        struct DTStruct6
        {
            public Byte _0;
            public Byte _1;
            public Byte _2;
            public DTStruct6(Byte v0, Byte v1, Byte v2)
            {
                _0 = v0;
                _1 = v1;
                _2 = v2;
            }
        }

        public static IEnumerable<Int32> Transduce(IEnumerable<Byte> input)
        {
            unchecked
            {
                IEnumerator<Byte> ie = input.GetEnumerator();
                DTStruct6 s = new DTStruct6(((byte)((byte)0U)), ((byte)((byte)0U)), ((byte)((byte)0U)));
                Byte i;
                M0:
                {
                    if (!ie.MoveNext())
                        goto F0;
                    i = ie.Current;
                    {
                        s._0 = ((byte)(i));
                        goto M1;
                    }
                }

                M1:
                {
                    if (!ie.MoveNext())
                        goto F1;
                    i = ie.Current;
                    {
                        s._1 = ((byte)(i));
                        goto M2;
                    }
                }

                M2:
                {
                    if (!ie.MoveNext())
                        goto F2;
                    i = ie.Current;
                    {
                        s._2 = ((byte)(i));
                        goto M3;
                    }
                }

                M3:
                {
                    if (!ie.MoveNext())
                        goto F3;
                    i = ie.Current;
                    {
                        var temp0 = ((((uint)((byte)((s)._0)) << 8) | (uint)((byte)((s)._1)) << 8) | (uint)((byte)((s)._2)) << 8) | (uint)((byte)(i));
                        yield return (Int32)(temp0);
                        s._2 = ((byte)((byte)0U));
                        s._1 = ((byte)((byte)0U));
                        s._0 = ((byte)((byte)0U));
                        goto M0;
                    }
                }

                F0:
                {
                    yield break;
                }

                F1:
                {
                    yield break;
                }

                F2:
                {
                    yield break;
                }

                F3:
                {
                    yield break;
                }
            }
        }
    }
}