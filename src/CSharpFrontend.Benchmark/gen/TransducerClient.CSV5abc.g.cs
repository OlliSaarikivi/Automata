using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class CSV5abc : Composition<CSV5ab, Int32ToBytes>
    {
        static UInt16 Fun0(UInt16 v0, UInt16 v1)
        {
            return (UInt16)(((ushort)((ushort)(((ushort)((ushort)(v0))) & 1023L)) << 6) | (ushort)((byte)(((byte)((ushort)(v1))) & 63L)));
        }

        static UInt32 Fun1(UInt32 v0, UInt32 v1)
        {
            return (UInt32)(((((int)((uint)(v0)) <= (int)((uint)(v1)))) ? ((uint)(v1)) : ((uint)(v0))));
        }

        struct DTStruct0
        {
            public UInt16 _0;
            public UInt32 _1;
            public UInt32 _2;
            public DTStruct0(UInt16 v0, UInt32 v1, UInt32 v2)
            {
                _0 = v0;
                _1 = v1;
                _2 = v2;
            }
        }

        public static IEnumerable<Byte> Transduce(IEnumerable<Byte> input)
        {
            unchecked
            {
                IEnumerator<Byte> ie = input.GetEnumerator();
                DTStruct0 s = new DTStruct0(((ushort)((ushort)0U)), ((uint)((uint)0U)), ((uint)((uint)4294967295U)));
                Byte i;
                M0:
                {
                    if (!ie.MoveNext())
                        goto F0;
                    i = ie.Current;
                    {
                        var temp3 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp4 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp3)));
                        var temp5 = ((int)((uint)(temp3)) <= (int)((uint)((uint)127U)));
                        var temp6 = ((temp4) && (temp5));
                        if (temp6)
                        {
                            var temp7 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp7)
                            {
                                goto M1;
                            }
                            else
                            {
                                goto M0;
                            }
                        }
                        else
                        {
                            var temp8 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp3)));
                            var temp9 = ((int)((uint)(temp3)) <= (int)((uint)((uint)223U)));
                            var temp10 = ((temp8) && (temp9));
                            if (temp10)
                            {
                                var temp11 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp11));
                                goto M2;
                            }
                            else
                            {
                                var temp12 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp12)
                                {
                                    var temp13 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp13));
                                    goto M3;
                                }
                                else
                                {
                                    var temp14 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp14)
                                    {
                                        var temp15 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp15));
                                        goto M4;
                                    }
                                    else
                                    {
                                        var temp16 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp3)));
                                        var temp17 = ((int)((uint)(temp3)) <= (int)((uint)((uint)239U)));
                                        var temp18 = ((temp16) && (temp17));
                                        if (temp18)
                                        {
                                            var temp19 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp19));
                                            goto M5;
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
                        var temp20 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp21 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp20)));
                        var temp22 = ((int)((uint)(temp20)) <= (int)((uint)((uint)127U)));
                        var temp23 = ((temp21) && (temp22));
                        if (temp23)
                        {
                            var temp24 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp24)
                            {
                                goto M6;
                            }
                            else
                            {
                                goto M1;
                            }
                        }
                        else
                        {
                            var temp25 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp20)));
                            var temp26 = ((int)((uint)(temp20)) <= (int)((uint)((uint)223U)));
                            var temp27 = ((temp25) && (temp26));
                            if (temp27)
                            {
                                var temp28 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp28));
                                goto M7;
                            }
                            else
                            {
                                var temp29 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp29)
                                {
                                    var temp30 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp30));
                                    goto M8;
                                }
                                else
                                {
                                    var temp31 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp31)
                                    {
                                        var temp32 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp32));
                                        goto M9;
                                    }
                                    else
                                    {
                                        var temp33 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp20)));
                                        var temp34 = ((int)((uint)(temp20)) <= (int)((uint)((uint)239U)));
                                        var temp35 = ((temp33) && (temp34));
                                        if (temp35)
                                        {
                                            var temp36 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp36));
                                            goto M10;
                                        }
                                        else
                                            throw new Exception();
                                    }
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
                        var temp40 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp41 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp40)));
                        var temp42 = ((int)((uint)(temp40)) <= (int)((uint)((uint)191U)));
                        var temp43 = ((temp41) && (temp42));
                        if (temp43)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M0;
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
                        var temp47 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp48 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp47)));
                        var temp49 = ((int)((uint)(temp47)) <= (int)((uint)((uint)191U)));
                        var temp50 = ((temp48) && (temp49));
                        if (temp50)
                        {
                            var temp51 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp52 = Fun0(((ushort)((s)._0)), ((ushort)(temp51)));
                            s._0 = ((ushort)(temp52));
                            goto M2;
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
                        var temp56 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp57 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp56)));
                        var temp58 = ((int)((uint)(temp56)) <= (int)((uint)((uint)159U)));
                        var temp59 = ((temp57) && (temp58));
                        if (temp59)
                        {
                            var temp60 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp61 = Fun0(((ushort)((s)._0)), ((ushort)(temp60)));
                            s._0 = ((ushort)(temp61));
                            goto M2;
                        }
                        else
                            throw new Exception();
                    }
                }

                M5:
                {
                    if (!ie.MoveNext())
                        goto F5;
                    i = ie.Current;
                    {
                        var temp65 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp66 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp65)));
                        var temp67 = ((int)((uint)(temp65)) <= (int)((uint)((uint)191U)));
                        var temp68 = ((temp66) && (temp67));
                        if (temp68)
                        {
                            var temp69 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp70 = Fun0(((ushort)((s)._0)), ((ushort)(temp69)));
                            s._0 = ((ushort)(temp70));
                            goto M2;
                        }
                        else
                            throw new Exception();
                    }
                }

                M6:
                {
                    if (!ie.MoveNext())
                        goto F6;
                    i = ie.Current;
                    {
                        var temp71 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp72 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp71)));
                        var temp73 = ((int)((uint)(temp71)) <= (int)((uint)((uint)127U)));
                        var temp74 = ((temp72) && (temp73));
                        if (temp74)
                        {
                            var temp75 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp75)
                            {
                                goto M11;
                            }
                            else
                            {
                                goto M6;
                            }
                        }
                        else
                        {
                            var temp76 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp71)));
                            var temp77 = ((int)((uint)(temp71)) <= (int)((uint)((uint)223U)));
                            var temp78 = ((temp76) && (temp77));
                            if (temp78)
                            {
                                var temp79 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp79));
                                goto M12;
                            }
                            else
                            {
                                var temp80 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp80)
                                {
                                    var temp81 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp81));
                                    goto M13;
                                }
                                else
                                {
                                    var temp82 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp82)
                                    {
                                        var temp83 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp83));
                                        goto M14;
                                    }
                                    else
                                    {
                                        var temp84 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp71)));
                                        var temp85 = ((int)((uint)(temp71)) <= (int)((uint)((uint)239U)));
                                        var temp86 = ((temp84) && (temp85));
                                        if (temp86)
                                        {
                                            var temp87 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp87));
                                            goto M15;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
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
                        var temp88 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp89 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp88)));
                        var temp90 = ((int)((uint)(temp88)) <= (int)((uint)((uint)191U)));
                        var temp91 = ((temp89) && (temp90));
                        if (temp91)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M1;
                        }
                        else
                            throw new Exception();
                    }
                }

                M8:
                {
                    if (!ie.MoveNext())
                        goto F8;
                    i = ie.Current;
                    {
                        var temp92 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp93 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp92)));
                        var temp94 = ((int)((uint)(temp92)) <= (int)((uint)((uint)191U)));
                        var temp95 = ((temp93) && (temp94));
                        if (temp95)
                        {
                            var temp96 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp97 = Fun0(((ushort)((s)._0)), ((ushort)(temp96)));
                            s._0 = ((ushort)(temp97));
                            goto M7;
                        }
                        else
                            throw new Exception();
                    }
                }

                M9:
                {
                    if (!ie.MoveNext())
                        goto F9;
                    i = ie.Current;
                    {
                        var temp98 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp99 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp98)));
                        var temp100 = ((int)((uint)(temp98)) <= (int)((uint)((uint)159U)));
                        var temp101 = ((temp99) && (temp100));
                        if (temp101)
                        {
                            var temp102 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp103 = Fun0(((ushort)((s)._0)), ((ushort)(temp102)));
                            s._0 = ((ushort)(temp103));
                            goto M7;
                        }
                        else
                            throw new Exception();
                    }
                }

                M10:
                {
                    if (!ie.MoveNext())
                        goto F10;
                    i = ie.Current;
                    {
                        var temp104 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp105 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp104)));
                        var temp106 = ((int)((uint)(temp104)) <= (int)((uint)((uint)191U)));
                        var temp107 = ((temp105) && (temp106));
                        if (temp107)
                        {
                            var temp108 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp109 = Fun0(((ushort)((s)._0)), ((ushort)(temp108)));
                            s._0 = ((ushort)(temp109));
                            goto M7;
                        }
                        else
                            throw new Exception();
                    }
                }

                M11:
                {
                    if (!ie.MoveNext())
                        goto F11;
                    i = ie.Current;
                    {
                        var temp110 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp111 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp110)));
                        var temp112 = ((int)((uint)(temp110)) <= (int)((uint)((uint)127U)));
                        var temp113 = ((temp111) && (temp112));
                        if (temp113)
                        {
                            var temp114 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp114)
                            {
                                goto M16;
                            }
                            else
                            {
                                goto M11;
                            }
                        }
                        else
                        {
                            var temp115 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp110)));
                            var temp116 = ((int)((uint)(temp110)) <= (int)((uint)((uint)223U)));
                            var temp117 = ((temp115) && (temp116));
                            if (temp117)
                            {
                                var temp118 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp118));
                                goto M17;
                            }
                            else
                            {
                                var temp119 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp119)
                                {
                                    var temp120 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp120));
                                    goto M18;
                                }
                                else
                                {
                                    var temp121 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp121)
                                    {
                                        var temp122 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp122));
                                        goto M19;
                                    }
                                    else
                                    {
                                        var temp123 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp110)));
                                        var temp124 = ((int)((uint)(temp110)) <= (int)((uint)((uint)239U)));
                                        var temp125 = ((temp123) && (temp124));
                                        if (temp125)
                                        {
                                            var temp126 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp126));
                                            goto M20;
                                        }
                                        else
                                            throw new Exception();
                                    }
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
                        var temp127 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp128 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp127)));
                        var temp129 = ((int)((uint)(temp127)) <= (int)((uint)((uint)191U)));
                        var temp130 = ((temp128) && (temp129));
                        if (temp130)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M6;
                        }
                        else
                            throw new Exception();
                    }
                }

                M13:
                {
                    if (!ie.MoveNext())
                        goto F13;
                    i = ie.Current;
                    {
                        var temp131 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp132 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp131)));
                        var temp133 = ((int)((uint)(temp131)) <= (int)((uint)((uint)191U)));
                        var temp134 = ((temp132) && (temp133));
                        if (temp134)
                        {
                            var temp135 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp136 = Fun0(((ushort)((s)._0)), ((ushort)(temp135)));
                            s._0 = ((ushort)(temp136));
                            goto M12;
                        }
                        else
                            throw new Exception();
                    }
                }

                M14:
                {
                    if (!ie.MoveNext())
                        goto F14;
                    i = ie.Current;
                    {
                        var temp137 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp138 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp137)));
                        var temp139 = ((int)((uint)(temp137)) <= (int)((uint)((uint)159U)));
                        var temp140 = ((temp138) && (temp139));
                        if (temp140)
                        {
                            var temp141 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp142 = Fun0(((ushort)((s)._0)), ((ushort)(temp141)));
                            s._0 = ((ushort)(temp142));
                            goto M12;
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
                        var temp143 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp144 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp143)));
                        var temp145 = ((int)((uint)(temp143)) <= (int)((uint)((uint)191U)));
                        var temp146 = ((temp144) && (temp145));
                        if (temp146)
                        {
                            var temp147 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp148 = Fun0(((ushort)((s)._0)), ((ushort)(temp147)));
                            s._0 = ((ushort)(temp148));
                            goto M12;
                        }
                        else
                            throw new Exception();
                    }
                }

                M16:
                {
                    if (!ie.MoveNext())
                        goto F16;
                    i = ie.Current;
                    {
                        var temp149 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp150 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp149)));
                        var temp151 = ((int)((uint)(temp149)) <= (int)((uint)((uint)127U)));
                        var temp152 = ((temp150) && (temp151));
                        if (temp152)
                        {
                            var temp153 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp153)
                            {
                                goto M21;
                            }
                            else
                            {
                                goto M16;
                            }
                        }
                        else
                        {
                            var temp154 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp149)));
                            var temp155 = ((int)((uint)(temp149)) <= (int)((uint)((uint)223U)));
                            var temp156 = ((temp154) && (temp155));
                            if (temp156)
                            {
                                var temp157 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp157));
                                goto M22;
                            }
                            else
                            {
                                var temp158 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp158)
                                {
                                    var temp159 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp159));
                                    goto M23;
                                }
                                else
                                {
                                    var temp160 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp160)
                                    {
                                        var temp161 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp161));
                                        goto M24;
                                    }
                                    else
                                    {
                                        var temp162 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp149)));
                                        var temp163 = ((int)((uint)(temp149)) <= (int)((uint)((uint)239U)));
                                        var temp164 = ((temp162) && (temp163));
                                        if (temp164)
                                        {
                                            var temp165 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp165));
                                            goto M25;
                                        }
                                        else
                                            throw new Exception();
                                    }
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
                        var temp166 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp167 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp166)));
                        var temp168 = ((int)((uint)(temp166)) <= (int)((uint)((uint)191U)));
                        var temp169 = ((temp167) && (temp168));
                        if (temp169)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M11;
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
                        var temp170 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp171 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp170)));
                        var temp172 = ((int)((uint)(temp170)) <= (int)((uint)((uint)191U)));
                        var temp173 = ((temp171) && (temp172));
                        if (temp173)
                        {
                            var temp174 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp175 = Fun0(((ushort)((s)._0)), ((ushort)(temp174)));
                            s._0 = ((ushort)(temp175));
                            goto M17;
                        }
                        else
                            throw new Exception();
                    }
                }

                M19:
                {
                    if (!ie.MoveNext())
                        goto F19;
                    i = ie.Current;
                    {
                        var temp176 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp177 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp176)));
                        var temp178 = ((int)((uint)(temp176)) <= (int)((uint)((uint)159U)));
                        var temp179 = ((temp177) && (temp178));
                        if (temp179)
                        {
                            var temp180 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp181 = Fun0(((ushort)((s)._0)), ((ushort)(temp180)));
                            s._0 = ((ushort)(temp181));
                            goto M17;
                        }
                        else
                            throw new Exception();
                    }
                }

                M20:
                {
                    if (!ie.MoveNext())
                        goto F20;
                    i = ie.Current;
                    {
                        var temp182 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp183 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp182)));
                        var temp184 = ((int)((uint)(temp182)) <= (int)((uint)((uint)191U)));
                        var temp185 = ((temp183) && (temp184));
                        if (temp185)
                        {
                            var temp186 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp187 = Fun0(((ushort)((s)._0)), ((ushort)(temp186)));
                            s._0 = ((ushort)(temp187));
                            goto M17;
                        }
                        else
                            throw new Exception();
                    }
                }

                M21:
                {
                    if (!ie.MoveNext())
                        goto F21;
                    i = ie.Current;
                    {
                        var temp188 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp189 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp188)));
                        var temp190 = ((int)((uint)(temp188)) <= (int)((uint)((uint)127U)));
                        var temp191 = ((temp189) && (temp190));
                        if (temp191)
                        {
                            var temp192 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp193 = ((byte)(((byte)(i)) >> 6));
                            var temp194 = (((byte)(temp193 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp195 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp196 = (((temp192) && (temp194)) && (temp195));
                            if (temp196)
                            {
                                var temp197 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp198 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp197))) + ((uint)(temp188))));
                                s._1 = ((uint)(temp198));
                                goto M26;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp199 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp188)));
                            var temp200 = ((int)((uint)(temp188)) <= (int)((uint)((uint)223U)));
                            var temp201 = ((temp199) && (temp200));
                            if (temp201)
                            {
                                var temp202 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp202));
                                goto M27;
                            }
                            else
                            {
                                var temp203 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp203)
                                {
                                    var temp204 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp204));
                                    goto M28;
                                }
                                else
                                {
                                    var temp205 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp205)
                                    {
                                        var temp206 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp206));
                                        goto M29;
                                    }
                                    else
                                    {
                                        var temp207 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp188)));
                                        var temp208 = ((int)((uint)(temp188)) <= (int)((uint)((uint)239U)));
                                        var temp209 = ((temp207) && (temp208));
                                        if (temp209)
                                        {
                                            var temp210 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp210));
                                            goto M30;
                                        }
                                        else
                                            throw new Exception();
                                    }
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
                        var temp211 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp212 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp211)));
                        var temp213 = ((int)((uint)(temp211)) <= (int)((uint)((uint)191U)));
                        var temp214 = ((temp212) && (temp213));
                        if (temp214)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M16;
                        }
                        else
                            throw new Exception();
                    }
                }

                M23:
                {
                    if (!ie.MoveNext())
                        goto F23;
                    i = ie.Current;
                    {
                        var temp215 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp216 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp215)));
                        var temp217 = ((int)((uint)(temp215)) <= (int)((uint)((uint)191U)));
                        var temp218 = ((temp216) && (temp217));
                        if (temp218)
                        {
                            var temp219 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp220 = Fun0(((ushort)((s)._0)), ((ushort)(temp219)));
                            s._0 = ((ushort)(temp220));
                            goto M22;
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
                        var temp221 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp222 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp221)));
                        var temp223 = ((int)((uint)(temp221)) <= (int)((uint)((uint)159U)));
                        var temp224 = ((temp222) && (temp223));
                        if (temp224)
                        {
                            var temp225 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp226 = Fun0(((ushort)((s)._0)), ((ushort)(temp225)));
                            s._0 = ((ushort)(temp226));
                            goto M22;
                        }
                        else
                            throw new Exception();
                    }
                }

                M25:
                {
                    if (!ie.MoveNext())
                        goto F25;
                    i = ie.Current;
                    {
                        var temp227 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp228 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp227)));
                        var temp229 = ((int)((uint)(temp227)) <= (int)((uint)((uint)191U)));
                        var temp230 = ((temp228) && (temp229));
                        if (temp230)
                        {
                            var temp231 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp232 = Fun0(((ushort)((s)._0)), ((ushort)(temp231)));
                            s._0 = ((ushort)(temp232));
                            goto M22;
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
                        var temp233 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp234 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp233)));
                        var temp235 = ((int)((uint)(temp233)) <= (int)((uint)((uint)127U)));
                        var temp236 = ((temp234) && (temp235));
                        if (temp236)
                        {
                            var temp237 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp237)
                            {
                                goto M31;
                            }
                            else
                            {
                                var temp238 = (((byte)((byte)48U)) <= ((byte)(i)));
                                var temp239 = ((byte)(((byte)(i)) >> 6));
                                var temp240 = (((byte)(temp239 & 3L)) == ((byte)((byte)0U & 3L)));
                                var temp241 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp242 = (((temp238) && (temp240)) && (temp241));
                                if (temp242)
                                {
                                    var temp243 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                    var temp244 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp243))) + ((uint)(temp233))));
                                    s._1 = ((uint)(temp244));
                                    goto M26;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                        else
                        {
                            var temp245 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp233)));
                            var temp246 = ((int)((uint)(temp233)) <= (int)((uint)((uint)223U)));
                            var temp247 = ((temp245) && (temp246));
                            if (temp247)
                            {
                                var temp248 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp248));
                                goto M32;
                            }
                            else
                            {
                                var temp249 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp249)
                                {
                                    var temp250 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp250));
                                    goto M33;
                                }
                                else
                                {
                                    var temp251 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp251)
                                    {
                                        var temp252 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp252));
                                        goto M34;
                                    }
                                    else
                                    {
                                        var temp253 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp233)));
                                        var temp254 = ((int)((uint)(temp233)) <= (int)((uint)((uint)239U)));
                                        var temp255 = ((temp253) && (temp254));
                                        if (temp255)
                                        {
                                            var temp256 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp256));
                                            goto M35;
                                        }
                                        else
                                            throw new Exception();
                                    }
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
                        var temp257 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp258 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp257)));
                        var temp259 = ((int)((uint)(temp257)) <= (int)((uint)((uint)191U)));
                        var temp260 = ((temp258) && (temp259));
                        if (temp260)
                        {
                            var temp261 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp262 = Fun0(((ushort)((s)._0)), ((ushort)(temp261)));
                            var temp263 = (((ushort)((ushort)48U)) <= ((ushort)(temp262)));
                            var temp264 = ((ushort)(((ushort)(temp262)) >> 6));
                            var temp265 = (((ushort)(temp264 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp266 = (((byte)(((byte)((ushort)(temp262))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp267 = (((temp263) && (temp265)) && (temp266));
                            var temp268 = (((ushort)((ushort)1632U)) <= ((ushort)(temp262)));
                            var temp269 = ((byte)(((ushort)(temp262)) >> 11));
                            var temp270 = (((byte)(temp269 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp271 = (((ushort)(((ushort)((ushort)(temp262))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp272 = (((temp268) && (temp270)) && (temp271));
                            var temp273 = (((ushort)((ushort)1776U)) <= ((ushort)(temp262)));
                            var temp274 = (((ushort)(((ushort)((ushort)(temp262))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp275 = (((temp273) && (temp270)) && (temp274));
                            var temp276 = (((ushort)((ushort)1984U)) <= ((ushort)(temp262)));
                            var temp277 = (((ushort)(((ushort)((ushort)(temp262))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp278 = (((temp276) && (temp270)) && (temp277));
                            var temp279 = (((ushort)((ushort)2406U)) <= ((ushort)(temp262)));
                            var temp280 = ((byte)(((ushort)(temp262)) >> 12));
                            var temp281 = (((byte)(temp280 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp282 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp283 = (((temp279) && (temp281)) && (temp282));
                            var temp284 = (((ushort)((ushort)2534U)) <= ((ushort)(temp262)));
                            var temp285 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp286 = (((temp284) && (temp281)) && (temp285));
                            var temp287 = (((ushort)((ushort)2662U)) <= ((ushort)(temp262)));
                            var temp288 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp289 = (((temp287) && (temp281)) && (temp288));
                            var temp290 = (((ushort)((ushort)2790U)) <= ((ushort)(temp262)));
                            var temp291 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp292 = (((temp290) && (temp281)) && (temp291));
                            var temp293 = (((ushort)((ushort)2918U)) <= ((ushort)(temp262)));
                            var temp294 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp295 = (((temp293) && (temp281)) && (temp294));
                            var temp296 = (((ushort)((ushort)3046U)) <= ((ushort)(temp262)));
                            var temp297 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp298 = (((temp296) && (temp281)) && (temp297));
                            var temp299 = (((ushort)((ushort)3174U)) <= ((ushort)(temp262)));
                            var temp300 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp301 = (((temp299) && (temp281)) && (temp300));
                            var temp302 = (((ushort)((ushort)3302U)) <= ((ushort)(temp262)));
                            var temp303 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp304 = (((temp302) && (temp281)) && (temp303));
                            var temp305 = (((ushort)((ushort)3430U)) <= ((ushort)(temp262)));
                            var temp306 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp307 = (((temp305) && (temp281)) && (temp306));
                            var temp308 = (((ushort)((ushort)3664U)) <= ((ushort)(temp262)));
                            var temp309 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp310 = (((temp308) && (temp281)) && (temp309));
                            var temp311 = (((ushort)((ushort)3792U)) <= ((ushort)(temp262)));
                            var temp312 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp313 = (((temp311) && (temp281)) && (temp312));
                            var temp314 = (((ushort)((ushort)3872U)) <= ((ushort)(temp262)));
                            var temp315 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp316 = (((temp314) && (temp281)) && (temp315));
                            var temp317 = (((ushort)((ushort)4160U)) <= ((ushort)(temp262)));
                            var temp318 = ((byte)(((ushort)(temp262)) >> 13));
                            var temp319 = (((byte)(temp318 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp320 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp321 = (((temp317) && (temp319)) && (temp320));
                            var temp322 = (((ushort)((ushort)4240U)) <= ((ushort)(temp262)));
                            var temp323 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp324 = (((temp322) && (temp319)) && (temp323));
                            var temp325 = (((ushort)((ushort)6112U)) <= ((ushort)(temp262)));
                            var temp326 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp327 = (((temp325) && (temp319)) && (temp326));
                            var temp328 = (((ushort)((ushort)6160U)) <= ((ushort)(temp262)));
                            var temp329 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp330 = (((temp328) && (temp319)) && (temp329));
                            var temp331 = (((ushort)((ushort)6470U)) <= ((ushort)(temp262)));
                            var temp332 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp333 = (((temp331) && (temp319)) && (temp332));
                            var temp334 = (((ushort)((ushort)6608U)) <= ((ushort)(temp262)));
                            var temp335 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp336 = (((temp334) && (temp319)) && (temp335));
                            var temp337 = (((ushort)((ushort)6992U)) <= ((ushort)(temp262)));
                            var temp338 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp339 = (((temp337) && (temp319)) && (temp338));
                            var temp340 = (((ushort)((ushort)7088U)) <= ((ushort)(temp262)));
                            var temp341 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp342 = (((temp340) && (temp319)) && (temp341));
                            var temp343 = (((ushort)((ushort)7232U)) <= ((ushort)(temp262)));
                            var temp344 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp345 = (((temp343) && (temp319)) && (temp344));
                            var temp346 = (((ushort)((ushort)7248U)) <= ((ushort)(temp262)));
                            var temp347 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp348 = (((temp346) && (temp319)) && (temp347));
                            var temp349 = (((ushort)((ushort)42528U)) <= ((ushort)(temp262)));
                            var temp350 = (((ushort)(temp262)) <= ((ushort)((ushort)42537U)));
                            var temp351 = ((temp349) && (temp350));
                            var temp352 = (((ushort)((ushort)43216U)) <= ((ushort)(temp262)));
                            var temp353 = (((ushort)(temp262)) <= ((ushort)((ushort)43225U)));
                            var temp354 = ((temp352) && (temp353));
                            var temp355 = (((ushort)((ushort)43264U)) <= ((ushort)(temp262)));
                            var temp356 = (((ushort)(temp262)) <= ((ushort)((ushort)43273U)));
                            var temp357 = ((temp355) && (temp356));
                            var temp358 = (((ushort)((ushort)43600U)) <= ((ushort)(temp262)));
                            var temp359 = (((ushort)(temp262)) <= ((ushort)((ushort)43609U)));
                            var temp360 = ((temp358) && (temp359));
                            var temp361 = (((ushort)((ushort)65296U)) <= ((ushort)(temp262)));
                            var temp362 = (((ushort)(temp262)) <= ((ushort)((ushort)65305U)));
                            var temp363 = ((temp361) && (temp362));
                            var temp364 = (((((((((((((((((((((((((((((((temp267) || (temp272)) || (temp275)) || (temp278)) || (temp283)) || (temp286)) || (temp289)) || (temp292)) || (temp295)) || (temp298)) || (temp301)) || (temp304)) || (temp307)) || (temp310)) || (temp313)) || (temp316)) || (temp321)) || (temp324)) || (temp327)) || (temp330)) || (temp333)) || (temp336)) || (temp339)) || (temp342)) || (temp345)) || (temp348)) || (temp351)) || (temp354)) || (temp357)) || (temp360)) || (temp363));
                            if (temp364)
                            {
                                var temp365 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp366 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp262));
                                var temp367 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp365))) + ((uint)(temp366))));
                                s._1 = ((uint)(temp367));
                                s._0 = ((ushort)((ushort)0U));
                                goto M26;
                            }
                            else
                                throw new Exception();
                        }
                        else
                            throw new Exception();
                    }
                }

                M28:
                {
                    if (!ie.MoveNext())
                        goto F28;
                    i = ie.Current;
                    {
                        var temp368 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp369 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp368)));
                        var temp370 = ((int)((uint)(temp368)) <= (int)((uint)((uint)191U)));
                        var temp371 = ((temp369) && (temp370));
                        if (temp371)
                        {
                            var temp372 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp373 = Fun0(((ushort)((s)._0)), ((ushort)(temp372)));
                            s._0 = ((ushort)(temp373));
                            goto M27;
                        }
                        else
                            throw new Exception();
                    }
                }

                M29:
                {
                    if (!ie.MoveNext())
                        goto F29;
                    i = ie.Current;
                    {
                        var temp374 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp375 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp374)));
                        var temp376 = ((int)((uint)(temp374)) <= (int)((uint)((uint)159U)));
                        var temp377 = ((temp375) && (temp376));
                        if (temp377)
                        {
                            var temp378 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp379 = Fun0(((ushort)((s)._0)), ((ushort)(temp378)));
                            s._0 = ((ushort)(temp379));
                            goto M27;
                        }
                        else
                            throw new Exception();
                    }
                }

                M30:
                {
                    if (!ie.MoveNext())
                        goto F30;
                    i = ie.Current;
                    {
                        var temp380 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp381 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp380)));
                        var temp382 = ((int)((uint)(temp380)) <= (int)((uint)((uint)191U)));
                        var temp383 = ((temp381) && (temp382));
                        if (temp383)
                        {
                            var temp384 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp385 = Fun0(((ushort)((s)._0)), ((ushort)(temp384)));
                            s._0 = ((ushort)(temp385));
                            goto M27;
                        }
                        else
                            throw new Exception();
                    }
                }

                M31:
                {
                    if (!ie.MoveNext())
                        goto F31;
                    i = ie.Current;
                    {
                        var temp386 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp387 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp386)));
                        var temp388 = ((int)((uint)(temp386)) <= (int)((uint)((uint)127U)));
                        var temp389 = ((temp387) && (temp388));
                        if (temp389)
                        {
                            var temp390 = (((byte)(i)) == ((byte)((byte)10U)));
                            if (temp390)
                            {
                                var temp391 = Fun1(((uint)((s)._1)), ((uint)((s)._2)));
                                s._2 = ((uint)(temp391));
                                s._1 = ((uint)((uint)0U));
                                goto M0;
                            }
                            else
                            {
                                goto M31;
                            }
                        }
                        else
                        {
                            var temp392 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp386)));
                            var temp393 = ((int)((uint)(temp386)) <= (int)((uint)((uint)223U)));
                            var temp394 = ((temp392) && (temp393));
                            if (temp394)
                            {
                                var temp395 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp395));
                                goto M36;
                            }
                            else
                            {
                                var temp396 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp396)
                                {
                                    var temp397 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp397));
                                    goto M37;
                                }
                                else
                                {
                                    var temp398 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp398)
                                    {
                                        var temp399 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp399));
                                        goto M38;
                                    }
                                    else
                                    {
                                        var temp400 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp386)));
                                        var temp401 = ((int)((uint)(temp386)) <= (int)((uint)((uint)239U)));
                                        var temp402 = ((temp400) && (temp401));
                                        if (temp402)
                                        {
                                            var temp403 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp403));
                                            goto M39;
                                        }
                                        else
                                            throw new Exception();
                                    }
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
                        var temp404 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp405 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp404)));
                        var temp406 = ((int)((uint)(temp404)) <= (int)((uint)((uint)191U)));
                        var temp407 = ((temp405) && (temp406));
                        if (temp407)
                        {
                            var temp408 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp409 = Fun0(((ushort)((s)._0)), ((ushort)(temp408)));
                            var temp410 = (((ushort)((ushort)48U)) <= ((ushort)(temp409)));
                            var temp411 = ((ushort)(((ushort)(temp409)) >> 6));
                            var temp412 = (((ushort)(temp411 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp413 = (((byte)(((byte)((ushort)(temp409))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp414 = (((temp410) && (temp412)) && (temp413));
                            var temp415 = (((ushort)((ushort)1632U)) <= ((ushort)(temp409)));
                            var temp416 = ((byte)(((ushort)(temp409)) >> 11));
                            var temp417 = (((byte)(temp416 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp418 = (((ushort)(((ushort)((ushort)(temp409))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp419 = (((temp415) && (temp417)) && (temp418));
                            var temp420 = (((ushort)((ushort)1776U)) <= ((ushort)(temp409)));
                            var temp421 = (((ushort)(((ushort)((ushort)(temp409))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp422 = (((temp420) && (temp417)) && (temp421));
                            var temp423 = (((ushort)((ushort)1984U)) <= ((ushort)(temp409)));
                            var temp424 = (((ushort)(((ushort)((ushort)(temp409))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp425 = (((temp423) && (temp417)) && (temp424));
                            var temp426 = (((ushort)((ushort)2406U)) <= ((ushort)(temp409)));
                            var temp427 = ((byte)(((ushort)(temp409)) >> 12));
                            var temp428 = (((byte)(temp427 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp429 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp430 = (((temp426) && (temp428)) && (temp429));
                            var temp431 = (((ushort)((ushort)2534U)) <= ((ushort)(temp409)));
                            var temp432 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp433 = (((temp431) && (temp428)) && (temp432));
                            var temp434 = (((ushort)((ushort)2662U)) <= ((ushort)(temp409)));
                            var temp435 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp436 = (((temp434) && (temp428)) && (temp435));
                            var temp437 = (((ushort)((ushort)2790U)) <= ((ushort)(temp409)));
                            var temp438 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp439 = (((temp437) && (temp428)) && (temp438));
                            var temp440 = (((ushort)((ushort)2918U)) <= ((ushort)(temp409)));
                            var temp441 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp442 = (((temp440) && (temp428)) && (temp441));
                            var temp443 = (((ushort)((ushort)3046U)) <= ((ushort)(temp409)));
                            var temp444 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp445 = (((temp443) && (temp428)) && (temp444));
                            var temp446 = (((ushort)((ushort)3174U)) <= ((ushort)(temp409)));
                            var temp447 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp448 = (((temp446) && (temp428)) && (temp447));
                            var temp449 = (((ushort)((ushort)3302U)) <= ((ushort)(temp409)));
                            var temp450 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp451 = (((temp449) && (temp428)) && (temp450));
                            var temp452 = (((ushort)((ushort)3430U)) <= ((ushort)(temp409)));
                            var temp453 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp454 = (((temp452) && (temp428)) && (temp453));
                            var temp455 = (((ushort)((ushort)3664U)) <= ((ushort)(temp409)));
                            var temp456 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp457 = (((temp455) && (temp428)) && (temp456));
                            var temp458 = (((ushort)((ushort)3792U)) <= ((ushort)(temp409)));
                            var temp459 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp460 = (((temp458) && (temp428)) && (temp459));
                            var temp461 = (((ushort)((ushort)3872U)) <= ((ushort)(temp409)));
                            var temp462 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp463 = (((temp461) && (temp428)) && (temp462));
                            var temp464 = (((ushort)((ushort)4160U)) <= ((ushort)(temp409)));
                            var temp465 = ((byte)(((ushort)(temp409)) >> 13));
                            var temp466 = (((byte)(temp465 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp467 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp468 = (((temp464) && (temp466)) && (temp467));
                            var temp469 = (((ushort)((ushort)4240U)) <= ((ushort)(temp409)));
                            var temp470 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp471 = (((temp469) && (temp466)) && (temp470));
                            var temp472 = (((ushort)((ushort)6112U)) <= ((ushort)(temp409)));
                            var temp473 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp474 = (((temp472) && (temp466)) && (temp473));
                            var temp475 = (((ushort)((ushort)6160U)) <= ((ushort)(temp409)));
                            var temp476 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp477 = (((temp475) && (temp466)) && (temp476));
                            var temp478 = (((ushort)((ushort)6470U)) <= ((ushort)(temp409)));
                            var temp479 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp480 = (((temp478) && (temp466)) && (temp479));
                            var temp481 = (((ushort)((ushort)6608U)) <= ((ushort)(temp409)));
                            var temp482 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp483 = (((temp481) && (temp466)) && (temp482));
                            var temp484 = (((ushort)((ushort)6992U)) <= ((ushort)(temp409)));
                            var temp485 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp486 = (((temp484) && (temp466)) && (temp485));
                            var temp487 = (((ushort)((ushort)7088U)) <= ((ushort)(temp409)));
                            var temp488 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp489 = (((temp487) && (temp466)) && (temp488));
                            var temp490 = (((ushort)((ushort)7232U)) <= ((ushort)(temp409)));
                            var temp491 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp492 = (((temp490) && (temp466)) && (temp491));
                            var temp493 = (((ushort)((ushort)7248U)) <= ((ushort)(temp409)));
                            var temp494 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp495 = (((temp493) && (temp466)) && (temp494));
                            var temp496 = (((ushort)((ushort)42528U)) <= ((ushort)(temp409)));
                            var temp497 = (((ushort)(temp409)) <= ((ushort)((ushort)42537U)));
                            var temp498 = ((temp496) && (temp497));
                            var temp499 = (((ushort)((ushort)43216U)) <= ((ushort)(temp409)));
                            var temp500 = (((ushort)(temp409)) <= ((ushort)((ushort)43225U)));
                            var temp501 = ((temp499) && (temp500));
                            var temp502 = (((ushort)((ushort)43264U)) <= ((ushort)(temp409)));
                            var temp503 = (((ushort)(temp409)) <= ((ushort)((ushort)43273U)));
                            var temp504 = ((temp502) && (temp503));
                            var temp505 = (((ushort)((ushort)43600U)) <= ((ushort)(temp409)));
                            var temp506 = (((ushort)(temp409)) <= ((ushort)((ushort)43609U)));
                            var temp507 = ((temp505) && (temp506));
                            var temp508 = (((ushort)((ushort)65296U)) <= ((ushort)(temp409)));
                            var temp509 = (((ushort)(temp409)) <= ((ushort)((ushort)65305U)));
                            var temp510 = ((temp508) && (temp509));
                            var temp511 = (((((((((((((((((((((((((((((((temp414) || (temp419)) || (temp422)) || (temp425)) || (temp430)) || (temp433)) || (temp436)) || (temp439)) || (temp442)) || (temp445)) || (temp448)) || (temp451)) || (temp454)) || (temp457)) || (temp460)) || (temp463)) || (temp468)) || (temp471)) || (temp474)) || (temp477)) || (temp480)) || (temp483)) || (temp486)) || (temp489)) || (temp492)) || (temp495)) || (temp498)) || (temp501)) || (temp504)) || (temp507)) || (temp510));
                            if (temp511)
                            {
                                var temp512 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp513 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp409));
                                var temp514 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp512))) + ((uint)(temp513))));
                                s._1 = ((uint)(temp514));
                                s._0 = ((ushort)((ushort)0U));
                                goto M26;
                            }
                            else
                                throw new Exception();
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
                        var temp515 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp516 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp515)));
                        var temp517 = ((int)((uint)(temp515)) <= (int)((uint)((uint)191U)));
                        var temp518 = ((temp516) && (temp517));
                        if (temp518)
                        {
                            var temp519 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp520 = Fun0(((ushort)((s)._0)), ((ushort)(temp519)));
                            s._0 = ((ushort)(temp520));
                            goto M32;
                        }
                        else
                            throw new Exception();
                    }
                }

                M34:
                {
                    if (!ie.MoveNext())
                        goto F34;
                    i = ie.Current;
                    {
                        var temp521 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp522 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp521)));
                        var temp523 = ((int)((uint)(temp521)) <= (int)((uint)((uint)159U)));
                        var temp524 = ((temp522) && (temp523));
                        if (temp524)
                        {
                            var temp525 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp526 = Fun0(((ushort)((s)._0)), ((ushort)(temp525)));
                            s._0 = ((ushort)(temp526));
                            goto M32;
                        }
                        else
                            throw new Exception();
                    }
                }

                M35:
                {
                    if (!ie.MoveNext())
                        goto F35;
                    i = ie.Current;
                    {
                        var temp527 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp528 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp527)));
                        var temp529 = ((int)((uint)(temp527)) <= (int)((uint)((uint)191U)));
                        var temp530 = ((temp528) && (temp529));
                        if (temp530)
                        {
                            var temp531 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp532 = Fun0(((ushort)((s)._0)), ((ushort)(temp531)));
                            s._0 = ((ushort)(temp532));
                            goto M32;
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
                        var temp533 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp534 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp533)));
                        var temp535 = ((int)((uint)(temp533)) <= (int)((uint)((uint)191U)));
                        var temp536 = ((temp534) && (temp535));
                        if (temp536)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M31;
                        }
                        else
                            throw new Exception();
                    }
                }

                M37:
                {
                    if (!ie.MoveNext())
                        goto F37;
                    i = ie.Current;
                    {
                        var temp537 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp538 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp537)));
                        var temp539 = ((int)((uint)(temp537)) <= (int)((uint)((uint)191U)));
                        var temp540 = ((temp538) && (temp539));
                        if (temp540)
                        {
                            var temp541 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp542 = Fun0(((ushort)((s)._0)), ((ushort)(temp541)));
                            s._0 = ((ushort)(temp542));
                            goto M36;
                        }
                        else
                            throw new Exception();
                    }
                }

                M38:
                {
                    if (!ie.MoveNext())
                        goto F38;
                    i = ie.Current;
                    {
                        var temp543 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp544 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp543)));
                        var temp545 = ((int)((uint)(temp543)) <= (int)((uint)((uint)159U)));
                        var temp546 = ((temp544) && (temp545));
                        if (temp546)
                        {
                            var temp547 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp548 = Fun0(((ushort)((s)._0)), ((ushort)(temp547)));
                            s._0 = ((ushort)(temp548));
                            goto M36;
                        }
                        else
                            throw new Exception();
                    }
                }

                M39:
                {
                    if (!ie.MoveNext())
                        goto F39;
                    i = ie.Current;
                    {
                        var temp549 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp550 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp549)));
                        var temp551 = ((int)((uint)(temp549)) <= (int)((uint)((uint)191U)));
                        var temp552 = ((temp550) && (temp551));
                        if (temp552)
                        {
                            var temp553 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp554 = Fun0(((ushort)((s)._0)), ((ushort)(temp553)));
                            s._0 = ((ushort)(temp554));
                            goto M36;
                        }
                        else
                            throw new Exception();
                    }
                }

                F0:
                {
                    var temp0 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    yield return (Byte)(((byte)((uint)(temp0))));
                    var temp1 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    yield return (Byte)(((byte)((uint)(temp1))));
                    var temp2 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    yield return (Byte)(((byte)((uint)(temp2))));
                    yield return (Byte)(((byte)((uint)((s)._2))));
                    yield break;
                }

                F1:
                    throw new Exception();
                F2:
                {
                    var temp37 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    yield return (Byte)(((byte)((uint)(temp37))));
                    var temp38 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    yield return (Byte)(((byte)((uint)(temp38))));
                    var temp39 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    yield return (Byte)(((byte)((uint)(temp39))));
                    yield return (Byte)(((byte)((uint)((s)._2))));
                    yield break;
                }

                F3:
                {
                    var temp44 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    yield return (Byte)(((byte)((uint)(temp44))));
                    var temp45 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    yield return (Byte)(((byte)((uint)(temp45))));
                    var temp46 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    yield return (Byte)(((byte)((uint)(temp46))));
                    yield return (Byte)(((byte)((uint)((s)._2))));
                    yield break;
                }

                F4:
                {
                    var temp53 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    yield return (Byte)(((byte)((uint)(temp53))));
                    var temp54 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    yield return (Byte)(((byte)((uint)(temp54))));
                    var temp55 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    yield return (Byte)(((byte)((uint)(temp55))));
                    yield return (Byte)(((byte)((uint)((s)._2))));
                    yield break;
                }

                F5:
                {
                    var temp62 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    yield return (Byte)(((byte)((uint)(temp62))));
                    var temp63 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    yield return (Byte)(((byte)((uint)(temp63))));
                    var temp64 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    yield return (Byte)(((byte)((uint)(temp64))));
                    yield return (Byte)(((byte)((uint)((s)._2))));
                    yield break;
                }

                F6:
                    throw new Exception();
                F7:
                    throw new Exception();
                F8:
                    throw new Exception();
                F9:
                    throw new Exception();
                F10:
                    throw new Exception();
                F11:
                    throw new Exception();
                F12:
                    throw new Exception();
                F13:
                    throw new Exception();
                F14:
                    throw new Exception();
                F15:
                    throw new Exception();
                F16:
                    throw new Exception();
                F17:
                    throw new Exception();
                F18:
                    throw new Exception();
                F19:
                    throw new Exception();
                F20:
                    throw new Exception();
                F21:
                    throw new Exception();
                F22:
                    throw new Exception();
                F23:
                    throw new Exception();
                F24:
                    throw new Exception();
                F25:
                    throw new Exception();
                F26:
                    throw new Exception();
                F27:
                    throw new Exception();
                F28:
                    throw new Exception();
                F29:
                    throw new Exception();
                F30:
                    throw new Exception();
                F31:
                    throw new Exception();
                F32:
                    throw new Exception();
                F33:
                    throw new Exception();
                F34:
                    throw new Exception();
                F35:
                    throw new Exception();
                F36:
                    throw new Exception();
                F37:
                    throw new Exception();
                F38:
                    throw new Exception();
                F39:
                    throw new Exception();
            }
        }

        struct DTStruct1
        {
            public UInt16 _0;
            public UInt32 _1;
            public UInt32 _2;
            public DTStruct1(UInt16 v0, UInt32 v1, UInt32 v2)
            {
                _0 = v0;
                _1 = v1;
                _2 = v2;
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
                DTStruct1 s = new DTStruct1(((ushort)((ushort)0U)), ((uint)((uint)0U)), ((uint)((uint)4294967295U)));
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
                        var temp3 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp4 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp3)));
                        var temp5 = ((int)((uint)(temp3)) <= (int)((uint)((uint)127U)));
                        var temp6 = ((temp4) && (temp5));
                        if (temp6)
                        {
                            var temp7 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp7)
                            {
                                goto M1;
                            }
                            else
                            {
                                goto M0;
                            }
                        }
                        else
                        {
                            var temp8 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp3)));
                            var temp9 = ((int)((uint)(temp3)) <= (int)((uint)((uint)223U)));
                            var temp10 = ((temp8) && (temp9));
                            if (temp10)
                            {
                                var temp11 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp11));
                                goto M2;
                            }
                            else
                            {
                                var temp12 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp12)
                                {
                                    var temp13 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp13));
                                    goto M3;
                                }
                                else
                                {
                                    var temp14 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp14)
                                    {
                                        var temp15 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp15));
                                        goto M4;
                                    }
                                    else
                                    {
                                        var temp16 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp3)));
                                        var temp17 = ((int)((uint)(temp3)) <= (int)((uint)((uint)239U)));
                                        var temp18 = ((temp16) && (temp17));
                                        if (temp18)
                                        {
                                            var temp19 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp19));
                                            goto M5;
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
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F1;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp20 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp21 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp20)));
                        var temp22 = ((int)((uint)(temp20)) <= (int)((uint)((uint)127U)));
                        var temp23 = ((temp21) && (temp22));
                        if (temp23)
                        {
                            var temp24 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp24)
                            {
                                goto M6;
                            }
                            else
                            {
                                goto M1;
                            }
                        }
                        else
                        {
                            var temp25 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp20)));
                            var temp26 = ((int)((uint)(temp20)) <= (int)((uint)((uint)223U)));
                            var temp27 = ((temp25) && (temp26));
                            if (temp27)
                            {
                                var temp28 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp28));
                                goto M7;
                            }
                            else
                            {
                                var temp29 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp29)
                                {
                                    var temp30 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp30));
                                    goto M8;
                                }
                                else
                                {
                                    var temp31 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp31)
                                    {
                                        var temp32 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp32));
                                        goto M9;
                                    }
                                    else
                                    {
                                        var temp33 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp20)));
                                        var temp34 = ((int)((uint)(temp20)) <= (int)((uint)((uint)239U)));
                                        var temp35 = ((temp33) && (temp34));
                                        if (temp35)
                                        {
                                            var temp36 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp36));
                                            goto M10;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
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
                        var temp40 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp41 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp40)));
                        var temp42 = ((int)((uint)(temp40)) <= (int)((uint)((uint)191U)));
                        var temp43 = ((temp41) && (temp42));
                        if (temp43)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M0;
                        }
                        else
                            throw new Exception();
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
                        var temp47 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp48 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp47)));
                        var temp49 = ((int)((uint)(temp47)) <= (int)((uint)((uint)191U)));
                        var temp50 = ((temp48) && (temp49));
                        if (temp50)
                        {
                            var temp51 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp52 = Fun0(((ushort)((s)._0)), ((ushort)(temp51)));
                            s._0 = ((ushort)(temp52));
                            goto M2;
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
                        var temp56 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp57 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp56)));
                        var temp58 = ((int)((uint)(temp56)) <= (int)((uint)((uint)159U)));
                        var temp59 = ((temp57) && (temp58));
                        if (temp59)
                        {
                            var temp60 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp61 = Fun0(((ushort)((s)._0)), ((ushort)(temp60)));
                            s._0 = ((ushort)(temp61));
                            goto M2;
                        }
                        else
                            throw new Exception();
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
                    {
                        var temp65 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp66 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp65)));
                        var temp67 = ((int)((uint)(temp65)) <= (int)((uint)((uint)191U)));
                        var temp68 = ((temp66) && (temp67));
                        if (temp68)
                        {
                            var temp69 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp70 = Fun0(((ushort)((s)._0)), ((ushort)(temp69)));
                            s._0 = ((ushort)(temp70));
                            goto M2;
                        }
                        else
                            throw new Exception();
                    }
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
                    {
                        var temp71 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp72 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp71)));
                        var temp73 = ((int)((uint)(temp71)) <= (int)((uint)((uint)127U)));
                        var temp74 = ((temp72) && (temp73));
                        if (temp74)
                        {
                            var temp75 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp75)
                            {
                                goto M11;
                            }
                            else
                            {
                                goto M6;
                            }
                        }
                        else
                        {
                            var temp76 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp71)));
                            var temp77 = ((int)((uint)(temp71)) <= (int)((uint)((uint)223U)));
                            var temp78 = ((temp76) && (temp77));
                            if (temp78)
                            {
                                var temp79 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp79));
                                goto M12;
                            }
                            else
                            {
                                var temp80 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp80)
                                {
                                    var temp81 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp81));
                                    goto M13;
                                }
                                else
                                {
                                    var temp82 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp82)
                                    {
                                        var temp83 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp83));
                                        goto M14;
                                    }
                                    else
                                    {
                                        var temp84 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp71)));
                                        var temp85 = ((int)((uint)(temp71)) <= (int)((uint)((uint)239U)));
                                        var temp86 = ((temp84) && (temp85));
                                        if (temp86)
                                        {
                                            var temp87 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp87));
                                            goto M15;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M7:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F7;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp88 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp89 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp88)));
                        var temp90 = ((int)((uint)(temp88)) <= (int)((uint)((uint)191U)));
                        var temp91 = ((temp89) && (temp90));
                        if (temp91)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M1;
                        }
                        else
                            throw new Exception();
                    }
                }

                M8:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F8;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp92 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp93 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp92)));
                        var temp94 = ((int)((uint)(temp92)) <= (int)((uint)((uint)191U)));
                        var temp95 = ((temp93) && (temp94));
                        if (temp95)
                        {
                            var temp96 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp97 = Fun0(((ushort)((s)._0)), ((ushort)(temp96)));
                            s._0 = ((ushort)(temp97));
                            goto M7;
                        }
                        else
                            throw new Exception();
                    }
                }

                M9:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F9;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp98 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp99 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp98)));
                        var temp100 = ((int)((uint)(temp98)) <= (int)((uint)((uint)159U)));
                        var temp101 = ((temp99) && (temp100));
                        if (temp101)
                        {
                            var temp102 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp103 = Fun0(((ushort)((s)._0)), ((ushort)(temp102)));
                            s._0 = ((ushort)(temp103));
                            goto M7;
                        }
                        else
                            throw new Exception();
                    }
                }

                M10:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F10;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp104 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp105 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp104)));
                        var temp106 = ((int)((uint)(temp104)) <= (int)((uint)((uint)191U)));
                        var temp107 = ((temp105) && (temp106));
                        if (temp107)
                        {
                            var temp108 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp109 = Fun0(((ushort)((s)._0)), ((ushort)(temp108)));
                            s._0 = ((ushort)(temp109));
                            goto M7;
                        }
                        else
                            throw new Exception();
                    }
                }

                M11:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F11;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp110 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp111 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp110)));
                        var temp112 = ((int)((uint)(temp110)) <= (int)((uint)((uint)127U)));
                        var temp113 = ((temp111) && (temp112));
                        if (temp113)
                        {
                            var temp114 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp114)
                            {
                                goto M16;
                            }
                            else
                            {
                                goto M11;
                            }
                        }
                        else
                        {
                            var temp115 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp110)));
                            var temp116 = ((int)((uint)(temp110)) <= (int)((uint)((uint)223U)));
                            var temp117 = ((temp115) && (temp116));
                            if (temp117)
                            {
                                var temp118 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp118));
                                goto M17;
                            }
                            else
                            {
                                var temp119 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp119)
                                {
                                    var temp120 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp120));
                                    goto M18;
                                }
                                else
                                {
                                    var temp121 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp121)
                                    {
                                        var temp122 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp122));
                                        goto M19;
                                    }
                                    else
                                    {
                                        var temp123 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp110)));
                                        var temp124 = ((int)((uint)(temp110)) <= (int)((uint)((uint)239U)));
                                        var temp125 = ((temp123) && (temp124));
                                        if (temp125)
                                        {
                                            var temp126 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp126));
                                            goto M20;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M12:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F12;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp127 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp128 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp127)));
                        var temp129 = ((int)((uint)(temp127)) <= (int)((uint)((uint)191U)));
                        var temp130 = ((temp128) && (temp129));
                        if (temp130)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M6;
                        }
                        else
                            throw new Exception();
                    }
                }

                M13:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F13;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp131 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp132 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp131)));
                        var temp133 = ((int)((uint)(temp131)) <= (int)((uint)((uint)191U)));
                        var temp134 = ((temp132) && (temp133));
                        if (temp134)
                        {
                            var temp135 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp136 = Fun0(((ushort)((s)._0)), ((ushort)(temp135)));
                            s._0 = ((ushort)(temp136));
                            goto M12;
                        }
                        else
                            throw new Exception();
                    }
                }

                M14:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F14;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp137 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp138 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp137)));
                        var temp139 = ((int)((uint)(temp137)) <= (int)((uint)((uint)159U)));
                        var temp140 = ((temp138) && (temp139));
                        if (temp140)
                        {
                            var temp141 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp142 = Fun0(((ushort)((s)._0)), ((ushort)(temp141)));
                            s._0 = ((ushort)(temp142));
                            goto M12;
                        }
                        else
                            throw new Exception();
                    }
                }

                M15:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F15;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp143 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp144 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp143)));
                        var temp145 = ((int)((uint)(temp143)) <= (int)((uint)((uint)191U)));
                        var temp146 = ((temp144) && (temp145));
                        if (temp146)
                        {
                            var temp147 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp148 = Fun0(((ushort)((s)._0)), ((ushort)(temp147)));
                            s._0 = ((ushort)(temp148));
                            goto M12;
                        }
                        else
                            throw new Exception();
                    }
                }

                M16:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F16;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp149 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp150 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp149)));
                        var temp151 = ((int)((uint)(temp149)) <= (int)((uint)((uint)127U)));
                        var temp152 = ((temp150) && (temp151));
                        if (temp152)
                        {
                            var temp153 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp153)
                            {
                                goto M21;
                            }
                            else
                            {
                                goto M16;
                            }
                        }
                        else
                        {
                            var temp154 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp149)));
                            var temp155 = ((int)((uint)(temp149)) <= (int)((uint)((uint)223U)));
                            var temp156 = ((temp154) && (temp155));
                            if (temp156)
                            {
                                var temp157 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp157));
                                goto M22;
                            }
                            else
                            {
                                var temp158 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp158)
                                {
                                    var temp159 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp159));
                                    goto M23;
                                }
                                else
                                {
                                    var temp160 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp160)
                                    {
                                        var temp161 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp161));
                                        goto M24;
                                    }
                                    else
                                    {
                                        var temp162 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp149)));
                                        var temp163 = ((int)((uint)(temp149)) <= (int)((uint)((uint)239U)));
                                        var temp164 = ((temp162) && (temp163));
                                        if (temp164)
                                        {
                                            var temp165 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp165));
                                            goto M25;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M17:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F17;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp166 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp167 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp166)));
                        var temp168 = ((int)((uint)(temp166)) <= (int)((uint)((uint)191U)));
                        var temp169 = ((temp167) && (temp168));
                        if (temp169)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M11;
                        }
                        else
                            throw new Exception();
                    }
                }

                M18:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F18;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp170 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp171 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp170)));
                        var temp172 = ((int)((uint)(temp170)) <= (int)((uint)((uint)191U)));
                        var temp173 = ((temp171) && (temp172));
                        if (temp173)
                        {
                            var temp174 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp175 = Fun0(((ushort)((s)._0)), ((ushort)(temp174)));
                            s._0 = ((ushort)(temp175));
                            goto M17;
                        }
                        else
                            throw new Exception();
                    }
                }

                M19:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F19;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp176 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp177 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp176)));
                        var temp178 = ((int)((uint)(temp176)) <= (int)((uint)((uint)159U)));
                        var temp179 = ((temp177) && (temp178));
                        if (temp179)
                        {
                            var temp180 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp181 = Fun0(((ushort)((s)._0)), ((ushort)(temp180)));
                            s._0 = ((ushort)(temp181));
                            goto M17;
                        }
                        else
                            throw new Exception();
                    }
                }

                M20:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F20;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp182 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp183 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp182)));
                        var temp184 = ((int)((uint)(temp182)) <= (int)((uint)((uint)191U)));
                        var temp185 = ((temp183) && (temp184));
                        if (temp185)
                        {
                            var temp186 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp187 = Fun0(((ushort)((s)._0)), ((ushort)(temp186)));
                            s._0 = ((ushort)(temp187));
                            goto M17;
                        }
                        else
                            throw new Exception();
                    }
                }

                M21:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F21;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp188 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp189 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp188)));
                        var temp190 = ((int)((uint)(temp188)) <= (int)((uint)((uint)127U)));
                        var temp191 = ((temp189) && (temp190));
                        if (temp191)
                        {
                            var temp192 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp193 = ((byte)(((byte)(i)) >> 6));
                            var temp194 = (((byte)(temp193 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp195 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp196 = (((temp192) && (temp194)) && (temp195));
                            if (temp196)
                            {
                                var temp197 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp198 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp197))) + ((uint)(temp188))));
                                s._1 = ((uint)(temp198));
                                goto M26;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp199 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp188)));
                            var temp200 = ((int)((uint)(temp188)) <= (int)((uint)((uint)223U)));
                            var temp201 = ((temp199) && (temp200));
                            if (temp201)
                            {
                                var temp202 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp202));
                                goto M27;
                            }
                            else
                            {
                                var temp203 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp203)
                                {
                                    var temp204 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp204));
                                    goto M28;
                                }
                                else
                                {
                                    var temp205 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp205)
                                    {
                                        var temp206 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp206));
                                        goto M29;
                                    }
                                    else
                                    {
                                        var temp207 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp188)));
                                        var temp208 = ((int)((uint)(temp188)) <= (int)((uint)((uint)239U)));
                                        var temp209 = ((temp207) && (temp208));
                                        if (temp209)
                                        {
                                            var temp210 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp210));
                                            goto M30;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M22:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F22;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp211 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp212 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp211)));
                        var temp213 = ((int)((uint)(temp211)) <= (int)((uint)((uint)191U)));
                        var temp214 = ((temp212) && (temp213));
                        if (temp214)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M16;
                        }
                        else
                            throw new Exception();
                    }
                }

                M23:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F23;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp215 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp216 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp215)));
                        var temp217 = ((int)((uint)(temp215)) <= (int)((uint)((uint)191U)));
                        var temp218 = ((temp216) && (temp217));
                        if (temp218)
                        {
                            var temp219 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp220 = Fun0(((ushort)((s)._0)), ((ushort)(temp219)));
                            s._0 = ((ushort)(temp220));
                            goto M22;
                        }
                        else
                            throw new Exception();
                    }
                }

                M24:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F24;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp221 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp222 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp221)));
                        var temp223 = ((int)((uint)(temp221)) <= (int)((uint)((uint)159U)));
                        var temp224 = ((temp222) && (temp223));
                        if (temp224)
                        {
                            var temp225 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp226 = Fun0(((ushort)((s)._0)), ((ushort)(temp225)));
                            s._0 = ((ushort)(temp226));
                            goto M22;
                        }
                        else
                            throw new Exception();
                    }
                }

                M25:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F25;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp227 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp228 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp227)));
                        var temp229 = ((int)((uint)(temp227)) <= (int)((uint)((uint)191U)));
                        var temp230 = ((temp228) && (temp229));
                        if (temp230)
                        {
                            var temp231 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp232 = Fun0(((ushort)((s)._0)), ((ushort)(temp231)));
                            s._0 = ((ushort)(temp232));
                            goto M22;
                        }
                        else
                            throw new Exception();
                    }
                }

                M26:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F26;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp233 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp234 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp233)));
                        var temp235 = ((int)((uint)(temp233)) <= (int)((uint)((uint)127U)));
                        var temp236 = ((temp234) && (temp235));
                        if (temp236)
                        {
                            var temp237 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp237)
                            {
                                goto M31;
                            }
                            else
                            {
                                var temp238 = (((byte)((byte)48U)) <= ((byte)(i)));
                                var temp239 = ((byte)(((byte)(i)) >> 6));
                                var temp240 = (((byte)(temp239 & 3L)) == ((byte)((byte)0U & 3L)));
                                var temp241 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp242 = (((temp238) && (temp240)) && (temp241));
                                if (temp242)
                                {
                                    var temp243 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                    var temp244 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp243))) + ((uint)(temp233))));
                                    s._1 = ((uint)(temp244));
                                    goto M26;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                        else
                        {
                            var temp245 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp233)));
                            var temp246 = ((int)((uint)(temp233)) <= (int)((uint)((uint)223U)));
                            var temp247 = ((temp245) && (temp246));
                            if (temp247)
                            {
                                var temp248 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp248));
                                goto M32;
                            }
                            else
                            {
                                var temp249 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp249)
                                {
                                    var temp250 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp250));
                                    goto M33;
                                }
                                else
                                {
                                    var temp251 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp251)
                                    {
                                        var temp252 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp252));
                                        goto M34;
                                    }
                                    else
                                    {
                                        var temp253 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp233)));
                                        var temp254 = ((int)((uint)(temp233)) <= (int)((uint)((uint)239U)));
                                        var temp255 = ((temp253) && (temp254));
                                        if (temp255)
                                        {
                                            var temp256 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp256));
                                            goto M35;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M27:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F27;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp257 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp258 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp257)));
                        var temp259 = ((int)((uint)(temp257)) <= (int)((uint)((uint)191U)));
                        var temp260 = ((temp258) && (temp259));
                        if (temp260)
                        {
                            var temp261 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp262 = Fun0(((ushort)((s)._0)), ((ushort)(temp261)));
                            var temp263 = (((ushort)((ushort)48U)) <= ((ushort)(temp262)));
                            var temp264 = ((ushort)(((ushort)(temp262)) >> 6));
                            var temp265 = (((ushort)(temp264 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp266 = (((byte)(((byte)((ushort)(temp262))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp267 = (((temp263) && (temp265)) && (temp266));
                            var temp268 = (((ushort)((ushort)1632U)) <= ((ushort)(temp262)));
                            var temp269 = ((byte)(((ushort)(temp262)) >> 11));
                            var temp270 = (((byte)(temp269 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp271 = (((ushort)(((ushort)((ushort)(temp262))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp272 = (((temp268) && (temp270)) && (temp271));
                            var temp273 = (((ushort)((ushort)1776U)) <= ((ushort)(temp262)));
                            var temp274 = (((ushort)(((ushort)((ushort)(temp262))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp275 = (((temp273) && (temp270)) && (temp274));
                            var temp276 = (((ushort)((ushort)1984U)) <= ((ushort)(temp262)));
                            var temp277 = (((ushort)(((ushort)((ushort)(temp262))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp278 = (((temp276) && (temp270)) && (temp277));
                            var temp279 = (((ushort)((ushort)2406U)) <= ((ushort)(temp262)));
                            var temp280 = ((byte)(((ushort)(temp262)) >> 12));
                            var temp281 = (((byte)(temp280 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp282 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp283 = (((temp279) && (temp281)) && (temp282));
                            var temp284 = (((ushort)((ushort)2534U)) <= ((ushort)(temp262)));
                            var temp285 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp286 = (((temp284) && (temp281)) && (temp285));
                            var temp287 = (((ushort)((ushort)2662U)) <= ((ushort)(temp262)));
                            var temp288 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp289 = (((temp287) && (temp281)) && (temp288));
                            var temp290 = (((ushort)((ushort)2790U)) <= ((ushort)(temp262)));
                            var temp291 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp292 = (((temp290) && (temp281)) && (temp291));
                            var temp293 = (((ushort)((ushort)2918U)) <= ((ushort)(temp262)));
                            var temp294 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp295 = (((temp293) && (temp281)) && (temp294));
                            var temp296 = (((ushort)((ushort)3046U)) <= ((ushort)(temp262)));
                            var temp297 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp298 = (((temp296) && (temp281)) && (temp297));
                            var temp299 = (((ushort)((ushort)3174U)) <= ((ushort)(temp262)));
                            var temp300 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp301 = (((temp299) && (temp281)) && (temp300));
                            var temp302 = (((ushort)((ushort)3302U)) <= ((ushort)(temp262)));
                            var temp303 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp304 = (((temp302) && (temp281)) && (temp303));
                            var temp305 = (((ushort)((ushort)3430U)) <= ((ushort)(temp262)));
                            var temp306 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp307 = (((temp305) && (temp281)) && (temp306));
                            var temp308 = (((ushort)((ushort)3664U)) <= ((ushort)(temp262)));
                            var temp309 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp310 = (((temp308) && (temp281)) && (temp309));
                            var temp311 = (((ushort)((ushort)3792U)) <= ((ushort)(temp262)));
                            var temp312 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp313 = (((temp311) && (temp281)) && (temp312));
                            var temp314 = (((ushort)((ushort)3872U)) <= ((ushort)(temp262)));
                            var temp315 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp316 = (((temp314) && (temp281)) && (temp315));
                            var temp317 = (((ushort)((ushort)4160U)) <= ((ushort)(temp262)));
                            var temp318 = ((byte)(((ushort)(temp262)) >> 13));
                            var temp319 = (((byte)(temp318 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp320 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp321 = (((temp317) && (temp319)) && (temp320));
                            var temp322 = (((ushort)((ushort)4240U)) <= ((ushort)(temp262)));
                            var temp323 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp324 = (((temp322) && (temp319)) && (temp323));
                            var temp325 = (((ushort)((ushort)6112U)) <= ((ushort)(temp262)));
                            var temp326 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp327 = (((temp325) && (temp319)) && (temp326));
                            var temp328 = (((ushort)((ushort)6160U)) <= ((ushort)(temp262)));
                            var temp329 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp330 = (((temp328) && (temp319)) && (temp329));
                            var temp331 = (((ushort)((ushort)6470U)) <= ((ushort)(temp262)));
                            var temp332 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp333 = (((temp331) && (temp319)) && (temp332));
                            var temp334 = (((ushort)((ushort)6608U)) <= ((ushort)(temp262)));
                            var temp335 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp336 = (((temp334) && (temp319)) && (temp335));
                            var temp337 = (((ushort)((ushort)6992U)) <= ((ushort)(temp262)));
                            var temp338 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp339 = (((temp337) && (temp319)) && (temp338));
                            var temp340 = (((ushort)((ushort)7088U)) <= ((ushort)(temp262)));
                            var temp341 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp342 = (((temp340) && (temp319)) && (temp341));
                            var temp343 = (((ushort)((ushort)7232U)) <= ((ushort)(temp262)));
                            var temp344 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp345 = (((temp343) && (temp319)) && (temp344));
                            var temp346 = (((ushort)((ushort)7248U)) <= ((ushort)(temp262)));
                            var temp347 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp348 = (((temp346) && (temp319)) && (temp347));
                            var temp349 = (((ushort)((ushort)42528U)) <= ((ushort)(temp262)));
                            var temp350 = (((ushort)(temp262)) <= ((ushort)((ushort)42537U)));
                            var temp351 = ((temp349) && (temp350));
                            var temp352 = (((ushort)((ushort)43216U)) <= ((ushort)(temp262)));
                            var temp353 = (((ushort)(temp262)) <= ((ushort)((ushort)43225U)));
                            var temp354 = ((temp352) && (temp353));
                            var temp355 = (((ushort)((ushort)43264U)) <= ((ushort)(temp262)));
                            var temp356 = (((ushort)(temp262)) <= ((ushort)((ushort)43273U)));
                            var temp357 = ((temp355) && (temp356));
                            var temp358 = (((ushort)((ushort)43600U)) <= ((ushort)(temp262)));
                            var temp359 = (((ushort)(temp262)) <= ((ushort)((ushort)43609U)));
                            var temp360 = ((temp358) && (temp359));
                            var temp361 = (((ushort)((ushort)65296U)) <= ((ushort)(temp262)));
                            var temp362 = (((ushort)(temp262)) <= ((ushort)((ushort)65305U)));
                            var temp363 = ((temp361) && (temp362));
                            var temp364 = (((((((((((((((((((((((((((((((temp267) || (temp272)) || (temp275)) || (temp278)) || (temp283)) || (temp286)) || (temp289)) || (temp292)) || (temp295)) || (temp298)) || (temp301)) || (temp304)) || (temp307)) || (temp310)) || (temp313)) || (temp316)) || (temp321)) || (temp324)) || (temp327)) || (temp330)) || (temp333)) || (temp336)) || (temp339)) || (temp342)) || (temp345)) || (temp348)) || (temp351)) || (temp354)) || (temp357)) || (temp360)) || (temp363));
                            if (temp364)
                            {
                                var temp365 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp366 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp262));
                                var temp367 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp365))) + ((uint)(temp366))));
                                s._1 = ((uint)(temp367));
                                s._0 = ((ushort)((ushort)0U));
                                goto M26;
                            }
                            else
                                throw new Exception();
                        }
                        else
                            throw new Exception();
                    }
                }

                M28:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F28;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp368 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp369 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp368)));
                        var temp370 = ((int)((uint)(temp368)) <= (int)((uint)((uint)191U)));
                        var temp371 = ((temp369) && (temp370));
                        if (temp371)
                        {
                            var temp372 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp373 = Fun0(((ushort)((s)._0)), ((ushort)(temp372)));
                            s._0 = ((ushort)(temp373));
                            goto M27;
                        }
                        else
                            throw new Exception();
                    }
                }

                M29:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F29;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp374 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp375 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp374)));
                        var temp376 = ((int)((uint)(temp374)) <= (int)((uint)((uint)159U)));
                        var temp377 = ((temp375) && (temp376));
                        if (temp377)
                        {
                            var temp378 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp379 = Fun0(((ushort)((s)._0)), ((ushort)(temp378)));
                            s._0 = ((ushort)(temp379));
                            goto M27;
                        }
                        else
                            throw new Exception();
                    }
                }

                M30:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F30;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp380 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp381 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp380)));
                        var temp382 = ((int)((uint)(temp380)) <= (int)((uint)((uint)191U)));
                        var temp383 = ((temp381) && (temp382));
                        if (temp383)
                        {
                            var temp384 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp385 = Fun0(((ushort)((s)._0)), ((ushort)(temp384)));
                            s._0 = ((ushort)(temp385));
                            goto M27;
                        }
                        else
                            throw new Exception();
                    }
                }

                M31:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F31;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp386 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp387 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp386)));
                        var temp388 = ((int)((uint)(temp386)) <= (int)((uint)((uint)127U)));
                        var temp389 = ((temp387) && (temp388));
                        if (temp389)
                        {
                            var temp390 = (((byte)(i)) == ((byte)((byte)10U)));
                            if (temp390)
                            {
                                var temp391 = Fun1(((uint)((s)._1)), ((uint)((s)._2)));
                                s._2 = ((uint)(temp391));
                                s._1 = ((uint)((uint)0U));
                                goto M0;
                            }
                            else
                            {
                                goto M31;
                            }
                        }
                        else
                        {
                            var temp392 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp386)));
                            var temp393 = ((int)((uint)(temp386)) <= (int)((uint)((uint)223U)));
                            var temp394 = ((temp392) && (temp393));
                            if (temp394)
                            {
                                var temp395 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp395));
                                goto M36;
                            }
                            else
                            {
                                var temp396 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp396)
                                {
                                    var temp397 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp397));
                                    goto M37;
                                }
                                else
                                {
                                    var temp398 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp398)
                                    {
                                        var temp399 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp399));
                                        goto M38;
                                    }
                                    else
                                    {
                                        var temp400 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp386)));
                                        var temp401 = ((int)((uint)(temp386)) <= (int)((uint)((uint)239U)));
                                        var temp402 = ((temp400) && (temp401));
                                        if (temp402)
                                        {
                                            var temp403 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp403));
                                            goto M39;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M32:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F32;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp404 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp405 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp404)));
                        var temp406 = ((int)((uint)(temp404)) <= (int)((uint)((uint)191U)));
                        var temp407 = ((temp405) && (temp406));
                        if (temp407)
                        {
                            var temp408 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp409 = Fun0(((ushort)((s)._0)), ((ushort)(temp408)));
                            var temp410 = (((ushort)((ushort)48U)) <= ((ushort)(temp409)));
                            var temp411 = ((ushort)(((ushort)(temp409)) >> 6));
                            var temp412 = (((ushort)(temp411 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp413 = (((byte)(((byte)((ushort)(temp409))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp414 = (((temp410) && (temp412)) && (temp413));
                            var temp415 = (((ushort)((ushort)1632U)) <= ((ushort)(temp409)));
                            var temp416 = ((byte)(((ushort)(temp409)) >> 11));
                            var temp417 = (((byte)(temp416 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp418 = (((ushort)(((ushort)((ushort)(temp409))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp419 = (((temp415) && (temp417)) && (temp418));
                            var temp420 = (((ushort)((ushort)1776U)) <= ((ushort)(temp409)));
                            var temp421 = (((ushort)(((ushort)((ushort)(temp409))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp422 = (((temp420) && (temp417)) && (temp421));
                            var temp423 = (((ushort)((ushort)1984U)) <= ((ushort)(temp409)));
                            var temp424 = (((ushort)(((ushort)((ushort)(temp409))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp425 = (((temp423) && (temp417)) && (temp424));
                            var temp426 = (((ushort)((ushort)2406U)) <= ((ushort)(temp409)));
                            var temp427 = ((byte)(((ushort)(temp409)) >> 12));
                            var temp428 = (((byte)(temp427 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp429 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp430 = (((temp426) && (temp428)) && (temp429));
                            var temp431 = (((ushort)((ushort)2534U)) <= ((ushort)(temp409)));
                            var temp432 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp433 = (((temp431) && (temp428)) && (temp432));
                            var temp434 = (((ushort)((ushort)2662U)) <= ((ushort)(temp409)));
                            var temp435 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp436 = (((temp434) && (temp428)) && (temp435));
                            var temp437 = (((ushort)((ushort)2790U)) <= ((ushort)(temp409)));
                            var temp438 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp439 = (((temp437) && (temp428)) && (temp438));
                            var temp440 = (((ushort)((ushort)2918U)) <= ((ushort)(temp409)));
                            var temp441 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp442 = (((temp440) && (temp428)) && (temp441));
                            var temp443 = (((ushort)((ushort)3046U)) <= ((ushort)(temp409)));
                            var temp444 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp445 = (((temp443) && (temp428)) && (temp444));
                            var temp446 = (((ushort)((ushort)3174U)) <= ((ushort)(temp409)));
                            var temp447 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp448 = (((temp446) && (temp428)) && (temp447));
                            var temp449 = (((ushort)((ushort)3302U)) <= ((ushort)(temp409)));
                            var temp450 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp451 = (((temp449) && (temp428)) && (temp450));
                            var temp452 = (((ushort)((ushort)3430U)) <= ((ushort)(temp409)));
                            var temp453 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp454 = (((temp452) && (temp428)) && (temp453));
                            var temp455 = (((ushort)((ushort)3664U)) <= ((ushort)(temp409)));
                            var temp456 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp457 = (((temp455) && (temp428)) && (temp456));
                            var temp458 = (((ushort)((ushort)3792U)) <= ((ushort)(temp409)));
                            var temp459 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp460 = (((temp458) && (temp428)) && (temp459));
                            var temp461 = (((ushort)((ushort)3872U)) <= ((ushort)(temp409)));
                            var temp462 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp463 = (((temp461) && (temp428)) && (temp462));
                            var temp464 = (((ushort)((ushort)4160U)) <= ((ushort)(temp409)));
                            var temp465 = ((byte)(((ushort)(temp409)) >> 13));
                            var temp466 = (((byte)(temp465 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp467 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp468 = (((temp464) && (temp466)) && (temp467));
                            var temp469 = (((ushort)((ushort)4240U)) <= ((ushort)(temp409)));
                            var temp470 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp471 = (((temp469) && (temp466)) && (temp470));
                            var temp472 = (((ushort)((ushort)6112U)) <= ((ushort)(temp409)));
                            var temp473 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp474 = (((temp472) && (temp466)) && (temp473));
                            var temp475 = (((ushort)((ushort)6160U)) <= ((ushort)(temp409)));
                            var temp476 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp477 = (((temp475) && (temp466)) && (temp476));
                            var temp478 = (((ushort)((ushort)6470U)) <= ((ushort)(temp409)));
                            var temp479 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp480 = (((temp478) && (temp466)) && (temp479));
                            var temp481 = (((ushort)((ushort)6608U)) <= ((ushort)(temp409)));
                            var temp482 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp483 = (((temp481) && (temp466)) && (temp482));
                            var temp484 = (((ushort)((ushort)6992U)) <= ((ushort)(temp409)));
                            var temp485 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp486 = (((temp484) && (temp466)) && (temp485));
                            var temp487 = (((ushort)((ushort)7088U)) <= ((ushort)(temp409)));
                            var temp488 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp489 = (((temp487) && (temp466)) && (temp488));
                            var temp490 = (((ushort)((ushort)7232U)) <= ((ushort)(temp409)));
                            var temp491 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp492 = (((temp490) && (temp466)) && (temp491));
                            var temp493 = (((ushort)((ushort)7248U)) <= ((ushort)(temp409)));
                            var temp494 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp495 = (((temp493) && (temp466)) && (temp494));
                            var temp496 = (((ushort)((ushort)42528U)) <= ((ushort)(temp409)));
                            var temp497 = (((ushort)(temp409)) <= ((ushort)((ushort)42537U)));
                            var temp498 = ((temp496) && (temp497));
                            var temp499 = (((ushort)((ushort)43216U)) <= ((ushort)(temp409)));
                            var temp500 = (((ushort)(temp409)) <= ((ushort)((ushort)43225U)));
                            var temp501 = ((temp499) && (temp500));
                            var temp502 = (((ushort)((ushort)43264U)) <= ((ushort)(temp409)));
                            var temp503 = (((ushort)(temp409)) <= ((ushort)((ushort)43273U)));
                            var temp504 = ((temp502) && (temp503));
                            var temp505 = (((ushort)((ushort)43600U)) <= ((ushort)(temp409)));
                            var temp506 = (((ushort)(temp409)) <= ((ushort)((ushort)43609U)));
                            var temp507 = ((temp505) && (temp506));
                            var temp508 = (((ushort)((ushort)65296U)) <= ((ushort)(temp409)));
                            var temp509 = (((ushort)(temp409)) <= ((ushort)((ushort)65305U)));
                            var temp510 = ((temp508) && (temp509));
                            var temp511 = (((((((((((((((((((((((((((((((temp414) || (temp419)) || (temp422)) || (temp425)) || (temp430)) || (temp433)) || (temp436)) || (temp439)) || (temp442)) || (temp445)) || (temp448)) || (temp451)) || (temp454)) || (temp457)) || (temp460)) || (temp463)) || (temp468)) || (temp471)) || (temp474)) || (temp477)) || (temp480)) || (temp483)) || (temp486)) || (temp489)) || (temp492)) || (temp495)) || (temp498)) || (temp501)) || (temp504)) || (temp507)) || (temp510));
                            if (temp511)
                            {
                                var temp512 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp513 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp409));
                                var temp514 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp512))) + ((uint)(temp513))));
                                s._1 = ((uint)(temp514));
                                s._0 = ((ushort)((ushort)0U));
                                goto M26;
                            }
                            else
                                throw new Exception();
                        }
                        else
                            throw new Exception();
                    }
                }

                M33:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F33;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp515 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp516 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp515)));
                        var temp517 = ((int)((uint)(temp515)) <= (int)((uint)((uint)191U)));
                        var temp518 = ((temp516) && (temp517));
                        if (temp518)
                        {
                            var temp519 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp520 = Fun0(((ushort)((s)._0)), ((ushort)(temp519)));
                            s._0 = ((ushort)(temp520));
                            goto M32;
                        }
                        else
                            throw new Exception();
                    }
                }

                M34:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F34;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp521 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp522 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp521)));
                        var temp523 = ((int)((uint)(temp521)) <= (int)((uint)((uint)159U)));
                        var temp524 = ((temp522) && (temp523));
                        if (temp524)
                        {
                            var temp525 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp526 = Fun0(((ushort)((s)._0)), ((ushort)(temp525)));
                            s._0 = ((ushort)(temp526));
                            goto M32;
                        }
                        else
                            throw new Exception();
                    }
                }

                M35:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F35;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp527 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp528 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp527)));
                        var temp529 = ((int)((uint)(temp527)) <= (int)((uint)((uint)191U)));
                        var temp530 = ((temp528) && (temp529));
                        if (temp530)
                        {
                            var temp531 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp532 = Fun0(((ushort)((s)._0)), ((ushort)(temp531)));
                            s._0 = ((ushort)(temp532));
                            goto M32;
                        }
                        else
                            throw new Exception();
                    }
                }

                M36:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F36;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp533 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp534 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp533)));
                        var temp535 = ((int)((uint)(temp533)) <= (int)((uint)((uint)191U)));
                        var temp536 = ((temp534) && (temp535));
                        if (temp536)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M31;
                        }
                        else
                            throw new Exception();
                    }
                }

                M37:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F37;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp537 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp538 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp537)));
                        var temp539 = ((int)((uint)(temp537)) <= (int)((uint)((uint)191U)));
                        var temp540 = ((temp538) && (temp539));
                        if (temp540)
                        {
                            var temp541 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp542 = Fun0(((ushort)((s)._0)), ((ushort)(temp541)));
                            s._0 = ((ushort)(temp542));
                            goto M36;
                        }
                        else
                            throw new Exception();
                    }
                }

                M38:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F38;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp543 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp544 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp543)));
                        var temp545 = ((int)((uint)(temp543)) <= (int)((uint)((uint)159U)));
                        var temp546 = ((temp544) && (temp545));
                        if (temp546)
                        {
                            var temp547 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp548 = Fun0(((ushort)((s)._0)), ((ushort)(temp547)));
                            s._0 = ((ushort)(temp548));
                            goto M36;
                        }
                        else
                            throw new Exception();
                    }
                }

                M39:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F39;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp549 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp550 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp549)));
                        var temp551 = ((int)((uint)(temp549)) <= (int)((uint)((uint)191U)));
                        var temp552 = ((temp550) && (temp551));
                        if (temp552)
                        {
                            var temp553 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp554 = Fun0(((ushort)((s)._0)), ((ushort)(temp553)));
                            s._0 = ((ushort)(temp554));
                            goto M36;
                        }
                        else
                            throw new Exception();
                    }
                }

                F0:
                {
                    if (oIndex > 16380)
                    {
                        output.Write(oBuf, 0, oIndex);
                        oIndex = 0;
                    }

                    var temp0 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp0))));
                    var temp1 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp1))));
                    var temp2 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp2))));
                    oBuf[oIndex + 3] = (Byte)(((byte)((uint)((s)._2))));
                    oIndex += 4;
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F1:
                    throw new Exception();
                F2:
                {
                    if (oIndex > 16380)
                    {
                        output.Write(oBuf, 0, oIndex);
                        oIndex = 0;
                    }

                    var temp37 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp37))));
                    var temp38 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp38))));
                    var temp39 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp39))));
                    oBuf[oIndex + 3] = (Byte)(((byte)((uint)((s)._2))));
                    oIndex += 4;
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F3:
                {
                    if (oIndex > 16380)
                    {
                        output.Write(oBuf, 0, oIndex);
                        oIndex = 0;
                    }

                    var temp44 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp44))));
                    var temp45 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp45))));
                    var temp46 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp46))));
                    oBuf[oIndex + 3] = (Byte)(((byte)((uint)((s)._2))));
                    oIndex += 4;
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F4:
                {
                    if (oIndex > 16380)
                    {
                        output.Write(oBuf, 0, oIndex);
                        oIndex = 0;
                    }

                    var temp53 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp53))));
                    var temp54 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp54))));
                    var temp55 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp55))));
                    oBuf[oIndex + 3] = (Byte)(((byte)((uint)((s)._2))));
                    oIndex += 4;
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F5:
                {
                    if (oIndex > 16380)
                    {
                        output.Write(oBuf, 0, oIndex);
                        oIndex = 0;
                    }

                    var temp62 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp62))));
                    var temp63 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp63))));
                    var temp64 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp64))));
                    oBuf[oIndex + 3] = (Byte)(((byte)((uint)((s)._2))));
                    oIndex += 4;
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F6:
                    throw new Exception();
                F7:
                    throw new Exception();
                F8:
                    throw new Exception();
                F9:
                    throw new Exception();
                F10:
                    throw new Exception();
                F11:
                    throw new Exception();
                F12:
                    throw new Exception();
                F13:
                    throw new Exception();
                F14:
                    throw new Exception();
                F15:
                    throw new Exception();
                F16:
                    throw new Exception();
                F17:
                    throw new Exception();
                F18:
                    throw new Exception();
                F19:
                    throw new Exception();
                F20:
                    throw new Exception();
                F21:
                    throw new Exception();
                F22:
                    throw new Exception();
                F23:
                    throw new Exception();
                F24:
                    throw new Exception();
                F25:
                    throw new Exception();
                F26:
                    throw new Exception();
                F27:
                    throw new Exception();
                F28:
                    throw new Exception();
                F29:
                    throw new Exception();
                F30:
                    throw new Exception();
                F31:
                    throw new Exception();
                F32:
                    throw new Exception();
                F33:
                    throw new Exception();
                F34:
                    throw new Exception();
                F35:
                    throw new Exception();
                F36:
                    throw new Exception();
                F37:
                    throw new Exception();
                F38:
                    throw new Exception();
                F39:
                    throw new Exception();
            }
        }

        struct DTStruct2
        {
            public UInt16 _0;
            public UInt32 _1;
            public UInt32 _2;
            public DTStruct2(UInt16 v0, UInt32 v1, UInt32 v2)
            {
                _0 = v0;
                _1 = v1;
                _2 = v2;
            }
        }

        public static void TransduceFromArrayToStream(byte[] input, Stream output)
        {
            unchecked
            {
                int iIndex = -1;
                var oBuf = new byte[16384];
                int oIndex = 0;
                DTStruct2 s = new DTStruct2(((ushort)((ushort)0U)), ((uint)((uint)0U)), ((uint)((uint)4294967295U)));
                Byte i;
                M0:
                {
                    if (++iIndex >= input.Length)
                        goto F0;
                    i = input[iIndex];
                    {
                        var temp3 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp4 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp3)));
                        var temp5 = ((int)((uint)(temp3)) <= (int)((uint)((uint)127U)));
                        var temp6 = ((temp4) && (temp5));
                        if (temp6)
                        {
                            var temp7 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp7)
                            {
                                goto M1;
                            }
                            else
                            {
                                goto M0;
                            }
                        }
                        else
                        {
                            var temp8 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp3)));
                            var temp9 = ((int)((uint)(temp3)) <= (int)((uint)((uint)223U)));
                            var temp10 = ((temp8) && (temp9));
                            if (temp10)
                            {
                                var temp11 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp11));
                                goto M2;
                            }
                            else
                            {
                                var temp12 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp12)
                                {
                                    var temp13 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp13));
                                    goto M3;
                                }
                                else
                                {
                                    var temp14 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp14)
                                    {
                                        var temp15 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp15));
                                        goto M4;
                                    }
                                    else
                                    {
                                        var temp16 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp3)));
                                        var temp17 = ((int)((uint)(temp3)) <= (int)((uint)((uint)239U)));
                                        var temp18 = ((temp16) && (temp17));
                                        if (temp18)
                                        {
                                            var temp19 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp19));
                                            goto M5;
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
                    if (++iIndex >= input.Length)
                        goto F1;
                    i = input[iIndex];
                    {
                        var temp20 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp21 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp20)));
                        var temp22 = ((int)((uint)(temp20)) <= (int)((uint)((uint)127U)));
                        var temp23 = ((temp21) && (temp22));
                        if (temp23)
                        {
                            var temp24 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp24)
                            {
                                goto M6;
                            }
                            else
                            {
                                goto M1;
                            }
                        }
                        else
                        {
                            var temp25 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp20)));
                            var temp26 = ((int)((uint)(temp20)) <= (int)((uint)((uint)223U)));
                            var temp27 = ((temp25) && (temp26));
                            if (temp27)
                            {
                                var temp28 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp28));
                                goto M7;
                            }
                            else
                            {
                                var temp29 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp29)
                                {
                                    var temp30 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp30));
                                    goto M8;
                                }
                                else
                                {
                                    var temp31 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp31)
                                    {
                                        var temp32 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp32));
                                        goto M9;
                                    }
                                    else
                                    {
                                        var temp33 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp20)));
                                        var temp34 = ((int)((uint)(temp20)) <= (int)((uint)((uint)239U)));
                                        var temp35 = ((temp33) && (temp34));
                                        if (temp35)
                                        {
                                            var temp36 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp36));
                                            goto M10;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M2:
                {
                    if (++iIndex >= input.Length)
                        goto F2;
                    i = input[iIndex];
                    {
                        var temp40 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp41 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp40)));
                        var temp42 = ((int)((uint)(temp40)) <= (int)((uint)((uint)191U)));
                        var temp43 = ((temp41) && (temp42));
                        if (temp43)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M0;
                        }
                        else
                            throw new Exception();
                    }
                }

                M3:
                {
                    if (++iIndex >= input.Length)
                        goto F3;
                    i = input[iIndex];
                    {
                        var temp47 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp48 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp47)));
                        var temp49 = ((int)((uint)(temp47)) <= (int)((uint)((uint)191U)));
                        var temp50 = ((temp48) && (temp49));
                        if (temp50)
                        {
                            var temp51 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp52 = Fun0(((ushort)((s)._0)), ((ushort)(temp51)));
                            s._0 = ((ushort)(temp52));
                            goto M2;
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
                        var temp56 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp57 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp56)));
                        var temp58 = ((int)((uint)(temp56)) <= (int)((uint)((uint)159U)));
                        var temp59 = ((temp57) && (temp58));
                        if (temp59)
                        {
                            var temp60 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp61 = Fun0(((ushort)((s)._0)), ((ushort)(temp60)));
                            s._0 = ((ushort)(temp61));
                            goto M2;
                        }
                        else
                            throw new Exception();
                    }
                }

                M5:
                {
                    if (++iIndex >= input.Length)
                        goto F5;
                    i = input[iIndex];
                    {
                        var temp65 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp66 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp65)));
                        var temp67 = ((int)((uint)(temp65)) <= (int)((uint)((uint)191U)));
                        var temp68 = ((temp66) && (temp67));
                        if (temp68)
                        {
                            var temp69 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp70 = Fun0(((ushort)((s)._0)), ((ushort)(temp69)));
                            s._0 = ((ushort)(temp70));
                            goto M2;
                        }
                        else
                            throw new Exception();
                    }
                }

                M6:
                {
                    if (++iIndex >= input.Length)
                        goto F6;
                    i = input[iIndex];
                    {
                        var temp71 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp72 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp71)));
                        var temp73 = ((int)((uint)(temp71)) <= (int)((uint)((uint)127U)));
                        var temp74 = ((temp72) && (temp73));
                        if (temp74)
                        {
                            var temp75 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp75)
                            {
                                goto M11;
                            }
                            else
                            {
                                goto M6;
                            }
                        }
                        else
                        {
                            var temp76 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp71)));
                            var temp77 = ((int)((uint)(temp71)) <= (int)((uint)((uint)223U)));
                            var temp78 = ((temp76) && (temp77));
                            if (temp78)
                            {
                                var temp79 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp79));
                                goto M12;
                            }
                            else
                            {
                                var temp80 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp80)
                                {
                                    var temp81 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp81));
                                    goto M13;
                                }
                                else
                                {
                                    var temp82 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp82)
                                    {
                                        var temp83 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp83));
                                        goto M14;
                                    }
                                    else
                                    {
                                        var temp84 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp71)));
                                        var temp85 = ((int)((uint)(temp71)) <= (int)((uint)((uint)239U)));
                                        var temp86 = ((temp84) && (temp85));
                                        if (temp86)
                                        {
                                            var temp87 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp87));
                                            goto M15;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M7:
                {
                    if (++iIndex >= input.Length)
                        goto F7;
                    i = input[iIndex];
                    {
                        var temp88 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp89 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp88)));
                        var temp90 = ((int)((uint)(temp88)) <= (int)((uint)((uint)191U)));
                        var temp91 = ((temp89) && (temp90));
                        if (temp91)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M1;
                        }
                        else
                            throw new Exception();
                    }
                }

                M8:
                {
                    if (++iIndex >= input.Length)
                        goto F8;
                    i = input[iIndex];
                    {
                        var temp92 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp93 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp92)));
                        var temp94 = ((int)((uint)(temp92)) <= (int)((uint)((uint)191U)));
                        var temp95 = ((temp93) && (temp94));
                        if (temp95)
                        {
                            var temp96 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp97 = Fun0(((ushort)((s)._0)), ((ushort)(temp96)));
                            s._0 = ((ushort)(temp97));
                            goto M7;
                        }
                        else
                            throw new Exception();
                    }
                }

                M9:
                {
                    if (++iIndex >= input.Length)
                        goto F9;
                    i = input[iIndex];
                    {
                        var temp98 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp99 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp98)));
                        var temp100 = ((int)((uint)(temp98)) <= (int)((uint)((uint)159U)));
                        var temp101 = ((temp99) && (temp100));
                        if (temp101)
                        {
                            var temp102 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp103 = Fun0(((ushort)((s)._0)), ((ushort)(temp102)));
                            s._0 = ((ushort)(temp103));
                            goto M7;
                        }
                        else
                            throw new Exception();
                    }
                }

                M10:
                {
                    if (++iIndex >= input.Length)
                        goto F10;
                    i = input[iIndex];
                    {
                        var temp104 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp105 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp104)));
                        var temp106 = ((int)((uint)(temp104)) <= (int)((uint)((uint)191U)));
                        var temp107 = ((temp105) && (temp106));
                        if (temp107)
                        {
                            var temp108 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp109 = Fun0(((ushort)((s)._0)), ((ushort)(temp108)));
                            s._0 = ((ushort)(temp109));
                            goto M7;
                        }
                        else
                            throw new Exception();
                    }
                }

                M11:
                {
                    if (++iIndex >= input.Length)
                        goto F11;
                    i = input[iIndex];
                    {
                        var temp110 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp111 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp110)));
                        var temp112 = ((int)((uint)(temp110)) <= (int)((uint)((uint)127U)));
                        var temp113 = ((temp111) && (temp112));
                        if (temp113)
                        {
                            var temp114 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp114)
                            {
                                goto M16;
                            }
                            else
                            {
                                goto M11;
                            }
                        }
                        else
                        {
                            var temp115 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp110)));
                            var temp116 = ((int)((uint)(temp110)) <= (int)((uint)((uint)223U)));
                            var temp117 = ((temp115) && (temp116));
                            if (temp117)
                            {
                                var temp118 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp118));
                                goto M17;
                            }
                            else
                            {
                                var temp119 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp119)
                                {
                                    var temp120 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp120));
                                    goto M18;
                                }
                                else
                                {
                                    var temp121 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp121)
                                    {
                                        var temp122 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp122));
                                        goto M19;
                                    }
                                    else
                                    {
                                        var temp123 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp110)));
                                        var temp124 = ((int)((uint)(temp110)) <= (int)((uint)((uint)239U)));
                                        var temp125 = ((temp123) && (temp124));
                                        if (temp125)
                                        {
                                            var temp126 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp126));
                                            goto M20;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M12:
                {
                    if (++iIndex >= input.Length)
                        goto F12;
                    i = input[iIndex];
                    {
                        var temp127 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp128 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp127)));
                        var temp129 = ((int)((uint)(temp127)) <= (int)((uint)((uint)191U)));
                        var temp130 = ((temp128) && (temp129));
                        if (temp130)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M6;
                        }
                        else
                            throw new Exception();
                    }
                }

                M13:
                {
                    if (++iIndex >= input.Length)
                        goto F13;
                    i = input[iIndex];
                    {
                        var temp131 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp132 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp131)));
                        var temp133 = ((int)((uint)(temp131)) <= (int)((uint)((uint)191U)));
                        var temp134 = ((temp132) && (temp133));
                        if (temp134)
                        {
                            var temp135 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp136 = Fun0(((ushort)((s)._0)), ((ushort)(temp135)));
                            s._0 = ((ushort)(temp136));
                            goto M12;
                        }
                        else
                            throw new Exception();
                    }
                }

                M14:
                {
                    if (++iIndex >= input.Length)
                        goto F14;
                    i = input[iIndex];
                    {
                        var temp137 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp138 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp137)));
                        var temp139 = ((int)((uint)(temp137)) <= (int)((uint)((uint)159U)));
                        var temp140 = ((temp138) && (temp139));
                        if (temp140)
                        {
                            var temp141 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp142 = Fun0(((ushort)((s)._0)), ((ushort)(temp141)));
                            s._0 = ((ushort)(temp142));
                            goto M12;
                        }
                        else
                            throw new Exception();
                    }
                }

                M15:
                {
                    if (++iIndex >= input.Length)
                        goto F15;
                    i = input[iIndex];
                    {
                        var temp143 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp144 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp143)));
                        var temp145 = ((int)((uint)(temp143)) <= (int)((uint)((uint)191U)));
                        var temp146 = ((temp144) && (temp145));
                        if (temp146)
                        {
                            var temp147 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp148 = Fun0(((ushort)((s)._0)), ((ushort)(temp147)));
                            s._0 = ((ushort)(temp148));
                            goto M12;
                        }
                        else
                            throw new Exception();
                    }
                }

                M16:
                {
                    if (++iIndex >= input.Length)
                        goto F16;
                    i = input[iIndex];
                    {
                        var temp149 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp150 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp149)));
                        var temp151 = ((int)((uint)(temp149)) <= (int)((uint)((uint)127U)));
                        var temp152 = ((temp150) && (temp151));
                        if (temp152)
                        {
                            var temp153 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp153)
                            {
                                goto M21;
                            }
                            else
                            {
                                goto M16;
                            }
                        }
                        else
                        {
                            var temp154 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp149)));
                            var temp155 = ((int)((uint)(temp149)) <= (int)((uint)((uint)223U)));
                            var temp156 = ((temp154) && (temp155));
                            if (temp156)
                            {
                                var temp157 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp157));
                                goto M22;
                            }
                            else
                            {
                                var temp158 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp158)
                                {
                                    var temp159 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp159));
                                    goto M23;
                                }
                                else
                                {
                                    var temp160 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp160)
                                    {
                                        var temp161 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp161));
                                        goto M24;
                                    }
                                    else
                                    {
                                        var temp162 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp149)));
                                        var temp163 = ((int)((uint)(temp149)) <= (int)((uint)((uint)239U)));
                                        var temp164 = ((temp162) && (temp163));
                                        if (temp164)
                                        {
                                            var temp165 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp165));
                                            goto M25;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M17:
                {
                    if (++iIndex >= input.Length)
                        goto F17;
                    i = input[iIndex];
                    {
                        var temp166 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp167 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp166)));
                        var temp168 = ((int)((uint)(temp166)) <= (int)((uint)((uint)191U)));
                        var temp169 = ((temp167) && (temp168));
                        if (temp169)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M11;
                        }
                        else
                            throw new Exception();
                    }
                }

                M18:
                {
                    if (++iIndex >= input.Length)
                        goto F18;
                    i = input[iIndex];
                    {
                        var temp170 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp171 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp170)));
                        var temp172 = ((int)((uint)(temp170)) <= (int)((uint)((uint)191U)));
                        var temp173 = ((temp171) && (temp172));
                        if (temp173)
                        {
                            var temp174 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp175 = Fun0(((ushort)((s)._0)), ((ushort)(temp174)));
                            s._0 = ((ushort)(temp175));
                            goto M17;
                        }
                        else
                            throw new Exception();
                    }
                }

                M19:
                {
                    if (++iIndex >= input.Length)
                        goto F19;
                    i = input[iIndex];
                    {
                        var temp176 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp177 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp176)));
                        var temp178 = ((int)((uint)(temp176)) <= (int)((uint)((uint)159U)));
                        var temp179 = ((temp177) && (temp178));
                        if (temp179)
                        {
                            var temp180 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp181 = Fun0(((ushort)((s)._0)), ((ushort)(temp180)));
                            s._0 = ((ushort)(temp181));
                            goto M17;
                        }
                        else
                            throw new Exception();
                    }
                }

                M20:
                {
                    if (++iIndex >= input.Length)
                        goto F20;
                    i = input[iIndex];
                    {
                        var temp182 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp183 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp182)));
                        var temp184 = ((int)((uint)(temp182)) <= (int)((uint)((uint)191U)));
                        var temp185 = ((temp183) && (temp184));
                        if (temp185)
                        {
                            var temp186 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp187 = Fun0(((ushort)((s)._0)), ((ushort)(temp186)));
                            s._0 = ((ushort)(temp187));
                            goto M17;
                        }
                        else
                            throw new Exception();
                    }
                }

                M21:
                {
                    if (++iIndex >= input.Length)
                        goto F21;
                    i = input[iIndex];
                    {
                        var temp188 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp189 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp188)));
                        var temp190 = ((int)((uint)(temp188)) <= (int)((uint)((uint)127U)));
                        var temp191 = ((temp189) && (temp190));
                        if (temp191)
                        {
                            var temp192 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp193 = ((byte)(((byte)(i)) >> 6));
                            var temp194 = (((byte)(temp193 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp195 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp196 = (((temp192) && (temp194)) && (temp195));
                            if (temp196)
                            {
                                var temp197 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp198 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp197))) + ((uint)(temp188))));
                                s._1 = ((uint)(temp198));
                                goto M26;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp199 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp188)));
                            var temp200 = ((int)((uint)(temp188)) <= (int)((uint)((uint)223U)));
                            var temp201 = ((temp199) && (temp200));
                            if (temp201)
                            {
                                var temp202 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp202));
                                goto M27;
                            }
                            else
                            {
                                var temp203 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp203)
                                {
                                    var temp204 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp204));
                                    goto M28;
                                }
                                else
                                {
                                    var temp205 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp205)
                                    {
                                        var temp206 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp206));
                                        goto M29;
                                    }
                                    else
                                    {
                                        var temp207 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp188)));
                                        var temp208 = ((int)((uint)(temp188)) <= (int)((uint)((uint)239U)));
                                        var temp209 = ((temp207) && (temp208));
                                        if (temp209)
                                        {
                                            var temp210 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp210));
                                            goto M30;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M22:
                {
                    if (++iIndex >= input.Length)
                        goto F22;
                    i = input[iIndex];
                    {
                        var temp211 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp212 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp211)));
                        var temp213 = ((int)((uint)(temp211)) <= (int)((uint)((uint)191U)));
                        var temp214 = ((temp212) && (temp213));
                        if (temp214)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M16;
                        }
                        else
                            throw new Exception();
                    }
                }

                M23:
                {
                    if (++iIndex >= input.Length)
                        goto F23;
                    i = input[iIndex];
                    {
                        var temp215 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp216 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp215)));
                        var temp217 = ((int)((uint)(temp215)) <= (int)((uint)((uint)191U)));
                        var temp218 = ((temp216) && (temp217));
                        if (temp218)
                        {
                            var temp219 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp220 = Fun0(((ushort)((s)._0)), ((ushort)(temp219)));
                            s._0 = ((ushort)(temp220));
                            goto M22;
                        }
                        else
                            throw new Exception();
                    }
                }

                M24:
                {
                    if (++iIndex >= input.Length)
                        goto F24;
                    i = input[iIndex];
                    {
                        var temp221 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp222 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp221)));
                        var temp223 = ((int)((uint)(temp221)) <= (int)((uint)((uint)159U)));
                        var temp224 = ((temp222) && (temp223));
                        if (temp224)
                        {
                            var temp225 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp226 = Fun0(((ushort)((s)._0)), ((ushort)(temp225)));
                            s._0 = ((ushort)(temp226));
                            goto M22;
                        }
                        else
                            throw new Exception();
                    }
                }

                M25:
                {
                    if (++iIndex >= input.Length)
                        goto F25;
                    i = input[iIndex];
                    {
                        var temp227 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp228 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp227)));
                        var temp229 = ((int)((uint)(temp227)) <= (int)((uint)((uint)191U)));
                        var temp230 = ((temp228) && (temp229));
                        if (temp230)
                        {
                            var temp231 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp232 = Fun0(((ushort)((s)._0)), ((ushort)(temp231)));
                            s._0 = ((ushort)(temp232));
                            goto M22;
                        }
                        else
                            throw new Exception();
                    }
                }

                M26:
                {
                    if (++iIndex >= input.Length)
                        goto F26;
                    i = input[iIndex];
                    {
                        var temp233 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp234 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp233)));
                        var temp235 = ((int)((uint)(temp233)) <= (int)((uint)((uint)127U)));
                        var temp236 = ((temp234) && (temp235));
                        if (temp236)
                        {
                            var temp237 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp237)
                            {
                                goto M31;
                            }
                            else
                            {
                                var temp238 = (((byte)((byte)48U)) <= ((byte)(i)));
                                var temp239 = ((byte)(((byte)(i)) >> 6));
                                var temp240 = (((byte)(temp239 & 3L)) == ((byte)((byte)0U & 3L)));
                                var temp241 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp242 = (((temp238) && (temp240)) && (temp241));
                                if (temp242)
                                {
                                    var temp243 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                    var temp244 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp243))) + ((uint)(temp233))));
                                    s._1 = ((uint)(temp244));
                                    goto M26;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                        else
                        {
                            var temp245 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp233)));
                            var temp246 = ((int)((uint)(temp233)) <= (int)((uint)((uint)223U)));
                            var temp247 = ((temp245) && (temp246));
                            if (temp247)
                            {
                                var temp248 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp248));
                                goto M32;
                            }
                            else
                            {
                                var temp249 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp249)
                                {
                                    var temp250 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp250));
                                    goto M33;
                                }
                                else
                                {
                                    var temp251 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp251)
                                    {
                                        var temp252 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp252));
                                        goto M34;
                                    }
                                    else
                                    {
                                        var temp253 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp233)));
                                        var temp254 = ((int)((uint)(temp233)) <= (int)((uint)((uint)239U)));
                                        var temp255 = ((temp253) && (temp254));
                                        if (temp255)
                                        {
                                            var temp256 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp256));
                                            goto M35;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M27:
                {
                    if (++iIndex >= input.Length)
                        goto F27;
                    i = input[iIndex];
                    {
                        var temp257 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp258 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp257)));
                        var temp259 = ((int)((uint)(temp257)) <= (int)((uint)((uint)191U)));
                        var temp260 = ((temp258) && (temp259));
                        if (temp260)
                        {
                            var temp261 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp262 = Fun0(((ushort)((s)._0)), ((ushort)(temp261)));
                            var temp263 = (((ushort)((ushort)48U)) <= ((ushort)(temp262)));
                            var temp264 = ((ushort)(((ushort)(temp262)) >> 6));
                            var temp265 = (((ushort)(temp264 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp266 = (((byte)(((byte)((ushort)(temp262))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp267 = (((temp263) && (temp265)) && (temp266));
                            var temp268 = (((ushort)((ushort)1632U)) <= ((ushort)(temp262)));
                            var temp269 = ((byte)(((ushort)(temp262)) >> 11));
                            var temp270 = (((byte)(temp269 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp271 = (((ushort)(((ushort)((ushort)(temp262))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp272 = (((temp268) && (temp270)) && (temp271));
                            var temp273 = (((ushort)((ushort)1776U)) <= ((ushort)(temp262)));
                            var temp274 = (((ushort)(((ushort)((ushort)(temp262))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp275 = (((temp273) && (temp270)) && (temp274));
                            var temp276 = (((ushort)((ushort)1984U)) <= ((ushort)(temp262)));
                            var temp277 = (((ushort)(((ushort)((ushort)(temp262))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp278 = (((temp276) && (temp270)) && (temp277));
                            var temp279 = (((ushort)((ushort)2406U)) <= ((ushort)(temp262)));
                            var temp280 = ((byte)(((ushort)(temp262)) >> 12));
                            var temp281 = (((byte)(temp280 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp282 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp283 = (((temp279) && (temp281)) && (temp282));
                            var temp284 = (((ushort)((ushort)2534U)) <= ((ushort)(temp262)));
                            var temp285 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp286 = (((temp284) && (temp281)) && (temp285));
                            var temp287 = (((ushort)((ushort)2662U)) <= ((ushort)(temp262)));
                            var temp288 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp289 = (((temp287) && (temp281)) && (temp288));
                            var temp290 = (((ushort)((ushort)2790U)) <= ((ushort)(temp262)));
                            var temp291 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp292 = (((temp290) && (temp281)) && (temp291));
                            var temp293 = (((ushort)((ushort)2918U)) <= ((ushort)(temp262)));
                            var temp294 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp295 = (((temp293) && (temp281)) && (temp294));
                            var temp296 = (((ushort)((ushort)3046U)) <= ((ushort)(temp262)));
                            var temp297 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp298 = (((temp296) && (temp281)) && (temp297));
                            var temp299 = (((ushort)((ushort)3174U)) <= ((ushort)(temp262)));
                            var temp300 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp301 = (((temp299) && (temp281)) && (temp300));
                            var temp302 = (((ushort)((ushort)3302U)) <= ((ushort)(temp262)));
                            var temp303 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp304 = (((temp302) && (temp281)) && (temp303));
                            var temp305 = (((ushort)((ushort)3430U)) <= ((ushort)(temp262)));
                            var temp306 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp307 = (((temp305) && (temp281)) && (temp306));
                            var temp308 = (((ushort)((ushort)3664U)) <= ((ushort)(temp262)));
                            var temp309 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp310 = (((temp308) && (temp281)) && (temp309));
                            var temp311 = (((ushort)((ushort)3792U)) <= ((ushort)(temp262)));
                            var temp312 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp313 = (((temp311) && (temp281)) && (temp312));
                            var temp314 = (((ushort)((ushort)3872U)) <= ((ushort)(temp262)));
                            var temp315 = (((ushort)(((ushort)((ushort)(temp262))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp316 = (((temp314) && (temp281)) && (temp315));
                            var temp317 = (((ushort)((ushort)4160U)) <= ((ushort)(temp262)));
                            var temp318 = ((byte)(((ushort)(temp262)) >> 13));
                            var temp319 = (((byte)(temp318 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp320 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp321 = (((temp317) && (temp319)) && (temp320));
                            var temp322 = (((ushort)((ushort)4240U)) <= ((ushort)(temp262)));
                            var temp323 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp324 = (((temp322) && (temp319)) && (temp323));
                            var temp325 = (((ushort)((ushort)6112U)) <= ((ushort)(temp262)));
                            var temp326 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp327 = (((temp325) && (temp319)) && (temp326));
                            var temp328 = (((ushort)((ushort)6160U)) <= ((ushort)(temp262)));
                            var temp329 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp330 = (((temp328) && (temp319)) && (temp329));
                            var temp331 = (((ushort)((ushort)6470U)) <= ((ushort)(temp262)));
                            var temp332 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp333 = (((temp331) && (temp319)) && (temp332));
                            var temp334 = (((ushort)((ushort)6608U)) <= ((ushort)(temp262)));
                            var temp335 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp336 = (((temp334) && (temp319)) && (temp335));
                            var temp337 = (((ushort)((ushort)6992U)) <= ((ushort)(temp262)));
                            var temp338 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp339 = (((temp337) && (temp319)) && (temp338));
                            var temp340 = (((ushort)((ushort)7088U)) <= ((ushort)(temp262)));
                            var temp341 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp342 = (((temp340) && (temp319)) && (temp341));
                            var temp343 = (((ushort)((ushort)7232U)) <= ((ushort)(temp262)));
                            var temp344 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp345 = (((temp343) && (temp319)) && (temp344));
                            var temp346 = (((ushort)((ushort)7248U)) <= ((ushort)(temp262)));
                            var temp347 = (((ushort)(((ushort)((ushort)(temp262))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp348 = (((temp346) && (temp319)) && (temp347));
                            var temp349 = (((ushort)((ushort)42528U)) <= ((ushort)(temp262)));
                            var temp350 = (((ushort)(temp262)) <= ((ushort)((ushort)42537U)));
                            var temp351 = ((temp349) && (temp350));
                            var temp352 = (((ushort)((ushort)43216U)) <= ((ushort)(temp262)));
                            var temp353 = (((ushort)(temp262)) <= ((ushort)((ushort)43225U)));
                            var temp354 = ((temp352) && (temp353));
                            var temp355 = (((ushort)((ushort)43264U)) <= ((ushort)(temp262)));
                            var temp356 = (((ushort)(temp262)) <= ((ushort)((ushort)43273U)));
                            var temp357 = ((temp355) && (temp356));
                            var temp358 = (((ushort)((ushort)43600U)) <= ((ushort)(temp262)));
                            var temp359 = (((ushort)(temp262)) <= ((ushort)((ushort)43609U)));
                            var temp360 = ((temp358) && (temp359));
                            var temp361 = (((ushort)((ushort)65296U)) <= ((ushort)(temp262)));
                            var temp362 = (((ushort)(temp262)) <= ((ushort)((ushort)65305U)));
                            var temp363 = ((temp361) && (temp362));
                            var temp364 = (((((((((((((((((((((((((((((((temp267) || (temp272)) || (temp275)) || (temp278)) || (temp283)) || (temp286)) || (temp289)) || (temp292)) || (temp295)) || (temp298)) || (temp301)) || (temp304)) || (temp307)) || (temp310)) || (temp313)) || (temp316)) || (temp321)) || (temp324)) || (temp327)) || (temp330)) || (temp333)) || (temp336)) || (temp339)) || (temp342)) || (temp345)) || (temp348)) || (temp351)) || (temp354)) || (temp357)) || (temp360)) || (temp363));
                            if (temp364)
                            {
                                var temp365 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp366 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp262));
                                var temp367 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp365))) + ((uint)(temp366))));
                                s._1 = ((uint)(temp367));
                                s._0 = ((ushort)((ushort)0U));
                                goto M26;
                            }
                            else
                                throw new Exception();
                        }
                        else
                            throw new Exception();
                    }
                }

                M28:
                {
                    if (++iIndex >= input.Length)
                        goto F28;
                    i = input[iIndex];
                    {
                        var temp368 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp369 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp368)));
                        var temp370 = ((int)((uint)(temp368)) <= (int)((uint)((uint)191U)));
                        var temp371 = ((temp369) && (temp370));
                        if (temp371)
                        {
                            var temp372 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp373 = Fun0(((ushort)((s)._0)), ((ushort)(temp372)));
                            s._0 = ((ushort)(temp373));
                            goto M27;
                        }
                        else
                            throw new Exception();
                    }
                }

                M29:
                {
                    if (++iIndex >= input.Length)
                        goto F29;
                    i = input[iIndex];
                    {
                        var temp374 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp375 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp374)));
                        var temp376 = ((int)((uint)(temp374)) <= (int)((uint)((uint)159U)));
                        var temp377 = ((temp375) && (temp376));
                        if (temp377)
                        {
                            var temp378 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp379 = Fun0(((ushort)((s)._0)), ((ushort)(temp378)));
                            s._0 = ((ushort)(temp379));
                            goto M27;
                        }
                        else
                            throw new Exception();
                    }
                }

                M30:
                {
                    if (++iIndex >= input.Length)
                        goto F30;
                    i = input[iIndex];
                    {
                        var temp380 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp381 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp380)));
                        var temp382 = ((int)((uint)(temp380)) <= (int)((uint)((uint)191U)));
                        var temp383 = ((temp381) && (temp382));
                        if (temp383)
                        {
                            var temp384 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp385 = Fun0(((ushort)((s)._0)), ((ushort)(temp384)));
                            s._0 = ((ushort)(temp385));
                            goto M27;
                        }
                        else
                            throw new Exception();
                    }
                }

                M31:
                {
                    if (++iIndex >= input.Length)
                        goto F31;
                    i = input[iIndex];
                    {
                        var temp386 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp387 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp386)));
                        var temp388 = ((int)((uint)(temp386)) <= (int)((uint)((uint)127U)));
                        var temp389 = ((temp387) && (temp388));
                        if (temp389)
                        {
                            var temp390 = (((byte)(i)) == ((byte)((byte)10U)));
                            if (temp390)
                            {
                                var temp391 = Fun1(((uint)((s)._1)), ((uint)((s)._2)));
                                s._2 = ((uint)(temp391));
                                s._1 = ((uint)((uint)0U));
                                goto M0;
                            }
                            else
                            {
                                goto M31;
                            }
                        }
                        else
                        {
                            var temp392 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp386)));
                            var temp393 = ((int)((uint)(temp386)) <= (int)((uint)((uint)223U)));
                            var temp394 = ((temp392) && (temp393));
                            if (temp394)
                            {
                                var temp395 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp395));
                                goto M36;
                            }
                            else
                            {
                                var temp396 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp396)
                                {
                                    var temp397 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp397));
                                    goto M37;
                                }
                                else
                                {
                                    var temp398 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp398)
                                    {
                                        var temp399 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp399));
                                        goto M38;
                                    }
                                    else
                                    {
                                        var temp400 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp386)));
                                        var temp401 = ((int)((uint)(temp386)) <= (int)((uint)((uint)239U)));
                                        var temp402 = ((temp400) && (temp401));
                                        if (temp402)
                                        {
                                            var temp403 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp403));
                                            goto M39;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M32:
                {
                    if (++iIndex >= input.Length)
                        goto F32;
                    i = input[iIndex];
                    {
                        var temp404 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp405 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp404)));
                        var temp406 = ((int)((uint)(temp404)) <= (int)((uint)((uint)191U)));
                        var temp407 = ((temp405) && (temp406));
                        if (temp407)
                        {
                            var temp408 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp409 = Fun0(((ushort)((s)._0)), ((ushort)(temp408)));
                            var temp410 = (((ushort)((ushort)48U)) <= ((ushort)(temp409)));
                            var temp411 = ((ushort)(((ushort)(temp409)) >> 6));
                            var temp412 = (((ushort)(temp411 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp413 = (((byte)(((byte)((ushort)(temp409))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp414 = (((temp410) && (temp412)) && (temp413));
                            var temp415 = (((ushort)((ushort)1632U)) <= ((ushort)(temp409)));
                            var temp416 = ((byte)(((ushort)(temp409)) >> 11));
                            var temp417 = (((byte)(temp416 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp418 = (((ushort)(((ushort)((ushort)(temp409))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp419 = (((temp415) && (temp417)) && (temp418));
                            var temp420 = (((ushort)((ushort)1776U)) <= ((ushort)(temp409)));
                            var temp421 = (((ushort)(((ushort)((ushort)(temp409))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp422 = (((temp420) && (temp417)) && (temp421));
                            var temp423 = (((ushort)((ushort)1984U)) <= ((ushort)(temp409)));
                            var temp424 = (((ushort)(((ushort)((ushort)(temp409))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp425 = (((temp423) && (temp417)) && (temp424));
                            var temp426 = (((ushort)((ushort)2406U)) <= ((ushort)(temp409)));
                            var temp427 = ((byte)(((ushort)(temp409)) >> 12));
                            var temp428 = (((byte)(temp427 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp429 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp430 = (((temp426) && (temp428)) && (temp429));
                            var temp431 = (((ushort)((ushort)2534U)) <= ((ushort)(temp409)));
                            var temp432 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp433 = (((temp431) && (temp428)) && (temp432));
                            var temp434 = (((ushort)((ushort)2662U)) <= ((ushort)(temp409)));
                            var temp435 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp436 = (((temp434) && (temp428)) && (temp435));
                            var temp437 = (((ushort)((ushort)2790U)) <= ((ushort)(temp409)));
                            var temp438 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp439 = (((temp437) && (temp428)) && (temp438));
                            var temp440 = (((ushort)((ushort)2918U)) <= ((ushort)(temp409)));
                            var temp441 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp442 = (((temp440) && (temp428)) && (temp441));
                            var temp443 = (((ushort)((ushort)3046U)) <= ((ushort)(temp409)));
                            var temp444 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp445 = (((temp443) && (temp428)) && (temp444));
                            var temp446 = (((ushort)((ushort)3174U)) <= ((ushort)(temp409)));
                            var temp447 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp448 = (((temp446) && (temp428)) && (temp447));
                            var temp449 = (((ushort)((ushort)3302U)) <= ((ushort)(temp409)));
                            var temp450 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp451 = (((temp449) && (temp428)) && (temp450));
                            var temp452 = (((ushort)((ushort)3430U)) <= ((ushort)(temp409)));
                            var temp453 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp454 = (((temp452) && (temp428)) && (temp453));
                            var temp455 = (((ushort)((ushort)3664U)) <= ((ushort)(temp409)));
                            var temp456 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp457 = (((temp455) && (temp428)) && (temp456));
                            var temp458 = (((ushort)((ushort)3792U)) <= ((ushort)(temp409)));
                            var temp459 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp460 = (((temp458) && (temp428)) && (temp459));
                            var temp461 = (((ushort)((ushort)3872U)) <= ((ushort)(temp409)));
                            var temp462 = (((ushort)(((ushort)((ushort)(temp409))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp463 = (((temp461) && (temp428)) && (temp462));
                            var temp464 = (((ushort)((ushort)4160U)) <= ((ushort)(temp409)));
                            var temp465 = ((byte)(((ushort)(temp409)) >> 13));
                            var temp466 = (((byte)(temp465 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp467 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp468 = (((temp464) && (temp466)) && (temp467));
                            var temp469 = (((ushort)((ushort)4240U)) <= ((ushort)(temp409)));
                            var temp470 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp471 = (((temp469) && (temp466)) && (temp470));
                            var temp472 = (((ushort)((ushort)6112U)) <= ((ushort)(temp409)));
                            var temp473 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp474 = (((temp472) && (temp466)) && (temp473));
                            var temp475 = (((ushort)((ushort)6160U)) <= ((ushort)(temp409)));
                            var temp476 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp477 = (((temp475) && (temp466)) && (temp476));
                            var temp478 = (((ushort)((ushort)6470U)) <= ((ushort)(temp409)));
                            var temp479 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp480 = (((temp478) && (temp466)) && (temp479));
                            var temp481 = (((ushort)((ushort)6608U)) <= ((ushort)(temp409)));
                            var temp482 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp483 = (((temp481) && (temp466)) && (temp482));
                            var temp484 = (((ushort)((ushort)6992U)) <= ((ushort)(temp409)));
                            var temp485 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp486 = (((temp484) && (temp466)) && (temp485));
                            var temp487 = (((ushort)((ushort)7088U)) <= ((ushort)(temp409)));
                            var temp488 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp489 = (((temp487) && (temp466)) && (temp488));
                            var temp490 = (((ushort)((ushort)7232U)) <= ((ushort)(temp409)));
                            var temp491 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp492 = (((temp490) && (temp466)) && (temp491));
                            var temp493 = (((ushort)((ushort)7248U)) <= ((ushort)(temp409)));
                            var temp494 = (((ushort)(((ushort)((ushort)(temp409))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp495 = (((temp493) && (temp466)) && (temp494));
                            var temp496 = (((ushort)((ushort)42528U)) <= ((ushort)(temp409)));
                            var temp497 = (((ushort)(temp409)) <= ((ushort)((ushort)42537U)));
                            var temp498 = ((temp496) && (temp497));
                            var temp499 = (((ushort)((ushort)43216U)) <= ((ushort)(temp409)));
                            var temp500 = (((ushort)(temp409)) <= ((ushort)((ushort)43225U)));
                            var temp501 = ((temp499) && (temp500));
                            var temp502 = (((ushort)((ushort)43264U)) <= ((ushort)(temp409)));
                            var temp503 = (((ushort)(temp409)) <= ((ushort)((ushort)43273U)));
                            var temp504 = ((temp502) && (temp503));
                            var temp505 = (((ushort)((ushort)43600U)) <= ((ushort)(temp409)));
                            var temp506 = (((ushort)(temp409)) <= ((ushort)((ushort)43609U)));
                            var temp507 = ((temp505) && (temp506));
                            var temp508 = (((ushort)((ushort)65296U)) <= ((ushort)(temp409)));
                            var temp509 = (((ushort)(temp409)) <= ((ushort)((ushort)65305U)));
                            var temp510 = ((temp508) && (temp509));
                            var temp511 = (((((((((((((((((((((((((((((((temp414) || (temp419)) || (temp422)) || (temp425)) || (temp430)) || (temp433)) || (temp436)) || (temp439)) || (temp442)) || (temp445)) || (temp448)) || (temp451)) || (temp454)) || (temp457)) || (temp460)) || (temp463)) || (temp468)) || (temp471)) || (temp474)) || (temp477)) || (temp480)) || (temp483)) || (temp486)) || (temp489)) || (temp492)) || (temp495)) || (temp498)) || (temp501)) || (temp504)) || (temp507)) || (temp510));
                            if (temp511)
                            {
                                var temp512 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp513 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp409));
                                var temp514 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp512))) + ((uint)(temp513))));
                                s._1 = ((uint)(temp514));
                                s._0 = ((ushort)((ushort)0U));
                                goto M26;
                            }
                            else
                                throw new Exception();
                        }
                        else
                            throw new Exception();
                    }
                }

                M33:
                {
                    if (++iIndex >= input.Length)
                        goto F33;
                    i = input[iIndex];
                    {
                        var temp515 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp516 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp515)));
                        var temp517 = ((int)((uint)(temp515)) <= (int)((uint)((uint)191U)));
                        var temp518 = ((temp516) && (temp517));
                        if (temp518)
                        {
                            var temp519 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp520 = Fun0(((ushort)((s)._0)), ((ushort)(temp519)));
                            s._0 = ((ushort)(temp520));
                            goto M32;
                        }
                        else
                            throw new Exception();
                    }
                }

                M34:
                {
                    if (++iIndex >= input.Length)
                        goto F34;
                    i = input[iIndex];
                    {
                        var temp521 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp522 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp521)));
                        var temp523 = ((int)((uint)(temp521)) <= (int)((uint)((uint)159U)));
                        var temp524 = ((temp522) && (temp523));
                        if (temp524)
                        {
                            var temp525 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp526 = Fun0(((ushort)((s)._0)), ((ushort)(temp525)));
                            s._0 = ((ushort)(temp526));
                            goto M32;
                        }
                        else
                            throw new Exception();
                    }
                }

                M35:
                {
                    if (++iIndex >= input.Length)
                        goto F35;
                    i = input[iIndex];
                    {
                        var temp527 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp528 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp527)));
                        var temp529 = ((int)((uint)(temp527)) <= (int)((uint)((uint)191U)));
                        var temp530 = ((temp528) && (temp529));
                        if (temp530)
                        {
                            var temp531 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp532 = Fun0(((ushort)((s)._0)), ((ushort)(temp531)));
                            s._0 = ((ushort)(temp532));
                            goto M32;
                        }
                        else
                            throw new Exception();
                    }
                }

                M36:
                {
                    if (++iIndex >= input.Length)
                        goto F36;
                    i = input[iIndex];
                    {
                        var temp533 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp534 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp533)));
                        var temp535 = ((int)((uint)(temp533)) <= (int)((uint)((uint)191U)));
                        var temp536 = ((temp534) && (temp535));
                        if (temp536)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M31;
                        }
                        else
                            throw new Exception();
                    }
                }

                M37:
                {
                    if (++iIndex >= input.Length)
                        goto F37;
                    i = input[iIndex];
                    {
                        var temp537 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp538 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp537)));
                        var temp539 = ((int)((uint)(temp537)) <= (int)((uint)((uint)191U)));
                        var temp540 = ((temp538) && (temp539));
                        if (temp540)
                        {
                            var temp541 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp542 = Fun0(((ushort)((s)._0)), ((ushort)(temp541)));
                            s._0 = ((ushort)(temp542));
                            goto M36;
                        }
                        else
                            throw new Exception();
                    }
                }

                M38:
                {
                    if (++iIndex >= input.Length)
                        goto F38;
                    i = input[iIndex];
                    {
                        var temp543 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp544 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp543)));
                        var temp545 = ((int)((uint)(temp543)) <= (int)((uint)((uint)159U)));
                        var temp546 = ((temp544) && (temp545));
                        if (temp546)
                        {
                            var temp547 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp548 = Fun0(((ushort)((s)._0)), ((ushort)(temp547)));
                            s._0 = ((ushort)(temp548));
                            goto M36;
                        }
                        else
                            throw new Exception();
                    }
                }

                M39:
                {
                    if (++iIndex >= input.Length)
                        goto F39;
                    i = input[iIndex];
                    {
                        var temp549 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp550 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp549)));
                        var temp551 = ((int)((uint)(temp549)) <= (int)((uint)((uint)191U)));
                        var temp552 = ((temp550) && (temp551));
                        if (temp552)
                        {
                            var temp553 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp554 = Fun0(((ushort)((s)._0)), ((ushort)(temp553)));
                            s._0 = ((ushort)(temp554));
                            goto M36;
                        }
                        else
                            throw new Exception();
                    }
                }

                F0:
                {
                    if (oIndex > 16380)
                    {
                        output.Write(oBuf, 0, oIndex);
                        oIndex = 0;
                    }

                    var temp0 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp0))));
                    var temp1 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp1))));
                    var temp2 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp2))));
                    oBuf[oIndex + 3] = (Byte)(((byte)((uint)((s)._2))));
                    oIndex += 4;
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F1:
                    throw new Exception();
                F2:
                {
                    if (oIndex > 16380)
                    {
                        output.Write(oBuf, 0, oIndex);
                        oIndex = 0;
                    }

                    var temp37 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp37))));
                    var temp38 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp38))));
                    var temp39 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp39))));
                    oBuf[oIndex + 3] = (Byte)(((byte)((uint)((s)._2))));
                    oIndex += 4;
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F3:
                {
                    if (oIndex > 16380)
                    {
                        output.Write(oBuf, 0, oIndex);
                        oIndex = 0;
                    }

                    var temp44 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp44))));
                    var temp45 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp45))));
                    var temp46 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp46))));
                    oBuf[oIndex + 3] = (Byte)(((byte)((uint)((s)._2))));
                    oIndex += 4;
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F4:
                {
                    if (oIndex > 16380)
                    {
                        output.Write(oBuf, 0, oIndex);
                        oIndex = 0;
                    }

                    var temp53 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp53))));
                    var temp54 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp54))));
                    var temp55 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp55))));
                    oBuf[oIndex + 3] = (Byte)(((byte)((uint)((s)._2))));
                    oIndex += 4;
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F5:
                {
                    if (oIndex > 16380)
                    {
                        output.Write(oBuf, 0, oIndex);
                        oIndex = 0;
                    }

                    var temp62 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp62))));
                    var temp63 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp63))));
                    var temp64 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp64))));
                    oBuf[oIndex + 3] = (Byte)(((byte)((uint)((s)._2))));
                    oIndex += 4;
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F6:
                    throw new Exception();
                F7:
                    throw new Exception();
                F8:
                    throw new Exception();
                F9:
                    throw new Exception();
                F10:
                    throw new Exception();
                F11:
                    throw new Exception();
                F12:
                    throw new Exception();
                F13:
                    throw new Exception();
                F14:
                    throw new Exception();
                F15:
                    throw new Exception();
                F16:
                    throw new Exception();
                F17:
                    throw new Exception();
                F18:
                    throw new Exception();
                F19:
                    throw new Exception();
                F20:
                    throw new Exception();
                F21:
                    throw new Exception();
                F22:
                    throw new Exception();
                F23:
                    throw new Exception();
                F24:
                    throw new Exception();
                F25:
                    throw new Exception();
                F26:
                    throw new Exception();
                F27:
                    throw new Exception();
                F28:
                    throw new Exception();
                F29:
                    throw new Exception();
                F30:
                    throw new Exception();
                F31:
                    throw new Exception();
                F32:
                    throw new Exception();
                F33:
                    throw new Exception();
                F34:
                    throw new Exception();
                F35:
                    throw new Exception();
                F36:
                    throw new Exception();
                F37:
                    throw new Exception();
                F38:
                    throw new Exception();
                F39:
                    throw new Exception();
            }
        }
    }
}