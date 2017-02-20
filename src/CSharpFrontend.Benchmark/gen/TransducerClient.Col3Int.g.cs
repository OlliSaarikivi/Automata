using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class Col3Int : SpecialTransducer
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
                            var temp1 = ((ushort)(((ushort)(i)) >> 4));
                            var temp2 = (((ushort)(temp1 & 4095L)) == ((ushort)((ushort)0U & 4095L)));
                            var temp3 = (((byte)(((byte)((ushort)(i))) & 15L)) <= ((byte)((byte)9U & 15L)));
                            var temp4 = ((temp2) && (temp3));
                            var temp5 = (((ushort)((ushort)11U)) <= ((ushort)(i)));
                            var temp6 = ((ushort)(((ushort)(i)) >> 6));
                            var temp7 = (((ushort)(temp6 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp8 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)43U & 63L)));
                            var temp9 = (((temp5) && (temp7)) && (temp8));
                            var temp10 = (((ushort)((ushort)45U)) <= ((ushort)(i)));
                            var temp11 = (((temp4) || (temp9)) || (temp10));
                            if (temp11)
                            {
                                goto M0;
                            }
                            else
                                throw new Exception();
                        }
                    }
                }

                M1:
                {
                    if (!ie.MoveNext())
                        goto F1;
                    i = ie.Current;
                    {
                        var temp12 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp12)
                        {
                            goto M2;
                        }
                        else
                        {
                            var temp13 = ((ushort)(((ushort)(i)) >> 4));
                            var temp14 = (((ushort)(temp13 & 4095L)) == ((ushort)((ushort)0U & 4095L)));
                            var temp15 = (((byte)(((byte)((ushort)(i))) & 15L)) <= ((byte)((byte)9U & 15L)));
                            var temp16 = ((temp14) && (temp15));
                            var temp17 = (((ushort)((ushort)11U)) <= ((ushort)(i)));
                            var temp18 = ((ushort)(((ushort)(i)) >> 6));
                            var temp19 = (((ushort)(temp18 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp20 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)43U & 63L)));
                            var temp21 = (((temp17) && (temp19)) && (temp20));
                            var temp22 = (((ushort)((ushort)45U)) <= ((ushort)(i)));
                            var temp23 = (((temp16) || (temp21)) || (temp22));
                            if (temp23)
                            {
                                goto M1;
                            }
                            else
                                throw new Exception();
                        }
                    }
                }

                M2:
                {
                    if (!ie.MoveNext())
                        goto F2;
                    i = ie.Current;
                    {
                        var temp24 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp24)
                        {
                            goto M3;
                        }
                        else
                        {
                            var temp25 = ((ushort)(((ushort)(i)) >> 4));
                            var temp26 = (((ushort)(temp25 & 4095L)) == ((ushort)((ushort)0U & 4095L)));
                            var temp27 = (((byte)(((byte)((ushort)(i))) & 15L)) <= ((byte)((byte)9U & 15L)));
                            var temp28 = ((temp26) && (temp27));
                            var temp29 = (((ushort)((ushort)11U)) <= ((ushort)(i)));
                            var temp30 = ((ushort)(((ushort)(i)) >> 6));
                            var temp31 = (((ushort)(temp30 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp32 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)43U & 63L)));
                            var temp33 = (((temp29) && (temp31)) && (temp32));
                            var temp34 = (((ushort)((ushort)45U)) <= ((ushort)(i)));
                            var temp35 = (((temp28) || (temp33)) || (temp34));
                            if (temp35)
                            {
                                goto M2;
                            }
                            else
                                throw new Exception();
                        }
                    }
                }

                M3:
                {
                    if (!ie.MoveNext())
                        goto F3;
                    i = ie.Current;
                    {
                        var temp36 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                        var temp37 = ((ushort)(((ushort)(i)) >> 6));
                        var temp38 = (((ushort)(temp37 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                        var temp39 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                        var temp40 = (((temp36) && (temp38)) && (temp39));
                        var temp41 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                        var temp42 = ((byte)(((ushort)(i)) >> 11));
                        var temp43 = (((byte)(temp42 & 31L)) == ((byte)((byte)0U & 31L)));
                        var temp44 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                        var temp45 = (((temp41) && (temp43)) && (temp44));
                        var temp46 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                        var temp47 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                        var temp48 = (((temp46) && (temp43)) && (temp47));
                        var temp49 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                        var temp50 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                        var temp51 = (((temp49) && (temp43)) && (temp50));
                        var temp52 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                        var temp53 = ((byte)(((ushort)(i)) >> 12));
                        var temp54 = (((byte)(temp53 & 15L)) == ((byte)((byte)0U & 15L)));
                        var temp55 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                        var temp56 = (((temp52) && (temp54)) && (temp55));
                        var temp57 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                        var temp58 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                        var temp59 = (((temp57) && (temp54)) && (temp58));
                        var temp60 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                        var temp61 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                        var temp62 = (((temp60) && (temp54)) && (temp61));
                        var temp63 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                        var temp64 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                        var temp65 = (((temp63) && (temp54)) && (temp64));
                        var temp66 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                        var temp67 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                        var temp68 = (((temp66) && (temp54)) && (temp67));
                        var temp69 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                        var temp70 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                        var temp71 = (((temp69) && (temp54)) && (temp70));
                        var temp72 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                        var temp73 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                        var temp74 = (((temp72) && (temp54)) && (temp73));
                        var temp75 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                        var temp76 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                        var temp77 = (((temp75) && (temp54)) && (temp76));
                        var temp78 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                        var temp79 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                        var temp80 = (((temp78) && (temp54)) && (temp79));
                        var temp81 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                        var temp82 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                        var temp83 = (((temp81) && (temp54)) && (temp82));
                        var temp84 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                        var temp85 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                        var temp86 = (((temp84) && (temp54)) && (temp85));
                        var temp87 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                        var temp88 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                        var temp89 = (((temp87) && (temp54)) && (temp88));
                        var temp90 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                        var temp91 = ((byte)(((ushort)(i)) >> 13));
                        var temp92 = (((byte)(temp91 & 7L)) == ((byte)((byte)0U & 7L)));
                        var temp93 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                        var temp94 = (((temp90) && (temp92)) && (temp93));
                        var temp95 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                        var temp96 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                        var temp97 = (((temp95) && (temp92)) && (temp96));
                        var temp98 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                        var temp99 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                        var temp100 = (((temp98) && (temp92)) && (temp99));
                        var temp101 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                        var temp102 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                        var temp103 = (((temp101) && (temp92)) && (temp102));
                        var temp104 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                        var temp105 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                        var temp106 = (((temp104) && (temp92)) && (temp105));
                        var temp107 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                        var temp108 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                        var temp109 = (((temp107) && (temp92)) && (temp108));
                        var temp110 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                        var temp111 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                        var temp112 = (((temp110) && (temp92)) && (temp111));
                        var temp113 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                        var temp114 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                        var temp115 = (((temp113) && (temp92)) && (temp114));
                        var temp116 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                        var temp117 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                        var temp118 = (((temp116) && (temp92)) && (temp117));
                        var temp119 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                        var temp120 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                        var temp121 = (((temp119) && (temp92)) && (temp120));
                        var temp122 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                        var temp123 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                        var temp124 = ((temp122) && (temp123));
                        var temp125 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                        var temp126 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                        var temp127 = ((temp125) && (temp126));
                        var temp128 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                        var temp129 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                        var temp130 = ((temp128) && (temp129));
                        var temp131 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                        var temp132 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                        var temp133 = ((temp131) && (temp132));
                        var temp134 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                        var temp135 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                        var temp136 = ((temp134) && (temp135));
                        var temp137 = (((((((((((((((((((((((((((((((temp40) || (temp45)) || (temp48)) || (temp51)) || (temp56)) || (temp59)) || (temp62)) || (temp65)) || (temp68)) || (temp71)) || (temp74)) || (temp77)) || (temp80)) || (temp83)) || (temp86)) || (temp89)) || (temp94)) || (temp97)) || (temp100)) || (temp103)) || (temp106)) || (temp109)) || (temp112)) || (temp115)) || (temp118)) || (temp121)) || (temp124)) || (temp127)) || (temp130)) || (temp133)) || (temp136));
                        if (temp137)
                        {
                            var temp138 = ((uint)(((uint)((uint)10U)) * ((uint)(s))));
                            var temp139 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                            var temp140 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp138))) + ((uint)(temp139))));
                            s = (uint)(temp140);
                            goto M4;
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
                        var temp141 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp141)
                        {
                            goto M5;
                        }
                        else
                        {
                            var temp142 = (((ushort)(i)) == ((ushort)((ushort)10U)));
                            if (temp142)
                            {
                                yield return (Int32)(s);
                                s = (uint)((uint)0U);
                                goto M0;
                            }
                            else
                            {
                                var temp143 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                                var temp144 = ((ushort)(((ushort)(i)) >> 6));
                                var temp145 = (((ushort)(temp144 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                var temp146 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp147 = (((temp143) && (temp145)) && (temp146));
                                var temp148 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                                var temp149 = ((byte)(((ushort)(i)) >> 11));
                                var temp150 = (((byte)(temp149 & 31L)) == ((byte)((byte)0U & 31L)));
                                var temp151 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                var temp152 = (((temp148) && (temp150)) && (temp151));
                                var temp153 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                                var temp154 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                var temp155 = (((temp153) && (temp150)) && (temp154));
                                var temp156 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                                var temp157 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                var temp158 = (((temp156) && (temp150)) && (temp157));
                                var temp159 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                                var temp160 = ((byte)(((ushort)(i)) >> 12));
                                var temp161 = (((byte)(temp160 & 15L)) == ((byte)((byte)0U & 15L)));
                                var temp162 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                var temp163 = (((temp159) && (temp161)) && (temp162));
                                var temp164 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                                var temp165 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                var temp166 = (((temp164) && (temp161)) && (temp165));
                                var temp167 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                                var temp168 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                var temp169 = (((temp167) && (temp161)) && (temp168));
                                var temp170 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                                var temp171 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                var temp172 = (((temp170) && (temp161)) && (temp171));
                                var temp173 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                                var temp174 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                var temp175 = (((temp173) && (temp161)) && (temp174));
                                var temp176 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                                var temp177 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                var temp178 = (((temp176) && (temp161)) && (temp177));
                                var temp179 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                                var temp180 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                var temp181 = (((temp179) && (temp161)) && (temp180));
                                var temp182 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                                var temp183 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                var temp184 = (((temp182) && (temp161)) && (temp183));
                                var temp185 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                                var temp186 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                var temp187 = (((temp185) && (temp161)) && (temp186));
                                var temp188 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                                var temp189 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                var temp190 = (((temp188) && (temp161)) && (temp189));
                                var temp191 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                                var temp192 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                var temp193 = (((temp191) && (temp161)) && (temp192));
                                var temp194 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                                var temp195 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                var temp196 = (((temp194) && (temp161)) && (temp195));
                                var temp197 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                                var temp198 = ((byte)(((ushort)(i)) >> 13));
                                var temp199 = (((byte)(temp198 & 7L)) == ((byte)((byte)0U & 7L)));
                                var temp200 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                var temp201 = (((temp197) && (temp199)) && (temp200));
                                var temp202 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                                var temp203 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                var temp204 = (((temp202) && (temp199)) && (temp203));
                                var temp205 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                                var temp206 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                var temp207 = (((temp205) && (temp199)) && (temp206));
                                var temp208 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                                var temp209 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                var temp210 = (((temp208) && (temp199)) && (temp209));
                                var temp211 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                                var temp212 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                var temp213 = (((temp211) && (temp199)) && (temp212));
                                var temp214 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                                var temp215 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                var temp216 = (((temp214) && (temp199)) && (temp215));
                                var temp217 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                                var temp218 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                var temp219 = (((temp217) && (temp199)) && (temp218));
                                var temp220 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                                var temp221 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                var temp222 = (((temp220) && (temp199)) && (temp221));
                                var temp223 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                                var temp224 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                var temp225 = (((temp223) && (temp199)) && (temp224));
                                var temp226 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                                var temp227 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                var temp228 = (((temp226) && (temp199)) && (temp227));
                                var temp229 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                                var temp230 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                                var temp231 = ((temp229) && (temp230));
                                var temp232 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                                var temp233 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                                var temp234 = ((temp232) && (temp233));
                                var temp235 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                                var temp236 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                                var temp237 = ((temp235) && (temp236));
                                var temp238 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                                var temp239 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                                var temp240 = ((temp238) && (temp239));
                                var temp241 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                                var temp242 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                                var temp243 = ((temp241) && (temp242));
                                var temp244 = (((((((((((((((((((((((((((((((temp147) || (temp152)) || (temp155)) || (temp158)) || (temp163)) || (temp166)) || (temp169)) || (temp172)) || (temp175)) || (temp178)) || (temp181)) || (temp184)) || (temp187)) || (temp190)) || (temp193)) || (temp196)) || (temp201)) || (temp204)) || (temp207)) || (temp210)) || (temp213)) || (temp216)) || (temp219)) || (temp222)) || (temp225)) || (temp228)) || (temp231)) || (temp234)) || (temp237)) || (temp240)) || (temp243));
                                if (temp244)
                                {
                                    var temp245 = ((uint)(((uint)((uint)10U)) * ((uint)(s))));
                                    var temp246 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                                    var temp247 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp245))) + ((uint)(temp246))));
                                    s = (uint)(temp247);
                                    goto M4;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                    }
                }

                M5:
                {
                    if (!ie.MoveNext())
                        goto F5;
                    i = ie.Current;
                    {
                        var temp248 = (((ushort)(i)) == ((ushort)((ushort)10U)));
                        if (temp248)
                        {
                            yield return (Int32)(s);
                            s = (uint)((uint)0U);
                            goto M0;
                        }
                        else
                        {
                            goto M5;
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
            }
        }
    }
}