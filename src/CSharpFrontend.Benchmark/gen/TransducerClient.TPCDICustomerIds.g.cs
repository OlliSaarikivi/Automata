using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class TPCDICustomerIds : SpecialTransducer
    {
        struct DTStruct3
        {
            public UInt32 _0;
            public UInt32 _1;
            public DTStruct3(UInt32 v0, UInt32 v1)
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
                DTStruct3 s = new DTStruct3(((uint)((uint)0U)), ((uint)((uint)0U)));
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
                            var temp2 = (((ushort)(i)) == ((ushort)((ushort)84U)));
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
                        var temp5 = (((ushort)(i)) == ((ushort)((ushort)80U)));
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
                        var temp19 = (((ushort)(i)) == ((ushort)((ushort)67U)));
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
                        var temp22 = (((ushort)(i)) == ((ushort)((ushort)68U)));
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
                        var temp25 = (((ushort)(i)) == ((ushort)((ushort)73U)));
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
                        var temp28 = (((ushort)(i)) == ((ushort)((ushort)58U)));
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
                        var temp31 = (((ushort)(i)) == ((ushort)((ushort)65U)));
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
                        var temp34 = (((ushort)(i)) == ((ushort)((ushort)99U)));
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
                        var temp37 = (((ushort)(i)) == ((ushort)((ushort)116U)));
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
                        var temp40 = (((ushort)(i)) == ((ushort)((ushort)105U)));
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
                        var temp43 = (((ushort)(i)) == ((ushort)((ushort)111U)));
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
                        var temp46 = (((ushort)(i)) == ((ushort)((ushort)110U)));
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
                        var temp49 = (((ushort)(i)) == ((ushort)((ushort)115U)));
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
                        var temp52 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp52)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M21;
                        }
                        else
                        {
                            var temp53 = (((ushort)(i)) == ((ushort)((ushort)32U)));
                            if (temp53)
                            {
                                goto M22;
                            }
                            else
                            {
                                var temp54 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp54)
                                {
                                    goto M23;
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
                        var temp55 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp55)
                        {
                            goto M25;
                        }
                        else
                        {
                            goto M21;
                        }
                    }
                }

                M22:
                {
                    if (!ie.MoveNext())
                        goto F22;
                    i = ie.Current;
                    {
                        var temp56 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp56)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M21;
                        }
                        else
                        {
                            var temp57 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp57)
                            {
                                goto M24;
                            }
                            else
                            {
                                goto M22;
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
                        var temp58 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp58)
                        {
                            goto M0;
                        }
                        else
                            throw new Exception();
                    }
                }

                M24:
                {
                    if (!ie.MoveNext())
                        goto F24;
                    i = ie.Current;
                    {
                        var temp59 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp59)
                        {
                            goto M0;
                        }
                        else
                        {
                            var temp60 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp60)
                            {
                                goto M24;
                            }
                            else
                            {
                                goto M22;
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
                        var temp61 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp61)
                        {
                            goto M26;
                        }
                        else
                        {
                            var temp62 = (((ushort)(i)) == ((ushort)((ushort)84U)));
                            if (temp62)
                            {
                                goto M27;
                            }
                            else
                            {
                                var temp63 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                                if (temp63)
                                {
                                    s._1 = ((uint)((uint)1U));
                                    goto M28;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M29;
                                }
                            }
                        }
                    }
                }

                M26:
                {
                    if (!ie.MoveNext())
                        goto F26;
                    i = ie.Current;
                    {
                        var temp64 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp64)
                        {
                            goto M0;
                        }
                        else
                        {
                            goto M26;
                        }
                    }
                }

                M27:
                {
                    if (!ie.MoveNext())
                        goto F27;
                    i = ie.Current;
                    {
                        var temp65 = (((ushort)(i)) == ((ushort)((ushort)80U)));
                        if (temp65)
                        {
                            goto M33;
                        }
                        else
                        {
                            var temp66 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp66)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M28;
                            }
                            else
                            {
                                var temp67 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp67)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M30;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M29;
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
                        var temp68 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp68)
                        {
                            goto M31;
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
                        var temp69 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp69)
                        {
                            var temp70 = ((uint)(((uint)((uint)1U)) + ((uint)((s)._1))));
                            s._1 = ((uint)(temp70));
                            goto M28;
                        }
                        else
                        {
                            var temp71 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp71)
                            {
                                goto M30;
                            }
                            else
                            {
                                goto M29;
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
                        var temp72 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp72)
                        {
                            var temp73 = (((uint)((s)._1)) == ((uint)((uint)0U)));
                            if (temp73)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M21;
                            }
                            else
                            {
                                goto M28;
                            }
                        }
                        else
                        {
                            var temp74 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp74)
                            {
                                goto M30;
                            }
                            else
                            {
                                goto M29;
                            }
                        }
                    }
                }

                M31:
                {
                    if (!ie.MoveNext())
                        goto F31;
                    i = ie.Current;
                    {
                        var temp75 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp75)
                        {
                            goto M32;
                        }
                        else
                        {
                            goto M29;
                        }
                    }
                }

                M32:
                {
                    if (!ie.MoveNext())
                        goto F32;
                    i = ie.Current;
                    {
                        var temp76 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp76)
                        {
                            var temp77 = (((uint)((s)._1)) == ((uint)((uint)1U)));
                            if (temp77)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M21;
                            }
                            else
                            {
                                var temp78 = ((uint)(((uint)((uint)4294967295U)) + ((uint)((s)._1))));
                                s._1 = ((uint)(temp78));
                                goto M28;
                            }
                        }
                        else
                        {
                            goto M32;
                        }
                    }
                }

                M33:
                {
                    if (!ie.MoveNext())
                        goto F33;
                    i = ie.Current;
                    {
                        var temp79 = (((ushort)(i)) == ((ushort)((ushort)67U)));
                        if (temp79)
                        {
                            goto M34;
                        }
                        else
                        {
                            var temp80 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp80)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M28;
                            }
                            else
                            {
                                var temp81 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp81)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M30;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M29;
                                }
                            }
                        }
                    }
                }

                M34:
                {
                    if (!ie.MoveNext())
                        goto F34;
                    i = ie.Current;
                    {
                        var temp82 = (((ushort)(i)) == ((ushort)((ushort)68U)));
                        if (temp82)
                        {
                            goto M35;
                        }
                        else
                        {
                            var temp83 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp83)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M28;
                            }
                            else
                            {
                                var temp84 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp84)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M30;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M29;
                                }
                            }
                        }
                    }
                }

                M35:
                {
                    if (!ie.MoveNext())
                        goto F35;
                    i = ie.Current;
                    {
                        var temp85 = (((ushort)(i)) == ((ushort)((ushort)73U)));
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
                                goto M28;
                            }
                            else
                            {
                                var temp87 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp87)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M30;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M29;
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
                        var temp88 = (((ushort)(i)) == ((ushort)((ushort)58U)));
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
                                goto M28;
                            }
                            else
                            {
                                var temp90 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp90)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M30;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M29;
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
                        var temp91 = (((ushort)(i)) == ((ushort)((ushort)65U)));
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
                                goto M28;
                            }
                            else
                            {
                                var temp93 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp93)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M30;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M29;
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
                        var temp94 = (((ushort)(i)) == ((ushort)((ushort)99U)));
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
                                goto M28;
                            }
                            else
                            {
                                var temp96 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp96)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M30;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M29;
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
                        var temp97 = (((ushort)(i)) == ((ushort)((ushort)116U)));
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
                                goto M28;
                            }
                            else
                            {
                                var temp99 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp99)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M30;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M29;
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
                        var temp100 = (((ushort)(i)) == ((ushort)((ushort)105U)));
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
                                goto M28;
                            }
                            else
                            {
                                var temp102 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp102)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M30;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M29;
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
                        var temp103 = (((ushort)(i)) == ((ushort)((ushort)111U)));
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
                                goto M28;
                            }
                            else
                            {
                                var temp105 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp105)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M30;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M29;
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
                        var temp106 = (((ushort)(i)) == ((ushort)((ushort)110U)));
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
                                goto M28;
                            }
                            else
                            {
                                var temp108 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp108)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M30;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M29;
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
                        var temp109 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp109)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M44;
                        }
                        else
                        {
                            var temp110 = (((ushort)(i)) == ((ushort)((ushort)32U)));
                            if (temp110)
                            {
                                goto M45;
                            }
                            else
                            {
                                var temp111 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp111)
                                {
                                    goto M46;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M29;
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
                        var temp112 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp112)
                        {
                            goto M48;
                        }
                        else
                        {
                            goto M44;
                        }
                    }
                }

                M45:
                {
                    if (!ie.MoveNext())
                        goto F45;
                    i = ie.Current;
                    {
                        var temp113 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp113)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M44;
                        }
                        else
                        {
                            var temp114 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp114)
                            {
                                goto M47;
                            }
                            else
                            {
                                goto M45;
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
                        var temp115 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp115)
                        {
                            goto M21;
                        }
                        else
                            throw new Exception();
                    }
                }

                M47:
                {
                    if (!ie.MoveNext())
                        goto F47;
                    i = ie.Current;
                    {
                        var temp116 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp116)
                        {
                            goto M21;
                        }
                        else
                        {
                            var temp117 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp117)
                            {
                                goto M47;
                            }
                            else
                            {
                                goto M45;
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
                        var temp118 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp118)
                        {
                            goto M49;
                        }
                        else
                        {
                            var temp119 = (((ushort)(i)) == ((ushort)((ushort)67U)));
                            if (temp119)
                            {
                                goto M50;
                            }
                            else
                            {
                                var temp120 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                                if (temp120)
                                {
                                    s._1 = ((uint)((uint)1U));
                                    goto M51;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M52;
                                }
                            }
                        }
                    }
                }

                M49:
                {
                    if (!ie.MoveNext())
                        goto F49;
                    i = ie.Current;
                    {
                        var temp121 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp121)
                        {
                            goto M21;
                        }
                        else
                        {
                            goto M49;
                        }
                    }
                }

                M50:
                {
                    if (!ie.MoveNext())
                        goto F50;
                    i = ie.Current;
                    {
                        var temp122 = (((ushort)(i)) == ((ushort)((ushort)117U)));
                        if (temp122)
                        {
                            goto M56;
                        }
                        else
                        {
                            var temp123 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp123)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M51;
                            }
                            else
                            {
                                var temp124 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp124)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M53;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M52;
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
                        var temp125 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp125)
                        {
                            goto M54;
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
                        var temp126 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp126)
                        {
                            var temp127 = ((uint)(((uint)((uint)1U)) + ((uint)((s)._1))));
                            s._1 = ((uint)(temp127));
                            goto M51;
                        }
                        else
                        {
                            var temp128 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp128)
                            {
                                goto M53;
                            }
                            else
                            {
                                goto M52;
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
                        var temp129 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp129)
                        {
                            var temp130 = (((uint)((s)._1)) == ((uint)((uint)0U)));
                            if (temp130)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M44;
                            }
                            else
                            {
                                goto M51;
                            }
                        }
                        else
                        {
                            var temp131 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp131)
                            {
                                goto M53;
                            }
                            else
                            {
                                goto M52;
                            }
                        }
                    }
                }

                M54:
                {
                    if (!ie.MoveNext())
                        goto F54;
                    i = ie.Current;
                    {
                        var temp132 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp132)
                        {
                            goto M55;
                        }
                        else
                        {
                            goto M52;
                        }
                    }
                }

                M55:
                {
                    if (!ie.MoveNext())
                        goto F55;
                    i = ie.Current;
                    {
                        var temp133 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp133)
                        {
                            var temp134 = (((uint)((s)._1)) == ((uint)((uint)1U)));
                            if (temp134)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M44;
                            }
                            else
                            {
                                var temp135 = ((uint)(((uint)((uint)4294967295U)) + ((uint)((s)._1))));
                                s._1 = ((uint)(temp135));
                                goto M51;
                            }
                        }
                        else
                        {
                            goto M55;
                        }
                    }
                }

                M56:
                {
                    if (!ie.MoveNext())
                        goto F56;
                    i = ie.Current;
                    {
                        var temp136 = (((ushort)(i)) == ((ushort)((ushort)115U)));
                        if (temp136)
                        {
                            goto M57;
                        }
                        else
                        {
                            var temp137 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp137)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M51;
                            }
                            else
                            {
                                var temp138 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp138)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M53;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M52;
                                }
                            }
                        }
                    }
                }

                M57:
                {
                    if (!ie.MoveNext())
                        goto F57;
                    i = ie.Current;
                    {
                        var temp139 = (((ushort)(i)) == ((ushort)((ushort)116U)));
                        if (temp139)
                        {
                            goto M58;
                        }
                        else
                        {
                            var temp140 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp140)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M51;
                            }
                            else
                            {
                                var temp141 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp141)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M53;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M52;
                                }
                            }
                        }
                    }
                }

                M58:
                {
                    if (!ie.MoveNext())
                        goto F58;
                    i = ie.Current;
                    {
                        var temp142 = (((ushort)(i)) == ((ushort)((ushort)111U)));
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
                                goto M51;
                            }
                            else
                            {
                                var temp144 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp144)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M53;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M52;
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
                                goto M51;
                            }
                            else
                            {
                                var temp147 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp147)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M53;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M52;
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
                        var temp148 = (((ushort)(i)) == ((ushort)((ushort)101U)));
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
                                goto M51;
                            }
                            else
                            {
                                var temp150 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp150)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M53;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M52;
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
                                goto M51;
                            }
                            else
                            {
                                var temp153 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp153)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M53;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M52;
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
                        var temp154 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp154)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M63;
                        }
                        else
                        {
                            var temp155 = (((ushort)(i)) == ((ushort)((ushort)32U)));
                            if (temp155)
                            {
                                goto M64;
                            }
                            else
                            {
                                var temp156 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp156)
                                {
                                    goto M65;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M52;
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
                        var temp157 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp157)
                        {
                            goto M67;
                        }
                        else
                        {
                            goto M63;
                        }
                    }
                }

                M64:
                {
                    if (!ie.MoveNext())
                        goto F64;
                    i = ie.Current;
                    {
                        var temp158 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp158)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M63;
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
                                goto M64;
                            }
                        }
                    }
                }

                M65:
                {
                    if (!ie.MoveNext())
                        goto F65;
                    i = ie.Current;
                    {
                        var temp160 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp160)
                        {
                            goto M44;
                        }
                        else
                            throw new Exception();
                    }
                }

                M66:
                {
                    if (!ie.MoveNext())
                        goto F66;
                    i = ie.Current;
                    {
                        var temp161 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp161)
                        {
                            goto M44;
                        }
                        else
                        {
                            var temp162 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp162)
                            {
                                goto M66;
                            }
                            else
                            {
                                goto M64;
                            }
                        }
                    }
                }

                M67:
                {
                    if (!ie.MoveNext())
                        goto F67;
                    i = ie.Current;
                    {
                        var temp163 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp163)
                        {
                            goto M68;
                        }
                        else
                        {
                            var temp164 = (((ushort)(i)) == ((ushort)((ushort)65U)));
                            if (temp164)
                            {
                                goto M69;
                            }
                            else
                            {
                                var temp165 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                                if (temp165)
                                {
                                    s._1 = ((uint)((uint)1U));
                                    goto M70;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M71;
                                }
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
                        var temp166 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp166)
                        {
                            goto M44;
                        }
                        else
                        {
                            goto M68;
                        }
                    }
                }

                M69:
                {
                    if (!ie.MoveNext())
                        goto F69;
                    i = ie.Current;
                    {
                        var temp167 = (((ushort)(i)) == ((ushort)((ushort)99U)));
                        if (temp167)
                        {
                            goto M75;
                        }
                        else
                        {
                            var temp168 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp168)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M70;
                            }
                            else
                            {
                                var temp169 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp169)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M72;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M71;
                                }
                            }
                        }
                    }
                }

                M70:
                {
                    if (!ie.MoveNext())
                        goto F70;
                    i = ie.Current;
                    {
                        var temp170 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp170)
                        {
                            goto M73;
                        }
                        else
                        {
                            goto M70;
                        }
                    }
                }

                M71:
                {
                    if (!ie.MoveNext())
                        goto F71;
                    i = ie.Current;
                    {
                        var temp171 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp171)
                        {
                            var temp172 = ((uint)(((uint)((uint)1U)) + ((uint)((s)._1))));
                            s._1 = ((uint)(temp172));
                            goto M70;
                        }
                        else
                        {
                            var temp173 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp173)
                            {
                                goto M72;
                            }
                            else
                            {
                                goto M71;
                            }
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
                            var temp175 = (((uint)((s)._1)) == ((uint)((uint)0U)));
                            if (temp175)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M63;
                            }
                            else
                            {
                                goto M70;
                            }
                        }
                        else
                        {
                            var temp176 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp176)
                            {
                                goto M72;
                            }
                            else
                            {
                                goto M71;
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
                        var temp177 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp177)
                        {
                            goto M74;
                        }
                        else
                        {
                            goto M71;
                        }
                    }
                }

                M74:
                {
                    if (!ie.MoveNext())
                        goto F74;
                    i = ie.Current;
                    {
                        var temp178 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp178)
                        {
                            var temp179 = (((uint)((s)._1)) == ((uint)((uint)1U)));
                            if (temp179)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M63;
                            }
                            else
                            {
                                var temp180 = ((uint)(((uint)((uint)4294967295U)) + ((uint)((s)._1))));
                                s._1 = ((uint)(temp180));
                                goto M70;
                            }
                        }
                        else
                        {
                            goto M74;
                        }
                    }
                }

                M75:
                {
                    if (!ie.MoveNext())
                        goto F75;
                    i = ie.Current;
                    {
                        var temp181 = (((ushort)(i)) == ((ushort)((ushort)99U)));
                        if (temp181)
                        {
                            goto M76;
                        }
                        else
                        {
                            var temp182 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp182)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M70;
                            }
                            else
                            {
                                var temp183 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp183)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M72;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M71;
                                }
                            }
                        }
                    }
                }

                M76:
                {
                    if (!ie.MoveNext())
                        goto F76;
                    i = ie.Current;
                    {
                        var temp184 = (((ushort)(i)) == ((ushort)((ushort)111U)));
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
                                goto M70;
                            }
                            else
                            {
                                var temp186 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp186)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M72;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M71;
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
                        var temp187 = (((ushort)(i)) == ((ushort)((ushort)117U)));
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
                                goto M70;
                            }
                            else
                            {
                                var temp189 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp189)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M72;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M71;
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
                        var temp190 = (((ushort)(i)) == ((ushort)((ushort)110U)));
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
                                goto M70;
                            }
                            else
                            {
                                var temp192 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp192)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M72;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M71;
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
                        var temp193 = (((ushort)(i)) == ((ushort)((ushort)116U)));
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
                                goto M70;
                            }
                            else
                            {
                                var temp195 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp195)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M72;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M71;
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
                                    goto M71;
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
                            goto M85;
                        }
                        else
                        {
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
                        var temp200 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp200)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M81;
                        }
                        else
                        {
                            var temp201 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp201)
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
                        var temp202 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp202)
                        {
                            goto M63;
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
                        var temp203 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp203)
                        {
                            goto M63;
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

                M85:
                {
                    if (!ie.MoveNext())
                        goto F85;
                    i = ie.Current;
                    {
                        var temp205 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp205)
                        {
                            goto M86;
                        }
                        else
                        {
                            var temp206 = (((ushort)(i)) == ((ushort)((ushort)67U)));
                            if (temp206)
                            {
                                goto M87;
                            }
                            else
                            {
                                var temp207 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                                if (temp207)
                                {
                                    s._1 = ((uint)((uint)1U));
                                    goto M88;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M89;
                                }
                            }
                        }
                    }
                }

                M86:
                {
                    if (!ie.MoveNext())
                        goto F86;
                    i = ie.Current;
                    {
                        var temp208 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp208)
                        {
                            goto M63;
                        }
                        else
                        {
                            goto M86;
                        }
                    }
                }

                M87:
                {
                    if (!ie.MoveNext())
                        goto F87;
                    i = ie.Current;
                    {
                        var temp209 = (((ushort)(i)) == ((ushort)((ushort)65U)));
                        if (temp209)
                        {
                            goto M93;
                        }
                        else
                        {
                            var temp210 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp210)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M88;
                            }
                            else
                            {
                                var temp211 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp211)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M90;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M89;
                                }
                            }
                        }
                    }
                }

                M88:
                {
                    if (!ie.MoveNext())
                        goto F88;
                    i = ie.Current;
                    {
                        var temp212 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp212)
                        {
                            goto M91;
                        }
                        else
                        {
                            goto M88;
                        }
                    }
                }

                M89:
                {
                    if (!ie.MoveNext())
                        goto F89;
                    i = ie.Current;
                    {
                        var temp213 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp213)
                        {
                            var temp214 = ((uint)(((uint)((uint)1U)) + ((uint)((s)._1))));
                            s._1 = ((uint)(temp214));
                            goto M88;
                        }
                        else
                        {
                            var temp215 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp215)
                            {
                                goto M90;
                            }
                            else
                            {
                                goto M89;
                            }
                        }
                    }
                }

                M90:
                {
                    if (!ie.MoveNext())
                        goto F90;
                    i = ie.Current;
                    {
                        var temp216 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp216)
                        {
                            var temp217 = (((uint)((s)._1)) == ((uint)((uint)0U)));
                            if (temp217)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M81;
                            }
                            else
                            {
                                goto M88;
                            }
                        }
                        else
                        {
                            var temp218 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp218)
                            {
                                goto M90;
                            }
                            else
                            {
                                goto M89;
                            }
                        }
                    }
                }

                M91:
                {
                    if (!ie.MoveNext())
                        goto F91;
                    i = ie.Current;
                    {
                        var temp219 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp219)
                        {
                            goto M92;
                        }
                        else
                        {
                            goto M89;
                        }
                    }
                }

                M92:
                {
                    if (!ie.MoveNext())
                        goto F92;
                    i = ie.Current;
                    {
                        var temp220 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp220)
                        {
                            var temp221 = (((uint)((s)._1)) == ((uint)((uint)1U)));
                            if (temp221)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M81;
                            }
                            else
                            {
                                var temp222 = ((uint)(((uint)((uint)4294967295U)) + ((uint)((s)._1))));
                                s._1 = ((uint)(temp222));
                                goto M88;
                            }
                        }
                        else
                        {
                            goto M92;
                        }
                    }
                }

                M93:
                {
                    if (!ie.MoveNext())
                        goto F93;
                    i = ie.Current;
                    {
                        var temp223 = (((ushort)(i)) == ((ushort)((ushort)95U)));
                        if (temp223)
                        {
                            goto M94;
                        }
                        else
                        {
                            var temp224 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp224)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M88;
                            }
                            else
                            {
                                var temp225 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp225)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M90;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M89;
                                }
                            }
                        }
                    }
                }

                M94:
                {
                    if (!ie.MoveNext())
                        goto F94;
                    i = ie.Current;
                    {
                        var temp226 = (((ushort)(i)) == ((ushort)((ushort)66U)));
                        if (temp226)
                        {
                            goto M95;
                        }
                        else
                        {
                            var temp227 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp227)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M88;
                            }
                            else
                            {
                                var temp228 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp228)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M90;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M89;
                                }
                            }
                        }
                    }
                }

                M95:
                {
                    if (!ie.MoveNext())
                        goto F95;
                    i = ie.Current;
                    {
                        var temp229 = (((ushort)(i)) == ((ushort)((ushort)95U)));
                        if (temp229)
                        {
                            goto M96;
                        }
                        else
                        {
                            var temp230 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp230)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M88;
                            }
                            else
                            {
                                var temp231 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp231)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M90;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M89;
                                }
                            }
                        }
                    }
                }

                M96:
                {
                    if (!ie.MoveNext())
                        goto F96;
                    i = ie.Current;
                    {
                        var temp232 = (((ushort)(i)) == ((ushort)((ushort)73U)));
                        if (temp232)
                        {
                            goto M97;
                        }
                        else
                        {
                            var temp233 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp233)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M88;
                            }
                            else
                            {
                                var temp234 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp234)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M90;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M89;
                                }
                            }
                        }
                    }
                }

                M97:
                {
                    if (!ie.MoveNext())
                        goto F97;
                    i = ie.Current;
                    {
                        var temp235 = (((ushort)(i)) == ((ushort)((ushort)68U)));
                        if (temp235)
                        {
                            goto M98;
                        }
                        else
                        {
                            var temp236 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp236)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M88;
                            }
                            else
                            {
                                var temp237 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp237)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M90;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M89;
                                }
                            }
                        }
                    }
                }

                M98:
                {
                    if (!ie.MoveNext())
                        goto F98;
                    i = ie.Current;
                    {
                        var temp238 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp238)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M99;
                        }
                        else
                        {
                            var temp239 = (((ushort)(i)) == ((ushort)((ushort)32U)));
                            if (temp239)
                            {
                                goto M100;
                            }
                            else
                            {
                                var temp240 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp240)
                                {
                                    goto M101;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M89;
                                }
                            }
                        }
                    }
                }

                M99:
                {
                    if (!ie.MoveNext())
                        goto F99;
                    i = ie.Current;
                    {
                        var temp241 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp241)
                        {
                            yield return (Int32)((s)._0);
                            s._0 = ((uint)((uint)0U));
                            goto M103;
                        }
                        else
                        {
                            var temp242 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._0))));
                            var temp243 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                            var temp244 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp242))) + ((uint)(temp243))));
                            s._0 = ((uint)(temp244));
                            goto M99;
                        }
                    }
                }

                M100:
                {
                    if (!ie.MoveNext())
                        goto F100;
                    i = ie.Current;
                    {
                        var temp245 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp245)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M99;
                        }
                        else
                        {
                            var temp246 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp246)
                            {
                                goto M102;
                            }
                            else
                            {
                                goto M100;
                            }
                        }
                    }
                }

                M101:
                {
                    if (!ie.MoveNext())
                        goto F101;
                    i = ie.Current;
                    {
                        var temp247 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp247)
                        {
                            goto M81;
                        }
                        else
                            throw new Exception();
                    }
                }

                M102:
                {
                    if (!ie.MoveNext())
                        goto F102;
                    i = ie.Current;
                    {
                        var temp248 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp248)
                        {
                            goto M81;
                        }
                        else
                        {
                            var temp249 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp249)
                            {
                                goto M102;
                            }
                            else
                            {
                                goto M100;
                            }
                        }
                    }
                }

                M103:
                {
                    if (!ie.MoveNext())
                        goto F103;
                    i = ie.Current;
                    {
                        var temp250 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp250)
                        {
                            goto M104;
                        }
                        else
                            throw new Exception();
                    }
                }

                M104:
                {
                    if (!ie.MoveNext())
                        goto F104;
                    i = ie.Current;
                    {
                        var temp251 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp251)
                        {
                            goto M81;
                        }
                        else
                        {
                            goto M104;
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

                F87:
                {
                    yield break;
                }

                F88:
                {
                    yield break;
                }

                F89:
                {
                    yield break;
                }

                F90:
                {
                    yield break;
                }

                F91:
                {
                    yield break;
                }

                F92:
                {
                    yield break;
                }

                F93:
                {
                    yield break;
                }

                F94:
                {
                    yield break;
                }

                F95:
                {
                    yield break;
                }

                F96:
                {
                    yield break;
                }

                F97:
                {
                    yield break;
                }

                F98:
                {
                    yield break;
                }

                F99:
                {
                    yield break;
                }

                F100:
                {
                    yield break;
                }

                F101:
                {
                    yield break;
                }

                F102:
                {
                    yield break;
                }

                F103:
                {
                    yield break;
                }

                F104:
                {
                    yield break;
                }
            }
        }
    }
}