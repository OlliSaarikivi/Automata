using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class UTF16ToUTF8 : Transducer<char, byte>
    {
        public static IEnumerable<Byte> Transduce(IEnumerable<Char> input)
        {
            unchecked
            {
                IEnumerator<Char> ie = input.GetEnumerator();
                Byte s = (byte)0U;
                Char i;
                M0:
                {
                    if (!ie.MoveNext())
                        goto F0;
                    i = ie.Current;
                    {
                        var temp0 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                        var temp1 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp0)));
                        var temp2 = ((int)((uint)(temp0)) <= (int)((uint)((uint)127U)));
                        var temp3 = ((temp1) && (temp2));
                        if (temp3)
                        {
                            yield return (Byte)(((byte)((ushort)(i))));
                            goto M0;
                        }
                        else
                        {
                            var temp4 = !(temp2);
                            var temp5 = ((int)((uint)(temp0)) <= (int)((uint)((uint)2047U)));
                            var temp6 = ((temp4) && (temp5));
                            if (temp6)
                            {
                                var temp7 = ((uint)(((int)((uint)(temp0))) >> (int)((uint)((uint)6U))));
                                var temp8 = ((byte)((byte)((byte)6U & 7L)) << 5) | (byte)((byte)(((byte)((uint)(temp7))) & 31L));
                                yield return (Byte)(temp8);
                                var temp9 = ((byte)((byte)((byte)2U & 3L)) << 6) | (byte)((byte)(((byte)((ushort)(i))) & 63L));
                                yield return (Byte)(temp9);
                                goto M0;
                            }
                            else
                            {
                                var temp10 = !(temp5);
                                var temp11 = ((int)((uint)(temp0)) <= (int)((uint)((uint)65535U)));
                                var temp12 = ((int)((uint)((uint)55296U)) <= (int)((uint)(temp0)));
                                var temp13 = !(temp12);
                                var temp14 = ((int)((uint)(temp0)) <= (int)((uint)((uint)57343U)));
                                var temp15 = !(temp14);
                                var temp16 = ((temp13) || (temp15));
                                var temp17 = (((temp10) && (temp11)) && (temp16));
                                if (temp17)
                                {
                                    var temp18 = ((uint)(((int)((uint)(temp0))) >> (int)((uint)((uint)12U))));
                                    var temp19 = ((byte)((byte)((byte)14U & 15L)) << 4) | (byte)((byte)(((byte)((uint)(temp18))) & 15L));
                                    yield return (Byte)(temp19);
                                    var temp20 = ((uint)(((int)((uint)(temp0))) >> (int)((uint)((uint)6U))));
                                    var temp21 = ((byte)((byte)((byte)2U & 3L)) << 6) | (byte)((byte)(((byte)((uint)(temp20))) & 63L));
                                    yield return (Byte)(temp21);
                                    var temp22 = ((byte)((byte)((byte)2U & 3L)) << 6) | (byte)((byte)(((byte)((ushort)(i))) & 63L));
                                    yield return (Byte)(temp22);
                                    goto M0;
                                }
                                else
                                {
                                    var temp23 = ((int)((uint)(temp0)) <= (int)((uint)((uint)56319U)));
                                    var temp24 = ((temp12) && (temp23));
                                    if (temp24)
                                    {
                                        var temp25 = ((uint)(((int)((uint)(temp0))) >> (int)((uint)((uint)6U))));
                                        var temp26 = ((uint)((uint)((uint)0U & 268435455L)) << 4) | (uint)((byte)(((byte)((uint)(temp25))) & 15L));
                                        var temp27 = ((uint)(((uint)((uint)1U)) + ((uint)(temp26))));
                                        var temp28 = ((uint)(((int)((uint)(temp27))) >> (int)((uint)((uint)2U))));
                                        var temp29 = ((byte)((byte)((byte)30U & 31L)) << 3) | (byte)((byte)(((byte)((uint)(temp28))) & 7L));
                                        yield return (Byte)(temp29);
                                        var temp30 = ((byte)(((byte)((byte)1U)) + ((byte)(((byte)((uint)(temp25)))))));
                                        var temp31 = ((uint)(((int)((uint)(temp0))) >> (int)((uint)((uint)2U))));
                                        var temp32 = (((byte)((byte)((byte)2U & 3L)) << 2) | (byte)((byte)(temp30 & 3L)) << 4) | (byte)((byte)(((byte)((uint)(temp31))) & 15L));
                                        yield return (Byte)(temp32);
                                        var temp33 = ((byte)((byte)((byte)0U & 63L)) << 2) | (byte)((byte)(((byte)((ushort)(i))) & 3L));
                                        s = (byte)(temp33);
                                        goto M1;
                                    }
                                    else
                                        throw new Exception();
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
                        var temp34 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                        var temp35 = ((int)((uint)((uint)56320U)) <= (int)((uint)(temp34)));
                        var temp36 = ((int)((uint)(temp34)) <= (int)((uint)((uint)57343U)));
                        var temp37 = ((temp35) && (temp36));
                        if (temp37)
                        {
                            var temp38 = ((uint)(((int)((uint)(temp34))) >> (int)((uint)((uint)6U))));
                            var temp39 = ((byte)((byte)((byte)8U & 15L)) << 4) | (byte)((byte)(((byte)((uint)(temp38))) & 15L));
                            yield return (Byte)(temp39);
                            var temp40 = ((byte)((byte)((byte)2U & 3L)) << 6) | (byte)((byte)(((byte)((ushort)(i))) & 63L));
                            yield return (Byte)(temp40);
                            s = (byte)((byte)0U);
                            goto M0;
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
                    throw new Exception();
            }
        }
    }
}