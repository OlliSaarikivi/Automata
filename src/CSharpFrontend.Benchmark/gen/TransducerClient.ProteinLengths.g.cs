using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class ProteinLengths : SpecialTransducer
    {
        struct DTStruct4
        {
            public UInt32 _0;
            public UInt32 _1;
            public DTStruct4(UInt32 v0, UInt32 v1)
            {
                _0 = v0;
                _1 = v1;
            }
        }

        public static IEnumerable<Int32> Transduce(IEnumerable<Char> input)
        {
            unchecked
            {
                IEnumerator<Char> ie = input.GetEnumerator();
                DTStruct4 s = new DTStruct4(((uint)((uint)0U)), ((uint)((uint)0U)));
                Char i;
                M0:
                {
                    if (!ie.MoveNext())
                        goto F0;
                    i = ie.Current;
                    {
                        var temp0 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp0)
                        {
                            goto M1;
                        }
                        else
                        {
                            goto M0;
                        }
                    }
                }

                M1:
                {
                    if (!ie.MoveNext())
                        goto F1;
                    i = ie.Current;
                    {
                        var temp1 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp1)
                        {
                            goto M2;
                        }
                        else
                        {
                            var temp2 = (((ushort)(i)) == ((ushort)((ushort)80U)));
                            if (temp2)
                            {
                                goto M3;
                            }
                            else
                            {
                                var temp3 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                                if (temp3)
                                {
                                    s._1 = ((uint)((uint)1U));
                                    goto M4;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M5;
                                }
                            }
                        }
                    }
                }

                M2:
                {
                    if (!ie.MoveNext())
                        goto F2;
                    i = ie.Current;
                    {
                        var temp4 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp4)
                            throw new Exception();
                        else
                        {
                            goto M2;
                        }
                    }
                }

                M3:
                {
                    if (!ie.MoveNext())
                        goto F3;
                    i = ie.Current;
                    {
                        var temp5 = (((ushort)(i)) == ((ushort)((ushort)114U)));
                        if (temp5)
                        {
                            goto M9;
                        }
                        else
                        {
                            var temp6 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp6)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M4;
                            }
                            else
                            {
                                var temp7 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp7)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M6;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M5;
                                }
                            }
                        }
                    }
                }

                M4:
                {
                    if (!ie.MoveNext())
                        goto F4;
                    i = ie.Current;
                    {
                        var temp8 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp8)
                        {
                            goto M7;
                        }
                        else
                        {
                            goto M4;
                        }
                    }
                }

                M5:
                {
                    if (!ie.MoveNext())
                        goto F5;
                    i = ie.Current;
                    {
                        var temp9 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp9)
                        {
                            var temp10 = ((uint)(((uint)((uint)1U)) + ((uint)((s)._1))));
                            s._1 = ((uint)(temp10));
                            goto M4;
                        }
                        else
                        {
                            var temp11 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp11)
                            {
                                goto M6;
                            }
                            else
                            {
                                goto M5;
                            }
                        }
                    }
                }

                M6:
                {
                    if (!ie.MoveNext())
                        goto F6;
                    i = ie.Current;
                    {
                        var temp12 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp12)
                        {
                            var temp13 = (((uint)((s)._1)) == ((uint)((uint)0U)));
                            if (temp13)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M0;
                            }
                            else
                            {
                                goto M4;
                            }
                        }
                        else
                        {
                            var temp14 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp14)
                            {
                                goto M6;
                            }
                            else
                            {
                                goto M5;
                            }
                        }
                    }
                }

                M7:
                {
                    if (!ie.MoveNext())
                        goto F7;
                    i = ie.Current;
                    {
                        var temp15 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp15)
                        {
                            goto M8;
                        }
                        else
                        {
                            goto M5;
                        }
                    }
                }

                M8:
                {
                    if (!ie.MoveNext())
                        goto F8;
                    i = ie.Current;
                    {
                        var temp16 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp16)
                        {
                            var temp17 = (((uint)((s)._1)) == ((uint)((uint)1U)));
                            if (temp17)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M0;
                            }
                            else
                            {
                                var temp18 = ((uint)(((uint)((uint)4294967295U)) + ((uint)((s)._1))));
                                s._1 = ((uint)(temp18));
                                goto M4;
                            }
                        }
                        else
                        {
                            goto M8;
                        }
                    }
                }

                M9:
                {
                    if (!ie.MoveNext())
                        goto F9;
                    i = ie.Current;
                    {
                        var temp19 = (((ushort)(i)) == ((ushort)((ushort)111U)));
                        if (temp19)
                        {
                            goto M10;
                        }
                        else
                        {
                            var temp20 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp20)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M4;
                            }
                            else
                            {
                                var temp21 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp21)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M6;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M5;
                                }
                            }
                        }
                    }
                }

                M10:
                {
                    if (!ie.MoveNext())
                        goto F10;
                    i = ie.Current;
                    {
                        var temp22 = (((ushort)(i)) == ((ushort)((ushort)116U)));
                        if (temp22)
                        {
                            goto M11;
                        }
                        else
                        {
                            var temp23 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp23)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M4;
                            }
                            else
                            {
                                var temp24 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp24)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M6;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M5;
                                }
                            }
                        }
                    }
                }

                M11:
                {
                    if (!ie.MoveNext())
                        goto F11;
                    i = ie.Current;
                    {
                        var temp25 = (((ushort)(i)) == ((ushort)((ushort)101U)));
                        if (temp25)
                        {
                            goto M12;
                        }
                        else
                        {
                            var temp26 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp26)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M4;
                            }
                            else
                            {
                                var temp27 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp27)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M6;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M5;
                                }
                            }
                        }
                    }
                }

                M12:
                {
                    if (!ie.MoveNext())
                        goto F12;
                    i = ie.Current;
                    {
                        var temp28 = (((ushort)(i)) == ((ushort)((ushort)105U)));
                        if (temp28)
                        {
                            goto M13;
                        }
                        else
                        {
                            var temp29 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp29)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M4;
                            }
                            else
                            {
                                var temp30 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp30)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M6;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M5;
                                }
                            }
                        }
                    }
                }

                M13:
                {
                    if (!ie.MoveNext())
                        goto F13;
                    i = ie.Current;
                    {
                        var temp31 = (((ushort)(i)) == ((ushort)((ushort)110U)));
                        if (temp31)
                        {
                            goto M14;
                        }
                        else
                        {
                            var temp32 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp32)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M4;
                            }
                            else
                            {
                                var temp33 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp33)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M6;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M5;
                                }
                            }
                        }
                    }
                }

                M14:
                {
                    if (!ie.MoveNext())
                        goto F14;
                    i = ie.Current;
                    {
                        var temp34 = (((ushort)(i)) == ((ushort)((ushort)68U)));
                        if (temp34)
                        {
                            goto M15;
                        }
                        else
                        {
                            var temp35 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp35)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M4;
                            }
                            else
                            {
                                var temp36 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp36)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M6;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M5;
                                }
                            }
                        }
                    }
                }

                M15:
                {
                    if (!ie.MoveNext())
                        goto F15;
                    i = ie.Current;
                    {
                        var temp37 = (((ushort)(i)) == ((ushort)((ushort)97U)));
                        if (temp37)
                        {
                            goto M16;
                        }
                        else
                        {
                            var temp38 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp38)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M4;
                            }
                            else
                            {
                                var temp39 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp39)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M6;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M5;
                                }
                            }
                        }
                    }
                }

                M16:
                {
                    if (!ie.MoveNext())
                        goto F16;
                    i = ie.Current;
                    {
                        var temp40 = (((ushort)(i)) == ((ushort)((ushort)116U)));
                        if (temp40)
                        {
                            goto M17;
                        }
                        else
                        {
                            var temp41 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp41)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M4;
                            }
                            else
                            {
                                var temp42 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp42)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M6;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M5;
                                }
                            }
                        }
                    }
                }

                M17:
                {
                    if (!ie.MoveNext())
                        goto F17;
                    i = ie.Current;
                    {
                        var temp43 = (((ushort)(i)) == ((ushort)((ushort)97U)));
                        if (temp43)
                        {
                            goto M18;
                        }
                        else
                        {
                            var temp44 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp44)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M4;
                            }
                            else
                            {
                                var temp45 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp45)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M6;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M5;
                                }
                            }
                        }
                    }
                }

                M18:
                {
                    if (!ie.MoveNext())
                        goto F18;
                    i = ie.Current;
                    {
                        var temp46 = (((ushort)(i)) == ((ushort)((ushort)98U)));
                        if (temp46)
                        {
                            goto M19;
                        }
                        else
                        {
                            var temp47 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp47)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M4;
                            }
                            else
                            {
                                var temp48 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp48)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M6;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M5;
                                }
                            }
                        }
                    }
                }

                M19:
                {
                    if (!ie.MoveNext())
                        goto F19;
                    i = ie.Current;
                    {
                        var temp49 = (((ushort)(i)) == ((ushort)((ushort)97U)));
                        if (temp49)
                        {
                            goto M20;
                        }
                        else
                        {
                            var temp50 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp50)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M4;
                            }
                            else
                            {
                                var temp51 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp51)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M6;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M5;
                                }
                            }
                        }
                    }
                }

                M20:
                {
                    if (!ie.MoveNext())
                        goto F20;
                    i = ie.Current;
                    {
                        var temp52 = (((ushort)(i)) == ((ushort)((ushort)115U)));
                        if (temp52)
                        {
                            goto M21;
                        }
                        else
                        {
                            var temp53 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp53)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M4;
                            }
                            else
                            {
                                var temp54 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp54)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M6;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M5;
                                }
                            }
                        }
                    }
                }

                M21:
                {
                    if (!ie.MoveNext())
                        goto F21;
                    i = ie.Current;
                    {
                        var temp55 = (((ushort)(i)) == ((ushort)((ushort)101U)));
                        if (temp55)
                        {
                            goto M22;
                        }
                        else
                        {
                            var temp56 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp56)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M4;
                            }
                            else
                            {
                                var temp57 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp57)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M6;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M5;
                                }
                            }
                        }
                    }
                }

                M22:
                {
                    if (!ie.MoveNext())
                        goto F22;
                    i = ie.Current;
                    {
                        var temp58 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp58)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M23;
                        }
                        else
                        {
                            var temp59 = (((ushort)(i)) == ((ushort)((ushort)32U)));
                            if (temp59)
                            {
                                goto M24;
                            }
                            else
                            {
                                var temp60 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp60)
                                {
                                    goto M25;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M5;
                                }
                            }
                        }
                    }
                }

                M23:
                {
                    if (!ie.MoveNext())
                        goto F23;
                    i = ie.Current;
                    {
                        var temp61 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp61)
                        {
                            goto M27;
                        }
                        else
                        {
                            goto M23;
                        }
                    }
                }

                M24:
                {
                    if (!ie.MoveNext())
                        goto F24;
                    i = ie.Current;
                    {
                        var temp62 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp62)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M23;
                        }
                        else
                        {
                            var temp63 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp63)
                            {
                                goto M26;
                            }
                            else
                            {
                                goto M24;
                            }
                        }
                    }
                }

                M25:
                {
                    if (!ie.MoveNext())
                        goto F25;
                    i = ie.Current;
                    {
                        var temp64 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp64)
                        {
                            goto M0;
                        }
                        else
                            throw new Exception();
                    }
                }

                M26:
                {
                    if (!ie.MoveNext())
                        goto F26;
                    i = ie.Current;
                    {
                        var temp65 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp65)
                        {
                            goto M0;
                        }
                        else
                        {
                            var temp66 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp66)
                            {
                                goto M26;
                            }
                            else
                            {
                                goto M24;
                            }
                        }
                    }
                }

                M27:
                {
                    if (!ie.MoveNext())
                        goto F27;
                    i = ie.Current;
                    {
                        var temp67 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp67)
                        {
                            goto M28;
                        }
                        else
                        {
                            var temp68 = (((ushort)(i)) == ((ushort)((ushort)80U)));
                            if (temp68)
                            {
                                goto M29;
                            }
                            else
                            {
                                var temp69 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                                if (temp69)
                                {
                                    s._1 = ((uint)((uint)1U));
                                    goto M30;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M31;
                                }
                            }
                        }
                    }
                }

                M28:
                {
                    if (!ie.MoveNext())
                        goto F28;
                    i = ie.Current;
                    {
                        var temp70 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp70)
                        {
                            goto M0;
                        }
                        else
                        {
                            goto M28;
                        }
                    }
                }

                M29:
                {
                    if (!ie.MoveNext())
                        goto F29;
                    i = ie.Current;
                    {
                        var temp71 = (((ushort)(i)) == ((ushort)((ushort)114U)));
                        if (temp71)
                        {
                            goto M35;
                        }
                        else
                        {
                            var temp72 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp72)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M30;
                            }
                            else
                            {
                                var temp73 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp73)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M32;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M31;
                                }
                            }
                        }
                    }
                }

                M30:
                {
                    if (!ie.MoveNext())
                        goto F30;
                    i = ie.Current;
                    {
                        var temp74 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp74)
                        {
                            goto M33;
                        }
                        else
                        {
                            goto M30;
                        }
                    }
                }

                M31:
                {
                    if (!ie.MoveNext())
                        goto F31;
                    i = ie.Current;
                    {
                        var temp75 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp75)
                        {
                            var temp76 = ((uint)(((uint)((uint)1U)) + ((uint)((s)._1))));
                            s._1 = ((uint)(temp76));
                            goto M30;
                        }
                        else
                        {
                            var temp77 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp77)
                            {
                                goto M32;
                            }
                            else
                            {
                                goto M31;
                            }
                        }
                    }
                }

                M32:
                {
                    if (!ie.MoveNext())
                        goto F32;
                    i = ie.Current;
                    {
                        var temp78 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp78)
                        {
                            var temp79 = (((uint)((s)._1)) == ((uint)((uint)0U)));
                            if (temp79)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M23;
                            }
                            else
                            {
                                goto M30;
                            }
                        }
                        else
                        {
                            var temp80 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp80)
                            {
                                goto M32;
                            }
                            else
                            {
                                goto M31;
                            }
                        }
                    }
                }

                M33:
                {
                    if (!ie.MoveNext())
                        goto F33;
                    i = ie.Current;
                    {
                        var temp81 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp81)
                        {
                            goto M34;
                        }
                        else
                        {
                            goto M31;
                        }
                    }
                }

                M34:
                {
                    if (!ie.MoveNext())
                        goto F34;
                    i = ie.Current;
                    {
                        var temp82 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp82)
                        {
                            var temp83 = (((uint)((s)._1)) == ((uint)((uint)1U)));
                            if (temp83)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M23;
                            }
                            else
                            {
                                var temp84 = ((uint)(((uint)((uint)4294967295U)) + ((uint)((s)._1))));
                                s._1 = ((uint)(temp84));
                                goto M30;
                            }
                        }
                        else
                        {
                            goto M34;
                        }
                    }
                }

                M35:
                {
                    if (!ie.MoveNext())
                        goto F35;
                    i = ie.Current;
                    {
                        var temp85 = (((ushort)(i)) == ((ushort)((ushort)111U)));
                        if (temp85)
                        {
                            goto M36;
                        }
                        else
                        {
                            var temp86 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp86)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M30;
                            }
                            else
                            {
                                var temp87 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp87)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M32;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M31;
                                }
                            }
                        }
                    }
                }

                M36:
                {
                    if (!ie.MoveNext())
                        goto F36;
                    i = ie.Current;
                    {
                        var temp88 = (((ushort)(i)) == ((ushort)((ushort)116U)));
                        if (temp88)
                        {
                            goto M37;
                        }
                        else
                        {
                            var temp89 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp89)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M30;
                            }
                            else
                            {
                                var temp90 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp90)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M32;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M31;
                                }
                            }
                        }
                    }
                }

                M37:
                {
                    if (!ie.MoveNext())
                        goto F37;
                    i = ie.Current;
                    {
                        var temp91 = (((ushort)(i)) == ((ushort)((ushort)101U)));
                        if (temp91)
                        {
                            goto M38;
                        }
                        else
                        {
                            var temp92 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp92)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M30;
                            }
                            else
                            {
                                var temp93 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp93)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M32;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M31;
                                }
                            }
                        }
                    }
                }

                M38:
                {
                    if (!ie.MoveNext())
                        goto F38;
                    i = ie.Current;
                    {
                        var temp94 = (((ushort)(i)) == ((ushort)((ushort)105U)));
                        if (temp94)
                        {
                            goto M39;
                        }
                        else
                        {
                            var temp95 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp95)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M30;
                            }
                            else
                            {
                                var temp96 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp96)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M32;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M31;
                                }
                            }
                        }
                    }
                }

                M39:
                {
                    if (!ie.MoveNext())
                        goto F39;
                    i = ie.Current;
                    {
                        var temp97 = (((ushort)(i)) == ((ushort)((ushort)110U)));
                        if (temp97)
                        {
                            goto M40;
                        }
                        else
                        {
                            var temp98 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp98)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M30;
                            }
                            else
                            {
                                var temp99 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp99)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M32;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M31;
                                }
                            }
                        }
                    }
                }

                M40:
                {
                    if (!ie.MoveNext())
                        goto F40;
                    i = ie.Current;
                    {
                        var temp100 = (((ushort)(i)) == ((ushort)((ushort)69U)));
                        if (temp100)
                        {
                            goto M41;
                        }
                        else
                        {
                            var temp101 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp101)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M30;
                            }
                            else
                            {
                                var temp102 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp102)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M32;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M31;
                                }
                            }
                        }
                    }
                }

                M41:
                {
                    if (!ie.MoveNext())
                        goto F41;
                    i = ie.Current;
                    {
                        var temp103 = (((ushort)(i)) == ((ushort)((ushort)110U)));
                        if (temp103)
                        {
                            goto M42;
                        }
                        else
                        {
                            var temp104 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp104)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M30;
                            }
                            else
                            {
                                var temp105 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp105)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M32;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M31;
                                }
                            }
                        }
                    }
                }

                M42:
                {
                    if (!ie.MoveNext())
                        goto F42;
                    i = ie.Current;
                    {
                        var temp106 = (((ushort)(i)) == ((ushort)((ushort)116U)));
                        if (temp106)
                        {
                            goto M43;
                        }
                        else
                        {
                            var temp107 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp107)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M30;
                            }
                            else
                            {
                                var temp108 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp108)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M32;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M31;
                                }
                            }
                        }
                    }
                }

                M43:
                {
                    if (!ie.MoveNext())
                        goto F43;
                    i = ie.Current;
                    {
                        var temp109 = (((ushort)(i)) == ((ushort)((ushort)114U)));
                        if (temp109)
                        {
                            goto M44;
                        }
                        else
                        {
                            var temp110 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp110)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M30;
                            }
                            else
                            {
                                var temp111 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp111)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M32;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M31;
                                }
                            }
                        }
                    }
                }

                M44:
                {
                    if (!ie.MoveNext())
                        goto F44;
                    i = ie.Current;
                    {
                        var temp112 = (((ushort)(i)) == ((ushort)((ushort)121U)));
                        if (temp112)
                        {
                            goto M45;
                        }
                        else
                        {
                            var temp113 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp113)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M30;
                            }
                            else
                            {
                                var temp114 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp114)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M32;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M31;
                                }
                            }
                        }
                    }
                }

                M45:
                {
                    if (!ie.MoveNext())
                        goto F45;
                    i = ie.Current;
                    {
                        var temp115 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp115)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M46;
                        }
                        else
                        {
                            var temp116 = (((ushort)(i)) == ((ushort)((ushort)32U)));
                            if (temp116)
                            {
                                goto M47;
                            }
                            else
                            {
                                var temp117 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp117)
                                {
                                    goto M48;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M31;
                                }
                            }
                        }
                    }
                }

                M46:
                {
                    if (!ie.MoveNext())
                        goto F46;
                    i = ie.Current;
                    {
                        var temp118 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp118)
                        {
                            goto M50;
                        }
                        else
                        {
                            goto M46;
                        }
                    }
                }

                M47:
                {
                    if (!ie.MoveNext())
                        goto F47;
                    i = ie.Current;
                    {
                        var temp119 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp119)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M46;
                        }
                        else
                        {
                            var temp120 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp120)
                            {
                                goto M49;
                            }
                            else
                            {
                                goto M47;
                            }
                        }
                    }
                }

                M48:
                {
                    if (!ie.MoveNext())
                        goto F48;
                    i = ie.Current;
                    {
                        var temp121 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp121)
                        {
                            goto M23;
                        }
                        else
                            throw new Exception();
                    }
                }

                M49:
                {
                    if (!ie.MoveNext())
                        goto F49;
                    i = ie.Current;
                    {
                        var temp122 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp122)
                        {
                            goto M23;
                        }
                        else
                        {
                            var temp123 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp123)
                            {
                                goto M49;
                            }
                            else
                            {
                                goto M47;
                            }
                        }
                    }
                }

                M50:
                {
                    if (!ie.MoveNext())
                        goto F50;
                    i = ie.Current;
                    {
                        var temp124 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp124)
                        {
                            goto M51;
                        }
                        else
                        {
                            var temp125 = (((ushort)(i)) == ((ushort)((ushort)115U)));
                            if (temp125)
                            {
                                goto M52;
                            }
                            else
                            {
                                var temp126 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                                if (temp126)
                                {
                                    s._1 = ((uint)((uint)1U));
                                    goto M53;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M54;
                                }
                            }
                        }
                    }
                }

                M51:
                {
                    if (!ie.MoveNext())
                        goto F51;
                    i = ie.Current;
                    {
                        var temp127 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp127)
                        {
                            goto M23;
                        }
                        else
                        {
                            goto M51;
                        }
                    }
                }

                M52:
                {
                    if (!ie.MoveNext())
                        goto F52;
                    i = ie.Current;
                    {
                        var temp128 = (((ushort)(i)) == ((ushort)((ushort)117U)));
                        if (temp128)
                        {
                            goto M58;
                        }
                        else
                        {
                            var temp129 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp129)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M53;
                            }
                            else
                            {
                                var temp130 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp130)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M55;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M54;
                                }
                            }
                        }
                    }
                }

                M53:
                {
                    if (!ie.MoveNext())
                        goto F53;
                    i = ie.Current;
                    {
                        var temp131 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp131)
                        {
                            goto M56;
                        }
                        else
                        {
                            goto M53;
                        }
                    }
                }

                M54:
                {
                    if (!ie.MoveNext())
                        goto F54;
                    i = ie.Current;
                    {
                        var temp132 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp132)
                        {
                            var temp133 = ((uint)(((uint)((uint)1U)) + ((uint)((s)._1))));
                            s._1 = ((uint)(temp133));
                            goto M53;
                        }
                        else
                        {
                            var temp134 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp134)
                            {
                                goto M55;
                            }
                            else
                            {
                                goto M54;
                            }
                        }
                    }
                }

                M55:
                {
                    if (!ie.MoveNext())
                        goto F55;
                    i = ie.Current;
                    {
                        var temp135 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp135)
                        {
                            var temp136 = (((uint)((s)._1)) == ((uint)((uint)0U)));
                            if (temp136)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M46;
                            }
                            else
                            {
                                goto M53;
                            }
                        }
                        else
                        {
                            var temp137 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp137)
                            {
                                goto M55;
                            }
                            else
                            {
                                goto M54;
                            }
                        }
                    }
                }

                M56:
                {
                    if (!ie.MoveNext())
                        goto F56;
                    i = ie.Current;
                    {
                        var temp138 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp138)
                        {
                            goto M57;
                        }
                        else
                        {
                            goto M54;
                        }
                    }
                }

                M57:
                {
                    if (!ie.MoveNext())
                        goto F57;
                    i = ie.Current;
                    {
                        var temp139 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp139)
                        {
                            var temp140 = (((uint)((s)._1)) == ((uint)((uint)1U)));
                            if (temp140)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M46;
                            }
                            else
                            {
                                var temp141 = ((uint)(((uint)((uint)4294967295U)) + ((uint)((s)._1))));
                                s._1 = ((uint)(temp141));
                                goto M53;
                            }
                        }
                        else
                        {
                            goto M57;
                        }
                    }
                }

                M58:
                {
                    if (!ie.MoveNext())
                        goto F58;
                    i = ie.Current;
                    {
                        var temp142 = (((ushort)(i)) == ((ushort)((ushort)109U)));
                        if (temp142)
                        {
                            goto M59;
                        }
                        else
                        {
                            var temp143 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp143)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M53;
                            }
                            else
                            {
                                var temp144 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp144)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M55;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M54;
                                }
                            }
                        }
                    }
                }

                M59:
                {
                    if (!ie.MoveNext())
                        goto F59;
                    i = ie.Current;
                    {
                        var temp145 = (((ushort)(i)) == ((ushort)((ushort)109U)));
                        if (temp145)
                        {
                            goto M60;
                        }
                        else
                        {
                            var temp146 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp146)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M53;
                            }
                            else
                            {
                                var temp147 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp147)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M55;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M54;
                                }
                            }
                        }
                    }
                }

                M60:
                {
                    if (!ie.MoveNext())
                        goto F60;
                    i = ie.Current;
                    {
                        var temp148 = (((ushort)(i)) == ((ushort)((ushort)97U)));
                        if (temp148)
                        {
                            goto M61;
                        }
                        else
                        {
                            var temp149 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp149)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M53;
                            }
                            else
                            {
                                var temp150 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp150)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M55;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M54;
                                }
                            }
                        }
                    }
                }

                M61:
                {
                    if (!ie.MoveNext())
                        goto F61;
                    i = ie.Current;
                    {
                        var temp151 = (((ushort)(i)) == ((ushort)((ushort)114U)));
                        if (temp151)
                        {
                            goto M62;
                        }
                        else
                        {
                            var temp152 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp152)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M53;
                            }
                            else
                            {
                                var temp153 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp153)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M55;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M54;
                                }
                            }
                        }
                    }
                }

                M62:
                {
                    if (!ie.MoveNext())
                        goto F62;
                    i = ie.Current;
                    {
                        var temp154 = (((ushort)(i)) == ((ushort)((ushort)121U)));
                        if (temp154)
                        {
                            goto M63;
                        }
                        else
                        {
                            var temp155 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp155)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M53;
                            }
                            else
                            {
                                var temp156 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp156)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M55;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M54;
                                }
                            }
                        }
                    }
                }

                M63:
                {
                    if (!ie.MoveNext())
                        goto F63;
                    i = ie.Current;
                    {
                        var temp157 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp157)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M64;
                        }
                        else
                        {
                            var temp158 = (((ushort)(i)) == ((ushort)((ushort)32U)));
                            if (temp158)
                            {
                                goto M65;
                            }
                            else
                            {
                                var temp159 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp159)
                                {
                                    goto M66;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M54;
                                }
                            }
                        }
                    }
                }

                M64:
                {
                    if (!ie.MoveNext())
                        goto F64;
                    i = ie.Current;
                    {
                        var temp160 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp160)
                        {
                            goto M68;
                        }
                        else
                        {
                            goto M64;
                        }
                    }
                }

                M65:
                {
                    if (!ie.MoveNext())
                        goto F65;
                    i = ie.Current;
                    {
                        var temp161 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp161)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M64;
                        }
                        else
                        {
                            var temp162 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp162)
                            {
                                goto M67;
                            }
                            else
                            {
                                goto M65;
                            }
                        }
                    }
                }

                M66:
                {
                    if (!ie.MoveNext())
                        goto F66;
                    i = ie.Current;
                    {
                        var temp163 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp163)
                        {
                            goto M46;
                        }
                        else
                            throw new Exception();
                    }
                }

                M67:
                {
                    if (!ie.MoveNext())
                        goto F67;
                    i = ie.Current;
                    {
                        var temp164 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp164)
                        {
                            goto M46;
                        }
                        else
                        {
                            var temp165 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp165)
                            {
                                goto M67;
                            }
                            else
                            {
                                goto M65;
                            }
                        }
                    }
                }

                M68:
                {
                    if (!ie.MoveNext())
                        goto F68;
                    i = ie.Current;
                    {
                        var temp166 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp166)
                        {
                            goto M69;
                        }
                        else
                        {
                            var temp167 = (((ushort)(i)) == ((ushort)((ushort)108U)));
                            if (temp167)
                            {
                                goto M70;
                            }
                            else
                            {
                                var temp168 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                                if (temp168)
                                {
                                    s._1 = ((uint)((uint)1U));
                                    goto M71;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M72;
                                }
                            }
                        }
                    }
                }

                M69:
                {
                    if (!ie.MoveNext())
                        goto F69;
                    i = ie.Current;
                    {
                        var temp169 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp169)
                        {
                            goto M46;
                        }
                        else
                        {
                            goto M69;
                        }
                    }
                }

                M70:
                {
                    if (!ie.MoveNext())
                        goto F70;
                    i = ie.Current;
                    {
                        var temp170 = (((ushort)(i)) == ((ushort)((ushort)101U)));
                        if (temp170)
                        {
                            goto M76;
                        }
                        else
                        {
                            var temp171 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp171)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M71;
                            }
                            else
                            {
                                var temp172 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp172)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M73;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M72;
                                }
                            }
                        }
                    }
                }

                M71:
                {
                    if (!ie.MoveNext())
                        goto F71;
                    i = ie.Current;
                    {
                        var temp173 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp173)
                        {
                            goto M74;
                        }
                        else
                        {
                            goto M71;
                        }
                    }
                }

                M72:
                {
                    if (!ie.MoveNext())
                        goto F72;
                    i = ie.Current;
                    {
                        var temp174 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp174)
                        {
                            var temp175 = ((uint)(((uint)((uint)1U)) + ((uint)((s)._1))));
                            s._1 = ((uint)(temp175));
                            goto M71;
                        }
                        else
                        {
                            var temp176 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp176)
                            {
                                goto M73;
                            }
                            else
                            {
                                goto M72;
                            }
                        }
                    }
                }

                M73:
                {
                    if (!ie.MoveNext())
                        goto F73;
                    i = ie.Current;
                    {
                        var temp177 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp177)
                        {
                            var temp178 = (((uint)((s)._1)) == ((uint)((uint)0U)));
                            if (temp178)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M64;
                            }
                            else
                            {
                                goto M71;
                            }
                        }
                        else
                        {
                            var temp179 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp179)
                            {
                                goto M73;
                            }
                            else
                            {
                                goto M72;
                            }
                        }
                    }
                }

                M74:
                {
                    if (!ie.MoveNext())
                        goto F74;
                    i = ie.Current;
                    {
                        var temp180 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp180)
                        {
                            goto M75;
                        }
                        else
                        {
                            goto M72;
                        }
                    }
                }

                M75:
                {
                    if (!ie.MoveNext())
                        goto F75;
                    i = ie.Current;
                    {
                        var temp181 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp181)
                        {
                            var temp182 = (((uint)((s)._1)) == ((uint)((uint)1U)));
                            if (temp182)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M64;
                            }
                            else
                            {
                                var temp183 = ((uint)(((uint)((uint)4294967295U)) + ((uint)((s)._1))));
                                s._1 = ((uint)(temp183));
                                goto M71;
                            }
                        }
                        else
                        {
                            goto M75;
                        }
                    }
                }

                M76:
                {
                    if (!ie.MoveNext())
                        goto F76;
                    i = ie.Current;
                    {
                        var temp184 = (((ushort)(i)) == ((ushort)((ushort)110U)));
                        if (temp184)
                        {
                            goto M77;
                        }
                        else
                        {
                            var temp185 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp185)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M71;
                            }
                            else
                            {
                                var temp186 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp186)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M73;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M72;
                                }
                            }
                        }
                    }
                }

                M77:
                {
                    if (!ie.MoveNext())
                        goto F77;
                    i = ie.Current;
                    {
                        var temp187 = (((ushort)(i)) == ((ushort)((ushort)103U)));
                        if (temp187)
                        {
                            goto M78;
                        }
                        else
                        {
                            var temp188 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp188)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M71;
                            }
                            else
                            {
                                var temp189 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp189)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M73;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M72;
                                }
                            }
                        }
                    }
                }

                M78:
                {
                    if (!ie.MoveNext())
                        goto F78;
                    i = ie.Current;
                    {
                        var temp190 = (((ushort)(i)) == ((ushort)((ushort)116U)));
                        if (temp190)
                        {
                            goto M79;
                        }
                        else
                        {
                            var temp191 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp191)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M71;
                            }
                            else
                            {
                                var temp192 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp192)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M73;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M72;
                                }
                            }
                        }
                    }
                }

                M79:
                {
                    if (!ie.MoveNext())
                        goto F79;
                    i = ie.Current;
                    {
                        var temp193 = (((ushort)(i)) == ((ushort)((ushort)104U)));
                        if (temp193)
                        {
                            goto M80;
                        }
                        else
                        {
                            var temp194 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp194)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M71;
                            }
                            else
                            {
                                var temp195 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp195)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M73;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M72;
                                }
                            }
                        }
                    }
                }

                M80:
                {
                    if (!ie.MoveNext())
                        goto F80;
                    i = ie.Current;
                    {
                        var temp196 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp196)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M81;
                        }
                        else
                        {
                            var temp197 = (((ushort)(i)) == ((ushort)((ushort)32U)));
                            if (temp197)
                            {
                                goto M82;
                            }
                            else
                            {
                                var temp198 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp198)
                                {
                                    goto M83;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M72;
                                }
                            }
                        }
                    }
                }

                M81:
                {
                    if (!ie.MoveNext())
                        goto F81;
                    i = ie.Current;
                    {
                        var temp199 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp199)
                        {
                            yield return (Int32)((s)._0);
                            s._0 = ((uint)((uint)0U));
                            goto M85;
                        }
                        else
                        {
                            var temp200 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._0))));
                            var temp201 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                            var temp202 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp200))) + ((uint)(temp201))));
                            s._0 = ((uint)(temp202));
                            goto M81;
                        }
                    }
                }

                M82:
                {
                    if (!ie.MoveNext())
                        goto F82;
                    i = ie.Current;
                    {
                        var temp203 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp203)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M81;
                        }
                        else
                        {
                            var temp204 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp204)
                            {
                                goto M84;
                            }
                            else
                            {
                                goto M82;
                            }
                        }
                    }
                }

                M83:
                {
                    if (!ie.MoveNext())
                        goto F83;
                    i = ie.Current;
                    {
                        var temp205 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp205)
                        {
                            goto M64;
                        }
                        else
                            throw new Exception();
                    }
                }

                M84:
                {
                    if (!ie.MoveNext())
                        goto F84;
                    i = ie.Current;
                    {
                        var temp206 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp206)
                        {
                            goto M64;
                        }
                        else
                        {
                            var temp207 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp207)
                            {
                                goto M84;
                            }
                            else
                            {
                                goto M82;
                            }
                        }
                    }
                }

                M85:
                {
                    if (!ie.MoveNext())
                        goto F85;
                    i = ie.Current;
                    {
                        var temp208 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp208)
                        {
                            goto M86;
                        }
                        else
                            throw new Exception();
                    }
                }

                M86:
                {
                    if (!ie.MoveNext())
                        goto F86;
                    i = ie.Current;
                    {
                        var temp209 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp209)
                        {
                            goto M64;
                        }
                        else
                        {
                            goto M86;
                        }
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

                F10:
                {
                    yield break;
                }

                F11:
                {
                    yield break;
                }

                F12:
                {
                    yield break;
                }

                F13:
                {
                    yield break;
                }

                F14:
                {
                    yield break;
                }

                F15:
                {
                    yield break;
                }

                F16:
                {
                    yield break;
                }

                F17:
                {
                    yield break;
                }

                F18:
                {
                    yield break;
                }

                F19:
                {
                    yield break;
                }

                F20:
                {
                    yield break;
                }

                F21:
                {
                    yield break;
                }

                F22:
                {
                    yield break;
                }

                F23:
                {
                    yield break;
                }

                F24:
                {
                    yield break;
                }

                F25:
                {
                    yield break;
                }

                F26:
                {
                    yield break;
                }

                F27:
                {
                    yield break;
                }

                F28:
                {
                    yield break;
                }

                F29:
                {
                    yield break;
                }

                F30:
                {
                    yield break;
                }

                F31:
                {
                    yield break;
                }

                F32:
                {
                    yield break;
                }

                F33:
                {
                    yield break;
                }

                F34:
                {
                    yield break;
                }

                F35:
                {
                    yield break;
                }

                F36:
                {
                    yield break;
                }

                F37:
                {
                    yield break;
                }

                F38:
                {
                    yield break;
                }

                F39:
                {
                    yield break;
                }

                F40:
                {
                    yield break;
                }

                F41:
                {
                    yield break;
                }

                F42:
                {
                    yield break;
                }

                F43:
                {
                    yield break;
                }

                F44:
                {
                    yield break;
                }

                F45:
                {
                    yield break;
                }

                F46:
                {
                    yield break;
                }

                F47:
                {
                    yield break;
                }

                F48:
                {
                    yield break;
                }

                F49:
                {
                    yield break;
                }

                F50:
                {
                    yield break;
                }

                F51:
                {
                    yield break;
                }

                F52:
                {
                    yield break;
                }

                F53:
                {
                    yield break;
                }

                F54:
                {
                    yield break;
                }

                F55:
                {
                    yield break;
                }

                F56:
                {
                    yield break;
                }

                F57:
                {
                    yield break;
                }

                F58:
                {
                    yield break;
                }

                F59:
                {
                    yield break;
                }

                F60:
                {
                    yield break;
                }

                F61:
                {
                    yield break;
                }

                F62:
                {
                    yield break;
                }

                F63:
                {
                    yield break;
                }

                F64:
                {
                    yield break;
                }

                F65:
                {
                    yield break;
                }

                F66:
                {
                    yield break;
                }

                F67:
                {
                    yield break;
                }

                F68:
                {
                    yield break;
                }

                F69:
                {
                    yield break;
                }

                F70:
                {
                    yield break;
                }

                F71:
                {
                    yield break;
                }

                F72:
                {
                    yield break;
                }

                F73:
                {
                    yield break;
                }

                F74:
                {
                    yield break;
                }

                F75:
                {
                    yield break;
                }

                F76:
                {
                    yield break;
                }

                F77:
                {
                    yield break;
                }

                F78:
                {
                    yield break;
                }

                F79:
                {
                    yield break;
                }

                F80:
                {
                    yield break;
                }

                F81:
                {
                    yield break;
                }

                F82:
                {
                    yield break;
                }

                F83:
                {
                    yield break;
                }

                F84:
                {
                    yield break;
                }

                F85:
                {
                    yield break;
                }

                F86:
                {
                    yield break;
                }
            }
        }
    }
}