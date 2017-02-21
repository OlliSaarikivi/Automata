using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class SBOEmployees : SpecialTransducer
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
                        var temp5 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                        var temp6 = ((ushort)(((ushort)(i)) >> 6));
                        var temp7 = (((ushort)(temp6 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                        var temp8 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                        var temp9 = (((temp5) && (temp7)) && (temp8));
                        var temp10 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                        var temp11 = ((byte)(((ushort)(i)) >> 11));
                        var temp12 = (((byte)(temp11 & 31L)) == ((byte)((byte)0U & 31L)));
                        var temp13 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                        var temp14 = (((temp10) && (temp12)) && (temp13));
                        var temp15 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                        var temp16 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                        var temp17 = (((temp15) && (temp12)) && (temp16));
                        var temp18 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                        var temp19 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                        var temp20 = (((temp18) && (temp12)) && (temp19));
                        var temp21 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                        var temp22 = ((byte)(((ushort)(i)) >> 12));
                        var temp23 = (((byte)(temp22 & 15L)) == ((byte)((byte)0U & 15L)));
                        var temp24 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                        var temp25 = (((temp21) && (temp23)) && (temp24));
                        var temp26 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                        var temp27 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                        var temp28 = (((temp26) && (temp23)) && (temp27));
                        var temp29 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                        var temp30 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                        var temp31 = (((temp29) && (temp23)) && (temp30));
                        var temp32 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                        var temp33 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                        var temp34 = (((temp32) && (temp23)) && (temp33));
                        var temp35 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                        var temp36 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                        var temp37 = (((temp35) && (temp23)) && (temp36));
                        var temp38 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                        var temp39 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                        var temp40 = (((temp38) && (temp23)) && (temp39));
                        var temp41 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                        var temp42 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                        var temp43 = (((temp41) && (temp23)) && (temp42));
                        var temp44 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                        var temp45 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                        var temp46 = (((temp44) && (temp23)) && (temp45));
                        var temp47 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                        var temp48 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                        var temp49 = (((temp47) && (temp23)) && (temp48));
                        var temp50 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                        var temp51 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                        var temp52 = (((temp50) && (temp23)) && (temp51));
                        var temp53 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                        var temp54 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                        var temp55 = (((temp53) && (temp23)) && (temp54));
                        var temp56 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                        var temp57 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                        var temp58 = (((temp56) && (temp23)) && (temp57));
                        var temp59 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                        var temp60 = ((byte)(((ushort)(i)) >> 13));
                        var temp61 = (((byte)(temp60 & 7L)) == ((byte)((byte)0U & 7L)));
                        var temp62 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                        var temp63 = (((temp59) && (temp61)) && (temp62));
                        var temp64 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                        var temp65 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                        var temp66 = (((temp64) && (temp61)) && (temp65));
                        var temp67 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                        var temp68 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                        var temp69 = (((temp67) && (temp61)) && (temp68));
                        var temp70 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                        var temp71 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                        var temp72 = (((temp70) && (temp61)) && (temp71));
                        var temp73 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                        var temp74 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                        var temp75 = (((temp73) && (temp61)) && (temp74));
                        var temp76 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                        var temp77 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                        var temp78 = (((temp76) && (temp61)) && (temp77));
                        var temp79 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                        var temp80 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                        var temp81 = (((temp79) && (temp61)) && (temp80));
                        var temp82 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                        var temp83 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                        var temp84 = (((temp82) && (temp61)) && (temp83));
                        var temp85 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                        var temp86 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                        var temp87 = (((temp85) && (temp61)) && (temp86));
                        var temp88 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                        var temp89 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                        var temp90 = (((temp88) && (temp61)) && (temp89));
                        var temp91 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                        var temp92 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                        var temp93 = ((temp91) && (temp92));
                        var temp94 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                        var temp95 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                        var temp96 = ((temp94) && (temp95));
                        var temp97 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                        var temp98 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                        var temp99 = ((temp97) && (temp98));
                        var temp100 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                        var temp101 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                        var temp102 = ((temp100) && (temp101));
                        var temp103 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                        var temp104 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                        var temp105 = ((temp103) && (temp104));
                        var temp106 = (((((((((((((((((((((((((((((((temp9) || (temp14)) || (temp17)) || (temp20)) || (temp25)) || (temp28)) || (temp31)) || (temp34)) || (temp37)) || (temp40)) || (temp43)) || (temp46)) || (temp49)) || (temp52)) || (temp55)) || (temp58)) || (temp63)) || (temp66)) || (temp69)) || (temp72)) || (temp75)) || (temp78)) || (temp81)) || (temp84)) || (temp87)) || (temp90)) || (temp93)) || (temp96)) || (temp99)) || (temp102)) || (temp105));
                        if (temp106)
                        {
                            var temp107 = ((uint)(((uint)((uint)10U)) * ((uint)(s))));
                            var temp108 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                            var temp109 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp107))) + ((uint)(temp108))));
                            s = (uint)(temp109);
                            goto M6;
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
                        var temp110 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp110)
                        {
                            goto M7;
                        }
                        else
                        {
                            var temp111 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                            var temp112 = ((ushort)(((ushort)(i)) >> 6));
                            var temp113 = (((ushort)(temp112 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp114 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp115 = (((temp111) && (temp113)) && (temp114));
                            var temp116 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                            var temp117 = ((byte)(((ushort)(i)) >> 11));
                            var temp118 = (((byte)(temp117 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp119 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp120 = (((temp116) && (temp118)) && (temp119));
                            var temp121 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                            var temp122 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp123 = (((temp121) && (temp118)) && (temp122));
                            var temp124 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                            var temp125 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp126 = (((temp124) && (temp118)) && (temp125));
                            var temp127 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                            var temp128 = ((byte)(((ushort)(i)) >> 12));
                            var temp129 = (((byte)(temp128 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp130 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp131 = (((temp127) && (temp129)) && (temp130));
                            var temp132 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                            var temp133 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp134 = (((temp132) && (temp129)) && (temp133));
                            var temp135 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                            var temp136 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp137 = (((temp135) && (temp129)) && (temp136));
                            var temp138 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                            var temp139 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp140 = (((temp138) && (temp129)) && (temp139));
                            var temp141 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                            var temp142 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp143 = (((temp141) && (temp129)) && (temp142));
                            var temp144 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                            var temp145 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp146 = (((temp144) && (temp129)) && (temp145));
                            var temp147 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                            var temp148 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp149 = (((temp147) && (temp129)) && (temp148));
                            var temp150 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                            var temp151 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp152 = (((temp150) && (temp129)) && (temp151));
                            var temp153 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                            var temp154 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp155 = (((temp153) && (temp129)) && (temp154));
                            var temp156 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                            var temp157 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp158 = (((temp156) && (temp129)) && (temp157));
                            var temp159 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                            var temp160 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp161 = (((temp159) && (temp129)) && (temp160));
                            var temp162 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                            var temp163 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp164 = (((temp162) && (temp129)) && (temp163));
                            var temp165 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                            var temp166 = ((byte)(((ushort)(i)) >> 13));
                            var temp167 = (((byte)(temp166 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp168 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp169 = (((temp165) && (temp167)) && (temp168));
                            var temp170 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                            var temp171 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp172 = (((temp170) && (temp167)) && (temp171));
                            var temp173 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                            var temp174 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp175 = (((temp173) && (temp167)) && (temp174));
                            var temp176 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                            var temp177 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp178 = (((temp176) && (temp167)) && (temp177));
                            var temp179 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                            var temp180 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp181 = (((temp179) && (temp167)) && (temp180));
                            var temp182 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                            var temp183 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp184 = (((temp182) && (temp167)) && (temp183));
                            var temp185 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                            var temp186 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp187 = (((temp185) && (temp167)) && (temp186));
                            var temp188 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                            var temp189 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp190 = (((temp188) && (temp167)) && (temp189));
                            var temp191 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                            var temp192 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp193 = (((temp191) && (temp167)) && (temp192));
                            var temp194 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                            var temp195 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp196 = (((temp194) && (temp167)) && (temp195));
                            var temp197 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                            var temp198 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                            var temp199 = ((temp197) && (temp198));
                            var temp200 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                            var temp201 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                            var temp202 = ((temp200) && (temp201));
                            var temp203 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                            var temp204 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                            var temp205 = ((temp203) && (temp204));
                            var temp206 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                            var temp207 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                            var temp208 = ((temp206) && (temp207));
                            var temp209 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                            var temp210 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                            var temp211 = ((temp209) && (temp210));
                            var temp212 = (((((((((((((((((((((((((((((((temp115) || (temp120)) || (temp123)) || (temp126)) || (temp131)) || (temp134)) || (temp137)) || (temp140)) || (temp143)) || (temp146)) || (temp149)) || (temp152)) || (temp155)) || (temp158)) || (temp161)) || (temp164)) || (temp169)) || (temp172)) || (temp175)) || (temp178)) || (temp181)) || (temp184)) || (temp187)) || (temp190)) || (temp193)) || (temp196)) || (temp199)) || (temp202)) || (temp205)) || (temp208)) || (temp211));
                            if (temp212)
                            {
                                var temp213 = ((uint)(((uint)((uint)10U)) * ((uint)(s))));
                                var temp214 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                                var temp215 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp213))) + ((uint)(temp214))));
                                s = (uint)(temp215);
                                goto M6;
                            }
                            else
                                throw new Exception();
                        }
                    }
                }

                M7:
                {
                    if (!ie.MoveNext())
                        goto F7;
                    i = ie.Current;
                    {
                        var temp216 = (((ushort)(i)) == ((ushort)((ushort)10U)));
                        if (temp216)
                        {
                            yield return (Int32)(s);
                            s = (uint)((uint)0U);
                            goto M0;
                        }
                        else
                        {
                            goto M7;
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
            }
        }
    }
}