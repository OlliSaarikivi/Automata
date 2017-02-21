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

        struct DTStruct34
        {
            public UInt16 _0;
            public UInt32 _1;
            public UInt32 _2;
            public DTStruct34(UInt16 v0, UInt32 v1, UInt32 v2)
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
                DTStruct34 s = new DTStruct34(((ushort)((ushort)0U)), ((uint)((uint)0U)), ((uint)((uint)4294967295U)));
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
                            var temp204 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp205 = ((byte)(((byte)(i)) >> 6));
                            var temp206 = (((byte)(temp205 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp207 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp208 = (((temp204) && (temp206)) && (temp207));
                            if (temp208)
                            {
                                var temp209 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp210 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp209))) + ((uint)(temp200))));
                                s._1 = ((uint)(temp210));
                                goto M26;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp211 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp200)));
                            var temp212 = ((int)((uint)(temp200)) <= (int)((uint)((uint)223U)));
                            var temp213 = ((temp211) && (temp212));
                            if (temp213)
                            {
                                var temp214 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp214));
                                goto M27;
                            }
                            else
                            {
                                var temp215 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp215)
                                {
                                    var temp216 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp216));
                                    goto M28;
                                }
                                else
                                {
                                    var temp217 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp217)
                                    {
                                        var temp218 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp218));
                                        goto M29;
                                    }
                                    else
                                    {
                                        var temp219 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp200)));
                                        var temp220 = ((int)((uint)(temp200)) <= (int)((uint)((uint)239U)));
                                        var temp221 = ((temp219) && (temp220));
                                        if (temp221)
                                        {
                                            var temp222 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp222));
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
                        var temp223 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp224 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp223)));
                        var temp225 = ((int)((uint)(temp223)) <= (int)((uint)((uint)191U)));
                        var temp226 = ((temp224) && (temp225));
                        if (temp226)
                        {
                            var temp227 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp228 = Fun0(((ushort)((s)._0)), ((ushort)(temp227)));
                            var temp229 = (((ushort)(temp228)) == ((ushort)((ushort)44U)));
                            if (temp229)
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
                        var temp230 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp231 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp230)));
                        var temp232 = ((int)((uint)(temp230)) <= (int)((uint)((uint)191U)));
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

                M24:
                {
                    if (!ie.MoveNext())
                        goto F24;
                    i = ie.Current;
                    {
                        var temp236 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp237 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp236)));
                        var temp238 = ((int)((uint)(temp236)) <= (int)((uint)((uint)159U)));
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

                M25:
                {
                    if (!ie.MoveNext())
                        goto F25;
                    i = ie.Current;
                    {
                        var temp242 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp243 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp242)));
                        var temp244 = ((int)((uint)(temp242)) <= (int)((uint)((uint)191U)));
                        var temp245 = ((temp243) && (temp244));
                        if (temp245)
                        {
                            var temp246 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp247 = Fun0(((ushort)((s)._0)), ((ushort)(temp246)));
                            s._0 = ((ushort)(temp247));
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
                        var temp248 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp249 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp248)));
                        var temp250 = ((int)((uint)(temp248)) <= (int)((uint)((uint)127U)));
                        var temp251 = ((temp249) && (temp250));
                        if (temp251)
                        {
                            var temp252 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp252)
                            {
                                goto M31;
                            }
                            else
                            {
                                var temp253 = (((byte)((byte)48U)) <= ((byte)(i)));
                                var temp254 = ((byte)(((byte)(i)) >> 6));
                                var temp255 = (((byte)(temp254 & 3L)) == ((byte)((byte)0U & 3L)));
                                var temp256 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp257 = (((temp253) && (temp255)) && (temp256));
                                if (temp257)
                                {
                                    var temp258 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                    var temp259 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp258))) + ((uint)(temp248))));
                                    s._1 = ((uint)(temp259));
                                    goto M26;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                        else
                        {
                            var temp260 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp248)));
                            var temp261 = ((int)((uint)(temp248)) <= (int)((uint)((uint)223U)));
                            var temp262 = ((temp260) && (temp261));
                            if (temp262)
                            {
                                var temp263 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp263));
                                goto M32;
                            }
                            else
                            {
                                var temp264 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp264)
                                {
                                    var temp265 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp265));
                                    goto M33;
                                }
                                else
                                {
                                    var temp266 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp266)
                                    {
                                        var temp267 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp267));
                                        goto M34;
                                    }
                                    else
                                    {
                                        var temp268 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp248)));
                                        var temp269 = ((int)((uint)(temp248)) <= (int)((uint)((uint)239U)));
                                        var temp270 = ((temp268) && (temp269));
                                        if (temp270)
                                        {
                                            var temp271 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp271));
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
                        var temp272 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp273 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp272)));
                        var temp274 = ((int)((uint)(temp272)) <= (int)((uint)((uint)191U)));
                        var temp275 = ((temp273) && (temp274));
                        if (temp275)
                        {
                            var temp276 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp277 = Fun0(((ushort)((s)._0)), ((ushort)(temp276)));
                            var temp278 = (((ushort)((ushort)48U)) <= ((ushort)(temp277)));
                            var temp279 = ((ushort)(((ushort)(temp277)) >> 6));
                            var temp280 = (((ushort)(temp279 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp281 = (((byte)(((byte)((ushort)(temp277))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp282 = (((temp278) && (temp280)) && (temp281));
                            var temp283 = (((ushort)((ushort)1632U)) <= ((ushort)(temp277)));
                            var temp284 = ((byte)(((ushort)(temp277)) >> 11));
                            var temp285 = (((byte)(temp284 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp286 = (((ushort)(((ushort)((ushort)(temp277))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp287 = (((temp283) && (temp285)) && (temp286));
                            var temp288 = (((ushort)((ushort)1776U)) <= ((ushort)(temp277)));
                            var temp289 = (((ushort)(((ushort)((ushort)(temp277))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp290 = (((temp288) && (temp285)) && (temp289));
                            var temp291 = (((ushort)((ushort)1984U)) <= ((ushort)(temp277)));
                            var temp292 = (((ushort)(((ushort)((ushort)(temp277))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp293 = (((temp291) && (temp285)) && (temp292));
                            var temp294 = (((ushort)((ushort)2406U)) <= ((ushort)(temp277)));
                            var temp295 = ((byte)(((ushort)(temp277)) >> 12));
                            var temp296 = (((byte)(temp295 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp297 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp298 = (((temp294) && (temp296)) && (temp297));
                            var temp299 = (((ushort)((ushort)2534U)) <= ((ushort)(temp277)));
                            var temp300 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp301 = (((temp299) && (temp296)) && (temp300));
                            var temp302 = (((ushort)((ushort)2662U)) <= ((ushort)(temp277)));
                            var temp303 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp304 = (((temp302) && (temp296)) && (temp303));
                            var temp305 = (((ushort)((ushort)2790U)) <= ((ushort)(temp277)));
                            var temp306 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp307 = (((temp305) && (temp296)) && (temp306));
                            var temp308 = (((ushort)((ushort)2918U)) <= ((ushort)(temp277)));
                            var temp309 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp310 = (((temp308) && (temp296)) && (temp309));
                            var temp311 = (((ushort)((ushort)3046U)) <= ((ushort)(temp277)));
                            var temp312 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp313 = (((temp311) && (temp296)) && (temp312));
                            var temp314 = (((ushort)((ushort)3174U)) <= ((ushort)(temp277)));
                            var temp315 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp316 = (((temp314) && (temp296)) && (temp315));
                            var temp317 = (((ushort)((ushort)3302U)) <= ((ushort)(temp277)));
                            var temp318 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp319 = (((temp317) && (temp296)) && (temp318));
                            var temp320 = (((ushort)((ushort)3430U)) <= ((ushort)(temp277)));
                            var temp321 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp322 = (((temp320) && (temp296)) && (temp321));
                            var temp323 = (((ushort)((ushort)3664U)) <= ((ushort)(temp277)));
                            var temp324 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp325 = (((temp323) && (temp296)) && (temp324));
                            var temp326 = (((ushort)((ushort)3792U)) <= ((ushort)(temp277)));
                            var temp327 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp328 = (((temp326) && (temp296)) && (temp327));
                            var temp329 = (((ushort)((ushort)3872U)) <= ((ushort)(temp277)));
                            var temp330 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp331 = (((temp329) && (temp296)) && (temp330));
                            var temp332 = (((ushort)((ushort)4160U)) <= ((ushort)(temp277)));
                            var temp333 = ((byte)(((ushort)(temp277)) >> 13));
                            var temp334 = (((byte)(temp333 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp335 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp336 = (((temp332) && (temp334)) && (temp335));
                            var temp337 = (((ushort)((ushort)4240U)) <= ((ushort)(temp277)));
                            var temp338 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp339 = (((temp337) && (temp334)) && (temp338));
                            var temp340 = (((ushort)((ushort)6112U)) <= ((ushort)(temp277)));
                            var temp341 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp342 = (((temp340) && (temp334)) && (temp341));
                            var temp343 = (((ushort)((ushort)6160U)) <= ((ushort)(temp277)));
                            var temp344 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp345 = (((temp343) && (temp334)) && (temp344));
                            var temp346 = (((ushort)((ushort)6470U)) <= ((ushort)(temp277)));
                            var temp347 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp348 = (((temp346) && (temp334)) && (temp347));
                            var temp349 = (((ushort)((ushort)6608U)) <= ((ushort)(temp277)));
                            var temp350 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp351 = (((temp349) && (temp334)) && (temp350));
                            var temp352 = (((ushort)((ushort)6992U)) <= ((ushort)(temp277)));
                            var temp353 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp354 = (((temp352) && (temp334)) && (temp353));
                            var temp355 = (((ushort)((ushort)7088U)) <= ((ushort)(temp277)));
                            var temp356 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp357 = (((temp355) && (temp334)) && (temp356));
                            var temp358 = (((ushort)((ushort)7232U)) <= ((ushort)(temp277)));
                            var temp359 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp360 = (((temp358) && (temp334)) && (temp359));
                            var temp361 = (((ushort)((ushort)7248U)) <= ((ushort)(temp277)));
                            var temp362 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp363 = (((temp361) && (temp334)) && (temp362));
                            var temp364 = (((ushort)((ushort)42528U)) <= ((ushort)(temp277)));
                            var temp365 = (((ushort)(temp277)) <= ((ushort)((ushort)42537U)));
                            var temp366 = ((temp364) && (temp365));
                            var temp367 = (((ushort)((ushort)43216U)) <= ((ushort)(temp277)));
                            var temp368 = (((ushort)(temp277)) <= ((ushort)((ushort)43225U)));
                            var temp369 = ((temp367) && (temp368));
                            var temp370 = (((ushort)((ushort)43264U)) <= ((ushort)(temp277)));
                            var temp371 = (((ushort)(temp277)) <= ((ushort)((ushort)43273U)));
                            var temp372 = ((temp370) && (temp371));
                            var temp373 = (((ushort)((ushort)43600U)) <= ((ushort)(temp277)));
                            var temp374 = (((ushort)(temp277)) <= ((ushort)((ushort)43609U)));
                            var temp375 = ((temp373) && (temp374));
                            var temp376 = (((ushort)((ushort)65296U)) <= ((ushort)(temp277)));
                            var temp377 = (((ushort)(temp277)) <= ((ushort)((ushort)65305U)));
                            var temp378 = ((temp376) && (temp377));
                            var temp379 = (((((((((((((((((((((((((((((((temp282) || (temp287)) || (temp290)) || (temp293)) || (temp298)) || (temp301)) || (temp304)) || (temp307)) || (temp310)) || (temp313)) || (temp316)) || (temp319)) || (temp322)) || (temp325)) || (temp328)) || (temp331)) || (temp336)) || (temp339)) || (temp342)) || (temp345)) || (temp348)) || (temp351)) || (temp354)) || (temp357)) || (temp360)) || (temp363)) || (temp366)) || (temp369)) || (temp372)) || (temp375)) || (temp378));
                            if (temp379)
                            {
                                var temp380 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp381 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp277));
                                var temp382 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp380))) + ((uint)(temp381))));
                                s._1 = ((uint)(temp382));
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
                        var temp383 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp384 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp383)));
                        var temp385 = ((int)((uint)(temp383)) <= (int)((uint)((uint)191U)));
                        var temp386 = ((temp384) && (temp385));
                        if (temp386)
                        {
                            var temp387 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp388 = Fun0(((ushort)((s)._0)), ((ushort)(temp387)));
                            s._0 = ((ushort)(temp388));
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
                        var temp389 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp390 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp389)));
                        var temp391 = ((int)((uint)(temp389)) <= (int)((uint)((uint)159U)));
                        var temp392 = ((temp390) && (temp391));
                        if (temp392)
                        {
                            var temp393 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp394 = Fun0(((ushort)((s)._0)), ((ushort)(temp393)));
                            s._0 = ((ushort)(temp394));
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
                        var temp395 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp396 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp395)));
                        var temp397 = ((int)((uint)(temp395)) <= (int)((uint)((uint)191U)));
                        var temp398 = ((temp396) && (temp397));
                        if (temp398)
                        {
                            var temp399 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp400 = Fun0(((ushort)((s)._0)), ((ushort)(temp399)));
                            s._0 = ((ushort)(temp400));
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
                        var temp401 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp402 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp401)));
                        var temp403 = ((int)((uint)(temp401)) <= (int)((uint)((uint)127U)));
                        var temp404 = ((temp402) && (temp403));
                        if (temp404)
                        {
                            var temp405 = (((byte)(i)) == ((byte)((byte)10U)));
                            if (temp405)
                            {
                                var temp406 = Fun1(((uint)((s)._1)), ((uint)((s)._2)));
                                s._2 = ((uint)(temp406));
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
                            var temp407 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp401)));
                            var temp408 = ((int)((uint)(temp401)) <= (int)((uint)((uint)223U)));
                            var temp409 = ((temp407) && (temp408));
                            if (temp409)
                            {
                                var temp410 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp410));
                                goto M36;
                            }
                            else
                            {
                                var temp411 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp411)
                                {
                                    var temp412 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp412));
                                    goto M37;
                                }
                                else
                                {
                                    var temp413 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp413)
                                    {
                                        var temp414 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp414));
                                        goto M38;
                                    }
                                    else
                                    {
                                        var temp415 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp401)));
                                        var temp416 = ((int)((uint)(temp401)) <= (int)((uint)((uint)239U)));
                                        var temp417 = ((temp415) && (temp416));
                                        if (temp417)
                                        {
                                            var temp418 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp418));
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
                        var temp419 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp420 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp419)));
                        var temp421 = ((int)((uint)(temp419)) <= (int)((uint)((uint)191U)));
                        var temp422 = ((temp420) && (temp421));
                        if (temp422)
                        {
                            var temp423 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp424 = Fun0(((ushort)((s)._0)), ((ushort)(temp423)));
                            var temp425 = (((ushort)(temp424)) == ((ushort)((ushort)44U)));
                            if (temp425)
                                throw new Exception();
                            else
                            {
                                var temp426 = (((ushort)((ushort)48U)) <= ((ushort)(temp424)));
                                var temp427 = ((ushort)(((ushort)(temp424)) >> 6));
                                var temp428 = (((ushort)(temp427 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                var temp429 = (((byte)(((byte)((ushort)(temp424))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp430 = (((temp426) && (temp428)) && (temp429));
                                var temp431 = (((ushort)((ushort)1632U)) <= ((ushort)(temp424)));
                                var temp432 = ((byte)(((ushort)(temp424)) >> 11));
                                var temp433 = (((byte)(temp432 & 31L)) == ((byte)((byte)0U & 31L)));
                                var temp434 = (((ushort)(((ushort)((ushort)(temp424))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                var temp435 = (((temp431) && (temp433)) && (temp434));
                                var temp436 = (((ushort)((ushort)1776U)) <= ((ushort)(temp424)));
                                var temp437 = (((ushort)(((ushort)((ushort)(temp424))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                var temp438 = (((temp436) && (temp433)) && (temp437));
                                var temp439 = (((ushort)((ushort)1984U)) <= ((ushort)(temp424)));
                                var temp440 = (((ushort)(((ushort)((ushort)(temp424))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                var temp441 = (((temp439) && (temp433)) && (temp440));
                                var temp442 = (((ushort)((ushort)2406U)) <= ((ushort)(temp424)));
                                var temp443 = ((byte)(((ushort)(temp424)) >> 12));
                                var temp444 = (((byte)(temp443 & 15L)) == ((byte)((byte)0U & 15L)));
                                var temp445 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                var temp446 = (((temp442) && (temp444)) && (temp445));
                                var temp447 = (((ushort)((ushort)2534U)) <= ((ushort)(temp424)));
                                var temp448 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                var temp449 = (((temp447) && (temp444)) && (temp448));
                                var temp450 = (((ushort)((ushort)2662U)) <= ((ushort)(temp424)));
                                var temp451 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                var temp452 = (((temp450) && (temp444)) && (temp451));
                                var temp453 = (((ushort)((ushort)2790U)) <= ((ushort)(temp424)));
                                var temp454 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                var temp455 = (((temp453) && (temp444)) && (temp454));
                                var temp456 = (((ushort)((ushort)2918U)) <= ((ushort)(temp424)));
                                var temp457 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                var temp458 = (((temp456) && (temp444)) && (temp457));
                                var temp459 = (((ushort)((ushort)3046U)) <= ((ushort)(temp424)));
                                var temp460 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                var temp461 = (((temp459) && (temp444)) && (temp460));
                                var temp462 = (((ushort)((ushort)3174U)) <= ((ushort)(temp424)));
                                var temp463 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                var temp464 = (((temp462) && (temp444)) && (temp463));
                                var temp465 = (((ushort)((ushort)3302U)) <= ((ushort)(temp424)));
                                var temp466 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                var temp467 = (((temp465) && (temp444)) && (temp466));
                                var temp468 = (((ushort)((ushort)3430U)) <= ((ushort)(temp424)));
                                var temp469 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                var temp470 = (((temp468) && (temp444)) && (temp469));
                                var temp471 = (((ushort)((ushort)3664U)) <= ((ushort)(temp424)));
                                var temp472 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                var temp473 = (((temp471) && (temp444)) && (temp472));
                                var temp474 = (((ushort)((ushort)3792U)) <= ((ushort)(temp424)));
                                var temp475 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                var temp476 = (((temp474) && (temp444)) && (temp475));
                                var temp477 = (((ushort)((ushort)3872U)) <= ((ushort)(temp424)));
                                var temp478 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                var temp479 = (((temp477) && (temp444)) && (temp478));
                                var temp480 = (((ushort)((ushort)4160U)) <= ((ushort)(temp424)));
                                var temp481 = ((byte)(((ushort)(temp424)) >> 13));
                                var temp482 = (((byte)(temp481 & 7L)) == ((byte)((byte)0U & 7L)));
                                var temp483 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                var temp484 = (((temp480) && (temp482)) && (temp483));
                                var temp485 = (((ushort)((ushort)4240U)) <= ((ushort)(temp424)));
                                var temp486 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                var temp487 = (((temp485) && (temp482)) && (temp486));
                                var temp488 = (((ushort)((ushort)6112U)) <= ((ushort)(temp424)));
                                var temp489 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                var temp490 = (((temp488) && (temp482)) && (temp489));
                                var temp491 = (((ushort)((ushort)6160U)) <= ((ushort)(temp424)));
                                var temp492 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                var temp493 = (((temp491) && (temp482)) && (temp492));
                                var temp494 = (((ushort)((ushort)6470U)) <= ((ushort)(temp424)));
                                var temp495 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                var temp496 = (((temp494) && (temp482)) && (temp495));
                                var temp497 = (((ushort)((ushort)6608U)) <= ((ushort)(temp424)));
                                var temp498 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                var temp499 = (((temp497) && (temp482)) && (temp498));
                                var temp500 = (((ushort)((ushort)6992U)) <= ((ushort)(temp424)));
                                var temp501 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                var temp502 = (((temp500) && (temp482)) && (temp501));
                                var temp503 = (((ushort)((ushort)7088U)) <= ((ushort)(temp424)));
                                var temp504 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                var temp505 = (((temp503) && (temp482)) && (temp504));
                                var temp506 = (((ushort)((ushort)7232U)) <= ((ushort)(temp424)));
                                var temp507 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                var temp508 = (((temp506) && (temp482)) && (temp507));
                                var temp509 = (((ushort)((ushort)7248U)) <= ((ushort)(temp424)));
                                var temp510 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                var temp511 = (((temp509) && (temp482)) && (temp510));
                                var temp512 = (((ushort)((ushort)42528U)) <= ((ushort)(temp424)));
                                var temp513 = (((ushort)(temp424)) <= ((ushort)((ushort)42537U)));
                                var temp514 = ((temp512) && (temp513));
                                var temp515 = (((ushort)((ushort)43216U)) <= ((ushort)(temp424)));
                                var temp516 = (((ushort)(temp424)) <= ((ushort)((ushort)43225U)));
                                var temp517 = ((temp515) && (temp516));
                                var temp518 = (((ushort)((ushort)43264U)) <= ((ushort)(temp424)));
                                var temp519 = (((ushort)(temp424)) <= ((ushort)((ushort)43273U)));
                                var temp520 = ((temp518) && (temp519));
                                var temp521 = (((ushort)((ushort)43600U)) <= ((ushort)(temp424)));
                                var temp522 = (((ushort)(temp424)) <= ((ushort)((ushort)43609U)));
                                var temp523 = ((temp521) && (temp522));
                                var temp524 = (((ushort)((ushort)65296U)) <= ((ushort)(temp424)));
                                var temp525 = (((ushort)(temp424)) <= ((ushort)((ushort)65305U)));
                                var temp526 = ((temp524) && (temp525));
                                var temp527 = (((((((((((((((((((((((((((((((temp430) || (temp435)) || (temp438)) || (temp441)) || (temp446)) || (temp449)) || (temp452)) || (temp455)) || (temp458)) || (temp461)) || (temp464)) || (temp467)) || (temp470)) || (temp473)) || (temp476)) || (temp479)) || (temp484)) || (temp487)) || (temp490)) || (temp493)) || (temp496)) || (temp499)) || (temp502)) || (temp505)) || (temp508)) || (temp511)) || (temp514)) || (temp517)) || (temp520)) || (temp523)) || (temp526));
                                if (temp527)
                                {
                                    var temp528 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                    var temp529 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp424));
                                    var temp530 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp528))) + ((uint)(temp529))));
                                    s._1 = ((uint)(temp530));
                                    s._0 = ((ushort)((ushort)0U));
                                    goto M26;
                                }
                                else
                                    throw new Exception();
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
                        var temp531 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp532 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp531)));
                        var temp533 = ((int)((uint)(temp531)) <= (int)((uint)((uint)191U)));
                        var temp534 = ((temp532) && (temp533));
                        if (temp534)
                        {
                            var temp535 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp536 = Fun0(((ushort)((s)._0)), ((ushort)(temp535)));
                            s._0 = ((ushort)(temp536));
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
                        var temp537 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp538 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp537)));
                        var temp539 = ((int)((uint)(temp537)) <= (int)((uint)((uint)159U)));
                        var temp540 = ((temp538) && (temp539));
                        if (temp540)
                        {
                            var temp541 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp542 = Fun0(((ushort)((s)._0)), ((ushort)(temp541)));
                            s._0 = ((ushort)(temp542));
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
                        var temp543 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp544 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp543)));
                        var temp545 = ((int)((uint)(temp543)) <= (int)((uint)((uint)191U)));
                        var temp546 = ((temp544) && (temp545));
                        if (temp546)
                        {
                            var temp547 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp548 = Fun0(((ushort)((s)._0)), ((ushort)(temp547)));
                            s._0 = ((ushort)(temp548));
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
                        var temp549 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp550 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp549)));
                        var temp551 = ((int)((uint)(temp549)) <= (int)((uint)((uint)191U)));
                        var temp552 = ((temp550) && (temp551));
                        if (temp552)
                        {
                            var temp553 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp554 = Fun0(((ushort)((s)._0)), ((ushort)(temp553)));
                            var temp555 = (((ushort)(temp554)) == ((ushort)((ushort)10U)));
                            if (temp555)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M31;
                            }
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
                        var temp556 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp557 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp556)));
                        var temp558 = ((int)((uint)(temp556)) <= (int)((uint)((uint)191U)));
                        var temp559 = ((temp557) && (temp558));
                        if (temp559)
                        {
                            var temp560 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp561 = Fun0(((ushort)((s)._0)), ((ushort)(temp560)));
                            s._0 = ((ushort)(temp561));
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
                        var temp562 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp563 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp562)));
                        var temp564 = ((int)((uint)(temp562)) <= (int)((uint)((uint)159U)));
                        var temp565 = ((temp563) && (temp564));
                        if (temp565)
                        {
                            var temp566 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp567 = Fun0(((ushort)((s)._0)), ((ushort)(temp566)));
                            s._0 = ((ushort)(temp567));
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
                        var temp568 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp569 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp568)));
                        var temp570 = ((int)((uint)(temp568)) <= (int)((uint)((uint)191U)));
                        var temp571 = ((temp569) && (temp570));
                        if (temp571)
                        {
                            var temp572 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp573 = Fun0(((ushort)((s)._0)), ((ushort)(temp572)));
                            s._0 = ((ushort)(temp573));
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
            }
        }

        struct DTStruct35
        {
            public UInt16 _0;
            public UInt32 _1;
            public UInt32 _2;
            public DTStruct35(UInt16 v0, UInt32 v1, UInt32 v2)
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
                DTStruct35 s = new DTStruct35(((ushort)((ushort)0U)), ((uint)((uint)0U)), ((uint)((uint)4294967295U)));
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
                            var temp204 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp205 = ((byte)(((byte)(i)) >> 6));
                            var temp206 = (((byte)(temp205 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp207 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp208 = (((temp204) && (temp206)) && (temp207));
                            if (temp208)
                            {
                                var temp209 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp210 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp209))) + ((uint)(temp200))));
                                s._1 = ((uint)(temp210));
                                goto M26;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp211 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp200)));
                            var temp212 = ((int)((uint)(temp200)) <= (int)((uint)((uint)223U)));
                            var temp213 = ((temp211) && (temp212));
                            if (temp213)
                            {
                                var temp214 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp214));
                                goto M27;
                            }
                            else
                            {
                                var temp215 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp215)
                                {
                                    var temp216 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp216));
                                    goto M28;
                                }
                                else
                                {
                                    var temp217 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp217)
                                    {
                                        var temp218 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp218));
                                        goto M29;
                                    }
                                    else
                                    {
                                        var temp219 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp200)));
                                        var temp220 = ((int)((uint)(temp200)) <= (int)((uint)((uint)239U)));
                                        var temp221 = ((temp219) && (temp220));
                                        if (temp221)
                                        {
                                            var temp222 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp222));
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
                        var temp223 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp224 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp223)));
                        var temp225 = ((int)((uint)(temp223)) <= (int)((uint)((uint)191U)));
                        var temp226 = ((temp224) && (temp225));
                        if (temp226)
                        {
                            var temp227 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp228 = Fun0(((ushort)((s)._0)), ((ushort)(temp227)));
                            var temp229 = (((ushort)(temp228)) == ((ushort)((ushort)44U)));
                            if (temp229)
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
                        var temp230 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp231 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp230)));
                        var temp232 = ((int)((uint)(temp230)) <= (int)((uint)((uint)191U)));
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
                        var temp236 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp237 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp236)));
                        var temp238 = ((int)((uint)(temp236)) <= (int)((uint)((uint)159U)));
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
                        var temp242 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp243 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp242)));
                        var temp244 = ((int)((uint)(temp242)) <= (int)((uint)((uint)191U)));
                        var temp245 = ((temp243) && (temp244));
                        if (temp245)
                        {
                            var temp246 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp247 = Fun0(((ushort)((s)._0)), ((ushort)(temp246)));
                            s._0 = ((ushort)(temp247));
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
                        var temp248 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp249 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp248)));
                        var temp250 = ((int)((uint)(temp248)) <= (int)((uint)((uint)127U)));
                        var temp251 = ((temp249) && (temp250));
                        if (temp251)
                        {
                            var temp252 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp252)
                            {
                                goto M31;
                            }
                            else
                            {
                                var temp253 = (((byte)((byte)48U)) <= ((byte)(i)));
                                var temp254 = ((byte)(((byte)(i)) >> 6));
                                var temp255 = (((byte)(temp254 & 3L)) == ((byte)((byte)0U & 3L)));
                                var temp256 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp257 = (((temp253) && (temp255)) && (temp256));
                                if (temp257)
                                {
                                    var temp258 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                    var temp259 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp258))) + ((uint)(temp248))));
                                    s._1 = ((uint)(temp259));
                                    goto M26;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                        else
                        {
                            var temp260 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp248)));
                            var temp261 = ((int)((uint)(temp248)) <= (int)((uint)((uint)223U)));
                            var temp262 = ((temp260) && (temp261));
                            if (temp262)
                            {
                                var temp263 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp263));
                                goto M32;
                            }
                            else
                            {
                                var temp264 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp264)
                                {
                                    var temp265 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp265));
                                    goto M33;
                                }
                                else
                                {
                                    var temp266 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp266)
                                    {
                                        var temp267 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp267));
                                        goto M34;
                                    }
                                    else
                                    {
                                        var temp268 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp248)));
                                        var temp269 = ((int)((uint)(temp248)) <= (int)((uint)((uint)239U)));
                                        var temp270 = ((temp268) && (temp269));
                                        if (temp270)
                                        {
                                            var temp271 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp271));
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
                        var temp272 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp273 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp272)));
                        var temp274 = ((int)((uint)(temp272)) <= (int)((uint)((uint)191U)));
                        var temp275 = ((temp273) && (temp274));
                        if (temp275)
                        {
                            var temp276 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp277 = Fun0(((ushort)((s)._0)), ((ushort)(temp276)));
                            var temp278 = (((ushort)((ushort)48U)) <= ((ushort)(temp277)));
                            var temp279 = ((ushort)(((ushort)(temp277)) >> 6));
                            var temp280 = (((ushort)(temp279 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp281 = (((byte)(((byte)((ushort)(temp277))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp282 = (((temp278) && (temp280)) && (temp281));
                            var temp283 = (((ushort)((ushort)1632U)) <= ((ushort)(temp277)));
                            var temp284 = ((byte)(((ushort)(temp277)) >> 11));
                            var temp285 = (((byte)(temp284 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp286 = (((ushort)(((ushort)((ushort)(temp277))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp287 = (((temp283) && (temp285)) && (temp286));
                            var temp288 = (((ushort)((ushort)1776U)) <= ((ushort)(temp277)));
                            var temp289 = (((ushort)(((ushort)((ushort)(temp277))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp290 = (((temp288) && (temp285)) && (temp289));
                            var temp291 = (((ushort)((ushort)1984U)) <= ((ushort)(temp277)));
                            var temp292 = (((ushort)(((ushort)((ushort)(temp277))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp293 = (((temp291) && (temp285)) && (temp292));
                            var temp294 = (((ushort)((ushort)2406U)) <= ((ushort)(temp277)));
                            var temp295 = ((byte)(((ushort)(temp277)) >> 12));
                            var temp296 = (((byte)(temp295 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp297 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp298 = (((temp294) && (temp296)) && (temp297));
                            var temp299 = (((ushort)((ushort)2534U)) <= ((ushort)(temp277)));
                            var temp300 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp301 = (((temp299) && (temp296)) && (temp300));
                            var temp302 = (((ushort)((ushort)2662U)) <= ((ushort)(temp277)));
                            var temp303 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp304 = (((temp302) && (temp296)) && (temp303));
                            var temp305 = (((ushort)((ushort)2790U)) <= ((ushort)(temp277)));
                            var temp306 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp307 = (((temp305) && (temp296)) && (temp306));
                            var temp308 = (((ushort)((ushort)2918U)) <= ((ushort)(temp277)));
                            var temp309 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp310 = (((temp308) && (temp296)) && (temp309));
                            var temp311 = (((ushort)((ushort)3046U)) <= ((ushort)(temp277)));
                            var temp312 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp313 = (((temp311) && (temp296)) && (temp312));
                            var temp314 = (((ushort)((ushort)3174U)) <= ((ushort)(temp277)));
                            var temp315 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp316 = (((temp314) && (temp296)) && (temp315));
                            var temp317 = (((ushort)((ushort)3302U)) <= ((ushort)(temp277)));
                            var temp318 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp319 = (((temp317) && (temp296)) && (temp318));
                            var temp320 = (((ushort)((ushort)3430U)) <= ((ushort)(temp277)));
                            var temp321 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp322 = (((temp320) && (temp296)) && (temp321));
                            var temp323 = (((ushort)((ushort)3664U)) <= ((ushort)(temp277)));
                            var temp324 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp325 = (((temp323) && (temp296)) && (temp324));
                            var temp326 = (((ushort)((ushort)3792U)) <= ((ushort)(temp277)));
                            var temp327 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp328 = (((temp326) && (temp296)) && (temp327));
                            var temp329 = (((ushort)((ushort)3872U)) <= ((ushort)(temp277)));
                            var temp330 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp331 = (((temp329) && (temp296)) && (temp330));
                            var temp332 = (((ushort)((ushort)4160U)) <= ((ushort)(temp277)));
                            var temp333 = ((byte)(((ushort)(temp277)) >> 13));
                            var temp334 = (((byte)(temp333 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp335 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp336 = (((temp332) && (temp334)) && (temp335));
                            var temp337 = (((ushort)((ushort)4240U)) <= ((ushort)(temp277)));
                            var temp338 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp339 = (((temp337) && (temp334)) && (temp338));
                            var temp340 = (((ushort)((ushort)6112U)) <= ((ushort)(temp277)));
                            var temp341 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp342 = (((temp340) && (temp334)) && (temp341));
                            var temp343 = (((ushort)((ushort)6160U)) <= ((ushort)(temp277)));
                            var temp344 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp345 = (((temp343) && (temp334)) && (temp344));
                            var temp346 = (((ushort)((ushort)6470U)) <= ((ushort)(temp277)));
                            var temp347 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp348 = (((temp346) && (temp334)) && (temp347));
                            var temp349 = (((ushort)((ushort)6608U)) <= ((ushort)(temp277)));
                            var temp350 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp351 = (((temp349) && (temp334)) && (temp350));
                            var temp352 = (((ushort)((ushort)6992U)) <= ((ushort)(temp277)));
                            var temp353 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp354 = (((temp352) && (temp334)) && (temp353));
                            var temp355 = (((ushort)((ushort)7088U)) <= ((ushort)(temp277)));
                            var temp356 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp357 = (((temp355) && (temp334)) && (temp356));
                            var temp358 = (((ushort)((ushort)7232U)) <= ((ushort)(temp277)));
                            var temp359 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp360 = (((temp358) && (temp334)) && (temp359));
                            var temp361 = (((ushort)((ushort)7248U)) <= ((ushort)(temp277)));
                            var temp362 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp363 = (((temp361) && (temp334)) && (temp362));
                            var temp364 = (((ushort)((ushort)42528U)) <= ((ushort)(temp277)));
                            var temp365 = (((ushort)(temp277)) <= ((ushort)((ushort)42537U)));
                            var temp366 = ((temp364) && (temp365));
                            var temp367 = (((ushort)((ushort)43216U)) <= ((ushort)(temp277)));
                            var temp368 = (((ushort)(temp277)) <= ((ushort)((ushort)43225U)));
                            var temp369 = ((temp367) && (temp368));
                            var temp370 = (((ushort)((ushort)43264U)) <= ((ushort)(temp277)));
                            var temp371 = (((ushort)(temp277)) <= ((ushort)((ushort)43273U)));
                            var temp372 = ((temp370) && (temp371));
                            var temp373 = (((ushort)((ushort)43600U)) <= ((ushort)(temp277)));
                            var temp374 = (((ushort)(temp277)) <= ((ushort)((ushort)43609U)));
                            var temp375 = ((temp373) && (temp374));
                            var temp376 = (((ushort)((ushort)65296U)) <= ((ushort)(temp277)));
                            var temp377 = (((ushort)(temp277)) <= ((ushort)((ushort)65305U)));
                            var temp378 = ((temp376) && (temp377));
                            var temp379 = (((((((((((((((((((((((((((((((temp282) || (temp287)) || (temp290)) || (temp293)) || (temp298)) || (temp301)) || (temp304)) || (temp307)) || (temp310)) || (temp313)) || (temp316)) || (temp319)) || (temp322)) || (temp325)) || (temp328)) || (temp331)) || (temp336)) || (temp339)) || (temp342)) || (temp345)) || (temp348)) || (temp351)) || (temp354)) || (temp357)) || (temp360)) || (temp363)) || (temp366)) || (temp369)) || (temp372)) || (temp375)) || (temp378));
                            if (temp379)
                            {
                                var temp380 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp381 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp277));
                                var temp382 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp380))) + ((uint)(temp381))));
                                s._1 = ((uint)(temp382));
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
                        var temp383 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp384 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp383)));
                        var temp385 = ((int)((uint)(temp383)) <= (int)((uint)((uint)191U)));
                        var temp386 = ((temp384) && (temp385));
                        if (temp386)
                        {
                            var temp387 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp388 = Fun0(((ushort)((s)._0)), ((ushort)(temp387)));
                            s._0 = ((ushort)(temp388));
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
                        var temp389 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp390 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp389)));
                        var temp391 = ((int)((uint)(temp389)) <= (int)((uint)((uint)159U)));
                        var temp392 = ((temp390) && (temp391));
                        if (temp392)
                        {
                            var temp393 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp394 = Fun0(((ushort)((s)._0)), ((ushort)(temp393)));
                            s._0 = ((ushort)(temp394));
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
                        var temp395 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp396 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp395)));
                        var temp397 = ((int)((uint)(temp395)) <= (int)((uint)((uint)191U)));
                        var temp398 = ((temp396) && (temp397));
                        if (temp398)
                        {
                            var temp399 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp400 = Fun0(((ushort)((s)._0)), ((ushort)(temp399)));
                            s._0 = ((ushort)(temp400));
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
                        var temp401 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp402 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp401)));
                        var temp403 = ((int)((uint)(temp401)) <= (int)((uint)((uint)127U)));
                        var temp404 = ((temp402) && (temp403));
                        if (temp404)
                        {
                            var temp405 = (((byte)(i)) == ((byte)((byte)10U)));
                            if (temp405)
                            {
                                var temp406 = Fun1(((uint)((s)._1)), ((uint)((s)._2)));
                                s._2 = ((uint)(temp406));
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
                            var temp407 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp401)));
                            var temp408 = ((int)((uint)(temp401)) <= (int)((uint)((uint)223U)));
                            var temp409 = ((temp407) && (temp408));
                            if (temp409)
                            {
                                var temp410 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp410));
                                goto M36;
                            }
                            else
                            {
                                var temp411 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp411)
                                {
                                    var temp412 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp412));
                                    goto M37;
                                }
                                else
                                {
                                    var temp413 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp413)
                                    {
                                        var temp414 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp414));
                                        goto M38;
                                    }
                                    else
                                    {
                                        var temp415 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp401)));
                                        var temp416 = ((int)((uint)(temp401)) <= (int)((uint)((uint)239U)));
                                        var temp417 = ((temp415) && (temp416));
                                        if (temp417)
                                        {
                                            var temp418 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp418));
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
                        var temp419 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp420 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp419)));
                        var temp421 = ((int)((uint)(temp419)) <= (int)((uint)((uint)191U)));
                        var temp422 = ((temp420) && (temp421));
                        if (temp422)
                        {
                            var temp423 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp424 = Fun0(((ushort)((s)._0)), ((ushort)(temp423)));
                            var temp425 = (((ushort)(temp424)) == ((ushort)((ushort)44U)));
                            if (temp425)
                                throw new Exception();
                            else
                            {
                                var temp426 = (((ushort)((ushort)48U)) <= ((ushort)(temp424)));
                                var temp427 = ((ushort)(((ushort)(temp424)) >> 6));
                                var temp428 = (((ushort)(temp427 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                var temp429 = (((byte)(((byte)((ushort)(temp424))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp430 = (((temp426) && (temp428)) && (temp429));
                                var temp431 = (((ushort)((ushort)1632U)) <= ((ushort)(temp424)));
                                var temp432 = ((byte)(((ushort)(temp424)) >> 11));
                                var temp433 = (((byte)(temp432 & 31L)) == ((byte)((byte)0U & 31L)));
                                var temp434 = (((ushort)(((ushort)((ushort)(temp424))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                var temp435 = (((temp431) && (temp433)) && (temp434));
                                var temp436 = (((ushort)((ushort)1776U)) <= ((ushort)(temp424)));
                                var temp437 = (((ushort)(((ushort)((ushort)(temp424))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                var temp438 = (((temp436) && (temp433)) && (temp437));
                                var temp439 = (((ushort)((ushort)1984U)) <= ((ushort)(temp424)));
                                var temp440 = (((ushort)(((ushort)((ushort)(temp424))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                var temp441 = (((temp439) && (temp433)) && (temp440));
                                var temp442 = (((ushort)((ushort)2406U)) <= ((ushort)(temp424)));
                                var temp443 = ((byte)(((ushort)(temp424)) >> 12));
                                var temp444 = (((byte)(temp443 & 15L)) == ((byte)((byte)0U & 15L)));
                                var temp445 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                var temp446 = (((temp442) && (temp444)) && (temp445));
                                var temp447 = (((ushort)((ushort)2534U)) <= ((ushort)(temp424)));
                                var temp448 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                var temp449 = (((temp447) && (temp444)) && (temp448));
                                var temp450 = (((ushort)((ushort)2662U)) <= ((ushort)(temp424)));
                                var temp451 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                var temp452 = (((temp450) && (temp444)) && (temp451));
                                var temp453 = (((ushort)((ushort)2790U)) <= ((ushort)(temp424)));
                                var temp454 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                var temp455 = (((temp453) && (temp444)) && (temp454));
                                var temp456 = (((ushort)((ushort)2918U)) <= ((ushort)(temp424)));
                                var temp457 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                var temp458 = (((temp456) && (temp444)) && (temp457));
                                var temp459 = (((ushort)((ushort)3046U)) <= ((ushort)(temp424)));
                                var temp460 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                var temp461 = (((temp459) && (temp444)) && (temp460));
                                var temp462 = (((ushort)((ushort)3174U)) <= ((ushort)(temp424)));
                                var temp463 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                var temp464 = (((temp462) && (temp444)) && (temp463));
                                var temp465 = (((ushort)((ushort)3302U)) <= ((ushort)(temp424)));
                                var temp466 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                var temp467 = (((temp465) && (temp444)) && (temp466));
                                var temp468 = (((ushort)((ushort)3430U)) <= ((ushort)(temp424)));
                                var temp469 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                var temp470 = (((temp468) && (temp444)) && (temp469));
                                var temp471 = (((ushort)((ushort)3664U)) <= ((ushort)(temp424)));
                                var temp472 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                var temp473 = (((temp471) && (temp444)) && (temp472));
                                var temp474 = (((ushort)((ushort)3792U)) <= ((ushort)(temp424)));
                                var temp475 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                var temp476 = (((temp474) && (temp444)) && (temp475));
                                var temp477 = (((ushort)((ushort)3872U)) <= ((ushort)(temp424)));
                                var temp478 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                var temp479 = (((temp477) && (temp444)) && (temp478));
                                var temp480 = (((ushort)((ushort)4160U)) <= ((ushort)(temp424)));
                                var temp481 = ((byte)(((ushort)(temp424)) >> 13));
                                var temp482 = (((byte)(temp481 & 7L)) == ((byte)((byte)0U & 7L)));
                                var temp483 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                var temp484 = (((temp480) && (temp482)) && (temp483));
                                var temp485 = (((ushort)((ushort)4240U)) <= ((ushort)(temp424)));
                                var temp486 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                var temp487 = (((temp485) && (temp482)) && (temp486));
                                var temp488 = (((ushort)((ushort)6112U)) <= ((ushort)(temp424)));
                                var temp489 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                var temp490 = (((temp488) && (temp482)) && (temp489));
                                var temp491 = (((ushort)((ushort)6160U)) <= ((ushort)(temp424)));
                                var temp492 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                var temp493 = (((temp491) && (temp482)) && (temp492));
                                var temp494 = (((ushort)((ushort)6470U)) <= ((ushort)(temp424)));
                                var temp495 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                var temp496 = (((temp494) && (temp482)) && (temp495));
                                var temp497 = (((ushort)((ushort)6608U)) <= ((ushort)(temp424)));
                                var temp498 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                var temp499 = (((temp497) && (temp482)) && (temp498));
                                var temp500 = (((ushort)((ushort)6992U)) <= ((ushort)(temp424)));
                                var temp501 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                var temp502 = (((temp500) && (temp482)) && (temp501));
                                var temp503 = (((ushort)((ushort)7088U)) <= ((ushort)(temp424)));
                                var temp504 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                var temp505 = (((temp503) && (temp482)) && (temp504));
                                var temp506 = (((ushort)((ushort)7232U)) <= ((ushort)(temp424)));
                                var temp507 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                var temp508 = (((temp506) && (temp482)) && (temp507));
                                var temp509 = (((ushort)((ushort)7248U)) <= ((ushort)(temp424)));
                                var temp510 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                var temp511 = (((temp509) && (temp482)) && (temp510));
                                var temp512 = (((ushort)((ushort)42528U)) <= ((ushort)(temp424)));
                                var temp513 = (((ushort)(temp424)) <= ((ushort)((ushort)42537U)));
                                var temp514 = ((temp512) && (temp513));
                                var temp515 = (((ushort)((ushort)43216U)) <= ((ushort)(temp424)));
                                var temp516 = (((ushort)(temp424)) <= ((ushort)((ushort)43225U)));
                                var temp517 = ((temp515) && (temp516));
                                var temp518 = (((ushort)((ushort)43264U)) <= ((ushort)(temp424)));
                                var temp519 = (((ushort)(temp424)) <= ((ushort)((ushort)43273U)));
                                var temp520 = ((temp518) && (temp519));
                                var temp521 = (((ushort)((ushort)43600U)) <= ((ushort)(temp424)));
                                var temp522 = (((ushort)(temp424)) <= ((ushort)((ushort)43609U)));
                                var temp523 = ((temp521) && (temp522));
                                var temp524 = (((ushort)((ushort)65296U)) <= ((ushort)(temp424)));
                                var temp525 = (((ushort)(temp424)) <= ((ushort)((ushort)65305U)));
                                var temp526 = ((temp524) && (temp525));
                                var temp527 = (((((((((((((((((((((((((((((((temp430) || (temp435)) || (temp438)) || (temp441)) || (temp446)) || (temp449)) || (temp452)) || (temp455)) || (temp458)) || (temp461)) || (temp464)) || (temp467)) || (temp470)) || (temp473)) || (temp476)) || (temp479)) || (temp484)) || (temp487)) || (temp490)) || (temp493)) || (temp496)) || (temp499)) || (temp502)) || (temp505)) || (temp508)) || (temp511)) || (temp514)) || (temp517)) || (temp520)) || (temp523)) || (temp526));
                                if (temp527)
                                {
                                    var temp528 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                    var temp529 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp424));
                                    var temp530 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp528))) + ((uint)(temp529))));
                                    s._1 = ((uint)(temp530));
                                    s._0 = ((ushort)((ushort)0U));
                                    goto M26;
                                }
                                else
                                    throw new Exception();
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
                        var temp531 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp532 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp531)));
                        var temp533 = ((int)((uint)(temp531)) <= (int)((uint)((uint)191U)));
                        var temp534 = ((temp532) && (temp533));
                        if (temp534)
                        {
                            var temp535 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp536 = Fun0(((ushort)((s)._0)), ((ushort)(temp535)));
                            s._0 = ((ushort)(temp536));
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
                        var temp537 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp538 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp537)));
                        var temp539 = ((int)((uint)(temp537)) <= (int)((uint)((uint)159U)));
                        var temp540 = ((temp538) && (temp539));
                        if (temp540)
                        {
                            var temp541 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp542 = Fun0(((ushort)((s)._0)), ((ushort)(temp541)));
                            s._0 = ((ushort)(temp542));
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
                        var temp543 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp544 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp543)));
                        var temp545 = ((int)((uint)(temp543)) <= (int)((uint)((uint)191U)));
                        var temp546 = ((temp544) && (temp545));
                        if (temp546)
                        {
                            var temp547 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp548 = Fun0(((ushort)((s)._0)), ((ushort)(temp547)));
                            s._0 = ((ushort)(temp548));
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
                        var temp549 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp550 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp549)));
                        var temp551 = ((int)((uint)(temp549)) <= (int)((uint)((uint)191U)));
                        var temp552 = ((temp550) && (temp551));
                        if (temp552)
                        {
                            var temp553 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp554 = Fun0(((ushort)((s)._0)), ((ushort)(temp553)));
                            var temp555 = (((ushort)(temp554)) == ((ushort)((ushort)10U)));
                            if (temp555)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M31;
                            }
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
                        var temp556 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp557 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp556)));
                        var temp558 = ((int)((uint)(temp556)) <= (int)((uint)((uint)191U)));
                        var temp559 = ((temp557) && (temp558));
                        if (temp559)
                        {
                            var temp560 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp561 = Fun0(((ushort)((s)._0)), ((ushort)(temp560)));
                            s._0 = ((ushort)(temp561));
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
                        var temp562 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp563 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp562)));
                        var temp564 = ((int)((uint)(temp562)) <= (int)((uint)((uint)159U)));
                        var temp565 = ((temp563) && (temp564));
                        if (temp565)
                        {
                            var temp566 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp567 = Fun0(((ushort)((s)._0)), ((ushort)(temp566)));
                            s._0 = ((ushort)(temp567));
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
                        var temp568 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp569 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp568)));
                        var temp570 = ((int)((uint)(temp568)) <= (int)((uint)((uint)191U)));
                        var temp571 = ((temp569) && (temp570));
                        if (temp571)
                        {
                            var temp572 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp573 = Fun0(((ushort)((s)._0)), ((ushort)(temp572)));
                            s._0 = ((ushort)(temp573));
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
            }
        }

        struct DTStruct36
        {
            public UInt16 _0;
            public UInt32 _1;
            public UInt32 _2;
            public DTStruct36(UInt16 v0, UInt32 v1, UInt32 v2)
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
                DTStruct36 s = new DTStruct36(((ushort)((ushort)0U)), ((uint)((uint)0U)), ((uint)((uint)4294967295U)));
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
                            var temp204 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp205 = ((byte)(((byte)(i)) >> 6));
                            var temp206 = (((byte)(temp205 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp207 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp208 = (((temp204) && (temp206)) && (temp207));
                            if (temp208)
                            {
                                var temp209 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp210 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp209))) + ((uint)(temp200))));
                                s._1 = ((uint)(temp210));
                                goto M26;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp211 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp200)));
                            var temp212 = ((int)((uint)(temp200)) <= (int)((uint)((uint)223U)));
                            var temp213 = ((temp211) && (temp212));
                            if (temp213)
                            {
                                var temp214 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp214));
                                goto M27;
                            }
                            else
                            {
                                var temp215 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp215)
                                {
                                    var temp216 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp216));
                                    goto M28;
                                }
                                else
                                {
                                    var temp217 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp217)
                                    {
                                        var temp218 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp218));
                                        goto M29;
                                    }
                                    else
                                    {
                                        var temp219 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp200)));
                                        var temp220 = ((int)((uint)(temp200)) <= (int)((uint)((uint)239U)));
                                        var temp221 = ((temp219) && (temp220));
                                        if (temp221)
                                        {
                                            var temp222 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp222));
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
                        var temp223 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp224 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp223)));
                        var temp225 = ((int)((uint)(temp223)) <= (int)((uint)((uint)191U)));
                        var temp226 = ((temp224) && (temp225));
                        if (temp226)
                        {
                            var temp227 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp228 = Fun0(((ushort)((s)._0)), ((ushort)(temp227)));
                            var temp229 = (((ushort)(temp228)) == ((ushort)((ushort)44U)));
                            if (temp229)
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
                        var temp230 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp231 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp230)));
                        var temp232 = ((int)((uint)(temp230)) <= (int)((uint)((uint)191U)));
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

                M24:
                {
                    if (++iIndex >= input.Length)
                        goto F24;
                    i = input[iIndex];
                    {
                        var temp236 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp237 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp236)));
                        var temp238 = ((int)((uint)(temp236)) <= (int)((uint)((uint)159U)));
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

                M25:
                {
                    if (++iIndex >= input.Length)
                        goto F25;
                    i = input[iIndex];
                    {
                        var temp242 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp243 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp242)));
                        var temp244 = ((int)((uint)(temp242)) <= (int)((uint)((uint)191U)));
                        var temp245 = ((temp243) && (temp244));
                        if (temp245)
                        {
                            var temp246 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp247 = Fun0(((ushort)((s)._0)), ((ushort)(temp246)));
                            s._0 = ((ushort)(temp247));
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
                        var temp248 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp249 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp248)));
                        var temp250 = ((int)((uint)(temp248)) <= (int)((uint)((uint)127U)));
                        var temp251 = ((temp249) && (temp250));
                        if (temp251)
                        {
                            var temp252 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp252)
                            {
                                goto M31;
                            }
                            else
                            {
                                var temp253 = (((byte)((byte)48U)) <= ((byte)(i)));
                                var temp254 = ((byte)(((byte)(i)) >> 6));
                                var temp255 = (((byte)(temp254 & 3L)) == ((byte)((byte)0U & 3L)));
                                var temp256 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp257 = (((temp253) && (temp255)) && (temp256));
                                if (temp257)
                                {
                                    var temp258 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                    var temp259 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp258))) + ((uint)(temp248))));
                                    s._1 = ((uint)(temp259));
                                    goto M26;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                        else
                        {
                            var temp260 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp248)));
                            var temp261 = ((int)((uint)(temp248)) <= (int)((uint)((uint)223U)));
                            var temp262 = ((temp260) && (temp261));
                            if (temp262)
                            {
                                var temp263 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp263));
                                goto M32;
                            }
                            else
                            {
                                var temp264 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp264)
                                {
                                    var temp265 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp265));
                                    goto M33;
                                }
                                else
                                {
                                    var temp266 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp266)
                                    {
                                        var temp267 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp267));
                                        goto M34;
                                    }
                                    else
                                    {
                                        var temp268 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp248)));
                                        var temp269 = ((int)((uint)(temp248)) <= (int)((uint)((uint)239U)));
                                        var temp270 = ((temp268) && (temp269));
                                        if (temp270)
                                        {
                                            var temp271 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp271));
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
                        var temp272 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp273 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp272)));
                        var temp274 = ((int)((uint)(temp272)) <= (int)((uint)((uint)191U)));
                        var temp275 = ((temp273) && (temp274));
                        if (temp275)
                        {
                            var temp276 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp277 = Fun0(((ushort)((s)._0)), ((ushort)(temp276)));
                            var temp278 = (((ushort)((ushort)48U)) <= ((ushort)(temp277)));
                            var temp279 = ((ushort)(((ushort)(temp277)) >> 6));
                            var temp280 = (((ushort)(temp279 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp281 = (((byte)(((byte)((ushort)(temp277))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp282 = (((temp278) && (temp280)) && (temp281));
                            var temp283 = (((ushort)((ushort)1632U)) <= ((ushort)(temp277)));
                            var temp284 = ((byte)(((ushort)(temp277)) >> 11));
                            var temp285 = (((byte)(temp284 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp286 = (((ushort)(((ushort)((ushort)(temp277))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp287 = (((temp283) && (temp285)) && (temp286));
                            var temp288 = (((ushort)((ushort)1776U)) <= ((ushort)(temp277)));
                            var temp289 = (((ushort)(((ushort)((ushort)(temp277))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp290 = (((temp288) && (temp285)) && (temp289));
                            var temp291 = (((ushort)((ushort)1984U)) <= ((ushort)(temp277)));
                            var temp292 = (((ushort)(((ushort)((ushort)(temp277))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp293 = (((temp291) && (temp285)) && (temp292));
                            var temp294 = (((ushort)((ushort)2406U)) <= ((ushort)(temp277)));
                            var temp295 = ((byte)(((ushort)(temp277)) >> 12));
                            var temp296 = (((byte)(temp295 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp297 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp298 = (((temp294) && (temp296)) && (temp297));
                            var temp299 = (((ushort)((ushort)2534U)) <= ((ushort)(temp277)));
                            var temp300 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp301 = (((temp299) && (temp296)) && (temp300));
                            var temp302 = (((ushort)((ushort)2662U)) <= ((ushort)(temp277)));
                            var temp303 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp304 = (((temp302) && (temp296)) && (temp303));
                            var temp305 = (((ushort)((ushort)2790U)) <= ((ushort)(temp277)));
                            var temp306 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp307 = (((temp305) && (temp296)) && (temp306));
                            var temp308 = (((ushort)((ushort)2918U)) <= ((ushort)(temp277)));
                            var temp309 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp310 = (((temp308) && (temp296)) && (temp309));
                            var temp311 = (((ushort)((ushort)3046U)) <= ((ushort)(temp277)));
                            var temp312 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp313 = (((temp311) && (temp296)) && (temp312));
                            var temp314 = (((ushort)((ushort)3174U)) <= ((ushort)(temp277)));
                            var temp315 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp316 = (((temp314) && (temp296)) && (temp315));
                            var temp317 = (((ushort)((ushort)3302U)) <= ((ushort)(temp277)));
                            var temp318 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp319 = (((temp317) && (temp296)) && (temp318));
                            var temp320 = (((ushort)((ushort)3430U)) <= ((ushort)(temp277)));
                            var temp321 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp322 = (((temp320) && (temp296)) && (temp321));
                            var temp323 = (((ushort)((ushort)3664U)) <= ((ushort)(temp277)));
                            var temp324 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp325 = (((temp323) && (temp296)) && (temp324));
                            var temp326 = (((ushort)((ushort)3792U)) <= ((ushort)(temp277)));
                            var temp327 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp328 = (((temp326) && (temp296)) && (temp327));
                            var temp329 = (((ushort)((ushort)3872U)) <= ((ushort)(temp277)));
                            var temp330 = (((ushort)(((ushort)((ushort)(temp277))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp331 = (((temp329) && (temp296)) && (temp330));
                            var temp332 = (((ushort)((ushort)4160U)) <= ((ushort)(temp277)));
                            var temp333 = ((byte)(((ushort)(temp277)) >> 13));
                            var temp334 = (((byte)(temp333 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp335 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp336 = (((temp332) && (temp334)) && (temp335));
                            var temp337 = (((ushort)((ushort)4240U)) <= ((ushort)(temp277)));
                            var temp338 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp339 = (((temp337) && (temp334)) && (temp338));
                            var temp340 = (((ushort)((ushort)6112U)) <= ((ushort)(temp277)));
                            var temp341 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp342 = (((temp340) && (temp334)) && (temp341));
                            var temp343 = (((ushort)((ushort)6160U)) <= ((ushort)(temp277)));
                            var temp344 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp345 = (((temp343) && (temp334)) && (temp344));
                            var temp346 = (((ushort)((ushort)6470U)) <= ((ushort)(temp277)));
                            var temp347 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp348 = (((temp346) && (temp334)) && (temp347));
                            var temp349 = (((ushort)((ushort)6608U)) <= ((ushort)(temp277)));
                            var temp350 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp351 = (((temp349) && (temp334)) && (temp350));
                            var temp352 = (((ushort)((ushort)6992U)) <= ((ushort)(temp277)));
                            var temp353 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp354 = (((temp352) && (temp334)) && (temp353));
                            var temp355 = (((ushort)((ushort)7088U)) <= ((ushort)(temp277)));
                            var temp356 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp357 = (((temp355) && (temp334)) && (temp356));
                            var temp358 = (((ushort)((ushort)7232U)) <= ((ushort)(temp277)));
                            var temp359 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp360 = (((temp358) && (temp334)) && (temp359));
                            var temp361 = (((ushort)((ushort)7248U)) <= ((ushort)(temp277)));
                            var temp362 = (((ushort)(((ushort)((ushort)(temp277))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp363 = (((temp361) && (temp334)) && (temp362));
                            var temp364 = (((ushort)((ushort)42528U)) <= ((ushort)(temp277)));
                            var temp365 = (((ushort)(temp277)) <= ((ushort)((ushort)42537U)));
                            var temp366 = ((temp364) && (temp365));
                            var temp367 = (((ushort)((ushort)43216U)) <= ((ushort)(temp277)));
                            var temp368 = (((ushort)(temp277)) <= ((ushort)((ushort)43225U)));
                            var temp369 = ((temp367) && (temp368));
                            var temp370 = (((ushort)((ushort)43264U)) <= ((ushort)(temp277)));
                            var temp371 = (((ushort)(temp277)) <= ((ushort)((ushort)43273U)));
                            var temp372 = ((temp370) && (temp371));
                            var temp373 = (((ushort)((ushort)43600U)) <= ((ushort)(temp277)));
                            var temp374 = (((ushort)(temp277)) <= ((ushort)((ushort)43609U)));
                            var temp375 = ((temp373) && (temp374));
                            var temp376 = (((ushort)((ushort)65296U)) <= ((ushort)(temp277)));
                            var temp377 = (((ushort)(temp277)) <= ((ushort)((ushort)65305U)));
                            var temp378 = ((temp376) && (temp377));
                            var temp379 = (((((((((((((((((((((((((((((((temp282) || (temp287)) || (temp290)) || (temp293)) || (temp298)) || (temp301)) || (temp304)) || (temp307)) || (temp310)) || (temp313)) || (temp316)) || (temp319)) || (temp322)) || (temp325)) || (temp328)) || (temp331)) || (temp336)) || (temp339)) || (temp342)) || (temp345)) || (temp348)) || (temp351)) || (temp354)) || (temp357)) || (temp360)) || (temp363)) || (temp366)) || (temp369)) || (temp372)) || (temp375)) || (temp378));
                            if (temp379)
                            {
                                var temp380 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp381 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp277));
                                var temp382 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp380))) + ((uint)(temp381))));
                                s._1 = ((uint)(temp382));
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
                        var temp383 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp384 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp383)));
                        var temp385 = ((int)((uint)(temp383)) <= (int)((uint)((uint)191U)));
                        var temp386 = ((temp384) && (temp385));
                        if (temp386)
                        {
                            var temp387 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp388 = Fun0(((ushort)((s)._0)), ((ushort)(temp387)));
                            s._0 = ((ushort)(temp388));
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
                        var temp389 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp390 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp389)));
                        var temp391 = ((int)((uint)(temp389)) <= (int)((uint)((uint)159U)));
                        var temp392 = ((temp390) && (temp391));
                        if (temp392)
                        {
                            var temp393 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp394 = Fun0(((ushort)((s)._0)), ((ushort)(temp393)));
                            s._0 = ((ushort)(temp394));
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
                        var temp395 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp396 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp395)));
                        var temp397 = ((int)((uint)(temp395)) <= (int)((uint)((uint)191U)));
                        var temp398 = ((temp396) && (temp397));
                        if (temp398)
                        {
                            var temp399 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp400 = Fun0(((ushort)((s)._0)), ((ushort)(temp399)));
                            s._0 = ((ushort)(temp400));
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
                        var temp401 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp402 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp401)));
                        var temp403 = ((int)((uint)(temp401)) <= (int)((uint)((uint)127U)));
                        var temp404 = ((temp402) && (temp403));
                        if (temp404)
                        {
                            var temp405 = (((byte)(i)) == ((byte)((byte)10U)));
                            if (temp405)
                            {
                                var temp406 = Fun1(((uint)((s)._1)), ((uint)((s)._2)));
                                s._2 = ((uint)(temp406));
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
                            var temp407 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp401)));
                            var temp408 = ((int)((uint)(temp401)) <= (int)((uint)((uint)223U)));
                            var temp409 = ((temp407) && (temp408));
                            if (temp409)
                            {
                                var temp410 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp410));
                                goto M36;
                            }
                            else
                            {
                                var temp411 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp411)
                                {
                                    var temp412 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp412));
                                    goto M37;
                                }
                                else
                                {
                                    var temp413 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp413)
                                    {
                                        var temp414 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp414));
                                        goto M38;
                                    }
                                    else
                                    {
                                        var temp415 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp401)));
                                        var temp416 = ((int)((uint)(temp401)) <= (int)((uint)((uint)239U)));
                                        var temp417 = ((temp415) && (temp416));
                                        if (temp417)
                                        {
                                            var temp418 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp418));
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
                        var temp419 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp420 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp419)));
                        var temp421 = ((int)((uint)(temp419)) <= (int)((uint)((uint)191U)));
                        var temp422 = ((temp420) && (temp421));
                        if (temp422)
                        {
                            var temp423 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp424 = Fun0(((ushort)((s)._0)), ((ushort)(temp423)));
                            var temp425 = (((ushort)(temp424)) == ((ushort)((ushort)44U)));
                            if (temp425)
                                throw new Exception();
                            else
                            {
                                var temp426 = (((ushort)((ushort)48U)) <= ((ushort)(temp424)));
                                var temp427 = ((ushort)(((ushort)(temp424)) >> 6));
                                var temp428 = (((ushort)(temp427 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                var temp429 = (((byte)(((byte)((ushort)(temp424))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp430 = (((temp426) && (temp428)) && (temp429));
                                var temp431 = (((ushort)((ushort)1632U)) <= ((ushort)(temp424)));
                                var temp432 = ((byte)(((ushort)(temp424)) >> 11));
                                var temp433 = (((byte)(temp432 & 31L)) == ((byte)((byte)0U & 31L)));
                                var temp434 = (((ushort)(((ushort)((ushort)(temp424))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                var temp435 = (((temp431) && (temp433)) && (temp434));
                                var temp436 = (((ushort)((ushort)1776U)) <= ((ushort)(temp424)));
                                var temp437 = (((ushort)(((ushort)((ushort)(temp424))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                var temp438 = (((temp436) && (temp433)) && (temp437));
                                var temp439 = (((ushort)((ushort)1984U)) <= ((ushort)(temp424)));
                                var temp440 = (((ushort)(((ushort)((ushort)(temp424))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                var temp441 = (((temp439) && (temp433)) && (temp440));
                                var temp442 = (((ushort)((ushort)2406U)) <= ((ushort)(temp424)));
                                var temp443 = ((byte)(((ushort)(temp424)) >> 12));
                                var temp444 = (((byte)(temp443 & 15L)) == ((byte)((byte)0U & 15L)));
                                var temp445 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                var temp446 = (((temp442) && (temp444)) && (temp445));
                                var temp447 = (((ushort)((ushort)2534U)) <= ((ushort)(temp424)));
                                var temp448 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                var temp449 = (((temp447) && (temp444)) && (temp448));
                                var temp450 = (((ushort)((ushort)2662U)) <= ((ushort)(temp424)));
                                var temp451 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                var temp452 = (((temp450) && (temp444)) && (temp451));
                                var temp453 = (((ushort)((ushort)2790U)) <= ((ushort)(temp424)));
                                var temp454 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                var temp455 = (((temp453) && (temp444)) && (temp454));
                                var temp456 = (((ushort)((ushort)2918U)) <= ((ushort)(temp424)));
                                var temp457 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                var temp458 = (((temp456) && (temp444)) && (temp457));
                                var temp459 = (((ushort)((ushort)3046U)) <= ((ushort)(temp424)));
                                var temp460 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                var temp461 = (((temp459) && (temp444)) && (temp460));
                                var temp462 = (((ushort)((ushort)3174U)) <= ((ushort)(temp424)));
                                var temp463 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                var temp464 = (((temp462) && (temp444)) && (temp463));
                                var temp465 = (((ushort)((ushort)3302U)) <= ((ushort)(temp424)));
                                var temp466 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                var temp467 = (((temp465) && (temp444)) && (temp466));
                                var temp468 = (((ushort)((ushort)3430U)) <= ((ushort)(temp424)));
                                var temp469 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                var temp470 = (((temp468) && (temp444)) && (temp469));
                                var temp471 = (((ushort)((ushort)3664U)) <= ((ushort)(temp424)));
                                var temp472 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                var temp473 = (((temp471) && (temp444)) && (temp472));
                                var temp474 = (((ushort)((ushort)3792U)) <= ((ushort)(temp424)));
                                var temp475 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                var temp476 = (((temp474) && (temp444)) && (temp475));
                                var temp477 = (((ushort)((ushort)3872U)) <= ((ushort)(temp424)));
                                var temp478 = (((ushort)(((ushort)((ushort)(temp424))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                var temp479 = (((temp477) && (temp444)) && (temp478));
                                var temp480 = (((ushort)((ushort)4160U)) <= ((ushort)(temp424)));
                                var temp481 = ((byte)(((ushort)(temp424)) >> 13));
                                var temp482 = (((byte)(temp481 & 7L)) == ((byte)((byte)0U & 7L)));
                                var temp483 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                var temp484 = (((temp480) && (temp482)) && (temp483));
                                var temp485 = (((ushort)((ushort)4240U)) <= ((ushort)(temp424)));
                                var temp486 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                var temp487 = (((temp485) && (temp482)) && (temp486));
                                var temp488 = (((ushort)((ushort)6112U)) <= ((ushort)(temp424)));
                                var temp489 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                var temp490 = (((temp488) && (temp482)) && (temp489));
                                var temp491 = (((ushort)((ushort)6160U)) <= ((ushort)(temp424)));
                                var temp492 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                var temp493 = (((temp491) && (temp482)) && (temp492));
                                var temp494 = (((ushort)((ushort)6470U)) <= ((ushort)(temp424)));
                                var temp495 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                var temp496 = (((temp494) && (temp482)) && (temp495));
                                var temp497 = (((ushort)((ushort)6608U)) <= ((ushort)(temp424)));
                                var temp498 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                var temp499 = (((temp497) && (temp482)) && (temp498));
                                var temp500 = (((ushort)((ushort)6992U)) <= ((ushort)(temp424)));
                                var temp501 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                var temp502 = (((temp500) && (temp482)) && (temp501));
                                var temp503 = (((ushort)((ushort)7088U)) <= ((ushort)(temp424)));
                                var temp504 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                var temp505 = (((temp503) && (temp482)) && (temp504));
                                var temp506 = (((ushort)((ushort)7232U)) <= ((ushort)(temp424)));
                                var temp507 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                var temp508 = (((temp506) && (temp482)) && (temp507));
                                var temp509 = (((ushort)((ushort)7248U)) <= ((ushort)(temp424)));
                                var temp510 = (((ushort)(((ushort)((ushort)(temp424))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                var temp511 = (((temp509) && (temp482)) && (temp510));
                                var temp512 = (((ushort)((ushort)42528U)) <= ((ushort)(temp424)));
                                var temp513 = (((ushort)(temp424)) <= ((ushort)((ushort)42537U)));
                                var temp514 = ((temp512) && (temp513));
                                var temp515 = (((ushort)((ushort)43216U)) <= ((ushort)(temp424)));
                                var temp516 = (((ushort)(temp424)) <= ((ushort)((ushort)43225U)));
                                var temp517 = ((temp515) && (temp516));
                                var temp518 = (((ushort)((ushort)43264U)) <= ((ushort)(temp424)));
                                var temp519 = (((ushort)(temp424)) <= ((ushort)((ushort)43273U)));
                                var temp520 = ((temp518) && (temp519));
                                var temp521 = (((ushort)((ushort)43600U)) <= ((ushort)(temp424)));
                                var temp522 = (((ushort)(temp424)) <= ((ushort)((ushort)43609U)));
                                var temp523 = ((temp521) && (temp522));
                                var temp524 = (((ushort)((ushort)65296U)) <= ((ushort)(temp424)));
                                var temp525 = (((ushort)(temp424)) <= ((ushort)((ushort)65305U)));
                                var temp526 = ((temp524) && (temp525));
                                var temp527 = (((((((((((((((((((((((((((((((temp430) || (temp435)) || (temp438)) || (temp441)) || (temp446)) || (temp449)) || (temp452)) || (temp455)) || (temp458)) || (temp461)) || (temp464)) || (temp467)) || (temp470)) || (temp473)) || (temp476)) || (temp479)) || (temp484)) || (temp487)) || (temp490)) || (temp493)) || (temp496)) || (temp499)) || (temp502)) || (temp505)) || (temp508)) || (temp511)) || (temp514)) || (temp517)) || (temp520)) || (temp523)) || (temp526));
                                if (temp527)
                                {
                                    var temp528 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                    var temp529 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp424));
                                    var temp530 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp528))) + ((uint)(temp529))));
                                    s._1 = ((uint)(temp530));
                                    s._0 = ((ushort)((ushort)0U));
                                    goto M26;
                                }
                                else
                                    throw new Exception();
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
                        var temp531 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp532 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp531)));
                        var temp533 = ((int)((uint)(temp531)) <= (int)((uint)((uint)191U)));
                        var temp534 = ((temp532) && (temp533));
                        if (temp534)
                        {
                            var temp535 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp536 = Fun0(((ushort)((s)._0)), ((ushort)(temp535)));
                            s._0 = ((ushort)(temp536));
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
                        var temp537 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp538 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp537)));
                        var temp539 = ((int)((uint)(temp537)) <= (int)((uint)((uint)159U)));
                        var temp540 = ((temp538) && (temp539));
                        if (temp540)
                        {
                            var temp541 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp542 = Fun0(((ushort)((s)._0)), ((ushort)(temp541)));
                            s._0 = ((ushort)(temp542));
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
                        var temp543 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp544 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp543)));
                        var temp545 = ((int)((uint)(temp543)) <= (int)((uint)((uint)191U)));
                        var temp546 = ((temp544) && (temp545));
                        if (temp546)
                        {
                            var temp547 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp548 = Fun0(((ushort)((s)._0)), ((ushort)(temp547)));
                            s._0 = ((ushort)(temp548));
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
                        var temp549 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp550 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp549)));
                        var temp551 = ((int)((uint)(temp549)) <= (int)((uint)((uint)191U)));
                        var temp552 = ((temp550) && (temp551));
                        if (temp552)
                        {
                            var temp553 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp554 = Fun0(((ushort)((s)._0)), ((ushort)(temp553)));
                            var temp555 = (((ushort)(temp554)) == ((ushort)((ushort)10U)));
                            if (temp555)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M31;
                            }
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
                        var temp556 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp557 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp556)));
                        var temp558 = ((int)((uint)(temp556)) <= (int)((uint)((uint)191U)));
                        var temp559 = ((temp557) && (temp558));
                        if (temp559)
                        {
                            var temp560 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp561 = Fun0(((ushort)((s)._0)), ((ushort)(temp560)));
                            s._0 = ((ushort)(temp561));
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
                        var temp562 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp563 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp562)));
                        var temp564 = ((int)((uint)(temp562)) <= (int)((uint)((uint)159U)));
                        var temp565 = ((temp563) && (temp564));
                        if (temp565)
                        {
                            var temp566 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp567 = Fun0(((ushort)((s)._0)), ((ushort)(temp566)));
                            s._0 = ((ushort)(temp567));
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
                        var temp568 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp569 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp568)));
                        var temp570 = ((int)((uint)(temp568)) <= (int)((uint)((uint)191U)));
                        var temp571 = ((temp569) && (temp570));
                        if (temp571)
                        {
                            var temp572 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp573 = Fun0(((ushort)((s)._0)), ((ushort)(temp572)));
                            s._0 = ((ushort)(temp573));
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
            }
        }
    }
}