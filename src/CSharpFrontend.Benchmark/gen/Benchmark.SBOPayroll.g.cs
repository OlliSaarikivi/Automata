using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class SBOPayroll : SpecialTransducer
    {
        public static IEnumerable<Int32> Transduce(IEnumerable<Char> input)
        {
            unchecked
            {
                IEnumerator<Char> ie = input.GetEnumerator();
                UInt32 s = (uint)0U;
                Char i;
                M0:
                {
                    if (!ie.MoveNext())
                        goto F0;
                    i = ie.Current;
                    {
                        var temp0 = (((ushort)(i)) == ((ushort)((ushort)44U)));
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
                        var temp1 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp1)
                        {
                            goto M2;
                        }
                        else
                        {
                            goto M1;
                        }
                    }
                }

                M2:
                {
                    if (!ie.MoveNext())
                        goto F2;
                    i = ie.Current;
                    {
                        var temp2 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp2)
                        {
                            goto M3;
                        }
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
                        var temp3 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp3)
                        {
                            goto M4;
                        }
                        else
                        {
                            goto M3;
                        }
                    }
                }

                M4:
                {
                    if (!ie.MoveNext())
                        goto F4;
                    i = ie.Current;
                    {
                        var temp4 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp4)
                        {
                            goto M5;
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
                        var temp5 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp5)
                        {
                            goto M6;
                        }
                        else
                        {
                            goto M5;
                        }
                    }
                }

                M6:
                {
                    if (!ie.MoveNext())
                        goto F6;
                    i = ie.Current;
                    {
                        var temp6 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                        var temp7 = ((ushort)(((ushort)(i)) >> 6));
                        var temp8 = (((ushort)(temp7 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                        var temp9 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                        var temp10 = (((temp6) && (temp8)) && (temp9));
                        var temp11 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                        var temp12 = ((byte)(((ushort)(i)) >> 11));
                        var temp13 = (((byte)(temp12 & 31L)) == ((byte)((byte)0U & 31L)));
                        var temp14 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                        var temp15 = (((temp11) && (temp13)) && (temp14));
                        var temp16 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                        var temp17 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                        var temp18 = (((temp16) && (temp13)) && (temp17));
                        var temp19 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                        var temp20 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                        var temp21 = (((temp19) && (temp13)) && (temp20));
                        var temp22 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                        var temp23 = ((byte)(((ushort)(i)) >> 12));
                        var temp24 = (((byte)(temp23 & 15L)) == ((byte)((byte)0U & 15L)));
                        var temp25 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                        var temp26 = (((temp22) && (temp24)) && (temp25));
                        var temp27 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                        var temp28 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                        var temp29 = (((temp27) && (temp24)) && (temp28));
                        var temp30 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                        var temp31 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                        var temp32 = (((temp30) && (temp24)) && (temp31));
                        var temp33 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                        var temp34 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                        var temp35 = (((temp33) && (temp24)) && (temp34));
                        var temp36 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                        var temp37 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                        var temp38 = (((temp36) && (temp24)) && (temp37));
                        var temp39 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                        var temp40 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                        var temp41 = (((temp39) && (temp24)) && (temp40));
                        var temp42 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                        var temp43 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                        var temp44 = (((temp42) && (temp24)) && (temp43));
                        var temp45 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                        var temp46 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                        var temp47 = (((temp45) && (temp24)) && (temp46));
                        var temp48 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                        var temp49 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                        var temp50 = (((temp48) && (temp24)) && (temp49));
                        var temp51 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                        var temp52 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                        var temp53 = (((temp51) && (temp24)) && (temp52));
                        var temp54 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                        var temp55 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                        var temp56 = (((temp54) && (temp24)) && (temp55));
                        var temp57 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                        var temp58 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                        var temp59 = (((temp57) && (temp24)) && (temp58));
                        var temp60 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                        var temp61 = ((byte)(((ushort)(i)) >> 13));
                        var temp62 = (((byte)(temp61 & 7L)) == ((byte)((byte)0U & 7L)));
                        var temp63 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                        var temp64 = (((temp60) && (temp62)) && (temp63));
                        var temp65 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                        var temp66 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                        var temp67 = (((temp65) && (temp62)) && (temp66));
                        var temp68 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                        var temp69 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                        var temp70 = (((temp68) && (temp62)) && (temp69));
                        var temp71 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                        var temp72 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                        var temp73 = (((temp71) && (temp62)) && (temp72));
                        var temp74 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                        var temp75 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                        var temp76 = (((temp74) && (temp62)) && (temp75));
                        var temp77 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                        var temp78 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                        var temp79 = (((temp77) && (temp62)) && (temp78));
                        var temp80 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                        var temp81 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                        var temp82 = (((temp80) && (temp62)) && (temp81));
                        var temp83 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                        var temp84 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                        var temp85 = (((temp83) && (temp62)) && (temp84));
                        var temp86 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                        var temp87 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                        var temp88 = (((temp86) && (temp62)) && (temp87));
                        var temp89 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                        var temp90 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                        var temp91 = (((temp89) && (temp62)) && (temp90));
                        var temp92 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                        var temp93 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                        var temp94 = ((temp92) && (temp93));
                        var temp95 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                        var temp96 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                        var temp97 = ((temp95) && (temp96));
                        var temp98 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                        var temp99 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                        var temp100 = ((temp98) && (temp99));
                        var temp101 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                        var temp102 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                        var temp103 = ((temp101) && (temp102));
                        var temp104 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                        var temp105 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                        var temp106 = ((temp104) && (temp105));
                        var temp107 = (((((((((((((((((((((((((((((((temp10) || (temp15)) || (temp18)) || (temp21)) || (temp26)) || (temp29)) || (temp32)) || (temp35)) || (temp38)) || (temp41)) || (temp44)) || (temp47)) || (temp50)) || (temp53)) || (temp56)) || (temp59)) || (temp64)) || (temp67)) || (temp70)) || (temp73)) || (temp76)) || (temp79)) || (temp82)) || (temp85)) || (temp88)) || (temp91)) || (temp94)) || (temp97)) || (temp100)) || (temp103)) || (temp106));
                        if (temp107)
                        {
                            var temp108 = ((uint)(((uint)((uint)10U)) * ((uint)(s))));
                            var temp109 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                            var temp110 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp108))) + ((uint)(temp109))));
                            s = (uint)(temp110);
                            goto M7;
                        }
                        else
                            throw new Exception();
                    }
                }

                M7:
                {
                    if (!ie.MoveNext())
                        goto F7;
                    i = ie.Current;
                    {
                        var temp111 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp111)
                        {
                            goto M8;
                        }
                        else
                        {
                            var temp112 = (((ushort)(i)) == ((ushort)((ushort)46U)));
                            if (temp112)
                            {
                                goto M9;
                            }
                            else
                            {
                                var temp113 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                                var temp114 = ((ushort)(((ushort)(i)) >> 6));
                                var temp115 = (((ushort)(temp114 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                var temp116 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp117 = (((temp113) && (temp115)) && (temp116));
                                var temp118 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                                var temp119 = ((byte)(((ushort)(i)) >> 11));
                                var temp120 = (((byte)(temp119 & 31L)) == ((byte)((byte)0U & 31L)));
                                var temp121 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                var temp122 = (((temp118) && (temp120)) && (temp121));
                                var temp123 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                                var temp124 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                var temp125 = (((temp123) && (temp120)) && (temp124));
                                var temp126 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                                var temp127 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                var temp128 = (((temp126) && (temp120)) && (temp127));
                                var temp129 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                                var temp130 = ((byte)(((ushort)(i)) >> 12));
                                var temp131 = (((byte)(temp130 & 15L)) == ((byte)((byte)0U & 15L)));
                                var temp132 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                var temp133 = (((temp129) && (temp131)) && (temp132));
                                var temp134 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                                var temp135 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                var temp136 = (((temp134) && (temp131)) && (temp135));
                                var temp137 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                                var temp138 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                var temp139 = (((temp137) && (temp131)) && (temp138));
                                var temp140 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                                var temp141 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                var temp142 = (((temp140) && (temp131)) && (temp141));
                                var temp143 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                                var temp144 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                var temp145 = (((temp143) && (temp131)) && (temp144));
                                var temp146 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                                var temp147 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                var temp148 = (((temp146) && (temp131)) && (temp147));
                                var temp149 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                                var temp150 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                var temp151 = (((temp149) && (temp131)) && (temp150));
                                var temp152 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                                var temp153 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                var temp154 = (((temp152) && (temp131)) && (temp153));
                                var temp155 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                                var temp156 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                var temp157 = (((temp155) && (temp131)) && (temp156));
                                var temp158 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                                var temp159 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                var temp160 = (((temp158) && (temp131)) && (temp159));
                                var temp161 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                                var temp162 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                var temp163 = (((temp161) && (temp131)) && (temp162));
                                var temp164 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                                var temp165 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                var temp166 = (((temp164) && (temp131)) && (temp165));
                                var temp167 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                                var temp168 = ((byte)(((ushort)(i)) >> 13));
                                var temp169 = (((byte)(temp168 & 7L)) == ((byte)((byte)0U & 7L)));
                                var temp170 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                var temp171 = (((temp167) && (temp169)) && (temp170));
                                var temp172 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                                var temp173 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                var temp174 = (((temp172) && (temp169)) && (temp173));
                                var temp175 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                                var temp176 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                var temp177 = (((temp175) && (temp169)) && (temp176));
                                var temp178 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                                var temp179 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                var temp180 = (((temp178) && (temp169)) && (temp179));
                                var temp181 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                                var temp182 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                var temp183 = (((temp181) && (temp169)) && (temp182));
                                var temp184 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                                var temp185 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                var temp186 = (((temp184) && (temp169)) && (temp185));
                                var temp187 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                                var temp188 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                var temp189 = (((temp187) && (temp169)) && (temp188));
                                var temp190 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                                var temp191 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                var temp192 = (((temp190) && (temp169)) && (temp191));
                                var temp193 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                                var temp194 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                var temp195 = (((temp193) && (temp169)) && (temp194));
                                var temp196 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                                var temp197 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                var temp198 = (((temp196) && (temp169)) && (temp197));
                                var temp199 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                                var temp200 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                                var temp201 = ((temp199) && (temp200));
                                var temp202 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                                var temp203 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                                var temp204 = ((temp202) && (temp203));
                                var temp205 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                                var temp206 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                                var temp207 = ((temp205) && (temp206));
                                var temp208 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                                var temp209 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                                var temp210 = ((temp208) && (temp209));
                                var temp211 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                                var temp212 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                                var temp213 = ((temp211) && (temp212));
                                var temp214 = (((((((((((((((((((((((((((((((temp117) || (temp122)) || (temp125)) || (temp128)) || (temp133)) || (temp136)) || (temp139)) || (temp142)) || (temp145)) || (temp148)) || (temp151)) || (temp154)) || (temp157)) || (temp160)) || (temp163)) || (temp166)) || (temp171)) || (temp174)) || (temp177)) || (temp180)) || (temp183)) || (temp186)) || (temp189)) || (temp192)) || (temp195)) || (temp198)) || (temp201)) || (temp204)) || (temp207)) || (temp210)) || (temp213));
                                if (temp214)
                                {
                                    var temp215 = ((uint)(((uint)((uint)10U)) * ((uint)(s))));
                                    var temp216 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                                    var temp217 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp215))) + ((uint)(temp216))));
                                    s = (uint)(temp217);
                                    goto M7;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                    }
                }

                M8:
                {
                    if (!ie.MoveNext())
                        goto F8;
                    i = ie.Current;
                    {
                        var temp218 = (((ushort)(i)) == ((ushort)((ushort)10U)));
                        if (temp218)
                        {
                            yield return (Int32)(s);
                            s = (uint)((uint)0U);
                            goto M0;
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
                        var temp219 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                        var temp220 = ((ushort)(((ushort)(i)) >> 6));
                        var temp221 = (((ushort)(temp220 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                        var temp222 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                        var temp223 = (((temp219) && (temp221)) && (temp222));
                        var temp224 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                        var temp225 = ((byte)(((ushort)(i)) >> 11));
                        var temp226 = (((byte)(temp225 & 31L)) == ((byte)((byte)0U & 31L)));
                        var temp227 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                        var temp228 = (((temp224) && (temp226)) && (temp227));
                        var temp229 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                        var temp230 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                        var temp231 = (((temp229) && (temp226)) && (temp230));
                        var temp232 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                        var temp233 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                        var temp234 = (((temp232) && (temp226)) && (temp233));
                        var temp235 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                        var temp236 = ((byte)(((ushort)(i)) >> 12));
                        var temp237 = (((byte)(temp236 & 15L)) == ((byte)((byte)0U & 15L)));
                        var temp238 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                        var temp239 = (((temp235) && (temp237)) && (temp238));
                        var temp240 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                        var temp241 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                        var temp242 = (((temp240) && (temp237)) && (temp241));
                        var temp243 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                        var temp244 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                        var temp245 = (((temp243) && (temp237)) && (temp244));
                        var temp246 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                        var temp247 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                        var temp248 = (((temp246) && (temp237)) && (temp247));
                        var temp249 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                        var temp250 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                        var temp251 = (((temp249) && (temp237)) && (temp250));
                        var temp252 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                        var temp253 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                        var temp254 = (((temp252) && (temp237)) && (temp253));
                        var temp255 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                        var temp256 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                        var temp257 = (((temp255) && (temp237)) && (temp256));
                        var temp258 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                        var temp259 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                        var temp260 = (((temp258) && (temp237)) && (temp259));
                        var temp261 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                        var temp262 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                        var temp263 = (((temp261) && (temp237)) && (temp262));
                        var temp264 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                        var temp265 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                        var temp266 = (((temp264) && (temp237)) && (temp265));
                        var temp267 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                        var temp268 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                        var temp269 = (((temp267) && (temp237)) && (temp268));
                        var temp270 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                        var temp271 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                        var temp272 = (((temp270) && (temp237)) && (temp271));
                        var temp273 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                        var temp274 = ((byte)(((ushort)(i)) >> 13));
                        var temp275 = (((byte)(temp274 & 7L)) == ((byte)((byte)0U & 7L)));
                        var temp276 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                        var temp277 = (((temp273) && (temp275)) && (temp276));
                        var temp278 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                        var temp279 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                        var temp280 = (((temp278) && (temp275)) && (temp279));
                        var temp281 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                        var temp282 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                        var temp283 = (((temp281) && (temp275)) && (temp282));
                        var temp284 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                        var temp285 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                        var temp286 = (((temp284) && (temp275)) && (temp285));
                        var temp287 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                        var temp288 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                        var temp289 = (((temp287) && (temp275)) && (temp288));
                        var temp290 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                        var temp291 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                        var temp292 = (((temp290) && (temp275)) && (temp291));
                        var temp293 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                        var temp294 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                        var temp295 = (((temp293) && (temp275)) && (temp294));
                        var temp296 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                        var temp297 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                        var temp298 = (((temp296) && (temp275)) && (temp297));
                        var temp299 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                        var temp300 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                        var temp301 = (((temp299) && (temp275)) && (temp300));
                        var temp302 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                        var temp303 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                        var temp304 = (((temp302) && (temp275)) && (temp303));
                        var temp305 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                        var temp306 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                        var temp307 = ((temp305) && (temp306));
                        var temp308 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                        var temp309 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                        var temp310 = ((temp308) && (temp309));
                        var temp311 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                        var temp312 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                        var temp313 = ((temp311) && (temp312));
                        var temp314 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                        var temp315 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                        var temp316 = ((temp314) && (temp315));
                        var temp317 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                        var temp318 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                        var temp319 = ((temp317) && (temp318));
                        var temp320 = (((((((((((((((((((((((((((((((temp223) || (temp228)) || (temp231)) || (temp234)) || (temp239)) || (temp242)) || (temp245)) || (temp248)) || (temp251)) || (temp254)) || (temp257)) || (temp260)) || (temp263)) || (temp266)) || (temp269)) || (temp272)) || (temp277)) || (temp280)) || (temp283)) || (temp286)) || (temp289)) || (temp292)) || (temp295)) || (temp298)) || (temp301)) || (temp304)) || (temp307)) || (temp310)) || (temp313)) || (temp316)) || (temp319));
                        if (temp320)
                        {
                            goto M10;
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
                        var temp321 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp321)
                        {
                            goto M8;
                        }
                        else
                        {
                            var temp322 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                            var temp323 = ((ushort)(((ushort)(i)) >> 6));
                            var temp324 = (((ushort)(temp323 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp325 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp326 = (((temp322) && (temp324)) && (temp325));
                            var temp327 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                            var temp328 = ((byte)(((ushort)(i)) >> 11));
                            var temp329 = (((byte)(temp328 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp330 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp331 = (((temp327) && (temp329)) && (temp330));
                            var temp332 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                            var temp333 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp334 = (((temp332) && (temp329)) && (temp333));
                            var temp335 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                            var temp336 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp337 = (((temp335) && (temp329)) && (temp336));
                            var temp338 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                            var temp339 = ((byte)(((ushort)(i)) >> 12));
                            var temp340 = (((byte)(temp339 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp341 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp342 = (((temp338) && (temp340)) && (temp341));
                            var temp343 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                            var temp344 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp345 = (((temp343) && (temp340)) && (temp344));
                            var temp346 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                            var temp347 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp348 = (((temp346) && (temp340)) && (temp347));
                            var temp349 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                            var temp350 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp351 = (((temp349) && (temp340)) && (temp350));
                            var temp352 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                            var temp353 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp354 = (((temp352) && (temp340)) && (temp353));
                            var temp355 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                            var temp356 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp357 = (((temp355) && (temp340)) && (temp356));
                            var temp358 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                            var temp359 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp360 = (((temp358) && (temp340)) && (temp359));
                            var temp361 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                            var temp362 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp363 = (((temp361) && (temp340)) && (temp362));
                            var temp364 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                            var temp365 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp366 = (((temp364) && (temp340)) && (temp365));
                            var temp367 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                            var temp368 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp369 = (((temp367) && (temp340)) && (temp368));
                            var temp370 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                            var temp371 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp372 = (((temp370) && (temp340)) && (temp371));
                            var temp373 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                            var temp374 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp375 = (((temp373) && (temp340)) && (temp374));
                            var temp376 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                            var temp377 = ((byte)(((ushort)(i)) >> 13));
                            var temp378 = (((byte)(temp377 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp379 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp380 = (((temp376) && (temp378)) && (temp379));
                            var temp381 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                            var temp382 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp383 = (((temp381) && (temp378)) && (temp382));
                            var temp384 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                            var temp385 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp386 = (((temp384) && (temp378)) && (temp385));
                            var temp387 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                            var temp388 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp389 = (((temp387) && (temp378)) && (temp388));
                            var temp390 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                            var temp391 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp392 = (((temp390) && (temp378)) && (temp391));
                            var temp393 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                            var temp394 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp395 = (((temp393) && (temp378)) && (temp394));
                            var temp396 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                            var temp397 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp398 = (((temp396) && (temp378)) && (temp397));
                            var temp399 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                            var temp400 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp401 = (((temp399) && (temp378)) && (temp400));
                            var temp402 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                            var temp403 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp404 = (((temp402) && (temp378)) && (temp403));
                            var temp405 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                            var temp406 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp407 = (((temp405) && (temp378)) && (temp406));
                            var temp408 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                            var temp409 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                            var temp410 = ((temp408) && (temp409));
                            var temp411 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                            var temp412 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                            var temp413 = ((temp411) && (temp412));
                            var temp414 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                            var temp415 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                            var temp416 = ((temp414) && (temp415));
                            var temp417 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                            var temp418 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                            var temp419 = ((temp417) && (temp418));
                            var temp420 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                            var temp421 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                            var temp422 = ((temp420) && (temp421));
                            var temp423 = (((((((((((((((((((((((((((((((temp326) || (temp331)) || (temp334)) || (temp337)) || (temp342)) || (temp345)) || (temp348)) || (temp351)) || (temp354)) || (temp357)) || (temp360)) || (temp363)) || (temp366)) || (temp369)) || (temp372)) || (temp375)) || (temp380)) || (temp383)) || (temp386)) || (temp389)) || (temp392)) || (temp395)) || (temp398)) || (temp401)) || (temp404)) || (temp407)) || (temp410)) || (temp413)) || (temp416)) || (temp419)) || (temp422));
                            if (temp423)
                            {
                                goto M10;
                            }
                            else
                                throw new Exception();
                        }
                    }
                }

                F0:
                {
                    yield break;
                }

                F1:
                    throw new Exception();
                F2:
                    throw new Exception();
                F3:
                    throw new Exception();
                F4:
                    throw new Exception();
                F5:
                    throw new Exception();
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
            }
        }
    }
}