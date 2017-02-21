using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class UTF8ToUTF16 : Transducer<byte, char>
    {
        static UInt16 Fun0(UInt16 v0, UInt16 v1)
        {
            return (UInt16)(((ushort)((ushort)(((ushort)((ushort)(v0))) & 1023L)) << 6) | (ushort)((byte)(((byte)((ushort)(v1))) & 63L)));
        }

        public static IEnumerable<Char> Transduce(IEnumerable<Byte> input)
        {
            unchecked
            {
                IEnumerator<Byte> ie = input.GetEnumerator();
                UInt16 s = (ushort)0U;
                Byte i;
                M0:
                {
                    if (!ie.MoveNext())
                        goto F0;
                    i = ie.Current;
                    {
                        var temp0 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp1 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp0)));
                        var temp2 = ((int)((uint)(temp0)) <= (int)((uint)((uint)127U)));
                        var temp3 = ((temp1) && (temp2));
                        if (temp3)
                        {
                            var temp4 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            yield return (Char)(temp4);
                            goto M0;
                        }
                        else
                        {
                            var temp5 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp0)));
                            var temp6 = ((int)((uint)(temp0)) <= (int)((uint)((uint)223U)));
                            var temp7 = ((temp5) && (temp6));
                            if (temp7)
                            {
                                var temp8 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s = (ushort)(temp8);
                                goto M1;
                            }
                            else
                            {
                                var temp9 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp9)
                                {
                                    var temp10 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s = (ushort)(temp10);
                                    goto M2;
                                }
                                else
                                {
                                    var temp11 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp11)
                                    {
                                        var temp12 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s = (ushort)(temp12);
                                        goto M3;
                                    }
                                    else
                                    {
                                        var temp13 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp0)));
                                        var temp14 = ((int)((uint)(temp0)) <= (int)((uint)((uint)239U)));
                                        var temp15 = ((temp13) && (temp14));
                                        if (temp15)
                                        {
                                            var temp16 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s = (ushort)(temp16);
                                            goto M4;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M1:
                {
                    if (!ie.MoveNext())
                        goto F1;
                    i = ie.Current;
                    {
                        var temp17 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp18 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp17)));
                        var temp19 = ((int)((uint)(temp17)) <= (int)((uint)((uint)191U)));
                        var temp20 = ((temp18) && (temp19));
                        if (temp20)
                        {
                            var temp21 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp22 = Fun0(((ushort)(s)), ((ushort)(temp21)));
                            yield return (Char)(temp22);
                            s = (ushort)((ushort)0U);
                            goto M0;
                        }
                        else
                            throw new Exception();
                    }
                }

                M2:
                {
                    if (!ie.MoveNext())
                        goto F2;
                    i = ie.Current;
                    {
                        var temp23 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp24 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp23)));
                        var temp25 = ((int)((uint)(temp23)) <= (int)((uint)((uint)191U)));
                        var temp26 = ((temp24) && (temp25));
                        if (temp26)
                        {
                            var temp27 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp28 = Fun0(((ushort)(s)), ((ushort)(temp27)));
                            s = (ushort)(temp28);
                            goto M1;
                        }
                        else
                            throw new Exception();
                    }
                }

                M3:
                {
                    if (!ie.MoveNext())
                        goto F3;
                    i = ie.Current;
                    {
                        var temp29 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp30 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp29)));
                        var temp31 = ((int)((uint)(temp29)) <= (int)((uint)((uint)159U)));
                        var temp32 = ((temp30) && (temp31));
                        if (temp32)
                        {
                            var temp33 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp34 = Fun0(((ushort)(s)), ((ushort)(temp33)));
                            s = (ushort)(temp34);
                            goto M1;
                        }
                        else
                            throw new Exception();
                    }
                }

                M4:
                {
                    if (!ie.MoveNext())
                        goto F4;
                    i = ie.Current;
                    {
                        var temp35 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp36 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp35)));
                        var temp37 = ((int)((uint)(temp35)) <= (int)((uint)((uint)191U)));
                        var temp38 = ((temp36) && (temp37));
                        if (temp38)
                        {
                            var temp39 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp40 = Fun0(((ushort)(s)), ((ushort)(temp39)));
                            s = (ushort)(temp40);
                            goto M1;
                        }
                        else
                            throw new Exception();
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
            }
        }
    }
}