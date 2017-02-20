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

        struct DTStruct0
        {
            public UInt16 _0;
            public UInt32 _1;
            public UInt64 _2;
            public UInt32 _3;
            public DTStruct0(UInt16 v0, UInt32 v1, UInt64 v2, UInt32 v3)
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
                DTStruct0 s = new DTStruct0(((ushort)((ushort)0U)), ((uint)((uint)0U)), ((ulong)((ulong)0UL)), ((uint)((uint)0U)));
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
                        var temp71 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp72 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp71)));
                        var temp73 = ((int)((uint)(temp71)) <= (int)((uint)((uint)191U)));
                        var temp74 = ((temp72) && (temp73));
                        if (temp74)
                        {
                            var temp75 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp76 = Fun0(((ushort)((s)._0)), ((ushort)(temp75)));
                            s._0 = ((ushort)(temp76));
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
                        var temp88 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp89 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp88)));
                        var temp90 = ((int)((uint)(temp88)) <= (int)((uint)((uint)159U)));
                        var temp91 = ((temp89) && (temp90));
                        if (temp91)
                        {
                            var temp92 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp93 = Fun0(((ushort)((s)._0)), ((ushort)(temp92)));
                            s._0 = ((ushort)(temp93));
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
                        var temp105 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp106 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp105)));
                        var temp107 = ((int)((uint)(temp105)) <= (int)((uint)((uint)191U)));
                        var temp108 = ((temp106) && (temp107));
                        if (temp108)
                        {
                            var temp109 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp110 = Fun0(((ushort)((s)._0)), ((ushort)(temp109)));
                            s._0 = ((ushort)(temp110));
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
                        var temp111 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp112 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp111)));
                        var temp113 = ((int)((uint)(temp111)) <= (int)((uint)((uint)127U)));
                        var temp114 = ((temp112) && (temp113));
                        if (temp114)
                        {
                            var temp115 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp115)
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
                            var temp116 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp111)));
                            var temp117 = ((int)((uint)(temp111)) <= (int)((uint)((uint)223U)));
                            var temp118 = ((temp116) && (temp117));
                            if (temp118)
                            {
                                var temp119 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp119));
                                goto M12;
                            }
                            else
                            {
                                var temp120 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp120)
                                {
                                    var temp121 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp121));
                                    goto M13;
                                }
                                else
                                {
                                    var temp122 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp122)
                                    {
                                        var temp123 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp123));
                                        goto M14;
                                    }
                                    else
                                    {
                                        var temp124 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp111)));
                                        var temp125 = ((int)((uint)(temp111)) <= (int)((uint)((uint)239U)));
                                        var temp126 = ((temp124) && (temp125));
                                        if (temp126)
                                        {
                                            var temp127 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp127));
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
                        var temp128 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp129 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp128)));
                        var temp130 = ((int)((uint)(temp128)) <= (int)((uint)((uint)191U)));
                        var temp131 = ((temp129) && (temp130));
                        if (temp131)
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
                        var temp132 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp133 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp132)));
                        var temp134 = ((int)((uint)(temp132)) <= (int)((uint)((uint)191U)));
                        var temp135 = ((temp133) && (temp134));
                        if (temp135)
                        {
                            var temp136 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp137 = Fun0(((ushort)((s)._0)), ((ushort)(temp136)));
                            s._0 = ((ushort)(temp137));
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
                        var temp138 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp139 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp138)));
                        var temp140 = ((int)((uint)(temp138)) <= (int)((uint)((uint)159U)));
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

                M10:
                {
                    if (!ie.MoveNext())
                        goto F10;
                    i = ie.Current;
                    {
                        var temp144 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp145 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp144)));
                        var temp146 = ((int)((uint)(temp144)) <= (int)((uint)((uint)191U)));
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

                M11:
                {
                    if (!ie.MoveNext())
                        goto F11;
                    i = ie.Current;
                    {
                        var temp150 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp151 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp150)));
                        var temp152 = ((int)((uint)(temp150)) <= (int)((uint)((uint)127U)));
                        var temp153 = ((temp151) && (temp152));
                        if (temp153)
                        {
                            var temp154 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp154)
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
                            var temp155 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp150)));
                            var temp156 = ((int)((uint)(temp150)) <= (int)((uint)((uint)223U)));
                            var temp157 = ((temp155) && (temp156));
                            if (temp157)
                            {
                                var temp158 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp158));
                                goto M17;
                            }
                            else
                            {
                                var temp159 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp159)
                                {
                                    var temp160 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp160));
                                    goto M18;
                                }
                                else
                                {
                                    var temp161 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp161)
                                    {
                                        var temp162 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp162));
                                        goto M19;
                                    }
                                    else
                                    {
                                        var temp163 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp150)));
                                        var temp164 = ((int)((uint)(temp150)) <= (int)((uint)((uint)239U)));
                                        var temp165 = ((temp163) && (temp164));
                                        if (temp165)
                                        {
                                            var temp166 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp166));
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
                        var temp167 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp168 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp167)));
                        var temp169 = ((int)((uint)(temp167)) <= (int)((uint)((uint)191U)));
                        var temp170 = ((temp168) && (temp169));
                        if (temp170)
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
                        var temp171 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp172 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp171)));
                        var temp173 = ((int)((uint)(temp171)) <= (int)((uint)((uint)191U)));
                        var temp174 = ((temp172) && (temp173));
                        if (temp174)
                        {
                            var temp175 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp176 = Fun0(((ushort)((s)._0)), ((ushort)(temp175)));
                            s._0 = ((ushort)(temp176));
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
                        var temp177 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp178 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp177)));
                        var temp179 = ((int)((uint)(temp177)) <= (int)((uint)((uint)159U)));
                        var temp180 = ((temp178) && (temp179));
                        if (temp180)
                        {
                            var temp181 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp182 = Fun0(((ushort)((s)._0)), ((ushort)(temp181)));
                            s._0 = ((ushort)(temp182));
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
                        var temp183 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp184 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp183)));
                        var temp185 = ((int)((uint)(temp183)) <= (int)((uint)((uint)191U)));
                        var temp186 = ((temp184) && (temp185));
                        if (temp186)
                        {
                            var temp187 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp188 = Fun0(((ushort)((s)._0)), ((ushort)(temp187)));
                            s._0 = ((ushort)(temp188));
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
                        var temp189 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp190 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp189)));
                        var temp191 = ((int)((uint)(temp189)) <= (int)((uint)((uint)127U)));
                        var temp192 = ((temp190) && (temp191));
                        if (temp192)
                        {
                            var temp193 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp193)
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
                            var temp194 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp189)));
                            var temp195 = ((int)((uint)(temp189)) <= (int)((uint)((uint)223U)));
                            var temp196 = ((temp194) && (temp195));
                            if (temp196)
                            {
                                var temp197 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp197));
                                goto M22;
                            }
                            else
                            {
                                var temp198 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp198)
                                {
                                    var temp199 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp199));
                                    goto M23;
                                }
                                else
                                {
                                    var temp200 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp200)
                                    {
                                        var temp201 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp201));
                                        goto M24;
                                    }
                                    else
                                    {
                                        var temp202 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp189)));
                                        var temp203 = ((int)((uint)(temp189)) <= (int)((uint)((uint)239U)));
                                        var temp204 = ((temp202) && (temp203));
                                        if (temp204)
                                        {
                                            var temp205 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp205));
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
                        var temp206 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp207 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp206)));
                        var temp208 = ((int)((uint)(temp206)) <= (int)((uint)((uint)191U)));
                        var temp209 = ((temp207) && (temp208));
                        if (temp209)
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
                        var temp210 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp211 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp210)));
                        var temp212 = ((int)((uint)(temp210)) <= (int)((uint)((uint)191U)));
                        var temp213 = ((temp211) && (temp212));
                        if (temp213)
                        {
                            var temp214 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp215 = Fun0(((ushort)((s)._0)), ((ushort)(temp214)));
                            s._0 = ((ushort)(temp215));
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
                        var temp216 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp217 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp216)));
                        var temp218 = ((int)((uint)(temp216)) <= (int)((uint)((uint)159U)));
                        var temp219 = ((temp217) && (temp218));
                        if (temp219)
                        {
                            var temp220 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp221 = Fun0(((ushort)((s)._0)), ((ushort)(temp220)));
                            s._0 = ((ushort)(temp221));
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
                        var temp222 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp223 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp222)));
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

                M21:
                {
                    if (!ie.MoveNext())
                        goto F21;
                    i = ie.Current;
                    {
                        var temp228 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp229 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp228)));
                        var temp230 = ((int)((uint)(temp228)) <= (int)((uint)((uint)127U)));
                        var temp231 = ((temp229) && (temp230));
                        if (temp231)
                        {
                            var temp232 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp232)
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
                            var temp233 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp228)));
                            var temp234 = ((int)((uint)(temp228)) <= (int)((uint)((uint)223U)));
                            var temp235 = ((temp233) && (temp234));
                            if (temp235)
                            {
                                var temp236 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp236));
                                goto M27;
                            }
                            else
                            {
                                var temp237 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp237)
                                {
                                    var temp238 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp238));
                                    goto M28;
                                }
                                else
                                {
                                    var temp239 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp239)
                                    {
                                        var temp240 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp240));
                                        goto M29;
                                    }
                                    else
                                    {
                                        var temp241 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp228)));
                                        var temp242 = ((int)((uint)(temp228)) <= (int)((uint)((uint)239U)));
                                        var temp243 = ((temp241) && (temp242));
                                        if (temp243)
                                        {
                                            var temp244 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp244));
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
                        var temp245 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp246 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp245)));
                        var temp247 = ((int)((uint)(temp245)) <= (int)((uint)((uint)191U)));
                        var temp248 = ((temp246) && (temp247));
                        if (temp248)
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
                        var temp249 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp250 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp249)));
                        var temp251 = ((int)((uint)(temp249)) <= (int)((uint)((uint)191U)));
                        var temp252 = ((temp250) && (temp251));
                        if (temp252)
                        {
                            var temp253 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp254 = Fun0(((ushort)((s)._0)), ((ushort)(temp253)));
                            s._0 = ((ushort)(temp254));
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
                        var temp255 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp256 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp255)));
                        var temp257 = ((int)((uint)(temp255)) <= (int)((uint)((uint)159U)));
                        var temp258 = ((temp256) && (temp257));
                        if (temp258)
                        {
                            var temp259 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp260 = Fun0(((ushort)((s)._0)), ((ushort)(temp259)));
                            s._0 = ((ushort)(temp260));
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
                        var temp261 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp262 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp261)));
                        var temp263 = ((int)((uint)(temp261)) <= (int)((uint)((uint)191U)));
                        var temp264 = ((temp262) && (temp263));
                        if (temp264)
                        {
                            var temp265 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp266 = Fun0(((ushort)((s)._0)), ((ushort)(temp265)));
                            s._0 = ((ushort)(temp266));
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
                        var temp267 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp268 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp267)));
                        var temp269 = ((int)((uint)(temp267)) <= (int)((uint)((uint)127U)));
                        var temp270 = ((temp268) && (temp269));
                        if (temp270)
                        {
                            var temp271 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp272 = ((byte)(((byte)(i)) >> 6));
                            var temp273 = (((byte)(temp272 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp274 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp275 = (((temp271) && (temp273)) && (temp274));
                            if (temp275)
                            {
                                var temp276 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp277 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp276))) + ((uint)(temp267))));
                                s._1 = ((uint)(temp277));
                                goto M31;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp278 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp267)));
                            var temp279 = ((int)((uint)(temp267)) <= (int)((uint)((uint)223U)));
                            var temp280 = ((temp278) && (temp279));
                            if (temp280)
                            {
                                var temp281 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp281));
                                goto M32;
                            }
                            else
                            {
                                var temp282 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp282)
                                {
                                    var temp283 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp283));
                                    goto M33;
                                }
                                else
                                {
                                    var temp284 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp284)
                                    {
                                        var temp285 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp285));
                                        goto M34;
                                    }
                                    else
                                    {
                                        var temp286 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp267)));
                                        var temp287 = ((int)((uint)(temp267)) <= (int)((uint)((uint)239U)));
                                        var temp288 = ((temp286) && (temp287));
                                        if (temp288)
                                        {
                                            var temp289 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp289));
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
                        var temp290 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp291 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp290)));
                        var temp292 = ((int)((uint)(temp290)) <= (int)((uint)((uint)191U)));
                        var temp293 = ((temp291) && (temp292));
                        if (temp293)
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
                        var temp294 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp295 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp294)));
                        var temp296 = ((int)((uint)(temp294)) <= (int)((uint)((uint)191U)));
                        var temp297 = ((temp295) && (temp296));
                        if (temp297)
                        {
                            var temp298 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp299 = Fun0(((ushort)((s)._0)), ((ushort)(temp298)));
                            s._0 = ((ushort)(temp299));
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
                        var temp300 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp301 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp300)));
                        var temp302 = ((int)((uint)(temp300)) <= (int)((uint)((uint)159U)));
                        var temp303 = ((temp301) && (temp302));
                        if (temp303)
                        {
                            var temp304 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp305 = Fun0(((ushort)((s)._0)), ((ushort)(temp304)));
                            s._0 = ((ushort)(temp305));
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
                        var temp306 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp307 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp306)));
                        var temp308 = ((int)((uint)(temp306)) <= (int)((uint)((uint)191U)));
                        var temp309 = ((temp307) && (temp308));
                        if (temp309)
                        {
                            var temp310 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp311 = Fun0(((ushort)((s)._0)), ((ushort)(temp310)));
                            s._0 = ((ushort)(temp311));
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
                        var temp312 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp313 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp312)));
                        var temp314 = ((int)((uint)(temp312)) <= (int)((uint)((uint)127U)));
                        var temp315 = ((temp313) && (temp314));
                        if (temp315)
                        {
                            var temp316 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp316)
                            {
                                goto M36;
                            }
                            else
                            {
                                var temp317 = (((byte)(i)) == ((byte)((byte)46U)));
                                if (temp317)
                                {
                                    goto M37;
                                }
                                else
                                {
                                    var temp318 = (((byte)((byte)48U)) <= ((byte)(i)));
                                    var temp319 = ((byte)(((byte)(i)) >> 6));
                                    var temp320 = (((byte)(temp319 & 3L)) == ((byte)((byte)0U & 3L)));
                                    var temp321 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                    var temp322 = (((temp318) && (temp320)) && (temp321));
                                    if (temp322)
                                    {
                                        var temp323 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                        var temp324 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp323))) + ((uint)(temp312))));
                                        s._1 = ((uint)(temp324));
                                        goto M31;
                                    }
                                    else
                                        throw new Exception();
                                }
                            }
                        }
                        else
                        {
                            var temp325 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp312)));
                            var temp326 = ((int)((uint)(temp312)) <= (int)((uint)((uint)223U)));
                            var temp327 = ((temp325) && (temp326));
                            if (temp327)
                            {
                                var temp328 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp328));
                                goto M38;
                            }
                            else
                            {
                                var temp329 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp329)
                                {
                                    var temp330 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp330));
                                    goto M39;
                                }
                                else
                                {
                                    var temp331 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp331)
                                    {
                                        var temp332 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp332));
                                        goto M40;
                                    }
                                    else
                                    {
                                        var temp333 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp312)));
                                        var temp334 = ((int)((uint)(temp312)) <= (int)((uint)((uint)239U)));
                                        var temp335 = ((temp333) && (temp334));
                                        if (temp335)
                                        {
                                            var temp336 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp336));
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
                        var temp337 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp338 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp337)));
                        var temp339 = ((int)((uint)(temp337)) <= (int)((uint)((uint)191U)));
                        var temp340 = ((temp338) && (temp339));
                        if (temp340)
                        {
                            var temp341 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp342 = Fun0(((ushort)((s)._0)), ((ushort)(temp341)));
                            var temp343 = (((ushort)((ushort)48U)) <= ((ushort)(temp342)));
                            var temp344 = ((ushort)(((ushort)(temp342)) >> 6));
                            var temp345 = (((ushort)(temp344 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp346 = (((byte)(((byte)((ushort)(temp342))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp347 = (((temp343) && (temp345)) && (temp346));
                            var temp348 = (((ushort)((ushort)1632U)) <= ((ushort)(temp342)));
                            var temp349 = ((byte)(((ushort)(temp342)) >> 11));
                            var temp350 = (((byte)(temp349 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp351 = (((ushort)(((ushort)((ushort)(temp342))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp352 = (((temp348) && (temp350)) && (temp351));
                            var temp353 = (((ushort)((ushort)1776U)) <= ((ushort)(temp342)));
                            var temp354 = (((ushort)(((ushort)((ushort)(temp342))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp355 = (((temp353) && (temp350)) && (temp354));
                            var temp356 = (((ushort)((ushort)1984U)) <= ((ushort)(temp342)));
                            var temp357 = (((ushort)(((ushort)((ushort)(temp342))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp358 = (((temp356) && (temp350)) && (temp357));
                            var temp359 = (((ushort)((ushort)2406U)) <= ((ushort)(temp342)));
                            var temp360 = ((byte)(((ushort)(temp342)) >> 12));
                            var temp361 = (((byte)(temp360 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp362 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp363 = (((temp359) && (temp361)) && (temp362));
                            var temp364 = (((ushort)((ushort)2534U)) <= ((ushort)(temp342)));
                            var temp365 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp366 = (((temp364) && (temp361)) && (temp365));
                            var temp367 = (((ushort)((ushort)2662U)) <= ((ushort)(temp342)));
                            var temp368 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp369 = (((temp367) && (temp361)) && (temp368));
                            var temp370 = (((ushort)((ushort)2790U)) <= ((ushort)(temp342)));
                            var temp371 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp372 = (((temp370) && (temp361)) && (temp371));
                            var temp373 = (((ushort)((ushort)2918U)) <= ((ushort)(temp342)));
                            var temp374 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp375 = (((temp373) && (temp361)) && (temp374));
                            var temp376 = (((ushort)((ushort)3046U)) <= ((ushort)(temp342)));
                            var temp377 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp378 = (((temp376) && (temp361)) && (temp377));
                            var temp379 = (((ushort)((ushort)3174U)) <= ((ushort)(temp342)));
                            var temp380 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp381 = (((temp379) && (temp361)) && (temp380));
                            var temp382 = (((ushort)((ushort)3302U)) <= ((ushort)(temp342)));
                            var temp383 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp384 = (((temp382) && (temp361)) && (temp383));
                            var temp385 = (((ushort)((ushort)3430U)) <= ((ushort)(temp342)));
                            var temp386 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp387 = (((temp385) && (temp361)) && (temp386));
                            var temp388 = (((ushort)((ushort)3664U)) <= ((ushort)(temp342)));
                            var temp389 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp390 = (((temp388) && (temp361)) && (temp389));
                            var temp391 = (((ushort)((ushort)3792U)) <= ((ushort)(temp342)));
                            var temp392 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp393 = (((temp391) && (temp361)) && (temp392));
                            var temp394 = (((ushort)((ushort)3872U)) <= ((ushort)(temp342)));
                            var temp395 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp396 = (((temp394) && (temp361)) && (temp395));
                            var temp397 = (((ushort)((ushort)4160U)) <= ((ushort)(temp342)));
                            var temp398 = ((byte)(((ushort)(temp342)) >> 13));
                            var temp399 = (((byte)(temp398 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp400 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp401 = (((temp397) && (temp399)) && (temp400));
                            var temp402 = (((ushort)((ushort)4240U)) <= ((ushort)(temp342)));
                            var temp403 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp404 = (((temp402) && (temp399)) && (temp403));
                            var temp405 = (((ushort)((ushort)6112U)) <= ((ushort)(temp342)));
                            var temp406 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp407 = (((temp405) && (temp399)) && (temp406));
                            var temp408 = (((ushort)((ushort)6160U)) <= ((ushort)(temp342)));
                            var temp409 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp410 = (((temp408) && (temp399)) && (temp409));
                            var temp411 = (((ushort)((ushort)6470U)) <= ((ushort)(temp342)));
                            var temp412 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp413 = (((temp411) && (temp399)) && (temp412));
                            var temp414 = (((ushort)((ushort)6608U)) <= ((ushort)(temp342)));
                            var temp415 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp416 = (((temp414) && (temp399)) && (temp415));
                            var temp417 = (((ushort)((ushort)6992U)) <= ((ushort)(temp342)));
                            var temp418 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp419 = (((temp417) && (temp399)) && (temp418));
                            var temp420 = (((ushort)((ushort)7088U)) <= ((ushort)(temp342)));
                            var temp421 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp422 = (((temp420) && (temp399)) && (temp421));
                            var temp423 = (((ushort)((ushort)7232U)) <= ((ushort)(temp342)));
                            var temp424 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp425 = (((temp423) && (temp399)) && (temp424));
                            var temp426 = (((ushort)((ushort)7248U)) <= ((ushort)(temp342)));
                            var temp427 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp428 = (((temp426) && (temp399)) && (temp427));
                            var temp429 = (((ushort)((ushort)42528U)) <= ((ushort)(temp342)));
                            var temp430 = (((ushort)(temp342)) <= ((ushort)((ushort)42537U)));
                            var temp431 = ((temp429) && (temp430));
                            var temp432 = (((ushort)((ushort)43216U)) <= ((ushort)(temp342)));
                            var temp433 = (((ushort)(temp342)) <= ((ushort)((ushort)43225U)));
                            var temp434 = ((temp432) && (temp433));
                            var temp435 = (((ushort)((ushort)43264U)) <= ((ushort)(temp342)));
                            var temp436 = (((ushort)(temp342)) <= ((ushort)((ushort)43273U)));
                            var temp437 = ((temp435) && (temp436));
                            var temp438 = (((ushort)((ushort)43600U)) <= ((ushort)(temp342)));
                            var temp439 = (((ushort)(temp342)) <= ((ushort)((ushort)43609U)));
                            var temp440 = ((temp438) && (temp439));
                            var temp441 = (((ushort)((ushort)65296U)) <= ((ushort)(temp342)));
                            var temp442 = (((ushort)(temp342)) <= ((ushort)((ushort)65305U)));
                            var temp443 = ((temp441) && (temp442));
                            var temp444 = (((((((((((((((((((((((((((((((temp347) || (temp352)) || (temp355)) || (temp358)) || (temp363)) || (temp366)) || (temp369)) || (temp372)) || (temp375)) || (temp378)) || (temp381)) || (temp384)) || (temp387)) || (temp390)) || (temp393)) || (temp396)) || (temp401)) || (temp404)) || (temp407)) || (temp410)) || (temp413)) || (temp416)) || (temp419)) || (temp422)) || (temp425)) || (temp428)) || (temp431)) || (temp434)) || (temp437)) || (temp440)) || (temp443));
                            if (temp444)
                            {
                                var temp445 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp446 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp342));
                                var temp447 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp445))) + ((uint)(temp446))));
                                s._1 = ((uint)(temp447));
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
                        var temp448 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp449 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp448)));
                        var temp450 = ((int)((uint)(temp448)) <= (int)((uint)((uint)191U)));
                        var temp451 = ((temp449) && (temp450));
                        if (temp451)
                        {
                            var temp452 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp453 = Fun0(((ushort)((s)._0)), ((ushort)(temp452)));
                            s._0 = ((ushort)(temp453));
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
                        var temp454 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp455 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp454)));
                        var temp456 = ((int)((uint)(temp454)) <= (int)((uint)((uint)159U)));
                        var temp457 = ((temp455) && (temp456));
                        if (temp457)
                        {
                            var temp458 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp459 = Fun0(((ushort)((s)._0)), ((ushort)(temp458)));
                            s._0 = ((ushort)(temp459));
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
                        var temp460 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp461 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp460)));
                        var temp462 = ((int)((uint)(temp460)) <= (int)((uint)((uint)191U)));
                        var temp463 = ((temp461) && (temp462));
                        if (temp463)
                        {
                            var temp464 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp465 = Fun0(((ushort)((s)._0)), ((ushort)(temp464)));
                            s._0 = ((ushort)(temp465));
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
                        var temp466 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp467 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp466)));
                        var temp468 = ((int)((uint)(temp466)) <= (int)((uint)((uint)127U)));
                        var temp469 = ((temp467) && (temp468));
                        if (temp469)
                        {
                            var temp470 = (((byte)(i)) == ((byte)((byte)10U)));
                            if (temp470)
                            {
                                var temp471 = ((uint)(((uint)((uint)1U)) + ((uint)((s)._3))));
                                s._3 = ((uint)(temp471));
                                var temp472 = ((byte)(((uint)((s)._1)) >> 31));
                                var temp473 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 32) | (ulong)((uint)((s)._1));
                                var temp474 = ((ulong)(((ulong)((s)._2)) + ((ulong)(temp473))));
                                s._2 = ((ulong)(temp474));
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
                            var temp475 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp466)));
                            var temp476 = ((int)((uint)(temp466)) <= (int)((uint)((uint)223U)));
                            var temp477 = ((temp475) && (temp476));
                            if (temp477)
                            {
                                var temp478 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp478));
                                goto M51;
                            }
                            else
                            {
                                var temp479 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp479)
                                {
                                    var temp480 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp480));
                                    goto M52;
                                }
                                else
                                {
                                    var temp481 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp481)
                                    {
                                        var temp482 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp482));
                                        goto M53;
                                    }
                                    else
                                    {
                                        var temp483 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp466)));
                                        var temp484 = ((int)((uint)(temp466)) <= (int)((uint)((uint)239U)));
                                        var temp485 = ((temp483) && (temp484));
                                        if (temp485)
                                        {
                                            var temp486 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp486));
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
                        var temp487 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp488 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp487)));
                        var temp489 = ((int)((uint)(temp487)) <= (int)((uint)((uint)127U)));
                        var temp490 = ((temp488) && (temp489));
                        if (temp490)
                        {
                            var temp491 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp492 = ((byte)(((byte)(i)) >> 6));
                            var temp493 = (((byte)(temp492 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp494 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp495 = (((temp491) && (temp493)) && (temp494));
                            if (temp495)
                            {
                                goto M42;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp496 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp487)));
                            var temp497 = ((int)((uint)(temp487)) <= (int)((uint)((uint)223U)));
                            var temp498 = ((temp496) && (temp497));
                            if (temp498)
                            {
                                var temp499 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp499));
                                goto M43;
                            }
                            else
                            {
                                var temp500 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp500)
                                {
                                    var temp501 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp501));
                                    goto M44;
                                }
                                else
                                {
                                    var temp502 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp502)
                                    {
                                        var temp503 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp503));
                                        goto M45;
                                    }
                                    else
                                    {
                                        var temp504 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp487)));
                                        var temp505 = ((int)((uint)(temp487)) <= (int)((uint)((uint)239U)));
                                        var temp506 = ((temp504) && (temp505));
                                        if (temp506)
                                        {
                                            var temp507 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp507));
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
                        var temp508 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp509 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp508)));
                        var temp510 = ((int)((uint)(temp508)) <= (int)((uint)((uint)191U)));
                        var temp511 = ((temp509) && (temp510));
                        if (temp511)
                        {
                            var temp512 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp513 = Fun0(((ushort)((s)._0)), ((ushort)(temp512)));
                            var temp514 = (((ushort)((ushort)48U)) <= ((ushort)(temp513)));
                            var temp515 = ((ushort)(((ushort)(temp513)) >> 6));
                            var temp516 = (((ushort)(temp515 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp517 = (((byte)(((byte)((ushort)(temp513))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp518 = (((temp514) && (temp516)) && (temp517));
                            var temp519 = (((ushort)((ushort)1632U)) <= ((ushort)(temp513)));
                            var temp520 = ((byte)(((ushort)(temp513)) >> 11));
                            var temp521 = (((byte)(temp520 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp522 = (((ushort)(((ushort)((ushort)(temp513))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp523 = (((temp519) && (temp521)) && (temp522));
                            var temp524 = (((ushort)((ushort)1776U)) <= ((ushort)(temp513)));
                            var temp525 = (((ushort)(((ushort)((ushort)(temp513))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp526 = (((temp524) && (temp521)) && (temp525));
                            var temp527 = (((ushort)((ushort)1984U)) <= ((ushort)(temp513)));
                            var temp528 = (((ushort)(((ushort)((ushort)(temp513))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp529 = (((temp527) && (temp521)) && (temp528));
                            var temp530 = (((ushort)((ushort)2406U)) <= ((ushort)(temp513)));
                            var temp531 = ((byte)(((ushort)(temp513)) >> 12));
                            var temp532 = (((byte)(temp531 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp533 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp534 = (((temp530) && (temp532)) && (temp533));
                            var temp535 = (((ushort)((ushort)2534U)) <= ((ushort)(temp513)));
                            var temp536 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp537 = (((temp535) && (temp532)) && (temp536));
                            var temp538 = (((ushort)((ushort)2662U)) <= ((ushort)(temp513)));
                            var temp539 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp540 = (((temp538) && (temp532)) && (temp539));
                            var temp541 = (((ushort)((ushort)2790U)) <= ((ushort)(temp513)));
                            var temp542 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp543 = (((temp541) && (temp532)) && (temp542));
                            var temp544 = (((ushort)((ushort)2918U)) <= ((ushort)(temp513)));
                            var temp545 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp546 = (((temp544) && (temp532)) && (temp545));
                            var temp547 = (((ushort)((ushort)3046U)) <= ((ushort)(temp513)));
                            var temp548 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp549 = (((temp547) && (temp532)) && (temp548));
                            var temp550 = (((ushort)((ushort)3174U)) <= ((ushort)(temp513)));
                            var temp551 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp552 = (((temp550) && (temp532)) && (temp551));
                            var temp553 = (((ushort)((ushort)3302U)) <= ((ushort)(temp513)));
                            var temp554 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp555 = (((temp553) && (temp532)) && (temp554));
                            var temp556 = (((ushort)((ushort)3430U)) <= ((ushort)(temp513)));
                            var temp557 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp558 = (((temp556) && (temp532)) && (temp557));
                            var temp559 = (((ushort)((ushort)3664U)) <= ((ushort)(temp513)));
                            var temp560 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp561 = (((temp559) && (temp532)) && (temp560));
                            var temp562 = (((ushort)((ushort)3792U)) <= ((ushort)(temp513)));
                            var temp563 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp564 = (((temp562) && (temp532)) && (temp563));
                            var temp565 = (((ushort)((ushort)3872U)) <= ((ushort)(temp513)));
                            var temp566 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp567 = (((temp565) && (temp532)) && (temp566));
                            var temp568 = (((ushort)((ushort)4160U)) <= ((ushort)(temp513)));
                            var temp569 = ((byte)(((ushort)(temp513)) >> 13));
                            var temp570 = (((byte)(temp569 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp571 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp572 = (((temp568) && (temp570)) && (temp571));
                            var temp573 = (((ushort)((ushort)4240U)) <= ((ushort)(temp513)));
                            var temp574 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp575 = (((temp573) && (temp570)) && (temp574));
                            var temp576 = (((ushort)((ushort)6112U)) <= ((ushort)(temp513)));
                            var temp577 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp578 = (((temp576) && (temp570)) && (temp577));
                            var temp579 = (((ushort)((ushort)6160U)) <= ((ushort)(temp513)));
                            var temp580 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp581 = (((temp579) && (temp570)) && (temp580));
                            var temp582 = (((ushort)((ushort)6470U)) <= ((ushort)(temp513)));
                            var temp583 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp584 = (((temp582) && (temp570)) && (temp583));
                            var temp585 = (((ushort)((ushort)6608U)) <= ((ushort)(temp513)));
                            var temp586 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp587 = (((temp585) && (temp570)) && (temp586));
                            var temp588 = (((ushort)((ushort)6992U)) <= ((ushort)(temp513)));
                            var temp589 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp590 = (((temp588) && (temp570)) && (temp589));
                            var temp591 = (((ushort)((ushort)7088U)) <= ((ushort)(temp513)));
                            var temp592 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp593 = (((temp591) && (temp570)) && (temp592));
                            var temp594 = (((ushort)((ushort)7232U)) <= ((ushort)(temp513)));
                            var temp595 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp596 = (((temp594) && (temp570)) && (temp595));
                            var temp597 = (((ushort)((ushort)7248U)) <= ((ushort)(temp513)));
                            var temp598 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp599 = (((temp597) && (temp570)) && (temp598));
                            var temp600 = (((ushort)((ushort)42528U)) <= ((ushort)(temp513)));
                            var temp601 = (((ushort)(temp513)) <= ((ushort)((ushort)42537U)));
                            var temp602 = ((temp600) && (temp601));
                            var temp603 = (((ushort)((ushort)43216U)) <= ((ushort)(temp513)));
                            var temp604 = (((ushort)(temp513)) <= ((ushort)((ushort)43225U)));
                            var temp605 = ((temp603) && (temp604));
                            var temp606 = (((ushort)((ushort)43264U)) <= ((ushort)(temp513)));
                            var temp607 = (((ushort)(temp513)) <= ((ushort)((ushort)43273U)));
                            var temp608 = ((temp606) && (temp607));
                            var temp609 = (((ushort)((ushort)43600U)) <= ((ushort)(temp513)));
                            var temp610 = (((ushort)(temp513)) <= ((ushort)((ushort)43609U)));
                            var temp611 = ((temp609) && (temp610));
                            var temp612 = (((ushort)((ushort)65296U)) <= ((ushort)(temp513)));
                            var temp613 = (((ushort)(temp513)) <= ((ushort)((ushort)65305U)));
                            var temp614 = ((temp612) && (temp613));
                            var temp615 = (((((((((((((((((((((((((((((((temp518) || (temp523)) || (temp526)) || (temp529)) || (temp534)) || (temp537)) || (temp540)) || (temp543)) || (temp546)) || (temp549)) || (temp552)) || (temp555)) || (temp558)) || (temp561)) || (temp564)) || (temp567)) || (temp572)) || (temp575)) || (temp578)) || (temp581)) || (temp584)) || (temp587)) || (temp590)) || (temp593)) || (temp596)) || (temp599)) || (temp602)) || (temp605)) || (temp608)) || (temp611)) || (temp614));
                            if (temp615)
                            {
                                var temp616 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp617 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp513));
                                var temp618 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp616))) + ((uint)(temp617))));
                                s._1 = ((uint)(temp618));
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

                M39:
                {
                    if (!ie.MoveNext())
                        goto F39;
                    i = ie.Current;
                    {
                        var temp619 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp620 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp619)));
                        var temp621 = ((int)((uint)(temp619)) <= (int)((uint)((uint)191U)));
                        var temp622 = ((temp620) && (temp621));
                        if (temp622)
                        {
                            var temp623 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp624 = Fun0(((ushort)((s)._0)), ((ushort)(temp623)));
                            s._0 = ((ushort)(temp624));
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
                        var temp625 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp626 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp625)));
                        var temp627 = ((int)((uint)(temp625)) <= (int)((uint)((uint)159U)));
                        var temp628 = ((temp626) && (temp627));
                        if (temp628)
                        {
                            var temp629 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp630 = Fun0(((ushort)((s)._0)), ((ushort)(temp629)));
                            s._0 = ((ushort)(temp630));
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
                        var temp631 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp632 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp631)));
                        var temp633 = ((int)((uint)(temp631)) <= (int)((uint)((uint)191U)));
                        var temp634 = ((temp632) && (temp633));
                        if (temp634)
                        {
                            var temp635 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp636 = Fun0(((ushort)((s)._0)), ((ushort)(temp635)));
                            s._0 = ((ushort)(temp636));
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
                        var temp637 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp638 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp637)));
                        var temp639 = ((int)((uint)(temp637)) <= (int)((uint)((uint)127U)));
                        var temp640 = ((temp638) && (temp639));
                        if (temp640)
                        {
                            var temp641 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp641)
                            {
                                goto M36;
                            }
                            else
                            {
                                var temp642 = (((byte)((byte)48U)) <= ((byte)(i)));
                                var temp643 = ((byte)(((byte)(i)) >> 6));
                                var temp644 = (((byte)(temp643 & 3L)) == ((byte)((byte)0U & 3L)));
                                var temp645 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp646 = (((temp642) && (temp644)) && (temp645));
                                if (temp646)
                                {
                                    goto M42;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                        else
                        {
                            var temp647 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp637)));
                            var temp648 = ((int)((uint)(temp637)) <= (int)((uint)((uint)223U)));
                            var temp649 = ((temp647) && (temp648));
                            if (temp649)
                            {
                                var temp650 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp650));
                                goto M47;
                            }
                            else
                            {
                                var temp651 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp651)
                                {
                                    var temp652 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp652));
                                    goto M48;
                                }
                                else
                                {
                                    var temp653 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp653)
                                    {
                                        var temp654 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp654));
                                        goto M49;
                                    }
                                    else
                                    {
                                        var temp655 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp637)));
                                        var temp656 = ((int)((uint)(temp637)) <= (int)((uint)((uint)239U)));
                                        var temp657 = ((temp655) && (temp656));
                                        if (temp657)
                                        {
                                            var temp658 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp658));
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
                        var temp659 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp660 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp659)));
                        var temp661 = ((int)((uint)(temp659)) <= (int)((uint)((uint)191U)));
                        var temp662 = ((temp660) && (temp661));
                        if (temp662)
                        {
                            var temp663 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp664 = Fun0(((ushort)((s)._0)), ((ushort)(temp663)));
                            var temp665 = (((ushort)((ushort)48U)) <= ((ushort)(temp664)));
                            var temp666 = ((ushort)(((ushort)(temp664)) >> 6));
                            var temp667 = (((ushort)(temp666 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp668 = (((byte)(((byte)((ushort)(temp664))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp669 = (((temp665) && (temp667)) && (temp668));
                            var temp670 = (((ushort)((ushort)1632U)) <= ((ushort)(temp664)));
                            var temp671 = ((byte)(((ushort)(temp664)) >> 11));
                            var temp672 = (((byte)(temp671 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp673 = (((ushort)(((ushort)((ushort)(temp664))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp674 = (((temp670) && (temp672)) && (temp673));
                            var temp675 = (((ushort)((ushort)1776U)) <= ((ushort)(temp664)));
                            var temp676 = (((ushort)(((ushort)((ushort)(temp664))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp677 = (((temp675) && (temp672)) && (temp676));
                            var temp678 = (((ushort)((ushort)1984U)) <= ((ushort)(temp664)));
                            var temp679 = (((ushort)(((ushort)((ushort)(temp664))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp680 = (((temp678) && (temp672)) && (temp679));
                            var temp681 = (((ushort)((ushort)2406U)) <= ((ushort)(temp664)));
                            var temp682 = ((byte)(((ushort)(temp664)) >> 12));
                            var temp683 = (((byte)(temp682 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp684 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp685 = (((temp681) && (temp683)) && (temp684));
                            var temp686 = (((ushort)((ushort)2534U)) <= ((ushort)(temp664)));
                            var temp687 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp688 = (((temp686) && (temp683)) && (temp687));
                            var temp689 = (((ushort)((ushort)2662U)) <= ((ushort)(temp664)));
                            var temp690 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp691 = (((temp689) && (temp683)) && (temp690));
                            var temp692 = (((ushort)((ushort)2790U)) <= ((ushort)(temp664)));
                            var temp693 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp694 = (((temp692) && (temp683)) && (temp693));
                            var temp695 = (((ushort)((ushort)2918U)) <= ((ushort)(temp664)));
                            var temp696 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp697 = (((temp695) && (temp683)) && (temp696));
                            var temp698 = (((ushort)((ushort)3046U)) <= ((ushort)(temp664)));
                            var temp699 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp700 = (((temp698) && (temp683)) && (temp699));
                            var temp701 = (((ushort)((ushort)3174U)) <= ((ushort)(temp664)));
                            var temp702 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp703 = (((temp701) && (temp683)) && (temp702));
                            var temp704 = (((ushort)((ushort)3302U)) <= ((ushort)(temp664)));
                            var temp705 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp706 = (((temp704) && (temp683)) && (temp705));
                            var temp707 = (((ushort)((ushort)3430U)) <= ((ushort)(temp664)));
                            var temp708 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp709 = (((temp707) && (temp683)) && (temp708));
                            var temp710 = (((ushort)((ushort)3664U)) <= ((ushort)(temp664)));
                            var temp711 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp712 = (((temp710) && (temp683)) && (temp711));
                            var temp713 = (((ushort)((ushort)3792U)) <= ((ushort)(temp664)));
                            var temp714 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp715 = (((temp713) && (temp683)) && (temp714));
                            var temp716 = (((ushort)((ushort)3872U)) <= ((ushort)(temp664)));
                            var temp717 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp718 = (((temp716) && (temp683)) && (temp717));
                            var temp719 = (((ushort)((ushort)4160U)) <= ((ushort)(temp664)));
                            var temp720 = ((byte)(((ushort)(temp664)) >> 13));
                            var temp721 = (((byte)(temp720 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp722 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp723 = (((temp719) && (temp721)) && (temp722));
                            var temp724 = (((ushort)((ushort)4240U)) <= ((ushort)(temp664)));
                            var temp725 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp726 = (((temp724) && (temp721)) && (temp725));
                            var temp727 = (((ushort)((ushort)6112U)) <= ((ushort)(temp664)));
                            var temp728 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp729 = (((temp727) && (temp721)) && (temp728));
                            var temp730 = (((ushort)((ushort)6160U)) <= ((ushort)(temp664)));
                            var temp731 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp732 = (((temp730) && (temp721)) && (temp731));
                            var temp733 = (((ushort)((ushort)6470U)) <= ((ushort)(temp664)));
                            var temp734 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp735 = (((temp733) && (temp721)) && (temp734));
                            var temp736 = (((ushort)((ushort)6608U)) <= ((ushort)(temp664)));
                            var temp737 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp738 = (((temp736) && (temp721)) && (temp737));
                            var temp739 = (((ushort)((ushort)6992U)) <= ((ushort)(temp664)));
                            var temp740 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp741 = (((temp739) && (temp721)) && (temp740));
                            var temp742 = (((ushort)((ushort)7088U)) <= ((ushort)(temp664)));
                            var temp743 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp744 = (((temp742) && (temp721)) && (temp743));
                            var temp745 = (((ushort)((ushort)7232U)) <= ((ushort)(temp664)));
                            var temp746 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp747 = (((temp745) && (temp721)) && (temp746));
                            var temp748 = (((ushort)((ushort)7248U)) <= ((ushort)(temp664)));
                            var temp749 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp750 = (((temp748) && (temp721)) && (temp749));
                            var temp751 = (((ushort)((ushort)42528U)) <= ((ushort)(temp664)));
                            var temp752 = (((ushort)(temp664)) <= ((ushort)((ushort)42537U)));
                            var temp753 = ((temp751) && (temp752));
                            var temp754 = (((ushort)((ushort)43216U)) <= ((ushort)(temp664)));
                            var temp755 = (((ushort)(temp664)) <= ((ushort)((ushort)43225U)));
                            var temp756 = ((temp754) && (temp755));
                            var temp757 = (((ushort)((ushort)43264U)) <= ((ushort)(temp664)));
                            var temp758 = (((ushort)(temp664)) <= ((ushort)((ushort)43273U)));
                            var temp759 = ((temp757) && (temp758));
                            var temp760 = (((ushort)((ushort)43600U)) <= ((ushort)(temp664)));
                            var temp761 = (((ushort)(temp664)) <= ((ushort)((ushort)43609U)));
                            var temp762 = ((temp760) && (temp761));
                            var temp763 = (((ushort)((ushort)65296U)) <= ((ushort)(temp664)));
                            var temp764 = (((ushort)(temp664)) <= ((ushort)((ushort)65305U)));
                            var temp765 = ((temp763) && (temp764));
                            var temp766 = (((((((((((((((((((((((((((((((temp669) || (temp674)) || (temp677)) || (temp680)) || (temp685)) || (temp688)) || (temp691)) || (temp694)) || (temp697)) || (temp700)) || (temp703)) || (temp706)) || (temp709)) || (temp712)) || (temp715)) || (temp718)) || (temp723)) || (temp726)) || (temp729)) || (temp732)) || (temp735)) || (temp738)) || (temp741)) || (temp744)) || (temp747)) || (temp750)) || (temp753)) || (temp756)) || (temp759)) || (temp762)) || (temp765));
                            if (temp766)
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
                        var temp767 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp768 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp767)));
                        var temp769 = ((int)((uint)(temp767)) <= (int)((uint)((uint)191U)));
                        var temp770 = ((temp768) && (temp769));
                        if (temp770)
                        {
                            var temp771 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp772 = Fun0(((ushort)((s)._0)), ((ushort)(temp771)));
                            s._0 = ((ushort)(temp772));
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
                        var temp773 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp774 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp773)));
                        var temp775 = ((int)((uint)(temp773)) <= (int)((uint)((uint)159U)));
                        var temp776 = ((temp774) && (temp775));
                        if (temp776)
                        {
                            var temp777 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp778 = Fun0(((ushort)((s)._0)), ((ushort)(temp777)));
                            s._0 = ((ushort)(temp778));
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
                        var temp779 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp780 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp779)));
                        var temp781 = ((int)((uint)(temp779)) <= (int)((uint)((uint)191U)));
                        var temp782 = ((temp780) && (temp781));
                        if (temp782)
                        {
                            var temp783 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp784 = Fun0(((ushort)((s)._0)), ((ushort)(temp783)));
                            s._0 = ((ushort)(temp784));
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
                        var temp785 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp786 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp785)));
                        var temp787 = ((int)((uint)(temp785)) <= (int)((uint)((uint)191U)));
                        var temp788 = ((temp786) && (temp787));
                        if (temp788)
                        {
                            var temp789 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp790 = Fun0(((ushort)((s)._0)), ((ushort)(temp789)));
                            var temp791 = (((ushort)((ushort)48U)) <= ((ushort)(temp790)));
                            var temp792 = ((ushort)(((ushort)(temp790)) >> 6));
                            var temp793 = (((ushort)(temp792 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp794 = (((byte)(((byte)((ushort)(temp790))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp795 = (((temp791) && (temp793)) && (temp794));
                            var temp796 = (((ushort)((ushort)1632U)) <= ((ushort)(temp790)));
                            var temp797 = ((byte)(((ushort)(temp790)) >> 11));
                            var temp798 = (((byte)(temp797 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp799 = (((ushort)(((ushort)((ushort)(temp790))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp800 = (((temp796) && (temp798)) && (temp799));
                            var temp801 = (((ushort)((ushort)1776U)) <= ((ushort)(temp790)));
                            var temp802 = (((ushort)(((ushort)((ushort)(temp790))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp803 = (((temp801) && (temp798)) && (temp802));
                            var temp804 = (((ushort)((ushort)1984U)) <= ((ushort)(temp790)));
                            var temp805 = (((ushort)(((ushort)((ushort)(temp790))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp806 = (((temp804) && (temp798)) && (temp805));
                            var temp807 = (((ushort)((ushort)2406U)) <= ((ushort)(temp790)));
                            var temp808 = ((byte)(((ushort)(temp790)) >> 12));
                            var temp809 = (((byte)(temp808 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp810 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp811 = (((temp807) && (temp809)) && (temp810));
                            var temp812 = (((ushort)((ushort)2534U)) <= ((ushort)(temp790)));
                            var temp813 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp814 = (((temp812) && (temp809)) && (temp813));
                            var temp815 = (((ushort)((ushort)2662U)) <= ((ushort)(temp790)));
                            var temp816 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp817 = (((temp815) && (temp809)) && (temp816));
                            var temp818 = (((ushort)((ushort)2790U)) <= ((ushort)(temp790)));
                            var temp819 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp820 = (((temp818) && (temp809)) && (temp819));
                            var temp821 = (((ushort)((ushort)2918U)) <= ((ushort)(temp790)));
                            var temp822 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp823 = (((temp821) && (temp809)) && (temp822));
                            var temp824 = (((ushort)((ushort)3046U)) <= ((ushort)(temp790)));
                            var temp825 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp826 = (((temp824) && (temp809)) && (temp825));
                            var temp827 = (((ushort)((ushort)3174U)) <= ((ushort)(temp790)));
                            var temp828 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp829 = (((temp827) && (temp809)) && (temp828));
                            var temp830 = (((ushort)((ushort)3302U)) <= ((ushort)(temp790)));
                            var temp831 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp832 = (((temp830) && (temp809)) && (temp831));
                            var temp833 = (((ushort)((ushort)3430U)) <= ((ushort)(temp790)));
                            var temp834 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp835 = (((temp833) && (temp809)) && (temp834));
                            var temp836 = (((ushort)((ushort)3664U)) <= ((ushort)(temp790)));
                            var temp837 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp838 = (((temp836) && (temp809)) && (temp837));
                            var temp839 = (((ushort)((ushort)3792U)) <= ((ushort)(temp790)));
                            var temp840 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp841 = (((temp839) && (temp809)) && (temp840));
                            var temp842 = (((ushort)((ushort)3872U)) <= ((ushort)(temp790)));
                            var temp843 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp844 = (((temp842) && (temp809)) && (temp843));
                            var temp845 = (((ushort)((ushort)4160U)) <= ((ushort)(temp790)));
                            var temp846 = ((byte)(((ushort)(temp790)) >> 13));
                            var temp847 = (((byte)(temp846 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp848 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp849 = (((temp845) && (temp847)) && (temp848));
                            var temp850 = (((ushort)((ushort)4240U)) <= ((ushort)(temp790)));
                            var temp851 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp852 = (((temp850) && (temp847)) && (temp851));
                            var temp853 = (((ushort)((ushort)6112U)) <= ((ushort)(temp790)));
                            var temp854 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp855 = (((temp853) && (temp847)) && (temp854));
                            var temp856 = (((ushort)((ushort)6160U)) <= ((ushort)(temp790)));
                            var temp857 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp858 = (((temp856) && (temp847)) && (temp857));
                            var temp859 = (((ushort)((ushort)6470U)) <= ((ushort)(temp790)));
                            var temp860 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp861 = (((temp859) && (temp847)) && (temp860));
                            var temp862 = (((ushort)((ushort)6608U)) <= ((ushort)(temp790)));
                            var temp863 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp864 = (((temp862) && (temp847)) && (temp863));
                            var temp865 = (((ushort)((ushort)6992U)) <= ((ushort)(temp790)));
                            var temp866 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp867 = (((temp865) && (temp847)) && (temp866));
                            var temp868 = (((ushort)((ushort)7088U)) <= ((ushort)(temp790)));
                            var temp869 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp870 = (((temp868) && (temp847)) && (temp869));
                            var temp871 = (((ushort)((ushort)7232U)) <= ((ushort)(temp790)));
                            var temp872 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp873 = (((temp871) && (temp847)) && (temp872));
                            var temp874 = (((ushort)((ushort)7248U)) <= ((ushort)(temp790)));
                            var temp875 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp876 = (((temp874) && (temp847)) && (temp875));
                            var temp877 = (((ushort)((ushort)42528U)) <= ((ushort)(temp790)));
                            var temp878 = (((ushort)(temp790)) <= ((ushort)((ushort)42537U)));
                            var temp879 = ((temp877) && (temp878));
                            var temp880 = (((ushort)((ushort)43216U)) <= ((ushort)(temp790)));
                            var temp881 = (((ushort)(temp790)) <= ((ushort)((ushort)43225U)));
                            var temp882 = ((temp880) && (temp881));
                            var temp883 = (((ushort)((ushort)43264U)) <= ((ushort)(temp790)));
                            var temp884 = (((ushort)(temp790)) <= ((ushort)((ushort)43273U)));
                            var temp885 = ((temp883) && (temp884));
                            var temp886 = (((ushort)((ushort)43600U)) <= ((ushort)(temp790)));
                            var temp887 = (((ushort)(temp790)) <= ((ushort)((ushort)43609U)));
                            var temp888 = ((temp886) && (temp887));
                            var temp889 = (((ushort)((ushort)65296U)) <= ((ushort)(temp790)));
                            var temp890 = (((ushort)(temp790)) <= ((ushort)((ushort)65305U)));
                            var temp891 = ((temp889) && (temp890));
                            var temp892 = (((((((((((((((((((((((((((((((temp795) || (temp800)) || (temp803)) || (temp806)) || (temp811)) || (temp814)) || (temp817)) || (temp820)) || (temp823)) || (temp826)) || (temp829)) || (temp832)) || (temp835)) || (temp838)) || (temp841)) || (temp844)) || (temp849)) || (temp852)) || (temp855)) || (temp858)) || (temp861)) || (temp864)) || (temp867)) || (temp870)) || (temp873)) || (temp876)) || (temp879)) || (temp882)) || (temp885)) || (temp888)) || (temp891));
                            if (temp892)
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

                M48:
                {
                    if (!ie.MoveNext())
                        goto F48;
                    i = ie.Current;
                    {
                        var temp893 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp894 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp893)));
                        var temp895 = ((int)((uint)(temp893)) <= (int)((uint)((uint)191U)));
                        var temp896 = ((temp894) && (temp895));
                        if (temp896)
                        {
                            var temp897 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp898 = Fun0(((ushort)((s)._0)), ((ushort)(temp897)));
                            s._0 = ((ushort)(temp898));
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
                        var temp899 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp900 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp899)));
                        var temp901 = ((int)((uint)(temp899)) <= (int)((uint)((uint)159U)));
                        var temp902 = ((temp900) && (temp901));
                        if (temp902)
                        {
                            var temp903 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp904 = Fun0(((ushort)((s)._0)), ((ushort)(temp903)));
                            s._0 = ((ushort)(temp904));
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
                        var temp905 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp906 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp905)));
                        var temp907 = ((int)((uint)(temp905)) <= (int)((uint)((uint)191U)));
                        var temp908 = ((temp906) && (temp907));
                        if (temp908)
                        {
                            var temp909 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp910 = Fun0(((ushort)((s)._0)), ((ushort)(temp909)));
                            s._0 = ((ushort)(temp910));
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
                        var temp911 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp912 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp911)));
                        var temp913 = ((int)((uint)(temp911)) <= (int)((uint)((uint)191U)));
                        var temp914 = ((temp912) && (temp913));
                        if (temp914)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M36;
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
                        var temp915 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp916 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp915)));
                        var temp917 = ((int)((uint)(temp915)) <= (int)((uint)((uint)191U)));
                        var temp918 = ((temp916) && (temp917));
                        if (temp918)
                        {
                            var temp919 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp920 = Fun0(((ushort)((s)._0)), ((ushort)(temp919)));
                            s._0 = ((ushort)(temp920));
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
                        var temp921 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp922 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp921)));
                        var temp923 = ((int)((uint)(temp921)) <= (int)((uint)((uint)159U)));
                        var temp924 = ((temp922) && (temp923));
                        if (temp924)
                        {
                            var temp925 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp926 = Fun0(((ushort)((s)._0)), ((ushort)(temp925)));
                            s._0 = ((ushort)(temp926));
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
                        var temp927 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp928 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp927)));
                        var temp929 = ((int)((uint)(temp927)) <= (int)((uint)((uint)191U)));
                        var temp930 = ((temp928) && (temp929));
                        if (temp930)
                        {
                            var temp931 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp932 = Fun0(((ushort)((s)._0)), ((ushort)(temp931)));
                            s._0 = ((ushort)(temp932));
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
                    var temp60 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp60)
                    {
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield break;
                    }
                    else
                    {
                        var temp61 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp62 = (((byte)(temp61 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp63 = ((temp60) && (temp62));
                        var temp64 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp65 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp64))));
                        var temp66 = ((temp63) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp65))))));
                        var temp67 = ((uint)(((int)((uint)(temp66))) >> (int)((uint)((uint)24U))));
                        yield return (Byte)(((byte)((uint)(temp67))));
                        var temp68 = ((uint)(((int)((uint)(temp66))) >> (int)((uint)((uint)16U))));
                        yield return (Byte)(((byte)((uint)(temp68))));
                        var temp69 = ((uint)(((int)((uint)(temp66))) >> (int)((uint)((uint)8U))));
                        yield return (Byte)(((byte)((uint)(temp69))));
                        var temp70 = ((temp63) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp65))))));
                        yield return (Byte)(temp70);
                        yield break;
                    }
                }

                F4:
                {
                    var temp77 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp77)
                    {
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield break;
                    }
                    else
                    {
                        var temp78 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp79 = (((byte)(temp78 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp80 = ((temp77) && (temp79));
                        var temp81 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp82 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp81))));
                        var temp83 = ((temp80) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp82))))));
                        var temp84 = ((uint)(((int)((uint)(temp83))) >> (int)((uint)((uint)24U))));
                        yield return (Byte)(((byte)((uint)(temp84))));
                        var temp85 = ((uint)(((int)((uint)(temp83))) >> (int)((uint)((uint)16U))));
                        yield return (Byte)(((byte)((uint)(temp85))));
                        var temp86 = ((uint)(((int)((uint)(temp83))) >> (int)((uint)((uint)8U))));
                        yield return (Byte)(((byte)((uint)(temp86))));
                        var temp87 = ((temp80) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp82))))));
                        yield return (Byte)(temp87);
                        yield break;
                    }
                }

                F5:
                {
                    var temp94 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp94)
                    {
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield return (Byte)((byte)0U);
                        yield break;
                    }
                    else
                    {
                        var temp95 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp96 = (((byte)(temp95 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp97 = ((temp94) && (temp96));
                        var temp98 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp99 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp98))));
                        var temp100 = ((temp97) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp99))))));
                        var temp101 = ((uint)(((int)((uint)(temp100))) >> (int)((uint)((uint)24U))));
                        yield return (Byte)(((byte)((uint)(temp101))));
                        var temp102 = ((uint)(((int)((uint)(temp100))) >> (int)((uint)((uint)16U))));
                        yield return (Byte)(((byte)((uint)(temp102))));
                        var temp103 = ((uint)(((int)((uint)(temp100))) >> (int)((uint)((uint)8U))));
                        yield return (Byte)(((byte)((uint)(temp103))));
                        var temp104 = ((temp97) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp99))))));
                        yield return (Byte)(temp104);
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

        struct DTStruct1
        {
            public UInt16 _0;
            public UInt32 _1;
            public UInt64 _2;
            public UInt32 _3;
            public DTStruct1(UInt16 v0, UInt32 v1, UInt64 v2, UInt32 v3)
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
                DTStruct1 s = new DTStruct1(((ushort)((ushort)0U)), ((uint)((uint)0U)), ((ulong)((ulong)0UL)), ((uint)((uint)0U)));
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
                        var temp71 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp72 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp71)));
                        var temp73 = ((int)((uint)(temp71)) <= (int)((uint)((uint)191U)));
                        var temp74 = ((temp72) && (temp73));
                        if (temp74)
                        {
                            var temp75 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp76 = Fun0(((ushort)((s)._0)), ((ushort)(temp75)));
                            s._0 = ((ushort)(temp76));
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
                        var temp88 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp89 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp88)));
                        var temp90 = ((int)((uint)(temp88)) <= (int)((uint)((uint)159U)));
                        var temp91 = ((temp89) && (temp90));
                        if (temp91)
                        {
                            var temp92 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp93 = Fun0(((ushort)((s)._0)), ((ushort)(temp92)));
                            s._0 = ((ushort)(temp93));
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
                        var temp105 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp106 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp105)));
                        var temp107 = ((int)((uint)(temp105)) <= (int)((uint)((uint)191U)));
                        var temp108 = ((temp106) && (temp107));
                        if (temp108)
                        {
                            var temp109 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp110 = Fun0(((ushort)((s)._0)), ((ushort)(temp109)));
                            s._0 = ((ushort)(temp110));
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
                        var temp111 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp112 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp111)));
                        var temp113 = ((int)((uint)(temp111)) <= (int)((uint)((uint)127U)));
                        var temp114 = ((temp112) && (temp113));
                        if (temp114)
                        {
                            var temp115 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp115)
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
                            var temp116 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp111)));
                            var temp117 = ((int)((uint)(temp111)) <= (int)((uint)((uint)223U)));
                            var temp118 = ((temp116) && (temp117));
                            if (temp118)
                            {
                                var temp119 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp119));
                                goto M12;
                            }
                            else
                            {
                                var temp120 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp120)
                                {
                                    var temp121 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp121));
                                    goto M13;
                                }
                                else
                                {
                                    var temp122 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp122)
                                    {
                                        var temp123 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp123));
                                        goto M14;
                                    }
                                    else
                                    {
                                        var temp124 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp111)));
                                        var temp125 = ((int)((uint)(temp111)) <= (int)((uint)((uint)239U)));
                                        var temp126 = ((temp124) && (temp125));
                                        if (temp126)
                                        {
                                            var temp127 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp127));
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
                        var temp128 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp129 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp128)));
                        var temp130 = ((int)((uint)(temp128)) <= (int)((uint)((uint)191U)));
                        var temp131 = ((temp129) && (temp130));
                        if (temp131)
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
                        var temp132 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp133 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp132)));
                        var temp134 = ((int)((uint)(temp132)) <= (int)((uint)((uint)191U)));
                        var temp135 = ((temp133) && (temp134));
                        if (temp135)
                        {
                            var temp136 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp137 = Fun0(((ushort)((s)._0)), ((ushort)(temp136)));
                            s._0 = ((ushort)(temp137));
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
                        var temp138 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp139 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp138)));
                        var temp140 = ((int)((uint)(temp138)) <= (int)((uint)((uint)159U)));
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
                        var temp144 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp145 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp144)));
                        var temp146 = ((int)((uint)(temp144)) <= (int)((uint)((uint)191U)));
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
                        var temp150 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp151 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp150)));
                        var temp152 = ((int)((uint)(temp150)) <= (int)((uint)((uint)127U)));
                        var temp153 = ((temp151) && (temp152));
                        if (temp153)
                        {
                            var temp154 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp154)
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
                            var temp155 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp150)));
                            var temp156 = ((int)((uint)(temp150)) <= (int)((uint)((uint)223U)));
                            var temp157 = ((temp155) && (temp156));
                            if (temp157)
                            {
                                var temp158 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp158));
                                goto M17;
                            }
                            else
                            {
                                var temp159 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp159)
                                {
                                    var temp160 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp160));
                                    goto M18;
                                }
                                else
                                {
                                    var temp161 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp161)
                                    {
                                        var temp162 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp162));
                                        goto M19;
                                    }
                                    else
                                    {
                                        var temp163 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp150)));
                                        var temp164 = ((int)((uint)(temp150)) <= (int)((uint)((uint)239U)));
                                        var temp165 = ((temp163) && (temp164));
                                        if (temp165)
                                        {
                                            var temp166 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp166));
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
                        var temp167 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp168 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp167)));
                        var temp169 = ((int)((uint)(temp167)) <= (int)((uint)((uint)191U)));
                        var temp170 = ((temp168) && (temp169));
                        if (temp170)
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
                        var temp171 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp172 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp171)));
                        var temp173 = ((int)((uint)(temp171)) <= (int)((uint)((uint)191U)));
                        var temp174 = ((temp172) && (temp173));
                        if (temp174)
                        {
                            var temp175 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp176 = Fun0(((ushort)((s)._0)), ((ushort)(temp175)));
                            s._0 = ((ushort)(temp176));
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
                        var temp177 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp178 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp177)));
                        var temp179 = ((int)((uint)(temp177)) <= (int)((uint)((uint)159U)));
                        var temp180 = ((temp178) && (temp179));
                        if (temp180)
                        {
                            var temp181 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp182 = Fun0(((ushort)((s)._0)), ((ushort)(temp181)));
                            s._0 = ((ushort)(temp182));
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
                        var temp183 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp184 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp183)));
                        var temp185 = ((int)((uint)(temp183)) <= (int)((uint)((uint)191U)));
                        var temp186 = ((temp184) && (temp185));
                        if (temp186)
                        {
                            var temp187 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp188 = Fun0(((ushort)((s)._0)), ((ushort)(temp187)));
                            s._0 = ((ushort)(temp188));
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
                        var temp189 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp190 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp189)));
                        var temp191 = ((int)((uint)(temp189)) <= (int)((uint)((uint)127U)));
                        var temp192 = ((temp190) && (temp191));
                        if (temp192)
                        {
                            var temp193 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp193)
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
                            var temp194 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp189)));
                            var temp195 = ((int)((uint)(temp189)) <= (int)((uint)((uint)223U)));
                            var temp196 = ((temp194) && (temp195));
                            if (temp196)
                            {
                                var temp197 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp197));
                                goto M22;
                            }
                            else
                            {
                                var temp198 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp198)
                                {
                                    var temp199 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp199));
                                    goto M23;
                                }
                                else
                                {
                                    var temp200 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp200)
                                    {
                                        var temp201 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp201));
                                        goto M24;
                                    }
                                    else
                                    {
                                        var temp202 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp189)));
                                        var temp203 = ((int)((uint)(temp189)) <= (int)((uint)((uint)239U)));
                                        var temp204 = ((temp202) && (temp203));
                                        if (temp204)
                                        {
                                            var temp205 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp205));
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
                        var temp206 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp207 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp206)));
                        var temp208 = ((int)((uint)(temp206)) <= (int)((uint)((uint)191U)));
                        var temp209 = ((temp207) && (temp208));
                        if (temp209)
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
                        var temp210 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp211 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp210)));
                        var temp212 = ((int)((uint)(temp210)) <= (int)((uint)((uint)191U)));
                        var temp213 = ((temp211) && (temp212));
                        if (temp213)
                        {
                            var temp214 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp215 = Fun0(((ushort)((s)._0)), ((ushort)(temp214)));
                            s._0 = ((ushort)(temp215));
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
                        var temp216 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp217 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp216)));
                        var temp218 = ((int)((uint)(temp216)) <= (int)((uint)((uint)159U)));
                        var temp219 = ((temp217) && (temp218));
                        if (temp219)
                        {
                            var temp220 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp221 = Fun0(((ushort)((s)._0)), ((ushort)(temp220)));
                            s._0 = ((ushort)(temp221));
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
                        var temp222 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp223 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp222)));
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
                        var temp228 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp229 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp228)));
                        var temp230 = ((int)((uint)(temp228)) <= (int)((uint)((uint)127U)));
                        var temp231 = ((temp229) && (temp230));
                        if (temp231)
                        {
                            var temp232 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp232)
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
                            var temp233 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp228)));
                            var temp234 = ((int)((uint)(temp228)) <= (int)((uint)((uint)223U)));
                            var temp235 = ((temp233) && (temp234));
                            if (temp235)
                            {
                                var temp236 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp236));
                                goto M27;
                            }
                            else
                            {
                                var temp237 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp237)
                                {
                                    var temp238 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp238));
                                    goto M28;
                                }
                                else
                                {
                                    var temp239 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp239)
                                    {
                                        var temp240 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp240));
                                        goto M29;
                                    }
                                    else
                                    {
                                        var temp241 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp228)));
                                        var temp242 = ((int)((uint)(temp228)) <= (int)((uint)((uint)239U)));
                                        var temp243 = ((temp241) && (temp242));
                                        if (temp243)
                                        {
                                            var temp244 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp244));
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
                        var temp245 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp246 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp245)));
                        var temp247 = ((int)((uint)(temp245)) <= (int)((uint)((uint)191U)));
                        var temp248 = ((temp246) && (temp247));
                        if (temp248)
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
                        var temp249 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp250 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp249)));
                        var temp251 = ((int)((uint)(temp249)) <= (int)((uint)((uint)191U)));
                        var temp252 = ((temp250) && (temp251));
                        if (temp252)
                        {
                            var temp253 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp254 = Fun0(((ushort)((s)._0)), ((ushort)(temp253)));
                            s._0 = ((ushort)(temp254));
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
                        var temp255 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp256 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp255)));
                        var temp257 = ((int)((uint)(temp255)) <= (int)((uint)((uint)159U)));
                        var temp258 = ((temp256) && (temp257));
                        if (temp258)
                        {
                            var temp259 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp260 = Fun0(((ushort)((s)._0)), ((ushort)(temp259)));
                            s._0 = ((ushort)(temp260));
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
                        var temp261 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp262 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp261)));
                        var temp263 = ((int)((uint)(temp261)) <= (int)((uint)((uint)191U)));
                        var temp264 = ((temp262) && (temp263));
                        if (temp264)
                        {
                            var temp265 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp266 = Fun0(((ushort)((s)._0)), ((ushort)(temp265)));
                            s._0 = ((ushort)(temp266));
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
                        var temp267 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp268 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp267)));
                        var temp269 = ((int)((uint)(temp267)) <= (int)((uint)((uint)127U)));
                        var temp270 = ((temp268) && (temp269));
                        if (temp270)
                        {
                            var temp271 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp272 = ((byte)(((byte)(i)) >> 6));
                            var temp273 = (((byte)(temp272 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp274 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp275 = (((temp271) && (temp273)) && (temp274));
                            if (temp275)
                            {
                                var temp276 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp277 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp276))) + ((uint)(temp267))));
                                s._1 = ((uint)(temp277));
                                goto M31;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp278 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp267)));
                            var temp279 = ((int)((uint)(temp267)) <= (int)((uint)((uint)223U)));
                            var temp280 = ((temp278) && (temp279));
                            if (temp280)
                            {
                                var temp281 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp281));
                                goto M32;
                            }
                            else
                            {
                                var temp282 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp282)
                                {
                                    var temp283 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp283));
                                    goto M33;
                                }
                                else
                                {
                                    var temp284 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp284)
                                    {
                                        var temp285 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp285));
                                        goto M34;
                                    }
                                    else
                                    {
                                        var temp286 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp267)));
                                        var temp287 = ((int)((uint)(temp267)) <= (int)((uint)((uint)239U)));
                                        var temp288 = ((temp286) && (temp287));
                                        if (temp288)
                                        {
                                            var temp289 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp289));
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
                        var temp290 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp291 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp290)));
                        var temp292 = ((int)((uint)(temp290)) <= (int)((uint)((uint)191U)));
                        var temp293 = ((temp291) && (temp292));
                        if (temp293)
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
                        var temp294 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp295 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp294)));
                        var temp296 = ((int)((uint)(temp294)) <= (int)((uint)((uint)191U)));
                        var temp297 = ((temp295) && (temp296));
                        if (temp297)
                        {
                            var temp298 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp299 = Fun0(((ushort)((s)._0)), ((ushort)(temp298)));
                            s._0 = ((ushort)(temp299));
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
                        var temp300 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp301 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp300)));
                        var temp302 = ((int)((uint)(temp300)) <= (int)((uint)((uint)159U)));
                        var temp303 = ((temp301) && (temp302));
                        if (temp303)
                        {
                            var temp304 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp305 = Fun0(((ushort)((s)._0)), ((ushort)(temp304)));
                            s._0 = ((ushort)(temp305));
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
                        var temp306 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp307 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp306)));
                        var temp308 = ((int)((uint)(temp306)) <= (int)((uint)((uint)191U)));
                        var temp309 = ((temp307) && (temp308));
                        if (temp309)
                        {
                            var temp310 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp311 = Fun0(((ushort)((s)._0)), ((ushort)(temp310)));
                            s._0 = ((ushort)(temp311));
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
                        var temp312 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp313 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp312)));
                        var temp314 = ((int)((uint)(temp312)) <= (int)((uint)((uint)127U)));
                        var temp315 = ((temp313) && (temp314));
                        if (temp315)
                        {
                            var temp316 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp316)
                            {
                                goto M36;
                            }
                            else
                            {
                                var temp317 = (((byte)(i)) == ((byte)((byte)46U)));
                                if (temp317)
                                {
                                    goto M37;
                                }
                                else
                                {
                                    var temp318 = (((byte)((byte)48U)) <= ((byte)(i)));
                                    var temp319 = ((byte)(((byte)(i)) >> 6));
                                    var temp320 = (((byte)(temp319 & 3L)) == ((byte)((byte)0U & 3L)));
                                    var temp321 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                    var temp322 = (((temp318) && (temp320)) && (temp321));
                                    if (temp322)
                                    {
                                        var temp323 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                        var temp324 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp323))) + ((uint)(temp312))));
                                        s._1 = ((uint)(temp324));
                                        goto M31;
                                    }
                                    else
                                        throw new Exception();
                                }
                            }
                        }
                        else
                        {
                            var temp325 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp312)));
                            var temp326 = ((int)((uint)(temp312)) <= (int)((uint)((uint)223U)));
                            var temp327 = ((temp325) && (temp326));
                            if (temp327)
                            {
                                var temp328 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp328));
                                goto M38;
                            }
                            else
                            {
                                var temp329 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp329)
                                {
                                    var temp330 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp330));
                                    goto M39;
                                }
                                else
                                {
                                    var temp331 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp331)
                                    {
                                        var temp332 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp332));
                                        goto M40;
                                    }
                                    else
                                    {
                                        var temp333 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp312)));
                                        var temp334 = ((int)((uint)(temp312)) <= (int)((uint)((uint)239U)));
                                        var temp335 = ((temp333) && (temp334));
                                        if (temp335)
                                        {
                                            var temp336 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp336));
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
                        var temp337 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp338 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp337)));
                        var temp339 = ((int)((uint)(temp337)) <= (int)((uint)((uint)191U)));
                        var temp340 = ((temp338) && (temp339));
                        if (temp340)
                        {
                            var temp341 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp342 = Fun0(((ushort)((s)._0)), ((ushort)(temp341)));
                            var temp343 = (((ushort)((ushort)48U)) <= ((ushort)(temp342)));
                            var temp344 = ((ushort)(((ushort)(temp342)) >> 6));
                            var temp345 = (((ushort)(temp344 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp346 = (((byte)(((byte)((ushort)(temp342))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp347 = (((temp343) && (temp345)) && (temp346));
                            var temp348 = (((ushort)((ushort)1632U)) <= ((ushort)(temp342)));
                            var temp349 = ((byte)(((ushort)(temp342)) >> 11));
                            var temp350 = (((byte)(temp349 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp351 = (((ushort)(((ushort)((ushort)(temp342))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp352 = (((temp348) && (temp350)) && (temp351));
                            var temp353 = (((ushort)((ushort)1776U)) <= ((ushort)(temp342)));
                            var temp354 = (((ushort)(((ushort)((ushort)(temp342))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp355 = (((temp353) && (temp350)) && (temp354));
                            var temp356 = (((ushort)((ushort)1984U)) <= ((ushort)(temp342)));
                            var temp357 = (((ushort)(((ushort)((ushort)(temp342))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp358 = (((temp356) && (temp350)) && (temp357));
                            var temp359 = (((ushort)((ushort)2406U)) <= ((ushort)(temp342)));
                            var temp360 = ((byte)(((ushort)(temp342)) >> 12));
                            var temp361 = (((byte)(temp360 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp362 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp363 = (((temp359) && (temp361)) && (temp362));
                            var temp364 = (((ushort)((ushort)2534U)) <= ((ushort)(temp342)));
                            var temp365 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp366 = (((temp364) && (temp361)) && (temp365));
                            var temp367 = (((ushort)((ushort)2662U)) <= ((ushort)(temp342)));
                            var temp368 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp369 = (((temp367) && (temp361)) && (temp368));
                            var temp370 = (((ushort)((ushort)2790U)) <= ((ushort)(temp342)));
                            var temp371 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp372 = (((temp370) && (temp361)) && (temp371));
                            var temp373 = (((ushort)((ushort)2918U)) <= ((ushort)(temp342)));
                            var temp374 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp375 = (((temp373) && (temp361)) && (temp374));
                            var temp376 = (((ushort)((ushort)3046U)) <= ((ushort)(temp342)));
                            var temp377 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp378 = (((temp376) && (temp361)) && (temp377));
                            var temp379 = (((ushort)((ushort)3174U)) <= ((ushort)(temp342)));
                            var temp380 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp381 = (((temp379) && (temp361)) && (temp380));
                            var temp382 = (((ushort)((ushort)3302U)) <= ((ushort)(temp342)));
                            var temp383 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp384 = (((temp382) && (temp361)) && (temp383));
                            var temp385 = (((ushort)((ushort)3430U)) <= ((ushort)(temp342)));
                            var temp386 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp387 = (((temp385) && (temp361)) && (temp386));
                            var temp388 = (((ushort)((ushort)3664U)) <= ((ushort)(temp342)));
                            var temp389 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp390 = (((temp388) && (temp361)) && (temp389));
                            var temp391 = (((ushort)((ushort)3792U)) <= ((ushort)(temp342)));
                            var temp392 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp393 = (((temp391) && (temp361)) && (temp392));
                            var temp394 = (((ushort)((ushort)3872U)) <= ((ushort)(temp342)));
                            var temp395 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp396 = (((temp394) && (temp361)) && (temp395));
                            var temp397 = (((ushort)((ushort)4160U)) <= ((ushort)(temp342)));
                            var temp398 = ((byte)(((ushort)(temp342)) >> 13));
                            var temp399 = (((byte)(temp398 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp400 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp401 = (((temp397) && (temp399)) && (temp400));
                            var temp402 = (((ushort)((ushort)4240U)) <= ((ushort)(temp342)));
                            var temp403 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp404 = (((temp402) && (temp399)) && (temp403));
                            var temp405 = (((ushort)((ushort)6112U)) <= ((ushort)(temp342)));
                            var temp406 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp407 = (((temp405) && (temp399)) && (temp406));
                            var temp408 = (((ushort)((ushort)6160U)) <= ((ushort)(temp342)));
                            var temp409 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp410 = (((temp408) && (temp399)) && (temp409));
                            var temp411 = (((ushort)((ushort)6470U)) <= ((ushort)(temp342)));
                            var temp412 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp413 = (((temp411) && (temp399)) && (temp412));
                            var temp414 = (((ushort)((ushort)6608U)) <= ((ushort)(temp342)));
                            var temp415 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp416 = (((temp414) && (temp399)) && (temp415));
                            var temp417 = (((ushort)((ushort)6992U)) <= ((ushort)(temp342)));
                            var temp418 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp419 = (((temp417) && (temp399)) && (temp418));
                            var temp420 = (((ushort)((ushort)7088U)) <= ((ushort)(temp342)));
                            var temp421 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp422 = (((temp420) && (temp399)) && (temp421));
                            var temp423 = (((ushort)((ushort)7232U)) <= ((ushort)(temp342)));
                            var temp424 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp425 = (((temp423) && (temp399)) && (temp424));
                            var temp426 = (((ushort)((ushort)7248U)) <= ((ushort)(temp342)));
                            var temp427 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp428 = (((temp426) && (temp399)) && (temp427));
                            var temp429 = (((ushort)((ushort)42528U)) <= ((ushort)(temp342)));
                            var temp430 = (((ushort)(temp342)) <= ((ushort)((ushort)42537U)));
                            var temp431 = ((temp429) && (temp430));
                            var temp432 = (((ushort)((ushort)43216U)) <= ((ushort)(temp342)));
                            var temp433 = (((ushort)(temp342)) <= ((ushort)((ushort)43225U)));
                            var temp434 = ((temp432) && (temp433));
                            var temp435 = (((ushort)((ushort)43264U)) <= ((ushort)(temp342)));
                            var temp436 = (((ushort)(temp342)) <= ((ushort)((ushort)43273U)));
                            var temp437 = ((temp435) && (temp436));
                            var temp438 = (((ushort)((ushort)43600U)) <= ((ushort)(temp342)));
                            var temp439 = (((ushort)(temp342)) <= ((ushort)((ushort)43609U)));
                            var temp440 = ((temp438) && (temp439));
                            var temp441 = (((ushort)((ushort)65296U)) <= ((ushort)(temp342)));
                            var temp442 = (((ushort)(temp342)) <= ((ushort)((ushort)65305U)));
                            var temp443 = ((temp441) && (temp442));
                            var temp444 = (((((((((((((((((((((((((((((((temp347) || (temp352)) || (temp355)) || (temp358)) || (temp363)) || (temp366)) || (temp369)) || (temp372)) || (temp375)) || (temp378)) || (temp381)) || (temp384)) || (temp387)) || (temp390)) || (temp393)) || (temp396)) || (temp401)) || (temp404)) || (temp407)) || (temp410)) || (temp413)) || (temp416)) || (temp419)) || (temp422)) || (temp425)) || (temp428)) || (temp431)) || (temp434)) || (temp437)) || (temp440)) || (temp443));
                            if (temp444)
                            {
                                var temp445 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp446 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp342));
                                var temp447 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp445))) + ((uint)(temp446))));
                                s._1 = ((uint)(temp447));
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
                        var temp448 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp449 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp448)));
                        var temp450 = ((int)((uint)(temp448)) <= (int)((uint)((uint)191U)));
                        var temp451 = ((temp449) && (temp450));
                        if (temp451)
                        {
                            var temp452 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp453 = Fun0(((ushort)((s)._0)), ((ushort)(temp452)));
                            s._0 = ((ushort)(temp453));
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
                        var temp454 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp455 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp454)));
                        var temp456 = ((int)((uint)(temp454)) <= (int)((uint)((uint)159U)));
                        var temp457 = ((temp455) && (temp456));
                        if (temp457)
                        {
                            var temp458 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp459 = Fun0(((ushort)((s)._0)), ((ushort)(temp458)));
                            s._0 = ((ushort)(temp459));
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
                        var temp460 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp461 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp460)));
                        var temp462 = ((int)((uint)(temp460)) <= (int)((uint)((uint)191U)));
                        var temp463 = ((temp461) && (temp462));
                        if (temp463)
                        {
                            var temp464 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp465 = Fun0(((ushort)((s)._0)), ((ushort)(temp464)));
                            s._0 = ((ushort)(temp465));
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
                        var temp466 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp467 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp466)));
                        var temp468 = ((int)((uint)(temp466)) <= (int)((uint)((uint)127U)));
                        var temp469 = ((temp467) && (temp468));
                        if (temp469)
                        {
                            var temp470 = (((byte)(i)) == ((byte)((byte)10U)));
                            if (temp470)
                            {
                                var temp471 = ((uint)(((uint)((uint)1U)) + ((uint)((s)._3))));
                                s._3 = ((uint)(temp471));
                                var temp472 = ((byte)(((uint)((s)._1)) >> 31));
                                var temp473 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 32) | (ulong)((uint)((s)._1));
                                var temp474 = ((ulong)(((ulong)((s)._2)) + ((ulong)(temp473))));
                                s._2 = ((ulong)(temp474));
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
                            var temp475 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp466)));
                            var temp476 = ((int)((uint)(temp466)) <= (int)((uint)((uint)223U)));
                            var temp477 = ((temp475) && (temp476));
                            if (temp477)
                            {
                                var temp478 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp478));
                                goto M51;
                            }
                            else
                            {
                                var temp479 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp479)
                                {
                                    var temp480 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp480));
                                    goto M52;
                                }
                                else
                                {
                                    var temp481 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp481)
                                    {
                                        var temp482 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp482));
                                        goto M53;
                                    }
                                    else
                                    {
                                        var temp483 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp466)));
                                        var temp484 = ((int)((uint)(temp466)) <= (int)((uint)((uint)239U)));
                                        var temp485 = ((temp483) && (temp484));
                                        if (temp485)
                                        {
                                            var temp486 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp486));
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
                        var temp487 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp488 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp487)));
                        var temp489 = ((int)((uint)(temp487)) <= (int)((uint)((uint)127U)));
                        var temp490 = ((temp488) && (temp489));
                        if (temp490)
                        {
                            var temp491 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp492 = ((byte)(((byte)(i)) >> 6));
                            var temp493 = (((byte)(temp492 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp494 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp495 = (((temp491) && (temp493)) && (temp494));
                            if (temp495)
                            {
                                goto M42;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp496 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp487)));
                            var temp497 = ((int)((uint)(temp487)) <= (int)((uint)((uint)223U)));
                            var temp498 = ((temp496) && (temp497));
                            if (temp498)
                            {
                                var temp499 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp499));
                                goto M43;
                            }
                            else
                            {
                                var temp500 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp500)
                                {
                                    var temp501 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp501));
                                    goto M44;
                                }
                                else
                                {
                                    var temp502 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp502)
                                    {
                                        var temp503 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp503));
                                        goto M45;
                                    }
                                    else
                                    {
                                        var temp504 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp487)));
                                        var temp505 = ((int)((uint)(temp487)) <= (int)((uint)((uint)239U)));
                                        var temp506 = ((temp504) && (temp505));
                                        if (temp506)
                                        {
                                            var temp507 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp507));
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
                        var temp508 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp509 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp508)));
                        var temp510 = ((int)((uint)(temp508)) <= (int)((uint)((uint)191U)));
                        var temp511 = ((temp509) && (temp510));
                        if (temp511)
                        {
                            var temp512 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp513 = Fun0(((ushort)((s)._0)), ((ushort)(temp512)));
                            var temp514 = (((ushort)((ushort)48U)) <= ((ushort)(temp513)));
                            var temp515 = ((ushort)(((ushort)(temp513)) >> 6));
                            var temp516 = (((ushort)(temp515 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp517 = (((byte)(((byte)((ushort)(temp513))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp518 = (((temp514) && (temp516)) && (temp517));
                            var temp519 = (((ushort)((ushort)1632U)) <= ((ushort)(temp513)));
                            var temp520 = ((byte)(((ushort)(temp513)) >> 11));
                            var temp521 = (((byte)(temp520 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp522 = (((ushort)(((ushort)((ushort)(temp513))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp523 = (((temp519) && (temp521)) && (temp522));
                            var temp524 = (((ushort)((ushort)1776U)) <= ((ushort)(temp513)));
                            var temp525 = (((ushort)(((ushort)((ushort)(temp513))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp526 = (((temp524) && (temp521)) && (temp525));
                            var temp527 = (((ushort)((ushort)1984U)) <= ((ushort)(temp513)));
                            var temp528 = (((ushort)(((ushort)((ushort)(temp513))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp529 = (((temp527) && (temp521)) && (temp528));
                            var temp530 = (((ushort)((ushort)2406U)) <= ((ushort)(temp513)));
                            var temp531 = ((byte)(((ushort)(temp513)) >> 12));
                            var temp532 = (((byte)(temp531 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp533 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp534 = (((temp530) && (temp532)) && (temp533));
                            var temp535 = (((ushort)((ushort)2534U)) <= ((ushort)(temp513)));
                            var temp536 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp537 = (((temp535) && (temp532)) && (temp536));
                            var temp538 = (((ushort)((ushort)2662U)) <= ((ushort)(temp513)));
                            var temp539 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp540 = (((temp538) && (temp532)) && (temp539));
                            var temp541 = (((ushort)((ushort)2790U)) <= ((ushort)(temp513)));
                            var temp542 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp543 = (((temp541) && (temp532)) && (temp542));
                            var temp544 = (((ushort)((ushort)2918U)) <= ((ushort)(temp513)));
                            var temp545 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp546 = (((temp544) && (temp532)) && (temp545));
                            var temp547 = (((ushort)((ushort)3046U)) <= ((ushort)(temp513)));
                            var temp548 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp549 = (((temp547) && (temp532)) && (temp548));
                            var temp550 = (((ushort)((ushort)3174U)) <= ((ushort)(temp513)));
                            var temp551 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp552 = (((temp550) && (temp532)) && (temp551));
                            var temp553 = (((ushort)((ushort)3302U)) <= ((ushort)(temp513)));
                            var temp554 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp555 = (((temp553) && (temp532)) && (temp554));
                            var temp556 = (((ushort)((ushort)3430U)) <= ((ushort)(temp513)));
                            var temp557 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp558 = (((temp556) && (temp532)) && (temp557));
                            var temp559 = (((ushort)((ushort)3664U)) <= ((ushort)(temp513)));
                            var temp560 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp561 = (((temp559) && (temp532)) && (temp560));
                            var temp562 = (((ushort)((ushort)3792U)) <= ((ushort)(temp513)));
                            var temp563 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp564 = (((temp562) && (temp532)) && (temp563));
                            var temp565 = (((ushort)((ushort)3872U)) <= ((ushort)(temp513)));
                            var temp566 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp567 = (((temp565) && (temp532)) && (temp566));
                            var temp568 = (((ushort)((ushort)4160U)) <= ((ushort)(temp513)));
                            var temp569 = ((byte)(((ushort)(temp513)) >> 13));
                            var temp570 = (((byte)(temp569 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp571 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp572 = (((temp568) && (temp570)) && (temp571));
                            var temp573 = (((ushort)((ushort)4240U)) <= ((ushort)(temp513)));
                            var temp574 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp575 = (((temp573) && (temp570)) && (temp574));
                            var temp576 = (((ushort)((ushort)6112U)) <= ((ushort)(temp513)));
                            var temp577 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp578 = (((temp576) && (temp570)) && (temp577));
                            var temp579 = (((ushort)((ushort)6160U)) <= ((ushort)(temp513)));
                            var temp580 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp581 = (((temp579) && (temp570)) && (temp580));
                            var temp582 = (((ushort)((ushort)6470U)) <= ((ushort)(temp513)));
                            var temp583 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp584 = (((temp582) && (temp570)) && (temp583));
                            var temp585 = (((ushort)((ushort)6608U)) <= ((ushort)(temp513)));
                            var temp586 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp587 = (((temp585) && (temp570)) && (temp586));
                            var temp588 = (((ushort)((ushort)6992U)) <= ((ushort)(temp513)));
                            var temp589 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp590 = (((temp588) && (temp570)) && (temp589));
                            var temp591 = (((ushort)((ushort)7088U)) <= ((ushort)(temp513)));
                            var temp592 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp593 = (((temp591) && (temp570)) && (temp592));
                            var temp594 = (((ushort)((ushort)7232U)) <= ((ushort)(temp513)));
                            var temp595 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp596 = (((temp594) && (temp570)) && (temp595));
                            var temp597 = (((ushort)((ushort)7248U)) <= ((ushort)(temp513)));
                            var temp598 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp599 = (((temp597) && (temp570)) && (temp598));
                            var temp600 = (((ushort)((ushort)42528U)) <= ((ushort)(temp513)));
                            var temp601 = (((ushort)(temp513)) <= ((ushort)((ushort)42537U)));
                            var temp602 = ((temp600) && (temp601));
                            var temp603 = (((ushort)((ushort)43216U)) <= ((ushort)(temp513)));
                            var temp604 = (((ushort)(temp513)) <= ((ushort)((ushort)43225U)));
                            var temp605 = ((temp603) && (temp604));
                            var temp606 = (((ushort)((ushort)43264U)) <= ((ushort)(temp513)));
                            var temp607 = (((ushort)(temp513)) <= ((ushort)((ushort)43273U)));
                            var temp608 = ((temp606) && (temp607));
                            var temp609 = (((ushort)((ushort)43600U)) <= ((ushort)(temp513)));
                            var temp610 = (((ushort)(temp513)) <= ((ushort)((ushort)43609U)));
                            var temp611 = ((temp609) && (temp610));
                            var temp612 = (((ushort)((ushort)65296U)) <= ((ushort)(temp513)));
                            var temp613 = (((ushort)(temp513)) <= ((ushort)((ushort)65305U)));
                            var temp614 = ((temp612) && (temp613));
                            var temp615 = (((((((((((((((((((((((((((((((temp518) || (temp523)) || (temp526)) || (temp529)) || (temp534)) || (temp537)) || (temp540)) || (temp543)) || (temp546)) || (temp549)) || (temp552)) || (temp555)) || (temp558)) || (temp561)) || (temp564)) || (temp567)) || (temp572)) || (temp575)) || (temp578)) || (temp581)) || (temp584)) || (temp587)) || (temp590)) || (temp593)) || (temp596)) || (temp599)) || (temp602)) || (temp605)) || (temp608)) || (temp611)) || (temp614));
                            if (temp615)
                            {
                                var temp616 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp617 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp513));
                                var temp618 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp616))) + ((uint)(temp617))));
                                s._1 = ((uint)(temp618));
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
                        var temp619 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp620 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp619)));
                        var temp621 = ((int)((uint)(temp619)) <= (int)((uint)((uint)191U)));
                        var temp622 = ((temp620) && (temp621));
                        if (temp622)
                        {
                            var temp623 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp624 = Fun0(((ushort)((s)._0)), ((ushort)(temp623)));
                            s._0 = ((ushort)(temp624));
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
                        var temp625 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp626 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp625)));
                        var temp627 = ((int)((uint)(temp625)) <= (int)((uint)((uint)159U)));
                        var temp628 = ((temp626) && (temp627));
                        if (temp628)
                        {
                            var temp629 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp630 = Fun0(((ushort)((s)._0)), ((ushort)(temp629)));
                            s._0 = ((ushort)(temp630));
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
                        var temp631 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp632 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp631)));
                        var temp633 = ((int)((uint)(temp631)) <= (int)((uint)((uint)191U)));
                        var temp634 = ((temp632) && (temp633));
                        if (temp634)
                        {
                            var temp635 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp636 = Fun0(((ushort)((s)._0)), ((ushort)(temp635)));
                            s._0 = ((ushort)(temp636));
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
                        var temp637 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp638 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp637)));
                        var temp639 = ((int)((uint)(temp637)) <= (int)((uint)((uint)127U)));
                        var temp640 = ((temp638) && (temp639));
                        if (temp640)
                        {
                            var temp641 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp641)
                            {
                                goto M36;
                            }
                            else
                            {
                                var temp642 = (((byte)((byte)48U)) <= ((byte)(i)));
                                var temp643 = ((byte)(((byte)(i)) >> 6));
                                var temp644 = (((byte)(temp643 & 3L)) == ((byte)((byte)0U & 3L)));
                                var temp645 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp646 = (((temp642) && (temp644)) && (temp645));
                                if (temp646)
                                {
                                    goto M42;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                        else
                        {
                            var temp647 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp637)));
                            var temp648 = ((int)((uint)(temp637)) <= (int)((uint)((uint)223U)));
                            var temp649 = ((temp647) && (temp648));
                            if (temp649)
                            {
                                var temp650 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp650));
                                goto M47;
                            }
                            else
                            {
                                var temp651 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp651)
                                {
                                    var temp652 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp652));
                                    goto M48;
                                }
                                else
                                {
                                    var temp653 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp653)
                                    {
                                        var temp654 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp654));
                                        goto M49;
                                    }
                                    else
                                    {
                                        var temp655 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp637)));
                                        var temp656 = ((int)((uint)(temp637)) <= (int)((uint)((uint)239U)));
                                        var temp657 = ((temp655) && (temp656));
                                        if (temp657)
                                        {
                                            var temp658 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp658));
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
                        var temp659 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp660 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp659)));
                        var temp661 = ((int)((uint)(temp659)) <= (int)((uint)((uint)191U)));
                        var temp662 = ((temp660) && (temp661));
                        if (temp662)
                        {
                            var temp663 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp664 = Fun0(((ushort)((s)._0)), ((ushort)(temp663)));
                            var temp665 = (((ushort)((ushort)48U)) <= ((ushort)(temp664)));
                            var temp666 = ((ushort)(((ushort)(temp664)) >> 6));
                            var temp667 = (((ushort)(temp666 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp668 = (((byte)(((byte)((ushort)(temp664))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp669 = (((temp665) && (temp667)) && (temp668));
                            var temp670 = (((ushort)((ushort)1632U)) <= ((ushort)(temp664)));
                            var temp671 = ((byte)(((ushort)(temp664)) >> 11));
                            var temp672 = (((byte)(temp671 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp673 = (((ushort)(((ushort)((ushort)(temp664))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp674 = (((temp670) && (temp672)) && (temp673));
                            var temp675 = (((ushort)((ushort)1776U)) <= ((ushort)(temp664)));
                            var temp676 = (((ushort)(((ushort)((ushort)(temp664))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp677 = (((temp675) && (temp672)) && (temp676));
                            var temp678 = (((ushort)((ushort)1984U)) <= ((ushort)(temp664)));
                            var temp679 = (((ushort)(((ushort)((ushort)(temp664))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp680 = (((temp678) && (temp672)) && (temp679));
                            var temp681 = (((ushort)((ushort)2406U)) <= ((ushort)(temp664)));
                            var temp682 = ((byte)(((ushort)(temp664)) >> 12));
                            var temp683 = (((byte)(temp682 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp684 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp685 = (((temp681) && (temp683)) && (temp684));
                            var temp686 = (((ushort)((ushort)2534U)) <= ((ushort)(temp664)));
                            var temp687 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp688 = (((temp686) && (temp683)) && (temp687));
                            var temp689 = (((ushort)((ushort)2662U)) <= ((ushort)(temp664)));
                            var temp690 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp691 = (((temp689) && (temp683)) && (temp690));
                            var temp692 = (((ushort)((ushort)2790U)) <= ((ushort)(temp664)));
                            var temp693 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp694 = (((temp692) && (temp683)) && (temp693));
                            var temp695 = (((ushort)((ushort)2918U)) <= ((ushort)(temp664)));
                            var temp696 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp697 = (((temp695) && (temp683)) && (temp696));
                            var temp698 = (((ushort)((ushort)3046U)) <= ((ushort)(temp664)));
                            var temp699 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp700 = (((temp698) && (temp683)) && (temp699));
                            var temp701 = (((ushort)((ushort)3174U)) <= ((ushort)(temp664)));
                            var temp702 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp703 = (((temp701) && (temp683)) && (temp702));
                            var temp704 = (((ushort)((ushort)3302U)) <= ((ushort)(temp664)));
                            var temp705 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp706 = (((temp704) && (temp683)) && (temp705));
                            var temp707 = (((ushort)((ushort)3430U)) <= ((ushort)(temp664)));
                            var temp708 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp709 = (((temp707) && (temp683)) && (temp708));
                            var temp710 = (((ushort)((ushort)3664U)) <= ((ushort)(temp664)));
                            var temp711 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp712 = (((temp710) && (temp683)) && (temp711));
                            var temp713 = (((ushort)((ushort)3792U)) <= ((ushort)(temp664)));
                            var temp714 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp715 = (((temp713) && (temp683)) && (temp714));
                            var temp716 = (((ushort)((ushort)3872U)) <= ((ushort)(temp664)));
                            var temp717 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp718 = (((temp716) && (temp683)) && (temp717));
                            var temp719 = (((ushort)((ushort)4160U)) <= ((ushort)(temp664)));
                            var temp720 = ((byte)(((ushort)(temp664)) >> 13));
                            var temp721 = (((byte)(temp720 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp722 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp723 = (((temp719) && (temp721)) && (temp722));
                            var temp724 = (((ushort)((ushort)4240U)) <= ((ushort)(temp664)));
                            var temp725 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp726 = (((temp724) && (temp721)) && (temp725));
                            var temp727 = (((ushort)((ushort)6112U)) <= ((ushort)(temp664)));
                            var temp728 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp729 = (((temp727) && (temp721)) && (temp728));
                            var temp730 = (((ushort)((ushort)6160U)) <= ((ushort)(temp664)));
                            var temp731 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp732 = (((temp730) && (temp721)) && (temp731));
                            var temp733 = (((ushort)((ushort)6470U)) <= ((ushort)(temp664)));
                            var temp734 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp735 = (((temp733) && (temp721)) && (temp734));
                            var temp736 = (((ushort)((ushort)6608U)) <= ((ushort)(temp664)));
                            var temp737 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp738 = (((temp736) && (temp721)) && (temp737));
                            var temp739 = (((ushort)((ushort)6992U)) <= ((ushort)(temp664)));
                            var temp740 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp741 = (((temp739) && (temp721)) && (temp740));
                            var temp742 = (((ushort)((ushort)7088U)) <= ((ushort)(temp664)));
                            var temp743 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp744 = (((temp742) && (temp721)) && (temp743));
                            var temp745 = (((ushort)((ushort)7232U)) <= ((ushort)(temp664)));
                            var temp746 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp747 = (((temp745) && (temp721)) && (temp746));
                            var temp748 = (((ushort)((ushort)7248U)) <= ((ushort)(temp664)));
                            var temp749 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp750 = (((temp748) && (temp721)) && (temp749));
                            var temp751 = (((ushort)((ushort)42528U)) <= ((ushort)(temp664)));
                            var temp752 = (((ushort)(temp664)) <= ((ushort)((ushort)42537U)));
                            var temp753 = ((temp751) && (temp752));
                            var temp754 = (((ushort)((ushort)43216U)) <= ((ushort)(temp664)));
                            var temp755 = (((ushort)(temp664)) <= ((ushort)((ushort)43225U)));
                            var temp756 = ((temp754) && (temp755));
                            var temp757 = (((ushort)((ushort)43264U)) <= ((ushort)(temp664)));
                            var temp758 = (((ushort)(temp664)) <= ((ushort)((ushort)43273U)));
                            var temp759 = ((temp757) && (temp758));
                            var temp760 = (((ushort)((ushort)43600U)) <= ((ushort)(temp664)));
                            var temp761 = (((ushort)(temp664)) <= ((ushort)((ushort)43609U)));
                            var temp762 = ((temp760) && (temp761));
                            var temp763 = (((ushort)((ushort)65296U)) <= ((ushort)(temp664)));
                            var temp764 = (((ushort)(temp664)) <= ((ushort)((ushort)65305U)));
                            var temp765 = ((temp763) && (temp764));
                            var temp766 = (((((((((((((((((((((((((((((((temp669) || (temp674)) || (temp677)) || (temp680)) || (temp685)) || (temp688)) || (temp691)) || (temp694)) || (temp697)) || (temp700)) || (temp703)) || (temp706)) || (temp709)) || (temp712)) || (temp715)) || (temp718)) || (temp723)) || (temp726)) || (temp729)) || (temp732)) || (temp735)) || (temp738)) || (temp741)) || (temp744)) || (temp747)) || (temp750)) || (temp753)) || (temp756)) || (temp759)) || (temp762)) || (temp765));
                            if (temp766)
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
                        var temp767 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp768 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp767)));
                        var temp769 = ((int)((uint)(temp767)) <= (int)((uint)((uint)191U)));
                        var temp770 = ((temp768) && (temp769));
                        if (temp770)
                        {
                            var temp771 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp772 = Fun0(((ushort)((s)._0)), ((ushort)(temp771)));
                            s._0 = ((ushort)(temp772));
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
                        var temp773 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp774 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp773)));
                        var temp775 = ((int)((uint)(temp773)) <= (int)((uint)((uint)159U)));
                        var temp776 = ((temp774) && (temp775));
                        if (temp776)
                        {
                            var temp777 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp778 = Fun0(((ushort)((s)._0)), ((ushort)(temp777)));
                            s._0 = ((ushort)(temp778));
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
                        var temp779 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp780 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp779)));
                        var temp781 = ((int)((uint)(temp779)) <= (int)((uint)((uint)191U)));
                        var temp782 = ((temp780) && (temp781));
                        if (temp782)
                        {
                            var temp783 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp784 = Fun0(((ushort)((s)._0)), ((ushort)(temp783)));
                            s._0 = ((ushort)(temp784));
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
                        var temp785 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp786 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp785)));
                        var temp787 = ((int)((uint)(temp785)) <= (int)((uint)((uint)191U)));
                        var temp788 = ((temp786) && (temp787));
                        if (temp788)
                        {
                            var temp789 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp790 = Fun0(((ushort)((s)._0)), ((ushort)(temp789)));
                            var temp791 = (((ushort)((ushort)48U)) <= ((ushort)(temp790)));
                            var temp792 = ((ushort)(((ushort)(temp790)) >> 6));
                            var temp793 = (((ushort)(temp792 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp794 = (((byte)(((byte)((ushort)(temp790))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp795 = (((temp791) && (temp793)) && (temp794));
                            var temp796 = (((ushort)((ushort)1632U)) <= ((ushort)(temp790)));
                            var temp797 = ((byte)(((ushort)(temp790)) >> 11));
                            var temp798 = (((byte)(temp797 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp799 = (((ushort)(((ushort)((ushort)(temp790))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp800 = (((temp796) && (temp798)) && (temp799));
                            var temp801 = (((ushort)((ushort)1776U)) <= ((ushort)(temp790)));
                            var temp802 = (((ushort)(((ushort)((ushort)(temp790))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp803 = (((temp801) && (temp798)) && (temp802));
                            var temp804 = (((ushort)((ushort)1984U)) <= ((ushort)(temp790)));
                            var temp805 = (((ushort)(((ushort)((ushort)(temp790))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp806 = (((temp804) && (temp798)) && (temp805));
                            var temp807 = (((ushort)((ushort)2406U)) <= ((ushort)(temp790)));
                            var temp808 = ((byte)(((ushort)(temp790)) >> 12));
                            var temp809 = (((byte)(temp808 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp810 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp811 = (((temp807) && (temp809)) && (temp810));
                            var temp812 = (((ushort)((ushort)2534U)) <= ((ushort)(temp790)));
                            var temp813 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp814 = (((temp812) && (temp809)) && (temp813));
                            var temp815 = (((ushort)((ushort)2662U)) <= ((ushort)(temp790)));
                            var temp816 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp817 = (((temp815) && (temp809)) && (temp816));
                            var temp818 = (((ushort)((ushort)2790U)) <= ((ushort)(temp790)));
                            var temp819 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp820 = (((temp818) && (temp809)) && (temp819));
                            var temp821 = (((ushort)((ushort)2918U)) <= ((ushort)(temp790)));
                            var temp822 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp823 = (((temp821) && (temp809)) && (temp822));
                            var temp824 = (((ushort)((ushort)3046U)) <= ((ushort)(temp790)));
                            var temp825 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp826 = (((temp824) && (temp809)) && (temp825));
                            var temp827 = (((ushort)((ushort)3174U)) <= ((ushort)(temp790)));
                            var temp828 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp829 = (((temp827) && (temp809)) && (temp828));
                            var temp830 = (((ushort)((ushort)3302U)) <= ((ushort)(temp790)));
                            var temp831 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp832 = (((temp830) && (temp809)) && (temp831));
                            var temp833 = (((ushort)((ushort)3430U)) <= ((ushort)(temp790)));
                            var temp834 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp835 = (((temp833) && (temp809)) && (temp834));
                            var temp836 = (((ushort)((ushort)3664U)) <= ((ushort)(temp790)));
                            var temp837 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp838 = (((temp836) && (temp809)) && (temp837));
                            var temp839 = (((ushort)((ushort)3792U)) <= ((ushort)(temp790)));
                            var temp840 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp841 = (((temp839) && (temp809)) && (temp840));
                            var temp842 = (((ushort)((ushort)3872U)) <= ((ushort)(temp790)));
                            var temp843 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp844 = (((temp842) && (temp809)) && (temp843));
                            var temp845 = (((ushort)((ushort)4160U)) <= ((ushort)(temp790)));
                            var temp846 = ((byte)(((ushort)(temp790)) >> 13));
                            var temp847 = (((byte)(temp846 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp848 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp849 = (((temp845) && (temp847)) && (temp848));
                            var temp850 = (((ushort)((ushort)4240U)) <= ((ushort)(temp790)));
                            var temp851 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp852 = (((temp850) && (temp847)) && (temp851));
                            var temp853 = (((ushort)((ushort)6112U)) <= ((ushort)(temp790)));
                            var temp854 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp855 = (((temp853) && (temp847)) && (temp854));
                            var temp856 = (((ushort)((ushort)6160U)) <= ((ushort)(temp790)));
                            var temp857 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp858 = (((temp856) && (temp847)) && (temp857));
                            var temp859 = (((ushort)((ushort)6470U)) <= ((ushort)(temp790)));
                            var temp860 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp861 = (((temp859) && (temp847)) && (temp860));
                            var temp862 = (((ushort)((ushort)6608U)) <= ((ushort)(temp790)));
                            var temp863 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp864 = (((temp862) && (temp847)) && (temp863));
                            var temp865 = (((ushort)((ushort)6992U)) <= ((ushort)(temp790)));
                            var temp866 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp867 = (((temp865) && (temp847)) && (temp866));
                            var temp868 = (((ushort)((ushort)7088U)) <= ((ushort)(temp790)));
                            var temp869 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp870 = (((temp868) && (temp847)) && (temp869));
                            var temp871 = (((ushort)((ushort)7232U)) <= ((ushort)(temp790)));
                            var temp872 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp873 = (((temp871) && (temp847)) && (temp872));
                            var temp874 = (((ushort)((ushort)7248U)) <= ((ushort)(temp790)));
                            var temp875 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp876 = (((temp874) && (temp847)) && (temp875));
                            var temp877 = (((ushort)((ushort)42528U)) <= ((ushort)(temp790)));
                            var temp878 = (((ushort)(temp790)) <= ((ushort)((ushort)42537U)));
                            var temp879 = ((temp877) && (temp878));
                            var temp880 = (((ushort)((ushort)43216U)) <= ((ushort)(temp790)));
                            var temp881 = (((ushort)(temp790)) <= ((ushort)((ushort)43225U)));
                            var temp882 = ((temp880) && (temp881));
                            var temp883 = (((ushort)((ushort)43264U)) <= ((ushort)(temp790)));
                            var temp884 = (((ushort)(temp790)) <= ((ushort)((ushort)43273U)));
                            var temp885 = ((temp883) && (temp884));
                            var temp886 = (((ushort)((ushort)43600U)) <= ((ushort)(temp790)));
                            var temp887 = (((ushort)(temp790)) <= ((ushort)((ushort)43609U)));
                            var temp888 = ((temp886) && (temp887));
                            var temp889 = (((ushort)((ushort)65296U)) <= ((ushort)(temp790)));
                            var temp890 = (((ushort)(temp790)) <= ((ushort)((ushort)65305U)));
                            var temp891 = ((temp889) && (temp890));
                            var temp892 = (((((((((((((((((((((((((((((((temp795) || (temp800)) || (temp803)) || (temp806)) || (temp811)) || (temp814)) || (temp817)) || (temp820)) || (temp823)) || (temp826)) || (temp829)) || (temp832)) || (temp835)) || (temp838)) || (temp841)) || (temp844)) || (temp849)) || (temp852)) || (temp855)) || (temp858)) || (temp861)) || (temp864)) || (temp867)) || (temp870)) || (temp873)) || (temp876)) || (temp879)) || (temp882)) || (temp885)) || (temp888)) || (temp891));
                            if (temp892)
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
                        var temp893 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp894 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp893)));
                        var temp895 = ((int)((uint)(temp893)) <= (int)((uint)((uint)191U)));
                        var temp896 = ((temp894) && (temp895));
                        if (temp896)
                        {
                            var temp897 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp898 = Fun0(((ushort)((s)._0)), ((ushort)(temp897)));
                            s._0 = ((ushort)(temp898));
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
                        var temp899 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp900 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp899)));
                        var temp901 = ((int)((uint)(temp899)) <= (int)((uint)((uint)159U)));
                        var temp902 = ((temp900) && (temp901));
                        if (temp902)
                        {
                            var temp903 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp904 = Fun0(((ushort)((s)._0)), ((ushort)(temp903)));
                            s._0 = ((ushort)(temp904));
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
                        var temp905 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp906 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp905)));
                        var temp907 = ((int)((uint)(temp905)) <= (int)((uint)((uint)191U)));
                        var temp908 = ((temp906) && (temp907));
                        if (temp908)
                        {
                            var temp909 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp910 = Fun0(((ushort)((s)._0)), ((ushort)(temp909)));
                            s._0 = ((ushort)(temp910));
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
                        var temp911 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp912 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp911)));
                        var temp913 = ((int)((uint)(temp911)) <= (int)((uint)((uint)191U)));
                        var temp914 = ((temp912) && (temp913));
                        if (temp914)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M36;
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
                        var temp915 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp916 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp915)));
                        var temp917 = ((int)((uint)(temp915)) <= (int)((uint)((uint)191U)));
                        var temp918 = ((temp916) && (temp917));
                        if (temp918)
                        {
                            var temp919 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp920 = Fun0(((ushort)((s)._0)), ((ushort)(temp919)));
                            s._0 = ((ushort)(temp920));
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
                        var temp921 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp922 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp921)));
                        var temp923 = ((int)((uint)(temp921)) <= (int)((uint)((uint)159U)));
                        var temp924 = ((temp922) && (temp923));
                        if (temp924)
                        {
                            var temp925 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp926 = Fun0(((ushort)((s)._0)), ((ushort)(temp925)));
                            s._0 = ((ushort)(temp926));
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
                        var temp927 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp928 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp927)));
                        var temp929 = ((int)((uint)(temp927)) <= (int)((uint)((uint)191U)));
                        var temp930 = ((temp928) && (temp929));
                        if (temp930)
                        {
                            var temp931 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp932 = Fun0(((ushort)((s)._0)), ((ushort)(temp931)));
                            s._0 = ((ushort)(temp932));
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
                    var temp60 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp60)
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

                        var temp61 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp62 = (((byte)(temp61 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp63 = ((temp60) && (temp62));
                        var temp64 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp65 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp64))));
                        var temp66 = ((temp63) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp65))))));
                        var temp67 = ((uint)(((int)((uint)(temp66))) >> (int)((uint)((uint)24U))));
                        oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp67))));
                        var temp68 = ((uint)(((int)((uint)(temp66))) >> (int)((uint)((uint)16U))));
                        oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp68))));
                        var temp69 = ((uint)(((int)((uint)(temp66))) >> (int)((uint)((uint)8U))));
                        oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp69))));
                        var temp70 = ((temp63) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp65))))));
                        oBuf[oIndex + 3] = (Byte)(temp70);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                }

                F4:
                {
                    var temp77 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp77)
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

                        var temp78 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp79 = (((byte)(temp78 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp80 = ((temp77) && (temp79));
                        var temp81 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp82 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp81))));
                        var temp83 = ((temp80) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp82))))));
                        var temp84 = ((uint)(((int)((uint)(temp83))) >> (int)((uint)((uint)24U))));
                        oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp84))));
                        var temp85 = ((uint)(((int)((uint)(temp83))) >> (int)((uint)((uint)16U))));
                        oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp85))));
                        var temp86 = ((uint)(((int)((uint)(temp83))) >> (int)((uint)((uint)8U))));
                        oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp86))));
                        var temp87 = ((temp80) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp82))))));
                        oBuf[oIndex + 3] = (Byte)(temp87);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                }

                F5:
                {
                    var temp94 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp94)
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

                        var temp95 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp96 = (((byte)(temp95 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp97 = ((temp94) && (temp96));
                        var temp98 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp99 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp98))));
                        var temp100 = ((temp97) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp99))))));
                        var temp101 = ((uint)(((int)((uint)(temp100))) >> (int)((uint)((uint)24U))));
                        oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp101))));
                        var temp102 = ((uint)(((int)((uint)(temp100))) >> (int)((uint)((uint)16U))));
                        oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp102))));
                        var temp103 = ((uint)(((int)((uint)(temp100))) >> (int)((uint)((uint)8U))));
                        oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp103))));
                        var temp104 = ((temp97) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp99))))));
                        oBuf[oIndex + 3] = (Byte)(temp104);
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

        struct DTStruct2
        {
            public UInt16 _0;
            public UInt32 _1;
            public UInt64 _2;
            public UInt32 _3;
            public DTStruct2(UInt16 v0, UInt32 v1, UInt64 v2, UInt32 v3)
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
                DTStruct2 s = new DTStruct2(((ushort)((ushort)0U)), ((uint)((uint)0U)), ((ulong)((ulong)0UL)), ((uint)((uint)0U)));
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
                        var temp71 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp72 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp71)));
                        var temp73 = ((int)((uint)(temp71)) <= (int)((uint)((uint)191U)));
                        var temp74 = ((temp72) && (temp73));
                        if (temp74)
                        {
                            var temp75 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp76 = Fun0(((ushort)((s)._0)), ((ushort)(temp75)));
                            s._0 = ((ushort)(temp76));
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
                        var temp88 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp89 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp88)));
                        var temp90 = ((int)((uint)(temp88)) <= (int)((uint)((uint)159U)));
                        var temp91 = ((temp89) && (temp90));
                        if (temp91)
                        {
                            var temp92 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp93 = Fun0(((ushort)((s)._0)), ((ushort)(temp92)));
                            s._0 = ((ushort)(temp93));
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
                        var temp105 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp106 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp105)));
                        var temp107 = ((int)((uint)(temp105)) <= (int)((uint)((uint)191U)));
                        var temp108 = ((temp106) && (temp107));
                        if (temp108)
                        {
                            var temp109 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp110 = Fun0(((ushort)((s)._0)), ((ushort)(temp109)));
                            s._0 = ((ushort)(temp110));
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
                        var temp111 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp112 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp111)));
                        var temp113 = ((int)((uint)(temp111)) <= (int)((uint)((uint)127U)));
                        var temp114 = ((temp112) && (temp113));
                        if (temp114)
                        {
                            var temp115 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp115)
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
                            var temp116 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp111)));
                            var temp117 = ((int)((uint)(temp111)) <= (int)((uint)((uint)223U)));
                            var temp118 = ((temp116) && (temp117));
                            if (temp118)
                            {
                                var temp119 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp119));
                                goto M12;
                            }
                            else
                            {
                                var temp120 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp120)
                                {
                                    var temp121 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp121));
                                    goto M13;
                                }
                                else
                                {
                                    var temp122 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp122)
                                    {
                                        var temp123 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp123));
                                        goto M14;
                                    }
                                    else
                                    {
                                        var temp124 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp111)));
                                        var temp125 = ((int)((uint)(temp111)) <= (int)((uint)((uint)239U)));
                                        var temp126 = ((temp124) && (temp125));
                                        if (temp126)
                                        {
                                            var temp127 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp127));
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
                        var temp128 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp129 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp128)));
                        var temp130 = ((int)((uint)(temp128)) <= (int)((uint)((uint)191U)));
                        var temp131 = ((temp129) && (temp130));
                        if (temp131)
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
                        var temp132 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp133 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp132)));
                        var temp134 = ((int)((uint)(temp132)) <= (int)((uint)((uint)191U)));
                        var temp135 = ((temp133) && (temp134));
                        if (temp135)
                        {
                            var temp136 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp137 = Fun0(((ushort)((s)._0)), ((ushort)(temp136)));
                            s._0 = ((ushort)(temp137));
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
                        var temp138 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp139 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp138)));
                        var temp140 = ((int)((uint)(temp138)) <= (int)((uint)((uint)159U)));
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

                M10:
                {
                    if (++iIndex >= input.Length)
                        goto F10;
                    i = input[iIndex];
                    {
                        var temp144 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp145 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp144)));
                        var temp146 = ((int)((uint)(temp144)) <= (int)((uint)((uint)191U)));
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

                M11:
                {
                    if (++iIndex >= input.Length)
                        goto F11;
                    i = input[iIndex];
                    {
                        var temp150 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp151 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp150)));
                        var temp152 = ((int)((uint)(temp150)) <= (int)((uint)((uint)127U)));
                        var temp153 = ((temp151) && (temp152));
                        if (temp153)
                        {
                            var temp154 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp154)
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
                            var temp155 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp150)));
                            var temp156 = ((int)((uint)(temp150)) <= (int)((uint)((uint)223U)));
                            var temp157 = ((temp155) && (temp156));
                            if (temp157)
                            {
                                var temp158 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp158));
                                goto M17;
                            }
                            else
                            {
                                var temp159 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp159)
                                {
                                    var temp160 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp160));
                                    goto M18;
                                }
                                else
                                {
                                    var temp161 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp161)
                                    {
                                        var temp162 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp162));
                                        goto M19;
                                    }
                                    else
                                    {
                                        var temp163 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp150)));
                                        var temp164 = ((int)((uint)(temp150)) <= (int)((uint)((uint)239U)));
                                        var temp165 = ((temp163) && (temp164));
                                        if (temp165)
                                        {
                                            var temp166 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp166));
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
                        var temp167 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp168 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp167)));
                        var temp169 = ((int)((uint)(temp167)) <= (int)((uint)((uint)191U)));
                        var temp170 = ((temp168) && (temp169));
                        if (temp170)
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
                        var temp171 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp172 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp171)));
                        var temp173 = ((int)((uint)(temp171)) <= (int)((uint)((uint)191U)));
                        var temp174 = ((temp172) && (temp173));
                        if (temp174)
                        {
                            var temp175 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp176 = Fun0(((ushort)((s)._0)), ((ushort)(temp175)));
                            s._0 = ((ushort)(temp176));
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
                        var temp177 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp178 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp177)));
                        var temp179 = ((int)((uint)(temp177)) <= (int)((uint)((uint)159U)));
                        var temp180 = ((temp178) && (temp179));
                        if (temp180)
                        {
                            var temp181 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp182 = Fun0(((ushort)((s)._0)), ((ushort)(temp181)));
                            s._0 = ((ushort)(temp182));
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
                        var temp183 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp184 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp183)));
                        var temp185 = ((int)((uint)(temp183)) <= (int)((uint)((uint)191U)));
                        var temp186 = ((temp184) && (temp185));
                        if (temp186)
                        {
                            var temp187 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp188 = Fun0(((ushort)((s)._0)), ((ushort)(temp187)));
                            s._0 = ((ushort)(temp188));
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
                        var temp189 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp190 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp189)));
                        var temp191 = ((int)((uint)(temp189)) <= (int)((uint)((uint)127U)));
                        var temp192 = ((temp190) && (temp191));
                        if (temp192)
                        {
                            var temp193 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp193)
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
                            var temp194 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp189)));
                            var temp195 = ((int)((uint)(temp189)) <= (int)((uint)((uint)223U)));
                            var temp196 = ((temp194) && (temp195));
                            if (temp196)
                            {
                                var temp197 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp197));
                                goto M22;
                            }
                            else
                            {
                                var temp198 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp198)
                                {
                                    var temp199 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp199));
                                    goto M23;
                                }
                                else
                                {
                                    var temp200 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp200)
                                    {
                                        var temp201 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp201));
                                        goto M24;
                                    }
                                    else
                                    {
                                        var temp202 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp189)));
                                        var temp203 = ((int)((uint)(temp189)) <= (int)((uint)((uint)239U)));
                                        var temp204 = ((temp202) && (temp203));
                                        if (temp204)
                                        {
                                            var temp205 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp205));
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
                        var temp206 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp207 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp206)));
                        var temp208 = ((int)((uint)(temp206)) <= (int)((uint)((uint)191U)));
                        var temp209 = ((temp207) && (temp208));
                        if (temp209)
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
                        var temp210 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp211 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp210)));
                        var temp212 = ((int)((uint)(temp210)) <= (int)((uint)((uint)191U)));
                        var temp213 = ((temp211) && (temp212));
                        if (temp213)
                        {
                            var temp214 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp215 = Fun0(((ushort)((s)._0)), ((ushort)(temp214)));
                            s._0 = ((ushort)(temp215));
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
                        var temp216 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp217 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp216)));
                        var temp218 = ((int)((uint)(temp216)) <= (int)((uint)((uint)159U)));
                        var temp219 = ((temp217) && (temp218));
                        if (temp219)
                        {
                            var temp220 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp221 = Fun0(((ushort)((s)._0)), ((ushort)(temp220)));
                            s._0 = ((ushort)(temp221));
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
                        var temp222 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp223 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp222)));
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

                M21:
                {
                    if (++iIndex >= input.Length)
                        goto F21;
                    i = input[iIndex];
                    {
                        var temp228 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp229 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp228)));
                        var temp230 = ((int)((uint)(temp228)) <= (int)((uint)((uint)127U)));
                        var temp231 = ((temp229) && (temp230));
                        if (temp231)
                        {
                            var temp232 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp232)
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
                            var temp233 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp228)));
                            var temp234 = ((int)((uint)(temp228)) <= (int)((uint)((uint)223U)));
                            var temp235 = ((temp233) && (temp234));
                            if (temp235)
                            {
                                var temp236 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp236));
                                goto M27;
                            }
                            else
                            {
                                var temp237 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp237)
                                {
                                    var temp238 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp238));
                                    goto M28;
                                }
                                else
                                {
                                    var temp239 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp239)
                                    {
                                        var temp240 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp240));
                                        goto M29;
                                    }
                                    else
                                    {
                                        var temp241 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp228)));
                                        var temp242 = ((int)((uint)(temp228)) <= (int)((uint)((uint)239U)));
                                        var temp243 = ((temp241) && (temp242));
                                        if (temp243)
                                        {
                                            var temp244 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp244));
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
                        var temp245 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp246 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp245)));
                        var temp247 = ((int)((uint)(temp245)) <= (int)((uint)((uint)191U)));
                        var temp248 = ((temp246) && (temp247));
                        if (temp248)
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
                        var temp249 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp250 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp249)));
                        var temp251 = ((int)((uint)(temp249)) <= (int)((uint)((uint)191U)));
                        var temp252 = ((temp250) && (temp251));
                        if (temp252)
                        {
                            var temp253 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp254 = Fun0(((ushort)((s)._0)), ((ushort)(temp253)));
                            s._0 = ((ushort)(temp254));
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
                        var temp255 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp256 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp255)));
                        var temp257 = ((int)((uint)(temp255)) <= (int)((uint)((uint)159U)));
                        var temp258 = ((temp256) && (temp257));
                        if (temp258)
                        {
                            var temp259 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp260 = Fun0(((ushort)((s)._0)), ((ushort)(temp259)));
                            s._0 = ((ushort)(temp260));
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
                        var temp261 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp262 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp261)));
                        var temp263 = ((int)((uint)(temp261)) <= (int)((uint)((uint)191U)));
                        var temp264 = ((temp262) && (temp263));
                        if (temp264)
                        {
                            var temp265 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp266 = Fun0(((ushort)((s)._0)), ((ushort)(temp265)));
                            s._0 = ((ushort)(temp266));
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
                        var temp267 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp268 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp267)));
                        var temp269 = ((int)((uint)(temp267)) <= (int)((uint)((uint)127U)));
                        var temp270 = ((temp268) && (temp269));
                        if (temp270)
                        {
                            var temp271 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp272 = ((byte)(((byte)(i)) >> 6));
                            var temp273 = (((byte)(temp272 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp274 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp275 = (((temp271) && (temp273)) && (temp274));
                            if (temp275)
                            {
                                var temp276 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp277 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp276))) + ((uint)(temp267))));
                                s._1 = ((uint)(temp277));
                                goto M31;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp278 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp267)));
                            var temp279 = ((int)((uint)(temp267)) <= (int)((uint)((uint)223U)));
                            var temp280 = ((temp278) && (temp279));
                            if (temp280)
                            {
                                var temp281 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp281));
                                goto M32;
                            }
                            else
                            {
                                var temp282 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp282)
                                {
                                    var temp283 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp283));
                                    goto M33;
                                }
                                else
                                {
                                    var temp284 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp284)
                                    {
                                        var temp285 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp285));
                                        goto M34;
                                    }
                                    else
                                    {
                                        var temp286 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp267)));
                                        var temp287 = ((int)((uint)(temp267)) <= (int)((uint)((uint)239U)));
                                        var temp288 = ((temp286) && (temp287));
                                        if (temp288)
                                        {
                                            var temp289 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp289));
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
                        var temp290 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp291 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp290)));
                        var temp292 = ((int)((uint)(temp290)) <= (int)((uint)((uint)191U)));
                        var temp293 = ((temp291) && (temp292));
                        if (temp293)
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
                        var temp294 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp295 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp294)));
                        var temp296 = ((int)((uint)(temp294)) <= (int)((uint)((uint)191U)));
                        var temp297 = ((temp295) && (temp296));
                        if (temp297)
                        {
                            var temp298 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp299 = Fun0(((ushort)((s)._0)), ((ushort)(temp298)));
                            s._0 = ((ushort)(temp299));
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
                        var temp300 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp301 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp300)));
                        var temp302 = ((int)((uint)(temp300)) <= (int)((uint)((uint)159U)));
                        var temp303 = ((temp301) && (temp302));
                        if (temp303)
                        {
                            var temp304 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp305 = Fun0(((ushort)((s)._0)), ((ushort)(temp304)));
                            s._0 = ((ushort)(temp305));
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
                        var temp306 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp307 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp306)));
                        var temp308 = ((int)((uint)(temp306)) <= (int)((uint)((uint)191U)));
                        var temp309 = ((temp307) && (temp308));
                        if (temp309)
                        {
                            var temp310 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp311 = Fun0(((ushort)((s)._0)), ((ushort)(temp310)));
                            s._0 = ((ushort)(temp311));
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
                        var temp312 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp313 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp312)));
                        var temp314 = ((int)((uint)(temp312)) <= (int)((uint)((uint)127U)));
                        var temp315 = ((temp313) && (temp314));
                        if (temp315)
                        {
                            var temp316 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp316)
                            {
                                goto M36;
                            }
                            else
                            {
                                var temp317 = (((byte)(i)) == ((byte)((byte)46U)));
                                if (temp317)
                                {
                                    goto M37;
                                }
                                else
                                {
                                    var temp318 = (((byte)((byte)48U)) <= ((byte)(i)));
                                    var temp319 = ((byte)(((byte)(i)) >> 6));
                                    var temp320 = (((byte)(temp319 & 3L)) == ((byte)((byte)0U & 3L)));
                                    var temp321 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                    var temp322 = (((temp318) && (temp320)) && (temp321));
                                    if (temp322)
                                    {
                                        var temp323 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                        var temp324 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp323))) + ((uint)(temp312))));
                                        s._1 = ((uint)(temp324));
                                        goto M31;
                                    }
                                    else
                                        throw new Exception();
                                }
                            }
                        }
                        else
                        {
                            var temp325 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp312)));
                            var temp326 = ((int)((uint)(temp312)) <= (int)((uint)((uint)223U)));
                            var temp327 = ((temp325) && (temp326));
                            if (temp327)
                            {
                                var temp328 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp328));
                                goto M38;
                            }
                            else
                            {
                                var temp329 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp329)
                                {
                                    var temp330 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp330));
                                    goto M39;
                                }
                                else
                                {
                                    var temp331 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp331)
                                    {
                                        var temp332 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp332));
                                        goto M40;
                                    }
                                    else
                                    {
                                        var temp333 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp312)));
                                        var temp334 = ((int)((uint)(temp312)) <= (int)((uint)((uint)239U)));
                                        var temp335 = ((temp333) && (temp334));
                                        if (temp335)
                                        {
                                            var temp336 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp336));
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
                        var temp337 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp338 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp337)));
                        var temp339 = ((int)((uint)(temp337)) <= (int)((uint)((uint)191U)));
                        var temp340 = ((temp338) && (temp339));
                        if (temp340)
                        {
                            var temp341 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp342 = Fun0(((ushort)((s)._0)), ((ushort)(temp341)));
                            var temp343 = (((ushort)((ushort)48U)) <= ((ushort)(temp342)));
                            var temp344 = ((ushort)(((ushort)(temp342)) >> 6));
                            var temp345 = (((ushort)(temp344 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp346 = (((byte)(((byte)((ushort)(temp342))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp347 = (((temp343) && (temp345)) && (temp346));
                            var temp348 = (((ushort)((ushort)1632U)) <= ((ushort)(temp342)));
                            var temp349 = ((byte)(((ushort)(temp342)) >> 11));
                            var temp350 = (((byte)(temp349 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp351 = (((ushort)(((ushort)((ushort)(temp342))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp352 = (((temp348) && (temp350)) && (temp351));
                            var temp353 = (((ushort)((ushort)1776U)) <= ((ushort)(temp342)));
                            var temp354 = (((ushort)(((ushort)((ushort)(temp342))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp355 = (((temp353) && (temp350)) && (temp354));
                            var temp356 = (((ushort)((ushort)1984U)) <= ((ushort)(temp342)));
                            var temp357 = (((ushort)(((ushort)((ushort)(temp342))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp358 = (((temp356) && (temp350)) && (temp357));
                            var temp359 = (((ushort)((ushort)2406U)) <= ((ushort)(temp342)));
                            var temp360 = ((byte)(((ushort)(temp342)) >> 12));
                            var temp361 = (((byte)(temp360 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp362 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp363 = (((temp359) && (temp361)) && (temp362));
                            var temp364 = (((ushort)((ushort)2534U)) <= ((ushort)(temp342)));
                            var temp365 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp366 = (((temp364) && (temp361)) && (temp365));
                            var temp367 = (((ushort)((ushort)2662U)) <= ((ushort)(temp342)));
                            var temp368 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp369 = (((temp367) && (temp361)) && (temp368));
                            var temp370 = (((ushort)((ushort)2790U)) <= ((ushort)(temp342)));
                            var temp371 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp372 = (((temp370) && (temp361)) && (temp371));
                            var temp373 = (((ushort)((ushort)2918U)) <= ((ushort)(temp342)));
                            var temp374 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp375 = (((temp373) && (temp361)) && (temp374));
                            var temp376 = (((ushort)((ushort)3046U)) <= ((ushort)(temp342)));
                            var temp377 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp378 = (((temp376) && (temp361)) && (temp377));
                            var temp379 = (((ushort)((ushort)3174U)) <= ((ushort)(temp342)));
                            var temp380 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp381 = (((temp379) && (temp361)) && (temp380));
                            var temp382 = (((ushort)((ushort)3302U)) <= ((ushort)(temp342)));
                            var temp383 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp384 = (((temp382) && (temp361)) && (temp383));
                            var temp385 = (((ushort)((ushort)3430U)) <= ((ushort)(temp342)));
                            var temp386 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp387 = (((temp385) && (temp361)) && (temp386));
                            var temp388 = (((ushort)((ushort)3664U)) <= ((ushort)(temp342)));
                            var temp389 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp390 = (((temp388) && (temp361)) && (temp389));
                            var temp391 = (((ushort)((ushort)3792U)) <= ((ushort)(temp342)));
                            var temp392 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp393 = (((temp391) && (temp361)) && (temp392));
                            var temp394 = (((ushort)((ushort)3872U)) <= ((ushort)(temp342)));
                            var temp395 = (((ushort)(((ushort)((ushort)(temp342))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp396 = (((temp394) && (temp361)) && (temp395));
                            var temp397 = (((ushort)((ushort)4160U)) <= ((ushort)(temp342)));
                            var temp398 = ((byte)(((ushort)(temp342)) >> 13));
                            var temp399 = (((byte)(temp398 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp400 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp401 = (((temp397) && (temp399)) && (temp400));
                            var temp402 = (((ushort)((ushort)4240U)) <= ((ushort)(temp342)));
                            var temp403 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp404 = (((temp402) && (temp399)) && (temp403));
                            var temp405 = (((ushort)((ushort)6112U)) <= ((ushort)(temp342)));
                            var temp406 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp407 = (((temp405) && (temp399)) && (temp406));
                            var temp408 = (((ushort)((ushort)6160U)) <= ((ushort)(temp342)));
                            var temp409 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp410 = (((temp408) && (temp399)) && (temp409));
                            var temp411 = (((ushort)((ushort)6470U)) <= ((ushort)(temp342)));
                            var temp412 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp413 = (((temp411) && (temp399)) && (temp412));
                            var temp414 = (((ushort)((ushort)6608U)) <= ((ushort)(temp342)));
                            var temp415 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp416 = (((temp414) && (temp399)) && (temp415));
                            var temp417 = (((ushort)((ushort)6992U)) <= ((ushort)(temp342)));
                            var temp418 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp419 = (((temp417) && (temp399)) && (temp418));
                            var temp420 = (((ushort)((ushort)7088U)) <= ((ushort)(temp342)));
                            var temp421 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp422 = (((temp420) && (temp399)) && (temp421));
                            var temp423 = (((ushort)((ushort)7232U)) <= ((ushort)(temp342)));
                            var temp424 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp425 = (((temp423) && (temp399)) && (temp424));
                            var temp426 = (((ushort)((ushort)7248U)) <= ((ushort)(temp342)));
                            var temp427 = (((ushort)(((ushort)((ushort)(temp342))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp428 = (((temp426) && (temp399)) && (temp427));
                            var temp429 = (((ushort)((ushort)42528U)) <= ((ushort)(temp342)));
                            var temp430 = (((ushort)(temp342)) <= ((ushort)((ushort)42537U)));
                            var temp431 = ((temp429) && (temp430));
                            var temp432 = (((ushort)((ushort)43216U)) <= ((ushort)(temp342)));
                            var temp433 = (((ushort)(temp342)) <= ((ushort)((ushort)43225U)));
                            var temp434 = ((temp432) && (temp433));
                            var temp435 = (((ushort)((ushort)43264U)) <= ((ushort)(temp342)));
                            var temp436 = (((ushort)(temp342)) <= ((ushort)((ushort)43273U)));
                            var temp437 = ((temp435) && (temp436));
                            var temp438 = (((ushort)((ushort)43600U)) <= ((ushort)(temp342)));
                            var temp439 = (((ushort)(temp342)) <= ((ushort)((ushort)43609U)));
                            var temp440 = ((temp438) && (temp439));
                            var temp441 = (((ushort)((ushort)65296U)) <= ((ushort)(temp342)));
                            var temp442 = (((ushort)(temp342)) <= ((ushort)((ushort)65305U)));
                            var temp443 = ((temp441) && (temp442));
                            var temp444 = (((((((((((((((((((((((((((((((temp347) || (temp352)) || (temp355)) || (temp358)) || (temp363)) || (temp366)) || (temp369)) || (temp372)) || (temp375)) || (temp378)) || (temp381)) || (temp384)) || (temp387)) || (temp390)) || (temp393)) || (temp396)) || (temp401)) || (temp404)) || (temp407)) || (temp410)) || (temp413)) || (temp416)) || (temp419)) || (temp422)) || (temp425)) || (temp428)) || (temp431)) || (temp434)) || (temp437)) || (temp440)) || (temp443));
                            if (temp444)
                            {
                                var temp445 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp446 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp342));
                                var temp447 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp445))) + ((uint)(temp446))));
                                s._1 = ((uint)(temp447));
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
                        var temp448 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp449 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp448)));
                        var temp450 = ((int)((uint)(temp448)) <= (int)((uint)((uint)191U)));
                        var temp451 = ((temp449) && (temp450));
                        if (temp451)
                        {
                            var temp452 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp453 = Fun0(((ushort)((s)._0)), ((ushort)(temp452)));
                            s._0 = ((ushort)(temp453));
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
                        var temp454 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp455 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp454)));
                        var temp456 = ((int)((uint)(temp454)) <= (int)((uint)((uint)159U)));
                        var temp457 = ((temp455) && (temp456));
                        if (temp457)
                        {
                            var temp458 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp459 = Fun0(((ushort)((s)._0)), ((ushort)(temp458)));
                            s._0 = ((ushort)(temp459));
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
                        var temp460 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp461 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp460)));
                        var temp462 = ((int)((uint)(temp460)) <= (int)((uint)((uint)191U)));
                        var temp463 = ((temp461) && (temp462));
                        if (temp463)
                        {
                            var temp464 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp465 = Fun0(((ushort)((s)._0)), ((ushort)(temp464)));
                            s._0 = ((ushort)(temp465));
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
                        var temp466 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp467 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp466)));
                        var temp468 = ((int)((uint)(temp466)) <= (int)((uint)((uint)127U)));
                        var temp469 = ((temp467) && (temp468));
                        if (temp469)
                        {
                            var temp470 = (((byte)(i)) == ((byte)((byte)10U)));
                            if (temp470)
                            {
                                var temp471 = ((uint)(((uint)((uint)1U)) + ((uint)((s)._3))));
                                s._3 = ((uint)(temp471));
                                var temp472 = ((byte)(((uint)((s)._1)) >> 31));
                                var temp473 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 1) | (ulong)((byte)(temp472 & 1L)) << 32) | (ulong)((uint)((s)._1));
                                var temp474 = ((ulong)(((ulong)((s)._2)) + ((ulong)(temp473))));
                                s._2 = ((ulong)(temp474));
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
                            var temp475 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp466)));
                            var temp476 = ((int)((uint)(temp466)) <= (int)((uint)((uint)223U)));
                            var temp477 = ((temp475) && (temp476));
                            if (temp477)
                            {
                                var temp478 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp478));
                                goto M51;
                            }
                            else
                            {
                                var temp479 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp479)
                                {
                                    var temp480 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp480));
                                    goto M52;
                                }
                                else
                                {
                                    var temp481 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp481)
                                    {
                                        var temp482 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp482));
                                        goto M53;
                                    }
                                    else
                                    {
                                        var temp483 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp466)));
                                        var temp484 = ((int)((uint)(temp466)) <= (int)((uint)((uint)239U)));
                                        var temp485 = ((temp483) && (temp484));
                                        if (temp485)
                                        {
                                            var temp486 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp486));
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
                        var temp487 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp488 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp487)));
                        var temp489 = ((int)((uint)(temp487)) <= (int)((uint)((uint)127U)));
                        var temp490 = ((temp488) && (temp489));
                        if (temp490)
                        {
                            var temp491 = (((byte)((byte)48U)) <= ((byte)(i)));
                            var temp492 = ((byte)(((byte)(i)) >> 6));
                            var temp493 = (((byte)(temp492 & 3L)) == ((byte)((byte)0U & 3L)));
                            var temp494 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp495 = (((temp491) && (temp493)) && (temp494));
                            if (temp495)
                            {
                                goto M42;
                            }
                            else
                                throw new Exception();
                        }
                        else
                        {
                            var temp496 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp487)));
                            var temp497 = ((int)((uint)(temp487)) <= (int)((uint)((uint)223U)));
                            var temp498 = ((temp496) && (temp497));
                            if (temp498)
                            {
                                var temp499 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp499));
                                goto M43;
                            }
                            else
                            {
                                var temp500 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp500)
                                {
                                    var temp501 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp501));
                                    goto M44;
                                }
                                else
                                {
                                    var temp502 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp502)
                                    {
                                        var temp503 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp503));
                                        goto M45;
                                    }
                                    else
                                    {
                                        var temp504 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp487)));
                                        var temp505 = ((int)((uint)(temp487)) <= (int)((uint)((uint)239U)));
                                        var temp506 = ((temp504) && (temp505));
                                        if (temp506)
                                        {
                                            var temp507 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp507));
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
                        var temp508 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp509 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp508)));
                        var temp510 = ((int)((uint)(temp508)) <= (int)((uint)((uint)191U)));
                        var temp511 = ((temp509) && (temp510));
                        if (temp511)
                        {
                            var temp512 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp513 = Fun0(((ushort)((s)._0)), ((ushort)(temp512)));
                            var temp514 = (((ushort)((ushort)48U)) <= ((ushort)(temp513)));
                            var temp515 = ((ushort)(((ushort)(temp513)) >> 6));
                            var temp516 = (((ushort)(temp515 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp517 = (((byte)(((byte)((ushort)(temp513))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp518 = (((temp514) && (temp516)) && (temp517));
                            var temp519 = (((ushort)((ushort)1632U)) <= ((ushort)(temp513)));
                            var temp520 = ((byte)(((ushort)(temp513)) >> 11));
                            var temp521 = (((byte)(temp520 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp522 = (((ushort)(((ushort)((ushort)(temp513))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp523 = (((temp519) && (temp521)) && (temp522));
                            var temp524 = (((ushort)((ushort)1776U)) <= ((ushort)(temp513)));
                            var temp525 = (((ushort)(((ushort)((ushort)(temp513))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp526 = (((temp524) && (temp521)) && (temp525));
                            var temp527 = (((ushort)((ushort)1984U)) <= ((ushort)(temp513)));
                            var temp528 = (((ushort)(((ushort)((ushort)(temp513))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp529 = (((temp527) && (temp521)) && (temp528));
                            var temp530 = (((ushort)((ushort)2406U)) <= ((ushort)(temp513)));
                            var temp531 = ((byte)(((ushort)(temp513)) >> 12));
                            var temp532 = (((byte)(temp531 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp533 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp534 = (((temp530) && (temp532)) && (temp533));
                            var temp535 = (((ushort)((ushort)2534U)) <= ((ushort)(temp513)));
                            var temp536 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp537 = (((temp535) && (temp532)) && (temp536));
                            var temp538 = (((ushort)((ushort)2662U)) <= ((ushort)(temp513)));
                            var temp539 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp540 = (((temp538) && (temp532)) && (temp539));
                            var temp541 = (((ushort)((ushort)2790U)) <= ((ushort)(temp513)));
                            var temp542 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp543 = (((temp541) && (temp532)) && (temp542));
                            var temp544 = (((ushort)((ushort)2918U)) <= ((ushort)(temp513)));
                            var temp545 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp546 = (((temp544) && (temp532)) && (temp545));
                            var temp547 = (((ushort)((ushort)3046U)) <= ((ushort)(temp513)));
                            var temp548 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp549 = (((temp547) && (temp532)) && (temp548));
                            var temp550 = (((ushort)((ushort)3174U)) <= ((ushort)(temp513)));
                            var temp551 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp552 = (((temp550) && (temp532)) && (temp551));
                            var temp553 = (((ushort)((ushort)3302U)) <= ((ushort)(temp513)));
                            var temp554 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp555 = (((temp553) && (temp532)) && (temp554));
                            var temp556 = (((ushort)((ushort)3430U)) <= ((ushort)(temp513)));
                            var temp557 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp558 = (((temp556) && (temp532)) && (temp557));
                            var temp559 = (((ushort)((ushort)3664U)) <= ((ushort)(temp513)));
                            var temp560 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp561 = (((temp559) && (temp532)) && (temp560));
                            var temp562 = (((ushort)((ushort)3792U)) <= ((ushort)(temp513)));
                            var temp563 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp564 = (((temp562) && (temp532)) && (temp563));
                            var temp565 = (((ushort)((ushort)3872U)) <= ((ushort)(temp513)));
                            var temp566 = (((ushort)(((ushort)((ushort)(temp513))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp567 = (((temp565) && (temp532)) && (temp566));
                            var temp568 = (((ushort)((ushort)4160U)) <= ((ushort)(temp513)));
                            var temp569 = ((byte)(((ushort)(temp513)) >> 13));
                            var temp570 = (((byte)(temp569 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp571 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp572 = (((temp568) && (temp570)) && (temp571));
                            var temp573 = (((ushort)((ushort)4240U)) <= ((ushort)(temp513)));
                            var temp574 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp575 = (((temp573) && (temp570)) && (temp574));
                            var temp576 = (((ushort)((ushort)6112U)) <= ((ushort)(temp513)));
                            var temp577 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp578 = (((temp576) && (temp570)) && (temp577));
                            var temp579 = (((ushort)((ushort)6160U)) <= ((ushort)(temp513)));
                            var temp580 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp581 = (((temp579) && (temp570)) && (temp580));
                            var temp582 = (((ushort)((ushort)6470U)) <= ((ushort)(temp513)));
                            var temp583 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp584 = (((temp582) && (temp570)) && (temp583));
                            var temp585 = (((ushort)((ushort)6608U)) <= ((ushort)(temp513)));
                            var temp586 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp587 = (((temp585) && (temp570)) && (temp586));
                            var temp588 = (((ushort)((ushort)6992U)) <= ((ushort)(temp513)));
                            var temp589 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp590 = (((temp588) && (temp570)) && (temp589));
                            var temp591 = (((ushort)((ushort)7088U)) <= ((ushort)(temp513)));
                            var temp592 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp593 = (((temp591) && (temp570)) && (temp592));
                            var temp594 = (((ushort)((ushort)7232U)) <= ((ushort)(temp513)));
                            var temp595 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp596 = (((temp594) && (temp570)) && (temp595));
                            var temp597 = (((ushort)((ushort)7248U)) <= ((ushort)(temp513)));
                            var temp598 = (((ushort)(((ushort)((ushort)(temp513))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp599 = (((temp597) && (temp570)) && (temp598));
                            var temp600 = (((ushort)((ushort)42528U)) <= ((ushort)(temp513)));
                            var temp601 = (((ushort)(temp513)) <= ((ushort)((ushort)42537U)));
                            var temp602 = ((temp600) && (temp601));
                            var temp603 = (((ushort)((ushort)43216U)) <= ((ushort)(temp513)));
                            var temp604 = (((ushort)(temp513)) <= ((ushort)((ushort)43225U)));
                            var temp605 = ((temp603) && (temp604));
                            var temp606 = (((ushort)((ushort)43264U)) <= ((ushort)(temp513)));
                            var temp607 = (((ushort)(temp513)) <= ((ushort)((ushort)43273U)));
                            var temp608 = ((temp606) && (temp607));
                            var temp609 = (((ushort)((ushort)43600U)) <= ((ushort)(temp513)));
                            var temp610 = (((ushort)(temp513)) <= ((ushort)((ushort)43609U)));
                            var temp611 = ((temp609) && (temp610));
                            var temp612 = (((ushort)((ushort)65296U)) <= ((ushort)(temp513)));
                            var temp613 = (((ushort)(temp513)) <= ((ushort)((ushort)65305U)));
                            var temp614 = ((temp612) && (temp613));
                            var temp615 = (((((((((((((((((((((((((((((((temp518) || (temp523)) || (temp526)) || (temp529)) || (temp534)) || (temp537)) || (temp540)) || (temp543)) || (temp546)) || (temp549)) || (temp552)) || (temp555)) || (temp558)) || (temp561)) || (temp564)) || (temp567)) || (temp572)) || (temp575)) || (temp578)) || (temp581)) || (temp584)) || (temp587)) || (temp590)) || (temp593)) || (temp596)) || (temp599)) || (temp602)) || (temp605)) || (temp608)) || (temp611)) || (temp614));
                            if (temp615)
                            {
                                var temp616 = ((uint)(((uint)((uint)10U)) * ((uint)((s)._1))));
                                var temp617 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(temp513));
                                var temp618 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp616))) + ((uint)(temp617))));
                                s._1 = ((uint)(temp618));
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

                M39:
                {
                    if (++iIndex >= input.Length)
                        goto F39;
                    i = input[iIndex];
                    {
                        var temp619 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp620 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp619)));
                        var temp621 = ((int)((uint)(temp619)) <= (int)((uint)((uint)191U)));
                        var temp622 = ((temp620) && (temp621));
                        if (temp622)
                        {
                            var temp623 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp624 = Fun0(((ushort)((s)._0)), ((ushort)(temp623)));
                            s._0 = ((ushort)(temp624));
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
                        var temp625 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp626 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp625)));
                        var temp627 = ((int)((uint)(temp625)) <= (int)((uint)((uint)159U)));
                        var temp628 = ((temp626) && (temp627));
                        if (temp628)
                        {
                            var temp629 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp630 = Fun0(((ushort)((s)._0)), ((ushort)(temp629)));
                            s._0 = ((ushort)(temp630));
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
                        var temp631 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp632 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp631)));
                        var temp633 = ((int)((uint)(temp631)) <= (int)((uint)((uint)191U)));
                        var temp634 = ((temp632) && (temp633));
                        if (temp634)
                        {
                            var temp635 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp636 = Fun0(((ushort)((s)._0)), ((ushort)(temp635)));
                            s._0 = ((ushort)(temp636));
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
                        var temp637 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp638 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp637)));
                        var temp639 = ((int)((uint)(temp637)) <= (int)((uint)((uint)127U)));
                        var temp640 = ((temp638) && (temp639));
                        if (temp640)
                        {
                            var temp641 = (((byte)(i)) == ((byte)((byte)44U)));
                            if (temp641)
                            {
                                goto M36;
                            }
                            else
                            {
                                var temp642 = (((byte)((byte)48U)) <= ((byte)(i)));
                                var temp643 = ((byte)(((byte)(i)) >> 6));
                                var temp644 = (((byte)(temp643 & 3L)) == ((byte)((byte)0U & 3L)));
                                var temp645 = (((byte)(((byte)((byte)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp646 = (((temp642) && (temp644)) && (temp645));
                                if (temp646)
                                {
                                    goto M42;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                        else
                        {
                            var temp647 = ((int)((uint)((uint)194U)) <= (int)((uint)(temp637)));
                            var temp648 = ((int)((uint)(temp637)) <= (int)((uint)((uint)223U)));
                            var temp649 = ((temp647) && (temp648));
                            if (temp649)
                            {
                                var temp650 = ((ushort)((ushort)((ushort)0U & 2047L)) << 5) | (ushort)((byte)(((byte)((byte)(i))) & 31L));
                                s._0 = ((ushort)(temp650));
                                goto M47;
                            }
                            else
                            {
                                var temp651 = (((byte)(i)) == ((byte)((byte)224U)));
                                if (temp651)
                                {
                                    var temp652 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                    s._0 = ((ushort)(temp652));
                                    goto M48;
                                }
                                else
                                {
                                    var temp653 = (((byte)(i)) == ((byte)((byte)237U)));
                                    if (temp653)
                                    {
                                        var temp654 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                        s._0 = ((ushort)(temp654));
                                        goto M49;
                                    }
                                    else
                                    {
                                        var temp655 = ((int)((uint)((uint)225U)) <= (int)((uint)(temp637)));
                                        var temp656 = ((int)((uint)(temp637)) <= (int)((uint)((uint)239U)));
                                        var temp657 = ((temp655) && (temp656));
                                        if (temp657)
                                        {
                                            var temp658 = ((ushort)((ushort)((ushort)0U & 4095L)) << 4) | (ushort)((byte)(((byte)((byte)(i))) & 15L));
                                            s._0 = ((ushort)(temp658));
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
                        var temp659 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp660 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp659)));
                        var temp661 = ((int)((uint)(temp659)) <= (int)((uint)((uint)191U)));
                        var temp662 = ((temp660) && (temp661));
                        if (temp662)
                        {
                            var temp663 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp664 = Fun0(((ushort)((s)._0)), ((ushort)(temp663)));
                            var temp665 = (((ushort)((ushort)48U)) <= ((ushort)(temp664)));
                            var temp666 = ((ushort)(((ushort)(temp664)) >> 6));
                            var temp667 = (((ushort)(temp666 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp668 = (((byte)(((byte)((ushort)(temp664))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp669 = (((temp665) && (temp667)) && (temp668));
                            var temp670 = (((ushort)((ushort)1632U)) <= ((ushort)(temp664)));
                            var temp671 = ((byte)(((ushort)(temp664)) >> 11));
                            var temp672 = (((byte)(temp671 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp673 = (((ushort)(((ushort)((ushort)(temp664))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp674 = (((temp670) && (temp672)) && (temp673));
                            var temp675 = (((ushort)((ushort)1776U)) <= ((ushort)(temp664)));
                            var temp676 = (((ushort)(((ushort)((ushort)(temp664))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp677 = (((temp675) && (temp672)) && (temp676));
                            var temp678 = (((ushort)((ushort)1984U)) <= ((ushort)(temp664)));
                            var temp679 = (((ushort)(((ushort)((ushort)(temp664))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp680 = (((temp678) && (temp672)) && (temp679));
                            var temp681 = (((ushort)((ushort)2406U)) <= ((ushort)(temp664)));
                            var temp682 = ((byte)(((ushort)(temp664)) >> 12));
                            var temp683 = (((byte)(temp682 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp684 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp685 = (((temp681) && (temp683)) && (temp684));
                            var temp686 = (((ushort)((ushort)2534U)) <= ((ushort)(temp664)));
                            var temp687 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp688 = (((temp686) && (temp683)) && (temp687));
                            var temp689 = (((ushort)((ushort)2662U)) <= ((ushort)(temp664)));
                            var temp690 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp691 = (((temp689) && (temp683)) && (temp690));
                            var temp692 = (((ushort)((ushort)2790U)) <= ((ushort)(temp664)));
                            var temp693 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp694 = (((temp692) && (temp683)) && (temp693));
                            var temp695 = (((ushort)((ushort)2918U)) <= ((ushort)(temp664)));
                            var temp696 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp697 = (((temp695) && (temp683)) && (temp696));
                            var temp698 = (((ushort)((ushort)3046U)) <= ((ushort)(temp664)));
                            var temp699 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp700 = (((temp698) && (temp683)) && (temp699));
                            var temp701 = (((ushort)((ushort)3174U)) <= ((ushort)(temp664)));
                            var temp702 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp703 = (((temp701) && (temp683)) && (temp702));
                            var temp704 = (((ushort)((ushort)3302U)) <= ((ushort)(temp664)));
                            var temp705 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp706 = (((temp704) && (temp683)) && (temp705));
                            var temp707 = (((ushort)((ushort)3430U)) <= ((ushort)(temp664)));
                            var temp708 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp709 = (((temp707) && (temp683)) && (temp708));
                            var temp710 = (((ushort)((ushort)3664U)) <= ((ushort)(temp664)));
                            var temp711 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp712 = (((temp710) && (temp683)) && (temp711));
                            var temp713 = (((ushort)((ushort)3792U)) <= ((ushort)(temp664)));
                            var temp714 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp715 = (((temp713) && (temp683)) && (temp714));
                            var temp716 = (((ushort)((ushort)3872U)) <= ((ushort)(temp664)));
                            var temp717 = (((ushort)(((ushort)((ushort)(temp664))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp718 = (((temp716) && (temp683)) && (temp717));
                            var temp719 = (((ushort)((ushort)4160U)) <= ((ushort)(temp664)));
                            var temp720 = ((byte)(((ushort)(temp664)) >> 13));
                            var temp721 = (((byte)(temp720 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp722 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp723 = (((temp719) && (temp721)) && (temp722));
                            var temp724 = (((ushort)((ushort)4240U)) <= ((ushort)(temp664)));
                            var temp725 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp726 = (((temp724) && (temp721)) && (temp725));
                            var temp727 = (((ushort)((ushort)6112U)) <= ((ushort)(temp664)));
                            var temp728 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp729 = (((temp727) && (temp721)) && (temp728));
                            var temp730 = (((ushort)((ushort)6160U)) <= ((ushort)(temp664)));
                            var temp731 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp732 = (((temp730) && (temp721)) && (temp731));
                            var temp733 = (((ushort)((ushort)6470U)) <= ((ushort)(temp664)));
                            var temp734 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp735 = (((temp733) && (temp721)) && (temp734));
                            var temp736 = (((ushort)((ushort)6608U)) <= ((ushort)(temp664)));
                            var temp737 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp738 = (((temp736) && (temp721)) && (temp737));
                            var temp739 = (((ushort)((ushort)6992U)) <= ((ushort)(temp664)));
                            var temp740 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp741 = (((temp739) && (temp721)) && (temp740));
                            var temp742 = (((ushort)((ushort)7088U)) <= ((ushort)(temp664)));
                            var temp743 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp744 = (((temp742) && (temp721)) && (temp743));
                            var temp745 = (((ushort)((ushort)7232U)) <= ((ushort)(temp664)));
                            var temp746 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp747 = (((temp745) && (temp721)) && (temp746));
                            var temp748 = (((ushort)((ushort)7248U)) <= ((ushort)(temp664)));
                            var temp749 = (((ushort)(((ushort)((ushort)(temp664))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp750 = (((temp748) && (temp721)) && (temp749));
                            var temp751 = (((ushort)((ushort)42528U)) <= ((ushort)(temp664)));
                            var temp752 = (((ushort)(temp664)) <= ((ushort)((ushort)42537U)));
                            var temp753 = ((temp751) && (temp752));
                            var temp754 = (((ushort)((ushort)43216U)) <= ((ushort)(temp664)));
                            var temp755 = (((ushort)(temp664)) <= ((ushort)((ushort)43225U)));
                            var temp756 = ((temp754) && (temp755));
                            var temp757 = (((ushort)((ushort)43264U)) <= ((ushort)(temp664)));
                            var temp758 = (((ushort)(temp664)) <= ((ushort)((ushort)43273U)));
                            var temp759 = ((temp757) && (temp758));
                            var temp760 = (((ushort)((ushort)43600U)) <= ((ushort)(temp664)));
                            var temp761 = (((ushort)(temp664)) <= ((ushort)((ushort)43609U)));
                            var temp762 = ((temp760) && (temp761));
                            var temp763 = (((ushort)((ushort)65296U)) <= ((ushort)(temp664)));
                            var temp764 = (((ushort)(temp664)) <= ((ushort)((ushort)65305U)));
                            var temp765 = ((temp763) && (temp764));
                            var temp766 = (((((((((((((((((((((((((((((((temp669) || (temp674)) || (temp677)) || (temp680)) || (temp685)) || (temp688)) || (temp691)) || (temp694)) || (temp697)) || (temp700)) || (temp703)) || (temp706)) || (temp709)) || (temp712)) || (temp715)) || (temp718)) || (temp723)) || (temp726)) || (temp729)) || (temp732)) || (temp735)) || (temp738)) || (temp741)) || (temp744)) || (temp747)) || (temp750)) || (temp753)) || (temp756)) || (temp759)) || (temp762)) || (temp765));
                            if (temp766)
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
                        var temp767 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp768 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp767)));
                        var temp769 = ((int)((uint)(temp767)) <= (int)((uint)((uint)191U)));
                        var temp770 = ((temp768) && (temp769));
                        if (temp770)
                        {
                            var temp771 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp772 = Fun0(((ushort)((s)._0)), ((ushort)(temp771)));
                            s._0 = ((ushort)(temp772));
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
                        var temp773 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp774 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp773)));
                        var temp775 = ((int)((uint)(temp773)) <= (int)((uint)((uint)159U)));
                        var temp776 = ((temp774) && (temp775));
                        if (temp776)
                        {
                            var temp777 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp778 = Fun0(((ushort)((s)._0)), ((ushort)(temp777)));
                            s._0 = ((ushort)(temp778));
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
                        var temp779 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp780 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp779)));
                        var temp781 = ((int)((uint)(temp779)) <= (int)((uint)((uint)191U)));
                        var temp782 = ((temp780) && (temp781));
                        if (temp782)
                        {
                            var temp783 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp784 = Fun0(((ushort)((s)._0)), ((ushort)(temp783)));
                            s._0 = ((ushort)(temp784));
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
                        var temp785 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp786 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp785)));
                        var temp787 = ((int)((uint)(temp785)) <= (int)((uint)((uint)191U)));
                        var temp788 = ((temp786) && (temp787));
                        if (temp788)
                        {
                            var temp789 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp790 = Fun0(((ushort)((s)._0)), ((ushort)(temp789)));
                            var temp791 = (((ushort)((ushort)48U)) <= ((ushort)(temp790)));
                            var temp792 = ((ushort)(((ushort)(temp790)) >> 6));
                            var temp793 = (((ushort)(temp792 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp794 = (((byte)(((byte)((ushort)(temp790))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp795 = (((temp791) && (temp793)) && (temp794));
                            var temp796 = (((ushort)((ushort)1632U)) <= ((ushort)(temp790)));
                            var temp797 = ((byte)(((ushort)(temp790)) >> 11));
                            var temp798 = (((byte)(temp797 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp799 = (((ushort)(((ushort)((ushort)(temp790))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp800 = (((temp796) && (temp798)) && (temp799));
                            var temp801 = (((ushort)((ushort)1776U)) <= ((ushort)(temp790)));
                            var temp802 = (((ushort)(((ushort)((ushort)(temp790))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp803 = (((temp801) && (temp798)) && (temp802));
                            var temp804 = (((ushort)((ushort)1984U)) <= ((ushort)(temp790)));
                            var temp805 = (((ushort)(((ushort)((ushort)(temp790))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp806 = (((temp804) && (temp798)) && (temp805));
                            var temp807 = (((ushort)((ushort)2406U)) <= ((ushort)(temp790)));
                            var temp808 = ((byte)(((ushort)(temp790)) >> 12));
                            var temp809 = (((byte)(temp808 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp810 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp811 = (((temp807) && (temp809)) && (temp810));
                            var temp812 = (((ushort)((ushort)2534U)) <= ((ushort)(temp790)));
                            var temp813 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp814 = (((temp812) && (temp809)) && (temp813));
                            var temp815 = (((ushort)((ushort)2662U)) <= ((ushort)(temp790)));
                            var temp816 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp817 = (((temp815) && (temp809)) && (temp816));
                            var temp818 = (((ushort)((ushort)2790U)) <= ((ushort)(temp790)));
                            var temp819 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp820 = (((temp818) && (temp809)) && (temp819));
                            var temp821 = (((ushort)((ushort)2918U)) <= ((ushort)(temp790)));
                            var temp822 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp823 = (((temp821) && (temp809)) && (temp822));
                            var temp824 = (((ushort)((ushort)3046U)) <= ((ushort)(temp790)));
                            var temp825 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp826 = (((temp824) && (temp809)) && (temp825));
                            var temp827 = (((ushort)((ushort)3174U)) <= ((ushort)(temp790)));
                            var temp828 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp829 = (((temp827) && (temp809)) && (temp828));
                            var temp830 = (((ushort)((ushort)3302U)) <= ((ushort)(temp790)));
                            var temp831 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp832 = (((temp830) && (temp809)) && (temp831));
                            var temp833 = (((ushort)((ushort)3430U)) <= ((ushort)(temp790)));
                            var temp834 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp835 = (((temp833) && (temp809)) && (temp834));
                            var temp836 = (((ushort)((ushort)3664U)) <= ((ushort)(temp790)));
                            var temp837 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp838 = (((temp836) && (temp809)) && (temp837));
                            var temp839 = (((ushort)((ushort)3792U)) <= ((ushort)(temp790)));
                            var temp840 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp841 = (((temp839) && (temp809)) && (temp840));
                            var temp842 = (((ushort)((ushort)3872U)) <= ((ushort)(temp790)));
                            var temp843 = (((ushort)(((ushort)((ushort)(temp790))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp844 = (((temp842) && (temp809)) && (temp843));
                            var temp845 = (((ushort)((ushort)4160U)) <= ((ushort)(temp790)));
                            var temp846 = ((byte)(((ushort)(temp790)) >> 13));
                            var temp847 = (((byte)(temp846 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp848 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp849 = (((temp845) && (temp847)) && (temp848));
                            var temp850 = (((ushort)((ushort)4240U)) <= ((ushort)(temp790)));
                            var temp851 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp852 = (((temp850) && (temp847)) && (temp851));
                            var temp853 = (((ushort)((ushort)6112U)) <= ((ushort)(temp790)));
                            var temp854 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp855 = (((temp853) && (temp847)) && (temp854));
                            var temp856 = (((ushort)((ushort)6160U)) <= ((ushort)(temp790)));
                            var temp857 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp858 = (((temp856) && (temp847)) && (temp857));
                            var temp859 = (((ushort)((ushort)6470U)) <= ((ushort)(temp790)));
                            var temp860 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp861 = (((temp859) && (temp847)) && (temp860));
                            var temp862 = (((ushort)((ushort)6608U)) <= ((ushort)(temp790)));
                            var temp863 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp864 = (((temp862) && (temp847)) && (temp863));
                            var temp865 = (((ushort)((ushort)6992U)) <= ((ushort)(temp790)));
                            var temp866 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp867 = (((temp865) && (temp847)) && (temp866));
                            var temp868 = (((ushort)((ushort)7088U)) <= ((ushort)(temp790)));
                            var temp869 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp870 = (((temp868) && (temp847)) && (temp869));
                            var temp871 = (((ushort)((ushort)7232U)) <= ((ushort)(temp790)));
                            var temp872 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp873 = (((temp871) && (temp847)) && (temp872));
                            var temp874 = (((ushort)((ushort)7248U)) <= ((ushort)(temp790)));
                            var temp875 = (((ushort)(((ushort)((ushort)(temp790))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp876 = (((temp874) && (temp847)) && (temp875));
                            var temp877 = (((ushort)((ushort)42528U)) <= ((ushort)(temp790)));
                            var temp878 = (((ushort)(temp790)) <= ((ushort)((ushort)42537U)));
                            var temp879 = ((temp877) && (temp878));
                            var temp880 = (((ushort)((ushort)43216U)) <= ((ushort)(temp790)));
                            var temp881 = (((ushort)(temp790)) <= ((ushort)((ushort)43225U)));
                            var temp882 = ((temp880) && (temp881));
                            var temp883 = (((ushort)((ushort)43264U)) <= ((ushort)(temp790)));
                            var temp884 = (((ushort)(temp790)) <= ((ushort)((ushort)43273U)));
                            var temp885 = ((temp883) && (temp884));
                            var temp886 = (((ushort)((ushort)43600U)) <= ((ushort)(temp790)));
                            var temp887 = (((ushort)(temp790)) <= ((ushort)((ushort)43609U)));
                            var temp888 = ((temp886) && (temp887));
                            var temp889 = (((ushort)((ushort)65296U)) <= ((ushort)(temp790)));
                            var temp890 = (((ushort)(temp790)) <= ((ushort)((ushort)65305U)));
                            var temp891 = ((temp889) && (temp890));
                            var temp892 = (((((((((((((((((((((((((((((((temp795) || (temp800)) || (temp803)) || (temp806)) || (temp811)) || (temp814)) || (temp817)) || (temp820)) || (temp823)) || (temp826)) || (temp829)) || (temp832)) || (temp835)) || (temp838)) || (temp841)) || (temp844)) || (temp849)) || (temp852)) || (temp855)) || (temp858)) || (temp861)) || (temp864)) || (temp867)) || (temp870)) || (temp873)) || (temp876)) || (temp879)) || (temp882)) || (temp885)) || (temp888)) || (temp891));
                            if (temp892)
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

                M48:
                {
                    if (++iIndex >= input.Length)
                        goto F48;
                    i = input[iIndex];
                    {
                        var temp893 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp894 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp893)));
                        var temp895 = ((int)((uint)(temp893)) <= (int)((uint)((uint)191U)));
                        var temp896 = ((temp894) && (temp895));
                        if (temp896)
                        {
                            var temp897 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp898 = Fun0(((ushort)((s)._0)), ((ushort)(temp897)));
                            s._0 = ((ushort)(temp898));
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
                        var temp899 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp900 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp899)));
                        var temp901 = ((int)((uint)(temp899)) <= (int)((uint)((uint)159U)));
                        var temp902 = ((temp900) && (temp901));
                        if (temp902)
                        {
                            var temp903 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp904 = Fun0(((ushort)((s)._0)), ((ushort)(temp903)));
                            s._0 = ((ushort)(temp904));
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
                        var temp905 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp906 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp905)));
                        var temp907 = ((int)((uint)(temp905)) <= (int)((uint)((uint)191U)));
                        var temp908 = ((temp906) && (temp907));
                        if (temp908)
                        {
                            var temp909 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp910 = Fun0(((ushort)((s)._0)), ((ushort)(temp909)));
                            s._0 = ((ushort)(temp910));
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
                        var temp911 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp912 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp911)));
                        var temp913 = ((int)((uint)(temp911)) <= (int)((uint)((uint)191U)));
                        var temp914 = ((temp912) && (temp913));
                        if (temp914)
                        {
                            s._0 = ((ushort)((ushort)0U));
                            goto M36;
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
                        var temp915 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp916 = ((int)((uint)((uint)160U)) <= (int)((uint)(temp915)));
                        var temp917 = ((int)((uint)(temp915)) <= (int)((uint)((uint)191U)));
                        var temp918 = ((temp916) && (temp917));
                        if (temp918)
                        {
                            var temp919 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp920 = Fun0(((ushort)((s)._0)), ((ushort)(temp919)));
                            s._0 = ((ushort)(temp920));
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
                        var temp921 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp922 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp921)));
                        var temp923 = ((int)((uint)(temp921)) <= (int)((uint)((uint)159U)));
                        var temp924 = ((temp922) && (temp923));
                        if (temp924)
                        {
                            var temp925 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp926 = Fun0(((ushort)((s)._0)), ((ushort)(temp925)));
                            s._0 = ((ushort)(temp926));
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
                        var temp927 = ((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(i));
                        var temp928 = ((int)((uint)((uint)128U)) <= (int)((uint)(temp927)));
                        var temp929 = ((int)((uint)(temp927)) <= (int)((uint)((uint)191U)));
                        var temp930 = ((temp928) && (temp929));
                        if (temp930)
                        {
                            var temp931 = ((ushort)((byte)((byte)0U)) << 8) | (ushort)((byte)(i));
                            var temp932 = Fun0(((ushort)((s)._0)), ((ushort)(temp931)));
                            s._0 = ((ushort)(temp932));
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
                    var temp60 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp60)
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

                        var temp61 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp62 = (((byte)(temp61 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp63 = ((temp60) && (temp62));
                        var temp64 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 1) | (ulong)((byte)(temp61 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp65 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp64))));
                        var temp66 = ((temp63) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp65))))));
                        var temp67 = ((uint)(((int)((uint)(temp66))) >> (int)((uint)((uint)24U))));
                        oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp67))));
                        var temp68 = ((uint)(((int)((uint)(temp66))) >> (int)((uint)((uint)16U))));
                        oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp68))));
                        var temp69 = ((uint)(((int)((uint)(temp66))) >> (int)((uint)((uint)8U))));
                        oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp69))));
                        var temp70 = ((temp63) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp65))))));
                        oBuf[oIndex + 3] = (Byte)(temp70);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                }

                F4:
                {
                    var temp77 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp77)
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

                        var temp78 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp79 = (((byte)(temp78 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp80 = ((temp77) && (temp79));
                        var temp81 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 1) | (ulong)((byte)(temp78 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp82 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp81))));
                        var temp83 = ((temp80) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp82))))));
                        var temp84 = ((uint)(((int)((uint)(temp83))) >> (int)((uint)((uint)24U))));
                        oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp84))));
                        var temp85 = ((uint)(((int)((uint)(temp83))) >> (int)((uint)((uint)16U))));
                        oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp85))));
                        var temp86 = ((uint)(((int)((uint)(temp83))) >> (int)((uint)((uint)8U))));
                        oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp86))));
                        var temp87 = ((temp80) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp82))))));
                        oBuf[oIndex + 3] = (Byte)(temp87);
                        oIndex += 4;
                        if (oIndex > 0)
                            output.Write(oBuf, 0, oIndex);
                        return;
                    }
                }

                F5:
                {
                    var temp94 = (((uint)((s)._3)) == ((uint)((uint)0U)));
                    if (temp94)
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

                        var temp95 = ((byte)(((uint)((s)._3)) >> 31));
                        var temp96 = (((byte)(temp95 & 1L)) == ((byte)((byte)0U & 1L)));
                        var temp97 = ((temp94) && (temp96));
                        var temp98 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 1) | (ulong)((byte)(temp95 & 1L)) << 32) | (ulong)((uint)((s)._3));
                        var temp99 = ((ulong)((long)((ulong)((s)._2)) / (long)((ulong)(temp98))));
                        var temp100 = ((temp97) ? ((uint)(((uint)((ulong)(((ulong)((s)._2))))))) : ((uint)(((uint)((ulong)(temp99))))));
                        var temp101 = ((uint)(((int)((uint)(temp100))) >> (int)((uint)((uint)24U))));
                        oBuf[oIndex + 0] = (Byte)(((byte)((uint)(temp101))));
                        var temp102 = ((uint)(((int)((uint)(temp100))) >> (int)((uint)((uint)16U))));
                        oBuf[oIndex + 1] = (Byte)(((byte)((uint)(temp102))));
                        var temp103 = ((uint)(((int)((uint)(temp100))) >> (int)((uint)((uint)8U))));
                        oBuf[oIndex + 2] = (Byte)(((byte)((uint)(temp103))));
                        var temp104 = ((temp97) ? ((byte)(((byte)((ulong)(((ulong)((s)._2))))))) : ((byte)(((byte)((ulong)(temp99))))));
                        oBuf[oIndex + 3] = (Byte)(temp104);
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