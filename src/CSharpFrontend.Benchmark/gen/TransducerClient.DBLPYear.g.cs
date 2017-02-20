using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class DBLPYear : SpecialTransducer
    {
        struct DTStruct5
        {
            public UInt32 _0;
            public UInt32 _1;
            public DTStruct5(UInt32 v0, UInt32 v1)
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
                DTStruct5 s = new DTStruct5(((uint)((uint)0U)), ((uint)((uint)0U)));
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
                            var temp2 = (((ushort)(i)) == ((ushort)((ushort)100U)));
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
                        var temp5 = (((ushort)(i)) == ((ushort)((ushort)98U)));
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
                        var temp19 = (((ushort)(i)) == ((ushort)((ushort)108U)));
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
                        var temp22 = (((ushort)(i)) == ((ushort)((ushort)112U)));
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
                        var temp25 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp25)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M12;
                        }
                        else
                        {
                            var temp26 = (((ushort)(i)) == ((ushort)((ushort)32U)));
                            if (temp26)
                            {
                                goto M13;
                            }
                            else
                            {
                                var temp27 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp27)
                                {
                                    goto M14;
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
                        var temp28 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp28)
                        {
                            goto M16;
                        }
                        else
                        {
                            goto M12;
                        }
                    }
                }

                M13:
                {
                    if (!ie.MoveNext())
                        goto F13;
                    i = ie.Current;
                    {
                        var temp29 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp29)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M12;
                        }
                        else
                        {
                            var temp30 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp30)
                            {
                                goto M15;
                            }
                            else
                            {
                                goto M13;
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
                        var temp31 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp31)
                        {
                            goto M0;
                        }
                        else
                            throw new Exception();
                    }
                }

                M15:
                {
                    if (!ie.MoveNext())
                        goto F15;
                    i = ie.Current;
                    {
                        var temp32 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp32)
                        {
                            goto M0;
                        }
                        else
                        {
                            var temp33 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp33)
                            {
                                goto M15;
                            }
                            else
                            {
                                goto M13;
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
                        var temp34 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp34)
                        {
                            goto M17;
                        }
                        else
                        {
                            var temp35 = (((ushort)(i)) == ((ushort)((ushort)97U)));
                            if (temp35)
                            {
                                goto M18;
                            }
                            else
                            {
                                var temp36 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                                if (temp36)
                                {
                                    s._1 = ((uint)((uint)1U));
                                    goto M19;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M20;
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
                        var temp37 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp37)
                        {
                            goto M0;
                        }
                        else
                        {
                            goto M17;
                        }
                    }
                }

                M18:
                {
                    if (!ie.MoveNext())
                        goto F18;
                    i = ie.Current;
                    {
                        var temp38 = (((ushort)(i)) == ((ushort)((ushort)114U)));
                        if (temp38)
                        {
                            goto M24;
                        }
                        else
                        {
                            var temp39 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp39)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M19;
                            }
                            else
                            {
                                var temp40 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp40)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M21;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M20;
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
                        var temp41 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp41)
                        {
                            goto M22;
                        }
                        else
                        {
                            goto M19;
                        }
                    }
                }

                M20:
                {
                    if (!ie.MoveNext())
                        goto F20;
                    i = ie.Current;
                    {
                        var temp42 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp42)
                        {
                            var temp43 = ((uint)(((uint)((uint)1U)) + ((uint)((s)._1))));
                            s._1 = ((uint)(temp43));
                            goto M19;
                        }
                        else
                        {
                            var temp44 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp44)
                            {
                                goto M21;
                            }
                            else
                            {
                                goto M20;
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
                        var temp45 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp45)
                        {
                            var temp46 = (((uint)((s)._1)) == ((uint)((uint)0U)));
                            if (temp46)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M12;
                            }
                            else
                            {
                                goto M19;
                            }
                        }
                        else
                        {
                            var temp47 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp47)
                            {
                                goto M21;
                            }
                            else
                            {
                                goto M20;
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
                        var temp48 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp48)
                        {
                            goto M23;
                        }
                        else
                        {
                            goto M20;
                        }
                    }
                }

                M23:
                {
                    if (!ie.MoveNext())
                        goto F23;
                    i = ie.Current;
                    {
                        var temp49 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp49)
                        {
                            var temp50 = (((uint)((s)._1)) == ((uint)((uint)1U)));
                            if (temp50)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M12;
                            }
                            else
                            {
                                var temp51 = ((uint)(((uint)((uint)4294967295U)) + ((uint)((s)._1))));
                                s._1 = ((uint)(temp51));
                                goto M19;
                            }
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
                        var temp52 = (((ushort)(i)) == ((ushort)((ushort)116U)));
                        if (temp52)
                        {
                            goto M25;
                        }
                        else
                        {
                            var temp53 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp53)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M19;
                            }
                            else
                            {
                                var temp54 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp54)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M21;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M20;
                                }
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
                        var temp55 = (((ushort)(i)) == ((ushort)((ushort)105U)));
                        if (temp55)
                        {
                            goto M26;
                        }
                        else
                        {
                            var temp56 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp56)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M19;
                            }
                            else
                            {
                                var temp57 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp57)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M21;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M20;
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
                        var temp58 = (((ushort)(i)) == ((ushort)((ushort)99U)));
                        if (temp58)
                        {
                            goto M27;
                        }
                        else
                        {
                            var temp59 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp59)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M19;
                            }
                            else
                            {
                                var temp60 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp60)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M21;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M20;
                                }
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
                        var temp61 = (((ushort)(i)) == ((ushort)((ushort)108U)));
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
                                goto M19;
                            }
                            else
                            {
                                var temp63 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp63)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M21;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M20;
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
                        var temp64 = (((ushort)(i)) == ((ushort)((ushort)101U)));
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
                                goto M19;
                            }
                            else
                            {
                                var temp66 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp66)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M21;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M20;
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
                        var temp67 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp67)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M30;
                        }
                        else
                        {
                            var temp68 = (((ushort)(i)) == ((ushort)((ushort)32U)));
                            if (temp68)
                            {
                                goto M31;
                            }
                            else
                            {
                                var temp69 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp69)
                                {
                                    goto M32;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M20;
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
                        var temp70 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp70)
                        {
                            goto M34;
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
                        var temp71 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp71)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M30;
                        }
                        else
                        {
                            var temp72 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp72)
                            {
                                goto M33;
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
                        var temp73 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp73)
                        {
                            goto M12;
                        }
                        else
                            throw new Exception();
                    }
                }

                M33:
                {
                    if (!ie.MoveNext())
                        goto F33;
                    i = ie.Current;
                    {
                        var temp74 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp74)
                        {
                            goto M12;
                        }
                        else
                        {
                            var temp75 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp75)
                            {
                                goto M33;
                            }
                            else
                            {
                                goto M31;
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
                        var temp76 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp76)
                        {
                            goto M35;
                        }
                        else
                        {
                            var temp77 = (((ushort)(i)) == ((ushort)((ushort)121U)));
                            if (temp77)
                            {
                                goto M36;
                            }
                            else
                            {
                                var temp78 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                                if (temp78)
                                {
                                    s._1 = ((uint)((uint)1U));
                                    goto M37;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M38;
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
                        var temp79 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp79)
                        {
                            goto M12;
                        }
                        else
                        {
                            goto M35;
                        }
                    }
                }

                M36:
                {
                    if (!ie.MoveNext())
                        goto F36;
                    i = ie.Current;
                    {
                        var temp80 = (((ushort)(i)) == ((ushort)((ushort)101U)));
                        if (temp80)
                        {
                            goto M42;
                        }
                        else
                        {
                            var temp81 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp81)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M37;
                            }
                            else
                            {
                                var temp82 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp82)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M39;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M38;
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
                        var temp83 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp83)
                        {
                            goto M40;
                        }
                        else
                        {
                            goto M37;
                        }
                    }
                }

                M38:
                {
                    if (!ie.MoveNext())
                        goto F38;
                    i = ie.Current;
                    {
                        var temp84 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp84)
                        {
                            var temp85 = ((uint)(((uint)((uint)1U)) + ((uint)((s)._1))));
                            s._1 = ((uint)(temp85));
                            goto M37;
                        }
                        else
                        {
                            var temp86 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp86)
                            {
                                goto M39;
                            }
                            else
                            {
                                goto M38;
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
                        var temp87 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp87)
                        {
                            var temp88 = (((uint)((s)._1)) == ((uint)((uint)0U)));
                            if (temp88)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M30;
                            }
                            else
                            {
                                goto M37;
                            }
                        }
                        else
                        {
                            var temp89 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp89)
                            {
                                goto M39;
                            }
                            else
                            {
                                goto M38;
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
                        var temp90 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp90)
                        {
                            goto M41;
                        }
                        else
                        {
                            goto M38;
                        }
                    }
                }

                M41:
                {
                    if (!ie.MoveNext())
                        goto F41;
                    i = ie.Current;
                    {
                        var temp91 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp91)
                        {
                            var temp92 = (((uint)((s)._1)) == ((uint)((uint)1U)));
                            if (temp92)
                            {
                                s._1 = ((uint)((uint)0U));
                                goto M30;
                            }
                            else
                            {
                                var temp93 = ((uint)(((uint)((uint)4294967295U)) + ((uint)((s)._1))));
                                s._1 = ((uint)(temp93));
                                goto M37;
                            }
                        }
                        else
                        {
                            goto M41;
                        }
                    }
                }

                M42:
                {
                    if (!ie.MoveNext())
                        goto F42;
                    i = ie.Current;
                    {
                        var temp94 = (((ushort)(i)) == ((ushort)((ushort)97U)));
                        if (temp94)
                        {
                            goto M43;
                        }
                        else
                        {
                            var temp95 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp95)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M37;
                            }
                            else
                            {
                                var temp96 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp96)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M39;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M38;
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
                        var temp97 = (((ushort)(i)) == ((ushort)((ushort)114U)));
                        if (temp97)
                        {
                            goto M44;
                        }
                        else
                        {
                            var temp98 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                            if (temp98)
                            {
                                s._1 = ((uint)((uint)1U));
                                goto M37;
                            }
                            else
                            {
                                var temp99 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp99)
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M39;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M38;
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
                        var temp100 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp100)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M45;
                        }
                        else
                        {
                            var temp101 = (((ushort)(i)) == ((ushort)((ushort)32U)));
                            if (temp101)
                            {
                                goto M46;
                            }
                            else
                            {
                                var temp102 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                                if (temp102)
                                {
                                    goto M47;
                                }
                                else
                                {
                                    s._1 = ((uint)((uint)0U));
                                    goto M38;
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
                        var temp103 = (((ushort)(i)) == ((ushort)((ushort)60U)));
                        if (temp103)
                        {
                            yield return (Int32)((s)._0);
                            s._0 = ((uint)((uint)0U));
                            goto M49;
                        }
                        else
                        {
                            var temp104 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._0))));
                            var temp105 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                            var temp106 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp104))) + ((uint)(temp105))));
                            s._0 = ((uint)(temp106));
                            goto M45;
                        }
                    }
                }

                M46:
                {
                    if (!ie.MoveNext())
                        goto F46;
                    i = ie.Current;
                    {
                        var temp107 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp107)
                        {
                            s._0 = ((uint)((uint)0U));
                            goto M45;
                        }
                        else
                        {
                            var temp108 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp108)
                            {
                                goto M48;
                            }
                            else
                            {
                                goto M46;
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
                            goto M30;
                        }
                        else
                            throw new Exception();
                    }
                }

                M48:
                {
                    if (!ie.MoveNext())
                        goto F48;
                    i = ie.Current;
                    {
                        var temp110 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp110)
                        {
                            goto M30;
                        }
                        else
                        {
                            var temp111 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                            if (temp111)
                            {
                                goto M48;
                            }
                            else
                            {
                                goto M46;
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
                        var temp112 = (((ushort)(i)) == ((ushort)((ushort)47U)));
                        if (temp112)
                        {
                            goto M50;
                        }
                        else
                            throw new Exception();
                    }
                }

                M50:
                {
                    if (!ie.MoveNext())
                        goto F50;
                    i = ie.Current;
                    {
                        var temp113 = (((ushort)(i)) == ((ushort)((ushort)62U)));
                        if (temp113)
                        {
                            goto M30;
                        }
                        else
                        {
                            goto M50;
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
            }
        }
    }
}