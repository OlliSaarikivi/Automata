using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class MondialCityPopulation : SpecialTransducer
    {
        struct DTStruct6
        {
            public UInt32 _0;
            public UInt32 _1;
            public DTStruct6(UInt32 v0, UInt32 v1)
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
                DTStruct6 s = new DTStruct6(((uint)((uint)0U)), ((uint)((uint)0U)));
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
                            var temp2 = (((ushort)(i)) == ((ushort)((ushort)109U)));
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
                        var temp5 = (((ushort)(i)) == ((ushort)((ushort)111U)));
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
                        var temp19 = (((ushort)(i)) == ((ushort)((ushort)110U)));
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
                        var temp22 = (((ushort)(i)) == ((ushort)((ushort)100U)));
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
                        var temp25 = (((ushort)(i)) == ((ushort)((ushort)105U)));
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
                        var temp28 = (((ushort)(i)) == ((ushort)((ushort)97U)));
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
                        var temp31 = (((ushort)(i)) == ((ushort)((ushort)108U)));
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
                        var temp34 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp34)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M15;
                        }
                        else
                        {
                            var temp35 = (((ushort)(i)) == ((ushort)((ushort)32U)));
                            if (temp35)
                            {
                                goto M16;
                            }
                            else
                            {
                                var temp36 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp36)
                                {
                                    goto M17;
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
                        var temp37 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp37)
                        {
                            goto M19;
                        }
                        else
                        {
                            goto M15;
                        }
                    }
                }

                M16:
                {
                    if (!ie.MoveNext())
                        goto F16;
                    i = ie.Current;
                    {
                        var temp38 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp38)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M15;
                        }
                        else
                        {
                            var temp39 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp39)
                            {
                                goto M18;
                            }
                            else
                            {
                                goto M16;
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
                        var temp40 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp40)
                        {
                            goto M0;
                        }
                        else
                            throw new Exception();
                    }
                }

                M18:
                {
                    if (!ie.MoveNext())
                        goto F18;
                    i = ie.Current;
                    {
                        var temp41 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp41)
                        {
                            goto M0;
                        }
                        else
                        {
                            var temp42 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp42)
                            {
                                goto M18;
                            }
                            else
                            {
                                goto M16;
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
                        var temp43 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp43)
                        {
                            goto M20;
                        }
                        else
                        {
                            var temp44 = (((ushort)(i)) == ((ushort)((ushort)99U)));
                            if (temp44)
                            {
                                goto M21;
                            }
                            else
                            {
                                var temp45 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                                if (temp45)
                                {
                                    s._1 = ((uint)((uint)1U));
                                    goto M22;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M23;
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
                        var temp46 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp46)
                        {
                            goto M0;
                        }
                        else
                        {
                            goto M20;
                        }
                    }
                }

                M21:
                {
                    if (!ie.MoveNext())
                        goto F21;
                    i = ie.Current;
                    {
                        var temp47 = (((ushort)(i)) == ((ushort)((ushort)111U)));
                        if (temp47)
                        {
                            goto M27;
                        }
                        else
                        {
                            var temp48 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp48)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M22;
                            }
                            else
                            {
                                var temp49 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp49)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M24;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M23;
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
                        var temp50 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp50)
                        {
                            goto M25;
                        }
                        else
                        {
                            goto M22;
                        }
                    }
                }

                M23:
                {
                    if (!ie.MoveNext())
                        goto F23;
                    i = ie.Current;
                    {
                        var temp51 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp51)
                        {
                            var temp52 = ((uint)(((uint)((uint)1U)) + ((uint)((s)._1))));
                            s._1 = ((uint)(temp52));
                            goto M22;
                        }
                        else
                        {
                            var temp53 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp53)
                            {
                                goto M24;
                            }
                            else
                            {
                                goto M23;
                            }
                        }
                    }
                }

                M24:
                {
                    if (!ie.MoveNext())
                        goto F24;
                    i = ie.Current;
                    {
                        var temp54 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp54)
                        {
                            var temp55 = (((uint)((s)._1)) == ((uint)((uint)0U)));
                            if (temp55)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M15;
                            }
                            else
                            {
                                goto M22;
                            }
                        }
                        else
                        {
                            var temp56 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp56)
                            {
                                goto M24;
                            }
                            else
                            {
                                goto M23;
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
                        var temp57 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp57)
                        {
                            goto M26;
                        }
                        else
                        {
                            goto M23;
                        }
                    }
                }

                M26:
                {
                    if (!ie.MoveNext())
                        goto F26;
                    i = ie.Current;
                    {
                        var temp58 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp58)
                        {
                            var temp59 = (((uint)((s)._1)) == ((uint)((uint)1U)));
                            if (temp59)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M15;
                            }
                            else
                            {
                                var temp60 = ((uint)(((uint)((uint)4294967295U)) + ((uint)((s)._1))));
                                s._1 = ((uint)(temp60));
                                goto M22;
                            }
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
                        var temp61 = (((ushort)(i)) == ((ushort)((ushort)117U)));
                        if (temp61)
                        {
                            goto M28;
                        }
                        else
                        {
                            var temp62 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp62)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M22;
                            }
                            else
                            {
                                var temp63 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp63)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M24;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M23;
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
                        var temp64 = (((ushort)(i)) == ((ushort)((ushort)110U)));
                        if (temp64)
                        {
                            goto M29;
                        }
                        else
                        {
                            var temp65 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp65)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M22;
                            }
                            else
                            {
                                var temp66 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp66)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M24;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M23;
                                }
                            }
                        }
                    }
                }

                M29:
                {
                    if (!ie.MoveNext())
                        goto F29;
                    i = ie.Current;
                    {
                        var temp67 = (((ushort)(i)) == ((ushort)((ushort)116U)));
                        if (temp67)
                        {
                            goto M30;
                        }
                        else
                        {
                            var temp68 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp68)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M22;
                            }
                            else
                            {
                                var temp69 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp69)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M24;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M23;
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
                        var temp70 = (((ushort)(i)) == ((ushort)((ushort)114U)));
                        if (temp70)
                        {
                            goto M31;
                        }
                        else
                        {
                            var temp71 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp71)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M22;
                            }
                            else
                            {
                                var temp72 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp72)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M24;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M23;
                                }
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
                        var temp73 = (((ushort)(i)) == ((ushort)((ushort)121U)));
                        if (temp73)
                        {
                            goto M32;
                        }
                        else
                        {
                            var temp74 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp74)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M22;
                            }
                            else
                            {
                                var temp75 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp75)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M24;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M23;
                                }
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
                        var temp76 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp76)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M33;
                        }
                        else
                        {
                            var temp77 = (((ushort)(i)) == ((ushort)((ushort)32U)));
                            if (temp77)
                            {
                                goto M34;
                            }
                            else
                            {
                                var temp78 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp78)
                                {
                                    goto M35;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M23;
                                }
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
                        var temp79 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp79)
                        {
                            goto M37;
                        }
                        else
                        {
                            goto M33;
                        }
                    }
                }

                M34:
                {
                    if (!ie.MoveNext())
                        goto F34;
                    i = ie.Current;
                    {
                        var temp80 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp80)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M33;
                        }
                        else
                        {
                            var temp81 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp81)
                            {
                                goto M36;
                            }
                            else
                            {
                                goto M34;
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
                        var temp82 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp82)
                        {
                            goto M15;
                        }
                        else
                            throw new Exception();
                    }
                }

                M36:
                {
                    if (!ie.MoveNext())
                        goto F36;
                    i = ie.Current;
                    {
                        var temp83 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp83)
                        {
                            goto M15;
                        }
                        else
                        {
                            var temp84 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp84)
                            {
                                goto M36;
                            }
                            else
                            {
                                goto M34;
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
                        var temp85 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp85)
                        {
                            goto M38;
                        }
                        else
                        {
                            var temp86 = (((ushort)(i)) == ((ushort)((ushort)99U)));
                            if (temp86)
                            {
                                goto M39;
                            }
                            else
                            {
                                var temp87 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                                if (temp87)
                                {
                                    s._1 = ((uint)((uint)1U));
                                    goto M40;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M41;
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
                        var temp88 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp88)
                        {
                            goto M15;
                        }
                        else
                        {
                            goto M38;
                        }
                    }
                }

                M39:
                {
                    if (!ie.MoveNext())
                        goto F39;
                    i = ie.Current;
                    {
                        var temp89 = (((ushort)(i)) == ((ushort)((ushort)105U)));
                        if (temp89)
                        {
                            goto M45;
                        }
                        else
                        {
                            var temp90 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp90)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M40;
                            }
                            else
                            {
                                var temp91 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp91)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M42;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M41;
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
                        var temp92 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp92)
                        {
                            goto M43;
                        }
                        else
                        {
                            goto M40;
                        }
                    }
                }

                M41:
                {
                    if (!ie.MoveNext())
                        goto F41;
                    i = ie.Current;
                    {
                        var temp93 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp93)
                        {
                            var temp94 = ((uint)(((uint)((uint)1U)) + ((uint)((s)._1))));
                            s._1 = ((uint)(temp94));
                            goto M40;
                        }
                        else
                        {
                            var temp95 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp95)
                            {
                                goto M42;
                            }
                            else
                            {
                                goto M41;
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
                        var temp96 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp96)
                        {
                            var temp97 = (((uint)((s)._1)) == ((uint)((uint)0U)));
                            if (temp97)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M33;
                            }
                            else
                            {
                                goto M40;
                            }
                        }
                        else
                        {
                            var temp98 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp98)
                            {
                                goto M42;
                            }
                            else
                            {
                                goto M41;
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
                        var temp99 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp99)
                        {
                            goto M44;
                        }
                        else
                        {
                            goto M41;
                        }
                    }
                }

                M44:
                {
                    if (!ie.MoveNext())
                        goto F44;
                    i = ie.Current;
                    {
                        var temp100 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp100)
                        {
                            var temp101 = (((uint)((s)._1)) == ((uint)((uint)1U)));
                            if (temp101)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M33;
                            }
                            else
                            {
                                var temp102 = ((uint)(((uint)((uint)4294967295U)) + ((uint)((s)._1))));
                                s._1 = ((uint)(temp102));
                                goto M40;
                            }
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
                        var temp103 = (((ushort)(i)) == ((ushort)((ushort)116U)));
                        if (temp103)
                        {
                            goto M46;
                        }
                        else
                        {
                            var temp104 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp104)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M40;
                            }
                            else
                            {
                                var temp105 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp105)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M42;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M41;
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
                        var temp106 = (((ushort)(i)) == ((ushort)((ushort)121U)));
                        if (temp106)
                        {
                            goto M47;
                        }
                        else
                        {
                            var temp107 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp107)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M40;
                            }
                            else
                            {
                                var temp108 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp108)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M42;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M41;
                                }
                            }
                        }
                    }
                }

                M47:
                {
                    if (!ie.MoveNext())
                        goto F47;
                    i = ie.Current;
                    {
                        var temp109 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp109)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M48;
                        }
                        else
                        {
                            var temp110 = (((ushort)(i)) == ((ushort)((ushort)32U)));
                            if (temp110)
                            {
                                goto M49;
                            }
                            else
                            {
                                var temp111 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp111)
                                {
                                    goto M50;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M41;
                                }
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
                        var temp112 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp112)
                        {
                            goto M52;
                        }
                        else
                        {
                            goto M48;
                        }
                    }
                }

                M49:
                {
                    if (!ie.MoveNext())
                        goto F49;
                    i = ie.Current;
                    {
                        var temp113 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp113)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M48;
                        }
                        else
                        {
                            var temp114 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp114)
                            {
                                goto M51;
                            }
                            else
                            {
                                goto M49;
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
                        var temp115 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp115)
                        {
                            goto M33;
                        }
                        else
                            throw new Exception();
                    }
                }

                M51:
                {
                    if (!ie.MoveNext())
                        goto F51;
                    i = ie.Current;
                    {
                        var temp116 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp116)
                        {
                            goto M33;
                        }
                        else
                        {
                            var temp117 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp117)
                            {
                                goto M51;
                            }
                            else
                            {
                                goto M49;
                            }
                        }
                    }
                }

                M52:
                {
                    if (!ie.MoveNext())
                        goto F52;
                    i = ie.Current;
                    {
                        var temp118 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp118)
                        {
                            goto M53;
                        }
                        else
                        {
                            var temp119 = (((ushort)(i)) == ((ushort)((ushort)112U)));
                            if (temp119)
                            {
                                goto M54;
                            }
                            else
                            {
                                var temp120 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                                if (temp120)
                                {
                                    s._1 = ((uint)((uint)1U));
                                    goto M55;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M56;
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
                        var temp121 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp121)
                        {
                            goto M33;
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
                        var temp122 = (((ushort)(i)) == ((ushort)((ushort)111U)));
                        if (temp122)
                        {
                            goto M60;
                        }
                        else
                        {
                            var temp123 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp123)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M55;
                            }
                            else
                            {
                                var temp124 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp124)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M57;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M56;
                                }
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
                        var temp125 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp125)
                        {
                            goto M58;
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
                        var temp126 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp126)
                        {
                            var temp127 = ((uint)(((uint)((uint)1U)) + ((uint)((s)._1))));
                            s._1 = ((uint)(temp127));
                            goto M55;
                        }
                        else
                        {
                            var temp128 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp128)
                            {
                                goto M57;
                            }
                            else
                            {
                                goto M56;
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
                        var temp129 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp129)
                        {
                            var temp130 = (((uint)((s)._1)) == ((uint)((uint)0U)));
                            if (temp130)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M48;
                            }
                            else
                            {
                                goto M55;
                            }
                        }
                        else
                        {
                            var temp131 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp131)
                            {
                                goto M57;
                            }
                            else
                            {
                                goto M56;
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
                        var temp132 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp132)
                        {
                            goto M59;
                        }
                        else
                        {
                            goto M56;
                        }
                    }
                }

                M59:
                {
                    if (!ie.MoveNext())
                        goto F59;
                    i = ie.Current;
                    {
                        var temp133 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp133)
                        {
                            var temp134 = (((uint)((s)._1)) == ((uint)((uint)1U)));
                            if (temp134)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M48;
                            }
                            else
                            {
                                var temp135 = ((uint)(((uint)((uint)4294967295U)) + ((uint)((s)._1))));
                                s._1 = ((uint)(temp135));
                                goto M55;
                            }
                        }
                        else
                        {
                            goto M59;
                        }
                    }
                }

                M60:
                {
                    if (!ie.MoveNext())
                        goto F60;
                    i = ie.Current;
                    {
                        var temp136 = (((ushort)(i)) == ((ushort)((ushort)112U)));
                        if (temp136)
                        {
                            goto M61;
                        }
                        else
                        {
                            var temp137 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp137)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M55;
                            }
                            else
                            {
                                var temp138 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp138)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M57;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M56;
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
                        var temp139 = (((ushort)(i)) == ((ushort)((ushort)117U)));
                        if (temp139)
                        {
                            goto M62;
                        }
                        else
                        {
                            var temp140 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp140)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M55;
                            }
                            else
                            {
                                var temp141 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp141)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M57;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M56;
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
                        var temp142 = (((ushort)(i)) == ((ushort)((ushort)108U)));
                        if (temp142)
                        {
                            goto M63;
                        }
                        else
                        {
                            var temp143 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp143)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M55;
                            }
                            else
                            {
                                var temp144 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp144)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M57;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M56;
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
                        var temp145 = (((ushort)(i)) == ((ushort)((ushort)97U)));
                        if (temp145)
                        {
                            goto M64;
                        }
                        else
                        {
                            var temp146 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp146)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M55;
                            }
                            else
                            {
                                var temp147 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp147)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M57;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M56;
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
                        var temp148 = (((ushort)(i)) == ((ushort)((ushort)116U)));
                        if (temp148)
                        {
                            goto M65;
                        }
                        else
                        {
                            var temp149 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp149)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M55;
                            }
                            else
                            {
                                var temp150 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp150)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M57;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M56;
                                }
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
                        var temp151 = (((ushort)(i)) == ((ushort)((ushort)105U)));
                        if (temp151)
                        {
                            goto M66;
                        }
                        else
                        {
                            var temp152 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp152)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M55;
                            }
                            else
                            {
                                var temp153 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp153)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M57;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M56;
                                }
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
                        var temp154 = (((ushort)(i)) == ((ushort)((ushort)111U)));
                        if (temp154)
                        {
                            goto M67;
                        }
                        else
                        {
                            var temp155 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp155)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M55;
                            }
                            else
                            {
                                var temp156 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp156)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M57;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M56;
                                }
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
                        var temp157 = (((ushort)(i)) == ((ushort)((ushort)110U)));
                        if (temp157)
                        {
                            goto M68;
                        }
                        else
                        {
                            var temp158 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp158)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M55;
                            }
                            else
                            {
                                var temp159 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp159)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M57;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M56;
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
                        var temp160 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp160)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M69;
                        }
                        else
                        {
                            var temp161 = (((ushort)(i)) == ((ushort)((ushort)32U)));
                            if (temp161)
                            {
                                goto M70;
                            }
                            else
                            {
                                var temp162 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp162)
                                {
                                    goto M71;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M56;
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
                        var temp163 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp163)
                        {
                            yield return (Int32)((s)._0);
                            s._0 = ((uint)((uint)0U));
                            goto M73;
                        }
                        else
                        {
                            var temp164 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._0))));
                            var temp165 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                            var temp166 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp164))) + ((uint)(temp165))));
                            s._0 = ((uint)(temp166));
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
                        var temp167 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp167)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M69;
                        }
                        else
                        {
                            var temp168 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp168)
                            {
                                goto M72;
                            }
                            else
                            {
                                goto M70;
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
                        var temp169 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp169)
                        {
                            goto M48;
                        }
                        else
                            throw new Exception();
                    }
                }

                M72:
                {
                    if (!ie.MoveNext())
                        goto F72;
                    i = ie.Current;
                    {
                        var temp170 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp170)
                        {
                            goto M48;
                        }
                        else
                        {
                            var temp171 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp171)
                            {
                                goto M72;
                            }
                            else
                            {
                                goto M70;
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
                        var temp172 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp172)
                        {
                            goto M74;
                        }
                        else
                            throw new Exception();
                    }
                }

                M74:
                {
                    if (!ie.MoveNext())
                        goto F74;
                    i = ie.Current;
                    {
                        var temp173 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp173)
                        {
                            goto M48;
                        }
                        else
                        {
                            goto M74;
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
            }
        }
    }
}