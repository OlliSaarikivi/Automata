using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class SQLInsertInt32 : Transducer<int, char>
    {
        static UInt32 Fun0(UInt64 v0)
        {
            return (UInt32)(((((long)((ulong)(v0)) <= (long)((ulong)((ulong)999999999UL)))) ? ((uint)(((((long)((ulong)(v0)) <= (long)((ulong)((ulong)99999999UL)))) ? ((uint)(((((long)((ulong)(v0)) <= (long)((ulong)((ulong)9999999UL)))) ? ((uint)(((((long)((ulong)(v0)) <= (long)((ulong)((ulong)999999UL)))) ? ((uint)(((((long)((ulong)(v0)) <= (long)((ulong)((ulong)99999UL)))) ? ((uint)(((((long)((ulong)(v0)) <= (long)((ulong)((ulong)9999UL)))) ? ((uint)(((((long)((ulong)(v0)) <= (long)((ulong)((ulong)999UL)))) ? ((uint)(((((long)((ulong)(v0)) <= (long)((ulong)((ulong)99UL)))) ? ((uint)(((((long)((ulong)(v0)) <= (long)((ulong)((ulong)9UL)))) ? ((uint)((uint)1U)) : ((uint)((uint)2U))))) : ((uint)((uint)3U))))) : ((uint)((uint)4U))))) : ((uint)((uint)5U))))) : ((uint)((uint)6U))))) : ((uint)((uint)7U))))) : ((uint)((uint)8U))))) : ((uint)((uint)9U))))) : ((uint)((uint)10U))));
        }

        public static IEnumerable<Char> Transduce(IEnumerable<Int32> input)
        {
            unchecked
            {
                IEnumerator<Int32> ie = input.GetEnumerator();
                object s = new object ();
                Int32 i;
                M0:
                {
                    if (!ie.MoveNext())
                        goto F0;
                    i = ie.Current;
                    {
                        var temp0 = (((uint)(i)) == ((uint)((uint)0U)));
                        if (temp0)
                        {
                            yield return (Char)((ushort)73U);
                            yield return (Char)((ushort)78U);
                            yield return (Char)((ushort)83U);
                            yield return (Char)((ushort)69U);
                            yield return (Char)((ushort)82U);
                            yield return (Char)((ushort)84U);
                            yield return (Char)((ushort)32U);
                            yield return (Char)((ushort)73U);
                            yield return (Char)((ushort)78U);
                            yield return (Char)((ushort)84U);
                            yield return (Char)((ushort)79U);
                            yield return (Char)((ushort)32U);
                            yield return (Char)((ushort)65U);
                            yield return (Char)((ushort)99U);
                            yield return (Char)((ushort)99U);
                            yield return (Char)((ushort)111U);
                            yield return (Char)((ushort)117U);
                            yield return (Char)((ushort)110U);
                            yield return (Char)((ushort)116U);
                            yield return (Char)((ushort)115U);
                            yield return (Char)((ushort)10U);
                            yield return (Char)((ushort)86U);
                            yield return (Char)((ushort)65U);
                            yield return (Char)((ushort)76U);
                            yield return (Char)((ushort)85U);
                            yield return (Char)((ushort)69U);
                            yield return (Char)((ushort)83U);
                            yield return (Char)((ushort)32U);
                            yield return (Char)((ushort)40U);
                            yield return (Char)((ushort)48U);
                            goto M0;
                        }
                        else
                        {
                            var temp1 = ((int)((uint)((uint)0U)) <= (int)((uint)(i)));
                            var temp2 = !(temp1);
                            if (temp2)
                            {
                                var temp3 = ((byte)(((uint)(i)) >> 31));
                                var temp4 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 1) | (ulong)((byte)(temp3 & 1L)) << 32) | (ulong)((uint)(i));
                                var temp5 = ((ulong)(((ulong)((ulong)18446744073709551615UL)) * ((ulong)(temp4))));
                                var temp6 = Fun0(((ulong)(temp5)));
                                var temp7 = ((uint)(((uint)((uint)4294967295U)) + ((uint)(temp6))));
                                var temp8 = ((int)((uint)(temp7)) <= (int)((uint)((uint)0U)));
                                var temp9 = !(temp8);
                                if (temp9)
                                {
                                    var temp10 = ((int)((uint)(temp7)) <= (int)((uint)((uint)1U)));
                                    var temp11 = !(temp10);
                                    if (temp11)
                                    {
                                        var temp12 = ((int)((uint)(temp7)) <= (int)((uint)((uint)2U)));
                                        var temp13 = !(temp12);
                                        if (temp13)
                                        {
                                            var temp14 = ((int)((uint)(temp7)) <= (int)((uint)((uint)3U)));
                                            var temp15 = !(temp14);
                                            if (temp15)
                                            {
                                                var temp16 = ((int)((uint)(temp7)) <= (int)((uint)((uint)4U)));
                                                var temp17 = !(temp16);
                                                if (temp17)
                                                {
                                                    var temp18 = ((int)((uint)(temp7)) <= (int)((uint)((uint)5U)));
                                                    var temp19 = !(temp18);
                                                    if (temp19)
                                                    {
                                                        var temp20 = ((int)((uint)(temp7)) <= (int)((uint)((uint)6U)));
                                                        var temp21 = !(temp20);
                                                        if (temp21)
                                                        {
                                                            var temp22 = ((int)((uint)(temp7)) <= (int)((uint)((uint)7U)));
                                                            var temp23 = !(temp22);
                                                            if (temp23)
                                                            {
                                                                var temp24 = ((int)((uint)(temp7)) <= (int)((uint)((uint)8U)));
                                                                var temp25 = !(temp24);
                                                                if (temp25)
                                                                {
                                                                    yield return (Char)((ushort)73U);
                                                                    yield return (Char)((ushort)78U);
                                                                    yield return (Char)((ushort)83U);
                                                                    yield return (Char)((ushort)69U);
                                                                    yield return (Char)((ushort)82U);
                                                                    yield return (Char)((ushort)84U);
                                                                    yield return (Char)((ushort)32U);
                                                                    yield return (Char)((ushort)73U);
                                                                    yield return (Char)((ushort)78U);
                                                                    yield return (Char)((ushort)84U);
                                                                    yield return (Char)((ushort)79U);
                                                                    yield return (Char)((ushort)32U);
                                                                    yield return (Char)((ushort)65U);
                                                                    yield return (Char)((ushort)99U);
                                                                    yield return (Char)((ushort)99U);
                                                                    yield return (Char)((ushort)111U);
                                                                    yield return (Char)((ushort)117U);
                                                                    yield return (Char)((ushort)110U);
                                                                    yield return (Char)((ushort)116U);
                                                                    yield return (Char)((ushort)115U);
                                                                    yield return (Char)((ushort)10U);
                                                                    yield return (Char)((ushort)86U);
                                                                    yield return (Char)((ushort)65U);
                                                                    yield return (Char)((ushort)76U);
                                                                    yield return (Char)((ushort)85U);
                                                                    yield return (Char)((ushort)69U);
                                                                    yield return (Char)((ushort)83U);
                                                                    yield return (Char)((ushort)32U);
                                                                    yield return (Char)((ushort)40U);
                                                                    yield return (Char)((ushort)45U);
                                                                    var temp26 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000000000U))));
                                                                    var temp27 = ((uint)((int)((uint)(temp26)) % (int)((uint)((uint)10U))));
                                                                    var temp28 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp27)))))));
                                                                    var temp29 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp28))));
                                                                    yield return (Char)(temp29);
                                                                    var temp30 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100000000U))));
                                                                    var temp31 = ((uint)((int)((uint)(temp30)) % (int)((uint)((uint)10U))));
                                                                    var temp32 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp31)))))));
                                                                    var temp33 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp32))));
                                                                    yield return (Char)(temp33);
                                                                    var temp34 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10000000U))));
                                                                    var temp35 = ((uint)((int)((uint)(temp34)) % (int)((uint)((uint)10U))));
                                                                    var temp36 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp35)))))));
                                                                    var temp37 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp36))));
                                                                    yield return (Char)(temp37);
                                                                    var temp38 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000000U))));
                                                                    var temp39 = ((uint)((int)((uint)(temp38)) % (int)((uint)((uint)10U))));
                                                                    var temp40 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp39)))))));
                                                                    var temp41 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp40))));
                                                                    yield return (Char)(temp41);
                                                                    var temp42 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100000U))));
                                                                    var temp43 = ((uint)((int)((uint)(temp42)) % (int)((uint)((uint)10U))));
                                                                    var temp44 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp43)))))));
                                                                    var temp45 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp44))));
                                                                    yield return (Char)(temp45);
                                                                    var temp46 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10000U))));
                                                                    var temp47 = ((uint)((int)((uint)(temp46)) % (int)((uint)((uint)10U))));
                                                                    var temp48 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp47)))))));
                                                                    var temp49 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp48))));
                                                                    yield return (Char)(temp49);
                                                                    var temp50 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000U))));
                                                                    var temp51 = ((uint)((int)((uint)(temp50)) % (int)((uint)((uint)10U))));
                                                                    var temp52 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp51)))))));
                                                                    var temp53 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp52))));
                                                                    yield return (Char)(temp53);
                                                                    var temp54 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100U))));
                                                                    var temp55 = ((uint)((int)((uint)(temp54)) % (int)((uint)((uint)10U))));
                                                                    var temp56 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp55)))))));
                                                                    var temp57 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp56))));
                                                                    yield return (Char)(temp57);
                                                                    var temp58 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10U))));
                                                                    var temp59 = ((uint)((int)((uint)(temp58)) % (int)((uint)((uint)10U))));
                                                                    var temp60 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp59)))))));
                                                                    var temp61 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp60))));
                                                                    yield return (Char)(temp61);
                                                                    var temp62 = ((uint)((int)((uint)(i)) % (int)((uint)((uint)10U))));
                                                                    var temp63 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp62)))))));
                                                                    var temp64 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp63))));
                                                                    yield return (Char)(temp64);
                                                                    yield return (Char)((ushort)41U);
                                                                    yield return (Char)((ushort)59U);
                                                                    yield return (Char)((ushort)10U);
                                                                    goto M0;
                                                                }
                                                                else
                                                                {
                                                                    yield return (Char)((ushort)73U);
                                                                    yield return (Char)((ushort)78U);
                                                                    yield return (Char)((ushort)83U);
                                                                    yield return (Char)((ushort)69U);
                                                                    yield return (Char)((ushort)82U);
                                                                    yield return (Char)((ushort)84U);
                                                                    yield return (Char)((ushort)32U);
                                                                    yield return (Char)((ushort)73U);
                                                                    yield return (Char)((ushort)78U);
                                                                    yield return (Char)((ushort)84U);
                                                                    yield return (Char)((ushort)79U);
                                                                    yield return (Char)((ushort)32U);
                                                                    yield return (Char)((ushort)65U);
                                                                    yield return (Char)((ushort)99U);
                                                                    yield return (Char)((ushort)99U);
                                                                    yield return (Char)((ushort)111U);
                                                                    yield return (Char)((ushort)117U);
                                                                    yield return (Char)((ushort)110U);
                                                                    yield return (Char)((ushort)116U);
                                                                    yield return (Char)((ushort)115U);
                                                                    yield return (Char)((ushort)10U);
                                                                    yield return (Char)((ushort)86U);
                                                                    yield return (Char)((ushort)65U);
                                                                    yield return (Char)((ushort)76U);
                                                                    yield return (Char)((ushort)85U);
                                                                    yield return (Char)((ushort)69U);
                                                                    yield return (Char)((ushort)83U);
                                                                    yield return (Char)((ushort)32U);
                                                                    yield return (Char)((ushort)40U);
                                                                    yield return (Char)((ushort)45U);
                                                                    var temp65 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100000000U))));
                                                                    var temp66 = ((uint)((int)((uint)(temp65)) % (int)((uint)((uint)10U))));
                                                                    var temp67 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp66)))))));
                                                                    var temp68 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp67))));
                                                                    yield return (Char)(temp68);
                                                                    var temp69 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10000000U))));
                                                                    var temp70 = ((uint)((int)((uint)(temp69)) % (int)((uint)((uint)10U))));
                                                                    var temp71 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp70)))))));
                                                                    var temp72 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp71))));
                                                                    yield return (Char)(temp72);
                                                                    var temp73 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000000U))));
                                                                    var temp74 = ((uint)((int)((uint)(temp73)) % (int)((uint)((uint)10U))));
                                                                    var temp75 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp74)))))));
                                                                    var temp76 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp75))));
                                                                    yield return (Char)(temp76);
                                                                    var temp77 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100000U))));
                                                                    var temp78 = ((uint)((int)((uint)(temp77)) % (int)((uint)((uint)10U))));
                                                                    var temp79 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp78)))))));
                                                                    var temp80 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp79))));
                                                                    yield return (Char)(temp80);
                                                                    var temp81 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10000U))));
                                                                    var temp82 = ((uint)((int)((uint)(temp81)) % (int)((uint)((uint)10U))));
                                                                    var temp83 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp82)))))));
                                                                    var temp84 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp83))));
                                                                    yield return (Char)(temp84);
                                                                    var temp85 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000U))));
                                                                    var temp86 = ((uint)((int)((uint)(temp85)) % (int)((uint)((uint)10U))));
                                                                    var temp87 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp86)))))));
                                                                    var temp88 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp87))));
                                                                    yield return (Char)(temp88);
                                                                    var temp89 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100U))));
                                                                    var temp90 = ((uint)((int)((uint)(temp89)) % (int)((uint)((uint)10U))));
                                                                    var temp91 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp90)))))));
                                                                    var temp92 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp91))));
                                                                    yield return (Char)(temp92);
                                                                    var temp93 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10U))));
                                                                    var temp94 = ((uint)((int)((uint)(temp93)) % (int)((uint)((uint)10U))));
                                                                    var temp95 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp94)))))));
                                                                    var temp96 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp95))));
                                                                    yield return (Char)(temp96);
                                                                    var temp97 = ((uint)((int)((uint)(i)) % (int)((uint)((uint)10U))));
                                                                    var temp98 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp97)))))));
                                                                    var temp99 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp98))));
                                                                    yield return (Char)(temp99);
                                                                    yield return (Char)((ushort)41U);
                                                                    yield return (Char)((ushort)59U);
                                                                    yield return (Char)((ushort)10U);
                                                                    goto M0;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                yield return (Char)((ushort)73U);
                                                                yield return (Char)((ushort)78U);
                                                                yield return (Char)((ushort)83U);
                                                                yield return (Char)((ushort)69U);
                                                                yield return (Char)((ushort)82U);
                                                                yield return (Char)((ushort)84U);
                                                                yield return (Char)((ushort)32U);
                                                                yield return (Char)((ushort)73U);
                                                                yield return (Char)((ushort)78U);
                                                                yield return (Char)((ushort)84U);
                                                                yield return (Char)((ushort)79U);
                                                                yield return (Char)((ushort)32U);
                                                                yield return (Char)((ushort)65U);
                                                                yield return (Char)((ushort)99U);
                                                                yield return (Char)((ushort)99U);
                                                                yield return (Char)((ushort)111U);
                                                                yield return (Char)((ushort)117U);
                                                                yield return (Char)((ushort)110U);
                                                                yield return (Char)((ushort)116U);
                                                                yield return (Char)((ushort)115U);
                                                                yield return (Char)((ushort)10U);
                                                                yield return (Char)((ushort)86U);
                                                                yield return (Char)((ushort)65U);
                                                                yield return (Char)((ushort)76U);
                                                                yield return (Char)((ushort)85U);
                                                                yield return (Char)((ushort)69U);
                                                                yield return (Char)((ushort)83U);
                                                                yield return (Char)((ushort)32U);
                                                                yield return (Char)((ushort)40U);
                                                                yield return (Char)((ushort)45U);
                                                                var temp100 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10000000U))));
                                                                var temp101 = ((uint)((int)((uint)(temp100)) % (int)((uint)((uint)10U))));
                                                                var temp102 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp101)))))));
                                                                var temp103 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp102))));
                                                                yield return (Char)(temp103);
                                                                var temp104 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000000U))));
                                                                var temp105 = ((uint)((int)((uint)(temp104)) % (int)((uint)((uint)10U))));
                                                                var temp106 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp105)))))));
                                                                var temp107 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp106))));
                                                                yield return (Char)(temp107);
                                                                var temp108 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100000U))));
                                                                var temp109 = ((uint)((int)((uint)(temp108)) % (int)((uint)((uint)10U))));
                                                                var temp110 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp109)))))));
                                                                var temp111 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp110))));
                                                                yield return (Char)(temp111);
                                                                var temp112 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10000U))));
                                                                var temp113 = ((uint)((int)((uint)(temp112)) % (int)((uint)((uint)10U))));
                                                                var temp114 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp113)))))));
                                                                var temp115 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp114))));
                                                                yield return (Char)(temp115);
                                                                var temp116 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000U))));
                                                                var temp117 = ((uint)((int)((uint)(temp116)) % (int)((uint)((uint)10U))));
                                                                var temp118 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp117)))))));
                                                                var temp119 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp118))));
                                                                yield return (Char)(temp119);
                                                                var temp120 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100U))));
                                                                var temp121 = ((uint)((int)((uint)(temp120)) % (int)((uint)((uint)10U))));
                                                                var temp122 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp121)))))));
                                                                var temp123 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp122))));
                                                                yield return (Char)(temp123);
                                                                var temp124 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10U))));
                                                                var temp125 = ((uint)((int)((uint)(temp124)) % (int)((uint)((uint)10U))));
                                                                var temp126 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp125)))))));
                                                                var temp127 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp126))));
                                                                yield return (Char)(temp127);
                                                                var temp128 = ((uint)((int)((uint)(i)) % (int)((uint)((uint)10U))));
                                                                var temp129 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp128)))))));
                                                                var temp130 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp129))));
                                                                yield return (Char)(temp130);
                                                                yield return (Char)((ushort)41U);
                                                                yield return (Char)((ushort)59U);
                                                                yield return (Char)((ushort)10U);
                                                                goto M0;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            yield return (Char)((ushort)73U);
                                                            yield return (Char)((ushort)78U);
                                                            yield return (Char)((ushort)83U);
                                                            yield return (Char)((ushort)69U);
                                                            yield return (Char)((ushort)82U);
                                                            yield return (Char)((ushort)84U);
                                                            yield return (Char)((ushort)32U);
                                                            yield return (Char)((ushort)73U);
                                                            yield return (Char)((ushort)78U);
                                                            yield return (Char)((ushort)84U);
                                                            yield return (Char)((ushort)79U);
                                                            yield return (Char)((ushort)32U);
                                                            yield return (Char)((ushort)65U);
                                                            yield return (Char)((ushort)99U);
                                                            yield return (Char)((ushort)99U);
                                                            yield return (Char)((ushort)111U);
                                                            yield return (Char)((ushort)117U);
                                                            yield return (Char)((ushort)110U);
                                                            yield return (Char)((ushort)116U);
                                                            yield return (Char)((ushort)115U);
                                                            yield return (Char)((ushort)10U);
                                                            yield return (Char)((ushort)86U);
                                                            yield return (Char)((ushort)65U);
                                                            yield return (Char)((ushort)76U);
                                                            yield return (Char)((ushort)85U);
                                                            yield return (Char)((ushort)69U);
                                                            yield return (Char)((ushort)83U);
                                                            yield return (Char)((ushort)32U);
                                                            yield return (Char)((ushort)40U);
                                                            yield return (Char)((ushort)45U);
                                                            var temp131 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000000U))));
                                                            var temp132 = ((uint)((int)((uint)(temp131)) % (int)((uint)((uint)10U))));
                                                            var temp133 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp132)))))));
                                                            var temp134 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp133))));
                                                            yield return (Char)(temp134);
                                                            var temp135 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100000U))));
                                                            var temp136 = ((uint)((int)((uint)(temp135)) % (int)((uint)((uint)10U))));
                                                            var temp137 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp136)))))));
                                                            var temp138 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp137))));
                                                            yield return (Char)(temp138);
                                                            var temp139 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10000U))));
                                                            var temp140 = ((uint)((int)((uint)(temp139)) % (int)((uint)((uint)10U))));
                                                            var temp141 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp140)))))));
                                                            var temp142 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp141))));
                                                            yield return (Char)(temp142);
                                                            var temp143 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000U))));
                                                            var temp144 = ((uint)((int)((uint)(temp143)) % (int)((uint)((uint)10U))));
                                                            var temp145 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp144)))))));
                                                            var temp146 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp145))));
                                                            yield return (Char)(temp146);
                                                            var temp147 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100U))));
                                                            var temp148 = ((uint)((int)((uint)(temp147)) % (int)((uint)((uint)10U))));
                                                            var temp149 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp148)))))));
                                                            var temp150 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp149))));
                                                            yield return (Char)(temp150);
                                                            var temp151 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10U))));
                                                            var temp152 = ((uint)((int)((uint)(temp151)) % (int)((uint)((uint)10U))));
                                                            var temp153 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp152)))))));
                                                            var temp154 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp153))));
                                                            yield return (Char)(temp154);
                                                            var temp155 = ((uint)((int)((uint)(i)) % (int)((uint)((uint)10U))));
                                                            var temp156 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp155)))))));
                                                            var temp157 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp156))));
                                                            yield return (Char)(temp157);
                                                            yield return (Char)((ushort)41U);
                                                            yield return (Char)((ushort)59U);
                                                            yield return (Char)((ushort)10U);
                                                            goto M0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        yield return (Char)((ushort)73U);
                                                        yield return (Char)((ushort)78U);
                                                        yield return (Char)((ushort)83U);
                                                        yield return (Char)((ushort)69U);
                                                        yield return (Char)((ushort)82U);
                                                        yield return (Char)((ushort)84U);
                                                        yield return (Char)((ushort)32U);
                                                        yield return (Char)((ushort)73U);
                                                        yield return (Char)((ushort)78U);
                                                        yield return (Char)((ushort)84U);
                                                        yield return (Char)((ushort)79U);
                                                        yield return (Char)((ushort)32U);
                                                        yield return (Char)((ushort)65U);
                                                        yield return (Char)((ushort)99U);
                                                        yield return (Char)((ushort)99U);
                                                        yield return (Char)((ushort)111U);
                                                        yield return (Char)((ushort)117U);
                                                        yield return (Char)((ushort)110U);
                                                        yield return (Char)((ushort)116U);
                                                        yield return (Char)((ushort)115U);
                                                        yield return (Char)((ushort)10U);
                                                        yield return (Char)((ushort)86U);
                                                        yield return (Char)((ushort)65U);
                                                        yield return (Char)((ushort)76U);
                                                        yield return (Char)((ushort)85U);
                                                        yield return (Char)((ushort)69U);
                                                        yield return (Char)((ushort)83U);
                                                        yield return (Char)((ushort)32U);
                                                        yield return (Char)((ushort)40U);
                                                        yield return (Char)((ushort)45U);
                                                        var temp158 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100000U))));
                                                        var temp159 = ((uint)((int)((uint)(temp158)) % (int)((uint)((uint)10U))));
                                                        var temp160 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp159)))))));
                                                        var temp161 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp160))));
                                                        yield return (Char)(temp161);
                                                        var temp162 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10000U))));
                                                        var temp163 = ((uint)((int)((uint)(temp162)) % (int)((uint)((uint)10U))));
                                                        var temp164 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp163)))))));
                                                        var temp165 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp164))));
                                                        yield return (Char)(temp165);
                                                        var temp166 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000U))));
                                                        var temp167 = ((uint)((int)((uint)(temp166)) % (int)((uint)((uint)10U))));
                                                        var temp168 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp167)))))));
                                                        var temp169 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp168))));
                                                        yield return (Char)(temp169);
                                                        var temp170 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100U))));
                                                        var temp171 = ((uint)((int)((uint)(temp170)) % (int)((uint)((uint)10U))));
                                                        var temp172 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp171)))))));
                                                        var temp173 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp172))));
                                                        yield return (Char)(temp173);
                                                        var temp174 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10U))));
                                                        var temp175 = ((uint)((int)((uint)(temp174)) % (int)((uint)((uint)10U))));
                                                        var temp176 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp175)))))));
                                                        var temp177 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp176))));
                                                        yield return (Char)(temp177);
                                                        var temp178 = ((uint)((int)((uint)(i)) % (int)((uint)((uint)10U))));
                                                        var temp179 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp178)))))));
                                                        var temp180 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp179))));
                                                        yield return (Char)(temp180);
                                                        yield return (Char)((ushort)41U);
                                                        yield return (Char)((ushort)59U);
                                                        yield return (Char)((ushort)10U);
                                                        goto M0;
                                                    }
                                                }
                                                else
                                                {
                                                    yield return (Char)((ushort)73U);
                                                    yield return (Char)((ushort)78U);
                                                    yield return (Char)((ushort)83U);
                                                    yield return (Char)((ushort)69U);
                                                    yield return (Char)((ushort)82U);
                                                    yield return (Char)((ushort)84U);
                                                    yield return (Char)((ushort)32U);
                                                    yield return (Char)((ushort)73U);
                                                    yield return (Char)((ushort)78U);
                                                    yield return (Char)((ushort)84U);
                                                    yield return (Char)((ushort)79U);
                                                    yield return (Char)((ushort)32U);
                                                    yield return (Char)((ushort)65U);
                                                    yield return (Char)((ushort)99U);
                                                    yield return (Char)((ushort)99U);
                                                    yield return (Char)((ushort)111U);
                                                    yield return (Char)((ushort)117U);
                                                    yield return (Char)((ushort)110U);
                                                    yield return (Char)((ushort)116U);
                                                    yield return (Char)((ushort)115U);
                                                    yield return (Char)((ushort)10U);
                                                    yield return (Char)((ushort)86U);
                                                    yield return (Char)((ushort)65U);
                                                    yield return (Char)((ushort)76U);
                                                    yield return (Char)((ushort)85U);
                                                    yield return (Char)((ushort)69U);
                                                    yield return (Char)((ushort)83U);
                                                    yield return (Char)((ushort)32U);
                                                    yield return (Char)((ushort)40U);
                                                    yield return (Char)((ushort)45U);
                                                    var temp181 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10000U))));
                                                    var temp182 = ((uint)((int)((uint)(temp181)) % (int)((uint)((uint)10U))));
                                                    var temp183 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp182)))))));
                                                    var temp184 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp183))));
                                                    yield return (Char)(temp184);
                                                    var temp185 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000U))));
                                                    var temp186 = ((uint)((int)((uint)(temp185)) % (int)((uint)((uint)10U))));
                                                    var temp187 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp186)))))));
                                                    var temp188 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp187))));
                                                    yield return (Char)(temp188);
                                                    var temp189 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100U))));
                                                    var temp190 = ((uint)((int)((uint)(temp189)) % (int)((uint)((uint)10U))));
                                                    var temp191 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp190)))))));
                                                    var temp192 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp191))));
                                                    yield return (Char)(temp192);
                                                    var temp193 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10U))));
                                                    var temp194 = ((uint)((int)((uint)(temp193)) % (int)((uint)((uint)10U))));
                                                    var temp195 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp194)))))));
                                                    var temp196 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp195))));
                                                    yield return (Char)(temp196);
                                                    var temp197 = ((uint)((int)((uint)(i)) % (int)((uint)((uint)10U))));
                                                    var temp198 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp197)))))));
                                                    var temp199 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp198))));
                                                    yield return (Char)(temp199);
                                                    yield return (Char)((ushort)41U);
                                                    yield return (Char)((ushort)59U);
                                                    yield return (Char)((ushort)10U);
                                                    goto M0;
                                                }
                                            }
                                            else
                                            {
                                                yield return (Char)((ushort)73U);
                                                yield return (Char)((ushort)78U);
                                                yield return (Char)((ushort)83U);
                                                yield return (Char)((ushort)69U);
                                                yield return (Char)((ushort)82U);
                                                yield return (Char)((ushort)84U);
                                                yield return (Char)((ushort)32U);
                                                yield return (Char)((ushort)73U);
                                                yield return (Char)((ushort)78U);
                                                yield return (Char)((ushort)84U);
                                                yield return (Char)((ushort)79U);
                                                yield return (Char)((ushort)32U);
                                                yield return (Char)((ushort)65U);
                                                yield return (Char)((ushort)99U);
                                                yield return (Char)((ushort)99U);
                                                yield return (Char)((ushort)111U);
                                                yield return (Char)((ushort)117U);
                                                yield return (Char)((ushort)110U);
                                                yield return (Char)((ushort)116U);
                                                yield return (Char)((ushort)115U);
                                                yield return (Char)((ushort)10U);
                                                yield return (Char)((ushort)86U);
                                                yield return (Char)((ushort)65U);
                                                yield return (Char)((ushort)76U);
                                                yield return (Char)((ushort)85U);
                                                yield return (Char)((ushort)69U);
                                                yield return (Char)((ushort)83U);
                                                yield return (Char)((ushort)32U);
                                                yield return (Char)((ushort)40U);
                                                yield return (Char)((ushort)45U);
                                                var temp200 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000U))));
                                                var temp201 = ((uint)((int)((uint)(temp200)) % (int)((uint)((uint)10U))));
                                                var temp202 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp201)))))));
                                                var temp203 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp202))));
                                                yield return (Char)(temp203);
                                                var temp204 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100U))));
                                                var temp205 = ((uint)((int)((uint)(temp204)) % (int)((uint)((uint)10U))));
                                                var temp206 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp205)))))));
                                                var temp207 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp206))));
                                                yield return (Char)(temp207);
                                                var temp208 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10U))));
                                                var temp209 = ((uint)((int)((uint)(temp208)) % (int)((uint)((uint)10U))));
                                                var temp210 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp209)))))));
                                                var temp211 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp210))));
                                                yield return (Char)(temp211);
                                                var temp212 = ((uint)((int)((uint)(i)) % (int)((uint)((uint)10U))));
                                                var temp213 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp212)))))));
                                                var temp214 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp213))));
                                                yield return (Char)(temp214);
                                                yield return (Char)((ushort)41U);
                                                yield return (Char)((ushort)59U);
                                                yield return (Char)((ushort)10U);
                                                goto M0;
                                            }
                                        }
                                        else
                                        {
                                            yield return (Char)((ushort)73U);
                                            yield return (Char)((ushort)78U);
                                            yield return (Char)((ushort)83U);
                                            yield return (Char)((ushort)69U);
                                            yield return (Char)((ushort)82U);
                                            yield return (Char)((ushort)84U);
                                            yield return (Char)((ushort)32U);
                                            yield return (Char)((ushort)73U);
                                            yield return (Char)((ushort)78U);
                                            yield return (Char)((ushort)84U);
                                            yield return (Char)((ushort)79U);
                                            yield return (Char)((ushort)32U);
                                            yield return (Char)((ushort)65U);
                                            yield return (Char)((ushort)99U);
                                            yield return (Char)((ushort)99U);
                                            yield return (Char)((ushort)111U);
                                            yield return (Char)((ushort)117U);
                                            yield return (Char)((ushort)110U);
                                            yield return (Char)((ushort)116U);
                                            yield return (Char)((ushort)115U);
                                            yield return (Char)((ushort)10U);
                                            yield return (Char)((ushort)86U);
                                            yield return (Char)((ushort)65U);
                                            yield return (Char)((ushort)76U);
                                            yield return (Char)((ushort)85U);
                                            yield return (Char)((ushort)69U);
                                            yield return (Char)((ushort)83U);
                                            yield return (Char)((ushort)32U);
                                            yield return (Char)((ushort)40U);
                                            yield return (Char)((ushort)45U);
                                            var temp215 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100U))));
                                            var temp216 = ((uint)((int)((uint)(temp215)) % (int)((uint)((uint)10U))));
                                            var temp217 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp216)))))));
                                            var temp218 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp217))));
                                            yield return (Char)(temp218);
                                            var temp219 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10U))));
                                            var temp220 = ((uint)((int)((uint)(temp219)) % (int)((uint)((uint)10U))));
                                            var temp221 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp220)))))));
                                            var temp222 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp221))));
                                            yield return (Char)(temp222);
                                            var temp223 = ((uint)((int)((uint)(i)) % (int)((uint)((uint)10U))));
                                            var temp224 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp223)))))));
                                            var temp225 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp224))));
                                            yield return (Char)(temp225);
                                            yield return (Char)((ushort)41U);
                                            yield return (Char)((ushort)59U);
                                            yield return (Char)((ushort)10U);
                                            goto M0;
                                        }
                                    }
                                    else
                                    {
                                        yield return (Char)((ushort)73U);
                                        yield return (Char)((ushort)78U);
                                        yield return (Char)((ushort)83U);
                                        yield return (Char)((ushort)69U);
                                        yield return (Char)((ushort)82U);
                                        yield return (Char)((ushort)84U);
                                        yield return (Char)((ushort)32U);
                                        yield return (Char)((ushort)73U);
                                        yield return (Char)((ushort)78U);
                                        yield return (Char)((ushort)84U);
                                        yield return (Char)((ushort)79U);
                                        yield return (Char)((ushort)32U);
                                        yield return (Char)((ushort)65U);
                                        yield return (Char)((ushort)99U);
                                        yield return (Char)((ushort)99U);
                                        yield return (Char)((ushort)111U);
                                        yield return (Char)((ushort)117U);
                                        yield return (Char)((ushort)110U);
                                        yield return (Char)((ushort)116U);
                                        yield return (Char)((ushort)115U);
                                        yield return (Char)((ushort)10U);
                                        yield return (Char)((ushort)86U);
                                        yield return (Char)((ushort)65U);
                                        yield return (Char)((ushort)76U);
                                        yield return (Char)((ushort)85U);
                                        yield return (Char)((ushort)69U);
                                        yield return (Char)((ushort)83U);
                                        yield return (Char)((ushort)32U);
                                        yield return (Char)((ushort)40U);
                                        yield return (Char)((ushort)45U);
                                        var temp226 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10U))));
                                        var temp227 = ((uint)((int)((uint)(temp226)) % (int)((uint)((uint)10U))));
                                        var temp228 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp227)))))));
                                        var temp229 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp228))));
                                        yield return (Char)(temp229);
                                        var temp230 = ((uint)((int)((uint)(i)) % (int)((uint)((uint)10U))));
                                        var temp231 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp230)))))));
                                        var temp232 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp231))));
                                        yield return (Char)(temp232);
                                        yield return (Char)((ushort)41U);
                                        yield return (Char)((ushort)59U);
                                        yield return (Char)((ushort)10U);
                                        goto M0;
                                    }
                                }
                                else
                                {
                                    yield return (Char)((ushort)73U);
                                    yield return (Char)((ushort)78U);
                                    yield return (Char)((ushort)83U);
                                    yield return (Char)((ushort)69U);
                                    yield return (Char)((ushort)82U);
                                    yield return (Char)((ushort)84U);
                                    yield return (Char)((ushort)32U);
                                    yield return (Char)((ushort)73U);
                                    yield return (Char)((ushort)78U);
                                    yield return (Char)((ushort)84U);
                                    yield return (Char)((ushort)79U);
                                    yield return (Char)((ushort)32U);
                                    yield return (Char)((ushort)65U);
                                    yield return (Char)((ushort)99U);
                                    yield return (Char)((ushort)99U);
                                    yield return (Char)((ushort)111U);
                                    yield return (Char)((ushort)117U);
                                    yield return (Char)((ushort)110U);
                                    yield return (Char)((ushort)116U);
                                    yield return (Char)((ushort)115U);
                                    yield return (Char)((ushort)10U);
                                    yield return (Char)((ushort)86U);
                                    yield return (Char)((ushort)65U);
                                    yield return (Char)((ushort)76U);
                                    yield return (Char)((ushort)85U);
                                    yield return (Char)((ushort)69U);
                                    yield return (Char)((ushort)83U);
                                    yield return (Char)((ushort)32U);
                                    yield return (Char)((ushort)40U);
                                    yield return (Char)((ushort)45U);
                                    var temp233 = ((uint)((int)((uint)(i)) % (int)((uint)((uint)10U))));
                                    var temp234 = ((ushort)(((ushort)((ushort)65535U)) * ((ushort)(((ushort)((uint)(temp233)))))));
                                    var temp235 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(temp234))));
                                    yield return (Char)(temp235);
                                    yield return (Char)((ushort)41U);
                                    yield return (Char)((ushort)59U);
                                    yield return (Char)((ushort)10U);
                                    goto M0;
                                }
                            }
                            else
                            {
                                var temp236 = ((byte)(((uint)(i)) >> 31));
                                var temp237 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 1) | (ulong)((byte)(temp236 & 1L)) << 32) | (ulong)((uint)(i));
                                var temp238 = Fun0(((ulong)(temp237)));
                                var temp239 = ((uint)(((uint)((uint)4294967295U)) + ((uint)(temp238))));
                                var temp240 = ((int)((uint)(temp239)) <= (int)((uint)((uint)0U)));
                                var temp241 = !(temp240);
                                if (temp241)
                                {
                                    var temp242 = ((int)((uint)(temp239)) <= (int)((uint)((uint)1U)));
                                    var temp243 = !(temp242);
                                    if (temp243)
                                    {
                                        var temp244 = ((int)((uint)(temp239)) <= (int)((uint)((uint)2U)));
                                        var temp245 = !(temp244);
                                        if (temp245)
                                        {
                                            var temp246 = ((int)((uint)(temp239)) <= (int)((uint)((uint)3U)));
                                            var temp247 = !(temp246);
                                            if (temp247)
                                            {
                                                var temp248 = ((int)((uint)(temp239)) <= (int)((uint)((uint)4U)));
                                                var temp249 = !(temp248);
                                                if (temp249)
                                                {
                                                    var temp250 = ((int)((uint)(temp239)) <= (int)((uint)((uint)5U)));
                                                    var temp251 = !(temp250);
                                                    if (temp251)
                                                    {
                                                        var temp252 = ((int)((uint)(temp239)) <= (int)((uint)((uint)6U)));
                                                        var temp253 = !(temp252);
                                                        if (temp253)
                                                        {
                                                            var temp254 = ((int)((uint)(temp239)) <= (int)((uint)((uint)7U)));
                                                            var temp255 = !(temp254);
                                                            if (temp255)
                                                            {
                                                                var temp256 = ((int)((uint)(temp239)) <= (int)((uint)((uint)8U)));
                                                                var temp257 = !(temp256);
                                                                if (temp257)
                                                                {
                                                                    yield return (Char)((ushort)73U);
                                                                    yield return (Char)((ushort)78U);
                                                                    yield return (Char)((ushort)83U);
                                                                    yield return (Char)((ushort)69U);
                                                                    yield return (Char)((ushort)82U);
                                                                    yield return (Char)((ushort)84U);
                                                                    yield return (Char)((ushort)32U);
                                                                    yield return (Char)((ushort)73U);
                                                                    yield return (Char)((ushort)78U);
                                                                    yield return (Char)((ushort)84U);
                                                                    yield return (Char)((ushort)79U);
                                                                    yield return (Char)((ushort)32U);
                                                                    yield return (Char)((ushort)65U);
                                                                    yield return (Char)((ushort)99U);
                                                                    yield return (Char)((ushort)99U);
                                                                    yield return (Char)((ushort)111U);
                                                                    yield return (Char)((ushort)117U);
                                                                    yield return (Char)((ushort)110U);
                                                                    yield return (Char)((ushort)116U);
                                                                    yield return (Char)((ushort)115U);
                                                                    yield return (Char)((ushort)10U);
                                                                    yield return (Char)((ushort)86U);
                                                                    yield return (Char)((ushort)65U);
                                                                    yield return (Char)((ushort)76U);
                                                                    yield return (Char)((ushort)85U);
                                                                    yield return (Char)((ushort)69U);
                                                                    yield return (Char)((ushort)83U);
                                                                    yield return (Char)((ushort)32U);
                                                                    yield return (Char)((ushort)40U);
                                                                    var temp258 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000000000U))));
                                                                    var temp259 = ((uint)((int)((uint)(temp258)) % (int)((uint)((uint)10U))));
                                                                    var temp260 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp259)))))));
                                                                    yield return (Char)(temp260);
                                                                    var temp261 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100000000U))));
                                                                    var temp262 = ((uint)((int)((uint)(temp261)) % (int)((uint)((uint)10U))));
                                                                    var temp263 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp262)))))));
                                                                    yield return (Char)(temp263);
                                                                    var temp264 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10000000U))));
                                                                    var temp265 = ((uint)((int)((uint)(temp264)) % (int)((uint)((uint)10U))));
                                                                    var temp266 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp265)))))));
                                                                    yield return (Char)(temp266);
                                                                    var temp267 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000000U))));
                                                                    var temp268 = ((uint)((int)((uint)(temp267)) % (int)((uint)((uint)10U))));
                                                                    var temp269 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp268)))))));
                                                                    yield return (Char)(temp269);
                                                                    var temp270 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100000U))));
                                                                    var temp271 = ((uint)((int)((uint)(temp270)) % (int)((uint)((uint)10U))));
                                                                    var temp272 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp271)))))));
                                                                    yield return (Char)(temp272);
                                                                    var temp273 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10000U))));
                                                                    var temp274 = ((uint)((int)((uint)(temp273)) % (int)((uint)((uint)10U))));
                                                                    var temp275 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp274)))))));
                                                                    yield return (Char)(temp275);
                                                                    var temp276 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000U))));
                                                                    var temp277 = ((uint)((int)((uint)(temp276)) % (int)((uint)((uint)10U))));
                                                                    var temp278 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp277)))))));
                                                                    yield return (Char)(temp278);
                                                                    var temp279 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100U))));
                                                                    var temp280 = ((uint)((int)((uint)(temp279)) % (int)((uint)((uint)10U))));
                                                                    var temp281 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp280)))))));
                                                                    yield return (Char)(temp281);
                                                                    var temp282 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10U))));
                                                                    var temp283 = ((uint)((int)((uint)(temp282)) % (int)((uint)((uint)10U))));
                                                                    var temp284 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp283)))))));
                                                                    yield return (Char)(temp284);
                                                                    var temp285 = ((uint)((int)((uint)(i)) % (int)((uint)((uint)10U))));
                                                                    var temp286 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp285)))))));
                                                                    yield return (Char)(temp286);
                                                                    yield return (Char)((ushort)41U);
                                                                    yield return (Char)((ushort)59U);
                                                                    yield return (Char)((ushort)10U);
                                                                    goto M0;
                                                                }
                                                                else
                                                                {
                                                                    yield return (Char)((ushort)73U);
                                                                    yield return (Char)((ushort)78U);
                                                                    yield return (Char)((ushort)83U);
                                                                    yield return (Char)((ushort)69U);
                                                                    yield return (Char)((ushort)82U);
                                                                    yield return (Char)((ushort)84U);
                                                                    yield return (Char)((ushort)32U);
                                                                    yield return (Char)((ushort)73U);
                                                                    yield return (Char)((ushort)78U);
                                                                    yield return (Char)((ushort)84U);
                                                                    yield return (Char)((ushort)79U);
                                                                    yield return (Char)((ushort)32U);
                                                                    yield return (Char)((ushort)65U);
                                                                    yield return (Char)((ushort)99U);
                                                                    yield return (Char)((ushort)99U);
                                                                    yield return (Char)((ushort)111U);
                                                                    yield return (Char)((ushort)117U);
                                                                    yield return (Char)((ushort)110U);
                                                                    yield return (Char)((ushort)116U);
                                                                    yield return (Char)((ushort)115U);
                                                                    yield return (Char)((ushort)10U);
                                                                    yield return (Char)((ushort)86U);
                                                                    yield return (Char)((ushort)65U);
                                                                    yield return (Char)((ushort)76U);
                                                                    yield return (Char)((ushort)85U);
                                                                    yield return (Char)((ushort)69U);
                                                                    yield return (Char)((ushort)83U);
                                                                    yield return (Char)((ushort)32U);
                                                                    yield return (Char)((ushort)40U);
                                                                    var temp287 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100000000U))));
                                                                    var temp288 = ((uint)((int)((uint)(temp287)) % (int)((uint)((uint)10U))));
                                                                    var temp289 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp288)))))));
                                                                    yield return (Char)(temp289);
                                                                    var temp290 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10000000U))));
                                                                    var temp291 = ((uint)((int)((uint)(temp290)) % (int)((uint)((uint)10U))));
                                                                    var temp292 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp291)))))));
                                                                    yield return (Char)(temp292);
                                                                    var temp293 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000000U))));
                                                                    var temp294 = ((uint)((int)((uint)(temp293)) % (int)((uint)((uint)10U))));
                                                                    var temp295 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp294)))))));
                                                                    yield return (Char)(temp295);
                                                                    var temp296 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100000U))));
                                                                    var temp297 = ((uint)((int)((uint)(temp296)) % (int)((uint)((uint)10U))));
                                                                    var temp298 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp297)))))));
                                                                    yield return (Char)(temp298);
                                                                    var temp299 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10000U))));
                                                                    var temp300 = ((uint)((int)((uint)(temp299)) % (int)((uint)((uint)10U))));
                                                                    var temp301 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp300)))))));
                                                                    yield return (Char)(temp301);
                                                                    var temp302 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000U))));
                                                                    var temp303 = ((uint)((int)((uint)(temp302)) % (int)((uint)((uint)10U))));
                                                                    var temp304 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp303)))))));
                                                                    yield return (Char)(temp304);
                                                                    var temp305 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100U))));
                                                                    var temp306 = ((uint)((int)((uint)(temp305)) % (int)((uint)((uint)10U))));
                                                                    var temp307 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp306)))))));
                                                                    yield return (Char)(temp307);
                                                                    var temp308 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10U))));
                                                                    var temp309 = ((uint)((int)((uint)(temp308)) % (int)((uint)((uint)10U))));
                                                                    var temp310 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp309)))))));
                                                                    yield return (Char)(temp310);
                                                                    var temp311 = ((uint)((int)((uint)(i)) % (int)((uint)((uint)10U))));
                                                                    var temp312 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp311)))))));
                                                                    yield return (Char)(temp312);
                                                                    yield return (Char)((ushort)41U);
                                                                    yield return (Char)((ushort)59U);
                                                                    yield return (Char)((ushort)10U);
                                                                    goto M0;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                yield return (Char)((ushort)73U);
                                                                yield return (Char)((ushort)78U);
                                                                yield return (Char)((ushort)83U);
                                                                yield return (Char)((ushort)69U);
                                                                yield return (Char)((ushort)82U);
                                                                yield return (Char)((ushort)84U);
                                                                yield return (Char)((ushort)32U);
                                                                yield return (Char)((ushort)73U);
                                                                yield return (Char)((ushort)78U);
                                                                yield return (Char)((ushort)84U);
                                                                yield return (Char)((ushort)79U);
                                                                yield return (Char)((ushort)32U);
                                                                yield return (Char)((ushort)65U);
                                                                yield return (Char)((ushort)99U);
                                                                yield return (Char)((ushort)99U);
                                                                yield return (Char)((ushort)111U);
                                                                yield return (Char)((ushort)117U);
                                                                yield return (Char)((ushort)110U);
                                                                yield return (Char)((ushort)116U);
                                                                yield return (Char)((ushort)115U);
                                                                yield return (Char)((ushort)10U);
                                                                yield return (Char)((ushort)86U);
                                                                yield return (Char)((ushort)65U);
                                                                yield return (Char)((ushort)76U);
                                                                yield return (Char)((ushort)85U);
                                                                yield return (Char)((ushort)69U);
                                                                yield return (Char)((ushort)83U);
                                                                yield return (Char)((ushort)32U);
                                                                yield return (Char)((ushort)40U);
                                                                var temp313 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10000000U))));
                                                                var temp314 = ((uint)((int)((uint)(temp313)) % (int)((uint)((uint)10U))));
                                                                var temp315 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp314)))))));
                                                                yield return (Char)(temp315);
                                                                var temp316 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000000U))));
                                                                var temp317 = ((uint)((int)((uint)(temp316)) % (int)((uint)((uint)10U))));
                                                                var temp318 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp317)))))));
                                                                yield return (Char)(temp318);
                                                                var temp319 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100000U))));
                                                                var temp320 = ((uint)((int)((uint)(temp319)) % (int)((uint)((uint)10U))));
                                                                var temp321 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp320)))))));
                                                                yield return (Char)(temp321);
                                                                var temp322 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10000U))));
                                                                var temp323 = ((uint)((int)((uint)(temp322)) % (int)((uint)((uint)10U))));
                                                                var temp324 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp323)))))));
                                                                yield return (Char)(temp324);
                                                                var temp325 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000U))));
                                                                var temp326 = ((uint)((int)((uint)(temp325)) % (int)((uint)((uint)10U))));
                                                                var temp327 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp326)))))));
                                                                yield return (Char)(temp327);
                                                                var temp328 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100U))));
                                                                var temp329 = ((uint)((int)((uint)(temp328)) % (int)((uint)((uint)10U))));
                                                                var temp330 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp329)))))));
                                                                yield return (Char)(temp330);
                                                                var temp331 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10U))));
                                                                var temp332 = ((uint)((int)((uint)(temp331)) % (int)((uint)((uint)10U))));
                                                                var temp333 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp332)))))));
                                                                yield return (Char)(temp333);
                                                                var temp334 = ((uint)((int)((uint)(i)) % (int)((uint)((uint)10U))));
                                                                var temp335 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp334)))))));
                                                                yield return (Char)(temp335);
                                                                yield return (Char)((ushort)41U);
                                                                yield return (Char)((ushort)59U);
                                                                yield return (Char)((ushort)10U);
                                                                goto M0;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            yield return (Char)((ushort)73U);
                                                            yield return (Char)((ushort)78U);
                                                            yield return (Char)((ushort)83U);
                                                            yield return (Char)((ushort)69U);
                                                            yield return (Char)((ushort)82U);
                                                            yield return (Char)((ushort)84U);
                                                            yield return (Char)((ushort)32U);
                                                            yield return (Char)((ushort)73U);
                                                            yield return (Char)((ushort)78U);
                                                            yield return (Char)((ushort)84U);
                                                            yield return (Char)((ushort)79U);
                                                            yield return (Char)((ushort)32U);
                                                            yield return (Char)((ushort)65U);
                                                            yield return (Char)((ushort)99U);
                                                            yield return (Char)((ushort)99U);
                                                            yield return (Char)((ushort)111U);
                                                            yield return (Char)((ushort)117U);
                                                            yield return (Char)((ushort)110U);
                                                            yield return (Char)((ushort)116U);
                                                            yield return (Char)((ushort)115U);
                                                            yield return (Char)((ushort)10U);
                                                            yield return (Char)((ushort)86U);
                                                            yield return (Char)((ushort)65U);
                                                            yield return (Char)((ushort)76U);
                                                            yield return (Char)((ushort)85U);
                                                            yield return (Char)((ushort)69U);
                                                            yield return (Char)((ushort)83U);
                                                            yield return (Char)((ushort)32U);
                                                            yield return (Char)((ushort)40U);
                                                            var temp336 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000000U))));
                                                            var temp337 = ((uint)((int)((uint)(temp336)) % (int)((uint)((uint)10U))));
                                                            var temp338 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp337)))))));
                                                            yield return (Char)(temp338);
                                                            var temp339 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100000U))));
                                                            var temp340 = ((uint)((int)((uint)(temp339)) % (int)((uint)((uint)10U))));
                                                            var temp341 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp340)))))));
                                                            yield return (Char)(temp341);
                                                            var temp342 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10000U))));
                                                            var temp343 = ((uint)((int)((uint)(temp342)) % (int)((uint)((uint)10U))));
                                                            var temp344 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp343)))))));
                                                            yield return (Char)(temp344);
                                                            var temp345 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000U))));
                                                            var temp346 = ((uint)((int)((uint)(temp345)) % (int)((uint)((uint)10U))));
                                                            var temp347 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp346)))))));
                                                            yield return (Char)(temp347);
                                                            var temp348 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100U))));
                                                            var temp349 = ((uint)((int)((uint)(temp348)) % (int)((uint)((uint)10U))));
                                                            var temp350 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp349)))))));
                                                            yield return (Char)(temp350);
                                                            var temp351 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10U))));
                                                            var temp352 = ((uint)((int)((uint)(temp351)) % (int)((uint)((uint)10U))));
                                                            var temp353 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp352)))))));
                                                            yield return (Char)(temp353);
                                                            var temp354 = ((uint)((int)((uint)(i)) % (int)((uint)((uint)10U))));
                                                            var temp355 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp354)))))));
                                                            yield return (Char)(temp355);
                                                            yield return (Char)((ushort)41U);
                                                            yield return (Char)((ushort)59U);
                                                            yield return (Char)((ushort)10U);
                                                            goto M0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        yield return (Char)((ushort)73U);
                                                        yield return (Char)((ushort)78U);
                                                        yield return (Char)((ushort)83U);
                                                        yield return (Char)((ushort)69U);
                                                        yield return (Char)((ushort)82U);
                                                        yield return (Char)((ushort)84U);
                                                        yield return (Char)((ushort)32U);
                                                        yield return (Char)((ushort)73U);
                                                        yield return (Char)((ushort)78U);
                                                        yield return (Char)((ushort)84U);
                                                        yield return (Char)((ushort)79U);
                                                        yield return (Char)((ushort)32U);
                                                        yield return (Char)((ushort)65U);
                                                        yield return (Char)((ushort)99U);
                                                        yield return (Char)((ushort)99U);
                                                        yield return (Char)((ushort)111U);
                                                        yield return (Char)((ushort)117U);
                                                        yield return (Char)((ushort)110U);
                                                        yield return (Char)((ushort)116U);
                                                        yield return (Char)((ushort)115U);
                                                        yield return (Char)((ushort)10U);
                                                        yield return (Char)((ushort)86U);
                                                        yield return (Char)((ushort)65U);
                                                        yield return (Char)((ushort)76U);
                                                        yield return (Char)((ushort)85U);
                                                        yield return (Char)((ushort)69U);
                                                        yield return (Char)((ushort)83U);
                                                        yield return (Char)((ushort)32U);
                                                        yield return (Char)((ushort)40U);
                                                        var temp356 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100000U))));
                                                        var temp357 = ((uint)((int)((uint)(temp356)) % (int)((uint)((uint)10U))));
                                                        var temp358 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp357)))))));
                                                        yield return (Char)(temp358);
                                                        var temp359 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10000U))));
                                                        var temp360 = ((uint)((int)((uint)(temp359)) % (int)((uint)((uint)10U))));
                                                        var temp361 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp360)))))));
                                                        yield return (Char)(temp361);
                                                        var temp362 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000U))));
                                                        var temp363 = ((uint)((int)((uint)(temp362)) % (int)((uint)((uint)10U))));
                                                        var temp364 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp363)))))));
                                                        yield return (Char)(temp364);
                                                        var temp365 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100U))));
                                                        var temp366 = ((uint)((int)((uint)(temp365)) % (int)((uint)((uint)10U))));
                                                        var temp367 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp366)))))));
                                                        yield return (Char)(temp367);
                                                        var temp368 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10U))));
                                                        var temp369 = ((uint)((int)((uint)(temp368)) % (int)((uint)((uint)10U))));
                                                        var temp370 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp369)))))));
                                                        yield return (Char)(temp370);
                                                        var temp371 = ((uint)((int)((uint)(i)) % (int)((uint)((uint)10U))));
                                                        var temp372 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp371)))))));
                                                        yield return (Char)(temp372);
                                                        yield return (Char)((ushort)41U);
                                                        yield return (Char)((ushort)59U);
                                                        yield return (Char)((ushort)10U);
                                                        goto M0;
                                                    }
                                                }
                                                else
                                                {
                                                    yield return (Char)((ushort)73U);
                                                    yield return (Char)((ushort)78U);
                                                    yield return (Char)((ushort)83U);
                                                    yield return (Char)((ushort)69U);
                                                    yield return (Char)((ushort)82U);
                                                    yield return (Char)((ushort)84U);
                                                    yield return (Char)((ushort)32U);
                                                    yield return (Char)((ushort)73U);
                                                    yield return (Char)((ushort)78U);
                                                    yield return (Char)((ushort)84U);
                                                    yield return (Char)((ushort)79U);
                                                    yield return (Char)((ushort)32U);
                                                    yield return (Char)((ushort)65U);
                                                    yield return (Char)((ushort)99U);
                                                    yield return (Char)((ushort)99U);
                                                    yield return (Char)((ushort)111U);
                                                    yield return (Char)((ushort)117U);
                                                    yield return (Char)((ushort)110U);
                                                    yield return (Char)((ushort)116U);
                                                    yield return (Char)((ushort)115U);
                                                    yield return (Char)((ushort)10U);
                                                    yield return (Char)((ushort)86U);
                                                    yield return (Char)((ushort)65U);
                                                    yield return (Char)((ushort)76U);
                                                    yield return (Char)((ushort)85U);
                                                    yield return (Char)((ushort)69U);
                                                    yield return (Char)((ushort)83U);
                                                    yield return (Char)((ushort)32U);
                                                    yield return (Char)((ushort)40U);
                                                    var temp373 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10000U))));
                                                    var temp374 = ((uint)((int)((uint)(temp373)) % (int)((uint)((uint)10U))));
                                                    var temp375 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp374)))))));
                                                    yield return (Char)(temp375);
                                                    var temp376 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000U))));
                                                    var temp377 = ((uint)((int)((uint)(temp376)) % (int)((uint)((uint)10U))));
                                                    var temp378 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp377)))))));
                                                    yield return (Char)(temp378);
                                                    var temp379 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100U))));
                                                    var temp380 = ((uint)((int)((uint)(temp379)) % (int)((uint)((uint)10U))));
                                                    var temp381 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp380)))))));
                                                    yield return (Char)(temp381);
                                                    var temp382 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10U))));
                                                    var temp383 = ((uint)((int)((uint)(temp382)) % (int)((uint)((uint)10U))));
                                                    var temp384 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp383)))))));
                                                    yield return (Char)(temp384);
                                                    var temp385 = ((uint)((int)((uint)(i)) % (int)((uint)((uint)10U))));
                                                    var temp386 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp385)))))));
                                                    yield return (Char)(temp386);
                                                    yield return (Char)((ushort)41U);
                                                    yield return (Char)((ushort)59U);
                                                    yield return (Char)((ushort)10U);
                                                    goto M0;
                                                }
                                            }
                                            else
                                            {
                                                yield return (Char)((ushort)73U);
                                                yield return (Char)((ushort)78U);
                                                yield return (Char)((ushort)83U);
                                                yield return (Char)((ushort)69U);
                                                yield return (Char)((ushort)82U);
                                                yield return (Char)((ushort)84U);
                                                yield return (Char)((ushort)32U);
                                                yield return (Char)((ushort)73U);
                                                yield return (Char)((ushort)78U);
                                                yield return (Char)((ushort)84U);
                                                yield return (Char)((ushort)79U);
                                                yield return (Char)((ushort)32U);
                                                yield return (Char)((ushort)65U);
                                                yield return (Char)((ushort)99U);
                                                yield return (Char)((ushort)99U);
                                                yield return (Char)((ushort)111U);
                                                yield return (Char)((ushort)117U);
                                                yield return (Char)((ushort)110U);
                                                yield return (Char)((ushort)116U);
                                                yield return (Char)((ushort)115U);
                                                yield return (Char)((ushort)10U);
                                                yield return (Char)((ushort)86U);
                                                yield return (Char)((ushort)65U);
                                                yield return (Char)((ushort)76U);
                                                yield return (Char)((ushort)85U);
                                                yield return (Char)((ushort)69U);
                                                yield return (Char)((ushort)83U);
                                                yield return (Char)((ushort)32U);
                                                yield return (Char)((ushort)40U);
                                                var temp387 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)1000U))));
                                                var temp388 = ((uint)((int)((uint)(temp387)) % (int)((uint)((uint)10U))));
                                                var temp389 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp388)))))));
                                                yield return (Char)(temp389);
                                                var temp390 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100U))));
                                                var temp391 = ((uint)((int)((uint)(temp390)) % (int)((uint)((uint)10U))));
                                                var temp392 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp391)))))));
                                                yield return (Char)(temp392);
                                                var temp393 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10U))));
                                                var temp394 = ((uint)((int)((uint)(temp393)) % (int)((uint)((uint)10U))));
                                                var temp395 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp394)))))));
                                                yield return (Char)(temp395);
                                                var temp396 = ((uint)((int)((uint)(i)) % (int)((uint)((uint)10U))));
                                                var temp397 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp396)))))));
                                                yield return (Char)(temp397);
                                                yield return (Char)((ushort)41U);
                                                yield return (Char)((ushort)59U);
                                                yield return (Char)((ushort)10U);
                                                goto M0;
                                            }
                                        }
                                        else
                                        {
                                            yield return (Char)((ushort)73U);
                                            yield return (Char)((ushort)78U);
                                            yield return (Char)((ushort)83U);
                                            yield return (Char)((ushort)69U);
                                            yield return (Char)((ushort)82U);
                                            yield return (Char)((ushort)84U);
                                            yield return (Char)((ushort)32U);
                                            yield return (Char)((ushort)73U);
                                            yield return (Char)((ushort)78U);
                                            yield return (Char)((ushort)84U);
                                            yield return (Char)((ushort)79U);
                                            yield return (Char)((ushort)32U);
                                            yield return (Char)((ushort)65U);
                                            yield return (Char)((ushort)99U);
                                            yield return (Char)((ushort)99U);
                                            yield return (Char)((ushort)111U);
                                            yield return (Char)((ushort)117U);
                                            yield return (Char)((ushort)110U);
                                            yield return (Char)((ushort)116U);
                                            yield return (Char)((ushort)115U);
                                            yield return (Char)((ushort)10U);
                                            yield return (Char)((ushort)86U);
                                            yield return (Char)((ushort)65U);
                                            yield return (Char)((ushort)76U);
                                            yield return (Char)((ushort)85U);
                                            yield return (Char)((ushort)69U);
                                            yield return (Char)((ushort)83U);
                                            yield return (Char)((ushort)32U);
                                            yield return (Char)((ushort)40U);
                                            var temp398 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)100U))));
                                            var temp399 = ((uint)((int)((uint)(temp398)) % (int)((uint)((uint)10U))));
                                            var temp400 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp399)))))));
                                            yield return (Char)(temp400);
                                            var temp401 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10U))));
                                            var temp402 = ((uint)((int)((uint)(temp401)) % (int)((uint)((uint)10U))));
                                            var temp403 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp402)))))));
                                            yield return (Char)(temp403);
                                            var temp404 = ((uint)((int)((uint)(i)) % (int)((uint)((uint)10U))));
                                            var temp405 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp404)))))));
                                            yield return (Char)(temp405);
                                            yield return (Char)((ushort)41U);
                                            yield return (Char)((ushort)59U);
                                            yield return (Char)((ushort)10U);
                                            goto M0;
                                        }
                                    }
                                    else
                                    {
                                        yield return (Char)((ushort)73U);
                                        yield return (Char)((ushort)78U);
                                        yield return (Char)((ushort)83U);
                                        yield return (Char)((ushort)69U);
                                        yield return (Char)((ushort)82U);
                                        yield return (Char)((ushort)84U);
                                        yield return (Char)((ushort)32U);
                                        yield return (Char)((ushort)73U);
                                        yield return (Char)((ushort)78U);
                                        yield return (Char)((ushort)84U);
                                        yield return (Char)((ushort)79U);
                                        yield return (Char)((ushort)32U);
                                        yield return (Char)((ushort)65U);
                                        yield return (Char)((ushort)99U);
                                        yield return (Char)((ushort)99U);
                                        yield return (Char)((ushort)111U);
                                        yield return (Char)((ushort)117U);
                                        yield return (Char)((ushort)110U);
                                        yield return (Char)((ushort)116U);
                                        yield return (Char)((ushort)115U);
                                        yield return (Char)((ushort)10U);
                                        yield return (Char)((ushort)86U);
                                        yield return (Char)((ushort)65U);
                                        yield return (Char)((ushort)76U);
                                        yield return (Char)((ushort)85U);
                                        yield return (Char)((ushort)69U);
                                        yield return (Char)((ushort)83U);
                                        yield return (Char)((ushort)32U);
                                        yield return (Char)((ushort)40U);
                                        var temp406 = ((uint)((int)((uint)(i)) / (int)((uint)((uint)10U))));
                                        var temp407 = ((uint)((int)((uint)(temp406)) % (int)((uint)((uint)10U))));
                                        var temp408 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp407)))))));
                                        yield return (Char)(temp408);
                                        var temp409 = ((uint)((int)((uint)(i)) % (int)((uint)((uint)10U))));
                                        var temp410 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp409)))))));
                                        yield return (Char)(temp410);
                                        yield return (Char)((ushort)41U);
                                        yield return (Char)((ushort)59U);
                                        yield return (Char)((ushort)10U);
                                        goto M0;
                                    }
                                }
                                else
                                {
                                    yield return (Char)((ushort)73U);
                                    yield return (Char)((ushort)78U);
                                    yield return (Char)((ushort)83U);
                                    yield return (Char)((ushort)69U);
                                    yield return (Char)((ushort)82U);
                                    yield return (Char)((ushort)84U);
                                    yield return (Char)((ushort)32U);
                                    yield return (Char)((ushort)73U);
                                    yield return (Char)((ushort)78U);
                                    yield return (Char)((ushort)84U);
                                    yield return (Char)((ushort)79U);
                                    yield return (Char)((ushort)32U);
                                    yield return (Char)((ushort)65U);
                                    yield return (Char)((ushort)99U);
                                    yield return (Char)((ushort)99U);
                                    yield return (Char)((ushort)111U);
                                    yield return (Char)((ushort)117U);
                                    yield return (Char)((ushort)110U);
                                    yield return (Char)((ushort)116U);
                                    yield return (Char)((ushort)115U);
                                    yield return (Char)((ushort)10U);
                                    yield return (Char)((ushort)86U);
                                    yield return (Char)((ushort)65U);
                                    yield return (Char)((ushort)76U);
                                    yield return (Char)((ushort)85U);
                                    yield return (Char)((ushort)69U);
                                    yield return (Char)((ushort)83U);
                                    yield return (Char)((ushort)32U);
                                    yield return (Char)((ushort)40U);
                                    var temp411 = ((uint)((int)((uint)(i)) % (int)((uint)((uint)10U))));
                                    var temp412 = ((ushort)(((ushort)((ushort)48U)) + ((ushort)(((ushort)((uint)(temp411)))))));
                                    yield return (Char)(temp412);
                                    yield return (Char)((ushort)41U);
                                    yield return (Char)((ushort)59U);
                                    yield return (Char)((ushort)10U);
                                    goto M0;
                                }
                            }
                        }
                    }
                }

                F0:
                {
                    yield break;
                }
            }
        }
    }
}