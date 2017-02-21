using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class SBOGrossReceipts : SpecialTransducer
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
                        var temp6 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp6)
                        {
                            goto M7;
                        }
                        else
                        {
                            goto M6;
                        }
                    }
                }

                M7:
                {
                    if (!ie.MoveNext())
                        goto F7;
                    i = ie.Current;
                    {
                        var temp7 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                        var temp8 = ((ushort)(((ushort)(i)) >> 6));
                        var temp9 = (((ushort)(temp8 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                        var temp10 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                        var temp11 = (((temp7) && (temp9)) && (temp10));
                        var temp12 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                        var temp13 = ((byte)(((ushort)(i)) >> 11));
                        var temp14 = (((byte)(temp13 & 31L)) == ((byte)((byte)0U & 31L)));
                        var temp15 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                        var temp16 = (((temp12) && (temp14)) && (temp15));
                        var temp17 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                        var temp18 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                        var temp19 = (((temp17) && (temp14)) && (temp18));
                        var temp20 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                        var temp21 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                        var temp22 = (((temp20) && (temp14)) && (temp21));
                        var temp23 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                        var temp24 = ((byte)(((ushort)(i)) >> 12));
                        var temp25 = (((byte)(temp24 & 15L)) == ((byte)((byte)0U & 15L)));
                        var temp26 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                        var temp27 = (((temp23) && (temp25)) && (temp26));
                        var temp28 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                        var temp29 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                        var temp30 = (((temp28) && (temp25)) && (temp29));
                        var temp31 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                        var temp32 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                        var temp33 = (((temp31) && (temp25)) && (temp32));
                        var temp34 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                        var temp35 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                        var temp36 = (((temp34) && (temp25)) && (temp35));
                        var temp37 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                        var temp38 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                        var temp39 = (((temp37) && (temp25)) && (temp38));
                        var temp40 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                        var temp41 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                        var temp42 = (((temp40) && (temp25)) && (temp41));
                        var temp43 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                        var temp44 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                        var temp45 = (((temp43) && (temp25)) && (temp44));
                        var temp46 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                        var temp47 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                        var temp48 = (((temp46) && (temp25)) && (temp47));
                        var temp49 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                        var temp50 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                        var temp51 = (((temp49) && (temp25)) && (temp50));
                        var temp52 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                        var temp53 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                        var temp54 = (((temp52) && (temp25)) && (temp53));
                        var temp55 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                        var temp56 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                        var temp57 = (((temp55) && (temp25)) && (temp56));
                        var temp58 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                        var temp59 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                        var temp60 = (((temp58) && (temp25)) && (temp59));
                        var temp61 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                        var temp62 = ((byte)(((ushort)(i)) >> 13));
                        var temp63 = (((byte)(temp62 & 7L)) == ((byte)((byte)0U & 7L)));
                        var temp64 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                        var temp65 = (((temp61) && (temp63)) && (temp64));
                        var temp66 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                        var temp67 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                        var temp68 = (((temp66) && (temp63)) && (temp67));
                        var temp69 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                        var temp70 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                        var temp71 = (((temp69) && (temp63)) && (temp70));
                        var temp72 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                        var temp73 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                        var temp74 = (((temp72) && (temp63)) && (temp73));
                        var temp75 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                        var temp76 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                        var temp77 = (((temp75) && (temp63)) && (temp76));
                        var temp78 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                        var temp79 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                        var temp80 = (((temp78) && (temp63)) && (temp79));
                        var temp81 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                        var temp82 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                        var temp83 = (((temp81) && (temp63)) && (temp82));
                        var temp84 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                        var temp85 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                        var temp86 = (((temp84) && (temp63)) && (temp85));
                        var temp87 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                        var temp88 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                        var temp89 = (((temp87) && (temp63)) && (temp88));
                        var temp90 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                        var temp91 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                        var temp92 = (((temp90) && (temp63)) && (temp91));
                        var temp93 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                        var temp94 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                        var temp95 = ((temp93) && (temp94));
                        var temp96 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                        var temp97 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                        var temp98 = ((temp96) && (temp97));
                        var temp99 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                        var temp100 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                        var temp101 = ((temp99) && (temp100));
                        var temp102 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                        var temp103 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                        var temp104 = ((temp102) && (temp103));
                        var temp105 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                        var temp106 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                        var temp107 = ((temp105) && (temp106));
                        var temp108 = (((((((((((((((((((((((((((((((temp11) || (temp16)) || (temp19)) || (temp22)) || (temp27)) || (temp30)) || (temp33)) || (temp36)) || (temp39)) || (temp42)) || (temp45)) || (temp48)) || (temp51)) || (temp54)) || (temp57)) || (temp60)) || (temp65)) || (temp68)) || (temp71)) || (temp74)) || (temp77)) || (temp80)) || (temp83)) || (temp86)) || (temp89)) || (temp92)) || (temp95)) || (temp98)) || (temp101)) || (temp104)) || (temp107));
                        if (temp108)
                        {
                            var temp109 = ((uint)(((uint)((uint)10U)) * ((uint)(s))));
                            var temp110 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                            var temp111 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp109))) + ((uint)(temp110))));
                            s = (uint)(temp111);
                            goto M8;
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
                        var temp112 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp112)
                        {
                            goto M9;
                        }
                        else
                        {
                            var temp113 = (((ushort)(i)) == ((ushort)((ushort)46U)));
                            if (temp113)
                            {
                                goto M10;
                            }
                            else
                            {
                                var temp114 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                                var temp115 = ((ushort)(((ushort)(i)) >> 6));
                                var temp116 = (((ushort)(temp115 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                var temp117 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp118 = (((temp114) && (temp116)) && (temp117));
                                var temp119 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                                var temp120 = ((byte)(((ushort)(i)) >> 11));
                                var temp121 = (((byte)(temp120 & 31L)) == ((byte)((byte)0U & 31L)));
                                var temp122 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                var temp123 = (((temp119) && (temp121)) && (temp122));
                                var temp124 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                                var temp125 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                var temp126 = (((temp124) && (temp121)) && (temp125));
                                var temp127 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                                var temp128 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                var temp129 = (((temp127) && (temp121)) && (temp128));
                                var temp130 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                                var temp131 = ((byte)(((ushort)(i)) >> 12));
                                var temp132 = (((byte)(temp131 & 15L)) == ((byte)((byte)0U & 15L)));
                                var temp133 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                var temp134 = (((temp130) && (temp132)) && (temp133));
                                var temp135 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                                var temp136 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                var temp137 = (((temp135) && (temp132)) && (temp136));
                                var temp138 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                                var temp139 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                var temp140 = (((temp138) && (temp132)) && (temp139));
                                var temp141 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                                var temp142 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                var temp143 = (((temp141) && (temp132)) && (temp142));
                                var temp144 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                                var temp145 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                var temp146 = (((temp144) && (temp132)) && (temp145));
                                var temp147 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                                var temp148 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                var temp149 = (((temp147) && (temp132)) && (temp148));
                                var temp150 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                                var temp151 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                var temp152 = (((temp150) && (temp132)) && (temp151));
                                var temp153 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                                var temp154 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                var temp155 = (((temp153) && (temp132)) && (temp154));
                                var temp156 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                                var temp157 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                var temp158 = (((temp156) && (temp132)) && (temp157));
                                var temp159 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                                var temp160 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                var temp161 = (((temp159) && (temp132)) && (temp160));
                                var temp162 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                                var temp163 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                var temp164 = (((temp162) && (temp132)) && (temp163));
                                var temp165 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                                var temp166 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                var temp167 = (((temp165) && (temp132)) && (temp166));
                                var temp168 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                                var temp169 = ((byte)(((ushort)(i)) >> 13));
                                var temp170 = (((byte)(temp169 & 7L)) == ((byte)((byte)0U & 7L)));
                                var temp171 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                var temp172 = (((temp168) && (temp170)) && (temp171));
                                var temp173 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                                var temp174 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                var temp175 = (((temp173) && (temp170)) && (temp174));
                                var temp176 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                                var temp177 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                var temp178 = (((temp176) && (temp170)) && (temp177));
                                var temp179 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                                var temp180 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                var temp181 = (((temp179) && (temp170)) && (temp180));
                                var temp182 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                                var temp183 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                var temp184 = (((temp182) && (temp170)) && (temp183));
                                var temp185 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                                var temp186 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                var temp187 = (((temp185) && (temp170)) && (temp186));
                                var temp188 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                                var temp189 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                var temp190 = (((temp188) && (temp170)) && (temp189));
                                var temp191 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                                var temp192 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                var temp193 = (((temp191) && (temp170)) && (temp192));
                                var temp194 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                                var temp195 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                var temp196 = (((temp194) && (temp170)) && (temp195));
                                var temp197 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                                var temp198 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                var temp199 = (((temp197) && (temp170)) && (temp198));
                                var temp200 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                                var temp201 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                                var temp202 = ((temp200) && (temp201));
                                var temp203 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                                var temp204 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                                var temp205 = ((temp203) && (temp204));
                                var temp206 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                                var temp207 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                                var temp208 = ((temp206) && (temp207));
                                var temp209 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                                var temp210 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                                var temp211 = ((temp209) && (temp210));
                                var temp212 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                                var temp213 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                                var temp214 = ((temp212) && (temp213));
                                var temp215 = (((((((((((((((((((((((((((((((temp118) || (temp123)) || (temp126)) || (temp129)) || (temp134)) || (temp137)) || (temp140)) || (temp143)) || (temp146)) || (temp149)) || (temp152)) || (temp155)) || (temp158)) || (temp161)) || (temp164)) || (temp167)) || (temp172)) || (temp175)) || (temp178)) || (temp181)) || (temp184)) || (temp187)) || (temp190)) || (temp193)) || (temp196)) || (temp199)) || (temp202)) || (temp205)) || (temp208)) || (temp211)) || (temp214));
                                if (temp215)
                                {
                                    var temp216 = ((uint)(((uint)((uint)10U)) * ((uint)(s))));
                                    var temp217 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                                    var temp218 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp216))) + ((uint)(temp217))));
                                    s = (uint)(temp218);
                                    goto M8;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                    }
                }

                M9:
                {
                    if (!ie.MoveNext())
                        goto F9;
                    i = ie.Current;
                    {
                        var temp219 = (((ushort)(i)) == ((ushort)((ushort)10U)));
                        if (temp219)
                        {
                            yield return (Int32)(s);
                            s = (uint)((uint)0U);
                            goto M0;
                        }
                        else
                        {
                            goto M9;
                        }
                    }
                }

                M10:
                {
                    if (!ie.MoveNext())
                        goto F10;
                    i = ie.Current;
                    {
                        var temp220 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                        var temp221 = ((ushort)(((ushort)(i)) >> 6));
                        var temp222 = (((ushort)(temp221 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                        var temp223 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                        var temp224 = (((temp220) && (temp222)) && (temp223));
                        var temp225 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                        var temp226 = ((byte)(((ushort)(i)) >> 11));
                        var temp227 = (((byte)(temp226 & 31L)) == ((byte)((byte)0U & 31L)));
                        var temp228 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                        var temp229 = (((temp225) && (temp227)) && (temp228));
                        var temp230 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                        var temp231 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                        var temp232 = (((temp230) && (temp227)) && (temp231));
                        var temp233 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                        var temp234 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                        var temp235 = (((temp233) && (temp227)) && (temp234));
                        var temp236 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                        var temp237 = ((byte)(((ushort)(i)) >> 12));
                        var temp238 = (((byte)(temp237 & 15L)) == ((byte)((byte)0U & 15L)));
                        var temp239 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                        var temp240 = (((temp236) && (temp238)) && (temp239));
                        var temp241 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                        var temp242 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                        var temp243 = (((temp241) && (temp238)) && (temp242));
                        var temp244 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                        var temp245 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                        var temp246 = (((temp244) && (temp238)) && (temp245));
                        var temp247 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                        var temp248 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                        var temp249 = (((temp247) && (temp238)) && (temp248));
                        var temp250 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                        var temp251 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                        var temp252 = (((temp250) && (temp238)) && (temp251));
                        var temp253 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                        var temp254 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                        var temp255 = (((temp253) && (temp238)) && (temp254));
                        var temp256 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                        var temp257 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                        var temp258 = (((temp256) && (temp238)) && (temp257));
                        var temp259 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                        var temp260 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                        var temp261 = (((temp259) && (temp238)) && (temp260));
                        var temp262 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                        var temp263 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                        var temp264 = (((temp262) && (temp238)) && (temp263));
                        var temp265 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                        var temp266 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                        var temp267 = (((temp265) && (temp238)) && (temp266));
                        var temp268 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                        var temp269 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                        var temp270 = (((temp268) && (temp238)) && (temp269));
                        var temp271 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                        var temp272 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                        var temp273 = (((temp271) && (temp238)) && (temp272));
                        var temp274 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                        var temp275 = ((byte)(((ushort)(i)) >> 13));
                        var temp276 = (((byte)(temp275 & 7L)) == ((byte)((byte)0U & 7L)));
                        var temp277 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                        var temp278 = (((temp274) && (temp276)) && (temp277));
                        var temp279 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                        var temp280 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                        var temp281 = (((temp279) && (temp276)) && (temp280));
                        var temp282 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                        var temp283 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                        var temp284 = (((temp282) && (temp276)) && (temp283));
                        var temp285 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                        var temp286 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                        var temp287 = (((temp285) && (temp276)) && (temp286));
                        var temp288 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                        var temp289 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                        var temp290 = (((temp288) && (temp276)) && (temp289));
                        var temp291 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                        var temp292 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                        var temp293 = (((temp291) && (temp276)) && (temp292));
                        var temp294 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                        var temp295 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                        var temp296 = (((temp294) && (temp276)) && (temp295));
                        var temp297 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                        var temp298 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                        var temp299 = (((temp297) && (temp276)) && (temp298));
                        var temp300 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                        var temp301 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                        var temp302 = (((temp300) && (temp276)) && (temp301));
                        var temp303 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                        var temp304 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                        var temp305 = (((temp303) && (temp276)) && (temp304));
                        var temp306 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                        var temp307 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                        var temp308 = ((temp306) && (temp307));
                        var temp309 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                        var temp310 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                        var temp311 = ((temp309) && (temp310));
                        var temp312 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                        var temp313 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                        var temp314 = ((temp312) && (temp313));
                        var temp315 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                        var temp316 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                        var temp317 = ((temp315) && (temp316));
                        var temp318 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                        var temp319 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                        var temp320 = ((temp318) && (temp319));
                        var temp321 = (((((((((((((((((((((((((((((((temp224) || (temp229)) || (temp232)) || (temp235)) || (temp240)) || (temp243)) || (temp246)) || (temp249)) || (temp252)) || (temp255)) || (temp258)) || (temp261)) || (temp264)) || (temp267)) || (temp270)) || (temp273)) || (temp278)) || (temp281)) || (temp284)) || (temp287)) || (temp290)) || (temp293)) || (temp296)) || (temp299)) || (temp302)) || (temp305)) || (temp308)) || (temp311)) || (temp314)) || (temp317)) || (temp320));
                        if (temp321)
                        {
                            goto M11;
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
                        var temp322 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp322)
                        {
                            goto M9;
                        }
                        else
                        {
                            var temp323 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                            var temp324 = ((ushort)(((ushort)(i)) >> 6));
                            var temp325 = (((ushort)(temp324 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp326 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp327 = (((temp323) && (temp325)) && (temp326));
                            var temp328 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                            var temp329 = ((byte)(((ushort)(i)) >> 11));
                            var temp330 = (((byte)(temp329 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp331 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp332 = (((temp328) && (temp330)) && (temp331));
                            var temp333 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                            var temp334 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp335 = (((temp333) && (temp330)) && (temp334));
                            var temp336 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                            var temp337 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp338 = (((temp336) && (temp330)) && (temp337));
                            var temp339 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                            var temp340 = ((byte)(((ushort)(i)) >> 12));
                            var temp341 = (((byte)(temp340 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp342 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp343 = (((temp339) && (temp341)) && (temp342));
                            var temp344 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                            var temp345 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp346 = (((temp344) && (temp341)) && (temp345));
                            var temp347 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                            var temp348 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp349 = (((temp347) && (temp341)) && (temp348));
                            var temp350 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                            var temp351 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp352 = (((temp350) && (temp341)) && (temp351));
                            var temp353 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                            var temp354 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp355 = (((temp353) && (temp341)) && (temp354));
                            var temp356 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                            var temp357 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp358 = (((temp356) && (temp341)) && (temp357));
                            var temp359 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                            var temp360 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp361 = (((temp359) && (temp341)) && (temp360));
                            var temp362 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                            var temp363 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp364 = (((temp362) && (temp341)) && (temp363));
                            var temp365 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                            var temp366 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp367 = (((temp365) && (temp341)) && (temp366));
                            var temp368 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                            var temp369 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp370 = (((temp368) && (temp341)) && (temp369));
                            var temp371 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                            var temp372 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp373 = (((temp371) && (temp341)) && (temp372));
                            var temp374 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                            var temp375 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp376 = (((temp374) && (temp341)) && (temp375));
                            var temp377 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                            var temp378 = ((byte)(((ushort)(i)) >> 13));
                            var temp379 = (((byte)(temp378 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp380 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp381 = (((temp377) && (temp379)) && (temp380));
                            var temp382 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                            var temp383 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp384 = (((temp382) && (temp379)) && (temp383));
                            var temp385 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                            var temp386 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp387 = (((temp385) && (temp379)) && (temp386));
                            var temp388 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                            var temp389 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp390 = (((temp388) && (temp379)) && (temp389));
                            var temp391 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                            var temp392 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp393 = (((temp391) && (temp379)) && (temp392));
                            var temp394 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                            var temp395 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp396 = (((temp394) && (temp379)) && (temp395));
                            var temp397 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                            var temp398 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp399 = (((temp397) && (temp379)) && (temp398));
                            var temp400 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                            var temp401 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp402 = (((temp400) && (temp379)) && (temp401));
                            var temp403 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                            var temp404 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp405 = (((temp403) && (temp379)) && (temp404));
                            var temp406 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                            var temp407 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp408 = (((temp406) && (temp379)) && (temp407));
                            var temp409 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                            var temp410 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                            var temp411 = ((temp409) && (temp410));
                            var temp412 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                            var temp413 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                            var temp414 = ((temp412) && (temp413));
                            var temp415 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                            var temp416 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                            var temp417 = ((temp415) && (temp416));
                            var temp418 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                            var temp419 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                            var temp420 = ((temp418) && (temp419));
                            var temp421 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                            var temp422 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                            var temp423 = ((temp421) && (temp422));
                            var temp424 = (((((((((((((((((((((((((((((((temp327) || (temp332)) || (temp335)) || (temp338)) || (temp343)) || (temp346)) || (temp349)) || (temp352)) || (temp355)) || (temp358)) || (temp361)) || (temp364)) || (temp367)) || (temp370)) || (temp373)) || (temp376)) || (temp381)) || (temp384)) || (temp387)) || (temp390)) || (temp393)) || (temp396)) || (temp399)) || (temp402)) || (temp405)) || (temp408)) || (temp411)) || (temp414)) || (temp417)) || (temp420)) || (temp423));
                            if (temp424)
                            {
                                goto M11;
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
                F11:
                    throw new Exception();
            }
        }
    }
}