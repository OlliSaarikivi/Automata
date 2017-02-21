using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class Base64Decoder : Transducer<byte, byte>
    {
        static UInt32 Fun0(Byte v0)
        {
            return (UInt32)(((((((int)((uint)((uint)65U)) <= (int)((uint)(((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(v0)))))) && (((int)((uint)(((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(v0)))) <= (int)((uint)((uint)90U)))))) ? ((uint)(((uint)(((uint)((uint)4294967231U)) + ((uint)(((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(v0)))))))) : ((uint)(((((((int)((uint)((uint)97U)) <= (int)((uint)(((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(v0)))))) && (((int)((uint)(((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(v0)))) <= (int)((uint)((uint)122U)))))) ? ((uint)(((uint)(((uint)((uint)4294967225U)) + ((uint)(((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(v0)))))))) : ((uint)(((((((int)((uint)((uint)48U)) <= (int)((uint)(((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(v0)))))) && (((int)((uint)(((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(v0)))) <= (int)((uint)((uint)57U)))))) ? ((uint)(((uint)(((uint)((uint)4U)) + ((uint)(((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(v0)))))))) : ((uint)((((((byte)(v0)) == ((byte)((byte)43U)))) ? ((uint)((uint)62U)) : ((uint)((uint)63U)))))))))))));
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
                        var temp0 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp0)
                            throw new Exception();
                        else
                        {
                            var temp1 = Fun0(((byte)(i)));
                            s = (byte)(((byte)((uint)(temp1))));
                            goto M1;
                        }
                    }
                }

                M1:
                {
                    if (!ie.MoveNext())
                        goto F1;
                    i = ie.Current;
                    {
                        var temp2 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp2)
                            throw new Exception();
                        else
                        {
                            var temp3 = ((byte)((byte)(((byte)((byte)(s))) & 63L)) << 2);
                            var temp4 = Fun0(((byte)(i)));
                            var temp5 = ((uint)(((int)((uint)(temp4))) >> (int)((uint)((uint)4U))));
                            var temp6 = ((byte)(((byte)(temp3)) | ((byte)(((byte)((uint)(temp5)))))));
                            yield return (Byte)(temp6);
                            s = (byte)(((byte)((uint)(temp4))));
                            goto M2;
                        }
                    }
                }

                M2:
                {
                    if (!ie.MoveNext())
                        goto F2;
                    i = ie.Current;
                    {
                        var temp7 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp7)
                        {
                            goto M3;
                        }
                        else
                        {
                            var temp8 = ((byte)((byte)(((byte)((byte)(s))) & 15L)) << 4);
                            var temp9 = Fun0(((byte)(i)));
                            var temp10 = ((uint)(((int)((uint)(temp9))) >> (int)((uint)((uint)2U))));
                            var temp11 = ((byte)(((byte)(temp8)) | ((byte)(((byte)((uint)(temp10)))))));
                            yield return (Byte)(temp11);
                            s = (byte)(((byte)((uint)(temp9))));
                            goto M4;
                        }
                    }
                }

                M3:
                {
                    if (!ie.MoveNext())
                        goto F3;
                    i = ie.Current;
                    {
                        var temp12 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp12)
                        {
                            goto M6;
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
                        var temp13 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp13)
                        {
                            goto M5;
                        }
                        else
                        {
                            var temp14 = ((byte)((byte)(((byte)((byte)(s))) & 3L)) << 6);
                            var temp15 = Fun0(((byte)(i)));
                            var temp16 = ((byte)(((byte)(temp14)) | ((byte)(((byte)((uint)(temp15)))))));
                            yield return (Byte)(temp16);
                            s = (byte)((byte)0U);
                            goto M0;
                        }
                    }
                }

                M5:
                {
                    if (!ie.MoveNext())
                        goto F5;
                    i = ie.Current;
                    throw new Exception();
                }

                M6:
                {
                    if (!ie.MoveNext())
                        goto F6;
                    i = ie.Current;
                    throw new Exception();
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
                    throw new Exception();
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
                        var temp0 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp0)
                            throw new Exception();
                        else
                        {
                            var temp1 = Fun0(((byte)(i)));
                            s = (byte)(((byte)((uint)(temp1))));
                            goto M1;
                        }
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
                        var temp2 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp2)
                            throw new Exception();
                        else
                        {
                            if (oIndex > 16383)
                            {
                                output.Write(oBuf, 0, oIndex);
                                oIndex = 0;
                            }

                            var temp3 = ((byte)((byte)(((byte)((byte)(s))) & 63L)) << 2);
                            var temp4 = Fun0(((byte)(i)));
                            var temp5 = ((uint)(((int)((uint)(temp4))) >> (int)((uint)((uint)4U))));
                            var temp6 = ((byte)(((byte)(temp3)) | ((byte)(((byte)((uint)(temp5)))))));
                            oBuf[oIndex + 0] = (Byte)(temp6);
                            oIndex += 1;
                            s = (byte)(((byte)((uint)(temp4))));
                            goto M2;
                        }
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
                        var temp7 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp7)
                        {
                            goto M3;
                        }
                        else
                        {
                            if (oIndex > 16383)
                            {
                                output.Write(oBuf, 0, oIndex);
                                oIndex = 0;
                            }

                            var temp8 = ((byte)((byte)(((byte)((byte)(s))) & 15L)) << 4);
                            var temp9 = Fun0(((byte)(i)));
                            var temp10 = ((uint)(((int)((uint)(temp9))) >> (int)((uint)((uint)2U))));
                            var temp11 = ((byte)(((byte)(temp8)) | ((byte)(((byte)((uint)(temp10)))))));
                            oBuf[oIndex + 0] = (Byte)(temp11);
                            oIndex += 1;
                            s = (byte)(((byte)((uint)(temp9))));
                            goto M4;
                        }
                    }
                }

                M3:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F3;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp12 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp12)
                        {
                            goto M6;
                        }
                        else
                            throw new Exception();
                    }
                }

                M4:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F4;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp13 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp13)
                        {
                            goto M5;
                        }
                        else
                        {
                            if (oIndex > 16383)
                            {
                                output.Write(oBuf, 0, oIndex);
                                oIndex = 0;
                            }

                            var temp14 = ((byte)((byte)(((byte)((byte)(s))) & 3L)) << 6);
                            var temp15 = Fun0(((byte)(i)));
                            var temp16 = ((byte)(((byte)(temp14)) | ((byte)(((byte)((uint)(temp15)))))));
                            oBuf[oIndex + 0] = (Byte)(temp16);
                            oIndex += 1;
                            s = (byte)((byte)0U);
                            goto M0;
                        }
                    }
                }

                M5:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F5;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    throw new Exception();
                }

                M6:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F6;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    throw new Exception();
                }

                F0:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F1:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F2:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F3:
                    throw new Exception();
                F4:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F5:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F6:
                {
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
                        var temp0 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp0)
                            throw new Exception();
                        else
                        {
                            var temp1 = Fun0(((byte)(i)));
                            s = (byte)(((byte)((uint)(temp1))));
                            goto M1;
                        }
                    }
                }

                M1:
                {
                    if (++iIndex >= input.Length)
                        goto F1;
                    i = input[iIndex];
                    {
                        var temp2 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp2)
                            throw new Exception();
                        else
                        {
                            if (oIndex > 16383)
                            {
                                output.Write(oBuf, 0, oIndex);
                                oIndex = 0;
                            }

                            var temp3 = ((byte)((byte)(((byte)((byte)(s))) & 63L)) << 2);
                            var temp4 = Fun0(((byte)(i)));
                            var temp5 = ((uint)(((int)((uint)(temp4))) >> (int)((uint)((uint)4U))));
                            var temp6 = ((byte)(((byte)(temp3)) | ((byte)(((byte)((uint)(temp5)))))));
                            oBuf[oIndex + 0] = (Byte)(temp6);
                            oIndex += 1;
                            s = (byte)(((byte)((uint)(temp4))));
                            goto M2;
                        }
                    }
                }

                M2:
                {
                    if (++iIndex >= input.Length)
                        goto F2;
                    i = input[iIndex];
                    {
                        var temp7 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp7)
                        {
                            goto M3;
                        }
                        else
                        {
                            if (oIndex > 16383)
                            {
                                output.Write(oBuf, 0, oIndex);
                                oIndex = 0;
                            }

                            var temp8 = ((byte)((byte)(((byte)((byte)(s))) & 15L)) << 4);
                            var temp9 = Fun0(((byte)(i)));
                            var temp10 = ((uint)(((int)((uint)(temp9))) >> (int)((uint)((uint)2U))));
                            var temp11 = ((byte)(((byte)(temp8)) | ((byte)(((byte)((uint)(temp10)))))));
                            oBuf[oIndex + 0] = (Byte)(temp11);
                            oIndex += 1;
                            s = (byte)(((byte)((uint)(temp9))));
                            goto M4;
                        }
                    }
                }

                M3:
                {
                    if (++iIndex >= input.Length)
                        goto F3;
                    i = input[iIndex];
                    {
                        var temp12 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp12)
                        {
                            goto M6;
                        }
                        else
                            throw new Exception();
                    }
                }

                M4:
                {
                    if (++iIndex >= input.Length)
                        goto F4;
                    i = input[iIndex];
                    {
                        var temp13 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp13)
                        {
                            goto M5;
                        }
                        else
                        {
                            if (oIndex > 16383)
                            {
                                output.Write(oBuf, 0, oIndex);
                                oIndex = 0;
                            }

                            var temp14 = ((byte)((byte)(((byte)((byte)(s))) & 3L)) << 6);
                            var temp15 = Fun0(((byte)(i)));
                            var temp16 = ((byte)(((byte)(temp14)) | ((byte)(((byte)((uint)(temp15)))))));
                            oBuf[oIndex + 0] = (Byte)(temp16);
                            oIndex += 1;
                            s = (byte)((byte)0U);
                            goto M0;
                        }
                    }
                }

                M5:
                {
                    if (++iIndex >= input.Length)
                        goto F5;
                    i = input[iIndex];
                    throw new Exception();
                }

                M6:
                {
                    if (++iIndex >= input.Length)
                        goto F6;
                    i = input[iIndex];
                    throw new Exception();
                }

                F0:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F1:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F2:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F3:
                    throw new Exception();
                F4:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F5:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F6:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }
            }
        }
    }
}