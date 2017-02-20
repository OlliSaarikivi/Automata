using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class StreamBase64Decoder
    {
        public static void Yield(Stream output, byte[] oBuf, int oNext, byte value)
        {
            oBuf[oNext] = value;
            if (oNext == oBuf.Length - 1)
            {
                output.Write(oBuf, 0, oBuf.Length);
            }
            oNext = (oNext + 1) % 16384;
        }

        public static void TransduceStreams(Stream input, Stream output)
        {
            unchecked
            {
                var iBuf = new byte[16384];
                var oBuf = new byte[16384];
                int iCur = 0;
                int oNext = 0;
                int read = 0;
                Byte s = (byte)0U;
                Byte i;
            M0:
                {
                    if (++iCur >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F0;
                        iCur = 0;
                    }

                    i = iBuf[iCur];
                    if (!((((byte)i) == ((byte)(byte)61U))))
                        if ((((((uint)(uint)65U) <= ((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)))) && ((((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)) <= ((uint)(uint)90U)))))
                        {
                            s = (byte)(((byte)(((byte)(byte)191U) + ((byte)i))));
                            goto M1;
                        }
                        else if ((((((uint)(uint)97U) <= ((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)))) && ((((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)) <= ((uint)(uint)122U)))))
                        {
                            s = (byte)(((byte)(((byte)(byte)185U) + ((byte)i))));
                            goto M1;
                        }
                        else if ((((((uint)(uint)48U) <= ((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)))) && ((((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)) <= ((uint)(uint)57U)))))
                        {
                            s = (byte)(((byte)(((byte)(byte)4U) + ((byte)i))));
                            goto M1;
                        }
                        else if ((((byte)i) == ((byte)(byte)43U)))
                        {
                            s = (byte)((byte)62U);
                            goto M1;
                        }
                        else if ((((byte)i) == ((byte)(byte)47U)))
                        {
                            s = (byte)((byte)63U);
                            goto M1;
                        }
                        else
                        {
                            s = (byte)((byte)0U);
                            goto M1;
                        }
                    else
                    {
                        goto M0;
                    }
                }

            F0:
                {
                    return;
                }

            M1:
                {
                    if (++iCur >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F1;
                        iCur = 0;
                    }

                    i = iBuf[iCur];
                    if (!((((byte)i) == ((byte)(byte)61U))))
                        if ((((((uint)(uint)65U) <= ((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)))) && ((((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)) <= ((uint)(uint)90U)))))
                        {
                            oBuf[oNext] = ((Byte)(((byte)(((byte)((byte)((byte)((byte)(((byte)s) >> 0) & 63UL) & 63L) << 2) | (byte)((byte)(byte)0U & 3L)) | ((byte)((byte)(((uint)((uint)((int)((uint)((uint)(((uint)(uint)4294967231U) + ((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i))))) >> (int)((uint)(uint)4U)))) >> 0) & 255UL))))));
                            if (oNext == oBuf.Length - 1)
                            {
                                output.Write(oBuf, 0, oBuf.Length);
                            }
                            oNext = (oNext + 1) % 16384;

                            s = (byte)(((byte)(((byte)(byte)191U) + ((byte)i))));
                            goto M2;
                        }
                        else if ((((((uint)(uint)97U) <= ((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)))) && ((((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)) <= ((uint)(uint)122U)))))
                        {
                            oBuf[oNext] = ((Byte)(((byte)(((byte)((byte)((byte)((byte)(((byte)s) >> 0) & 63UL) & 63L) << 2) | (byte)((byte)(byte)0U & 3L)) | ((byte)((byte)(((uint)((uint)((int)((uint)((uint)(((uint)(uint)4294967225U) + ((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i))))) >> (int)((uint)(uint)4U)))) >> 0) & 255UL))))));
                            if (oNext == oBuf.Length - 1)
                            {
                                output.Write(oBuf, 0, oBuf.Length);
                            }
                            oNext = (oNext + 1) % 16384;

                            s = (byte)(((byte)(((byte)(byte)185U) + ((byte)i))));
                            goto M2;
                        }
                        else if ((((((uint)(uint)48U) <= ((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)))) && ((((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)) <= ((uint)(uint)57U)))))
                        {
                            oBuf[oNext] = ((Byte)(((byte)(((byte)((byte)((byte)((byte)(((byte)s) >> 0) & 63UL) & 63L) << 2) | (byte)((byte)(byte)0U & 3L)) | ((byte)((byte)(((uint)((uint)((int)((uint)((uint)(((uint)(uint)4U) + ((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i))))) >> (int)((uint)(uint)4U)))) >> 0) & 255UL))))));
                            if (oNext == oBuf.Length - 1)
                            {
                                output.Write(oBuf, 0, oBuf.Length);
                            }
                            oNext = (oNext + 1) % 16384;

                            s = (byte)(((byte)(((byte)(byte)4U) + ((byte)i))));
                            goto M2;
                        }
                        else if ((((byte)i) == ((byte)(byte)43U)))
                        {
                            oBuf[oNext] = ((Byte)(((byte)((byte)((byte)(((byte)s) >> 0) & 63UL) & 63L) << 2) | (byte)((byte)(byte)3U & 3L)));
                            if (oNext == oBuf.Length - 1)
                            {
                                output.Write(oBuf, 0, oBuf.Length);
                            }
                            oNext = (oNext + 1) % 16384;

                            s = (byte)((byte)62U);
                            goto M2;
                        }
                        else if ((((byte)i) == ((byte)(byte)47U)))
                        {
                            oBuf[oNext] = ((Byte)(((byte)((byte)((byte)(((byte)s) >> 0) & 63UL) & 63L) << 2) | (byte)((byte)(byte)3U & 3L)));
                            if (oNext == oBuf.Length - 1)
                            {
                                output.Write(oBuf, 0, oBuf.Length);
                            }
                            oNext = (oNext + 1) % 16384;

                            s = (byte)((byte)63U);
                            goto M2;
                        }
                        else
                        {
                            oBuf[oNext] = ((Byte)(((byte)((byte)((byte)(((byte)s) >> 0) & 63UL) & 63L) << 2) | (byte)((byte)(byte)0U & 3L)));
                            if (oNext == oBuf.Length - 1)
                            {
                                output.Write(oBuf, 0, oBuf.Length);
                            }
                            oNext = (oNext + 1) % 16384;

                            s = (byte)((byte)0U);
                            goto M2;
                        }
                    else
                    {
                        goto M1;
                    }
                }

            F1:
                {
                    return;
                }

            M2:
                {
                    if (++iCur >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F2;
                        iCur = 0;
                    }

                    i = iBuf[iCur];
                    if (!((((byte)i) == ((byte)(byte)61U))))
                        if ((((((uint)(uint)65U) <= ((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)))) && ((((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)) <= ((uint)(uint)90U)))))
                        {
                            oBuf[oNext] = ((Byte)(((byte)(((byte)((byte)((byte)((byte)(((byte)s) >> 0) & 15UL) & 15L) << 4) | (byte)((byte)(byte)0U & 15L)) | ((byte)((byte)(((uint)((uint)((int)((uint)((uint)(((uint)(uint)4294967231U) + ((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i))))) >> (int)((uint)(uint)2U)))) >> 0) & 255UL))))));
                            if (oNext == oBuf.Length - 1)
                            {
                                output.Write(oBuf, 0, oBuf.Length);
                            }
                            oNext = (oNext + 1) % 16384;

                            s = (byte)(((byte)(((byte)(byte)191U) + ((byte)i))));
                            goto M3;
                        }
                        else if ((((((uint)(uint)97U) <= ((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)))) && ((((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)) <= ((uint)(uint)122U)))))
                        {
                            oBuf[oNext] = ((Byte)(((byte)(((byte)((byte)((byte)((byte)(((byte)s) >> 0) & 15UL) & 15L) << 4) | (byte)((byte)(byte)0U & 15L)) | ((byte)((byte)(((uint)((uint)((int)((uint)((uint)(((uint)(uint)4294967225U) + ((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i))))) >> (int)((uint)(uint)2U)))) >> 0) & 255UL))))));
                            if (oNext == oBuf.Length - 1)
                            {
                                output.Write(oBuf, 0, oBuf.Length);
                            }
                            oNext = (oNext + 1) % 16384;

                            s = (byte)(((byte)(((byte)(byte)185U) + ((byte)i))));
                            goto M3;
                        }
                        else if ((((((uint)(uint)48U) <= ((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)))) && ((((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)) <= ((uint)(uint)57U)))))
                        {
                            oBuf[oNext] = ((Byte)(((byte)(((byte)((byte)((byte)((byte)(((byte)s) >> 0) & 15UL) & 15L) << 4) | (byte)((byte)(byte)0U & 15L)) | ((byte)((byte)(((uint)((uint)((int)((uint)((uint)(((uint)(uint)4U) + ((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i))))) >> (int)((uint)(uint)2U)))) >> 0) & 255UL))))));
                            if (oNext == oBuf.Length - 1)
                            {
                                output.Write(oBuf, 0, oBuf.Length);
                            }
                            oNext = (oNext + 1) % 16384;

                            s = (byte)(((byte)(((byte)(byte)4U) + ((byte)i))));
                            goto M3;
                        }
                        else if ((((byte)i) == ((byte)(byte)43U)))
                        {
                            oBuf[oNext] = ((Byte)(((byte)((byte)((byte)(((byte)s) >> 0) & 15UL) & 15L) << 4) | (byte)((byte)(byte)15U & 15L)));
                            if (oNext == oBuf.Length - 1)
                            {
                                output.Write(oBuf, 0, oBuf.Length);
                            }
                            oNext = (oNext + 1) % 16384;

                            s = (byte)((byte)62U);
                            goto M3;
                        }
                        else if ((((byte)i) == ((byte)(byte)47U)))
                        {
                            oBuf[oNext] = ((Byte)(((byte)((byte)((byte)(((byte)s) >> 0) & 15UL) & 15L) << 4) | (byte)((byte)(byte)15U & 15L)));
                            if (oNext == oBuf.Length - 1)
                            {
                                output.Write(oBuf, 0, oBuf.Length);
                            }
                            oNext = (oNext + 1) % 16384;

                            s = (byte)((byte)63U);
                            goto M3;
                        }
                        else
                        {
                            oBuf[oNext] = ((Byte)(((byte)((byte)((byte)(((byte)s) >> 0) & 15UL) & 15L) << 4) | (byte)((byte)(byte)0U & 15L)));
                            if (oNext == oBuf.Length - 1)
                            {
                                output.Write(oBuf, 0, oBuf.Length);
                            }
                            oNext = (oNext + 1) % 16384;

                            s = (byte)((byte)0U);
                            goto M3;
                        }
                    else
                    {
                        goto M2;
                    }
                }

            F2:
                {
                    return;
                }

            M3:
                {
                    if (++iCur >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F3;
                        iCur = 0;
                    }

                    i = iBuf[iCur];
                    if (!((((byte)i) == ((byte)(byte)61U))))
                        if ((((((uint)(uint)65U) <= ((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)))) && ((((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)) <= ((uint)(uint)90U)))))
                        {
                            oBuf[oNext] = ((Byte)(((byte)(((byte)((byte)((byte)((byte)(((byte)s) >> 0) & 3UL) & 3L) << 6) | (byte)((byte)(byte)0U & 63L)) | ((byte)((byte)(((byte)(byte)191U) + ((byte)i))))))));
                            if (oNext == oBuf.Length - 1)
                            {
                                output.Write(oBuf, 0, oBuf.Length);
                            }
                            oNext = (oNext + 1) % 16384;

                            s = (byte)(((byte)(((byte)(byte)191U) + ((byte)i))));
                            goto M0;
                        }
                        else if ((((((uint)(uint)97U) <= ((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)))) && ((((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)) <= ((uint)(uint)122U)))))
                        {
                            oBuf[oNext] = ((Byte)(((byte)(((byte)((byte)((byte)((byte)(((byte)s) >> 0) & 3UL) & 3L) << 6) | (byte)((byte)(byte)0U & 63L)) | ((byte)((byte)(((byte)(byte)185U) + ((byte)i))))))));
                            if (oNext == oBuf.Length - 1)
                            {
                                output.Write(oBuf, 0, oBuf.Length);
                            }
                            oNext = (oNext + 1) % 16384;

                            s = (byte)(((byte)(((byte)(byte)185U) + ((byte)i))));
                            goto M0;
                        }
                        else if ((((((uint)(uint)48U) <= ((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)))) && ((((uint)((uint)((uint)(uint)0U & 16777215L) << 8) | (uint)((byte)i)) <= ((uint)(uint)57U)))))
                        {
                            oBuf[oNext] = ((Byte)(((byte)(((byte)((byte)((byte)((byte)(((byte)s) >> 0) & 3UL) & 3L) << 6) | (byte)((byte)(byte)0U & 63L)) | ((byte)((byte)(((byte)(byte)4U) + ((byte)i))))))));
                            if (oNext == oBuf.Length - 1)
                            {
                                output.Write(oBuf, 0, oBuf.Length);
                            }
                            oNext = (oNext + 1) % 16384;

                            s = (byte)(((byte)(((byte)(byte)4U) + ((byte)i))));
                            goto M0;
                        }
                        else if ((((byte)i) == ((byte)(byte)43U)))
                        {
                            oBuf[oNext] = ((Byte)(((byte)((byte)((byte)(((byte)s) >> 0) & 3UL) & 3L) << 6) | (byte)((byte)(byte)62U & 63L)));
                            if (oNext == oBuf.Length - 1)
                            {
                                output.Write(oBuf, 0, oBuf.Length);
                            }
                            oNext = (oNext + 1) % 16384;

                            s = (byte)((byte)62U);
                            goto M0;
                        }
                        else if ((((byte)i) == ((byte)(byte)47U)))
                        {
                            oBuf[oNext] = ((Byte)(((byte)((byte)((byte)(((byte)s) >> 0) & 3UL) & 3L) << 6) | (byte)((byte)(byte)63U & 63L)));
                            if (oNext == oBuf.Length - 1)
                            {
                                output.Write(oBuf, 0, oBuf.Length);
                            }
                            oNext = (oNext + 1) % 16384;

                            s = (byte)((byte)63U);
                            goto M0;
                        }
                        else
                        {
                            oBuf[oNext] = ((Byte)(((byte)((byte)((byte)(((byte)s) >> 0) & 3UL) & 3L) << 6) | (byte)((byte)(byte)0U & 63L)));
                            if (oNext == oBuf.Length - 1)
                            {
                                output.Write(oBuf, 0, oBuf.Length);
                            }
                            oNext = (oNext + 1) % 16384;

                            s = (byte)((byte)0U);
                            goto M0;
                        }
                    else
                    {
                        goto M3;
                    }
                }

            F3:
                {
                    return;
                }
            }
        }
    }
}