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

        struct DTStruct40
        {
            public UInt16 _0;
            public UInt32 _1;
            public UInt32 _2;
            public DTStruct40(UInt16 v0, UInt32 v1, UInt32 v2)
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
                DTStruct40 s = new DTStruct40(((ushort)((ushort)0U)), ((uint)((uint)0U)), ((uint)((uint)2147483647U)));
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
                            var temp44 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp45 = Fun0(((ushort)((s)._0)), ((ushort)(temp44)));
                            var temp46 = (((ushort)(temp45)) == ((ushort)((ushort)44U)));
                            if (temp46)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M0;
                            }
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
                        var temp50 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp51 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp50)));
                        var temp52 = ((int)((uint)(temp50)) <= (int)((uint)((uint)191U)));
                        var temp53 = ((temp51) && (temp52));
                        if (temp53)
                        {
                            var temp54 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp55 = Fun0(((ushort)((s)._0)), ((ushort)(temp54)));
                            s._0 = ((ushort)(temp55));
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
                        var temp59 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp60 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp59)));
                        var temp61 = ((int)((uint)(temp59)) <= (int)((uint)((uint)159U)));
                        var temp62 = ((temp60) && (temp61));
                        if (temp62)
                        {
                            var temp63 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp64 = Fun0(((ushort)((s)._0)), ((ushort)(temp63)));
                            s._0 = ((ushort)(temp64));
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
                        var temp68 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp69 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp68)));
                        var temp70 = ((int)((uint)(temp68)) <= (int)((uint)((uint)191U)));
                        var temp71 = ((temp69) && (temp70));
                        if (temp71)
                        {
                            var temp72 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp73 = Fun0(((ushort)((s)._0)), ((ushort)(temp72)));
                            s._0 = ((ushort)(temp73));
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
                        var temp74 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp75 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp74)));
                        var temp76 = ((int)((uint)(temp74)) <= (int)((uint)((uint)127U)));
                        var temp77 = ((temp75) && (temp76));
                        if (temp77)
                        {
                            var temp78 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp78)
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
                            var temp79 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp74)));
                            var temp80 = ((int)((uint)(temp74)) <= (int)((uint)((uint)223U)));
                            var temp81 = ((temp79) && (temp80));
                            if (temp81)
                            {
                                var temp82 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp82));
                                goto M12;
                            }
                            else
                            {
                                var temp83 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp83)
                                {
                                    var temp84 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp84));
                                    goto M13;
                                }
                                else
                                {
                                    var temp85 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp85)
                                    {
                                        var temp86 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp86));
                                        goto M14;
                                    }
                                    else
                                    {
                                        var temp87 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp74)));
                                        var temp88 = ((int)((uint)(temp74)) <= (int)((uint)((uint)239U)));
                                        var temp89 = ((temp87) && (temp88));
                                        if (temp89)
                                        {
                                            var temp90 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp90));
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
                        var temp91 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp92 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp91)));
                        var temp93 = ((int)((uint)(temp91)) <= (int)((uint)((uint)191U)));
                        var temp94 = ((temp92) && (temp93));
                        if (temp94)
                        {
                            var temp95 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp96 = Fun0(((ushort)((s)._0)), ((ushort)(temp95)));
                            var temp97 = (((ushort)(temp96)) == ((ushort)((ushort)44U)));
                            if (temp97)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M1;
                            }
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
                        var temp98 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp99 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp98)));
                        var temp100 = ((int)((uint)(temp98)) <= (int)((uint)((uint)191U)));
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

                M9:
                {
                    if (!ie.MoveNext())
                        goto F9;
                    i = ie.Current;
                    {
                        var temp104 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp105 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp104)));
                        var temp106 = ((int)((uint)(temp104)) <= (int)((uint)((uint)159U)));
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

                M10:
                {
                    if (!ie.MoveNext())
                        goto F10;
                    i = ie.Current;
                    {
                        var temp110 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp111 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp110)));
                        var temp112 = ((int)((uint)(temp110)) <= (int)((uint)((uint)191U)));
                        var temp113 = ((temp111) && (temp112));
                        if (temp113)
                        {
                            var temp114 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp115 = Fun0(((ushort)((s)._0)), ((ushort)(temp114)));
                            s._0 = ((ushort)(temp115));
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
                        var temp116 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp117 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp116)));
                        var temp118 = ((int)((uint)(temp116)) <= (int)((uint)((uint)127U)));
                        var temp119 = ((temp117) && (temp118));
                        if (temp119)
                        {
                            var temp120 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp120)
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
                            var temp121 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp116)));
                            var temp122 = ((int)((uint)(temp116)) <= (int)((uint)((uint)223U)));
                            var temp123 = ((temp121) && (temp122));
                            if (temp123)
                            {
                                var temp124 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp124));
                                goto M17;
                            }
                            else
                            {
                                var temp125 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp125)
                                {
                                    var temp126 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp126));
                                    goto M18;
                                }
                                else
                                {
                                    var temp127 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp127)
                                    {
                                        var temp128 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp128));
                                        goto M19;
                                    }
                                    else
                                    {
                                        var temp129 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp116)));
                                        var temp130 = ((int)((uint)(temp116)) <= (int)((uint)((uint)239U)));
                                        var temp131 = ((temp129) && (temp130));
                                        if (temp131)
                                        {
                                            var temp132 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp132));
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
                        var temp133 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp134 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp133)));
                        var temp135 = ((int)((uint)(temp133)) <= (int)((uint)((uint)191U)));
                        var temp136 = ((temp134) && (temp135));
                        if (temp136)
                        {
                            var temp137 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp138 = Fun0(((ushort)((s)._0)), ((ushort)(temp137)));
                            var temp139 = (((ushort)(temp138)) == ((ushort)((ushort)44U)));
                            if (temp139)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M6;
                            }
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
                        var temp140 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp141 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp140)));
                        var temp142 = ((int)((uint)(temp140)) <= (int)((uint)((uint)191U)));
                        var temp143 = ((temp141) && (temp142));
                        if (temp143)
                        {
                            var temp144 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp145 = Fun0(((ushort)((s)._0)), ((ushort)(temp144)));
                            s._0 = ((ushort)(temp145));
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
                        var temp146 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp147 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp146)));
                        var temp148 = ((int)((uint)(temp146)) <= (int)((uint)((uint)159U)));
                        var temp149 = ((temp147) && (temp148));
                        if (temp149)
                        {
                            var temp150 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp151 = Fun0(((ushort)((s)._0)), ((ushort)(temp150)));
                            s._0 = ((ushort)(temp151));
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
                        var temp152 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp153 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp152)));
                        var temp154 = ((int)((uint)(temp152)) <= (int)((uint)((uint)191U)));
                        var temp155 = ((temp153) && (temp154));
                        if (temp155)
                        {
                            var temp156 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp157 = Fun0(((ushort)((s)._0)), ((ushort)(temp156)));
                            s._0 = ((ushort)(temp157));
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
                        var temp158 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp159 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp158)));
                        var temp160 = ((int)((uint)(temp158)) <= (int)((uint)((uint)127U)));
                        var temp161 = ((temp159) && (temp160));
                        if (temp161)
                        {
                            var temp162 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp162)
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
                            var temp163 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp158)));
                            var temp164 = ((int)((uint)(temp158)) <= (int)((uint)((uint)223U)));
                            var temp165 = ((temp163) && (temp164));
                            if (temp165)
                            {
                                var temp166 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp166));
                                goto M22;
                            }
                            else
                            {
                                var temp167 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp167)
                                {
                                    var temp168 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp168));
                                    goto M23;
                                }
                                else
                                {
                                    var temp169 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp169)
                                    {
                                        var temp170 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp170));
                                        goto M24;
                                    }
                                    else
                                    {
                                        var temp171 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp158)));
                                        var temp172 = ((int)((uint)(temp158)) <= (int)((uint)((uint)239U)));
                                        var temp173 = ((temp171) && (temp172));
                                        if (temp173)
                                        {
                                            var temp174 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp174));
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
                        var temp175 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp176 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp175)));
                        var temp177 = ((int)((uint)(temp175)) <= (int)((uint)((uint)191U)));
                        var temp178 = ((temp176) && (temp177));
                        if (temp178)
                        {
                            var temp179 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp180 = Fun0(((ushort)((s)._0)), ((ushort)(temp179)));
                            var temp181 = (((ushort)(temp180)) == ((ushort)((ushort)44U)));
                            if (temp181)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M11;
                            }
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
                        var temp182 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp183 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp182)));
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

                M19:
                {
                    if (!ie.MoveNext())
                        goto F19;
                    i = ie.Current;
                    {
                        var temp188 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp189 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp188)));
                        var temp190 = ((int)((uint)(temp188)) <= (int)((uint)((uint)159U)));
                        var temp191 = ((temp189) && (temp190));
                        if (temp191)
                        {
                            var temp192 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp193 = Fun0(((ushort)((s)._0)), ((ushort)(temp192)));
                            s._0 = ((ushort)(temp193));
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
                        var temp194 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp195 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp194)));
                        var temp196 = ((int)((uint)(temp194)) <= (int)((uint)((uint)191U)));
                        var temp197 = ((temp195) && (temp196));
                        if (temp197)
                        {
                            var temp198 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp199 = Fun0(((ushort)((s)._0)), ((ushort)(temp198)));
                            s._0 = ((ushort)(temp199));
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
                        var temp200 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp201 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp200)));
                        var temp202 = ((int)((uint)(temp200)) <= (int)((uint)((uint)127U)));
                        var temp203 = ((temp201) && (temp202));
                        if (temp203)
                        {
                            var temp204 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp204)
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
                            var temp205 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp200)));
                            var temp206 = ((int)((uint)(temp200)) <= (int)((uint)((uint)223U)));
                            var temp207 = ((temp205) && (temp206));
                            if (temp207)
                            {
                                var temp208 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp208));
                                goto M27;
                            }
                            else
                            {
                                var temp209 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp209)
                                {
                                    var temp210 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp210));
                                    goto M28;
                                }
                                else
                                {
                                    var temp211 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp211)
                                    {
                                        var temp212 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp212));
                                        goto M29;
                                    }
                                    else
                                    {
                                        var temp213 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp200)));
                                        var temp214 = ((int)((uint)(temp200)) <= (int)((uint)((uint)239U)));
                                        var temp215 = ((temp213) && (temp214));
                                        if (temp215)
                                        {
                                            var temp216 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp216));
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
                        var temp217 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp218 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp217)));
                        var temp219 = ((int)((uint)(temp217)) <= (int)((uint)((uint)191U)));
                        var temp220 = ((temp218) && (temp219));
                        if (temp220)
                        {
                            var temp221 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp222 = Fun0(((ushort)((s)._0)), ((ushort)(temp221)));
                            var temp223 = (((ushort)(temp222)) == ((ushort)((ushort)44U)));
                            if (temp223)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M16;
                            }
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
                        var temp224 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp225 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp224)));
                        var temp226 = ((int)((uint)(temp224)) <= (int)((uint)((uint)191U)));
                        var temp227 = ((temp225) && (temp226));
                        if (temp227)
                        {
                            var temp228 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp229 = Fun0(((ushort)((s)._0)), ((ushort)(temp228)));
                            s._0 = ((ushort)(temp229));
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
                        var temp230 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp231 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp230)));
                        var temp232 = ((int)((uint)(temp230)) <= (int)((uint)((uint)159U)));
                        var temp233 = ((temp231) && (temp232));
                        if (temp233)
                        {
                            var temp234 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp235 = Fun0(((ushort)((s)._0)), ((ushort)(temp234)));
                            s._0 = ((ushort)(temp235));
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
                        var temp236 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp237 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp236)));
                        var temp238 = ((int)((uint)(temp236)) <= (int)((uint)((uint)191U)));
                        var temp239 = ((temp237) && (temp238));
                        if (temp239)
                        {
                            var temp240 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp241 = Fun0(((ushort)((s)._0)), ((ushort)(temp240)));
                            s._0 = ((ushort)(temp241));
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
                        var temp242 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp243 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp242)));
                        var temp244 = ((int)((uint)(temp242)) <= (int)((uint)((uint)127U)));
                        var temp245 = ((temp243) && (temp244));
                        if (temp245)
                        {
                            var temp246 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp246)
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
                            var temp247 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp242)));
                            var temp248 = ((int)((uint)(temp242)) <= (int)((uint)((uint)223U)));
                            var temp249 = ((temp247) && (temp248));
                            if (temp249)
                            {
                                var temp250 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp250));
                                goto M32;
                            }
                            else
                            {
                                var temp251 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp251)
                                {
                                    var temp252 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp252));
                                    goto M33;
                                }
                                else
                                {
                                    var temp253 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp253)
                                    {
                                        var temp254 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp254));
                                        goto M34;
                                    }
                                    else
                                    {
                                        var temp255 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp242)));
                                        var temp256 = ((int)((uint)(temp242)) <= (int)((uint)((uint)239U)));
                                        var temp257 = ((temp255) && (temp256));
                                        if (temp257)
                                        {
                                            var temp258 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp258));
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
                        var temp259 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp260 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp259)));
                        var temp261 = ((int)((uint)(temp259)) <= (int)((uint)((uint)191U)));
                        var temp262 = ((temp260) && (temp261));
                        if (temp262)
                        {
                            var temp263 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp264 = Fun0(((ushort)((s)._0)), ((ushort)(temp263)));
                            var temp265 = (((ushort)(temp264)) == ((ushort)((ushort)44U)));
                            if (temp265)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M21;
                            }
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
                        var temp266 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp267 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp266)));
                        var temp268 = ((int)((uint)(temp266)) <= (int)((uint)((uint)191U)));
                        var temp269 = ((temp267) && (temp268));
                        if (temp269)
                        {
                            var temp270 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp271 = Fun0(((ushort)((s)._0)), ((ushort)(temp270)));
                            s._0 = ((ushort)(temp271));
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
                        var temp272 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp273 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp272)));
                        var temp274 = ((int)((uint)(temp272)) <= (int)((uint)((uint)159U)));
                        var temp275 = ((temp273) && (temp274));
                        if (temp275)
                        {
                            var temp276 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp277 = Fun0(((ushort)((s)._0)), ((ushort)(temp276)));
                            s._0 = ((ushort)(temp277));
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
                        var temp278 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp279 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp278)));
                        var temp280 = ((int)((uint)(temp278)) <= (int)((uint)((uint)191U)));
                        var temp281 = ((temp279) && (temp280));
                        if (temp281)
                        {
                            var temp282 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp283 = Fun0(((ushort)((s)._0)), ((ushort)(temp282)));
                            s._0 = ((ushort)(temp283));
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
                        var temp284 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp285 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp284)));
                        var temp286 = ((int)((uint)(temp284)) <= (int)((uint)((uint)127U)));
                        var temp287 = ((temp285) && (temp286));
                        if (temp287)
                        {
                            var temp288 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp289 = ((byte)(((byte)(i)) >> 6));
                            var temp290 = (((byte)(temp289 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp291 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp292 = (((temp288) && (temp290)) && (temp291));
                            if (temp292)
                            {
                                var temp293 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp294 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp293))) + ((uint)(temp284))));
                                s._1 = ((uint)(temp294));
                                goto M36;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp295 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp284)));
                            var temp296 = ((int)((uint)(temp284)) <= (int)((uint)((uint)223U)));
                            var temp297 = ((temp295) && (temp296));
                            if (temp297)
                            {
                                var temp298 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp298));
                                goto M37;
                            }
                            else
                            {
                                var temp299 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp299)
                                {
                                    var temp300 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp300));
                                    goto M38;
                                }
                                else
                                {
                                    var temp301 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp301)
                                    {
                                        var temp302 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp302));
                                        goto M39;
                                    }
                                    else
                                    {
                                        var temp303 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp284)));
                                        var temp304 = ((int)((uint)(temp284)) <= (int)((uint)((uint)239U)));
                                        var temp305 = ((temp303) && (temp304));
                                        if (temp305)
                                        {
                                            var temp306 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp306));
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
                        var temp307 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp308 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp307)));
                        var temp309 = ((int)((uint)(temp307)) <= (int)((uint)((uint)191U)));
                        var temp310 = ((temp308) && (temp309));
                        if (temp310)
                        {
                            var temp311 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp312 = Fun0(((ushort)((s)._0)), ((ushort)(temp311)));
                            var temp313 = (((ushort)(temp312)) == ((ushort)((ushort)44U)));
                            if (temp313)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M26;
                            }
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
                        var temp314 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp315 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp314)));
                        var temp316 = ((int)((uint)(temp314)) <= (int)((uint)((uint)191U)));
                        var temp317 = ((temp315) && (temp316));
                        if (temp317)
                        {
                            var temp318 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp319 = Fun0(((ushort)((s)._0)), ((ushort)(temp318)));
                            s._0 = ((ushort)(temp319));
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
                        var temp320 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp321 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp320)));
                        var temp322 = ((int)((uint)(temp320)) <= (int)((uint)((uint)159U)));
                        var temp323 = ((temp321) && (temp322));
                        if (temp323)
                        {
                            var temp324 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp325 = Fun0(((ushort)((s)._0)), ((ushort)(temp324)));
                            s._0 = ((ushort)(temp325));
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
                        var temp326 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp327 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp326)));
                        var temp328 = ((int)((uint)(temp326)) <= (int)((uint)((uint)191U)));
                        var temp329 = ((temp327) && (temp328));
                        if (temp329)
                        {
                            var temp330 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp331 = Fun0(((ushort)((s)._0)), ((ushort)(temp330)));
                            s._0 = ((ushort)(temp331));
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
                        var temp332 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp333 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp332)));
                        var temp334 = ((int)((uint)(temp332)) <= (int)((uint)((uint)127U)));
                        var temp335 = ((temp333) && (temp334));
                        if (temp335)
                        {
                            var temp336 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp336)
                            {
                                goto M41;
                            }
                            else
                            {
                                var temp337 = (((byte)(i)) == ((byte)((byte)46U)));
                                if (temp337)
                                {
                                    goto M42;
                                }
                                else
                                {
                                    var temp338 = (((byte)((byte)48U)) <= ((byte)(i)));
                                    var temp339 = ((byte)(((byte)(i)) >> 6));
                                    var temp340 = (((byte)(temp339 & 3L)) == ((byte)((byte)0U & 3L)));
                                    var temp341 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                    var temp342 = (((temp338) && (temp340)) && (temp341));
                                    if (temp342)
                                    {
                                        var temp343 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                        var temp344 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp343))) + ((uint)(temp332))));
                                        s._1 = ((uint)(temp344));
                                        goto M36;
                                    }
                                    else
                                        throw new Exception();
                                }
                            }
                        }
                        else
                        {
                            var temp345 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp332)));
                            var temp346 = ((int)((uint)(temp332)) <= (int)((uint)((uint)223U)));
                            var temp347 = ((temp345) && (temp346));
                            if (temp347)
                            {
                                var temp348 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp348));
                                goto M43;
                            }
                            else
                            {
                                var temp349 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp349)
                                {
                                    var temp350 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp350));
                                    goto M44;
                                }
                                else
                                {
                                    var temp351 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp351)
                                    {
                                        var temp352 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp352));
                                        goto M45;
                                    }
                                    else
                                    {
                                        var temp353 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp332)));
                                        var temp354 = ((int)((uint)(temp332)) <= (int)((uint)((uint)239U)));
                                        var temp355 = ((temp353) && (temp354));
                                        if (temp355)
                                        {
                                            var temp356 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp356));
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
                        var temp357 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp358 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp357)));
                        var temp359 = ((int)((uint)(temp357)) <= (int)((uint)((uint)191U)));
                        var temp360 = ((temp358) && (temp359));
                        if (temp360)
                        {
                            var temp361 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp362 = Fun0(((ushort)((s)._0)), ((ushort)(temp361)));
                            var temp363 = (((ushort)((ushort)48U)) <= ((ushort)(temp362)));
                            var temp364 = ((ushort)(((ushort)(temp362)) >> 6));
                            var temp365 = (((ushort)(temp364 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp366 = (((byte)(((byte)((ushort)(temp362))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp367 = (((temp363) && (temp365)) && (temp366));
                            var temp368 = (((ushort)((ushort)1632U)) <= ((ushort)(temp362)));
                            var temp369 = ((byte)(((ushort)(temp362)) >> 11));
                            var temp370 = (((byte)(temp369 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp371 = (((ushort)(((ushort)((ushort)(temp362))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp372 = (((temp368) && (temp370)) && (temp371));
                            var temp373 = (((ushort)((ushort)1776U)) <= ((ushort)(temp362)));
                            var temp374 = (((ushort)(((ushort)((ushort)(temp362))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp375 = (((temp373) && (temp370)) && (temp374));
                            var temp376 = (((ushort)((ushort)1984U)) <= ((ushort)(temp362)));
                            var temp377 = (((ushort)(((ushort)((ushort)(temp362))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp378 = (((temp376) && (temp370)) && (temp377));
                            var temp379 = (((ushort)((ushort)2406U)) <= ((ushort)(temp362)));
                            var temp380 = ((byte)(((ushort)(temp362)) >> 12));
                            var temp381 = (((byte)(temp380 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp382 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp383 = (((temp379) && (temp381)) && (temp382));
                            var temp384 = (((ushort)((ushort)2534U)) <= ((ushort)(temp362)));
                            var temp385 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp386 = (((temp384) && (temp381)) && (temp385));
                            var temp387 = (((ushort)((ushort)2662U)) <= ((ushort)(temp362)));
                            var temp388 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp389 = (((temp387) && (temp381)) && (temp388));
                            var temp390 = (((ushort)((ushort)2790U)) <= ((ushort)(temp362)));
                            var temp391 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp392 = (((temp390) && (temp381)) && (temp391));
                            var temp393 = (((ushort)((ushort)2918U)) <= ((ushort)(temp362)));
                            var temp394 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp395 = (((temp393) && (temp381)) && (temp394));
                            var temp396 = (((ushort)((ushort)3046U)) <= ((ushort)(temp362)));
                            var temp397 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp398 = (((temp396) && (temp381)) && (temp397));
                            var temp399 = (((ushort)((ushort)3174U)) <= ((ushort)(temp362)));
                            var temp400 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp401 = (((temp399) && (temp381)) && (temp400));
                            var temp402 = (((ushort)((ushort)3302U)) <= ((ushort)(temp362)));
                            var temp403 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp404 = (((temp402) && (temp381)) && (temp403));
                            var temp405 = (((ushort)((ushort)3430U)) <= ((ushort)(temp362)));
                            var temp406 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp407 = (((temp405) && (temp381)) && (temp406));
                            var temp408 = (((ushort)((ushort)3664U)) <= ((ushort)(temp362)));
                            var temp409 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp410 = (((temp408) && (temp381)) && (temp409));
                            var temp411 = (((ushort)((ushort)3792U)) <= ((ushort)(temp362)));
                            var temp412 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp413 = (((temp411) && (temp381)) && (temp412));
                            var temp414 = (((ushort)((ushort)3872U)) <= ((ushort)(temp362)));
                            var temp415 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp416 = (((temp414) && (temp381)) && (temp415));
                            var temp417 = (((ushort)((ushort)4160U)) <= ((ushort)(temp362)));
                            var temp418 = ((byte)(((ushort)(temp362)) >> 13));
                            var temp419 = (((byte)(temp418 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp420 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp421 = (((temp417) && (temp419)) && (temp420));
                            var temp422 = (((ushort)((ushort)4240U)) <= ((ushort)(temp362)));
                            var temp423 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp424 = (((temp422) && (temp419)) && (temp423));
                            var temp425 = (((ushort)((ushort)6112U)) <= ((ushort)(temp362)));
                            var temp426 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp427 = (((temp425) && (temp419)) && (temp426));
                            var temp428 = (((ushort)((ushort)6160U)) <= ((ushort)(temp362)));
                            var temp429 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp430 = (((temp428) && (temp419)) && (temp429));
                            var temp431 = (((ushort)((ushort)6470U)) <= ((ushort)(temp362)));
                            var temp432 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp433 = (((temp431) && (temp419)) && (temp432));
                            var temp434 = (((ushort)((ushort)6608U)) <= ((ushort)(temp362)));
                            var temp435 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp436 = (((temp434) && (temp419)) && (temp435));
                            var temp437 = (((ushort)((ushort)6992U)) <= ((ushort)(temp362)));
                            var temp438 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp439 = (((temp437) && (temp419)) && (temp438));
                            var temp440 = (((ushort)((ushort)7088U)) <= ((ushort)(temp362)));
                            var temp441 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp442 = (((temp440) && (temp419)) && (temp441));
                            var temp443 = (((ushort)((ushort)7232U)) <= ((ushort)(temp362)));
                            var temp444 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp445 = (((temp443) && (temp419)) && (temp444));
                            var temp446 = (((ushort)((ushort)7248U)) <= ((ushort)(temp362)));
                            var temp447 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp448 = (((temp446) && (temp419)) && (temp447));
                            var temp449 = (((ushort)((ushort)42528U)) <= ((ushort)(temp362)));
                            var temp450 = (((ushort)(temp362)) <= ((ushort)((ushort)42537U)));
                            var temp451 = ((temp449) && (temp450));
                            var temp452 = (((ushort)((ushort)43216U)) <= ((ushort)(temp362)));
                            var temp453 = (((ushort)(temp362)) <= ((ushort)((ushort)43225U)));
                            var temp454 = ((temp452) && (temp453));
                            var temp455 = (((ushort)((ushort)43264U)) <= ((ushort)(temp362)));
                            var temp456 = (((ushort)(temp362)) <= ((ushort)((ushort)43273U)));
                            var temp457 = ((temp455) && (temp456));
                            var temp458 = (((ushort)((ushort)43600U)) <= ((ushort)(temp362)));
                            var temp459 = (((ushort)(temp362)) <= ((ushort)((ushort)43609U)));
                            var temp460 = ((temp458) && (temp459));
                            var temp461 = (((ushort)((ushort)65296U)) <= ((ushort)(temp362)));
                            var temp462 = (((ushort)(temp362)) <= ((ushort)((ushort)65305U)));
                            var temp463 = ((temp461) && (temp462));
                            var temp464 = (((((((((((((((((((((((((((((((temp367) || (temp372)) || (temp375)) || (temp378)) || (temp383)) || (temp386)) || (temp389)) || (temp392)) || (temp395)) || (temp398)) || (temp401)) || (temp404)) || (temp407)) || (temp410)) || (temp413)) || (temp416)) || (temp421)) || (temp424)) || (temp427)) || (temp430)) || (temp433)) || (temp436)) || (temp439)) || (temp442)) || (temp445)) || (temp448)) || (temp451)) || (temp454)) || (temp457)) || (temp460)) || (temp463));
                            if (temp464)
                            {
                                var temp465 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp466 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp362));
                                var temp467 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp465))) + ((uint)(temp466))));
                                s._1 = ((uint)(temp467));
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
                        var temp468 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp469 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp468)));
                        var temp470 = ((int)((uint)(temp468)) <= (int)((uint)((uint)191U)));
                        var temp471 = ((temp469) && (temp470));
                        if (temp471)
                        {
                            var temp472 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp473 = Fun0(((ushort)((s)._0)), ((ushort)(temp472)));
                            s._0 = ((ushort)(temp473));
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
                        var temp474 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp475 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp474)));
                        var temp476 = ((int)((uint)(temp474)) <= (int)((uint)((uint)159U)));
                        var temp477 = ((temp475) && (temp476));
                        if (temp477)
                        {
                            var temp478 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp479 = Fun0(((ushort)((s)._0)), ((ushort)(temp478)));
                            s._0 = ((ushort)(temp479));
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
                        var temp480 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp481 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp480)));
                        var temp482 = ((int)((uint)(temp480)) <= (int)((uint)((uint)191U)));
                        var temp483 = ((temp481) && (temp482));
                        if (temp483)
                        {
                            var temp484 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp485 = Fun0(((ushort)((s)._0)), ((ushort)(temp484)));
                            s._0 = ((ushort)(temp485));
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
                        var temp486 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp487 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp486)));
                        var temp488 = ((int)((uint)(temp486)) <= (int)((uint)((uint)127U)));
                        var temp489 = ((temp487) && (temp488));
                        if (temp489)
                        {
                            var temp490 = (((byte)(i)) == ((byte)((byte)10U)));
                            if (temp490)
                            {
                                var temp491 = Fun1(((uint)((s)._1)), ((uint)((s)._2)));
                                s._2 = ((uint)(temp491));
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
                            var temp492 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp486)));
                            var temp493 = ((int)((uint)(temp486)) <= (int)((uint)((uint)223U)));
                            var temp494 = ((temp492) && (temp493));
                            if (temp494)
                            {
                                var temp495 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp495));
                                goto M56;
                            }
                            else
                            {
                                var temp496 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp496)
                                {
                                    var temp497 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp497));
                                    goto M57;
                                }
                                else
                                {
                                    var temp498 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp498)
                                    {
                                        var temp499 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp499));
                                        goto M58;
                                    }
                                    else
                                    {
                                        var temp500 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp486)));
                                        var temp501 = ((int)((uint)(temp486)) <= (int)((uint)((uint)239U)));
                                        var temp502 = ((temp500) && (temp501));
                                        if (temp502)
                                        {
                                            var temp503 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp503));
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
                        var temp504 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp505 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp504)));
                        var temp506 = ((int)((uint)(temp504)) <= (int)((uint)((uint)127U)));
                        var temp507 = ((temp505) && (temp506));
                        if (temp507)
                        {
                            var temp508 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp509 = ((byte)(((byte)(i)) >> 6));
                            var temp510 = (((byte)(temp509 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp511 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp512 = (((temp508) && (temp510)) && (temp511));
                            if (temp512)
                            {
                                goto M47;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp513 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp504)));
                            var temp514 = ((int)((uint)(temp504)) <= (int)((uint)((uint)223U)));
                            var temp515 = ((temp513) && (temp514));
                            if (temp515)
                            {
                                var temp516 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp516));
                                goto M48;
                            }
                            else
                            {
                                var temp517 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp517)
                                {
                                    var temp518 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp518));
                                    goto M49;
                                }
                                else
                                {
                                    var temp519 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp519)
                                    {
                                        var temp520 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp520));
                                        goto M50;
                                    }
                                    else
                                    {
                                        var temp521 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp504)));
                                        var temp522 = ((int)((uint)(temp504)) <= (int)((uint)((uint)239U)));
                                        var temp523 = ((temp521) && (temp522));
                                        if (temp523)
                                        {
                                            var temp524 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp524));
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
                        var temp525 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp526 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp525)));
                        var temp527 = ((int)((uint)(temp525)) <= (int)((uint)((uint)191U)));
                        var temp528 = ((temp526) && (temp527));
                        if (temp528)
                        {
                            var temp529 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp530 = Fun0(((ushort)((s)._0)), ((ushort)(temp529)));
                            var temp531 = (((ushort)(temp530)) == ((ushort)((ushort)44U)));
                            if (temp531)
                                throw new Exception();
                            else
                            {
                                var temp532 = (((ushort)(temp530)) == ((ushort)((ushort)46U)));
                                if (temp532)
                                    throw new Exception();
                                else
                                {
                                    var temp533 = (((ushort)((ushort)48U)) <= ((ushort)(temp530)));
                                    var temp534 = ((ushort)(((ushort)(temp530)) >> 6));
                                    var temp535 = (((ushort)(temp534 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                    var temp536 = (((byte)(((byte)((ushort)(temp530))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                    var temp537 = (((temp533) && (temp535)) && (temp536));
                                    var temp538 = (((ushort)((ushort)1632U)) <= ((ushort)(temp530)));
                                    var temp539 = ((byte)(((ushort)(temp530)) >> 11));
                                    var temp540 = (((byte)(temp539 & 31L)) == ((byte)((byte)0U & 31L)));
                                    var temp541 = (((ushort)(((ushort)((ushort)(temp530))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                    var temp542 = (((temp538) && (temp540)) && (temp541));
                                    var temp543 = (((ushort)((ushort)1776U)) <= ((ushort)(temp530)));
                                    var temp544 = (((ushort)(((ushort)((ushort)(temp530))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                    var temp545 = (((temp543) && (temp540)) && (temp544));
                                    var temp546 = (((ushort)((ushort)1984U)) <= ((ushort)(temp530)));
                                    var temp547 = (((ushort)(((ushort)((ushort)(temp530))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                    var temp548 = (((temp546) && (temp540)) && (temp547));
                                    var temp549 = (((ushort)((ushort)2406U)) <= ((ushort)(temp530)));
                                    var temp550 = ((byte)(((ushort)(temp530)) >> 12));
                                    var temp551 = (((byte)(temp550 & 15L)) == ((byte)((byte)0U & 15L)));
                                    var temp552 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                    var temp553 = (((temp549) && (temp551)) && (temp552));
                                    var temp554 = (((ushort)((ushort)2534U)) <= ((ushort)(temp530)));
                                    var temp555 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                    var temp556 = (((temp554) && (temp551)) && (temp555));
                                    var temp557 = (((ushort)((ushort)2662U)) <= ((ushort)(temp530)));
                                    var temp558 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                    var temp559 = (((temp557) && (temp551)) && (temp558));
                                    var temp560 = (((ushort)((ushort)2790U)) <= ((ushort)(temp530)));
                                    var temp561 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                    var temp562 = (((temp560) && (temp551)) && (temp561));
                                    var temp563 = (((ushort)((ushort)2918U)) <= ((ushort)(temp530)));
                                    var temp564 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                    var temp565 = (((temp563) && (temp551)) && (temp564));
                                    var temp566 = (((ushort)((ushort)3046U)) <= ((ushort)(temp530)));
                                    var temp567 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                    var temp568 = (((temp566) && (temp551)) && (temp567));
                                    var temp569 = (((ushort)((ushort)3174U)) <= ((ushort)(temp530)));
                                    var temp570 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                    var temp571 = (((temp569) && (temp551)) && (temp570));
                                    var temp572 = (((ushort)((ushort)3302U)) <= ((ushort)(temp530)));
                                    var temp573 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                    var temp574 = (((temp572) && (temp551)) && (temp573));
                                    var temp575 = (((ushort)((ushort)3430U)) <= ((ushort)(temp530)));
                                    var temp576 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                    var temp577 = (((temp575) && (temp551)) && (temp576));
                                    var temp578 = (((ushort)((ushort)3664U)) <= ((ushort)(temp530)));
                                    var temp579 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                    var temp580 = (((temp578) && (temp551)) && (temp579));
                                    var temp581 = (((ushort)((ushort)3792U)) <= ((ushort)(temp530)));
                                    var temp582 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                    var temp583 = (((temp581) && (temp551)) && (temp582));
                                    var temp584 = (((ushort)((ushort)3872U)) <= ((ushort)(temp530)));
                                    var temp585 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                    var temp586 = (((temp584) && (temp551)) && (temp585));
                                    var temp587 = (((ushort)((ushort)4160U)) <= ((ushort)(temp530)));
                                    var temp588 = ((byte)(((ushort)(temp530)) >> 13));
                                    var temp589 = (((byte)(temp588 & 7L)) == ((byte)((byte)0U & 7L)));
                                    var temp590 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                    var temp591 = (((temp587) && (temp589)) && (temp590));
                                    var temp592 = (((ushort)((ushort)4240U)) <= ((ushort)(temp530)));
                                    var temp593 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                    var temp594 = (((temp592) && (temp589)) && (temp593));
                                    var temp595 = (((ushort)((ushort)6112U)) <= ((ushort)(temp530)));
                                    var temp596 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                    var temp597 = (((temp595) && (temp589)) && (temp596));
                                    var temp598 = (((ushort)((ushort)6160U)) <= ((ushort)(temp530)));
                                    var temp599 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                    var temp600 = (((temp598) && (temp589)) && (temp599));
                                    var temp601 = (((ushort)((ushort)6470U)) <= ((ushort)(temp530)));
                                    var temp602 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                    var temp603 = (((temp601) && (temp589)) && (temp602));
                                    var temp604 = (((ushort)((ushort)6608U)) <= ((ushort)(temp530)));
                                    var temp605 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                    var temp606 = (((temp604) && (temp589)) && (temp605));
                                    var temp607 = (((ushort)((ushort)6992U)) <= ((ushort)(temp530)));
                                    var temp608 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                    var temp609 = (((temp607) && (temp589)) && (temp608));
                                    var temp610 = (((ushort)((ushort)7088U)) <= ((ushort)(temp530)));
                                    var temp611 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                    var temp612 = (((temp610) && (temp589)) && (temp611));
                                    var temp613 = (((ushort)((ushort)7232U)) <= ((ushort)(temp530)));
                                    var temp614 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                    var temp615 = (((temp613) && (temp589)) && (temp614));
                                    var temp616 = (((ushort)((ushort)7248U)) <= ((ushort)(temp530)));
                                    var temp617 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                    var temp618 = (((temp616) && (temp589)) && (temp617));
                                    var temp619 = (((ushort)((ushort)42528U)) <= ((ushort)(temp530)));
                                    var temp620 = (((ushort)(temp530)) <= ((ushort)((ushort)42537U)));
                                    var temp621 = ((temp619) && (temp620));
                                    var temp622 = (((ushort)((ushort)43216U)) <= ((ushort)(temp530)));
                                    var temp623 = (((ushort)(temp530)) <= ((ushort)((ushort)43225U)));
                                    var temp624 = ((temp622) && (temp623));
                                    var temp625 = (((ushort)((ushort)43264U)) <= ((ushort)(temp530)));
                                    var temp626 = (((ushort)(temp530)) <= ((ushort)((ushort)43273U)));
                                    var temp627 = ((temp625) && (temp626));
                                    var temp628 = (((ushort)((ushort)43600U)) <= ((ushort)(temp530)));
                                    var temp629 = (((ushort)(temp530)) <= ((ushort)((ushort)43609U)));
                                    var temp630 = ((temp628) && (temp629));
                                    var temp631 = (((ushort)((ushort)65296U)) <= ((ushort)(temp530)));
                                    var temp632 = (((ushort)(temp530)) <= ((ushort)((ushort)65305U)));
                                    var temp633 = ((temp631) && (temp632));
                                    var temp634 = (((((((((((((((((((((((((((((((temp537) || (temp542)) || (temp545)) || (temp548)) || (temp553)) || (temp556)) || (temp559)) || (temp562)) || (temp565)) || (temp568)) || (temp571)) || (temp574)) || (temp577)) || (temp580)) || (temp583)) || (temp586)) || (temp591)) || (temp594)) || (temp597)) || (temp600)) || (temp603)) || (temp606)) || (temp609)) || (temp612)) || (temp615)) || (temp618)) || (temp621)) || (temp624)) || (temp627)) || (temp630)) || (temp633));
                                    if (temp634)
                                    {
                                        var temp635 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                        var temp636 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp530));
                                        var temp637 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp635))) + ((uint)(temp636))));
                                        s._1 = ((uint)(temp637));
                                        s._0 = ((ushort)((ushort)0U));
                                        goto M36;
                                    }
                                    else
                                        throw new Exception();
                                }
                            }
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
                        var temp638 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp639 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp638)));
                        var temp640 = ((int)((uint)(temp638)) <= (int)((uint)((uint)191U)));
                        var temp641 = ((temp639) && (temp640));
                        if (temp641)
                        {
                            var temp642 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp643 = Fun0(((ushort)((s)._0)), ((ushort)(temp642)));
                            s._0 = ((ushort)(temp643));
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
                        var temp644 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp645 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp644)));
                        var temp646 = ((int)((uint)(temp644)) <= (int)((uint)((uint)159U)));
                        var temp647 = ((temp645) && (temp646));
                        if (temp647)
                        {
                            var temp648 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp649 = Fun0(((ushort)((s)._0)), ((ushort)(temp648)));
                            s._0 = ((ushort)(temp649));
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
                        var temp650 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp651 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp650)));
                        var temp652 = ((int)((uint)(temp650)) <= (int)((uint)((uint)191U)));
                        var temp653 = ((temp651) && (temp652));
                        if (temp653)
                        {
                            var temp654 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp655 = Fun0(((ushort)((s)._0)), ((ushort)(temp654)));
                            s._0 = ((ushort)(temp655));
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
                        var temp656 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp657 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp656)));
                        var temp658 = ((int)((uint)(temp656)) <= (int)((uint)((uint)127U)));
                        var temp659 = ((temp657) && (temp658));
                        if (temp659)
                        {
                            var temp660 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp660)
                            {
                                goto M41;
                            }
                            else
                            {
                                var temp661 = (((byte)((byte)48U)) <= ((byte)(i)));
                                var temp662 = ((byte)(((byte)(i)) >> 6));
                                var temp663 = (((byte)(temp662 & 3L)) == ((byte)((byte)0U & 3L)));
                                var temp664 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp665 = (((temp661) && (temp663)) && (temp664));
                                if (temp665)
                                {
                                    goto M47;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                        else
                        {
                            var temp666 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp656)));
                            var temp667 = ((int)((uint)(temp656)) <= (int)((uint)((uint)223U)));
                            var temp668 = ((temp666) && (temp667));
                            if (temp668)
                            {
                                var temp669 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp669));
                                goto M52;
                            }
                            else
                            {
                                var temp670 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp670)
                                {
                                    var temp671 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp671));
                                    goto M53;
                                }
                                else
                                {
                                    var temp672 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp672)
                                    {
                                        var temp673 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp673));
                                        goto M54;
                                    }
                                    else
                                    {
                                        var temp674 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp656)));
                                        var temp675 = ((int)((uint)(temp656)) <= (int)((uint)((uint)239U)));
                                        var temp676 = ((temp674) && (temp675));
                                        if (temp676)
                                        {
                                            var temp677 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp677));
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
                        var temp678 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp679 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp678)));
                        var temp680 = ((int)((uint)(temp678)) <= (int)((uint)((uint)191U)));
                        var temp681 = ((temp679) && (temp680));
                        if (temp681)
                        {
                            var temp682 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp683 = Fun0(((ushort)((s)._0)), ((ushort)(temp682)));
                            var temp684 = (((ushort)((ushort)48U)) <= ((ushort)(temp683)));
                            var temp685 = ((ushort)(((ushort)(temp683)) >> 6));
                            var temp686 = (((ushort)(temp685 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp687 = (((byte)(((byte)((ushort)(temp683))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp688 = (((temp684) && (temp686)) && (temp687));
                            var temp689 = (((ushort)((ushort)1632U)) <= ((ushort)(temp683)));
                            var temp690 = ((byte)(((ushort)(temp683)) >> 11));
                            var temp691 = (((byte)(temp690 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp692 = (((ushort)(((ushort)((ushort)(temp683))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp693 = (((temp689) && (temp691)) && (temp692));
                            var temp694 = (((ushort)((ushort)1776U)) <= ((ushort)(temp683)));
                            var temp695 = (((ushort)(((ushort)((ushort)(temp683))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp696 = (((temp694) && (temp691)) && (temp695));
                            var temp697 = (((ushort)((ushort)1984U)) <= ((ushort)(temp683)));
                            var temp698 = (((ushort)(((ushort)((ushort)(temp683))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp699 = (((temp697) && (temp691)) && (temp698));
                            var temp700 = (((ushort)((ushort)2406U)) <= ((ushort)(temp683)));
                            var temp701 = ((byte)(((ushort)(temp683)) >> 12));
                            var temp702 = (((byte)(temp701 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp703 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp704 = (((temp700) && (temp702)) && (temp703));
                            var temp705 = (((ushort)((ushort)2534U)) <= ((ushort)(temp683)));
                            var temp706 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp707 = (((temp705) && (temp702)) && (temp706));
                            var temp708 = (((ushort)((ushort)2662U)) <= ((ushort)(temp683)));
                            var temp709 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp710 = (((temp708) && (temp702)) && (temp709));
                            var temp711 = (((ushort)((ushort)2790U)) <= ((ushort)(temp683)));
                            var temp712 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp713 = (((temp711) && (temp702)) && (temp712));
                            var temp714 = (((ushort)((ushort)2918U)) <= ((ushort)(temp683)));
                            var temp715 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp716 = (((temp714) && (temp702)) && (temp715));
                            var temp717 = (((ushort)((ushort)3046U)) <= ((ushort)(temp683)));
                            var temp718 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp719 = (((temp717) && (temp702)) && (temp718));
                            var temp720 = (((ushort)((ushort)3174U)) <= ((ushort)(temp683)));
                            var temp721 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp722 = (((temp720) && (temp702)) && (temp721));
                            var temp723 = (((ushort)((ushort)3302U)) <= ((ushort)(temp683)));
                            var temp724 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp725 = (((temp723) && (temp702)) && (temp724));
                            var temp726 = (((ushort)((ushort)3430U)) <= ((ushort)(temp683)));
                            var temp727 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp728 = (((temp726) && (temp702)) && (temp727));
                            var temp729 = (((ushort)((ushort)3664U)) <= ((ushort)(temp683)));
                            var temp730 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp731 = (((temp729) && (temp702)) && (temp730));
                            var temp732 = (((ushort)((ushort)3792U)) <= ((ushort)(temp683)));
                            var temp733 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp734 = (((temp732) && (temp702)) && (temp733));
                            var temp735 = (((ushort)((ushort)3872U)) <= ((ushort)(temp683)));
                            var temp736 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp737 = (((temp735) && (temp702)) && (temp736));
                            var temp738 = (((ushort)((ushort)4160U)) <= ((ushort)(temp683)));
                            var temp739 = ((byte)(((ushort)(temp683)) >> 13));
                            var temp740 = (((byte)(temp739 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp741 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp742 = (((temp738) && (temp740)) && (temp741));
                            var temp743 = (((ushort)((ushort)4240U)) <= ((ushort)(temp683)));
                            var temp744 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp745 = (((temp743) && (temp740)) && (temp744));
                            var temp746 = (((ushort)((ushort)6112U)) <= ((ushort)(temp683)));
                            var temp747 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp748 = (((temp746) && (temp740)) && (temp747));
                            var temp749 = (((ushort)((ushort)6160U)) <= ((ushort)(temp683)));
                            var temp750 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp751 = (((temp749) && (temp740)) && (temp750));
                            var temp752 = (((ushort)((ushort)6470U)) <= ((ushort)(temp683)));
                            var temp753 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp754 = (((temp752) && (temp740)) && (temp753));
                            var temp755 = (((ushort)((ushort)6608U)) <= ((ushort)(temp683)));
                            var temp756 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp757 = (((temp755) && (temp740)) && (temp756));
                            var temp758 = (((ushort)((ushort)6992U)) <= ((ushort)(temp683)));
                            var temp759 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp760 = (((temp758) && (temp740)) && (temp759));
                            var temp761 = (((ushort)((ushort)7088U)) <= ((ushort)(temp683)));
                            var temp762 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp763 = (((temp761) && (temp740)) && (temp762));
                            var temp764 = (((ushort)((ushort)7232U)) <= ((ushort)(temp683)));
                            var temp765 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp766 = (((temp764) && (temp740)) && (temp765));
                            var temp767 = (((ushort)((ushort)7248U)) <= ((ushort)(temp683)));
                            var temp768 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp769 = (((temp767) && (temp740)) && (temp768));
                            var temp770 = (((ushort)((ushort)42528U)) <= ((ushort)(temp683)));
                            var temp771 = (((ushort)(temp683)) <= ((ushort)((ushort)42537U)));
                            var temp772 = ((temp770) && (temp771));
                            var temp773 = (((ushort)((ushort)43216U)) <= ((ushort)(temp683)));
                            var temp774 = (((ushort)(temp683)) <= ((ushort)((ushort)43225U)));
                            var temp775 = ((temp773) && (temp774));
                            var temp776 = (((ushort)((ushort)43264U)) <= ((ushort)(temp683)));
                            var temp777 = (((ushort)(temp683)) <= ((ushort)((ushort)43273U)));
                            var temp778 = ((temp776) && (temp777));
                            var temp779 = (((ushort)((ushort)43600U)) <= ((ushort)(temp683)));
                            var temp780 = (((ushort)(temp683)) <= ((ushort)((ushort)43609U)));
                            var temp781 = ((temp779) && (temp780));
                            var temp782 = (((ushort)((ushort)65296U)) <= ((ushort)(temp683)));
                            var temp783 = (((ushort)(temp683)) <= ((ushort)((ushort)65305U)));
                            var temp784 = ((temp782) && (temp783));
                            var temp785 = (((((((((((((((((((((((((((((((temp688) || (temp693)) || (temp696)) || (temp699)) || (temp704)) || (temp707)) || (temp710)) || (temp713)) || (temp716)) || (temp719)) || (temp722)) || (temp725)) || (temp728)) || (temp731)) || (temp734)) || (temp737)) || (temp742)) || (temp745)) || (temp748)) || (temp751)) || (temp754)) || (temp757)) || (temp760)) || (temp763)) || (temp766)) || (temp769)) || (temp772)) || (temp775)) || (temp778)) || (temp781)) || (temp784));
                            if (temp785)
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
                        var temp786 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp787 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp786)));
                        var temp788 = ((int)((uint)(temp786)) <= (int)((uint)((uint)191U)));
                        var temp789 = ((temp787) && (temp788));
                        if (temp789)
                        {
                            var temp790 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp791 = Fun0(((ushort)((s)._0)), ((ushort)(temp790)));
                            s._0 = ((ushort)(temp791));
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
                        var temp792 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp793 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp792)));
                        var temp794 = ((int)((uint)(temp792)) <= (int)((uint)((uint)159U)));
                        var temp795 = ((temp793) && (temp794));
                        if (temp795)
                        {
                            var temp796 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp797 = Fun0(((ushort)((s)._0)), ((ushort)(temp796)));
                            s._0 = ((ushort)(temp797));
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
                        var temp798 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp799 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp798)));
                        var temp800 = ((int)((uint)(temp798)) <= (int)((uint)((uint)191U)));
                        var temp801 = ((temp799) && (temp800));
                        if (temp801)
                        {
                            var temp802 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp803 = Fun0(((ushort)((s)._0)), ((ushort)(temp802)));
                            s._0 = ((ushort)(temp803));
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
                        var temp804 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp805 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp804)));
                        var temp806 = ((int)((uint)(temp804)) <= (int)((uint)((uint)191U)));
                        var temp807 = ((temp805) && (temp806));
                        if (temp807)
                        {
                            var temp808 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp809 = Fun0(((ushort)((s)._0)), ((ushort)(temp808)));
                            var temp810 = (((ushort)(temp809)) == ((ushort)((ushort)44U)));
                            if (temp810)
                                throw new Exception();
                            else
                            {
                                var temp811 = (((ushort)((ushort)48U)) <= ((ushort)(temp809)));
                                var temp812 = ((ushort)(((ushort)(temp809)) >> 6));
                                var temp813 = (((ushort)(temp812 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                var temp814 = (((byte)(((byte)((ushort)(temp809))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp815 = (((temp811) && (temp813)) && (temp814));
                                var temp816 = (((ushort)((ushort)1632U)) <= ((ushort)(temp809)));
                                var temp817 = ((byte)(((ushort)(temp809)) >> 11));
                                var temp818 = (((byte)(temp817 & 31L)) == ((byte)((byte)0U & 31L)));
                                var temp819 = (((ushort)(((ushort)((ushort)(temp809))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                var temp820 = (((temp816) && (temp818)) && (temp819));
                                var temp821 = (((ushort)((ushort)1776U)) <= ((ushort)(temp809)));
                                var temp822 = (((ushort)(((ushort)((ushort)(temp809))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                var temp823 = (((temp821) && (temp818)) && (temp822));
                                var temp824 = (((ushort)((ushort)1984U)) <= ((ushort)(temp809)));
                                var temp825 = (((ushort)(((ushort)((ushort)(temp809))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                var temp826 = (((temp824) && (temp818)) && (temp825));
                                var temp827 = (((ushort)((ushort)2406U)) <= ((ushort)(temp809)));
                                var temp828 = ((byte)(((ushort)(temp809)) >> 12));
                                var temp829 = (((byte)(temp828 & 15L)) == ((byte)((byte)0U & 15L)));
                                var temp830 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                var temp831 = (((temp827) && (temp829)) && (temp830));
                                var temp832 = (((ushort)((ushort)2534U)) <= ((ushort)(temp809)));
                                var temp833 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                var temp834 = (((temp832) && (temp829)) && (temp833));
                                var temp835 = (((ushort)((ushort)2662U)) <= ((ushort)(temp809)));
                                var temp836 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                var temp837 = (((temp835) && (temp829)) && (temp836));
                                var temp838 = (((ushort)((ushort)2790U)) <= ((ushort)(temp809)));
                                var temp839 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                var temp840 = (((temp838) && (temp829)) && (temp839));
                                var temp841 = (((ushort)((ushort)2918U)) <= ((ushort)(temp809)));
                                var temp842 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                var temp843 = (((temp841) && (temp829)) && (temp842));
                                var temp844 = (((ushort)((ushort)3046U)) <= ((ushort)(temp809)));
                                var temp845 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                var temp846 = (((temp844) && (temp829)) && (temp845));
                                var temp847 = (((ushort)((ushort)3174U)) <= ((ushort)(temp809)));
                                var temp848 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                var temp849 = (((temp847) && (temp829)) && (temp848));
                                var temp850 = (((ushort)((ushort)3302U)) <= ((ushort)(temp809)));
                                var temp851 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                var temp852 = (((temp850) && (temp829)) && (temp851));
                                var temp853 = (((ushort)((ushort)3430U)) <= ((ushort)(temp809)));
                                var temp854 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                var temp855 = (((temp853) && (temp829)) && (temp854));
                                var temp856 = (((ushort)((ushort)3664U)) <= ((ushort)(temp809)));
                                var temp857 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                var temp858 = (((temp856) && (temp829)) && (temp857));
                                var temp859 = (((ushort)((ushort)3792U)) <= ((ushort)(temp809)));
                                var temp860 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                var temp861 = (((temp859) && (temp829)) && (temp860));
                                var temp862 = (((ushort)((ushort)3872U)) <= ((ushort)(temp809)));
                                var temp863 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                var temp864 = (((temp862) && (temp829)) && (temp863));
                                var temp865 = (((ushort)((ushort)4160U)) <= ((ushort)(temp809)));
                                var temp866 = ((byte)(((ushort)(temp809)) >> 13));
                                var temp867 = (((byte)(temp866 & 7L)) == ((byte)((byte)0U & 7L)));
                                var temp868 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                var temp869 = (((temp865) && (temp867)) && (temp868));
                                var temp870 = (((ushort)((ushort)4240U)) <= ((ushort)(temp809)));
                                var temp871 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                var temp872 = (((temp870) && (temp867)) && (temp871));
                                var temp873 = (((ushort)((ushort)6112U)) <= ((ushort)(temp809)));
                                var temp874 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                var temp875 = (((temp873) && (temp867)) && (temp874));
                                var temp876 = (((ushort)((ushort)6160U)) <= ((ushort)(temp809)));
                                var temp877 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                var temp878 = (((temp876) && (temp867)) && (temp877));
                                var temp879 = (((ushort)((ushort)6470U)) <= ((ushort)(temp809)));
                                var temp880 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                var temp881 = (((temp879) && (temp867)) && (temp880));
                                var temp882 = (((ushort)((ushort)6608U)) <= ((ushort)(temp809)));
                                var temp883 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                var temp884 = (((temp882) && (temp867)) && (temp883));
                                var temp885 = (((ushort)((ushort)6992U)) <= ((ushort)(temp809)));
                                var temp886 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                var temp887 = (((temp885) && (temp867)) && (temp886));
                                var temp888 = (((ushort)((ushort)7088U)) <= ((ushort)(temp809)));
                                var temp889 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                var temp890 = (((temp888) && (temp867)) && (temp889));
                                var temp891 = (((ushort)((ushort)7232U)) <= ((ushort)(temp809)));
                                var temp892 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                var temp893 = (((temp891) && (temp867)) && (temp892));
                                var temp894 = (((ushort)((ushort)7248U)) <= ((ushort)(temp809)));
                                var temp895 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                var temp896 = (((temp894) && (temp867)) && (temp895));
                                var temp897 = (((ushort)((ushort)42528U)) <= ((ushort)(temp809)));
                                var temp898 = (((ushort)(temp809)) <= ((ushort)((ushort)42537U)));
                                var temp899 = ((temp897) && (temp898));
                                var temp900 = (((ushort)((ushort)43216U)) <= ((ushort)(temp809)));
                                var temp901 = (((ushort)(temp809)) <= ((ushort)((ushort)43225U)));
                                var temp902 = ((temp900) && (temp901));
                                var temp903 = (((ushort)((ushort)43264U)) <= ((ushort)(temp809)));
                                var temp904 = (((ushort)(temp809)) <= ((ushort)((ushort)43273U)));
                                var temp905 = ((temp903) && (temp904));
                                var temp906 = (((ushort)((ushort)43600U)) <= ((ushort)(temp809)));
                                var temp907 = (((ushort)(temp809)) <= ((ushort)((ushort)43609U)));
                                var temp908 = ((temp906) && (temp907));
                                var temp909 = (((ushort)((ushort)65296U)) <= ((ushort)(temp809)));
                                var temp910 = (((ushort)(temp809)) <= ((ushort)((ushort)65305U)));
                                var temp911 = ((temp909) && (temp910));
                                var temp912 = (((((((((((((((((((((((((((((((temp815) || (temp820)) || (temp823)) || (temp826)) || (temp831)) || (temp834)) || (temp837)) || (temp840)) || (temp843)) || (temp846)) || (temp849)) || (temp852)) || (temp855)) || (temp858)) || (temp861)) || (temp864)) || (temp869)) || (temp872)) || (temp875)) || (temp878)) || (temp881)) || (temp884)) || (temp887)) || (temp890)) || (temp893)) || (temp896)) || (temp899)) || (temp902)) || (temp905)) || (temp908)) || (temp911));
                                if (temp912)
                                {
                                    s._0 = ((ushort)((ushort)0U));
                                    goto M47;
                                }
                                else
                                    throw new Exception();
                            }
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
                        var temp913 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp914 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp913)));
                        var temp915 = ((int)((uint)(temp913)) <= (int)((uint)((uint)191U)));
                        var temp916 = ((temp914) && (temp915));
                        if (temp916)
                        {
                            var temp917 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp918 = Fun0(((ushort)((s)._0)), ((ushort)(temp917)));
                            s._0 = ((ushort)(temp918));
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
                        var temp919 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp920 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp919)));
                        var temp921 = ((int)((uint)(temp919)) <= (int)((uint)((uint)159U)));
                        var temp922 = ((temp920) && (temp921));
                        if (temp922)
                        {
                            var temp923 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp924 = Fun0(((ushort)((s)._0)), ((ushort)(temp923)));
                            s._0 = ((ushort)(temp924));
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
                        var temp925 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp926 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp925)));
                        var temp927 = ((int)((uint)(temp925)) <= (int)((uint)((uint)191U)));
                        var temp928 = ((temp926) && (temp927));
                        if (temp928)
                        {
                            var temp929 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp930 = Fun0(((ushort)((s)._0)), ((ushort)(temp929)));
                            s._0 = ((ushort)(temp930));
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
                        var temp931 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp932 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp931)));
                        var temp933 = ((int)((uint)(temp931)) <= (int)((uint)((uint)191U)));
                        var temp934 = ((temp932) && (temp933));
                        if (temp934)
                        {
                            var temp935 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp936 = Fun0(((ushort)((s)._0)), ((ushort)(temp935)));
                            var temp937 = (((ushort)(temp936)) == ((ushort)((ushort)10U)));
                            if (temp937)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M41;
                            }
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
                        var temp938 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp939 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp938)));
                        var temp940 = ((int)((uint)(temp938)) <= (int)((uint)((uint)191U)));
                        var temp941 = ((temp939) && (temp940));
                        if (temp941)
                        {
                            var temp942 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp943 = Fun0(((ushort)((s)._0)), ((ushort)(temp942)));
                            s._0 = ((ushort)(temp943));
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
                        var temp944 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp945 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp944)));
                        var temp946 = ((int)((uint)(temp944)) <= (int)((uint)((uint)159U)));
                        var temp947 = ((temp945) && (temp946));
                        if (temp947)
                        {
                            var temp948 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp949 = Fun0(((ushort)((s)._0)), ((ushort)(temp948)));
                            s._0 = ((ushort)(temp949));
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
                        var temp950 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp951 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp950)));
                        var temp952 = ((int)((uint)(temp950)) <= (int)((uint)((uint)191U)));
                        var temp953 = ((temp951) && (temp952));
                        if (temp953)
                        {
                            var temp954 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp955 = Fun0(((ushort)((s)._0)), ((ushort)(temp954)));
                            s._0 = ((ushort)(temp955));
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
                    var temp47 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    yield return (Byte)(((byte)((uint)(temp47))));
                    var temp48 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    yield return (Byte)(((byte)((uint)(temp48))));
                    var temp49 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    yield return (Byte)(((byte)((uint)(temp49))));
                    yield return (Byte)(((byte)((uint)((s)._2))));
                    yield break;
                }

                F4:
                {
                    var temp56 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    yield return (Byte)(((byte)((uint)(temp56))));
                    var temp57 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    yield return (Byte)(((byte)((uint)(temp57))));
                    var temp58 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    yield return (Byte)(((byte)((uint)(temp58))));
                    yield return (Byte)(((byte)((uint)((s)._2))));
                    yield break;
                }

                F5:
                {
                    var temp65 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    yield return (Byte)(((byte)((uint)(temp65))));
                    var temp66 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    yield return (Byte)(((byte)((uint)(temp66))));
                    var temp67 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    yield return (Byte)(((byte)((uint)(temp67))));
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

        struct DTStruct41
        {
            public UInt16 _0;
            public UInt32 _1;
            public UInt32 _2;
            public DTStruct41(UInt16 v0, UInt32 v1, UInt32 v2)
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
                DTStruct41 s = new DTStruct41(((ushort)((ushort)0U)), ((uint)((uint)0U)), ((uint)((uint)2147483647U)));
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
                            var temp44 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp45 = Fun0(((ushort)((s)._0)), ((ushort)(temp44)));
                            var temp46 = (((ushort)(temp45)) == ((ushort)((ushort)44U)));
                            if (temp46)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M0;
                            }
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
                        var temp50 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp51 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp50)));
                        var temp52 = ((int)((uint)(temp50)) <= (int)((uint)((uint)191U)));
                        var temp53 = ((temp51) && (temp52));
                        if (temp53)
                        {
                            var temp54 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp55 = Fun0(((ushort)((s)._0)), ((ushort)(temp54)));
                            s._0 = ((ushort)(temp55));
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
                        var temp59 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp60 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp59)));
                        var temp61 = ((int)((uint)(temp59)) <= (int)((uint)((uint)159U)));
                        var temp62 = ((temp60) && (temp61));
                        if (temp62)
                        {
                            var temp63 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp64 = Fun0(((ushort)((s)._0)), ((ushort)(temp63)));
                            s._0 = ((ushort)(temp64));
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
                        var temp68 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp69 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp68)));
                        var temp70 = ((int)((uint)(temp68)) <= (int)((uint)((uint)191U)));
                        var temp71 = ((temp69) && (temp70));
                        if (temp71)
                        {
                            var temp72 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp73 = Fun0(((ushort)((s)._0)), ((ushort)(temp72)));
                            s._0 = ((ushort)(temp73));
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
                        var temp74 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp75 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp74)));
                        var temp76 = ((int)((uint)(temp74)) <= (int)((uint)((uint)127U)));
                        var temp77 = ((temp75) && (temp76));
                        if (temp77)
                        {
                            var temp78 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp78)
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
                            var temp79 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp74)));
                            var temp80 = ((int)((uint)(temp74)) <= (int)((uint)((uint)223U)));
                            var temp81 = ((temp79) && (temp80));
                            if (temp81)
                            {
                                var temp82 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp82));
                                goto M12;
                            }
                            else
                            {
                                var temp83 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp83)
                                {
                                    var temp84 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp84));
                                    goto M13;
                                }
                                else
                                {
                                    var temp85 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp85)
                                    {
                                        var temp86 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp86));
                                        goto M14;
                                    }
                                    else
                                    {
                                        var temp87 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp74)));
                                        var temp88 = ((int)((uint)(temp74)) <= (int)((uint)((uint)239U)));
                                        var temp89 = ((temp87) && (temp88));
                                        if (temp89)
                                        {
                                            var temp90 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp90));
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
                        var temp91 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp92 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp91)));
                        var temp93 = ((int)((uint)(temp91)) <= (int)((uint)((uint)191U)));
                        var temp94 = ((temp92) && (temp93));
                        if (temp94)
                        {
                            var temp95 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp96 = Fun0(((ushort)((s)._0)), ((ushort)(temp95)));
                            var temp97 = (((ushort)(temp96)) == ((ushort)((ushort)44U)));
                            if (temp97)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M1;
                            }
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
                        var temp98 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp99 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp98)));
                        var temp100 = ((int)((uint)(temp98)) <= (int)((uint)((uint)191U)));
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
                        var temp104 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp105 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp104)));
                        var temp106 = ((int)((uint)(temp104)) <= (int)((uint)((uint)159U)));
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
                        var temp110 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp111 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp110)));
                        var temp112 = ((int)((uint)(temp110)) <= (int)((uint)((uint)191U)));
                        var temp113 = ((temp111) && (temp112));
                        if (temp113)
                        {
                            var temp114 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp115 = Fun0(((ushort)((s)._0)), ((ushort)(temp114)));
                            s._0 = ((ushort)(temp115));
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
                        var temp116 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp117 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp116)));
                        var temp118 = ((int)((uint)(temp116)) <= (int)((uint)((uint)127U)));
                        var temp119 = ((temp117) && (temp118));
                        if (temp119)
                        {
                            var temp120 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp120)
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
                            var temp121 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp116)));
                            var temp122 = ((int)((uint)(temp116)) <= (int)((uint)((uint)223U)));
                            var temp123 = ((temp121) && (temp122));
                            if (temp123)
                            {
                                var temp124 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp124));
                                goto M17;
                            }
                            else
                            {
                                var temp125 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp125)
                                {
                                    var temp126 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp126));
                                    goto M18;
                                }
                                else
                                {
                                    var temp127 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp127)
                                    {
                                        var temp128 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp128));
                                        goto M19;
                                    }
                                    else
                                    {
                                        var temp129 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp116)));
                                        var temp130 = ((int)((uint)(temp116)) <= (int)((uint)((uint)239U)));
                                        var temp131 = ((temp129) && (temp130));
                                        if (temp131)
                                        {
                                            var temp132 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp132));
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
                        var temp133 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp134 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp133)));
                        var temp135 = ((int)((uint)(temp133)) <= (int)((uint)((uint)191U)));
                        var temp136 = ((temp134) && (temp135));
                        if (temp136)
                        {
                            var temp137 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp138 = Fun0(((ushort)((s)._0)), ((ushort)(temp137)));
                            var temp139 = (((ushort)(temp138)) == ((ushort)((ushort)44U)));
                            if (temp139)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M6;
                            }
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
                        var temp140 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp141 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp140)));
                        var temp142 = ((int)((uint)(temp140)) <= (int)((uint)((uint)191U)));
                        var temp143 = ((temp141) && (temp142));
                        if (temp143)
                        {
                            var temp144 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp145 = Fun0(((ushort)((s)._0)), ((ushort)(temp144)));
                            s._0 = ((ushort)(temp145));
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
                        var temp146 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp147 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp146)));
                        var temp148 = ((int)((uint)(temp146)) <= (int)((uint)((uint)159U)));
                        var temp149 = ((temp147) && (temp148));
                        if (temp149)
                        {
                            var temp150 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp151 = Fun0(((ushort)((s)._0)), ((ushort)(temp150)));
                            s._0 = ((ushort)(temp151));
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
                        var temp152 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp153 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp152)));
                        var temp154 = ((int)((uint)(temp152)) <= (int)((uint)((uint)191U)));
                        var temp155 = ((temp153) && (temp154));
                        if (temp155)
                        {
                            var temp156 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp157 = Fun0(((ushort)((s)._0)), ((ushort)(temp156)));
                            s._0 = ((ushort)(temp157));
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
                        var temp158 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp159 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp158)));
                        var temp160 = ((int)((uint)(temp158)) <= (int)((uint)((uint)127U)));
                        var temp161 = ((temp159) && (temp160));
                        if (temp161)
                        {
                            var temp162 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp162)
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
                            var temp163 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp158)));
                            var temp164 = ((int)((uint)(temp158)) <= (int)((uint)((uint)223U)));
                            var temp165 = ((temp163) && (temp164));
                            if (temp165)
                            {
                                var temp166 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp166));
                                goto M22;
                            }
                            else
                            {
                                var temp167 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp167)
                                {
                                    var temp168 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp168));
                                    goto M23;
                                }
                                else
                                {
                                    var temp169 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp169)
                                    {
                                        var temp170 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp170));
                                        goto M24;
                                    }
                                    else
                                    {
                                        var temp171 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp158)));
                                        var temp172 = ((int)((uint)(temp158)) <= (int)((uint)((uint)239U)));
                                        var temp173 = ((temp171) && (temp172));
                                        if (temp173)
                                        {
                                            var temp174 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp174));
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
                        var temp175 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp176 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp175)));
                        var temp177 = ((int)((uint)(temp175)) <= (int)((uint)((uint)191U)));
                        var temp178 = ((temp176) && (temp177));
                        if (temp178)
                        {
                            var temp179 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp180 = Fun0(((ushort)((s)._0)), ((ushort)(temp179)));
                            var temp181 = (((ushort)(temp180)) == ((ushort)((ushort)44U)));
                            if (temp181)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M11;
                            }
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
                        var temp182 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp183 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp182)));
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
                        var temp188 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp189 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp188)));
                        var temp190 = ((int)((uint)(temp188)) <= (int)((uint)((uint)159U)));
                        var temp191 = ((temp189) && (temp190));
                        if (temp191)
                        {
                            var temp192 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp193 = Fun0(((ushort)((s)._0)), ((ushort)(temp192)));
                            s._0 = ((ushort)(temp193));
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
                        var temp194 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp195 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp194)));
                        var temp196 = ((int)((uint)(temp194)) <= (int)((uint)((uint)191U)));
                        var temp197 = ((temp195) && (temp196));
                        if (temp197)
                        {
                            var temp198 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp199 = Fun0(((ushort)((s)._0)), ((ushort)(temp198)));
                            s._0 = ((ushort)(temp199));
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
                        var temp200 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp201 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp200)));
                        var temp202 = ((int)((uint)(temp200)) <= (int)((uint)((uint)127U)));
                        var temp203 = ((temp201) && (temp202));
                        if (temp203)
                        {
                            var temp204 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp204)
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
                            var temp205 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp200)));
                            var temp206 = ((int)((uint)(temp200)) <= (int)((uint)((uint)223U)));
                            var temp207 = ((temp205) && (temp206));
                            if (temp207)
                            {
                                var temp208 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp208));
                                goto M27;
                            }
                            else
                            {
                                var temp209 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp209)
                                {
                                    var temp210 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp210));
                                    goto M28;
                                }
                                else
                                {
                                    var temp211 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp211)
                                    {
                                        var temp212 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp212));
                                        goto M29;
                                    }
                                    else
                                    {
                                        var temp213 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp200)));
                                        var temp214 = ((int)((uint)(temp200)) <= (int)((uint)((uint)239U)));
                                        var temp215 = ((temp213) && (temp214));
                                        if (temp215)
                                        {
                                            var temp216 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp216));
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
                        var temp217 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp218 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp217)));
                        var temp219 = ((int)((uint)(temp217)) <= (int)((uint)((uint)191U)));
                        var temp220 = ((temp218) && (temp219));
                        if (temp220)
                        {
                            var temp221 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp222 = Fun0(((ushort)((s)._0)), ((ushort)(temp221)));
                            var temp223 = (((ushort)(temp222)) == ((ushort)((ushort)44U)));
                            if (temp223)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M16;
                            }
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
                        var temp224 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp225 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp224)));
                        var temp226 = ((int)((uint)(temp224)) <= (int)((uint)((uint)191U)));
                        var temp227 = ((temp225) && (temp226));
                        if (temp227)
                        {
                            var temp228 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp229 = Fun0(((ushort)((s)._0)), ((ushort)(temp228)));
                            s._0 = ((ushort)(temp229));
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
                        var temp230 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp231 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp230)));
                        var temp232 = ((int)((uint)(temp230)) <= (int)((uint)((uint)159U)));
                        var temp233 = ((temp231) && (temp232));
                        if (temp233)
                        {
                            var temp234 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp235 = Fun0(((ushort)((s)._0)), ((ushort)(temp234)));
                            s._0 = ((ushort)(temp235));
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
                        var temp236 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp237 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp236)));
                        var temp238 = ((int)((uint)(temp236)) <= (int)((uint)((uint)191U)));
                        var temp239 = ((temp237) && (temp238));
                        if (temp239)
                        {
                            var temp240 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp241 = Fun0(((ushort)((s)._0)), ((ushort)(temp240)));
                            s._0 = ((ushort)(temp241));
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
                        var temp242 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp243 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp242)));
                        var temp244 = ((int)((uint)(temp242)) <= (int)((uint)((uint)127U)));
                        var temp245 = ((temp243) && (temp244));
                        if (temp245)
                        {
                            var temp246 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp246)
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
                            var temp247 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp242)));
                            var temp248 = ((int)((uint)(temp242)) <= (int)((uint)((uint)223U)));
                            var temp249 = ((temp247) && (temp248));
                            if (temp249)
                            {
                                var temp250 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp250));
                                goto M32;
                            }
                            else
                            {
                                var temp251 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp251)
                                {
                                    var temp252 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp252));
                                    goto M33;
                                }
                                else
                                {
                                    var temp253 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp253)
                                    {
                                        var temp254 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp254));
                                        goto M34;
                                    }
                                    else
                                    {
                                        var temp255 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp242)));
                                        var temp256 = ((int)((uint)(temp242)) <= (int)((uint)((uint)239U)));
                                        var temp257 = ((temp255) && (temp256));
                                        if (temp257)
                                        {
                                            var temp258 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp258));
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
                        var temp259 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp260 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp259)));
                        var temp261 = ((int)((uint)(temp259)) <= (int)((uint)((uint)191U)));
                        var temp262 = ((temp260) && (temp261));
                        if (temp262)
                        {
                            var temp263 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp264 = Fun0(((ushort)((s)._0)), ((ushort)(temp263)));
                            var temp265 = (((ushort)(temp264)) == ((ushort)((ushort)44U)));
                            if (temp265)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M21;
                            }
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
                        var temp266 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp267 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp266)));
                        var temp268 = ((int)((uint)(temp266)) <= (int)((uint)((uint)191U)));
                        var temp269 = ((temp267) && (temp268));
                        if (temp269)
                        {
                            var temp270 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp271 = Fun0(((ushort)((s)._0)), ((ushort)(temp270)));
                            s._0 = ((ushort)(temp271));
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
                        var temp272 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp273 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp272)));
                        var temp274 = ((int)((uint)(temp272)) <= (int)((uint)((uint)159U)));
                        var temp275 = ((temp273) && (temp274));
                        if (temp275)
                        {
                            var temp276 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp277 = Fun0(((ushort)((s)._0)), ((ushort)(temp276)));
                            s._0 = ((ushort)(temp277));
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
                        var temp278 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp279 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp278)));
                        var temp280 = ((int)((uint)(temp278)) <= (int)((uint)((uint)191U)));
                        var temp281 = ((temp279) && (temp280));
                        if (temp281)
                        {
                            var temp282 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp283 = Fun0(((ushort)((s)._0)), ((ushort)(temp282)));
                            s._0 = ((ushort)(temp283));
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
                        var temp284 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp285 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp284)));
                        var temp286 = ((int)((uint)(temp284)) <= (int)((uint)((uint)127U)));
                        var temp287 = ((temp285) && (temp286));
                        if (temp287)
                        {
                            var temp288 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp289 = ((byte)(((byte)(i)) >> 6));
                            var temp290 = (((byte)(temp289 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp291 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp292 = (((temp288) && (temp290)) && (temp291));
                            if (temp292)
                            {
                                var temp293 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp294 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp293))) + ((uint)(temp284))));
                                s._1 = ((uint)(temp294));
                                goto M36;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp295 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp284)));
                            var temp296 = ((int)((uint)(temp284)) <= (int)((uint)((uint)223U)));
                            var temp297 = ((temp295) && (temp296));
                            if (temp297)
                            {
                                var temp298 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp298));
                                goto M37;
                            }
                            else
                            {
                                var temp299 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp299)
                                {
                                    var temp300 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp300));
                                    goto M38;
                                }
                                else
                                {
                                    var temp301 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp301)
                                    {
                                        var temp302 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp302));
                                        goto M39;
                                    }
                                    else
                                    {
                                        var temp303 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp284)));
                                        var temp304 = ((int)((uint)(temp284)) <= (int)((uint)((uint)239U)));
                                        var temp305 = ((temp303) && (temp304));
                                        if (temp305)
                                        {
                                            var temp306 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp306));
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
                        var temp307 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp308 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp307)));
                        var temp309 = ((int)((uint)(temp307)) <= (int)((uint)((uint)191U)));
                        var temp310 = ((temp308) && (temp309));
                        if (temp310)
                        {
                            var temp311 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp312 = Fun0(((ushort)((s)._0)), ((ushort)(temp311)));
                            var temp313 = (((ushort)(temp312)) == ((ushort)((ushort)44U)));
                            if (temp313)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M26;
                            }
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
                        var temp314 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp315 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp314)));
                        var temp316 = ((int)((uint)(temp314)) <= (int)((uint)((uint)191U)));
                        var temp317 = ((temp315) && (temp316));
                        if (temp317)
                        {
                            var temp318 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp319 = Fun0(((ushort)((s)._0)), ((ushort)(temp318)));
                            s._0 = ((ushort)(temp319));
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
                        var temp320 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp321 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp320)));
                        var temp322 = ((int)((uint)(temp320)) <= (int)((uint)((uint)159U)));
                        var temp323 = ((temp321) && (temp322));
                        if (temp323)
                        {
                            var temp324 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp325 = Fun0(((ushort)((s)._0)), ((ushort)(temp324)));
                            s._0 = ((ushort)(temp325));
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
                        var temp326 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp327 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp326)));
                        var temp328 = ((int)((uint)(temp326)) <= (int)((uint)((uint)191U)));
                        var temp329 = ((temp327) && (temp328));
                        if (temp329)
                        {
                            var temp330 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp331 = Fun0(((ushort)((s)._0)), ((ushort)(temp330)));
                            s._0 = ((ushort)(temp331));
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
                        var temp332 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp333 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp332)));
                        var temp334 = ((int)((uint)(temp332)) <= (int)((uint)((uint)127U)));
                        var temp335 = ((temp333) && (temp334));
                        if (temp335)
                        {
                            var temp336 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp336)
                            {
                                goto M41;
                            }
                            else
                            {
                                var temp337 = (((byte)(i)) == ((byte)((byte)46U)));
                                if (temp337)
                                {
                                    goto M42;
                                }
                                else
                                {
                                    var temp338 = (((byte)((byte)48U)) <= ((byte)(i)));
                                    var temp339 = ((byte)(((byte)(i)) >> 6));
                                    var temp340 = (((byte)(temp339 & 3L)) == ((byte)((byte)0U & 3L)));
                                    var temp341 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                    var temp342 = (((temp338) && (temp340)) && (temp341));
                                    if (temp342)
                                    {
                                        var temp343 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                        var temp344 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp343))) + ((uint)(temp332))));
                                        s._1 = ((uint)(temp344));
                                        goto M36;
                                    }
                                    else
                                        throw new Exception();
                                }
                            }
                        }
                        else
                        {
                            var temp345 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp332)));
                            var temp346 = ((int)((uint)(temp332)) <= (int)((uint)((uint)223U)));
                            var temp347 = ((temp345) && (temp346));
                            if (temp347)
                            {
                                var temp348 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp348));
                                goto M43;
                            }
                            else
                            {
                                var temp349 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp349)
                                {
                                    var temp350 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp350));
                                    goto M44;
                                }
                                else
                                {
                                    var temp351 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp351)
                                    {
                                        var temp352 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp352));
                                        goto M45;
                                    }
                                    else
                                    {
                                        var temp353 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp332)));
                                        var temp354 = ((int)((uint)(temp332)) <= (int)((uint)((uint)239U)));
                                        var temp355 = ((temp353) && (temp354));
                                        if (temp355)
                                        {
                                            var temp356 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp356));
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
                        var temp357 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp358 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp357)));
                        var temp359 = ((int)((uint)(temp357)) <= (int)((uint)((uint)191U)));
                        var temp360 = ((temp358) && (temp359));
                        if (temp360)
                        {
                            var temp361 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp362 = Fun0(((ushort)((s)._0)), ((ushort)(temp361)));
                            var temp363 = (((ushort)((ushort)48U)) <= ((ushort)(temp362)));
                            var temp364 = ((ushort)(((ushort)(temp362)) >> 6));
                            var temp365 = (((ushort)(temp364 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp366 = (((byte)(((byte)((ushort)(temp362))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp367 = (((temp363) && (temp365)) && (temp366));
                            var temp368 = (((ushort)((ushort)1632U)) <= ((ushort)(temp362)));
                            var temp369 = ((byte)(((ushort)(temp362)) >> 11));
                            var temp370 = (((byte)(temp369 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp371 = (((ushort)(((ushort)((ushort)(temp362))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp372 = (((temp368) && (temp370)) && (temp371));
                            var temp373 = (((ushort)((ushort)1776U)) <= ((ushort)(temp362)));
                            var temp374 = (((ushort)(((ushort)((ushort)(temp362))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp375 = (((temp373) && (temp370)) && (temp374));
                            var temp376 = (((ushort)((ushort)1984U)) <= ((ushort)(temp362)));
                            var temp377 = (((ushort)(((ushort)((ushort)(temp362))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp378 = (((temp376) && (temp370)) && (temp377));
                            var temp379 = (((ushort)((ushort)2406U)) <= ((ushort)(temp362)));
                            var temp380 = ((byte)(((ushort)(temp362)) >> 12));
                            var temp381 = (((byte)(temp380 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp382 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp383 = (((temp379) && (temp381)) && (temp382));
                            var temp384 = (((ushort)((ushort)2534U)) <= ((ushort)(temp362)));
                            var temp385 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp386 = (((temp384) && (temp381)) && (temp385));
                            var temp387 = (((ushort)((ushort)2662U)) <= ((ushort)(temp362)));
                            var temp388 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp389 = (((temp387) && (temp381)) && (temp388));
                            var temp390 = (((ushort)((ushort)2790U)) <= ((ushort)(temp362)));
                            var temp391 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp392 = (((temp390) && (temp381)) && (temp391));
                            var temp393 = (((ushort)((ushort)2918U)) <= ((ushort)(temp362)));
                            var temp394 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp395 = (((temp393) && (temp381)) && (temp394));
                            var temp396 = (((ushort)((ushort)3046U)) <= ((ushort)(temp362)));
                            var temp397 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp398 = (((temp396) && (temp381)) && (temp397));
                            var temp399 = (((ushort)((ushort)3174U)) <= ((ushort)(temp362)));
                            var temp400 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp401 = (((temp399) && (temp381)) && (temp400));
                            var temp402 = (((ushort)((ushort)3302U)) <= ((ushort)(temp362)));
                            var temp403 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp404 = (((temp402) && (temp381)) && (temp403));
                            var temp405 = (((ushort)((ushort)3430U)) <= ((ushort)(temp362)));
                            var temp406 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp407 = (((temp405) && (temp381)) && (temp406));
                            var temp408 = (((ushort)((ushort)3664U)) <= ((ushort)(temp362)));
                            var temp409 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp410 = (((temp408) && (temp381)) && (temp409));
                            var temp411 = (((ushort)((ushort)3792U)) <= ((ushort)(temp362)));
                            var temp412 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp413 = (((temp411) && (temp381)) && (temp412));
                            var temp414 = (((ushort)((ushort)3872U)) <= ((ushort)(temp362)));
                            var temp415 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp416 = (((temp414) && (temp381)) && (temp415));
                            var temp417 = (((ushort)((ushort)4160U)) <= ((ushort)(temp362)));
                            var temp418 = ((byte)(((ushort)(temp362)) >> 13));
                            var temp419 = (((byte)(temp418 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp420 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp421 = (((temp417) && (temp419)) && (temp420));
                            var temp422 = (((ushort)((ushort)4240U)) <= ((ushort)(temp362)));
                            var temp423 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp424 = (((temp422) && (temp419)) && (temp423));
                            var temp425 = (((ushort)((ushort)6112U)) <= ((ushort)(temp362)));
                            var temp426 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp427 = (((temp425) && (temp419)) && (temp426));
                            var temp428 = (((ushort)((ushort)6160U)) <= ((ushort)(temp362)));
                            var temp429 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp430 = (((temp428) && (temp419)) && (temp429));
                            var temp431 = (((ushort)((ushort)6470U)) <= ((ushort)(temp362)));
                            var temp432 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp433 = (((temp431) && (temp419)) && (temp432));
                            var temp434 = (((ushort)((ushort)6608U)) <= ((ushort)(temp362)));
                            var temp435 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp436 = (((temp434) && (temp419)) && (temp435));
                            var temp437 = (((ushort)((ushort)6992U)) <= ((ushort)(temp362)));
                            var temp438 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp439 = (((temp437) && (temp419)) && (temp438));
                            var temp440 = (((ushort)((ushort)7088U)) <= ((ushort)(temp362)));
                            var temp441 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp442 = (((temp440) && (temp419)) && (temp441));
                            var temp443 = (((ushort)((ushort)7232U)) <= ((ushort)(temp362)));
                            var temp444 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp445 = (((temp443) && (temp419)) && (temp444));
                            var temp446 = (((ushort)((ushort)7248U)) <= ((ushort)(temp362)));
                            var temp447 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp448 = (((temp446) && (temp419)) && (temp447));
                            var temp449 = (((ushort)((ushort)42528U)) <= ((ushort)(temp362)));
                            var temp450 = (((ushort)(temp362)) <= ((ushort)((ushort)42537U)));
                            var temp451 = ((temp449) && (temp450));
                            var temp452 = (((ushort)((ushort)43216U)) <= ((ushort)(temp362)));
                            var temp453 = (((ushort)(temp362)) <= ((ushort)((ushort)43225U)));
                            var temp454 = ((temp452) && (temp453));
                            var temp455 = (((ushort)((ushort)43264U)) <= ((ushort)(temp362)));
                            var temp456 = (((ushort)(temp362)) <= ((ushort)((ushort)43273U)));
                            var temp457 = ((temp455) && (temp456));
                            var temp458 = (((ushort)((ushort)43600U)) <= ((ushort)(temp362)));
                            var temp459 = (((ushort)(temp362)) <= ((ushort)((ushort)43609U)));
                            var temp460 = ((temp458) && (temp459));
                            var temp461 = (((ushort)((ushort)65296U)) <= ((ushort)(temp362)));
                            var temp462 = (((ushort)(temp362)) <= ((ushort)((ushort)65305U)));
                            var temp463 = ((temp461) && (temp462));
                            var temp464 = (((((((((((((((((((((((((((((((temp367) || (temp372)) || (temp375)) || (temp378)) || (temp383)) || (temp386)) || (temp389)) || (temp392)) || (temp395)) || (temp398)) || (temp401)) || (temp404)) || (temp407)) || (temp410)) || (temp413)) || (temp416)) || (temp421)) || (temp424)) || (temp427)) || (temp430)) || (temp433)) || (temp436)) || (temp439)) || (temp442)) || (temp445)) || (temp448)) || (temp451)) || (temp454)) || (temp457)) || (temp460)) || (temp463));
                            if (temp464)
                            {
                                var temp465 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp466 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp362));
                                var temp467 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp465))) + ((uint)(temp466))));
                                s._1 = ((uint)(temp467));
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
                        var temp468 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp469 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp468)));
                        var temp470 = ((int)((uint)(temp468)) <= (int)((uint)((uint)191U)));
                        var temp471 = ((temp469) && (temp470));
                        if (temp471)
                        {
                            var temp472 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp473 = Fun0(((ushort)((s)._0)), ((ushort)(temp472)));
                            s._0 = ((ushort)(temp473));
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
                        var temp474 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp475 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp474)));
                        var temp476 = ((int)((uint)(temp474)) <= (int)((uint)((uint)159U)));
                        var temp477 = ((temp475) && (temp476));
                        if (temp477)
                        {
                            var temp478 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp479 = Fun0(((ushort)((s)._0)), ((ushort)(temp478)));
                            s._0 = ((ushort)(temp479));
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
                        var temp480 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp481 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp480)));
                        var temp482 = ((int)((uint)(temp480)) <= (int)((uint)((uint)191U)));
                        var temp483 = ((temp481) && (temp482));
                        if (temp483)
                        {
                            var temp484 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp485 = Fun0(((ushort)((s)._0)), ((ushort)(temp484)));
                            s._0 = ((ushort)(temp485));
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
                        var temp486 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp487 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp486)));
                        var temp488 = ((int)((uint)(temp486)) <= (int)((uint)((uint)127U)));
                        var temp489 = ((temp487) && (temp488));
                        if (temp489)
                        {
                            var temp490 = (((byte)(i)) == ((byte)((byte)10U)));
                            if (temp490)
                            {
                                var temp491 = Fun1(((uint)((s)._1)), ((uint)((s)._2)));
                                s._2 = ((uint)(temp491));
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
                            var temp492 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp486)));
                            var temp493 = ((int)((uint)(temp486)) <= (int)((uint)((uint)223U)));
                            var temp494 = ((temp492) && (temp493));
                            if (temp494)
                            {
                                var temp495 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp495));
                                goto M56;
                            }
                            else
                            {
                                var temp496 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp496)
                                {
                                    var temp497 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp497));
                                    goto M57;
                                }
                                else
                                {
                                    var temp498 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp498)
                                    {
                                        var temp499 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp499));
                                        goto M58;
                                    }
                                    else
                                    {
                                        var temp500 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp486)));
                                        var temp501 = ((int)((uint)(temp486)) <= (int)((uint)((uint)239U)));
                                        var temp502 = ((temp500) && (temp501));
                                        if (temp502)
                                        {
                                            var temp503 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp503));
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
                        var temp504 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp505 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp504)));
                        var temp506 = ((int)((uint)(temp504)) <= (int)((uint)((uint)127U)));
                        var temp507 = ((temp505) && (temp506));
                        if (temp507)
                        {
                            var temp508 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp509 = ((byte)(((byte)(i)) >> 6));
                            var temp510 = (((byte)(temp509 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp511 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp512 = (((temp508) && (temp510)) && (temp511));
                            if (temp512)
                            {
                                goto M47;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp513 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp504)));
                            var temp514 = ((int)((uint)(temp504)) <= (int)((uint)((uint)223U)));
                            var temp515 = ((temp513) && (temp514));
                            if (temp515)
                            {
                                var temp516 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp516));
                                goto M48;
                            }
                            else
                            {
                                var temp517 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp517)
                                {
                                    var temp518 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp518));
                                    goto M49;
                                }
                                else
                                {
                                    var temp519 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp519)
                                    {
                                        var temp520 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp520));
                                        goto M50;
                                    }
                                    else
                                    {
                                        var temp521 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp504)));
                                        var temp522 = ((int)((uint)(temp504)) <= (int)((uint)((uint)239U)));
                                        var temp523 = ((temp521) && (temp522));
                                        if (temp523)
                                        {
                                            var temp524 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp524));
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
                        var temp525 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp526 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp525)));
                        var temp527 = ((int)((uint)(temp525)) <= (int)((uint)((uint)191U)));
                        var temp528 = ((temp526) && (temp527));
                        if (temp528)
                        {
                            var temp529 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp530 = Fun0(((ushort)((s)._0)), ((ushort)(temp529)));
                            var temp531 = (((ushort)(temp530)) == ((ushort)((ushort)44U)));
                            if (temp531)
                                throw new Exception();
                            else
                            {
                                var temp532 = (((ushort)(temp530)) == ((ushort)((ushort)46U)));
                                if (temp532)
                                    throw new Exception();
                                else
                                {
                                    var temp533 = (((ushort)((ushort)48U)) <= ((ushort)(temp530)));
                                    var temp534 = ((ushort)(((ushort)(temp530)) >> 6));
                                    var temp535 = (((ushort)(temp534 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                    var temp536 = (((byte)(((byte)((ushort)(temp530))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                    var temp537 = (((temp533) && (temp535)) && (temp536));
                                    var temp538 = (((ushort)((ushort)1632U)) <= ((ushort)(temp530)));
                                    var temp539 = ((byte)(((ushort)(temp530)) >> 11));
                                    var temp540 = (((byte)(temp539 & 31L)) == ((byte)((byte)0U & 31L)));
                                    var temp541 = (((ushort)(((ushort)((ushort)(temp530))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                    var temp542 = (((temp538) && (temp540)) && (temp541));
                                    var temp543 = (((ushort)((ushort)1776U)) <= ((ushort)(temp530)));
                                    var temp544 = (((ushort)(((ushort)((ushort)(temp530))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                    var temp545 = (((temp543) && (temp540)) && (temp544));
                                    var temp546 = (((ushort)((ushort)1984U)) <= ((ushort)(temp530)));
                                    var temp547 = (((ushort)(((ushort)((ushort)(temp530))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                    var temp548 = (((temp546) && (temp540)) && (temp547));
                                    var temp549 = (((ushort)((ushort)2406U)) <= ((ushort)(temp530)));
                                    var temp550 = ((byte)(((ushort)(temp530)) >> 12));
                                    var temp551 = (((byte)(temp550 & 15L)) == ((byte)((byte)0U & 15L)));
                                    var temp552 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                    var temp553 = (((temp549) && (temp551)) && (temp552));
                                    var temp554 = (((ushort)((ushort)2534U)) <= ((ushort)(temp530)));
                                    var temp555 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                    var temp556 = (((temp554) && (temp551)) && (temp555));
                                    var temp557 = (((ushort)((ushort)2662U)) <= ((ushort)(temp530)));
                                    var temp558 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                    var temp559 = (((temp557) && (temp551)) && (temp558));
                                    var temp560 = (((ushort)((ushort)2790U)) <= ((ushort)(temp530)));
                                    var temp561 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                    var temp562 = (((temp560) && (temp551)) && (temp561));
                                    var temp563 = (((ushort)((ushort)2918U)) <= ((ushort)(temp530)));
                                    var temp564 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                    var temp565 = (((temp563) && (temp551)) && (temp564));
                                    var temp566 = (((ushort)((ushort)3046U)) <= ((ushort)(temp530)));
                                    var temp567 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                    var temp568 = (((temp566) && (temp551)) && (temp567));
                                    var temp569 = (((ushort)((ushort)3174U)) <= ((ushort)(temp530)));
                                    var temp570 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                    var temp571 = (((temp569) && (temp551)) && (temp570));
                                    var temp572 = (((ushort)((ushort)3302U)) <= ((ushort)(temp530)));
                                    var temp573 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                    var temp574 = (((temp572) && (temp551)) && (temp573));
                                    var temp575 = (((ushort)((ushort)3430U)) <= ((ushort)(temp530)));
                                    var temp576 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                    var temp577 = (((temp575) && (temp551)) && (temp576));
                                    var temp578 = (((ushort)((ushort)3664U)) <= ((ushort)(temp530)));
                                    var temp579 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                    var temp580 = (((temp578) && (temp551)) && (temp579));
                                    var temp581 = (((ushort)((ushort)3792U)) <= ((ushort)(temp530)));
                                    var temp582 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                    var temp583 = (((temp581) && (temp551)) && (temp582));
                                    var temp584 = (((ushort)((ushort)3872U)) <= ((ushort)(temp530)));
                                    var temp585 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                    var temp586 = (((temp584) && (temp551)) && (temp585));
                                    var temp587 = (((ushort)((ushort)4160U)) <= ((ushort)(temp530)));
                                    var temp588 = ((byte)(((ushort)(temp530)) >> 13));
                                    var temp589 = (((byte)(temp588 & 7L)) == ((byte)((byte)0U & 7L)));
                                    var temp590 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                    var temp591 = (((temp587) && (temp589)) && (temp590));
                                    var temp592 = (((ushort)((ushort)4240U)) <= ((ushort)(temp530)));
                                    var temp593 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                    var temp594 = (((temp592) && (temp589)) && (temp593));
                                    var temp595 = (((ushort)((ushort)6112U)) <= ((ushort)(temp530)));
                                    var temp596 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                    var temp597 = (((temp595) && (temp589)) && (temp596));
                                    var temp598 = (((ushort)((ushort)6160U)) <= ((ushort)(temp530)));
                                    var temp599 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                    var temp600 = (((temp598) && (temp589)) && (temp599));
                                    var temp601 = (((ushort)((ushort)6470U)) <= ((ushort)(temp530)));
                                    var temp602 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                    var temp603 = (((temp601) && (temp589)) && (temp602));
                                    var temp604 = (((ushort)((ushort)6608U)) <= ((ushort)(temp530)));
                                    var temp605 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                    var temp606 = (((temp604) && (temp589)) && (temp605));
                                    var temp607 = (((ushort)((ushort)6992U)) <= ((ushort)(temp530)));
                                    var temp608 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                    var temp609 = (((temp607) && (temp589)) && (temp608));
                                    var temp610 = (((ushort)((ushort)7088U)) <= ((ushort)(temp530)));
                                    var temp611 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                    var temp612 = (((temp610) && (temp589)) && (temp611));
                                    var temp613 = (((ushort)((ushort)7232U)) <= ((ushort)(temp530)));
                                    var temp614 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                    var temp615 = (((temp613) && (temp589)) && (temp614));
                                    var temp616 = (((ushort)((ushort)7248U)) <= ((ushort)(temp530)));
                                    var temp617 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                    var temp618 = (((temp616) && (temp589)) && (temp617));
                                    var temp619 = (((ushort)((ushort)42528U)) <= ((ushort)(temp530)));
                                    var temp620 = (((ushort)(temp530)) <= ((ushort)((ushort)42537U)));
                                    var temp621 = ((temp619) && (temp620));
                                    var temp622 = (((ushort)((ushort)43216U)) <= ((ushort)(temp530)));
                                    var temp623 = (((ushort)(temp530)) <= ((ushort)((ushort)43225U)));
                                    var temp624 = ((temp622) && (temp623));
                                    var temp625 = (((ushort)((ushort)43264U)) <= ((ushort)(temp530)));
                                    var temp626 = (((ushort)(temp530)) <= ((ushort)((ushort)43273U)));
                                    var temp627 = ((temp625) && (temp626));
                                    var temp628 = (((ushort)((ushort)43600U)) <= ((ushort)(temp530)));
                                    var temp629 = (((ushort)(temp530)) <= ((ushort)((ushort)43609U)));
                                    var temp630 = ((temp628) && (temp629));
                                    var temp631 = (((ushort)((ushort)65296U)) <= ((ushort)(temp530)));
                                    var temp632 = (((ushort)(temp530)) <= ((ushort)((ushort)65305U)));
                                    var temp633 = ((temp631) && (temp632));
                                    var temp634 = (((((((((((((((((((((((((((((((temp537) || (temp542)) || (temp545)) || (temp548)) || (temp553)) || (temp556)) || (temp559)) || (temp562)) || (temp565)) || (temp568)) || (temp571)) || (temp574)) || (temp577)) || (temp580)) || (temp583)) || (temp586)) || (temp591)) || (temp594)) || (temp597)) || (temp600)) || (temp603)) || (temp606)) || (temp609)) || (temp612)) || (temp615)) || (temp618)) || (temp621)) || (temp624)) || (temp627)) || (temp630)) || (temp633));
                                    if (temp634)
                                    {
                                        var temp635 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                        var temp636 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp530));
                                        var temp637 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp635))) + ((uint)(temp636))));
                                        s._1 = ((uint)(temp637));
                                        s._0 = ((ushort)((ushort)0U));
                                        goto M36;
                                    }
                                    else
                                        throw new Exception();
                                }
                            }
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
                        var temp638 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp639 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp638)));
                        var temp640 = ((int)((uint)(temp638)) <= (int)((uint)((uint)191U)));
                        var temp641 = ((temp639) && (temp640));
                        if (temp641)
                        {
                            var temp642 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp643 = Fun0(((ushort)((s)._0)), ((ushort)(temp642)));
                            s._0 = ((ushort)(temp643));
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
                        var temp644 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp645 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp644)));
                        var temp646 = ((int)((uint)(temp644)) <= (int)((uint)((uint)159U)));
                        var temp647 = ((temp645) && (temp646));
                        if (temp647)
                        {
                            var temp648 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp649 = Fun0(((ushort)((s)._0)), ((ushort)(temp648)));
                            s._0 = ((ushort)(temp649));
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
                        var temp650 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp651 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp650)));
                        var temp652 = ((int)((uint)(temp650)) <= (int)((uint)((uint)191U)));
                        var temp653 = ((temp651) && (temp652));
                        if (temp653)
                        {
                            var temp654 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp655 = Fun0(((ushort)((s)._0)), ((ushort)(temp654)));
                            s._0 = ((ushort)(temp655));
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
                        var temp656 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp657 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp656)));
                        var temp658 = ((int)((uint)(temp656)) <= (int)((uint)((uint)127U)));
                        var temp659 = ((temp657) && (temp658));
                        if (temp659)
                        {
                            var temp660 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp660)
                            {
                                goto M41;
                            }
                            else
                            {
                                var temp661 = (((byte)((byte)48U)) <= ((byte)(i)));
                                var temp662 = ((byte)(((byte)(i)) >> 6));
                                var temp663 = (((byte)(temp662 & 3L)) == ((byte)((byte)0U & 3L)));
                                var temp664 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp665 = (((temp661) && (temp663)) && (temp664));
                                if (temp665)
                                {
                                    goto M47;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                        else
                        {
                            var temp666 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp656)));
                            var temp667 = ((int)((uint)(temp656)) <= (int)((uint)((uint)223U)));
                            var temp668 = ((temp666) && (temp667));
                            if (temp668)
                            {
                                var temp669 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp669));
                                goto M52;
                            }
                            else
                            {
                                var temp670 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp670)
                                {
                                    var temp671 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp671));
                                    goto M53;
                                }
                                else
                                {
                                    var temp672 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp672)
                                    {
                                        var temp673 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp673));
                                        goto M54;
                                    }
                                    else
                                    {
                                        var temp674 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp656)));
                                        var temp675 = ((int)((uint)(temp656)) <= (int)((uint)((uint)239U)));
                                        var temp676 = ((temp674) && (temp675));
                                        if (temp676)
                                        {
                                            var temp677 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp677));
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
                        var temp678 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp679 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp678)));
                        var temp680 = ((int)((uint)(temp678)) <= (int)((uint)((uint)191U)));
                        var temp681 = ((temp679) && (temp680));
                        if (temp681)
                        {
                            var temp682 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp683 = Fun0(((ushort)((s)._0)), ((ushort)(temp682)));
                            var temp684 = (((ushort)((ushort)48U)) <= ((ushort)(temp683)));
                            var temp685 = ((ushort)(((ushort)(temp683)) >> 6));
                            var temp686 = (((ushort)(temp685 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp687 = (((byte)(((byte)((ushort)(temp683))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp688 = (((temp684) && (temp686)) && (temp687));
                            var temp689 = (((ushort)((ushort)1632U)) <= ((ushort)(temp683)));
                            var temp690 = ((byte)(((ushort)(temp683)) >> 11));
                            var temp691 = (((byte)(temp690 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp692 = (((ushort)(((ushort)((ushort)(temp683))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp693 = (((temp689) && (temp691)) && (temp692));
                            var temp694 = (((ushort)((ushort)1776U)) <= ((ushort)(temp683)));
                            var temp695 = (((ushort)(((ushort)((ushort)(temp683))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp696 = (((temp694) && (temp691)) && (temp695));
                            var temp697 = (((ushort)((ushort)1984U)) <= ((ushort)(temp683)));
                            var temp698 = (((ushort)(((ushort)((ushort)(temp683))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp699 = (((temp697) && (temp691)) && (temp698));
                            var temp700 = (((ushort)((ushort)2406U)) <= ((ushort)(temp683)));
                            var temp701 = ((byte)(((ushort)(temp683)) >> 12));
                            var temp702 = (((byte)(temp701 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp703 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp704 = (((temp700) && (temp702)) && (temp703));
                            var temp705 = (((ushort)((ushort)2534U)) <= ((ushort)(temp683)));
                            var temp706 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp707 = (((temp705) && (temp702)) && (temp706));
                            var temp708 = (((ushort)((ushort)2662U)) <= ((ushort)(temp683)));
                            var temp709 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp710 = (((temp708) && (temp702)) && (temp709));
                            var temp711 = (((ushort)((ushort)2790U)) <= ((ushort)(temp683)));
                            var temp712 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp713 = (((temp711) && (temp702)) && (temp712));
                            var temp714 = (((ushort)((ushort)2918U)) <= ((ushort)(temp683)));
                            var temp715 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp716 = (((temp714) && (temp702)) && (temp715));
                            var temp717 = (((ushort)((ushort)3046U)) <= ((ushort)(temp683)));
                            var temp718 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp719 = (((temp717) && (temp702)) && (temp718));
                            var temp720 = (((ushort)((ushort)3174U)) <= ((ushort)(temp683)));
                            var temp721 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp722 = (((temp720) && (temp702)) && (temp721));
                            var temp723 = (((ushort)((ushort)3302U)) <= ((ushort)(temp683)));
                            var temp724 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp725 = (((temp723) && (temp702)) && (temp724));
                            var temp726 = (((ushort)((ushort)3430U)) <= ((ushort)(temp683)));
                            var temp727 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp728 = (((temp726) && (temp702)) && (temp727));
                            var temp729 = (((ushort)((ushort)3664U)) <= ((ushort)(temp683)));
                            var temp730 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp731 = (((temp729) && (temp702)) && (temp730));
                            var temp732 = (((ushort)((ushort)3792U)) <= ((ushort)(temp683)));
                            var temp733 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp734 = (((temp732) && (temp702)) && (temp733));
                            var temp735 = (((ushort)((ushort)3872U)) <= ((ushort)(temp683)));
                            var temp736 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp737 = (((temp735) && (temp702)) && (temp736));
                            var temp738 = (((ushort)((ushort)4160U)) <= ((ushort)(temp683)));
                            var temp739 = ((byte)(((ushort)(temp683)) >> 13));
                            var temp740 = (((byte)(temp739 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp741 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp742 = (((temp738) && (temp740)) && (temp741));
                            var temp743 = (((ushort)((ushort)4240U)) <= ((ushort)(temp683)));
                            var temp744 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp745 = (((temp743) && (temp740)) && (temp744));
                            var temp746 = (((ushort)((ushort)6112U)) <= ((ushort)(temp683)));
                            var temp747 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp748 = (((temp746) && (temp740)) && (temp747));
                            var temp749 = (((ushort)((ushort)6160U)) <= ((ushort)(temp683)));
                            var temp750 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp751 = (((temp749) && (temp740)) && (temp750));
                            var temp752 = (((ushort)((ushort)6470U)) <= ((ushort)(temp683)));
                            var temp753 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp754 = (((temp752) && (temp740)) && (temp753));
                            var temp755 = (((ushort)((ushort)6608U)) <= ((ushort)(temp683)));
                            var temp756 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp757 = (((temp755) && (temp740)) && (temp756));
                            var temp758 = (((ushort)((ushort)6992U)) <= ((ushort)(temp683)));
                            var temp759 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp760 = (((temp758) && (temp740)) && (temp759));
                            var temp761 = (((ushort)((ushort)7088U)) <= ((ushort)(temp683)));
                            var temp762 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp763 = (((temp761) && (temp740)) && (temp762));
                            var temp764 = (((ushort)((ushort)7232U)) <= ((ushort)(temp683)));
                            var temp765 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp766 = (((temp764) && (temp740)) && (temp765));
                            var temp767 = (((ushort)((ushort)7248U)) <= ((ushort)(temp683)));
                            var temp768 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp769 = (((temp767) && (temp740)) && (temp768));
                            var temp770 = (((ushort)((ushort)42528U)) <= ((ushort)(temp683)));
                            var temp771 = (((ushort)(temp683)) <= ((ushort)((ushort)42537U)));
                            var temp772 = ((temp770) && (temp771));
                            var temp773 = (((ushort)((ushort)43216U)) <= ((ushort)(temp683)));
                            var temp774 = (((ushort)(temp683)) <= ((ushort)((ushort)43225U)));
                            var temp775 = ((temp773) && (temp774));
                            var temp776 = (((ushort)((ushort)43264U)) <= ((ushort)(temp683)));
                            var temp777 = (((ushort)(temp683)) <= ((ushort)((ushort)43273U)));
                            var temp778 = ((temp776) && (temp777));
                            var temp779 = (((ushort)((ushort)43600U)) <= ((ushort)(temp683)));
                            var temp780 = (((ushort)(temp683)) <= ((ushort)((ushort)43609U)));
                            var temp781 = ((temp779) && (temp780));
                            var temp782 = (((ushort)((ushort)65296U)) <= ((ushort)(temp683)));
                            var temp783 = (((ushort)(temp683)) <= ((ushort)((ushort)65305U)));
                            var temp784 = ((temp782) && (temp783));
                            var temp785 = (((((((((((((((((((((((((((((((temp688) || (temp693)) || (temp696)) || (temp699)) || (temp704)) || (temp707)) || (temp710)) || (temp713)) || (temp716)) || (temp719)) || (temp722)) || (temp725)) || (temp728)) || (temp731)) || (temp734)) || (temp737)) || (temp742)) || (temp745)) || (temp748)) || (temp751)) || (temp754)) || (temp757)) || (temp760)) || (temp763)) || (temp766)) || (temp769)) || (temp772)) || (temp775)) || (temp778)) || (temp781)) || (temp784));
                            if (temp785)
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
                        var temp786 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp787 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp786)));
                        var temp788 = ((int)((uint)(temp786)) <= (int)((uint)((uint)191U)));
                        var temp789 = ((temp787) && (temp788));
                        if (temp789)
                        {
                            var temp790 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp791 = Fun0(((ushort)((s)._0)), ((ushort)(temp790)));
                            s._0 = ((ushort)(temp791));
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
                        var temp792 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp793 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp792)));
                        var temp794 = ((int)((uint)(temp792)) <= (int)((uint)((uint)159U)));
                        var temp795 = ((temp793) && (temp794));
                        if (temp795)
                        {
                            var temp796 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp797 = Fun0(((ushort)((s)._0)), ((ushort)(temp796)));
                            s._0 = ((ushort)(temp797));
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
                        var temp798 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp799 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp798)));
                        var temp800 = ((int)((uint)(temp798)) <= (int)((uint)((uint)191U)));
                        var temp801 = ((temp799) && (temp800));
                        if (temp801)
                        {
                            var temp802 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp803 = Fun0(((ushort)((s)._0)), ((ushort)(temp802)));
                            s._0 = ((ushort)(temp803));
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
                        var temp804 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp805 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp804)));
                        var temp806 = ((int)((uint)(temp804)) <= (int)((uint)((uint)191U)));
                        var temp807 = ((temp805) && (temp806));
                        if (temp807)
                        {
                            var temp808 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp809 = Fun0(((ushort)((s)._0)), ((ushort)(temp808)));
                            var temp810 = (((ushort)(temp809)) == ((ushort)((ushort)44U)));
                            if (temp810)
                                throw new Exception();
                            else
                            {
                                var temp811 = (((ushort)((ushort)48U)) <= ((ushort)(temp809)));
                                var temp812 = ((ushort)(((ushort)(temp809)) >> 6));
                                var temp813 = (((ushort)(temp812 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                var temp814 = (((byte)(((byte)((ushort)(temp809))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp815 = (((temp811) && (temp813)) && (temp814));
                                var temp816 = (((ushort)((ushort)1632U)) <= ((ushort)(temp809)));
                                var temp817 = ((byte)(((ushort)(temp809)) >> 11));
                                var temp818 = (((byte)(temp817 & 31L)) == ((byte)((byte)0U & 31L)));
                                var temp819 = (((ushort)(((ushort)((ushort)(temp809))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                var temp820 = (((temp816) && (temp818)) && (temp819));
                                var temp821 = (((ushort)((ushort)1776U)) <= ((ushort)(temp809)));
                                var temp822 = (((ushort)(((ushort)((ushort)(temp809))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                var temp823 = (((temp821) && (temp818)) && (temp822));
                                var temp824 = (((ushort)((ushort)1984U)) <= ((ushort)(temp809)));
                                var temp825 = (((ushort)(((ushort)((ushort)(temp809))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                var temp826 = (((temp824) && (temp818)) && (temp825));
                                var temp827 = (((ushort)((ushort)2406U)) <= ((ushort)(temp809)));
                                var temp828 = ((byte)(((ushort)(temp809)) >> 12));
                                var temp829 = (((byte)(temp828 & 15L)) == ((byte)((byte)0U & 15L)));
                                var temp830 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                var temp831 = (((temp827) && (temp829)) && (temp830));
                                var temp832 = (((ushort)((ushort)2534U)) <= ((ushort)(temp809)));
                                var temp833 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                var temp834 = (((temp832) && (temp829)) && (temp833));
                                var temp835 = (((ushort)((ushort)2662U)) <= ((ushort)(temp809)));
                                var temp836 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                var temp837 = (((temp835) && (temp829)) && (temp836));
                                var temp838 = (((ushort)((ushort)2790U)) <= ((ushort)(temp809)));
                                var temp839 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                var temp840 = (((temp838) && (temp829)) && (temp839));
                                var temp841 = (((ushort)((ushort)2918U)) <= ((ushort)(temp809)));
                                var temp842 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                var temp843 = (((temp841) && (temp829)) && (temp842));
                                var temp844 = (((ushort)((ushort)3046U)) <= ((ushort)(temp809)));
                                var temp845 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                var temp846 = (((temp844) && (temp829)) && (temp845));
                                var temp847 = (((ushort)((ushort)3174U)) <= ((ushort)(temp809)));
                                var temp848 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                var temp849 = (((temp847) && (temp829)) && (temp848));
                                var temp850 = (((ushort)((ushort)3302U)) <= ((ushort)(temp809)));
                                var temp851 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                var temp852 = (((temp850) && (temp829)) && (temp851));
                                var temp853 = (((ushort)((ushort)3430U)) <= ((ushort)(temp809)));
                                var temp854 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                var temp855 = (((temp853) && (temp829)) && (temp854));
                                var temp856 = (((ushort)((ushort)3664U)) <= ((ushort)(temp809)));
                                var temp857 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                var temp858 = (((temp856) && (temp829)) && (temp857));
                                var temp859 = (((ushort)((ushort)3792U)) <= ((ushort)(temp809)));
                                var temp860 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                var temp861 = (((temp859) && (temp829)) && (temp860));
                                var temp862 = (((ushort)((ushort)3872U)) <= ((ushort)(temp809)));
                                var temp863 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                var temp864 = (((temp862) && (temp829)) && (temp863));
                                var temp865 = (((ushort)((ushort)4160U)) <= ((ushort)(temp809)));
                                var temp866 = ((byte)(((ushort)(temp809)) >> 13));
                                var temp867 = (((byte)(temp866 & 7L)) == ((byte)((byte)0U & 7L)));
                                var temp868 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                var temp869 = (((temp865) && (temp867)) && (temp868));
                                var temp870 = (((ushort)((ushort)4240U)) <= ((ushort)(temp809)));
                                var temp871 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                var temp872 = (((temp870) && (temp867)) && (temp871));
                                var temp873 = (((ushort)((ushort)6112U)) <= ((ushort)(temp809)));
                                var temp874 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                var temp875 = (((temp873) && (temp867)) && (temp874));
                                var temp876 = (((ushort)((ushort)6160U)) <= ((ushort)(temp809)));
                                var temp877 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                var temp878 = (((temp876) && (temp867)) && (temp877));
                                var temp879 = (((ushort)((ushort)6470U)) <= ((ushort)(temp809)));
                                var temp880 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                var temp881 = (((temp879) && (temp867)) && (temp880));
                                var temp882 = (((ushort)((ushort)6608U)) <= ((ushort)(temp809)));
                                var temp883 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                var temp884 = (((temp882) && (temp867)) && (temp883));
                                var temp885 = (((ushort)((ushort)6992U)) <= ((ushort)(temp809)));
                                var temp886 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                var temp887 = (((temp885) && (temp867)) && (temp886));
                                var temp888 = (((ushort)((ushort)7088U)) <= ((ushort)(temp809)));
                                var temp889 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                var temp890 = (((temp888) && (temp867)) && (temp889));
                                var temp891 = (((ushort)((ushort)7232U)) <= ((ushort)(temp809)));
                                var temp892 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                var temp893 = (((temp891) && (temp867)) && (temp892));
                                var temp894 = (((ushort)((ushort)7248U)) <= ((ushort)(temp809)));
                                var temp895 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                var temp896 = (((temp894) && (temp867)) && (temp895));
                                var temp897 = (((ushort)((ushort)42528U)) <= ((ushort)(temp809)));
                                var temp898 = (((ushort)(temp809)) <= ((ushort)((ushort)42537U)));
                                var temp899 = ((temp897) && (temp898));
                                var temp900 = (((ushort)((ushort)43216U)) <= ((ushort)(temp809)));
                                var temp901 = (((ushort)(temp809)) <= ((ushort)((ushort)43225U)));
                                var temp902 = ((temp900) && (temp901));
                                var temp903 = (((ushort)((ushort)43264U)) <= ((ushort)(temp809)));
                                var temp904 = (((ushort)(temp809)) <= ((ushort)((ushort)43273U)));
                                var temp905 = ((temp903) && (temp904));
                                var temp906 = (((ushort)((ushort)43600U)) <= ((ushort)(temp809)));
                                var temp907 = (((ushort)(temp809)) <= ((ushort)((ushort)43609U)));
                                var temp908 = ((temp906) && (temp907));
                                var temp909 = (((ushort)((ushort)65296U)) <= ((ushort)(temp809)));
                                var temp910 = (((ushort)(temp809)) <= ((ushort)((ushort)65305U)));
                                var temp911 = ((temp909) && (temp910));
                                var temp912 = (((((((((((((((((((((((((((((((temp815) || (temp820)) || (temp823)) || (temp826)) || (temp831)) || (temp834)) || (temp837)) || (temp840)) || (temp843)) || (temp846)) || (temp849)) || (temp852)) || (temp855)) || (temp858)) || (temp861)) || (temp864)) || (temp869)) || (temp872)) || (temp875)) || (temp878)) || (temp881)) || (temp884)) || (temp887)) || (temp890)) || (temp893)) || (temp896)) || (temp899)) || (temp902)) || (temp905)) || (temp908)) || (temp911));
                                if (temp912)
                                {
                                    s._0 = ((ushort)((ushort)0U));
                                    goto M47;
                                }
                                else
                                    throw new Exception();
                            }
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
                        var temp913 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp914 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp913)));
                        var temp915 = ((int)((uint)(temp913)) <= (int)((uint)((uint)191U)));
                        var temp916 = ((temp914) && (temp915));
                        if (temp916)
                        {
                            var temp917 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp918 = Fun0(((ushort)((s)._0)), ((ushort)(temp917)));
                            s._0 = ((ushort)(temp918));
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
                        var temp919 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp920 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp919)));
                        var temp921 = ((int)((uint)(temp919)) <= (int)((uint)((uint)159U)));
                        var temp922 = ((temp920) && (temp921));
                        if (temp922)
                        {
                            var temp923 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp924 = Fun0(((ushort)((s)._0)), ((ushort)(temp923)));
                            s._0 = ((ushort)(temp924));
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
                        var temp925 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp926 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp925)));
                        var temp927 = ((int)((uint)(temp925)) <= (int)((uint)((uint)191U)));
                        var temp928 = ((temp926) && (temp927));
                        if (temp928)
                        {
                            var temp929 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp930 = Fun0(((ushort)((s)._0)), ((ushort)(temp929)));
                            s._0 = ((ushort)(temp930));
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
                        var temp931 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp932 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp931)));
                        var temp933 = ((int)((uint)(temp931)) <= (int)((uint)((uint)191U)));
                        var temp934 = ((temp932) && (temp933));
                        if (temp934)
                        {
                            var temp935 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp936 = Fun0(((ushort)((s)._0)), ((ushort)(temp935)));
                            var temp937 = (((ushort)(temp936)) == ((ushort)((ushort)10U)));
                            if (temp937)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M41;
                            }
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
                        var temp938 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp939 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp938)));
                        var temp940 = ((int)((uint)(temp938)) <= (int)((uint)((uint)191U)));
                        var temp941 = ((temp939) && (temp940));
                        if (temp941)
                        {
                            var temp942 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp943 = Fun0(((ushort)((s)._0)), ((ushort)(temp942)));
                            s._0 = ((ushort)(temp943));
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
                        var temp944 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp945 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp944)));
                        var temp946 = ((int)((uint)(temp944)) <= (int)((uint)((uint)159U)));
                        var temp947 = ((temp945) && (temp946));
                        if (temp947)
                        {
                            var temp948 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp949 = Fun0(((ushort)((s)._0)), ((ushort)(temp948)));
                            s._0 = ((ushort)(temp949));
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
                        var temp950 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp951 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp950)));
                        var temp952 = ((int)((uint)(temp950)) <= (int)((uint)((uint)191U)));
                        var temp953 = ((temp951) && (temp952));
                        if (temp953)
                        {
                            var temp954 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp955 = Fun0(((ushort)((s)._0)), ((ushort)(temp954)));
                            s._0 = ((ushort)(temp955));
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

                    var temp47 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp47))));
                    var temp48 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp48))));
                    var temp49 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp49))));
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

                    var temp56 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp56))));
                    var temp57 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp57))));
                    var temp58 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp58))));
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

                    var temp65 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp65))));
                    var temp66 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp66))));
                    var temp67 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp67))));
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

        struct DTStruct42
        {
            public UInt16 _0;
            public UInt32 _1;
            public UInt32 _2;
            public DTStruct42(UInt16 v0, UInt32 v1, UInt32 v2)
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
                DTStruct42 s = new DTStruct42(((ushort)((ushort)0U)), ((uint)((uint)0U)), ((uint)((uint)2147483647U)));
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
                            var temp44 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp45 = Fun0(((ushort)((s)._0)), ((ushort)(temp44)));
                            var temp46 = (((ushort)(temp45)) == ((ushort)((ushort)44U)));
                            if (temp46)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M0;
                            }
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
                        var temp50 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp51 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp50)));
                        var temp52 = ((int)((uint)(temp50)) <= (int)((uint)((uint)191U)));
                        var temp53 = ((temp51) && (temp52));
                        if (temp53)
                        {
                            var temp54 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp55 = Fun0(((ushort)((s)._0)), ((ushort)(temp54)));
                            s._0 = ((ushort)(temp55));
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
                        var temp59 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp60 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp59)));
                        var temp61 = ((int)((uint)(temp59)) <= (int)((uint)((uint)159U)));
                        var temp62 = ((temp60) && (temp61));
                        if (temp62)
                        {
                            var temp63 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp64 = Fun0(((ushort)((s)._0)), ((ushort)(temp63)));
                            s._0 = ((ushort)(temp64));
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
                        var temp68 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp69 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp68)));
                        var temp70 = ((int)((uint)(temp68)) <= (int)((uint)((uint)191U)));
                        var temp71 = ((temp69) && (temp70));
                        if (temp71)
                        {
                            var temp72 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp73 = Fun0(((ushort)((s)._0)), ((ushort)(temp72)));
                            s._0 = ((ushort)(temp73));
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
                        var temp74 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp75 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp74)));
                        var temp76 = ((int)((uint)(temp74)) <= (int)((uint)((uint)127U)));
                        var temp77 = ((temp75) && (temp76));
                        if (temp77)
                        {
                            var temp78 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp78)
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
                            var temp79 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp74)));
                            var temp80 = ((int)((uint)(temp74)) <= (int)((uint)((uint)223U)));
                            var temp81 = ((temp79) && (temp80));
                            if (temp81)
                            {
                                var temp82 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp82));
                                goto M12;
                            }
                            else
                            {
                                var temp83 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp83)
                                {
                                    var temp84 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp84));
                                    goto M13;
                                }
                                else
                                {
                                    var temp85 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp85)
                                    {
                                        var temp86 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp86));
                                        goto M14;
                                    }
                                    else
                                    {
                                        var temp87 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp74)));
                                        var temp88 = ((int)((uint)(temp74)) <= (int)((uint)((uint)239U)));
                                        var temp89 = ((temp87) && (temp88));
                                        if (temp89)
                                        {
                                            var temp90 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp90));
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
                        var temp91 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp92 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp91)));
                        var temp93 = ((int)((uint)(temp91)) <= (int)((uint)((uint)191U)));
                        var temp94 = ((temp92) && (temp93));
                        if (temp94)
                        {
                            var temp95 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp96 = Fun0(((ushort)((s)._0)), ((ushort)(temp95)));
                            var temp97 = (((ushort)(temp96)) == ((ushort)((ushort)44U)));
                            if (temp97)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M1;
                            }
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
                        var temp98 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp99 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp98)));
                        var temp100 = ((int)((uint)(temp98)) <= (int)((uint)((uint)191U)));
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

                M9:
                {
                    if (++iIndex >= input.Length)
                        goto F9;
                    i = input[iIndex];
                    {
                        var temp104 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp105 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp104)));
                        var temp106 = ((int)((uint)(temp104)) <= (int)((uint)((uint)159U)));
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

                M10:
                {
                    if (++iIndex >= input.Length)
                        goto F10;
                    i = input[iIndex];
                    {
                        var temp110 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp111 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp110)));
                        var temp112 = ((int)((uint)(temp110)) <= (int)((uint)((uint)191U)));
                        var temp113 = ((temp111) && (temp112));
                        if (temp113)
                        {
                            var temp114 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp115 = Fun0(((ushort)((s)._0)), ((ushort)(temp114)));
                            s._0 = ((ushort)(temp115));
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
                        var temp116 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp117 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp116)));
                        var temp118 = ((int)((uint)(temp116)) <= (int)((uint)((uint)127U)));
                        var temp119 = ((temp117) && (temp118));
                        if (temp119)
                        {
                            var temp120 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp120)
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
                            var temp121 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp116)));
                            var temp122 = ((int)((uint)(temp116)) <= (int)((uint)((uint)223U)));
                            var temp123 = ((temp121) && (temp122));
                            if (temp123)
                            {
                                var temp124 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp124));
                                goto M17;
                            }
                            else
                            {
                                var temp125 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp125)
                                {
                                    var temp126 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp126));
                                    goto M18;
                                }
                                else
                                {
                                    var temp127 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp127)
                                    {
                                        var temp128 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp128));
                                        goto M19;
                                    }
                                    else
                                    {
                                        var temp129 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp116)));
                                        var temp130 = ((int)((uint)(temp116)) <= (int)((uint)((uint)239U)));
                                        var temp131 = ((temp129) && (temp130));
                                        if (temp131)
                                        {
                                            var temp132 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp132));
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
                        var temp133 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp134 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp133)));
                        var temp135 = ((int)((uint)(temp133)) <= (int)((uint)((uint)191U)));
                        var temp136 = ((temp134) && (temp135));
                        if (temp136)
                        {
                            var temp137 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp138 = Fun0(((ushort)((s)._0)), ((ushort)(temp137)));
                            var temp139 = (((ushort)(temp138)) == ((ushort)((ushort)44U)));
                            if (temp139)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M6;
                            }
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
                        var temp140 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp141 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp140)));
                        var temp142 = ((int)((uint)(temp140)) <= (int)((uint)((uint)191U)));
                        var temp143 = ((temp141) && (temp142));
                        if (temp143)
                        {
                            var temp144 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp145 = Fun0(((ushort)((s)._0)), ((ushort)(temp144)));
                            s._0 = ((ushort)(temp145));
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
                        var temp146 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp147 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp146)));
                        var temp148 = ((int)((uint)(temp146)) <= (int)((uint)((uint)159U)));
                        var temp149 = ((temp147) && (temp148));
                        if (temp149)
                        {
                            var temp150 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp151 = Fun0(((ushort)((s)._0)), ((ushort)(temp150)));
                            s._0 = ((ushort)(temp151));
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
                        var temp152 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp153 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp152)));
                        var temp154 = ((int)((uint)(temp152)) <= (int)((uint)((uint)191U)));
                        var temp155 = ((temp153) && (temp154));
                        if (temp155)
                        {
                            var temp156 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp157 = Fun0(((ushort)((s)._0)), ((ushort)(temp156)));
                            s._0 = ((ushort)(temp157));
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
                        var temp158 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp159 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp158)));
                        var temp160 = ((int)((uint)(temp158)) <= (int)((uint)((uint)127U)));
                        var temp161 = ((temp159) && (temp160));
                        if (temp161)
                        {
                            var temp162 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp162)
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
                            var temp163 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp158)));
                            var temp164 = ((int)((uint)(temp158)) <= (int)((uint)((uint)223U)));
                            var temp165 = ((temp163) && (temp164));
                            if (temp165)
                            {
                                var temp166 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp166));
                                goto M22;
                            }
                            else
                            {
                                var temp167 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp167)
                                {
                                    var temp168 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp168));
                                    goto M23;
                                }
                                else
                                {
                                    var temp169 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp169)
                                    {
                                        var temp170 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp170));
                                        goto M24;
                                    }
                                    else
                                    {
                                        var temp171 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp158)));
                                        var temp172 = ((int)((uint)(temp158)) <= (int)((uint)((uint)239U)));
                                        var temp173 = ((temp171) && (temp172));
                                        if (temp173)
                                        {
                                            var temp174 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp174));
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
                        var temp175 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp176 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp175)));
                        var temp177 = ((int)((uint)(temp175)) <= (int)((uint)((uint)191U)));
                        var temp178 = ((temp176) && (temp177));
                        if (temp178)
                        {
                            var temp179 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp180 = Fun0(((ushort)((s)._0)), ((ushort)(temp179)));
                            var temp181 = (((ushort)(temp180)) == ((ushort)((ushort)44U)));
                            if (temp181)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M11;
                            }
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
                        var temp182 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp183 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp182)));
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

                M19:
                {
                    if (++iIndex >= input.Length)
                        goto F19;
                    i = input[iIndex];
                    {
                        var temp188 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp189 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp188)));
                        var temp190 = ((int)((uint)(temp188)) <= (int)((uint)((uint)159U)));
                        var temp191 = ((temp189) && (temp190));
                        if (temp191)
                        {
                            var temp192 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp193 = Fun0(((ushort)((s)._0)), ((ushort)(temp192)));
                            s._0 = ((ushort)(temp193));
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
                        var temp194 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp195 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp194)));
                        var temp196 = ((int)((uint)(temp194)) <= (int)((uint)((uint)191U)));
                        var temp197 = ((temp195) && (temp196));
                        if (temp197)
                        {
                            var temp198 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp199 = Fun0(((ushort)((s)._0)), ((ushort)(temp198)));
                            s._0 = ((ushort)(temp199));
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
                        var temp200 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp201 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp200)));
                        var temp202 = ((int)((uint)(temp200)) <= (int)((uint)((uint)127U)));
                        var temp203 = ((temp201) && (temp202));
                        if (temp203)
                        {
                            var temp204 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp204)
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
                            var temp205 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp200)));
                            var temp206 = ((int)((uint)(temp200)) <= (int)((uint)((uint)223U)));
                            var temp207 = ((temp205) && (temp206));
                            if (temp207)
                            {
                                var temp208 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp208));
                                goto M27;
                            }
                            else
                            {
                                var temp209 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp209)
                                {
                                    var temp210 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp210));
                                    goto M28;
                                }
                                else
                                {
                                    var temp211 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp211)
                                    {
                                        var temp212 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp212));
                                        goto M29;
                                    }
                                    else
                                    {
                                        var temp213 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp200)));
                                        var temp214 = ((int)((uint)(temp200)) <= (int)((uint)((uint)239U)));
                                        var temp215 = ((temp213) && (temp214));
                                        if (temp215)
                                        {
                                            var temp216 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp216));
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
                        var temp217 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp218 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp217)));
                        var temp219 = ((int)((uint)(temp217)) <= (int)((uint)((uint)191U)));
                        var temp220 = ((temp218) && (temp219));
                        if (temp220)
                        {
                            var temp221 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp222 = Fun0(((ushort)((s)._0)), ((ushort)(temp221)));
                            var temp223 = (((ushort)(temp222)) == ((ushort)((ushort)44U)));
                            if (temp223)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M16;
                            }
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
                        var temp224 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp225 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp224)));
                        var temp226 = ((int)((uint)(temp224)) <= (int)((uint)((uint)191U)));
                        var temp227 = ((temp225) && (temp226));
                        if (temp227)
                        {
                            var temp228 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp229 = Fun0(((ushort)((s)._0)), ((ushort)(temp228)));
                            s._0 = ((ushort)(temp229));
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
                        var temp230 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp231 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp230)));
                        var temp232 = ((int)((uint)(temp230)) <= (int)((uint)((uint)159U)));
                        var temp233 = ((temp231) && (temp232));
                        if (temp233)
                        {
                            var temp234 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp235 = Fun0(((ushort)((s)._0)), ((ushort)(temp234)));
                            s._0 = ((ushort)(temp235));
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
                        var temp236 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp237 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp236)));
                        var temp238 = ((int)((uint)(temp236)) <= (int)((uint)((uint)191U)));
                        var temp239 = ((temp237) && (temp238));
                        if (temp239)
                        {
                            var temp240 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp241 = Fun0(((ushort)((s)._0)), ((ushort)(temp240)));
                            s._0 = ((ushort)(temp241));
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
                        var temp242 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp243 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp242)));
                        var temp244 = ((int)((uint)(temp242)) <= (int)((uint)((uint)127U)));
                        var temp245 = ((temp243) && (temp244));
                        if (temp245)
                        {
                            var temp246 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp246)
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
                            var temp247 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp242)));
                            var temp248 = ((int)((uint)(temp242)) <= (int)((uint)((uint)223U)));
                            var temp249 = ((temp247) && (temp248));
                            if (temp249)
                            {
                                var temp250 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp250));
                                goto M32;
                            }
                            else
                            {
                                var temp251 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp251)
                                {
                                    var temp252 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp252));
                                    goto M33;
                                }
                                else
                                {
                                    var temp253 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp253)
                                    {
                                        var temp254 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp254));
                                        goto M34;
                                    }
                                    else
                                    {
                                        var temp255 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp242)));
                                        var temp256 = ((int)((uint)(temp242)) <= (int)((uint)((uint)239U)));
                                        var temp257 = ((temp255) && (temp256));
                                        if (temp257)
                                        {
                                            var temp258 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp258));
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
                        var temp259 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp260 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp259)));
                        var temp261 = ((int)((uint)(temp259)) <= (int)((uint)((uint)191U)));
                        var temp262 = ((temp260) && (temp261));
                        if (temp262)
                        {
                            var temp263 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp264 = Fun0(((ushort)((s)._0)), ((ushort)(temp263)));
                            var temp265 = (((ushort)(temp264)) == ((ushort)((ushort)44U)));
                            if (temp265)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M21;
                            }
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
                        var temp266 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp267 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp266)));
                        var temp268 = ((int)((uint)(temp266)) <= (int)((uint)((uint)191U)));
                        var temp269 = ((temp267) && (temp268));
                        if (temp269)
                        {
                            var temp270 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp271 = Fun0(((ushort)((s)._0)), ((ushort)(temp270)));
                            s._0 = ((ushort)(temp271));
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
                        var temp272 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp273 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp272)));
                        var temp274 = ((int)((uint)(temp272)) <= (int)((uint)((uint)159U)));
                        var temp275 = ((temp273) && (temp274));
                        if (temp275)
                        {
                            var temp276 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp277 = Fun0(((ushort)((s)._0)), ((ushort)(temp276)));
                            s._0 = ((ushort)(temp277));
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
                        var temp278 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp279 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp278)));
                        var temp280 = ((int)((uint)(temp278)) <= (int)((uint)((uint)191U)));
                        var temp281 = ((temp279) && (temp280));
                        if (temp281)
                        {
                            var temp282 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp283 = Fun0(((ushort)((s)._0)), ((ushort)(temp282)));
                            s._0 = ((ushort)(temp283));
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
                        var temp284 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp285 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp284)));
                        var temp286 = ((int)((uint)(temp284)) <= (int)((uint)((uint)127U)));
                        var temp287 = ((temp285) && (temp286));
                        if (temp287)
                        {
                            var temp288 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp289 = ((byte)(((byte)(i)) >> 6));
                            var temp290 = (((byte)(temp289 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp291 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp292 = (((temp288) && (temp290)) && (temp291));
                            if (temp292)
                            {
                                var temp293 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp294 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp293))) + ((uint)(temp284))));
                                s._1 = ((uint)(temp294));
                                goto M36;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp295 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp284)));
                            var temp296 = ((int)((uint)(temp284)) <= (int)((uint)((uint)223U)));
                            var temp297 = ((temp295) && (temp296));
                            if (temp297)
                            {
                                var temp298 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp298));
                                goto M37;
                            }
                            else
                            {
                                var temp299 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp299)
                                {
                                    var temp300 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp300));
                                    goto M38;
                                }
                                else
                                {
                                    var temp301 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp301)
                                    {
                                        var temp302 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp302));
                                        goto M39;
                                    }
                                    else
                                    {
                                        var temp303 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp284)));
                                        var temp304 = ((int)((uint)(temp284)) <= (int)((uint)((uint)239U)));
                                        var temp305 = ((temp303) && (temp304));
                                        if (temp305)
                                        {
                                            var temp306 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp306));
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
                        var temp307 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp308 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp307)));
                        var temp309 = ((int)((uint)(temp307)) <= (int)((uint)((uint)191U)));
                        var temp310 = ((temp308) && (temp309));
                        if (temp310)
                        {
                            var temp311 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp312 = Fun0(((ushort)((s)._0)), ((ushort)(temp311)));
                            var temp313 = (((ushort)(temp312)) == ((ushort)((ushort)44U)));
                            if (temp313)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M26;
                            }
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
                        var temp314 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp315 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp314)));
                        var temp316 = ((int)((uint)(temp314)) <= (int)((uint)((uint)191U)));
                        var temp317 = ((temp315) && (temp316));
                        if (temp317)
                        {
                            var temp318 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp319 = Fun0(((ushort)((s)._0)), ((ushort)(temp318)));
                            s._0 = ((ushort)(temp319));
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
                        var temp320 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp321 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp320)));
                        var temp322 = ((int)((uint)(temp320)) <= (int)((uint)((uint)159U)));
                        var temp323 = ((temp321) && (temp322));
                        if (temp323)
                        {
                            var temp324 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp325 = Fun0(((ushort)((s)._0)), ((ushort)(temp324)));
                            s._0 = ((ushort)(temp325));
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
                        var temp326 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp327 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp326)));
                        var temp328 = ((int)((uint)(temp326)) <= (int)((uint)((uint)191U)));
                        var temp329 = ((temp327) && (temp328));
                        if (temp329)
                        {
                            var temp330 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp331 = Fun0(((ushort)((s)._0)), ((ushort)(temp330)));
                            s._0 = ((ushort)(temp331));
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
                        var temp332 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp333 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp332)));
                        var temp334 = ((int)((uint)(temp332)) <= (int)((uint)((uint)127U)));
                        var temp335 = ((temp333) && (temp334));
                        if (temp335)
                        {
                            var temp336 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp336)
                            {
                                goto M41;
                            }
                            else
                            {
                                var temp337 = (((byte)(i)) == ((byte)((byte)46U)));
                                if (temp337)
                                {
                                    goto M42;
                                }
                                else
                                {
                                    var temp338 = (((byte)((byte)48U)) <= ((byte)(i)));
                                    var temp339 = ((byte)(((byte)(i)) >> 6));
                                    var temp340 = (((byte)(temp339 & 3L)) == ((byte)((byte)0U & 3L)));
                                    var temp341 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                    var temp342 = (((temp338) && (temp340)) && (temp341));
                                    if (temp342)
                                    {
                                        var temp343 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                        var temp344 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp343))) + ((uint)(temp332))));
                                        s._1 = ((uint)(temp344));
                                        goto M36;
                                    }
                                    else
                                        throw new Exception();
                                }
                            }
                        }
                        else
                        {
                            var temp345 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp332)));
                            var temp346 = ((int)((uint)(temp332)) <= (int)((uint)((uint)223U)));
                            var temp347 = ((temp345) && (temp346));
                            if (temp347)
                            {
                                var temp348 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp348));
                                goto M43;
                            }
                            else
                            {
                                var temp349 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp349)
                                {
                                    var temp350 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp350));
                                    goto M44;
                                }
                                else
                                {
                                    var temp351 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp351)
                                    {
                                        var temp352 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp352));
                                        goto M45;
                                    }
                                    else
                                    {
                                        var temp353 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp332)));
                                        var temp354 = ((int)((uint)(temp332)) <= (int)((uint)((uint)239U)));
                                        var temp355 = ((temp353) && (temp354));
                                        if (temp355)
                                        {
                                            var temp356 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp356));
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
                        var temp357 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp358 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp357)));
                        var temp359 = ((int)((uint)(temp357)) <= (int)((uint)((uint)191U)));
                        var temp360 = ((temp358) && (temp359));
                        if (temp360)
                        {
                            var temp361 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp362 = Fun0(((ushort)((s)._0)), ((ushort)(temp361)));
                            var temp363 = (((ushort)((ushort)48U)) <= ((ushort)(temp362)));
                            var temp364 = ((ushort)(((ushort)(temp362)) >> 6));
                            var temp365 = (((ushort)(temp364 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp366 = (((byte)(((byte)((ushort)(temp362))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp367 = (((temp363) && (temp365)) && (temp366));
                            var temp368 = (((ushort)((ushort)1632U)) <= ((ushort)(temp362)));
                            var temp369 = ((byte)(((ushort)(temp362)) >> 11));
                            var temp370 = (((byte)(temp369 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp371 = (((ushort)(((ushort)((ushort)(temp362))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp372 = (((temp368) && (temp370)) && (temp371));
                            var temp373 = (((ushort)((ushort)1776U)) <= ((ushort)(temp362)));
                            var temp374 = (((ushort)(((ushort)((ushort)(temp362))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp375 = (((temp373) && (temp370)) && (temp374));
                            var temp376 = (((ushort)((ushort)1984U)) <= ((ushort)(temp362)));
                            var temp377 = (((ushort)(((ushort)((ushort)(temp362))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp378 = (((temp376) && (temp370)) && (temp377));
                            var temp379 = (((ushort)((ushort)2406U)) <= ((ushort)(temp362)));
                            var temp380 = ((byte)(((ushort)(temp362)) >> 12));
                            var temp381 = (((byte)(temp380 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp382 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp383 = (((temp379) && (temp381)) && (temp382));
                            var temp384 = (((ushort)((ushort)2534U)) <= ((ushort)(temp362)));
                            var temp385 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp386 = (((temp384) && (temp381)) && (temp385));
                            var temp387 = (((ushort)((ushort)2662U)) <= ((ushort)(temp362)));
                            var temp388 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp389 = (((temp387) && (temp381)) && (temp388));
                            var temp390 = (((ushort)((ushort)2790U)) <= ((ushort)(temp362)));
                            var temp391 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp392 = (((temp390) && (temp381)) && (temp391));
                            var temp393 = (((ushort)((ushort)2918U)) <= ((ushort)(temp362)));
                            var temp394 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp395 = (((temp393) && (temp381)) && (temp394));
                            var temp396 = (((ushort)((ushort)3046U)) <= ((ushort)(temp362)));
                            var temp397 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp398 = (((temp396) && (temp381)) && (temp397));
                            var temp399 = (((ushort)((ushort)3174U)) <= ((ushort)(temp362)));
                            var temp400 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp401 = (((temp399) && (temp381)) && (temp400));
                            var temp402 = (((ushort)((ushort)3302U)) <= ((ushort)(temp362)));
                            var temp403 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp404 = (((temp402) && (temp381)) && (temp403));
                            var temp405 = (((ushort)((ushort)3430U)) <= ((ushort)(temp362)));
                            var temp406 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp407 = (((temp405) && (temp381)) && (temp406));
                            var temp408 = (((ushort)((ushort)3664U)) <= ((ushort)(temp362)));
                            var temp409 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp410 = (((temp408) && (temp381)) && (temp409));
                            var temp411 = (((ushort)((ushort)3792U)) <= ((ushort)(temp362)));
                            var temp412 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp413 = (((temp411) && (temp381)) && (temp412));
                            var temp414 = (((ushort)((ushort)3872U)) <= ((ushort)(temp362)));
                            var temp415 = (((ushort)(((ushort)((ushort)(temp362))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp416 = (((temp414) && (temp381)) && (temp415));
                            var temp417 = (((ushort)((ushort)4160U)) <= ((ushort)(temp362)));
                            var temp418 = ((byte)(((ushort)(temp362)) >> 13));
                            var temp419 = (((byte)(temp418 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp420 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp421 = (((temp417) && (temp419)) && (temp420));
                            var temp422 = (((ushort)((ushort)4240U)) <= ((ushort)(temp362)));
                            var temp423 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp424 = (((temp422) && (temp419)) && (temp423));
                            var temp425 = (((ushort)((ushort)6112U)) <= ((ushort)(temp362)));
                            var temp426 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp427 = (((temp425) && (temp419)) && (temp426));
                            var temp428 = (((ushort)((ushort)6160U)) <= ((ushort)(temp362)));
                            var temp429 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp430 = (((temp428) && (temp419)) && (temp429));
                            var temp431 = (((ushort)((ushort)6470U)) <= ((ushort)(temp362)));
                            var temp432 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp433 = (((temp431) && (temp419)) && (temp432));
                            var temp434 = (((ushort)((ushort)6608U)) <= ((ushort)(temp362)));
                            var temp435 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp436 = (((temp434) && (temp419)) && (temp435));
                            var temp437 = (((ushort)((ushort)6992U)) <= ((ushort)(temp362)));
                            var temp438 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp439 = (((temp437) && (temp419)) && (temp438));
                            var temp440 = (((ushort)((ushort)7088U)) <= ((ushort)(temp362)));
                            var temp441 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp442 = (((temp440) && (temp419)) && (temp441));
                            var temp443 = (((ushort)((ushort)7232U)) <= ((ushort)(temp362)));
                            var temp444 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp445 = (((temp443) && (temp419)) && (temp444));
                            var temp446 = (((ushort)((ushort)7248U)) <= ((ushort)(temp362)));
                            var temp447 = (((ushort)(((ushort)((ushort)(temp362))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp448 = (((temp446) && (temp419)) && (temp447));
                            var temp449 = (((ushort)((ushort)42528U)) <= ((ushort)(temp362)));
                            var temp450 = (((ushort)(temp362)) <= ((ushort)((ushort)42537U)));
                            var temp451 = ((temp449) && (temp450));
                            var temp452 = (((ushort)((ushort)43216U)) <= ((ushort)(temp362)));
                            var temp453 = (((ushort)(temp362)) <= ((ushort)((ushort)43225U)));
                            var temp454 = ((temp452) && (temp453));
                            var temp455 = (((ushort)((ushort)43264U)) <= ((ushort)(temp362)));
                            var temp456 = (((ushort)(temp362)) <= ((ushort)((ushort)43273U)));
                            var temp457 = ((temp455) && (temp456));
                            var temp458 = (((ushort)((ushort)43600U)) <= ((ushort)(temp362)));
                            var temp459 = (((ushort)(temp362)) <= ((ushort)((ushort)43609U)));
                            var temp460 = ((temp458) && (temp459));
                            var temp461 = (((ushort)((ushort)65296U)) <= ((ushort)(temp362)));
                            var temp462 = (((ushort)(temp362)) <= ((ushort)((ushort)65305U)));
                            var temp463 = ((temp461) && (temp462));
                            var temp464 = (((((((((((((((((((((((((((((((temp367) || (temp372)) || (temp375)) || (temp378)) || (temp383)) || (temp386)) || (temp389)) || (temp392)) || (temp395)) || (temp398)) || (temp401)) || (temp404)) || (temp407)) || (temp410)) || (temp413)) || (temp416)) || (temp421)) || (temp424)) || (temp427)) || (temp430)) || (temp433)) || (temp436)) || (temp439)) || (temp442)) || (temp445)) || (temp448)) || (temp451)) || (temp454)) || (temp457)) || (temp460)) || (temp463));
                            if (temp464)
                            {
                                var temp465 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp466 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp362));
                                var temp467 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp465))) + ((uint)(temp466))));
                                s._1 = ((uint)(temp467));
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
                        var temp468 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp469 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp468)));
                        var temp470 = ((int)((uint)(temp468)) <= (int)((uint)((uint)191U)));
                        var temp471 = ((temp469) && (temp470));
                        if (temp471)
                        {
                            var temp472 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp473 = Fun0(((ushort)((s)._0)), ((ushort)(temp472)));
                            s._0 = ((ushort)(temp473));
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
                        var temp474 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp475 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp474)));
                        var temp476 = ((int)((uint)(temp474)) <= (int)((uint)((uint)159U)));
                        var temp477 = ((temp475) && (temp476));
                        if (temp477)
                        {
                            var temp478 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp479 = Fun0(((ushort)((s)._0)), ((ushort)(temp478)));
                            s._0 = ((ushort)(temp479));
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
                        var temp480 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp481 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp480)));
                        var temp482 = ((int)((uint)(temp480)) <= (int)((uint)((uint)191U)));
                        var temp483 = ((temp481) && (temp482));
                        if (temp483)
                        {
                            var temp484 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp485 = Fun0(((ushort)((s)._0)), ((ushort)(temp484)));
                            s._0 = ((ushort)(temp485));
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
                        var temp486 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp487 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp486)));
                        var temp488 = ((int)((uint)(temp486)) <= (int)((uint)((uint)127U)));
                        var temp489 = ((temp487) && (temp488));
                        if (temp489)
                        {
                            var temp490 = (((byte)(i)) == ((byte)((byte)10U)));
                            if (temp490)
                            {
                                var temp491 = Fun1(((uint)((s)._1)), ((uint)((s)._2)));
                                s._2 = ((uint)(temp491));
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
                            var temp492 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp486)));
                            var temp493 = ((int)((uint)(temp486)) <= (int)((uint)((uint)223U)));
                            var temp494 = ((temp492) && (temp493));
                            if (temp494)
                            {
                                var temp495 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp495));
                                goto M56;
                            }
                            else
                            {
                                var temp496 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp496)
                                {
                                    var temp497 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp497));
                                    goto M57;
                                }
                                else
                                {
                                    var temp498 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp498)
                                    {
                                        var temp499 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp499));
                                        goto M58;
                                    }
                                    else
                                    {
                                        var temp500 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp486)));
                                        var temp501 = ((int)((uint)(temp486)) <= (int)((uint)((uint)239U)));
                                        var temp502 = ((temp500) && (temp501));
                                        if (temp502)
                                        {
                                            var temp503 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp503));
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
                        var temp504 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp505 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp504)));
                        var temp506 = ((int)((uint)(temp504)) <= (int)((uint)((uint)127U)));
                        var temp507 = ((temp505) && (temp506));
                        if (temp507)
                        {
                            var temp508 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp509 = ((byte)(((byte)(i)) >> 6));
                            var temp510 = (((byte)(temp509 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp511 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp512 = (((temp508) && (temp510)) && (temp511));
                            if (temp512)
                            {
                                goto M47;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp513 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp504)));
                            var temp514 = ((int)((uint)(temp504)) <= (int)((uint)((uint)223U)));
                            var temp515 = ((temp513) && (temp514));
                            if (temp515)
                            {
                                var temp516 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp516));
                                goto M48;
                            }
                            else
                            {
                                var temp517 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp517)
                                {
                                    var temp518 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp518));
                                    goto M49;
                                }
                                else
                                {
                                    var temp519 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp519)
                                    {
                                        var temp520 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp520));
                                        goto M50;
                                    }
                                    else
                                    {
                                        var temp521 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp504)));
                                        var temp522 = ((int)((uint)(temp504)) <= (int)((uint)((uint)239U)));
                                        var temp523 = ((temp521) && (temp522));
                                        if (temp523)
                                        {
                                            var temp524 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp524));
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
                        var temp525 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp526 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp525)));
                        var temp527 = ((int)((uint)(temp525)) <= (int)((uint)((uint)191U)));
                        var temp528 = ((temp526) && (temp527));
                        if (temp528)
                        {
                            var temp529 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp530 = Fun0(((ushort)((s)._0)), ((ushort)(temp529)));
                            var temp531 = (((ushort)(temp530)) == ((ushort)((ushort)44U)));
                            if (temp531)
                                throw new Exception();
                            else
                            {
                                var temp532 = (((ushort)(temp530)) == ((ushort)((ushort)46U)));
                                if (temp532)
                                    throw new Exception();
                                else
                                {
                                    var temp533 = (((ushort)((ushort)48U)) <= ((ushort)(temp530)));
                                    var temp534 = ((ushort)(((ushort)(temp530)) >> 6));
                                    var temp535 = (((ushort)(temp534 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                    var temp536 = (((byte)(((byte)((ushort)(temp530))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                    var temp537 = (((temp533) && (temp535)) && (temp536));
                                    var temp538 = (((ushort)((ushort)1632U)) <= ((ushort)(temp530)));
                                    var temp539 = ((byte)(((ushort)(temp530)) >> 11));
                                    var temp540 = (((byte)(temp539 & 31L)) == ((byte)((byte)0U & 31L)));
                                    var temp541 = (((ushort)(((ushort)((ushort)(temp530))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                    var temp542 = (((temp538) && (temp540)) && (temp541));
                                    var temp543 = (((ushort)((ushort)1776U)) <= ((ushort)(temp530)));
                                    var temp544 = (((ushort)(((ushort)((ushort)(temp530))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                    var temp545 = (((temp543) && (temp540)) && (temp544));
                                    var temp546 = (((ushort)((ushort)1984U)) <= ((ushort)(temp530)));
                                    var temp547 = (((ushort)(((ushort)((ushort)(temp530))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                    var temp548 = (((temp546) && (temp540)) && (temp547));
                                    var temp549 = (((ushort)((ushort)2406U)) <= ((ushort)(temp530)));
                                    var temp550 = ((byte)(((ushort)(temp530)) >> 12));
                                    var temp551 = (((byte)(temp550 & 15L)) == ((byte)((byte)0U & 15L)));
                                    var temp552 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                    var temp553 = (((temp549) && (temp551)) && (temp552));
                                    var temp554 = (((ushort)((ushort)2534U)) <= ((ushort)(temp530)));
                                    var temp555 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                    var temp556 = (((temp554) && (temp551)) && (temp555));
                                    var temp557 = (((ushort)((ushort)2662U)) <= ((ushort)(temp530)));
                                    var temp558 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                    var temp559 = (((temp557) && (temp551)) && (temp558));
                                    var temp560 = (((ushort)((ushort)2790U)) <= ((ushort)(temp530)));
                                    var temp561 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                    var temp562 = (((temp560) && (temp551)) && (temp561));
                                    var temp563 = (((ushort)((ushort)2918U)) <= ((ushort)(temp530)));
                                    var temp564 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                    var temp565 = (((temp563) && (temp551)) && (temp564));
                                    var temp566 = (((ushort)((ushort)3046U)) <= ((ushort)(temp530)));
                                    var temp567 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                    var temp568 = (((temp566) && (temp551)) && (temp567));
                                    var temp569 = (((ushort)((ushort)3174U)) <= ((ushort)(temp530)));
                                    var temp570 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                    var temp571 = (((temp569) && (temp551)) && (temp570));
                                    var temp572 = (((ushort)((ushort)3302U)) <= ((ushort)(temp530)));
                                    var temp573 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                    var temp574 = (((temp572) && (temp551)) && (temp573));
                                    var temp575 = (((ushort)((ushort)3430U)) <= ((ushort)(temp530)));
                                    var temp576 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                    var temp577 = (((temp575) && (temp551)) && (temp576));
                                    var temp578 = (((ushort)((ushort)3664U)) <= ((ushort)(temp530)));
                                    var temp579 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                    var temp580 = (((temp578) && (temp551)) && (temp579));
                                    var temp581 = (((ushort)((ushort)3792U)) <= ((ushort)(temp530)));
                                    var temp582 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                    var temp583 = (((temp581) && (temp551)) && (temp582));
                                    var temp584 = (((ushort)((ushort)3872U)) <= ((ushort)(temp530)));
                                    var temp585 = (((ushort)(((ushort)((ushort)(temp530))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                    var temp586 = (((temp584) && (temp551)) && (temp585));
                                    var temp587 = (((ushort)((ushort)4160U)) <= ((ushort)(temp530)));
                                    var temp588 = ((byte)(((ushort)(temp530)) >> 13));
                                    var temp589 = (((byte)(temp588 & 7L)) == ((byte)((byte)0U & 7L)));
                                    var temp590 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                    var temp591 = (((temp587) && (temp589)) && (temp590));
                                    var temp592 = (((ushort)((ushort)4240U)) <= ((ushort)(temp530)));
                                    var temp593 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                    var temp594 = (((temp592) && (temp589)) && (temp593));
                                    var temp595 = (((ushort)((ushort)6112U)) <= ((ushort)(temp530)));
                                    var temp596 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                    var temp597 = (((temp595) && (temp589)) && (temp596));
                                    var temp598 = (((ushort)((ushort)6160U)) <= ((ushort)(temp530)));
                                    var temp599 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                    var temp600 = (((temp598) && (temp589)) && (temp599));
                                    var temp601 = (((ushort)((ushort)6470U)) <= ((ushort)(temp530)));
                                    var temp602 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                    var temp603 = (((temp601) && (temp589)) && (temp602));
                                    var temp604 = (((ushort)((ushort)6608U)) <= ((ushort)(temp530)));
                                    var temp605 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                    var temp606 = (((temp604) && (temp589)) && (temp605));
                                    var temp607 = (((ushort)((ushort)6992U)) <= ((ushort)(temp530)));
                                    var temp608 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                    var temp609 = (((temp607) && (temp589)) && (temp608));
                                    var temp610 = (((ushort)((ushort)7088U)) <= ((ushort)(temp530)));
                                    var temp611 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                    var temp612 = (((temp610) && (temp589)) && (temp611));
                                    var temp613 = (((ushort)((ushort)7232U)) <= ((ushort)(temp530)));
                                    var temp614 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                    var temp615 = (((temp613) && (temp589)) && (temp614));
                                    var temp616 = (((ushort)((ushort)7248U)) <= ((ushort)(temp530)));
                                    var temp617 = (((ushort)(((ushort)((ushort)(temp530))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                    var temp618 = (((temp616) && (temp589)) && (temp617));
                                    var temp619 = (((ushort)((ushort)42528U)) <= ((ushort)(temp530)));
                                    var temp620 = (((ushort)(temp530)) <= ((ushort)((ushort)42537U)));
                                    var temp621 = ((temp619) && (temp620));
                                    var temp622 = (((ushort)((ushort)43216U)) <= ((ushort)(temp530)));
                                    var temp623 = (((ushort)(temp530)) <= ((ushort)((ushort)43225U)));
                                    var temp624 = ((temp622) && (temp623));
                                    var temp625 = (((ushort)((ushort)43264U)) <= ((ushort)(temp530)));
                                    var temp626 = (((ushort)(temp530)) <= ((ushort)((ushort)43273U)));
                                    var temp627 = ((temp625) && (temp626));
                                    var temp628 = (((ushort)((ushort)43600U)) <= ((ushort)(temp530)));
                                    var temp629 = (((ushort)(temp530)) <= ((ushort)((ushort)43609U)));
                                    var temp630 = ((temp628) && (temp629));
                                    var temp631 = (((ushort)((ushort)65296U)) <= ((ushort)(temp530)));
                                    var temp632 = (((ushort)(temp530)) <= ((ushort)((ushort)65305U)));
                                    var temp633 = ((temp631) && (temp632));
                                    var temp634 = (((((((((((((((((((((((((((((((temp537) || (temp542)) || (temp545)) || (temp548)) || (temp553)) || (temp556)) || (temp559)) || (temp562)) || (temp565)) || (temp568)) || (temp571)) || (temp574)) || (temp577)) || (temp580)) || (temp583)) || (temp586)) || (temp591)) || (temp594)) || (temp597)) || (temp600)) || (temp603)) || (temp606)) || (temp609)) || (temp612)) || (temp615)) || (temp618)) || (temp621)) || (temp624)) || (temp627)) || (temp630)) || (temp633));
                                    if (temp634)
                                    {
                                        var temp635 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                        var temp636 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp530));
                                        var temp637 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp635))) + ((uint)(temp636))));
                                        s._1 = ((uint)(temp637));
                                        s._0 = ((ushort)((ushort)0U));
                                        goto M36;
                                    }
                                    else
                                        throw new Exception();
                                }
                            }
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
                        var temp638 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp639 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp638)));
                        var temp640 = ((int)((uint)(temp638)) <= (int)((uint)((uint)191U)));
                        var temp641 = ((temp639) && (temp640));
                        if (temp641)
                        {
                            var temp642 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp643 = Fun0(((ushort)((s)._0)), ((ushort)(temp642)));
                            s._0 = ((ushort)(temp643));
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
                        var temp644 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp645 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp644)));
                        var temp646 = ((int)((uint)(temp644)) <= (int)((uint)((uint)159U)));
                        var temp647 = ((temp645) && (temp646));
                        if (temp647)
                        {
                            var temp648 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp649 = Fun0(((ushort)((s)._0)), ((ushort)(temp648)));
                            s._0 = ((ushort)(temp649));
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
                        var temp650 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp651 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp650)));
                        var temp652 = ((int)((uint)(temp650)) <= (int)((uint)((uint)191U)));
                        var temp653 = ((temp651) && (temp652));
                        if (temp653)
                        {
                            var temp654 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp655 = Fun0(((ushort)((s)._0)), ((ushort)(temp654)));
                            s._0 = ((ushort)(temp655));
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
                        var temp656 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp657 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp656)));
                        var temp658 = ((int)((uint)(temp656)) <= (int)((uint)((uint)127U)));
                        var temp659 = ((temp657) && (temp658));
                        if (temp659)
                        {
                            var temp660 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp660)
                            {
                                goto M41;
                            }
                            else
                            {
                                var temp661 = (((byte)((byte)48U)) <= ((byte)(i)));
                                var temp662 = ((byte)(((byte)(i)) >> 6));
                                var temp663 = (((byte)(temp662 & 3L)) == ((byte)((byte)0U & 3L)));
                                var temp664 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp665 = (((temp661) && (temp663)) && (temp664));
                                if (temp665)
                                {
                                    goto M47;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                        else
                        {
                            var temp666 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp656)));
                            var temp667 = ((int)((uint)(temp656)) <= (int)((uint)((uint)223U)));
                            var temp668 = ((temp666) && (temp667));
                            if (temp668)
                            {
                                var temp669 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp669));
                                goto M52;
                            }
                            else
                            {
                                var temp670 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp670)
                                {
                                    var temp671 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp671));
                                    goto M53;
                                }
                                else
                                {
                                    var temp672 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp672)
                                    {
                                        var temp673 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp673));
                                        goto M54;
                                    }
                                    else
                                    {
                                        var temp674 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp656)));
                                        var temp675 = ((int)((uint)(temp656)) <= (int)((uint)((uint)239U)));
                                        var temp676 = ((temp674) && (temp675));
                                        if (temp676)
                                        {
                                            var temp677 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp677));
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
                        var temp678 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp679 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp678)));
                        var temp680 = ((int)((uint)(temp678)) <= (int)((uint)((uint)191U)));
                        var temp681 = ((temp679) && (temp680));
                        if (temp681)
                        {
                            var temp682 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp683 = Fun0(((ushort)((s)._0)), ((ushort)(temp682)));
                            var temp684 = (((ushort)((ushort)48U)) <= ((ushort)(temp683)));
                            var temp685 = ((ushort)(((ushort)(temp683)) >> 6));
                            var temp686 = (((ushort)(temp685 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp687 = (((byte)(((byte)((ushort)(temp683))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp688 = (((temp684) && (temp686)) && (temp687));
                            var temp689 = (((ushort)((ushort)1632U)) <= ((ushort)(temp683)));
                            var temp690 = ((byte)(((ushort)(temp683)) >> 11));
                            var temp691 = (((byte)(temp690 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp692 = (((ushort)(((ushort)((ushort)(temp683))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp693 = (((temp689) && (temp691)) && (temp692));
                            var temp694 = (((ushort)((ushort)1776U)) <= ((ushort)(temp683)));
                            var temp695 = (((ushort)(((ushort)((ushort)(temp683))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp696 = (((temp694) && (temp691)) && (temp695));
                            var temp697 = (((ushort)((ushort)1984U)) <= ((ushort)(temp683)));
                            var temp698 = (((ushort)(((ushort)((ushort)(temp683))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp699 = (((temp697) && (temp691)) && (temp698));
                            var temp700 = (((ushort)((ushort)2406U)) <= ((ushort)(temp683)));
                            var temp701 = ((byte)(((ushort)(temp683)) >> 12));
                            var temp702 = (((byte)(temp701 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp703 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp704 = (((temp700) && (temp702)) && (temp703));
                            var temp705 = (((ushort)((ushort)2534U)) <= ((ushort)(temp683)));
                            var temp706 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp707 = (((temp705) && (temp702)) && (temp706));
                            var temp708 = (((ushort)((ushort)2662U)) <= ((ushort)(temp683)));
                            var temp709 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp710 = (((temp708) && (temp702)) && (temp709));
                            var temp711 = (((ushort)((ushort)2790U)) <= ((ushort)(temp683)));
                            var temp712 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp713 = (((temp711) && (temp702)) && (temp712));
                            var temp714 = (((ushort)((ushort)2918U)) <= ((ushort)(temp683)));
                            var temp715 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp716 = (((temp714) && (temp702)) && (temp715));
                            var temp717 = (((ushort)((ushort)3046U)) <= ((ushort)(temp683)));
                            var temp718 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp719 = (((temp717) && (temp702)) && (temp718));
                            var temp720 = (((ushort)((ushort)3174U)) <= ((ushort)(temp683)));
                            var temp721 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp722 = (((temp720) && (temp702)) && (temp721));
                            var temp723 = (((ushort)((ushort)3302U)) <= ((ushort)(temp683)));
                            var temp724 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp725 = (((temp723) && (temp702)) && (temp724));
                            var temp726 = (((ushort)((ushort)3430U)) <= ((ushort)(temp683)));
                            var temp727 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp728 = (((temp726) && (temp702)) && (temp727));
                            var temp729 = (((ushort)((ushort)3664U)) <= ((ushort)(temp683)));
                            var temp730 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp731 = (((temp729) && (temp702)) && (temp730));
                            var temp732 = (((ushort)((ushort)3792U)) <= ((ushort)(temp683)));
                            var temp733 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp734 = (((temp732) && (temp702)) && (temp733));
                            var temp735 = (((ushort)((ushort)3872U)) <= ((ushort)(temp683)));
                            var temp736 = (((ushort)(((ushort)((ushort)(temp683))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp737 = (((temp735) && (temp702)) && (temp736));
                            var temp738 = (((ushort)((ushort)4160U)) <= ((ushort)(temp683)));
                            var temp739 = ((byte)(((ushort)(temp683)) >> 13));
                            var temp740 = (((byte)(temp739 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp741 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp742 = (((temp738) && (temp740)) && (temp741));
                            var temp743 = (((ushort)((ushort)4240U)) <= ((ushort)(temp683)));
                            var temp744 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp745 = (((temp743) && (temp740)) && (temp744));
                            var temp746 = (((ushort)((ushort)6112U)) <= ((ushort)(temp683)));
                            var temp747 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp748 = (((temp746) && (temp740)) && (temp747));
                            var temp749 = (((ushort)((ushort)6160U)) <= ((ushort)(temp683)));
                            var temp750 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp751 = (((temp749) && (temp740)) && (temp750));
                            var temp752 = (((ushort)((ushort)6470U)) <= ((ushort)(temp683)));
                            var temp753 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp754 = (((temp752) && (temp740)) && (temp753));
                            var temp755 = (((ushort)((ushort)6608U)) <= ((ushort)(temp683)));
                            var temp756 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp757 = (((temp755) && (temp740)) && (temp756));
                            var temp758 = (((ushort)((ushort)6992U)) <= ((ushort)(temp683)));
                            var temp759 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp760 = (((temp758) && (temp740)) && (temp759));
                            var temp761 = (((ushort)((ushort)7088U)) <= ((ushort)(temp683)));
                            var temp762 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp763 = (((temp761) && (temp740)) && (temp762));
                            var temp764 = (((ushort)((ushort)7232U)) <= ((ushort)(temp683)));
                            var temp765 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp766 = (((temp764) && (temp740)) && (temp765));
                            var temp767 = (((ushort)((ushort)7248U)) <= ((ushort)(temp683)));
                            var temp768 = (((ushort)(((ushort)((ushort)(temp683))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp769 = (((temp767) && (temp740)) && (temp768));
                            var temp770 = (((ushort)((ushort)42528U)) <= ((ushort)(temp683)));
                            var temp771 = (((ushort)(temp683)) <= ((ushort)((ushort)42537U)));
                            var temp772 = ((temp770) && (temp771));
                            var temp773 = (((ushort)((ushort)43216U)) <= ((ushort)(temp683)));
                            var temp774 = (((ushort)(temp683)) <= ((ushort)((ushort)43225U)));
                            var temp775 = ((temp773) && (temp774));
                            var temp776 = (((ushort)((ushort)43264U)) <= ((ushort)(temp683)));
                            var temp777 = (((ushort)(temp683)) <= ((ushort)((ushort)43273U)));
                            var temp778 = ((temp776) && (temp777));
                            var temp779 = (((ushort)((ushort)43600U)) <= ((ushort)(temp683)));
                            var temp780 = (((ushort)(temp683)) <= ((ushort)((ushort)43609U)));
                            var temp781 = ((temp779) && (temp780));
                            var temp782 = (((ushort)((ushort)65296U)) <= ((ushort)(temp683)));
                            var temp783 = (((ushort)(temp683)) <= ((ushort)((ushort)65305U)));
                            var temp784 = ((temp782) && (temp783));
                            var temp785 = (((((((((((((((((((((((((((((((temp688) || (temp693)) || (temp696)) || (temp699)) || (temp704)) || (temp707)) || (temp710)) || (temp713)) || (temp716)) || (temp719)) || (temp722)) || (temp725)) || (temp728)) || (temp731)) || (temp734)) || (temp737)) || (temp742)) || (temp745)) || (temp748)) || (temp751)) || (temp754)) || (temp757)) || (temp760)) || (temp763)) || (temp766)) || (temp769)) || (temp772)) || (temp775)) || (temp778)) || (temp781)) || (temp784));
                            if (temp785)
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
                        var temp786 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp787 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp786)));
                        var temp788 = ((int)((uint)(temp786)) <= (int)((uint)((uint)191U)));
                        var temp789 = ((temp787) && (temp788));
                        if (temp789)
                        {
                            var temp790 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp791 = Fun0(((ushort)((s)._0)), ((ushort)(temp790)));
                            s._0 = ((ushort)(temp791));
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
                        var temp792 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp793 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp792)));
                        var temp794 = ((int)((uint)(temp792)) <= (int)((uint)((uint)159U)));
                        var temp795 = ((temp793) && (temp794));
                        if (temp795)
                        {
                            var temp796 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp797 = Fun0(((ushort)((s)._0)), ((ushort)(temp796)));
                            s._0 = ((ushort)(temp797));
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
                        var temp798 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp799 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp798)));
                        var temp800 = ((int)((uint)(temp798)) <= (int)((uint)((uint)191U)));
                        var temp801 = ((temp799) && (temp800));
                        if (temp801)
                        {
                            var temp802 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp803 = Fun0(((ushort)((s)._0)), ((ushort)(temp802)));
                            s._0 = ((ushort)(temp803));
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
                        var temp804 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp805 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp804)));
                        var temp806 = ((int)((uint)(temp804)) <= (int)((uint)((uint)191U)));
                        var temp807 = ((temp805) && (temp806));
                        if (temp807)
                        {
                            var temp808 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp809 = Fun0(((ushort)((s)._0)), ((ushort)(temp808)));
                            var temp810 = (((ushort)(temp809)) == ((ushort)((ushort)44U)));
                            if (temp810)
                                throw new Exception();
                            else
                            {
                                var temp811 = (((ushort)((ushort)48U)) <= ((ushort)(temp809)));
                                var temp812 = ((ushort)(((ushort)(temp809)) >> 6));
                                var temp813 = (((ushort)(temp812 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                var temp814 = (((byte)(((byte)((ushort)(temp809))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp815 = (((temp811) && (temp813)) && (temp814));
                                var temp816 = (((ushort)((ushort)1632U)) <= ((ushort)(temp809)));
                                var temp817 = ((byte)(((ushort)(temp809)) >> 11));
                                var temp818 = (((byte)(temp817 & 31L)) == ((byte)((byte)0U & 31L)));
                                var temp819 = (((ushort)(((ushort)((ushort)(temp809))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                var temp820 = (((temp816) && (temp818)) && (temp819));
                                var temp821 = (((ushort)((ushort)1776U)) <= ((ushort)(temp809)));
                                var temp822 = (((ushort)(((ushort)((ushort)(temp809))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                var temp823 = (((temp821) && (temp818)) && (temp822));
                                var temp824 = (((ushort)((ushort)1984U)) <= ((ushort)(temp809)));
                                var temp825 = (((ushort)(((ushort)((ushort)(temp809))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                var temp826 = (((temp824) && (temp818)) && (temp825));
                                var temp827 = (((ushort)((ushort)2406U)) <= ((ushort)(temp809)));
                                var temp828 = ((byte)(((ushort)(temp809)) >> 12));
                                var temp829 = (((byte)(temp828 & 15L)) == ((byte)((byte)0U & 15L)));
                                var temp830 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                var temp831 = (((temp827) && (temp829)) && (temp830));
                                var temp832 = (((ushort)((ushort)2534U)) <= ((ushort)(temp809)));
                                var temp833 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                var temp834 = (((temp832) && (temp829)) && (temp833));
                                var temp835 = (((ushort)((ushort)2662U)) <= ((ushort)(temp809)));
                                var temp836 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                var temp837 = (((temp835) && (temp829)) && (temp836));
                                var temp838 = (((ushort)((ushort)2790U)) <= ((ushort)(temp809)));
                                var temp839 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                var temp840 = (((temp838) && (temp829)) && (temp839));
                                var temp841 = (((ushort)((ushort)2918U)) <= ((ushort)(temp809)));
                                var temp842 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                var temp843 = (((temp841) && (temp829)) && (temp842));
                                var temp844 = (((ushort)((ushort)3046U)) <= ((ushort)(temp809)));
                                var temp845 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                var temp846 = (((temp844) && (temp829)) && (temp845));
                                var temp847 = (((ushort)((ushort)3174U)) <= ((ushort)(temp809)));
                                var temp848 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                var temp849 = (((temp847) && (temp829)) && (temp848));
                                var temp850 = (((ushort)((ushort)3302U)) <= ((ushort)(temp809)));
                                var temp851 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                var temp852 = (((temp850) && (temp829)) && (temp851));
                                var temp853 = (((ushort)((ushort)3430U)) <= ((ushort)(temp809)));
                                var temp854 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                var temp855 = (((temp853) && (temp829)) && (temp854));
                                var temp856 = (((ushort)((ushort)3664U)) <= ((ushort)(temp809)));
                                var temp857 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                var temp858 = (((temp856) && (temp829)) && (temp857));
                                var temp859 = (((ushort)((ushort)3792U)) <= ((ushort)(temp809)));
                                var temp860 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                var temp861 = (((temp859) && (temp829)) && (temp860));
                                var temp862 = (((ushort)((ushort)3872U)) <= ((ushort)(temp809)));
                                var temp863 = (((ushort)(((ushort)((ushort)(temp809))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                var temp864 = (((temp862) && (temp829)) && (temp863));
                                var temp865 = (((ushort)((ushort)4160U)) <= ((ushort)(temp809)));
                                var temp866 = ((byte)(((ushort)(temp809)) >> 13));
                                var temp867 = (((byte)(temp866 & 7L)) == ((byte)((byte)0U & 7L)));
                                var temp868 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                var temp869 = (((temp865) && (temp867)) && (temp868));
                                var temp870 = (((ushort)((ushort)4240U)) <= ((ushort)(temp809)));
                                var temp871 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                var temp872 = (((temp870) && (temp867)) && (temp871));
                                var temp873 = (((ushort)((ushort)6112U)) <= ((ushort)(temp809)));
                                var temp874 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                var temp875 = (((temp873) && (temp867)) && (temp874));
                                var temp876 = (((ushort)((ushort)6160U)) <= ((ushort)(temp809)));
                                var temp877 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                var temp878 = (((temp876) && (temp867)) && (temp877));
                                var temp879 = (((ushort)((ushort)6470U)) <= ((ushort)(temp809)));
                                var temp880 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                var temp881 = (((temp879) && (temp867)) && (temp880));
                                var temp882 = (((ushort)((ushort)6608U)) <= ((ushort)(temp809)));
                                var temp883 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                var temp884 = (((temp882) && (temp867)) && (temp883));
                                var temp885 = (((ushort)((ushort)6992U)) <= ((ushort)(temp809)));
                                var temp886 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                var temp887 = (((temp885) && (temp867)) && (temp886));
                                var temp888 = (((ushort)((ushort)7088U)) <= ((ushort)(temp809)));
                                var temp889 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                var temp890 = (((temp888) && (temp867)) && (temp889));
                                var temp891 = (((ushort)((ushort)7232U)) <= ((ushort)(temp809)));
                                var temp892 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                var temp893 = (((temp891) && (temp867)) && (temp892));
                                var temp894 = (((ushort)((ushort)7248U)) <= ((ushort)(temp809)));
                                var temp895 = (((ushort)(((ushort)((ushort)(temp809))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                var temp896 = (((temp894) && (temp867)) && (temp895));
                                var temp897 = (((ushort)((ushort)42528U)) <= ((ushort)(temp809)));
                                var temp898 = (((ushort)(temp809)) <= ((ushort)((ushort)42537U)));
                                var temp899 = ((temp897) && (temp898));
                                var temp900 = (((ushort)((ushort)43216U)) <= ((ushort)(temp809)));
                                var temp901 = (((ushort)(temp809)) <= ((ushort)((ushort)43225U)));
                                var temp902 = ((temp900) && (temp901));
                                var temp903 = (((ushort)((ushort)43264U)) <= ((ushort)(temp809)));
                                var temp904 = (((ushort)(temp809)) <= ((ushort)((ushort)43273U)));
                                var temp905 = ((temp903) && (temp904));
                                var temp906 = (((ushort)((ushort)43600U)) <= ((ushort)(temp809)));
                                var temp907 = (((ushort)(temp809)) <= ((ushort)((ushort)43609U)));
                                var temp908 = ((temp906) && (temp907));
                                var temp909 = (((ushort)((ushort)65296U)) <= ((ushort)(temp809)));
                                var temp910 = (((ushort)(temp809)) <= ((ushort)((ushort)65305U)));
                                var temp911 = ((temp909) && (temp910));
                                var temp912 = (((((((((((((((((((((((((((((((temp815) || (temp820)) || (temp823)) || (temp826)) || (temp831)) || (temp834)) || (temp837)) || (temp840)) || (temp843)) || (temp846)) || (temp849)) || (temp852)) || (temp855)) || (temp858)) || (temp861)) || (temp864)) || (temp869)) || (temp872)) || (temp875)) || (temp878)) || (temp881)) || (temp884)) || (temp887)) || (temp890)) || (temp893)) || (temp896)) || (temp899)) || (temp902)) || (temp905)) || (temp908)) || (temp911));
                                if (temp912)
                                {
                                    s._0 = ((ushort)((ushort)0U));
                                    goto M47;
                                }
                                else
                                    throw new Exception();
                            }
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
                        var temp913 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp914 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp913)));
                        var temp915 = ((int)((uint)(temp913)) <= (int)((uint)((uint)191U)));
                        var temp916 = ((temp914) && (temp915));
                        if (temp916)
                        {
                            var temp917 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp918 = Fun0(((ushort)((s)._0)), ((ushort)(temp917)));
                            s._0 = ((ushort)(temp918));
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
                        var temp919 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp920 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp919)));
                        var temp921 = ((int)((uint)(temp919)) <= (int)((uint)((uint)159U)));
                        var temp922 = ((temp920) && (temp921));
                        if (temp922)
                        {
                            var temp923 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp924 = Fun0(((ushort)((s)._0)), ((ushort)(temp923)));
                            s._0 = ((ushort)(temp924));
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
                        var temp925 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp926 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp925)));
                        var temp927 = ((int)((uint)(temp925)) <= (int)((uint)((uint)191U)));
                        var temp928 = ((temp926) && (temp927));
                        if (temp928)
                        {
                            var temp929 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp930 = Fun0(((ushort)((s)._0)), ((ushort)(temp929)));
                            s._0 = ((ushort)(temp930));
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
                        var temp931 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp932 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp931)));
                        var temp933 = ((int)((uint)(temp931)) <= (int)((uint)((uint)191U)));
                        var temp934 = ((temp932) && (temp933));
                        if (temp934)
                        {
                            var temp935 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp936 = Fun0(((ushort)((s)._0)), ((ushort)(temp935)));
                            var temp937 = (((ushort)(temp936)) == ((ushort)((ushort)10U)));
                            if (temp937)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M41;
                            }
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
                        var temp938 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp939 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp938)));
                        var temp940 = ((int)((uint)(temp938)) <= (int)((uint)((uint)191U)));
                        var temp941 = ((temp939) && (temp940));
                        if (temp941)
                        {
                            var temp942 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp943 = Fun0(((ushort)((s)._0)), ((ushort)(temp942)));
                            s._0 = ((ushort)(temp943));
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
                        var temp944 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp945 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp944)));
                        var temp946 = ((int)((uint)(temp944)) <= (int)((uint)((uint)159U)));
                        var temp947 = ((temp945) && (temp946));
                        if (temp947)
                        {
                            var temp948 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp949 = Fun0(((ushort)((s)._0)), ((ushort)(temp948)));
                            s._0 = ((ushort)(temp949));
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
                        var temp950 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp951 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp950)));
                        var temp952 = ((int)((uint)(temp950)) <= (int)((uint)((uint)191U)));
                        var temp953 = ((temp951) && (temp952));
                        if (temp953)
                        {
                            var temp954 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp955 = Fun0(((ushort)((s)._0)), ((ushort)(temp954)));
                            s._0 = ((ushort)(temp955));
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

                    var temp47 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp47))));
                    var temp48 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp48))));
                    var temp49 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp49))));
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

                    var temp56 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp56))));
                    var temp57 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp57))));
                    var temp58 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp58))));
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

                    var temp65 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)24U))));
                    oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp65))));
                    var temp66 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)16U))));
                    oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp66))));
                    var temp67 = ((uint)(((int)((uint)((s)._2))) >> (int)((uint)((uint)8U))));
                    oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp67))));
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