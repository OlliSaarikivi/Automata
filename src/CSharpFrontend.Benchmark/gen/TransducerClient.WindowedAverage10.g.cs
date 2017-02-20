using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class WindowedAverage10 : Transducer<int, int>
    {
        struct DTStruct0
        {
            public UInt64 _0;
            public UInt64 _1;
            public UInt64 _2;
            public UInt64 _3;
            public UInt64 _4;
            public UInt64 _5;
            public UInt64 _6;
            public UInt64 _7;
            public UInt64 _8;
            public UInt64 _9;
            public DTStruct0(UInt64 v0, UInt64 v1, UInt64 v2, UInt64 v3, UInt64 v4, UInt64 v5, UInt64 v6, UInt64 v7, UInt64 v8, UInt64 v9)
            {
                _0 = v0;
                _1 = v1;
                _2 = v2;
                _3 = v3;
                _4 = v4;
                _5 = v5;
                _6 = v6;
                _7 = v7;
                _8 = v8;
                _9 = v9;
            }
        }

        public static IEnumerable<Int32> Transduce(IEnumerable<Int32> input)
        {
            unchecked
            {
                IEnumerator<Int32> ie = input.GetEnumerator();
                DTStruct0 s = new DTStruct0(((ulong)((ulong)0UL)), ((ulong)((ulong)0UL)), ((ulong)((ulong)0UL)), ((ulong)((ulong)0UL)), ((ulong)((ulong)0UL)), ((ulong)((ulong)0UL)), ((ulong)((ulong)0UL)), ((ulong)((ulong)0UL)), ((ulong)((ulong)0UL)), ((ulong)((ulong)0UL)));
                Int32 i;
                M0:
                {
                    if (!ie.MoveNext())
                        goto F0;
                    i = ie.Current;
                    {
                        var temp0 = ((uint)(((((((((((uint)(i)) + ((uint)(((uint)((ulong)((s)._1)))))) + ((uint)(((uint)((ulong)((s)._2)))))) + ((uint)(((uint)((ulong)((s)._3)))))) + ((uint)(((uint)((ulong)((s)._4)))))) + ((uint)(((uint)((ulong)((s)._5)))))) + ((uint)(((uint)((ulong)((s)._6)))))) + ((uint)(((uint)((ulong)((s)._7)))))) + ((uint)(((uint)((ulong)((s)._8)))))) + ((uint)(((uint)((ulong)((s)._9)))))));
                        var temp1 = ((uint)((int)((uint)(temp0)) / (int)((uint)((uint)10U))));
                        yield return (Int32)(temp1);
                        var temp2 = ((byte)(((uint)(i)) >> 31));
                        var temp3 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 1) | (ulong)((byte)(temp2 & 1L)) << 32) | (ulong)((uint)(i));
                        s._0 = ((ulong)(temp3));
                        goto M1;
                    }
                }

                M1:
                {
                    if (!ie.MoveNext())
                        goto F1;
                    i = ie.Current;
                    {
                        var temp4 = ((uint)(((((((((((uint)(((uint)((ulong)((s)._0))))) + ((uint)(i))) + ((uint)(((uint)((ulong)((s)._2)))))) + ((uint)(((uint)((ulong)((s)._3)))))) + ((uint)(((uint)((ulong)((s)._4)))))) + ((uint)(((uint)((ulong)((s)._5)))))) + ((uint)(((uint)((ulong)((s)._6)))))) + ((uint)(((uint)((ulong)((s)._7)))))) + ((uint)(((uint)((ulong)((s)._8)))))) + ((uint)(((uint)((ulong)((s)._9)))))));
                        var temp5 = ((uint)((int)((uint)(temp4)) / (int)((uint)((uint)10U))));
                        yield return (Int32)(temp5);
                        var temp6 = ((byte)(((uint)(i)) >> 31));
                        var temp7 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 1) | (ulong)((byte)(temp6 & 1L)) << 32) | (ulong)((uint)(i));
                        s._1 = ((ulong)(temp7));
                        goto M2;
                    }
                }

                M2:
                {
                    if (!ie.MoveNext())
                        goto F2;
                    i = ie.Current;
                    {
                        var temp8 = ((uint)(((((((((((uint)(((uint)((ulong)((s)._0))))) + ((uint)(((uint)((ulong)((s)._1)))))) + ((uint)(i))) + ((uint)(((uint)((ulong)((s)._3)))))) + ((uint)(((uint)((ulong)((s)._4)))))) + ((uint)(((uint)((ulong)((s)._5)))))) + ((uint)(((uint)((ulong)((s)._6)))))) + ((uint)(((uint)((ulong)((s)._7)))))) + ((uint)(((uint)((ulong)((s)._8)))))) + ((uint)(((uint)((ulong)((s)._9)))))));
                        var temp9 = ((uint)((int)((uint)(temp8)) / (int)((uint)((uint)10U))));
                        yield return (Int32)(temp9);
                        var temp10 = ((byte)(((uint)(i)) >> 31));
                        var temp11 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 1) | (ulong)((byte)(temp10 & 1L)) << 32) | (ulong)((uint)(i));
                        s._2 = ((ulong)(temp11));
                        goto M3;
                    }
                }

                M3:
                {
                    if (!ie.MoveNext())
                        goto F3;
                    i = ie.Current;
                    {
                        var temp12 = ((uint)(((((((((((uint)(((uint)((ulong)((s)._0))))) + ((uint)(((uint)((ulong)((s)._1)))))) + ((uint)(((uint)((ulong)((s)._2)))))) + ((uint)(i))) + ((uint)(((uint)((ulong)((s)._4)))))) + ((uint)(((uint)((ulong)((s)._5)))))) + ((uint)(((uint)((ulong)((s)._6)))))) + ((uint)(((uint)((ulong)((s)._7)))))) + ((uint)(((uint)((ulong)((s)._8)))))) + ((uint)(((uint)((ulong)((s)._9)))))));
                        var temp13 = ((uint)((int)((uint)(temp12)) / (int)((uint)((uint)10U))));
                        yield return (Int32)(temp13);
                        var temp14 = ((byte)(((uint)(i)) >> 31));
                        var temp15 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 1) | (ulong)((byte)(temp14 & 1L)) << 32) | (ulong)((uint)(i));
                        s._3 = ((ulong)(temp15));
                        goto M4;
                    }
                }

                M4:
                {
                    if (!ie.MoveNext())
                        goto F4;
                    i = ie.Current;
                    {
                        var temp16 = ((uint)(((((((((((uint)(((uint)((ulong)((s)._0))))) + ((uint)(((uint)((ulong)((s)._1)))))) + ((uint)(((uint)((ulong)((s)._2)))))) + ((uint)(((uint)((ulong)((s)._3)))))) + ((uint)(i))) + ((uint)(((uint)((ulong)((s)._5)))))) + ((uint)(((uint)((ulong)((s)._6)))))) + ((uint)(((uint)((ulong)((s)._7)))))) + ((uint)(((uint)((ulong)((s)._8)))))) + ((uint)(((uint)((ulong)((s)._9)))))));
                        var temp17 = ((uint)((int)((uint)(temp16)) / (int)((uint)((uint)10U))));
                        yield return (Int32)(temp17);
                        var temp18 = ((byte)(((uint)(i)) >> 31));
                        var temp19 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 1) | (ulong)((byte)(temp18 & 1L)) << 32) | (ulong)((uint)(i));
                        s._4 = ((ulong)(temp19));
                        goto M5;
                    }
                }

                M5:
                {
                    if (!ie.MoveNext())
                        goto F5;
                    i = ie.Current;
                    {
                        var temp20 = ((uint)(((((((((((uint)(((uint)((ulong)((s)._0))))) + ((uint)(((uint)((ulong)((s)._1)))))) + ((uint)(((uint)((ulong)((s)._2)))))) + ((uint)(((uint)((ulong)((s)._3)))))) + ((uint)(((uint)((ulong)((s)._4)))))) + ((uint)(i))) + ((uint)(((uint)((ulong)((s)._6)))))) + ((uint)(((uint)((ulong)((s)._7)))))) + ((uint)(((uint)((ulong)((s)._8)))))) + ((uint)(((uint)((ulong)((s)._9)))))));
                        var temp21 = ((uint)((int)((uint)(temp20)) / (int)((uint)((uint)10U))));
                        yield return (Int32)(temp21);
                        var temp22 = ((byte)(((uint)(i)) >> 31));
                        var temp23 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 1) | (ulong)((byte)(temp22 & 1L)) << 32) | (ulong)((uint)(i));
                        s._5 = ((ulong)(temp23));
                        goto M6;
                    }
                }

                M6:
                {
                    if (!ie.MoveNext())
                        goto F6;
                    i = ie.Current;
                    {
                        var temp24 = ((uint)(((((((((((uint)(((uint)((ulong)((s)._0))))) + ((uint)(((uint)((ulong)((s)._1)))))) + ((uint)(((uint)((ulong)((s)._2)))))) + ((uint)(((uint)((ulong)((s)._3)))))) + ((uint)(((uint)((ulong)((s)._4)))))) + ((uint)(((uint)((ulong)((s)._5)))))) + ((uint)(i))) + ((uint)(((uint)((ulong)((s)._7)))))) + ((uint)(((uint)((ulong)((s)._8)))))) + ((uint)(((uint)((ulong)((s)._9)))))));
                        var temp25 = ((uint)((int)((uint)(temp24)) / (int)((uint)((uint)10U))));
                        yield return (Int32)(temp25);
                        var temp26 = ((byte)(((uint)(i)) >> 31));
                        var temp27 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 1) | (ulong)((byte)(temp26 & 1L)) << 32) | (ulong)((uint)(i));
                        s._6 = ((ulong)(temp27));
                        goto M7;
                    }
                }

                M7:
                {
                    if (!ie.MoveNext())
                        goto F7;
                    i = ie.Current;
                    {
                        var temp28 = ((uint)(((((((((((uint)(((uint)((ulong)((s)._0))))) + ((uint)(((uint)((ulong)((s)._1)))))) + ((uint)(((uint)((ulong)((s)._2)))))) + ((uint)(((uint)((ulong)((s)._3)))))) + ((uint)(((uint)((ulong)((s)._4)))))) + ((uint)(((uint)((ulong)((s)._5)))))) + ((uint)(((uint)((ulong)((s)._6)))))) + ((uint)(i))) + ((uint)(((uint)((ulong)((s)._8)))))) + ((uint)(((uint)((ulong)((s)._9)))))));
                        var temp29 = ((uint)((int)((uint)(temp28)) / (int)((uint)((uint)10U))));
                        yield return (Int32)(temp29);
                        var temp30 = ((byte)(((uint)(i)) >> 31));
                        var temp31 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 32) | (ulong)((uint)(i));
                        s._7 = ((ulong)(temp31));
                        goto M8;
                    }
                }

                M8:
                {
                    if (!ie.MoveNext())
                        goto F8;
                    i = ie.Current;
                    {
                        var temp32 = ((uint)(((((((((((uint)(((uint)((ulong)((s)._0))))) + ((uint)(((uint)((ulong)((s)._1)))))) + ((uint)(((uint)((ulong)((s)._2)))))) + ((uint)(((uint)((ulong)((s)._3)))))) + ((uint)(((uint)((ulong)((s)._4)))))) + ((uint)(((uint)((ulong)((s)._5)))))) + ((uint)(((uint)((ulong)((s)._6)))))) + ((uint)(((uint)((ulong)((s)._7)))))) + ((uint)(i))) + ((uint)(((uint)((ulong)((s)._9)))))));
                        var temp33 = ((uint)((int)((uint)(temp32)) / (int)((uint)((uint)10U))));
                        yield return (Int32)(temp33);
                        var temp34 = ((byte)(((uint)(i)) >> 31));
                        var temp35 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 1) | (ulong)((byte)(temp34 & 1L)) << 32) | (ulong)((uint)(i));
                        s._8 = ((ulong)(temp35));
                        goto M9;
                    }
                }

                M9:
                {
                    if (!ie.MoveNext())
                        goto F9;
                    i = ie.Current;
                    {
                        var temp36 = ((uint)(((((((((((uint)(((uint)((ulong)((s)._0))))) + ((uint)(((uint)((ulong)((s)._1)))))) + ((uint)(((uint)((ulong)((s)._2)))))) + ((uint)(((uint)((ulong)((s)._3)))))) + ((uint)(((uint)((ulong)((s)._4)))))) + ((uint)(((uint)((ulong)((s)._5)))))) + ((uint)(((uint)((ulong)((s)._6)))))) + ((uint)(((uint)((ulong)((s)._7)))))) + ((uint)(((uint)((ulong)((s)._8)))))) + ((uint)(i))));
                        var temp37 = ((uint)((int)((uint)(temp36)) / (int)((uint)((uint)10U))));
                        yield return (Int32)(temp37);
                        var temp38 = ((byte)(((uint)(i)) >> 31));
                        var temp39 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 1) | (ulong)((byte)(temp38 & 1L)) << 32) | (ulong)((uint)(i));
                        s._9 = ((ulong)(temp39));
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

                F4:
                {
                    yield break;
                }

                F5:
                {
                    yield break;
                }

                F6:
                {
                    yield break;
                }

                F7:
                {
                    yield break;
                }

                F8:
                {
                    yield break;
                }

                F9:
                {
                    yield break;
                }
            }
        }
    }
}