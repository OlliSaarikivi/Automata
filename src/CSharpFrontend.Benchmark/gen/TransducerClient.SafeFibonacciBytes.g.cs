using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class SafeFibonacciBytes : Composition<SafeFibonacci, Int32ToBytes>
    {
        static Boolean Fun0(UInt32 v0)
        {
            return (Boolean)(((((((((((((((((((((((((((((((((((((((((((((((((uint)(v0)) == ((uint)((uint)1U)))) || ((((uint)(v0)) == ((uint)((uint)2U))))) || ((((uint)(v0)) == ((uint)((uint)3U))))) || ((((uint)(v0)) == ((uint)((uint)5U))))) || ((((uint)(v0)) == ((uint)((uint)8U))))) || ((((uint)(v0)) == ((uint)((uint)13U))))) || ((((uint)(v0)) == ((uint)((uint)21U))))) || ((((uint)(v0)) == ((uint)((uint)34U))))) || ((((uint)(v0)) == ((uint)((uint)55U))))) || ((((uint)(v0)) == ((uint)((uint)89U))))) || ((((uint)(v0)) == ((uint)((uint)144U))))) || ((((uint)(v0)) == ((uint)((uint)233U))))) || ((((uint)(v0)) == ((uint)((uint)377U))))) || ((((uint)(v0)) == ((uint)((uint)610U))))) || ((((uint)(v0)) == ((uint)((uint)987U))))) || ((((uint)(v0)) == ((uint)((uint)1597U))))) || ((((uint)(v0)) == ((uint)((uint)2584U))))) || ((((uint)(v0)) == ((uint)((uint)4181U))))) || ((((uint)(v0)) == ((uint)((uint)6765U))))) || ((((uint)(v0)) == ((uint)((uint)10946U))))) || ((((uint)(v0)) == ((uint)((uint)17711U))))) || ((((uint)(v0)) == ((uint)((uint)28657U))))) || ((((uint)(v0)) == ((uint)((uint)46368U))))) || ((((uint)(v0)) == ((uint)((uint)75025U))))) || ((((uint)(v0)) == ((uint)((uint)121393U))))) || ((((uint)(v0)) == ((uint)((uint)196418U))))) || ((((uint)(v0)) == ((uint)((uint)317811U))))) || ((((uint)(v0)) == ((uint)((uint)514229U))))) || ((((uint)(v0)) == ((uint)((uint)832040U))))) || ((((uint)(v0)) == ((uint)((uint)1346269U))))) || ((((uint)(v0)) == ((uint)((uint)2178309U))))) || ((((uint)(v0)) == ((uint)((uint)3524578U))))) || ((((uint)(v0)) == ((uint)((uint)5702887U))))) || ((((uint)(v0)) == ((uint)((uint)9227465U))))) || ((((uint)(v0)) == ((uint)((uint)14930352U))))) || ((((uint)(v0)) == ((uint)((uint)24157817U))))) || ((((uint)(v0)) == ((uint)((uint)39088169U))))) || ((((uint)(v0)) == ((uint)((uint)63245986U))))) || ((((uint)(v0)) == ((uint)((uint)102334155U))))) || ((((uint)(v0)) == ((uint)((uint)165580141U))))) || ((((uint)(v0)) == ((uint)((uint)267914296U))))) || ((((uint)(v0)) == ((uint)((uint)433494437U))))) || ((((uint)(v0)) == ((uint)((uint)701408733U))))) || ((((uint)(v0)) == ((uint)((uint)1134903170U))))) || ((((uint)(v0)) == ((uint)((uint)1836311903U))))));
        }

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

        public static IEnumerable<Byte> Transduce(IEnumerable<Byte> input)
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
                            s._1 = ((uint)((uint)1U));
                            s._0 = ((uint)((uint)1U));
                            goto M0;
                        }
                        else
                        {
                            var temp3 = ((uint)(((int)((uint)(temp0))) >> (int)((uint)((uint)24U))));
                            yield return (Byte)(((byte)((uint)(temp3))));
                            var temp4 = ((uint)(((int)((uint)(temp0))) >> (int)((uint)((uint)16U))));
                            yield return (Byte)(((byte)((uint)(temp4))));
                            var temp5 = ((uint)(((int)((uint)(temp0))) >> (int)((uint)((uint)8U))));
                            yield return (Byte)(((byte)((uint)(temp5))));
                            var temp6 = ((byte)(((byte)(((byte)((uint)((s)._0))))) + ((byte)(((byte)((uint)((s)._1)))))));
                            yield return (Byte)(temp6);
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

        struct DTStruct1
        {
            public UInt32 _0;
            public UInt32 _1;
            public DTStruct1(UInt32 v0, UInt32 v1)
            {
                _0 = v0;
                _1 = v1;
            }
        }

        public static void TransduceFromStreamToStream(Stream input, Stream output)
        {
            unchecked
            {
                var iBuf = new byte[16384];
                int iIndex = 0;
                int read = 0;
                var oBuf = new byte[16384];
                int oIndex = 0;
                DTStruct1 s = new DTStruct1(((uint)((uint)1U)), ((uint)((uint)1U)));
                Byte i;
                M0:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F0;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp0 = ((uint)(((uint)((s)._0)) + ((uint)((s)._1))));
                        var temp1 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp0)));
                        var temp2 = !(temp1);
                        if (temp2)
                        {
                            s._1 = ((uint)((uint)1U));
                            s._0 = ((uint)((uint)1U));
                            goto M0;
                        }
                        else
                        {
                            if (oIndex > 16380)
                            {
                                output.Write(oBuf, 0, oIndex);
                                oIndex = 0;
                            }

                            var temp3 = ((uint)(((int)((uint)(temp0))) >> (int)((uint)((uint)24U))));
                            oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp3))));
                            var temp4 = ((uint)(((int)((uint)(temp0))) >> (int)((uint)((uint)16U))));
                            oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp4))));
                            var temp5 = ((uint)(((int)((uint)(temp0))) >> (int)((uint)((uint)8U))));
                            oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp5))));
                            var temp6 = ((byte)(((byte)(((byte)((uint)((s)._0))))) + ((byte)(((byte)((uint)((s)._1)))))));
                            oBuf[oIndex + 3] = (Byte)(temp6);
                            oIndex += 4;
                            UInt32 t1 = ((uint)(temp0));
                            s._0 = ((uint)((s)._1));
                            s._1 = t1;
                            goto M0;
                        }
                    }
                }

                F0:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }
            }
        }

        struct DTStruct2
        {
            public UInt32 _0;
            public UInt32 _1;
            public DTStruct2(UInt32 v0, UInt32 v1)
            {
                _0 = v0;
                _1 = v1;
            }
        }

        public static void TransduceFromArrayToStream(byte[] input, Stream output)
        {
            unchecked
            {
                int iIndex = -1;
                var oBuf = new byte[16384];
                int oIndex = 0;
                DTStruct2 s = new DTStruct2(((uint)((uint)1U)), ((uint)((uint)1U)));
                Byte i;
                M0:
                {
                    if (++iIndex >= input.Length)
                        goto F0;
                    i = input[iIndex];
                    {
                        var temp0 = ((uint)(((uint)((s)._0)) + ((uint)((s)._1))));
                        var temp1 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp0)));
                        var temp2 = !(temp1);
                        if (temp2)
                        {
                            s._1 = ((uint)((uint)1U));
                            s._0 = ((uint)((uint)1U));
                            goto M0;
                        }
                        else
                        {
                            if (oIndex > 16380)
                            {
                                output.Write(oBuf, 0, oIndex);
                                oIndex = 0;
                            }

                            var temp3 = ((uint)(((int)((uint)(temp0))) >> (int)((uint)((uint)24U))));
                            oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp3))));
                            var temp4 = ((uint)(((int)((uint)(temp0))) >> (int)((uint)((uint)16U))));
                            oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp4))));
                            var temp5 = ((uint)(((int)((uint)(temp0))) >> (int)((uint)((uint)8U))));
                            oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp5))));
                            var temp6 = ((byte)(((byte)(((byte)((uint)((s)._0))))) + ((byte)(((byte)((uint)((s)._1)))))));
                            oBuf[oIndex + 3] = (Byte)(temp6);
                            oIndex += 4;
                            UInt32 t1 = ((uint)(temp0));
                            s._0 = ((uint)((s)._1));
                            s._1 = t1;
                            goto M0;
                        }
                    }
                }

                F0:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }
            }
        }
    }
}