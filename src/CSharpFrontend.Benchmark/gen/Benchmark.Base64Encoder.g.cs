using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class Base64Encoder : Transducer<byte, byte>
    {
        static Byte Fun0(UInt32 v0)
        {
            return (Byte)(((((((int)((uint)((uint)0U)) <= (int)((uint)(v0)))) && (((int)((uint)(v0)) <= (int)((uint)((uint)25U)))))) ? ((byte)(((byte)(((byte)((byte)65U)) + ((byte)(((byte)((uint)(v0))))))))) : ((byte)(((((((int)((uint)((uint)26U)) <= (int)((uint)(v0)))) && (((int)((uint)(v0)) <= (int)((uint)((uint)51U)))))) ? ((byte)(((byte)(((byte)((byte)71U)) + ((byte)(((byte)((uint)(v0))))))))) : ((byte)(((((((int)((uint)((uint)52U)) <= (int)((uint)(v0)))) && (((int)((uint)(v0)) <= (int)((uint)((uint)61U)))))) ? ((byte)(((byte)(((byte)((byte)252U)) + ((byte)(((byte)((uint)(v0))))))))) : ((byte)((((((uint)(v0)) == ((uint)((uint)62U)))) ? ((byte)((byte)43U)) : ((byte)((byte)47U)))))))))))));
        }

        public static IEnumerable<Byte> Transduce(IEnumerable<Byte> input)
        {
            unchecked
            {
                IEnumerator<Byte> ie = input.GetEnumerator();
                Byte s = (byte)0U;
                Byte i;
                M0:
                {
                    if (!ie.MoveNext())
                        goto F0;
                    i = ie.Current;
                    {
                        var temp0 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp1 = ((uint)(((int)((uint)(temp0))) >> (int)((uint)((uint)2U))));
                        var temp2 = ((uint)((uint)((uint)0U & 67108863L)) << 6) | (uint)((byte)(((byte)((uint)(temp1))) & 63L));
                        var temp3 = Fun0(((uint)(temp2)));
                        yield return (Byte)(temp3);
                        s = (byte)(i);
                        goto M1;
                    }
                }

                M1:
                {
                    if (!ie.MoveNext())
                        goto F1;
                    i = ie.Current;
                    {
                        var temp6 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp7 = ((uint)(((int)((uint)(temp6))) >> (int)((uint)((uint)4U))));
                        var temp8 = (((uint)((uint)((uint)0U & 67108863L)) << 2) | (uint)((byte)(((byte)((byte)(s))) & 3L)) << 4) | (uint)((byte)(((byte)((uint)(temp7))) & 15L));
                        var temp9 = Fun0(((uint)(temp8)));
                        yield return (Byte)(temp9);
                        s = (byte)(i);
                        goto M2;
                    }
                }

                M2:
                {
                    if (!ie.MoveNext())
                        goto F2;
                    i = ie.Current;
                    {
                        var temp12 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp13 = ((uint)(((int)((uint)(temp12))) >> (int)((uint)((uint)6U))));
                        var temp14 = (((uint)((uint)((uint)0U & 67108863L)) << 4) | (uint)((byte)(((byte)((byte)(s))) & 15L)) << 2) | (uint)((byte)(((byte)((uint)(temp13))) & 3L));
                        var temp15 = Fun0(((uint)(temp14)));
                        yield return (Byte)(temp15);
                        var temp16 = ((uint)((uint)((uint)0U & 67108863L)) << 6) | (uint)((byte)(((byte)((byte)(i))) & 63L));
                        var temp17 = Fun0(((uint)(temp16)));
                        yield return (Byte)(temp17);
                        s = (byte)((byte)0U);
                        goto M0;
                    }
                }

                F0:
                {
                    yield break;
                }

                F1:
                {
                    var temp4 = (((uint)((uint)((uint)0U & 67108863L)) << 2) | (uint)((byte)(((byte)((byte)(s))) & 3L)) << 4);
                    var temp5 = Fun0(((uint)(temp4)));
                    yield return (Byte)(temp5);
                    yield return (Byte)((byte)61U);
                    yield return (Byte)((byte)61U);
                    yield break;
                }

                F2:
                {
                    var temp10 = (((uint)((uint)((uint)0U & 67108863L)) << 4) | (uint)((byte)(((byte)((byte)(s))) & 15L)) << 2);
                    var temp11 = Fun0(((uint)(temp10)));
                    yield return (Byte)(temp11);
                    yield return (Byte)((byte)61U);
                    yield break;
                }
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
                Byte s = (byte)0U;
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
                        if (oIndex > 16383)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        var temp0 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp1 = ((uint)(((int)((uint)(temp0))) >> (int)((uint)((uint)2U))));
                        var temp2 = ((uint)((uint)((uint)0U & 67108863L)) << 6) | (uint)((byte)(((byte)((uint)(temp1))) & 63L));
                        var temp3 = Fun0(((uint)(temp2)));
                        oBuf[oIndex + 0] = (Byte)(temp3);
                        oIndex += 1;
                        s = (byte)(i);
                        goto M1;
                    }
                }

                M1:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F1;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        if (oIndex > 16383)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        var temp6 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp7 = ((uint)(((int)((uint)(temp6))) >> (int)((uint)((uint)4U))));
                        var temp8 = (((uint)((uint)((uint)0U & 67108863L)) << 2) | (uint)((byte)(((byte)((byte)(s))) & 3L)) << 4) | (uint)((byte)(((byte)((uint)(temp7))) & 15L));
                        var temp9 = Fun0(((uint)(temp8)));
                        oBuf[oIndex + 0] = (Byte)(temp9);
                        oIndex += 1;
                        s = (byte)(i);
                        goto M2;
                    }
                }

                M2:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F2;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        if (oIndex > 16382)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        var temp12 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp13 = ((uint)(((int)((uint)(temp12))) >> (int)((uint)((uint)6U))));
                        var temp14 = (((uint)((uint)((uint)0U & 67108863L)) << 4) | (uint)((byte)(((byte)((byte)(s))) & 15L)) << 2) | (uint)((byte)(((byte)((uint)(temp13))) & 3L));
                        var temp15 = Fun0(((uint)(temp14)));
                        oBuf[oIndex + 0] = (Byte)(temp15);
                        var temp16 = ((uint)((uint)((uint)0U & 67108863L)) << 6) | (uint)((byte)(((byte)((byte)(i))) & 63L));
                        var temp17 = Fun0(((uint)(temp16)));
                        oBuf[oIndex + 1] = (Byte)(temp17);
                        oIndex += 2;
                        s = (byte)((byte)0U);
                        goto M0;
                    }
                }

                F0:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F1:
                {
                    if (oIndex > 16381)
                    {
                        output.Write(oBuf, 0, oIndex);
                        oIndex = 0;
                    }

                    var temp4 = (((uint)((uint)((uint)0U & 67108863L)) << 2) | (uint)((byte)(((byte)((byte)(s))) & 3L)) << 4);
                    var temp5 = Fun0(((uint)(temp4)));
                    oBuf[oIndex + 0] = (Byte)(temp5);
                    oBuf[oIndex + 1] = (Byte)((byte)61U);
                    oBuf[oIndex + 2] = (Byte)((byte)61U);
                    oIndex += 3;
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F2:
                {
                    if (oIndex > 16382)
                    {
                        output.Write(oBuf, 0, oIndex);
                        oIndex = 0;
                    }

                    var temp10 = (((uint)((uint)((uint)0U & 67108863L)) << 4) | (uint)((byte)(((byte)((byte)(s))) & 15L)) << 2);
                    var temp11 = Fun0(((uint)(temp10)));
                    oBuf[oIndex + 0] = (Byte)(temp11);
                    oBuf[oIndex + 1] = (Byte)((byte)61U);
                    oIndex += 2;
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }
            }
        }

        public static void TransduceFromArrayToStream(byte[] input, Stream output)
        {
            unchecked
            {
                int iIndex = -1;
                var oBuf = new byte[16384];
                int oIndex = 0;
                Byte s = (byte)0U;
                Byte i;
                M0:
                {
                    if (++iIndex >= input.Length)
                        goto F0;
                    i = input[iIndex];
                    {
                        if (oIndex > 16383)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        var temp0 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp1 = ((uint)(((int)((uint)(temp0))) >> (int)((uint)((uint)2U))));
                        var temp2 = ((uint)((uint)((uint)0U & 67108863L)) << 6) | (uint)((byte)(((byte)((uint)(temp1))) & 63L));
                        var temp3 = Fun0(((uint)(temp2)));
                        oBuf[oIndex + 0] = (Byte)(temp3);
                        oIndex += 1;
                        s = (byte)(i);
                        goto M1;
                    }
                }

                M1:
                {
                    if (++iIndex >= input.Length)
                        goto F1;
                    i = input[iIndex];
                    {
                        if (oIndex > 16383)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        var temp6 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp7 = ((uint)(((int)((uint)(temp6))) >> (int)((uint)((uint)4U))));
                        var temp8 = (((uint)((uint)((uint)0U & 67108863L)) << 2) | (uint)((byte)(((byte)((byte)(s))) & 3L)) << 4) | (uint)((byte)(((byte)((uint)(temp7))) & 15L));
                        var temp9 = Fun0(((uint)(temp8)));
                        oBuf[oIndex + 0] = (Byte)(temp9);
                        oIndex += 1;
                        s = (byte)(i);
                        goto M2;
                    }
                }

                M2:
                {
                    if (++iIndex >= input.Length)
                        goto F2;
                    i = input[iIndex];
                    {
                        if (oIndex > 16382)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        var temp12 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp13 = ((uint)(((int)((uint)(temp12))) >> (int)((uint)((uint)6U))));
                        var temp14 = (((uint)((uint)((uint)0U & 67108863L)) << 4) | (uint)((byte)(((byte)((byte)(s))) & 15L)) << 2) | (uint)((byte)(((byte)((uint)(temp13))) & 3L));
                        var temp15 = Fun0(((uint)(temp14)));
                        oBuf[oIndex + 0] = (Byte)(temp15);
                        var temp16 = ((uint)((uint)((uint)0U & 67108863L)) << 6) | (uint)((byte)(((byte)((byte)(i))) & 63L));
                        var temp17 = Fun0(((uint)(temp16)));
                        oBuf[oIndex + 1] = (Byte)(temp17);
                        oIndex += 2;
                        s = (byte)((byte)0U);
                        goto M0;
                    }
                }

                F0:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F1:
                {
                    if (oIndex > 16381)
                    {
                        output.Write(oBuf, 0, oIndex);
                        oIndex = 0;
                    }

                    var temp4 = (((uint)((uint)((uint)0U & 67108863L)) << 2) | (uint)((byte)(((byte)((byte)(s))) & 3L)) << 4);
                    var temp5 = Fun0(((uint)(temp4)));
                    oBuf[oIndex + 0] = (Byte)(temp5);
                    oBuf[oIndex + 1] = (Byte)((byte)61U);
                    oBuf[oIndex + 2] = (Byte)((byte)61U);
                    oIndex += 3;
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F2:
                {
                    if (oIndex > 16382)
                    {
                        output.Write(oBuf, 0, oIndex);
                        oIndex = 0;
                    }

                    var temp10 = (((uint)((uint)((uint)0U & 67108863L)) << 4) | (uint)((byte)(((byte)((byte)(s))) & 15L)) << 2);
                    var temp11 = Fun0(((uint)(temp10)));
                    oBuf[oIndex + 0] = (Byte)(temp11);
                    oBuf[oIndex + 1] = (Byte)((byte)61U);
                    oIndex += 2;
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }
            }
        }
    }
}