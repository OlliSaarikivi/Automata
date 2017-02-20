using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class CSV7abc : Composition<CSV7ab, Int32ToBytes>
    {
        static UInt16 Fun0(UInt16 v0, UInt16 v1)
        {
            return (UInt16)(((ushort)((ushort)(((ushort)((ushort)(v0))) & 1023L)) << 6) | (ushort)((byte)(((byte)((ushort)(v1))) & 63L)));
        }

        static UInt32 Fun1(UInt32 v0, UInt32 v1)
        {
            return (UInt32)(((((int)((uint)(v1)) <= (int)((uint)(v0)))) ? ((uint)(v1)) : ((uint)(v0))));
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
                DTStruct0 s = new DTStruct0(((ushort)((ushort)0U)), ((uint)((uint)0U)), ((uint)((uint)2147483647U)));
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
                            var temp192 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp192)
                            {
                                goto M26;
                            }
                            else
                            {
                                goto M21;
                            }
                        }
                        else
                        {
                            var temp193 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp188)));
                            var temp194 = ((int)((uint)(temp188)) <= (int)((uint)((uint)223U)));
                            var temp195 = ((temp193) && (temp194));
                            if (temp195)
                            {
                                var temp196 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp196));
                                goto M27;
                            }
                            else
                            {
                                var temp197 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp197)
                                {
                                    var temp198 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp198));
                                    goto M28;
                                }
                                else
                                {
                                    var temp199 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp199)
                                    {
                                        var temp200 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp200));
                                        goto M29;
                                    }
                                    else
                                    {
                                        var temp201 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp188)));
                                        var temp202 = ((int)((uint)(temp188)) <= (int)((uint)((uint)239U)));
                                        var temp203 = ((temp201) && (temp202));
                                        if (temp203)
                                        {
                                            var temp204 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp204));
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
                        var temp205 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp206 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp205)));
                        var temp207 = ((int)((uint)(temp205)) <= (int)((uint)((uint)191U)));
                        var temp208 = ((temp206) && (temp207));
                        if (temp208)
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
                        var temp209 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp210 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp209)));
                        var temp211 = ((int)((uint)(temp209)) <= (int)((uint)((uint)191U)));
                        var temp212 = ((temp210) && (temp211));
                        if (temp212)
                        {
                            var temp213 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp214 = Fun0(((ushort)((s)._0)), ((ushort)(temp213)));
                            s._0 = ((ushort)(temp214));
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
                        var temp215 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp216 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp215)));
                        var temp217 = ((int)((uint)(temp215)) <= (int)((uint)((uint)159U)));
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

                M25:
                {
                    if (!ie.MoveNext())
                        goto F25;
                    i = ie.Current;
                    {
                        var temp221 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp222 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp221)));
                        var temp223 = ((int)((uint)(temp221)) <= (int)((uint)((uint)191U)));
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

                M26:
                {
                    if (!ie.MoveNext())
                        goto F26;
                    i = ie.Current;
                    {
                        var temp227 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp228 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp227)));
                        var temp229 = ((int)((uint)(temp227)) <= (int)((uint)((uint)127U)));
                        var temp230 = ((temp228) && (temp229));
                        if (temp230)
                        {
                            var temp231 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp231)
                            {
                                goto M31;
                            }
                            else
                            {
                                goto M26;
                            }
                        }
                        else
                        {
                            var temp232 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp227)));
                            var temp233 = ((int)((uint)(temp227)) <= (int)((uint)((uint)223U)));
                            var temp234 = ((temp232) && (temp233));
                            if (temp234)
                            {
                                var temp235 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp235));
                                goto M32;
                            }
                            else
                            {
                                var temp236 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp236)
                                {
                                    var temp237 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp237));
                                    goto M33;
                                }
                                else
                                {
                                    var temp238 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp238)
                                    {
                                        var temp239 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp239));
                                        goto M34;
                                    }
                                    else
                                    {
                                        var temp240 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp227)));
                                        var temp241 = ((int)((uint)(temp227)) <= (int)((uint)((uint)239U)));
                                        var temp242 = ((temp240) && (temp241));
                                        if (temp242)
                                        {
                                            var temp243 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp243));
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
                        var temp244 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp245 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp244)));
                        var temp246 = ((int)((uint)(temp244)) <= (int)((uint)((uint)191U)));
                        var temp247 = ((temp245) && (temp246));
                        if (temp247)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M21;
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
                        var temp248 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp249 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp248)));
                        var temp250 = ((int)((uint)(temp248)) <= (int)((uint)((uint)191U)));
                        var temp251 = ((temp249) && (temp250));
                        if (temp251)
                        {
                            var temp252 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp253 = Fun0(((ushort)((s)._0)), ((ushort)(temp252)));
                            s._0 = ((ushort)(temp253));
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
                        var temp254 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp255 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp254)));
                        var temp256 = ((int)((uint)(temp254)) <= (int)((uint)((uint)159U)));
                        var temp257 = ((temp255) && (temp256));
                        if (temp257)
                        {
                            var temp258 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp259 = Fun0(((ushort)((s)._0)), ((ushort)(temp258)));
                            s._0 = ((ushort)(temp259));
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
                        var temp260 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp261 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp260)));
                        var temp262 = ((int)((uint)(temp260)) <= (int)((uint)((uint)191U)));
                        var temp263 = ((temp261) && (temp262));
                        if (temp263)
                        {
                            var temp264 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp265 = Fun0(((ushort)((s)._0)), ((ushort)(temp264)));
                            s._0 = ((ushort)(temp265));
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
                        var temp266 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp267 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp266)));
                        var temp268 = ((int)((uint)(temp266)) <= (int)((uint)((uint)127U)));
                        var temp269 = ((temp267) && (temp268));
                        if (temp269)
                        {
                            var temp270 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp271 = ((byte)(((byte)(i)) >> 6));
                            var temp272 = (((byte)(temp271 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp273 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp274 = (((temp270) && (temp272)) && (temp273));
                            if (temp274)
                            {
                                var temp275 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp276 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp275))) + ((uint)(temp266))));
                                s._1 = ((uint)(temp276));
                                goto M36;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp277 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp266)));
                            var temp278 = ((int)((uint)(temp266)) <= (int)((uint)((uint)223U)));
                            var temp279 = ((temp277) && (temp278));
                            if (temp279)
                            {
                                var temp280 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp280));
                                goto M37;
                            }
                            else
                            {
                                var temp281 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp281)
                                {
                                    var temp282 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp282));
                                    goto M38;
                                }
                                else
                                {
                                    var temp283 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp283)
                                    {
                                        var temp284 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp284));
                                        goto M39;
                                    }
                                    else
                                    {
                                        var temp285 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp266)));
                                        var temp286 = ((int)((uint)(temp266)) <= (int)((uint)((uint)239U)));
                                        var temp287 = ((temp285) && (temp286));
                                        if (temp287)
                                        {
                                            var temp288 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp288));
                                            goto M40;
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
                        var temp289 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp290 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp289)));
                        var temp291 = ((int)((uint)(temp289)) <= (int)((uint)((uint)191U)));
                        var temp292 = ((temp290) && (temp291));
                        if (temp292)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M26;
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
                        var temp293 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp294 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp293)));
                        var temp295 = ((int)((uint)(temp293)) <= (int)((uint)((uint)191U)));
                        var temp296 = ((temp294) && (temp295));
                        if (temp296)
                        {
                            var temp297 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp298 = Fun0(((ushort)((s)._0)), ((ushort)(temp297)));
                            s._0 = ((ushort)(temp298));
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
                        var temp299 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp300 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp299)));
                        var temp301 = ((int)((uint)(temp299)) <= (int)((uint)((uint)159U)));
                        var temp302 = ((temp300) && (temp301));
                        if (temp302)
                        {
                            var temp303 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp304 = Fun0(((ushort)((s)._0)), ((ushort)(temp303)));
                            s._0 = ((ushort)(temp304));
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
                        var temp305 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp306 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp305)));
                        var temp307 = ((int)((uint)(temp305)) <= (int)((uint)((uint)191U)));
                        var temp308 = ((temp306) && (temp307));
                        if (temp308)
                        {
                            var temp309 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp310 = Fun0(((ushort)((s)._0)), ((ushort)(temp309)));
                            s._0 = ((ushort)(temp310));
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
                        var temp311 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp312 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp311)));
                        var temp313 = ((int)((uint)(temp311)) <= (int)((uint)((uint)127U)));
                        var temp314 = ((temp312) && (temp313));
                        if (temp314)
                        {
                            var temp315 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp315)
                            {
                                goto M41;
                            }
                            else
                            {
                                var temp316 = (((byte)(i)) == ((byte)((byte)46U)));
                                if (temp316)
                                {
                                    goto M42;
                                }
                                else
                                {
                                    var temp317 = (((byte)((byte)48U)) <= ((byte)(i)));
                                    var temp318 = ((byte)(((byte)(i)) >> 6));
                                    var temp319 = (((byte)(temp318 & 3L)) == ((byte)((byte)0U & 3L)));
                                    var temp320 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                    var temp321 = (((temp317) && (temp319)) && (temp320));
                                    if (temp321)
                                    {
                                        var temp322 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                        var temp323 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp322))) + ((uint)(temp311))));
                                        s._1 = ((uint)(temp323));
                                        goto M36;
                                    }
                                    else
                                        throw new Exception();
                                }
                            }
                        }
                        else
                        {
                            var temp324 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp311)));
                            var temp325 = ((int)((uint)(temp311)) <= (int)((uint)((uint)223U)));
                            var temp326 = ((temp324) && (temp325));
                            if (temp326)
                            {
                                var temp327 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp327));
                                goto M43;
                            }
                            else
                            {
                                var temp328 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp328)
                                {
                                    var temp329 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp329));
                                    goto M44;
                                }
                                else
                                {
                                    var temp330 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp330)
                                    {
                                        var temp331 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp331));
                                        goto M45;
                                    }
                                    else
                                    {
                                        var temp332 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp311)));
                                        var temp333 = ((int)((uint)(temp311)) <= (int)((uint)((uint)239U)));
                                        var temp334 = ((temp332) && (temp333));
                                        if (temp334)
                                        {
                                            var temp335 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp335));
                                            goto M46;
                                        }
                                        else
                                            throw new Exception();
                                    }
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
                        var temp336 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp337 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp336)));
                        var temp338 = ((int)((uint)(temp336)) <= (int)((uint)((uint)191U)));
                        var temp339 = ((temp337) && (temp338));
                        if (temp339)
                        {
                            var temp340 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp341 = Fun0(((ushort)((s)._0)), ((ushort)(temp340)));
                            var temp342 = (((ushort)((ushort)48U)) <= ((ushort)(temp341)));
                            var temp343 = ((ushort)(((ushort)(temp341)) >> 6));
                            var temp344 = (((ushort)(temp343 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp345 = (((byte)(((byte)((ushort)(temp341))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp346 = (((temp342) && (temp344)) && (temp345));
                            var temp347 = (((ushort)((ushort)1632U)) <= ((ushort)(temp341)));
                            var temp348 = ((byte)(((ushort)(temp341)) >> 11));
                            var temp349 = (((byte)(temp348 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp350 = (((ushort)(((ushort)((ushort)(temp341))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp351 = (((temp347) && (temp349)) && (temp350));
                            var temp352 = (((ushort)((ushort)1776U)) <= ((ushort)(temp341)));
                            var temp353 = (((ushort)(((ushort)((ushort)(temp341))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp354 = (((temp352) && (temp349)) && (temp353));
                            var temp355 = (((ushort)((ushort)1984U)) <= ((ushort)(temp341)));
                            var temp356 = (((ushort)(((ushort)((ushort)(temp341))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp357 = (((temp355) && (temp349)) && (temp356));
                            var temp358 = (((ushort)((ushort)2406U)) <= ((ushort)(temp341)));
                            var temp359 = ((byte)(((ushort)(temp341)) >> 12));
                            var temp360 = (((byte)(temp359 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp361 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp362 = (((temp358) && (temp360)) && (temp361));
                            var temp363 = (((ushort)((ushort)2534U)) <= ((ushort)(temp341)));
                            var temp364 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp365 = (((temp363) && (temp360)) && (temp364));
                            var temp366 = (((ushort)((ushort)2662U)) <= ((ushort)(temp341)));
                            var temp367 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp368 = (((temp366) && (temp360)) && (temp367));
                            var temp369 = (((ushort)((ushort)2790U)) <= ((ushort)(temp341)));
                            var temp370 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp371 = (((temp369) && (temp360)) && (temp370));
                            var temp372 = (((ushort)((ushort)2918U)) <= ((ushort)(temp341)));
                            var temp373 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp374 = (((temp372) && (temp360)) && (temp373));
                            var temp375 = (((ushort)((ushort)3046U)) <= ((ushort)(temp341)));
                            var temp376 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp377 = (((temp375) && (temp360)) && (temp376));
                            var temp378 = (((ushort)((ushort)3174U)) <= ((ushort)(temp341)));
                            var temp379 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp380 = (((temp378) && (temp360)) && (temp379));
                            var temp381 = (((ushort)((ushort)3302U)) <= ((ushort)(temp341)));
                            var temp382 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp383 = (((temp381) && (temp360)) && (temp382));
                            var temp384 = (((ushort)((ushort)3430U)) <= ((ushort)(temp341)));
                            var temp385 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp386 = (((temp384) && (temp360)) && (temp385));
                            var temp387 = (((ushort)((ushort)3664U)) <= ((ushort)(temp341)));
                            var temp388 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp389 = (((temp387) && (temp360)) && (temp388));
                            var temp390 = (((ushort)((ushort)3792U)) <= ((ushort)(temp341)));
                            var temp391 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp392 = (((temp390) && (temp360)) && (temp391));
                            var temp393 = (((ushort)((ushort)3872U)) <= ((ushort)(temp341)));
                            var temp394 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp395 = (((temp393) && (temp360)) && (temp394));
                            var temp396 = (((ushort)((ushort)4160U)) <= ((ushort)(temp341)));
                            var temp397 = ((byte)(((ushort)(temp341)) >> 13));
                            var temp398 = (((byte)(temp397 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp399 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp400 = (((temp396) && (temp398)) && (temp399));
                            var temp401 = (((ushort)((ushort)4240U)) <= ((ushort)(temp341)));
                            var temp402 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp403 = (((temp401) && (temp398)) && (temp402));
                            var temp404 = (((ushort)((ushort)6112U)) <= ((ushort)(temp341)));
                            var temp405 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp406 = (((temp404) && (temp398)) && (temp405));
                            var temp407 = (((ushort)((ushort)6160U)) <= ((ushort)(temp341)));
                            var temp408 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp409 = (((temp407) && (temp398)) && (temp408));
                            var temp410 = (((ushort)((ushort)6470U)) <= ((ushort)(temp341)));
                            var temp411 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp412 = (((temp410) && (temp398)) && (temp411));
                            var temp413 = (((ushort)((ushort)6608U)) <= ((ushort)(temp341)));
                            var temp414 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp415 = (((temp413) && (temp398)) && (temp414));
                            var temp416 = (((ushort)((ushort)6992U)) <= ((ushort)(temp341)));
                            var temp417 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp418 = (((temp416) && (temp398)) && (temp417));
                            var temp419 = (((ushort)((ushort)7088U)) <= ((ushort)(temp341)));
                            var temp420 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp421 = (((temp419) && (temp398)) && (temp420));
                            var temp422 = (((ushort)((ushort)7232U)) <= ((ushort)(temp341)));
                            var temp423 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp424 = (((temp422) && (temp398)) && (temp423));
                            var temp425 = (((ushort)((ushort)7248U)) <= ((ushort)(temp341)));
                            var temp426 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp427 = (((temp425) && (temp398)) && (temp426));
                            var temp428 = (((ushort)((ushort)42528U)) <= ((ushort)(temp341)));
                            var temp429 = (((ushort)(temp341)) <= ((ushort)((ushort)42537U)));
                            var temp430 = ((temp428) && (temp429));
                            var temp431 = (((ushort)((ushort)43216U)) <= ((ushort)(temp341)));
                            var temp432 = (((ushort)(temp341)) <= ((ushort)((ushort)43225U)));
                            var temp433 = ((temp431) && (temp432));
                            var temp434 = (((ushort)((ushort)43264U)) <= ((ushort)(temp341)));
                            var temp435 = (((ushort)(temp341)) <= ((ushort)((ushort)43273U)));
                            var temp436 = ((temp434) && (temp435));
                            var temp437 = (((ushort)((ushort)43600U)) <= ((ushort)(temp341)));
                            var temp438 = (((ushort)(temp341)) <= ((ushort)((ushort)43609U)));
                            var temp439 = ((temp437) && (temp438));
                            var temp440 = (((ushort)((ushort)65296U)) <= ((ushort)(temp341)));
                            var temp441 = (((ushort)(temp341)) <= ((ushort)((ushort)65305U)));
                            var temp442 = ((temp440) && (temp441));
                            var temp443 = (((((((((((((((((((((((((((((((temp346) || (temp351)) || (temp354)) || (temp357)) || (temp362)) || (temp365)) || (temp368)) || (temp371)) || (temp374)) || (temp377)) || (temp380)) || (temp383)) || (temp386)) || (temp389)) || (temp392)) || (temp395)) || (temp400)) || (temp403)) || (temp406)) || (temp409)) || (temp412)) || (temp415)) || (temp418)) || (temp421)) || (temp424)) || (temp427)) || (temp430)) || (temp433)) || (temp436)) || (temp439)) || (temp442));
                            if (temp443)
                            {
                                var temp444 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp445 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp341));
                                var temp446 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp444))) + ((uint)(temp445))));
                                s._1 = ((uint)(temp446));
                                s._0 = ((ushort)((ushort)0U));
                                goto M36;
                            }
                            else
                                throw new Exception();
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
                        var temp447 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp448 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp447)));
                        var temp449 = ((int)((uint)(temp447)) <= (int)((uint)((uint)191U)));
                        var temp450 = ((temp448) && (temp449));
                        if (temp450)
                        {
                            var temp451 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp452 = Fun0(((ushort)((s)._0)), ((ushort)(temp451)));
                            s._0 = ((ushort)(temp452));
                            goto M37;
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
                        var temp453 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp454 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp453)));
                        var temp455 = ((int)((uint)(temp453)) <= (int)((uint)((uint)159U)));
                        var temp456 = ((temp454) && (temp455));
                        if (temp456)
                        {
                            var temp457 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp458 = Fun0(((ushort)((s)._0)), ((ushort)(temp457)));
                            s._0 = ((ushort)(temp458));
                            goto M37;
                        }
                        else
                            throw new Exception();
                    }
                }

                M40:
                {
                    if (!ie.MoveNext())
                        goto F40;
                    i = ie.Current;
                    {
                        var temp459 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp460 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp459)));
                        var temp461 = ((int)((uint)(temp459)) <= (int)((uint)((uint)191U)));
                        var temp462 = ((temp460) && (temp461));
                        if (temp462)
                        {
                            var temp463 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp464 = Fun0(((ushort)((s)._0)), ((ushort)(temp463)));
                            s._0 = ((ushort)(temp464));
                            goto M37;
                        }
                        else
                            throw new Exception();
                    }
                }

                M41:
                {
                    if (!ie.MoveNext())
                        goto F41;
                    i = ie.Current;
                    {
                        var temp465 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp466 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp465)));
                        var temp467 = ((int)((uint)(temp465)) <= (int)((uint)((uint)127U)));
                        var temp468 = ((temp466) && (temp467));
                        if (temp468)
                        {
                            var temp469 = (((byte)(i)) == ((byte)((byte)10U)));
                            if (temp469)
                            {
                                var temp470 = Fun1(((uint)((s)._1)), ((uint)((s)._2)));
                                s._2 = ((uint)(temp470));
                                s._1 = ((uint)((uint)0U));
                                goto M0;
                            }
                            else
                            {
                                goto M41;
                            }
                        }
                        else
                        {
                            var temp471 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp465)));
                            var temp472 = ((int)((uint)(temp465)) <= (int)((uint)((uint)223U)));
                            var temp473 = ((temp471) && (temp472));
                            if (temp473)
                            {
                                var temp474 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp474));
                                goto M56;
                            }
                            else
                            {
                                var temp475 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp475)
                                {
                                    var temp476 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp476));
                                    goto M57;
                                }
                                else
                                {
                                    var temp477 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp477)
                                    {
                                        var temp478 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp478));
                                        goto M58;
                                    }
                                    else
                                    {
                                        var temp479 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp465)));
                                        var temp480 = ((int)((uint)(temp465)) <= (int)((uint)((uint)239U)));
                                        var temp481 = ((temp479) && (temp480));
                                        if (temp481)
                                        {
                                            var temp482 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp482));
                                            goto M59;
                                        }
                                        else
                                            throw new Exception();
                                    }
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
                        var temp483 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp484 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp483)));
                        var temp485 = ((int)((uint)(temp483)) <= (int)((uint)((uint)127U)));
                        var temp486 = ((temp484) && (temp485));
                        if (temp486)
                        {
                            var temp487 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp488 = ((byte)(((byte)(i)) >> 6));
                            var temp489 = (((byte)(temp488 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp490 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp491 = (((temp487) && (temp489)) && (temp490));
                            if (temp491)
                            {
                                goto M47;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp492 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp483)));
                            var temp493 = ((int)((uint)(temp483)) <= (int)((uint)((uint)223U)));
                            var temp494 = ((temp492) && (temp493));
                            if (temp494)
                            {
                                var temp495 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp495));
                                goto M48;
                            }
                            else
                            {
                                var temp496 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp496)
                                {
                                    var temp497 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp497));
                                    goto M49;
                                }
                                else
                                {
                                    var temp498 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp498)
                                    {
                                        var temp499 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp499));
                                        goto M50;
                                    }
                                    else
                                    {
                                        var temp500 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp483)));
                                        var temp501 = ((int)((uint)(temp483)) <= (int)((uint)((uint)239U)));
                                        var temp502 = ((temp500) && (temp501));
                                        if (temp502)
                                        {
                                            var temp503 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp503));
                                            goto M51;
                                        }
                                        else
                                            throw new Exception();
                                    }
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
                        var temp504 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp505 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp504)));
                        var temp506 = ((int)((uint)(temp504)) <= (int)((uint)((uint)191U)));
                        var temp507 = ((temp505) && (temp506));
                        if (temp507)
                        {
                            var temp508 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp509 = Fun0(((ushort)((s)._0)), ((ushort)(temp508)));
                            var temp510 = (((ushort)((ushort)48U)) <= ((ushort)(temp509)));
                            var temp511 = ((ushort)(((ushort)(temp509)) >> 6));
                            var temp512 = (((ushort)(temp511 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp513 = (((byte)(((byte)((ushort)(temp509))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp514 = (((temp510) && (temp512)) && (temp513));
                            var temp515 = (((ushort)((ushort)1632U)) <= ((ushort)(temp509)));
                            var temp516 = ((byte)(((ushort)(temp509)) >> 11));
                            var temp517 = (((byte)(temp516 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp518 = (((ushort)(((ushort)((ushort)(temp509))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp519 = (((temp515) && (temp517)) && (temp518));
                            var temp520 = (((ushort)((ushort)1776U)) <= ((ushort)(temp509)));
                            var temp521 = (((ushort)(((ushort)((ushort)(temp509))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp522 = (((temp520) && (temp517)) && (temp521));
                            var temp523 = (((ushort)((ushort)1984U)) <= ((ushort)(temp509)));
                            var temp524 = (((ushort)(((ushort)((ushort)(temp509))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp525 = (((temp523) && (temp517)) && (temp524));
                            var temp526 = (((ushort)((ushort)2406U)) <= ((ushort)(temp509)));
                            var temp527 = ((byte)(((ushort)(temp509)) >> 12));
                            var temp528 = (((byte)(temp527 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp529 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp530 = (((temp526) && (temp528)) && (temp529));
                            var temp531 = (((ushort)((ushort)2534U)) <= ((ushort)(temp509)));
                            var temp532 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp533 = (((temp531) && (temp528)) && (temp532));
                            var temp534 = (((ushort)((ushort)2662U)) <= ((ushort)(temp509)));
                            var temp535 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp536 = (((temp534) && (temp528)) && (temp535));
                            var temp537 = (((ushort)((ushort)2790U)) <= ((ushort)(temp509)));
                            var temp538 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp539 = (((temp537) && (temp528)) && (temp538));
                            var temp540 = (((ushort)((ushort)2918U)) <= ((ushort)(temp509)));
                            var temp541 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp542 = (((temp540) && (temp528)) && (temp541));
                            var temp543 = (((ushort)((ushort)3046U)) <= ((ushort)(temp509)));
                            var temp544 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp545 = (((temp543) && (temp528)) && (temp544));
                            var temp546 = (((ushort)((ushort)3174U)) <= ((ushort)(temp509)));
                            var temp547 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp548 = (((temp546) && (temp528)) && (temp547));
                            var temp549 = (((ushort)((ushort)3302U)) <= ((ushort)(temp509)));
                            var temp550 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp551 = (((temp549) && (temp528)) && (temp550));
                            var temp552 = (((ushort)((ushort)3430U)) <= ((ushort)(temp509)));
                            var temp553 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp554 = (((temp552) && (temp528)) && (temp553));
                            var temp555 = (((ushort)((ushort)3664U)) <= ((ushort)(temp509)));
                            var temp556 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp557 = (((temp555) && (temp528)) && (temp556));
                            var temp558 = (((ushort)((ushort)3792U)) <= ((ushort)(temp509)));
                            var temp559 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp560 = (((temp558) && (temp528)) && (temp559));
                            var temp561 = (((ushort)((ushort)3872U)) <= ((ushort)(temp509)));
                            var temp562 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp563 = (((temp561) && (temp528)) && (temp562));
                            var temp564 = (((ushort)((ushort)4160U)) <= ((ushort)(temp509)));
                            var temp565 = ((byte)(((ushort)(temp509)) >> 13));
                            var temp566 = (((byte)(temp565 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp567 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp568 = (((temp564) && (temp566)) && (temp567));
                            var temp569 = (((ushort)((ushort)4240U)) <= ((ushort)(temp509)));
                            var temp570 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp571 = (((temp569) && (temp566)) && (temp570));
                            var temp572 = (((ushort)((ushort)6112U)) <= ((ushort)(temp509)));
                            var temp573 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp574 = (((temp572) && (temp566)) && (temp573));
                            var temp575 = (((ushort)((ushort)6160U)) <= ((ushort)(temp509)));
                            var temp576 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp577 = (((temp575) && (temp566)) && (temp576));
                            var temp578 = (((ushort)((ushort)6470U)) <= ((ushort)(temp509)));
                            var temp579 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp580 = (((temp578) && (temp566)) && (temp579));
                            var temp581 = (((ushort)((ushort)6608U)) <= ((ushort)(temp509)));
                            var temp582 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp583 = (((temp581) && (temp566)) && (temp582));
                            var temp584 = (((ushort)((ushort)6992U)) <= ((ushort)(temp509)));
                            var temp585 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp586 = (((temp584) && (temp566)) && (temp585));
                            var temp587 = (((ushort)((ushort)7088U)) <= ((ushort)(temp509)));
                            var temp588 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp589 = (((temp587) && (temp566)) && (temp588));
                            var temp590 = (((ushort)((ushort)7232U)) <= ((ushort)(temp509)));
                            var temp591 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp592 = (((temp590) && (temp566)) && (temp591));
                            var temp593 = (((ushort)((ushort)7248U)) <= ((ushort)(temp509)));
                            var temp594 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp595 = (((temp593) && (temp566)) && (temp594));
                            var temp596 = (((ushort)((ushort)42528U)) <= ((ushort)(temp509)));
                            var temp597 = (((ushort)(temp509)) <= ((ushort)((ushort)42537U)));
                            var temp598 = ((temp596) && (temp597));
                            var temp599 = (((ushort)((ushort)43216U)) <= ((ushort)(temp509)));
                            var temp600 = (((ushort)(temp509)) <= ((ushort)((ushort)43225U)));
                            var temp601 = ((temp599) && (temp600));
                            var temp602 = (((ushort)((ushort)43264U)) <= ((ushort)(temp509)));
                            var temp603 = (((ushort)(temp509)) <= ((ushort)((ushort)43273U)));
                            var temp604 = ((temp602) && (temp603));
                            var temp605 = (((ushort)((ushort)43600U)) <= ((ushort)(temp509)));
                            var temp606 = (((ushort)(temp509)) <= ((ushort)((ushort)43609U)));
                            var temp607 = ((temp605) && (temp606));
                            var temp608 = (((ushort)((ushort)65296U)) <= ((ushort)(temp509)));
                            var temp609 = (((ushort)(temp509)) <= ((ushort)((ushort)65305U)));
                            var temp610 = ((temp608) && (temp609));
                            var temp611 = (((((((((((((((((((((((((((((((temp514) || (temp519)) || (temp522)) || (temp525)) || (temp530)) || (temp533)) || (temp536)) || (temp539)) || (temp542)) || (temp545)) || (temp548)) || (temp551)) || (temp554)) || (temp557)) || (temp560)) || (temp563)) || (temp568)) || (temp571)) || (temp574)) || (temp577)) || (temp580)) || (temp583)) || (temp586)) || (temp589)) || (temp592)) || (temp595)) || (temp598)) || (temp601)) || (temp604)) || (temp607)) || (temp610));
                            if (temp611)
                            {
                                var temp612 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp613 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp509));
                                var temp614 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp612))) + ((uint)(temp613))));
                                s._1 = ((uint)(temp614));
                                s._0 = ((ushort)((ushort)0U));
                                goto M36;
                            }
                            else
                                throw new Exception();
                        }
                        else
                            throw new Exception();
                    }
                }

                M44:
                {
                    if (!ie.MoveNext())
                        goto F44;
                    i = ie.Current;
                    {
                        var temp615 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp616 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp615)));
                        var temp617 = ((int)((uint)(temp615)) <= (int)((uint)((uint)191U)));
                        var temp618 = ((temp616) && (temp617));
                        if (temp618)
                        {
                            var temp619 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp620 = Fun0(((ushort)((s)._0)), ((ushort)(temp619)));
                            s._0 = ((ushort)(temp620));
                            goto M43;
                        }
                        else
                            throw new Exception();
                    }
                }

                M45:
                {
                    if (!ie.MoveNext())
                        goto F45;
                    i = ie.Current;
                    {
                        var temp621 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp622 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp621)));
                        var temp623 = ((int)((uint)(temp621)) <= (int)((uint)((uint)159U)));
                        var temp624 = ((temp622) && (temp623));
                        if (temp624)
                        {
                            var temp625 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp626 = Fun0(((ushort)((s)._0)), ((ushort)(temp625)));
                            s._0 = ((ushort)(temp626));
                            goto M43;
                        }
                        else
                            throw new Exception();
                    }
                }

                M46:
                {
                    if (!ie.MoveNext())
                        goto F46;
                    i = ie.Current;
                    {
                        var temp627 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp628 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp627)));
                        var temp629 = ((int)((uint)(temp627)) <= (int)((uint)((uint)191U)));
                        var temp630 = ((temp628) && (temp629));
                        if (temp630)
                        {
                            var temp631 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp632 = Fun0(((ushort)((s)._0)), ((ushort)(temp631)));
                            s._0 = ((ushort)(temp632));
                            goto M43;
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
                        var temp633 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp634 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp633)));
                        var temp635 = ((int)((uint)(temp633)) <= (int)((uint)((uint)127U)));
                        var temp636 = ((temp634) && (temp635));
                        if (temp636)
                        {
                            var temp637 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp637)
                            {
                                goto M41;
                            }
                            else
                            {
                                var temp638 = (((byte)((byte)48U)) <= ((byte)(i)));
                                var temp639 = ((byte)(((byte)(i)) >> 6));
                                var temp640 = (((byte)(temp639 & 3L)) == ((byte)((byte)0U & 3L)));
                                var temp641 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp642 = (((temp638) && (temp640)) && (temp641));
                                if (temp642)
                                {
                                    goto M47;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                        else
                        {
                            var temp643 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp633)));
                            var temp644 = ((int)((uint)(temp633)) <= (int)((uint)((uint)223U)));
                            var temp645 = ((temp643) && (temp644));
                            if (temp645)
                            {
                                var temp646 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp646));
                                goto M52;
                            }
                            else
                            {
                                var temp647 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp647)
                                {
                                    var temp648 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp648));
                                    goto M53;
                                }
                                else
                                {
                                    var temp649 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp649)
                                    {
                                        var temp650 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp650));
                                        goto M54;
                                    }
                                    else
                                    {
                                        var temp651 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp633)));
                                        var temp652 = ((int)((uint)(temp633)) <= (int)((uint)((uint)239U)));
                                        var temp653 = ((temp651) && (temp652));
                                        if (temp653)
                                        {
                                            var temp654 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp654));
                                            goto M55;
                                        }
                                        else
                                            throw new Exception();
                                    }
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
                        var temp655 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp656 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp655)));
                        var temp657 = ((int)((uint)(temp655)) <= (int)((uint)((uint)191U)));
                        var temp658 = ((temp656) && (temp657));
                        if (temp658)
                        {
                            var temp659 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp660 = Fun0(((ushort)((s)._0)), ((ushort)(temp659)));
                            var temp661 = (((ushort)((ushort)48U)) <= ((ushort)(temp660)));
                            var temp662 = ((ushort)(((ushort)(temp660)) >> 6));
                            var temp663 = (((ushort)(temp662 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp664 = (((byte)(((byte)((ushort)(temp660))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp665 = (((temp661) && (temp663)) && (temp664));
                            var temp666 = (((ushort)((ushort)1632U)) <= ((ushort)(temp660)));
                            var temp667 = ((byte)(((ushort)(temp660)) >> 11));
                            var temp668 = (((byte)(temp667 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp669 = (((ushort)(((ushort)((ushort)(temp660))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp670 = (((temp666) && (temp668)) && (temp669));
                            var temp671 = (((ushort)((ushort)1776U)) <= ((ushort)(temp660)));
                            var temp672 = (((ushort)(((ushort)((ushort)(temp660))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp673 = (((temp671) && (temp668)) && (temp672));
                            var temp674 = (((ushort)((ushort)1984U)) <= ((ushort)(temp660)));
                            var temp675 = (((ushort)(((ushort)((ushort)(temp660))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp676 = (((temp674) && (temp668)) && (temp675));
                            var temp677 = (((ushort)((ushort)2406U)) <= ((ushort)(temp660)));
                            var temp678 = ((byte)(((ushort)(temp660)) >> 12));
                            var temp679 = (((byte)(temp678 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp680 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp681 = (((temp677) && (temp679)) && (temp680));
                            var temp682 = (((ushort)((ushort)2534U)) <= ((ushort)(temp660)));
                            var temp683 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp684 = (((temp682) && (temp679)) && (temp683));
                            var temp685 = (((ushort)((ushort)2662U)) <= ((ushort)(temp660)));
                            var temp686 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp687 = (((temp685) && (temp679)) && (temp686));
                            var temp688 = (((ushort)((ushort)2790U)) <= ((ushort)(temp660)));
                            var temp689 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp690 = (((temp688) && (temp679)) && (temp689));
                            var temp691 = (((ushort)((ushort)2918U)) <= ((ushort)(temp660)));
                            var temp692 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp693 = (((temp691) && (temp679)) && (temp692));
                            var temp694 = (((ushort)((ushort)3046U)) <= ((ushort)(temp660)));
                            var temp695 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp696 = (((temp694) && (temp679)) && (temp695));
                            var temp697 = (((ushort)((ushort)3174U)) <= ((ushort)(temp660)));
                            var temp698 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp699 = (((temp697) && (temp679)) && (temp698));
                            var temp700 = (((ushort)((ushort)3302U)) <= ((ushort)(temp660)));
                            var temp701 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp702 = (((temp700) && (temp679)) && (temp701));
                            var temp703 = (((ushort)((ushort)3430U)) <= ((ushort)(temp660)));
                            var temp704 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp705 = (((temp703) && (temp679)) && (temp704));
                            var temp706 = (((ushort)((ushort)3664U)) <= ((ushort)(temp660)));
                            var temp707 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp708 = (((temp706) && (temp679)) && (temp707));
                            var temp709 = (((ushort)((ushort)3792U)) <= ((ushort)(temp660)));
                            var temp710 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp711 = (((temp709) && (temp679)) && (temp710));
                            var temp712 = (((ushort)((ushort)3872U)) <= ((ushort)(temp660)));
                            var temp713 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp714 = (((temp712) && (temp679)) && (temp713));
                            var temp715 = (((ushort)((ushort)4160U)) <= ((ushort)(temp660)));
                            var temp716 = ((byte)(((ushort)(temp660)) >> 13));
                            var temp717 = (((byte)(temp716 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp718 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp719 = (((temp715) && (temp717)) && (temp718));
                            var temp720 = (((ushort)((ushort)4240U)) <= ((ushort)(temp660)));
                            var temp721 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp722 = (((temp720) && (temp717)) && (temp721));
                            var temp723 = (((ushort)((ushort)6112U)) <= ((ushort)(temp660)));
                            var temp724 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp725 = (((temp723) && (temp717)) && (temp724));
                            var temp726 = (((ushort)((ushort)6160U)) <= ((ushort)(temp660)));
                            var temp727 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp728 = (((temp726) && (temp717)) && (temp727));
                            var temp729 = (((ushort)((ushort)6470U)) <= ((ushort)(temp660)));
                            var temp730 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp731 = (((temp729) && (temp717)) && (temp730));
                            var temp732 = (((ushort)((ushort)6608U)) <= ((ushort)(temp660)));
                            var temp733 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp734 = (((temp732) && (temp717)) && (temp733));
                            var temp735 = (((ushort)((ushort)6992U)) <= ((ushort)(temp660)));
                            var temp736 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp737 = (((temp735) && (temp717)) && (temp736));
                            var temp738 = (((ushort)((ushort)7088U)) <= ((ushort)(temp660)));
                            var temp739 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp740 = (((temp738) && (temp717)) && (temp739));
                            var temp741 = (((ushort)((ushort)7232U)) <= ((ushort)(temp660)));
                            var temp742 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp743 = (((temp741) && (temp717)) && (temp742));
                            var temp744 = (((ushort)((ushort)7248U)) <= ((ushort)(temp660)));
                            var temp745 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp746 = (((temp744) && (temp717)) && (temp745));
                            var temp747 = (((ushort)((ushort)42528U)) <= ((ushort)(temp660)));
                            var temp748 = (((ushort)(temp660)) <= ((ushort)((ushort)42537U)));
                            var temp749 = ((temp747) && (temp748));
                            var temp750 = (((ushort)((ushort)43216U)) <= ((ushort)(temp660)));
                            var temp751 = (((ushort)(temp660)) <= ((ushort)((ushort)43225U)));
                            var temp752 = ((temp750) && (temp751));
                            var temp753 = (((ushort)((ushort)43264U)) <= ((ushort)(temp660)));
                            var temp754 = (((ushort)(temp660)) <= ((ushort)((ushort)43273U)));
                            var temp755 = ((temp753) && (temp754));
                            var temp756 = (((ushort)((ushort)43600U)) <= ((ushort)(temp660)));
                            var temp757 = (((ushort)(temp660)) <= ((ushort)((ushort)43609U)));
                            var temp758 = ((temp756) && (temp757));
                            var temp759 = (((ushort)((ushort)65296U)) <= ((ushort)(temp660)));
                            var temp760 = (((ushort)(temp660)) <= ((ushort)((ushort)65305U)));
                            var temp761 = ((temp759) && (temp760));
                            var temp762 = (((((((((((((((((((((((((((((((temp665) || (temp670)) || (temp673)) || (temp676)) || (temp681)) || (temp684)) || (temp687)) || (temp690)) || (temp693)) || (temp696)) || (temp699)) || (temp702)) || (temp705)) || (temp708)) || (temp711)) || (temp714)) || (temp719)) || (temp722)) || (temp725)) || (temp728)) || (temp731)) || (temp734)) || (temp737)) || (temp740)) || (temp743)) || (temp746)) || (temp749)) || (temp752)) || (temp755)) || (temp758)) || (temp761));
                            if (temp762)
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M47;
                            }
                            else
                                throw new Exception();
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
                        var temp763 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp764 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp763)));
                        var temp765 = ((int)((uint)(temp763)) <= (int)((uint)((uint)191U)));
                        var temp766 = ((temp764) && (temp765));
                        if (temp766)
                        {
                            var temp767 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp768 = Fun0(((ushort)((s)._0)), ((ushort)(temp767)));
                            s._0 = ((ushort)(temp768));
                            goto M48;
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
                        var temp769 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp770 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp769)));
                        var temp771 = ((int)((uint)(temp769)) <= (int)((uint)((uint)159U)));
                        var temp772 = ((temp770) && (temp771));
                        if (temp772)
                        {
                            var temp773 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp774 = Fun0(((ushort)((s)._0)), ((ushort)(temp773)));
                            s._0 = ((ushort)(temp774));
                            goto M48;
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
                        var temp775 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp776 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp775)));
                        var temp777 = ((int)((uint)(temp775)) <= (int)((uint)((uint)191U)));
                        var temp778 = ((temp776) && (temp777));
                        if (temp778)
                        {
                            var temp779 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp780 = Fun0(((ushort)((s)._0)), ((ushort)(temp779)));
                            s._0 = ((ushort)(temp780));
                            goto M48;
                        }
                        else
                            throw new Exception();
                    }
                }

                M52:
                {
                    if (!ie.MoveNext())
                        goto F52;
                    i = ie.Current;
                    {
                        var temp781 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp782 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp781)));
                        var temp783 = ((int)((uint)(temp781)) <= (int)((uint)((uint)191U)));
                        var temp784 = ((temp782) && (temp783));
                        if (temp784)
                        {
                            var temp785 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp786 = Fun0(((ushort)((s)._0)), ((ushort)(temp785)));
                            var temp787 = (((ushort)((ushort)48U)) <= ((ushort)(temp786)));
                            var temp788 = ((ushort)(((ushort)(temp786)) >> 6));
                            var temp789 = (((ushort)(temp788 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp790 = (((byte)(((byte)((ushort)(temp786))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp791 = (((temp787) && (temp789)) && (temp790));
                            var temp792 = (((ushort)((ushort)1632U)) <= ((ushort)(temp786)));
                            var temp793 = ((byte)(((ushort)(temp786)) >> 11));
                            var temp794 = (((byte)(temp793 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp795 = (((ushort)(((ushort)((ushort)(temp786))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp796 = (((temp792) && (temp794)) && (temp795));
                            var temp797 = (((ushort)((ushort)1776U)) <= ((ushort)(temp786)));
                            var temp798 = (((ushort)(((ushort)((ushort)(temp786))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp799 = (((temp797) && (temp794)) && (temp798));
                            var temp800 = (((ushort)((ushort)1984U)) <= ((ushort)(temp786)));
                            var temp801 = (((ushort)(((ushort)((ushort)(temp786))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp802 = (((temp800) && (temp794)) && (temp801));
                            var temp803 = (((ushort)((ushort)2406U)) <= ((ushort)(temp786)));
                            var temp804 = ((byte)(((ushort)(temp786)) >> 12));
                            var temp805 = (((byte)(temp804 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp806 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp807 = (((temp803) && (temp805)) && (temp806));
                            var temp808 = (((ushort)((ushort)2534U)) <= ((ushort)(temp786)));
                            var temp809 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp810 = (((temp808) && (temp805)) && (temp809));
                            var temp811 = (((ushort)((ushort)2662U)) <= ((ushort)(temp786)));
                            var temp812 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp813 = (((temp811) && (temp805)) && (temp812));
                            var temp814 = (((ushort)((ushort)2790U)) <= ((ushort)(temp786)));
                            var temp815 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp816 = (((temp814) && (temp805)) && (temp815));
                            var temp817 = (((ushort)((ushort)2918U)) <= ((ushort)(temp786)));
                            var temp818 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp819 = (((temp817) && (temp805)) && (temp818));
                            var temp820 = (((ushort)((ushort)3046U)) <= ((ushort)(temp786)));
                            var temp821 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp822 = (((temp820) && (temp805)) && (temp821));
                            var temp823 = (((ushort)((ushort)3174U)) <= ((ushort)(temp786)));
                            var temp824 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp825 = (((temp823) && (temp805)) && (temp824));
                            var temp826 = (((ushort)((ushort)3302U)) <= ((ushort)(temp786)));
                            var temp827 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp828 = (((temp826) && (temp805)) && (temp827));
                            var temp829 = (((ushort)((ushort)3430U)) <= ((ushort)(temp786)));
                            var temp830 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp831 = (((temp829) && (temp805)) && (temp830));
                            var temp832 = (((ushort)((ushort)3664U)) <= ((ushort)(temp786)));
                            var temp833 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp834 = (((temp832) && (temp805)) && (temp833));
                            var temp835 = (((ushort)((ushort)3792U)) <= ((ushort)(temp786)));
                            var temp836 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp837 = (((temp835) && (temp805)) && (temp836));
                            var temp838 = (((ushort)((ushort)3872U)) <= ((ushort)(temp786)));
                            var temp839 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp840 = (((temp838) && (temp805)) && (temp839));
                            var temp841 = (((ushort)((ushort)4160U)) <= ((ushort)(temp786)));
                            var temp842 = ((byte)(((ushort)(temp786)) >> 13));
                            var temp843 = (((byte)(temp842 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp844 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp845 = (((temp841) && (temp843)) && (temp844));
                            var temp846 = (((ushort)((ushort)4240U)) <= ((ushort)(temp786)));
                            var temp847 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp848 = (((temp846) && (temp843)) && (temp847));
                            var temp849 = (((ushort)((ushort)6112U)) <= ((ushort)(temp786)));
                            var temp850 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp851 = (((temp849) && (temp843)) && (temp850));
                            var temp852 = (((ushort)((ushort)6160U)) <= ((ushort)(temp786)));
                            var temp853 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp854 = (((temp852) && (temp843)) && (temp853));
                            var temp855 = (((ushort)((ushort)6470U)) <= ((ushort)(temp786)));
                            var temp856 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp857 = (((temp855) && (temp843)) && (temp856));
                            var temp858 = (((ushort)((ushort)6608U)) <= ((ushort)(temp786)));
                            var temp859 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp860 = (((temp858) && (temp843)) && (temp859));
                            var temp861 = (((ushort)((ushort)6992U)) <= ((ushort)(temp786)));
                            var temp862 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp863 = (((temp861) && (temp843)) && (temp862));
                            var temp864 = (((ushort)((ushort)7088U)) <= ((ushort)(temp786)));
                            var temp865 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp866 = (((temp864) && (temp843)) && (temp865));
                            var temp867 = (((ushort)((ushort)7232U)) <= ((ushort)(temp786)));
                            var temp868 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp869 = (((temp867) && (temp843)) && (temp868));
                            var temp870 = (((ushort)((ushort)7248U)) <= ((ushort)(temp786)));
                            var temp871 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp872 = (((temp870) && (temp843)) && (temp871));
                            var temp873 = (((ushort)((ushort)42528U)) <= ((ushort)(temp786)));
                            var temp874 = (((ushort)(temp786)) <= ((ushort)((ushort)42537U)));
                            var temp875 = ((temp873) && (temp874));
                            var temp876 = (((ushort)((ushort)43216U)) <= ((ushort)(temp786)));
                            var temp877 = (((ushort)(temp786)) <= ((ushort)((ushort)43225U)));
                            var temp878 = ((temp876) && (temp877));
                            var temp879 = (((ushort)((ushort)43264U)) <= ((ushort)(temp786)));
                            var temp880 = (((ushort)(temp786)) <= ((ushort)((ushort)43273U)));
                            var temp881 = ((temp879) && (temp880));
                            var temp882 = (((ushort)((ushort)43600U)) <= ((ushort)(temp786)));
                            var temp883 = (((ushort)(temp786)) <= ((ushort)((ushort)43609U)));
                            var temp884 = ((temp882) && (temp883));
                            var temp885 = (((ushort)((ushort)65296U)) <= ((ushort)(temp786)));
                            var temp886 = (((ushort)(temp786)) <= ((ushort)((ushort)65305U)));
                            var temp887 = ((temp885) && (temp886));
                            var temp888 = (((((((((((((((((((((((((((((((temp791) || (temp796)) || (temp799)) || (temp802)) || (temp807)) || (temp810)) || (temp813)) || (temp816)) || (temp819)) || (temp822)) || (temp825)) || (temp828)) || (temp831)) || (temp834)) || (temp837)) || (temp840)) || (temp845)) || (temp848)) || (temp851)) || (temp854)) || (temp857)) || (temp860)) || (temp863)) || (temp866)) || (temp869)) || (temp872)) || (temp875)) || (temp878)) || (temp881)) || (temp884)) || (temp887));
                            if (temp888)
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M47;
                            }
                            else
                                throw new Exception();
                        }
                        else
                            throw new Exception();
                    }
                }

                M53:
                {
                    if (!ie.MoveNext())
                        goto F53;
                    i = ie.Current;
                    {
                        var temp889 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp890 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp889)));
                        var temp891 = ((int)((uint)(temp889)) <= (int)((uint)((uint)191U)));
                        var temp892 = ((temp890) && (temp891));
                        if (temp892)
                        {
                            var temp893 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp894 = Fun0(((ushort)((s)._0)), ((ushort)(temp893)));
                            s._0 = ((ushort)(temp894));
                            goto M52;
                        }
                        else
                            throw new Exception();
                    }
                }

                M54:
                {
                    if (!ie.MoveNext())
                        goto F54;
                    i = ie.Current;
                    {
                        var temp895 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp896 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp895)));
                        var temp897 = ((int)((uint)(temp895)) <= (int)((uint)((uint)159U)));
                        var temp898 = ((temp896) && (temp897));
                        if (temp898)
                        {
                            var temp899 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp900 = Fun0(((ushort)((s)._0)), ((ushort)(temp899)));
                            s._0 = ((ushort)(temp900));
                            goto M52;
                        }
                        else
                            throw new Exception();
                    }
                }

                M55:
                {
                    if (!ie.MoveNext())
                        goto F55;
                    i = ie.Current;
                    {
                        var temp901 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp902 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp901)));
                        var temp903 = ((int)((uint)(temp901)) <= (int)((uint)((uint)191U)));
                        var temp904 = ((temp902) && (temp903));
                        if (temp904)
                        {
                            var temp905 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp906 = Fun0(((ushort)((s)._0)), ((ushort)(temp905)));
                            s._0 = ((ushort)(temp906));
                            goto M52;
                        }
                        else
                            throw new Exception();
                    }
                }

                M56:
                {
                    if (!ie.MoveNext())
                        goto F56;
                    i = ie.Current;
                    {
                        var temp907 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp908 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp907)));
                        var temp909 = ((int)((uint)(temp907)) <= (int)((uint)((uint)191U)));
                        var temp910 = ((temp908) && (temp909));
                        if (temp910)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M41;
                        }
                        else
                            throw new Exception();
                    }
                }

                M57:
                {
                    if (!ie.MoveNext())
                        goto F57;
                    i = ie.Current;
                    {
                        var temp911 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp912 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp911)));
                        var temp913 = ((int)((uint)(temp911)) <= (int)((uint)((uint)191U)));
                        var temp914 = ((temp912) && (temp913));
                        if (temp914)
                        {
                            var temp915 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp916 = Fun0(((ushort)((s)._0)), ((ushort)(temp915)));
                            s._0 = ((ushort)(temp916));
                            goto M56;
                        }
                        else
                            throw new Exception();
                    }
                }

                M58:
                {
                    if (!ie.MoveNext())
                        goto F58;
                    i = ie.Current;
                    {
                        var temp917 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp918 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp917)));
                        var temp919 = ((int)((uint)(temp917)) <= (int)((uint)((uint)159U)));
                        var temp920 = ((temp918) && (temp919));
                        if (temp920)
                        {
                            var temp921 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp922 = Fun0(((ushort)((s)._0)), ((ushort)(temp921)));
                            s._0 = ((ushort)(temp922));
                            goto M56;
                        }
                        else
                            throw new Exception();
                    }
                }

                M59:
                {
                    if (!ie.MoveNext())
                        goto F59;
                    i = ie.Current;
                    {
                        var temp923 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp924 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp923)));
                        var temp925 = ((int)((uint)(temp923)) <= (int)((uint)((uint)191U)));
                        var temp926 = ((temp924) && (temp925));
                        if (temp926)
                        {
                            var temp927 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp928 = Fun0(((ushort)((s)._0)), ((ushort)(temp927)));
                            s._0 = ((ushort)(temp928));
                            goto M56;
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
                F40:
                    throw new Exception();
                F41:
                    throw new Exception();
                F42:
                    throw new Exception();
                F43:
                    throw new Exception();
                F44:
                    throw new Exception();
                F45:
                    throw new Exception();
                F46:
                    throw new Exception();
                F47:
                    throw new Exception();
                F48:
                    throw new Exception();
                F49:
                    throw new Exception();
                F50:
                    throw new Exception();
                F51:
                    throw new Exception();
                F52:
                    throw new Exception();
                F53:
                    throw new Exception();
                F54:
                    throw new Exception();
                F55:
                    throw new Exception();
                F56:
                    throw new Exception();
                F57:
                    throw new Exception();
                F58:
                    throw new Exception();
                F59:
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
                DTStruct1 s = new DTStruct1(((ushort)((ushort)0U)), ((uint)((uint)0U)), ((uint)((uint)2147483647U)));
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
                            var temp192 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp192)
                            {
                                goto M26;
                            }
                            else
                            {
                                goto M21;
                            }
                        }
                        else
                        {
                            var temp193 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp188)));
                            var temp194 = ((int)((uint)(temp188)) <= (int)((uint)((uint)223U)));
                            var temp195 = ((temp193) && (temp194));
                            if (temp195)
                            {
                                var temp196 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp196));
                                goto M27;
                            }
                            else
                            {
                                var temp197 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp197)
                                {
                                    var temp198 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp198));
                                    goto M28;
                                }
                                else
                                {
                                    var temp199 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp199)
                                    {
                                        var temp200 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp200));
                                        goto M29;
                                    }
                                    else
                                    {
                                        var temp201 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp188)));
                                        var temp202 = ((int)((uint)(temp188)) <= (int)((uint)((uint)239U)));
                                        var temp203 = ((temp201) && (temp202));
                                        if (temp203)
                                        {
                                            var temp204 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp204));
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
                        var temp205 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp206 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp205)));
                        var temp207 = ((int)((uint)(temp205)) <= (int)((uint)((uint)191U)));
                        var temp208 = ((temp206) && (temp207));
                        if (temp208)
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
                        var temp209 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp210 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp209)));
                        var temp211 = ((int)((uint)(temp209)) <= (int)((uint)((uint)191U)));
                        var temp212 = ((temp210) && (temp211));
                        if (temp212)
                        {
                            var temp213 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp214 = Fun0(((ushort)((s)._0)), ((ushort)(temp213)));
                            s._0 = ((ushort)(temp214));
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
                        var temp215 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp216 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp215)));
                        var temp217 = ((int)((uint)(temp215)) <= (int)((uint)((uint)159U)));
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
                        var temp221 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp222 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp221)));
                        var temp223 = ((int)((uint)(temp221)) <= (int)((uint)((uint)191U)));
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
                        var temp227 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp228 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp227)));
                        var temp229 = ((int)((uint)(temp227)) <= (int)((uint)((uint)127U)));
                        var temp230 = ((temp228) && (temp229));
                        if (temp230)
                        {
                            var temp231 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp231)
                            {
                                goto M31;
                            }
                            else
                            {
                                goto M26;
                            }
                        }
                        else
                        {
                            var temp232 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp227)));
                            var temp233 = ((int)((uint)(temp227)) <= (int)((uint)((uint)223U)));
                            var temp234 = ((temp232) && (temp233));
                            if (temp234)
                            {
                                var temp235 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp235));
                                goto M32;
                            }
                            else
                            {
                                var temp236 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp236)
                                {
                                    var temp237 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp237));
                                    goto M33;
                                }
                                else
                                {
                                    var temp238 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp238)
                                    {
                                        var temp239 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp239));
                                        goto M34;
                                    }
                                    else
                                    {
                                        var temp240 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp227)));
                                        var temp241 = ((int)((uint)(temp227)) <= (int)((uint)((uint)239U)));
                                        var temp242 = ((temp240) && (temp241));
                                        if (temp242)
                                        {
                                            var temp243 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp243));
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
                        var temp244 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp245 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp244)));
                        var temp246 = ((int)((uint)(temp244)) <= (int)((uint)((uint)191U)));
                        var temp247 = ((temp245) && (temp246));
                        if (temp247)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M21;
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
                        var temp248 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp249 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp248)));
                        var temp250 = ((int)((uint)(temp248)) <= (int)((uint)((uint)191U)));
                        var temp251 = ((temp249) && (temp250));
                        if (temp251)
                        {
                            var temp252 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp253 = Fun0(((ushort)((s)._0)), ((ushort)(temp252)));
                            s._0 = ((ushort)(temp253));
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
                        var temp254 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp255 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp254)));
                        var temp256 = ((int)((uint)(temp254)) <= (int)((uint)((uint)159U)));
                        var temp257 = ((temp255) && (temp256));
                        if (temp257)
                        {
                            var temp258 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp259 = Fun0(((ushort)((s)._0)), ((ushort)(temp258)));
                            s._0 = ((ushort)(temp259));
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
                        var temp260 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp261 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp260)));
                        var temp262 = ((int)((uint)(temp260)) <= (int)((uint)((uint)191U)));
                        var temp263 = ((temp261) && (temp262));
                        if (temp263)
                        {
                            var temp264 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp265 = Fun0(((ushort)((s)._0)), ((ushort)(temp264)));
                            s._0 = ((ushort)(temp265));
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
                        var temp266 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp267 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp266)));
                        var temp268 = ((int)((uint)(temp266)) <= (int)((uint)((uint)127U)));
                        var temp269 = ((temp267) && (temp268));
                        if (temp269)
                        {
                            var temp270 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp271 = ((byte)(((byte)(i)) >> 6));
                            var temp272 = (((byte)(temp271 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp273 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp274 = (((temp270) && (temp272)) && (temp273));
                            if (temp274)
                            {
                                var temp275 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp276 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp275))) + ((uint)(temp266))));
                                s._1 = ((uint)(temp276));
                                goto M36;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp277 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp266)));
                            var temp278 = ((int)((uint)(temp266)) <= (int)((uint)((uint)223U)));
                            var temp279 = ((temp277) && (temp278));
                            if (temp279)
                            {
                                var temp280 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp280));
                                goto M37;
                            }
                            else
                            {
                                var temp281 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp281)
                                {
                                    var temp282 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp282));
                                    goto M38;
                                }
                                else
                                {
                                    var temp283 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp283)
                                    {
                                        var temp284 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp284));
                                        goto M39;
                                    }
                                    else
                                    {
                                        var temp285 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp266)));
                                        var temp286 = ((int)((uint)(temp266)) <= (int)((uint)((uint)239U)));
                                        var temp287 = ((temp285) && (temp286));
                                        if (temp287)
                                        {
                                            var temp288 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp288));
                                            goto M40;
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
                        var temp289 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp290 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp289)));
                        var temp291 = ((int)((uint)(temp289)) <= (int)((uint)((uint)191U)));
                        var temp292 = ((temp290) && (temp291));
                        if (temp292)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M26;
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
                        var temp293 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp294 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp293)));
                        var temp295 = ((int)((uint)(temp293)) <= (int)((uint)((uint)191U)));
                        var temp296 = ((temp294) && (temp295));
                        if (temp296)
                        {
                            var temp297 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp298 = Fun0(((ushort)((s)._0)), ((ushort)(temp297)));
                            s._0 = ((ushort)(temp298));
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
                        var temp299 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp300 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp299)));
                        var temp301 = ((int)((uint)(temp299)) <= (int)((uint)((uint)159U)));
                        var temp302 = ((temp300) && (temp301));
                        if (temp302)
                        {
                            var temp303 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp304 = Fun0(((ushort)((s)._0)), ((ushort)(temp303)));
                            s._0 = ((ushort)(temp304));
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
                        var temp305 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp306 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp305)));
                        var temp307 = ((int)((uint)(temp305)) <= (int)((uint)((uint)191U)));
                        var temp308 = ((temp306) && (temp307));
                        if (temp308)
                        {
                            var temp309 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp310 = Fun0(((ushort)((s)._0)), ((ushort)(temp309)));
                            s._0 = ((ushort)(temp310));
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
                        var temp311 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp312 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp311)));
                        var temp313 = ((int)((uint)(temp311)) <= (int)((uint)((uint)127U)));
                        var temp314 = ((temp312) && (temp313));
                        if (temp314)
                        {
                            var temp315 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp315)
                            {
                                goto M41;
                            }
                            else
                            {
                                var temp316 = (((byte)(i)) == ((byte)((byte)46U)));
                                if (temp316)
                                {
                                    goto M42;
                                }
                                else
                                {
                                    var temp317 = (((byte)((byte)48U)) <= ((byte)(i)));
                                    var temp318 = ((byte)(((byte)(i)) >> 6));
                                    var temp319 = (((byte)(temp318 & 3L)) == ((byte)((byte)0U & 3L)));
                                    var temp320 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                    var temp321 = (((temp317) && (temp319)) && (temp320));
                                    if (temp321)
                                    {
                                        var temp322 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                        var temp323 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp322))) + ((uint)(temp311))));
                                        s._1 = ((uint)(temp323));
                                        goto M36;
                                    }
                                    else
                                        throw new Exception();
                                }
                            }
                        }
                        else
                        {
                            var temp324 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp311)));
                            var temp325 = ((int)((uint)(temp311)) <= (int)((uint)((uint)223U)));
                            var temp326 = ((temp324) && (temp325));
                            if (temp326)
                            {
                                var temp327 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp327));
                                goto M43;
                            }
                            else
                            {
                                var temp328 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp328)
                                {
                                    var temp329 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp329));
                                    goto M44;
                                }
                                else
                                {
                                    var temp330 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp330)
                                    {
                                        var temp331 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp331));
                                        goto M45;
                                    }
                                    else
                                    {
                                        var temp332 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp311)));
                                        var temp333 = ((int)((uint)(temp311)) <= (int)((uint)((uint)239U)));
                                        var temp334 = ((temp332) && (temp333));
                                        if (temp334)
                                        {
                                            var temp335 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp335));
                                            goto M46;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
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
                        var temp336 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp337 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp336)));
                        var temp338 = ((int)((uint)(temp336)) <= (int)((uint)((uint)191U)));
                        var temp339 = ((temp337) && (temp338));
                        if (temp339)
                        {
                            var temp340 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp341 = Fun0(((ushort)((s)._0)), ((ushort)(temp340)));
                            var temp342 = (((ushort)((ushort)48U)) <= ((ushort)(temp341)));
                            var temp343 = ((ushort)(((ushort)(temp341)) >> 6));
                            var temp344 = (((ushort)(temp343 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp345 = (((byte)(((byte)((ushort)(temp341))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp346 = (((temp342) && (temp344)) && (temp345));
                            var temp347 = (((ushort)((ushort)1632U)) <= ((ushort)(temp341)));
                            var temp348 = ((byte)(((ushort)(temp341)) >> 11));
                            var temp349 = (((byte)(temp348 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp350 = (((ushort)(((ushort)((ushort)(temp341))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp351 = (((temp347) && (temp349)) && (temp350));
                            var temp352 = (((ushort)((ushort)1776U)) <= ((ushort)(temp341)));
                            var temp353 = (((ushort)(((ushort)((ushort)(temp341))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp354 = (((temp352) && (temp349)) && (temp353));
                            var temp355 = (((ushort)((ushort)1984U)) <= ((ushort)(temp341)));
                            var temp356 = (((ushort)(((ushort)((ushort)(temp341))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp357 = (((temp355) && (temp349)) && (temp356));
                            var temp358 = (((ushort)((ushort)2406U)) <= ((ushort)(temp341)));
                            var temp359 = ((byte)(((ushort)(temp341)) >> 12));
                            var temp360 = (((byte)(temp359 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp361 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp362 = (((temp358) && (temp360)) && (temp361));
                            var temp363 = (((ushort)((ushort)2534U)) <= ((ushort)(temp341)));
                            var temp364 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp365 = (((temp363) && (temp360)) && (temp364));
                            var temp366 = (((ushort)((ushort)2662U)) <= ((ushort)(temp341)));
                            var temp367 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp368 = (((temp366) && (temp360)) && (temp367));
                            var temp369 = (((ushort)((ushort)2790U)) <= ((ushort)(temp341)));
                            var temp370 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp371 = (((temp369) && (temp360)) && (temp370));
                            var temp372 = (((ushort)((ushort)2918U)) <= ((ushort)(temp341)));
                            var temp373 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp374 = (((temp372) && (temp360)) && (temp373));
                            var temp375 = (((ushort)((ushort)3046U)) <= ((ushort)(temp341)));
                            var temp376 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp377 = (((temp375) && (temp360)) && (temp376));
                            var temp378 = (((ushort)((ushort)3174U)) <= ((ushort)(temp341)));
                            var temp379 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp380 = (((temp378) && (temp360)) && (temp379));
                            var temp381 = (((ushort)((ushort)3302U)) <= ((ushort)(temp341)));
                            var temp382 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp383 = (((temp381) && (temp360)) && (temp382));
                            var temp384 = (((ushort)((ushort)3430U)) <= ((ushort)(temp341)));
                            var temp385 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp386 = (((temp384) && (temp360)) && (temp385));
                            var temp387 = (((ushort)((ushort)3664U)) <= ((ushort)(temp341)));
                            var temp388 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp389 = (((temp387) && (temp360)) && (temp388));
                            var temp390 = (((ushort)((ushort)3792U)) <= ((ushort)(temp341)));
                            var temp391 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp392 = (((temp390) && (temp360)) && (temp391));
                            var temp393 = (((ushort)((ushort)3872U)) <= ((ushort)(temp341)));
                            var temp394 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp395 = (((temp393) && (temp360)) && (temp394));
                            var temp396 = (((ushort)((ushort)4160U)) <= ((ushort)(temp341)));
                            var temp397 = ((byte)(((ushort)(temp341)) >> 13));
                            var temp398 = (((byte)(temp397 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp399 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp400 = (((temp396) && (temp398)) && (temp399));
                            var temp401 = (((ushort)((ushort)4240U)) <= ((ushort)(temp341)));
                            var temp402 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp403 = (((temp401) && (temp398)) && (temp402));
                            var temp404 = (((ushort)((ushort)6112U)) <= ((ushort)(temp341)));
                            var temp405 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp406 = (((temp404) && (temp398)) && (temp405));
                            var temp407 = (((ushort)((ushort)6160U)) <= ((ushort)(temp341)));
                            var temp408 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp409 = (((temp407) && (temp398)) && (temp408));
                            var temp410 = (((ushort)((ushort)6470U)) <= ((ushort)(temp341)));
                            var temp411 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp412 = (((temp410) && (temp398)) && (temp411));
                            var temp413 = (((ushort)((ushort)6608U)) <= ((ushort)(temp341)));
                            var temp414 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp415 = (((temp413) && (temp398)) && (temp414));
                            var temp416 = (((ushort)((ushort)6992U)) <= ((ushort)(temp341)));
                            var temp417 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp418 = (((temp416) && (temp398)) && (temp417));
                            var temp419 = (((ushort)((ushort)7088U)) <= ((ushort)(temp341)));
                            var temp420 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp421 = (((temp419) && (temp398)) && (temp420));
                            var temp422 = (((ushort)((ushort)7232U)) <= ((ushort)(temp341)));
                            var temp423 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp424 = (((temp422) && (temp398)) && (temp423));
                            var temp425 = (((ushort)((ushort)7248U)) <= ((ushort)(temp341)));
                            var temp426 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp427 = (((temp425) && (temp398)) && (temp426));
                            var temp428 = (((ushort)((ushort)42528U)) <= ((ushort)(temp341)));
                            var temp429 = (((ushort)(temp341)) <= ((ushort)((ushort)42537U)));
                            var temp430 = ((temp428) && (temp429));
                            var temp431 = (((ushort)((ushort)43216U)) <= ((ushort)(temp341)));
                            var temp432 = (((ushort)(temp341)) <= ((ushort)((ushort)43225U)));
                            var temp433 = ((temp431) && (temp432));
                            var temp434 = (((ushort)((ushort)43264U)) <= ((ushort)(temp341)));
                            var temp435 = (((ushort)(temp341)) <= ((ushort)((ushort)43273U)));
                            var temp436 = ((temp434) && (temp435));
                            var temp437 = (((ushort)((ushort)43600U)) <= ((ushort)(temp341)));
                            var temp438 = (((ushort)(temp341)) <= ((ushort)((ushort)43609U)));
                            var temp439 = ((temp437) && (temp438));
                            var temp440 = (((ushort)((ushort)65296U)) <= ((ushort)(temp341)));
                            var temp441 = (((ushort)(temp341)) <= ((ushort)((ushort)65305U)));
                            var temp442 = ((temp440) && (temp441));
                            var temp443 = (((((((((((((((((((((((((((((((temp346) || (temp351)) || (temp354)) || (temp357)) || (temp362)) || (temp365)) || (temp368)) || (temp371)) || (temp374)) || (temp377)) || (temp380)) || (temp383)) || (temp386)) || (temp389)) || (temp392)) || (temp395)) || (temp400)) || (temp403)) || (temp406)) || (temp409)) || (temp412)) || (temp415)) || (temp418)) || (temp421)) || (temp424)) || (temp427)) || (temp430)) || (temp433)) || (temp436)) || (temp439)) || (temp442));
                            if (temp443)
                            {
                                var temp444 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp445 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp341));
                                var temp446 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp444))) + ((uint)(temp445))));
                                s._1 = ((uint)(temp446));
                                s._0 = ((ushort)((ushort)0U));
                                goto M36;
                            }
                            else
                                throw new Exception();
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
                        var temp447 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp448 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp447)));
                        var temp449 = ((int)((uint)(temp447)) <= (int)((uint)((uint)191U)));
                        var temp450 = ((temp448) && (temp449));
                        if (temp450)
                        {
                            var temp451 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp452 = Fun0(((ushort)((s)._0)), ((ushort)(temp451)));
                            s._0 = ((ushort)(temp452));
                            goto M37;
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
                        var temp453 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp454 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp453)));
                        var temp455 = ((int)((uint)(temp453)) <= (int)((uint)((uint)159U)));
                        var temp456 = ((temp454) && (temp455));
                        if (temp456)
                        {
                            var temp457 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp458 = Fun0(((ushort)((s)._0)), ((ushort)(temp457)));
                            s._0 = ((ushort)(temp458));
                            goto M37;
                        }
                        else
                            throw new Exception();
                    }
                }

                M40:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F40;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp459 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp460 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp459)));
                        var temp461 = ((int)((uint)(temp459)) <= (int)((uint)((uint)191U)));
                        var temp462 = ((temp460) && (temp461));
                        if (temp462)
                        {
                            var temp463 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp464 = Fun0(((ushort)((s)._0)), ((ushort)(temp463)));
                            s._0 = ((ushort)(temp464));
                            goto M37;
                        }
                        else
                            throw new Exception();
                    }
                }

                M41:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F41;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp465 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp466 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp465)));
                        var temp467 = ((int)((uint)(temp465)) <= (int)((uint)((uint)127U)));
                        var temp468 = ((temp466) && (temp467));
                        if (temp468)
                        {
                            var temp469 = (((byte)(i)) == ((byte)((byte)10U)));
                            if (temp469)
                            {
                                var temp470 = Fun1(((uint)((s)._1)), ((uint)((s)._2)));
                                s._2 = ((uint)(temp470));
                                s._1 = ((uint)((uint)0U));
                                goto M0;
                            }
                            else
                            {
                                goto M41;
                            }
                        }
                        else
                        {
                            var temp471 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp465)));
                            var temp472 = ((int)((uint)(temp465)) <= (int)((uint)((uint)223U)));
                            var temp473 = ((temp471) && (temp472));
                            if (temp473)
                            {
                                var temp474 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp474));
                                goto M56;
                            }
                            else
                            {
                                var temp475 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp475)
                                {
                                    var temp476 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp476));
                                    goto M57;
                                }
                                else
                                {
                                    var temp477 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp477)
                                    {
                                        var temp478 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp478));
                                        goto M58;
                                    }
                                    else
                                    {
                                        var temp479 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp465)));
                                        var temp480 = ((int)((uint)(temp465)) <= (int)((uint)((uint)239U)));
                                        var temp481 = ((temp479) && (temp480));
                                        if (temp481)
                                        {
                                            var temp482 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp482));
                                            goto M59;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M42:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F42;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp483 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp484 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp483)));
                        var temp485 = ((int)((uint)(temp483)) <= (int)((uint)((uint)127U)));
                        var temp486 = ((temp484) && (temp485));
                        if (temp486)
                        {
                            var temp487 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp488 = ((byte)(((byte)(i)) >> 6));
                            var temp489 = (((byte)(temp488 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp490 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp491 = (((temp487) && (temp489)) && (temp490));
                            if (temp491)
                            {
                                goto M47;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp492 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp483)));
                            var temp493 = ((int)((uint)(temp483)) <= (int)((uint)((uint)223U)));
                            var temp494 = ((temp492) && (temp493));
                            if (temp494)
                            {
                                var temp495 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp495));
                                goto M48;
                            }
                            else
                            {
                                var temp496 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp496)
                                {
                                    var temp497 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp497));
                                    goto M49;
                                }
                                else
                                {
                                    var temp498 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp498)
                                    {
                                        var temp499 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp499));
                                        goto M50;
                                    }
                                    else
                                    {
                                        var temp500 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp483)));
                                        var temp501 = ((int)((uint)(temp483)) <= (int)((uint)((uint)239U)));
                                        var temp502 = ((temp500) && (temp501));
                                        if (temp502)
                                        {
                                            var temp503 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp503));
                                            goto M51;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M43:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F43;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp504 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp505 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp504)));
                        var temp506 = ((int)((uint)(temp504)) <= (int)((uint)((uint)191U)));
                        var temp507 = ((temp505) && (temp506));
                        if (temp507)
                        {
                            var temp508 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp509 = Fun0(((ushort)((s)._0)), ((ushort)(temp508)));
                            var temp510 = (((ushort)((ushort)48U)) <= ((ushort)(temp509)));
                            var temp511 = ((ushort)(((ushort)(temp509)) >> 6));
                            var temp512 = (((ushort)(temp511 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp513 = (((byte)(((byte)((ushort)(temp509))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp514 = (((temp510) && (temp512)) && (temp513));
                            var temp515 = (((ushort)((ushort)1632U)) <= ((ushort)(temp509)));
                            var temp516 = ((byte)(((ushort)(temp509)) >> 11));
                            var temp517 = (((byte)(temp516 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp518 = (((ushort)(((ushort)((ushort)(temp509))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp519 = (((temp515) && (temp517)) && (temp518));
                            var temp520 = (((ushort)((ushort)1776U)) <= ((ushort)(temp509)));
                            var temp521 = (((ushort)(((ushort)((ushort)(temp509))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp522 = (((temp520) && (temp517)) && (temp521));
                            var temp523 = (((ushort)((ushort)1984U)) <= ((ushort)(temp509)));
                            var temp524 = (((ushort)(((ushort)((ushort)(temp509))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp525 = (((temp523) && (temp517)) && (temp524));
                            var temp526 = (((ushort)((ushort)2406U)) <= ((ushort)(temp509)));
                            var temp527 = ((byte)(((ushort)(temp509)) >> 12));
                            var temp528 = (((byte)(temp527 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp529 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp530 = (((temp526) && (temp528)) && (temp529));
                            var temp531 = (((ushort)((ushort)2534U)) <= ((ushort)(temp509)));
                            var temp532 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp533 = (((temp531) && (temp528)) && (temp532));
                            var temp534 = (((ushort)((ushort)2662U)) <= ((ushort)(temp509)));
                            var temp535 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp536 = (((temp534) && (temp528)) && (temp535));
                            var temp537 = (((ushort)((ushort)2790U)) <= ((ushort)(temp509)));
                            var temp538 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp539 = (((temp537) && (temp528)) && (temp538));
                            var temp540 = (((ushort)((ushort)2918U)) <= ((ushort)(temp509)));
                            var temp541 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp542 = (((temp540) && (temp528)) && (temp541));
                            var temp543 = (((ushort)((ushort)3046U)) <= ((ushort)(temp509)));
                            var temp544 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp545 = (((temp543) && (temp528)) && (temp544));
                            var temp546 = (((ushort)((ushort)3174U)) <= ((ushort)(temp509)));
                            var temp547 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp548 = (((temp546) && (temp528)) && (temp547));
                            var temp549 = (((ushort)((ushort)3302U)) <= ((ushort)(temp509)));
                            var temp550 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp551 = (((temp549) && (temp528)) && (temp550));
                            var temp552 = (((ushort)((ushort)3430U)) <= ((ushort)(temp509)));
                            var temp553 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp554 = (((temp552) && (temp528)) && (temp553));
                            var temp555 = (((ushort)((ushort)3664U)) <= ((ushort)(temp509)));
                            var temp556 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp557 = (((temp555) && (temp528)) && (temp556));
                            var temp558 = (((ushort)((ushort)3792U)) <= ((ushort)(temp509)));
                            var temp559 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp560 = (((temp558) && (temp528)) && (temp559));
                            var temp561 = (((ushort)((ushort)3872U)) <= ((ushort)(temp509)));
                            var temp562 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp563 = (((temp561) && (temp528)) && (temp562));
                            var temp564 = (((ushort)((ushort)4160U)) <= ((ushort)(temp509)));
                            var temp565 = ((byte)(((ushort)(temp509)) >> 13));
                            var temp566 = (((byte)(temp565 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp567 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp568 = (((temp564) && (temp566)) && (temp567));
                            var temp569 = (((ushort)((ushort)4240U)) <= ((ushort)(temp509)));
                            var temp570 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp571 = (((temp569) && (temp566)) && (temp570));
                            var temp572 = (((ushort)((ushort)6112U)) <= ((ushort)(temp509)));
                            var temp573 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp574 = (((temp572) && (temp566)) && (temp573));
                            var temp575 = (((ushort)((ushort)6160U)) <= ((ushort)(temp509)));
                            var temp576 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp577 = (((temp575) && (temp566)) && (temp576));
                            var temp578 = (((ushort)((ushort)6470U)) <= ((ushort)(temp509)));
                            var temp579 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp580 = (((temp578) && (temp566)) && (temp579));
                            var temp581 = (((ushort)((ushort)6608U)) <= ((ushort)(temp509)));
                            var temp582 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp583 = (((temp581) && (temp566)) && (temp582));
                            var temp584 = (((ushort)((ushort)6992U)) <= ((ushort)(temp509)));
                            var temp585 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp586 = (((temp584) && (temp566)) && (temp585));
                            var temp587 = (((ushort)((ushort)7088U)) <= ((ushort)(temp509)));
                            var temp588 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp589 = (((temp587) && (temp566)) && (temp588));
                            var temp590 = (((ushort)((ushort)7232U)) <= ((ushort)(temp509)));
                            var temp591 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp592 = (((temp590) && (temp566)) && (temp591));
                            var temp593 = (((ushort)((ushort)7248U)) <= ((ushort)(temp509)));
                            var temp594 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp595 = (((temp593) && (temp566)) && (temp594));
                            var temp596 = (((ushort)((ushort)42528U)) <= ((ushort)(temp509)));
                            var temp597 = (((ushort)(temp509)) <= ((ushort)((ushort)42537U)));
                            var temp598 = ((temp596) && (temp597));
                            var temp599 = (((ushort)((ushort)43216U)) <= ((ushort)(temp509)));
                            var temp600 = (((ushort)(temp509)) <= ((ushort)((ushort)43225U)));
                            var temp601 = ((temp599) && (temp600));
                            var temp602 = (((ushort)((ushort)43264U)) <= ((ushort)(temp509)));
                            var temp603 = (((ushort)(temp509)) <= ((ushort)((ushort)43273U)));
                            var temp604 = ((temp602) && (temp603));
                            var temp605 = (((ushort)((ushort)43600U)) <= ((ushort)(temp509)));
                            var temp606 = (((ushort)(temp509)) <= ((ushort)((ushort)43609U)));
                            var temp607 = ((temp605) && (temp606));
                            var temp608 = (((ushort)((ushort)65296U)) <= ((ushort)(temp509)));
                            var temp609 = (((ushort)(temp509)) <= ((ushort)((ushort)65305U)));
                            var temp610 = ((temp608) && (temp609));
                            var temp611 = (((((((((((((((((((((((((((((((temp514) || (temp519)) || (temp522)) || (temp525)) || (temp530)) || (temp533)) || (temp536)) || (temp539)) || (temp542)) || (temp545)) || (temp548)) || (temp551)) || (temp554)) || (temp557)) || (temp560)) || (temp563)) || (temp568)) || (temp571)) || (temp574)) || (temp577)) || (temp580)) || (temp583)) || (temp586)) || (temp589)) || (temp592)) || (temp595)) || (temp598)) || (temp601)) || (temp604)) || (temp607)) || (temp610));
                            if (temp611)
                            {
                                var temp612 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp613 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp509));
                                var temp614 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp612))) + ((uint)(temp613))));
                                s._1 = ((uint)(temp614));
                                s._0 = ((ushort)((ushort)0U));
                                goto M36;
                            }
                            else
                                throw new Exception();
                        }
                        else
                            throw new Exception();
                    }
                }

                M44:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F44;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp615 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp616 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp615)));
                        var temp617 = ((int)((uint)(temp615)) <= (int)((uint)((uint)191U)));
                        var temp618 = ((temp616) && (temp617));
                        if (temp618)
                        {
                            var temp619 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp620 = Fun0(((ushort)((s)._0)), ((ushort)(temp619)));
                            s._0 = ((ushort)(temp620));
                            goto M43;
                        }
                        else
                            throw new Exception();
                    }
                }

                M45:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F45;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp621 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp622 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp621)));
                        var temp623 = ((int)((uint)(temp621)) <= (int)((uint)((uint)159U)));
                        var temp624 = ((temp622) && (temp623));
                        if (temp624)
                        {
                            var temp625 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp626 = Fun0(((ushort)((s)._0)), ((ushort)(temp625)));
                            s._0 = ((ushort)(temp626));
                            goto M43;
                        }
                        else
                            throw new Exception();
                    }
                }

                M46:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F46;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp627 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp628 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp627)));
                        var temp629 = ((int)((uint)(temp627)) <= (int)((uint)((uint)191U)));
                        var temp630 = ((temp628) && (temp629));
                        if (temp630)
                        {
                            var temp631 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp632 = Fun0(((ushort)((s)._0)), ((ushort)(temp631)));
                            s._0 = ((ushort)(temp632));
                            goto M43;
                        }
                        else
                            throw new Exception();
                    }
                }

                M47:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F47;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp633 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp634 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp633)));
                        var temp635 = ((int)((uint)(temp633)) <= (int)((uint)((uint)127U)));
                        var temp636 = ((temp634) && (temp635));
                        if (temp636)
                        {
                            var temp637 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp637)
                            {
                                goto M41;
                            }
                            else
                            {
                                var temp638 = (((byte)((byte)48U)) <= ((byte)(i)));
                                var temp639 = ((byte)(((byte)(i)) >> 6));
                                var temp640 = (((byte)(temp639 & 3L)) == ((byte)((byte)0U & 3L)));
                                var temp641 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp642 = (((temp638) && (temp640)) && (temp641));
                                if (temp642)
                                {
                                    goto M47;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                        else
                        {
                            var temp643 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp633)));
                            var temp644 = ((int)((uint)(temp633)) <= (int)((uint)((uint)223U)));
                            var temp645 = ((temp643) && (temp644));
                            if (temp645)
                            {
                                var temp646 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp646));
                                goto M52;
                            }
                            else
                            {
                                var temp647 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp647)
                                {
                                    var temp648 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp648));
                                    goto M53;
                                }
                                else
                                {
                                    var temp649 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp649)
                                    {
                                        var temp650 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp650));
                                        goto M54;
                                    }
                                    else
                                    {
                                        var temp651 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp633)));
                                        var temp652 = ((int)((uint)(temp633)) <= (int)((uint)((uint)239U)));
                                        var temp653 = ((temp651) && (temp652));
                                        if (temp653)
                                        {
                                            var temp654 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp654));
                                            goto M55;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M48:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F48;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp655 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp656 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp655)));
                        var temp657 = ((int)((uint)(temp655)) <= (int)((uint)((uint)191U)));
                        var temp658 = ((temp656) && (temp657));
                        if (temp658)
                        {
                            var temp659 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp660 = Fun0(((ushort)((s)._0)), ((ushort)(temp659)));
                            var temp661 = (((ushort)((ushort)48U)) <= ((ushort)(temp660)));
                            var temp662 = ((ushort)(((ushort)(temp660)) >> 6));
                            var temp663 = (((ushort)(temp662 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp664 = (((byte)(((byte)((ushort)(temp660))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp665 = (((temp661) && (temp663)) && (temp664));
                            var temp666 = (((ushort)((ushort)1632U)) <= ((ushort)(temp660)));
                            var temp667 = ((byte)(((ushort)(temp660)) >> 11));
                            var temp668 = (((byte)(temp667 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp669 = (((ushort)(((ushort)((ushort)(temp660))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp670 = (((temp666) && (temp668)) && (temp669));
                            var temp671 = (((ushort)((ushort)1776U)) <= ((ushort)(temp660)));
                            var temp672 = (((ushort)(((ushort)((ushort)(temp660))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp673 = (((temp671) && (temp668)) && (temp672));
                            var temp674 = (((ushort)((ushort)1984U)) <= ((ushort)(temp660)));
                            var temp675 = (((ushort)(((ushort)((ushort)(temp660))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp676 = (((temp674) && (temp668)) && (temp675));
                            var temp677 = (((ushort)((ushort)2406U)) <= ((ushort)(temp660)));
                            var temp678 = ((byte)(((ushort)(temp660)) >> 12));
                            var temp679 = (((byte)(temp678 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp680 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp681 = (((temp677) && (temp679)) && (temp680));
                            var temp682 = (((ushort)((ushort)2534U)) <= ((ushort)(temp660)));
                            var temp683 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp684 = (((temp682) && (temp679)) && (temp683));
                            var temp685 = (((ushort)((ushort)2662U)) <= ((ushort)(temp660)));
                            var temp686 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp687 = (((temp685) && (temp679)) && (temp686));
                            var temp688 = (((ushort)((ushort)2790U)) <= ((ushort)(temp660)));
                            var temp689 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp690 = (((temp688) && (temp679)) && (temp689));
                            var temp691 = (((ushort)((ushort)2918U)) <= ((ushort)(temp660)));
                            var temp692 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp693 = (((temp691) && (temp679)) && (temp692));
                            var temp694 = (((ushort)((ushort)3046U)) <= ((ushort)(temp660)));
                            var temp695 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp696 = (((temp694) && (temp679)) && (temp695));
                            var temp697 = (((ushort)((ushort)3174U)) <= ((ushort)(temp660)));
                            var temp698 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp699 = (((temp697) && (temp679)) && (temp698));
                            var temp700 = (((ushort)((ushort)3302U)) <= ((ushort)(temp660)));
                            var temp701 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp702 = (((temp700) && (temp679)) && (temp701));
                            var temp703 = (((ushort)((ushort)3430U)) <= ((ushort)(temp660)));
                            var temp704 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp705 = (((temp703) && (temp679)) && (temp704));
                            var temp706 = (((ushort)((ushort)3664U)) <= ((ushort)(temp660)));
                            var temp707 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp708 = (((temp706) && (temp679)) && (temp707));
                            var temp709 = (((ushort)((ushort)3792U)) <= ((ushort)(temp660)));
                            var temp710 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp711 = (((temp709) && (temp679)) && (temp710));
                            var temp712 = (((ushort)((ushort)3872U)) <= ((ushort)(temp660)));
                            var temp713 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp714 = (((temp712) && (temp679)) && (temp713));
                            var temp715 = (((ushort)((ushort)4160U)) <= ((ushort)(temp660)));
                            var temp716 = ((byte)(((ushort)(temp660)) >> 13));
                            var temp717 = (((byte)(temp716 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp718 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp719 = (((temp715) && (temp717)) && (temp718));
                            var temp720 = (((ushort)((ushort)4240U)) <= ((ushort)(temp660)));
                            var temp721 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp722 = (((temp720) && (temp717)) && (temp721));
                            var temp723 = (((ushort)((ushort)6112U)) <= ((ushort)(temp660)));
                            var temp724 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp725 = (((temp723) && (temp717)) && (temp724));
                            var temp726 = (((ushort)((ushort)6160U)) <= ((ushort)(temp660)));
                            var temp727 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp728 = (((temp726) && (temp717)) && (temp727));
                            var temp729 = (((ushort)((ushort)6470U)) <= ((ushort)(temp660)));
                            var temp730 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp731 = (((temp729) && (temp717)) && (temp730));
                            var temp732 = (((ushort)((ushort)6608U)) <= ((ushort)(temp660)));
                            var temp733 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp734 = (((temp732) && (temp717)) && (temp733));
                            var temp735 = (((ushort)((ushort)6992U)) <= ((ushort)(temp660)));
                            var temp736 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp737 = (((temp735) && (temp717)) && (temp736));
                            var temp738 = (((ushort)((ushort)7088U)) <= ((ushort)(temp660)));
                            var temp739 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp740 = (((temp738) && (temp717)) && (temp739));
                            var temp741 = (((ushort)((ushort)7232U)) <= ((ushort)(temp660)));
                            var temp742 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp743 = (((temp741) && (temp717)) && (temp742));
                            var temp744 = (((ushort)((ushort)7248U)) <= ((ushort)(temp660)));
                            var temp745 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp746 = (((temp744) && (temp717)) && (temp745));
                            var temp747 = (((ushort)((ushort)42528U)) <= ((ushort)(temp660)));
                            var temp748 = (((ushort)(temp660)) <= ((ushort)((ushort)42537U)));
                            var temp749 = ((temp747) && (temp748));
                            var temp750 = (((ushort)((ushort)43216U)) <= ((ushort)(temp660)));
                            var temp751 = (((ushort)(temp660)) <= ((ushort)((ushort)43225U)));
                            var temp752 = ((temp750) && (temp751));
                            var temp753 = (((ushort)((ushort)43264U)) <= ((ushort)(temp660)));
                            var temp754 = (((ushort)(temp660)) <= ((ushort)((ushort)43273U)));
                            var temp755 = ((temp753) && (temp754));
                            var temp756 = (((ushort)((ushort)43600U)) <= ((ushort)(temp660)));
                            var temp757 = (((ushort)(temp660)) <= ((ushort)((ushort)43609U)));
                            var temp758 = ((temp756) && (temp757));
                            var temp759 = (((ushort)((ushort)65296U)) <= ((ushort)(temp660)));
                            var temp760 = (((ushort)(temp660)) <= ((ushort)((ushort)65305U)));
                            var temp761 = ((temp759) && (temp760));
                            var temp762 = (((((((((((((((((((((((((((((((temp665) || (temp670)) || (temp673)) || (temp676)) || (temp681)) || (temp684)) || (temp687)) || (temp690)) || (temp693)) || (temp696)) || (temp699)) || (temp702)) || (temp705)) || (temp708)) || (temp711)) || (temp714)) || (temp719)) || (temp722)) || (temp725)) || (temp728)) || (temp731)) || (temp734)) || (temp737)) || (temp740)) || (temp743)) || (temp746)) || (temp749)) || (temp752)) || (temp755)) || (temp758)) || (temp761));
                            if (temp762)
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M47;
                            }
                            else
                                throw new Exception();
                        }
                        else
                            throw new Exception();
                    }
                }

                M49:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F49;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp763 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp764 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp763)));
                        var temp765 = ((int)((uint)(temp763)) <= (int)((uint)((uint)191U)));
                        var temp766 = ((temp764) && (temp765));
                        if (temp766)
                        {
                            var temp767 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp768 = Fun0(((ushort)((s)._0)), ((ushort)(temp767)));
                            s._0 = ((ushort)(temp768));
                            goto M48;
                        }
                        else
                            throw new Exception();
                    }
                }

                M50:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F50;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp769 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp770 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp769)));
                        var temp771 = ((int)((uint)(temp769)) <= (int)((uint)((uint)159U)));
                        var temp772 = ((temp770) && (temp771));
                        if (temp772)
                        {
                            var temp773 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp774 = Fun0(((ushort)((s)._0)), ((ushort)(temp773)));
                            s._0 = ((ushort)(temp774));
                            goto M48;
                        }
                        else
                            throw new Exception();
                    }
                }

                M51:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F51;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp775 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp776 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp775)));
                        var temp777 = ((int)((uint)(temp775)) <= (int)((uint)((uint)191U)));
                        var temp778 = ((temp776) && (temp777));
                        if (temp778)
                        {
                            var temp779 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp780 = Fun0(((ushort)((s)._0)), ((ushort)(temp779)));
                            s._0 = ((ushort)(temp780));
                            goto M48;
                        }
                        else
                            throw new Exception();
                    }
                }

                M52:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F52;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp781 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp782 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp781)));
                        var temp783 = ((int)((uint)(temp781)) <= (int)((uint)((uint)191U)));
                        var temp784 = ((temp782) && (temp783));
                        if (temp784)
                        {
                            var temp785 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp786 = Fun0(((ushort)((s)._0)), ((ushort)(temp785)));
                            var temp787 = (((ushort)((ushort)48U)) <= ((ushort)(temp786)));
                            var temp788 = ((ushort)(((ushort)(temp786)) >> 6));
                            var temp789 = (((ushort)(temp788 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp790 = (((byte)(((byte)((ushort)(temp786))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp791 = (((temp787) && (temp789)) && (temp790));
                            var temp792 = (((ushort)((ushort)1632U)) <= ((ushort)(temp786)));
                            var temp793 = ((byte)(((ushort)(temp786)) >> 11));
                            var temp794 = (((byte)(temp793 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp795 = (((ushort)(((ushort)((ushort)(temp786))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp796 = (((temp792) && (temp794)) && (temp795));
                            var temp797 = (((ushort)((ushort)1776U)) <= ((ushort)(temp786)));
                            var temp798 = (((ushort)(((ushort)((ushort)(temp786))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp799 = (((temp797) && (temp794)) && (temp798));
                            var temp800 = (((ushort)((ushort)1984U)) <= ((ushort)(temp786)));
                            var temp801 = (((ushort)(((ushort)((ushort)(temp786))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp802 = (((temp800) && (temp794)) && (temp801));
                            var temp803 = (((ushort)((ushort)2406U)) <= ((ushort)(temp786)));
                            var temp804 = ((byte)(((ushort)(temp786)) >> 12));
                            var temp805 = (((byte)(temp804 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp806 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp807 = (((temp803) && (temp805)) && (temp806));
                            var temp808 = (((ushort)((ushort)2534U)) <= ((ushort)(temp786)));
                            var temp809 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp810 = (((temp808) && (temp805)) && (temp809));
                            var temp811 = (((ushort)((ushort)2662U)) <= ((ushort)(temp786)));
                            var temp812 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp813 = (((temp811) && (temp805)) && (temp812));
                            var temp814 = (((ushort)((ushort)2790U)) <= ((ushort)(temp786)));
                            var temp815 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp816 = (((temp814) && (temp805)) && (temp815));
                            var temp817 = (((ushort)((ushort)2918U)) <= ((ushort)(temp786)));
                            var temp818 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp819 = (((temp817) && (temp805)) && (temp818));
                            var temp820 = (((ushort)((ushort)3046U)) <= ((ushort)(temp786)));
                            var temp821 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp822 = (((temp820) && (temp805)) && (temp821));
                            var temp823 = (((ushort)((ushort)3174U)) <= ((ushort)(temp786)));
                            var temp824 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp825 = (((temp823) && (temp805)) && (temp824));
                            var temp826 = (((ushort)((ushort)3302U)) <= ((ushort)(temp786)));
                            var temp827 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp828 = (((temp826) && (temp805)) && (temp827));
                            var temp829 = (((ushort)((ushort)3430U)) <= ((ushort)(temp786)));
                            var temp830 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp831 = (((temp829) && (temp805)) && (temp830));
                            var temp832 = (((ushort)((ushort)3664U)) <= ((ushort)(temp786)));
                            var temp833 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp834 = (((temp832) && (temp805)) && (temp833));
                            var temp835 = (((ushort)((ushort)3792U)) <= ((ushort)(temp786)));
                            var temp836 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp837 = (((temp835) && (temp805)) && (temp836));
                            var temp838 = (((ushort)((ushort)3872U)) <= ((ushort)(temp786)));
                            var temp839 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp840 = (((temp838) && (temp805)) && (temp839));
                            var temp841 = (((ushort)((ushort)4160U)) <= ((ushort)(temp786)));
                            var temp842 = ((byte)(((ushort)(temp786)) >> 13));
                            var temp843 = (((byte)(temp842 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp844 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp845 = (((temp841) && (temp843)) && (temp844));
                            var temp846 = (((ushort)((ushort)4240U)) <= ((ushort)(temp786)));
                            var temp847 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp848 = (((temp846) && (temp843)) && (temp847));
                            var temp849 = (((ushort)((ushort)6112U)) <= ((ushort)(temp786)));
                            var temp850 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp851 = (((temp849) && (temp843)) && (temp850));
                            var temp852 = (((ushort)((ushort)6160U)) <= ((ushort)(temp786)));
                            var temp853 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp854 = (((temp852) && (temp843)) && (temp853));
                            var temp855 = (((ushort)((ushort)6470U)) <= ((ushort)(temp786)));
                            var temp856 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp857 = (((temp855) && (temp843)) && (temp856));
                            var temp858 = (((ushort)((ushort)6608U)) <= ((ushort)(temp786)));
                            var temp859 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp860 = (((temp858) && (temp843)) && (temp859));
                            var temp861 = (((ushort)((ushort)6992U)) <= ((ushort)(temp786)));
                            var temp862 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp863 = (((temp861) && (temp843)) && (temp862));
                            var temp864 = (((ushort)((ushort)7088U)) <= ((ushort)(temp786)));
                            var temp865 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp866 = (((temp864) && (temp843)) && (temp865));
                            var temp867 = (((ushort)((ushort)7232U)) <= ((ushort)(temp786)));
                            var temp868 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp869 = (((temp867) && (temp843)) && (temp868));
                            var temp870 = (((ushort)((ushort)7248U)) <= ((ushort)(temp786)));
                            var temp871 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp872 = (((temp870) && (temp843)) && (temp871));
                            var temp873 = (((ushort)((ushort)42528U)) <= ((ushort)(temp786)));
                            var temp874 = (((ushort)(temp786)) <= ((ushort)((ushort)42537U)));
                            var temp875 = ((temp873) && (temp874));
                            var temp876 = (((ushort)((ushort)43216U)) <= ((ushort)(temp786)));
                            var temp877 = (((ushort)(temp786)) <= ((ushort)((ushort)43225U)));
                            var temp878 = ((temp876) && (temp877));
                            var temp879 = (((ushort)((ushort)43264U)) <= ((ushort)(temp786)));
                            var temp880 = (((ushort)(temp786)) <= ((ushort)((ushort)43273U)));
                            var temp881 = ((temp879) && (temp880));
                            var temp882 = (((ushort)((ushort)43600U)) <= ((ushort)(temp786)));
                            var temp883 = (((ushort)(temp786)) <= ((ushort)((ushort)43609U)));
                            var temp884 = ((temp882) && (temp883));
                            var temp885 = (((ushort)((ushort)65296U)) <= ((ushort)(temp786)));
                            var temp886 = (((ushort)(temp786)) <= ((ushort)((ushort)65305U)));
                            var temp887 = ((temp885) && (temp886));
                            var temp888 = (((((((((((((((((((((((((((((((temp791) || (temp796)) || (temp799)) || (temp802)) || (temp807)) || (temp810)) || (temp813)) || (temp816)) || (temp819)) || (temp822)) || (temp825)) || (temp828)) || (temp831)) || (temp834)) || (temp837)) || (temp840)) || (temp845)) || (temp848)) || (temp851)) || (temp854)) || (temp857)) || (temp860)) || (temp863)) || (temp866)) || (temp869)) || (temp872)) || (temp875)) || (temp878)) || (temp881)) || (temp884)) || (temp887));
                            if (temp888)
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M47;
                            }
                            else
                                throw new Exception();
                        }
                        else
                            throw new Exception();
                    }
                }

                M53:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F53;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp889 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp890 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp889)));
                        var temp891 = ((int)((uint)(temp889)) <= (int)((uint)((uint)191U)));
                        var temp892 = ((temp890) && (temp891));
                        if (temp892)
                        {
                            var temp893 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp894 = Fun0(((ushort)((s)._0)), ((ushort)(temp893)));
                            s._0 = ((ushort)(temp894));
                            goto M52;
                        }
                        else
                            throw new Exception();
                    }
                }

                M54:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F54;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp895 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp896 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp895)));
                        var temp897 = ((int)((uint)(temp895)) <= (int)((uint)((uint)159U)));
                        var temp898 = ((temp896) && (temp897));
                        if (temp898)
                        {
                            var temp899 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp900 = Fun0(((ushort)((s)._0)), ((ushort)(temp899)));
                            s._0 = ((ushort)(temp900));
                            goto M52;
                        }
                        else
                            throw new Exception();
                    }
                }

                M55:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F55;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp901 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp902 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp901)));
                        var temp903 = ((int)((uint)(temp901)) <= (int)((uint)((uint)191U)));
                        var temp904 = ((temp902) && (temp903));
                        if (temp904)
                        {
                            var temp905 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp906 = Fun0(((ushort)((s)._0)), ((ushort)(temp905)));
                            s._0 = ((ushort)(temp906));
                            goto M52;
                        }
                        else
                            throw new Exception();
                    }
                }

                M56:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F56;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp907 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp908 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp907)));
                        var temp909 = ((int)((uint)(temp907)) <= (int)((uint)((uint)191U)));
                        var temp910 = ((temp908) && (temp909));
                        if (temp910)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M41;
                        }
                        else
                            throw new Exception();
                    }
                }

                M57:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F57;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp911 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp912 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp911)));
                        var temp913 = ((int)((uint)(temp911)) <= (int)((uint)((uint)191U)));
                        var temp914 = ((temp912) && (temp913));
                        if (temp914)
                        {
                            var temp915 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp916 = Fun0(((ushort)((s)._0)), ((ushort)(temp915)));
                            s._0 = ((ushort)(temp916));
                            goto M56;
                        }
                        else
                            throw new Exception();
                    }
                }

                M58:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F58;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp917 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp918 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp917)));
                        var temp919 = ((int)((uint)(temp917)) <= (int)((uint)((uint)159U)));
                        var temp920 = ((temp918) && (temp919));
                        if (temp920)
                        {
                            var temp921 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp922 = Fun0(((ushort)((s)._0)), ((ushort)(temp921)));
                            s._0 = ((ushort)(temp922));
                            goto M56;
                        }
                        else
                            throw new Exception();
                    }
                }

                M59:
                {
                    if (++iIndex >= read)
                    {
                        read = input.Read(iBuf, 0, iBuf.Length);
                        if (read == 0)
                            goto F59;
                        iIndex = 0;
                    }

                    i = iBuf[iIndex];
                    {
                        var temp923 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp924 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp923)));
                        var temp925 = ((int)((uint)(temp923)) <= (int)((uint)((uint)191U)));
                        var temp926 = ((temp924) && (temp925));
                        if (temp926)
                        {
                            var temp927 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp928 = Fun0(((ushort)((s)._0)), ((ushort)(temp927)));
                            s._0 = ((ushort)(temp928));
                            goto M56;
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
                F40:
                    throw new Exception();
                F41:
                    throw new Exception();
                F42:
                    throw new Exception();
                F43:
                    throw new Exception();
                F44:
                    throw new Exception();
                F45:
                    throw new Exception();
                F46:
                    throw new Exception();
                F47:
                    throw new Exception();
                F48:
                    throw new Exception();
                F49:
                    throw new Exception();
                F50:
                    throw new Exception();
                F51:
                    throw new Exception();
                F52:
                    throw new Exception();
                F53:
                    throw new Exception();
                F54:
                    throw new Exception();
                F55:
                    throw new Exception();
                F56:
                    throw new Exception();
                F57:
                    throw new Exception();
                F58:
                    throw new Exception();
                F59:
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
                DTStruct2 s = new DTStruct2(((ushort)((ushort)0U)), ((uint)((uint)0U)), ((uint)((uint)2147483647U)));
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
                            var temp192 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp192)
                            {
                                goto M26;
                            }
                            else
                            {
                                goto M21;
                            }
                        }
                        else
                        {
                            var temp193 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp188)));
                            var temp194 = ((int)((uint)(temp188)) <= (int)((uint)((uint)223U)));
                            var temp195 = ((temp193) && (temp194));
                            if (temp195)
                            {
                                var temp196 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp196));
                                goto M27;
                            }
                            else
                            {
                                var temp197 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp197)
                                {
                                    var temp198 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp198));
                                    goto M28;
                                }
                                else
                                {
                                    var temp199 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp199)
                                    {
                                        var temp200 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp200));
                                        goto M29;
                                    }
                                    else
                                    {
                                        var temp201 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp188)));
                                        var temp202 = ((int)((uint)(temp188)) <= (int)((uint)((uint)239U)));
                                        var temp203 = ((temp201) && (temp202));
                                        if (temp203)
                                        {
                                            var temp204 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp204));
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
                        var temp205 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp206 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp205)));
                        var temp207 = ((int)((uint)(temp205)) <= (int)((uint)((uint)191U)));
                        var temp208 = ((temp206) && (temp207));
                        if (temp208)
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
                        var temp209 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp210 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp209)));
                        var temp211 = ((int)((uint)(temp209)) <= (int)((uint)((uint)191U)));
                        var temp212 = ((temp210) && (temp211));
                        if (temp212)
                        {
                            var temp213 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp214 = Fun0(((ushort)((s)._0)), ((ushort)(temp213)));
                            s._0 = ((ushort)(temp214));
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
                        var temp215 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp216 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp215)));
                        var temp217 = ((int)((uint)(temp215)) <= (int)((uint)((uint)159U)));
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

                M25:
                {
                    if (++iIndex >= input.Length)
                        goto F25;
                    i = input[iIndex];
                    {
                        var temp221 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp222 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp221)));
                        var temp223 = ((int)((uint)(temp221)) <= (int)((uint)((uint)191U)));
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

                M26:
                {
                    if (++iIndex >= input.Length)
                        goto F26;
                    i = input[iIndex];
                    {
                        var temp227 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp228 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp227)));
                        var temp229 = ((int)((uint)(temp227)) <= (int)((uint)((uint)127U)));
                        var temp230 = ((temp228) && (temp229));
                        if (temp230)
                        {
                            var temp231 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp231)
                            {
                                goto M31;
                            }
                            else
                            {
                                goto M26;
                            }
                        }
                        else
                        {
                            var temp232 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp227)));
                            var temp233 = ((int)((uint)(temp227)) <= (int)((uint)((uint)223U)));
                            var temp234 = ((temp232) && (temp233));
                            if (temp234)
                            {
                                var temp235 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp235));
                                goto M32;
                            }
                            else
                            {
                                var temp236 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp236)
                                {
                                    var temp237 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp237));
                                    goto M33;
                                }
                                else
                                {
                                    var temp238 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp238)
                                    {
                                        var temp239 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp239));
                                        goto M34;
                                    }
                                    else
                                    {
                                        var temp240 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp227)));
                                        var temp241 = ((int)((uint)(temp227)) <= (int)((uint)((uint)239U)));
                                        var temp242 = ((temp240) && (temp241));
                                        if (temp242)
                                        {
                                            var temp243 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp243));
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
                        var temp244 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp245 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp244)));
                        var temp246 = ((int)((uint)(temp244)) <= (int)((uint)((uint)191U)));
                        var temp247 = ((temp245) && (temp246));
                        if (temp247)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M21;
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
                        var temp248 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp249 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp248)));
                        var temp250 = ((int)((uint)(temp248)) <= (int)((uint)((uint)191U)));
                        var temp251 = ((temp249) && (temp250));
                        if (temp251)
                        {
                            var temp252 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp253 = Fun0(((ushort)((s)._0)), ((ushort)(temp252)));
                            s._0 = ((ushort)(temp253));
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
                        var temp254 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp255 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp254)));
                        var temp256 = ((int)((uint)(temp254)) <= (int)((uint)((uint)159U)));
                        var temp257 = ((temp255) && (temp256));
                        if (temp257)
                        {
                            var temp258 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp259 = Fun0(((ushort)((s)._0)), ((ushort)(temp258)));
                            s._0 = ((ushort)(temp259));
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
                        var temp260 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp261 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp260)));
                        var temp262 = ((int)((uint)(temp260)) <= (int)((uint)((uint)191U)));
                        var temp263 = ((temp261) && (temp262));
                        if (temp263)
                        {
                            var temp264 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp265 = Fun0(((ushort)((s)._0)), ((ushort)(temp264)));
                            s._0 = ((ushort)(temp265));
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
                        var temp266 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp267 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp266)));
                        var temp268 = ((int)((uint)(temp266)) <= (int)((uint)((uint)127U)));
                        var temp269 = ((temp267) && (temp268));
                        if (temp269)
                        {
                            var temp270 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp271 = ((byte)(((byte)(i)) >> 6));
                            var temp272 = (((byte)(temp271 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp273 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp274 = (((temp270) && (temp272)) && (temp273));
                            if (temp274)
                            {
                                var temp275 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp276 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp275))) + ((uint)(temp266))));
                                s._1 = ((uint)(temp276));
                                goto M36;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp277 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp266)));
                            var temp278 = ((int)((uint)(temp266)) <= (int)((uint)((uint)223U)));
                            var temp279 = ((temp277) && (temp278));
                            if (temp279)
                            {
                                var temp280 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp280));
                                goto M37;
                            }
                            else
                            {
                                var temp281 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp281)
                                {
                                    var temp282 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp282));
                                    goto M38;
                                }
                                else
                                {
                                    var temp283 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp283)
                                    {
                                        var temp284 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp284));
                                        goto M39;
                                    }
                                    else
                                    {
                                        var temp285 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp266)));
                                        var temp286 = ((int)((uint)(temp266)) <= (int)((uint)((uint)239U)));
                                        var temp287 = ((temp285) && (temp286));
                                        if (temp287)
                                        {
                                            var temp288 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp288));
                                            goto M40;
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
                        var temp289 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp290 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp289)));
                        var temp291 = ((int)((uint)(temp289)) <= (int)((uint)((uint)191U)));
                        var temp292 = ((temp290) && (temp291));
                        if (temp292)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M26;
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
                        var temp293 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp294 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp293)));
                        var temp295 = ((int)((uint)(temp293)) <= (int)((uint)((uint)191U)));
                        var temp296 = ((temp294) && (temp295));
                        if (temp296)
                        {
                            var temp297 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp298 = Fun0(((ushort)((s)._0)), ((ushort)(temp297)));
                            s._0 = ((ushort)(temp298));
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
                        var temp299 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp300 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp299)));
                        var temp301 = ((int)((uint)(temp299)) <= (int)((uint)((uint)159U)));
                        var temp302 = ((temp300) && (temp301));
                        if (temp302)
                        {
                            var temp303 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp304 = Fun0(((ushort)((s)._0)), ((ushort)(temp303)));
                            s._0 = ((ushort)(temp304));
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
                        var temp305 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp306 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp305)));
                        var temp307 = ((int)((uint)(temp305)) <= (int)((uint)((uint)191U)));
                        var temp308 = ((temp306) && (temp307));
                        if (temp308)
                        {
                            var temp309 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp310 = Fun0(((ushort)((s)._0)), ((ushort)(temp309)));
                            s._0 = ((ushort)(temp310));
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
                        var temp311 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp312 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp311)));
                        var temp313 = ((int)((uint)(temp311)) <= (int)((uint)((uint)127U)));
                        var temp314 = ((temp312) && (temp313));
                        if (temp314)
                        {
                            var temp315 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp315)
                            {
                                goto M41;
                            }
                            else
                            {
                                var temp316 = (((byte)(i)) == ((byte)((byte)46U)));
                                if (temp316)
                                {
                                    goto M42;
                                }
                                else
                                {
                                    var temp317 = (((byte)((byte)48U)) <= ((byte)(i)));
                                    var temp318 = ((byte)(((byte)(i)) >> 6));
                                    var temp319 = (((byte)(temp318 & 3L)) == ((byte)((byte)0U & 3L)));
                                    var temp320 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                    var temp321 = (((temp317) && (temp319)) && (temp320));
                                    if (temp321)
                                    {
                                        var temp322 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                        var temp323 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp322))) + ((uint)(temp311))));
                                        s._1 = ((uint)(temp323));
                                        goto M36;
                                    }
                                    else
                                        throw new Exception();
                                }
                            }
                        }
                        else
                        {
                            var temp324 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp311)));
                            var temp325 = ((int)((uint)(temp311)) <= (int)((uint)((uint)223U)));
                            var temp326 = ((temp324) && (temp325));
                            if (temp326)
                            {
                                var temp327 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp327));
                                goto M43;
                            }
                            else
                            {
                                var temp328 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp328)
                                {
                                    var temp329 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp329));
                                    goto M44;
                                }
                                else
                                {
                                    var temp330 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp330)
                                    {
                                        var temp331 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp331));
                                        goto M45;
                                    }
                                    else
                                    {
                                        var temp332 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp311)));
                                        var temp333 = ((int)((uint)(temp311)) <= (int)((uint)((uint)239U)));
                                        var temp334 = ((temp332) && (temp333));
                                        if (temp334)
                                        {
                                            var temp335 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp335));
                                            goto M46;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M37:
                {
                    if (++iIndex >= input.Length)
                        goto F37;
                    i = input[iIndex];
                    {
                        var temp336 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp337 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp336)));
                        var temp338 = ((int)((uint)(temp336)) <= (int)((uint)((uint)191U)));
                        var temp339 = ((temp337) && (temp338));
                        if (temp339)
                        {
                            var temp340 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp341 = Fun0(((ushort)((s)._0)), ((ushort)(temp340)));
                            var temp342 = (((ushort)((ushort)48U)) <= ((ushort)(temp341)));
                            var temp343 = ((ushort)(((ushort)(temp341)) >> 6));
                            var temp344 = (((ushort)(temp343 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp345 = (((byte)(((byte)((ushort)(temp341))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp346 = (((temp342) && (temp344)) && (temp345));
                            var temp347 = (((ushort)((ushort)1632U)) <= ((ushort)(temp341)));
                            var temp348 = ((byte)(((ushort)(temp341)) >> 11));
                            var temp349 = (((byte)(temp348 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp350 = (((ushort)(((ushort)((ushort)(temp341))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp351 = (((temp347) && (temp349)) && (temp350));
                            var temp352 = (((ushort)((ushort)1776U)) <= ((ushort)(temp341)));
                            var temp353 = (((ushort)(((ushort)((ushort)(temp341))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp354 = (((temp352) && (temp349)) && (temp353));
                            var temp355 = (((ushort)((ushort)1984U)) <= ((ushort)(temp341)));
                            var temp356 = (((ushort)(((ushort)((ushort)(temp341))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp357 = (((temp355) && (temp349)) && (temp356));
                            var temp358 = (((ushort)((ushort)2406U)) <= ((ushort)(temp341)));
                            var temp359 = ((byte)(((ushort)(temp341)) >> 12));
                            var temp360 = (((byte)(temp359 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp361 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp362 = (((temp358) && (temp360)) && (temp361));
                            var temp363 = (((ushort)((ushort)2534U)) <= ((ushort)(temp341)));
                            var temp364 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp365 = (((temp363) && (temp360)) && (temp364));
                            var temp366 = (((ushort)((ushort)2662U)) <= ((ushort)(temp341)));
                            var temp367 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp368 = (((temp366) && (temp360)) && (temp367));
                            var temp369 = (((ushort)((ushort)2790U)) <= ((ushort)(temp341)));
                            var temp370 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp371 = (((temp369) && (temp360)) && (temp370));
                            var temp372 = (((ushort)((ushort)2918U)) <= ((ushort)(temp341)));
                            var temp373 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp374 = (((temp372) && (temp360)) && (temp373));
                            var temp375 = (((ushort)((ushort)3046U)) <= ((ushort)(temp341)));
                            var temp376 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp377 = (((temp375) && (temp360)) && (temp376));
                            var temp378 = (((ushort)((ushort)3174U)) <= ((ushort)(temp341)));
                            var temp379 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp380 = (((temp378) && (temp360)) && (temp379));
                            var temp381 = (((ushort)((ushort)3302U)) <= ((ushort)(temp341)));
                            var temp382 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp383 = (((temp381) && (temp360)) && (temp382));
                            var temp384 = (((ushort)((ushort)3430U)) <= ((ushort)(temp341)));
                            var temp385 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp386 = (((temp384) && (temp360)) && (temp385));
                            var temp387 = (((ushort)((ushort)3664U)) <= ((ushort)(temp341)));
                            var temp388 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp389 = (((temp387) && (temp360)) && (temp388));
                            var temp390 = (((ushort)((ushort)3792U)) <= ((ushort)(temp341)));
                            var temp391 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp392 = (((temp390) && (temp360)) && (temp391));
                            var temp393 = (((ushort)((ushort)3872U)) <= ((ushort)(temp341)));
                            var temp394 = (((ushort)(((ushort)((ushort)(temp341))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp395 = (((temp393) && (temp360)) && (temp394));
                            var temp396 = (((ushort)((ushort)4160U)) <= ((ushort)(temp341)));
                            var temp397 = ((byte)(((ushort)(temp341)) >> 13));
                            var temp398 = (((byte)(temp397 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp399 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp400 = (((temp396) && (temp398)) && (temp399));
                            var temp401 = (((ushort)((ushort)4240U)) <= ((ushort)(temp341)));
                            var temp402 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp403 = (((temp401) && (temp398)) && (temp402));
                            var temp404 = (((ushort)((ushort)6112U)) <= ((ushort)(temp341)));
                            var temp405 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp406 = (((temp404) && (temp398)) && (temp405));
                            var temp407 = (((ushort)((ushort)6160U)) <= ((ushort)(temp341)));
                            var temp408 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp409 = (((temp407) && (temp398)) && (temp408));
                            var temp410 = (((ushort)((ushort)6470U)) <= ((ushort)(temp341)));
                            var temp411 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp412 = (((temp410) && (temp398)) && (temp411));
                            var temp413 = (((ushort)((ushort)6608U)) <= ((ushort)(temp341)));
                            var temp414 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp415 = (((temp413) && (temp398)) && (temp414));
                            var temp416 = (((ushort)((ushort)6992U)) <= ((ushort)(temp341)));
                            var temp417 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp418 = (((temp416) && (temp398)) && (temp417));
                            var temp419 = (((ushort)((ushort)7088U)) <= ((ushort)(temp341)));
                            var temp420 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp421 = (((temp419) && (temp398)) && (temp420));
                            var temp422 = (((ushort)((ushort)7232U)) <= ((ushort)(temp341)));
                            var temp423 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp424 = (((temp422) && (temp398)) && (temp423));
                            var temp425 = (((ushort)((ushort)7248U)) <= ((ushort)(temp341)));
                            var temp426 = (((ushort)(((ushort)((ushort)(temp341))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp427 = (((temp425) && (temp398)) && (temp426));
                            var temp428 = (((ushort)((ushort)42528U)) <= ((ushort)(temp341)));
                            var temp429 = (((ushort)(temp341)) <= ((ushort)((ushort)42537U)));
                            var temp430 = ((temp428) && (temp429));
                            var temp431 = (((ushort)((ushort)43216U)) <= ((ushort)(temp341)));
                            var temp432 = (((ushort)(temp341)) <= ((ushort)((ushort)43225U)));
                            var temp433 = ((temp431) && (temp432));
                            var temp434 = (((ushort)((ushort)43264U)) <= ((ushort)(temp341)));
                            var temp435 = (((ushort)(temp341)) <= ((ushort)((ushort)43273U)));
                            var temp436 = ((temp434) && (temp435));
                            var temp437 = (((ushort)((ushort)43600U)) <= ((ushort)(temp341)));
                            var temp438 = (((ushort)(temp341)) <= ((ushort)((ushort)43609U)));
                            var temp439 = ((temp437) && (temp438));
                            var temp440 = (((ushort)((ushort)65296U)) <= ((ushort)(temp341)));
                            var temp441 = (((ushort)(temp341)) <= ((ushort)((ushort)65305U)));
                            var temp442 = ((temp440) && (temp441));
                            var temp443 = (((((((((((((((((((((((((((((((temp346) || (temp351)) || (temp354)) || (temp357)) || (temp362)) || (temp365)) || (temp368)) || (temp371)) || (temp374)) || (temp377)) || (temp380)) || (temp383)) || (temp386)) || (temp389)) || (temp392)) || (temp395)) || (temp400)) || (temp403)) || (temp406)) || (temp409)) || (temp412)) || (temp415)) || (temp418)) || (temp421)) || (temp424)) || (temp427)) || (temp430)) || (temp433)) || (temp436)) || (temp439)) || (temp442));
                            if (temp443)
                            {
                                var temp444 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp445 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp341));
                                var temp446 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp444))) + ((uint)(temp445))));
                                s._1 = ((uint)(temp446));
                                s._0 = ((ushort)((ushort)0U));
                                goto M36;
                            }
                            else
                                throw new Exception();
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
                        var temp447 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp448 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp447)));
                        var temp449 = ((int)((uint)(temp447)) <= (int)((uint)((uint)191U)));
                        var temp450 = ((temp448) && (temp449));
                        if (temp450)
                        {
                            var temp451 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp452 = Fun0(((ushort)((s)._0)), ((ushort)(temp451)));
                            s._0 = ((ushort)(temp452));
                            goto M37;
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
                        var temp453 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp454 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp453)));
                        var temp455 = ((int)((uint)(temp453)) <= (int)((uint)((uint)159U)));
                        var temp456 = ((temp454) && (temp455));
                        if (temp456)
                        {
                            var temp457 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp458 = Fun0(((ushort)((s)._0)), ((ushort)(temp457)));
                            s._0 = ((ushort)(temp458));
                            goto M37;
                        }
                        else
                            throw new Exception();
                    }
                }

                M40:
                {
                    if (++iIndex >= input.Length)
                        goto F40;
                    i = input[iIndex];
                    {
                        var temp459 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp460 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp459)));
                        var temp461 = ((int)((uint)(temp459)) <= (int)((uint)((uint)191U)));
                        var temp462 = ((temp460) && (temp461));
                        if (temp462)
                        {
                            var temp463 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp464 = Fun0(((ushort)((s)._0)), ((ushort)(temp463)));
                            s._0 = ((ushort)(temp464));
                            goto M37;
                        }
                        else
                            throw new Exception();
                    }
                }

                M41:
                {
                    if (++iIndex >= input.Length)
                        goto F41;
                    i = input[iIndex];
                    {
                        var temp465 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp466 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp465)));
                        var temp467 = ((int)((uint)(temp465)) <= (int)((uint)((uint)127U)));
                        var temp468 = ((temp466) && (temp467));
                        if (temp468)
                        {
                            var temp469 = (((byte)(i)) == ((byte)((byte)10U)));
                            if (temp469)
                            {
                                var temp470 = Fun1(((uint)((s)._1)), ((uint)((s)._2)));
                                s._2 = ((uint)(temp470));
                                s._1 = ((uint)((uint)0U));
                                goto M0;
                            }
                            else
                            {
                                goto M41;
                            }
                        }
                        else
                        {
                            var temp471 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp465)));
                            var temp472 = ((int)((uint)(temp465)) <= (int)((uint)((uint)223U)));
                            var temp473 = ((temp471) && (temp472));
                            if (temp473)
                            {
                                var temp474 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp474));
                                goto M56;
                            }
                            else
                            {
                                var temp475 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp475)
                                {
                                    var temp476 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp476));
                                    goto M57;
                                }
                                else
                                {
                                    var temp477 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp477)
                                    {
                                        var temp478 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp478));
                                        goto M58;
                                    }
                                    else
                                    {
                                        var temp479 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp465)));
                                        var temp480 = ((int)((uint)(temp465)) <= (int)((uint)((uint)239U)));
                                        var temp481 = ((temp479) && (temp480));
                                        if (temp481)
                                        {
                                            var temp482 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp482));
                                            goto M59;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M42:
                {
                    if (++iIndex >= input.Length)
                        goto F42;
                    i = input[iIndex];
                    {
                        var temp483 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp484 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp483)));
                        var temp485 = ((int)((uint)(temp483)) <= (int)((uint)((uint)127U)));
                        var temp486 = ((temp484) && (temp485));
                        if (temp486)
                        {
                            var temp487 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp488 = ((byte)(((byte)(i)) >> 6));
                            var temp489 = (((byte)(temp488 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp490 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp491 = (((temp487) && (temp489)) && (temp490));
                            if (temp491)
                            {
                                goto M47;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp492 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp483)));
                            var temp493 = ((int)((uint)(temp483)) <= (int)((uint)((uint)223U)));
                            var temp494 = ((temp492) && (temp493));
                            if (temp494)
                            {
                                var temp495 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp495));
                                goto M48;
                            }
                            else
                            {
                                var temp496 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp496)
                                {
                                    var temp497 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp497));
                                    goto M49;
                                }
                                else
                                {
                                    var temp498 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp498)
                                    {
                                        var temp499 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp499));
                                        goto M50;
                                    }
                                    else
                                    {
                                        var temp500 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp483)));
                                        var temp501 = ((int)((uint)(temp483)) <= (int)((uint)((uint)239U)));
                                        var temp502 = ((temp500) && (temp501));
                                        if (temp502)
                                        {
                                            var temp503 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp503));
                                            goto M51;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M43:
                {
                    if (++iIndex >= input.Length)
                        goto F43;
                    i = input[iIndex];
                    {
                        var temp504 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp505 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp504)));
                        var temp506 = ((int)((uint)(temp504)) <= (int)((uint)((uint)191U)));
                        var temp507 = ((temp505) && (temp506));
                        if (temp507)
                        {
                            var temp508 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp509 = Fun0(((ushort)((s)._0)), ((ushort)(temp508)));
                            var temp510 = (((ushort)((ushort)48U)) <= ((ushort)(temp509)));
                            var temp511 = ((ushort)(((ushort)(temp509)) >> 6));
                            var temp512 = (((ushort)(temp511 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp513 = (((byte)(((byte)((ushort)(temp509))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp514 = (((temp510) && (temp512)) && (temp513));
                            var temp515 = (((ushort)((ushort)1632U)) <= ((ushort)(temp509)));
                            var temp516 = ((byte)(((ushort)(temp509)) >> 11));
                            var temp517 = (((byte)(temp516 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp518 = (((ushort)(((ushort)((ushort)(temp509))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp519 = (((temp515) && (temp517)) && (temp518));
                            var temp520 = (((ushort)((ushort)1776U)) <= ((ushort)(temp509)));
                            var temp521 = (((ushort)(((ushort)((ushort)(temp509))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp522 = (((temp520) && (temp517)) && (temp521));
                            var temp523 = (((ushort)((ushort)1984U)) <= ((ushort)(temp509)));
                            var temp524 = (((ushort)(((ushort)((ushort)(temp509))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp525 = (((temp523) && (temp517)) && (temp524));
                            var temp526 = (((ushort)((ushort)2406U)) <= ((ushort)(temp509)));
                            var temp527 = ((byte)(((ushort)(temp509)) >> 12));
                            var temp528 = (((byte)(temp527 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp529 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp530 = (((temp526) && (temp528)) && (temp529));
                            var temp531 = (((ushort)((ushort)2534U)) <= ((ushort)(temp509)));
                            var temp532 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp533 = (((temp531) && (temp528)) && (temp532));
                            var temp534 = (((ushort)((ushort)2662U)) <= ((ushort)(temp509)));
                            var temp535 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp536 = (((temp534) && (temp528)) && (temp535));
                            var temp537 = (((ushort)((ushort)2790U)) <= ((ushort)(temp509)));
                            var temp538 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp539 = (((temp537) && (temp528)) && (temp538));
                            var temp540 = (((ushort)((ushort)2918U)) <= ((ushort)(temp509)));
                            var temp541 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp542 = (((temp540) && (temp528)) && (temp541));
                            var temp543 = (((ushort)((ushort)3046U)) <= ((ushort)(temp509)));
                            var temp544 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp545 = (((temp543) && (temp528)) && (temp544));
                            var temp546 = (((ushort)((ushort)3174U)) <= ((ushort)(temp509)));
                            var temp547 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp548 = (((temp546) && (temp528)) && (temp547));
                            var temp549 = (((ushort)((ushort)3302U)) <= ((ushort)(temp509)));
                            var temp550 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp551 = (((temp549) && (temp528)) && (temp550));
                            var temp552 = (((ushort)((ushort)3430U)) <= ((ushort)(temp509)));
                            var temp553 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp554 = (((temp552) && (temp528)) && (temp553));
                            var temp555 = (((ushort)((ushort)3664U)) <= ((ushort)(temp509)));
                            var temp556 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp557 = (((temp555) && (temp528)) && (temp556));
                            var temp558 = (((ushort)((ushort)3792U)) <= ((ushort)(temp509)));
                            var temp559 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp560 = (((temp558) && (temp528)) && (temp559));
                            var temp561 = (((ushort)((ushort)3872U)) <= ((ushort)(temp509)));
                            var temp562 = (((ushort)(((ushort)((ushort)(temp509))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp563 = (((temp561) && (temp528)) && (temp562));
                            var temp564 = (((ushort)((ushort)4160U)) <= ((ushort)(temp509)));
                            var temp565 = ((byte)(((ushort)(temp509)) >> 13));
                            var temp566 = (((byte)(temp565 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp567 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp568 = (((temp564) && (temp566)) && (temp567));
                            var temp569 = (((ushort)((ushort)4240U)) <= ((ushort)(temp509)));
                            var temp570 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp571 = (((temp569) && (temp566)) && (temp570));
                            var temp572 = (((ushort)((ushort)6112U)) <= ((ushort)(temp509)));
                            var temp573 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp574 = (((temp572) && (temp566)) && (temp573));
                            var temp575 = (((ushort)((ushort)6160U)) <= ((ushort)(temp509)));
                            var temp576 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp577 = (((temp575) && (temp566)) && (temp576));
                            var temp578 = (((ushort)((ushort)6470U)) <= ((ushort)(temp509)));
                            var temp579 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp580 = (((temp578) && (temp566)) && (temp579));
                            var temp581 = (((ushort)((ushort)6608U)) <= ((ushort)(temp509)));
                            var temp582 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp583 = (((temp581) && (temp566)) && (temp582));
                            var temp584 = (((ushort)((ushort)6992U)) <= ((ushort)(temp509)));
                            var temp585 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp586 = (((temp584) && (temp566)) && (temp585));
                            var temp587 = (((ushort)((ushort)7088U)) <= ((ushort)(temp509)));
                            var temp588 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp589 = (((temp587) && (temp566)) && (temp588));
                            var temp590 = (((ushort)((ushort)7232U)) <= ((ushort)(temp509)));
                            var temp591 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp592 = (((temp590) && (temp566)) && (temp591));
                            var temp593 = (((ushort)((ushort)7248U)) <= ((ushort)(temp509)));
                            var temp594 = (((ushort)(((ushort)((ushort)(temp509))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp595 = (((temp593) && (temp566)) && (temp594));
                            var temp596 = (((ushort)((ushort)42528U)) <= ((ushort)(temp509)));
                            var temp597 = (((ushort)(temp509)) <= ((ushort)((ushort)42537U)));
                            var temp598 = ((temp596) && (temp597));
                            var temp599 = (((ushort)((ushort)43216U)) <= ((ushort)(temp509)));
                            var temp600 = (((ushort)(temp509)) <= ((ushort)((ushort)43225U)));
                            var temp601 = ((temp599) && (temp600));
                            var temp602 = (((ushort)((ushort)43264U)) <= ((ushort)(temp509)));
                            var temp603 = (((ushort)(temp509)) <= ((ushort)((ushort)43273U)));
                            var temp604 = ((temp602) && (temp603));
                            var temp605 = (((ushort)((ushort)43600U)) <= ((ushort)(temp509)));
                            var temp606 = (((ushort)(temp509)) <= ((ushort)((ushort)43609U)));
                            var temp607 = ((temp605) && (temp606));
                            var temp608 = (((ushort)((ushort)65296U)) <= ((ushort)(temp509)));
                            var temp609 = (((ushort)(temp509)) <= ((ushort)((ushort)65305U)));
                            var temp610 = ((temp608) && (temp609));
                            var temp611 = (((((((((((((((((((((((((((((((temp514) || (temp519)) || (temp522)) || (temp525)) || (temp530)) || (temp533)) || (temp536)) || (temp539)) || (temp542)) || (temp545)) || (temp548)) || (temp551)) || (temp554)) || (temp557)) || (temp560)) || (temp563)) || (temp568)) || (temp571)) || (temp574)) || (temp577)) || (temp580)) || (temp583)) || (temp586)) || (temp589)) || (temp592)) || (temp595)) || (temp598)) || (temp601)) || (temp604)) || (temp607)) || (temp610));
                            if (temp611)
                            {
                                var temp612 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp613 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp509));
                                var temp614 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp612))) + ((uint)(temp613))));
                                s._1 = ((uint)(temp614));
                                s._0 = ((ushort)((ushort)0U));
                                goto M36;
                            }
                            else
                                throw new Exception();
                        }
                        else
                            throw new Exception();
                    }
                }

                M44:
                {
                    if (++iIndex >= input.Length)
                        goto F44;
                    i = input[iIndex];
                    {
                        var temp615 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp616 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp615)));
                        var temp617 = ((int)((uint)(temp615)) <= (int)((uint)((uint)191U)));
                        var temp618 = ((temp616) && (temp617));
                        if (temp618)
                        {
                            var temp619 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp620 = Fun0(((ushort)((s)._0)), ((ushort)(temp619)));
                            s._0 = ((ushort)(temp620));
                            goto M43;
                        }
                        else
                            throw new Exception();
                    }
                }

                M45:
                {
                    if (++iIndex >= input.Length)
                        goto F45;
                    i = input[iIndex];
                    {
                        var temp621 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp622 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp621)));
                        var temp623 = ((int)((uint)(temp621)) <= (int)((uint)((uint)159U)));
                        var temp624 = ((temp622) && (temp623));
                        if (temp624)
                        {
                            var temp625 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp626 = Fun0(((ushort)((s)._0)), ((ushort)(temp625)));
                            s._0 = ((ushort)(temp626));
                            goto M43;
                        }
                        else
                            throw new Exception();
                    }
                }

                M46:
                {
                    if (++iIndex >= input.Length)
                        goto F46;
                    i = input[iIndex];
                    {
                        var temp627 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp628 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp627)));
                        var temp629 = ((int)((uint)(temp627)) <= (int)((uint)((uint)191U)));
                        var temp630 = ((temp628) && (temp629));
                        if (temp630)
                        {
                            var temp631 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp632 = Fun0(((ushort)((s)._0)), ((ushort)(temp631)));
                            s._0 = ((ushort)(temp632));
                            goto M43;
                        }
                        else
                            throw new Exception();
                    }
                }

                M47:
                {
                    if (++iIndex >= input.Length)
                        goto F47;
                    i = input[iIndex];
                    {
                        var temp633 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp634 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp633)));
                        var temp635 = ((int)((uint)(temp633)) <= (int)((uint)((uint)127U)));
                        var temp636 = ((temp634) && (temp635));
                        if (temp636)
                        {
                            var temp637 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp637)
                            {
                                goto M41;
                            }
                            else
                            {
                                var temp638 = (((byte)((byte)48U)) <= ((byte)(i)));
                                var temp639 = ((byte)(((byte)(i)) >> 6));
                                var temp640 = (((byte)(temp639 & 3L)) == ((byte)((byte)0U & 3L)));
                                var temp641 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp642 = (((temp638) && (temp640)) && (temp641));
                                if (temp642)
                                {
                                    goto M47;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                        else
                        {
                            var temp643 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp633)));
                            var temp644 = ((int)((uint)(temp633)) <= (int)((uint)((uint)223U)));
                            var temp645 = ((temp643) && (temp644));
                            if (temp645)
                            {
                                var temp646 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp646));
                                goto M52;
                            }
                            else
                            {
                                var temp647 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp647)
                                {
                                    var temp648 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp648));
                                    goto M53;
                                }
                                else
                                {
                                    var temp649 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp649)
                                    {
                                        var temp650 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp650));
                                        goto M54;
                                    }
                                    else
                                    {
                                        var temp651 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp633)));
                                        var temp652 = ((int)((uint)(temp633)) <= (int)((uint)((uint)239U)));
                                        var temp653 = ((temp651) && (temp652));
                                        if (temp653)
                                        {
                                            var temp654 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp654));
                                            goto M55;
                                        }
                                        else
                                            throw new Exception();
                                    }
                                }
                            }
                        }
                    }
                }

                M48:
                {
                    if (++iIndex >= input.Length)
                        goto F48;
                    i = input[iIndex];
                    {
                        var temp655 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp656 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp655)));
                        var temp657 = ((int)((uint)(temp655)) <= (int)((uint)((uint)191U)));
                        var temp658 = ((temp656) && (temp657));
                        if (temp658)
                        {
                            var temp659 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp660 = Fun0(((ushort)((s)._0)), ((ushort)(temp659)));
                            var temp661 = (((ushort)((ushort)48U)) <= ((ushort)(temp660)));
                            var temp662 = ((ushort)(((ushort)(temp660)) >> 6));
                            var temp663 = (((ushort)(temp662 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp664 = (((byte)(((byte)((ushort)(temp660))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp665 = (((temp661) && (temp663)) && (temp664));
                            var temp666 = (((ushort)((ushort)1632U)) <= ((ushort)(temp660)));
                            var temp667 = ((byte)(((ushort)(temp660)) >> 11));
                            var temp668 = (((byte)(temp667 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp669 = (((ushort)(((ushort)((ushort)(temp660))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp670 = (((temp666) && (temp668)) && (temp669));
                            var temp671 = (((ushort)((ushort)1776U)) <= ((ushort)(temp660)));
                            var temp672 = (((ushort)(((ushort)((ushort)(temp660))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp673 = (((temp671) && (temp668)) && (temp672));
                            var temp674 = (((ushort)((ushort)1984U)) <= ((ushort)(temp660)));
                            var temp675 = (((ushort)(((ushort)((ushort)(temp660))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp676 = (((temp674) && (temp668)) && (temp675));
                            var temp677 = (((ushort)((ushort)2406U)) <= ((ushort)(temp660)));
                            var temp678 = ((byte)(((ushort)(temp660)) >> 12));
                            var temp679 = (((byte)(temp678 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp680 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp681 = (((temp677) && (temp679)) && (temp680));
                            var temp682 = (((ushort)((ushort)2534U)) <= ((ushort)(temp660)));
                            var temp683 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp684 = (((temp682) && (temp679)) && (temp683));
                            var temp685 = (((ushort)((ushort)2662U)) <= ((ushort)(temp660)));
                            var temp686 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp687 = (((temp685) && (temp679)) && (temp686));
                            var temp688 = (((ushort)((ushort)2790U)) <= ((ushort)(temp660)));
                            var temp689 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp690 = (((temp688) && (temp679)) && (temp689));
                            var temp691 = (((ushort)((ushort)2918U)) <= ((ushort)(temp660)));
                            var temp692 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp693 = (((temp691) && (temp679)) && (temp692));
                            var temp694 = (((ushort)((ushort)3046U)) <= ((ushort)(temp660)));
                            var temp695 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp696 = (((temp694) && (temp679)) && (temp695));
                            var temp697 = (((ushort)((ushort)3174U)) <= ((ushort)(temp660)));
                            var temp698 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp699 = (((temp697) && (temp679)) && (temp698));
                            var temp700 = (((ushort)((ushort)3302U)) <= ((ushort)(temp660)));
                            var temp701 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp702 = (((temp700) && (temp679)) && (temp701));
                            var temp703 = (((ushort)((ushort)3430U)) <= ((ushort)(temp660)));
                            var temp704 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp705 = (((temp703) && (temp679)) && (temp704));
                            var temp706 = (((ushort)((ushort)3664U)) <= ((ushort)(temp660)));
                            var temp707 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp708 = (((temp706) && (temp679)) && (temp707));
                            var temp709 = (((ushort)((ushort)3792U)) <= ((ushort)(temp660)));
                            var temp710 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp711 = (((temp709) && (temp679)) && (temp710));
                            var temp712 = (((ushort)((ushort)3872U)) <= ((ushort)(temp660)));
                            var temp713 = (((ushort)(((ushort)((ushort)(temp660))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp714 = (((temp712) && (temp679)) && (temp713));
                            var temp715 = (((ushort)((ushort)4160U)) <= ((ushort)(temp660)));
                            var temp716 = ((byte)(((ushort)(temp660)) >> 13));
                            var temp717 = (((byte)(temp716 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp718 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp719 = (((temp715) && (temp717)) && (temp718));
                            var temp720 = (((ushort)((ushort)4240U)) <= ((ushort)(temp660)));
                            var temp721 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp722 = (((temp720) && (temp717)) && (temp721));
                            var temp723 = (((ushort)((ushort)6112U)) <= ((ushort)(temp660)));
                            var temp724 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp725 = (((temp723) && (temp717)) && (temp724));
                            var temp726 = (((ushort)((ushort)6160U)) <= ((ushort)(temp660)));
                            var temp727 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp728 = (((temp726) && (temp717)) && (temp727));
                            var temp729 = (((ushort)((ushort)6470U)) <= ((ushort)(temp660)));
                            var temp730 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp731 = (((temp729) && (temp717)) && (temp730));
                            var temp732 = (((ushort)((ushort)6608U)) <= ((ushort)(temp660)));
                            var temp733 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp734 = (((temp732) && (temp717)) && (temp733));
                            var temp735 = (((ushort)((ushort)6992U)) <= ((ushort)(temp660)));
                            var temp736 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp737 = (((temp735) && (temp717)) && (temp736));
                            var temp738 = (((ushort)((ushort)7088U)) <= ((ushort)(temp660)));
                            var temp739 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp740 = (((temp738) && (temp717)) && (temp739));
                            var temp741 = (((ushort)((ushort)7232U)) <= ((ushort)(temp660)));
                            var temp742 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp743 = (((temp741) && (temp717)) && (temp742));
                            var temp744 = (((ushort)((ushort)7248U)) <= ((ushort)(temp660)));
                            var temp745 = (((ushort)(((ushort)((ushort)(temp660))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp746 = (((temp744) && (temp717)) && (temp745));
                            var temp747 = (((ushort)((ushort)42528U)) <= ((ushort)(temp660)));
                            var temp748 = (((ushort)(temp660)) <= ((ushort)((ushort)42537U)));
                            var temp749 = ((temp747) && (temp748));
                            var temp750 = (((ushort)((ushort)43216U)) <= ((ushort)(temp660)));
                            var temp751 = (((ushort)(temp660)) <= ((ushort)((ushort)43225U)));
                            var temp752 = ((temp750) && (temp751));
                            var temp753 = (((ushort)((ushort)43264U)) <= ((ushort)(temp660)));
                            var temp754 = (((ushort)(temp660)) <= ((ushort)((ushort)43273U)));
                            var temp755 = ((temp753) && (temp754));
                            var temp756 = (((ushort)((ushort)43600U)) <= ((ushort)(temp660)));
                            var temp757 = (((ushort)(temp660)) <= ((ushort)((ushort)43609U)));
                            var temp758 = ((temp756) && (temp757));
                            var temp759 = (((ushort)((ushort)65296U)) <= ((ushort)(temp660)));
                            var temp760 = (((ushort)(temp660)) <= ((ushort)((ushort)65305U)));
                            var temp761 = ((temp759) && (temp760));
                            var temp762 = (((((((((((((((((((((((((((((((temp665) || (temp670)) || (temp673)) || (temp676)) || (temp681)) || (temp684)) || (temp687)) || (temp690)) || (temp693)) || (temp696)) || (temp699)) || (temp702)) || (temp705)) || (temp708)) || (temp711)) || (temp714)) || (temp719)) || (temp722)) || (temp725)) || (temp728)) || (temp731)) || (temp734)) || (temp737)) || (temp740)) || (temp743)) || (temp746)) || (temp749)) || (temp752)) || (temp755)) || (temp758)) || (temp761));
                            if (temp762)
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M47;
                            }
                            else
                                throw new Exception();
                        }
                        else
                            throw new Exception();
                    }
                }

                M49:
                {
                    if (++iIndex >= input.Length)
                        goto F49;
                    i = input[iIndex];
                    {
                        var temp763 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp764 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp763)));
                        var temp765 = ((int)((uint)(temp763)) <= (int)((uint)((uint)191U)));
                        var temp766 = ((temp764) && (temp765));
                        if (temp766)
                        {
                            var temp767 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp768 = Fun0(((ushort)((s)._0)), ((ushort)(temp767)));
                            s._0 = ((ushort)(temp768));
                            goto M48;
                        }
                        else
                            throw new Exception();
                    }
                }

                M50:
                {
                    if (++iIndex >= input.Length)
                        goto F50;
                    i = input[iIndex];
                    {
                        var temp769 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp770 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp769)));
                        var temp771 = ((int)((uint)(temp769)) <= (int)((uint)((uint)159U)));
                        var temp772 = ((temp770) && (temp771));
                        if (temp772)
                        {
                            var temp773 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp774 = Fun0(((ushort)((s)._0)), ((ushort)(temp773)));
                            s._0 = ((ushort)(temp774));
                            goto M48;
                        }
                        else
                            throw new Exception();
                    }
                }

                M51:
                {
                    if (++iIndex >= input.Length)
                        goto F51;
                    i = input[iIndex];
                    {
                        var temp775 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp776 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp775)));
                        var temp777 = ((int)((uint)(temp775)) <= (int)((uint)((uint)191U)));
                        var temp778 = ((temp776) && (temp777));
                        if (temp778)
                        {
                            var temp779 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp780 = Fun0(((ushort)((s)._0)), ((ushort)(temp779)));
                            s._0 = ((ushort)(temp780));
                            goto M48;
                        }
                        else
                            throw new Exception();
                    }
                }

                M52:
                {
                    if (++iIndex >= input.Length)
                        goto F52;
                    i = input[iIndex];
                    {
                        var temp781 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp782 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp781)));
                        var temp783 = ((int)((uint)(temp781)) <= (int)((uint)((uint)191U)));
                        var temp784 = ((temp782) && (temp783));
                        if (temp784)
                        {
                            var temp785 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp786 = Fun0(((ushort)((s)._0)), ((ushort)(temp785)));
                            var temp787 = (((ushort)((ushort)48U)) <= ((ushort)(temp786)));
                            var temp788 = ((ushort)(((ushort)(temp786)) >> 6));
                            var temp789 = (((ushort)(temp788 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp790 = (((byte)(((byte)((ushort)(temp786))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp791 = (((temp787) && (temp789)) && (temp790));
                            var temp792 = (((ushort)((ushort)1632U)) <= ((ushort)(temp786)));
                            var temp793 = ((byte)(((ushort)(temp786)) >> 11));
                            var temp794 = (((byte)(temp793 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp795 = (((ushort)(((ushort)((ushort)(temp786))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp796 = (((temp792) && (temp794)) && (temp795));
                            var temp797 = (((ushort)((ushort)1776U)) <= ((ushort)(temp786)));
                            var temp798 = (((ushort)(((ushort)((ushort)(temp786))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp799 = (((temp797) && (temp794)) && (temp798));
                            var temp800 = (((ushort)((ushort)1984U)) <= ((ushort)(temp786)));
                            var temp801 = (((ushort)(((ushort)((ushort)(temp786))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp802 = (((temp800) && (temp794)) && (temp801));
                            var temp803 = (((ushort)((ushort)2406U)) <= ((ushort)(temp786)));
                            var temp804 = ((byte)(((ushort)(temp786)) >> 12));
                            var temp805 = (((byte)(temp804 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp806 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp807 = (((temp803) && (temp805)) && (temp806));
                            var temp808 = (((ushort)((ushort)2534U)) <= ((ushort)(temp786)));
                            var temp809 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp810 = (((temp808) && (temp805)) && (temp809));
                            var temp811 = (((ushort)((ushort)2662U)) <= ((ushort)(temp786)));
                            var temp812 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp813 = (((temp811) && (temp805)) && (temp812));
                            var temp814 = (((ushort)((ushort)2790U)) <= ((ushort)(temp786)));
                            var temp815 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp816 = (((temp814) && (temp805)) && (temp815));
                            var temp817 = (((ushort)((ushort)2918U)) <= ((ushort)(temp786)));
                            var temp818 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp819 = (((temp817) && (temp805)) && (temp818));
                            var temp820 = (((ushort)((ushort)3046U)) <= ((ushort)(temp786)));
                            var temp821 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp822 = (((temp820) && (temp805)) && (temp821));
                            var temp823 = (((ushort)((ushort)3174U)) <= ((ushort)(temp786)));
                            var temp824 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp825 = (((temp823) && (temp805)) && (temp824));
                            var temp826 = (((ushort)((ushort)3302U)) <= ((ushort)(temp786)));
                            var temp827 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp828 = (((temp826) && (temp805)) && (temp827));
                            var temp829 = (((ushort)((ushort)3430U)) <= ((ushort)(temp786)));
                            var temp830 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp831 = (((temp829) && (temp805)) && (temp830));
                            var temp832 = (((ushort)((ushort)3664U)) <= ((ushort)(temp786)));
                            var temp833 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp834 = (((temp832) && (temp805)) && (temp833));
                            var temp835 = (((ushort)((ushort)3792U)) <= ((ushort)(temp786)));
                            var temp836 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp837 = (((temp835) && (temp805)) && (temp836));
                            var temp838 = (((ushort)((ushort)3872U)) <= ((ushort)(temp786)));
                            var temp839 = (((ushort)(((ushort)((ushort)(temp786))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp840 = (((temp838) && (temp805)) && (temp839));
                            var temp841 = (((ushort)((ushort)4160U)) <= ((ushort)(temp786)));
                            var temp842 = ((byte)(((ushort)(temp786)) >> 13));
                            var temp843 = (((byte)(temp842 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp844 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp845 = (((temp841) && (temp843)) && (temp844));
                            var temp846 = (((ushort)((ushort)4240U)) <= ((ushort)(temp786)));
                            var temp847 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp848 = (((temp846) && (temp843)) && (temp847));
                            var temp849 = (((ushort)((ushort)6112U)) <= ((ushort)(temp786)));
                            var temp850 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp851 = (((temp849) && (temp843)) && (temp850));
                            var temp852 = (((ushort)((ushort)6160U)) <= ((ushort)(temp786)));
                            var temp853 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp854 = (((temp852) && (temp843)) && (temp853));
                            var temp855 = (((ushort)((ushort)6470U)) <= ((ushort)(temp786)));
                            var temp856 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp857 = (((temp855) && (temp843)) && (temp856));
                            var temp858 = (((ushort)((ushort)6608U)) <= ((ushort)(temp786)));
                            var temp859 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp860 = (((temp858) && (temp843)) && (temp859));
                            var temp861 = (((ushort)((ushort)6992U)) <= ((ushort)(temp786)));
                            var temp862 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp863 = (((temp861) && (temp843)) && (temp862));
                            var temp864 = (((ushort)((ushort)7088U)) <= ((ushort)(temp786)));
                            var temp865 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp866 = (((temp864) && (temp843)) && (temp865));
                            var temp867 = (((ushort)((ushort)7232U)) <= ((ushort)(temp786)));
                            var temp868 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp869 = (((temp867) && (temp843)) && (temp868));
                            var temp870 = (((ushort)((ushort)7248U)) <= ((ushort)(temp786)));
                            var temp871 = (((ushort)(((ushort)((ushort)(temp786))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp872 = (((temp870) && (temp843)) && (temp871));
                            var temp873 = (((ushort)((ushort)42528U)) <= ((ushort)(temp786)));
                            var temp874 = (((ushort)(temp786)) <= ((ushort)((ushort)42537U)));
                            var temp875 = ((temp873) && (temp874));
                            var temp876 = (((ushort)((ushort)43216U)) <= ((ushort)(temp786)));
                            var temp877 = (((ushort)(temp786)) <= ((ushort)((ushort)43225U)));
                            var temp878 = ((temp876) && (temp877));
                            var temp879 = (((ushort)((ushort)43264U)) <= ((ushort)(temp786)));
                            var temp880 = (((ushort)(temp786)) <= ((ushort)((ushort)43273U)));
                            var temp881 = ((temp879) && (temp880));
                            var temp882 = (((ushort)((ushort)43600U)) <= ((ushort)(temp786)));
                            var temp883 = (((ushort)(temp786)) <= ((ushort)((ushort)43609U)));
                            var temp884 = ((temp882) && (temp883));
                            var temp885 = (((ushort)((ushort)65296U)) <= ((ushort)(temp786)));
                            var temp886 = (((ushort)(temp786)) <= ((ushort)((ushort)65305U)));
                            var temp887 = ((temp885) && (temp886));
                            var temp888 = (((((((((((((((((((((((((((((((temp791) || (temp796)) || (temp799)) || (temp802)) || (temp807)) || (temp810)) || (temp813)) || (temp816)) || (temp819)) || (temp822)) || (temp825)) || (temp828)) || (temp831)) || (temp834)) || (temp837)) || (temp840)) || (temp845)) || (temp848)) || (temp851)) || (temp854)) || (temp857)) || (temp860)) || (temp863)) || (temp866)) || (temp869)) || (temp872)) || (temp875)) || (temp878)) || (temp881)) || (temp884)) || (temp887));
                            if (temp888)
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M47;
                            }
                            else
                                throw new Exception();
                        }
                        else
                            throw new Exception();
                    }
                }

                M53:
                {
                    if (++iIndex >= input.Length)
                        goto F53;
                    i = input[iIndex];
                    {
                        var temp889 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp890 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp889)));
                        var temp891 = ((int)((uint)(temp889)) <= (int)((uint)((uint)191U)));
                        var temp892 = ((temp890) && (temp891));
                        if (temp892)
                        {
                            var temp893 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp894 = Fun0(((ushort)((s)._0)), ((ushort)(temp893)));
                            s._0 = ((ushort)(temp894));
                            goto M52;
                        }
                        else
                            throw new Exception();
                    }
                }

                M54:
                {
                    if (++iIndex >= input.Length)
                        goto F54;
                    i = input[iIndex];
                    {
                        var temp895 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp896 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp895)));
                        var temp897 = ((int)((uint)(temp895)) <= (int)((uint)((uint)159U)));
                        var temp898 = ((temp896) && (temp897));
                        if (temp898)
                        {
                            var temp899 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp900 = Fun0(((ushort)((s)._0)), ((ushort)(temp899)));
                            s._0 = ((ushort)(temp900));
                            goto M52;
                        }
                        else
                            throw new Exception();
                    }
                }

                M55:
                {
                    if (++iIndex >= input.Length)
                        goto F55;
                    i = input[iIndex];
                    {
                        var temp901 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp902 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp901)));
                        var temp903 = ((int)((uint)(temp901)) <= (int)((uint)((uint)191U)));
                        var temp904 = ((temp902) && (temp903));
                        if (temp904)
                        {
                            var temp905 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp906 = Fun0(((ushort)((s)._0)), ((ushort)(temp905)));
                            s._0 = ((ushort)(temp906));
                            goto M52;
                        }
                        else
                            throw new Exception();
                    }
                }

                M56:
                {
                    if (++iIndex >= input.Length)
                        goto F56;
                    i = input[iIndex];
                    {
                        var temp907 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp908 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp907)));
                        var temp909 = ((int)((uint)(temp907)) <= (int)((uint)((uint)191U)));
                        var temp910 = ((temp908) && (temp909));
                        if (temp910)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M41;
                        }
                        else
                            throw new Exception();
                    }
                }

                M57:
                {
                    if (++iIndex >= input.Length)
                        goto F57;
                    i = input[iIndex];
                    {
                        var temp911 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp912 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp911)));
                        var temp913 = ((int)((uint)(temp911)) <= (int)((uint)((uint)191U)));
                        var temp914 = ((temp912) && (temp913));
                        if (temp914)
                        {
                            var temp915 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp916 = Fun0(((ushort)((s)._0)), ((ushort)(temp915)));
                            s._0 = ((ushort)(temp916));
                            goto M56;
                        }
                        else
                            throw new Exception();
                    }
                }

                M58:
                {
                    if (++iIndex >= input.Length)
                        goto F58;
                    i = input[iIndex];
                    {
                        var temp917 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp918 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp917)));
                        var temp919 = ((int)((uint)(temp917)) <= (int)((uint)((uint)159U)));
                        var temp920 = ((temp918) && (temp919));
                        if (temp920)
                        {
                            var temp921 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp922 = Fun0(((ushort)((s)._0)), ((ushort)(temp921)));
                            s._0 = ((ushort)(temp922));
                            goto M56;
                        }
                        else
                            throw new Exception();
                    }
                }

                M59:
                {
                    if (++iIndex >= input.Length)
                        goto F59;
                    i = input[iIndex];
                    {
                        var temp923 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp924 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp923)));
                        var temp925 = ((int)((uint)(temp923)) <= (int)((uint)((uint)191U)));
                        var temp926 = ((temp924) && (temp925));
                        if (temp926)
                        {
                            var temp927 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp928 = Fun0(((ushort)((s)._0)), ((ushort)(temp927)));
                            s._0 = ((ushort)(temp928));
                            goto M56;
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
                F40:
                    throw new Exception();
                F41:
                    throw new Exception();
                F42:
                    throw new Exception();
                F43:
                    throw new Exception();
                F44:
                    throw new Exception();
                F45:
                    throw new Exception();
                F46:
                    throw new Exception();
                F47:
                    throw new Exception();
                F48:
                    throw new Exception();
                F49:
                    throw new Exception();
                F50:
                    throw new Exception();
                F51:
                    throw new Exception();
                F52:
                    throw new Exception();
                F53:
                    throw new Exception();
                F54:
                    throw new Exception();
                F55:
                    throw new Exception();
                F56:
                    throw new Exception();
                F57:
                    throw new Exception();
                F58:
                    throw new Exception();
                F59:
                    throw new Exception();
            }
        }
    }
}