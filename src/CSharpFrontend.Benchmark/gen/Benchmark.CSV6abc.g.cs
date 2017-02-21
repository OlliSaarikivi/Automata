using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class CSV6abc : Composition<CSV6ab, Int32ToBytes>
    {
        static UInt16 Fun0(UInt16 v0, UInt16 v1)
        {
            return (UInt16)(((ushort)((ushort)(((ushort)((ushort)(v0))) & 1023L)) << 6) | (ushort)((byte)(((byte)((ushort)(v1))) & 63L)));
        }

        struct DTStruct37
        {
            public UInt16 _0;
            public UInt32 _1;
            public UInt64 _2;
            public UInt32 _3;
            public DTStruct37(UInt16 v0, UInt32 v1, UInt64 v2, UInt32 v3)
            {
                _0 = v0;
                _1 = v1;
                _2 = v2;
                _3 = v3;
            }
        }

        public static IEnumerable<Byte> Transduce(IEnumerable<Byte> input)
        {
            unchecked
            {
                IEnumerator<Byte> ie = input.GetEnumerator();
                DTStruct37 s = new DTStruct37(((ushort)((ushort)0U)), ((uint)((uint)0U)), ((ulong)((ulong)0UL)), ((uint)((uint)0U)));
                Byte i;
                M0:
                {
                    if (!ie.MoveNext())
                        goto F0;
                    i = ie.Current;
                    {
                        var temp11 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp12 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp11)));
                        var temp13 = ((int)((uint)(temp11)) <= (int)((uint)((uint)127U)));
                        var temp14 = ((temp12) && (temp13));
                        if (temp14)
                        {
                            var temp15 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp15)
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
                            var temp16 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp11)));
                            var temp17 = ((int)((uint)(temp11)) <= (int)((uint)((uint)223U)));
                            var temp18 = ((temp16) && (temp17));
                            if (temp18)
                            {
                                var temp19 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp19));
                                goto M2;
                            }
                            else
                            {
                                var temp20 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp20)
                                {
                                    var temp21 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp21));
                                    goto M3;
                                }
                                else
                                {
                                    var temp22 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp22)
                                    {
                                        var temp23 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp23));
                                        goto M4;
                                    }
                                    else
                                    {
                                        var temp24 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp11)));
                                        var temp25 = ((int)((uint)(temp11)) <= (int)((uint)((uint)239U)));
                                        var temp26 = ((temp24) && (temp25));
                                        if (temp26)
                                        {
                                            var temp27 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp27));
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
                        var temp28 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp29 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp28)));
                        var temp30 = ((int)((uint)(temp28)) <= (int)((uint)((uint)127U)));
                        var temp31 = ((temp29) && (temp30));
                        if (temp31)
                        {
                            var temp32 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp32)
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
                            var temp33 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp28)));
                            var temp34 = ((int)((uint)(temp28)) <= (int)((uint)((uint)223U)));
                            var temp35 = ((temp33) && (temp34));
                            if (temp35)
                            {
                                var temp36 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp36));
                                goto M7;
                            }
                            else
                            {
                                var temp37 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp37)
                                {
                                    var temp38 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp38));
                                    goto M8;
                                }
                                else
                                {
                                    var temp39 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp39)
                                    {
                                        var temp40 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp40));
                                        goto M9;
                                    }
                                    else
                                    {
                                        var temp41 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp28)));
                                        var temp42 = ((int)((uint)(temp28)) <= (int)((uint)((uint)239U)));
                                        var temp43 = ((temp41) && (temp42));
                                        if (temp43)
                                        {
                                            var temp44 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp44));
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
                        var temp56 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp57 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp56)));
                        var temp58 = ((int)((uint)(temp56)) <= (int)((uint)((uint)191U)));
                        var temp59 = ((temp57) && (temp58));
                        if (temp59)
                        {
                            var temp60 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp61 = Fun0(((ushort)((s)._0)), ((ushort)(temp60)));
                            var temp62 = (((ushort)(temp61)) == ((ushort)((ushort)44U)));
                            if (temp62)
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
                        var temp74 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp75 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp74)));
                        var temp76 = ((int)((uint)(temp74)) <= (int)((uint)((uint)191U)));
                        var temp77 = ((temp75) && (temp76));
                        if (temp77)
                        {
                            var temp78 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp79 = Fun0(((ushort)((s)._0)), ((ushort)(temp78)));
                            s._0 = ((ushort)(temp79));
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
                        var temp91 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp92 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp91)));
                        var temp93 = ((int)((uint)(temp91)) <= (int)((uint)((uint)159U)));
                        var temp94 = ((temp92) && (temp93));
                        if (temp94)
                        {
                            var temp95 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp96 = Fun0(((ushort)((s)._0)), ((ushort)(temp95)));
                            s._0 = ((ushort)(temp96));
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
                        var temp108 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp109 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp108)));
                        var temp110 = ((int)((uint)(temp108)) <= (int)((uint)((uint)191U)));
                        var temp111 = ((temp109) && (temp110));
                        if (temp111)
                        {
                            var temp112 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp113 = Fun0(((ushort)((s)._0)), ((ushort)(temp112)));
                            s._0 = ((ushort)(temp113));
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
                        var temp114 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp115 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp114)));
                        var temp116 = ((int)((uint)(temp114)) <= (int)((uint)((uint)127U)));
                        var temp117 = ((temp115) && (temp116));
                        if (temp117)
                        {
                            var temp118 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp118)
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
                            var temp119 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp114)));
                            var temp120 = ((int)((uint)(temp114)) <= (int)((uint)((uint)223U)));
                            var temp121 = ((temp119) && (temp120));
                            if (temp121)
                            {
                                var temp122 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp122));
                                goto M12;
                            }
                            else
                            {
                                var temp123 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp123)
                                {
                                    var temp124 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp124));
                                    goto M13;
                                }
                                else
                                {
                                    var temp125 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp125)
                                    {
                                        var temp126 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp126));
                                        goto M14;
                                    }
                                    else
                                    {
                                        var temp127 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp114)));
                                        var temp128 = ((int)((uint)(temp114)) <= (int)((uint)((uint)239U)));
                                        var temp129 = ((temp127) && (temp128));
                                        if (temp129)
                                        {
                                            var temp130 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp130));
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
                        var temp131 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp132 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp131)));
                        var temp133 = ((int)((uint)(temp131)) <= (int)((uint)((uint)191U)));
                        var temp134 = ((temp132) && (temp133));
                        if (temp134)
                        {
                            var temp135 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp136 = Fun0(((ushort)((s)._0)), ((ushort)(temp135)));
                            var temp137 = (((ushort)(temp136)) == ((ushort)((ushort)44U)));
                            if (temp137)
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
                        var temp138 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp139 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp138)));
                        var temp140 = ((int)((uint)(temp138)) <= (int)((uint)((uint)191U)));
                        var temp141 = ((temp139) && (temp140));
                        if (temp141)
                        {
                            var temp142 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp143 = Fun0(((ushort)((s)._0)), ((ushort)(temp142)));
                            s._0 = ((ushort)(temp143));
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
                        var temp144 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp145 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp144)));
                        var temp146 = ((int)((uint)(temp144)) <= (int)((uint)((uint)159U)));
                        var temp147 = ((temp145) && (temp146));
                        if (temp147)
                        {
                            var temp148 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp149 = Fun0(((ushort)((s)._0)), ((ushort)(temp148)));
                            s._0 = ((ushort)(temp149));
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
                        var temp150 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp151 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp150)));
                        var temp152 = ((int)((uint)(temp150)) <= (int)((uint)((uint)191U)));
                        var temp153 = ((temp151) && (temp152));
                        if (temp153)
                        {
                            var temp154 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp155 = Fun0(((ushort)((s)._0)), ((ushort)(temp154)));
                            s._0 = ((ushort)(temp155));
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
                        var temp156 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp157 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp156)));
                        var temp158 = ((int)((uint)(temp156)) <= (int)((uint)((uint)127U)));
                        var temp159 = ((temp157) && (temp158));
                        if (temp159)
                        {
                            var temp160 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp160)
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
                            var temp161 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp156)));
                            var temp162 = ((int)((uint)(temp156)) <= (int)((uint)((uint)223U)));
                            var temp163 = ((temp161) && (temp162));
                            if (temp163)
                            {
                                var temp164 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp164));
                                goto M17;
                            }
                            else
                            {
                                var temp165 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp165)
                                {
                                    var temp166 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp166));
                                    goto M18;
                                }
                                else
                                {
                                    var temp167 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp167)
                                    {
                                        var temp168 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp168));
                                        goto M19;
                                    }
                                    else
                                    {
                                        var temp169 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp156)));
                                        var temp170 = ((int)((uint)(temp156)) <= (int)((uint)((uint)239U)));
                                        var temp171 = ((temp169) && (temp170));
                                        if (temp171)
                                        {
                                            var temp172 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp172));
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
                        var temp173 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp174 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp173)));
                        var temp175 = ((int)((uint)(temp173)) <= (int)((uint)((uint)191U)));
                        var temp176 = ((temp174) && (temp175));
                        if (temp176)
                        {
                            var temp177 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp178 = Fun0(((ushort)((s)._0)), ((ushort)(temp177)));
                            var temp179 = (((ushort)(temp178)) == ((ushort)((ushort)44U)));
                            if (temp179)
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
                        var temp180 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp181 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp180)));
                        var temp182 = ((int)((uint)(temp180)) <= (int)((uint)((uint)191U)));
                        var temp183 = ((temp181) && (temp182));
                        if (temp183)
                        {
                            var temp184 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp185 = Fun0(((ushort)((s)._0)), ((ushort)(temp184)));
                            s._0 = ((ushort)(temp185));
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
                        var temp186 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp187 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp186)));
                        var temp188 = ((int)((uint)(temp186)) <= (int)((uint)((uint)159U)));
                        var temp189 = ((temp187) && (temp188));
                        if (temp189)
                        {
                            var temp190 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp191 = Fun0(((ushort)((s)._0)), ((ushort)(temp190)));
                            s._0 = ((ushort)(temp191));
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
                        var temp192 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp193 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp192)));
                        var temp194 = ((int)((uint)(temp192)) <= (int)((uint)((uint)191U)));
                        var temp195 = ((temp193) && (temp194));
                        if (temp195)
                        {
                            var temp196 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp197 = Fun0(((ushort)((s)._0)), ((ushort)(temp196)));
                            s._0 = ((ushort)(temp197));
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
                        var temp198 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp199 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp198)));
                        var temp200 = ((int)((uint)(temp198)) <= (int)((uint)((uint)127U)));
                        var temp201 = ((temp199) && (temp200));
                        if (temp201)
                        {
                            var temp202 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp202)
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
                            var temp203 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp198)));
                            var temp204 = ((int)((uint)(temp198)) <= (int)((uint)((uint)223U)));
                            var temp205 = ((temp203) && (temp204));
                            if (temp205)
                            {
                                var temp206 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp206));
                                goto M22;
                            }
                            else
                            {
                                var temp207 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp207)
                                {
                                    var temp208 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp208));
                                    goto M23;
                                }
                                else
                                {
                                    var temp209 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp209)
                                    {
                                        var temp210 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp210));
                                        goto M24;
                                    }
                                    else
                                    {
                                        var temp211 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp198)));
                                        var temp212 = ((int)((uint)(temp198)) <= (int)((uint)((uint)239U)));
                                        var temp213 = ((temp211) && (temp212));
                                        if (temp213)
                                        {
                                            var temp214 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp214));
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
                        var temp215 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp216 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp215)));
                        var temp217 = ((int)((uint)(temp215)) <= (int)((uint)((uint)191U)));
                        var temp218 = ((temp216) && (temp217));
                        if (temp218)
                        {
                            var temp219 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp220 = Fun0(((ushort)((s)._0)), ((ushort)(temp219)));
                            var temp221 = (((ushort)(temp220)) == ((ushort)((ushort)44U)));
                            if (temp221)
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
                        var temp222 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp223 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp222)));
                        var temp224 = ((int)((uint)(temp222)) <= (int)((uint)((uint)191U)));
                        var temp225 = ((temp223) && (temp224));
                        if (temp225)
                        {
                            var temp226 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp227 = Fun0(((ushort)((s)._0)), ((ushort)(temp226)));
                            s._0 = ((ushort)(temp227));
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
                        var temp228 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp229 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp228)));
                        var temp230 = ((int)((uint)(temp228)) <= (int)((uint)((uint)159U)));
                        var temp231 = ((temp229) && (temp230));
                        if (temp231)
                        {
                            var temp232 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp233 = Fun0(((ushort)((s)._0)), ((ushort)(temp232)));
                            s._0 = ((ushort)(temp233));
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
                        var temp234 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp235 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp234)));
                        var temp236 = ((int)((uint)(temp234)) <= (int)((uint)((uint)191U)));
                        var temp237 = ((temp235) && (temp236));
                        if (temp237)
                        {
                            var temp238 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp239 = Fun0(((ushort)((s)._0)), ((ushort)(temp238)));
                            s._0 = ((ushort)(temp239));
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
                        var temp240 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp241 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp240)));
                        var temp242 = ((int)((uint)(temp240)) <= (int)((uint)((uint)127U)));
                        var temp243 = ((temp241) && (temp242));
                        if (temp243)
                        {
                            var temp244 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp244)
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
                            var temp245 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp240)));
                            var temp246 = ((int)((uint)(temp240)) <= (int)((uint)((uint)223U)));
                            var temp247 = ((temp245) && (temp246));
                            if (temp247)
                            {
                                var temp248 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp248));
                                goto M27;
                            }
                            else
                            {
                                var temp249 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp249)
                                {
                                    var temp250 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp250));
                                    goto M28;
                                }
                                else
                                {
                                    var temp251 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp251)
                                    {
                                        var temp252 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp252));
                                        goto M29;
                                    }
                                    else
                                    {
                                        var temp253 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp240)));
                                        var temp254 = ((int)((uint)(temp240)) <= (int)((uint)((uint)239U)));
                                        var temp255 = ((temp253) && (temp254));
                                        if (temp255)
                                        {
                                            var temp256 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp256));
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
                        var temp257 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp258 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp257)));
                        var temp259 = ((int)((uint)(temp257)) <= (int)((uint)((uint)191U)));
                        var temp260 = ((temp258) && (temp259));
                        if (temp260)
                        {
                            var temp261 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp262 = Fun0(((ushort)((s)._0)), ((ushort)(temp261)));
                            var temp263 = (((ushort)(temp262)) == ((ushort)((ushort)44U)));
                            if (temp263)
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
                        var temp264 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp265 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp264)));
                        var temp266 = ((int)((uint)(temp264)) <= (int)((uint)((uint)191U)));
                        var temp267 = ((temp265) && (temp266));
                        if (temp267)
                        {
                            var temp268 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp269 = Fun0(((ushort)((s)._0)), ((ushort)(temp268)));
                            s._0 = ((ushort)(temp269));
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
                        var temp270 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp271 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp270)));
                        var temp272 = ((int)((uint)(temp270)) <= (int)((uint)((uint)159U)));
                        var temp273 = ((temp271) && (temp272));
                        if (temp273)
                        {
                            var temp274 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp275 = Fun0(((ushort)((s)._0)), ((ushort)(temp274)));
                            s._0 = ((ushort)(temp275));
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
                        var temp276 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp277 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp276)));
                        var temp278 = ((int)((uint)(temp276)) <= (int)((uint)((uint)191U)));
                        var temp279 = ((temp277) && (temp278));
                        if (temp279)
                        {
                            var temp280 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp281 = Fun0(((ushort)((s)._0)), ((ushort)(temp280)));
                            s._0 = ((ushort)(temp281));
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
                        var temp282 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp283 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp282)));
                        var temp284 = ((int)((uint)(temp282)) <= (int)((uint)((uint)127U)));
                        var temp285 = ((temp283) && (temp284));
                        if (temp285)
                        {
                            var temp286 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp287 = ((byte)(((byte)(i)) >> 6));
                            var temp288 = (((byte)(temp287 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp289 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp290 = (((temp286) && (temp288)) && (temp289));
                            if (temp290)
                            {
                                var temp291 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp292 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp291))) + ((uint)(temp282))));
                                s._1 = ((uint)(temp292));
                                goto M31;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp293 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp282)));
                            var temp294 = ((int)((uint)(temp282)) <= (int)((uint)((uint)223U)));
                            var temp295 = ((temp293) && (temp294));
                            if (temp295)
                            {
                                var temp296 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp296));
                                goto M32;
                            }
                            else
                            {
                                var temp297 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp297)
                                {
                                    var temp298 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp298));
                                    goto M33;
                                }
                                else
                                {
                                    var temp299 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp299)
                                    {
                                        var temp300 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp300));
                                        goto M34;
                                    }
                                    else
                                    {
                                        var temp301 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp282)));
                                        var temp302 = ((int)((uint)(temp282)) <= (int)((uint)((uint)239U)));
                                        var temp303 = ((temp301) && (temp302));
                                        if (temp303)
                                        {
                                            var temp304 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp304));
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
                        var temp305 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp306 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp305)));
                        var temp307 = ((int)((uint)(temp305)) <= (int)((uint)((uint)191U)));
                        var temp308 = ((temp306) && (temp307));
                        if (temp308)
                        {
                            var temp309 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp310 = Fun0(((ushort)((s)._0)), ((ushort)(temp309)));
                            var temp311 = (((ushort)(temp310)) == ((ushort)((ushort)44U)));
                            if (temp311)
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
                        var temp312 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp313 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp312)));
                        var temp314 = ((int)((uint)(temp312)) <= (int)((uint)((uint)191U)));
                        var temp315 = ((temp313) && (temp314));
                        if (temp315)
                        {
                            var temp316 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp317 = Fun0(((ushort)((s)._0)), ((ushort)(temp316)));
                            s._0 = ((ushort)(temp317));
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
                        var temp318 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp319 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp318)));
                        var temp320 = ((int)((uint)(temp318)) <= (int)((uint)((uint)159U)));
                        var temp321 = ((temp319) && (temp320));
                        if (temp321)
                        {
                            var temp322 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp323 = Fun0(((ushort)((s)._0)), ((ushort)(temp322)));
                            s._0 = ((ushort)(temp323));
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
                        var temp324 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp325 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp324)));
                        var temp326 = ((int)((uint)(temp324)) <= (int)((uint)((uint)191U)));
                        var temp327 = ((temp325) && (temp326));
                        if (temp327)
                        {
                            var temp328 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp329 = Fun0(((ushort)((s)._0)), ((ushort)(temp328)));
                            s._0 = ((ushort)(temp329));
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
                        var temp330 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp331 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp330)));
                        var temp332 = ((int)((uint)(temp330)) <= (int)((uint)((uint)127U)));
                        var temp333 = ((temp331) && (temp332));
                        if (temp333)
                        {
                            var temp334 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp334)
                            {
                                goto M36;
                            }
                            else
                            {
                                var temp335 = (((byte)(i)) == ((byte)((byte)46U)));
                                if (temp335)
                                {
                                    goto M37;
                                }
                                else
                                {
                                    var temp336 = (((byte)((byte)48U)) <= ((byte)(i)));
                                    var temp337 = ((byte)(((byte)(i)) >> 6));
                                    var temp338 = (((byte)(temp337 & 3L)) == ((byte)((byte)0U & 3L)));
                                    var temp339 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                    var temp340 = (((temp336) && (temp338)) && (temp339));
                                    if (temp340)
                                    {
                                        var temp341 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                        var temp342 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp341))) + ((uint)(temp330))));
                                        s._1 = ((uint)(temp342));
                                        goto M31;
                                    }
                                    else
                                        throw new Exception();
                                }
                            }
                        }
                        else
                        {
                            var temp343 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp330)));
                            var temp344 = ((int)((uint)(temp330)) <= (int)((uint)((uint)223U)));
                            var temp345 = ((temp343) && (temp344));
                            if (temp345)
                            {
                                var temp346 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp346));
                                goto M38;
                            }
                            else
                            {
                                var temp347 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp347)
                                {
                                    var temp348 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp348));
                                    goto M39;
                                }
                                else
                                {
                                    var temp349 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp349)
                                    {
                                        var temp350 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp350));
                                        goto M40;
                                    }
                                    else
                                    {
                                        var temp351 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp330)));
                                        var temp352 = ((int)((uint)(temp330)) <= (int)((uint)((uint)239U)));
                                        var temp353 = ((temp351) && (temp352));
                                        if (temp353)
                                        {
                                            var temp354 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp354));
                                            goto M41;
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
                        var temp355 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp356 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp355)));
                        var temp357 = ((int)((uint)(temp355)) <= (int)((uint)((uint)191U)));
                        var temp358 = ((temp356) && (temp357));
                        if (temp358)
                        {
                            var temp359 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp360 = Fun0(((ushort)((s)._0)), ((ushort)(temp359)));
                            var temp361 = (((ushort)((ushort)48U)) <= ((ushort)(temp360)));
                            var temp362 = ((ushort)(((ushort)(temp360)) >> 6));
                            var temp363 = (((ushort)(temp362 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp364 = (((byte)(((byte)((ushort)(temp360))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp365 = (((temp361) && (temp363)) && (temp364));
                            var temp366 = (((ushort)((ushort)1632U)) <= ((ushort)(temp360)));
                            var temp367 = ((byte)(((ushort)(temp360)) >> 11));
                            var temp368 = (((byte)(temp367 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp369 = (((ushort)(((ushort)((ushort)(temp360))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp370 = (((temp366) && (temp368)) && (temp369));
                            var temp371 = (((ushort)((ushort)1776U)) <= ((ushort)(temp360)));
                            var temp372 = (((ushort)(((ushort)((ushort)(temp360))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp373 = (((temp371) && (temp368)) && (temp372));
                            var temp374 = (((ushort)((ushort)1984U)) <= ((ushort)(temp360)));
                            var temp375 = (((ushort)(((ushort)((ushort)(temp360))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp376 = (((temp374) && (temp368)) && (temp375));
                            var temp377 = (((ushort)((ushort)2406U)) <= ((ushort)(temp360)));
                            var temp378 = ((byte)(((ushort)(temp360)) >> 12));
                            var temp379 = (((byte)(temp378 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp380 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp381 = (((temp377) && (temp379)) && (temp380));
                            var temp382 = (((ushort)((ushort)2534U)) <= ((ushort)(temp360)));
                            var temp383 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp384 = (((temp382) && (temp379)) && (temp383));
                            var temp385 = (((ushort)((ushort)2662U)) <= ((ushort)(temp360)));
                            var temp386 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp387 = (((temp385) && (temp379)) && (temp386));
                            var temp388 = (((ushort)((ushort)2790U)) <= ((ushort)(temp360)));
                            var temp389 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp390 = (((temp388) && (temp379)) && (temp389));
                            var temp391 = (((ushort)((ushort)2918U)) <= ((ushort)(temp360)));
                            var temp392 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp393 = (((temp391) && (temp379)) && (temp392));
                            var temp394 = (((ushort)((ushort)3046U)) <= ((ushort)(temp360)));
                            var temp395 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp396 = (((temp394) && (temp379)) && (temp395));
                            var temp397 = (((ushort)((ushort)3174U)) <= ((ushort)(temp360)));
                            var temp398 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp399 = (((temp397) && (temp379)) && (temp398));
                            var temp400 = (((ushort)((ushort)3302U)) <= ((ushort)(temp360)));
                            var temp401 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp402 = (((temp400) && (temp379)) && (temp401));
                            var temp403 = (((ushort)((ushort)3430U)) <= ((ushort)(temp360)));
                            var temp404 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp405 = (((temp403) && (temp379)) && (temp404));
                            var temp406 = (((ushort)((ushort)3664U)) <= ((ushort)(temp360)));
                            var temp407 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp408 = (((temp406) && (temp379)) && (temp407));
                            var temp409 = (((ushort)((ushort)3792U)) <= ((ushort)(temp360)));
                            var temp410 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp411 = (((temp409) && (temp379)) && (temp410));
                            var temp412 = (((ushort)((ushort)3872U)) <= ((ushort)(temp360)));
                            var temp413 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp414 = (((temp412) && (temp379)) && (temp413));
                            var temp415 = (((ushort)((ushort)4160U)) <= ((ushort)(temp360)));
                            var temp416 = ((byte)(((ushort)(temp360)) >> 13));
                            var temp417 = (((byte)(temp416 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp418 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp419 = (((temp415) && (temp417)) && (temp418));
                            var temp420 = (((ushort)((ushort)4240U)) <= ((ushort)(temp360)));
                            var temp421 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp422 = (((temp420) && (temp417)) && (temp421));
                            var temp423 = (((ushort)((ushort)6112U)) <= ((ushort)(temp360)));
                            var temp424 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp425 = (((temp423) && (temp417)) && (temp424));
                            var temp426 = (((ushort)((ushort)6160U)) <= ((ushort)(temp360)));
                            var temp427 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp428 = (((temp426) && (temp417)) && (temp427));
                            var temp429 = (((ushort)((ushort)6470U)) <= ((ushort)(temp360)));
                            var temp430 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp431 = (((temp429) && (temp417)) && (temp430));
                            var temp432 = (((ushort)((ushort)6608U)) <= ((ushort)(temp360)));
                            var temp433 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp434 = (((temp432) && (temp417)) && (temp433));
                            var temp435 = (((ushort)((ushort)6992U)) <= ((ushort)(temp360)));
                            var temp436 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp437 = (((temp435) && (temp417)) && (temp436));
                            var temp438 = (((ushort)((ushort)7088U)) <= ((ushort)(temp360)));
                            var temp439 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp440 = (((temp438) && (temp417)) && (temp439));
                            var temp441 = (((ushort)((ushort)7232U)) <= ((ushort)(temp360)));
                            var temp442 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp443 = (((temp441) && (temp417)) && (temp442));
                            var temp444 = (((ushort)((ushort)7248U)) <= ((ushort)(temp360)));
                            var temp445 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp446 = (((temp444) && (temp417)) && (temp445));
                            var temp447 = (((ushort)((ushort)42528U)) <= ((ushort)(temp360)));
                            var temp448 = (((ushort)(temp360)) <= ((ushort)((ushort)42537U)));
                            var temp449 = ((temp447) && (temp448));
                            var temp450 = (((ushort)((ushort)43216U)) <= ((ushort)(temp360)));
                            var temp451 = (((ushort)(temp360)) <= ((ushort)((ushort)43225U)));
                            var temp452 = ((temp450) && (temp451));
                            var temp453 = (((ushort)((ushort)43264U)) <= ((ushort)(temp360)));
                            var temp454 = (((ushort)(temp360)) <= ((ushort)((ushort)43273U)));
                            var temp455 = ((temp453) && (temp454));
                            var temp456 = (((ushort)((ushort)43600U)) <= ((ushort)(temp360)));
                            var temp457 = (((ushort)(temp360)) <= ((ushort)((ushort)43609U)));
                            var temp458 = ((temp456) && (temp457));
                            var temp459 = (((ushort)((ushort)65296U)) <= ((ushort)(temp360)));
                            var temp460 = (((ushort)(temp360)) <= ((ushort)((ushort)65305U)));
                            var temp461 = ((temp459) && (temp460));
                            var temp462 = (((((((((((((((((((((((((((((((temp365) || (temp370)) || (temp373)) || (temp376)) || (temp381)) || (temp384)) || (temp387)) || (temp390)) || (temp393)) || (temp396)) || (temp399)) || (temp402)) || (temp405)) || (temp408)) || (temp411)) || (temp414)) || (temp419)) || (temp422)) || (temp425)) || (temp428)) || (temp431)) || (temp434)) || (temp437)) || (temp440)) || (temp443)) || (temp446)) || (temp449)) || (temp452)) || (temp455)) || (temp458)) || (temp461));
                            if (temp462)
                            {
                                var temp463 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp464 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp360));
                                var temp465 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp463))) + ((uint)(temp464))));
                                s._1 = ((uint)(temp465));
                                s._0 = ((ushort)((ushort)0U));
                                goto M31;
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
                        var temp466 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp467 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp466)));
                        var temp468 = ((int)((uint)(temp466)) <= (int)((uint)((uint)191U)));
                        var temp469 = ((temp467) && (temp468));
                        if (temp469)
                        {
                            var temp470 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp471 = Fun0(((ushort)((s)._0)), ((ushort)(temp470)));
                            s._0 = ((ushort)(temp471));
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
                        var temp472 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp473 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp472)));
                        var temp474 = ((int)((uint)(temp472)) <= (int)((uint)((uint)159U)));
                        var temp475 = ((temp473) && (temp474));
                        if (temp475)
                        {
                            var temp476 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp477 = Fun0(((ushort)((s)._0)), ((ushort)(temp476)));
                            s._0 = ((ushort)(temp477));
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
                        var temp478 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp479 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp478)));
                        var temp480 = ((int)((uint)(temp478)) <= (int)((uint)((uint)191U)));
                        var temp481 = ((temp479) && (temp480));
                        if (temp481)
                        {
                            var temp482 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp483 = Fun0(((ushort)((s)._0)), ((ushort)(temp482)));
                            s._0 = ((ushort)(temp483));
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
                        var temp484 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp485 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp484)));
                        var temp486 = ((int)((uint)(temp484)) <= (int)((uint)((uint)127U)));
                        var temp487 = ((temp485) && (temp486));
                        if (temp487)
                        {
                            var temp488 = (((byte)(i)) == ((byte)((byte)10U)));
                            if (temp488)
                            {
                                var temp489 = ((uint)(((uint)((uint)1U)) + ((uint)((s)._3))));
                                s._3 = ((uint)(temp489));
                                var temp490 = ((byte)(((uint)((s)._1)) >> 31));
                                var temp491 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 32) | (ulong)((uint)((s)._1));
                                var temp492 = ((ulong)(((ulong)((s)._2)) + ((ulong)(temp491))));
                                s._2 = ((ulong)(temp492));
                                s._1 = ((uint)((uint)0U));
                                goto M0;
                            }
                            else
                            {
                                goto M36;
                            }
                        }
                        else
                        {
                            var temp493 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp484)));
                            var temp494 = ((int)((uint)(temp484)) <= (int)((uint)((uint)223U)));
                            var temp495 = ((temp493) && (temp494));
                            if (temp495)
                            {
                                var temp496 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp496));
                                goto M51;
                            }
                            else
                            {
                                var temp497 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp497)
                                {
                                    var temp498 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp498));
                                    goto M52;
                                }
                                else
                                {
                                    var temp499 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp499)
                                    {
                                        var temp500 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp500));
                                        goto M53;
                                    }
                                    else
                                    {
                                        var temp501 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp484)));
                                        var temp502 = ((int)((uint)(temp484)) <= (int)((uint)((uint)239U)));
                                        var temp503 = ((temp501) && (temp502));
                                        if (temp503)
                                        {
                                            var temp504 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp504));
                                            goto M54;
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
                        var temp505 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp506 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp505)));
                        var temp507 = ((int)((uint)(temp505)) <= (int)((uint)((uint)127U)));
                        var temp508 = ((temp506) && (temp507));
                        if (temp508)
                        {
                            var temp509 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp510 = ((byte)(((byte)(i)) >> 6));
                            var temp511 = (((byte)(temp510 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp512 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp513 = (((temp509) && (temp511)) && (temp512));
                            if (temp513)
                            {
                                goto M42;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp514 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp505)));
                            var temp515 = ((int)((uint)(temp505)) <= (int)((uint)((uint)223U)));
                            var temp516 = ((temp514) && (temp515));
                            if (temp516)
                            {
                                var temp517 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp517));
                                goto M43;
                            }
                            else
                            {
                                var temp518 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp518)
                                {
                                    var temp519 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp519));
                                    goto M44;
                                }
                                else
                                {
                                    var temp520 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp520)
                                    {
                                        var temp521 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp521));
                                        goto M45;
                                    }
                                    else
                                    {
                                        var temp522 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp505)));
                                        var temp523 = ((int)((uint)(temp505)) <= (int)((uint)((uint)239U)));
                                        var temp524 = ((temp522) && (temp523));
                                        if (temp524)
                                        {
                                            var temp525 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp525));
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

                M38:
                {
                    if (!ie.MoveNext())
                        goto F38;
                    i = ie.Current;
                    {
                        var temp526 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp527 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp526)));
                        var temp528 = ((int)((uint)(temp526)) <= (int)((uint)((uint)191U)));
                        var temp529 = ((temp527) && (temp528));
                        if (temp529)
                        {
                            var temp530 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp531 = Fun0(((ushort)((s)._0)), ((ushort)(temp530)));
                            var temp532 = (((ushort)(temp531)) == ((ushort)((ushort)44U)));
                            if (temp532)
                                throw new Exception();
                            else
                            {
                                var temp533 = (((ushort)(temp531)) == ((ushort)((ushort)46U)));
                                if (temp533)
                                    throw new Exception();
                                else
                                {
                                    var temp534 = (((ushort)((ushort)48U)) <= ((ushort)(temp531)));
                                    var temp535 = ((ushort)(((ushort)(temp531)) >> 6));
                                    var temp536 = (((ushort)(temp535 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                    var temp537 = (((byte)(((byte)((ushort)(temp531))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                    var temp538 = (((temp534) && (temp536)) && (temp537));
                                    var temp539 = (((ushort)((ushort)1632U)) <= ((ushort)(temp531)));
                                    var temp540 = ((byte)(((ushort)(temp531)) >> 11));
                                    var temp541 = (((byte)(temp540 & 31L)) == ((byte)((byte)0U & 31L)));
                                    var temp542 = (((ushort)(((ushort)((ushort)(temp531))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                    var temp543 = (((temp539) && (temp541)) && (temp542));
                                    var temp544 = (((ushort)((ushort)1776U)) <= ((ushort)(temp531)));
                                    var temp545 = (((ushort)(((ushort)((ushort)(temp531))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                    var temp546 = (((temp544) && (temp541)) && (temp545));
                                    var temp547 = (((ushort)((ushort)1984U)) <= ((ushort)(temp531)));
                                    var temp548 = (((ushort)(((ushort)((ushort)(temp531))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                    var temp549 = (((temp547) && (temp541)) && (temp548));
                                    var temp550 = (((ushort)((ushort)2406U)) <= ((ushort)(temp531)));
                                    var temp551 = ((byte)(((ushort)(temp531)) >> 12));
                                    var temp552 = (((byte)(temp551 & 15L)) == ((byte)((byte)0U & 15L)));
                                    var temp553 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                    var temp554 = (((temp550) && (temp552)) && (temp553));
                                    var temp555 = (((ushort)((ushort)2534U)) <= ((ushort)(temp531)));
                                    var temp556 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                    var temp557 = (((temp555) && (temp552)) && (temp556));
                                    var temp558 = (((ushort)((ushort)2662U)) <= ((ushort)(temp531)));
                                    var temp559 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                    var temp560 = (((temp558) && (temp552)) && (temp559));
                                    var temp561 = (((ushort)((ushort)2790U)) <= ((ushort)(temp531)));
                                    var temp562 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                    var temp563 = (((temp561) && (temp552)) && (temp562));
                                    var temp564 = (((ushort)((ushort)2918U)) <= ((ushort)(temp531)));
                                    var temp565 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                    var temp566 = (((temp564) && (temp552)) && (temp565));
                                    var temp567 = (((ushort)((ushort)3046U)) <= ((ushort)(temp531)));
                                    var temp568 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                    var temp569 = (((temp567) && (temp552)) && (temp568));
                                    var temp570 = (((ushort)((ushort)3174U)) <= ((ushort)(temp531)));
                                    var temp571 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                    var temp572 = (((temp570) && (temp552)) && (temp571));
                                    var temp573 = (((ushort)((ushort)3302U)) <= ((ushort)(temp531)));
                                    var temp574 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                    var temp575 = (((temp573) && (temp552)) && (temp574));
                                    var temp576 = (((ushort)((ushort)3430U)) <= ((ushort)(temp531)));
                                    var temp577 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                    var temp578 = (((temp576) && (temp552)) && (temp577));
                                    var temp579 = (((ushort)((ushort)3664U)) <= ((ushort)(temp531)));
                                    var temp580 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                    var temp581 = (((temp579) && (temp552)) && (temp580));
                                    var temp582 = (((ushort)((ushort)3792U)) <= ((ushort)(temp531)));
                                    var temp583 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                    var temp584 = (((temp582) && (temp552)) && (temp583));
                                    var temp585 = (((ushort)((ushort)3872U)) <= ((ushort)(temp531)));
                                    var temp586 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                    var temp587 = (((temp585) && (temp552)) && (temp586));
                                    var temp588 = (((ushort)((ushort)4160U)) <= ((ushort)(temp531)));
                                    var temp589 = ((byte)(((ushort)(temp531)) >> 13));
                                    var temp590 = (((byte)(temp589 & 7L)) == ((byte)((byte)0U & 7L)));
                                    var temp591 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                    var temp592 = (((temp588) && (temp590)) && (temp591));
                                    var temp593 = (((ushort)((ushort)4240U)) <= ((ushort)(temp531)));
                                    var temp594 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                    var temp595 = (((temp593) && (temp590)) && (temp594));
                                    var temp596 = (((ushort)((ushort)6112U)) <= ((ushort)(temp531)));
                                    var temp597 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                    var temp598 = (((temp596) && (temp590)) && (temp597));
                                    var temp599 = (((ushort)((ushort)6160U)) <= ((ushort)(temp531)));
                                    var temp600 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                    var temp601 = (((temp599) && (temp590)) && (temp600));
                                    var temp602 = (((ushort)((ushort)6470U)) <= ((ushort)(temp531)));
                                    var temp603 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                    var temp604 = (((temp602) && (temp590)) && (temp603));
                                    var temp605 = (((ushort)((ushort)6608U)) <= ((ushort)(temp531)));
                                    var temp606 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                    var temp607 = (((temp605) && (temp590)) && (temp606));
                                    var temp608 = (((ushort)((ushort)6992U)) <= ((ushort)(temp531)));
                                    var temp609 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                    var temp610 = (((temp608) && (temp590)) && (temp609));
                                    var temp611 = (((ushort)((ushort)7088U)) <= ((ushort)(temp531)));
                                    var temp612 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                    var temp613 = (((temp611) && (temp590)) && (temp612));
                                    var temp614 = (((ushort)((ushort)7232U)) <= ((ushort)(temp531)));
                                    var temp615 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                    var temp616 = (((temp614) && (temp590)) && (temp615));
                                    var temp617 = (((ushort)((ushort)7248U)) <= ((ushort)(temp531)));
                                    var temp618 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                    var temp619 = (((temp617) && (temp590)) && (temp618));
                                    var temp620 = (((ushort)((ushort)42528U)) <= ((ushort)(temp531)));
                                    var temp621 = (((ushort)(temp531)) <= ((ushort)((ushort)42537U)));
                                    var temp622 = ((temp620) && (temp621));
                                    var temp623 = (((ushort)((ushort)43216U)) <= ((ushort)(temp531)));
                                    var temp624 = (((ushort)(temp531)) <= ((ushort)((ushort)43225U)));
                                    var temp625 = ((temp623) && (temp624));
                                    var temp626 = (((ushort)((ushort)43264U)) <= ((ushort)(temp531)));
                                    var temp627 = (((ushort)(temp531)) <= ((ushort)((ushort)43273U)));
                                    var temp628 = ((temp626) && (temp627));
                                    var temp629 = (((ushort)((ushort)43600U)) <= ((ushort)(temp531)));
                                    var temp630 = (((ushort)(temp531)) <= ((ushort)((ushort)43609U)));
                                    var temp631 = ((temp629) && (temp630));
                                    var temp632 = (((ushort)((ushort)65296U)) <= ((ushort)(temp531)));
                                    var temp633 = (((ushort)(temp531)) <= ((ushort)((ushort)65305U)));
                                    var temp634 = ((temp632) && (temp633));
                                    var temp635 = (((((((((((((((((((((((((((((((temp538) || (temp543)) || (temp546)) || (temp549)) || (temp554)) || (temp557)) || (temp560)) || (temp563)) || (temp566)) || (temp569)) || (temp572)) || (temp575)) || (temp578)) || (temp581)) || (temp584)) || (temp587)) || (temp592)) || (temp595)) || (temp598)) || (temp601)) || (temp604)) || (temp607)) || (temp610)) || (temp613)) || (temp616)) || (temp619)) || (temp622)) || (temp625)) || (temp628)) || (temp631)) || (temp634));
                                    if (temp635)
                                    {
                                        var temp636 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                        var temp637 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp531));
                                        var temp638 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp636))) + ((uint)(temp637))));
                                        s._1 = ((uint)(temp638));
                                        s._0 = ((ushort)((ushort)0U));
                                        goto M31;
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

                M39:
                {
                    if (!ie.MoveNext())
                        goto F39;
                    i = ie.Current;
                    {
                        var temp639 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp640 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp639)));
                        var temp641 = ((int)((uint)(temp639)) <= (int)((uint)((uint)191U)));
                        var temp642 = ((temp640) && (temp641));
                        if (temp642)
                        {
                            var temp643 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp644 = Fun0(((ushort)((s)._0)), ((ushort)(temp643)));
                            s._0 = ((ushort)(temp644));
                            goto M38;
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
                        var temp645 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp646 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp645)));
                        var temp647 = ((int)((uint)(temp645)) <= (int)((uint)((uint)159U)));
                        var temp648 = ((temp646) && (temp647));
                        if (temp648)
                        {
                            var temp649 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp650 = Fun0(((ushort)((s)._0)), ((ushort)(temp649)));
                            s._0 = ((ushort)(temp650));
                            goto M38;
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
                        var temp651 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp652 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp651)));
                        var temp653 = ((int)((uint)(temp651)) <= (int)((uint)((uint)191U)));
                        var temp654 = ((temp652) && (temp653));
                        if (temp654)
                        {
                            var temp655 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp656 = Fun0(((ushort)((s)._0)), ((ushort)(temp655)));
                            s._0 = ((ushort)(temp656));
                            goto M38;
                        }
                        else
                            throw new Exception();
                    }
                }

                M42:
                {
                    if (!ie.MoveNext())
                        goto F42;
                    i = ie.Current;
                    {
                        var temp657 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp658 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp657)));
                        var temp659 = ((int)((uint)(temp657)) <= (int)((uint)((uint)127U)));
                        var temp660 = ((temp658) && (temp659));
                        if (temp660)
                        {
                            var temp661 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp661)
                            {
                                goto M36;
                            }
                            else
                            {
                                var temp662 = (((byte)((byte)48U)) <= ((byte)(i)));
                                var temp663 = ((byte)(((byte)(i)) >> 6));
                                var temp664 = (((byte)(temp663 & 3L)) == ((byte)((byte)0U & 3L)));
                                var temp665 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp666 = (((temp662) && (temp664)) && (temp665));
                                if (temp666)
                                {
                                    goto M42;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                        else
                        {
                            var temp667 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp657)));
                            var temp668 = ((int)((uint)(temp657)) <= (int)((uint)((uint)223U)));
                            var temp669 = ((temp667) && (temp668));
                            if (temp669)
                            {
                                var temp670 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp670));
                                goto M47;
                            }
                            else
                            {
                                var temp671 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp671)
                                {
                                    var temp672 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp672));
                                    goto M48;
                                }
                                else
                                {
                                    var temp673 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp673)
                                    {
                                        var temp674 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp674));
                                        goto M49;
                                    }
                                    else
                                    {
                                        var temp675 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp657)));
                                        var temp676 = ((int)((uint)(temp657)) <= (int)((uint)((uint)239U)));
                                        var temp677 = ((temp675) && (temp676));
                                        if (temp677)
                                        {
                                            var temp678 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp678));
                                            goto M50;
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
                        var temp679 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp680 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp679)));
                        var temp681 = ((int)((uint)(temp679)) <= (int)((uint)((uint)191U)));
                        var temp682 = ((temp680) && (temp681));
                        if (temp682)
                        {
                            var temp683 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp684 = Fun0(((ushort)((s)._0)), ((ushort)(temp683)));
                            var temp685 = (((ushort)((ushort)48U)) <= ((ushort)(temp684)));
                            var temp686 = ((ushort)(((ushort)(temp684)) >> 6));
                            var temp687 = (((ushort)(temp686 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp688 = (((byte)(((byte)((ushort)(temp684))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp689 = (((temp685) && (temp687)) && (temp688));
                            var temp690 = (((ushort)((ushort)1632U)) <= ((ushort)(temp684)));
                            var temp691 = ((byte)(((ushort)(temp684)) >> 11));
                            var temp692 = (((byte)(temp691 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp693 = (((ushort)(((ushort)((ushort)(temp684))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp694 = (((temp690) && (temp692)) && (temp693));
                            var temp695 = (((ushort)((ushort)1776U)) <= ((ushort)(temp684)));
                            var temp696 = (((ushort)(((ushort)((ushort)(temp684))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp697 = (((temp695) && (temp692)) && (temp696));
                            var temp698 = (((ushort)((ushort)1984U)) <= ((ushort)(temp684)));
                            var temp699 = (((ushort)(((ushort)((ushort)(temp684))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp700 = (((temp698) && (temp692)) && (temp699));
                            var temp701 = (((ushort)((ushort)2406U)) <= ((ushort)(temp684)));
                            var temp702 = ((byte)(((ushort)(temp684)) >> 12));
                            var temp703 = (((byte)(temp702 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp704 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp705 = (((temp701) && (temp703)) && (temp704));
                            var temp706 = (((ushort)((ushort)2534U)) <= ((ushort)(temp684)));
                            var temp707 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp708 = (((temp706) && (temp703)) && (temp707));
                            var temp709 = (((ushort)((ushort)2662U)) <= ((ushort)(temp684)));
                            var temp710 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp711 = (((temp709) && (temp703)) && (temp710));
                            var temp712 = (((ushort)((ushort)2790U)) <= ((ushort)(temp684)));
                            var temp713 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp714 = (((temp712) && (temp703)) && (temp713));
                            var temp715 = (((ushort)((ushort)2918U)) <= ((ushort)(temp684)));
                            var temp716 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp717 = (((temp715) && (temp703)) && (temp716));
                            var temp718 = (((ushort)((ushort)3046U)) <= ((ushort)(temp684)));
                            var temp719 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp720 = (((temp718) && (temp703)) && (temp719));
                            var temp721 = (((ushort)((ushort)3174U)) <= ((ushort)(temp684)));
                            var temp722 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp723 = (((temp721) && (temp703)) && (temp722));
                            var temp724 = (((ushort)((ushort)3302U)) <= ((ushort)(temp684)));
                            var temp725 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp726 = (((temp724) && (temp703)) && (temp725));
                            var temp727 = (((ushort)((ushort)3430U)) <= ((ushort)(temp684)));
                            var temp728 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp729 = (((temp727) && (temp703)) && (temp728));
                            var temp730 = (((ushort)((ushort)3664U)) <= ((ushort)(temp684)));
                            var temp731 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp732 = (((temp730) && (temp703)) && (temp731));
                            var temp733 = (((ushort)((ushort)3792U)) <= ((ushort)(temp684)));
                            var temp734 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp735 = (((temp733) && (temp703)) && (temp734));
                            var temp736 = (((ushort)((ushort)3872U)) <= ((ushort)(temp684)));
                            var temp737 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp738 = (((temp736) && (temp703)) && (temp737));
                            var temp739 = (((ushort)((ushort)4160U)) <= ((ushort)(temp684)));
                            var temp740 = ((byte)(((ushort)(temp684)) >> 13));
                            var temp741 = (((byte)(temp740 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp742 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp743 = (((temp739) && (temp741)) && (temp742));
                            var temp744 = (((ushort)((ushort)4240U)) <= ((ushort)(temp684)));
                            var temp745 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp746 = (((temp744) && (temp741)) && (temp745));
                            var temp747 = (((ushort)((ushort)6112U)) <= ((ushort)(temp684)));
                            var temp748 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp749 = (((temp747) && (temp741)) && (temp748));
                            var temp750 = (((ushort)((ushort)6160U)) <= ((ushort)(temp684)));
                            var temp751 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp752 = (((temp750) && (temp741)) && (temp751));
                            var temp753 = (((ushort)((ushort)6470U)) <= ((ushort)(temp684)));
                            var temp754 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp755 = (((temp753) && (temp741)) && (temp754));
                            var temp756 = (((ushort)((ushort)6608U)) <= ((ushort)(temp684)));
                            var temp757 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp758 = (((temp756) && (temp741)) && (temp757));
                            var temp759 = (((ushort)((ushort)6992U)) <= ((ushort)(temp684)));
                            var temp760 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp761 = (((temp759) && (temp741)) && (temp760));
                            var temp762 = (((ushort)((ushort)7088U)) <= ((ushort)(temp684)));
                            var temp763 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp764 = (((temp762) && (temp741)) && (temp763));
                            var temp765 = (((ushort)((ushort)7232U)) <= ((ushort)(temp684)));
                            var temp766 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp767 = (((temp765) && (temp741)) && (temp766));
                            var temp768 = (((ushort)((ushort)7248U)) <= ((ushort)(temp684)));
                            var temp769 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp770 = (((temp768) && (temp741)) && (temp769));
                            var temp771 = (((ushort)((ushort)42528U)) <= ((ushort)(temp684)));
                            var temp772 = (((ushort)(temp684)) <= ((ushort)((ushort)42537U)));
                            var temp773 = ((temp771) && (temp772));
                            var temp774 = (((ushort)((ushort)43216U)) <= ((ushort)(temp684)));
                            var temp775 = (((ushort)(temp684)) <= ((ushort)((ushort)43225U)));
                            var temp776 = ((temp774) && (temp775));
                            var temp777 = (((ushort)((ushort)43264U)) <= ((ushort)(temp684)));
                            var temp778 = (((ushort)(temp684)) <= ((ushort)((ushort)43273U)));
                            var temp779 = ((temp777) && (temp778));
                            var temp780 = (((ushort)((ushort)43600U)) <= ((ushort)(temp684)));
                            var temp781 = (((ushort)(temp684)) <= ((ushort)((ushort)43609U)));
                            var temp782 = ((temp780) && (temp781));
                            var temp783 = (((ushort)((ushort)65296U)) <= ((ushort)(temp684)));
                            var temp784 = (((ushort)(temp684)) <= ((ushort)((ushort)65305U)));
                            var temp785 = ((temp783) && (temp784));
                            var temp786 = (((((((((((((((((((((((((((((((temp689) || (temp694)) || (temp697)) || (temp700)) || (temp705)) || (temp708)) || (temp711)) || (temp714)) || (temp717)) || (temp720)) || (temp723)) || (temp726)) || (temp729)) || (temp732)) || (temp735)) || (temp738)) || (temp743)) || (temp746)) || (temp749)) || (temp752)) || (temp755)) || (temp758)) || (temp761)) || (temp764)) || (temp767)) || (temp770)) || (temp773)) || (temp776)) || (temp779)) || (temp782)) || (temp785));
                            if (temp786)
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M42;
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
                        var temp787 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp788 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp787)));
                        var temp789 = ((int)((uint)(temp787)) <= (int)((uint)((uint)191U)));
                        var temp790 = ((temp788) && (temp789));
                        if (temp790)
                        {
                            var temp791 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp792 = Fun0(((ushort)((s)._0)), ((ushort)(temp791)));
                            s._0 = ((ushort)(temp792));
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
                        var temp793 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp794 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp793)));
                        var temp795 = ((int)((uint)(temp793)) <= (int)((uint)((uint)159U)));
                        var temp796 = ((temp794) && (temp795));
                        if (temp796)
                        {
                            var temp797 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp798 = Fun0(((ushort)((s)._0)), ((ushort)(temp797)));
                            s._0 = ((ushort)(temp798));
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
                        var temp799 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp800 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp799)));
                        var temp801 = ((int)((uint)(temp799)) <= (int)((uint)((uint)191U)));
                        var temp802 = ((temp800) && (temp801));
                        if (temp802)
                        {
                            var temp803 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp804 = Fun0(((ushort)((s)._0)), ((ushort)(temp803)));
                            s._0 = ((ushort)(temp804));
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
                        var temp805 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp806 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp805)));
                        var temp807 = ((int)((uint)(temp805)) <= (int)((uint)((uint)191U)));
                        var temp808 = ((temp806) && (temp807));
                        if (temp808)
                        {
                            var temp809 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp810 = Fun0(((ushort)((s)._0)), ((ushort)(temp809)));
                            var temp811 = (((ushort)(temp810)) == ((ushort)((ushort)44U)));
                            if (temp811)
                                throw new Exception();
                            else
                            {
                                var temp812 = (((ushort)((ushort)48U)) <= ((ushort)(temp810)));
                                var temp813 = ((ushort)(((ushort)(temp810)) >> 6));
                                var temp814 = (((ushort)(temp813 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                var temp815 = (((byte)(((byte)((ushort)(temp810))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp816 = (((temp812) && (temp814)) && (temp815));
                                var temp817 = (((ushort)((ushort)1632U)) <= ((ushort)(temp810)));
                                var temp818 = ((byte)(((ushort)(temp810)) >> 11));
                                var temp819 = (((byte)(temp818 & 31L)) == ((byte)((byte)0U & 31L)));
                                var temp820 = (((ushort)(((ushort)((ushort)(temp810))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                var temp821 = (((temp817) && (temp819)) && (temp820));
                                var temp822 = (((ushort)((ushort)1776U)) <= ((ushort)(temp810)));
                                var temp823 = (((ushort)(((ushort)((ushort)(temp810))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                var temp824 = (((temp822) && (temp819)) && (temp823));
                                var temp825 = (((ushort)((ushort)1984U)) <= ((ushort)(temp810)));
                                var temp826 = (((ushort)(((ushort)((ushort)(temp810))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                var temp827 = (((temp825) && (temp819)) && (temp826));
                                var temp828 = (((ushort)((ushort)2406U)) <= ((ushort)(temp810)));
                                var temp829 = ((byte)(((ushort)(temp810)) >> 12));
                                var temp830 = (((byte)(temp829 & 15L)) == ((byte)((byte)0U & 15L)));
                                var temp831 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                var temp832 = (((temp828) && (temp830)) && (temp831));
                                var temp833 = (((ushort)((ushort)2534U)) <= ((ushort)(temp810)));
                                var temp834 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                var temp835 = (((temp833) && (temp830)) && (temp834));
                                var temp836 = (((ushort)((ushort)2662U)) <= ((ushort)(temp810)));
                                var temp837 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                var temp838 = (((temp836) && (temp830)) && (temp837));
                                var temp839 = (((ushort)((ushort)2790U)) <= ((ushort)(temp810)));
                                var temp840 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                var temp841 = (((temp839) && (temp830)) && (temp840));
                                var temp842 = (((ushort)((ushort)2918U)) <= ((ushort)(temp810)));
                                var temp843 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                var temp844 = (((temp842) && (temp830)) && (temp843));
                                var temp845 = (((ushort)((ushort)3046U)) <= ((ushort)(temp810)));
                                var temp846 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                var temp847 = (((temp845) && (temp830)) && (temp846));
                                var temp848 = (((ushort)((ushort)3174U)) <= ((ushort)(temp810)));
                                var temp849 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                var temp850 = (((temp848) && (temp830)) && (temp849));
                                var temp851 = (((ushort)((ushort)3302U)) <= ((ushort)(temp810)));
                                var temp852 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                var temp853 = (((temp851) && (temp830)) && (temp852));
                                var temp854 = (((ushort)((ushort)3430U)) <= ((ushort)(temp810)));
                                var temp855 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                var temp856 = (((temp854) && (temp830)) && (temp855));
                                var temp857 = (((ushort)((ushort)3664U)) <= ((ushort)(temp810)));
                                var temp858 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                var temp859 = (((temp857) && (temp830)) && (temp858));
                                var temp860 = (((ushort)((ushort)3792U)) <= ((ushort)(temp810)));
                                var temp861 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                var temp862 = (((temp860) && (temp830)) && (temp861));
                                var temp863 = (((ushort)((ushort)3872U)) <= ((ushort)(temp810)));
                                var temp864 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                var temp865 = (((temp863) && (temp830)) && (temp864));
                                var temp866 = (((ushort)((ushort)4160U)) <= ((ushort)(temp810)));
                                var temp867 = ((byte)(((ushort)(temp810)) >> 13));
                                var temp868 = (((byte)(temp867 & 7L)) == ((byte)((byte)0U & 7L)));
                                var temp869 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                var temp870 = (((temp866) && (temp868)) && (temp869));
                                var temp871 = (((ushort)((ushort)4240U)) <= ((ushort)(temp810)));
                                var temp872 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                var temp873 = (((temp871) && (temp868)) && (temp872));
                                var temp874 = (((ushort)((ushort)6112U)) <= ((ushort)(temp810)));
                                var temp875 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                var temp876 = (((temp874) && (temp868)) && (temp875));
                                var temp877 = (((ushort)((ushort)6160U)) <= ((ushort)(temp810)));
                                var temp878 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                var temp879 = (((temp877) && (temp868)) && (temp878));
                                var temp880 = (((ushort)((ushort)6470U)) <= ((ushort)(temp810)));
                                var temp881 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                var temp882 = (((temp880) && (temp868)) && (temp881));
                                var temp883 = (((ushort)((ushort)6608U)) <= ((ushort)(temp810)));
                                var temp884 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                var temp885 = (((temp883) && (temp868)) && (temp884));
                                var temp886 = (((ushort)((ushort)6992U)) <= ((ushort)(temp810)));
                                var temp887 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                var temp888 = (((temp886) && (temp868)) && (temp887));
                                var temp889 = (((ushort)((ushort)7088U)) <= ((ushort)(temp810)));
                                var temp890 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                var temp891 = (((temp889) && (temp868)) && (temp890));
                                var temp892 = (((ushort)((ushort)7232U)) <= ((ushort)(temp810)));
                                var temp893 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                var temp894 = (((temp892) && (temp868)) && (temp893));
                                var temp895 = (((ushort)((ushort)7248U)) <= ((ushort)(temp810)));
                                var temp896 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                var temp897 = (((temp895) && (temp868)) && (temp896));
                                var temp898 = (((ushort)((ushort)42528U)) <= ((ushort)(temp810)));
                                var temp899 = (((ushort)(temp810)) <= ((ushort)((ushort)42537U)));
                                var temp900 = ((temp898) && (temp899));
                                var temp901 = (((ushort)((ushort)43216U)) <= ((ushort)(temp810)));
                                var temp902 = (((ushort)(temp810)) <= ((ushort)((ushort)43225U)));
                                var temp903 = ((temp901) && (temp902));
                                var temp904 = (((ushort)((ushort)43264U)) <= ((ushort)(temp810)));
                                var temp905 = (((ushort)(temp810)) <= ((ushort)((ushort)43273U)));
                                var temp906 = ((temp904) && (temp905));
                                var temp907 = (((ushort)((ushort)43600U)) <= ((ushort)(temp810)));
                                var temp908 = (((ushort)(temp810)) <= ((ushort)((ushort)43609U)));
                                var temp909 = ((temp907) && (temp908));
                                var temp910 = (((ushort)((ushort)65296U)) <= ((ushort)(temp810)));
                                var temp911 = (((ushort)(temp810)) <= ((ushort)((ushort)65305U)));
                                var temp912 = ((temp910) && (temp911));
                                var temp913 = (((((((((((((((((((((((((((((((temp816) || (temp821)) || (temp824)) || (temp827)) || (temp832)) || (temp835)) || (temp838)) || (temp841)) || (temp844)) || (temp847)) || (temp850)) || (temp853)) || (temp856)) || (temp859)) || (temp862)) || (temp865)) || (temp870)) || (temp873)) || (temp876)) || (temp879)) || (temp882)) || (temp885)) || (temp888)) || (temp891)) || (temp894)) || (temp897)) || (temp900)) || (temp903)) || (temp906)) || (temp909)) || (temp912));
                                if (temp913)
                                {
                                    s._0 = ((ushort)((ushort)0U));
                                    goto M42;
                                }
                                else
                                    throw new Exception();
                            }
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
                        var temp914 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp915 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp914)));
                        var temp916 = ((int)((uint)(temp914)) <= (int)((uint)((uint)191U)));
                        var temp917 = ((temp915) && (temp916));
                        if (temp917)
                        {
                            var temp918 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp919 = Fun0(((ushort)((s)._0)), ((ushort)(temp918)));
                            s._0 = ((ushort)(temp919));
                            goto M47;
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
                        var temp920 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp921 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp920)));
                        var temp922 = ((int)((uint)(temp920)) <= (int)((uint)((uint)159U)));
                        var temp923 = ((temp921) && (temp922));
                        if (temp923)
                        {
                            var temp924 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp925 = Fun0(((ushort)((s)._0)), ((ushort)(temp924)));
                            s._0 = ((ushort)(temp925));
                            goto M47;
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
                        var temp926 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp927 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp926)));
                        var temp928 = ((int)((uint)(temp926)) <= (int)((uint)((uint)191U)));
                        var temp929 = ((temp927) && (temp928));
                        if (temp929)
                        {
                            var temp930 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp931 = Fun0(((ushort)((s)._0)), ((ushort)(temp930)));
                            s._0 = ((ushort)(temp931));
                            goto M47;
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
                        var temp932 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp933 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp932)));
                        var temp934 = ((int)((uint)(temp932)) <= (int)((uint)((uint)191U)));
                        var temp935 = ((temp933) && (temp934));
                        if (temp935)
                        {
                            var temp936 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp937 = Fun0(((ushort)((s)._0)), ((ushort)(temp936)));
                            var temp938 = (((ushort)(temp937)) == ((ushort)((ushort)10U)));
                            if (temp938)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M36;
                            }
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
                        var temp939 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp940 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp939)));
                        var temp941 = ((int)((uint)(temp939)) <= (int)((uint)((uint)191U)));
                        var temp942 = ((temp940) && (temp941));
                        if (temp942)
                        {
                            var temp943 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp944 = Fun0(((ushort)((s)._0)), ((ushort)(temp943)));
                            s._0 = ((ushort)(temp944));
                            goto M51;
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
                        var temp945 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp946 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp945)));
                        var temp947 = ((int)((uint)(temp945)) <= (int)((uint)((uint)159U)));
                        var temp948 = ((temp946) && (temp947));
                        if (temp948)
                        {
                            var temp949 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp950 = Fun0(((ushort)((s)._0)), ((ushort)(temp949)));
                            s._0 = ((ushort)(temp950));
                            goto M51;
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
                        var temp951 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp952 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp951)));
                        var temp953 = ((int)((uint)(temp951)) <= (int)((uint)((uint)191U)));
                        var temp954 = ((temp952) && (temp953));
                        if (temp954)
                        {
                            var temp955 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp956 = Fun0(((ushort)((s)._0)), ((ushort)(temp955)));
                            s._0 = ((ushort)(temp956));
                            goto M51;
                        }
                        else
                            throw new Exception();
                    }
                }

                F0:
                {
                    var temp0 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp0)
                    {
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield break;
                    }
                    else
                    {
                        var temp1 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp2 = (((byte)(temp1 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp3 = ((temp0) && (temp2));
                        var temp4 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp5 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp4))));
                        var temp6 = ((temp3) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp5))))));
                        var temp7 = ((uint)(((int)((uint)(temp6))) >> (int)((uint)((uint)24U))));
                        yield return (Byte)(((byte)((uint)(temp7))));
                        var temp8 = ((uint)(((int)((uint)(temp6))) >> (int)((uint)((uint)16U))));
                        yield return (Byte)(((byte)((uint)(temp8))));
                        var temp9 = ((uint)(((int)((uint)(temp6))) >> (int)((uint)((uint)8U))));
                        yield return (Byte)(((byte)((uint)(temp9))));
                        var temp10 = ((temp3) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp5))))));
                        yield return (Byte)(temp10);
                        yield break;
                    }
                }

                F1:
                    throw new Exception();
                F2:
                {
                    var temp45 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp45)
                    {
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield break;
                    }
                    else
                    {
                        var temp46 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp47 = (((byte)(temp46 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp48 = ((temp45) && (temp47));
                        var temp49 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp50 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp49))));
                        var temp51 = ((temp48) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp50))))));
                        var temp52 = ((uint)(((int)((uint)(temp51))) >> (int)((uint)((uint)24U))));
                        yield return (Byte)(((byte)((uint)(temp52))));
                        var temp53 = ((uint)(((int)((uint)(temp51))) >> (int)((uint)((uint)16U))));
                        yield return (Byte)(((byte)((uint)(temp53))));
                        var temp54 = ((uint)(((int)((uint)(temp51))) >> (int)((uint)((uint)8U))));
                        yield return (Byte)(((byte)((uint)(temp54))));
                        var temp55 = ((temp48) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp50))))));
                        yield return (Byte)(temp55);
                        yield break;
                    }
                }

                F3:
                {
                    var temp63 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp63)
                    {
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield break;
                    }
                    else
                    {
                        var temp64 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp65 = (((byte)(temp64 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp66 = ((temp63) && (temp65));
                        var temp67 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp68 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp67))));
                        var temp69 = ((temp66) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp68))))));
                        var temp70 = ((uint)(((int)((uint)(temp69))) >> (int)((uint)((uint)24U))));
                        yield return (Byte)(((byte)((uint)(temp70))));
                        var temp71 = ((uint)(((int)((uint)(temp69))) >> (int)((uint)((uint)16U))));
                        yield return (Byte)(((byte)((uint)(temp71))));
                        var temp72 = ((uint)(((int)((uint)(temp69))) >> (int)((uint)((uint)8U))));
                        yield return (Byte)(((byte)((uint)(temp72))));
                        var temp73 = ((temp66) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp68))))));
                        yield return (Byte)(temp73);
                        yield break;
                    }
                }

                F4:
                {
                    var temp80 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp80)
                    {
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield break;
                    }
                    else
                    {
                        var temp81 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp82 = (((byte)(temp81 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp83 = ((temp80) && (temp82));
                        var temp84 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp85 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp84))));
                        var temp86 = ((temp83) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp85))))));
                        var temp87 = ((uint)(((int)((uint)(temp86))) >> (int)((uint)((uint)24U))));
                        yield return (Byte)(((byte)((uint)(temp87))));
                        var temp88 = ((uint)(((int)((uint)(temp86))) >> (int)((uint)((uint)16U))));
                        yield return (Byte)(((byte)((uint)(temp88))));
                        var temp89 = ((uint)(((int)((uint)(temp86))) >> (int)((uint)((uint)8U))));
                        yield return (Byte)(((byte)((uint)(temp89))));
                        var temp90 = ((temp83) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp85))))));
                        yield return (Byte)(temp90);
                        yield break;
                    }
                }

                F5:
                {
                    var temp97 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp97)
                    {
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield break;
                    }
                    else
                    {
                        var temp98 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp99 = (((byte)(temp98 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp100 = ((temp97) && (temp99));
                        var temp101 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp102 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp101))));
                        var temp103 = ((temp100) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp102))))));
                        var temp104 = ((uint)(((int)((uint)(temp103))) >> (int)((uint)((uint)24U))));
                        yield return (Byte)(((byte)((uint)(temp104))));
                        var temp105 = ((uint)(((int)((uint)(temp103))) >> (int)((uint)((uint)16U))));
                        yield return (Byte)(((byte)((uint)(temp105))));
                        var temp106 = ((uint)(((int)((uint)(temp103))) >> (int)((uint)((uint)8U))));
                        yield return (Byte)(((byte)((uint)(temp106))));
                        var temp107 = ((temp100) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp102))))));
                        yield return (Byte)(temp107);
                        yield break;
                    }
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
            }
        }

        struct DTStruct38
        {
            public UInt16 _0;
            public UInt32 _1;
            public UInt64 _2;
            public UInt32 _3;
            public DTStruct38(UInt16 v0, UInt32 v1, UInt64 v2, UInt32 v3)
            {
                _0 = v0;
                _1 = v1;
                _2 = v2;
                _3 = v3;
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
                DTStruct38 s = new DTStruct38(((ushort)((ushort)0U)), ((uint)((uint)0U)), ((ulong)((ulong)0UL)), ((uint)((uint)0U)));
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
                        var temp11 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp12 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp11)));
                        var temp13 = ((int)((uint)(temp11)) <= (int)((uint)((uint)127U)));
                        var temp14 = ((temp12) && (temp13));
                        if (temp14)
                        {
                            var temp15 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp15)
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
                            var temp16 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp11)));
                            var temp17 = ((int)((uint)(temp11)) <= (int)((uint)((uint)223U)));
                            var temp18 = ((temp16) && (temp17));
                            if (temp18)
                            {
                                var temp19 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp19));
                                goto M2;
                            }
                            else
                            {
                                var temp20 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp20)
                                {
                                    var temp21 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp21));
                                    goto M3;
                                }
                                else
                                {
                                    var temp22 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp22)
                                    {
                                        var temp23 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp23));
                                        goto M4;
                                    }
                                    else
                                    {
                                        var temp24 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp11)));
                                        var temp25 = ((int)((uint)(temp11)) <= (int)((uint)((uint)239U)));
                                        var temp26 = ((temp24) && (temp25));
                                        if (temp26)
                                        {
                                            var temp27 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp27));
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
                        var temp28 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp29 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp28)));
                        var temp30 = ((int)((uint)(temp28)) <= (int)((uint)((uint)127U)));
                        var temp31 = ((temp29) && (temp30));
                        if (temp31)
                        {
                            var temp32 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp32)
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
                            var temp33 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp28)));
                            var temp34 = ((int)((uint)(temp28)) <= (int)((uint)((uint)223U)));
                            var temp35 = ((temp33) && (temp34));
                            if (temp35)
                            {
                                var temp36 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp36));
                                goto M7;
                            }
                            else
                            {
                                var temp37 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp37)
                                {
                                    var temp38 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp38));
                                    goto M8;
                                }
                                else
                                {
                                    var temp39 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp39)
                                    {
                                        var temp40 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp40));
                                        goto M9;
                                    }
                                    else
                                    {
                                        var temp41 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp28)));
                                        var temp42 = ((int)((uint)(temp28)) <= (int)((uint)((uint)239U)));
                                        var temp43 = ((temp41) && (temp42));
                                        if (temp43)
                                        {
                                            var temp44 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp44));
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
                        var temp56 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp57 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp56)));
                        var temp58 = ((int)((uint)(temp56)) <= (int)((uint)((uint)191U)));
                        var temp59 = ((temp57) && (temp58));
                        if (temp59)
                        {
                            var temp60 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp61 = Fun0(((ushort)((s)._0)), ((ushort)(temp60)));
                            var temp62 = (((ushort)(temp61)) == ((ushort)((ushort)44U)));
                            if (temp62)
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
                        var temp74 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp75 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp74)));
                        var temp76 = ((int)((uint)(temp74)) <= (int)((uint)((uint)191U)));
                        var temp77 = ((temp75) && (temp76));
                        if (temp77)
                        {
                            var temp78 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp79 = Fun0(((ushort)((s)._0)), ((ushort)(temp78)));
                            s._0 = ((ushort)(temp79));
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
                        var temp91 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp92 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp91)));
                        var temp93 = ((int)((uint)(temp91)) <= (int)((uint)((uint)159U)));
                        var temp94 = ((temp92) && (temp93));
                        if (temp94)
                        {
                            var temp95 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp96 = Fun0(((ushort)((s)._0)), ((ushort)(temp95)));
                            s._0 = ((ushort)(temp96));
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
                        var temp108 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp109 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp108)));
                        var temp110 = ((int)((uint)(temp108)) <= (int)((uint)((uint)191U)));
                        var temp111 = ((temp109) && (temp110));
                        if (temp111)
                        {
                            var temp112 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp113 = Fun0(((ushort)((s)._0)), ((ushort)(temp112)));
                            s._0 = ((ushort)(temp113));
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
                        var temp114 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp115 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp114)));
                        var temp116 = ((int)((uint)(temp114)) <= (int)((uint)((uint)127U)));
                        var temp117 = ((temp115) && (temp116));
                        if (temp117)
                        {
                            var temp118 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp118)
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
                            var temp119 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp114)));
                            var temp120 = ((int)((uint)(temp114)) <= (int)((uint)((uint)223U)));
                            var temp121 = ((temp119) && (temp120));
                            if (temp121)
                            {
                                var temp122 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp122));
                                goto M12;
                            }
                            else
                            {
                                var temp123 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp123)
                                {
                                    var temp124 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp124));
                                    goto M13;
                                }
                                else
                                {
                                    var temp125 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp125)
                                    {
                                        var temp126 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp126));
                                        goto M14;
                                    }
                                    else
                                    {
                                        var temp127 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp114)));
                                        var temp128 = ((int)((uint)(temp114)) <= (int)((uint)((uint)239U)));
                                        var temp129 = ((temp127) && (temp128));
                                        if (temp129)
                                        {
                                            var temp130 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp130));
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
                        var temp131 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp132 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp131)));
                        var temp133 = ((int)((uint)(temp131)) <= (int)((uint)((uint)191U)));
                        var temp134 = ((temp132) && (temp133));
                        if (temp134)
                        {
                            var temp135 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp136 = Fun0(((ushort)((s)._0)), ((ushort)(temp135)));
                            var temp137 = (((ushort)(temp136)) == ((ushort)((ushort)44U)));
                            if (temp137)
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
                        var temp138 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp139 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp138)));
                        var temp140 = ((int)((uint)(temp138)) <= (int)((uint)((uint)191U)));
                        var temp141 = ((temp139) && (temp140));
                        if (temp141)
                        {
                            var temp142 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp143 = Fun0(((ushort)((s)._0)), ((ushort)(temp142)));
                            s._0 = ((ushort)(temp143));
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
                        var temp144 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp145 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp144)));
                        var temp146 = ((int)((uint)(temp144)) <= (int)((uint)((uint)159U)));
                        var temp147 = ((temp145) && (temp146));
                        if (temp147)
                        {
                            var temp148 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp149 = Fun0(((ushort)((s)._0)), ((ushort)(temp148)));
                            s._0 = ((ushort)(temp149));
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
                        var temp150 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp151 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp150)));
                        var temp152 = ((int)((uint)(temp150)) <= (int)((uint)((uint)191U)));
                        var temp153 = ((temp151) && (temp152));
                        if (temp153)
                        {
                            var temp154 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp155 = Fun0(((ushort)((s)._0)), ((ushort)(temp154)));
                            s._0 = ((ushort)(temp155));
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
                        var temp156 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp157 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp156)));
                        var temp158 = ((int)((uint)(temp156)) <= (int)((uint)((uint)127U)));
                        var temp159 = ((temp157) && (temp158));
                        if (temp159)
                        {
                            var temp160 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp160)
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
                            var temp161 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp156)));
                            var temp162 = ((int)((uint)(temp156)) <= (int)((uint)((uint)223U)));
                            var temp163 = ((temp161) && (temp162));
                            if (temp163)
                            {
                                var temp164 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp164));
                                goto M17;
                            }
                            else
                            {
                                var temp165 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp165)
                                {
                                    var temp166 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp166));
                                    goto M18;
                                }
                                else
                                {
                                    var temp167 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp167)
                                    {
                                        var temp168 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp168));
                                        goto M19;
                                    }
                                    else
                                    {
                                        var temp169 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp156)));
                                        var temp170 = ((int)((uint)(temp156)) <= (int)((uint)((uint)239U)));
                                        var temp171 = ((temp169) && (temp170));
                                        if (temp171)
                                        {
                                            var temp172 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp172));
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
                        var temp173 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp174 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp173)));
                        var temp175 = ((int)((uint)(temp173)) <= (int)((uint)((uint)191U)));
                        var temp176 = ((temp174) && (temp175));
                        if (temp176)
                        {
                            var temp177 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp178 = Fun0(((ushort)((s)._0)), ((ushort)(temp177)));
                            var temp179 = (((ushort)(temp178)) == ((ushort)((ushort)44U)));
                            if (temp179)
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
                        var temp180 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp181 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp180)));
                        var temp182 = ((int)((uint)(temp180)) <= (int)((uint)((uint)191U)));
                        var temp183 = ((temp181) && (temp182));
                        if (temp183)
                        {
                            var temp184 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp185 = Fun0(((ushort)((s)._0)), ((ushort)(temp184)));
                            s._0 = ((ushort)(temp185));
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
                        var temp186 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp187 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp186)));
                        var temp188 = ((int)((uint)(temp186)) <= (int)((uint)((uint)159U)));
                        var temp189 = ((temp187) && (temp188));
                        if (temp189)
                        {
                            var temp190 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp191 = Fun0(((ushort)((s)._0)), ((ushort)(temp190)));
                            s._0 = ((ushort)(temp191));
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
                        var temp192 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp193 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp192)));
                        var temp194 = ((int)((uint)(temp192)) <= (int)((uint)((uint)191U)));
                        var temp195 = ((temp193) && (temp194));
                        if (temp195)
                        {
                            var temp196 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp197 = Fun0(((ushort)((s)._0)), ((ushort)(temp196)));
                            s._0 = ((ushort)(temp197));
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
                        var temp198 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp199 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp198)));
                        var temp200 = ((int)((uint)(temp198)) <= (int)((uint)((uint)127U)));
                        var temp201 = ((temp199) && (temp200));
                        if (temp201)
                        {
                            var temp202 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp202)
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
                            var temp203 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp198)));
                            var temp204 = ((int)((uint)(temp198)) <= (int)((uint)((uint)223U)));
                            var temp205 = ((temp203) && (temp204));
                            if (temp205)
                            {
                                var temp206 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp206));
                                goto M22;
                            }
                            else
                            {
                                var temp207 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp207)
                                {
                                    var temp208 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp208));
                                    goto M23;
                                }
                                else
                                {
                                    var temp209 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp209)
                                    {
                                        var temp210 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp210));
                                        goto M24;
                                    }
                                    else
                                    {
                                        var temp211 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp198)));
                                        var temp212 = ((int)((uint)(temp198)) <= (int)((uint)((uint)239U)));
                                        var temp213 = ((temp211) && (temp212));
                                        if (temp213)
                                        {
                                            var temp214 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp214));
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
                        var temp215 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp216 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp215)));
                        var temp217 = ((int)((uint)(temp215)) <= (int)((uint)((uint)191U)));
                        var temp218 = ((temp216) && (temp217));
                        if (temp218)
                        {
                            var temp219 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp220 = Fun0(((ushort)((s)._0)), ((ushort)(temp219)));
                            var temp221 = (((ushort)(temp220)) == ((ushort)((ushort)44U)));
                            if (temp221)
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
                        var temp222 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp223 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp222)));
                        var temp224 = ((int)((uint)(temp222)) <= (int)((uint)((uint)191U)));
                        var temp225 = ((temp223) && (temp224));
                        if (temp225)
                        {
                            var temp226 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp227 = Fun0(((ushort)((s)._0)), ((ushort)(temp226)));
                            s._0 = ((ushort)(temp227));
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
                        var temp228 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp229 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp228)));
                        var temp230 = ((int)((uint)(temp228)) <= (int)((uint)((uint)159U)));
                        var temp231 = ((temp229) && (temp230));
                        if (temp231)
                        {
                            var temp232 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp233 = Fun0(((ushort)((s)._0)), ((ushort)(temp232)));
                            s._0 = ((ushort)(temp233));
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
                        var temp234 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp235 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp234)));
                        var temp236 = ((int)((uint)(temp234)) <= (int)((uint)((uint)191U)));
                        var temp237 = ((temp235) && (temp236));
                        if (temp237)
                        {
                            var temp238 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp239 = Fun0(((ushort)((s)._0)), ((ushort)(temp238)));
                            s._0 = ((ushort)(temp239));
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
                        var temp240 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp241 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp240)));
                        var temp242 = ((int)((uint)(temp240)) <= (int)((uint)((uint)127U)));
                        var temp243 = ((temp241) && (temp242));
                        if (temp243)
                        {
                            var temp244 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp244)
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
                            var temp245 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp240)));
                            var temp246 = ((int)((uint)(temp240)) <= (int)((uint)((uint)223U)));
                            var temp247 = ((temp245) && (temp246));
                            if (temp247)
                            {
                                var temp248 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp248));
                                goto M27;
                            }
                            else
                            {
                                var temp249 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp249)
                                {
                                    var temp250 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp250));
                                    goto M28;
                                }
                                else
                                {
                                    var temp251 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp251)
                                    {
                                        var temp252 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp252));
                                        goto M29;
                                    }
                                    else
                                    {
                                        var temp253 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp240)));
                                        var temp254 = ((int)((uint)(temp240)) <= (int)((uint)((uint)239U)));
                                        var temp255 = ((temp253) && (temp254));
                                        if (temp255)
                                        {
                                            var temp256 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp256));
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
                        var temp257 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp258 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp257)));
                        var temp259 = ((int)((uint)(temp257)) <= (int)((uint)((uint)191U)));
                        var temp260 = ((temp258) && (temp259));
                        if (temp260)
                        {
                            var temp261 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp262 = Fun0(((ushort)((s)._0)), ((ushort)(temp261)));
                            var temp263 = (((ushort)(temp262)) == ((ushort)((ushort)44U)));
                            if (temp263)
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
                        var temp264 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp265 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp264)));
                        var temp266 = ((int)((uint)(temp264)) <= (int)((uint)((uint)191U)));
                        var temp267 = ((temp265) && (temp266));
                        if (temp267)
                        {
                            var temp268 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp269 = Fun0(((ushort)((s)._0)), ((ushort)(temp268)));
                            s._0 = ((ushort)(temp269));
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
                        var temp270 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp271 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp270)));
                        var temp272 = ((int)((uint)(temp270)) <= (int)((uint)((uint)159U)));
                        var temp273 = ((temp271) && (temp272));
                        if (temp273)
                        {
                            var temp274 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp275 = Fun0(((ushort)((s)._0)), ((ushort)(temp274)));
                            s._0 = ((ushort)(temp275));
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
                        var temp276 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp277 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp276)));
                        var temp278 = ((int)((uint)(temp276)) <= (int)((uint)((uint)191U)));
                        var temp279 = ((temp277) && (temp278));
                        if (temp279)
                        {
                            var temp280 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp281 = Fun0(((ushort)((s)._0)), ((ushort)(temp280)));
                            s._0 = ((ushort)(temp281));
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
                        var temp282 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp283 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp282)));
                        var temp284 = ((int)((uint)(temp282)) <= (int)((uint)((uint)127U)));
                        var temp285 = ((temp283) && (temp284));
                        if (temp285)
                        {
                            var temp286 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp287 = ((byte)(((byte)(i)) >> 6));
                            var temp288 = (((byte)(temp287 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp289 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp290 = (((temp286) && (temp288)) && (temp289));
                            if (temp290)
                            {
                                var temp291 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp292 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp291))) + ((uint)(temp282))));
                                s._1 = ((uint)(temp292));
                                goto M31;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp293 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp282)));
                            var temp294 = ((int)((uint)(temp282)) <= (int)((uint)((uint)223U)));
                            var temp295 = ((temp293) && (temp294));
                            if (temp295)
                            {
                                var temp296 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp296));
                                goto M32;
                            }
                            else
                            {
                                var temp297 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp297)
                                {
                                    var temp298 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp298));
                                    goto M33;
                                }
                                else
                                {
                                    var temp299 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp299)
                                    {
                                        var temp300 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp300));
                                        goto M34;
                                    }
                                    else
                                    {
                                        var temp301 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp282)));
                                        var temp302 = ((int)((uint)(temp282)) <= (int)((uint)((uint)239U)));
                                        var temp303 = ((temp301) && (temp302));
                                        if (temp303)
                                        {
                                            var temp304 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp304));
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
                        var temp305 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp306 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp305)));
                        var temp307 = ((int)((uint)(temp305)) <= (int)((uint)((uint)191U)));
                        var temp308 = ((temp306) && (temp307));
                        if (temp308)
                        {
                            var temp309 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp310 = Fun0(((ushort)((s)._0)), ((ushort)(temp309)));
                            var temp311 = (((ushort)(temp310)) == ((ushort)((ushort)44U)));
                            if (temp311)
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
                        var temp312 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp313 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp312)));
                        var temp314 = ((int)((uint)(temp312)) <= (int)((uint)((uint)191U)));
                        var temp315 = ((temp313) && (temp314));
                        if (temp315)
                        {
                            var temp316 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp317 = Fun0(((ushort)((s)._0)), ((ushort)(temp316)));
                            s._0 = ((ushort)(temp317));
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
                        var temp318 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp319 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp318)));
                        var temp320 = ((int)((uint)(temp318)) <= (int)((uint)((uint)159U)));
                        var temp321 = ((temp319) && (temp320));
                        if (temp321)
                        {
                            var temp322 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp323 = Fun0(((ushort)((s)._0)), ((ushort)(temp322)));
                            s._0 = ((ushort)(temp323));
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
                        var temp324 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp325 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp324)));
                        var temp326 = ((int)((uint)(temp324)) <= (int)((uint)((uint)191U)));
                        var temp327 = ((temp325) && (temp326));
                        if (temp327)
                        {
                            var temp328 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp329 = Fun0(((ushort)((s)._0)), ((ushort)(temp328)));
                            s._0 = ((ushort)(temp329));
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
                        var temp330 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp331 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp330)));
                        var temp332 = ((int)((uint)(temp330)) <= (int)((uint)((uint)127U)));
                        var temp333 = ((temp331) && (temp332));
                        if (temp333)
                        {
                            var temp334 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp334)
                            {
                                goto M36;
                            }
                            else
                            {
                                var temp335 = (((byte)(i)) == ((byte)((byte)46U)));
                                if (temp335)
                                {
                                    goto M37;
                                }
                                else
                                {
                                    var temp336 = (((byte)((byte)48U)) <= ((byte)(i)));
                                    var temp337 = ((byte)(((byte)(i)) >> 6));
                                    var temp338 = (((byte)(temp337 & 3L)) == ((byte)((byte)0U & 3L)));
                                    var temp339 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                    var temp340 = (((temp336) && (temp338)) && (temp339));
                                    if (temp340)
                                    {
                                        var temp341 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                        var temp342 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp341))) + ((uint)(temp330))));
                                        s._1 = ((uint)(temp342));
                                        goto M31;
                                    }
                                    else
                                        throw new Exception();
                                }
                            }
                        }
                        else
                        {
                            var temp343 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp330)));
                            var temp344 = ((int)((uint)(temp330)) <= (int)((uint)((uint)223U)));
                            var temp345 = ((temp343) && (temp344));
                            if (temp345)
                            {
                                var temp346 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp346));
                                goto M38;
                            }
                            else
                            {
                                var temp347 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp347)
                                {
                                    var temp348 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp348));
                                    goto M39;
                                }
                                else
                                {
                                    var temp349 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp349)
                                    {
                                        var temp350 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp350));
                                        goto M40;
                                    }
                                    else
                                    {
                                        var temp351 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp330)));
                                        var temp352 = ((int)((uint)(temp330)) <= (int)((uint)((uint)239U)));
                                        var temp353 = ((temp351) && (temp352));
                                        if (temp353)
                                        {
                                            var temp354 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp354));
                                            goto M41;
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
                        var temp355 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp356 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp355)));
                        var temp357 = ((int)((uint)(temp355)) <= (int)((uint)((uint)191U)));
                        var temp358 = ((temp356) && (temp357));
                        if (temp358)
                        {
                            var temp359 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp360 = Fun0(((ushort)((s)._0)), ((ushort)(temp359)));
                            var temp361 = (((ushort)((ushort)48U)) <= ((ushort)(temp360)));
                            var temp362 = ((ushort)(((ushort)(temp360)) >> 6));
                            var temp363 = (((ushort)(temp362 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp364 = (((byte)(((byte)((ushort)(temp360))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp365 = (((temp361) && (temp363)) && (temp364));
                            var temp366 = (((ushort)((ushort)1632U)) <= ((ushort)(temp360)));
                            var temp367 = ((byte)(((ushort)(temp360)) >> 11));
                            var temp368 = (((byte)(temp367 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp369 = (((ushort)(((ushort)((ushort)(temp360))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp370 = (((temp366) && (temp368)) && (temp369));
                            var temp371 = (((ushort)((ushort)1776U)) <= ((ushort)(temp360)));
                            var temp372 = (((ushort)(((ushort)((ushort)(temp360))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp373 = (((temp371) && (temp368)) && (temp372));
                            var temp374 = (((ushort)((ushort)1984U)) <= ((ushort)(temp360)));
                            var temp375 = (((ushort)(((ushort)((ushort)(temp360))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp376 = (((temp374) && (temp368)) && (temp375));
                            var temp377 = (((ushort)((ushort)2406U)) <= ((ushort)(temp360)));
                            var temp378 = ((byte)(((ushort)(temp360)) >> 12));
                            var temp379 = (((byte)(temp378 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp380 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp381 = (((temp377) && (temp379)) && (temp380));
                            var temp382 = (((ushort)((ushort)2534U)) <= ((ushort)(temp360)));
                            var temp383 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp384 = (((temp382) && (temp379)) && (temp383));
                            var temp385 = (((ushort)((ushort)2662U)) <= ((ushort)(temp360)));
                            var temp386 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp387 = (((temp385) && (temp379)) && (temp386));
                            var temp388 = (((ushort)((ushort)2790U)) <= ((ushort)(temp360)));
                            var temp389 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp390 = (((temp388) && (temp379)) && (temp389));
                            var temp391 = (((ushort)((ushort)2918U)) <= ((ushort)(temp360)));
                            var temp392 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp393 = (((temp391) && (temp379)) && (temp392));
                            var temp394 = (((ushort)((ushort)3046U)) <= ((ushort)(temp360)));
                            var temp395 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp396 = (((temp394) && (temp379)) && (temp395));
                            var temp397 = (((ushort)((ushort)3174U)) <= ((ushort)(temp360)));
                            var temp398 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp399 = (((temp397) && (temp379)) && (temp398));
                            var temp400 = (((ushort)((ushort)3302U)) <= ((ushort)(temp360)));
                            var temp401 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp402 = (((temp400) && (temp379)) && (temp401));
                            var temp403 = (((ushort)((ushort)3430U)) <= ((ushort)(temp360)));
                            var temp404 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp405 = (((temp403) && (temp379)) && (temp404));
                            var temp406 = (((ushort)((ushort)3664U)) <= ((ushort)(temp360)));
                            var temp407 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp408 = (((temp406) && (temp379)) && (temp407));
                            var temp409 = (((ushort)((ushort)3792U)) <= ((ushort)(temp360)));
                            var temp410 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp411 = (((temp409) && (temp379)) && (temp410));
                            var temp412 = (((ushort)((ushort)3872U)) <= ((ushort)(temp360)));
                            var temp413 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp414 = (((temp412) && (temp379)) && (temp413));
                            var temp415 = (((ushort)((ushort)4160U)) <= ((ushort)(temp360)));
                            var temp416 = ((byte)(((ushort)(temp360)) >> 13));
                            var temp417 = (((byte)(temp416 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp418 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp419 = (((temp415) && (temp417)) && (temp418));
                            var temp420 = (((ushort)((ushort)4240U)) <= ((ushort)(temp360)));
                            var temp421 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp422 = (((temp420) && (temp417)) && (temp421));
                            var temp423 = (((ushort)((ushort)6112U)) <= ((ushort)(temp360)));
                            var temp424 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp425 = (((temp423) && (temp417)) && (temp424));
                            var temp426 = (((ushort)((ushort)6160U)) <= ((ushort)(temp360)));
                            var temp427 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp428 = (((temp426) && (temp417)) && (temp427));
                            var temp429 = (((ushort)((ushort)6470U)) <= ((ushort)(temp360)));
                            var temp430 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp431 = (((temp429) && (temp417)) && (temp430));
                            var temp432 = (((ushort)((ushort)6608U)) <= ((ushort)(temp360)));
                            var temp433 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp434 = (((temp432) && (temp417)) && (temp433));
                            var temp435 = (((ushort)((ushort)6992U)) <= ((ushort)(temp360)));
                            var temp436 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp437 = (((temp435) && (temp417)) && (temp436));
                            var temp438 = (((ushort)((ushort)7088U)) <= ((ushort)(temp360)));
                            var temp439 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp440 = (((temp438) && (temp417)) && (temp439));
                            var temp441 = (((ushort)((ushort)7232U)) <= ((ushort)(temp360)));
                            var temp442 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp443 = (((temp441) && (temp417)) && (temp442));
                            var temp444 = (((ushort)((ushort)7248U)) <= ((ushort)(temp360)));
                            var temp445 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp446 = (((temp444) && (temp417)) && (temp445));
                            var temp447 = (((ushort)((ushort)42528U)) <= ((ushort)(temp360)));
                            var temp448 = (((ushort)(temp360)) <= ((ushort)((ushort)42537U)));
                            var temp449 = ((temp447) && (temp448));
                            var temp450 = (((ushort)((ushort)43216U)) <= ((ushort)(temp360)));
                            var temp451 = (((ushort)(temp360)) <= ((ushort)((ushort)43225U)));
                            var temp452 = ((temp450) && (temp451));
                            var temp453 = (((ushort)((ushort)43264U)) <= ((ushort)(temp360)));
                            var temp454 = (((ushort)(temp360)) <= ((ushort)((ushort)43273U)));
                            var temp455 = ((temp453) && (temp454));
                            var temp456 = (((ushort)((ushort)43600U)) <= ((ushort)(temp360)));
                            var temp457 = (((ushort)(temp360)) <= ((ushort)((ushort)43609U)));
                            var temp458 = ((temp456) && (temp457));
                            var temp459 = (((ushort)((ushort)65296U)) <= ((ushort)(temp360)));
                            var temp460 = (((ushort)(temp360)) <= ((ushort)((ushort)65305U)));
                            var temp461 = ((temp459) && (temp460));
                            var temp462 = (((((((((((((((((((((((((((((((temp365) || (temp370)) || (temp373)) || (temp376)) || (temp381)) || (temp384)) || (temp387)) || (temp390)) || (temp393)) || (temp396)) || (temp399)) || (temp402)) || (temp405)) || (temp408)) || (temp411)) || (temp414)) || (temp419)) || (temp422)) || (temp425)) || (temp428)) || (temp431)) || (temp434)) || (temp437)) || (temp440)) || (temp443)) || (temp446)) || (temp449)) || (temp452)) || (temp455)) || (temp458)) || (temp461));
                            if (temp462)
                            {
                                var temp463 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp464 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp360));
                                var temp465 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp463))) + ((uint)(temp464))));
                                s._1 = ((uint)(temp465));
                                s._0 = ((ushort)((ushort)0U));
                                goto M31;
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
                        var temp466 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp467 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp466)));
                        var temp468 = ((int)((uint)(temp466)) <= (int)((uint)((uint)191U)));
                        var temp469 = ((temp467) && (temp468));
                        if (temp469)
                        {
                            var temp470 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp471 = Fun0(((ushort)((s)._0)), ((ushort)(temp470)));
                            s._0 = ((ushort)(temp471));
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
                        var temp472 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp473 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp472)));
                        var temp474 = ((int)((uint)(temp472)) <= (int)((uint)((uint)159U)));
                        var temp475 = ((temp473) && (temp474));
                        if (temp475)
                        {
                            var temp476 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp477 = Fun0(((ushort)((s)._0)), ((ushort)(temp476)));
                            s._0 = ((ushort)(temp477));
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
                        var temp478 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp479 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp478)));
                        var temp480 = ((int)((uint)(temp478)) <= (int)((uint)((uint)191U)));
                        var temp481 = ((temp479) && (temp480));
                        if (temp481)
                        {
                            var temp482 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp483 = Fun0(((ushort)((s)._0)), ((ushort)(temp482)));
                            s._0 = ((ushort)(temp483));
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
                        var temp484 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp485 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp484)));
                        var temp486 = ((int)((uint)(temp484)) <= (int)((uint)((uint)127U)));
                        var temp487 = ((temp485) && (temp486));
                        if (temp487)
                        {
                            var temp488 = (((byte)(i)) == ((byte)((byte)10U)));
                            if (temp488)
                            {
                                var temp489 = ((uint)(((uint)((uint)1U)) + ((uint)((s)._3))));
                                s._3 = ((uint)(temp489));
                                var temp490 = ((byte)(((uint)((s)._1)) >> 31));
                                var temp491 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 32) | (ulong)((uint)((s)._1));
                                var temp492 = ((ulong)(((ulong)((s)._2)) + ((ulong)(temp491))));
                                s._2 = ((ulong)(temp492));
                                s._1 = ((uint)((uint)0U));
                                goto M0;
                            }
                            else
                            {
                                goto M36;
                            }
                        }
                        else
                        {
                            var temp493 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp484)));
                            var temp494 = ((int)((uint)(temp484)) <= (int)((uint)((uint)223U)));
                            var temp495 = ((temp493) && (temp494));
                            if (temp495)
                            {
                                var temp496 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp496));
                                goto M51;
                            }
                            else
                            {
                                var temp497 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp497)
                                {
                                    var temp498 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp498));
                                    goto M52;
                                }
                                else
                                {
                                    var temp499 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp499)
                                    {
                                        var temp500 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp500));
                                        goto M53;
                                    }
                                    else
                                    {
                                        var temp501 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp484)));
                                        var temp502 = ((int)((uint)(temp484)) <= (int)((uint)((uint)239U)));
                                        var temp503 = ((temp501) && (temp502));
                                        if (temp503)
                                        {
                                            var temp504 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp504));
                                            goto M54;
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
                        var temp505 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp506 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp505)));
                        var temp507 = ((int)((uint)(temp505)) <= (int)((uint)((uint)127U)));
                        var temp508 = ((temp506) && (temp507));
                        if (temp508)
                        {
                            var temp509 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp510 = ((byte)(((byte)(i)) >> 6));
                            var temp511 = (((byte)(temp510 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp512 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp513 = (((temp509) && (temp511)) && (temp512));
                            if (temp513)
                            {
                                goto M42;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp514 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp505)));
                            var temp515 = ((int)((uint)(temp505)) <= (int)((uint)((uint)223U)));
                            var temp516 = ((temp514) && (temp515));
                            if (temp516)
                            {
                                var temp517 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp517));
                                goto M43;
                            }
                            else
                            {
                                var temp518 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp518)
                                {
                                    var temp519 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp519));
                                    goto M44;
                                }
                                else
                                {
                                    var temp520 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp520)
                                    {
                                        var temp521 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp521));
                                        goto M45;
                                    }
                                    else
                                    {
                                        var temp522 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp505)));
                                        var temp523 = ((int)((uint)(temp505)) <= (int)((uint)((uint)239U)));
                                        var temp524 = ((temp522) && (temp523));
                                        if (temp524)
                                        {
                                            var temp525 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp525));
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
                        var temp526 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp527 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp526)));
                        var temp528 = ((int)((uint)(temp526)) <= (int)((uint)((uint)191U)));
                        var temp529 = ((temp527) && (temp528));
                        if (temp529)
                        {
                            var temp530 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp531 = Fun0(((ushort)((s)._0)), ((ushort)(temp530)));
                            var temp532 = (((ushort)(temp531)) == ((ushort)((ushort)44U)));
                            if (temp532)
                                throw new Exception();
                            else
                            {
                                var temp533 = (((ushort)(temp531)) == ((ushort)((ushort)46U)));
                                if (temp533)
                                    throw new Exception();
                                else
                                {
                                    var temp534 = (((ushort)((ushort)48U)) <= ((ushort)(temp531)));
                                    var temp535 = ((ushort)(((ushort)(temp531)) >> 6));
                                    var temp536 = (((ushort)(temp535 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                    var temp537 = (((byte)(((byte)((ushort)(temp531))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                    var temp538 = (((temp534) && (temp536)) && (temp537));
                                    var temp539 = (((ushort)((ushort)1632U)) <= ((ushort)(temp531)));
                                    var temp540 = ((byte)(((ushort)(temp531)) >> 11));
                                    var temp541 = (((byte)(temp540 & 31L)) == ((byte)((byte)0U & 31L)));
                                    var temp542 = (((ushort)(((ushort)((ushort)(temp531))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                    var temp543 = (((temp539) && (temp541)) && (temp542));
                                    var temp544 = (((ushort)((ushort)1776U)) <= ((ushort)(temp531)));
                                    var temp545 = (((ushort)(((ushort)((ushort)(temp531))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                    var temp546 = (((temp544) && (temp541)) && (temp545));
                                    var temp547 = (((ushort)((ushort)1984U)) <= ((ushort)(temp531)));
                                    var temp548 = (((ushort)(((ushort)((ushort)(temp531))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                    var temp549 = (((temp547) && (temp541)) && (temp548));
                                    var temp550 = (((ushort)((ushort)2406U)) <= ((ushort)(temp531)));
                                    var temp551 = ((byte)(((ushort)(temp531)) >> 12));
                                    var temp552 = (((byte)(temp551 & 15L)) == ((byte)((byte)0U & 15L)));
                                    var temp553 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                    var temp554 = (((temp550) && (temp552)) && (temp553));
                                    var temp555 = (((ushort)((ushort)2534U)) <= ((ushort)(temp531)));
                                    var temp556 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                    var temp557 = (((temp555) && (temp552)) && (temp556));
                                    var temp558 = (((ushort)((ushort)2662U)) <= ((ushort)(temp531)));
                                    var temp559 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                    var temp560 = (((temp558) && (temp552)) && (temp559));
                                    var temp561 = (((ushort)((ushort)2790U)) <= ((ushort)(temp531)));
                                    var temp562 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                    var temp563 = (((temp561) && (temp552)) && (temp562));
                                    var temp564 = (((ushort)((ushort)2918U)) <= ((ushort)(temp531)));
                                    var temp565 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                    var temp566 = (((temp564) && (temp552)) && (temp565));
                                    var temp567 = (((ushort)((ushort)3046U)) <= ((ushort)(temp531)));
                                    var temp568 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                    var temp569 = (((temp567) && (temp552)) && (temp568));
                                    var temp570 = (((ushort)((ushort)3174U)) <= ((ushort)(temp531)));
                                    var temp571 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                    var temp572 = (((temp570) && (temp552)) && (temp571));
                                    var temp573 = (((ushort)((ushort)3302U)) <= ((ushort)(temp531)));
                                    var temp574 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                    var temp575 = (((temp573) && (temp552)) && (temp574));
                                    var temp576 = (((ushort)((ushort)3430U)) <= ((ushort)(temp531)));
                                    var temp577 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                    var temp578 = (((temp576) && (temp552)) && (temp577));
                                    var temp579 = (((ushort)((ushort)3664U)) <= ((ushort)(temp531)));
                                    var temp580 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                    var temp581 = (((temp579) && (temp552)) && (temp580));
                                    var temp582 = (((ushort)((ushort)3792U)) <= ((ushort)(temp531)));
                                    var temp583 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                    var temp584 = (((temp582) && (temp552)) && (temp583));
                                    var temp585 = (((ushort)((ushort)3872U)) <= ((ushort)(temp531)));
                                    var temp586 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                    var temp587 = (((temp585) && (temp552)) && (temp586));
                                    var temp588 = (((ushort)((ushort)4160U)) <= ((ushort)(temp531)));
                                    var temp589 = ((byte)(((ushort)(temp531)) >> 13));
                                    var temp590 = (((byte)(temp589 & 7L)) == ((byte)((byte)0U & 7L)));
                                    var temp591 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                    var temp592 = (((temp588) && (temp590)) && (temp591));
                                    var temp593 = (((ushort)((ushort)4240U)) <= ((ushort)(temp531)));
                                    var temp594 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                    var temp595 = (((temp593) && (temp590)) && (temp594));
                                    var temp596 = (((ushort)((ushort)6112U)) <= ((ushort)(temp531)));
                                    var temp597 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                    var temp598 = (((temp596) && (temp590)) && (temp597));
                                    var temp599 = (((ushort)((ushort)6160U)) <= ((ushort)(temp531)));
                                    var temp600 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                    var temp601 = (((temp599) && (temp590)) && (temp600));
                                    var temp602 = (((ushort)((ushort)6470U)) <= ((ushort)(temp531)));
                                    var temp603 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                    var temp604 = (((temp602) && (temp590)) && (temp603));
                                    var temp605 = (((ushort)((ushort)6608U)) <= ((ushort)(temp531)));
                                    var temp606 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                    var temp607 = (((temp605) && (temp590)) && (temp606));
                                    var temp608 = (((ushort)((ushort)6992U)) <= ((ushort)(temp531)));
                                    var temp609 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                    var temp610 = (((temp608) && (temp590)) && (temp609));
                                    var temp611 = (((ushort)((ushort)7088U)) <= ((ushort)(temp531)));
                                    var temp612 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                    var temp613 = (((temp611) && (temp590)) && (temp612));
                                    var temp614 = (((ushort)((ushort)7232U)) <= ((ushort)(temp531)));
                                    var temp615 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                    var temp616 = (((temp614) && (temp590)) && (temp615));
                                    var temp617 = (((ushort)((ushort)7248U)) <= ((ushort)(temp531)));
                                    var temp618 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                    var temp619 = (((temp617) && (temp590)) && (temp618));
                                    var temp620 = (((ushort)((ushort)42528U)) <= ((ushort)(temp531)));
                                    var temp621 = (((ushort)(temp531)) <= ((ushort)((ushort)42537U)));
                                    var temp622 = ((temp620) && (temp621));
                                    var temp623 = (((ushort)((ushort)43216U)) <= ((ushort)(temp531)));
                                    var temp624 = (((ushort)(temp531)) <= ((ushort)((ushort)43225U)));
                                    var temp625 = ((temp623) && (temp624));
                                    var temp626 = (((ushort)((ushort)43264U)) <= ((ushort)(temp531)));
                                    var temp627 = (((ushort)(temp531)) <= ((ushort)((ushort)43273U)));
                                    var temp628 = ((temp626) && (temp627));
                                    var temp629 = (((ushort)((ushort)43600U)) <= ((ushort)(temp531)));
                                    var temp630 = (((ushort)(temp531)) <= ((ushort)((ushort)43609U)));
                                    var temp631 = ((temp629) && (temp630));
                                    var temp632 = (((ushort)((ushort)65296U)) <= ((ushort)(temp531)));
                                    var temp633 = (((ushort)(temp531)) <= ((ushort)((ushort)65305U)));
                                    var temp634 = ((temp632) && (temp633));
                                    var temp635 = (((((((((((((((((((((((((((((((temp538) || (temp543)) || (temp546)) || (temp549)) || (temp554)) || (temp557)) || (temp560)) || (temp563)) || (temp566)) || (temp569)) || (temp572)) || (temp575)) || (temp578)) || (temp581)) || (temp584)) || (temp587)) || (temp592)) || (temp595)) || (temp598)) || (temp601)) || (temp604)) || (temp607)) || (temp610)) || (temp613)) || (temp616)) || (temp619)) || (temp622)) || (temp625)) || (temp628)) || (temp631)) || (temp634));
                                    if (temp635)
                                    {
                                        var temp636 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                        var temp637 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp531));
                                        var temp638 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp636))) + ((uint)(temp637))));
                                        s._1 = ((uint)(temp638));
                                        s._0 = ((ushort)((ushort)0U));
                                        goto M31;
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
                        var temp639 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp640 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp639)));
                        var temp641 = ((int)((uint)(temp639)) <= (int)((uint)((uint)191U)));
                        var temp642 = ((temp640) && (temp641));
                        if (temp642)
                        {
                            var temp643 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp644 = Fun0(((ushort)((s)._0)), ((ushort)(temp643)));
                            s._0 = ((ushort)(temp644));
                            goto M38;
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
                        var temp645 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp646 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp645)));
                        var temp647 = ((int)((uint)(temp645)) <= (int)((uint)((uint)159U)));
                        var temp648 = ((temp646) && (temp647));
                        if (temp648)
                        {
                            var temp649 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp650 = Fun0(((ushort)((s)._0)), ((ushort)(temp649)));
                            s._0 = ((ushort)(temp650));
                            goto M38;
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
                        var temp651 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp652 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp651)));
                        var temp653 = ((int)((uint)(temp651)) <= (int)((uint)((uint)191U)));
                        var temp654 = ((temp652) && (temp653));
                        if (temp654)
                        {
                            var temp655 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp656 = Fun0(((ushort)((s)._0)), ((ushort)(temp655)));
                            s._0 = ((ushort)(temp656));
                            goto M38;
                        }
                        else
                            throw new Exception();
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
                        var temp657 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp658 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp657)));
                        var temp659 = ((int)((uint)(temp657)) <= (int)((uint)((uint)127U)));
                        var temp660 = ((temp658) && (temp659));
                        if (temp660)
                        {
                            var temp661 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp661)
                            {
                                goto M36;
                            }
                            else
                            {
                                var temp662 = (((byte)((byte)48U)) <= ((byte)(i)));
                                var temp663 = ((byte)(((byte)(i)) >> 6));
                                var temp664 = (((byte)(temp663 & 3L)) == ((byte)((byte)0U & 3L)));
                                var temp665 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp666 = (((temp662) && (temp664)) && (temp665));
                                if (temp666)
                                {
                                    goto M42;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                        else
                        {
                            var temp667 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp657)));
                            var temp668 = ((int)((uint)(temp657)) <= (int)((uint)((uint)223U)));
                            var temp669 = ((temp667) && (temp668));
                            if (temp669)
                            {
                                var temp670 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp670));
                                goto M47;
                            }
                            else
                            {
                                var temp671 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp671)
                                {
                                    var temp672 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp672));
                                    goto M48;
                                }
                                else
                                {
                                    var temp673 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp673)
                                    {
                                        var temp674 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp674));
                                        goto M49;
                                    }
                                    else
                                    {
                                        var temp675 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp657)));
                                        var temp676 = ((int)((uint)(temp657)) <= (int)((uint)((uint)239U)));
                                        var temp677 = ((temp675) && (temp676));
                                        if (temp677)
                                        {
                                            var temp678 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp678));
                                            goto M50;
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
                        var temp679 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp680 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp679)));
                        var temp681 = ((int)((uint)(temp679)) <= (int)((uint)((uint)191U)));
                        var temp682 = ((temp680) && (temp681));
                        if (temp682)
                        {
                            var temp683 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp684 = Fun0(((ushort)((s)._0)), ((ushort)(temp683)));
                            var temp685 = (((ushort)((ushort)48U)) <= ((ushort)(temp684)));
                            var temp686 = ((ushort)(((ushort)(temp684)) >> 6));
                            var temp687 = (((ushort)(temp686 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp688 = (((byte)(((byte)((ushort)(temp684))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp689 = (((temp685) && (temp687)) && (temp688));
                            var temp690 = (((ushort)((ushort)1632U)) <= ((ushort)(temp684)));
                            var temp691 = ((byte)(((ushort)(temp684)) >> 11));
                            var temp692 = (((byte)(temp691 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp693 = (((ushort)(((ushort)((ushort)(temp684))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp694 = (((temp690) && (temp692)) && (temp693));
                            var temp695 = (((ushort)((ushort)1776U)) <= ((ushort)(temp684)));
                            var temp696 = (((ushort)(((ushort)((ushort)(temp684))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp697 = (((temp695) && (temp692)) && (temp696));
                            var temp698 = (((ushort)((ushort)1984U)) <= ((ushort)(temp684)));
                            var temp699 = (((ushort)(((ushort)((ushort)(temp684))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp700 = (((temp698) && (temp692)) && (temp699));
                            var temp701 = (((ushort)((ushort)2406U)) <= ((ushort)(temp684)));
                            var temp702 = ((byte)(((ushort)(temp684)) >> 12));
                            var temp703 = (((byte)(temp702 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp704 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp705 = (((temp701) && (temp703)) && (temp704));
                            var temp706 = (((ushort)((ushort)2534U)) <= ((ushort)(temp684)));
                            var temp707 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp708 = (((temp706) && (temp703)) && (temp707));
                            var temp709 = (((ushort)((ushort)2662U)) <= ((ushort)(temp684)));
                            var temp710 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp711 = (((temp709) && (temp703)) && (temp710));
                            var temp712 = (((ushort)((ushort)2790U)) <= ((ushort)(temp684)));
                            var temp713 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp714 = (((temp712) && (temp703)) && (temp713));
                            var temp715 = (((ushort)((ushort)2918U)) <= ((ushort)(temp684)));
                            var temp716 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp717 = (((temp715) && (temp703)) && (temp716));
                            var temp718 = (((ushort)((ushort)3046U)) <= ((ushort)(temp684)));
                            var temp719 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp720 = (((temp718) && (temp703)) && (temp719));
                            var temp721 = (((ushort)((ushort)3174U)) <= ((ushort)(temp684)));
                            var temp722 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp723 = (((temp721) && (temp703)) && (temp722));
                            var temp724 = (((ushort)((ushort)3302U)) <= ((ushort)(temp684)));
                            var temp725 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp726 = (((temp724) && (temp703)) && (temp725));
                            var temp727 = (((ushort)((ushort)3430U)) <= ((ushort)(temp684)));
                            var temp728 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp729 = (((temp727) && (temp703)) && (temp728));
                            var temp730 = (((ushort)((ushort)3664U)) <= ((ushort)(temp684)));
                            var temp731 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp732 = (((temp730) && (temp703)) && (temp731));
                            var temp733 = (((ushort)((ushort)3792U)) <= ((ushort)(temp684)));
                            var temp734 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp735 = (((temp733) && (temp703)) && (temp734));
                            var temp736 = (((ushort)((ushort)3872U)) <= ((ushort)(temp684)));
                            var temp737 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp738 = (((temp736) && (temp703)) && (temp737));
                            var temp739 = (((ushort)((ushort)4160U)) <= ((ushort)(temp684)));
                            var temp740 = ((byte)(((ushort)(temp684)) >> 13));
                            var temp741 = (((byte)(temp740 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp742 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp743 = (((temp739) && (temp741)) && (temp742));
                            var temp744 = (((ushort)((ushort)4240U)) <= ((ushort)(temp684)));
                            var temp745 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp746 = (((temp744) && (temp741)) && (temp745));
                            var temp747 = (((ushort)((ushort)6112U)) <= ((ushort)(temp684)));
                            var temp748 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp749 = (((temp747) && (temp741)) && (temp748));
                            var temp750 = (((ushort)((ushort)6160U)) <= ((ushort)(temp684)));
                            var temp751 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp752 = (((temp750) && (temp741)) && (temp751));
                            var temp753 = (((ushort)((ushort)6470U)) <= ((ushort)(temp684)));
                            var temp754 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp755 = (((temp753) && (temp741)) && (temp754));
                            var temp756 = (((ushort)((ushort)6608U)) <= ((ushort)(temp684)));
                            var temp757 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp758 = (((temp756) && (temp741)) && (temp757));
                            var temp759 = (((ushort)((ushort)6992U)) <= ((ushort)(temp684)));
                            var temp760 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp761 = (((temp759) && (temp741)) && (temp760));
                            var temp762 = (((ushort)((ushort)7088U)) <= ((ushort)(temp684)));
                            var temp763 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp764 = (((temp762) && (temp741)) && (temp763));
                            var temp765 = (((ushort)((ushort)7232U)) <= ((ushort)(temp684)));
                            var temp766 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp767 = (((temp765) && (temp741)) && (temp766));
                            var temp768 = (((ushort)((ushort)7248U)) <= ((ushort)(temp684)));
                            var temp769 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp770 = (((temp768) && (temp741)) && (temp769));
                            var temp771 = (((ushort)((ushort)42528U)) <= ((ushort)(temp684)));
                            var temp772 = (((ushort)(temp684)) <= ((ushort)((ushort)42537U)));
                            var temp773 = ((temp771) && (temp772));
                            var temp774 = (((ushort)((ushort)43216U)) <= ((ushort)(temp684)));
                            var temp775 = (((ushort)(temp684)) <= ((ushort)((ushort)43225U)));
                            var temp776 = ((temp774) && (temp775));
                            var temp777 = (((ushort)((ushort)43264U)) <= ((ushort)(temp684)));
                            var temp778 = (((ushort)(temp684)) <= ((ushort)((ushort)43273U)));
                            var temp779 = ((temp777) && (temp778));
                            var temp780 = (((ushort)((ushort)43600U)) <= ((ushort)(temp684)));
                            var temp781 = (((ushort)(temp684)) <= ((ushort)((ushort)43609U)));
                            var temp782 = ((temp780) && (temp781));
                            var temp783 = (((ushort)((ushort)65296U)) <= ((ushort)(temp684)));
                            var temp784 = (((ushort)(temp684)) <= ((ushort)((ushort)65305U)));
                            var temp785 = ((temp783) && (temp784));
                            var temp786 = (((((((((((((((((((((((((((((((temp689) || (temp694)) || (temp697)) || (temp700)) || (temp705)) || (temp708)) || (temp711)) || (temp714)) || (temp717)) || (temp720)) || (temp723)) || (temp726)) || (temp729)) || (temp732)) || (temp735)) || (temp738)) || (temp743)) || (temp746)) || (temp749)) || (temp752)) || (temp755)) || (temp758)) || (temp761)) || (temp764)) || (temp767)) || (temp770)) || (temp773)) || (temp776)) || (temp779)) || (temp782)) || (temp785));
                            if (temp786)
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M42;
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
                        var temp787 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp788 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp787)));
                        var temp789 = ((int)((uint)(temp787)) <= (int)((uint)((uint)191U)));
                        var temp790 = ((temp788) && (temp789));
                        if (temp790)
                        {
                            var temp791 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp792 = Fun0(((ushort)((s)._0)), ((ushort)(temp791)));
                            s._0 = ((ushort)(temp792));
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
                        var temp793 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp794 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp793)));
                        var temp795 = ((int)((uint)(temp793)) <= (int)((uint)((uint)159U)));
                        var temp796 = ((temp794) && (temp795));
                        if (temp796)
                        {
                            var temp797 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp798 = Fun0(((ushort)((s)._0)), ((ushort)(temp797)));
                            s._0 = ((ushort)(temp798));
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
                        var temp799 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp800 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp799)));
                        var temp801 = ((int)((uint)(temp799)) <= (int)((uint)((uint)191U)));
                        var temp802 = ((temp800) && (temp801));
                        if (temp802)
                        {
                            var temp803 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp804 = Fun0(((ushort)((s)._0)), ((ushort)(temp803)));
                            s._0 = ((ushort)(temp804));
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
                        var temp805 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp806 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp805)));
                        var temp807 = ((int)((uint)(temp805)) <= (int)((uint)((uint)191U)));
                        var temp808 = ((temp806) && (temp807));
                        if (temp808)
                        {
                            var temp809 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp810 = Fun0(((ushort)((s)._0)), ((ushort)(temp809)));
                            var temp811 = (((ushort)(temp810)) == ((ushort)((ushort)44U)));
                            if (temp811)
                                throw new Exception();
                            else
                            {
                                var temp812 = (((ushort)((ushort)48U)) <= ((ushort)(temp810)));
                                var temp813 = ((ushort)(((ushort)(temp810)) >> 6));
                                var temp814 = (((ushort)(temp813 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                var temp815 = (((byte)(((byte)((ushort)(temp810))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp816 = (((temp812) && (temp814)) && (temp815));
                                var temp817 = (((ushort)((ushort)1632U)) <= ((ushort)(temp810)));
                                var temp818 = ((byte)(((ushort)(temp810)) >> 11));
                                var temp819 = (((byte)(temp818 & 31L)) == ((byte)((byte)0U & 31L)));
                                var temp820 = (((ushort)(((ushort)((ushort)(temp810))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                var temp821 = (((temp817) && (temp819)) && (temp820));
                                var temp822 = (((ushort)((ushort)1776U)) <= ((ushort)(temp810)));
                                var temp823 = (((ushort)(((ushort)((ushort)(temp810))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                var temp824 = (((temp822) && (temp819)) && (temp823));
                                var temp825 = (((ushort)((ushort)1984U)) <= ((ushort)(temp810)));
                                var temp826 = (((ushort)(((ushort)((ushort)(temp810))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                var temp827 = (((temp825) && (temp819)) && (temp826));
                                var temp828 = (((ushort)((ushort)2406U)) <= ((ushort)(temp810)));
                                var temp829 = ((byte)(((ushort)(temp810)) >> 12));
                                var temp830 = (((byte)(temp829 & 15L)) == ((byte)((byte)0U & 15L)));
                                var temp831 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                var temp832 = (((temp828) && (temp830)) && (temp831));
                                var temp833 = (((ushort)((ushort)2534U)) <= ((ushort)(temp810)));
                                var temp834 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                var temp835 = (((temp833) && (temp830)) && (temp834));
                                var temp836 = (((ushort)((ushort)2662U)) <= ((ushort)(temp810)));
                                var temp837 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                var temp838 = (((temp836) && (temp830)) && (temp837));
                                var temp839 = (((ushort)((ushort)2790U)) <= ((ushort)(temp810)));
                                var temp840 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                var temp841 = (((temp839) && (temp830)) && (temp840));
                                var temp842 = (((ushort)((ushort)2918U)) <= ((ushort)(temp810)));
                                var temp843 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                var temp844 = (((temp842) && (temp830)) && (temp843));
                                var temp845 = (((ushort)((ushort)3046U)) <= ((ushort)(temp810)));
                                var temp846 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                var temp847 = (((temp845) && (temp830)) && (temp846));
                                var temp848 = (((ushort)((ushort)3174U)) <= ((ushort)(temp810)));
                                var temp849 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                var temp850 = (((temp848) && (temp830)) && (temp849));
                                var temp851 = (((ushort)((ushort)3302U)) <= ((ushort)(temp810)));
                                var temp852 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                var temp853 = (((temp851) && (temp830)) && (temp852));
                                var temp854 = (((ushort)((ushort)3430U)) <= ((ushort)(temp810)));
                                var temp855 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                var temp856 = (((temp854) && (temp830)) && (temp855));
                                var temp857 = (((ushort)((ushort)3664U)) <= ((ushort)(temp810)));
                                var temp858 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                var temp859 = (((temp857) && (temp830)) && (temp858));
                                var temp860 = (((ushort)((ushort)3792U)) <= ((ushort)(temp810)));
                                var temp861 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                var temp862 = (((temp860) && (temp830)) && (temp861));
                                var temp863 = (((ushort)((ushort)3872U)) <= ((ushort)(temp810)));
                                var temp864 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                var temp865 = (((temp863) && (temp830)) && (temp864));
                                var temp866 = (((ushort)((ushort)4160U)) <= ((ushort)(temp810)));
                                var temp867 = ((byte)(((ushort)(temp810)) >> 13));
                                var temp868 = (((byte)(temp867 & 7L)) == ((byte)((byte)0U & 7L)));
                                var temp869 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                var temp870 = (((temp866) && (temp868)) && (temp869));
                                var temp871 = (((ushort)((ushort)4240U)) <= ((ushort)(temp810)));
                                var temp872 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                var temp873 = (((temp871) && (temp868)) && (temp872));
                                var temp874 = (((ushort)((ushort)6112U)) <= ((ushort)(temp810)));
                                var temp875 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                var temp876 = (((temp874) && (temp868)) && (temp875));
                                var temp877 = (((ushort)((ushort)6160U)) <= ((ushort)(temp810)));
                                var temp878 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                var temp879 = (((temp877) && (temp868)) && (temp878));
                                var temp880 = (((ushort)((ushort)6470U)) <= ((ushort)(temp810)));
                                var temp881 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                var temp882 = (((temp880) && (temp868)) && (temp881));
                                var temp883 = (((ushort)((ushort)6608U)) <= ((ushort)(temp810)));
                                var temp884 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                var temp885 = (((temp883) && (temp868)) && (temp884));
                                var temp886 = (((ushort)((ushort)6992U)) <= ((ushort)(temp810)));
                                var temp887 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                var temp888 = (((temp886) && (temp868)) && (temp887));
                                var temp889 = (((ushort)((ushort)7088U)) <= ((ushort)(temp810)));
                                var temp890 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                var temp891 = (((temp889) && (temp868)) && (temp890));
                                var temp892 = (((ushort)((ushort)7232U)) <= ((ushort)(temp810)));
                                var temp893 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                var temp894 = (((temp892) && (temp868)) && (temp893));
                                var temp895 = (((ushort)((ushort)7248U)) <= ((ushort)(temp810)));
                                var temp896 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                var temp897 = (((temp895) && (temp868)) && (temp896));
                                var temp898 = (((ushort)((ushort)42528U)) <= ((ushort)(temp810)));
                                var temp899 = (((ushort)(temp810)) <= ((ushort)((ushort)42537U)));
                                var temp900 = ((temp898) && (temp899));
                                var temp901 = (((ushort)((ushort)43216U)) <= ((ushort)(temp810)));
                                var temp902 = (((ushort)(temp810)) <= ((ushort)((ushort)43225U)));
                                var temp903 = ((temp901) && (temp902));
                                var temp904 = (((ushort)((ushort)43264U)) <= ((ushort)(temp810)));
                                var temp905 = (((ushort)(temp810)) <= ((ushort)((ushort)43273U)));
                                var temp906 = ((temp904) && (temp905));
                                var temp907 = (((ushort)((ushort)43600U)) <= ((ushort)(temp810)));
                                var temp908 = (((ushort)(temp810)) <= ((ushort)((ushort)43609U)));
                                var temp909 = ((temp907) && (temp908));
                                var temp910 = (((ushort)((ushort)65296U)) <= ((ushort)(temp810)));
                                var temp911 = (((ushort)(temp810)) <= ((ushort)((ushort)65305U)));
                                var temp912 = ((temp910) && (temp911));
                                var temp913 = (((((((((((((((((((((((((((((((temp816) || (temp821)) || (temp824)) || (temp827)) || (temp832)) || (temp835)) || (temp838)) || (temp841)) || (temp844)) || (temp847)) || (temp850)) || (temp853)) || (temp856)) || (temp859)) || (temp862)) || (temp865)) || (temp870)) || (temp873)) || (temp876)) || (temp879)) || (temp882)) || (temp885)) || (temp888)) || (temp891)) || (temp894)) || (temp897)) || (temp900)) || (temp903)) || (temp906)) || (temp909)) || (temp912));
                                if (temp913)
                                {
                                    s._0 = ((ushort)((ushort)0U));
                                    goto M42;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                        else
                            throw new Exception();
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
                        var temp914 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp915 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp914)));
                        var temp916 = ((int)((uint)(temp914)) <= (int)((uint)((uint)191U)));
                        var temp917 = ((temp915) && (temp916));
                        if (temp917)
                        {
                            var temp918 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp919 = Fun0(((ushort)((s)._0)), ((ushort)(temp918)));
                            s._0 = ((ushort)(temp919));
                            goto M47;
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
                        var temp920 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp921 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp920)));
                        var temp922 = ((int)((uint)(temp920)) <= (int)((uint)((uint)159U)));
                        var temp923 = ((temp921) && (temp922));
                        if (temp923)
                        {
                            var temp924 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp925 = Fun0(((ushort)((s)._0)), ((ushort)(temp924)));
                            s._0 = ((ushort)(temp925));
                            goto M47;
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
                        var temp926 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp927 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp926)));
                        var temp928 = ((int)((uint)(temp926)) <= (int)((uint)((uint)191U)));
                        var temp929 = ((temp927) && (temp928));
                        if (temp929)
                        {
                            var temp930 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp931 = Fun0(((ushort)((s)._0)), ((ushort)(temp930)));
                            s._0 = ((ushort)(temp931));
                            goto M47;
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
                        var temp932 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp933 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp932)));
                        var temp934 = ((int)((uint)(temp932)) <= (int)((uint)((uint)191U)));
                        var temp935 = ((temp933) && (temp934));
                        if (temp935)
                        {
                            var temp936 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp937 = Fun0(((ushort)((s)._0)), ((ushort)(temp936)));
                            var temp938 = (((ushort)(temp937)) == ((ushort)((ushort)10U)));
                            if (temp938)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M36;
                            }
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
                        var temp939 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp940 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp939)));
                        var temp941 = ((int)((uint)(temp939)) <= (int)((uint)((uint)191U)));
                        var temp942 = ((temp940) && (temp941));
                        if (temp942)
                        {
                            var temp943 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp944 = Fun0(((ushort)((s)._0)), ((ushort)(temp943)));
                            s._0 = ((ushort)(temp944));
                            goto M51;
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
                        var temp945 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp946 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp945)));
                        var temp947 = ((int)((uint)(temp945)) <= (int)((uint)((uint)159U)));
                        var temp948 = ((temp946) && (temp947));
                        if (temp948)
                        {
                            var temp949 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp950 = Fun0(((ushort)((s)._0)), ((ushort)(temp949)));
                            s._0 = ((ushort)(temp950));
                            goto M51;
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
                        var temp951 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp952 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp951)));
                        var temp953 = ((int)((uint)(temp951)) <= (int)((uint)((uint)191U)));
                        var temp954 = ((temp952) && (temp953));
                        if (temp954)
                        {
                            var temp955 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp956 = Fun0(((ushort)((s)._0)), ((ushort)(temp955)));
                            s._0 = ((ushort)(temp956));
                            goto M51;
                        }
                        else
                            throw new Exception();
                    }
                }

                F0:
                {
                    var temp0 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp0)
                    {
                        if (oIndex > 16380)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        oBuf[oIndex + 0] = (Byte)((byte)0U);
                        oBuf[oIndex + 1] = (Byte)((byte)0U);
                        oBuf[oIndex + 2] = (Byte)((byte)0U);
                        oBuf[oIndex + 3] = (Byte)((byte)0U);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                    else
                    {
                        if (oIndex > 16380)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        var temp1 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp2 = (((byte)(temp1 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp3 = ((temp0) && (temp2));
                        var temp4 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp5 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp4))));
                        var temp6 = ((temp3) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp5))))));
                        var temp7 = ((uint)(((int)((uint)(temp6))) >> (int)((uint)((uint)24U))));
                        oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp7))));
                        var temp8 = ((uint)(((int)((uint)(temp6))) >> (int)((uint)((uint)16U))));
                        oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp8))));
                        var temp9 = ((uint)(((int)((uint)(temp6))) >> (int)((uint)((uint)8U))));
                        oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp9))));
                        var temp10 = ((temp3) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp5))))));
                        oBuf[oIndex + 3] = (Byte)(temp10);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                }

                F1:
                    throw new Exception();
                F2:
                {
                    var temp45 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp45)
                    {
                        if (oIndex > 16380)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        oBuf[oIndex + 0] = (Byte)((byte)0U);
                        oBuf[oIndex + 1] = (Byte)((byte)0U);
                        oBuf[oIndex + 2] = (Byte)((byte)0U);
                        oBuf[oIndex + 3] = (Byte)((byte)0U);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                    else
                    {
                        if (oIndex > 16380)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        var temp46 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp47 = (((byte)(temp46 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp48 = ((temp45) && (temp47));
                        var temp49 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp50 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp49))));
                        var temp51 = ((temp48) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp50))))));
                        var temp52 = ((uint)(((int)((uint)(temp51))) >> (int)((uint)((uint)24U))));
                        oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp52))));
                        var temp53 = ((uint)(((int)((uint)(temp51))) >> (int)((uint)((uint)16U))));
                        oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp53))));
                        var temp54 = ((uint)(((int)((uint)(temp51))) >> (int)((uint)((uint)8U))));
                        oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp54))));
                        var temp55 = ((temp48) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp50))))));
                        oBuf[oIndex + 3] = (Byte)(temp55);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                }

                F3:
                {
                    var temp63 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp63)
                    {
                        if (oIndex > 16380)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        oBuf[oIndex + 0] = (Byte)((byte)0U);
                        oBuf[oIndex + 1] = (Byte)((byte)0U);
                        oBuf[oIndex + 2] = (Byte)((byte)0U);
                        oBuf[oIndex + 3] = (Byte)((byte)0U);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                    else
                    {
                        if (oIndex > 16380)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        var temp64 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp65 = (((byte)(temp64 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp66 = ((temp63) && (temp65));
                        var temp67 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp68 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp67))));
                        var temp69 = ((temp66) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp68))))));
                        var temp70 = ((uint)(((int)((uint)(temp69))) >> (int)((uint)((uint)24U))));
                        oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp70))));
                        var temp71 = ((uint)(((int)((uint)(temp69))) >> (int)((uint)((uint)16U))));
                        oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp71))));
                        var temp72 = ((uint)(((int)((uint)(temp69))) >> (int)((uint)((uint)8U))));
                        oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp72))));
                        var temp73 = ((temp66) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp68))))));
                        oBuf[oIndex + 3] = (Byte)(temp73);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                }

                F4:
                {
                    var temp80 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp80)
                    {
                        if (oIndex > 16380)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        oBuf[oIndex + 0] = (Byte)((byte)0U);
                        oBuf[oIndex + 1] = (Byte)((byte)0U);
                        oBuf[oIndex + 2] = (Byte)((byte)0U);
                        oBuf[oIndex + 3] = (Byte)((byte)0U);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                    else
                    {
                        if (oIndex > 16380)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        var temp81 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp82 = (((byte)(temp81 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp83 = ((temp80) && (temp82));
                        var temp84 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp85 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp84))));
                        var temp86 = ((temp83) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp85))))));
                        var temp87 = ((uint)(((int)((uint)(temp86))) >> (int)((uint)((uint)24U))));
                        oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp87))));
                        var temp88 = ((uint)(((int)((uint)(temp86))) >> (int)((uint)((uint)16U))));
                        oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp88))));
                        var temp89 = ((uint)(((int)((uint)(temp86))) >> (int)((uint)((uint)8U))));
                        oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp89))));
                        var temp90 = ((temp83) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp85))))));
                        oBuf[oIndex + 3] = (Byte)(temp90);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                }

                F5:
                {
                    var temp97 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp97)
                    {
                        if (oIndex > 16380)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        oBuf[oIndex + 0] = (Byte)((byte)0U);
                        oBuf[oIndex + 1] = (Byte)((byte)0U);
                        oBuf[oIndex + 2] = (Byte)((byte)0U);
                        oBuf[oIndex + 3] = (Byte)((byte)0U);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                    else
                    {
                        if (oIndex > 16380)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        var temp98 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp99 = (((byte)(temp98 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp100 = ((temp97) && (temp99));
                        var temp101 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp102 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp101))));
                        var temp103 = ((temp100) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp102))))));
                        var temp104 = ((uint)(((int)((uint)(temp103))) >> (int)((uint)((uint)24U))));
                        oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp104))));
                        var temp105 = ((uint)(((int)((uint)(temp103))) >> (int)((uint)((uint)16U))));
                        oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp105))));
                        var temp106 = ((uint)(((int)((uint)(temp103))) >> (int)((uint)((uint)8U))));
                        oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp106))));
                        var temp107 = ((temp100) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp102))))));
                        oBuf[oIndex + 3] = (Byte)(temp107);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
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
            }
        }

        struct DTStruct39
        {
            public UInt16 _0;
            public UInt32 _1;
            public UInt64 _2;
            public UInt32 _3;
            public DTStruct39(UInt16 v0, UInt32 v1, UInt64 v2, UInt32 v3)
            {
                _0 = v0;
                _1 = v1;
                _2 = v2;
                _3 = v3;
            }
        }

        public static void TransduceFromArrayToStream(byte[] input, Stream output)
        {
            unchecked
            {
                int iIndex = -1;
                var oBuf = new byte[16384];
                int oIndex = 0;
                DTStruct39 s = new DTStruct39(((ushort)((ushort)0U)), ((uint)((uint)0U)), ((ulong)((ulong)0UL)), ((uint)((uint)0U)));
                Byte i;
                M0:
                {
                    if (++iIndex >= input.Length)
                        goto F0;
                    i = input[iIndex];
                    {
                        var temp11 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp12 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp11)));
                        var temp13 = ((int)((uint)(temp11)) <= (int)((uint)((uint)127U)));
                        var temp14 = ((temp12) && (temp13));
                        if (temp14)
                        {
                            var temp15 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp15)
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
                            var temp16 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp11)));
                            var temp17 = ((int)((uint)(temp11)) <= (int)((uint)((uint)223U)));
                            var temp18 = ((temp16) && (temp17));
                            if (temp18)
                            {
                                var temp19 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp19));
                                goto M2;
                            }
                            else
                            {
                                var temp20 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp20)
                                {
                                    var temp21 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp21));
                                    goto M3;
                                }
                                else
                                {
                                    var temp22 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp22)
                                    {
                                        var temp23 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp23));
                                        goto M4;
                                    }
                                    else
                                    {
                                        var temp24 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp11)));
                                        var temp25 = ((int)((uint)(temp11)) <= (int)((uint)((uint)239U)));
                                        var temp26 = ((temp24) && (temp25));
                                        if (temp26)
                                        {
                                            var temp27 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp27));
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
                        var temp28 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp29 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp28)));
                        var temp30 = ((int)((uint)(temp28)) <= (int)((uint)((uint)127U)));
                        var temp31 = ((temp29) && (temp30));
                        if (temp31)
                        {
                            var temp32 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp32)
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
                            var temp33 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp28)));
                            var temp34 = ((int)((uint)(temp28)) <= (int)((uint)((uint)223U)));
                            var temp35 = ((temp33) && (temp34));
                            if (temp35)
                            {
                                var temp36 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp36));
                                goto M7;
                            }
                            else
                            {
                                var temp37 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp37)
                                {
                                    var temp38 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp38));
                                    goto M8;
                                }
                                else
                                {
                                    var temp39 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp39)
                                    {
                                        var temp40 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp40));
                                        goto M9;
                                    }
                                    else
                                    {
                                        var temp41 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp28)));
                                        var temp42 = ((int)((uint)(temp28)) <= (int)((uint)((uint)239U)));
                                        var temp43 = ((temp41) && (temp42));
                                        if (temp43)
                                        {
                                            var temp44 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp44));
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
                        var temp56 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp57 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp56)));
                        var temp58 = ((int)((uint)(temp56)) <= (int)((uint)((uint)191U)));
                        var temp59 = ((temp57) && (temp58));
                        if (temp59)
                        {
                            var temp60 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp61 = Fun0(((ushort)((s)._0)), ((ushort)(temp60)));
                            var temp62 = (((ushort)(temp61)) == ((ushort)((ushort)44U)));
                            if (temp62)
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
                        var temp74 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp75 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp74)));
                        var temp76 = ((int)((uint)(temp74)) <= (int)((uint)((uint)191U)));
                        var temp77 = ((temp75) && (temp76));
                        if (temp77)
                        {
                            var temp78 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp79 = Fun0(((ushort)((s)._0)), ((ushort)(temp78)));
                            s._0 = ((ushort)(temp79));
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
                        var temp91 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp92 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp91)));
                        var temp93 = ((int)((uint)(temp91)) <= (int)((uint)((uint)159U)));
                        var temp94 = ((temp92) && (temp93));
                        if (temp94)
                        {
                            var temp95 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp96 = Fun0(((ushort)((s)._0)), ((ushort)(temp95)));
                            s._0 = ((ushort)(temp96));
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
                        var temp108 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp109 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp108)));
                        var temp110 = ((int)((uint)(temp108)) <= (int)((uint)((uint)191U)));
                        var temp111 = ((temp109) && (temp110));
                        if (temp111)
                        {
                            var temp112 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp113 = Fun0(((ushort)((s)._0)), ((ushort)(temp112)));
                            s._0 = ((ushort)(temp113));
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
                        var temp114 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp115 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp114)));
                        var temp116 = ((int)((uint)(temp114)) <= (int)((uint)((uint)127U)));
                        var temp117 = ((temp115) && (temp116));
                        if (temp117)
                        {
                            var temp118 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp118)
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
                            var temp119 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp114)));
                            var temp120 = ((int)((uint)(temp114)) <= (int)((uint)((uint)223U)));
                            var temp121 = ((temp119) && (temp120));
                            if (temp121)
                            {
                                var temp122 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp122));
                                goto M12;
                            }
                            else
                            {
                                var temp123 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp123)
                                {
                                    var temp124 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp124));
                                    goto M13;
                                }
                                else
                                {
                                    var temp125 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp125)
                                    {
                                        var temp126 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp126));
                                        goto M14;
                                    }
                                    else
                                    {
                                        var temp127 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp114)));
                                        var temp128 = ((int)((uint)(temp114)) <= (int)((uint)((uint)239U)));
                                        var temp129 = ((temp127) && (temp128));
                                        if (temp129)
                                        {
                                            var temp130 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp130));
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
                        var temp131 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp132 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp131)));
                        var temp133 = ((int)((uint)(temp131)) <= (int)((uint)((uint)191U)));
                        var temp134 = ((temp132) && (temp133));
                        if (temp134)
                        {
                            var temp135 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp136 = Fun0(((ushort)((s)._0)), ((ushort)(temp135)));
                            var temp137 = (((ushort)(temp136)) == ((ushort)((ushort)44U)));
                            if (temp137)
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
                        var temp138 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp139 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp138)));
                        var temp140 = ((int)((uint)(temp138)) <= (int)((uint)((uint)191U)));
                        var temp141 = ((temp139) && (temp140));
                        if (temp141)
                        {
                            var temp142 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp143 = Fun0(((ushort)((s)._0)), ((ushort)(temp142)));
                            s._0 = ((ushort)(temp143));
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
                        var temp144 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp145 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp144)));
                        var temp146 = ((int)((uint)(temp144)) <= (int)((uint)((uint)159U)));
                        var temp147 = ((temp145) && (temp146));
                        if (temp147)
                        {
                            var temp148 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp149 = Fun0(((ushort)((s)._0)), ((ushort)(temp148)));
                            s._0 = ((ushort)(temp149));
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
                        var temp150 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp151 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp150)));
                        var temp152 = ((int)((uint)(temp150)) <= (int)((uint)((uint)191U)));
                        var temp153 = ((temp151) && (temp152));
                        if (temp153)
                        {
                            var temp154 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp155 = Fun0(((ushort)((s)._0)), ((ushort)(temp154)));
                            s._0 = ((ushort)(temp155));
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
                        var temp156 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp157 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp156)));
                        var temp158 = ((int)((uint)(temp156)) <= (int)((uint)((uint)127U)));
                        var temp159 = ((temp157) && (temp158));
                        if (temp159)
                        {
                            var temp160 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp160)
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
                            var temp161 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp156)));
                            var temp162 = ((int)((uint)(temp156)) <= (int)((uint)((uint)223U)));
                            var temp163 = ((temp161) && (temp162));
                            if (temp163)
                            {
                                var temp164 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp164));
                                goto M17;
                            }
                            else
                            {
                                var temp165 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp165)
                                {
                                    var temp166 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp166));
                                    goto M18;
                                }
                                else
                                {
                                    var temp167 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp167)
                                    {
                                        var temp168 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp168));
                                        goto M19;
                                    }
                                    else
                                    {
                                        var temp169 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp156)));
                                        var temp170 = ((int)((uint)(temp156)) <= (int)((uint)((uint)239U)));
                                        var temp171 = ((temp169) && (temp170));
                                        if (temp171)
                                        {
                                            var temp172 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp172));
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
                        var temp173 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp174 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp173)));
                        var temp175 = ((int)((uint)(temp173)) <= (int)((uint)((uint)191U)));
                        var temp176 = ((temp174) && (temp175));
                        if (temp176)
                        {
                            var temp177 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp178 = Fun0(((ushort)((s)._0)), ((ushort)(temp177)));
                            var temp179 = (((ushort)(temp178)) == ((ushort)((ushort)44U)));
                            if (temp179)
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
                        var temp180 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp181 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp180)));
                        var temp182 = ((int)((uint)(temp180)) <= (int)((uint)((uint)191U)));
                        var temp183 = ((temp181) && (temp182));
                        if (temp183)
                        {
                            var temp184 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp185 = Fun0(((ushort)((s)._0)), ((ushort)(temp184)));
                            s._0 = ((ushort)(temp185));
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
                        var temp186 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp187 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp186)));
                        var temp188 = ((int)((uint)(temp186)) <= (int)((uint)((uint)159U)));
                        var temp189 = ((temp187) && (temp188));
                        if (temp189)
                        {
                            var temp190 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp191 = Fun0(((ushort)((s)._0)), ((ushort)(temp190)));
                            s._0 = ((ushort)(temp191));
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
                        var temp192 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp193 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp192)));
                        var temp194 = ((int)((uint)(temp192)) <= (int)((uint)((uint)191U)));
                        var temp195 = ((temp193) && (temp194));
                        if (temp195)
                        {
                            var temp196 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp197 = Fun0(((ushort)((s)._0)), ((ushort)(temp196)));
                            s._0 = ((ushort)(temp197));
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
                        var temp198 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp199 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp198)));
                        var temp200 = ((int)((uint)(temp198)) <= (int)((uint)((uint)127U)));
                        var temp201 = ((temp199) && (temp200));
                        if (temp201)
                        {
                            var temp202 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp202)
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
                            var temp203 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp198)));
                            var temp204 = ((int)((uint)(temp198)) <= (int)((uint)((uint)223U)));
                            var temp205 = ((temp203) && (temp204));
                            if (temp205)
                            {
                                var temp206 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp206));
                                goto M22;
                            }
                            else
                            {
                                var temp207 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp207)
                                {
                                    var temp208 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp208));
                                    goto M23;
                                }
                                else
                                {
                                    var temp209 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp209)
                                    {
                                        var temp210 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp210));
                                        goto M24;
                                    }
                                    else
                                    {
                                        var temp211 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp198)));
                                        var temp212 = ((int)((uint)(temp198)) <= (int)((uint)((uint)239U)));
                                        var temp213 = ((temp211) && (temp212));
                                        if (temp213)
                                        {
                                            var temp214 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp214));
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
                        var temp215 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp216 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp215)));
                        var temp217 = ((int)((uint)(temp215)) <= (int)((uint)((uint)191U)));
                        var temp218 = ((temp216) && (temp217));
                        if (temp218)
                        {
                            var temp219 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp220 = Fun0(((ushort)((s)._0)), ((ushort)(temp219)));
                            var temp221 = (((ushort)(temp220)) == ((ushort)((ushort)44U)));
                            if (temp221)
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
                        var temp222 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp223 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp222)));
                        var temp224 = ((int)((uint)(temp222)) <= (int)((uint)((uint)191U)));
                        var temp225 = ((temp223) && (temp224));
                        if (temp225)
                        {
                            var temp226 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp227 = Fun0(((ushort)((s)._0)), ((ushort)(temp226)));
                            s._0 = ((ushort)(temp227));
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
                        var temp228 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp229 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp228)));
                        var temp230 = ((int)((uint)(temp228)) <= (int)((uint)((uint)159U)));
                        var temp231 = ((temp229) && (temp230));
                        if (temp231)
                        {
                            var temp232 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp233 = Fun0(((ushort)((s)._0)), ((ushort)(temp232)));
                            s._0 = ((ushort)(temp233));
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
                        var temp234 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp235 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp234)));
                        var temp236 = ((int)((uint)(temp234)) <= (int)((uint)((uint)191U)));
                        var temp237 = ((temp235) && (temp236));
                        if (temp237)
                        {
                            var temp238 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp239 = Fun0(((ushort)((s)._0)), ((ushort)(temp238)));
                            s._0 = ((ushort)(temp239));
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
                        var temp240 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp241 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp240)));
                        var temp242 = ((int)((uint)(temp240)) <= (int)((uint)((uint)127U)));
                        var temp243 = ((temp241) && (temp242));
                        if (temp243)
                        {
                            var temp244 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp244)
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
                            var temp245 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp240)));
                            var temp246 = ((int)((uint)(temp240)) <= (int)((uint)((uint)223U)));
                            var temp247 = ((temp245) && (temp246));
                            if (temp247)
                            {
                                var temp248 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp248));
                                goto M27;
                            }
                            else
                            {
                                var temp249 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp249)
                                {
                                    var temp250 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp250));
                                    goto M28;
                                }
                                else
                                {
                                    var temp251 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp251)
                                    {
                                        var temp252 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp252));
                                        goto M29;
                                    }
                                    else
                                    {
                                        var temp253 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp240)));
                                        var temp254 = ((int)((uint)(temp240)) <= (int)((uint)((uint)239U)));
                                        var temp255 = ((temp253) && (temp254));
                                        if (temp255)
                                        {
                                            var temp256 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp256));
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
                        var temp257 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp258 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp257)));
                        var temp259 = ((int)((uint)(temp257)) <= (int)((uint)((uint)191U)));
                        var temp260 = ((temp258) && (temp259));
                        if (temp260)
                        {
                            var temp261 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp262 = Fun0(((ushort)((s)._0)), ((ushort)(temp261)));
                            var temp263 = (((ushort)(temp262)) == ((ushort)((ushort)44U)));
                            if (temp263)
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
                        var temp264 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp265 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp264)));
                        var temp266 = ((int)((uint)(temp264)) <= (int)((uint)((uint)191U)));
                        var temp267 = ((temp265) && (temp266));
                        if (temp267)
                        {
                            var temp268 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp269 = Fun0(((ushort)((s)._0)), ((ushort)(temp268)));
                            s._0 = ((ushort)(temp269));
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
                        var temp270 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp271 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp270)));
                        var temp272 = ((int)((uint)(temp270)) <= (int)((uint)((uint)159U)));
                        var temp273 = ((temp271) && (temp272));
                        if (temp273)
                        {
                            var temp274 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp275 = Fun0(((ushort)((s)._0)), ((ushort)(temp274)));
                            s._0 = ((ushort)(temp275));
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
                        var temp276 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp277 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp276)));
                        var temp278 = ((int)((uint)(temp276)) <= (int)((uint)((uint)191U)));
                        var temp279 = ((temp277) && (temp278));
                        if (temp279)
                        {
                            var temp280 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp281 = Fun0(((ushort)((s)._0)), ((ushort)(temp280)));
                            s._0 = ((ushort)(temp281));
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
                        var temp282 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp283 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp282)));
                        var temp284 = ((int)((uint)(temp282)) <= (int)((uint)((uint)127U)));
                        var temp285 = ((temp283) && (temp284));
                        if (temp285)
                        {
                            var temp286 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp287 = ((byte)(((byte)(i)) >> 6));
                            var temp288 = (((byte)(temp287 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp289 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp290 = (((temp286) && (temp288)) && (temp289));
                            if (temp290)
                            {
                                var temp291 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp292 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp291))) + ((uint)(temp282))));
                                s._1 = ((uint)(temp292));
                                goto M31;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp293 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp282)));
                            var temp294 = ((int)((uint)(temp282)) <= (int)((uint)((uint)223U)));
                            var temp295 = ((temp293) && (temp294));
                            if (temp295)
                            {
                                var temp296 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp296));
                                goto M32;
                            }
                            else
                            {
                                var temp297 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp297)
                                {
                                    var temp298 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp298));
                                    goto M33;
                                }
                                else
                                {
                                    var temp299 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp299)
                                    {
                                        var temp300 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp300));
                                        goto M34;
                                    }
                                    else
                                    {
                                        var temp301 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp282)));
                                        var temp302 = ((int)((uint)(temp282)) <= (int)((uint)((uint)239U)));
                                        var temp303 = ((temp301) && (temp302));
                                        if (temp303)
                                        {
                                            var temp304 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp304));
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
                        var temp305 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp306 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp305)));
                        var temp307 = ((int)((uint)(temp305)) <= (int)((uint)((uint)191U)));
                        var temp308 = ((temp306) && (temp307));
                        if (temp308)
                        {
                            var temp309 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp310 = Fun0(((ushort)((s)._0)), ((ushort)(temp309)));
                            var temp311 = (((ushort)(temp310)) == ((ushort)((ushort)44U)));
                            if (temp311)
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
                        var temp312 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp313 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp312)));
                        var temp314 = ((int)((uint)(temp312)) <= (int)((uint)((uint)191U)));
                        var temp315 = ((temp313) && (temp314));
                        if (temp315)
                        {
                            var temp316 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp317 = Fun0(((ushort)((s)._0)), ((ushort)(temp316)));
                            s._0 = ((ushort)(temp317));
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
                        var temp318 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp319 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp318)));
                        var temp320 = ((int)((uint)(temp318)) <= (int)((uint)((uint)159U)));
                        var temp321 = ((temp319) && (temp320));
                        if (temp321)
                        {
                            var temp322 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp323 = Fun0(((ushort)((s)._0)), ((ushort)(temp322)));
                            s._0 = ((ushort)(temp323));
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
                        var temp324 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp325 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp324)));
                        var temp326 = ((int)((uint)(temp324)) <= (int)((uint)((uint)191U)));
                        var temp327 = ((temp325) && (temp326));
                        if (temp327)
                        {
                            var temp328 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp329 = Fun0(((ushort)((s)._0)), ((ushort)(temp328)));
                            s._0 = ((ushort)(temp329));
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
                        var temp330 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp331 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp330)));
                        var temp332 = ((int)((uint)(temp330)) <= (int)((uint)((uint)127U)));
                        var temp333 = ((temp331) && (temp332));
                        if (temp333)
                        {
                            var temp334 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp334)
                            {
                                goto M36;
                            }
                            else
                            {
                                var temp335 = (((byte)(i)) == ((byte)((byte)46U)));
                                if (temp335)
                                {
                                    goto M37;
                                }
                                else
                                {
                                    var temp336 = (((byte)((byte)48U)) <= ((byte)(i)));
                                    var temp337 = ((byte)(((byte)(i)) >> 6));
                                    var temp338 = (((byte)(temp337 & 3L)) == ((byte)((byte)0U & 3L)));
                                    var temp339 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                    var temp340 = (((temp336) && (temp338)) && (temp339));
                                    if (temp340)
                                    {
                                        var temp341 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                        var temp342 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp341))) + ((uint)(temp330))));
                                        s._1 = ((uint)(temp342));
                                        goto M31;
                                    }
                                    else
                                        throw new Exception();
                                }
                            }
                        }
                        else
                        {
                            var temp343 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp330)));
                            var temp344 = ((int)((uint)(temp330)) <= (int)((uint)((uint)223U)));
                            var temp345 = ((temp343) && (temp344));
                            if (temp345)
                            {
                                var temp346 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp346));
                                goto M38;
                            }
                            else
                            {
                                var temp347 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp347)
                                {
                                    var temp348 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp348));
                                    goto M39;
                                }
                                else
                                {
                                    var temp349 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp349)
                                    {
                                        var temp350 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp350));
                                        goto M40;
                                    }
                                    else
                                    {
                                        var temp351 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp330)));
                                        var temp352 = ((int)((uint)(temp330)) <= (int)((uint)((uint)239U)));
                                        var temp353 = ((temp351) && (temp352));
                                        if (temp353)
                                        {
                                            var temp354 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp354));
                                            goto M41;
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
                        var temp355 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp356 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp355)));
                        var temp357 = ((int)((uint)(temp355)) <= (int)((uint)((uint)191U)));
                        var temp358 = ((temp356) && (temp357));
                        if (temp358)
                        {
                            var temp359 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp360 = Fun0(((ushort)((s)._0)), ((ushort)(temp359)));
                            var temp361 = (((ushort)((ushort)48U)) <= ((ushort)(temp360)));
                            var temp362 = ((ushort)(((ushort)(temp360)) >> 6));
                            var temp363 = (((ushort)(temp362 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp364 = (((byte)(((byte)((ushort)(temp360))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp365 = (((temp361) && (temp363)) && (temp364));
                            var temp366 = (((ushort)((ushort)1632U)) <= ((ushort)(temp360)));
                            var temp367 = ((byte)(((ushort)(temp360)) >> 11));
                            var temp368 = (((byte)(temp367 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp369 = (((ushort)(((ushort)((ushort)(temp360))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp370 = (((temp366) && (temp368)) && (temp369));
                            var temp371 = (((ushort)((ushort)1776U)) <= ((ushort)(temp360)));
                            var temp372 = (((ushort)(((ushort)((ushort)(temp360))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp373 = (((temp371) && (temp368)) && (temp372));
                            var temp374 = (((ushort)((ushort)1984U)) <= ((ushort)(temp360)));
                            var temp375 = (((ushort)(((ushort)((ushort)(temp360))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp376 = (((temp374) && (temp368)) && (temp375));
                            var temp377 = (((ushort)((ushort)2406U)) <= ((ushort)(temp360)));
                            var temp378 = ((byte)(((ushort)(temp360)) >> 12));
                            var temp379 = (((byte)(temp378 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp380 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp381 = (((temp377) && (temp379)) && (temp380));
                            var temp382 = (((ushort)((ushort)2534U)) <= ((ushort)(temp360)));
                            var temp383 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp384 = (((temp382) && (temp379)) && (temp383));
                            var temp385 = (((ushort)((ushort)2662U)) <= ((ushort)(temp360)));
                            var temp386 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp387 = (((temp385) && (temp379)) && (temp386));
                            var temp388 = (((ushort)((ushort)2790U)) <= ((ushort)(temp360)));
                            var temp389 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp390 = (((temp388) && (temp379)) && (temp389));
                            var temp391 = (((ushort)((ushort)2918U)) <= ((ushort)(temp360)));
                            var temp392 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp393 = (((temp391) && (temp379)) && (temp392));
                            var temp394 = (((ushort)((ushort)3046U)) <= ((ushort)(temp360)));
                            var temp395 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp396 = (((temp394) && (temp379)) && (temp395));
                            var temp397 = (((ushort)((ushort)3174U)) <= ((ushort)(temp360)));
                            var temp398 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp399 = (((temp397) && (temp379)) && (temp398));
                            var temp400 = (((ushort)((ushort)3302U)) <= ((ushort)(temp360)));
                            var temp401 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp402 = (((temp400) && (temp379)) && (temp401));
                            var temp403 = (((ushort)((ushort)3430U)) <= ((ushort)(temp360)));
                            var temp404 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp405 = (((temp403) && (temp379)) && (temp404));
                            var temp406 = (((ushort)((ushort)3664U)) <= ((ushort)(temp360)));
                            var temp407 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp408 = (((temp406) && (temp379)) && (temp407));
                            var temp409 = (((ushort)((ushort)3792U)) <= ((ushort)(temp360)));
                            var temp410 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp411 = (((temp409) && (temp379)) && (temp410));
                            var temp412 = (((ushort)((ushort)3872U)) <= ((ushort)(temp360)));
                            var temp413 = (((ushort)(((ushort)((ushort)(temp360))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp414 = (((temp412) && (temp379)) && (temp413));
                            var temp415 = (((ushort)((ushort)4160U)) <= ((ushort)(temp360)));
                            var temp416 = ((byte)(((ushort)(temp360)) >> 13));
                            var temp417 = (((byte)(temp416 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp418 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp419 = (((temp415) && (temp417)) && (temp418));
                            var temp420 = (((ushort)((ushort)4240U)) <= ((ushort)(temp360)));
                            var temp421 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp422 = (((temp420) && (temp417)) && (temp421));
                            var temp423 = (((ushort)((ushort)6112U)) <= ((ushort)(temp360)));
                            var temp424 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp425 = (((temp423) && (temp417)) && (temp424));
                            var temp426 = (((ushort)((ushort)6160U)) <= ((ushort)(temp360)));
                            var temp427 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp428 = (((temp426) && (temp417)) && (temp427));
                            var temp429 = (((ushort)((ushort)6470U)) <= ((ushort)(temp360)));
                            var temp430 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp431 = (((temp429) && (temp417)) && (temp430));
                            var temp432 = (((ushort)((ushort)6608U)) <= ((ushort)(temp360)));
                            var temp433 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp434 = (((temp432) && (temp417)) && (temp433));
                            var temp435 = (((ushort)((ushort)6992U)) <= ((ushort)(temp360)));
                            var temp436 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp437 = (((temp435) && (temp417)) && (temp436));
                            var temp438 = (((ushort)((ushort)7088U)) <= ((ushort)(temp360)));
                            var temp439 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp440 = (((temp438) && (temp417)) && (temp439));
                            var temp441 = (((ushort)((ushort)7232U)) <= ((ushort)(temp360)));
                            var temp442 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp443 = (((temp441) && (temp417)) && (temp442));
                            var temp444 = (((ushort)((ushort)7248U)) <= ((ushort)(temp360)));
                            var temp445 = (((ushort)(((ushort)((ushort)(temp360))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp446 = (((temp444) && (temp417)) && (temp445));
                            var temp447 = (((ushort)((ushort)42528U)) <= ((ushort)(temp360)));
                            var temp448 = (((ushort)(temp360)) <= ((ushort)((ushort)42537U)));
                            var temp449 = ((temp447) && (temp448));
                            var temp450 = (((ushort)((ushort)43216U)) <= ((ushort)(temp360)));
                            var temp451 = (((ushort)(temp360)) <= ((ushort)((ushort)43225U)));
                            var temp452 = ((temp450) && (temp451));
                            var temp453 = (((ushort)((ushort)43264U)) <= ((ushort)(temp360)));
                            var temp454 = (((ushort)(temp360)) <= ((ushort)((ushort)43273U)));
                            var temp455 = ((temp453) && (temp454));
                            var temp456 = (((ushort)((ushort)43600U)) <= ((ushort)(temp360)));
                            var temp457 = (((ushort)(temp360)) <= ((ushort)((ushort)43609U)));
                            var temp458 = ((temp456) && (temp457));
                            var temp459 = (((ushort)((ushort)65296U)) <= ((ushort)(temp360)));
                            var temp460 = (((ushort)(temp360)) <= ((ushort)((ushort)65305U)));
                            var temp461 = ((temp459) && (temp460));
                            var temp462 = (((((((((((((((((((((((((((((((temp365) || (temp370)) || (temp373)) || (temp376)) || (temp381)) || (temp384)) || (temp387)) || (temp390)) || (temp393)) || (temp396)) || (temp399)) || (temp402)) || (temp405)) || (temp408)) || (temp411)) || (temp414)) || (temp419)) || (temp422)) || (temp425)) || (temp428)) || (temp431)) || (temp434)) || (temp437)) || (temp440)) || (temp443)) || (temp446)) || (temp449)) || (temp452)) || (temp455)) || (temp458)) || (temp461));
                            if (temp462)
                            {
                                var temp463 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp464 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp360));
                                var temp465 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp463))) + ((uint)(temp464))));
                                s._1 = ((uint)(temp465));
                                s._0 = ((ushort)((ushort)0U));
                                goto M31;
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
                        var temp466 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp467 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp466)));
                        var temp468 = ((int)((uint)(temp466)) <= (int)((uint)((uint)191U)));
                        var temp469 = ((temp467) && (temp468));
                        if (temp469)
                        {
                            var temp470 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp471 = Fun0(((ushort)((s)._0)), ((ushort)(temp470)));
                            s._0 = ((ushort)(temp471));
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
                        var temp472 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp473 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp472)));
                        var temp474 = ((int)((uint)(temp472)) <= (int)((uint)((uint)159U)));
                        var temp475 = ((temp473) && (temp474));
                        if (temp475)
                        {
                            var temp476 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp477 = Fun0(((ushort)((s)._0)), ((ushort)(temp476)));
                            s._0 = ((ushort)(temp477));
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
                        var temp478 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp479 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp478)));
                        var temp480 = ((int)((uint)(temp478)) <= (int)((uint)((uint)191U)));
                        var temp481 = ((temp479) && (temp480));
                        if (temp481)
                        {
                            var temp482 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp483 = Fun0(((ushort)((s)._0)), ((ushort)(temp482)));
                            s._0 = ((ushort)(temp483));
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
                        var temp484 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp485 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp484)));
                        var temp486 = ((int)((uint)(temp484)) <= (int)((uint)((uint)127U)));
                        var temp487 = ((temp485) && (temp486));
                        if (temp487)
                        {
                            var temp488 = (((byte)(i)) == ((byte)((byte)10U)));
                            if (temp488)
                            {
                                var temp489 = ((uint)(((uint)((uint)1U)) + ((uint)((s)._3))));
                                s._3 = ((uint)(temp489));
                                var temp490 = ((byte)(((uint)((s)._1)) >> 31));
                                var temp491 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 1) | (ulong)((byte)(temp490 & 1L)) << 32) | (ulong)((uint)((s)._1));
                                var temp492 = ((ulong)(((ulong)((s)._2)) + ((ulong)(temp491))));
                                s._2 = ((ulong)(temp492));
                                s._1 = ((uint)((uint)0U));
                                goto M0;
                            }
                            else
                            {
                                goto M36;
                            }
                        }
                        else
                        {
                            var temp493 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp484)));
                            var temp494 = ((int)((uint)(temp484)) <= (int)((uint)((uint)223U)));
                            var temp495 = ((temp493) && (temp494));
                            if (temp495)
                            {
                                var temp496 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp496));
                                goto M51;
                            }
                            else
                            {
                                var temp497 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp497)
                                {
                                    var temp498 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp498));
                                    goto M52;
                                }
                                else
                                {
                                    var temp499 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp499)
                                    {
                                        var temp500 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp500));
                                        goto M53;
                                    }
                                    else
                                    {
                                        var temp501 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp484)));
                                        var temp502 = ((int)((uint)(temp484)) <= (int)((uint)((uint)239U)));
                                        var temp503 = ((temp501) && (temp502));
                                        if (temp503)
                                        {
                                            var temp504 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp504));
                                            goto M54;
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
                        var temp505 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp506 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp505)));
                        var temp507 = ((int)((uint)(temp505)) <= (int)((uint)((uint)127U)));
                        var temp508 = ((temp506) && (temp507));
                        if (temp508)
                        {
                            var temp509 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp510 = ((byte)(((byte)(i)) >> 6));
                            var temp511 = (((byte)(temp510 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp512 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp513 = (((temp509) && (temp511)) && (temp512));
                            if (temp513)
                            {
                                goto M42;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp514 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp505)));
                            var temp515 = ((int)((uint)(temp505)) <= (int)((uint)((uint)223U)));
                            var temp516 = ((temp514) && (temp515));
                            if (temp516)
                            {
                                var temp517 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp517));
                                goto M43;
                            }
                            else
                            {
                                var temp518 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp518)
                                {
                                    var temp519 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp519));
                                    goto M44;
                                }
                                else
                                {
                                    var temp520 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp520)
                                    {
                                        var temp521 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp521));
                                        goto M45;
                                    }
                                    else
                                    {
                                        var temp522 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp505)));
                                        var temp523 = ((int)((uint)(temp505)) <= (int)((uint)((uint)239U)));
                                        var temp524 = ((temp522) && (temp523));
                                        if (temp524)
                                        {
                                            var temp525 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp525));
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

                M38:
                {
                    if (++iIndex >= input.Length)
                        goto F38;
                    i = input[iIndex];
                    {
                        var temp526 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp527 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp526)));
                        var temp528 = ((int)((uint)(temp526)) <= (int)((uint)((uint)191U)));
                        var temp529 = ((temp527) && (temp528));
                        if (temp529)
                        {
                            var temp530 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp531 = Fun0(((ushort)((s)._0)), ((ushort)(temp530)));
                            var temp532 = (((ushort)(temp531)) == ((ushort)((ushort)44U)));
                            if (temp532)
                                throw new Exception();
                            else
                            {
                                var temp533 = (((ushort)(temp531)) == ((ushort)((ushort)46U)));
                                if (temp533)
                                    throw new Exception();
                                else
                                {
                                    var temp534 = (((ushort)((ushort)48U)) <= ((ushort)(temp531)));
                                    var temp535 = ((ushort)(((ushort)(temp531)) >> 6));
                                    var temp536 = (((ushort)(temp535 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                    var temp537 = (((byte)(((byte)((ushort)(temp531))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                    var temp538 = (((temp534) && (temp536)) && (temp537));
                                    var temp539 = (((ushort)((ushort)1632U)) <= ((ushort)(temp531)));
                                    var temp540 = ((byte)(((ushort)(temp531)) >> 11));
                                    var temp541 = (((byte)(temp540 & 31L)) == ((byte)((byte)0U & 31L)));
                                    var temp542 = (((ushort)(((ushort)((ushort)(temp531))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                    var temp543 = (((temp539) && (temp541)) && (temp542));
                                    var temp544 = (((ushort)((ushort)1776U)) <= ((ushort)(temp531)));
                                    var temp545 = (((ushort)(((ushort)((ushort)(temp531))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                    var temp546 = (((temp544) && (temp541)) && (temp545));
                                    var temp547 = (((ushort)((ushort)1984U)) <= ((ushort)(temp531)));
                                    var temp548 = (((ushort)(((ushort)((ushort)(temp531))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                    var temp549 = (((temp547) && (temp541)) && (temp548));
                                    var temp550 = (((ushort)((ushort)2406U)) <= ((ushort)(temp531)));
                                    var temp551 = ((byte)(((ushort)(temp531)) >> 12));
                                    var temp552 = (((byte)(temp551 & 15L)) == ((byte)((byte)0U & 15L)));
                                    var temp553 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                    var temp554 = (((temp550) && (temp552)) && (temp553));
                                    var temp555 = (((ushort)((ushort)2534U)) <= ((ushort)(temp531)));
                                    var temp556 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                    var temp557 = (((temp555) && (temp552)) && (temp556));
                                    var temp558 = (((ushort)((ushort)2662U)) <= ((ushort)(temp531)));
                                    var temp559 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                    var temp560 = (((temp558) && (temp552)) && (temp559));
                                    var temp561 = (((ushort)((ushort)2790U)) <= ((ushort)(temp531)));
                                    var temp562 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                    var temp563 = (((temp561) && (temp552)) && (temp562));
                                    var temp564 = (((ushort)((ushort)2918U)) <= ((ushort)(temp531)));
                                    var temp565 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                    var temp566 = (((temp564) && (temp552)) && (temp565));
                                    var temp567 = (((ushort)((ushort)3046U)) <= ((ushort)(temp531)));
                                    var temp568 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                    var temp569 = (((temp567) && (temp552)) && (temp568));
                                    var temp570 = (((ushort)((ushort)3174U)) <= ((ushort)(temp531)));
                                    var temp571 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                    var temp572 = (((temp570) && (temp552)) && (temp571));
                                    var temp573 = (((ushort)((ushort)3302U)) <= ((ushort)(temp531)));
                                    var temp574 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                    var temp575 = (((temp573) && (temp552)) && (temp574));
                                    var temp576 = (((ushort)((ushort)3430U)) <= ((ushort)(temp531)));
                                    var temp577 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                    var temp578 = (((temp576) && (temp552)) && (temp577));
                                    var temp579 = (((ushort)((ushort)3664U)) <= ((ushort)(temp531)));
                                    var temp580 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                    var temp581 = (((temp579) && (temp552)) && (temp580));
                                    var temp582 = (((ushort)((ushort)3792U)) <= ((ushort)(temp531)));
                                    var temp583 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                    var temp584 = (((temp582) && (temp552)) && (temp583));
                                    var temp585 = (((ushort)((ushort)3872U)) <= ((ushort)(temp531)));
                                    var temp586 = (((ushort)(((ushort)((ushort)(temp531))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                    var temp587 = (((temp585) && (temp552)) && (temp586));
                                    var temp588 = (((ushort)((ushort)4160U)) <= ((ushort)(temp531)));
                                    var temp589 = ((byte)(((ushort)(temp531)) >> 13));
                                    var temp590 = (((byte)(temp589 & 7L)) == ((byte)((byte)0U & 7L)));
                                    var temp591 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                    var temp592 = (((temp588) && (temp590)) && (temp591));
                                    var temp593 = (((ushort)((ushort)4240U)) <= ((ushort)(temp531)));
                                    var temp594 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                    var temp595 = (((temp593) && (temp590)) && (temp594));
                                    var temp596 = (((ushort)((ushort)6112U)) <= ((ushort)(temp531)));
                                    var temp597 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                    var temp598 = (((temp596) && (temp590)) && (temp597));
                                    var temp599 = (((ushort)((ushort)6160U)) <= ((ushort)(temp531)));
                                    var temp600 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                    var temp601 = (((temp599) && (temp590)) && (temp600));
                                    var temp602 = (((ushort)((ushort)6470U)) <= ((ushort)(temp531)));
                                    var temp603 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                    var temp604 = (((temp602) && (temp590)) && (temp603));
                                    var temp605 = (((ushort)((ushort)6608U)) <= ((ushort)(temp531)));
                                    var temp606 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                    var temp607 = (((temp605) && (temp590)) && (temp606));
                                    var temp608 = (((ushort)((ushort)6992U)) <= ((ushort)(temp531)));
                                    var temp609 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                    var temp610 = (((temp608) && (temp590)) && (temp609));
                                    var temp611 = (((ushort)((ushort)7088U)) <= ((ushort)(temp531)));
                                    var temp612 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                    var temp613 = (((temp611) && (temp590)) && (temp612));
                                    var temp614 = (((ushort)((ushort)7232U)) <= ((ushort)(temp531)));
                                    var temp615 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                    var temp616 = (((temp614) && (temp590)) && (temp615));
                                    var temp617 = (((ushort)((ushort)7248U)) <= ((ushort)(temp531)));
                                    var temp618 = (((ushort)(((ushort)((ushort)(temp531))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                    var temp619 = (((temp617) && (temp590)) && (temp618));
                                    var temp620 = (((ushort)((ushort)42528U)) <= ((ushort)(temp531)));
                                    var temp621 = (((ushort)(temp531)) <= ((ushort)((ushort)42537U)));
                                    var temp622 = ((temp620) && (temp621));
                                    var temp623 = (((ushort)((ushort)43216U)) <= ((ushort)(temp531)));
                                    var temp624 = (((ushort)(temp531)) <= ((ushort)((ushort)43225U)));
                                    var temp625 = ((temp623) && (temp624));
                                    var temp626 = (((ushort)((ushort)43264U)) <= ((ushort)(temp531)));
                                    var temp627 = (((ushort)(temp531)) <= ((ushort)((ushort)43273U)));
                                    var temp628 = ((temp626) && (temp627));
                                    var temp629 = (((ushort)((ushort)43600U)) <= ((ushort)(temp531)));
                                    var temp630 = (((ushort)(temp531)) <= ((ushort)((ushort)43609U)));
                                    var temp631 = ((temp629) && (temp630));
                                    var temp632 = (((ushort)((ushort)65296U)) <= ((ushort)(temp531)));
                                    var temp633 = (((ushort)(temp531)) <= ((ushort)((ushort)65305U)));
                                    var temp634 = ((temp632) && (temp633));
                                    var temp635 = (((((((((((((((((((((((((((((((temp538) || (temp543)) || (temp546)) || (temp549)) || (temp554)) || (temp557)) || (temp560)) || (temp563)) || (temp566)) || (temp569)) || (temp572)) || (temp575)) || (temp578)) || (temp581)) || (temp584)) || (temp587)) || (temp592)) || (temp595)) || (temp598)) || (temp601)) || (temp604)) || (temp607)) || (temp610)) || (temp613)) || (temp616)) || (temp619)) || (temp622)) || (temp625)) || (temp628)) || (temp631)) || (temp634));
                                    if (temp635)
                                    {
                                        var temp636 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                        var temp637 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp531));
                                        var temp638 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp636))) + ((uint)(temp637))));
                                        s._1 = ((uint)(temp638));
                                        s._0 = ((ushort)((ushort)0U));
                                        goto M31;
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

                M39:
                {
                    if (++iIndex >= input.Length)
                        goto F39;
                    i = input[iIndex];
                    {
                        var temp639 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp640 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp639)));
                        var temp641 = ((int)((uint)(temp639)) <= (int)((uint)((uint)191U)));
                        var temp642 = ((temp640) && (temp641));
                        if (temp642)
                        {
                            var temp643 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp644 = Fun0(((ushort)((s)._0)), ((ushort)(temp643)));
                            s._0 = ((ushort)(temp644));
                            goto M38;
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
                        var temp645 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp646 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp645)));
                        var temp647 = ((int)((uint)(temp645)) <= (int)((uint)((uint)159U)));
                        var temp648 = ((temp646) && (temp647));
                        if (temp648)
                        {
                            var temp649 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp650 = Fun0(((ushort)((s)._0)), ((ushort)(temp649)));
                            s._0 = ((ushort)(temp650));
                            goto M38;
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
                        var temp651 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp652 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp651)));
                        var temp653 = ((int)((uint)(temp651)) <= (int)((uint)((uint)191U)));
                        var temp654 = ((temp652) && (temp653));
                        if (temp654)
                        {
                            var temp655 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp656 = Fun0(((ushort)((s)._0)), ((ushort)(temp655)));
                            s._0 = ((ushort)(temp656));
                            goto M38;
                        }
                        else
                            throw new Exception();
                    }
                }

                M42:
                {
                    if (++iIndex >= input.Length)
                        goto F42;
                    i = input[iIndex];
                    {
                        var temp657 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp658 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp657)));
                        var temp659 = ((int)((uint)(temp657)) <= (int)((uint)((uint)127U)));
                        var temp660 = ((temp658) && (temp659));
                        if (temp660)
                        {
                            var temp661 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp661)
                            {
                                goto M36;
                            }
                            else
                            {
                                var temp662 = (((byte)((byte)48U)) <= ((byte)(i)));
                                var temp663 = ((byte)(((byte)(i)) >> 6));
                                var temp664 = (((byte)(temp663 & 3L)) == ((byte)((byte)0U & 3L)));
                                var temp665 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp666 = (((temp662) && (temp664)) && (temp665));
                                if (temp666)
                                {
                                    goto M42;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                        else
                        {
                            var temp667 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp657)));
                            var temp668 = ((int)((uint)(temp657)) <= (int)((uint)((uint)223U)));
                            var temp669 = ((temp667) && (temp668));
                            if (temp669)
                            {
                                var temp670 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp670));
                                goto M47;
                            }
                            else
                            {
                                var temp671 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp671)
                                {
                                    var temp672 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp672));
                                    goto M48;
                                }
                                else
                                {
                                    var temp673 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp673)
                                    {
                                        var temp674 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp674));
                                        goto M49;
                                    }
                                    else
                                    {
                                        var temp675 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp657)));
                                        var temp676 = ((int)((uint)(temp657)) <= (int)((uint)((uint)239U)));
                                        var temp677 = ((temp675) && (temp676));
                                        if (temp677)
                                        {
                                            var temp678 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp678));
                                            goto M50;
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
                        var temp679 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp680 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp679)));
                        var temp681 = ((int)((uint)(temp679)) <= (int)((uint)((uint)191U)));
                        var temp682 = ((temp680) && (temp681));
                        if (temp682)
                        {
                            var temp683 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp684 = Fun0(((ushort)((s)._0)), ((ushort)(temp683)));
                            var temp685 = (((ushort)((ushort)48U)) <= ((ushort)(temp684)));
                            var temp686 = ((ushort)(((ushort)(temp684)) >> 6));
                            var temp687 = (((ushort)(temp686 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp688 = (((byte)(((byte)((ushort)(temp684))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp689 = (((temp685) && (temp687)) && (temp688));
                            var temp690 = (((ushort)((ushort)1632U)) <= ((ushort)(temp684)));
                            var temp691 = ((byte)(((ushort)(temp684)) >> 11));
                            var temp692 = (((byte)(temp691 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp693 = (((ushort)(((ushort)((ushort)(temp684))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp694 = (((temp690) && (temp692)) && (temp693));
                            var temp695 = (((ushort)((ushort)1776U)) <= ((ushort)(temp684)));
                            var temp696 = (((ushort)(((ushort)((ushort)(temp684))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp697 = (((temp695) && (temp692)) && (temp696));
                            var temp698 = (((ushort)((ushort)1984U)) <= ((ushort)(temp684)));
                            var temp699 = (((ushort)(((ushort)((ushort)(temp684))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp700 = (((temp698) && (temp692)) && (temp699));
                            var temp701 = (((ushort)((ushort)2406U)) <= ((ushort)(temp684)));
                            var temp702 = ((byte)(((ushort)(temp684)) >> 12));
                            var temp703 = (((byte)(temp702 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp704 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp705 = (((temp701) && (temp703)) && (temp704));
                            var temp706 = (((ushort)((ushort)2534U)) <= ((ushort)(temp684)));
                            var temp707 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp708 = (((temp706) && (temp703)) && (temp707));
                            var temp709 = (((ushort)((ushort)2662U)) <= ((ushort)(temp684)));
                            var temp710 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp711 = (((temp709) && (temp703)) && (temp710));
                            var temp712 = (((ushort)((ushort)2790U)) <= ((ushort)(temp684)));
                            var temp713 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp714 = (((temp712) && (temp703)) && (temp713));
                            var temp715 = (((ushort)((ushort)2918U)) <= ((ushort)(temp684)));
                            var temp716 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp717 = (((temp715) && (temp703)) && (temp716));
                            var temp718 = (((ushort)((ushort)3046U)) <= ((ushort)(temp684)));
                            var temp719 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp720 = (((temp718) && (temp703)) && (temp719));
                            var temp721 = (((ushort)((ushort)3174U)) <= ((ushort)(temp684)));
                            var temp722 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp723 = (((temp721) && (temp703)) && (temp722));
                            var temp724 = (((ushort)((ushort)3302U)) <= ((ushort)(temp684)));
                            var temp725 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp726 = (((temp724) && (temp703)) && (temp725));
                            var temp727 = (((ushort)((ushort)3430U)) <= ((ushort)(temp684)));
                            var temp728 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp729 = (((temp727) && (temp703)) && (temp728));
                            var temp730 = (((ushort)((ushort)3664U)) <= ((ushort)(temp684)));
                            var temp731 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp732 = (((temp730) && (temp703)) && (temp731));
                            var temp733 = (((ushort)((ushort)3792U)) <= ((ushort)(temp684)));
                            var temp734 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp735 = (((temp733) && (temp703)) && (temp734));
                            var temp736 = (((ushort)((ushort)3872U)) <= ((ushort)(temp684)));
                            var temp737 = (((ushort)(((ushort)((ushort)(temp684))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp738 = (((temp736) && (temp703)) && (temp737));
                            var temp739 = (((ushort)((ushort)4160U)) <= ((ushort)(temp684)));
                            var temp740 = ((byte)(((ushort)(temp684)) >> 13));
                            var temp741 = (((byte)(temp740 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp742 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp743 = (((temp739) && (temp741)) && (temp742));
                            var temp744 = (((ushort)((ushort)4240U)) <= ((ushort)(temp684)));
                            var temp745 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp746 = (((temp744) && (temp741)) && (temp745));
                            var temp747 = (((ushort)((ushort)6112U)) <= ((ushort)(temp684)));
                            var temp748 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp749 = (((temp747) && (temp741)) && (temp748));
                            var temp750 = (((ushort)((ushort)6160U)) <= ((ushort)(temp684)));
                            var temp751 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp752 = (((temp750) && (temp741)) && (temp751));
                            var temp753 = (((ushort)((ushort)6470U)) <= ((ushort)(temp684)));
                            var temp754 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp755 = (((temp753) && (temp741)) && (temp754));
                            var temp756 = (((ushort)((ushort)6608U)) <= ((ushort)(temp684)));
                            var temp757 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp758 = (((temp756) && (temp741)) && (temp757));
                            var temp759 = (((ushort)((ushort)6992U)) <= ((ushort)(temp684)));
                            var temp760 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp761 = (((temp759) && (temp741)) && (temp760));
                            var temp762 = (((ushort)((ushort)7088U)) <= ((ushort)(temp684)));
                            var temp763 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp764 = (((temp762) && (temp741)) && (temp763));
                            var temp765 = (((ushort)((ushort)7232U)) <= ((ushort)(temp684)));
                            var temp766 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp767 = (((temp765) && (temp741)) && (temp766));
                            var temp768 = (((ushort)((ushort)7248U)) <= ((ushort)(temp684)));
                            var temp769 = (((ushort)(((ushort)((ushort)(temp684))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp770 = (((temp768) && (temp741)) && (temp769));
                            var temp771 = (((ushort)((ushort)42528U)) <= ((ushort)(temp684)));
                            var temp772 = (((ushort)(temp684)) <= ((ushort)((ushort)42537U)));
                            var temp773 = ((temp771) && (temp772));
                            var temp774 = (((ushort)((ushort)43216U)) <= ((ushort)(temp684)));
                            var temp775 = (((ushort)(temp684)) <= ((ushort)((ushort)43225U)));
                            var temp776 = ((temp774) && (temp775));
                            var temp777 = (((ushort)((ushort)43264U)) <= ((ushort)(temp684)));
                            var temp778 = (((ushort)(temp684)) <= ((ushort)((ushort)43273U)));
                            var temp779 = ((temp777) && (temp778));
                            var temp780 = (((ushort)((ushort)43600U)) <= ((ushort)(temp684)));
                            var temp781 = (((ushort)(temp684)) <= ((ushort)((ushort)43609U)));
                            var temp782 = ((temp780) && (temp781));
                            var temp783 = (((ushort)((ushort)65296U)) <= ((ushort)(temp684)));
                            var temp784 = (((ushort)(temp684)) <= ((ushort)((ushort)65305U)));
                            var temp785 = ((temp783) && (temp784));
                            var temp786 = (((((((((((((((((((((((((((((((temp689) || (temp694)) || (temp697)) || (temp700)) || (temp705)) || (temp708)) || (temp711)) || (temp714)) || (temp717)) || (temp720)) || (temp723)) || (temp726)) || (temp729)) || (temp732)) || (temp735)) || (temp738)) || (temp743)) || (temp746)) || (temp749)) || (temp752)) || (temp755)) || (temp758)) || (temp761)) || (temp764)) || (temp767)) || (temp770)) || (temp773)) || (temp776)) || (temp779)) || (temp782)) || (temp785));
                            if (temp786)
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M42;
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
                        var temp787 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp788 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp787)));
                        var temp789 = ((int)((uint)(temp787)) <= (int)((uint)((uint)191U)));
                        var temp790 = ((temp788) && (temp789));
                        if (temp790)
                        {
                            var temp791 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp792 = Fun0(((ushort)((s)._0)), ((ushort)(temp791)));
                            s._0 = ((ushort)(temp792));
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
                        var temp793 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp794 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp793)));
                        var temp795 = ((int)((uint)(temp793)) <= (int)((uint)((uint)159U)));
                        var temp796 = ((temp794) && (temp795));
                        if (temp796)
                        {
                            var temp797 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp798 = Fun0(((ushort)((s)._0)), ((ushort)(temp797)));
                            s._0 = ((ushort)(temp798));
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
                        var temp799 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp800 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp799)));
                        var temp801 = ((int)((uint)(temp799)) <= (int)((uint)((uint)191U)));
                        var temp802 = ((temp800) && (temp801));
                        if (temp802)
                        {
                            var temp803 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp804 = Fun0(((ushort)((s)._0)), ((ushort)(temp803)));
                            s._0 = ((ushort)(temp804));
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
                        var temp805 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp806 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp805)));
                        var temp807 = ((int)((uint)(temp805)) <= (int)((uint)((uint)191U)));
                        var temp808 = ((temp806) && (temp807));
                        if (temp808)
                        {
                            var temp809 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp810 = Fun0(((ushort)((s)._0)), ((ushort)(temp809)));
                            var temp811 = (((ushort)(temp810)) == ((ushort)((ushort)44U)));
                            if (temp811)
                                throw new Exception();
                            else
                            {
                                var temp812 = (((ushort)((ushort)48U)) <= ((ushort)(temp810)));
                                var temp813 = ((ushort)(((ushort)(temp810)) >> 6));
                                var temp814 = (((ushort)(temp813 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                var temp815 = (((byte)(((byte)((ushort)(temp810))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp816 = (((temp812) && (temp814)) && (temp815));
                                var temp817 = (((ushort)((ushort)1632U)) <= ((ushort)(temp810)));
                                var temp818 = ((byte)(((ushort)(temp810)) >> 11));
                                var temp819 = (((byte)(temp818 & 31L)) == ((byte)((byte)0U & 31L)));
                                var temp820 = (((ushort)(((ushort)((ushort)(temp810))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                var temp821 = (((temp817) && (temp819)) && (temp820));
                                var temp822 = (((ushort)((ushort)1776U)) <= ((ushort)(temp810)));
                                var temp823 = (((ushort)(((ushort)((ushort)(temp810))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                var temp824 = (((temp822) && (temp819)) && (temp823));
                                var temp825 = (((ushort)((ushort)1984U)) <= ((ushort)(temp810)));
                                var temp826 = (((ushort)(((ushort)((ushort)(temp810))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                var temp827 = (((temp825) && (temp819)) && (temp826));
                                var temp828 = (((ushort)((ushort)2406U)) <= ((ushort)(temp810)));
                                var temp829 = ((byte)(((ushort)(temp810)) >> 12));
                                var temp830 = (((byte)(temp829 & 15L)) == ((byte)((byte)0U & 15L)));
                                var temp831 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                var temp832 = (((temp828) && (temp830)) && (temp831));
                                var temp833 = (((ushort)((ushort)2534U)) <= ((ushort)(temp810)));
                                var temp834 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                var temp835 = (((temp833) && (temp830)) && (temp834));
                                var temp836 = (((ushort)((ushort)2662U)) <= ((ushort)(temp810)));
                                var temp837 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                var temp838 = (((temp836) && (temp830)) && (temp837));
                                var temp839 = (((ushort)((ushort)2790U)) <= ((ushort)(temp810)));
                                var temp840 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                var temp841 = (((temp839) && (temp830)) && (temp840));
                                var temp842 = (((ushort)((ushort)2918U)) <= ((ushort)(temp810)));
                                var temp843 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                var temp844 = (((temp842) && (temp830)) && (temp843));
                                var temp845 = (((ushort)((ushort)3046U)) <= ((ushort)(temp810)));
                                var temp846 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                var temp847 = (((temp845) && (temp830)) && (temp846));
                                var temp848 = (((ushort)((ushort)3174U)) <= ((ushort)(temp810)));
                                var temp849 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                var temp850 = (((temp848) && (temp830)) && (temp849));
                                var temp851 = (((ushort)((ushort)3302U)) <= ((ushort)(temp810)));
                                var temp852 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                var temp853 = (((temp851) && (temp830)) && (temp852));
                                var temp854 = (((ushort)((ushort)3430U)) <= ((ushort)(temp810)));
                                var temp855 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                var temp856 = (((temp854) && (temp830)) && (temp855));
                                var temp857 = (((ushort)((ushort)3664U)) <= ((ushort)(temp810)));
                                var temp858 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                var temp859 = (((temp857) && (temp830)) && (temp858));
                                var temp860 = (((ushort)((ushort)3792U)) <= ((ushort)(temp810)));
                                var temp861 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                var temp862 = (((temp860) && (temp830)) && (temp861));
                                var temp863 = (((ushort)((ushort)3872U)) <= ((ushort)(temp810)));
                                var temp864 = (((ushort)(((ushort)((ushort)(temp810))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                var temp865 = (((temp863) && (temp830)) && (temp864));
                                var temp866 = (((ushort)((ushort)4160U)) <= ((ushort)(temp810)));
                                var temp867 = ((byte)(((ushort)(temp810)) >> 13));
                                var temp868 = (((byte)(temp867 & 7L)) == ((byte)((byte)0U & 7L)));
                                var temp869 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                var temp870 = (((temp866) && (temp868)) && (temp869));
                                var temp871 = (((ushort)((ushort)4240U)) <= ((ushort)(temp810)));
                                var temp872 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                var temp873 = (((temp871) && (temp868)) && (temp872));
                                var temp874 = (((ushort)((ushort)6112U)) <= ((ushort)(temp810)));
                                var temp875 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                var temp876 = (((temp874) && (temp868)) && (temp875));
                                var temp877 = (((ushort)((ushort)6160U)) <= ((ushort)(temp810)));
                                var temp878 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                var temp879 = (((temp877) && (temp868)) && (temp878));
                                var temp880 = (((ushort)((ushort)6470U)) <= ((ushort)(temp810)));
                                var temp881 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                var temp882 = (((temp880) && (temp868)) && (temp881));
                                var temp883 = (((ushort)((ushort)6608U)) <= ((ushort)(temp810)));
                                var temp884 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                var temp885 = (((temp883) && (temp868)) && (temp884));
                                var temp886 = (((ushort)((ushort)6992U)) <= ((ushort)(temp810)));
                                var temp887 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                var temp888 = (((temp886) && (temp868)) && (temp887));
                                var temp889 = (((ushort)((ushort)7088U)) <= ((ushort)(temp810)));
                                var temp890 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                var temp891 = (((temp889) && (temp868)) && (temp890));
                                var temp892 = (((ushort)((ushort)7232U)) <= ((ushort)(temp810)));
                                var temp893 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                var temp894 = (((temp892) && (temp868)) && (temp893));
                                var temp895 = (((ushort)((ushort)7248U)) <= ((ushort)(temp810)));
                                var temp896 = (((ushort)(((ushort)((ushort)(temp810))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                var temp897 = (((temp895) && (temp868)) && (temp896));
                                var temp898 = (((ushort)((ushort)42528U)) <= ((ushort)(temp810)));
                                var temp899 = (((ushort)(temp810)) <= ((ushort)((ushort)42537U)));
                                var temp900 = ((temp898) && (temp899));
                                var temp901 = (((ushort)((ushort)43216U)) <= ((ushort)(temp810)));
                                var temp902 = (((ushort)(temp810)) <= ((ushort)((ushort)43225U)));
                                var temp903 = ((temp901) && (temp902));
                                var temp904 = (((ushort)((ushort)43264U)) <= ((ushort)(temp810)));
                                var temp905 = (((ushort)(temp810)) <= ((ushort)((ushort)43273U)));
                                var temp906 = ((temp904) && (temp905));
                                var temp907 = (((ushort)((ushort)43600U)) <= ((ushort)(temp810)));
                                var temp908 = (((ushort)(temp810)) <= ((ushort)((ushort)43609U)));
                                var temp909 = ((temp907) && (temp908));
                                var temp910 = (((ushort)((ushort)65296U)) <= ((ushort)(temp810)));
                                var temp911 = (((ushort)(temp810)) <= ((ushort)((ushort)65305U)));
                                var temp912 = ((temp910) && (temp911));
                                var temp913 = (((((((((((((((((((((((((((((((temp816) || (temp821)) || (temp824)) || (temp827)) || (temp832)) || (temp835)) || (temp838)) || (temp841)) || (temp844)) || (temp847)) || (temp850)) || (temp853)) || (temp856)) || (temp859)) || (temp862)) || (temp865)) || (temp870)) || (temp873)) || (temp876)) || (temp879)) || (temp882)) || (temp885)) || (temp888)) || (temp891)) || (temp894)) || (temp897)) || (temp900)) || (temp903)) || (temp906)) || (temp909)) || (temp912));
                                if (temp913)
                                {
                                    s._0 = ((ushort)((ushort)0U));
                                    goto M42;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                        else
                            throw new Exception();
                    }
                }

                M48:
                {
                    if (++iIndex >= input.Length)
                        goto F48;
                    i = input[iIndex];
                    {
                        var temp914 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp915 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp914)));
                        var temp916 = ((int)((uint)(temp914)) <= (int)((uint)((uint)191U)));
                        var temp917 = ((temp915) && (temp916));
                        if (temp917)
                        {
                            var temp918 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp919 = Fun0(((ushort)((s)._0)), ((ushort)(temp918)));
                            s._0 = ((ushort)(temp919));
                            goto M47;
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
                        var temp920 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp921 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp920)));
                        var temp922 = ((int)((uint)(temp920)) <= (int)((uint)((uint)159U)));
                        var temp923 = ((temp921) && (temp922));
                        if (temp923)
                        {
                            var temp924 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp925 = Fun0(((ushort)((s)._0)), ((ushort)(temp924)));
                            s._0 = ((ushort)(temp925));
                            goto M47;
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
                        var temp926 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp927 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp926)));
                        var temp928 = ((int)((uint)(temp926)) <= (int)((uint)((uint)191U)));
                        var temp929 = ((temp927) && (temp928));
                        if (temp929)
                        {
                            var temp930 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp931 = Fun0(((ushort)((s)._0)), ((ushort)(temp930)));
                            s._0 = ((ushort)(temp931));
                            goto M47;
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
                        var temp932 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp933 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp932)));
                        var temp934 = ((int)((uint)(temp932)) <= (int)((uint)((uint)191U)));
                        var temp935 = ((temp933) && (temp934));
                        if (temp935)
                        {
                            var temp936 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp937 = Fun0(((ushort)((s)._0)), ((ushort)(temp936)));
                            var temp938 = (((ushort)(temp937)) == ((ushort)((ushort)10U)));
                            if (temp938)
                                throw new Exception();
                            else
                            {
                                s._0 = ((ushort)((ushort)0U));
                                goto M36;
                            }
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
                        var temp939 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp940 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp939)));
                        var temp941 = ((int)((uint)(temp939)) <= (int)((uint)((uint)191U)));
                        var temp942 = ((temp940) && (temp941));
                        if (temp942)
                        {
                            var temp943 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp944 = Fun0(((ushort)((s)._0)), ((ushort)(temp943)));
                            s._0 = ((ushort)(temp944));
                            goto M51;
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
                        var temp945 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp946 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp945)));
                        var temp947 = ((int)((uint)(temp945)) <= (int)((uint)((uint)159U)));
                        var temp948 = ((temp946) && (temp947));
                        if (temp948)
                        {
                            var temp949 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp950 = Fun0(((ushort)((s)._0)), ((ushort)(temp949)));
                            s._0 = ((ushort)(temp950));
                            goto M51;
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
                        var temp951 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp952 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp951)));
                        var temp953 = ((int)((uint)(temp951)) <= (int)((uint)((uint)191U)));
                        var temp954 = ((temp952) && (temp953));
                        if (temp954)
                        {
                            var temp955 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp956 = Fun0(((ushort)((s)._0)), ((ushort)(temp955)));
                            s._0 = ((ushort)(temp956));
                            goto M51;
                        }
                        else
                            throw new Exception();
                    }
                }

                F0:
                {
                    var temp0 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp0)
                    {
                        if (oIndex > 16380)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        oBuf[oIndex + 0] = (Byte)((byte)0U);
                        oBuf[oIndex + 1] = (Byte)((byte)0U);
                        oBuf[oIndex + 2] = (Byte)((byte)0U);
                        oBuf[oIndex + 3] = (Byte)((byte)0U);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                    else
                    {
                        if (oIndex > 16380)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        var temp1 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp2 = (((byte)(temp1 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp3 = ((temp0) && (temp2));
                        var temp4 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 1) | (ulong)((byte)(temp1 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp5 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp4))));
                        var temp6 = ((temp3) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp5))))));
                        var temp7 = ((uint)(((int)((uint)(temp6))) >> (int)((uint)((uint)24U))));
                        oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp7))));
                        var temp8 = ((uint)(((int)((uint)(temp6))) >> (int)((uint)((uint)16U))));
                        oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp8))));
                        var temp9 = ((uint)(((int)((uint)(temp6))) >> (int)((uint)((uint)8U))));
                        oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp9))));
                        var temp10 = ((temp3) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp5))))));
                        oBuf[oIndex + 3] = (Byte)(temp10);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                }

                F1:
                    throw new Exception();
                F2:
                {
                    var temp45 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp45)
                    {
                        if (oIndex > 16380)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        oBuf[oIndex + 0] = (Byte)((byte)0U);
                        oBuf[oIndex + 1] = (Byte)((byte)0U);
                        oBuf[oIndex + 2] = (Byte)((byte)0U);
                        oBuf[oIndex + 3] = (Byte)((byte)0U);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                    else
                    {
                        if (oIndex > 16380)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        var temp46 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp47 = (((byte)(temp46 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp48 = ((temp45) && (temp47));
                        var temp49 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 1) | (ulong)((byte)(temp46 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp50 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp49))));
                        var temp51 = ((temp48) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp50))))));
                        var temp52 = ((uint)(((int)((uint)(temp51))) >> (int)((uint)((uint)24U))));
                        oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp52))));
                        var temp53 = ((uint)(((int)((uint)(temp51))) >> (int)((uint)((uint)16U))));
                        oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp53))));
                        var temp54 = ((uint)(((int)((uint)(temp51))) >> (int)((uint)((uint)8U))));
                        oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp54))));
                        var temp55 = ((temp48) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp50))))));
                        oBuf[oIndex + 3] = (Byte)(temp55);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                }

                F3:
                {
                    var temp63 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp63)
                    {
                        if (oIndex > 16380)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        oBuf[oIndex + 0] = (Byte)((byte)0U);
                        oBuf[oIndex + 1] = (Byte)((byte)0U);
                        oBuf[oIndex + 2] = (Byte)((byte)0U);
                        oBuf[oIndex + 3] = (Byte)((byte)0U);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                    else
                    {
                        if (oIndex > 16380)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        var temp64 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp65 = (((byte)(temp64 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp66 = ((temp63) && (temp65));
                        var temp67 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 1) | (ulong)((byte)(temp64 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp68 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp67))));
                        var temp69 = ((temp66) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp68))))));
                        var temp70 = ((uint)(((int)((uint)(temp69))) >> (int)((uint)((uint)24U))));
                        oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp70))));
                        var temp71 = ((uint)(((int)((uint)(temp69))) >> (int)((uint)((uint)16U))));
                        oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp71))));
                        var temp72 = ((uint)(((int)((uint)(temp69))) >> (int)((uint)((uint)8U))));
                        oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp72))));
                        var temp73 = ((temp66) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp68))))));
                        oBuf[oIndex + 3] = (Byte)(temp73);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                }

                F4:
                {
                    var temp80 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp80)
                    {
                        if (oIndex > 16380)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        oBuf[oIndex + 0] = (Byte)((byte)0U);
                        oBuf[oIndex + 1] = (Byte)((byte)0U);
                        oBuf[oIndex + 2] = (Byte)((byte)0U);
                        oBuf[oIndex + 3] = (Byte)((byte)0U);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                    else
                    {
                        if (oIndex > 16380)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        var temp81 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp82 = (((byte)(temp81 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp83 = ((temp80) && (temp82));
                        var temp84 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 1) | (ulong)((byte)(temp81 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp85 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp84))));
                        var temp86 = ((temp83) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp85))))));
                        var temp87 = ((uint)(((int)((uint)(temp86))) >> (int)((uint)((uint)24U))));
                        oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp87))));
                        var temp88 = ((uint)(((int)((uint)(temp86))) >> (int)((uint)((uint)16U))));
                        oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp88))));
                        var temp89 = ((uint)(((int)((uint)(temp86))) >> (int)((uint)((uint)8U))));
                        oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp89))));
                        var temp90 = ((temp83) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp85))))));
                        oBuf[oIndex + 3] = (Byte)(temp90);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                }

                F5:
                {
                    var temp97 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp97)
                    {
                        if (oIndex > 16380)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        oBuf[oIndex + 0] = (Byte)((byte)0U);
                        oBuf[oIndex + 1] = (Byte)((byte)0U);
                        oBuf[oIndex + 2] = (Byte)((byte)0U);
                        oBuf[oIndex + 3] = (Byte)((byte)0U);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                    else
                    {
                        if (oIndex > 16380)
                        {
                            output.Write(oBuf, 0, oIndex);
                            oIndex = 0;
                        }

                        var temp98 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp99 = (((byte)(temp98 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp100 = ((temp97) && (temp99));
                        var temp101 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 1) | (ulong)((byte)(temp98 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp102 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp101))));
                        var temp103 = ((temp100) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp102))))));
                        var temp104 = ((uint)(((int)((uint)(temp103))) >> (int)((uint)((uint)24U))));
                        oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp104))));
                        var temp105 = ((uint)(((int)((uint)(temp103))) >> (int)((uint)((uint)16U))));
                        oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp105))));
                        var temp106 = ((uint)(((int)((uint)(temp103))) >> (int)((uint)((uint)8U))));
                        oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp106))));
                        var temp107 = ((temp100) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp102))))));
                        oBuf[oIndex + 3] = (Byte)(temp107);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
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
            }
        }
    }
}