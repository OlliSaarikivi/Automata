using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class B64FormattedDeltaUTF8 : Composition<B64ToInts, FormattedDeltaUTF8>
    {
        static UInt32 Fun0(Byte v0)
        {
            return (UInt32)(((((((int)((uint)((uint)65U)) <= (int)((uint)(((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(v0)))))) && (((int)((uint)(((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(v0)))) <= (int)((uint)((uint)90U)))))) ? ((uint)(((uint)(((uint)((uint)4294967231U)) + ((uint)(((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(v0)))))))) : ((uint)(((((((int)((uint)((uint)97U)) <= (int)((uint)(((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(v0)))))) && (((int)((uint)(((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(v0)))) <= (int)((uint)((uint)122U)))))) ? ((uint)(((uint)(((uint)((uint)4294967225U)) + ((uint)(((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(v0)))))))) : ((uint)(((((((int)((uint)((uint)48U)) <= (int)((uint)(((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(v0)))))) && (((int)((uint)(((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(v0)))) <= (int)((uint)((uint)57U)))))) ? ((uint)(((uint)(((uint)((uint)4U)) + ((uint)(((uint)((uint)((uint)0U & 16777215L)) << 8) | (uint)((byte)(v0)))))))) : ((uint)((((((byte)(v0)) == ((byte)((byte)43U)))) ? ((uint)((uint)62U)) : ((uint)((uint)63U)))))))))))));
        }

        static UInt32 Fun1(UInt64 v0)
        {
            return (UInt32)(((((long)((ulong)(v0)) <= (long)((ulong)((ulong)999999999UL)))) ? ((uint)(((((long)((ulong)(v0)) <= (long)((ulong)((ulong)99999999UL)))) ? ((uint)(((((long)((ulong)(v0)) <= (long)((ulong)((ulong)9999999UL)))) ? ((uint)(((((long)((ulong)(v0)) <= (long)((ulong)((ulong)999999UL)))) ? ((uint)(((((long)((ulong)(v0)) <= (long)((ulong)((ulong)99999UL)))) ? ((uint)(((((long)((ulong)(v0)) <= (long)((ulong)((ulong)9999UL)))) ? ((uint)(((((long)((ulong)(v0)) <= (long)((ulong)((ulong)999UL)))) ? ((uint)(((((long)((ulong)(v0)) <= (long)((ulong)((ulong)99UL)))) ? ((uint)(((((long)((ulong)(v0)) <= (long)((ulong)((ulong)9UL)))) ? ((uint)((uint)1U)) : ((uint)((uint)2U))))) : ((uint)((uint)3U))))) : ((uint)((uint)4U))))) : ((uint)((uint)5U))))) : ((uint)((uint)6U))))) : ((uint)((uint)7U))))) : ((uint)((uint)8U))))) : ((uint)((uint)9U))))) : ((uint)((uint)10U))));
        }

        struct DTStruct0
        {
            public Byte _0;
            public Byte _1;
            public Byte _2;
            public Byte _3;
            public UInt32 _4;
            public DTStruct0(Byte v0, Byte v1, Byte v2, Byte v3, UInt32 v4)
            {
                _0 = v0;
                _1 = v1;
                _2 = v2;
                _3 = v3;
                _4 = v4;
            }
        }

        public static IEnumerable<Byte> Transduce(IEnumerable<Byte> input)
        {
            unchecked
            {
                IEnumerator<Byte> ie = input.GetEnumerator();
                DTStruct0 s = new DTStruct0(((byte)((byte)0U)), ((byte)((byte)0U)), ((byte)((byte)0U)), ((byte)((byte)0U)), ((uint)((uint)0U)));
                Byte i;
                M0:
                {
                    if (!ie.MoveNext())
                        goto F0;
                    i = ie.Current;
                    {
                        var temp0 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp0)
                            throw new Exception();
                        else
                        {
                            var temp1 = Fun0(((byte)(i)));
                            s._0 = ((byte)(((byte)((uint)(temp1)))));
                            goto M1;
                        }
                    }
                }

                M1:
                {
                    if (!ie.MoveNext())
                        goto F1;
                    i = ie.Current;
                    {
                        var temp2 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp2)
                            throw new Exception();
                        else
                        {
                            var temp3 = ((byte)((byte)(((byte)((byte)((s)._0))) & 63L)) << 2);
                            var temp4 = Fun0(((byte)(i)));
                            var temp5 = ((uint)(((int)((uint)(temp4))) >> (int)((uint)((uint)4U))));
                            var temp6 = ((byte)(((byte)(temp3)) | ((byte)(((byte)((uint)(temp5)))))));
                            s._1 = ((byte)(temp6));
                            s._0 = ((byte)(((byte)((uint)(temp4)))));
                            goto M2;
                        }
                    }
                }

                M2:
                {
                    if (!ie.MoveNext())
                        goto F2;
                    i = ie.Current;
                    {
                        var temp7 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp7)
                        {
                            goto M3;
                        }
                        else
                        {
                            var temp8 = ((byte)((byte)(((byte)((byte)((s)._0))) & 15L)) << 4);
                            var temp9 = Fun0(((byte)(i)));
                            var temp10 = ((uint)(((int)((uint)(temp9))) >> (int)((uint)((uint)2U))));
                            var temp11 = ((byte)(((byte)(temp8)) | ((byte)(((byte)((uint)(temp10)))))));
                            s._2 = ((byte)(temp11));
                            s._0 = ((byte)(((byte)((uint)(temp9)))));
                            goto M4;
                        }
                    }
                }

                M3:
                {
                    if (!ie.MoveNext())
                        goto F3;
                    i = ie.Current;
                    {
                        var temp12 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp12)
                        {
                            goto M27;
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
                        var temp13 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp13)
                        {
                            goto M5;
                        }
                        else
                        {
                            var temp14 = ((byte)((byte)(((byte)((byte)((s)._0))) & 3L)) << 6);
                            var temp15 = Fun0(((byte)(i)));
                            var temp16 = ((byte)(((byte)(temp14)) | ((byte)(((byte)((uint)(temp15)))))));
                            s._3 = ((byte)(temp16));
                            s._0 = ((byte)((byte)0U));
                            goto M6;
                        }
                    }
                }

                M5:
                {
                    if (!ie.MoveNext())
                        goto F5;
                    i = ie.Current;
                    throw new Exception();
                }

                M6:
                {
                    if (!ie.MoveNext())
                        goto F6;
                    i = ie.Current;
                    {
                        var temp17 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp17)
                            throw new Exception();
                        else
                        {
                            var temp18 = Fun0(((byte)(i)));
                            s._0 = ((byte)(((byte)((uint)(temp18)))));
                            goto M7;
                        }
                    }
                }

                M7:
                {
                    if (!ie.MoveNext())
                        goto F7;
                    i = ie.Current;
                    {
                        var temp19 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp19)
                            throw new Exception();
                        else
                        {
                            var temp20 = ((byte)((byte)(((byte)((byte)((s)._0))) & 63L)) << 2);
                            var temp21 = Fun0(((byte)(i)));
                            var temp22 = ((uint)(((int)((uint)(temp21))) >> (int)((uint)((uint)4U))));
                            var temp23 = ((byte)(((byte)(temp20)) | ((byte)(((byte)((uint)(temp22)))))));
                            var temp24 = ((((uint)((byte)((s)._1)) << 8) | (uint)((byte)((s)._2)) << 8) | (uint)((byte)((s)._3)) << 8) | (uint)((byte)(temp23));
                            var temp25 = (((uint)(temp24)) == ((uint)((s)._4)));
                            if (temp25)
                            {
                                yield return (Byte)((byte)48U);
                                s._4 = ((uint)(temp24));
                                s._3 = ((byte)((byte)0U));
                                s._2 = ((byte)((byte)0U));
                                s._1 = ((byte)((byte)0U));
                                s._0 = ((byte)(((byte)((uint)(temp21)))));
                                goto M8;
                            }
                            else
                            {
                                var temp26 = ((uint)(((uint)((uint)4294967295U)) * ((uint)((s)._4))));
                                var temp27 = ((uint)(((uint)(temp24)) + ((uint)(temp26))));
                                var temp28 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp27)));
                                var temp29 = !(temp28);
                                if (temp29)
                                {
                                    var temp30 = ((byte)(((uint)(temp27)) >> 31));
                                    var temp31 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 32) | (ulong)((uint)(temp27));
                                    var temp32 = ((ulong)(((ulong)((ulong)18446744073709551615UL)) * ((ulong)(temp31))));
                                    var temp33 = Fun1(((ulong)(temp32)));
                                    var temp34 = ((uint)(((uint)((uint)4294967295U)) + ((uint)(temp33))));
                                    var temp35 = ((int)((uint)(temp34)) <= (int)((uint)((uint)0U)));
                                    var temp36 = !(temp35);
                                    if (temp36)
                                    {
                                        var temp37 = ((int)((uint)(temp34)) <= (int)((uint)((uint)1U)));
                                        var temp38 = !(temp37);
                                        if (temp38)
                                        {
                                            var temp39 = ((int)((uint)(temp34)) <= (int)((uint)((uint)2U)));
                                            var temp40 = !(temp39);
                                            if (temp40)
                                            {
                                                var temp41 = ((int)((uint)(temp34)) <= (int)((uint)((uint)3U)));
                                                var temp42 = !(temp41);
                                                if (temp42)
                                                {
                                                    var temp43 = ((int)((uint)(temp34)) <= (int)((uint)((uint)4U)));
                                                    var temp44 = !(temp43);
                                                    if (temp44)
                                                    {
                                                        var temp45 = ((int)((uint)(temp34)) <= (int)((uint)((uint)5U)));
                                                        var temp46 = !(temp45);
                                                        if (temp46)
                                                        {
                                                            var temp47 = ((int)((uint)(temp34)) <= (int)((uint)((uint)6U)));
                                                            var temp48 = !(temp47);
                                                            if (temp48)
                                                            {
                                                                var temp49 = ((int)((uint)(temp34)) <= (int)((uint)((uint)7U)));
                                                                var temp50 = !(temp49);
                                                                if (temp50)
                                                                {
                                                                    var temp51 = ((int)((uint)(temp34)) <= (int)((uint)((uint)8U)));
                                                                    var temp52 = !(temp51);
                                                                    if (temp52)
                                                                    {
                                                                        yield return (Byte)((byte)45U);
                                                                        var temp53 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000000U))));
                                                                        var temp54 = ((uint)((int)((uint)(temp53)) % (int)((uint)((uint)10U))));
                                                                        var temp55 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp54)))))));
                                                                        var temp56 = ((byte)(((byte)((byte)48U)) + ((byte)(temp55))));
                                                                        yield return (Byte)(temp56);
                                                                        var temp57 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000000U))));
                                                                        var temp58 = ((uint)((int)((uint)(temp57)) % (int)((uint)((uint)10U))));
                                                                        var temp59 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp58)))))));
                                                                        var temp60 = ((byte)(((byte)((byte)48U)) + ((byte)(temp59))));
                                                                        yield return (Byte)(temp60);
                                                                        var temp61 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000000U))));
                                                                        var temp62 = ((uint)((int)((uint)(temp61)) % (int)((uint)((uint)10U))));
                                                                        var temp63 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp62)))))));
                                                                        var temp64 = ((byte)(((byte)((byte)48U)) + ((byte)(temp63))));
                                                                        yield return (Byte)(temp64);
                                                                        var temp65 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                        var temp66 = ((uint)((int)((uint)(temp65)) % (int)((uint)((uint)10U))));
                                                                        var temp67 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp66)))))));
                                                                        var temp68 = ((byte)(((byte)((byte)48U)) + ((byte)(temp67))));
                                                                        yield return (Byte)(temp68);
                                                                        var temp69 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                        var temp70 = ((uint)((int)((uint)(temp69)) % (int)((uint)((uint)10U))));
                                                                        var temp71 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp70)))))));
                                                                        var temp72 = ((byte)(((byte)((byte)48U)) + ((byte)(temp71))));
                                                                        yield return (Byte)(temp72);
                                                                        var temp73 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                        var temp74 = ((uint)((int)((uint)(temp73)) % (int)((uint)((uint)10U))));
                                                                        var temp75 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp74)))))));
                                                                        var temp76 = ((byte)(((byte)((byte)48U)) + ((byte)(temp75))));
                                                                        yield return (Byte)(temp76);
                                                                        var temp77 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                        var temp78 = ((uint)((int)((uint)(temp77)) % (int)((uint)((uint)10U))));
                                                                        var temp79 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp78)))))));
                                                                        var temp80 = ((byte)(((byte)((byte)48U)) + ((byte)(temp79))));
                                                                        yield return (Byte)(temp80);
                                                                        var temp81 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                        var temp82 = ((uint)((int)((uint)(temp81)) % (int)((uint)((uint)10U))));
                                                                        var temp83 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp82)))))));
                                                                        var temp84 = ((byte)(((byte)((byte)48U)) + ((byte)(temp83))));
                                                                        yield return (Byte)(temp84);
                                                                        var temp85 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                        var temp86 = ((uint)((int)((uint)(temp85)) % (int)((uint)((uint)10U))));
                                                                        var temp87 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp86)))))));
                                                                        var temp88 = ((byte)(((byte)((byte)48U)) + ((byte)(temp87))));
                                                                        yield return (Byte)(temp88);
                                                                        var temp89 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                        var temp90 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp89)))))));
                                                                        var temp91 = ((byte)(((byte)((byte)48U)) + ((byte)(temp90))));
                                                                        yield return (Byte)(temp91);
                                                                        yield return (Byte)((byte)10U);
                                                                        s._4 = ((uint)(temp24));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                        goto M8;
                                                                    }
                                                                    else
                                                                    {
                                                                        yield return (Byte)((byte)45U);
                                                                        var temp92 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000000U))));
                                                                        var temp93 = ((uint)((int)((uint)(temp92)) % (int)((uint)((uint)10U))));
                                                                        var temp94 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp93)))))));
                                                                        var temp95 = ((byte)(((byte)((byte)48U)) + ((byte)(temp94))));
                                                                        yield return (Byte)(temp95);
                                                                        var temp96 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000000U))));
                                                                        var temp97 = ((uint)((int)((uint)(temp96)) % (int)((uint)((uint)10U))));
                                                                        var temp98 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp97)))))));
                                                                        var temp99 = ((byte)(((byte)((byte)48U)) + ((byte)(temp98))));
                                                                        yield return (Byte)(temp99);
                                                                        var temp100 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                        var temp101 = ((uint)((int)((uint)(temp100)) % (int)((uint)((uint)10U))));
                                                                        var temp102 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp101)))))));
                                                                        var temp103 = ((byte)(((byte)((byte)48U)) + ((byte)(temp102))));
                                                                        yield return (Byte)(temp103);
                                                                        var temp104 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                        var temp105 = ((uint)((int)((uint)(temp104)) % (int)((uint)((uint)10U))));
                                                                        var temp106 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp105)))))));
                                                                        var temp107 = ((byte)(((byte)((byte)48U)) + ((byte)(temp106))));
                                                                        yield return (Byte)(temp107);
                                                                        var temp108 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                        var temp109 = ((uint)((int)((uint)(temp108)) % (int)((uint)((uint)10U))));
                                                                        var temp110 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp109)))))));
                                                                        var temp111 = ((byte)(((byte)((byte)48U)) + ((byte)(temp110))));
                                                                        yield return (Byte)(temp111);
                                                                        var temp112 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                        var temp113 = ((uint)((int)((uint)(temp112)) % (int)((uint)((uint)10U))));
                                                                        var temp114 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp113)))))));
                                                                        var temp115 = ((byte)(((byte)((byte)48U)) + ((byte)(temp114))));
                                                                        yield return (Byte)(temp115);
                                                                        var temp116 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                        var temp117 = ((uint)((int)((uint)(temp116)) % (int)((uint)((uint)10U))));
                                                                        var temp118 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp117)))))));
                                                                        var temp119 = ((byte)(((byte)((byte)48U)) + ((byte)(temp118))));
                                                                        yield return (Byte)(temp119);
                                                                        var temp120 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                        var temp121 = ((uint)((int)((uint)(temp120)) % (int)((uint)((uint)10U))));
                                                                        var temp122 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp121)))))));
                                                                        var temp123 = ((byte)(((byte)((byte)48U)) + ((byte)(temp122))));
                                                                        yield return (Byte)(temp123);
                                                                        var temp124 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                        var temp125 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp124)))))));
                                                                        var temp126 = ((byte)(((byte)((byte)48U)) + ((byte)(temp125))));
                                                                        yield return (Byte)(temp126);
                                                                        yield return (Byte)((byte)10U);
                                                                        s._4 = ((uint)(temp24));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                        goto M8;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    yield return (Byte)((byte)45U);
                                                                    var temp127 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000000U))));
                                                                    var temp128 = ((uint)((int)((uint)(temp127)) % (int)((uint)((uint)10U))));
                                                                    var temp129 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp128)))))));
                                                                    var temp130 = ((byte)(((byte)((byte)48U)) + ((byte)(temp129))));
                                                                    yield return (Byte)(temp130);
                                                                    var temp131 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                    var temp132 = ((uint)((int)((uint)(temp131)) % (int)((uint)((uint)10U))));
                                                                    var temp133 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp132)))))));
                                                                    var temp134 = ((byte)(((byte)((byte)48U)) + ((byte)(temp133))));
                                                                    yield return (Byte)(temp134);
                                                                    var temp135 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                    var temp136 = ((uint)((int)((uint)(temp135)) % (int)((uint)((uint)10U))));
                                                                    var temp137 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp136)))))));
                                                                    var temp138 = ((byte)(((byte)((byte)48U)) + ((byte)(temp137))));
                                                                    yield return (Byte)(temp138);
                                                                    var temp139 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                    var temp140 = ((uint)((int)((uint)(temp139)) % (int)((uint)((uint)10U))));
                                                                    var temp141 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp140)))))));
                                                                    var temp142 = ((byte)(((byte)((byte)48U)) + ((byte)(temp141))));
                                                                    yield return (Byte)(temp142);
                                                                    var temp143 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                    var temp144 = ((uint)((int)((uint)(temp143)) % (int)((uint)((uint)10U))));
                                                                    var temp145 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp144)))))));
                                                                    var temp146 = ((byte)(((byte)((byte)48U)) + ((byte)(temp145))));
                                                                    yield return (Byte)(temp146);
                                                                    var temp147 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                    var temp148 = ((uint)((int)((uint)(temp147)) % (int)((uint)((uint)10U))));
                                                                    var temp149 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp148)))))));
                                                                    var temp150 = ((byte)(((byte)((byte)48U)) + ((byte)(temp149))));
                                                                    yield return (Byte)(temp150);
                                                                    var temp151 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                    var temp152 = ((uint)((int)((uint)(temp151)) % (int)((uint)((uint)10U))));
                                                                    var temp153 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp152)))))));
                                                                    var temp154 = ((byte)(((byte)((byte)48U)) + ((byte)(temp153))));
                                                                    yield return (Byte)(temp154);
                                                                    var temp155 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                    var temp156 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp155)))))));
                                                                    var temp157 = ((byte)(((byte)((byte)48U)) + ((byte)(temp156))));
                                                                    yield return (Byte)(temp157);
                                                                    yield return (Byte)((byte)10U);
                                                                    s._4 = ((uint)(temp24));
                                                                    s._3 = ((byte)((byte)0U));
                                                                    s._2 = ((byte)((byte)0U));
                                                                    s._1 = ((byte)((byte)0U));
                                                                    s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                    goto M8;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                yield return (Byte)((byte)45U);
                                                                var temp158 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                var temp159 = ((uint)((int)((uint)(temp158)) % (int)((uint)((uint)10U))));
                                                                var temp160 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp159)))))));
                                                                var temp161 = ((byte)(((byte)((byte)48U)) + ((byte)(temp160))));
                                                                yield return (Byte)(temp161);
                                                                var temp162 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                var temp163 = ((uint)((int)((uint)(temp162)) % (int)((uint)((uint)10U))));
                                                                var temp164 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp163)))))));
                                                                var temp165 = ((byte)(((byte)((byte)48U)) + ((byte)(temp164))));
                                                                yield return (Byte)(temp165);
                                                                var temp166 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                var temp167 = ((uint)((int)((uint)(temp166)) % (int)((uint)((uint)10U))));
                                                                var temp168 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp167)))))));
                                                                var temp169 = ((byte)(((byte)((byte)48U)) + ((byte)(temp168))));
                                                                yield return (Byte)(temp169);
                                                                var temp170 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                var temp171 = ((uint)((int)((uint)(temp170)) % (int)((uint)((uint)10U))));
                                                                var temp172 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp171)))))));
                                                                var temp173 = ((byte)(((byte)((byte)48U)) + ((byte)(temp172))));
                                                                yield return (Byte)(temp173);
                                                                var temp174 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                var temp175 = ((uint)((int)((uint)(temp174)) % (int)((uint)((uint)10U))));
                                                                var temp176 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp175)))))));
                                                                var temp177 = ((byte)(((byte)((byte)48U)) + ((byte)(temp176))));
                                                                yield return (Byte)(temp177);
                                                                var temp178 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                var temp179 = ((uint)((int)((uint)(temp178)) % (int)((uint)((uint)10U))));
                                                                var temp180 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp179)))))));
                                                                var temp181 = ((byte)(((byte)((byte)48U)) + ((byte)(temp180))));
                                                                yield return (Byte)(temp181);
                                                                var temp182 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                var temp183 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp182)))))));
                                                                var temp184 = ((byte)(((byte)((byte)48U)) + ((byte)(temp183))));
                                                                yield return (Byte)(temp184);
                                                                yield return (Byte)((byte)10U);
                                                                s._4 = ((uint)(temp24));
                                                                s._3 = ((byte)((byte)0U));
                                                                s._2 = ((byte)((byte)0U));
                                                                s._1 = ((byte)((byte)0U));
                                                                s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                goto M8;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            yield return (Byte)((byte)45U);
                                                            var temp185 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                            var temp186 = ((uint)((int)((uint)(temp185)) % (int)((uint)((uint)10U))));
                                                            var temp187 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp186)))))));
                                                            var temp188 = ((byte)(((byte)((byte)48U)) + ((byte)(temp187))));
                                                            yield return (Byte)(temp188);
                                                            var temp189 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                            var temp190 = ((uint)((int)((uint)(temp189)) % (int)((uint)((uint)10U))));
                                                            var temp191 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp190)))))));
                                                            var temp192 = ((byte)(((byte)((byte)48U)) + ((byte)(temp191))));
                                                            yield return (Byte)(temp192);
                                                            var temp193 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                            var temp194 = ((uint)((int)((uint)(temp193)) % (int)((uint)((uint)10U))));
                                                            var temp195 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp194)))))));
                                                            var temp196 = ((byte)(((byte)((byte)48U)) + ((byte)(temp195))));
                                                            yield return (Byte)(temp196);
                                                            var temp197 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                            var temp198 = ((uint)((int)((uint)(temp197)) % (int)((uint)((uint)10U))));
                                                            var temp199 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp198)))))));
                                                            var temp200 = ((byte)(((byte)((byte)48U)) + ((byte)(temp199))));
                                                            yield return (Byte)(temp200);
                                                            var temp201 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                            var temp202 = ((uint)((int)((uint)(temp201)) % (int)((uint)((uint)10U))));
                                                            var temp203 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp202)))))));
                                                            var temp204 = ((byte)(((byte)((byte)48U)) + ((byte)(temp203))));
                                                            yield return (Byte)(temp204);
                                                            var temp205 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                            var temp206 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp205)))))));
                                                            var temp207 = ((byte)(((byte)((byte)48U)) + ((byte)(temp206))));
                                                            yield return (Byte)(temp207);
                                                            yield return (Byte)((byte)10U);
                                                            s._4 = ((uint)(temp24));
                                                            s._3 = ((byte)((byte)0U));
                                                            s._2 = ((byte)((byte)0U));
                                                            s._1 = ((byte)((byte)0U));
                                                            s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                            goto M8;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        yield return (Byte)((byte)45U);
                                                        var temp208 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                        var temp209 = ((uint)((int)((uint)(temp208)) % (int)((uint)((uint)10U))));
                                                        var temp210 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp209)))))));
                                                        var temp211 = ((byte)(((byte)((byte)48U)) + ((byte)(temp210))));
                                                        yield return (Byte)(temp211);
                                                        var temp212 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                        var temp213 = ((uint)((int)((uint)(temp212)) % (int)((uint)((uint)10U))));
                                                        var temp214 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp213)))))));
                                                        var temp215 = ((byte)(((byte)((byte)48U)) + ((byte)(temp214))));
                                                        yield return (Byte)(temp215);
                                                        var temp216 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                        var temp217 = ((uint)((int)((uint)(temp216)) % (int)((uint)((uint)10U))));
                                                        var temp218 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp217)))))));
                                                        var temp219 = ((byte)(((byte)((byte)48U)) + ((byte)(temp218))));
                                                        yield return (Byte)(temp219);
                                                        var temp220 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                        var temp221 = ((uint)((int)((uint)(temp220)) % (int)((uint)((uint)10U))));
                                                        var temp222 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp221)))))));
                                                        var temp223 = ((byte)(((byte)((byte)48U)) + ((byte)(temp222))));
                                                        yield return (Byte)(temp223);
                                                        var temp224 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                        var temp225 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp224)))))));
                                                        var temp226 = ((byte)(((byte)((byte)48U)) + ((byte)(temp225))));
                                                        yield return (Byte)(temp226);
                                                        yield return (Byte)((byte)10U);
                                                        s._4 = ((uint)(temp24));
                                                        s._3 = ((byte)((byte)0U));
                                                        s._2 = ((byte)((byte)0U));
                                                        s._1 = ((byte)((byte)0U));
                                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                        goto M8;
                                                    }
                                                }
                                                else
                                                {
                                                    yield return (Byte)((byte)45U);
                                                    var temp227 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                    var temp228 = ((uint)((int)((uint)(temp227)) % (int)((uint)((uint)10U))));
                                                    var temp229 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp228)))))));
                                                    var temp230 = ((byte)(((byte)((byte)48U)) + ((byte)(temp229))));
                                                    yield return (Byte)(temp230);
                                                    var temp231 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                    var temp232 = ((uint)((int)((uint)(temp231)) % (int)((uint)((uint)10U))));
                                                    var temp233 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp232)))))));
                                                    var temp234 = ((byte)(((byte)((byte)48U)) + ((byte)(temp233))));
                                                    yield return (Byte)(temp234);
                                                    var temp235 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                    var temp236 = ((uint)((int)((uint)(temp235)) % (int)((uint)((uint)10U))));
                                                    var temp237 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp236)))))));
                                                    var temp238 = ((byte)(((byte)((byte)48U)) + ((byte)(temp237))));
                                                    yield return (Byte)(temp238);
                                                    var temp239 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                    var temp240 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp239)))))));
                                                    var temp241 = ((byte)(((byte)((byte)48U)) + ((byte)(temp240))));
                                                    yield return (Byte)(temp241);
                                                    yield return (Byte)((byte)10U);
                                                    s._4 = ((uint)(temp24));
                                                    s._3 = ((byte)((byte)0U));
                                                    s._2 = ((byte)((byte)0U));
                                                    s._1 = ((byte)((byte)0U));
                                                    s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                    goto M8;
                                                }
                                            }
                                            else
                                            {
                                                yield return (Byte)((byte)45U);
                                                var temp242 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                var temp243 = ((uint)((int)((uint)(temp242)) % (int)((uint)((uint)10U))));
                                                var temp244 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp243)))))));
                                                var temp245 = ((byte)(((byte)((byte)48U)) + ((byte)(temp244))));
                                                yield return (Byte)(temp245);
                                                var temp246 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                var temp247 = ((uint)((int)((uint)(temp246)) % (int)((uint)((uint)10U))));
                                                var temp248 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp247)))))));
                                                var temp249 = ((byte)(((byte)((byte)48U)) + ((byte)(temp248))));
                                                yield return (Byte)(temp249);
                                                var temp250 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                var temp251 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp250)))))));
                                                var temp252 = ((byte)(((byte)((byte)48U)) + ((byte)(temp251))));
                                                yield return (Byte)(temp252);
                                                yield return (Byte)((byte)10U);
                                                s._4 = ((uint)(temp24));
                                                s._3 = ((byte)((byte)0U));
                                                s._2 = ((byte)((byte)0U));
                                                s._1 = ((byte)((byte)0U));
                                                s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                goto M8;
                                            }
                                        }
                                        else
                                        {
                                            yield return (Byte)((byte)45U);
                                            var temp253 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                            var temp254 = ((uint)((int)((uint)(temp253)) % (int)((uint)((uint)10U))));
                                            var temp255 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp254)))))));
                                            var temp256 = ((byte)(((byte)((byte)48U)) + ((byte)(temp255))));
                                            yield return (Byte)(temp256);
                                            var temp257 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                            var temp258 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp257)))))));
                                            var temp259 = ((byte)(((byte)((byte)48U)) + ((byte)(temp258))));
                                            yield return (Byte)(temp259);
                                            yield return (Byte)((byte)10U);
                                            s._4 = ((uint)(temp24));
                                            s._3 = ((byte)((byte)0U));
                                            s._2 = ((byte)((byte)0U));
                                            s._1 = ((byte)((byte)0U));
                                            s._0 = ((byte)(((byte)((uint)(temp21)))));
                                            goto M8;
                                        }
                                    }
                                    else
                                    {
                                        yield return (Byte)((byte)45U);
                                        var temp260 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                        var temp261 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp260)))))));
                                        var temp262 = ((byte)(((byte)((byte)48U)) + ((byte)(temp261))));
                                        yield return (Byte)(temp262);
                                        yield return (Byte)((byte)10U);
                                        s._4 = ((uint)(temp24));
                                        s._3 = ((byte)((byte)0U));
                                        s._2 = ((byte)((byte)0U));
                                        s._1 = ((byte)((byte)0U));
                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                        goto M8;
                                    }
                                }
                                else
                                {
                                    var temp263 = ((byte)(((uint)(temp27)) >> 31));
                                    var temp264 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 32) | (ulong)((uint)(temp27));
                                    var temp265 = Fun1(((ulong)(temp264)));
                                    var temp266 = ((uint)(((uint)((uint)4294967295U)) + ((uint)(temp265))));
                                    var temp267 = ((int)((uint)(temp266)) <= (int)((uint)((uint)0U)));
                                    var temp268 = !(temp267);
                                    if (temp268)
                                    {
                                        var temp269 = ((int)((uint)(temp266)) <= (int)((uint)((uint)1U)));
                                        var temp270 = !(temp269);
                                        if (temp270)
                                        {
                                            var temp271 = ((int)((uint)(temp266)) <= (int)((uint)((uint)2U)));
                                            var temp272 = !(temp271);
                                            if (temp272)
                                            {
                                                var temp273 = ((int)((uint)(temp266)) <= (int)((uint)((uint)3U)));
                                                var temp274 = !(temp273);
                                                if (temp274)
                                                {
                                                    var temp275 = ((int)((uint)(temp266)) <= (int)((uint)((uint)4U)));
                                                    var temp276 = !(temp275);
                                                    if (temp276)
                                                    {
                                                        var temp277 = ((int)((uint)(temp266)) <= (int)((uint)((uint)5U)));
                                                        var temp278 = !(temp277);
                                                        if (temp278)
                                                        {
                                                            var temp279 = ((int)((uint)(temp266)) <= (int)((uint)((uint)6U)));
                                                            var temp280 = !(temp279);
                                                            if (temp280)
                                                            {
                                                                var temp281 = ((int)((uint)(temp266)) <= (int)((uint)((uint)7U)));
                                                                var temp282 = !(temp281);
                                                                if (temp282)
                                                                {
                                                                    var temp283 = ((int)((uint)(temp266)) <= (int)((uint)((uint)8U)));
                                                                    var temp284 = !(temp283);
                                                                    if (temp284)
                                                                    {
                                                                        var temp285 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000000U))));
                                                                        var temp286 = ((uint)((int)((uint)(temp285)) % (int)((uint)((uint)10U))));
                                                                        var temp287 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp286)))))));
                                                                        yield return (Byte)(temp287);
                                                                        var temp288 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000000U))));
                                                                        var temp289 = ((uint)((int)((uint)(temp288)) % (int)((uint)((uint)10U))));
                                                                        var temp290 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp289)))))));
                                                                        yield return (Byte)(temp290);
                                                                        var temp291 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000000U))));
                                                                        var temp292 = ((uint)((int)((uint)(temp291)) % (int)((uint)((uint)10U))));
                                                                        var temp293 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp292)))))));
                                                                        yield return (Byte)(temp293);
                                                                        var temp294 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                        var temp295 = ((uint)((int)((uint)(temp294)) % (int)((uint)((uint)10U))));
                                                                        var temp296 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp295)))))));
                                                                        yield return (Byte)(temp296);
                                                                        var temp297 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                        var temp298 = ((uint)((int)((uint)(temp297)) % (int)((uint)((uint)10U))));
                                                                        var temp299 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp298)))))));
                                                                        yield return (Byte)(temp299);
                                                                        var temp300 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                        var temp301 = ((uint)((int)((uint)(temp300)) % (int)((uint)((uint)10U))));
                                                                        var temp302 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp301)))))));
                                                                        yield return (Byte)(temp302);
                                                                        var temp303 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                        var temp304 = ((uint)((int)((uint)(temp303)) % (int)((uint)((uint)10U))));
                                                                        var temp305 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp304)))))));
                                                                        yield return (Byte)(temp305);
                                                                        var temp306 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                        var temp307 = ((uint)((int)((uint)(temp306)) % (int)((uint)((uint)10U))));
                                                                        var temp308 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp307)))))));
                                                                        yield return (Byte)(temp308);
                                                                        var temp309 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                        var temp310 = ((uint)((int)((uint)(temp309)) % (int)((uint)((uint)10U))));
                                                                        var temp311 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp310)))))));
                                                                        yield return (Byte)(temp311);
                                                                        var temp312 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                        var temp313 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp312)))))));
                                                                        yield return (Byte)(temp313);
                                                                        yield return (Byte)((byte)10U);
                                                                        s._4 = ((uint)(temp24));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                        goto M8;
                                                                    }
                                                                    else
                                                                    {
                                                                        var temp314 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000000U))));
                                                                        var temp315 = ((uint)((int)((uint)(temp314)) % (int)((uint)((uint)10U))));
                                                                        var temp316 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp315)))))));
                                                                        yield return (Byte)(temp316);
                                                                        var temp317 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000000U))));
                                                                        var temp318 = ((uint)((int)((uint)(temp317)) % (int)((uint)((uint)10U))));
                                                                        var temp319 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp318)))))));
                                                                        yield return (Byte)(temp319);
                                                                        var temp320 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                        var temp321 = ((uint)((int)((uint)(temp320)) % (int)((uint)((uint)10U))));
                                                                        var temp322 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp321)))))));
                                                                        yield return (Byte)(temp322);
                                                                        var temp323 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                        var temp324 = ((uint)((int)((uint)(temp323)) % (int)((uint)((uint)10U))));
                                                                        var temp325 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp324)))))));
                                                                        yield return (Byte)(temp325);
                                                                        var temp326 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                        var temp327 = ((uint)((int)((uint)(temp326)) % (int)((uint)((uint)10U))));
                                                                        var temp328 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp327)))))));
                                                                        yield return (Byte)(temp328);
                                                                        var temp329 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                        var temp330 = ((uint)((int)((uint)(temp329)) % (int)((uint)((uint)10U))));
                                                                        var temp331 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp330)))))));
                                                                        yield return (Byte)(temp331);
                                                                        var temp332 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                        var temp333 = ((uint)((int)((uint)(temp332)) % (int)((uint)((uint)10U))));
                                                                        var temp334 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp333)))))));
                                                                        yield return (Byte)(temp334);
                                                                        var temp335 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                        var temp336 = ((uint)((int)((uint)(temp335)) % (int)((uint)((uint)10U))));
                                                                        var temp337 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp336)))))));
                                                                        yield return (Byte)(temp337);
                                                                        var temp338 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                        var temp339 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp338)))))));
                                                                        yield return (Byte)(temp339);
                                                                        yield return (Byte)((byte)10U);
                                                                        s._4 = ((uint)(temp24));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                        goto M8;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    var temp340 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000000U))));
                                                                    var temp341 = ((uint)((int)((uint)(temp340)) % (int)((uint)((uint)10U))));
                                                                    var temp342 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp341)))))));
                                                                    yield return (Byte)(temp342);
                                                                    var temp343 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                    var temp344 = ((uint)((int)((uint)(temp343)) % (int)((uint)((uint)10U))));
                                                                    var temp345 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp344)))))));
                                                                    yield return (Byte)(temp345);
                                                                    var temp346 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                    var temp347 = ((uint)((int)((uint)(temp346)) % (int)((uint)((uint)10U))));
                                                                    var temp348 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp347)))))));
                                                                    yield return (Byte)(temp348);
                                                                    var temp349 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                    var temp350 = ((uint)((int)((uint)(temp349)) % (int)((uint)((uint)10U))));
                                                                    var temp351 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp350)))))));
                                                                    yield return (Byte)(temp351);
                                                                    var temp352 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                    var temp353 = ((uint)((int)((uint)(temp352)) % (int)((uint)((uint)10U))));
                                                                    var temp354 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp353)))))));
                                                                    yield return (Byte)(temp354);
                                                                    var temp355 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                    var temp356 = ((uint)((int)((uint)(temp355)) % (int)((uint)((uint)10U))));
                                                                    var temp357 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp356)))))));
                                                                    yield return (Byte)(temp357);
                                                                    var temp358 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                    var temp359 = ((uint)((int)((uint)(temp358)) % (int)((uint)((uint)10U))));
                                                                    var temp360 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp359)))))));
                                                                    yield return (Byte)(temp360);
                                                                    var temp361 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                    var temp362 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp361)))))));
                                                                    yield return (Byte)(temp362);
                                                                    yield return (Byte)((byte)10U);
                                                                    s._4 = ((uint)(temp24));
                                                                    s._3 = ((byte)((byte)0U));
                                                                    s._2 = ((byte)((byte)0U));
                                                                    s._1 = ((byte)((byte)0U));
                                                                    s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                    goto M8;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                var temp363 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                var temp364 = ((uint)((int)((uint)(temp363)) % (int)((uint)((uint)10U))));
                                                                var temp365 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp364)))))));
                                                                yield return (Byte)(temp365);
                                                                var temp366 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                var temp367 = ((uint)((int)((uint)(temp366)) % (int)((uint)((uint)10U))));
                                                                var temp368 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp367)))))));
                                                                yield return (Byte)(temp368);
                                                                var temp369 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                var temp370 = ((uint)((int)((uint)(temp369)) % (int)((uint)((uint)10U))));
                                                                var temp371 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp370)))))));
                                                                yield return (Byte)(temp371);
                                                                var temp372 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                var temp373 = ((uint)((int)((uint)(temp372)) % (int)((uint)((uint)10U))));
                                                                var temp374 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp373)))))));
                                                                yield return (Byte)(temp374);
                                                                var temp375 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                var temp376 = ((uint)((int)((uint)(temp375)) % (int)((uint)((uint)10U))));
                                                                var temp377 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp376)))))));
                                                                yield return (Byte)(temp377);
                                                                var temp378 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                var temp379 = ((uint)((int)((uint)(temp378)) % (int)((uint)((uint)10U))));
                                                                var temp380 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp379)))))));
                                                                yield return (Byte)(temp380);
                                                                var temp381 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                var temp382 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp381)))))));
                                                                yield return (Byte)(temp382);
                                                                yield return (Byte)((byte)10U);
                                                                s._4 = ((uint)(temp24));
                                                                s._3 = ((byte)((byte)0U));
                                                                s._2 = ((byte)((byte)0U));
                                                                s._1 = ((byte)((byte)0U));
                                                                s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                goto M8;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            var temp383 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                            var temp384 = ((uint)((int)((uint)(temp383)) % (int)((uint)((uint)10U))));
                                                            var temp385 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp384)))))));
                                                            yield return (Byte)(temp385);
                                                            var temp386 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                            var temp387 = ((uint)((int)((uint)(temp386)) % (int)((uint)((uint)10U))));
                                                            var temp388 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp387)))))));
                                                            yield return (Byte)(temp388);
                                                            var temp389 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                            var temp390 = ((uint)((int)((uint)(temp389)) % (int)((uint)((uint)10U))));
                                                            var temp391 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp390)))))));
                                                            yield return (Byte)(temp391);
                                                            var temp392 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                            var temp393 = ((uint)((int)((uint)(temp392)) % (int)((uint)((uint)10U))));
                                                            var temp394 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp393)))))));
                                                            yield return (Byte)(temp394);
                                                            var temp395 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                            var temp396 = ((uint)((int)((uint)(temp395)) % (int)((uint)((uint)10U))));
                                                            var temp397 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp396)))))));
                                                            yield return (Byte)(temp397);
                                                            var temp398 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                            var temp399 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp398)))))));
                                                            yield return (Byte)(temp399);
                                                            yield return (Byte)((byte)10U);
                                                            s._4 = ((uint)(temp24));
                                                            s._3 = ((byte)((byte)0U));
                                                            s._2 = ((byte)((byte)0U));
                                                            s._1 = ((byte)((byte)0U));
                                                            s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                            goto M8;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        var temp400 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                        var temp401 = ((uint)((int)((uint)(temp400)) % (int)((uint)((uint)10U))));
                                                        var temp402 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp401)))))));
                                                        yield return (Byte)(temp402);
                                                        var temp403 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                        var temp404 = ((uint)((int)((uint)(temp403)) % (int)((uint)((uint)10U))));
                                                        var temp405 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp404)))))));
                                                        yield return (Byte)(temp405);
                                                        var temp406 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                        var temp407 = ((uint)((int)((uint)(temp406)) % (int)((uint)((uint)10U))));
                                                        var temp408 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp407)))))));
                                                        yield return (Byte)(temp408);
                                                        var temp409 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                        var temp410 = ((uint)((int)((uint)(temp409)) % (int)((uint)((uint)10U))));
                                                        var temp411 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp410)))))));
                                                        yield return (Byte)(temp411);
                                                        var temp412 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                        var temp413 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp412)))))));
                                                        yield return (Byte)(temp413);
                                                        yield return (Byte)((byte)10U);
                                                        s._4 = ((uint)(temp24));
                                                        s._3 = ((byte)((byte)0U));
                                                        s._2 = ((byte)((byte)0U));
                                                        s._1 = ((byte)((byte)0U));
                                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                        goto M8;
                                                    }
                                                }
                                                else
                                                {
                                                    var temp414 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                    var temp415 = ((uint)((int)((uint)(temp414)) % (int)((uint)((uint)10U))));
                                                    var temp416 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp415)))))));
                                                    yield return (Byte)(temp416);
                                                    var temp417 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                    var temp418 = ((uint)((int)((uint)(temp417)) % (int)((uint)((uint)10U))));
                                                    var temp419 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp418)))))));
                                                    yield return (Byte)(temp419);
                                                    var temp420 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                    var temp421 = ((uint)((int)((uint)(temp420)) % (int)((uint)((uint)10U))));
                                                    var temp422 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp421)))))));
                                                    yield return (Byte)(temp422);
                                                    var temp423 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                    var temp424 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp423)))))));
                                                    yield return (Byte)(temp424);
                                                    yield return (Byte)((byte)10U);
                                                    s._4 = ((uint)(temp24));
                                                    s._3 = ((byte)((byte)0U));
                                                    s._2 = ((byte)((byte)0U));
                                                    s._1 = ((byte)((byte)0U));
                                                    s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                    goto M8;
                                                }
                                            }
                                            else
                                            {
                                                var temp425 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                var temp426 = ((uint)((int)((uint)(temp425)) % (int)((uint)((uint)10U))));
                                                var temp427 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp426)))))));
                                                yield return (Byte)(temp427);
                                                var temp428 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                var temp429 = ((uint)((int)((uint)(temp428)) % (int)((uint)((uint)10U))));
                                                var temp430 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp429)))))));
                                                yield return (Byte)(temp430);
                                                var temp431 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                var temp432 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp431)))))));
                                                yield return (Byte)(temp432);
                                                yield return (Byte)((byte)10U);
                                                s._4 = ((uint)(temp24));
                                                s._3 = ((byte)((byte)0U));
                                                s._2 = ((byte)((byte)0U));
                                                s._1 = ((byte)((byte)0U));
                                                s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                goto M8;
                                            }
                                        }
                                        else
                                        {
                                            var temp433 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                            var temp434 = ((uint)((int)((uint)(temp433)) % (int)((uint)((uint)10U))));
                                            var temp435 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp434)))))));
                                            yield return (Byte)(temp435);
                                            var temp436 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                            var temp437 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp436)))))));
                                            yield return (Byte)(temp437);
                                            yield return (Byte)((byte)10U);
                                            s._4 = ((uint)(temp24));
                                            s._3 = ((byte)((byte)0U));
                                            s._2 = ((byte)((byte)0U));
                                            s._1 = ((byte)((byte)0U));
                                            s._0 = ((byte)(((byte)((uint)(temp21)))));
                                            goto M8;
                                        }
                                    }
                                    else
                                    {
                                        var temp438 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                        var temp439 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp438)))))));
                                        yield return (Byte)(temp439);
                                        yield return (Byte)((byte)10U);
                                        s._4 = ((uint)(temp24));
                                        s._3 = ((byte)((byte)0U));
                                        s._2 = ((byte)((byte)0U));
                                        s._1 = ((byte)((byte)0U));
                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                        goto M8;
                                    }
                                }
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
                        var temp440 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp440)
                        {
                            goto M9;
                        }
                        else
                        {
                            var temp441 = ((byte)((byte)(((byte)((byte)((s)._0))) & 15L)) << 4);
                            var temp442 = Fun0(((byte)(i)));
                            var temp443 = ((uint)(((int)((uint)(temp442))) >> (int)((uint)((uint)2U))));
                            var temp444 = ((byte)(((byte)(temp441)) | ((byte)(((byte)((uint)(temp443)))))));
                            s._1 = ((byte)(temp444));
                            s._0 = ((byte)(((byte)((uint)(temp442)))));
                            goto M10;
                        }
                    }
                }

                M9:
                {
                    if (!ie.MoveNext())
                        goto F9;
                    i = ie.Current;
                    {
                        var temp445 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp445)
                        {
                            goto M26;
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
                        var temp446 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp446)
                        {
                            goto M11;
                        }
                        else
                        {
                            var temp447 = ((byte)((byte)(((byte)((byte)((s)._0))) & 3L)) << 6);
                            var temp448 = Fun0(((byte)(i)));
                            var temp449 = ((byte)(((byte)(temp447)) | ((byte)(((byte)((uint)(temp448)))))));
                            s._2 = ((byte)(temp449));
                            s._0 = ((byte)((byte)0U));
                            goto M12;
                        }
                    }
                }

                M11:
                {
                    if (!ie.MoveNext())
                        goto F11;
                    i = ie.Current;
                    throw new Exception();
                }

                M12:
                {
                    if (!ie.MoveNext())
                        goto F12;
                    i = ie.Current;
                    {
                        var temp450 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp450)
                            throw new Exception();
                        else
                        {
                            var temp451 = Fun0(((byte)(i)));
                            s._0 = ((byte)(((byte)((uint)(temp451)))));
                            goto M13;
                        }
                    }
                }

                M13:
                {
                    if (!ie.MoveNext())
                        goto F13;
                    i = ie.Current;
                    {
                        var temp452 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp452)
                            throw new Exception();
                        else
                        {
                            var temp453 = ((byte)((byte)(((byte)((byte)((s)._0))) & 63L)) << 2);
                            var temp454 = Fun0(((byte)(i)));
                            var temp455 = ((uint)(((int)((uint)(temp454))) >> (int)((uint)((uint)4U))));
                            var temp456 = ((byte)(((byte)(temp453)) | ((byte)(((byte)((uint)(temp455)))))));
                            s._3 = ((byte)(temp456));
                            s._0 = ((byte)(((byte)((uint)(temp454)))));
                            goto M14;
                        }
                    }
                }

                M14:
                {
                    if (!ie.MoveNext())
                        goto F14;
                    i = ie.Current;
                    {
                        var temp457 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp457)
                        {
                            goto M15;
                        }
                        else
                        {
                            var temp458 = ((byte)((byte)(((byte)((byte)((s)._0))) & 15L)) << 4);
                            var temp459 = Fun0(((byte)(i)));
                            var temp460 = ((uint)(((int)((uint)(temp459))) >> (int)((uint)((uint)2U))));
                            var temp461 = ((byte)(((byte)(temp458)) | ((byte)(((byte)((uint)(temp460)))))));
                            var temp462 = ((((uint)((byte)((s)._1)) << 8) | (uint)((byte)((s)._2)) << 8) | (uint)((byte)((s)._3)) << 8) | (uint)((byte)(temp461));
                            var temp463 = (((uint)(temp462)) == ((uint)((s)._4)));
                            if (temp463)
                            {
                                yield return (Byte)((byte)48U);
                                s._4 = ((uint)(temp462));
                                s._3 = ((byte)((byte)0U));
                                s._2 = ((byte)((byte)0U));
                                s._1 = ((byte)((byte)0U));
                                s._0 = ((byte)(((byte)((uint)(temp459)))));
                                goto M16;
                            }
                            else
                            {
                                var temp464 = ((uint)(((uint)((uint)4294967295U)) * ((uint)((s)._4))));
                                var temp465 = ((uint)(((uint)(temp462)) + ((uint)(temp464))));
                                var temp466 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp465)));
                                var temp467 = !(temp466);
                                if (temp467)
                                {
                                    var temp468 = ((byte)(((uint)(temp465)) >> 31));
                                    var temp469 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 32) | (ulong)((uint)(temp465));
                                    var temp470 = ((ulong)(((ulong)((ulong)18446744073709551615UL)) * ((ulong)(temp469))));
                                    var temp471 = Fun1(((ulong)(temp470)));
                                    var temp472 = ((uint)(((uint)((uint)4294967295U)) + ((uint)(temp471))));
                                    var temp473 = ((int)((uint)(temp472)) <= (int)((uint)((uint)0U)));
                                    var temp474 = !(temp473);
                                    if (temp474)
                                    {
                                        var temp475 = ((int)((uint)(temp472)) <= (int)((uint)((uint)1U)));
                                        var temp476 = !(temp475);
                                        if (temp476)
                                        {
                                            var temp477 = ((int)((uint)(temp472)) <= (int)((uint)((uint)2U)));
                                            var temp478 = !(temp477);
                                            if (temp478)
                                            {
                                                var temp479 = ((int)((uint)(temp472)) <= (int)((uint)((uint)3U)));
                                                var temp480 = !(temp479);
                                                if (temp480)
                                                {
                                                    var temp481 = ((int)((uint)(temp472)) <= (int)((uint)((uint)4U)));
                                                    var temp482 = !(temp481);
                                                    if (temp482)
                                                    {
                                                        var temp483 = ((int)((uint)(temp472)) <= (int)((uint)((uint)5U)));
                                                        var temp484 = !(temp483);
                                                        if (temp484)
                                                        {
                                                            var temp485 = ((int)((uint)(temp472)) <= (int)((uint)((uint)6U)));
                                                            var temp486 = !(temp485);
                                                            if (temp486)
                                                            {
                                                                var temp487 = ((int)((uint)(temp472)) <= (int)((uint)((uint)7U)));
                                                                var temp488 = !(temp487);
                                                                if (temp488)
                                                                {
                                                                    var temp489 = ((int)((uint)(temp472)) <= (int)((uint)((uint)8U)));
                                                                    var temp490 = !(temp489);
                                                                    if (temp490)
                                                                    {
                                                                        yield return (Byte)((byte)45U);
                                                                        var temp491 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000000U))));
                                                                        var temp492 = ((uint)((int)((uint)(temp491)) % (int)((uint)((uint)10U))));
                                                                        var temp493 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp492)))))));
                                                                        var temp494 = ((byte)(((byte)((byte)48U)) + ((byte)(temp493))));
                                                                        yield return (Byte)(temp494);
                                                                        var temp495 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000000U))));
                                                                        var temp496 = ((uint)((int)((uint)(temp495)) % (int)((uint)((uint)10U))));
                                                                        var temp497 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp496)))))));
                                                                        var temp498 = ((byte)(((byte)((byte)48U)) + ((byte)(temp497))));
                                                                        yield return (Byte)(temp498);
                                                                        var temp499 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000000U))));
                                                                        var temp500 = ((uint)((int)((uint)(temp499)) % (int)((uint)((uint)10U))));
                                                                        var temp501 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp500)))))));
                                                                        var temp502 = ((byte)(((byte)((byte)48U)) + ((byte)(temp501))));
                                                                        yield return (Byte)(temp502);
                                                                        var temp503 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                        var temp504 = ((uint)((int)((uint)(temp503)) % (int)((uint)((uint)10U))));
                                                                        var temp505 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp504)))))));
                                                                        var temp506 = ((byte)(((byte)((byte)48U)) + ((byte)(temp505))));
                                                                        yield return (Byte)(temp506);
                                                                        var temp507 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                        var temp508 = ((uint)((int)((uint)(temp507)) % (int)((uint)((uint)10U))));
                                                                        var temp509 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp508)))))));
                                                                        var temp510 = ((byte)(((byte)((byte)48U)) + ((byte)(temp509))));
                                                                        yield return (Byte)(temp510);
                                                                        var temp511 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                        var temp512 = ((uint)((int)((uint)(temp511)) % (int)((uint)((uint)10U))));
                                                                        var temp513 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp512)))))));
                                                                        var temp514 = ((byte)(((byte)((byte)48U)) + ((byte)(temp513))));
                                                                        yield return (Byte)(temp514);
                                                                        var temp515 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                        var temp516 = ((uint)((int)((uint)(temp515)) % (int)((uint)((uint)10U))));
                                                                        var temp517 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp516)))))));
                                                                        var temp518 = ((byte)(((byte)((byte)48U)) + ((byte)(temp517))));
                                                                        yield return (Byte)(temp518);
                                                                        var temp519 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                        var temp520 = ((uint)((int)((uint)(temp519)) % (int)((uint)((uint)10U))));
                                                                        var temp521 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp520)))))));
                                                                        var temp522 = ((byte)(((byte)((byte)48U)) + ((byte)(temp521))));
                                                                        yield return (Byte)(temp522);
                                                                        var temp523 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                        var temp524 = ((uint)((int)((uint)(temp523)) % (int)((uint)((uint)10U))));
                                                                        var temp525 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp524)))))));
                                                                        var temp526 = ((byte)(((byte)((byte)48U)) + ((byte)(temp525))));
                                                                        yield return (Byte)(temp526);
                                                                        var temp527 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                        var temp528 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp527)))))));
                                                                        var temp529 = ((byte)(((byte)((byte)48U)) + ((byte)(temp528))));
                                                                        yield return (Byte)(temp529);
                                                                        yield return (Byte)((byte)10U);
                                                                        s._4 = ((uint)(temp462));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                        goto M16;
                                                                    }
                                                                    else
                                                                    {
                                                                        yield return (Byte)((byte)45U);
                                                                        var temp530 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000000U))));
                                                                        var temp531 = ((uint)((int)((uint)(temp530)) % (int)((uint)((uint)10U))));
                                                                        var temp532 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp531)))))));
                                                                        var temp533 = ((byte)(((byte)((byte)48U)) + ((byte)(temp532))));
                                                                        yield return (Byte)(temp533);
                                                                        var temp534 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000000U))));
                                                                        var temp535 = ((uint)((int)((uint)(temp534)) % (int)((uint)((uint)10U))));
                                                                        var temp536 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp535)))))));
                                                                        var temp537 = ((byte)(((byte)((byte)48U)) + ((byte)(temp536))));
                                                                        yield return (Byte)(temp537);
                                                                        var temp538 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                        var temp539 = ((uint)((int)((uint)(temp538)) % (int)((uint)((uint)10U))));
                                                                        var temp540 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp539)))))));
                                                                        var temp541 = ((byte)(((byte)((byte)48U)) + ((byte)(temp540))));
                                                                        yield return (Byte)(temp541);
                                                                        var temp542 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                        var temp543 = ((uint)((int)((uint)(temp542)) % (int)((uint)((uint)10U))));
                                                                        var temp544 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp543)))))));
                                                                        var temp545 = ((byte)(((byte)((byte)48U)) + ((byte)(temp544))));
                                                                        yield return (Byte)(temp545);
                                                                        var temp546 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                        var temp547 = ((uint)((int)((uint)(temp546)) % (int)((uint)((uint)10U))));
                                                                        var temp548 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp547)))))));
                                                                        var temp549 = ((byte)(((byte)((byte)48U)) + ((byte)(temp548))));
                                                                        yield return (Byte)(temp549);
                                                                        var temp550 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                        var temp551 = ((uint)((int)((uint)(temp550)) % (int)((uint)((uint)10U))));
                                                                        var temp552 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp551)))))));
                                                                        var temp553 = ((byte)(((byte)((byte)48U)) + ((byte)(temp552))));
                                                                        yield return (Byte)(temp553);
                                                                        var temp554 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                        var temp555 = ((uint)((int)((uint)(temp554)) % (int)((uint)((uint)10U))));
                                                                        var temp556 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp555)))))));
                                                                        var temp557 = ((byte)(((byte)((byte)48U)) + ((byte)(temp556))));
                                                                        yield return (Byte)(temp557);
                                                                        var temp558 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                        var temp559 = ((uint)((int)((uint)(temp558)) % (int)((uint)((uint)10U))));
                                                                        var temp560 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp559)))))));
                                                                        var temp561 = ((byte)(((byte)((byte)48U)) + ((byte)(temp560))));
                                                                        yield return (Byte)(temp561);
                                                                        var temp562 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                        var temp563 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp562)))))));
                                                                        var temp564 = ((byte)(((byte)((byte)48U)) + ((byte)(temp563))));
                                                                        yield return (Byte)(temp564);
                                                                        yield return (Byte)((byte)10U);
                                                                        s._4 = ((uint)(temp462));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                        goto M16;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    yield return (Byte)((byte)45U);
                                                                    var temp565 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000000U))));
                                                                    var temp566 = ((uint)((int)((uint)(temp565)) % (int)((uint)((uint)10U))));
                                                                    var temp567 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp566)))))));
                                                                    var temp568 = ((byte)(((byte)((byte)48U)) + ((byte)(temp567))));
                                                                    yield return (Byte)(temp568);
                                                                    var temp569 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                    var temp570 = ((uint)((int)((uint)(temp569)) % (int)((uint)((uint)10U))));
                                                                    var temp571 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp570)))))));
                                                                    var temp572 = ((byte)(((byte)((byte)48U)) + ((byte)(temp571))));
                                                                    yield return (Byte)(temp572);
                                                                    var temp573 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                    var temp574 = ((uint)((int)((uint)(temp573)) % (int)((uint)((uint)10U))));
                                                                    var temp575 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp574)))))));
                                                                    var temp576 = ((byte)(((byte)((byte)48U)) + ((byte)(temp575))));
                                                                    yield return (Byte)(temp576);
                                                                    var temp577 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                    var temp578 = ((uint)((int)((uint)(temp577)) % (int)((uint)((uint)10U))));
                                                                    var temp579 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp578)))))));
                                                                    var temp580 = ((byte)(((byte)((byte)48U)) + ((byte)(temp579))));
                                                                    yield return (Byte)(temp580);
                                                                    var temp581 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                    var temp582 = ((uint)((int)((uint)(temp581)) % (int)((uint)((uint)10U))));
                                                                    var temp583 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp582)))))));
                                                                    var temp584 = ((byte)(((byte)((byte)48U)) + ((byte)(temp583))));
                                                                    yield return (Byte)(temp584);
                                                                    var temp585 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                    var temp586 = ((uint)((int)((uint)(temp585)) % (int)((uint)((uint)10U))));
                                                                    var temp587 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp586)))))));
                                                                    var temp588 = ((byte)(((byte)((byte)48U)) + ((byte)(temp587))));
                                                                    yield return (Byte)(temp588);
                                                                    var temp589 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                    var temp590 = ((uint)((int)((uint)(temp589)) % (int)((uint)((uint)10U))));
                                                                    var temp591 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp590)))))));
                                                                    var temp592 = ((byte)(((byte)((byte)48U)) + ((byte)(temp591))));
                                                                    yield return (Byte)(temp592);
                                                                    var temp593 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                    var temp594 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp593)))))));
                                                                    var temp595 = ((byte)(((byte)((byte)48U)) + ((byte)(temp594))));
                                                                    yield return (Byte)(temp595);
                                                                    yield return (Byte)((byte)10U);
                                                                    s._4 = ((uint)(temp462));
                                                                    s._3 = ((byte)((byte)0U));
                                                                    s._2 = ((byte)((byte)0U));
                                                                    s._1 = ((byte)((byte)0U));
                                                                    s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                    goto M16;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                yield return (Byte)((byte)45U);
                                                                var temp596 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                var temp597 = ((uint)((int)((uint)(temp596)) % (int)((uint)((uint)10U))));
                                                                var temp598 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp597)))))));
                                                                var temp599 = ((byte)(((byte)((byte)48U)) + ((byte)(temp598))));
                                                                yield return (Byte)(temp599);
                                                                var temp600 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                var temp601 = ((uint)((int)((uint)(temp600)) % (int)((uint)((uint)10U))));
                                                                var temp602 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp601)))))));
                                                                var temp603 = ((byte)(((byte)((byte)48U)) + ((byte)(temp602))));
                                                                yield return (Byte)(temp603);
                                                                var temp604 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                var temp605 = ((uint)((int)((uint)(temp604)) % (int)((uint)((uint)10U))));
                                                                var temp606 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp605)))))));
                                                                var temp607 = ((byte)(((byte)((byte)48U)) + ((byte)(temp606))));
                                                                yield return (Byte)(temp607);
                                                                var temp608 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                var temp609 = ((uint)((int)((uint)(temp608)) % (int)((uint)((uint)10U))));
                                                                var temp610 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp609)))))));
                                                                var temp611 = ((byte)(((byte)((byte)48U)) + ((byte)(temp610))));
                                                                yield return (Byte)(temp611);
                                                                var temp612 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                var temp613 = ((uint)((int)((uint)(temp612)) % (int)((uint)((uint)10U))));
                                                                var temp614 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp613)))))));
                                                                var temp615 = ((byte)(((byte)((byte)48U)) + ((byte)(temp614))));
                                                                yield return (Byte)(temp615);
                                                                var temp616 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                var temp617 = ((uint)((int)((uint)(temp616)) % (int)((uint)((uint)10U))));
                                                                var temp618 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp617)))))));
                                                                var temp619 = ((byte)(((byte)((byte)48U)) + ((byte)(temp618))));
                                                                yield return (Byte)(temp619);
                                                                var temp620 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                var temp621 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp620)))))));
                                                                var temp622 = ((byte)(((byte)((byte)48U)) + ((byte)(temp621))));
                                                                yield return (Byte)(temp622);
                                                                yield return (Byte)((byte)10U);
                                                                s._4 = ((uint)(temp462));
                                                                s._3 = ((byte)((byte)0U));
                                                                s._2 = ((byte)((byte)0U));
                                                                s._1 = ((byte)((byte)0U));
                                                                s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                goto M16;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            yield return (Byte)((byte)45U);
                                                            var temp623 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                            var temp624 = ((uint)((int)((uint)(temp623)) % (int)((uint)((uint)10U))));
                                                            var temp625 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp624)))))));
                                                            var temp626 = ((byte)(((byte)((byte)48U)) + ((byte)(temp625))));
                                                            yield return (Byte)(temp626);
                                                            var temp627 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                            var temp628 = ((uint)((int)((uint)(temp627)) % (int)((uint)((uint)10U))));
                                                            var temp629 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp628)))))));
                                                            var temp630 = ((byte)(((byte)((byte)48U)) + ((byte)(temp629))));
                                                            yield return (Byte)(temp630);
                                                            var temp631 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                            var temp632 = ((uint)((int)((uint)(temp631)) % (int)((uint)((uint)10U))));
                                                            var temp633 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp632)))))));
                                                            var temp634 = ((byte)(((byte)((byte)48U)) + ((byte)(temp633))));
                                                            yield return (Byte)(temp634);
                                                            var temp635 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                            var temp636 = ((uint)((int)((uint)(temp635)) % (int)((uint)((uint)10U))));
                                                            var temp637 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp636)))))));
                                                            var temp638 = ((byte)(((byte)((byte)48U)) + ((byte)(temp637))));
                                                            yield return (Byte)(temp638);
                                                            var temp639 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                            var temp640 = ((uint)((int)((uint)(temp639)) % (int)((uint)((uint)10U))));
                                                            var temp641 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp640)))))));
                                                            var temp642 = ((byte)(((byte)((byte)48U)) + ((byte)(temp641))));
                                                            yield return (Byte)(temp642);
                                                            var temp643 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                            var temp644 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp643)))))));
                                                            var temp645 = ((byte)(((byte)((byte)48U)) + ((byte)(temp644))));
                                                            yield return (Byte)(temp645);
                                                            yield return (Byte)((byte)10U);
                                                            s._4 = ((uint)(temp462));
                                                            s._3 = ((byte)((byte)0U));
                                                            s._2 = ((byte)((byte)0U));
                                                            s._1 = ((byte)((byte)0U));
                                                            s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                            goto M16;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        yield return (Byte)((byte)45U);
                                                        var temp646 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                        var temp647 = ((uint)((int)((uint)(temp646)) % (int)((uint)((uint)10U))));
                                                        var temp648 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp647)))))));
                                                        var temp649 = ((byte)(((byte)((byte)48U)) + ((byte)(temp648))));
                                                        yield return (Byte)(temp649);
                                                        var temp650 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                        var temp651 = ((uint)((int)((uint)(temp650)) % (int)((uint)((uint)10U))));
                                                        var temp652 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp651)))))));
                                                        var temp653 = ((byte)(((byte)((byte)48U)) + ((byte)(temp652))));
                                                        yield return (Byte)(temp653);
                                                        var temp654 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                        var temp655 = ((uint)((int)((uint)(temp654)) % (int)((uint)((uint)10U))));
                                                        var temp656 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp655)))))));
                                                        var temp657 = ((byte)(((byte)((byte)48U)) + ((byte)(temp656))));
                                                        yield return (Byte)(temp657);
                                                        var temp658 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                        var temp659 = ((uint)((int)((uint)(temp658)) % (int)((uint)((uint)10U))));
                                                        var temp660 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp659)))))));
                                                        var temp661 = ((byte)(((byte)((byte)48U)) + ((byte)(temp660))));
                                                        yield return (Byte)(temp661);
                                                        var temp662 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                        var temp663 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp662)))))));
                                                        var temp664 = ((byte)(((byte)((byte)48U)) + ((byte)(temp663))));
                                                        yield return (Byte)(temp664);
                                                        yield return (Byte)((byte)10U);
                                                        s._4 = ((uint)(temp462));
                                                        s._3 = ((byte)((byte)0U));
                                                        s._2 = ((byte)((byte)0U));
                                                        s._1 = ((byte)((byte)0U));
                                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                        goto M16;
                                                    }
                                                }
                                                else
                                                {
                                                    yield return (Byte)((byte)45U);
                                                    var temp665 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                    var temp666 = ((uint)((int)((uint)(temp665)) % (int)((uint)((uint)10U))));
                                                    var temp667 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp666)))))));
                                                    var temp668 = ((byte)(((byte)((byte)48U)) + ((byte)(temp667))));
                                                    yield return (Byte)(temp668);
                                                    var temp669 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                    var temp670 = ((uint)((int)((uint)(temp669)) % (int)((uint)((uint)10U))));
                                                    var temp671 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp670)))))));
                                                    var temp672 = ((byte)(((byte)((byte)48U)) + ((byte)(temp671))));
                                                    yield return (Byte)(temp672);
                                                    var temp673 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                    var temp674 = ((uint)((int)((uint)(temp673)) % (int)((uint)((uint)10U))));
                                                    var temp675 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp674)))))));
                                                    var temp676 = ((byte)(((byte)((byte)48U)) + ((byte)(temp675))));
                                                    yield return (Byte)(temp676);
                                                    var temp677 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                    var temp678 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp677)))))));
                                                    var temp679 = ((byte)(((byte)((byte)48U)) + ((byte)(temp678))));
                                                    yield return (Byte)(temp679);
                                                    yield return (Byte)((byte)10U);
                                                    s._4 = ((uint)(temp462));
                                                    s._3 = ((byte)((byte)0U));
                                                    s._2 = ((byte)((byte)0U));
                                                    s._1 = ((byte)((byte)0U));
                                                    s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                    goto M16;
                                                }
                                            }
                                            else
                                            {
                                                yield return (Byte)((byte)45U);
                                                var temp680 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                var temp681 = ((uint)((int)((uint)(temp680)) % (int)((uint)((uint)10U))));
                                                var temp682 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp681)))))));
                                                var temp683 = ((byte)(((byte)((byte)48U)) + ((byte)(temp682))));
                                                yield return (Byte)(temp683);
                                                var temp684 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                var temp685 = ((uint)((int)((uint)(temp684)) % (int)((uint)((uint)10U))));
                                                var temp686 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp685)))))));
                                                var temp687 = ((byte)(((byte)((byte)48U)) + ((byte)(temp686))));
                                                yield return (Byte)(temp687);
                                                var temp688 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                var temp689 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp688)))))));
                                                var temp690 = ((byte)(((byte)((byte)48U)) + ((byte)(temp689))));
                                                yield return (Byte)(temp690);
                                                yield return (Byte)((byte)10U);
                                                s._4 = ((uint)(temp462));
                                                s._3 = ((byte)((byte)0U));
                                                s._2 = ((byte)((byte)0U));
                                                s._1 = ((byte)((byte)0U));
                                                s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                goto M16;
                                            }
                                        }
                                        else
                                        {
                                            yield return (Byte)((byte)45U);
                                            var temp691 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                            var temp692 = ((uint)((int)((uint)(temp691)) % (int)((uint)((uint)10U))));
                                            var temp693 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp692)))))));
                                            var temp694 = ((byte)(((byte)((byte)48U)) + ((byte)(temp693))));
                                            yield return (Byte)(temp694);
                                            var temp695 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                            var temp696 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp695)))))));
                                            var temp697 = ((byte)(((byte)((byte)48U)) + ((byte)(temp696))));
                                            yield return (Byte)(temp697);
                                            yield return (Byte)((byte)10U);
                                            s._4 = ((uint)(temp462));
                                            s._3 = ((byte)((byte)0U));
                                            s._2 = ((byte)((byte)0U));
                                            s._1 = ((byte)((byte)0U));
                                            s._0 = ((byte)(((byte)((uint)(temp459)))));
                                            goto M16;
                                        }
                                    }
                                    else
                                    {
                                        yield return (Byte)((byte)45U);
                                        var temp698 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                        var temp699 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp698)))))));
                                        var temp700 = ((byte)(((byte)((byte)48U)) + ((byte)(temp699))));
                                        yield return (Byte)(temp700);
                                        yield return (Byte)((byte)10U);
                                        s._4 = ((uint)(temp462));
                                        s._3 = ((byte)((byte)0U));
                                        s._2 = ((byte)((byte)0U));
                                        s._1 = ((byte)((byte)0U));
                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                        goto M16;
                                    }
                                }
                                else
                                {
                                    var temp701 = ((byte)(((uint)(temp465)) >> 31));
                                    var temp702 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 32) | (ulong)((uint)(temp465));
                                    var temp703 = Fun1(((ulong)(temp702)));
                                    var temp704 = ((uint)(((uint)((uint)4294967295U)) + ((uint)(temp703))));
                                    var temp705 = ((int)((uint)(temp704)) <= (int)((uint)((uint)0U)));
                                    var temp706 = !(temp705);
                                    if (temp706)
                                    {
                                        var temp707 = ((int)((uint)(temp704)) <= (int)((uint)((uint)1U)));
                                        var temp708 = !(temp707);
                                        if (temp708)
                                        {
                                            var temp709 = ((int)((uint)(temp704)) <= (int)((uint)((uint)2U)));
                                            var temp710 = !(temp709);
                                            if (temp710)
                                            {
                                                var temp711 = ((int)((uint)(temp704)) <= (int)((uint)((uint)3U)));
                                                var temp712 = !(temp711);
                                                if (temp712)
                                                {
                                                    var temp713 = ((int)((uint)(temp704)) <= (int)((uint)((uint)4U)));
                                                    var temp714 = !(temp713);
                                                    if (temp714)
                                                    {
                                                        var temp715 = ((int)((uint)(temp704)) <= (int)((uint)((uint)5U)));
                                                        var temp716 = !(temp715);
                                                        if (temp716)
                                                        {
                                                            var temp717 = ((int)((uint)(temp704)) <= (int)((uint)((uint)6U)));
                                                            var temp718 = !(temp717);
                                                            if (temp718)
                                                            {
                                                                var temp719 = ((int)((uint)(temp704)) <= (int)((uint)((uint)7U)));
                                                                var temp720 = !(temp719);
                                                                if (temp720)
                                                                {
                                                                    var temp721 = ((int)((uint)(temp704)) <= (int)((uint)((uint)8U)));
                                                                    var temp722 = !(temp721);
                                                                    if (temp722)
                                                                    {
                                                                        var temp723 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000000U))));
                                                                        var temp724 = ((uint)((int)((uint)(temp723)) % (int)((uint)((uint)10U))));
                                                                        var temp725 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp724)))))));
                                                                        yield return (Byte)(temp725);
                                                                        var temp726 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000000U))));
                                                                        var temp727 = ((uint)((int)((uint)(temp726)) % (int)((uint)((uint)10U))));
                                                                        var temp728 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp727)))))));
                                                                        yield return (Byte)(temp728);
                                                                        var temp729 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000000U))));
                                                                        var temp730 = ((uint)((int)((uint)(temp729)) % (int)((uint)((uint)10U))));
                                                                        var temp731 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp730)))))));
                                                                        yield return (Byte)(temp731);
                                                                        var temp732 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                        var temp733 = ((uint)((int)((uint)(temp732)) % (int)((uint)((uint)10U))));
                                                                        var temp734 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp733)))))));
                                                                        yield return (Byte)(temp734);
                                                                        var temp735 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                        var temp736 = ((uint)((int)((uint)(temp735)) % (int)((uint)((uint)10U))));
                                                                        var temp737 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp736)))))));
                                                                        yield return (Byte)(temp737);
                                                                        var temp738 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                        var temp739 = ((uint)((int)((uint)(temp738)) % (int)((uint)((uint)10U))));
                                                                        var temp740 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp739)))))));
                                                                        yield return (Byte)(temp740);
                                                                        var temp741 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                        var temp742 = ((uint)((int)((uint)(temp741)) % (int)((uint)((uint)10U))));
                                                                        var temp743 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp742)))))));
                                                                        yield return (Byte)(temp743);
                                                                        var temp744 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                        var temp745 = ((uint)((int)((uint)(temp744)) % (int)((uint)((uint)10U))));
                                                                        var temp746 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp745)))))));
                                                                        yield return (Byte)(temp746);
                                                                        var temp747 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                        var temp748 = ((uint)((int)((uint)(temp747)) % (int)((uint)((uint)10U))));
                                                                        var temp749 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp748)))))));
                                                                        yield return (Byte)(temp749);
                                                                        var temp750 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                        var temp751 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp750)))))));
                                                                        yield return (Byte)(temp751);
                                                                        yield return (Byte)((byte)10U);
                                                                        s._4 = ((uint)(temp462));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                        goto M16;
                                                                    }
                                                                    else
                                                                    {
                                                                        var temp752 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000000U))));
                                                                        var temp753 = ((uint)((int)((uint)(temp752)) % (int)((uint)((uint)10U))));
                                                                        var temp754 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp753)))))));
                                                                        yield return (Byte)(temp754);
                                                                        var temp755 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000000U))));
                                                                        var temp756 = ((uint)((int)((uint)(temp755)) % (int)((uint)((uint)10U))));
                                                                        var temp757 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp756)))))));
                                                                        yield return (Byte)(temp757);
                                                                        var temp758 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                        var temp759 = ((uint)((int)((uint)(temp758)) % (int)((uint)((uint)10U))));
                                                                        var temp760 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp759)))))));
                                                                        yield return (Byte)(temp760);
                                                                        var temp761 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                        var temp762 = ((uint)((int)((uint)(temp761)) % (int)((uint)((uint)10U))));
                                                                        var temp763 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp762)))))));
                                                                        yield return (Byte)(temp763);
                                                                        var temp764 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                        var temp765 = ((uint)((int)((uint)(temp764)) % (int)((uint)((uint)10U))));
                                                                        var temp766 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp765)))))));
                                                                        yield return (Byte)(temp766);
                                                                        var temp767 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                        var temp768 = ((uint)((int)((uint)(temp767)) % (int)((uint)((uint)10U))));
                                                                        var temp769 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp768)))))));
                                                                        yield return (Byte)(temp769);
                                                                        var temp770 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                        var temp771 = ((uint)((int)((uint)(temp770)) % (int)((uint)((uint)10U))));
                                                                        var temp772 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp771)))))));
                                                                        yield return (Byte)(temp772);
                                                                        var temp773 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                        var temp774 = ((uint)((int)((uint)(temp773)) % (int)((uint)((uint)10U))));
                                                                        var temp775 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp774)))))));
                                                                        yield return (Byte)(temp775);
                                                                        var temp776 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                        var temp777 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp776)))))));
                                                                        yield return (Byte)(temp777);
                                                                        yield return (Byte)((byte)10U);
                                                                        s._4 = ((uint)(temp462));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                        goto M16;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    var temp778 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000000U))));
                                                                    var temp779 = ((uint)((int)((uint)(temp778)) % (int)((uint)((uint)10U))));
                                                                    var temp780 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp779)))))));
                                                                    yield return (Byte)(temp780);
                                                                    var temp781 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                    var temp782 = ((uint)((int)((uint)(temp781)) % (int)((uint)((uint)10U))));
                                                                    var temp783 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp782)))))));
                                                                    yield return (Byte)(temp783);
                                                                    var temp784 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                    var temp785 = ((uint)((int)((uint)(temp784)) % (int)((uint)((uint)10U))));
                                                                    var temp786 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp785)))))));
                                                                    yield return (Byte)(temp786);
                                                                    var temp787 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                    var temp788 = ((uint)((int)((uint)(temp787)) % (int)((uint)((uint)10U))));
                                                                    var temp789 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp788)))))));
                                                                    yield return (Byte)(temp789);
                                                                    var temp790 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                    var temp791 = ((uint)((int)((uint)(temp790)) % (int)((uint)((uint)10U))));
                                                                    var temp792 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp791)))))));
                                                                    yield return (Byte)(temp792);
                                                                    var temp793 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                    var temp794 = ((uint)((int)((uint)(temp793)) % (int)((uint)((uint)10U))));
                                                                    var temp795 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp794)))))));
                                                                    yield return (Byte)(temp795);
                                                                    var temp796 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                    var temp797 = ((uint)((int)((uint)(temp796)) % (int)((uint)((uint)10U))));
                                                                    var temp798 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp797)))))));
                                                                    yield return (Byte)(temp798);
                                                                    var temp799 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                    var temp800 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp799)))))));
                                                                    yield return (Byte)(temp800);
                                                                    yield return (Byte)((byte)10U);
                                                                    s._4 = ((uint)(temp462));
                                                                    s._3 = ((byte)((byte)0U));
                                                                    s._2 = ((byte)((byte)0U));
                                                                    s._1 = ((byte)((byte)0U));
                                                                    s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                    goto M16;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                var temp801 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                var temp802 = ((uint)((int)((uint)(temp801)) % (int)((uint)((uint)10U))));
                                                                var temp803 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp802)))))));
                                                                yield return (Byte)(temp803);
                                                                var temp804 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                var temp805 = ((uint)((int)((uint)(temp804)) % (int)((uint)((uint)10U))));
                                                                var temp806 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp805)))))));
                                                                yield return (Byte)(temp806);
                                                                var temp807 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                var temp808 = ((uint)((int)((uint)(temp807)) % (int)((uint)((uint)10U))));
                                                                var temp809 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp808)))))));
                                                                yield return (Byte)(temp809);
                                                                var temp810 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                var temp811 = ((uint)((int)((uint)(temp810)) % (int)((uint)((uint)10U))));
                                                                var temp812 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp811)))))));
                                                                yield return (Byte)(temp812);
                                                                var temp813 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                var temp814 = ((uint)((int)((uint)(temp813)) % (int)((uint)((uint)10U))));
                                                                var temp815 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp814)))))));
                                                                yield return (Byte)(temp815);
                                                                var temp816 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                var temp817 = ((uint)((int)((uint)(temp816)) % (int)((uint)((uint)10U))));
                                                                var temp818 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp817)))))));
                                                                yield return (Byte)(temp818);
                                                                var temp819 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                var temp820 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp819)))))));
                                                                yield return (Byte)(temp820);
                                                                yield return (Byte)((byte)10U);
                                                                s._4 = ((uint)(temp462));
                                                                s._3 = ((byte)((byte)0U));
                                                                s._2 = ((byte)((byte)0U));
                                                                s._1 = ((byte)((byte)0U));
                                                                s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                goto M16;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            var temp821 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                            var temp822 = ((uint)((int)((uint)(temp821)) % (int)((uint)((uint)10U))));
                                                            var temp823 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp822)))))));
                                                            yield return (Byte)(temp823);
                                                            var temp824 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                            var temp825 = ((uint)((int)((uint)(temp824)) % (int)((uint)((uint)10U))));
                                                            var temp826 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp825)))))));
                                                            yield return (Byte)(temp826);
                                                            var temp827 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                            var temp828 = ((uint)((int)((uint)(temp827)) % (int)((uint)((uint)10U))));
                                                            var temp829 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp828)))))));
                                                            yield return (Byte)(temp829);
                                                            var temp830 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                            var temp831 = ((uint)((int)((uint)(temp830)) % (int)((uint)((uint)10U))));
                                                            var temp832 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp831)))))));
                                                            yield return (Byte)(temp832);
                                                            var temp833 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                            var temp834 = ((uint)((int)((uint)(temp833)) % (int)((uint)((uint)10U))));
                                                            var temp835 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp834)))))));
                                                            yield return (Byte)(temp835);
                                                            var temp836 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                            var temp837 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp836)))))));
                                                            yield return (Byte)(temp837);
                                                            yield return (Byte)((byte)10U);
                                                            s._4 = ((uint)(temp462));
                                                            s._3 = ((byte)((byte)0U));
                                                            s._2 = ((byte)((byte)0U));
                                                            s._1 = ((byte)((byte)0U));
                                                            s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                            goto M16;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        var temp838 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                        var temp839 = ((uint)((int)((uint)(temp838)) % (int)((uint)((uint)10U))));
                                                        var temp840 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp839)))))));
                                                        yield return (Byte)(temp840);
                                                        var temp841 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                        var temp842 = ((uint)((int)((uint)(temp841)) % (int)((uint)((uint)10U))));
                                                        var temp843 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp842)))))));
                                                        yield return (Byte)(temp843);
                                                        var temp844 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                        var temp845 = ((uint)((int)((uint)(temp844)) % (int)((uint)((uint)10U))));
                                                        var temp846 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp845)))))));
                                                        yield return (Byte)(temp846);
                                                        var temp847 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                        var temp848 = ((uint)((int)((uint)(temp847)) % (int)((uint)((uint)10U))));
                                                        var temp849 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp848)))))));
                                                        yield return (Byte)(temp849);
                                                        var temp850 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                        var temp851 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp850)))))));
                                                        yield return (Byte)(temp851);
                                                        yield return (Byte)((byte)10U);
                                                        s._4 = ((uint)(temp462));
                                                        s._3 = ((byte)((byte)0U));
                                                        s._2 = ((byte)((byte)0U));
                                                        s._1 = ((byte)((byte)0U));
                                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                        goto M16;
                                                    }
                                                }
                                                else
                                                {
                                                    var temp852 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                    var temp853 = ((uint)((int)((uint)(temp852)) % (int)((uint)((uint)10U))));
                                                    var temp854 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp853)))))));
                                                    yield return (Byte)(temp854);
                                                    var temp855 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                    var temp856 = ((uint)((int)((uint)(temp855)) % (int)((uint)((uint)10U))));
                                                    var temp857 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp856)))))));
                                                    yield return (Byte)(temp857);
                                                    var temp858 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                    var temp859 = ((uint)((int)((uint)(temp858)) % (int)((uint)((uint)10U))));
                                                    var temp860 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp859)))))));
                                                    yield return (Byte)(temp860);
                                                    var temp861 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                    var temp862 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp861)))))));
                                                    yield return (Byte)(temp862);
                                                    yield return (Byte)((byte)10U);
                                                    s._4 = ((uint)(temp462));
                                                    s._3 = ((byte)((byte)0U));
                                                    s._2 = ((byte)((byte)0U));
                                                    s._1 = ((byte)((byte)0U));
                                                    s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                    goto M16;
                                                }
                                            }
                                            else
                                            {
                                                var temp863 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                var temp864 = ((uint)((int)((uint)(temp863)) % (int)((uint)((uint)10U))));
                                                var temp865 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp864)))))));
                                                yield return (Byte)(temp865);
                                                var temp866 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                var temp867 = ((uint)((int)((uint)(temp866)) % (int)((uint)((uint)10U))));
                                                var temp868 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp867)))))));
                                                yield return (Byte)(temp868);
                                                var temp869 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                var temp870 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp869)))))));
                                                yield return (Byte)(temp870);
                                                yield return (Byte)((byte)10U);
                                                s._4 = ((uint)(temp462));
                                                s._3 = ((byte)((byte)0U));
                                                s._2 = ((byte)((byte)0U));
                                                s._1 = ((byte)((byte)0U));
                                                s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                goto M16;
                                            }
                                        }
                                        else
                                        {
                                            var temp871 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                            var temp872 = ((uint)((int)((uint)(temp871)) % (int)((uint)((uint)10U))));
                                            var temp873 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp872)))))));
                                            yield return (Byte)(temp873);
                                            var temp874 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                            var temp875 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp874)))))));
                                            yield return (Byte)(temp875);
                                            yield return (Byte)((byte)10U);
                                            s._4 = ((uint)(temp462));
                                            s._3 = ((byte)((byte)0U));
                                            s._2 = ((byte)((byte)0U));
                                            s._1 = ((byte)((byte)0U));
                                            s._0 = ((byte)(((byte)((uint)(temp459)))));
                                            goto M16;
                                        }
                                    }
                                    else
                                    {
                                        var temp876 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                        var temp877 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp876)))))));
                                        yield return (Byte)(temp877);
                                        yield return (Byte)((byte)10U);
                                        s._4 = ((uint)(temp462));
                                        s._3 = ((byte)((byte)0U));
                                        s._2 = ((byte)((byte)0U));
                                        s._1 = ((byte)((byte)0U));
                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                        goto M16;
                                    }
                                }
                            }
                        }
                    }
                }

                M15:
                {
                    if (!ie.MoveNext())
                        goto F15;
                    i = ie.Current;
                    {
                        var temp878 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp878)
                        {
                            goto M25;
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
                        var temp879 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp879)
                        {
                            goto M17;
                        }
                        else
                        {
                            var temp880 = ((byte)((byte)(((byte)((byte)((s)._0))) & 3L)) << 6);
                            var temp881 = Fun0(((byte)(i)));
                            var temp882 = ((byte)(((byte)(temp880)) | ((byte)(((byte)((uint)(temp881)))))));
                            s._1 = ((byte)(temp882));
                            s._0 = ((byte)((byte)0U));
                            goto M18;
                        }
                    }
                }

                M17:
                {
                    if (!ie.MoveNext())
                        goto F17;
                    i = ie.Current;
                    throw new Exception();
                }

                M18:
                {
                    if (!ie.MoveNext())
                        goto F18;
                    i = ie.Current;
                    {
                        var temp883 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp883)
                            throw new Exception();
                        else
                        {
                            var temp884 = Fun0(((byte)(i)));
                            s._0 = ((byte)(((byte)((uint)(temp884)))));
                            goto M19;
                        }
                    }
                }

                M19:
                {
                    if (!ie.MoveNext())
                        goto F19;
                    i = ie.Current;
                    {
                        var temp885 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp885)
                            throw new Exception();
                        else
                        {
                            var temp886 = ((byte)((byte)(((byte)((byte)((s)._0))) & 63L)) << 2);
                            var temp887 = Fun0(((byte)(i)));
                            var temp888 = ((uint)(((int)((uint)(temp887))) >> (int)((uint)((uint)4U))));
                            var temp889 = ((byte)(((byte)(temp886)) | ((byte)(((byte)((uint)(temp888)))))));
                            s._2 = ((byte)(temp889));
                            s._0 = ((byte)(((byte)((uint)(temp887)))));
                            goto M20;
                        }
                    }
                }

                M20:
                {
                    if (!ie.MoveNext())
                        goto F20;
                    i = ie.Current;
                    {
                        var temp890 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp890)
                        {
                            goto M21;
                        }
                        else
                        {
                            var temp891 = ((byte)((byte)(((byte)((byte)((s)._0))) & 15L)) << 4);
                            var temp892 = Fun0(((byte)(i)));
                            var temp893 = ((uint)(((int)((uint)(temp892))) >> (int)((uint)((uint)2U))));
                            var temp894 = ((byte)(((byte)(temp891)) | ((byte)(((byte)((uint)(temp893)))))));
                            s._3 = ((byte)(temp894));
                            s._0 = ((byte)(((byte)((uint)(temp892)))));
                            goto M22;
                        }
                    }
                }

                M21:
                {
                    if (!ie.MoveNext())
                        goto F21;
                    i = ie.Current;
                    {
                        var temp895 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp895)
                        {
                            goto M24;
                        }
                        else
                            throw new Exception();
                    }
                }

                M22:
                {
                    if (!ie.MoveNext())
                        goto F22;
                    i = ie.Current;
                    {
                        var temp896 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp896)
                        {
                            goto M23;
                        }
                        else
                        {
                            var temp897 = ((byte)((byte)(((byte)((byte)((s)._0))) & 3L)) << 6);
                            var temp898 = Fun0(((byte)(i)));
                            var temp899 = ((byte)(((byte)(temp897)) | ((byte)(((byte)((uint)(temp898)))))));
                            var temp900 = ((((uint)((byte)((s)._1)) << 8) | (uint)((byte)((s)._2)) << 8) | (uint)((byte)((s)._3)) << 8) | (uint)((byte)(temp899));
                            var temp901 = (((uint)(temp900)) == ((uint)((s)._4)));
                            if (temp901)
                            {
                                yield return (Byte)((byte)48U);
                                s._4 = ((uint)(temp900));
                                s._3 = ((byte)((byte)0U));
                                s._2 = ((byte)((byte)0U));
                                s._1 = ((byte)((byte)0U));
                                s._0 = ((byte)((byte)0U));
                                goto M0;
                            }
                            else
                            {
                                var temp902 = ((uint)(((uint)((uint)4294967295U)) * ((uint)((s)._4))));
                                var temp903 = ((uint)(((uint)(temp900)) + ((uint)(temp902))));
                                var temp904 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp903)));
                                var temp905 = !(temp904);
                                if (temp905)
                                {
                                    var temp906 = ((byte)(((uint)(temp903)) >> 31));
                                    var temp907 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 32) | (ulong)((uint)(temp903));
                                    var temp908 = ((ulong)(((ulong)((ulong)18446744073709551615UL)) * ((ulong)(temp907))));
                                    var temp909 = Fun1(((ulong)(temp908)));
                                    var temp910 = ((uint)(((uint)((uint)4294967295U)) + ((uint)(temp909))));
                                    var temp911 = ((int)((uint)(temp910)) <= (int)((uint)((uint)0U)));
                                    var temp912 = !(temp911);
                                    if (temp912)
                                    {
                                        var temp913 = ((int)((uint)(temp910)) <= (int)((uint)((uint)1U)));
                                        var temp914 = !(temp913);
                                        if (temp914)
                                        {
                                            var temp915 = ((int)((uint)(temp910)) <= (int)((uint)((uint)2U)));
                                            var temp916 = !(temp915);
                                            if (temp916)
                                            {
                                                var temp917 = ((int)((uint)(temp910)) <= (int)((uint)((uint)3U)));
                                                var temp918 = !(temp917);
                                                if (temp918)
                                                {
                                                    var temp919 = ((int)((uint)(temp910)) <= (int)((uint)((uint)4U)));
                                                    var temp920 = !(temp919);
                                                    if (temp920)
                                                    {
                                                        var temp921 = ((int)((uint)(temp910)) <= (int)((uint)((uint)5U)));
                                                        var temp922 = !(temp921);
                                                        if (temp922)
                                                        {
                                                            var temp923 = ((int)((uint)(temp910)) <= (int)((uint)((uint)6U)));
                                                            var temp924 = !(temp923);
                                                            if (temp924)
                                                            {
                                                                var temp925 = ((int)((uint)(temp910)) <= (int)((uint)((uint)7U)));
                                                                var temp926 = !(temp925);
                                                                if (temp926)
                                                                {
                                                                    var temp927 = ((int)((uint)(temp910)) <= (int)((uint)((uint)8U)));
                                                                    var temp928 = !(temp927);
                                                                    if (temp928)
                                                                    {
                                                                        yield return (Byte)((byte)45U);
                                                                        var temp929 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000000U))));
                                                                        var temp930 = ((uint)((int)((uint)(temp929)) % (int)((uint)((uint)10U))));
                                                                        var temp931 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp930)))))));
                                                                        var temp932 = ((byte)(((byte)((byte)48U)) + ((byte)(temp931))));
                                                                        yield return (Byte)(temp932);
                                                                        var temp933 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000000U))));
                                                                        var temp934 = ((uint)((int)((uint)(temp933)) % (int)((uint)((uint)10U))));
                                                                        var temp935 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp934)))))));
                                                                        var temp936 = ((byte)(((byte)((byte)48U)) + ((byte)(temp935))));
                                                                        yield return (Byte)(temp936);
                                                                        var temp937 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000000U))));
                                                                        var temp938 = ((uint)((int)((uint)(temp937)) % (int)((uint)((uint)10U))));
                                                                        var temp939 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp938)))))));
                                                                        var temp940 = ((byte)(((byte)((byte)48U)) + ((byte)(temp939))));
                                                                        yield return (Byte)(temp940);
                                                                        var temp941 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                        var temp942 = ((uint)((int)((uint)(temp941)) % (int)((uint)((uint)10U))));
                                                                        var temp943 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp942)))))));
                                                                        var temp944 = ((byte)(((byte)((byte)48U)) + ((byte)(temp943))));
                                                                        yield return (Byte)(temp944);
                                                                        var temp945 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                        var temp946 = ((uint)((int)((uint)(temp945)) % (int)((uint)((uint)10U))));
                                                                        var temp947 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp946)))))));
                                                                        var temp948 = ((byte)(((byte)((byte)48U)) + ((byte)(temp947))));
                                                                        yield return (Byte)(temp948);
                                                                        var temp949 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                        var temp950 = ((uint)((int)((uint)(temp949)) % (int)((uint)((uint)10U))));
                                                                        var temp951 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp950)))))));
                                                                        var temp952 = ((byte)(((byte)((byte)48U)) + ((byte)(temp951))));
                                                                        yield return (Byte)(temp952);
                                                                        var temp953 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                        var temp954 = ((uint)((int)((uint)(temp953)) % (int)((uint)((uint)10U))));
                                                                        var temp955 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp954)))))));
                                                                        var temp956 = ((byte)(((byte)((byte)48U)) + ((byte)(temp955))));
                                                                        yield return (Byte)(temp956);
                                                                        var temp957 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                        var temp958 = ((uint)((int)((uint)(temp957)) % (int)((uint)((uint)10U))));
                                                                        var temp959 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp958)))))));
                                                                        var temp960 = ((byte)(((byte)((byte)48U)) + ((byte)(temp959))));
                                                                        yield return (Byte)(temp960);
                                                                        var temp961 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                        var temp962 = ((uint)((int)((uint)(temp961)) % (int)((uint)((uint)10U))));
                                                                        var temp963 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp962)))))));
                                                                        var temp964 = ((byte)(((byte)((byte)48U)) + ((byte)(temp963))));
                                                                        yield return (Byte)(temp964);
                                                                        var temp965 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                        var temp966 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp965)))))));
                                                                        var temp967 = ((byte)(((byte)((byte)48U)) + ((byte)(temp966))));
                                                                        yield return (Byte)(temp967);
                                                                        yield return (Byte)((byte)10U);
                                                                        s._4 = ((uint)(temp900));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)((byte)0U));
                                                                        goto M0;
                                                                    }
                                                                    else
                                                                    {
                                                                        yield return (Byte)((byte)45U);
                                                                        var temp968 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000000U))));
                                                                        var temp969 = ((uint)((int)((uint)(temp968)) % (int)((uint)((uint)10U))));
                                                                        var temp970 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp969)))))));
                                                                        var temp971 = ((byte)(((byte)((byte)48U)) + ((byte)(temp970))));
                                                                        yield return (Byte)(temp971);
                                                                        var temp972 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000000U))));
                                                                        var temp973 = ((uint)((int)((uint)(temp972)) % (int)((uint)((uint)10U))));
                                                                        var temp974 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp973)))))));
                                                                        var temp975 = ((byte)(((byte)((byte)48U)) + ((byte)(temp974))));
                                                                        yield return (Byte)(temp975);
                                                                        var temp976 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                        var temp977 = ((uint)((int)((uint)(temp976)) % (int)((uint)((uint)10U))));
                                                                        var temp978 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp977)))))));
                                                                        var temp979 = ((byte)(((byte)((byte)48U)) + ((byte)(temp978))));
                                                                        yield return (Byte)(temp979);
                                                                        var temp980 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                        var temp981 = ((uint)((int)((uint)(temp980)) % (int)((uint)((uint)10U))));
                                                                        var temp982 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp981)))))));
                                                                        var temp983 = ((byte)(((byte)((byte)48U)) + ((byte)(temp982))));
                                                                        yield return (Byte)(temp983);
                                                                        var temp984 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                        var temp985 = ((uint)((int)((uint)(temp984)) % (int)((uint)((uint)10U))));
                                                                        var temp986 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp985)))))));
                                                                        var temp987 = ((byte)(((byte)((byte)48U)) + ((byte)(temp986))));
                                                                        yield return (Byte)(temp987);
                                                                        var temp988 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                        var temp989 = ((uint)((int)((uint)(temp988)) % (int)((uint)((uint)10U))));
                                                                        var temp990 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp989)))))));
                                                                        var temp991 = ((byte)(((byte)((byte)48U)) + ((byte)(temp990))));
                                                                        yield return (Byte)(temp991);
                                                                        var temp992 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                        var temp993 = ((uint)((int)((uint)(temp992)) % (int)((uint)((uint)10U))));
                                                                        var temp994 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp993)))))));
                                                                        var temp995 = ((byte)(((byte)((byte)48U)) + ((byte)(temp994))));
                                                                        yield return (Byte)(temp995);
                                                                        var temp996 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                        var temp997 = ((uint)((int)((uint)(temp996)) % (int)((uint)((uint)10U))));
                                                                        var temp998 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp997)))))));
                                                                        var temp999 = ((byte)(((byte)((byte)48U)) + ((byte)(temp998))));
                                                                        yield return (Byte)(temp999);
                                                                        var temp1000 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                        var temp1001 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1000)))))));
                                                                        var temp1002 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1001))));
                                                                        yield return (Byte)(temp1002);
                                                                        yield return (Byte)((byte)10U);
                                                                        s._4 = ((uint)(temp900));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)((byte)0U));
                                                                        goto M0;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    yield return (Byte)((byte)45U);
                                                                    var temp1003 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000000U))));
                                                                    var temp1004 = ((uint)((int)((uint)(temp1003)) % (int)((uint)((uint)10U))));
                                                                    var temp1005 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1004)))))));
                                                                    var temp1006 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1005))));
                                                                    yield return (Byte)(temp1006);
                                                                    var temp1007 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                    var temp1008 = ((uint)((int)((uint)(temp1007)) % (int)((uint)((uint)10U))));
                                                                    var temp1009 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1008)))))));
                                                                    var temp1010 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1009))));
                                                                    yield return (Byte)(temp1010);
                                                                    var temp1011 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                    var temp1012 = ((uint)((int)((uint)(temp1011)) % (int)((uint)((uint)10U))));
                                                                    var temp1013 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1012)))))));
                                                                    var temp1014 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1013))));
                                                                    yield return (Byte)(temp1014);
                                                                    var temp1015 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                    var temp1016 = ((uint)((int)((uint)(temp1015)) % (int)((uint)((uint)10U))));
                                                                    var temp1017 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1016)))))));
                                                                    var temp1018 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1017))));
                                                                    yield return (Byte)(temp1018);
                                                                    var temp1019 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                    var temp1020 = ((uint)((int)((uint)(temp1019)) % (int)((uint)((uint)10U))));
                                                                    var temp1021 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1020)))))));
                                                                    var temp1022 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1021))));
                                                                    yield return (Byte)(temp1022);
                                                                    var temp1023 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                    var temp1024 = ((uint)((int)((uint)(temp1023)) % (int)((uint)((uint)10U))));
                                                                    var temp1025 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1024)))))));
                                                                    var temp1026 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1025))));
                                                                    yield return (Byte)(temp1026);
                                                                    var temp1027 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                    var temp1028 = ((uint)((int)((uint)(temp1027)) % (int)((uint)((uint)10U))));
                                                                    var temp1029 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1028)))))));
                                                                    var temp1030 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1029))));
                                                                    yield return (Byte)(temp1030);
                                                                    var temp1031 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                    var temp1032 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1031)))))));
                                                                    var temp1033 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1032))));
                                                                    yield return (Byte)(temp1033);
                                                                    yield return (Byte)((byte)10U);
                                                                    s._4 = ((uint)(temp900));
                                                                    s._3 = ((byte)((byte)0U));
                                                                    s._2 = ((byte)((byte)0U));
                                                                    s._1 = ((byte)((byte)0U));
                                                                    s._0 = ((byte)((byte)0U));
                                                                    goto M0;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                yield return (Byte)((byte)45U);
                                                                var temp1034 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                var temp1035 = ((uint)((int)((uint)(temp1034)) % (int)((uint)((uint)10U))));
                                                                var temp1036 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1035)))))));
                                                                var temp1037 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1036))));
                                                                yield return (Byte)(temp1037);
                                                                var temp1038 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                var temp1039 = ((uint)((int)((uint)(temp1038)) % (int)((uint)((uint)10U))));
                                                                var temp1040 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1039)))))));
                                                                var temp1041 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1040))));
                                                                yield return (Byte)(temp1041);
                                                                var temp1042 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                var temp1043 = ((uint)((int)((uint)(temp1042)) % (int)((uint)((uint)10U))));
                                                                var temp1044 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1043)))))));
                                                                var temp1045 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1044))));
                                                                yield return (Byte)(temp1045);
                                                                var temp1046 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                var temp1047 = ((uint)((int)((uint)(temp1046)) % (int)((uint)((uint)10U))));
                                                                var temp1048 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1047)))))));
                                                                var temp1049 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1048))));
                                                                yield return (Byte)(temp1049);
                                                                var temp1050 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                var temp1051 = ((uint)((int)((uint)(temp1050)) % (int)((uint)((uint)10U))));
                                                                var temp1052 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1051)))))));
                                                                var temp1053 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1052))));
                                                                yield return (Byte)(temp1053);
                                                                var temp1054 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                var temp1055 = ((uint)((int)((uint)(temp1054)) % (int)((uint)((uint)10U))));
                                                                var temp1056 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1055)))))));
                                                                var temp1057 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1056))));
                                                                yield return (Byte)(temp1057);
                                                                var temp1058 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                var temp1059 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1058)))))));
                                                                var temp1060 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1059))));
                                                                yield return (Byte)(temp1060);
                                                                yield return (Byte)((byte)10U);
                                                                s._4 = ((uint)(temp900));
                                                                s._3 = ((byte)((byte)0U));
                                                                s._2 = ((byte)((byte)0U));
                                                                s._1 = ((byte)((byte)0U));
                                                                s._0 = ((byte)((byte)0U));
                                                                goto M0;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            yield return (Byte)((byte)45U);
                                                            var temp1061 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                            var temp1062 = ((uint)((int)((uint)(temp1061)) % (int)((uint)((uint)10U))));
                                                            var temp1063 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1062)))))));
                                                            var temp1064 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1063))));
                                                            yield return (Byte)(temp1064);
                                                            var temp1065 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                            var temp1066 = ((uint)((int)((uint)(temp1065)) % (int)((uint)((uint)10U))));
                                                            var temp1067 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1066)))))));
                                                            var temp1068 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1067))));
                                                            yield return (Byte)(temp1068);
                                                            var temp1069 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                            var temp1070 = ((uint)((int)((uint)(temp1069)) % (int)((uint)((uint)10U))));
                                                            var temp1071 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1070)))))));
                                                            var temp1072 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1071))));
                                                            yield return (Byte)(temp1072);
                                                            var temp1073 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                            var temp1074 = ((uint)((int)((uint)(temp1073)) % (int)((uint)((uint)10U))));
                                                            var temp1075 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1074)))))));
                                                            var temp1076 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1075))));
                                                            yield return (Byte)(temp1076);
                                                            var temp1077 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                            var temp1078 = ((uint)((int)((uint)(temp1077)) % (int)((uint)((uint)10U))));
                                                            var temp1079 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1078)))))));
                                                            var temp1080 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1079))));
                                                            yield return (Byte)(temp1080);
                                                            var temp1081 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                            var temp1082 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1081)))))));
                                                            var temp1083 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1082))));
                                                            yield return (Byte)(temp1083);
                                                            yield return (Byte)((byte)10U);
                                                            s._4 = ((uint)(temp900));
                                                            s._3 = ((byte)((byte)0U));
                                                            s._2 = ((byte)((byte)0U));
                                                            s._1 = ((byte)((byte)0U));
                                                            s._0 = ((byte)((byte)0U));
                                                            goto M0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        yield return (Byte)((byte)45U);
                                                        var temp1084 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                        var temp1085 = ((uint)((int)((uint)(temp1084)) % (int)((uint)((uint)10U))));
                                                        var temp1086 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1085)))))));
                                                        var temp1087 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1086))));
                                                        yield return (Byte)(temp1087);
                                                        var temp1088 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                        var temp1089 = ((uint)((int)((uint)(temp1088)) % (int)((uint)((uint)10U))));
                                                        var temp1090 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1089)))))));
                                                        var temp1091 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1090))));
                                                        yield return (Byte)(temp1091);
                                                        var temp1092 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                        var temp1093 = ((uint)((int)((uint)(temp1092)) % (int)((uint)((uint)10U))));
                                                        var temp1094 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1093)))))));
                                                        var temp1095 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1094))));
                                                        yield return (Byte)(temp1095);
                                                        var temp1096 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                        var temp1097 = ((uint)((int)((uint)(temp1096)) % (int)((uint)((uint)10U))));
                                                        var temp1098 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1097)))))));
                                                        var temp1099 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1098))));
                                                        yield return (Byte)(temp1099);
                                                        var temp1100 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                        var temp1101 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1100)))))));
                                                        var temp1102 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1101))));
                                                        yield return (Byte)(temp1102);
                                                        yield return (Byte)((byte)10U);
                                                        s._4 = ((uint)(temp900));
                                                        s._3 = ((byte)((byte)0U));
                                                        s._2 = ((byte)((byte)0U));
                                                        s._1 = ((byte)((byte)0U));
                                                        s._0 = ((byte)((byte)0U));
                                                        goto M0;
                                                    }
                                                }
                                                else
                                                {
                                                    yield return (Byte)((byte)45U);
                                                    var temp1103 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                    var temp1104 = ((uint)((int)((uint)(temp1103)) % (int)((uint)((uint)10U))));
                                                    var temp1105 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1104)))))));
                                                    var temp1106 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1105))));
                                                    yield return (Byte)(temp1106);
                                                    var temp1107 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                    var temp1108 = ((uint)((int)((uint)(temp1107)) % (int)((uint)((uint)10U))));
                                                    var temp1109 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1108)))))));
                                                    var temp1110 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1109))));
                                                    yield return (Byte)(temp1110);
                                                    var temp1111 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                    var temp1112 = ((uint)((int)((uint)(temp1111)) % (int)((uint)((uint)10U))));
                                                    var temp1113 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1112)))))));
                                                    var temp1114 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1113))));
                                                    yield return (Byte)(temp1114);
                                                    var temp1115 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                    var temp1116 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1115)))))));
                                                    var temp1117 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1116))));
                                                    yield return (Byte)(temp1117);
                                                    yield return (Byte)((byte)10U);
                                                    s._4 = ((uint)(temp900));
                                                    s._3 = ((byte)((byte)0U));
                                                    s._2 = ((byte)((byte)0U));
                                                    s._1 = ((byte)((byte)0U));
                                                    s._0 = ((byte)((byte)0U));
                                                    goto M0;
                                                }
                                            }
                                            else
                                            {
                                                yield return (Byte)((byte)45U);
                                                var temp1118 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                var temp1119 = ((uint)((int)((uint)(temp1118)) % (int)((uint)((uint)10U))));
                                                var temp1120 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1119)))))));
                                                var temp1121 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1120))));
                                                yield return (Byte)(temp1121);
                                                var temp1122 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                var temp1123 = ((uint)((int)((uint)(temp1122)) % (int)((uint)((uint)10U))));
                                                var temp1124 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1123)))))));
                                                var temp1125 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1124))));
                                                yield return (Byte)(temp1125);
                                                var temp1126 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                var temp1127 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1126)))))));
                                                var temp1128 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1127))));
                                                yield return (Byte)(temp1128);
                                                yield return (Byte)((byte)10U);
                                                s._4 = ((uint)(temp900));
                                                s._3 = ((byte)((byte)0U));
                                                s._2 = ((byte)((byte)0U));
                                                s._1 = ((byte)((byte)0U));
                                                s._0 = ((byte)((byte)0U));
                                                goto M0;
                                            }
                                        }
                                        else
                                        {
                                            yield return (Byte)((byte)45U);
                                            var temp1129 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                            var temp1130 = ((uint)((int)((uint)(temp1129)) % (int)((uint)((uint)10U))));
                                            var temp1131 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1130)))))));
                                            var temp1132 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1131))));
                                            yield return (Byte)(temp1132);
                                            var temp1133 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                            var temp1134 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1133)))))));
                                            var temp1135 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1134))));
                                            yield return (Byte)(temp1135);
                                            yield return (Byte)((byte)10U);
                                            s._4 = ((uint)(temp900));
                                            s._3 = ((byte)((byte)0U));
                                            s._2 = ((byte)((byte)0U));
                                            s._1 = ((byte)((byte)0U));
                                            s._0 = ((byte)((byte)0U));
                                            goto M0;
                                        }
                                    }
                                    else
                                    {
                                        yield return (Byte)((byte)45U);
                                        var temp1136 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                        var temp1137 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1136)))))));
                                        var temp1138 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1137))));
                                        yield return (Byte)(temp1138);
                                        yield return (Byte)((byte)10U);
                                        s._4 = ((uint)(temp900));
                                        s._3 = ((byte)((byte)0U));
                                        s._2 = ((byte)((byte)0U));
                                        s._1 = ((byte)((byte)0U));
                                        s._0 = ((byte)((byte)0U));
                                        goto M0;
                                    }
                                }
                                else
                                {
                                    var temp1139 = ((byte)(((uint)(temp903)) >> 31));
                                    var temp1140 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 32) | (ulong)((uint)(temp903));
                                    var temp1141 = Fun1(((ulong)(temp1140)));
                                    var temp1142 = ((uint)(((uint)((uint)4294967295U)) + ((uint)(temp1141))));
                                    var temp1143 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)0U)));
                                    var temp1144 = !(temp1143);
                                    if (temp1144)
                                    {
                                        var temp1145 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)1U)));
                                        var temp1146 = !(temp1145);
                                        if (temp1146)
                                        {
                                            var temp1147 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)2U)));
                                            var temp1148 = !(temp1147);
                                            if (temp1148)
                                            {
                                                var temp1149 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)3U)));
                                                var temp1150 = !(temp1149);
                                                if (temp1150)
                                                {
                                                    var temp1151 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)4U)));
                                                    var temp1152 = !(temp1151);
                                                    if (temp1152)
                                                    {
                                                        var temp1153 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)5U)));
                                                        var temp1154 = !(temp1153);
                                                        if (temp1154)
                                                        {
                                                            var temp1155 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)6U)));
                                                            var temp1156 = !(temp1155);
                                                            if (temp1156)
                                                            {
                                                                var temp1157 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)7U)));
                                                                var temp1158 = !(temp1157);
                                                                if (temp1158)
                                                                {
                                                                    var temp1159 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)8U)));
                                                                    var temp1160 = !(temp1159);
                                                                    if (temp1160)
                                                                    {
                                                                        var temp1161 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000000U))));
                                                                        var temp1162 = ((uint)((int)((uint)(temp1161)) % (int)((uint)((uint)10U))));
                                                                        var temp1163 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1162)))))));
                                                                        yield return (Byte)(temp1163);
                                                                        var temp1164 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000000U))));
                                                                        var temp1165 = ((uint)((int)((uint)(temp1164)) % (int)((uint)((uint)10U))));
                                                                        var temp1166 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1165)))))));
                                                                        yield return (Byte)(temp1166);
                                                                        var temp1167 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000000U))));
                                                                        var temp1168 = ((uint)((int)((uint)(temp1167)) % (int)((uint)((uint)10U))));
                                                                        var temp1169 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1168)))))));
                                                                        yield return (Byte)(temp1169);
                                                                        var temp1170 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                        var temp1171 = ((uint)((int)((uint)(temp1170)) % (int)((uint)((uint)10U))));
                                                                        var temp1172 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1171)))))));
                                                                        yield return (Byte)(temp1172);
                                                                        var temp1173 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                        var temp1174 = ((uint)((int)((uint)(temp1173)) % (int)((uint)((uint)10U))));
                                                                        var temp1175 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1174)))))));
                                                                        yield return (Byte)(temp1175);
                                                                        var temp1176 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                        var temp1177 = ((uint)((int)((uint)(temp1176)) % (int)((uint)((uint)10U))));
                                                                        var temp1178 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1177)))))));
                                                                        yield return (Byte)(temp1178);
                                                                        var temp1179 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                        var temp1180 = ((uint)((int)((uint)(temp1179)) % (int)((uint)((uint)10U))));
                                                                        var temp1181 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1180)))))));
                                                                        yield return (Byte)(temp1181);
                                                                        var temp1182 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                        var temp1183 = ((uint)((int)((uint)(temp1182)) % (int)((uint)((uint)10U))));
                                                                        var temp1184 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1183)))))));
                                                                        yield return (Byte)(temp1184);
                                                                        var temp1185 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                        var temp1186 = ((uint)((int)((uint)(temp1185)) % (int)((uint)((uint)10U))));
                                                                        var temp1187 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1186)))))));
                                                                        yield return (Byte)(temp1187);
                                                                        var temp1188 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                        var temp1189 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1188)))))));
                                                                        yield return (Byte)(temp1189);
                                                                        yield return (Byte)((byte)10U);
                                                                        s._4 = ((uint)(temp900));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)((byte)0U));
                                                                        goto M0;
                                                                    }
                                                                    else
                                                                    {
                                                                        var temp1190 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000000U))));
                                                                        var temp1191 = ((uint)((int)((uint)(temp1190)) % (int)((uint)((uint)10U))));
                                                                        var temp1192 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1191)))))));
                                                                        yield return (Byte)(temp1192);
                                                                        var temp1193 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000000U))));
                                                                        var temp1194 = ((uint)((int)((uint)(temp1193)) % (int)((uint)((uint)10U))));
                                                                        var temp1195 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1194)))))));
                                                                        yield return (Byte)(temp1195);
                                                                        var temp1196 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                        var temp1197 = ((uint)((int)((uint)(temp1196)) % (int)((uint)((uint)10U))));
                                                                        var temp1198 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1197)))))));
                                                                        yield return (Byte)(temp1198);
                                                                        var temp1199 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                        var temp1200 = ((uint)((int)((uint)(temp1199)) % (int)((uint)((uint)10U))));
                                                                        var temp1201 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1200)))))));
                                                                        yield return (Byte)(temp1201);
                                                                        var temp1202 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                        var temp1203 = ((uint)((int)((uint)(temp1202)) % (int)((uint)((uint)10U))));
                                                                        var temp1204 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1203)))))));
                                                                        yield return (Byte)(temp1204);
                                                                        var temp1205 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                        var temp1206 = ((uint)((int)((uint)(temp1205)) % (int)((uint)((uint)10U))));
                                                                        var temp1207 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1206)))))));
                                                                        yield return (Byte)(temp1207);
                                                                        var temp1208 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                        var temp1209 = ((uint)((int)((uint)(temp1208)) % (int)((uint)((uint)10U))));
                                                                        var temp1210 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1209)))))));
                                                                        yield return (Byte)(temp1210);
                                                                        var temp1211 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                        var temp1212 = ((uint)((int)((uint)(temp1211)) % (int)((uint)((uint)10U))));
                                                                        var temp1213 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1212)))))));
                                                                        yield return (Byte)(temp1213);
                                                                        var temp1214 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                        var temp1215 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1214)))))));
                                                                        yield return (Byte)(temp1215);
                                                                        yield return (Byte)((byte)10U);
                                                                        s._4 = ((uint)(temp900));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)((byte)0U));
                                                                        goto M0;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    var temp1216 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000000U))));
                                                                    var temp1217 = ((uint)((int)((uint)(temp1216)) % (int)((uint)((uint)10U))));
                                                                    var temp1218 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1217)))))));
                                                                    yield return (Byte)(temp1218);
                                                                    var temp1219 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                    var temp1220 = ((uint)((int)((uint)(temp1219)) % (int)((uint)((uint)10U))));
                                                                    var temp1221 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1220)))))));
                                                                    yield return (Byte)(temp1221);
                                                                    var temp1222 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                    var temp1223 = ((uint)((int)((uint)(temp1222)) % (int)((uint)((uint)10U))));
                                                                    var temp1224 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1223)))))));
                                                                    yield return (Byte)(temp1224);
                                                                    var temp1225 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                    var temp1226 = ((uint)((int)((uint)(temp1225)) % (int)((uint)((uint)10U))));
                                                                    var temp1227 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1226)))))));
                                                                    yield return (Byte)(temp1227);
                                                                    var temp1228 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                    var temp1229 = ((uint)((int)((uint)(temp1228)) % (int)((uint)((uint)10U))));
                                                                    var temp1230 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1229)))))));
                                                                    yield return (Byte)(temp1230);
                                                                    var temp1231 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                    var temp1232 = ((uint)((int)((uint)(temp1231)) % (int)((uint)((uint)10U))));
                                                                    var temp1233 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1232)))))));
                                                                    yield return (Byte)(temp1233);
                                                                    var temp1234 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                    var temp1235 = ((uint)((int)((uint)(temp1234)) % (int)((uint)((uint)10U))));
                                                                    var temp1236 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1235)))))));
                                                                    yield return (Byte)(temp1236);
                                                                    var temp1237 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                    var temp1238 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1237)))))));
                                                                    yield return (Byte)(temp1238);
                                                                    yield return (Byte)((byte)10U);
                                                                    s._4 = ((uint)(temp900));
                                                                    s._3 = ((byte)((byte)0U));
                                                                    s._2 = ((byte)((byte)0U));
                                                                    s._1 = ((byte)((byte)0U));
                                                                    s._0 = ((byte)((byte)0U));
                                                                    goto M0;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                var temp1239 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                var temp1240 = ((uint)((int)((uint)(temp1239)) % (int)((uint)((uint)10U))));
                                                                var temp1241 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1240)))))));
                                                                yield return (Byte)(temp1241);
                                                                var temp1242 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                var temp1243 = ((uint)((int)((uint)(temp1242)) % (int)((uint)((uint)10U))));
                                                                var temp1244 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1243)))))));
                                                                yield return (Byte)(temp1244);
                                                                var temp1245 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                var temp1246 = ((uint)((int)((uint)(temp1245)) % (int)((uint)((uint)10U))));
                                                                var temp1247 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1246)))))));
                                                                yield return (Byte)(temp1247);
                                                                var temp1248 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                var temp1249 = ((uint)((int)((uint)(temp1248)) % (int)((uint)((uint)10U))));
                                                                var temp1250 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1249)))))));
                                                                yield return (Byte)(temp1250);
                                                                var temp1251 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                var temp1252 = ((uint)((int)((uint)(temp1251)) % (int)((uint)((uint)10U))));
                                                                var temp1253 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1252)))))));
                                                                yield return (Byte)(temp1253);
                                                                var temp1254 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                var temp1255 = ((uint)((int)((uint)(temp1254)) % (int)((uint)((uint)10U))));
                                                                var temp1256 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1255)))))));
                                                                yield return (Byte)(temp1256);
                                                                var temp1257 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                var temp1258 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1257)))))));
                                                                yield return (Byte)(temp1258);
                                                                yield return (Byte)((byte)10U);
                                                                s._4 = ((uint)(temp900));
                                                                s._3 = ((byte)((byte)0U));
                                                                s._2 = ((byte)((byte)0U));
                                                                s._1 = ((byte)((byte)0U));
                                                                s._0 = ((byte)((byte)0U));
                                                                goto M0;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            var temp1259 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                            var temp1260 = ((uint)((int)((uint)(temp1259)) % (int)((uint)((uint)10U))));
                                                            var temp1261 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1260)))))));
                                                            yield return (Byte)(temp1261);
                                                            var temp1262 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                            var temp1263 = ((uint)((int)((uint)(temp1262)) % (int)((uint)((uint)10U))));
                                                            var temp1264 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1263)))))));
                                                            yield return (Byte)(temp1264);
                                                            var temp1265 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                            var temp1266 = ((uint)((int)((uint)(temp1265)) % (int)((uint)((uint)10U))));
                                                            var temp1267 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1266)))))));
                                                            yield return (Byte)(temp1267);
                                                            var temp1268 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                            var temp1269 = ((uint)((int)((uint)(temp1268)) % (int)((uint)((uint)10U))));
                                                            var temp1270 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1269)))))));
                                                            yield return (Byte)(temp1270);
                                                            var temp1271 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                            var temp1272 = ((uint)((int)((uint)(temp1271)) % (int)((uint)((uint)10U))));
                                                            var temp1273 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1272)))))));
                                                            yield return (Byte)(temp1273);
                                                            var temp1274 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                            var temp1275 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1274)))))));
                                                            yield return (Byte)(temp1275);
                                                            yield return (Byte)((byte)10U);
                                                            s._4 = ((uint)(temp900));
                                                            s._3 = ((byte)((byte)0U));
                                                            s._2 = ((byte)((byte)0U));
                                                            s._1 = ((byte)((byte)0U));
                                                            s._0 = ((byte)((byte)0U));
                                                            goto M0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        var temp1276 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                        var temp1277 = ((uint)((int)((uint)(temp1276)) % (int)((uint)((uint)10U))));
                                                        var temp1278 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1277)))))));
                                                        yield return (Byte)(temp1278);
                                                        var temp1279 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                        var temp1280 = ((uint)((int)((uint)(temp1279)) % (int)((uint)((uint)10U))));
                                                        var temp1281 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1280)))))));
                                                        yield return (Byte)(temp1281);
                                                        var temp1282 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                        var temp1283 = ((uint)((int)((uint)(temp1282)) % (int)((uint)((uint)10U))));
                                                        var temp1284 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1283)))))));
                                                        yield return (Byte)(temp1284);
                                                        var temp1285 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                        var temp1286 = ((uint)((int)((uint)(temp1285)) % (int)((uint)((uint)10U))));
                                                        var temp1287 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1286)))))));
                                                        yield return (Byte)(temp1287);
                                                        var temp1288 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                        var temp1289 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1288)))))));
                                                        yield return (Byte)(temp1289);
                                                        yield return (Byte)((byte)10U);
                                                        s._4 = ((uint)(temp900));
                                                        s._3 = ((byte)((byte)0U));
                                                        s._2 = ((byte)((byte)0U));
                                                        s._1 = ((byte)((byte)0U));
                                                        s._0 = ((byte)((byte)0U));
                                                        goto M0;
                                                    }
                                                }
                                                else
                                                {
                                                    var temp1290 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                    var temp1291 = ((uint)((int)((uint)(temp1290)) % (int)((uint)((uint)10U))));
                                                    var temp1292 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1291)))))));
                                                    yield return (Byte)(temp1292);
                                                    var temp1293 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                    var temp1294 = ((uint)((int)((uint)(temp1293)) % (int)((uint)((uint)10U))));
                                                    var temp1295 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1294)))))));
                                                    yield return (Byte)(temp1295);
                                                    var temp1296 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                    var temp1297 = ((uint)((int)((uint)(temp1296)) % (int)((uint)((uint)10U))));
                                                    var temp1298 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1297)))))));
                                                    yield return (Byte)(temp1298);
                                                    var temp1299 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                    var temp1300 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1299)))))));
                                                    yield return (Byte)(temp1300);
                                                    yield return (Byte)((byte)10U);
                                                    s._4 = ((uint)(temp900));
                                                    s._3 = ((byte)((byte)0U));
                                                    s._2 = ((byte)((byte)0U));
                                                    s._1 = ((byte)((byte)0U));
                                                    s._0 = ((byte)((byte)0U));
                                                    goto M0;
                                                }
                                            }
                                            else
                                            {
                                                var temp1301 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                var temp1302 = ((uint)((int)((uint)(temp1301)) % (int)((uint)((uint)10U))));
                                                var temp1303 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1302)))))));
                                                yield return (Byte)(temp1303);
                                                var temp1304 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                var temp1305 = ((uint)((int)((uint)(temp1304)) % (int)((uint)((uint)10U))));
                                                var temp1306 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1305)))))));
                                                yield return (Byte)(temp1306);
                                                var temp1307 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                var temp1308 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1307)))))));
                                                yield return (Byte)(temp1308);
                                                yield return (Byte)((byte)10U);
                                                s._4 = ((uint)(temp900));
                                                s._3 = ((byte)((byte)0U));
                                                s._2 = ((byte)((byte)0U));
                                                s._1 = ((byte)((byte)0U));
                                                s._0 = ((byte)((byte)0U));
                                                goto M0;
                                            }
                                        }
                                        else
                                        {
                                            var temp1309 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                            var temp1310 = ((uint)((int)((uint)(temp1309)) % (int)((uint)((uint)10U))));
                                            var temp1311 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1310)))))));
                                            yield return (Byte)(temp1311);
                                            var temp1312 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                            var temp1313 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1312)))))));
                                            yield return (Byte)(temp1313);
                                            yield return (Byte)((byte)10U);
                                            s._4 = ((uint)(temp900));
                                            s._3 = ((byte)((byte)0U));
                                            s._2 = ((byte)((byte)0U));
                                            s._1 = ((byte)((byte)0U));
                                            s._0 = ((byte)((byte)0U));
                                            goto M0;
                                        }
                                    }
                                    else
                                    {
                                        var temp1314 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                        var temp1315 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1314)))))));
                                        yield return (Byte)(temp1315);
                                        yield return (Byte)((byte)10U);
                                        s._4 = ((uint)(temp900));
                                        s._3 = ((byte)((byte)0U));
                                        s._2 = ((byte)((byte)0U));
                                        s._1 = ((byte)((byte)0U));
                                        s._0 = ((byte)((byte)0U));
                                        goto M0;
                                    }
                                }
                            }
                        }
                    }
                }

                M23:
                {
                    if (!ie.MoveNext())
                        goto F23;
                    i = ie.Current;
                    throw new Exception();
                }

                M24:
                {
                    if (!ie.MoveNext())
                        goto F24;
                    i = ie.Current;
                    throw new Exception();
                }

                M25:
                {
                    if (!ie.MoveNext())
                        goto F25;
                    i = ie.Current;
                    throw new Exception();
                }

                M26:
                {
                    if (!ie.MoveNext())
                        goto F26;
                    i = ie.Current;
                    throw new Exception();
                }

                M27:
                {
                    if (!ie.MoveNext())
                        goto F27;
                    i = ie.Current;
                    throw new Exception();
                }

                F0:
                {
                    yield break;
                }

                F1:
                {
                    yield break;
                }

                F2:
                {
                    yield break;
                }

                F3:
                    throw new Exception();
                F4:
                {
                    yield break;
                }

                F5:
                {
                    yield break;
                }

                F6:
                {
                    yield break;
                }

                F7:
                {
                    yield break;
                }

                F8:
                {
                    yield break;
                }

                F9:
                    throw new Exception();
                F10:
                {
                    yield break;
                }

                F11:
                {
                    yield break;
                }

                F12:
                {
                    yield break;
                }

                F13:
                {
                    yield break;
                }

                F14:
                {
                    yield break;
                }

                F15:
                    throw new Exception();
                F16:
                {
                    yield break;
                }

                F17:
                {
                    yield break;
                }

                F18:
                {
                    yield break;
                }

                F19:
                {
                    yield break;
                }

                F20:
                {
                    yield break;
                }

                F21:
                    throw new Exception();
                F22:
                {
                    yield break;
                }

                F23:
                {
                    yield break;
                }

                F24:
                {
                    yield break;
                }

                F25:
                {
                    yield break;
                }

                F26:
                {
                    yield break;
                }

                F27:
                {
                    yield break;
                }
            }
        }

        struct DTStruct1
        {
            public Byte _0;
            public Byte _1;
            public Byte _2;
            public Byte _3;
            public UInt32 _4;
            public DTStruct1(Byte v0, Byte v1, Byte v2, Byte v3, UInt32 v4)
            {
                _0 = v0;
                _1 = v1;
                _2 = v2;
                _3 = v3;
                _4 = v4;
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
                DTStruct1 s = new DTStruct1(((byte)((byte)0U)), ((byte)((byte)0U)), ((byte)((byte)0U)), ((byte)((byte)0U)), ((uint)((uint)0U)));
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
                        var temp0 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp0)
                            throw new Exception();
                        else
                        {
                            var temp1 = Fun0(((byte)(i)));
                            s._0 = ((byte)(((byte)((uint)(temp1)))));
                            goto M1;
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
                        var temp2 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp2)
                            throw new Exception();
                        else
                        {
                            var temp3 = ((byte)((byte)(((byte)((byte)((s)._0))) & 63L)) << 2);
                            var temp4 = Fun0(((byte)(i)));
                            var temp5 = ((uint)(((int)((uint)(temp4))) >> (int)((uint)((uint)4U))));
                            var temp6 = ((byte)(((byte)(temp3)) | ((byte)(((byte)((uint)(temp5)))))));
                            s._1 = ((byte)(temp6));
                            s._0 = ((byte)(((byte)((uint)(temp4)))));
                            goto M2;
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
                        var temp7 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp7)
                        {
                            goto M3;
                        }
                        else
                        {
                            var temp8 = ((byte)((byte)(((byte)((byte)((s)._0))) & 15L)) << 4);
                            var temp9 = Fun0(((byte)(i)));
                            var temp10 = ((uint)(((int)((uint)(temp9))) >> (int)((uint)((uint)2U))));
                            var temp11 = ((byte)(((byte)(temp8)) | ((byte)(((byte)((uint)(temp10)))))));
                            s._2 = ((byte)(temp11));
                            s._0 = ((byte)(((byte)((uint)(temp9)))));
                            goto M4;
                        }
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
                        var temp12 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp12)
                        {
                            goto M27;
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
                        var temp13 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp13)
                        {
                            goto M5;
                        }
                        else
                        {
                            var temp14 = ((byte)((byte)(((byte)((byte)((s)._0))) & 3L)) << 6);
                            var temp15 = Fun0(((byte)(i)));
                            var temp16 = ((byte)(((byte)(temp14)) | ((byte)(((byte)((uint)(temp15)))))));
                            s._3 = ((byte)(temp16));
                            s._0 = ((byte)((byte)0U));
                            goto M6;
                        }
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
                    throw new Exception();
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
                        var temp17 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp17)
                            throw new Exception();
                        else
                        {
                            var temp18 = Fun0(((byte)(i)));
                            s._0 = ((byte)(((byte)((uint)(temp18)))));
                            goto M7;
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
                        var temp19 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp19)
                            throw new Exception();
                        else
                        {
                            var temp20 = ((byte)((byte)(((byte)((byte)((s)._0))) & 63L)) << 2);
                            var temp21 = Fun0(((byte)(i)));
                            var temp22 = ((uint)(((int)((uint)(temp21))) >> (int)((uint)((uint)4U))));
                            var temp23 = ((byte)(((byte)(temp20)) | ((byte)(((byte)((uint)(temp22)))))));
                            var temp24 = ((((uint)((byte)((s)._1)) << 8) | (uint)((byte)((s)._2)) << 8) | (uint)((byte)((s)._3)) << 8) | (uint)((byte)(temp23));
                            var temp25 = (((uint)(temp24)) == ((uint)((s)._4)));
                            if (temp25)
                            {
                                if (oIndex > 16383)
                                {
                                    output.Write(oBuf, 0, oIndex);
                                    oIndex = 0;
                                }

                                oBuf[oIndex + 0] = (Byte)((byte)48U);
                                oIndex += 1;
                                s._4 = ((uint)(temp24));
                                s._3 = ((byte)((byte)0U));
                                s._2 = ((byte)((byte)0U));
                                s._1 = ((byte)((byte)0U));
                                s._0 = ((byte)(((byte)((uint)(temp21)))));
                                goto M8;
                            }
                            else
                            {
                                var temp26 = ((uint)(((uint)((uint)4294967295U)) * ((uint)((s)._4))));
                                var temp27 = ((uint)(((uint)(temp24)) + ((uint)(temp26))));
                                var temp28 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp27)));
                                var temp29 = !(temp28);
                                if (temp29)
                                {
                                    var temp30 = ((byte)(((uint)(temp27)) >> 31));
                                    var temp31 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 32) | (ulong)((uint)(temp27));
                                    var temp32 = ((ulong)(((ulong)((ulong)18446744073709551615UL)) * ((ulong)(temp31))));
                                    var temp33 = Fun1(((ulong)(temp32)));
                                    var temp34 = ((uint)(((uint)((uint)4294967295U)) + ((uint)(temp33))));
                                    var temp35 = ((int)((uint)(temp34)) <= (int)((uint)((uint)0U)));
                                    var temp36 = !(temp35);
                                    if (temp36)
                                    {
                                        var temp37 = ((int)((uint)(temp34)) <= (int)((uint)((uint)1U)));
                                        var temp38 = !(temp37);
                                        if (temp38)
                                        {
                                            var temp39 = ((int)((uint)(temp34)) <= (int)((uint)((uint)2U)));
                                            var temp40 = !(temp39);
                                            if (temp40)
                                            {
                                                var temp41 = ((int)((uint)(temp34)) <= (int)((uint)((uint)3U)));
                                                var temp42 = !(temp41);
                                                if (temp42)
                                                {
                                                    var temp43 = ((int)((uint)(temp34)) <= (int)((uint)((uint)4U)));
                                                    var temp44 = !(temp43);
                                                    if (temp44)
                                                    {
                                                        var temp45 = ((int)((uint)(temp34)) <= (int)((uint)((uint)5U)));
                                                        var temp46 = !(temp45);
                                                        if (temp46)
                                                        {
                                                            var temp47 = ((int)((uint)(temp34)) <= (int)((uint)((uint)6U)));
                                                            var temp48 = !(temp47);
                                                            if (temp48)
                                                            {
                                                                var temp49 = ((int)((uint)(temp34)) <= (int)((uint)((uint)7U)));
                                                                var temp50 = !(temp49);
                                                                if (temp50)
                                                                {
                                                                    var temp51 = ((int)((uint)(temp34)) <= (int)((uint)((uint)8U)));
                                                                    var temp52 = !(temp51);
                                                                    if (temp52)
                                                                    {
                                                                        if (oIndex > 16372)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                        var temp53 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000000U))));
                                                                        var temp54 = ((uint)((int)((uint)(temp53)) % (int)((uint)((uint)10U))));
                                                                        var temp55 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp54)))))));
                                                                        var temp56 = ((byte)(((byte)((byte)48U)) + ((byte)(temp55))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp56);
                                                                        var temp57 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000000U))));
                                                                        var temp58 = ((uint)((int)((uint)(temp57)) % (int)((uint)((uint)10U))));
                                                                        var temp59 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp58)))))));
                                                                        var temp60 = ((byte)(((byte)((byte)48U)) + ((byte)(temp59))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp60);
                                                                        var temp61 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000000U))));
                                                                        var temp62 = ((uint)((int)((uint)(temp61)) % (int)((uint)((uint)10U))));
                                                                        var temp63 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp62)))))));
                                                                        var temp64 = ((byte)(((byte)((byte)48U)) + ((byte)(temp63))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp64);
                                                                        var temp65 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                        var temp66 = ((uint)((int)((uint)(temp65)) % (int)((uint)((uint)10U))));
                                                                        var temp67 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp66)))))));
                                                                        var temp68 = ((byte)(((byte)((byte)48U)) + ((byte)(temp67))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp68);
                                                                        var temp69 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                        var temp70 = ((uint)((int)((uint)(temp69)) % (int)((uint)((uint)10U))));
                                                                        var temp71 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp70)))))));
                                                                        var temp72 = ((byte)(((byte)((byte)48U)) + ((byte)(temp71))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp72);
                                                                        var temp73 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                        var temp74 = ((uint)((int)((uint)(temp73)) % (int)((uint)((uint)10U))));
                                                                        var temp75 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp74)))))));
                                                                        var temp76 = ((byte)(((byte)((byte)48U)) + ((byte)(temp75))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp76);
                                                                        var temp77 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                        var temp78 = ((uint)((int)((uint)(temp77)) % (int)((uint)((uint)10U))));
                                                                        var temp79 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp78)))))));
                                                                        var temp80 = ((byte)(((byte)((byte)48U)) + ((byte)(temp79))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp80);
                                                                        var temp81 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                        var temp82 = ((uint)((int)((uint)(temp81)) % (int)((uint)((uint)10U))));
                                                                        var temp83 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp82)))))));
                                                                        var temp84 = ((byte)(((byte)((byte)48U)) + ((byte)(temp83))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp84);
                                                                        var temp85 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                        var temp86 = ((uint)((int)((uint)(temp85)) % (int)((uint)((uint)10U))));
                                                                        var temp87 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp86)))))));
                                                                        var temp88 = ((byte)(((byte)((byte)48U)) + ((byte)(temp87))));
                                                                        oBuf[oIndex + 9] = (Byte)(temp88);
                                                                        var temp89 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                        var temp90 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp89)))))));
                                                                        var temp91 = ((byte)(((byte)((byte)48U)) + ((byte)(temp90))));
                                                                        oBuf[oIndex + 10] = (Byte)(temp91);
                                                                        oBuf[oIndex + 11] = (Byte)((byte)10U);
                                                                        oIndex += 12;
                                                                        s._4 = ((uint)(temp24));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                        goto M8;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (oIndex > 16373)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                        var temp92 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000000U))));
                                                                        var temp93 = ((uint)((int)((uint)(temp92)) % (int)((uint)((uint)10U))));
                                                                        var temp94 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp93)))))));
                                                                        var temp95 = ((byte)(((byte)((byte)48U)) + ((byte)(temp94))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp95);
                                                                        var temp96 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000000U))));
                                                                        var temp97 = ((uint)((int)((uint)(temp96)) % (int)((uint)((uint)10U))));
                                                                        var temp98 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp97)))))));
                                                                        var temp99 = ((byte)(((byte)((byte)48U)) + ((byte)(temp98))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp99);
                                                                        var temp100 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                        var temp101 = ((uint)((int)((uint)(temp100)) % (int)((uint)((uint)10U))));
                                                                        var temp102 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp101)))))));
                                                                        var temp103 = ((byte)(((byte)((byte)48U)) + ((byte)(temp102))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp103);
                                                                        var temp104 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                        var temp105 = ((uint)((int)((uint)(temp104)) % (int)((uint)((uint)10U))));
                                                                        var temp106 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp105)))))));
                                                                        var temp107 = ((byte)(((byte)((byte)48U)) + ((byte)(temp106))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp107);
                                                                        var temp108 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                        var temp109 = ((uint)((int)((uint)(temp108)) % (int)((uint)((uint)10U))));
                                                                        var temp110 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp109)))))));
                                                                        var temp111 = ((byte)(((byte)((byte)48U)) + ((byte)(temp110))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp111);
                                                                        var temp112 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                        var temp113 = ((uint)((int)((uint)(temp112)) % (int)((uint)((uint)10U))));
                                                                        var temp114 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp113)))))));
                                                                        var temp115 = ((byte)(((byte)((byte)48U)) + ((byte)(temp114))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp115);
                                                                        var temp116 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                        var temp117 = ((uint)((int)((uint)(temp116)) % (int)((uint)((uint)10U))));
                                                                        var temp118 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp117)))))));
                                                                        var temp119 = ((byte)(((byte)((byte)48U)) + ((byte)(temp118))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp119);
                                                                        var temp120 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                        var temp121 = ((uint)((int)((uint)(temp120)) % (int)((uint)((uint)10U))));
                                                                        var temp122 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp121)))))));
                                                                        var temp123 = ((byte)(((byte)((byte)48U)) + ((byte)(temp122))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp123);
                                                                        var temp124 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                        var temp125 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp124)))))));
                                                                        var temp126 = ((byte)(((byte)((byte)48U)) + ((byte)(temp125))));
                                                                        oBuf[oIndex + 9] = (Byte)(temp126);
                                                                        oBuf[oIndex + 10] = (Byte)((byte)10U);
                                                                        oIndex += 11;
                                                                        s._4 = ((uint)(temp24));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                        goto M8;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (oIndex > 16374)
                                                                    {
                                                                        output.Write(oBuf, 0, oIndex);
                                                                        oIndex = 0;
                                                                    }

                                                                    oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                    var temp127 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000000U))));
                                                                    var temp128 = ((uint)((int)((uint)(temp127)) % (int)((uint)((uint)10U))));
                                                                    var temp129 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp128)))))));
                                                                    var temp130 = ((byte)(((byte)((byte)48U)) + ((byte)(temp129))));
                                                                    oBuf[oIndex + 1] = (Byte)(temp130);
                                                                    var temp131 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                    var temp132 = ((uint)((int)((uint)(temp131)) % (int)((uint)((uint)10U))));
                                                                    var temp133 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp132)))))));
                                                                    var temp134 = ((byte)(((byte)((byte)48U)) + ((byte)(temp133))));
                                                                    oBuf[oIndex + 2] = (Byte)(temp134);
                                                                    var temp135 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                    var temp136 = ((uint)((int)((uint)(temp135)) % (int)((uint)((uint)10U))));
                                                                    var temp137 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp136)))))));
                                                                    var temp138 = ((byte)(((byte)((byte)48U)) + ((byte)(temp137))));
                                                                    oBuf[oIndex + 3] = (Byte)(temp138);
                                                                    var temp139 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                    var temp140 = ((uint)((int)((uint)(temp139)) % (int)((uint)((uint)10U))));
                                                                    var temp141 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp140)))))));
                                                                    var temp142 = ((byte)(((byte)((byte)48U)) + ((byte)(temp141))));
                                                                    oBuf[oIndex + 4] = (Byte)(temp142);
                                                                    var temp143 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                    var temp144 = ((uint)((int)((uint)(temp143)) % (int)((uint)((uint)10U))));
                                                                    var temp145 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp144)))))));
                                                                    var temp146 = ((byte)(((byte)((byte)48U)) + ((byte)(temp145))));
                                                                    oBuf[oIndex + 5] = (Byte)(temp146);
                                                                    var temp147 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                    var temp148 = ((uint)((int)((uint)(temp147)) % (int)((uint)((uint)10U))));
                                                                    var temp149 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp148)))))));
                                                                    var temp150 = ((byte)(((byte)((byte)48U)) + ((byte)(temp149))));
                                                                    oBuf[oIndex + 6] = (Byte)(temp150);
                                                                    var temp151 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                    var temp152 = ((uint)((int)((uint)(temp151)) % (int)((uint)((uint)10U))));
                                                                    var temp153 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp152)))))));
                                                                    var temp154 = ((byte)(((byte)((byte)48U)) + ((byte)(temp153))));
                                                                    oBuf[oIndex + 7] = (Byte)(temp154);
                                                                    var temp155 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                    var temp156 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp155)))))));
                                                                    var temp157 = ((byte)(((byte)((byte)48U)) + ((byte)(temp156))));
                                                                    oBuf[oIndex + 8] = (Byte)(temp157);
                                                                    oBuf[oIndex + 9] = (Byte)((byte)10U);
                                                                    oIndex += 10;
                                                                    s._4 = ((uint)(temp24));
                                                                    s._3 = ((byte)((byte)0U));
                                                                    s._2 = ((byte)((byte)0U));
                                                                    s._1 = ((byte)((byte)0U));
                                                                    s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                    goto M8;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (oIndex > 16375)
                                                                {
                                                                    output.Write(oBuf, 0, oIndex);
                                                                    oIndex = 0;
                                                                }

                                                                oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                var temp158 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                var temp159 = ((uint)((int)((uint)(temp158)) % (int)((uint)((uint)10U))));
                                                                var temp160 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp159)))))));
                                                                var temp161 = ((byte)(((byte)((byte)48U)) + ((byte)(temp160))));
                                                                oBuf[oIndex + 1] = (Byte)(temp161);
                                                                var temp162 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                var temp163 = ((uint)((int)((uint)(temp162)) % (int)((uint)((uint)10U))));
                                                                var temp164 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp163)))))));
                                                                var temp165 = ((byte)(((byte)((byte)48U)) + ((byte)(temp164))));
                                                                oBuf[oIndex + 2] = (Byte)(temp165);
                                                                var temp166 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                var temp167 = ((uint)((int)((uint)(temp166)) % (int)((uint)((uint)10U))));
                                                                var temp168 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp167)))))));
                                                                var temp169 = ((byte)(((byte)((byte)48U)) + ((byte)(temp168))));
                                                                oBuf[oIndex + 3] = (Byte)(temp169);
                                                                var temp170 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                var temp171 = ((uint)((int)((uint)(temp170)) % (int)((uint)((uint)10U))));
                                                                var temp172 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp171)))))));
                                                                var temp173 = ((byte)(((byte)((byte)48U)) + ((byte)(temp172))));
                                                                oBuf[oIndex + 4] = (Byte)(temp173);
                                                                var temp174 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                var temp175 = ((uint)((int)((uint)(temp174)) % (int)((uint)((uint)10U))));
                                                                var temp176 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp175)))))));
                                                                var temp177 = ((byte)(((byte)((byte)48U)) + ((byte)(temp176))));
                                                                oBuf[oIndex + 5] = (Byte)(temp177);
                                                                var temp178 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                var temp179 = ((uint)((int)((uint)(temp178)) % (int)((uint)((uint)10U))));
                                                                var temp180 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp179)))))));
                                                                var temp181 = ((byte)(((byte)((byte)48U)) + ((byte)(temp180))));
                                                                oBuf[oIndex + 6] = (Byte)(temp181);
                                                                var temp182 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                var temp183 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp182)))))));
                                                                var temp184 = ((byte)(((byte)((byte)48U)) + ((byte)(temp183))));
                                                                oBuf[oIndex + 7] = (Byte)(temp184);
                                                                oBuf[oIndex + 8] = (Byte)((byte)10U);
                                                                oIndex += 9;
                                                                s._4 = ((uint)(temp24));
                                                                s._3 = ((byte)((byte)0U));
                                                                s._2 = ((byte)((byte)0U));
                                                                s._1 = ((byte)((byte)0U));
                                                                s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                goto M8;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (oIndex > 16376)
                                                            {
                                                                output.Write(oBuf, 0, oIndex);
                                                                oIndex = 0;
                                                            }

                                                            oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                            var temp185 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                            var temp186 = ((uint)((int)((uint)(temp185)) % (int)((uint)((uint)10U))));
                                                            var temp187 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp186)))))));
                                                            var temp188 = ((byte)(((byte)((byte)48U)) + ((byte)(temp187))));
                                                            oBuf[oIndex + 1] = (Byte)(temp188);
                                                            var temp189 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                            var temp190 = ((uint)((int)((uint)(temp189)) % (int)((uint)((uint)10U))));
                                                            var temp191 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp190)))))));
                                                            var temp192 = ((byte)(((byte)((byte)48U)) + ((byte)(temp191))));
                                                            oBuf[oIndex + 2] = (Byte)(temp192);
                                                            var temp193 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                            var temp194 = ((uint)((int)((uint)(temp193)) % (int)((uint)((uint)10U))));
                                                            var temp195 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp194)))))));
                                                            var temp196 = ((byte)(((byte)((byte)48U)) + ((byte)(temp195))));
                                                            oBuf[oIndex + 3] = (Byte)(temp196);
                                                            var temp197 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                            var temp198 = ((uint)((int)((uint)(temp197)) % (int)((uint)((uint)10U))));
                                                            var temp199 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp198)))))));
                                                            var temp200 = ((byte)(((byte)((byte)48U)) + ((byte)(temp199))));
                                                            oBuf[oIndex + 4] = (Byte)(temp200);
                                                            var temp201 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                            var temp202 = ((uint)((int)((uint)(temp201)) % (int)((uint)((uint)10U))));
                                                            var temp203 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp202)))))));
                                                            var temp204 = ((byte)(((byte)((byte)48U)) + ((byte)(temp203))));
                                                            oBuf[oIndex + 5] = (Byte)(temp204);
                                                            var temp205 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                            var temp206 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp205)))))));
                                                            var temp207 = ((byte)(((byte)((byte)48U)) + ((byte)(temp206))));
                                                            oBuf[oIndex + 6] = (Byte)(temp207);
                                                            oBuf[oIndex + 7] = (Byte)((byte)10U);
                                                            oIndex += 8;
                                                            s._4 = ((uint)(temp24));
                                                            s._3 = ((byte)((byte)0U));
                                                            s._2 = ((byte)((byte)0U));
                                                            s._1 = ((byte)((byte)0U));
                                                            s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                            goto M8;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (oIndex > 16377)
                                                        {
                                                            output.Write(oBuf, 0, oIndex);
                                                            oIndex = 0;
                                                        }

                                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                        var temp208 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                        var temp209 = ((uint)((int)((uint)(temp208)) % (int)((uint)((uint)10U))));
                                                        var temp210 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp209)))))));
                                                        var temp211 = ((byte)(((byte)((byte)48U)) + ((byte)(temp210))));
                                                        oBuf[oIndex + 1] = (Byte)(temp211);
                                                        var temp212 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                        var temp213 = ((uint)((int)((uint)(temp212)) % (int)((uint)((uint)10U))));
                                                        var temp214 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp213)))))));
                                                        var temp215 = ((byte)(((byte)((byte)48U)) + ((byte)(temp214))));
                                                        oBuf[oIndex + 2] = (Byte)(temp215);
                                                        var temp216 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                        var temp217 = ((uint)((int)((uint)(temp216)) % (int)((uint)((uint)10U))));
                                                        var temp218 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp217)))))));
                                                        var temp219 = ((byte)(((byte)((byte)48U)) + ((byte)(temp218))));
                                                        oBuf[oIndex + 3] = (Byte)(temp219);
                                                        var temp220 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                        var temp221 = ((uint)((int)((uint)(temp220)) % (int)((uint)((uint)10U))));
                                                        var temp222 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp221)))))));
                                                        var temp223 = ((byte)(((byte)((byte)48U)) + ((byte)(temp222))));
                                                        oBuf[oIndex + 4] = (Byte)(temp223);
                                                        var temp224 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                        var temp225 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp224)))))));
                                                        var temp226 = ((byte)(((byte)((byte)48U)) + ((byte)(temp225))));
                                                        oBuf[oIndex + 5] = (Byte)(temp226);
                                                        oBuf[oIndex + 6] = (Byte)((byte)10U);
                                                        oIndex += 7;
                                                        s._4 = ((uint)(temp24));
                                                        s._3 = ((byte)((byte)0U));
                                                        s._2 = ((byte)((byte)0U));
                                                        s._1 = ((byte)((byte)0U));
                                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                        goto M8;
                                                    }
                                                }
                                                else
                                                {
                                                    if (oIndex > 16378)
                                                    {
                                                        output.Write(oBuf, 0, oIndex);
                                                        oIndex = 0;
                                                    }

                                                    oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                    var temp227 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                    var temp228 = ((uint)((int)((uint)(temp227)) % (int)((uint)((uint)10U))));
                                                    var temp229 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp228)))))));
                                                    var temp230 = ((byte)(((byte)((byte)48U)) + ((byte)(temp229))));
                                                    oBuf[oIndex + 1] = (Byte)(temp230);
                                                    var temp231 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                    var temp232 = ((uint)((int)((uint)(temp231)) % (int)((uint)((uint)10U))));
                                                    var temp233 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp232)))))));
                                                    var temp234 = ((byte)(((byte)((byte)48U)) + ((byte)(temp233))));
                                                    oBuf[oIndex + 2] = (Byte)(temp234);
                                                    var temp235 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                    var temp236 = ((uint)((int)((uint)(temp235)) % (int)((uint)((uint)10U))));
                                                    var temp237 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp236)))))));
                                                    var temp238 = ((byte)(((byte)((byte)48U)) + ((byte)(temp237))));
                                                    oBuf[oIndex + 3] = (Byte)(temp238);
                                                    var temp239 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                    var temp240 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp239)))))));
                                                    var temp241 = ((byte)(((byte)((byte)48U)) + ((byte)(temp240))));
                                                    oBuf[oIndex + 4] = (Byte)(temp241);
                                                    oBuf[oIndex + 5] = (Byte)((byte)10U);
                                                    oIndex += 6;
                                                    s._4 = ((uint)(temp24));
                                                    s._3 = ((byte)((byte)0U));
                                                    s._2 = ((byte)((byte)0U));
                                                    s._1 = ((byte)((byte)0U));
                                                    s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                    goto M8;
                                                }
                                            }
                                            else
                                            {
                                                if (oIndex > 16379)
                                                {
                                                    output.Write(oBuf, 0, oIndex);
                                                    oIndex = 0;
                                                }

                                                oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                var temp242 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                var temp243 = ((uint)((int)((uint)(temp242)) % (int)((uint)((uint)10U))));
                                                var temp244 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp243)))))));
                                                var temp245 = ((byte)(((byte)((byte)48U)) + ((byte)(temp244))));
                                                oBuf[oIndex + 1] = (Byte)(temp245);
                                                var temp246 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                var temp247 = ((uint)((int)((uint)(temp246)) % (int)((uint)((uint)10U))));
                                                var temp248 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp247)))))));
                                                var temp249 = ((byte)(((byte)((byte)48U)) + ((byte)(temp248))));
                                                oBuf[oIndex + 2] = (Byte)(temp249);
                                                var temp250 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                var temp251 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp250)))))));
                                                var temp252 = ((byte)(((byte)((byte)48U)) + ((byte)(temp251))));
                                                oBuf[oIndex + 3] = (Byte)(temp252);
                                                oBuf[oIndex + 4] = (Byte)((byte)10U);
                                                oIndex += 5;
                                                s._4 = ((uint)(temp24));
                                                s._3 = ((byte)((byte)0U));
                                                s._2 = ((byte)((byte)0U));
                                                s._1 = ((byte)((byte)0U));
                                                s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                goto M8;
                                            }
                                        }
                                        else
                                        {
                                            if (oIndex > 16380)
                                            {
                                                output.Write(oBuf, 0, oIndex);
                                                oIndex = 0;
                                            }

                                            oBuf[oIndex + 0] = (Byte)((byte)45U);
                                            var temp253 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                            var temp254 = ((uint)((int)((uint)(temp253)) % (int)((uint)((uint)10U))));
                                            var temp255 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp254)))))));
                                            var temp256 = ((byte)(((byte)((byte)48U)) + ((byte)(temp255))));
                                            oBuf[oIndex + 1] = (Byte)(temp256);
                                            var temp257 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                            var temp258 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp257)))))));
                                            var temp259 = ((byte)(((byte)((byte)48U)) + ((byte)(temp258))));
                                            oBuf[oIndex + 2] = (Byte)(temp259);
                                            oBuf[oIndex + 3] = (Byte)((byte)10U);
                                            oIndex += 4;
                                            s._4 = ((uint)(temp24));
                                            s._3 = ((byte)((byte)0U));
                                            s._2 = ((byte)((byte)0U));
                                            s._1 = ((byte)((byte)0U));
                                            s._0 = ((byte)(((byte)((uint)(temp21)))));
                                            goto M8;
                                        }
                                    }
                                    else
                                    {
                                        if (oIndex > 16381)
                                        {
                                            output.Write(oBuf, 0, oIndex);
                                            oIndex = 0;
                                        }

                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                        var temp260 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                        var temp261 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp260)))))));
                                        var temp262 = ((byte)(((byte)((byte)48U)) + ((byte)(temp261))));
                                        oBuf[oIndex + 1] = (Byte)(temp262);
                                        oBuf[oIndex + 2] = (Byte)((byte)10U);
                                        oIndex += 3;
                                        s._4 = ((uint)(temp24));
                                        s._3 = ((byte)((byte)0U));
                                        s._2 = ((byte)((byte)0U));
                                        s._1 = ((byte)((byte)0U));
                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                        goto M8;
                                    }
                                }
                                else
                                {
                                    var temp263 = ((byte)(((uint)(temp27)) >> 31));
                                    var temp264 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 32) | (ulong)((uint)(temp27));
                                    var temp265 = Fun1(((ulong)(temp264)));
                                    var temp266 = ((uint)(((uint)((uint)4294967295U)) + ((uint)(temp265))));
                                    var temp267 = ((int)((uint)(temp266)) <= (int)((uint)((uint)0U)));
                                    var temp268 = !(temp267);
                                    if (temp268)
                                    {
                                        var temp269 = ((int)((uint)(temp266)) <= (int)((uint)((uint)1U)));
                                        var temp270 = !(temp269);
                                        if (temp270)
                                        {
                                            var temp271 = ((int)((uint)(temp266)) <= (int)((uint)((uint)2U)));
                                            var temp272 = !(temp271);
                                            if (temp272)
                                            {
                                                var temp273 = ((int)((uint)(temp266)) <= (int)((uint)((uint)3U)));
                                                var temp274 = !(temp273);
                                                if (temp274)
                                                {
                                                    var temp275 = ((int)((uint)(temp266)) <= (int)((uint)((uint)4U)));
                                                    var temp276 = !(temp275);
                                                    if (temp276)
                                                    {
                                                        var temp277 = ((int)((uint)(temp266)) <= (int)((uint)((uint)5U)));
                                                        var temp278 = !(temp277);
                                                        if (temp278)
                                                        {
                                                            var temp279 = ((int)((uint)(temp266)) <= (int)((uint)((uint)6U)));
                                                            var temp280 = !(temp279);
                                                            if (temp280)
                                                            {
                                                                var temp281 = ((int)((uint)(temp266)) <= (int)((uint)((uint)7U)));
                                                                var temp282 = !(temp281);
                                                                if (temp282)
                                                                {
                                                                    var temp283 = ((int)((uint)(temp266)) <= (int)((uint)((uint)8U)));
                                                                    var temp284 = !(temp283);
                                                                    if (temp284)
                                                                    {
                                                                        if (oIndex > 16373)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        var temp285 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000000U))));
                                                                        var temp286 = ((uint)((int)((uint)(temp285)) % (int)((uint)((uint)10U))));
                                                                        var temp287 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp286)))))));
                                                                        oBuf[oIndex + 0] = (Byte)(temp287);
                                                                        var temp288 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000000U))));
                                                                        var temp289 = ((uint)((int)((uint)(temp288)) % (int)((uint)((uint)10U))));
                                                                        var temp290 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp289)))))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp290);
                                                                        var temp291 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000000U))));
                                                                        var temp292 = ((uint)((int)((uint)(temp291)) % (int)((uint)((uint)10U))));
                                                                        var temp293 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp292)))))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp293);
                                                                        var temp294 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                        var temp295 = ((uint)((int)((uint)(temp294)) % (int)((uint)((uint)10U))));
                                                                        var temp296 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp295)))))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp296);
                                                                        var temp297 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                        var temp298 = ((uint)((int)((uint)(temp297)) % (int)((uint)((uint)10U))));
                                                                        var temp299 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp298)))))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp299);
                                                                        var temp300 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                        var temp301 = ((uint)((int)((uint)(temp300)) % (int)((uint)((uint)10U))));
                                                                        var temp302 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp301)))))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp302);
                                                                        var temp303 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                        var temp304 = ((uint)((int)((uint)(temp303)) % (int)((uint)((uint)10U))));
                                                                        var temp305 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp304)))))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp305);
                                                                        var temp306 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                        var temp307 = ((uint)((int)((uint)(temp306)) % (int)((uint)((uint)10U))));
                                                                        var temp308 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp307)))))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp308);
                                                                        var temp309 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                        var temp310 = ((uint)((int)((uint)(temp309)) % (int)((uint)((uint)10U))));
                                                                        var temp311 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp310)))))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp311);
                                                                        var temp312 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                        var temp313 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp312)))))));
                                                                        oBuf[oIndex + 9] = (Byte)(temp313);
                                                                        oBuf[oIndex + 10] = (Byte)((byte)10U);
                                                                        oIndex += 11;
                                                                        s._4 = ((uint)(temp24));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                        goto M8;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (oIndex > 16374)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        var temp314 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000000U))));
                                                                        var temp315 = ((uint)((int)((uint)(temp314)) % (int)((uint)((uint)10U))));
                                                                        var temp316 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp315)))))));
                                                                        oBuf[oIndex + 0] = (Byte)(temp316);
                                                                        var temp317 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000000U))));
                                                                        var temp318 = ((uint)((int)((uint)(temp317)) % (int)((uint)((uint)10U))));
                                                                        var temp319 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp318)))))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp319);
                                                                        var temp320 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                        var temp321 = ((uint)((int)((uint)(temp320)) % (int)((uint)((uint)10U))));
                                                                        var temp322 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp321)))))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp322);
                                                                        var temp323 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                        var temp324 = ((uint)((int)((uint)(temp323)) % (int)((uint)((uint)10U))));
                                                                        var temp325 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp324)))))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp325);
                                                                        var temp326 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                        var temp327 = ((uint)((int)((uint)(temp326)) % (int)((uint)((uint)10U))));
                                                                        var temp328 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp327)))))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp328);
                                                                        var temp329 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                        var temp330 = ((uint)((int)((uint)(temp329)) % (int)((uint)((uint)10U))));
                                                                        var temp331 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp330)))))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp331);
                                                                        var temp332 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                        var temp333 = ((uint)((int)((uint)(temp332)) % (int)((uint)((uint)10U))));
                                                                        var temp334 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp333)))))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp334);
                                                                        var temp335 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                        var temp336 = ((uint)((int)((uint)(temp335)) % (int)((uint)((uint)10U))));
                                                                        var temp337 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp336)))))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp337);
                                                                        var temp338 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                        var temp339 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp338)))))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp339);
                                                                        oBuf[oIndex + 9] = (Byte)((byte)10U);
                                                                        oIndex += 10;
                                                                        s._4 = ((uint)(temp24));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                        goto M8;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (oIndex > 16375)
                                                                    {
                                                                        output.Write(oBuf, 0, oIndex);
                                                                        oIndex = 0;
                                                                    }

                                                                    var temp340 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000000U))));
                                                                    var temp341 = ((uint)((int)((uint)(temp340)) % (int)((uint)((uint)10U))));
                                                                    var temp342 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp341)))))));
                                                                    oBuf[oIndex + 0] = (Byte)(temp342);
                                                                    var temp343 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                    var temp344 = ((uint)((int)((uint)(temp343)) % (int)((uint)((uint)10U))));
                                                                    var temp345 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp344)))))));
                                                                    oBuf[oIndex + 1] = (Byte)(temp345);
                                                                    var temp346 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                    var temp347 = ((uint)((int)((uint)(temp346)) % (int)((uint)((uint)10U))));
                                                                    var temp348 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp347)))))));
                                                                    oBuf[oIndex + 2] = (Byte)(temp348);
                                                                    var temp349 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                    var temp350 = ((uint)((int)((uint)(temp349)) % (int)((uint)((uint)10U))));
                                                                    var temp351 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp350)))))));
                                                                    oBuf[oIndex + 3] = (Byte)(temp351);
                                                                    var temp352 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                    var temp353 = ((uint)((int)((uint)(temp352)) % (int)((uint)((uint)10U))));
                                                                    var temp354 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp353)))))));
                                                                    oBuf[oIndex + 4] = (Byte)(temp354);
                                                                    var temp355 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                    var temp356 = ((uint)((int)((uint)(temp355)) % (int)((uint)((uint)10U))));
                                                                    var temp357 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp356)))))));
                                                                    oBuf[oIndex + 5] = (Byte)(temp357);
                                                                    var temp358 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                    var temp359 = ((uint)((int)((uint)(temp358)) % (int)((uint)((uint)10U))));
                                                                    var temp360 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp359)))))));
                                                                    oBuf[oIndex + 6] = (Byte)(temp360);
                                                                    var temp361 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                    var temp362 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp361)))))));
                                                                    oBuf[oIndex + 7] = (Byte)(temp362);
                                                                    oBuf[oIndex + 8] = (Byte)((byte)10U);
                                                                    oIndex += 9;
                                                                    s._4 = ((uint)(temp24));
                                                                    s._3 = ((byte)((byte)0U));
                                                                    s._2 = ((byte)((byte)0U));
                                                                    s._1 = ((byte)((byte)0U));
                                                                    s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                    goto M8;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (oIndex > 16376)
                                                                {
                                                                    output.Write(oBuf, 0, oIndex);
                                                                    oIndex = 0;
                                                                }

                                                                var temp363 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                var temp364 = ((uint)((int)((uint)(temp363)) % (int)((uint)((uint)10U))));
                                                                var temp365 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp364)))))));
                                                                oBuf[oIndex + 0] = (Byte)(temp365);
                                                                var temp366 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                var temp367 = ((uint)((int)((uint)(temp366)) % (int)((uint)((uint)10U))));
                                                                var temp368 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp367)))))));
                                                                oBuf[oIndex + 1] = (Byte)(temp368);
                                                                var temp369 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                var temp370 = ((uint)((int)((uint)(temp369)) % (int)((uint)((uint)10U))));
                                                                var temp371 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp370)))))));
                                                                oBuf[oIndex + 2] = (Byte)(temp371);
                                                                var temp372 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                var temp373 = ((uint)((int)((uint)(temp372)) % (int)((uint)((uint)10U))));
                                                                var temp374 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp373)))))));
                                                                oBuf[oIndex + 3] = (Byte)(temp374);
                                                                var temp375 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                var temp376 = ((uint)((int)((uint)(temp375)) % (int)((uint)((uint)10U))));
                                                                var temp377 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp376)))))));
                                                                oBuf[oIndex + 4] = (Byte)(temp377);
                                                                var temp378 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                var temp379 = ((uint)((int)((uint)(temp378)) % (int)((uint)((uint)10U))));
                                                                var temp380 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp379)))))));
                                                                oBuf[oIndex + 5] = (Byte)(temp380);
                                                                var temp381 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                var temp382 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp381)))))));
                                                                oBuf[oIndex + 6] = (Byte)(temp382);
                                                                oBuf[oIndex + 7] = (Byte)((byte)10U);
                                                                oIndex += 8;
                                                                s._4 = ((uint)(temp24));
                                                                s._3 = ((byte)((byte)0U));
                                                                s._2 = ((byte)((byte)0U));
                                                                s._1 = ((byte)((byte)0U));
                                                                s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                goto M8;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (oIndex > 16377)
                                                            {
                                                                output.Write(oBuf, 0, oIndex);
                                                                oIndex = 0;
                                                            }

                                                            var temp383 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                            var temp384 = ((uint)((int)((uint)(temp383)) % (int)((uint)((uint)10U))));
                                                            var temp385 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp384)))))));
                                                            oBuf[oIndex + 0] = (Byte)(temp385);
                                                            var temp386 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                            var temp387 = ((uint)((int)((uint)(temp386)) % (int)((uint)((uint)10U))));
                                                            var temp388 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp387)))))));
                                                            oBuf[oIndex + 1] = (Byte)(temp388);
                                                            var temp389 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                            var temp390 = ((uint)((int)((uint)(temp389)) % (int)((uint)((uint)10U))));
                                                            var temp391 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp390)))))));
                                                            oBuf[oIndex + 2] = (Byte)(temp391);
                                                            var temp392 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                            var temp393 = ((uint)((int)((uint)(temp392)) % (int)((uint)((uint)10U))));
                                                            var temp394 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp393)))))));
                                                            oBuf[oIndex + 3] = (Byte)(temp394);
                                                            var temp395 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                            var temp396 = ((uint)((int)((uint)(temp395)) % (int)((uint)((uint)10U))));
                                                            var temp397 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp396)))))));
                                                            oBuf[oIndex + 4] = (Byte)(temp397);
                                                            var temp398 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                            var temp399 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp398)))))));
                                                            oBuf[oIndex + 5] = (Byte)(temp399);
                                                            oBuf[oIndex + 6] = (Byte)((byte)10U);
                                                            oIndex += 7;
                                                            s._4 = ((uint)(temp24));
                                                            s._3 = ((byte)((byte)0U));
                                                            s._2 = ((byte)((byte)0U));
                                                            s._1 = ((byte)((byte)0U));
                                                            s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                            goto M8;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (oIndex > 16378)
                                                        {
                                                            output.Write(oBuf, 0, oIndex);
                                                            oIndex = 0;
                                                        }

                                                        var temp400 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                        var temp401 = ((uint)((int)((uint)(temp400)) % (int)((uint)((uint)10U))));
                                                        var temp402 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp401)))))));
                                                        oBuf[oIndex + 0] = (Byte)(temp402);
                                                        var temp403 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                        var temp404 = ((uint)((int)((uint)(temp403)) % (int)((uint)((uint)10U))));
                                                        var temp405 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp404)))))));
                                                        oBuf[oIndex + 1] = (Byte)(temp405);
                                                        var temp406 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                        var temp407 = ((uint)((int)((uint)(temp406)) % (int)((uint)((uint)10U))));
                                                        var temp408 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp407)))))));
                                                        oBuf[oIndex + 2] = (Byte)(temp408);
                                                        var temp409 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                        var temp410 = ((uint)((int)((uint)(temp409)) % (int)((uint)((uint)10U))));
                                                        var temp411 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp410)))))));
                                                        oBuf[oIndex + 3] = (Byte)(temp411);
                                                        var temp412 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                        var temp413 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp412)))))));
                                                        oBuf[oIndex + 4] = (Byte)(temp413);
                                                        oBuf[oIndex + 5] = (Byte)((byte)10U);
                                                        oIndex += 6;
                                                        s._4 = ((uint)(temp24));
                                                        s._3 = ((byte)((byte)0U));
                                                        s._2 = ((byte)((byte)0U));
                                                        s._1 = ((byte)((byte)0U));
                                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                        goto M8;
                                                    }
                                                }
                                                else
                                                {
                                                    if (oIndex > 16379)
                                                    {
                                                        output.Write(oBuf, 0, oIndex);
                                                        oIndex = 0;
                                                    }

                                                    var temp414 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                    var temp415 = ((uint)((int)((uint)(temp414)) % (int)((uint)((uint)10U))));
                                                    var temp416 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp415)))))));
                                                    oBuf[oIndex + 0] = (Byte)(temp416);
                                                    var temp417 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                    var temp418 = ((uint)((int)((uint)(temp417)) % (int)((uint)((uint)10U))));
                                                    var temp419 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp418)))))));
                                                    oBuf[oIndex + 1] = (Byte)(temp419);
                                                    var temp420 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                    var temp421 = ((uint)((int)((uint)(temp420)) % (int)((uint)((uint)10U))));
                                                    var temp422 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp421)))))));
                                                    oBuf[oIndex + 2] = (Byte)(temp422);
                                                    var temp423 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                    var temp424 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp423)))))));
                                                    oBuf[oIndex + 3] = (Byte)(temp424);
                                                    oBuf[oIndex + 4] = (Byte)((byte)10U);
                                                    oIndex += 5;
                                                    s._4 = ((uint)(temp24));
                                                    s._3 = ((byte)((byte)0U));
                                                    s._2 = ((byte)((byte)0U));
                                                    s._1 = ((byte)((byte)0U));
                                                    s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                    goto M8;
                                                }
                                            }
                                            else
                                            {
                                                if (oIndex > 16380)
                                                {
                                                    output.Write(oBuf, 0, oIndex);
                                                    oIndex = 0;
                                                }

                                                var temp425 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                var temp426 = ((uint)((int)((uint)(temp425)) % (int)((uint)((uint)10U))));
                                                var temp427 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp426)))))));
                                                oBuf[oIndex + 0] = (Byte)(temp427);
                                                var temp428 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                var temp429 = ((uint)((int)((uint)(temp428)) % (int)((uint)((uint)10U))));
                                                var temp430 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp429)))))));
                                                oBuf[oIndex + 1] = (Byte)(temp430);
                                                var temp431 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                var temp432 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp431)))))));
                                                oBuf[oIndex + 2] = (Byte)(temp432);
                                                oBuf[oIndex + 3] = (Byte)((byte)10U);
                                                oIndex += 4;
                                                s._4 = ((uint)(temp24));
                                                s._3 = ((byte)((byte)0U));
                                                s._2 = ((byte)((byte)0U));
                                                s._1 = ((byte)((byte)0U));
                                                s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                goto M8;
                                            }
                                        }
                                        else
                                        {
                                            if (oIndex > 16381)
                                            {
                                                output.Write(oBuf, 0, oIndex);
                                                oIndex = 0;
                                            }

                                            var temp433 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                            var temp434 = ((uint)((int)((uint)(temp433)) % (int)((uint)((uint)10U))));
                                            var temp435 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp434)))))));
                                            oBuf[oIndex + 0] = (Byte)(temp435);
                                            var temp436 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                            var temp437 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp436)))))));
                                            oBuf[oIndex + 1] = (Byte)(temp437);
                                            oBuf[oIndex + 2] = (Byte)((byte)10U);
                                            oIndex += 3;
                                            s._4 = ((uint)(temp24));
                                            s._3 = ((byte)((byte)0U));
                                            s._2 = ((byte)((byte)0U));
                                            s._1 = ((byte)((byte)0U));
                                            s._0 = ((byte)(((byte)((uint)(temp21)))));
                                            goto M8;
                                        }
                                    }
                                    else
                                    {
                                        if (oIndex > 16382)
                                        {
                                            output.Write(oBuf, 0, oIndex);
                                            oIndex = 0;
                                        }

                                        var temp438 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                        var temp439 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp438)))))));
                                        oBuf[oIndex + 0] = (Byte)(temp439);
                                        oBuf[oIndex + 1] = (Byte)((byte)10U);
                                        oIndex += 2;
                                        s._4 = ((uint)(temp24));
                                        s._3 = ((byte)((byte)0U));
                                        s._2 = ((byte)((byte)0U));
                                        s._1 = ((byte)((byte)0U));
                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                        goto M8;
                                    }
                                }
                            }
                        }
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
                        var temp440 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp440)
                        {
                            goto M9;
                        }
                        else
                        {
                            var temp441 = ((byte)((byte)(((byte)((byte)((s)._0))) & 15L)) << 4);
                            var temp442 = Fun0(((byte)(i)));
                            var temp443 = ((uint)(((int)((uint)(temp442))) >> (int)((uint)((uint)2U))));
                            var temp444 = ((byte)(((byte)(temp441)) | ((byte)(((byte)((uint)(temp443)))))));
                            s._1 = ((byte)(temp444));
                            s._0 = ((byte)(((byte)((uint)(temp442)))));
                            goto M10;
                        }
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
                        var temp445 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp445)
                        {
                            goto M26;
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
                        var temp446 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp446)
                        {
                            goto M11;
                        }
                        else
                        {
                            var temp447 = ((byte)((byte)(((byte)((byte)((s)._0))) & 3L)) << 6);
                            var temp448 = Fun0(((byte)(i)));
                            var temp449 = ((byte)(((byte)(temp447)) | ((byte)(((byte)((uint)(temp448)))))));
                            s._2 = ((byte)(temp449));
                            s._0 = ((byte)((byte)0U));
                            goto M12;
                        }
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
                    throw new Exception();
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
                        var temp450 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp450)
                            throw new Exception();
                        else
                        {
                            var temp451 = Fun0(((byte)(i)));
                            s._0 = ((byte)(((byte)((uint)(temp451)))));
                            goto M13;
                        }
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
                        var temp452 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp452)
                            throw new Exception();
                        else
                        {
                            var temp453 = ((byte)((byte)(((byte)((byte)((s)._0))) & 63L)) << 2);
                            var temp454 = Fun0(((byte)(i)));
                            var temp455 = ((uint)(((int)((uint)(temp454))) >> (int)((uint)((uint)4U))));
                            var temp456 = ((byte)(((byte)(temp453)) | ((byte)(((byte)((uint)(temp455)))))));
                            s._3 = ((byte)(temp456));
                            s._0 = ((byte)(((byte)((uint)(temp454)))));
                            goto M14;
                        }
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
                        var temp457 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp457)
                        {
                            goto M15;
                        }
                        else
                        {
                            var temp458 = ((byte)((byte)(((byte)((byte)((s)._0))) & 15L)) << 4);
                            var temp459 = Fun0(((byte)(i)));
                            var temp460 = ((uint)(((int)((uint)(temp459))) >> (int)((uint)((uint)2U))));
                            var temp461 = ((byte)(((byte)(temp458)) | ((byte)(((byte)((uint)(temp460)))))));
                            var temp462 = ((((uint)((byte)((s)._1)) << 8) | (uint)((byte)((s)._2)) << 8) | (uint)((byte)((s)._3)) << 8) | (uint)((byte)(temp461));
                            var temp463 = (((uint)(temp462)) == ((uint)((s)._4)));
                            if (temp463)
                            {
                                if (oIndex > 16383)
                                {
                                    output.Write(oBuf, 0, oIndex);
                                    oIndex = 0;
                                }

                                oBuf[oIndex + 0] = (Byte)((byte)48U);
                                oIndex += 1;
                                s._4 = ((uint)(temp462));
                                s._3 = ((byte)((byte)0U));
                                s._2 = ((byte)((byte)0U));
                                s._1 = ((byte)((byte)0U));
                                s._0 = ((byte)(((byte)((uint)(temp459)))));
                                goto M16;
                            }
                            else
                            {
                                var temp464 = ((uint)(((uint)((uint)4294967295U)) * ((uint)((s)._4))));
                                var temp465 = ((uint)(((uint)(temp462)) + ((uint)(temp464))));
                                var temp466 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp465)));
                                var temp467 = !(temp466);
                                if (temp467)
                                {
                                    var temp468 = ((byte)(((uint)(temp465)) >> 31));
                                    var temp469 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 32) | (ulong)((uint)(temp465));
                                    var temp470 = ((ulong)(((ulong)((ulong)18446744073709551615UL)) * ((ulong)(temp469))));
                                    var temp471 = Fun1(((ulong)(temp470)));
                                    var temp472 = ((uint)(((uint)((uint)4294967295U)) + ((uint)(temp471))));
                                    var temp473 = ((int)((uint)(temp472)) <= (int)((uint)((uint)0U)));
                                    var temp474 = !(temp473);
                                    if (temp474)
                                    {
                                        var temp475 = ((int)((uint)(temp472)) <= (int)((uint)((uint)1U)));
                                        var temp476 = !(temp475);
                                        if (temp476)
                                        {
                                            var temp477 = ((int)((uint)(temp472)) <= (int)((uint)((uint)2U)));
                                            var temp478 = !(temp477);
                                            if (temp478)
                                            {
                                                var temp479 = ((int)((uint)(temp472)) <= (int)((uint)((uint)3U)));
                                                var temp480 = !(temp479);
                                                if (temp480)
                                                {
                                                    var temp481 = ((int)((uint)(temp472)) <= (int)((uint)((uint)4U)));
                                                    var temp482 = !(temp481);
                                                    if (temp482)
                                                    {
                                                        var temp483 = ((int)((uint)(temp472)) <= (int)((uint)((uint)5U)));
                                                        var temp484 = !(temp483);
                                                        if (temp484)
                                                        {
                                                            var temp485 = ((int)((uint)(temp472)) <= (int)((uint)((uint)6U)));
                                                            var temp486 = !(temp485);
                                                            if (temp486)
                                                            {
                                                                var temp487 = ((int)((uint)(temp472)) <= (int)((uint)((uint)7U)));
                                                                var temp488 = !(temp487);
                                                                if (temp488)
                                                                {
                                                                    var temp489 = ((int)((uint)(temp472)) <= (int)((uint)((uint)8U)));
                                                                    var temp490 = !(temp489);
                                                                    if (temp490)
                                                                    {
                                                                        if (oIndex > 16372)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                        var temp491 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000000U))));
                                                                        var temp492 = ((uint)((int)((uint)(temp491)) % (int)((uint)((uint)10U))));
                                                                        var temp493 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp492)))))));
                                                                        var temp494 = ((byte)(((byte)((byte)48U)) + ((byte)(temp493))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp494);
                                                                        var temp495 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000000U))));
                                                                        var temp496 = ((uint)((int)((uint)(temp495)) % (int)((uint)((uint)10U))));
                                                                        var temp497 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp496)))))));
                                                                        var temp498 = ((byte)(((byte)((byte)48U)) + ((byte)(temp497))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp498);
                                                                        var temp499 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000000U))));
                                                                        var temp500 = ((uint)((int)((uint)(temp499)) % (int)((uint)((uint)10U))));
                                                                        var temp501 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp500)))))));
                                                                        var temp502 = ((byte)(((byte)((byte)48U)) + ((byte)(temp501))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp502);
                                                                        var temp503 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                        var temp504 = ((uint)((int)((uint)(temp503)) % (int)((uint)((uint)10U))));
                                                                        var temp505 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp504)))))));
                                                                        var temp506 = ((byte)(((byte)((byte)48U)) + ((byte)(temp505))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp506);
                                                                        var temp507 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                        var temp508 = ((uint)((int)((uint)(temp507)) % (int)((uint)((uint)10U))));
                                                                        var temp509 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp508)))))));
                                                                        var temp510 = ((byte)(((byte)((byte)48U)) + ((byte)(temp509))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp510);
                                                                        var temp511 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                        var temp512 = ((uint)((int)((uint)(temp511)) % (int)((uint)((uint)10U))));
                                                                        var temp513 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp512)))))));
                                                                        var temp514 = ((byte)(((byte)((byte)48U)) + ((byte)(temp513))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp514);
                                                                        var temp515 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                        var temp516 = ((uint)((int)((uint)(temp515)) % (int)((uint)((uint)10U))));
                                                                        var temp517 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp516)))))));
                                                                        var temp518 = ((byte)(((byte)((byte)48U)) + ((byte)(temp517))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp518);
                                                                        var temp519 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                        var temp520 = ((uint)((int)((uint)(temp519)) % (int)((uint)((uint)10U))));
                                                                        var temp521 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp520)))))));
                                                                        var temp522 = ((byte)(((byte)((byte)48U)) + ((byte)(temp521))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp522);
                                                                        var temp523 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                        var temp524 = ((uint)((int)((uint)(temp523)) % (int)((uint)((uint)10U))));
                                                                        var temp525 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp524)))))));
                                                                        var temp526 = ((byte)(((byte)((byte)48U)) + ((byte)(temp525))));
                                                                        oBuf[oIndex + 9] = (Byte)(temp526);
                                                                        var temp527 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                        var temp528 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp527)))))));
                                                                        var temp529 = ((byte)(((byte)((byte)48U)) + ((byte)(temp528))));
                                                                        oBuf[oIndex + 10] = (Byte)(temp529);
                                                                        oBuf[oIndex + 11] = (Byte)((byte)10U);
                                                                        oIndex += 12;
                                                                        s._4 = ((uint)(temp462));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                        goto M16;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (oIndex > 16373)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                        var temp530 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000000U))));
                                                                        var temp531 = ((uint)((int)((uint)(temp530)) % (int)((uint)((uint)10U))));
                                                                        var temp532 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp531)))))));
                                                                        var temp533 = ((byte)(((byte)((byte)48U)) + ((byte)(temp532))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp533);
                                                                        var temp534 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000000U))));
                                                                        var temp535 = ((uint)((int)((uint)(temp534)) % (int)((uint)((uint)10U))));
                                                                        var temp536 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp535)))))));
                                                                        var temp537 = ((byte)(((byte)((byte)48U)) + ((byte)(temp536))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp537);
                                                                        var temp538 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                        var temp539 = ((uint)((int)((uint)(temp538)) % (int)((uint)((uint)10U))));
                                                                        var temp540 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp539)))))));
                                                                        var temp541 = ((byte)(((byte)((byte)48U)) + ((byte)(temp540))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp541);
                                                                        var temp542 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                        var temp543 = ((uint)((int)((uint)(temp542)) % (int)((uint)((uint)10U))));
                                                                        var temp544 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp543)))))));
                                                                        var temp545 = ((byte)(((byte)((byte)48U)) + ((byte)(temp544))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp545);
                                                                        var temp546 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                        var temp547 = ((uint)((int)((uint)(temp546)) % (int)((uint)((uint)10U))));
                                                                        var temp548 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp547)))))));
                                                                        var temp549 = ((byte)(((byte)((byte)48U)) + ((byte)(temp548))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp549);
                                                                        var temp550 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                        var temp551 = ((uint)((int)((uint)(temp550)) % (int)((uint)((uint)10U))));
                                                                        var temp552 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp551)))))));
                                                                        var temp553 = ((byte)(((byte)((byte)48U)) + ((byte)(temp552))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp553);
                                                                        var temp554 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                        var temp555 = ((uint)((int)((uint)(temp554)) % (int)((uint)((uint)10U))));
                                                                        var temp556 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp555)))))));
                                                                        var temp557 = ((byte)(((byte)((byte)48U)) + ((byte)(temp556))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp557);
                                                                        var temp558 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                        var temp559 = ((uint)((int)((uint)(temp558)) % (int)((uint)((uint)10U))));
                                                                        var temp560 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp559)))))));
                                                                        var temp561 = ((byte)(((byte)((byte)48U)) + ((byte)(temp560))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp561);
                                                                        var temp562 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                        var temp563 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp562)))))));
                                                                        var temp564 = ((byte)(((byte)((byte)48U)) + ((byte)(temp563))));
                                                                        oBuf[oIndex + 9] = (Byte)(temp564);
                                                                        oBuf[oIndex + 10] = (Byte)((byte)10U);
                                                                        oIndex += 11;
                                                                        s._4 = ((uint)(temp462));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                        goto M16;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (oIndex > 16374)
                                                                    {
                                                                        output.Write(oBuf, 0, oIndex);
                                                                        oIndex = 0;
                                                                    }

                                                                    oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                    var temp565 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000000U))));
                                                                    var temp566 = ((uint)((int)((uint)(temp565)) % (int)((uint)((uint)10U))));
                                                                    var temp567 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp566)))))));
                                                                    var temp568 = ((byte)(((byte)((byte)48U)) + ((byte)(temp567))));
                                                                    oBuf[oIndex + 1] = (Byte)(temp568);
                                                                    var temp569 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                    var temp570 = ((uint)((int)((uint)(temp569)) % (int)((uint)((uint)10U))));
                                                                    var temp571 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp570)))))));
                                                                    var temp572 = ((byte)(((byte)((byte)48U)) + ((byte)(temp571))));
                                                                    oBuf[oIndex + 2] = (Byte)(temp572);
                                                                    var temp573 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                    var temp574 = ((uint)((int)((uint)(temp573)) % (int)((uint)((uint)10U))));
                                                                    var temp575 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp574)))))));
                                                                    var temp576 = ((byte)(((byte)((byte)48U)) + ((byte)(temp575))));
                                                                    oBuf[oIndex + 3] = (Byte)(temp576);
                                                                    var temp577 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                    var temp578 = ((uint)((int)((uint)(temp577)) % (int)((uint)((uint)10U))));
                                                                    var temp579 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp578)))))));
                                                                    var temp580 = ((byte)(((byte)((byte)48U)) + ((byte)(temp579))));
                                                                    oBuf[oIndex + 4] = (Byte)(temp580);
                                                                    var temp581 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                    var temp582 = ((uint)((int)((uint)(temp581)) % (int)((uint)((uint)10U))));
                                                                    var temp583 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp582)))))));
                                                                    var temp584 = ((byte)(((byte)((byte)48U)) + ((byte)(temp583))));
                                                                    oBuf[oIndex + 5] = (Byte)(temp584);
                                                                    var temp585 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                    var temp586 = ((uint)((int)((uint)(temp585)) % (int)((uint)((uint)10U))));
                                                                    var temp587 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp586)))))));
                                                                    var temp588 = ((byte)(((byte)((byte)48U)) + ((byte)(temp587))));
                                                                    oBuf[oIndex + 6] = (Byte)(temp588);
                                                                    var temp589 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                    var temp590 = ((uint)((int)((uint)(temp589)) % (int)((uint)((uint)10U))));
                                                                    var temp591 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp590)))))));
                                                                    var temp592 = ((byte)(((byte)((byte)48U)) + ((byte)(temp591))));
                                                                    oBuf[oIndex + 7] = (Byte)(temp592);
                                                                    var temp593 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                    var temp594 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp593)))))));
                                                                    var temp595 = ((byte)(((byte)((byte)48U)) + ((byte)(temp594))));
                                                                    oBuf[oIndex + 8] = (Byte)(temp595);
                                                                    oBuf[oIndex + 9] = (Byte)((byte)10U);
                                                                    oIndex += 10;
                                                                    s._4 = ((uint)(temp462));
                                                                    s._3 = ((byte)((byte)0U));
                                                                    s._2 = ((byte)((byte)0U));
                                                                    s._1 = ((byte)((byte)0U));
                                                                    s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                    goto M16;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (oIndex > 16375)
                                                                {
                                                                    output.Write(oBuf, 0, oIndex);
                                                                    oIndex = 0;
                                                                }

                                                                oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                var temp596 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                var temp597 = ((uint)((int)((uint)(temp596)) % (int)((uint)((uint)10U))));
                                                                var temp598 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp597)))))));
                                                                var temp599 = ((byte)(((byte)((byte)48U)) + ((byte)(temp598))));
                                                                oBuf[oIndex + 1] = (Byte)(temp599);
                                                                var temp600 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                var temp601 = ((uint)((int)((uint)(temp600)) % (int)((uint)((uint)10U))));
                                                                var temp602 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp601)))))));
                                                                var temp603 = ((byte)(((byte)((byte)48U)) + ((byte)(temp602))));
                                                                oBuf[oIndex + 2] = (Byte)(temp603);
                                                                var temp604 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                var temp605 = ((uint)((int)((uint)(temp604)) % (int)((uint)((uint)10U))));
                                                                var temp606 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp605)))))));
                                                                var temp607 = ((byte)(((byte)((byte)48U)) + ((byte)(temp606))));
                                                                oBuf[oIndex + 3] = (Byte)(temp607);
                                                                var temp608 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                var temp609 = ((uint)((int)((uint)(temp608)) % (int)((uint)((uint)10U))));
                                                                var temp610 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp609)))))));
                                                                var temp611 = ((byte)(((byte)((byte)48U)) + ((byte)(temp610))));
                                                                oBuf[oIndex + 4] = (Byte)(temp611);
                                                                var temp612 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                var temp613 = ((uint)((int)((uint)(temp612)) % (int)((uint)((uint)10U))));
                                                                var temp614 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp613)))))));
                                                                var temp615 = ((byte)(((byte)((byte)48U)) + ((byte)(temp614))));
                                                                oBuf[oIndex + 5] = (Byte)(temp615);
                                                                var temp616 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                var temp617 = ((uint)((int)((uint)(temp616)) % (int)((uint)((uint)10U))));
                                                                var temp618 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp617)))))));
                                                                var temp619 = ((byte)(((byte)((byte)48U)) + ((byte)(temp618))));
                                                                oBuf[oIndex + 6] = (Byte)(temp619);
                                                                var temp620 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                var temp621 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp620)))))));
                                                                var temp622 = ((byte)(((byte)((byte)48U)) + ((byte)(temp621))));
                                                                oBuf[oIndex + 7] = (Byte)(temp622);
                                                                oBuf[oIndex + 8] = (Byte)((byte)10U);
                                                                oIndex += 9;
                                                                s._4 = ((uint)(temp462));
                                                                s._3 = ((byte)((byte)0U));
                                                                s._2 = ((byte)((byte)0U));
                                                                s._1 = ((byte)((byte)0U));
                                                                s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                goto M16;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (oIndex > 16376)
                                                            {
                                                                output.Write(oBuf, 0, oIndex);
                                                                oIndex = 0;
                                                            }

                                                            oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                            var temp623 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                            var temp624 = ((uint)((int)((uint)(temp623)) % (int)((uint)((uint)10U))));
                                                            var temp625 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp624)))))));
                                                            var temp626 = ((byte)(((byte)((byte)48U)) + ((byte)(temp625))));
                                                            oBuf[oIndex + 1] = (Byte)(temp626);
                                                            var temp627 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                            var temp628 = ((uint)((int)((uint)(temp627)) % (int)((uint)((uint)10U))));
                                                            var temp629 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp628)))))));
                                                            var temp630 = ((byte)(((byte)((byte)48U)) + ((byte)(temp629))));
                                                            oBuf[oIndex + 2] = (Byte)(temp630);
                                                            var temp631 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                            var temp632 = ((uint)((int)((uint)(temp631)) % (int)((uint)((uint)10U))));
                                                            var temp633 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp632)))))));
                                                            var temp634 = ((byte)(((byte)((byte)48U)) + ((byte)(temp633))));
                                                            oBuf[oIndex + 3] = (Byte)(temp634);
                                                            var temp635 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                            var temp636 = ((uint)((int)((uint)(temp635)) % (int)((uint)((uint)10U))));
                                                            var temp637 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp636)))))));
                                                            var temp638 = ((byte)(((byte)((byte)48U)) + ((byte)(temp637))));
                                                            oBuf[oIndex + 4] = (Byte)(temp638);
                                                            var temp639 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                            var temp640 = ((uint)((int)((uint)(temp639)) % (int)((uint)((uint)10U))));
                                                            var temp641 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp640)))))));
                                                            var temp642 = ((byte)(((byte)((byte)48U)) + ((byte)(temp641))));
                                                            oBuf[oIndex + 5] = (Byte)(temp642);
                                                            var temp643 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                            var temp644 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp643)))))));
                                                            var temp645 = ((byte)(((byte)((byte)48U)) + ((byte)(temp644))));
                                                            oBuf[oIndex + 6] = (Byte)(temp645);
                                                            oBuf[oIndex + 7] = (Byte)((byte)10U);
                                                            oIndex += 8;
                                                            s._4 = ((uint)(temp462));
                                                            s._3 = ((byte)((byte)0U));
                                                            s._2 = ((byte)((byte)0U));
                                                            s._1 = ((byte)((byte)0U));
                                                            s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                            goto M16;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (oIndex > 16377)
                                                        {
                                                            output.Write(oBuf, 0, oIndex);
                                                            oIndex = 0;
                                                        }

                                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                        var temp646 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                        var temp647 = ((uint)((int)((uint)(temp646)) % (int)((uint)((uint)10U))));
                                                        var temp648 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp647)))))));
                                                        var temp649 = ((byte)(((byte)((byte)48U)) + ((byte)(temp648))));
                                                        oBuf[oIndex + 1] = (Byte)(temp649);
                                                        var temp650 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                        var temp651 = ((uint)((int)((uint)(temp650)) % (int)((uint)((uint)10U))));
                                                        var temp652 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp651)))))));
                                                        var temp653 = ((byte)(((byte)((byte)48U)) + ((byte)(temp652))));
                                                        oBuf[oIndex + 2] = (Byte)(temp653);
                                                        var temp654 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                        var temp655 = ((uint)((int)((uint)(temp654)) % (int)((uint)((uint)10U))));
                                                        var temp656 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp655)))))));
                                                        var temp657 = ((byte)(((byte)((byte)48U)) + ((byte)(temp656))));
                                                        oBuf[oIndex + 3] = (Byte)(temp657);
                                                        var temp658 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                        var temp659 = ((uint)((int)((uint)(temp658)) % (int)((uint)((uint)10U))));
                                                        var temp660 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp659)))))));
                                                        var temp661 = ((byte)(((byte)((byte)48U)) + ((byte)(temp660))));
                                                        oBuf[oIndex + 4] = (Byte)(temp661);
                                                        var temp662 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                        var temp663 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp662)))))));
                                                        var temp664 = ((byte)(((byte)((byte)48U)) + ((byte)(temp663))));
                                                        oBuf[oIndex + 5] = (Byte)(temp664);
                                                        oBuf[oIndex + 6] = (Byte)((byte)10U);
                                                        oIndex += 7;
                                                        s._4 = ((uint)(temp462));
                                                        s._3 = ((byte)((byte)0U));
                                                        s._2 = ((byte)((byte)0U));
                                                        s._1 = ((byte)((byte)0U));
                                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                        goto M16;
                                                    }
                                                }
                                                else
                                                {
                                                    if (oIndex > 16378)
                                                    {
                                                        output.Write(oBuf, 0, oIndex);
                                                        oIndex = 0;
                                                    }

                                                    oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                    var temp665 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                    var temp666 = ((uint)((int)((uint)(temp665)) % (int)((uint)((uint)10U))));
                                                    var temp667 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp666)))))));
                                                    var temp668 = ((byte)(((byte)((byte)48U)) + ((byte)(temp667))));
                                                    oBuf[oIndex + 1] = (Byte)(temp668);
                                                    var temp669 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                    var temp670 = ((uint)((int)((uint)(temp669)) % (int)((uint)((uint)10U))));
                                                    var temp671 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp670)))))));
                                                    var temp672 = ((byte)(((byte)((byte)48U)) + ((byte)(temp671))));
                                                    oBuf[oIndex + 2] = (Byte)(temp672);
                                                    var temp673 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                    var temp674 = ((uint)((int)((uint)(temp673)) % (int)((uint)((uint)10U))));
                                                    var temp675 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp674)))))));
                                                    var temp676 = ((byte)(((byte)((byte)48U)) + ((byte)(temp675))));
                                                    oBuf[oIndex + 3] = (Byte)(temp676);
                                                    var temp677 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                    var temp678 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp677)))))));
                                                    var temp679 = ((byte)(((byte)((byte)48U)) + ((byte)(temp678))));
                                                    oBuf[oIndex + 4] = (Byte)(temp679);
                                                    oBuf[oIndex + 5] = (Byte)((byte)10U);
                                                    oIndex += 6;
                                                    s._4 = ((uint)(temp462));
                                                    s._3 = ((byte)((byte)0U));
                                                    s._2 = ((byte)((byte)0U));
                                                    s._1 = ((byte)((byte)0U));
                                                    s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                    goto M16;
                                                }
                                            }
                                            else
                                            {
                                                if (oIndex > 16379)
                                                {
                                                    output.Write(oBuf, 0, oIndex);
                                                    oIndex = 0;
                                                }

                                                oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                var temp680 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                var temp681 = ((uint)((int)((uint)(temp680)) % (int)((uint)((uint)10U))));
                                                var temp682 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp681)))))));
                                                var temp683 = ((byte)(((byte)((byte)48U)) + ((byte)(temp682))));
                                                oBuf[oIndex + 1] = (Byte)(temp683);
                                                var temp684 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                var temp685 = ((uint)((int)((uint)(temp684)) % (int)((uint)((uint)10U))));
                                                var temp686 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp685)))))));
                                                var temp687 = ((byte)(((byte)((byte)48U)) + ((byte)(temp686))));
                                                oBuf[oIndex + 2] = (Byte)(temp687);
                                                var temp688 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                var temp689 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp688)))))));
                                                var temp690 = ((byte)(((byte)((byte)48U)) + ((byte)(temp689))));
                                                oBuf[oIndex + 3] = (Byte)(temp690);
                                                oBuf[oIndex + 4] = (Byte)((byte)10U);
                                                oIndex += 5;
                                                s._4 = ((uint)(temp462));
                                                s._3 = ((byte)((byte)0U));
                                                s._2 = ((byte)((byte)0U));
                                                s._1 = ((byte)((byte)0U));
                                                s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                goto M16;
                                            }
                                        }
                                        else
                                        {
                                            if (oIndex > 16380)
                                            {
                                                output.Write(oBuf, 0, oIndex);
                                                oIndex = 0;
                                            }

                                            oBuf[oIndex + 0] = (Byte)((byte)45U);
                                            var temp691 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                            var temp692 = ((uint)((int)((uint)(temp691)) % (int)((uint)((uint)10U))));
                                            var temp693 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp692)))))));
                                            var temp694 = ((byte)(((byte)((byte)48U)) + ((byte)(temp693))));
                                            oBuf[oIndex + 1] = (Byte)(temp694);
                                            var temp695 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                            var temp696 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp695)))))));
                                            var temp697 = ((byte)(((byte)((byte)48U)) + ((byte)(temp696))));
                                            oBuf[oIndex + 2] = (Byte)(temp697);
                                            oBuf[oIndex + 3] = (Byte)((byte)10U);
                                            oIndex += 4;
                                            s._4 = ((uint)(temp462));
                                            s._3 = ((byte)((byte)0U));
                                            s._2 = ((byte)((byte)0U));
                                            s._1 = ((byte)((byte)0U));
                                            s._0 = ((byte)(((byte)((uint)(temp459)))));
                                            goto M16;
                                        }
                                    }
                                    else
                                    {
                                        if (oIndex > 16381)
                                        {
                                            output.Write(oBuf, 0, oIndex);
                                            oIndex = 0;
                                        }

                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                        var temp698 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                        var temp699 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp698)))))));
                                        var temp700 = ((byte)(((byte)((byte)48U)) + ((byte)(temp699))));
                                        oBuf[oIndex + 1] = (Byte)(temp700);
                                        oBuf[oIndex + 2] = (Byte)((byte)10U);
                                        oIndex += 3;
                                        s._4 = ((uint)(temp462));
                                        s._3 = ((byte)((byte)0U));
                                        s._2 = ((byte)((byte)0U));
                                        s._1 = ((byte)((byte)0U));
                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                        goto M16;
                                    }
                                }
                                else
                                {
                                    var temp701 = ((byte)(((uint)(temp465)) >> 31));
                                    var temp702 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 32) | (ulong)((uint)(temp465));
                                    var temp703 = Fun1(((ulong)(temp702)));
                                    var temp704 = ((uint)(((uint)((uint)4294967295U)) + ((uint)(temp703))));
                                    var temp705 = ((int)((uint)(temp704)) <= (int)((uint)((uint)0U)));
                                    var temp706 = !(temp705);
                                    if (temp706)
                                    {
                                        var temp707 = ((int)((uint)(temp704)) <= (int)((uint)((uint)1U)));
                                        var temp708 = !(temp707);
                                        if (temp708)
                                        {
                                            var temp709 = ((int)((uint)(temp704)) <= (int)((uint)((uint)2U)));
                                            var temp710 = !(temp709);
                                            if (temp710)
                                            {
                                                var temp711 = ((int)((uint)(temp704)) <= (int)((uint)((uint)3U)));
                                                var temp712 = !(temp711);
                                                if (temp712)
                                                {
                                                    var temp713 = ((int)((uint)(temp704)) <= (int)((uint)((uint)4U)));
                                                    var temp714 = !(temp713);
                                                    if (temp714)
                                                    {
                                                        var temp715 = ((int)((uint)(temp704)) <= (int)((uint)((uint)5U)));
                                                        var temp716 = !(temp715);
                                                        if (temp716)
                                                        {
                                                            var temp717 = ((int)((uint)(temp704)) <= (int)((uint)((uint)6U)));
                                                            var temp718 = !(temp717);
                                                            if (temp718)
                                                            {
                                                                var temp719 = ((int)((uint)(temp704)) <= (int)((uint)((uint)7U)));
                                                                var temp720 = !(temp719);
                                                                if (temp720)
                                                                {
                                                                    var temp721 = ((int)((uint)(temp704)) <= (int)((uint)((uint)8U)));
                                                                    var temp722 = !(temp721);
                                                                    if (temp722)
                                                                    {
                                                                        if (oIndex > 16373)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        var temp723 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000000U))));
                                                                        var temp724 = ((uint)((int)((uint)(temp723)) % (int)((uint)((uint)10U))));
                                                                        var temp725 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp724)))))));
                                                                        oBuf[oIndex + 0] = (Byte)(temp725);
                                                                        var temp726 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000000U))));
                                                                        var temp727 = ((uint)((int)((uint)(temp726)) % (int)((uint)((uint)10U))));
                                                                        var temp728 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp727)))))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp728);
                                                                        var temp729 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000000U))));
                                                                        var temp730 = ((uint)((int)((uint)(temp729)) % (int)((uint)((uint)10U))));
                                                                        var temp731 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp730)))))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp731);
                                                                        var temp732 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                        var temp733 = ((uint)((int)((uint)(temp732)) % (int)((uint)((uint)10U))));
                                                                        var temp734 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp733)))))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp734);
                                                                        var temp735 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                        var temp736 = ((uint)((int)((uint)(temp735)) % (int)((uint)((uint)10U))));
                                                                        var temp737 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp736)))))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp737);
                                                                        var temp738 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                        var temp739 = ((uint)((int)((uint)(temp738)) % (int)((uint)((uint)10U))));
                                                                        var temp740 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp739)))))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp740);
                                                                        var temp741 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                        var temp742 = ((uint)((int)((uint)(temp741)) % (int)((uint)((uint)10U))));
                                                                        var temp743 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp742)))))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp743);
                                                                        var temp744 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                        var temp745 = ((uint)((int)((uint)(temp744)) % (int)((uint)((uint)10U))));
                                                                        var temp746 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp745)))))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp746);
                                                                        var temp747 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                        var temp748 = ((uint)((int)((uint)(temp747)) % (int)((uint)((uint)10U))));
                                                                        var temp749 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp748)))))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp749);
                                                                        var temp750 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                        var temp751 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp750)))))));
                                                                        oBuf[oIndex + 9] = (Byte)(temp751);
                                                                        oBuf[oIndex + 10] = (Byte)((byte)10U);
                                                                        oIndex += 11;
                                                                        s._4 = ((uint)(temp462));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                        goto M16;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (oIndex > 16374)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        var temp752 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000000U))));
                                                                        var temp753 = ((uint)((int)((uint)(temp752)) % (int)((uint)((uint)10U))));
                                                                        var temp754 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp753)))))));
                                                                        oBuf[oIndex + 0] = (Byte)(temp754);
                                                                        var temp755 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000000U))));
                                                                        var temp756 = ((uint)((int)((uint)(temp755)) % (int)((uint)((uint)10U))));
                                                                        var temp757 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp756)))))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp757);
                                                                        var temp758 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                        var temp759 = ((uint)((int)((uint)(temp758)) % (int)((uint)((uint)10U))));
                                                                        var temp760 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp759)))))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp760);
                                                                        var temp761 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                        var temp762 = ((uint)((int)((uint)(temp761)) % (int)((uint)((uint)10U))));
                                                                        var temp763 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp762)))))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp763);
                                                                        var temp764 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                        var temp765 = ((uint)((int)((uint)(temp764)) % (int)((uint)((uint)10U))));
                                                                        var temp766 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp765)))))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp766);
                                                                        var temp767 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                        var temp768 = ((uint)((int)((uint)(temp767)) % (int)((uint)((uint)10U))));
                                                                        var temp769 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp768)))))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp769);
                                                                        var temp770 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                        var temp771 = ((uint)((int)((uint)(temp770)) % (int)((uint)((uint)10U))));
                                                                        var temp772 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp771)))))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp772);
                                                                        var temp773 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                        var temp774 = ((uint)((int)((uint)(temp773)) % (int)((uint)((uint)10U))));
                                                                        var temp775 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp774)))))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp775);
                                                                        var temp776 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                        var temp777 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp776)))))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp777);
                                                                        oBuf[oIndex + 9] = (Byte)((byte)10U);
                                                                        oIndex += 10;
                                                                        s._4 = ((uint)(temp462));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                        goto M16;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (oIndex > 16375)
                                                                    {
                                                                        output.Write(oBuf, 0, oIndex);
                                                                        oIndex = 0;
                                                                    }

                                                                    var temp778 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000000U))));
                                                                    var temp779 = ((uint)((int)((uint)(temp778)) % (int)((uint)((uint)10U))));
                                                                    var temp780 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp779)))))));
                                                                    oBuf[oIndex + 0] = (Byte)(temp780);
                                                                    var temp781 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                    var temp782 = ((uint)((int)((uint)(temp781)) % (int)((uint)((uint)10U))));
                                                                    var temp783 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp782)))))));
                                                                    oBuf[oIndex + 1] = (Byte)(temp783);
                                                                    var temp784 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                    var temp785 = ((uint)((int)((uint)(temp784)) % (int)((uint)((uint)10U))));
                                                                    var temp786 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp785)))))));
                                                                    oBuf[oIndex + 2] = (Byte)(temp786);
                                                                    var temp787 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                    var temp788 = ((uint)((int)((uint)(temp787)) % (int)((uint)((uint)10U))));
                                                                    var temp789 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp788)))))));
                                                                    oBuf[oIndex + 3] = (Byte)(temp789);
                                                                    var temp790 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                    var temp791 = ((uint)((int)((uint)(temp790)) % (int)((uint)((uint)10U))));
                                                                    var temp792 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp791)))))));
                                                                    oBuf[oIndex + 4] = (Byte)(temp792);
                                                                    var temp793 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                    var temp794 = ((uint)((int)((uint)(temp793)) % (int)((uint)((uint)10U))));
                                                                    var temp795 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp794)))))));
                                                                    oBuf[oIndex + 5] = (Byte)(temp795);
                                                                    var temp796 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                    var temp797 = ((uint)((int)((uint)(temp796)) % (int)((uint)((uint)10U))));
                                                                    var temp798 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp797)))))));
                                                                    oBuf[oIndex + 6] = (Byte)(temp798);
                                                                    var temp799 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                    var temp800 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp799)))))));
                                                                    oBuf[oIndex + 7] = (Byte)(temp800);
                                                                    oBuf[oIndex + 8] = (Byte)((byte)10U);
                                                                    oIndex += 9;
                                                                    s._4 = ((uint)(temp462));
                                                                    s._3 = ((byte)((byte)0U));
                                                                    s._2 = ((byte)((byte)0U));
                                                                    s._1 = ((byte)((byte)0U));
                                                                    s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                    goto M16;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (oIndex > 16376)
                                                                {
                                                                    output.Write(oBuf, 0, oIndex);
                                                                    oIndex = 0;
                                                                }

                                                                var temp801 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                var temp802 = ((uint)((int)((uint)(temp801)) % (int)((uint)((uint)10U))));
                                                                var temp803 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp802)))))));
                                                                oBuf[oIndex + 0] = (Byte)(temp803);
                                                                var temp804 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                var temp805 = ((uint)((int)((uint)(temp804)) % (int)((uint)((uint)10U))));
                                                                var temp806 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp805)))))));
                                                                oBuf[oIndex + 1] = (Byte)(temp806);
                                                                var temp807 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                var temp808 = ((uint)((int)((uint)(temp807)) % (int)((uint)((uint)10U))));
                                                                var temp809 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp808)))))));
                                                                oBuf[oIndex + 2] = (Byte)(temp809);
                                                                var temp810 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                var temp811 = ((uint)((int)((uint)(temp810)) % (int)((uint)((uint)10U))));
                                                                var temp812 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp811)))))));
                                                                oBuf[oIndex + 3] = (Byte)(temp812);
                                                                var temp813 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                var temp814 = ((uint)((int)((uint)(temp813)) % (int)((uint)((uint)10U))));
                                                                var temp815 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp814)))))));
                                                                oBuf[oIndex + 4] = (Byte)(temp815);
                                                                var temp816 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                var temp817 = ((uint)((int)((uint)(temp816)) % (int)((uint)((uint)10U))));
                                                                var temp818 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp817)))))));
                                                                oBuf[oIndex + 5] = (Byte)(temp818);
                                                                var temp819 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                var temp820 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp819)))))));
                                                                oBuf[oIndex + 6] = (Byte)(temp820);
                                                                oBuf[oIndex + 7] = (Byte)((byte)10U);
                                                                oIndex += 8;
                                                                s._4 = ((uint)(temp462));
                                                                s._3 = ((byte)((byte)0U));
                                                                s._2 = ((byte)((byte)0U));
                                                                s._1 = ((byte)((byte)0U));
                                                                s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                goto M16;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (oIndex > 16377)
                                                            {
                                                                output.Write(oBuf, 0, oIndex);
                                                                oIndex = 0;
                                                            }

                                                            var temp821 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                            var temp822 = ((uint)((int)((uint)(temp821)) % (int)((uint)((uint)10U))));
                                                            var temp823 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp822)))))));
                                                            oBuf[oIndex + 0] = (Byte)(temp823);
                                                            var temp824 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                            var temp825 = ((uint)((int)((uint)(temp824)) % (int)((uint)((uint)10U))));
                                                            var temp826 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp825)))))));
                                                            oBuf[oIndex + 1] = (Byte)(temp826);
                                                            var temp827 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                            var temp828 = ((uint)((int)((uint)(temp827)) % (int)((uint)((uint)10U))));
                                                            var temp829 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp828)))))));
                                                            oBuf[oIndex + 2] = (Byte)(temp829);
                                                            var temp830 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                            var temp831 = ((uint)((int)((uint)(temp830)) % (int)((uint)((uint)10U))));
                                                            var temp832 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp831)))))));
                                                            oBuf[oIndex + 3] = (Byte)(temp832);
                                                            var temp833 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                            var temp834 = ((uint)((int)((uint)(temp833)) % (int)((uint)((uint)10U))));
                                                            var temp835 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp834)))))));
                                                            oBuf[oIndex + 4] = (Byte)(temp835);
                                                            var temp836 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                            var temp837 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp836)))))));
                                                            oBuf[oIndex + 5] = (Byte)(temp837);
                                                            oBuf[oIndex + 6] = (Byte)((byte)10U);
                                                            oIndex += 7;
                                                            s._4 = ((uint)(temp462));
                                                            s._3 = ((byte)((byte)0U));
                                                            s._2 = ((byte)((byte)0U));
                                                            s._1 = ((byte)((byte)0U));
                                                            s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                            goto M16;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (oIndex > 16378)
                                                        {
                                                            output.Write(oBuf, 0, oIndex);
                                                            oIndex = 0;
                                                        }

                                                        var temp838 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                        var temp839 = ((uint)((int)((uint)(temp838)) % (int)((uint)((uint)10U))));
                                                        var temp840 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp839)))))));
                                                        oBuf[oIndex + 0] = (Byte)(temp840);
                                                        var temp841 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                        var temp842 = ((uint)((int)((uint)(temp841)) % (int)((uint)((uint)10U))));
                                                        var temp843 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp842)))))));
                                                        oBuf[oIndex + 1] = (Byte)(temp843);
                                                        var temp844 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                        var temp845 = ((uint)((int)((uint)(temp844)) % (int)((uint)((uint)10U))));
                                                        var temp846 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp845)))))));
                                                        oBuf[oIndex + 2] = (Byte)(temp846);
                                                        var temp847 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                        var temp848 = ((uint)((int)((uint)(temp847)) % (int)((uint)((uint)10U))));
                                                        var temp849 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp848)))))));
                                                        oBuf[oIndex + 3] = (Byte)(temp849);
                                                        var temp850 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                        var temp851 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp850)))))));
                                                        oBuf[oIndex + 4] = (Byte)(temp851);
                                                        oBuf[oIndex + 5] = (Byte)((byte)10U);
                                                        oIndex += 6;
                                                        s._4 = ((uint)(temp462));
                                                        s._3 = ((byte)((byte)0U));
                                                        s._2 = ((byte)((byte)0U));
                                                        s._1 = ((byte)((byte)0U));
                                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                        goto M16;
                                                    }
                                                }
                                                else
                                                {
                                                    if (oIndex > 16379)
                                                    {
                                                        output.Write(oBuf, 0, oIndex);
                                                        oIndex = 0;
                                                    }

                                                    var temp852 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                    var temp853 = ((uint)((int)((uint)(temp852)) % (int)((uint)((uint)10U))));
                                                    var temp854 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp853)))))));
                                                    oBuf[oIndex + 0] = (Byte)(temp854);
                                                    var temp855 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                    var temp856 = ((uint)((int)((uint)(temp855)) % (int)((uint)((uint)10U))));
                                                    var temp857 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp856)))))));
                                                    oBuf[oIndex + 1] = (Byte)(temp857);
                                                    var temp858 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                    var temp859 = ((uint)((int)((uint)(temp858)) % (int)((uint)((uint)10U))));
                                                    var temp860 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp859)))))));
                                                    oBuf[oIndex + 2] = (Byte)(temp860);
                                                    var temp861 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                    var temp862 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp861)))))));
                                                    oBuf[oIndex + 3] = (Byte)(temp862);
                                                    oBuf[oIndex + 4] = (Byte)((byte)10U);
                                                    oIndex += 5;
                                                    s._4 = ((uint)(temp462));
                                                    s._3 = ((byte)((byte)0U));
                                                    s._2 = ((byte)((byte)0U));
                                                    s._1 = ((byte)((byte)0U));
                                                    s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                    goto M16;
                                                }
                                            }
                                            else
                                            {
                                                if (oIndex > 16380)
                                                {
                                                    output.Write(oBuf, 0, oIndex);
                                                    oIndex = 0;
                                                }

                                                var temp863 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                var temp864 = ((uint)((int)((uint)(temp863)) % (int)((uint)((uint)10U))));
                                                var temp865 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp864)))))));
                                                oBuf[oIndex + 0] = (Byte)(temp865);
                                                var temp866 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                var temp867 = ((uint)((int)((uint)(temp866)) % (int)((uint)((uint)10U))));
                                                var temp868 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp867)))))));
                                                oBuf[oIndex + 1] = (Byte)(temp868);
                                                var temp869 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                var temp870 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp869)))))));
                                                oBuf[oIndex + 2] = (Byte)(temp870);
                                                oBuf[oIndex + 3] = (Byte)((byte)10U);
                                                oIndex += 4;
                                                s._4 = ((uint)(temp462));
                                                s._3 = ((byte)((byte)0U));
                                                s._2 = ((byte)((byte)0U));
                                                s._1 = ((byte)((byte)0U));
                                                s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                goto M16;
                                            }
                                        }
                                        else
                                        {
                                            if (oIndex > 16381)
                                            {
                                                output.Write(oBuf, 0, oIndex);
                                                oIndex = 0;
                                            }

                                            var temp871 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                            var temp872 = ((uint)((int)((uint)(temp871)) % (int)((uint)((uint)10U))));
                                            var temp873 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp872)))))));
                                            oBuf[oIndex + 0] = (Byte)(temp873);
                                            var temp874 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                            var temp875 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp874)))))));
                                            oBuf[oIndex + 1] = (Byte)(temp875);
                                            oBuf[oIndex + 2] = (Byte)((byte)10U);
                                            oIndex += 3;
                                            s._4 = ((uint)(temp462));
                                            s._3 = ((byte)((byte)0U));
                                            s._2 = ((byte)((byte)0U));
                                            s._1 = ((byte)((byte)0U));
                                            s._0 = ((byte)(((byte)((uint)(temp459)))));
                                            goto M16;
                                        }
                                    }
                                    else
                                    {
                                        if (oIndex > 16382)
                                        {
                                            output.Write(oBuf, 0, oIndex);
                                            oIndex = 0;
                                        }

                                        var temp876 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                        var temp877 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp876)))))));
                                        oBuf[oIndex + 0] = (Byte)(temp877);
                                        oBuf[oIndex + 1] = (Byte)((byte)10U);
                                        oIndex += 2;
                                        s._4 = ((uint)(temp462));
                                        s._3 = ((byte)((byte)0U));
                                        s._2 = ((byte)((byte)0U));
                                        s._1 = ((byte)((byte)0U));
                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                        goto M16;
                                    }
                                }
                            }
                        }
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
                        var temp878 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp878)
                        {
                            goto M25;
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
                        var temp879 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp879)
                        {
                            goto M17;
                        }
                        else
                        {
                            var temp880 = ((byte)((byte)(((byte)((byte)((s)._0))) & 3L)) << 6);
                            var temp881 = Fun0(((byte)(i)));
                            var temp882 = ((byte)(((byte)(temp880)) | ((byte)(((byte)((uint)(temp881)))))));
                            s._1 = ((byte)(temp882));
                            s._0 = ((byte)((byte)0U));
                            goto M18;
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
                    throw new Exception();
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
                        var temp883 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp883)
                            throw new Exception();
                        else
                        {
                            var temp884 = Fun0(((byte)(i)));
                            s._0 = ((byte)(((byte)((uint)(temp884)))));
                            goto M19;
                        }
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
                        var temp885 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp885)
                            throw new Exception();
                        else
                        {
                            var temp886 = ((byte)((byte)(((byte)((byte)((s)._0))) & 63L)) << 2);
                            var temp887 = Fun0(((byte)(i)));
                            var temp888 = ((uint)(((int)((uint)(temp887))) >> (int)((uint)((uint)4U))));
                            var temp889 = ((byte)(((byte)(temp886)) | ((byte)(((byte)((uint)(temp888)))))));
                            s._2 = ((byte)(temp889));
                            s._0 = ((byte)(((byte)((uint)(temp887)))));
                            goto M20;
                        }
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
                        var temp890 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp890)
                        {
                            goto M21;
                        }
                        else
                        {
                            var temp891 = ((byte)((byte)(((byte)((byte)((s)._0))) & 15L)) << 4);
                            var temp892 = Fun0(((byte)(i)));
                            var temp893 = ((uint)(((int)((uint)(temp892))) >> (int)((uint)((uint)2U))));
                            var temp894 = ((byte)(((byte)(temp891)) | ((byte)(((byte)((uint)(temp893)))))));
                            s._3 = ((byte)(temp894));
                            s._0 = ((byte)(((byte)((uint)(temp892)))));
                            goto M22;
                        }
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
                        var temp895 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp895)
                        {
                            goto M24;
                        }
                        else
                            throw new Exception();
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
                        var temp896 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp896)
                        {
                            goto M23;
                        }
                        else
                        {
                            var temp897 = ((byte)((byte)(((byte)((byte)((s)._0))) & 3L)) << 6);
                            var temp898 = Fun0(((byte)(i)));
                            var temp899 = ((byte)(((byte)(temp897)) | ((byte)(((byte)((uint)(temp898)))))));
                            var temp900 = ((((uint)((byte)((s)._1)) << 8) | (uint)((byte)((s)._2)) << 8) | (uint)((byte)((s)._3)) << 8) | (uint)((byte)(temp899));
                            var temp901 = (((uint)(temp900)) == ((uint)((s)._4)));
                            if (temp901)
                            {
                                if (oIndex > 16383)
                                {
                                    output.Write(oBuf, 0, oIndex);
                                    oIndex = 0;
                                }

                                oBuf[oIndex + 0] = (Byte)((byte)48U);
                                oIndex += 1;
                                s._4 = ((uint)(temp900));
                                s._3 = ((byte)((byte)0U));
                                s._2 = ((byte)((byte)0U));
                                s._1 = ((byte)((byte)0U));
                                s._0 = ((byte)((byte)0U));
                                goto M0;
                            }
                            else
                            {
                                var temp902 = ((uint)(((uint)((uint)4294967295U)) * ((uint)((s)._4))));
                                var temp903 = ((uint)(((uint)(temp900)) + ((uint)(temp902))));
                                var temp904 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp903)));
                                var temp905 = !(temp904);
                                if (temp905)
                                {
                                    var temp906 = ((byte)(((uint)(temp903)) >> 31));
                                    var temp907 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 32) | (ulong)((uint)(temp903));
                                    var temp908 = ((ulong)(((ulong)((ulong)18446744073709551615UL)) * ((ulong)(temp907))));
                                    var temp909 = Fun1(((ulong)(temp908)));
                                    var temp910 = ((uint)(((uint)((uint)4294967295U)) + ((uint)(temp909))));
                                    var temp911 = ((int)((uint)(temp910)) <= (int)((uint)((uint)0U)));
                                    var temp912 = !(temp911);
                                    if (temp912)
                                    {
                                        var temp913 = ((int)((uint)(temp910)) <= (int)((uint)((uint)1U)));
                                        var temp914 = !(temp913);
                                        if (temp914)
                                        {
                                            var temp915 = ((int)((uint)(temp910)) <= (int)((uint)((uint)2U)));
                                            var temp916 = !(temp915);
                                            if (temp916)
                                            {
                                                var temp917 = ((int)((uint)(temp910)) <= (int)((uint)((uint)3U)));
                                                var temp918 = !(temp917);
                                                if (temp918)
                                                {
                                                    var temp919 = ((int)((uint)(temp910)) <= (int)((uint)((uint)4U)));
                                                    var temp920 = !(temp919);
                                                    if (temp920)
                                                    {
                                                        var temp921 = ((int)((uint)(temp910)) <= (int)((uint)((uint)5U)));
                                                        var temp922 = !(temp921);
                                                        if (temp922)
                                                        {
                                                            var temp923 = ((int)((uint)(temp910)) <= (int)((uint)((uint)6U)));
                                                            var temp924 = !(temp923);
                                                            if (temp924)
                                                            {
                                                                var temp925 = ((int)((uint)(temp910)) <= (int)((uint)((uint)7U)));
                                                                var temp926 = !(temp925);
                                                                if (temp926)
                                                                {
                                                                    var temp927 = ((int)((uint)(temp910)) <= (int)((uint)((uint)8U)));
                                                                    var temp928 = !(temp927);
                                                                    if (temp928)
                                                                    {
                                                                        if (oIndex > 16372)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                        var temp929 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000000U))));
                                                                        var temp930 = ((uint)((int)((uint)(temp929)) % (int)((uint)((uint)10U))));
                                                                        var temp931 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp930)))))));
                                                                        var temp932 = ((byte)(((byte)((byte)48U)) + ((byte)(temp931))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp932);
                                                                        var temp933 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000000U))));
                                                                        var temp934 = ((uint)((int)((uint)(temp933)) % (int)((uint)((uint)10U))));
                                                                        var temp935 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp934)))))));
                                                                        var temp936 = ((byte)(((byte)((byte)48U)) + ((byte)(temp935))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp936);
                                                                        var temp937 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000000U))));
                                                                        var temp938 = ((uint)((int)((uint)(temp937)) % (int)((uint)((uint)10U))));
                                                                        var temp939 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp938)))))));
                                                                        var temp940 = ((byte)(((byte)((byte)48U)) + ((byte)(temp939))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp940);
                                                                        var temp941 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                        var temp942 = ((uint)((int)((uint)(temp941)) % (int)((uint)((uint)10U))));
                                                                        var temp943 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp942)))))));
                                                                        var temp944 = ((byte)(((byte)((byte)48U)) + ((byte)(temp943))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp944);
                                                                        var temp945 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                        var temp946 = ((uint)((int)((uint)(temp945)) % (int)((uint)((uint)10U))));
                                                                        var temp947 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp946)))))));
                                                                        var temp948 = ((byte)(((byte)((byte)48U)) + ((byte)(temp947))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp948);
                                                                        var temp949 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                        var temp950 = ((uint)((int)((uint)(temp949)) % (int)((uint)((uint)10U))));
                                                                        var temp951 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp950)))))));
                                                                        var temp952 = ((byte)(((byte)((byte)48U)) + ((byte)(temp951))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp952);
                                                                        var temp953 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                        var temp954 = ((uint)((int)((uint)(temp953)) % (int)((uint)((uint)10U))));
                                                                        var temp955 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp954)))))));
                                                                        var temp956 = ((byte)(((byte)((byte)48U)) + ((byte)(temp955))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp956);
                                                                        var temp957 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                        var temp958 = ((uint)((int)((uint)(temp957)) % (int)((uint)((uint)10U))));
                                                                        var temp959 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp958)))))));
                                                                        var temp960 = ((byte)(((byte)((byte)48U)) + ((byte)(temp959))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp960);
                                                                        var temp961 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                        var temp962 = ((uint)((int)((uint)(temp961)) % (int)((uint)((uint)10U))));
                                                                        var temp963 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp962)))))));
                                                                        var temp964 = ((byte)(((byte)((byte)48U)) + ((byte)(temp963))));
                                                                        oBuf[oIndex + 9] = (Byte)(temp964);
                                                                        var temp965 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                        var temp966 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp965)))))));
                                                                        var temp967 = ((byte)(((byte)((byte)48U)) + ((byte)(temp966))));
                                                                        oBuf[oIndex + 10] = (Byte)(temp967);
                                                                        oBuf[oIndex + 11] = (Byte)((byte)10U);
                                                                        oIndex += 12;
                                                                        s._4 = ((uint)(temp900));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)((byte)0U));
                                                                        goto M0;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (oIndex > 16373)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                        var temp968 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000000U))));
                                                                        var temp969 = ((uint)((int)((uint)(temp968)) % (int)((uint)((uint)10U))));
                                                                        var temp970 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp969)))))));
                                                                        var temp971 = ((byte)(((byte)((byte)48U)) + ((byte)(temp970))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp971);
                                                                        var temp972 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000000U))));
                                                                        var temp973 = ((uint)((int)((uint)(temp972)) % (int)((uint)((uint)10U))));
                                                                        var temp974 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp973)))))));
                                                                        var temp975 = ((byte)(((byte)((byte)48U)) + ((byte)(temp974))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp975);
                                                                        var temp976 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                        var temp977 = ((uint)((int)((uint)(temp976)) % (int)((uint)((uint)10U))));
                                                                        var temp978 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp977)))))));
                                                                        var temp979 = ((byte)(((byte)((byte)48U)) + ((byte)(temp978))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp979);
                                                                        var temp980 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                        var temp981 = ((uint)((int)((uint)(temp980)) % (int)((uint)((uint)10U))));
                                                                        var temp982 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp981)))))));
                                                                        var temp983 = ((byte)(((byte)((byte)48U)) + ((byte)(temp982))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp983);
                                                                        var temp984 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                        var temp985 = ((uint)((int)((uint)(temp984)) % (int)((uint)((uint)10U))));
                                                                        var temp986 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp985)))))));
                                                                        var temp987 = ((byte)(((byte)((byte)48U)) + ((byte)(temp986))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp987);
                                                                        var temp988 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                        var temp989 = ((uint)((int)((uint)(temp988)) % (int)((uint)((uint)10U))));
                                                                        var temp990 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp989)))))));
                                                                        var temp991 = ((byte)(((byte)((byte)48U)) + ((byte)(temp990))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp991);
                                                                        var temp992 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                        var temp993 = ((uint)((int)((uint)(temp992)) % (int)((uint)((uint)10U))));
                                                                        var temp994 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp993)))))));
                                                                        var temp995 = ((byte)(((byte)((byte)48U)) + ((byte)(temp994))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp995);
                                                                        var temp996 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                        var temp997 = ((uint)((int)((uint)(temp996)) % (int)((uint)((uint)10U))));
                                                                        var temp998 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp997)))))));
                                                                        var temp999 = ((byte)(((byte)((byte)48U)) + ((byte)(temp998))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp999);
                                                                        var temp1000 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                        var temp1001 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1000)))))));
                                                                        var temp1002 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1001))));
                                                                        oBuf[oIndex + 9] = (Byte)(temp1002);
                                                                        oBuf[oIndex + 10] = (Byte)((byte)10U);
                                                                        oIndex += 11;
                                                                        s._4 = ((uint)(temp900));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)((byte)0U));
                                                                        goto M0;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (oIndex > 16374)
                                                                    {
                                                                        output.Write(oBuf, 0, oIndex);
                                                                        oIndex = 0;
                                                                    }

                                                                    oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                    var temp1003 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000000U))));
                                                                    var temp1004 = ((uint)((int)((uint)(temp1003)) % (int)((uint)((uint)10U))));
                                                                    var temp1005 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1004)))))));
                                                                    var temp1006 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1005))));
                                                                    oBuf[oIndex + 1] = (Byte)(temp1006);
                                                                    var temp1007 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                    var temp1008 = ((uint)((int)((uint)(temp1007)) % (int)((uint)((uint)10U))));
                                                                    var temp1009 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1008)))))));
                                                                    var temp1010 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1009))));
                                                                    oBuf[oIndex + 2] = (Byte)(temp1010);
                                                                    var temp1011 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                    var temp1012 = ((uint)((int)((uint)(temp1011)) % (int)((uint)((uint)10U))));
                                                                    var temp1013 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1012)))))));
                                                                    var temp1014 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1013))));
                                                                    oBuf[oIndex + 3] = (Byte)(temp1014);
                                                                    var temp1015 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                    var temp1016 = ((uint)((int)((uint)(temp1015)) % (int)((uint)((uint)10U))));
                                                                    var temp1017 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1016)))))));
                                                                    var temp1018 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1017))));
                                                                    oBuf[oIndex + 4] = (Byte)(temp1018);
                                                                    var temp1019 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                    var temp1020 = ((uint)((int)((uint)(temp1019)) % (int)((uint)((uint)10U))));
                                                                    var temp1021 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1020)))))));
                                                                    var temp1022 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1021))));
                                                                    oBuf[oIndex + 5] = (Byte)(temp1022);
                                                                    var temp1023 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                    var temp1024 = ((uint)((int)((uint)(temp1023)) % (int)((uint)((uint)10U))));
                                                                    var temp1025 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1024)))))));
                                                                    var temp1026 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1025))));
                                                                    oBuf[oIndex + 6] = (Byte)(temp1026);
                                                                    var temp1027 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                    var temp1028 = ((uint)((int)((uint)(temp1027)) % (int)((uint)((uint)10U))));
                                                                    var temp1029 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1028)))))));
                                                                    var temp1030 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1029))));
                                                                    oBuf[oIndex + 7] = (Byte)(temp1030);
                                                                    var temp1031 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                    var temp1032 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1031)))))));
                                                                    var temp1033 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1032))));
                                                                    oBuf[oIndex + 8] = (Byte)(temp1033);
                                                                    oBuf[oIndex + 9] = (Byte)((byte)10U);
                                                                    oIndex += 10;
                                                                    s._4 = ((uint)(temp900));
                                                                    s._3 = ((byte)((byte)0U));
                                                                    s._2 = ((byte)((byte)0U));
                                                                    s._1 = ((byte)((byte)0U));
                                                                    s._0 = ((byte)((byte)0U));
                                                                    goto M0;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (oIndex > 16375)
                                                                {
                                                                    output.Write(oBuf, 0, oIndex);
                                                                    oIndex = 0;
                                                                }

                                                                oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                var temp1034 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                var temp1035 = ((uint)((int)((uint)(temp1034)) % (int)((uint)((uint)10U))));
                                                                var temp1036 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1035)))))));
                                                                var temp1037 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1036))));
                                                                oBuf[oIndex + 1] = (Byte)(temp1037);
                                                                var temp1038 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                var temp1039 = ((uint)((int)((uint)(temp1038)) % (int)((uint)((uint)10U))));
                                                                var temp1040 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1039)))))));
                                                                var temp1041 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1040))));
                                                                oBuf[oIndex + 2] = (Byte)(temp1041);
                                                                var temp1042 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                var temp1043 = ((uint)((int)((uint)(temp1042)) % (int)((uint)((uint)10U))));
                                                                var temp1044 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1043)))))));
                                                                var temp1045 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1044))));
                                                                oBuf[oIndex + 3] = (Byte)(temp1045);
                                                                var temp1046 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                var temp1047 = ((uint)((int)((uint)(temp1046)) % (int)((uint)((uint)10U))));
                                                                var temp1048 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1047)))))));
                                                                var temp1049 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1048))));
                                                                oBuf[oIndex + 4] = (Byte)(temp1049);
                                                                var temp1050 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                var temp1051 = ((uint)((int)((uint)(temp1050)) % (int)((uint)((uint)10U))));
                                                                var temp1052 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1051)))))));
                                                                var temp1053 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1052))));
                                                                oBuf[oIndex + 5] = (Byte)(temp1053);
                                                                var temp1054 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                var temp1055 = ((uint)((int)((uint)(temp1054)) % (int)((uint)((uint)10U))));
                                                                var temp1056 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1055)))))));
                                                                var temp1057 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1056))));
                                                                oBuf[oIndex + 6] = (Byte)(temp1057);
                                                                var temp1058 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                var temp1059 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1058)))))));
                                                                var temp1060 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1059))));
                                                                oBuf[oIndex + 7] = (Byte)(temp1060);
                                                                oBuf[oIndex + 8] = (Byte)((byte)10U);
                                                                oIndex += 9;
                                                                s._4 = ((uint)(temp900));
                                                                s._3 = ((byte)((byte)0U));
                                                                s._2 = ((byte)((byte)0U));
                                                                s._1 = ((byte)((byte)0U));
                                                                s._0 = ((byte)((byte)0U));
                                                                goto M0;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (oIndex > 16376)
                                                            {
                                                                output.Write(oBuf, 0, oIndex);
                                                                oIndex = 0;
                                                            }

                                                            oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                            var temp1061 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                            var temp1062 = ((uint)((int)((uint)(temp1061)) % (int)((uint)((uint)10U))));
                                                            var temp1063 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1062)))))));
                                                            var temp1064 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1063))));
                                                            oBuf[oIndex + 1] = (Byte)(temp1064);
                                                            var temp1065 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                            var temp1066 = ((uint)((int)((uint)(temp1065)) % (int)((uint)((uint)10U))));
                                                            var temp1067 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1066)))))));
                                                            var temp1068 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1067))));
                                                            oBuf[oIndex + 2] = (Byte)(temp1068);
                                                            var temp1069 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                            var temp1070 = ((uint)((int)((uint)(temp1069)) % (int)((uint)((uint)10U))));
                                                            var temp1071 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1070)))))));
                                                            var temp1072 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1071))));
                                                            oBuf[oIndex + 3] = (Byte)(temp1072);
                                                            var temp1073 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                            var temp1074 = ((uint)((int)((uint)(temp1073)) % (int)((uint)((uint)10U))));
                                                            var temp1075 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1074)))))));
                                                            var temp1076 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1075))));
                                                            oBuf[oIndex + 4] = (Byte)(temp1076);
                                                            var temp1077 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                            var temp1078 = ((uint)((int)((uint)(temp1077)) % (int)((uint)((uint)10U))));
                                                            var temp1079 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1078)))))));
                                                            var temp1080 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1079))));
                                                            oBuf[oIndex + 5] = (Byte)(temp1080);
                                                            var temp1081 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                            var temp1082 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1081)))))));
                                                            var temp1083 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1082))));
                                                            oBuf[oIndex + 6] = (Byte)(temp1083);
                                                            oBuf[oIndex + 7] = (Byte)((byte)10U);
                                                            oIndex += 8;
                                                            s._4 = ((uint)(temp900));
                                                            s._3 = ((byte)((byte)0U));
                                                            s._2 = ((byte)((byte)0U));
                                                            s._1 = ((byte)((byte)0U));
                                                            s._0 = ((byte)((byte)0U));
                                                            goto M0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (oIndex > 16377)
                                                        {
                                                            output.Write(oBuf, 0, oIndex);
                                                            oIndex = 0;
                                                        }

                                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                        var temp1084 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                        var temp1085 = ((uint)((int)((uint)(temp1084)) % (int)((uint)((uint)10U))));
                                                        var temp1086 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1085)))))));
                                                        var temp1087 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1086))));
                                                        oBuf[oIndex + 1] = (Byte)(temp1087);
                                                        var temp1088 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                        var temp1089 = ((uint)((int)((uint)(temp1088)) % (int)((uint)((uint)10U))));
                                                        var temp1090 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1089)))))));
                                                        var temp1091 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1090))));
                                                        oBuf[oIndex + 2] = (Byte)(temp1091);
                                                        var temp1092 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                        var temp1093 = ((uint)((int)((uint)(temp1092)) % (int)((uint)((uint)10U))));
                                                        var temp1094 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1093)))))));
                                                        var temp1095 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1094))));
                                                        oBuf[oIndex + 3] = (Byte)(temp1095);
                                                        var temp1096 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                        var temp1097 = ((uint)((int)((uint)(temp1096)) % (int)((uint)((uint)10U))));
                                                        var temp1098 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1097)))))));
                                                        var temp1099 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1098))));
                                                        oBuf[oIndex + 4] = (Byte)(temp1099);
                                                        var temp1100 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                        var temp1101 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1100)))))));
                                                        var temp1102 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1101))));
                                                        oBuf[oIndex + 5] = (Byte)(temp1102);
                                                        oBuf[oIndex + 6] = (Byte)((byte)10U);
                                                        oIndex += 7;
                                                        s._4 = ((uint)(temp900));
                                                        s._3 = ((byte)((byte)0U));
                                                        s._2 = ((byte)((byte)0U));
                                                        s._1 = ((byte)((byte)0U));
                                                        s._0 = ((byte)((byte)0U));
                                                        goto M0;
                                                    }
                                                }
                                                else
                                                {
                                                    if (oIndex > 16378)
                                                    {
                                                        output.Write(oBuf, 0, oIndex);
                                                        oIndex = 0;
                                                    }

                                                    oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                    var temp1103 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                    var temp1104 = ((uint)((int)((uint)(temp1103)) % (int)((uint)((uint)10U))));
                                                    var temp1105 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1104)))))));
                                                    var temp1106 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1105))));
                                                    oBuf[oIndex + 1] = (Byte)(temp1106);
                                                    var temp1107 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                    var temp1108 = ((uint)((int)((uint)(temp1107)) % (int)((uint)((uint)10U))));
                                                    var temp1109 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1108)))))));
                                                    var temp1110 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1109))));
                                                    oBuf[oIndex + 2] = (Byte)(temp1110);
                                                    var temp1111 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                    var temp1112 = ((uint)((int)((uint)(temp1111)) % (int)((uint)((uint)10U))));
                                                    var temp1113 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1112)))))));
                                                    var temp1114 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1113))));
                                                    oBuf[oIndex + 3] = (Byte)(temp1114);
                                                    var temp1115 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                    var temp1116 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1115)))))));
                                                    var temp1117 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1116))));
                                                    oBuf[oIndex + 4] = (Byte)(temp1117);
                                                    oBuf[oIndex + 5] = (Byte)((byte)10U);
                                                    oIndex += 6;
                                                    s._4 = ((uint)(temp900));
                                                    s._3 = ((byte)((byte)0U));
                                                    s._2 = ((byte)((byte)0U));
                                                    s._1 = ((byte)((byte)0U));
                                                    s._0 = ((byte)((byte)0U));
                                                    goto M0;
                                                }
                                            }
                                            else
                                            {
                                                if (oIndex > 16379)
                                                {
                                                    output.Write(oBuf, 0, oIndex);
                                                    oIndex = 0;
                                                }

                                                oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                var temp1118 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                var temp1119 = ((uint)((int)((uint)(temp1118)) % (int)((uint)((uint)10U))));
                                                var temp1120 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1119)))))));
                                                var temp1121 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1120))));
                                                oBuf[oIndex + 1] = (Byte)(temp1121);
                                                var temp1122 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                var temp1123 = ((uint)((int)((uint)(temp1122)) % (int)((uint)((uint)10U))));
                                                var temp1124 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1123)))))));
                                                var temp1125 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1124))));
                                                oBuf[oIndex + 2] = (Byte)(temp1125);
                                                var temp1126 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                var temp1127 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1126)))))));
                                                var temp1128 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1127))));
                                                oBuf[oIndex + 3] = (Byte)(temp1128);
                                                oBuf[oIndex + 4] = (Byte)((byte)10U);
                                                oIndex += 5;
                                                s._4 = ((uint)(temp900));
                                                s._3 = ((byte)((byte)0U));
                                                s._2 = ((byte)((byte)0U));
                                                s._1 = ((byte)((byte)0U));
                                                s._0 = ((byte)((byte)0U));
                                                goto M0;
                                            }
                                        }
                                        else
                                        {
                                            if (oIndex > 16380)
                                            {
                                                output.Write(oBuf, 0, oIndex);
                                                oIndex = 0;
                                            }

                                            oBuf[oIndex + 0] = (Byte)((byte)45U);
                                            var temp1129 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                            var temp1130 = ((uint)((int)((uint)(temp1129)) % (int)((uint)((uint)10U))));
                                            var temp1131 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1130)))))));
                                            var temp1132 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1131))));
                                            oBuf[oIndex + 1] = (Byte)(temp1132);
                                            var temp1133 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                            var temp1134 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1133)))))));
                                            var temp1135 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1134))));
                                            oBuf[oIndex + 2] = (Byte)(temp1135);
                                            oBuf[oIndex + 3] = (Byte)((byte)10U);
                                            oIndex += 4;
                                            s._4 = ((uint)(temp900));
                                            s._3 = ((byte)((byte)0U));
                                            s._2 = ((byte)((byte)0U));
                                            s._1 = ((byte)((byte)0U));
                                            s._0 = ((byte)((byte)0U));
                                            goto M0;
                                        }
                                    }
                                    else
                                    {
                                        if (oIndex > 16381)
                                        {
                                            output.Write(oBuf, 0, oIndex);
                                            oIndex = 0;
                                        }

                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                        var temp1136 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                        var temp1137 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1136)))))));
                                        var temp1138 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1137))));
                                        oBuf[oIndex + 1] = (Byte)(temp1138);
                                        oBuf[oIndex + 2] = (Byte)((byte)10U);
                                        oIndex += 3;
                                        s._4 = ((uint)(temp900));
                                        s._3 = ((byte)((byte)0U));
                                        s._2 = ((byte)((byte)0U));
                                        s._1 = ((byte)((byte)0U));
                                        s._0 = ((byte)((byte)0U));
                                        goto M0;
                                    }
                                }
                                else
                                {
                                    var temp1139 = ((byte)(((uint)(temp903)) >> 31));
                                    var temp1140 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 32) | (ulong)((uint)(temp903));
                                    var temp1141 = Fun1(((ulong)(temp1140)));
                                    var temp1142 = ((uint)(((uint)((uint)4294967295U)) + ((uint)(temp1141))));
                                    var temp1143 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)0U)));
                                    var temp1144 = !(temp1143);
                                    if (temp1144)
                                    {
                                        var temp1145 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)1U)));
                                        var temp1146 = !(temp1145);
                                        if (temp1146)
                                        {
                                            var temp1147 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)2U)));
                                            var temp1148 = !(temp1147);
                                            if (temp1148)
                                            {
                                                var temp1149 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)3U)));
                                                var temp1150 = !(temp1149);
                                                if (temp1150)
                                                {
                                                    var temp1151 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)4U)));
                                                    var temp1152 = !(temp1151);
                                                    if (temp1152)
                                                    {
                                                        var temp1153 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)5U)));
                                                        var temp1154 = !(temp1153);
                                                        if (temp1154)
                                                        {
                                                            var temp1155 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)6U)));
                                                            var temp1156 = !(temp1155);
                                                            if (temp1156)
                                                            {
                                                                var temp1157 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)7U)));
                                                                var temp1158 = !(temp1157);
                                                                if (temp1158)
                                                                {
                                                                    var temp1159 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)8U)));
                                                                    var temp1160 = !(temp1159);
                                                                    if (temp1160)
                                                                    {
                                                                        if (oIndex > 16373)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        var temp1161 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000000U))));
                                                                        var temp1162 = ((uint)((int)((uint)(temp1161)) % (int)((uint)((uint)10U))));
                                                                        var temp1163 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1162)))))));
                                                                        oBuf[oIndex + 0] = (Byte)(temp1163);
                                                                        var temp1164 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000000U))));
                                                                        var temp1165 = ((uint)((int)((uint)(temp1164)) % (int)((uint)((uint)10U))));
                                                                        var temp1166 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1165)))))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp1166);
                                                                        var temp1167 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000000U))));
                                                                        var temp1168 = ((uint)((int)((uint)(temp1167)) % (int)((uint)((uint)10U))));
                                                                        var temp1169 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1168)))))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp1169);
                                                                        var temp1170 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                        var temp1171 = ((uint)((int)((uint)(temp1170)) % (int)((uint)((uint)10U))));
                                                                        var temp1172 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1171)))))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp1172);
                                                                        var temp1173 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                        var temp1174 = ((uint)((int)((uint)(temp1173)) % (int)((uint)((uint)10U))));
                                                                        var temp1175 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1174)))))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp1175);
                                                                        var temp1176 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                        var temp1177 = ((uint)((int)((uint)(temp1176)) % (int)((uint)((uint)10U))));
                                                                        var temp1178 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1177)))))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp1178);
                                                                        var temp1179 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                        var temp1180 = ((uint)((int)((uint)(temp1179)) % (int)((uint)((uint)10U))));
                                                                        var temp1181 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1180)))))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp1181);
                                                                        var temp1182 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                        var temp1183 = ((uint)((int)((uint)(temp1182)) % (int)((uint)((uint)10U))));
                                                                        var temp1184 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1183)))))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp1184);
                                                                        var temp1185 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                        var temp1186 = ((uint)((int)((uint)(temp1185)) % (int)((uint)((uint)10U))));
                                                                        var temp1187 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1186)))))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp1187);
                                                                        var temp1188 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                        var temp1189 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1188)))))));
                                                                        oBuf[oIndex + 9] = (Byte)(temp1189);
                                                                        oBuf[oIndex + 10] = (Byte)((byte)10U);
                                                                        oIndex += 11;
                                                                        s._4 = ((uint)(temp900));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)((byte)0U));
                                                                        goto M0;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (oIndex > 16374)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        var temp1190 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000000U))));
                                                                        var temp1191 = ((uint)((int)((uint)(temp1190)) % (int)((uint)((uint)10U))));
                                                                        var temp1192 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1191)))))));
                                                                        oBuf[oIndex + 0] = (Byte)(temp1192);
                                                                        var temp1193 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000000U))));
                                                                        var temp1194 = ((uint)((int)((uint)(temp1193)) % (int)((uint)((uint)10U))));
                                                                        var temp1195 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1194)))))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp1195);
                                                                        var temp1196 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                        var temp1197 = ((uint)((int)((uint)(temp1196)) % (int)((uint)((uint)10U))));
                                                                        var temp1198 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1197)))))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp1198);
                                                                        var temp1199 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                        var temp1200 = ((uint)((int)((uint)(temp1199)) % (int)((uint)((uint)10U))));
                                                                        var temp1201 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1200)))))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp1201);
                                                                        var temp1202 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                        var temp1203 = ((uint)((int)((uint)(temp1202)) % (int)((uint)((uint)10U))));
                                                                        var temp1204 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1203)))))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp1204);
                                                                        var temp1205 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                        var temp1206 = ((uint)((int)((uint)(temp1205)) % (int)((uint)((uint)10U))));
                                                                        var temp1207 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1206)))))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp1207);
                                                                        var temp1208 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                        var temp1209 = ((uint)((int)((uint)(temp1208)) % (int)((uint)((uint)10U))));
                                                                        var temp1210 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1209)))))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp1210);
                                                                        var temp1211 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                        var temp1212 = ((uint)((int)((uint)(temp1211)) % (int)((uint)((uint)10U))));
                                                                        var temp1213 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1212)))))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp1213);
                                                                        var temp1214 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                        var temp1215 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1214)))))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp1215);
                                                                        oBuf[oIndex + 9] = (Byte)((byte)10U);
                                                                        oIndex += 10;
                                                                        s._4 = ((uint)(temp900));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)((byte)0U));
                                                                        goto M0;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (oIndex > 16375)
                                                                    {
                                                                        output.Write(oBuf, 0, oIndex);
                                                                        oIndex = 0;
                                                                    }

                                                                    var temp1216 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000000U))));
                                                                    var temp1217 = ((uint)((int)((uint)(temp1216)) % (int)((uint)((uint)10U))));
                                                                    var temp1218 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1217)))))));
                                                                    oBuf[oIndex + 0] = (Byte)(temp1218);
                                                                    var temp1219 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                    var temp1220 = ((uint)((int)((uint)(temp1219)) % (int)((uint)((uint)10U))));
                                                                    var temp1221 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1220)))))));
                                                                    oBuf[oIndex + 1] = (Byte)(temp1221);
                                                                    var temp1222 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                    var temp1223 = ((uint)((int)((uint)(temp1222)) % (int)((uint)((uint)10U))));
                                                                    var temp1224 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1223)))))));
                                                                    oBuf[oIndex + 2] = (Byte)(temp1224);
                                                                    var temp1225 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                    var temp1226 = ((uint)((int)((uint)(temp1225)) % (int)((uint)((uint)10U))));
                                                                    var temp1227 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1226)))))));
                                                                    oBuf[oIndex + 3] = (Byte)(temp1227);
                                                                    var temp1228 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                    var temp1229 = ((uint)((int)((uint)(temp1228)) % (int)((uint)((uint)10U))));
                                                                    var temp1230 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1229)))))));
                                                                    oBuf[oIndex + 4] = (Byte)(temp1230);
                                                                    var temp1231 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                    var temp1232 = ((uint)((int)((uint)(temp1231)) % (int)((uint)((uint)10U))));
                                                                    var temp1233 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1232)))))));
                                                                    oBuf[oIndex + 5] = (Byte)(temp1233);
                                                                    var temp1234 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                    var temp1235 = ((uint)((int)((uint)(temp1234)) % (int)((uint)((uint)10U))));
                                                                    var temp1236 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1235)))))));
                                                                    oBuf[oIndex + 6] = (Byte)(temp1236);
                                                                    var temp1237 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                    var temp1238 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1237)))))));
                                                                    oBuf[oIndex + 7] = (Byte)(temp1238);
                                                                    oBuf[oIndex + 8] = (Byte)((byte)10U);
                                                                    oIndex += 9;
                                                                    s._4 = ((uint)(temp900));
                                                                    s._3 = ((byte)((byte)0U));
                                                                    s._2 = ((byte)((byte)0U));
                                                                    s._1 = ((byte)((byte)0U));
                                                                    s._0 = ((byte)((byte)0U));
                                                                    goto M0;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (oIndex > 16376)
                                                                {
                                                                    output.Write(oBuf, 0, oIndex);
                                                                    oIndex = 0;
                                                                }

                                                                var temp1239 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                var temp1240 = ((uint)((int)((uint)(temp1239)) % (int)((uint)((uint)10U))));
                                                                var temp1241 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1240)))))));
                                                                oBuf[oIndex + 0] = (Byte)(temp1241);
                                                                var temp1242 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                var temp1243 = ((uint)((int)((uint)(temp1242)) % (int)((uint)((uint)10U))));
                                                                var temp1244 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1243)))))));
                                                                oBuf[oIndex + 1] = (Byte)(temp1244);
                                                                var temp1245 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                var temp1246 = ((uint)((int)((uint)(temp1245)) % (int)((uint)((uint)10U))));
                                                                var temp1247 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1246)))))));
                                                                oBuf[oIndex + 2] = (Byte)(temp1247);
                                                                var temp1248 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                var temp1249 = ((uint)((int)((uint)(temp1248)) % (int)((uint)((uint)10U))));
                                                                var temp1250 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1249)))))));
                                                                oBuf[oIndex + 3] = (Byte)(temp1250);
                                                                var temp1251 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                var temp1252 = ((uint)((int)((uint)(temp1251)) % (int)((uint)((uint)10U))));
                                                                var temp1253 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1252)))))));
                                                                oBuf[oIndex + 4] = (Byte)(temp1253);
                                                                var temp1254 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                var temp1255 = ((uint)((int)((uint)(temp1254)) % (int)((uint)((uint)10U))));
                                                                var temp1256 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1255)))))));
                                                                oBuf[oIndex + 5] = (Byte)(temp1256);
                                                                var temp1257 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                var temp1258 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1257)))))));
                                                                oBuf[oIndex + 6] = (Byte)(temp1258);
                                                                oBuf[oIndex + 7] = (Byte)((byte)10U);
                                                                oIndex += 8;
                                                                s._4 = ((uint)(temp900));
                                                                s._3 = ((byte)((byte)0U));
                                                                s._2 = ((byte)((byte)0U));
                                                                s._1 = ((byte)((byte)0U));
                                                                s._0 = ((byte)((byte)0U));
                                                                goto M0;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (oIndex > 16377)
                                                            {
                                                                output.Write(oBuf, 0, oIndex);
                                                                oIndex = 0;
                                                            }

                                                            var temp1259 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                            var temp1260 = ((uint)((int)((uint)(temp1259)) % (int)((uint)((uint)10U))));
                                                            var temp1261 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1260)))))));
                                                            oBuf[oIndex + 0] = (Byte)(temp1261);
                                                            var temp1262 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                            var temp1263 = ((uint)((int)((uint)(temp1262)) % (int)((uint)((uint)10U))));
                                                            var temp1264 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1263)))))));
                                                            oBuf[oIndex + 1] = (Byte)(temp1264);
                                                            var temp1265 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                            var temp1266 = ((uint)((int)((uint)(temp1265)) % (int)((uint)((uint)10U))));
                                                            var temp1267 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1266)))))));
                                                            oBuf[oIndex + 2] = (Byte)(temp1267);
                                                            var temp1268 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                            var temp1269 = ((uint)((int)((uint)(temp1268)) % (int)((uint)((uint)10U))));
                                                            var temp1270 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1269)))))));
                                                            oBuf[oIndex + 3] = (Byte)(temp1270);
                                                            var temp1271 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                            var temp1272 = ((uint)((int)((uint)(temp1271)) % (int)((uint)((uint)10U))));
                                                            var temp1273 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1272)))))));
                                                            oBuf[oIndex + 4] = (Byte)(temp1273);
                                                            var temp1274 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                            var temp1275 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1274)))))));
                                                            oBuf[oIndex + 5] = (Byte)(temp1275);
                                                            oBuf[oIndex + 6] = (Byte)((byte)10U);
                                                            oIndex += 7;
                                                            s._4 = ((uint)(temp900));
                                                            s._3 = ((byte)((byte)0U));
                                                            s._2 = ((byte)((byte)0U));
                                                            s._1 = ((byte)((byte)0U));
                                                            s._0 = ((byte)((byte)0U));
                                                            goto M0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (oIndex > 16378)
                                                        {
                                                            output.Write(oBuf, 0, oIndex);
                                                            oIndex = 0;
                                                        }

                                                        var temp1276 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                        var temp1277 = ((uint)((int)((uint)(temp1276)) % (int)((uint)((uint)10U))));
                                                        var temp1278 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1277)))))));
                                                        oBuf[oIndex + 0] = (Byte)(temp1278);
                                                        var temp1279 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                        var temp1280 = ((uint)((int)((uint)(temp1279)) % (int)((uint)((uint)10U))));
                                                        var temp1281 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1280)))))));
                                                        oBuf[oIndex + 1] = (Byte)(temp1281);
                                                        var temp1282 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                        var temp1283 = ((uint)((int)((uint)(temp1282)) % (int)((uint)((uint)10U))));
                                                        var temp1284 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1283)))))));
                                                        oBuf[oIndex + 2] = (Byte)(temp1284);
                                                        var temp1285 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                        var temp1286 = ((uint)((int)((uint)(temp1285)) % (int)((uint)((uint)10U))));
                                                        var temp1287 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1286)))))));
                                                        oBuf[oIndex + 3] = (Byte)(temp1287);
                                                        var temp1288 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                        var temp1289 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1288)))))));
                                                        oBuf[oIndex + 4] = (Byte)(temp1289);
                                                        oBuf[oIndex + 5] = (Byte)((byte)10U);
                                                        oIndex += 6;
                                                        s._4 = ((uint)(temp900));
                                                        s._3 = ((byte)((byte)0U));
                                                        s._2 = ((byte)((byte)0U));
                                                        s._1 = ((byte)((byte)0U));
                                                        s._0 = ((byte)((byte)0U));
                                                        goto M0;
                                                    }
                                                }
                                                else
                                                {
                                                    if (oIndex > 16379)
                                                    {
                                                        output.Write(oBuf, 0, oIndex);
                                                        oIndex = 0;
                                                    }

                                                    var temp1290 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                    var temp1291 = ((uint)((int)((uint)(temp1290)) % (int)((uint)((uint)10U))));
                                                    var temp1292 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1291)))))));
                                                    oBuf[oIndex + 0] = (Byte)(temp1292);
                                                    var temp1293 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                    var temp1294 = ((uint)((int)((uint)(temp1293)) % (int)((uint)((uint)10U))));
                                                    var temp1295 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1294)))))));
                                                    oBuf[oIndex + 1] = (Byte)(temp1295);
                                                    var temp1296 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                    var temp1297 = ((uint)((int)((uint)(temp1296)) % (int)((uint)((uint)10U))));
                                                    var temp1298 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1297)))))));
                                                    oBuf[oIndex + 2] = (Byte)(temp1298);
                                                    var temp1299 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                    var temp1300 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1299)))))));
                                                    oBuf[oIndex + 3] = (Byte)(temp1300);
                                                    oBuf[oIndex + 4] = (Byte)((byte)10U);
                                                    oIndex += 5;
                                                    s._4 = ((uint)(temp900));
                                                    s._3 = ((byte)((byte)0U));
                                                    s._2 = ((byte)((byte)0U));
                                                    s._1 = ((byte)((byte)0U));
                                                    s._0 = ((byte)((byte)0U));
                                                    goto M0;
                                                }
                                            }
                                            else
                                            {
                                                if (oIndex > 16380)
                                                {
                                                    output.Write(oBuf, 0, oIndex);
                                                    oIndex = 0;
                                                }

                                                var temp1301 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                var temp1302 = ((uint)((int)((uint)(temp1301)) % (int)((uint)((uint)10U))));
                                                var temp1303 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1302)))))));
                                                oBuf[oIndex + 0] = (Byte)(temp1303);
                                                var temp1304 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                var temp1305 = ((uint)((int)((uint)(temp1304)) % (int)((uint)((uint)10U))));
                                                var temp1306 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1305)))))));
                                                oBuf[oIndex + 1] = (Byte)(temp1306);
                                                var temp1307 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                var temp1308 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1307)))))));
                                                oBuf[oIndex + 2] = (Byte)(temp1308);
                                                oBuf[oIndex + 3] = (Byte)((byte)10U);
                                                oIndex += 4;
                                                s._4 = ((uint)(temp900));
                                                s._3 = ((byte)((byte)0U));
                                                s._2 = ((byte)((byte)0U));
                                                s._1 = ((byte)((byte)0U));
                                                s._0 = ((byte)((byte)0U));
                                                goto M0;
                                            }
                                        }
                                        else
                                        {
                                            if (oIndex > 16381)
                                            {
                                                output.Write(oBuf, 0, oIndex);
                                                oIndex = 0;
                                            }

                                            var temp1309 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                            var temp1310 = ((uint)((int)((uint)(temp1309)) % (int)((uint)((uint)10U))));
                                            var temp1311 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1310)))))));
                                            oBuf[oIndex + 0] = (Byte)(temp1311);
                                            var temp1312 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                            var temp1313 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1312)))))));
                                            oBuf[oIndex + 1] = (Byte)(temp1313);
                                            oBuf[oIndex + 2] = (Byte)((byte)10U);
                                            oIndex += 3;
                                            s._4 = ((uint)(temp900));
                                            s._3 = ((byte)((byte)0U));
                                            s._2 = ((byte)((byte)0U));
                                            s._1 = ((byte)((byte)0U));
                                            s._0 = ((byte)((byte)0U));
                                            goto M0;
                                        }
                                    }
                                    else
                                    {
                                        if (oIndex > 16382)
                                        {
                                            output.Write(oBuf, 0, oIndex);
                                            oIndex = 0;
                                        }

                                        var temp1314 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                        var temp1315 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1314)))))));
                                        oBuf[oIndex + 0] = (Byte)(temp1315);
                                        oBuf[oIndex + 1] = (Byte)((byte)10U);
                                        oIndex += 2;
                                        s._4 = ((uint)(temp900));
                                        s._3 = ((byte)((byte)0U));
                                        s._2 = ((byte)((byte)0U));
                                        s._1 = ((byte)((byte)0U));
                                        s._0 = ((byte)((byte)0U));
                                        goto M0;
                                    }
                                }
                            }
                        }
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
                    throw new Exception();
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
                    throw new Exception();
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
                    throw new Exception();
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
                    throw new Exception();
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
                    throw new Exception();
                }

                F0:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F1:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F2:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F3:
                    throw new Exception();
                F4:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F5:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F6:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F7:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F8:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F9:
                    throw new Exception();
                F10:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F11:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F12:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F13:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F14:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F15:
                    throw new Exception();
                F16:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F17:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F18:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F19:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F20:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F21:
                    throw new Exception();
                F22:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F23:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F24:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F25:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F26:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F27:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }
            }
        }

        struct DTStruct2
        {
            public Byte _0;
            public Byte _1;
            public Byte _2;
            public Byte _3;
            public UInt32 _4;
            public DTStruct2(Byte v0, Byte v1, Byte v2, Byte v3, UInt32 v4)
            {
                _0 = v0;
                _1 = v1;
                _2 = v2;
                _3 = v3;
                _4 = v4;
            }
        }

        public static void TransduceFromArrayToStream(byte[] input, Stream output)
        {
            unchecked
            {
                int iIndex = -1;
                var oBuf = new byte[16384];
                int oIndex = 0;
                DTStruct2 s = new DTStruct2(((byte)((byte)0U)), ((byte)((byte)0U)), ((byte)((byte)0U)), ((byte)((byte)0U)), ((uint)((uint)0U)));
                Byte i;
                M0:
                {
                    if (++iIndex >= input.Length)
                        goto F0;
                    i = input[iIndex];
                    {
                        var temp0 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp0)
                            throw new Exception();
                        else
                        {
                            var temp1 = Fun0(((byte)(i)));
                            s._0 = ((byte)(((byte)((uint)(temp1)))));
                            goto M1;
                        }
                    }
                }

                M1:
                {
                    if (++iIndex >= input.Length)
                        goto F1;
                    i = input[iIndex];
                    {
                        var temp2 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp2)
                            throw new Exception();
                        else
                        {
                            var temp3 = ((byte)((byte)(((byte)((byte)((s)._0))) & 63L)) << 2);
                            var temp4 = Fun0(((byte)(i)));
                            var temp5 = ((uint)(((int)((uint)(temp4))) >> (int)((uint)((uint)4U))));
                            var temp6 = ((byte)(((byte)(temp3)) | ((byte)(((byte)((uint)(temp5)))))));
                            s._1 = ((byte)(temp6));
                            s._0 = ((byte)(((byte)((uint)(temp4)))));
                            goto M2;
                        }
                    }
                }

                M2:
                {
                    if (++iIndex >= input.Length)
                        goto F2;
                    i = input[iIndex];
                    {
                        var temp7 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp7)
                        {
                            goto M3;
                        }
                        else
                        {
                            var temp8 = ((byte)((byte)(((byte)((byte)((s)._0))) & 15L)) << 4);
                            var temp9 = Fun0(((byte)(i)));
                            var temp10 = ((uint)(((int)((uint)(temp9))) >> (int)((uint)((uint)2U))));
                            var temp11 = ((byte)(((byte)(temp8)) | ((byte)(((byte)((uint)(temp10)))))));
                            s._2 = ((byte)(temp11));
                            s._0 = ((byte)(((byte)((uint)(temp9)))));
                            goto M4;
                        }
                    }
                }

                M3:
                {
                    if (++iIndex >= input.Length)
                        goto F3;
                    i = input[iIndex];
                    {
                        var temp12 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp12)
                        {
                            goto M27;
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
                        var temp13 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp13)
                        {
                            goto M5;
                        }
                        else
                        {
                            var temp14 = ((byte)((byte)(((byte)((byte)((s)._0))) & 3L)) << 6);
                            var temp15 = Fun0(((byte)(i)));
                            var temp16 = ((byte)(((byte)(temp14)) | ((byte)(((byte)((uint)(temp15)))))));
                            s._3 = ((byte)(temp16));
                            s._0 = ((byte)((byte)0U));
                            goto M6;
                        }
                    }
                }

                M5:
                {
                    if (++iIndex >= input.Length)
                        goto F5;
                    i = input[iIndex];
                    throw new Exception();
                }

                M6:
                {
                    if (++iIndex >= input.Length)
                        goto F6;
                    i = input[iIndex];
                    {
                        var temp17 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp17)
                            throw new Exception();
                        else
                        {
                            var temp18 = Fun0(((byte)(i)));
                            s._0 = ((byte)(((byte)((uint)(temp18)))));
                            goto M7;
                        }
                    }
                }

                M7:
                {
                    if (++iIndex >= input.Length)
                        goto F7;
                    i = input[iIndex];
                    {
                        var temp19 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp19)
                            throw new Exception();
                        else
                        {
                            var temp20 = ((byte)((byte)(((byte)((byte)((s)._0))) & 63L)) << 2);
                            var temp21 = Fun0(((byte)(i)));
                            var temp22 = ((uint)(((int)((uint)(temp21))) >> (int)((uint)((uint)4U))));
                            var temp23 = ((byte)(((byte)(temp20)) | ((byte)(((byte)((uint)(temp22)))))));
                            var temp24 = ((((uint)((byte)((s)._1)) << 8) | (uint)((byte)((s)._2)) << 8) | (uint)((byte)((s)._3)) << 8) | (uint)((byte)(temp23));
                            var temp25 = (((uint)(temp24)) == ((uint)((s)._4)));
                            if (temp25)
                            {
                                if (oIndex > 16383)
                                {
                                    output.Write(oBuf, 0, oIndex);
                                    oIndex = 0;
                                }

                                oBuf[oIndex + 0] = (Byte)((byte)48U);
                                oIndex += 1;
                                s._4 = ((uint)(temp24));
                                s._3 = ((byte)((byte)0U));
                                s._2 = ((byte)((byte)0U));
                                s._1 = ((byte)((byte)0U));
                                s._0 = ((byte)(((byte)((uint)(temp21)))));
                                goto M8;
                            }
                            else
                            {
                                var temp26 = ((uint)(((uint)((uint)4294967295U)) * ((uint)((s)._4))));
                                var temp27 = ((uint)(((uint)(temp24)) + ((uint)(temp26))));
                                var temp28 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp27)));
                                var temp29 = !(temp28);
                                if (temp29)
                                {
                                    var temp30 = ((byte)(((uint)(temp27)) >> 31));
                                    var temp31 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 1) | (ulong)((byte)(temp30 & 1L)) << 32) | (ulong)((uint)(temp27));
                                    var temp32 = ((ulong)(((ulong)((ulong)18446744073709551615UL)) * ((ulong)(temp31))));
                                    var temp33 = Fun1(((ulong)(temp32)));
                                    var temp34 = ((uint)(((uint)((uint)4294967295U)) + ((uint)(temp33))));
                                    var temp35 = ((int)((uint)(temp34)) <= (int)((uint)((uint)0U)));
                                    var temp36 = !(temp35);
                                    if (temp36)
                                    {
                                        var temp37 = ((int)((uint)(temp34)) <= (int)((uint)((uint)1U)));
                                        var temp38 = !(temp37);
                                        if (temp38)
                                        {
                                            var temp39 = ((int)((uint)(temp34)) <= (int)((uint)((uint)2U)));
                                            var temp40 = !(temp39);
                                            if (temp40)
                                            {
                                                var temp41 = ((int)((uint)(temp34)) <= (int)((uint)((uint)3U)));
                                                var temp42 = !(temp41);
                                                if (temp42)
                                                {
                                                    var temp43 = ((int)((uint)(temp34)) <= (int)((uint)((uint)4U)));
                                                    var temp44 = !(temp43);
                                                    if (temp44)
                                                    {
                                                        var temp45 = ((int)((uint)(temp34)) <= (int)((uint)((uint)5U)));
                                                        var temp46 = !(temp45);
                                                        if (temp46)
                                                        {
                                                            var temp47 = ((int)((uint)(temp34)) <= (int)((uint)((uint)6U)));
                                                            var temp48 = !(temp47);
                                                            if (temp48)
                                                            {
                                                                var temp49 = ((int)((uint)(temp34)) <= (int)((uint)((uint)7U)));
                                                                var temp50 = !(temp49);
                                                                if (temp50)
                                                                {
                                                                    var temp51 = ((int)((uint)(temp34)) <= (int)((uint)((uint)8U)));
                                                                    var temp52 = !(temp51);
                                                                    if (temp52)
                                                                    {
                                                                        if (oIndex > 16372)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                        var temp53 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000000U))));
                                                                        var temp54 = ((uint)((int)((uint)(temp53)) % (int)((uint)((uint)10U))));
                                                                        var temp55 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp54)))))));
                                                                        var temp56 = ((byte)(((byte)((byte)48U)) + ((byte)(temp55))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp56);
                                                                        var temp57 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000000U))));
                                                                        var temp58 = ((uint)((int)((uint)(temp57)) % (int)((uint)((uint)10U))));
                                                                        var temp59 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp58)))))));
                                                                        var temp60 = ((byte)(((byte)((byte)48U)) + ((byte)(temp59))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp60);
                                                                        var temp61 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000000U))));
                                                                        var temp62 = ((uint)((int)((uint)(temp61)) % (int)((uint)((uint)10U))));
                                                                        var temp63 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp62)))))));
                                                                        var temp64 = ((byte)(((byte)((byte)48U)) + ((byte)(temp63))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp64);
                                                                        var temp65 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                        var temp66 = ((uint)((int)((uint)(temp65)) % (int)((uint)((uint)10U))));
                                                                        var temp67 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp66)))))));
                                                                        var temp68 = ((byte)(((byte)((byte)48U)) + ((byte)(temp67))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp68);
                                                                        var temp69 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                        var temp70 = ((uint)((int)((uint)(temp69)) % (int)((uint)((uint)10U))));
                                                                        var temp71 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp70)))))));
                                                                        var temp72 = ((byte)(((byte)((byte)48U)) + ((byte)(temp71))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp72);
                                                                        var temp73 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                        var temp74 = ((uint)((int)((uint)(temp73)) % (int)((uint)((uint)10U))));
                                                                        var temp75 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp74)))))));
                                                                        var temp76 = ((byte)(((byte)((byte)48U)) + ((byte)(temp75))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp76);
                                                                        var temp77 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                        var temp78 = ((uint)((int)((uint)(temp77)) % (int)((uint)((uint)10U))));
                                                                        var temp79 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp78)))))));
                                                                        var temp80 = ((byte)(((byte)((byte)48U)) + ((byte)(temp79))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp80);
                                                                        var temp81 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                        var temp82 = ((uint)((int)((uint)(temp81)) % (int)((uint)((uint)10U))));
                                                                        var temp83 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp82)))))));
                                                                        var temp84 = ((byte)(((byte)((byte)48U)) + ((byte)(temp83))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp84);
                                                                        var temp85 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                        var temp86 = ((uint)((int)((uint)(temp85)) % (int)((uint)((uint)10U))));
                                                                        var temp87 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp86)))))));
                                                                        var temp88 = ((byte)(((byte)((byte)48U)) + ((byte)(temp87))));
                                                                        oBuf[oIndex + 9] = (Byte)(temp88);
                                                                        var temp89 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                        var temp90 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp89)))))));
                                                                        var temp91 = ((byte)(((byte)((byte)48U)) + ((byte)(temp90))));
                                                                        oBuf[oIndex + 10] = (Byte)(temp91);
                                                                        oBuf[oIndex + 11] = (Byte)((byte)10U);
                                                                        oIndex += 12;
                                                                        s._4 = ((uint)(temp24));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                        goto M8;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (oIndex > 16373)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                        var temp92 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000000U))));
                                                                        var temp93 = ((uint)((int)((uint)(temp92)) % (int)((uint)((uint)10U))));
                                                                        var temp94 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp93)))))));
                                                                        var temp95 = ((byte)(((byte)((byte)48U)) + ((byte)(temp94))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp95);
                                                                        var temp96 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000000U))));
                                                                        var temp97 = ((uint)((int)((uint)(temp96)) % (int)((uint)((uint)10U))));
                                                                        var temp98 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp97)))))));
                                                                        var temp99 = ((byte)(((byte)((byte)48U)) + ((byte)(temp98))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp99);
                                                                        var temp100 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                        var temp101 = ((uint)((int)((uint)(temp100)) % (int)((uint)((uint)10U))));
                                                                        var temp102 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp101)))))));
                                                                        var temp103 = ((byte)(((byte)((byte)48U)) + ((byte)(temp102))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp103);
                                                                        var temp104 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                        var temp105 = ((uint)((int)((uint)(temp104)) % (int)((uint)((uint)10U))));
                                                                        var temp106 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp105)))))));
                                                                        var temp107 = ((byte)(((byte)((byte)48U)) + ((byte)(temp106))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp107);
                                                                        var temp108 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                        var temp109 = ((uint)((int)((uint)(temp108)) % (int)((uint)((uint)10U))));
                                                                        var temp110 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp109)))))));
                                                                        var temp111 = ((byte)(((byte)((byte)48U)) + ((byte)(temp110))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp111);
                                                                        var temp112 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                        var temp113 = ((uint)((int)((uint)(temp112)) % (int)((uint)((uint)10U))));
                                                                        var temp114 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp113)))))));
                                                                        var temp115 = ((byte)(((byte)((byte)48U)) + ((byte)(temp114))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp115);
                                                                        var temp116 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                        var temp117 = ((uint)((int)((uint)(temp116)) % (int)((uint)((uint)10U))));
                                                                        var temp118 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp117)))))));
                                                                        var temp119 = ((byte)(((byte)((byte)48U)) + ((byte)(temp118))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp119);
                                                                        var temp120 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                        var temp121 = ((uint)((int)((uint)(temp120)) % (int)((uint)((uint)10U))));
                                                                        var temp122 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp121)))))));
                                                                        var temp123 = ((byte)(((byte)((byte)48U)) + ((byte)(temp122))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp123);
                                                                        var temp124 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                        var temp125 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp124)))))));
                                                                        var temp126 = ((byte)(((byte)((byte)48U)) + ((byte)(temp125))));
                                                                        oBuf[oIndex + 9] = (Byte)(temp126);
                                                                        oBuf[oIndex + 10] = (Byte)((byte)10U);
                                                                        oIndex += 11;
                                                                        s._4 = ((uint)(temp24));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                        goto M8;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (oIndex > 16374)
                                                                    {
                                                                        output.Write(oBuf, 0, oIndex);
                                                                        oIndex = 0;
                                                                    }

                                                                    oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                    var temp127 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000000U))));
                                                                    var temp128 = ((uint)((int)((uint)(temp127)) % (int)((uint)((uint)10U))));
                                                                    var temp129 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp128)))))));
                                                                    var temp130 = ((byte)(((byte)((byte)48U)) + ((byte)(temp129))));
                                                                    oBuf[oIndex + 1] = (Byte)(temp130);
                                                                    var temp131 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                    var temp132 = ((uint)((int)((uint)(temp131)) % (int)((uint)((uint)10U))));
                                                                    var temp133 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp132)))))));
                                                                    var temp134 = ((byte)(((byte)((byte)48U)) + ((byte)(temp133))));
                                                                    oBuf[oIndex + 2] = (Byte)(temp134);
                                                                    var temp135 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                    var temp136 = ((uint)((int)((uint)(temp135)) % (int)((uint)((uint)10U))));
                                                                    var temp137 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp136)))))));
                                                                    var temp138 = ((byte)(((byte)((byte)48U)) + ((byte)(temp137))));
                                                                    oBuf[oIndex + 3] = (Byte)(temp138);
                                                                    var temp139 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                    var temp140 = ((uint)((int)((uint)(temp139)) % (int)((uint)((uint)10U))));
                                                                    var temp141 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp140)))))));
                                                                    var temp142 = ((byte)(((byte)((byte)48U)) + ((byte)(temp141))));
                                                                    oBuf[oIndex + 4] = (Byte)(temp142);
                                                                    var temp143 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                    var temp144 = ((uint)((int)((uint)(temp143)) % (int)((uint)((uint)10U))));
                                                                    var temp145 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp144)))))));
                                                                    var temp146 = ((byte)(((byte)((byte)48U)) + ((byte)(temp145))));
                                                                    oBuf[oIndex + 5] = (Byte)(temp146);
                                                                    var temp147 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                    var temp148 = ((uint)((int)((uint)(temp147)) % (int)((uint)((uint)10U))));
                                                                    var temp149 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp148)))))));
                                                                    var temp150 = ((byte)(((byte)((byte)48U)) + ((byte)(temp149))));
                                                                    oBuf[oIndex + 6] = (Byte)(temp150);
                                                                    var temp151 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                    var temp152 = ((uint)((int)((uint)(temp151)) % (int)((uint)((uint)10U))));
                                                                    var temp153 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp152)))))));
                                                                    var temp154 = ((byte)(((byte)((byte)48U)) + ((byte)(temp153))));
                                                                    oBuf[oIndex + 7] = (Byte)(temp154);
                                                                    var temp155 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                    var temp156 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp155)))))));
                                                                    var temp157 = ((byte)(((byte)((byte)48U)) + ((byte)(temp156))));
                                                                    oBuf[oIndex + 8] = (Byte)(temp157);
                                                                    oBuf[oIndex + 9] = (Byte)((byte)10U);
                                                                    oIndex += 10;
                                                                    s._4 = ((uint)(temp24));
                                                                    s._3 = ((byte)((byte)0U));
                                                                    s._2 = ((byte)((byte)0U));
                                                                    s._1 = ((byte)((byte)0U));
                                                                    s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                    goto M8;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (oIndex > 16375)
                                                                {
                                                                    output.Write(oBuf, 0, oIndex);
                                                                    oIndex = 0;
                                                                }

                                                                oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                var temp158 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                var temp159 = ((uint)((int)((uint)(temp158)) % (int)((uint)((uint)10U))));
                                                                var temp160 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp159)))))));
                                                                var temp161 = ((byte)(((byte)((byte)48U)) + ((byte)(temp160))));
                                                                oBuf[oIndex + 1] = (Byte)(temp161);
                                                                var temp162 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                var temp163 = ((uint)((int)((uint)(temp162)) % (int)((uint)((uint)10U))));
                                                                var temp164 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp163)))))));
                                                                var temp165 = ((byte)(((byte)((byte)48U)) + ((byte)(temp164))));
                                                                oBuf[oIndex + 2] = (Byte)(temp165);
                                                                var temp166 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                var temp167 = ((uint)((int)((uint)(temp166)) % (int)((uint)((uint)10U))));
                                                                var temp168 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp167)))))));
                                                                var temp169 = ((byte)(((byte)((byte)48U)) + ((byte)(temp168))));
                                                                oBuf[oIndex + 3] = (Byte)(temp169);
                                                                var temp170 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                var temp171 = ((uint)((int)((uint)(temp170)) % (int)((uint)((uint)10U))));
                                                                var temp172 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp171)))))));
                                                                var temp173 = ((byte)(((byte)((byte)48U)) + ((byte)(temp172))));
                                                                oBuf[oIndex + 4] = (Byte)(temp173);
                                                                var temp174 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                var temp175 = ((uint)((int)((uint)(temp174)) % (int)((uint)((uint)10U))));
                                                                var temp176 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp175)))))));
                                                                var temp177 = ((byte)(((byte)((byte)48U)) + ((byte)(temp176))));
                                                                oBuf[oIndex + 5] = (Byte)(temp177);
                                                                var temp178 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                var temp179 = ((uint)((int)((uint)(temp178)) % (int)((uint)((uint)10U))));
                                                                var temp180 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp179)))))));
                                                                var temp181 = ((byte)(((byte)((byte)48U)) + ((byte)(temp180))));
                                                                oBuf[oIndex + 6] = (Byte)(temp181);
                                                                var temp182 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                var temp183 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp182)))))));
                                                                var temp184 = ((byte)(((byte)((byte)48U)) + ((byte)(temp183))));
                                                                oBuf[oIndex + 7] = (Byte)(temp184);
                                                                oBuf[oIndex + 8] = (Byte)((byte)10U);
                                                                oIndex += 9;
                                                                s._4 = ((uint)(temp24));
                                                                s._3 = ((byte)((byte)0U));
                                                                s._2 = ((byte)((byte)0U));
                                                                s._1 = ((byte)((byte)0U));
                                                                s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                goto M8;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (oIndex > 16376)
                                                            {
                                                                output.Write(oBuf, 0, oIndex);
                                                                oIndex = 0;
                                                            }

                                                            oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                            var temp185 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                            var temp186 = ((uint)((int)((uint)(temp185)) % (int)((uint)((uint)10U))));
                                                            var temp187 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp186)))))));
                                                            var temp188 = ((byte)(((byte)((byte)48U)) + ((byte)(temp187))));
                                                            oBuf[oIndex + 1] = (Byte)(temp188);
                                                            var temp189 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                            var temp190 = ((uint)((int)((uint)(temp189)) % (int)((uint)((uint)10U))));
                                                            var temp191 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp190)))))));
                                                            var temp192 = ((byte)(((byte)((byte)48U)) + ((byte)(temp191))));
                                                            oBuf[oIndex + 2] = (Byte)(temp192);
                                                            var temp193 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                            var temp194 = ((uint)((int)((uint)(temp193)) % (int)((uint)((uint)10U))));
                                                            var temp195 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp194)))))));
                                                            var temp196 = ((byte)(((byte)((byte)48U)) + ((byte)(temp195))));
                                                            oBuf[oIndex + 3] = (Byte)(temp196);
                                                            var temp197 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                            var temp198 = ((uint)((int)((uint)(temp197)) % (int)((uint)((uint)10U))));
                                                            var temp199 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp198)))))));
                                                            var temp200 = ((byte)(((byte)((byte)48U)) + ((byte)(temp199))));
                                                            oBuf[oIndex + 4] = (Byte)(temp200);
                                                            var temp201 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                            var temp202 = ((uint)((int)((uint)(temp201)) % (int)((uint)((uint)10U))));
                                                            var temp203 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp202)))))));
                                                            var temp204 = ((byte)(((byte)((byte)48U)) + ((byte)(temp203))));
                                                            oBuf[oIndex + 5] = (Byte)(temp204);
                                                            var temp205 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                            var temp206 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp205)))))));
                                                            var temp207 = ((byte)(((byte)((byte)48U)) + ((byte)(temp206))));
                                                            oBuf[oIndex + 6] = (Byte)(temp207);
                                                            oBuf[oIndex + 7] = (Byte)((byte)10U);
                                                            oIndex += 8;
                                                            s._4 = ((uint)(temp24));
                                                            s._3 = ((byte)((byte)0U));
                                                            s._2 = ((byte)((byte)0U));
                                                            s._1 = ((byte)((byte)0U));
                                                            s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                            goto M8;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (oIndex > 16377)
                                                        {
                                                            output.Write(oBuf, 0, oIndex);
                                                            oIndex = 0;
                                                        }

                                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                        var temp208 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                        var temp209 = ((uint)((int)((uint)(temp208)) % (int)((uint)((uint)10U))));
                                                        var temp210 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp209)))))));
                                                        var temp211 = ((byte)(((byte)((byte)48U)) + ((byte)(temp210))));
                                                        oBuf[oIndex + 1] = (Byte)(temp211);
                                                        var temp212 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                        var temp213 = ((uint)((int)((uint)(temp212)) % (int)((uint)((uint)10U))));
                                                        var temp214 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp213)))))));
                                                        var temp215 = ((byte)(((byte)((byte)48U)) + ((byte)(temp214))));
                                                        oBuf[oIndex + 2] = (Byte)(temp215);
                                                        var temp216 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                        var temp217 = ((uint)((int)((uint)(temp216)) % (int)((uint)((uint)10U))));
                                                        var temp218 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp217)))))));
                                                        var temp219 = ((byte)(((byte)((byte)48U)) + ((byte)(temp218))));
                                                        oBuf[oIndex + 3] = (Byte)(temp219);
                                                        var temp220 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                        var temp221 = ((uint)((int)((uint)(temp220)) % (int)((uint)((uint)10U))));
                                                        var temp222 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp221)))))));
                                                        var temp223 = ((byte)(((byte)((byte)48U)) + ((byte)(temp222))));
                                                        oBuf[oIndex + 4] = (Byte)(temp223);
                                                        var temp224 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                        var temp225 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp224)))))));
                                                        var temp226 = ((byte)(((byte)((byte)48U)) + ((byte)(temp225))));
                                                        oBuf[oIndex + 5] = (Byte)(temp226);
                                                        oBuf[oIndex + 6] = (Byte)((byte)10U);
                                                        oIndex += 7;
                                                        s._4 = ((uint)(temp24));
                                                        s._3 = ((byte)((byte)0U));
                                                        s._2 = ((byte)((byte)0U));
                                                        s._1 = ((byte)((byte)0U));
                                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                        goto M8;
                                                    }
                                                }
                                                else
                                                {
                                                    if (oIndex > 16378)
                                                    {
                                                        output.Write(oBuf, 0, oIndex);
                                                        oIndex = 0;
                                                    }

                                                    oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                    var temp227 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                    var temp228 = ((uint)((int)((uint)(temp227)) % (int)((uint)((uint)10U))));
                                                    var temp229 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp228)))))));
                                                    var temp230 = ((byte)(((byte)((byte)48U)) + ((byte)(temp229))));
                                                    oBuf[oIndex + 1] = (Byte)(temp230);
                                                    var temp231 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                    var temp232 = ((uint)((int)((uint)(temp231)) % (int)((uint)((uint)10U))));
                                                    var temp233 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp232)))))));
                                                    var temp234 = ((byte)(((byte)((byte)48U)) + ((byte)(temp233))));
                                                    oBuf[oIndex + 2] = (Byte)(temp234);
                                                    var temp235 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                    var temp236 = ((uint)((int)((uint)(temp235)) % (int)((uint)((uint)10U))));
                                                    var temp237 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp236)))))));
                                                    var temp238 = ((byte)(((byte)((byte)48U)) + ((byte)(temp237))));
                                                    oBuf[oIndex + 3] = (Byte)(temp238);
                                                    var temp239 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                    var temp240 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp239)))))));
                                                    var temp241 = ((byte)(((byte)((byte)48U)) + ((byte)(temp240))));
                                                    oBuf[oIndex + 4] = (Byte)(temp241);
                                                    oBuf[oIndex + 5] = (Byte)((byte)10U);
                                                    oIndex += 6;
                                                    s._4 = ((uint)(temp24));
                                                    s._3 = ((byte)((byte)0U));
                                                    s._2 = ((byte)((byte)0U));
                                                    s._1 = ((byte)((byte)0U));
                                                    s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                    goto M8;
                                                }
                                            }
                                            else
                                            {
                                                if (oIndex > 16379)
                                                {
                                                    output.Write(oBuf, 0, oIndex);
                                                    oIndex = 0;
                                                }

                                                oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                var temp242 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                var temp243 = ((uint)((int)((uint)(temp242)) % (int)((uint)((uint)10U))));
                                                var temp244 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp243)))))));
                                                var temp245 = ((byte)(((byte)((byte)48U)) + ((byte)(temp244))));
                                                oBuf[oIndex + 1] = (Byte)(temp245);
                                                var temp246 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                var temp247 = ((uint)((int)((uint)(temp246)) % (int)((uint)((uint)10U))));
                                                var temp248 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp247)))))));
                                                var temp249 = ((byte)(((byte)((byte)48U)) + ((byte)(temp248))));
                                                oBuf[oIndex + 2] = (Byte)(temp249);
                                                var temp250 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                var temp251 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp250)))))));
                                                var temp252 = ((byte)(((byte)((byte)48U)) + ((byte)(temp251))));
                                                oBuf[oIndex + 3] = (Byte)(temp252);
                                                oBuf[oIndex + 4] = (Byte)((byte)10U);
                                                oIndex += 5;
                                                s._4 = ((uint)(temp24));
                                                s._3 = ((byte)((byte)0U));
                                                s._2 = ((byte)((byte)0U));
                                                s._1 = ((byte)((byte)0U));
                                                s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                goto M8;
                                            }
                                        }
                                        else
                                        {
                                            if (oIndex > 16380)
                                            {
                                                output.Write(oBuf, 0, oIndex);
                                                oIndex = 0;
                                            }

                                            oBuf[oIndex + 0] = (Byte)((byte)45U);
                                            var temp253 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                            var temp254 = ((uint)((int)((uint)(temp253)) % (int)((uint)((uint)10U))));
                                            var temp255 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp254)))))));
                                            var temp256 = ((byte)(((byte)((byte)48U)) + ((byte)(temp255))));
                                            oBuf[oIndex + 1] = (Byte)(temp256);
                                            var temp257 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                            var temp258 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp257)))))));
                                            var temp259 = ((byte)(((byte)((byte)48U)) + ((byte)(temp258))));
                                            oBuf[oIndex + 2] = (Byte)(temp259);
                                            oBuf[oIndex + 3] = (Byte)((byte)10U);
                                            oIndex += 4;
                                            s._4 = ((uint)(temp24));
                                            s._3 = ((byte)((byte)0U));
                                            s._2 = ((byte)((byte)0U));
                                            s._1 = ((byte)((byte)0U));
                                            s._0 = ((byte)(((byte)((uint)(temp21)))));
                                            goto M8;
                                        }
                                    }
                                    else
                                    {
                                        if (oIndex > 16381)
                                        {
                                            output.Write(oBuf, 0, oIndex);
                                            oIndex = 0;
                                        }

                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                        var temp260 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                        var temp261 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp260)))))));
                                        var temp262 = ((byte)(((byte)((byte)48U)) + ((byte)(temp261))));
                                        oBuf[oIndex + 1] = (Byte)(temp262);
                                        oBuf[oIndex + 2] = (Byte)((byte)10U);
                                        oIndex += 3;
                                        s._4 = ((uint)(temp24));
                                        s._3 = ((byte)((byte)0U));
                                        s._2 = ((byte)((byte)0U));
                                        s._1 = ((byte)((byte)0U));
                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                        goto M8;
                                    }
                                }
                                else
                                {
                                    var temp263 = ((byte)(((uint)(temp27)) >> 31));
                                    var temp264 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 1) | (ulong)((byte)(temp263 & 1L)) << 32) | (ulong)((uint)(temp27));
                                    var temp265 = Fun1(((ulong)(temp264)));
                                    var temp266 = ((uint)(((uint)((uint)4294967295U)) + ((uint)(temp265))));
                                    var temp267 = ((int)((uint)(temp266)) <= (int)((uint)((uint)0U)));
                                    var temp268 = !(temp267);
                                    if (temp268)
                                    {
                                        var temp269 = ((int)((uint)(temp266)) <= (int)((uint)((uint)1U)));
                                        var temp270 = !(temp269);
                                        if (temp270)
                                        {
                                            var temp271 = ((int)((uint)(temp266)) <= (int)((uint)((uint)2U)));
                                            var temp272 = !(temp271);
                                            if (temp272)
                                            {
                                                var temp273 = ((int)((uint)(temp266)) <= (int)((uint)((uint)3U)));
                                                var temp274 = !(temp273);
                                                if (temp274)
                                                {
                                                    var temp275 = ((int)((uint)(temp266)) <= (int)((uint)((uint)4U)));
                                                    var temp276 = !(temp275);
                                                    if (temp276)
                                                    {
                                                        var temp277 = ((int)((uint)(temp266)) <= (int)((uint)((uint)5U)));
                                                        var temp278 = !(temp277);
                                                        if (temp278)
                                                        {
                                                            var temp279 = ((int)((uint)(temp266)) <= (int)((uint)((uint)6U)));
                                                            var temp280 = !(temp279);
                                                            if (temp280)
                                                            {
                                                                var temp281 = ((int)((uint)(temp266)) <= (int)((uint)((uint)7U)));
                                                                var temp282 = !(temp281);
                                                                if (temp282)
                                                                {
                                                                    var temp283 = ((int)((uint)(temp266)) <= (int)((uint)((uint)8U)));
                                                                    var temp284 = !(temp283);
                                                                    if (temp284)
                                                                    {
                                                                        if (oIndex > 16373)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        var temp285 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000000U))));
                                                                        var temp286 = ((uint)((int)((uint)(temp285)) % (int)((uint)((uint)10U))));
                                                                        var temp287 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp286)))))));
                                                                        oBuf[oIndex + 0] = (Byte)(temp287);
                                                                        var temp288 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000000U))));
                                                                        var temp289 = ((uint)((int)((uint)(temp288)) % (int)((uint)((uint)10U))));
                                                                        var temp290 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp289)))))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp290);
                                                                        var temp291 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000000U))));
                                                                        var temp292 = ((uint)((int)((uint)(temp291)) % (int)((uint)((uint)10U))));
                                                                        var temp293 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp292)))))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp293);
                                                                        var temp294 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                        var temp295 = ((uint)((int)((uint)(temp294)) % (int)((uint)((uint)10U))));
                                                                        var temp296 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp295)))))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp296);
                                                                        var temp297 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                        var temp298 = ((uint)((int)((uint)(temp297)) % (int)((uint)((uint)10U))));
                                                                        var temp299 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp298)))))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp299);
                                                                        var temp300 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                        var temp301 = ((uint)((int)((uint)(temp300)) % (int)((uint)((uint)10U))));
                                                                        var temp302 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp301)))))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp302);
                                                                        var temp303 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                        var temp304 = ((uint)((int)((uint)(temp303)) % (int)((uint)((uint)10U))));
                                                                        var temp305 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp304)))))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp305);
                                                                        var temp306 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                        var temp307 = ((uint)((int)((uint)(temp306)) % (int)((uint)((uint)10U))));
                                                                        var temp308 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp307)))))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp308);
                                                                        var temp309 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                        var temp310 = ((uint)((int)((uint)(temp309)) % (int)((uint)((uint)10U))));
                                                                        var temp311 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp310)))))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp311);
                                                                        var temp312 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                        var temp313 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp312)))))));
                                                                        oBuf[oIndex + 9] = (Byte)(temp313);
                                                                        oBuf[oIndex + 10] = (Byte)((byte)10U);
                                                                        oIndex += 11;
                                                                        s._4 = ((uint)(temp24));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                        goto M8;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (oIndex > 16374)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        var temp314 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000000U))));
                                                                        var temp315 = ((uint)((int)((uint)(temp314)) % (int)((uint)((uint)10U))));
                                                                        var temp316 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp315)))))));
                                                                        oBuf[oIndex + 0] = (Byte)(temp316);
                                                                        var temp317 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000000U))));
                                                                        var temp318 = ((uint)((int)((uint)(temp317)) % (int)((uint)((uint)10U))));
                                                                        var temp319 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp318)))))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp319);
                                                                        var temp320 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                        var temp321 = ((uint)((int)((uint)(temp320)) % (int)((uint)((uint)10U))));
                                                                        var temp322 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp321)))))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp322);
                                                                        var temp323 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                        var temp324 = ((uint)((int)((uint)(temp323)) % (int)((uint)((uint)10U))));
                                                                        var temp325 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp324)))))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp325);
                                                                        var temp326 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                        var temp327 = ((uint)((int)((uint)(temp326)) % (int)((uint)((uint)10U))));
                                                                        var temp328 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp327)))))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp328);
                                                                        var temp329 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                        var temp330 = ((uint)((int)((uint)(temp329)) % (int)((uint)((uint)10U))));
                                                                        var temp331 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp330)))))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp331);
                                                                        var temp332 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                        var temp333 = ((uint)((int)((uint)(temp332)) % (int)((uint)((uint)10U))));
                                                                        var temp334 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp333)))))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp334);
                                                                        var temp335 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                        var temp336 = ((uint)((int)((uint)(temp335)) % (int)((uint)((uint)10U))));
                                                                        var temp337 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp336)))))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp337);
                                                                        var temp338 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                        var temp339 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp338)))))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp339);
                                                                        oBuf[oIndex + 9] = (Byte)((byte)10U);
                                                                        oIndex += 10;
                                                                        s._4 = ((uint)(temp24));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                        goto M8;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (oIndex > 16375)
                                                                    {
                                                                        output.Write(oBuf, 0, oIndex);
                                                                        oIndex = 0;
                                                                    }

                                                                    var temp340 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000000U))));
                                                                    var temp341 = ((uint)((int)((uint)(temp340)) % (int)((uint)((uint)10U))));
                                                                    var temp342 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp341)))))));
                                                                    oBuf[oIndex + 0] = (Byte)(temp342);
                                                                    var temp343 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                    var temp344 = ((uint)((int)((uint)(temp343)) % (int)((uint)((uint)10U))));
                                                                    var temp345 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp344)))))));
                                                                    oBuf[oIndex + 1] = (Byte)(temp345);
                                                                    var temp346 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                    var temp347 = ((uint)((int)((uint)(temp346)) % (int)((uint)((uint)10U))));
                                                                    var temp348 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp347)))))));
                                                                    oBuf[oIndex + 2] = (Byte)(temp348);
                                                                    var temp349 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                    var temp350 = ((uint)((int)((uint)(temp349)) % (int)((uint)((uint)10U))));
                                                                    var temp351 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp350)))))));
                                                                    oBuf[oIndex + 3] = (Byte)(temp351);
                                                                    var temp352 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                    var temp353 = ((uint)((int)((uint)(temp352)) % (int)((uint)((uint)10U))));
                                                                    var temp354 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp353)))))));
                                                                    oBuf[oIndex + 4] = (Byte)(temp354);
                                                                    var temp355 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                    var temp356 = ((uint)((int)((uint)(temp355)) % (int)((uint)((uint)10U))));
                                                                    var temp357 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp356)))))));
                                                                    oBuf[oIndex + 5] = (Byte)(temp357);
                                                                    var temp358 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                    var temp359 = ((uint)((int)((uint)(temp358)) % (int)((uint)((uint)10U))));
                                                                    var temp360 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp359)))))));
                                                                    oBuf[oIndex + 6] = (Byte)(temp360);
                                                                    var temp361 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                    var temp362 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp361)))))));
                                                                    oBuf[oIndex + 7] = (Byte)(temp362);
                                                                    oBuf[oIndex + 8] = (Byte)((byte)10U);
                                                                    oIndex += 9;
                                                                    s._4 = ((uint)(temp24));
                                                                    s._3 = ((byte)((byte)0U));
                                                                    s._2 = ((byte)((byte)0U));
                                                                    s._1 = ((byte)((byte)0U));
                                                                    s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                    goto M8;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (oIndex > 16376)
                                                                {
                                                                    output.Write(oBuf, 0, oIndex);
                                                                    oIndex = 0;
                                                                }

                                                                var temp363 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000000U))));
                                                                var temp364 = ((uint)((int)((uint)(temp363)) % (int)((uint)((uint)10U))));
                                                                var temp365 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp364)))))));
                                                                oBuf[oIndex + 0] = (Byte)(temp365);
                                                                var temp366 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                                var temp367 = ((uint)((int)((uint)(temp366)) % (int)((uint)((uint)10U))));
                                                                var temp368 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp367)))))));
                                                                oBuf[oIndex + 1] = (Byte)(temp368);
                                                                var temp369 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                                var temp370 = ((uint)((int)((uint)(temp369)) % (int)((uint)((uint)10U))));
                                                                var temp371 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp370)))))));
                                                                oBuf[oIndex + 2] = (Byte)(temp371);
                                                                var temp372 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                                var temp373 = ((uint)((int)((uint)(temp372)) % (int)((uint)((uint)10U))));
                                                                var temp374 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp373)))))));
                                                                oBuf[oIndex + 3] = (Byte)(temp374);
                                                                var temp375 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                                var temp376 = ((uint)((int)((uint)(temp375)) % (int)((uint)((uint)10U))));
                                                                var temp377 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp376)))))));
                                                                oBuf[oIndex + 4] = (Byte)(temp377);
                                                                var temp378 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                                var temp379 = ((uint)((int)((uint)(temp378)) % (int)((uint)((uint)10U))));
                                                                var temp380 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp379)))))));
                                                                oBuf[oIndex + 5] = (Byte)(temp380);
                                                                var temp381 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                                var temp382 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp381)))))));
                                                                oBuf[oIndex + 6] = (Byte)(temp382);
                                                                oBuf[oIndex + 7] = (Byte)((byte)10U);
                                                                oIndex += 8;
                                                                s._4 = ((uint)(temp24));
                                                                s._3 = ((byte)((byte)0U));
                                                                s._2 = ((byte)((byte)0U));
                                                                s._1 = ((byte)((byte)0U));
                                                                s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                                goto M8;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (oIndex > 16377)
                                                            {
                                                                output.Write(oBuf, 0, oIndex);
                                                                oIndex = 0;
                                                            }

                                                            var temp383 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100000U))));
                                                            var temp384 = ((uint)((int)((uint)(temp383)) % (int)((uint)((uint)10U))));
                                                            var temp385 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp384)))))));
                                                            oBuf[oIndex + 0] = (Byte)(temp385);
                                                            var temp386 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                            var temp387 = ((uint)((int)((uint)(temp386)) % (int)((uint)((uint)10U))));
                                                            var temp388 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp387)))))));
                                                            oBuf[oIndex + 1] = (Byte)(temp388);
                                                            var temp389 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                            var temp390 = ((uint)((int)((uint)(temp389)) % (int)((uint)((uint)10U))));
                                                            var temp391 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp390)))))));
                                                            oBuf[oIndex + 2] = (Byte)(temp391);
                                                            var temp392 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                            var temp393 = ((uint)((int)((uint)(temp392)) % (int)((uint)((uint)10U))));
                                                            var temp394 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp393)))))));
                                                            oBuf[oIndex + 3] = (Byte)(temp394);
                                                            var temp395 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                            var temp396 = ((uint)((int)((uint)(temp395)) % (int)((uint)((uint)10U))));
                                                            var temp397 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp396)))))));
                                                            oBuf[oIndex + 4] = (Byte)(temp397);
                                                            var temp398 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                            var temp399 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp398)))))));
                                                            oBuf[oIndex + 5] = (Byte)(temp399);
                                                            oBuf[oIndex + 6] = (Byte)((byte)10U);
                                                            oIndex += 7;
                                                            s._4 = ((uint)(temp24));
                                                            s._3 = ((byte)((byte)0U));
                                                            s._2 = ((byte)((byte)0U));
                                                            s._1 = ((byte)((byte)0U));
                                                            s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                            goto M8;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (oIndex > 16378)
                                                        {
                                                            output.Write(oBuf, 0, oIndex);
                                                            oIndex = 0;
                                                        }

                                                        var temp400 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10000U))));
                                                        var temp401 = ((uint)((int)((uint)(temp400)) % (int)((uint)((uint)10U))));
                                                        var temp402 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp401)))))));
                                                        oBuf[oIndex + 0] = (Byte)(temp402);
                                                        var temp403 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                        var temp404 = ((uint)((int)((uint)(temp403)) % (int)((uint)((uint)10U))));
                                                        var temp405 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp404)))))));
                                                        oBuf[oIndex + 1] = (Byte)(temp405);
                                                        var temp406 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                        var temp407 = ((uint)((int)((uint)(temp406)) % (int)((uint)((uint)10U))));
                                                        var temp408 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp407)))))));
                                                        oBuf[oIndex + 2] = (Byte)(temp408);
                                                        var temp409 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                        var temp410 = ((uint)((int)((uint)(temp409)) % (int)((uint)((uint)10U))));
                                                        var temp411 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp410)))))));
                                                        oBuf[oIndex + 3] = (Byte)(temp411);
                                                        var temp412 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                        var temp413 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp412)))))));
                                                        oBuf[oIndex + 4] = (Byte)(temp413);
                                                        oBuf[oIndex + 5] = (Byte)((byte)10U);
                                                        oIndex += 6;
                                                        s._4 = ((uint)(temp24));
                                                        s._3 = ((byte)((byte)0U));
                                                        s._2 = ((byte)((byte)0U));
                                                        s._1 = ((byte)((byte)0U));
                                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                        goto M8;
                                                    }
                                                }
                                                else
                                                {
                                                    if (oIndex > 16379)
                                                    {
                                                        output.Write(oBuf, 0, oIndex);
                                                        oIndex = 0;
                                                    }

                                                    var temp414 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)1000U))));
                                                    var temp415 = ((uint)((int)((uint)(temp414)) % (int)((uint)((uint)10U))));
                                                    var temp416 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp415)))))));
                                                    oBuf[oIndex + 0] = (Byte)(temp416);
                                                    var temp417 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                    var temp418 = ((uint)((int)((uint)(temp417)) % (int)((uint)((uint)10U))));
                                                    var temp419 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp418)))))));
                                                    oBuf[oIndex + 1] = (Byte)(temp419);
                                                    var temp420 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                    var temp421 = ((uint)((int)((uint)(temp420)) % (int)((uint)((uint)10U))));
                                                    var temp422 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp421)))))));
                                                    oBuf[oIndex + 2] = (Byte)(temp422);
                                                    var temp423 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                    var temp424 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp423)))))));
                                                    oBuf[oIndex + 3] = (Byte)(temp424);
                                                    oBuf[oIndex + 4] = (Byte)((byte)10U);
                                                    oIndex += 5;
                                                    s._4 = ((uint)(temp24));
                                                    s._3 = ((byte)((byte)0U));
                                                    s._2 = ((byte)((byte)0U));
                                                    s._1 = ((byte)((byte)0U));
                                                    s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                    goto M8;
                                                }
                                            }
                                            else
                                            {
                                                if (oIndex > 16380)
                                                {
                                                    output.Write(oBuf, 0, oIndex);
                                                    oIndex = 0;
                                                }

                                                var temp425 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)100U))));
                                                var temp426 = ((uint)((int)((uint)(temp425)) % (int)((uint)((uint)10U))));
                                                var temp427 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp426)))))));
                                                oBuf[oIndex + 0] = (Byte)(temp427);
                                                var temp428 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                                var temp429 = ((uint)((int)((uint)(temp428)) % (int)((uint)((uint)10U))));
                                                var temp430 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp429)))))));
                                                oBuf[oIndex + 1] = (Byte)(temp430);
                                                var temp431 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                                var temp432 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp431)))))));
                                                oBuf[oIndex + 2] = (Byte)(temp432);
                                                oBuf[oIndex + 3] = (Byte)((byte)10U);
                                                oIndex += 4;
                                                s._4 = ((uint)(temp24));
                                                s._3 = ((byte)((byte)0U));
                                                s._2 = ((byte)((byte)0U));
                                                s._1 = ((byte)((byte)0U));
                                                s._0 = ((byte)(((byte)((uint)(temp21)))));
                                                goto M8;
                                            }
                                        }
                                        else
                                        {
                                            if (oIndex > 16381)
                                            {
                                                output.Write(oBuf, 0, oIndex);
                                                oIndex = 0;
                                            }

                                            var temp433 = ((uint)((int)((uint)(temp27)) / (int)((uint)((uint)10U))));
                                            var temp434 = ((uint)((int)((uint)(temp433)) % (int)((uint)((uint)10U))));
                                            var temp435 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp434)))))));
                                            oBuf[oIndex + 0] = (Byte)(temp435);
                                            var temp436 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                            var temp437 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp436)))))));
                                            oBuf[oIndex + 1] = (Byte)(temp437);
                                            oBuf[oIndex + 2] = (Byte)((byte)10U);
                                            oIndex += 3;
                                            s._4 = ((uint)(temp24));
                                            s._3 = ((byte)((byte)0U));
                                            s._2 = ((byte)((byte)0U));
                                            s._1 = ((byte)((byte)0U));
                                            s._0 = ((byte)(((byte)((uint)(temp21)))));
                                            goto M8;
                                        }
                                    }
                                    else
                                    {
                                        if (oIndex > 16382)
                                        {
                                            output.Write(oBuf, 0, oIndex);
                                            oIndex = 0;
                                        }

                                        var temp438 = ((uint)((int)((uint)(temp27)) % (int)((uint)((uint)10U))));
                                        var temp439 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp438)))))));
                                        oBuf[oIndex + 0] = (Byte)(temp439);
                                        oBuf[oIndex + 1] = (Byte)((byte)10U);
                                        oIndex += 2;
                                        s._4 = ((uint)(temp24));
                                        s._3 = ((byte)((byte)0U));
                                        s._2 = ((byte)((byte)0U));
                                        s._1 = ((byte)((byte)0U));
                                        s._0 = ((byte)(((byte)((uint)(temp21)))));
                                        goto M8;
                                    }
                                }
                            }
                        }
                    }
                }

                M8:
                {
                    if (++iIndex >= input.Length)
                        goto F8;
                    i = input[iIndex];
                    {
                        var temp440 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp440)
                        {
                            goto M9;
                        }
                        else
                        {
                            var temp441 = ((byte)((byte)(((byte)((byte)((s)._0))) & 15L)) << 4);
                            var temp442 = Fun0(((byte)(i)));
                            var temp443 = ((uint)(((int)((uint)(temp442))) >> (int)((uint)((uint)2U))));
                            var temp444 = ((byte)(((byte)(temp441)) | ((byte)(((byte)((uint)(temp443)))))));
                            s._1 = ((byte)(temp444));
                            s._0 = ((byte)(((byte)((uint)(temp442)))));
                            goto M10;
                        }
                    }
                }

                M9:
                {
                    if (++iIndex >= input.Length)
                        goto F9;
                    i = input[iIndex];
                    {
                        var temp445 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp445)
                        {
                            goto M26;
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
                        var temp446 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp446)
                        {
                            goto M11;
                        }
                        else
                        {
                            var temp447 = ((byte)((byte)(((byte)((byte)((s)._0))) & 3L)) << 6);
                            var temp448 = Fun0(((byte)(i)));
                            var temp449 = ((byte)(((byte)(temp447)) | ((byte)(((byte)((uint)(temp448)))))));
                            s._2 = ((byte)(temp449));
                            s._0 = ((byte)((byte)0U));
                            goto M12;
                        }
                    }
                }

                M11:
                {
                    if (++iIndex >= input.Length)
                        goto F11;
                    i = input[iIndex];
                    throw new Exception();
                }

                M12:
                {
                    if (++iIndex >= input.Length)
                        goto F12;
                    i = input[iIndex];
                    {
                        var temp450 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp450)
                            throw new Exception();
                        else
                        {
                            var temp451 = Fun0(((byte)(i)));
                            s._0 = ((byte)(((byte)((uint)(temp451)))));
                            goto M13;
                        }
                    }
                }

                M13:
                {
                    if (++iIndex >= input.Length)
                        goto F13;
                    i = input[iIndex];
                    {
                        var temp452 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp452)
                            throw new Exception();
                        else
                        {
                            var temp453 = ((byte)((byte)(((byte)((byte)((s)._0))) & 63L)) << 2);
                            var temp454 = Fun0(((byte)(i)));
                            var temp455 = ((uint)(((int)((uint)(temp454))) >> (int)((uint)((uint)4U))));
                            var temp456 = ((byte)(((byte)(temp453)) | ((byte)(((byte)((uint)(temp455)))))));
                            s._3 = ((byte)(temp456));
                            s._0 = ((byte)(((byte)((uint)(temp454)))));
                            goto M14;
                        }
                    }
                }

                M14:
                {
                    if (++iIndex >= input.Length)
                        goto F14;
                    i = input[iIndex];
                    {
                        var temp457 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp457)
                        {
                            goto M15;
                        }
                        else
                        {
                            var temp458 = ((byte)((byte)(((byte)((byte)((s)._0))) & 15L)) << 4);
                            var temp459 = Fun0(((byte)(i)));
                            var temp460 = ((uint)(((int)((uint)(temp459))) >> (int)((uint)((uint)2U))));
                            var temp461 = ((byte)(((byte)(temp458)) | ((byte)(((byte)((uint)(temp460)))))));
                            var temp462 = ((((uint)((byte)((s)._1)) << 8) | (uint)((byte)((s)._2)) << 8) | (uint)((byte)((s)._3)) << 8) | (uint)((byte)(temp461));
                            var temp463 = (((uint)(temp462)) == ((uint)((s)._4)));
                            if (temp463)
                            {
                                if (oIndex > 16383)
                                {
                                    output.Write(oBuf, 0, oIndex);
                                    oIndex = 0;
                                }

                                oBuf[oIndex + 0] = (Byte)((byte)48U);
                                oIndex += 1;
                                s._4 = ((uint)(temp462));
                                s._3 = ((byte)((byte)0U));
                                s._2 = ((byte)((byte)0U));
                                s._1 = ((byte)((byte)0U));
                                s._0 = ((byte)(((byte)((uint)(temp459)))));
                                goto M16;
                            }
                            else
                            {
                                var temp464 = ((uint)(((uint)((uint)4294967295U)) * ((uint)((s)._4))));
                                var temp465 = ((uint)(((uint)(temp462)) + ((uint)(temp464))));
                                var temp466 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp465)));
                                var temp467 = !(temp466);
                                if (temp467)
                                {
                                    var temp468 = ((byte)(((uint)(temp465)) >> 31));
                                    var temp469 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 1) | (ulong)((byte)(temp468 & 1L)) << 32) | (ulong)((uint)(temp465));
                                    var temp470 = ((ulong)(((ulong)((ulong)18446744073709551615UL)) * ((ulong)(temp469))));
                                    var temp471 = Fun1(((ulong)(temp470)));
                                    var temp472 = ((uint)(((uint)((uint)4294967295U)) + ((uint)(temp471))));
                                    var temp473 = ((int)((uint)(temp472)) <= (int)((uint)((uint)0U)));
                                    var temp474 = !(temp473);
                                    if (temp474)
                                    {
                                        var temp475 = ((int)((uint)(temp472)) <= (int)((uint)((uint)1U)));
                                        var temp476 = !(temp475);
                                        if (temp476)
                                        {
                                            var temp477 = ((int)((uint)(temp472)) <= (int)((uint)((uint)2U)));
                                            var temp478 = !(temp477);
                                            if (temp478)
                                            {
                                                var temp479 = ((int)((uint)(temp472)) <= (int)((uint)((uint)3U)));
                                                var temp480 = !(temp479);
                                                if (temp480)
                                                {
                                                    var temp481 = ((int)((uint)(temp472)) <= (int)((uint)((uint)4U)));
                                                    var temp482 = !(temp481);
                                                    if (temp482)
                                                    {
                                                        var temp483 = ((int)((uint)(temp472)) <= (int)((uint)((uint)5U)));
                                                        var temp484 = !(temp483);
                                                        if (temp484)
                                                        {
                                                            var temp485 = ((int)((uint)(temp472)) <= (int)((uint)((uint)6U)));
                                                            var temp486 = !(temp485);
                                                            if (temp486)
                                                            {
                                                                var temp487 = ((int)((uint)(temp472)) <= (int)((uint)((uint)7U)));
                                                                var temp488 = !(temp487);
                                                                if (temp488)
                                                                {
                                                                    var temp489 = ((int)((uint)(temp472)) <= (int)((uint)((uint)8U)));
                                                                    var temp490 = !(temp489);
                                                                    if (temp490)
                                                                    {
                                                                        if (oIndex > 16372)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                        var temp491 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000000U))));
                                                                        var temp492 = ((uint)((int)((uint)(temp491)) % (int)((uint)((uint)10U))));
                                                                        var temp493 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp492)))))));
                                                                        var temp494 = ((byte)(((byte)((byte)48U)) + ((byte)(temp493))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp494);
                                                                        var temp495 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000000U))));
                                                                        var temp496 = ((uint)((int)((uint)(temp495)) % (int)((uint)((uint)10U))));
                                                                        var temp497 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp496)))))));
                                                                        var temp498 = ((byte)(((byte)((byte)48U)) + ((byte)(temp497))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp498);
                                                                        var temp499 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000000U))));
                                                                        var temp500 = ((uint)((int)((uint)(temp499)) % (int)((uint)((uint)10U))));
                                                                        var temp501 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp500)))))));
                                                                        var temp502 = ((byte)(((byte)((byte)48U)) + ((byte)(temp501))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp502);
                                                                        var temp503 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                        var temp504 = ((uint)((int)((uint)(temp503)) % (int)((uint)((uint)10U))));
                                                                        var temp505 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp504)))))));
                                                                        var temp506 = ((byte)(((byte)((byte)48U)) + ((byte)(temp505))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp506);
                                                                        var temp507 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                        var temp508 = ((uint)((int)((uint)(temp507)) % (int)((uint)((uint)10U))));
                                                                        var temp509 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp508)))))));
                                                                        var temp510 = ((byte)(((byte)((byte)48U)) + ((byte)(temp509))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp510);
                                                                        var temp511 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                        var temp512 = ((uint)((int)((uint)(temp511)) % (int)((uint)((uint)10U))));
                                                                        var temp513 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp512)))))));
                                                                        var temp514 = ((byte)(((byte)((byte)48U)) + ((byte)(temp513))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp514);
                                                                        var temp515 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                        var temp516 = ((uint)((int)((uint)(temp515)) % (int)((uint)((uint)10U))));
                                                                        var temp517 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp516)))))));
                                                                        var temp518 = ((byte)(((byte)((byte)48U)) + ((byte)(temp517))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp518);
                                                                        var temp519 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                        var temp520 = ((uint)((int)((uint)(temp519)) % (int)((uint)((uint)10U))));
                                                                        var temp521 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp520)))))));
                                                                        var temp522 = ((byte)(((byte)((byte)48U)) + ((byte)(temp521))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp522);
                                                                        var temp523 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                        var temp524 = ((uint)((int)((uint)(temp523)) % (int)((uint)((uint)10U))));
                                                                        var temp525 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp524)))))));
                                                                        var temp526 = ((byte)(((byte)((byte)48U)) + ((byte)(temp525))));
                                                                        oBuf[oIndex + 9] = (Byte)(temp526);
                                                                        var temp527 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                        var temp528 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp527)))))));
                                                                        var temp529 = ((byte)(((byte)((byte)48U)) + ((byte)(temp528))));
                                                                        oBuf[oIndex + 10] = (Byte)(temp529);
                                                                        oBuf[oIndex + 11] = (Byte)((byte)10U);
                                                                        oIndex += 12;
                                                                        s._4 = ((uint)(temp462));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                        goto M16;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (oIndex > 16373)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                        var temp530 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000000U))));
                                                                        var temp531 = ((uint)((int)((uint)(temp530)) % (int)((uint)((uint)10U))));
                                                                        var temp532 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp531)))))));
                                                                        var temp533 = ((byte)(((byte)((byte)48U)) + ((byte)(temp532))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp533);
                                                                        var temp534 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000000U))));
                                                                        var temp535 = ((uint)((int)((uint)(temp534)) % (int)((uint)((uint)10U))));
                                                                        var temp536 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp535)))))));
                                                                        var temp537 = ((byte)(((byte)((byte)48U)) + ((byte)(temp536))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp537);
                                                                        var temp538 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                        var temp539 = ((uint)((int)((uint)(temp538)) % (int)((uint)((uint)10U))));
                                                                        var temp540 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp539)))))));
                                                                        var temp541 = ((byte)(((byte)((byte)48U)) + ((byte)(temp540))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp541);
                                                                        var temp542 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                        var temp543 = ((uint)((int)((uint)(temp542)) % (int)((uint)((uint)10U))));
                                                                        var temp544 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp543)))))));
                                                                        var temp545 = ((byte)(((byte)((byte)48U)) + ((byte)(temp544))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp545);
                                                                        var temp546 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                        var temp547 = ((uint)((int)((uint)(temp546)) % (int)((uint)((uint)10U))));
                                                                        var temp548 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp547)))))));
                                                                        var temp549 = ((byte)(((byte)((byte)48U)) + ((byte)(temp548))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp549);
                                                                        var temp550 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                        var temp551 = ((uint)((int)((uint)(temp550)) % (int)((uint)((uint)10U))));
                                                                        var temp552 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp551)))))));
                                                                        var temp553 = ((byte)(((byte)((byte)48U)) + ((byte)(temp552))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp553);
                                                                        var temp554 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                        var temp555 = ((uint)((int)((uint)(temp554)) % (int)((uint)((uint)10U))));
                                                                        var temp556 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp555)))))));
                                                                        var temp557 = ((byte)(((byte)((byte)48U)) + ((byte)(temp556))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp557);
                                                                        var temp558 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                        var temp559 = ((uint)((int)((uint)(temp558)) % (int)((uint)((uint)10U))));
                                                                        var temp560 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp559)))))));
                                                                        var temp561 = ((byte)(((byte)((byte)48U)) + ((byte)(temp560))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp561);
                                                                        var temp562 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                        var temp563 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp562)))))));
                                                                        var temp564 = ((byte)(((byte)((byte)48U)) + ((byte)(temp563))));
                                                                        oBuf[oIndex + 9] = (Byte)(temp564);
                                                                        oBuf[oIndex + 10] = (Byte)((byte)10U);
                                                                        oIndex += 11;
                                                                        s._4 = ((uint)(temp462));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                        goto M16;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (oIndex > 16374)
                                                                    {
                                                                        output.Write(oBuf, 0, oIndex);
                                                                        oIndex = 0;
                                                                    }

                                                                    oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                    var temp565 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000000U))));
                                                                    var temp566 = ((uint)((int)((uint)(temp565)) % (int)((uint)((uint)10U))));
                                                                    var temp567 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp566)))))));
                                                                    var temp568 = ((byte)(((byte)((byte)48U)) + ((byte)(temp567))));
                                                                    oBuf[oIndex + 1] = (Byte)(temp568);
                                                                    var temp569 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                    var temp570 = ((uint)((int)((uint)(temp569)) % (int)((uint)((uint)10U))));
                                                                    var temp571 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp570)))))));
                                                                    var temp572 = ((byte)(((byte)((byte)48U)) + ((byte)(temp571))));
                                                                    oBuf[oIndex + 2] = (Byte)(temp572);
                                                                    var temp573 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                    var temp574 = ((uint)((int)((uint)(temp573)) % (int)((uint)((uint)10U))));
                                                                    var temp575 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp574)))))));
                                                                    var temp576 = ((byte)(((byte)((byte)48U)) + ((byte)(temp575))));
                                                                    oBuf[oIndex + 3] = (Byte)(temp576);
                                                                    var temp577 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                    var temp578 = ((uint)((int)((uint)(temp577)) % (int)((uint)((uint)10U))));
                                                                    var temp579 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp578)))))));
                                                                    var temp580 = ((byte)(((byte)((byte)48U)) + ((byte)(temp579))));
                                                                    oBuf[oIndex + 4] = (Byte)(temp580);
                                                                    var temp581 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                    var temp582 = ((uint)((int)((uint)(temp581)) % (int)((uint)((uint)10U))));
                                                                    var temp583 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp582)))))));
                                                                    var temp584 = ((byte)(((byte)((byte)48U)) + ((byte)(temp583))));
                                                                    oBuf[oIndex + 5] = (Byte)(temp584);
                                                                    var temp585 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                    var temp586 = ((uint)((int)((uint)(temp585)) % (int)((uint)((uint)10U))));
                                                                    var temp587 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp586)))))));
                                                                    var temp588 = ((byte)(((byte)((byte)48U)) + ((byte)(temp587))));
                                                                    oBuf[oIndex + 6] = (Byte)(temp588);
                                                                    var temp589 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                    var temp590 = ((uint)((int)((uint)(temp589)) % (int)((uint)((uint)10U))));
                                                                    var temp591 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp590)))))));
                                                                    var temp592 = ((byte)(((byte)((byte)48U)) + ((byte)(temp591))));
                                                                    oBuf[oIndex + 7] = (Byte)(temp592);
                                                                    var temp593 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                    var temp594 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp593)))))));
                                                                    var temp595 = ((byte)(((byte)((byte)48U)) + ((byte)(temp594))));
                                                                    oBuf[oIndex + 8] = (Byte)(temp595);
                                                                    oBuf[oIndex + 9] = (Byte)((byte)10U);
                                                                    oIndex += 10;
                                                                    s._4 = ((uint)(temp462));
                                                                    s._3 = ((byte)((byte)0U));
                                                                    s._2 = ((byte)((byte)0U));
                                                                    s._1 = ((byte)((byte)0U));
                                                                    s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                    goto M16;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (oIndex > 16375)
                                                                {
                                                                    output.Write(oBuf, 0, oIndex);
                                                                    oIndex = 0;
                                                                }

                                                                oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                var temp596 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                var temp597 = ((uint)((int)((uint)(temp596)) % (int)((uint)((uint)10U))));
                                                                var temp598 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp597)))))));
                                                                var temp599 = ((byte)(((byte)((byte)48U)) + ((byte)(temp598))));
                                                                oBuf[oIndex + 1] = (Byte)(temp599);
                                                                var temp600 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                var temp601 = ((uint)((int)((uint)(temp600)) % (int)((uint)((uint)10U))));
                                                                var temp602 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp601)))))));
                                                                var temp603 = ((byte)(((byte)((byte)48U)) + ((byte)(temp602))));
                                                                oBuf[oIndex + 2] = (Byte)(temp603);
                                                                var temp604 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                var temp605 = ((uint)((int)((uint)(temp604)) % (int)((uint)((uint)10U))));
                                                                var temp606 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp605)))))));
                                                                var temp607 = ((byte)(((byte)((byte)48U)) + ((byte)(temp606))));
                                                                oBuf[oIndex + 3] = (Byte)(temp607);
                                                                var temp608 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                var temp609 = ((uint)((int)((uint)(temp608)) % (int)((uint)((uint)10U))));
                                                                var temp610 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp609)))))));
                                                                var temp611 = ((byte)(((byte)((byte)48U)) + ((byte)(temp610))));
                                                                oBuf[oIndex + 4] = (Byte)(temp611);
                                                                var temp612 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                var temp613 = ((uint)((int)((uint)(temp612)) % (int)((uint)((uint)10U))));
                                                                var temp614 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp613)))))));
                                                                var temp615 = ((byte)(((byte)((byte)48U)) + ((byte)(temp614))));
                                                                oBuf[oIndex + 5] = (Byte)(temp615);
                                                                var temp616 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                var temp617 = ((uint)((int)((uint)(temp616)) % (int)((uint)((uint)10U))));
                                                                var temp618 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp617)))))));
                                                                var temp619 = ((byte)(((byte)((byte)48U)) + ((byte)(temp618))));
                                                                oBuf[oIndex + 6] = (Byte)(temp619);
                                                                var temp620 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                var temp621 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp620)))))));
                                                                var temp622 = ((byte)(((byte)((byte)48U)) + ((byte)(temp621))));
                                                                oBuf[oIndex + 7] = (Byte)(temp622);
                                                                oBuf[oIndex + 8] = (Byte)((byte)10U);
                                                                oIndex += 9;
                                                                s._4 = ((uint)(temp462));
                                                                s._3 = ((byte)((byte)0U));
                                                                s._2 = ((byte)((byte)0U));
                                                                s._1 = ((byte)((byte)0U));
                                                                s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                goto M16;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (oIndex > 16376)
                                                            {
                                                                output.Write(oBuf, 0, oIndex);
                                                                oIndex = 0;
                                                            }

                                                            oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                            var temp623 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                            var temp624 = ((uint)((int)((uint)(temp623)) % (int)((uint)((uint)10U))));
                                                            var temp625 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp624)))))));
                                                            var temp626 = ((byte)(((byte)((byte)48U)) + ((byte)(temp625))));
                                                            oBuf[oIndex + 1] = (Byte)(temp626);
                                                            var temp627 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                            var temp628 = ((uint)((int)((uint)(temp627)) % (int)((uint)((uint)10U))));
                                                            var temp629 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp628)))))));
                                                            var temp630 = ((byte)(((byte)((byte)48U)) + ((byte)(temp629))));
                                                            oBuf[oIndex + 2] = (Byte)(temp630);
                                                            var temp631 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                            var temp632 = ((uint)((int)((uint)(temp631)) % (int)((uint)((uint)10U))));
                                                            var temp633 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp632)))))));
                                                            var temp634 = ((byte)(((byte)((byte)48U)) + ((byte)(temp633))));
                                                            oBuf[oIndex + 3] = (Byte)(temp634);
                                                            var temp635 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                            var temp636 = ((uint)((int)((uint)(temp635)) % (int)((uint)((uint)10U))));
                                                            var temp637 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp636)))))));
                                                            var temp638 = ((byte)(((byte)((byte)48U)) + ((byte)(temp637))));
                                                            oBuf[oIndex + 4] = (Byte)(temp638);
                                                            var temp639 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                            var temp640 = ((uint)((int)((uint)(temp639)) % (int)((uint)((uint)10U))));
                                                            var temp641 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp640)))))));
                                                            var temp642 = ((byte)(((byte)((byte)48U)) + ((byte)(temp641))));
                                                            oBuf[oIndex + 5] = (Byte)(temp642);
                                                            var temp643 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                            var temp644 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp643)))))));
                                                            var temp645 = ((byte)(((byte)((byte)48U)) + ((byte)(temp644))));
                                                            oBuf[oIndex + 6] = (Byte)(temp645);
                                                            oBuf[oIndex + 7] = (Byte)((byte)10U);
                                                            oIndex += 8;
                                                            s._4 = ((uint)(temp462));
                                                            s._3 = ((byte)((byte)0U));
                                                            s._2 = ((byte)((byte)0U));
                                                            s._1 = ((byte)((byte)0U));
                                                            s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                            goto M16;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (oIndex > 16377)
                                                        {
                                                            output.Write(oBuf, 0, oIndex);
                                                            oIndex = 0;
                                                        }

                                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                        var temp646 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                        var temp647 = ((uint)((int)((uint)(temp646)) % (int)((uint)((uint)10U))));
                                                        var temp648 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp647)))))));
                                                        var temp649 = ((byte)(((byte)((byte)48U)) + ((byte)(temp648))));
                                                        oBuf[oIndex + 1] = (Byte)(temp649);
                                                        var temp650 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                        var temp651 = ((uint)((int)((uint)(temp650)) % (int)((uint)((uint)10U))));
                                                        var temp652 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp651)))))));
                                                        var temp653 = ((byte)(((byte)((byte)48U)) + ((byte)(temp652))));
                                                        oBuf[oIndex + 2] = (Byte)(temp653);
                                                        var temp654 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                        var temp655 = ((uint)((int)((uint)(temp654)) % (int)((uint)((uint)10U))));
                                                        var temp656 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp655)))))));
                                                        var temp657 = ((byte)(((byte)((byte)48U)) + ((byte)(temp656))));
                                                        oBuf[oIndex + 3] = (Byte)(temp657);
                                                        var temp658 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                        var temp659 = ((uint)((int)((uint)(temp658)) % (int)((uint)((uint)10U))));
                                                        var temp660 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp659)))))));
                                                        var temp661 = ((byte)(((byte)((byte)48U)) + ((byte)(temp660))));
                                                        oBuf[oIndex + 4] = (Byte)(temp661);
                                                        var temp662 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                        var temp663 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp662)))))));
                                                        var temp664 = ((byte)(((byte)((byte)48U)) + ((byte)(temp663))));
                                                        oBuf[oIndex + 5] = (Byte)(temp664);
                                                        oBuf[oIndex + 6] = (Byte)((byte)10U);
                                                        oIndex += 7;
                                                        s._4 = ((uint)(temp462));
                                                        s._3 = ((byte)((byte)0U));
                                                        s._2 = ((byte)((byte)0U));
                                                        s._1 = ((byte)((byte)0U));
                                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                        goto M16;
                                                    }
                                                }
                                                else
                                                {
                                                    if (oIndex > 16378)
                                                    {
                                                        output.Write(oBuf, 0, oIndex);
                                                        oIndex = 0;
                                                    }

                                                    oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                    var temp665 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                    var temp666 = ((uint)((int)((uint)(temp665)) % (int)((uint)((uint)10U))));
                                                    var temp667 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp666)))))));
                                                    var temp668 = ((byte)(((byte)((byte)48U)) + ((byte)(temp667))));
                                                    oBuf[oIndex + 1] = (Byte)(temp668);
                                                    var temp669 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                    var temp670 = ((uint)((int)((uint)(temp669)) % (int)((uint)((uint)10U))));
                                                    var temp671 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp670)))))));
                                                    var temp672 = ((byte)(((byte)((byte)48U)) + ((byte)(temp671))));
                                                    oBuf[oIndex + 2] = (Byte)(temp672);
                                                    var temp673 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                    var temp674 = ((uint)((int)((uint)(temp673)) % (int)((uint)((uint)10U))));
                                                    var temp675 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp674)))))));
                                                    var temp676 = ((byte)(((byte)((byte)48U)) + ((byte)(temp675))));
                                                    oBuf[oIndex + 3] = (Byte)(temp676);
                                                    var temp677 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                    var temp678 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp677)))))));
                                                    var temp679 = ((byte)(((byte)((byte)48U)) + ((byte)(temp678))));
                                                    oBuf[oIndex + 4] = (Byte)(temp679);
                                                    oBuf[oIndex + 5] = (Byte)((byte)10U);
                                                    oIndex += 6;
                                                    s._4 = ((uint)(temp462));
                                                    s._3 = ((byte)((byte)0U));
                                                    s._2 = ((byte)((byte)0U));
                                                    s._1 = ((byte)((byte)0U));
                                                    s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                    goto M16;
                                                }
                                            }
                                            else
                                            {
                                                if (oIndex > 16379)
                                                {
                                                    output.Write(oBuf, 0, oIndex);
                                                    oIndex = 0;
                                                }

                                                oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                var temp680 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                var temp681 = ((uint)((int)((uint)(temp680)) % (int)((uint)((uint)10U))));
                                                var temp682 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp681)))))));
                                                var temp683 = ((byte)(((byte)((byte)48U)) + ((byte)(temp682))));
                                                oBuf[oIndex + 1] = (Byte)(temp683);
                                                var temp684 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                var temp685 = ((uint)((int)((uint)(temp684)) % (int)((uint)((uint)10U))));
                                                var temp686 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp685)))))));
                                                var temp687 = ((byte)(((byte)((byte)48U)) + ((byte)(temp686))));
                                                oBuf[oIndex + 2] = (Byte)(temp687);
                                                var temp688 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                var temp689 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp688)))))));
                                                var temp690 = ((byte)(((byte)((byte)48U)) + ((byte)(temp689))));
                                                oBuf[oIndex + 3] = (Byte)(temp690);
                                                oBuf[oIndex + 4] = (Byte)((byte)10U);
                                                oIndex += 5;
                                                s._4 = ((uint)(temp462));
                                                s._3 = ((byte)((byte)0U));
                                                s._2 = ((byte)((byte)0U));
                                                s._1 = ((byte)((byte)0U));
                                                s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                goto M16;
                                            }
                                        }
                                        else
                                        {
                                            if (oIndex > 16380)
                                            {
                                                output.Write(oBuf, 0, oIndex);
                                                oIndex = 0;
                                            }

                                            oBuf[oIndex + 0] = (Byte)((byte)45U);
                                            var temp691 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                            var temp692 = ((uint)((int)((uint)(temp691)) % (int)((uint)((uint)10U))));
                                            var temp693 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp692)))))));
                                            var temp694 = ((byte)(((byte)((byte)48U)) + ((byte)(temp693))));
                                            oBuf[oIndex + 1] = (Byte)(temp694);
                                            var temp695 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                            var temp696 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp695)))))));
                                            var temp697 = ((byte)(((byte)((byte)48U)) + ((byte)(temp696))));
                                            oBuf[oIndex + 2] = (Byte)(temp697);
                                            oBuf[oIndex + 3] = (Byte)((byte)10U);
                                            oIndex += 4;
                                            s._4 = ((uint)(temp462));
                                            s._3 = ((byte)((byte)0U));
                                            s._2 = ((byte)((byte)0U));
                                            s._1 = ((byte)((byte)0U));
                                            s._0 = ((byte)(((byte)((uint)(temp459)))));
                                            goto M16;
                                        }
                                    }
                                    else
                                    {
                                        if (oIndex > 16381)
                                        {
                                            output.Write(oBuf, 0, oIndex);
                                            oIndex = 0;
                                        }

                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                        var temp698 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                        var temp699 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp698)))))));
                                        var temp700 = ((byte)(((byte)((byte)48U)) + ((byte)(temp699))));
                                        oBuf[oIndex + 1] = (Byte)(temp700);
                                        oBuf[oIndex + 2] = (Byte)((byte)10U);
                                        oIndex += 3;
                                        s._4 = ((uint)(temp462));
                                        s._3 = ((byte)((byte)0U));
                                        s._2 = ((byte)((byte)0U));
                                        s._1 = ((byte)((byte)0U));
                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                        goto M16;
                                    }
                                }
                                else
                                {
                                    var temp701 = ((byte)(((uint)(temp465)) >> 31));
                                    var temp702 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 1) | (ulong)((byte)(temp701 & 1L)) << 32) | (ulong)((uint)(temp465));
                                    var temp703 = Fun1(((ulong)(temp702)));
                                    var temp704 = ((uint)(((uint)((uint)4294967295U)) + ((uint)(temp703))));
                                    var temp705 = ((int)((uint)(temp704)) <= (int)((uint)((uint)0U)));
                                    var temp706 = !(temp705);
                                    if (temp706)
                                    {
                                        var temp707 = ((int)((uint)(temp704)) <= (int)((uint)((uint)1U)));
                                        var temp708 = !(temp707);
                                        if (temp708)
                                        {
                                            var temp709 = ((int)((uint)(temp704)) <= (int)((uint)((uint)2U)));
                                            var temp710 = !(temp709);
                                            if (temp710)
                                            {
                                                var temp711 = ((int)((uint)(temp704)) <= (int)((uint)((uint)3U)));
                                                var temp712 = !(temp711);
                                                if (temp712)
                                                {
                                                    var temp713 = ((int)((uint)(temp704)) <= (int)((uint)((uint)4U)));
                                                    var temp714 = !(temp713);
                                                    if (temp714)
                                                    {
                                                        var temp715 = ((int)((uint)(temp704)) <= (int)((uint)((uint)5U)));
                                                        var temp716 = !(temp715);
                                                        if (temp716)
                                                        {
                                                            var temp717 = ((int)((uint)(temp704)) <= (int)((uint)((uint)6U)));
                                                            var temp718 = !(temp717);
                                                            if (temp718)
                                                            {
                                                                var temp719 = ((int)((uint)(temp704)) <= (int)((uint)((uint)7U)));
                                                                var temp720 = !(temp719);
                                                                if (temp720)
                                                                {
                                                                    var temp721 = ((int)((uint)(temp704)) <= (int)((uint)((uint)8U)));
                                                                    var temp722 = !(temp721);
                                                                    if (temp722)
                                                                    {
                                                                        if (oIndex > 16373)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        var temp723 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000000U))));
                                                                        var temp724 = ((uint)((int)((uint)(temp723)) % (int)((uint)((uint)10U))));
                                                                        var temp725 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp724)))))));
                                                                        oBuf[oIndex + 0] = (Byte)(temp725);
                                                                        var temp726 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000000U))));
                                                                        var temp727 = ((uint)((int)((uint)(temp726)) % (int)((uint)((uint)10U))));
                                                                        var temp728 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp727)))))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp728);
                                                                        var temp729 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000000U))));
                                                                        var temp730 = ((uint)((int)((uint)(temp729)) % (int)((uint)((uint)10U))));
                                                                        var temp731 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp730)))))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp731);
                                                                        var temp732 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                        var temp733 = ((uint)((int)((uint)(temp732)) % (int)((uint)((uint)10U))));
                                                                        var temp734 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp733)))))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp734);
                                                                        var temp735 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                        var temp736 = ((uint)((int)((uint)(temp735)) % (int)((uint)((uint)10U))));
                                                                        var temp737 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp736)))))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp737);
                                                                        var temp738 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                        var temp739 = ((uint)((int)((uint)(temp738)) % (int)((uint)((uint)10U))));
                                                                        var temp740 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp739)))))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp740);
                                                                        var temp741 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                        var temp742 = ((uint)((int)((uint)(temp741)) % (int)((uint)((uint)10U))));
                                                                        var temp743 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp742)))))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp743);
                                                                        var temp744 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                        var temp745 = ((uint)((int)((uint)(temp744)) % (int)((uint)((uint)10U))));
                                                                        var temp746 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp745)))))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp746);
                                                                        var temp747 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                        var temp748 = ((uint)((int)((uint)(temp747)) % (int)((uint)((uint)10U))));
                                                                        var temp749 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp748)))))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp749);
                                                                        var temp750 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                        var temp751 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp750)))))));
                                                                        oBuf[oIndex + 9] = (Byte)(temp751);
                                                                        oBuf[oIndex + 10] = (Byte)((byte)10U);
                                                                        oIndex += 11;
                                                                        s._4 = ((uint)(temp462));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                        goto M16;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (oIndex > 16374)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        var temp752 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000000U))));
                                                                        var temp753 = ((uint)((int)((uint)(temp752)) % (int)((uint)((uint)10U))));
                                                                        var temp754 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp753)))))));
                                                                        oBuf[oIndex + 0] = (Byte)(temp754);
                                                                        var temp755 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000000U))));
                                                                        var temp756 = ((uint)((int)((uint)(temp755)) % (int)((uint)((uint)10U))));
                                                                        var temp757 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp756)))))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp757);
                                                                        var temp758 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                        var temp759 = ((uint)((int)((uint)(temp758)) % (int)((uint)((uint)10U))));
                                                                        var temp760 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp759)))))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp760);
                                                                        var temp761 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                        var temp762 = ((uint)((int)((uint)(temp761)) % (int)((uint)((uint)10U))));
                                                                        var temp763 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp762)))))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp763);
                                                                        var temp764 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                        var temp765 = ((uint)((int)((uint)(temp764)) % (int)((uint)((uint)10U))));
                                                                        var temp766 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp765)))))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp766);
                                                                        var temp767 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                        var temp768 = ((uint)((int)((uint)(temp767)) % (int)((uint)((uint)10U))));
                                                                        var temp769 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp768)))))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp769);
                                                                        var temp770 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                        var temp771 = ((uint)((int)((uint)(temp770)) % (int)((uint)((uint)10U))));
                                                                        var temp772 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp771)))))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp772);
                                                                        var temp773 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                        var temp774 = ((uint)((int)((uint)(temp773)) % (int)((uint)((uint)10U))));
                                                                        var temp775 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp774)))))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp775);
                                                                        var temp776 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                        var temp777 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp776)))))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp777);
                                                                        oBuf[oIndex + 9] = (Byte)((byte)10U);
                                                                        oIndex += 10;
                                                                        s._4 = ((uint)(temp462));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                        goto M16;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (oIndex > 16375)
                                                                    {
                                                                        output.Write(oBuf, 0, oIndex);
                                                                        oIndex = 0;
                                                                    }

                                                                    var temp778 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000000U))));
                                                                    var temp779 = ((uint)((int)((uint)(temp778)) % (int)((uint)((uint)10U))));
                                                                    var temp780 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp779)))))));
                                                                    oBuf[oIndex + 0] = (Byte)(temp780);
                                                                    var temp781 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                    var temp782 = ((uint)((int)((uint)(temp781)) % (int)((uint)((uint)10U))));
                                                                    var temp783 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp782)))))));
                                                                    oBuf[oIndex + 1] = (Byte)(temp783);
                                                                    var temp784 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                    var temp785 = ((uint)((int)((uint)(temp784)) % (int)((uint)((uint)10U))));
                                                                    var temp786 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp785)))))));
                                                                    oBuf[oIndex + 2] = (Byte)(temp786);
                                                                    var temp787 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                    var temp788 = ((uint)((int)((uint)(temp787)) % (int)((uint)((uint)10U))));
                                                                    var temp789 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp788)))))));
                                                                    oBuf[oIndex + 3] = (Byte)(temp789);
                                                                    var temp790 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                    var temp791 = ((uint)((int)((uint)(temp790)) % (int)((uint)((uint)10U))));
                                                                    var temp792 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp791)))))));
                                                                    oBuf[oIndex + 4] = (Byte)(temp792);
                                                                    var temp793 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                    var temp794 = ((uint)((int)((uint)(temp793)) % (int)((uint)((uint)10U))));
                                                                    var temp795 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp794)))))));
                                                                    oBuf[oIndex + 5] = (Byte)(temp795);
                                                                    var temp796 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                    var temp797 = ((uint)((int)((uint)(temp796)) % (int)((uint)((uint)10U))));
                                                                    var temp798 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp797)))))));
                                                                    oBuf[oIndex + 6] = (Byte)(temp798);
                                                                    var temp799 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                    var temp800 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp799)))))));
                                                                    oBuf[oIndex + 7] = (Byte)(temp800);
                                                                    oBuf[oIndex + 8] = (Byte)((byte)10U);
                                                                    oIndex += 9;
                                                                    s._4 = ((uint)(temp462));
                                                                    s._3 = ((byte)((byte)0U));
                                                                    s._2 = ((byte)((byte)0U));
                                                                    s._1 = ((byte)((byte)0U));
                                                                    s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                    goto M16;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (oIndex > 16376)
                                                                {
                                                                    output.Write(oBuf, 0, oIndex);
                                                                    oIndex = 0;
                                                                }

                                                                var temp801 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000000U))));
                                                                var temp802 = ((uint)((int)((uint)(temp801)) % (int)((uint)((uint)10U))));
                                                                var temp803 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp802)))))));
                                                                oBuf[oIndex + 0] = (Byte)(temp803);
                                                                var temp804 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                                var temp805 = ((uint)((int)((uint)(temp804)) % (int)((uint)((uint)10U))));
                                                                var temp806 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp805)))))));
                                                                oBuf[oIndex + 1] = (Byte)(temp806);
                                                                var temp807 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                                var temp808 = ((uint)((int)((uint)(temp807)) % (int)((uint)((uint)10U))));
                                                                var temp809 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp808)))))));
                                                                oBuf[oIndex + 2] = (Byte)(temp809);
                                                                var temp810 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                                var temp811 = ((uint)((int)((uint)(temp810)) % (int)((uint)((uint)10U))));
                                                                var temp812 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp811)))))));
                                                                oBuf[oIndex + 3] = (Byte)(temp812);
                                                                var temp813 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                                var temp814 = ((uint)((int)((uint)(temp813)) % (int)((uint)((uint)10U))));
                                                                var temp815 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp814)))))));
                                                                oBuf[oIndex + 4] = (Byte)(temp815);
                                                                var temp816 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                                var temp817 = ((uint)((int)((uint)(temp816)) % (int)((uint)((uint)10U))));
                                                                var temp818 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp817)))))));
                                                                oBuf[oIndex + 5] = (Byte)(temp818);
                                                                var temp819 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                                var temp820 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp819)))))));
                                                                oBuf[oIndex + 6] = (Byte)(temp820);
                                                                oBuf[oIndex + 7] = (Byte)((byte)10U);
                                                                oIndex += 8;
                                                                s._4 = ((uint)(temp462));
                                                                s._3 = ((byte)((byte)0U));
                                                                s._2 = ((byte)((byte)0U));
                                                                s._1 = ((byte)((byte)0U));
                                                                s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                                goto M16;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (oIndex > 16377)
                                                            {
                                                                output.Write(oBuf, 0, oIndex);
                                                                oIndex = 0;
                                                            }

                                                            var temp821 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100000U))));
                                                            var temp822 = ((uint)((int)((uint)(temp821)) % (int)((uint)((uint)10U))));
                                                            var temp823 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp822)))))));
                                                            oBuf[oIndex + 0] = (Byte)(temp823);
                                                            var temp824 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                            var temp825 = ((uint)((int)((uint)(temp824)) % (int)((uint)((uint)10U))));
                                                            var temp826 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp825)))))));
                                                            oBuf[oIndex + 1] = (Byte)(temp826);
                                                            var temp827 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                            var temp828 = ((uint)((int)((uint)(temp827)) % (int)((uint)((uint)10U))));
                                                            var temp829 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp828)))))));
                                                            oBuf[oIndex + 2] = (Byte)(temp829);
                                                            var temp830 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                            var temp831 = ((uint)((int)((uint)(temp830)) % (int)((uint)((uint)10U))));
                                                            var temp832 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp831)))))));
                                                            oBuf[oIndex + 3] = (Byte)(temp832);
                                                            var temp833 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                            var temp834 = ((uint)((int)((uint)(temp833)) % (int)((uint)((uint)10U))));
                                                            var temp835 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp834)))))));
                                                            oBuf[oIndex + 4] = (Byte)(temp835);
                                                            var temp836 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                            var temp837 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp836)))))));
                                                            oBuf[oIndex + 5] = (Byte)(temp837);
                                                            oBuf[oIndex + 6] = (Byte)((byte)10U);
                                                            oIndex += 7;
                                                            s._4 = ((uint)(temp462));
                                                            s._3 = ((byte)((byte)0U));
                                                            s._2 = ((byte)((byte)0U));
                                                            s._1 = ((byte)((byte)0U));
                                                            s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                            goto M16;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (oIndex > 16378)
                                                        {
                                                            output.Write(oBuf, 0, oIndex);
                                                            oIndex = 0;
                                                        }

                                                        var temp838 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10000U))));
                                                        var temp839 = ((uint)((int)((uint)(temp838)) % (int)((uint)((uint)10U))));
                                                        var temp840 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp839)))))));
                                                        oBuf[oIndex + 0] = (Byte)(temp840);
                                                        var temp841 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                        var temp842 = ((uint)((int)((uint)(temp841)) % (int)((uint)((uint)10U))));
                                                        var temp843 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp842)))))));
                                                        oBuf[oIndex + 1] = (Byte)(temp843);
                                                        var temp844 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                        var temp845 = ((uint)((int)((uint)(temp844)) % (int)((uint)((uint)10U))));
                                                        var temp846 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp845)))))));
                                                        oBuf[oIndex + 2] = (Byte)(temp846);
                                                        var temp847 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                        var temp848 = ((uint)((int)((uint)(temp847)) % (int)((uint)((uint)10U))));
                                                        var temp849 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp848)))))));
                                                        oBuf[oIndex + 3] = (Byte)(temp849);
                                                        var temp850 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                        var temp851 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp850)))))));
                                                        oBuf[oIndex + 4] = (Byte)(temp851);
                                                        oBuf[oIndex + 5] = (Byte)((byte)10U);
                                                        oIndex += 6;
                                                        s._4 = ((uint)(temp462));
                                                        s._3 = ((byte)((byte)0U));
                                                        s._2 = ((byte)((byte)0U));
                                                        s._1 = ((byte)((byte)0U));
                                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                        goto M16;
                                                    }
                                                }
                                                else
                                                {
                                                    if (oIndex > 16379)
                                                    {
                                                        output.Write(oBuf, 0, oIndex);
                                                        oIndex = 0;
                                                    }

                                                    var temp852 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)1000U))));
                                                    var temp853 = ((uint)((int)((uint)(temp852)) % (int)((uint)((uint)10U))));
                                                    var temp854 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp853)))))));
                                                    oBuf[oIndex + 0] = (Byte)(temp854);
                                                    var temp855 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                    var temp856 = ((uint)((int)((uint)(temp855)) % (int)((uint)((uint)10U))));
                                                    var temp857 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp856)))))));
                                                    oBuf[oIndex + 1] = (Byte)(temp857);
                                                    var temp858 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                    var temp859 = ((uint)((int)((uint)(temp858)) % (int)((uint)((uint)10U))));
                                                    var temp860 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp859)))))));
                                                    oBuf[oIndex + 2] = (Byte)(temp860);
                                                    var temp861 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                    var temp862 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp861)))))));
                                                    oBuf[oIndex + 3] = (Byte)(temp862);
                                                    oBuf[oIndex + 4] = (Byte)((byte)10U);
                                                    oIndex += 5;
                                                    s._4 = ((uint)(temp462));
                                                    s._3 = ((byte)((byte)0U));
                                                    s._2 = ((byte)((byte)0U));
                                                    s._1 = ((byte)((byte)0U));
                                                    s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                    goto M16;
                                                }
                                            }
                                            else
                                            {
                                                if (oIndex > 16380)
                                                {
                                                    output.Write(oBuf, 0, oIndex);
                                                    oIndex = 0;
                                                }

                                                var temp863 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)100U))));
                                                var temp864 = ((uint)((int)((uint)(temp863)) % (int)((uint)((uint)10U))));
                                                var temp865 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp864)))))));
                                                oBuf[oIndex + 0] = (Byte)(temp865);
                                                var temp866 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                                var temp867 = ((uint)((int)((uint)(temp866)) % (int)((uint)((uint)10U))));
                                                var temp868 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp867)))))));
                                                oBuf[oIndex + 1] = (Byte)(temp868);
                                                var temp869 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                                var temp870 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp869)))))));
                                                oBuf[oIndex + 2] = (Byte)(temp870);
                                                oBuf[oIndex + 3] = (Byte)((byte)10U);
                                                oIndex += 4;
                                                s._4 = ((uint)(temp462));
                                                s._3 = ((byte)((byte)0U));
                                                s._2 = ((byte)((byte)0U));
                                                s._1 = ((byte)((byte)0U));
                                                s._0 = ((byte)(((byte)((uint)(temp459)))));
                                                goto M16;
                                            }
                                        }
                                        else
                                        {
                                            if (oIndex > 16381)
                                            {
                                                output.Write(oBuf, 0, oIndex);
                                                oIndex = 0;
                                            }

                                            var temp871 = ((uint)((int)((uint)(temp465)) / (int)((uint)((uint)10U))));
                                            var temp872 = ((uint)((int)((uint)(temp871)) % (int)((uint)((uint)10U))));
                                            var temp873 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp872)))))));
                                            oBuf[oIndex + 0] = (Byte)(temp873);
                                            var temp874 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                            var temp875 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp874)))))));
                                            oBuf[oIndex + 1] = (Byte)(temp875);
                                            oBuf[oIndex + 2] = (Byte)((byte)10U);
                                            oIndex += 3;
                                            s._4 = ((uint)(temp462));
                                            s._3 = ((byte)((byte)0U));
                                            s._2 = ((byte)((byte)0U));
                                            s._1 = ((byte)((byte)0U));
                                            s._0 = ((byte)(((byte)((uint)(temp459)))));
                                            goto M16;
                                        }
                                    }
                                    else
                                    {
                                        if (oIndex > 16382)
                                        {
                                            output.Write(oBuf, 0, oIndex);
                                            oIndex = 0;
                                        }

                                        var temp876 = ((uint)((int)((uint)(temp465)) % (int)((uint)((uint)10U))));
                                        var temp877 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp876)))))));
                                        oBuf[oIndex + 0] = (Byte)(temp877);
                                        oBuf[oIndex + 1] = (Byte)((byte)10U);
                                        oIndex += 2;
                                        s._4 = ((uint)(temp462));
                                        s._3 = ((byte)((byte)0U));
                                        s._2 = ((byte)((byte)0U));
                                        s._1 = ((byte)((byte)0U));
                                        s._0 = ((byte)(((byte)((uint)(temp459)))));
                                        goto M16;
                                    }
                                }
                            }
                        }
                    }
                }

                M15:
                {
                    if (++iIndex >= input.Length)
                        goto F15;
                    i = input[iIndex];
                    {
                        var temp878 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp878)
                        {
                            goto M25;
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
                        var temp879 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp879)
                        {
                            goto M17;
                        }
                        else
                        {
                            var temp880 = ((byte)((byte)(((byte)((byte)((s)._0))) & 3L)) << 6);
                            var temp881 = Fun0(((byte)(i)));
                            var temp882 = ((byte)(((byte)(temp880)) | ((byte)(((byte)((uint)(temp881)))))));
                            s._1 = ((byte)(temp882));
                            s._0 = ((byte)((byte)0U));
                            goto M18;
                        }
                    }
                }

                M17:
                {
                    if (++iIndex >= input.Length)
                        goto F17;
                    i = input[iIndex];
                    throw new Exception();
                }

                M18:
                {
                    if (++iIndex >= input.Length)
                        goto F18;
                    i = input[iIndex];
                    {
                        var temp883 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp883)
                            throw new Exception();
                        else
                        {
                            var temp884 = Fun0(((byte)(i)));
                            s._0 = ((byte)(((byte)((uint)(temp884)))));
                            goto M19;
                        }
                    }
                }

                M19:
                {
                    if (++iIndex >= input.Length)
                        goto F19;
                    i = input[iIndex];
                    {
                        var temp885 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp885)
                            throw new Exception();
                        else
                        {
                            var temp886 = ((byte)((byte)(((byte)((byte)((s)._0))) & 63L)) << 2);
                            var temp887 = Fun0(((byte)(i)));
                            var temp888 = ((uint)(((int)((uint)(temp887))) >> (int)((uint)((uint)4U))));
                            var temp889 = ((byte)(((byte)(temp886)) | ((byte)(((byte)((uint)(temp888)))))));
                            s._2 = ((byte)(temp889));
                            s._0 = ((byte)(((byte)((uint)(temp887)))));
                            goto M20;
                        }
                    }
                }

                M20:
                {
                    if (++iIndex >= input.Length)
                        goto F20;
                    i = input[iIndex];
                    {
                        var temp890 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp890)
                        {
                            goto M21;
                        }
                        else
                        {
                            var temp891 = ((byte)((byte)(((byte)((byte)((s)._0))) & 15L)) << 4);
                            var temp892 = Fun0(((byte)(i)));
                            var temp893 = ((uint)(((int)((uint)(temp892))) >> (int)((uint)((uint)2U))));
                            var temp894 = ((byte)(((byte)(temp891)) | ((byte)(((byte)((uint)(temp893)))))));
                            s._3 = ((byte)(temp894));
                            s._0 = ((byte)(((byte)((uint)(temp892)))));
                            goto M22;
                        }
                    }
                }

                M21:
                {
                    if (++iIndex >= input.Length)
                        goto F21;
                    i = input[iIndex];
                    {
                        var temp895 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp895)
                        {
                            goto M24;
                        }
                        else
                            throw new Exception();
                    }
                }

                M22:
                {
                    if (++iIndex >= input.Length)
                        goto F22;
                    i = input[iIndex];
                    {
                        var temp896 = (((byte)(i)) == ((byte)((byte)61U)));
                        if (temp896)
                        {
                            goto M23;
                        }
                        else
                        {
                            var temp897 = ((byte)((byte)(((byte)((byte)((s)._0))) & 3L)) << 6);
                            var temp898 = Fun0(((byte)(i)));
                            var temp899 = ((byte)(((byte)(temp897)) | ((byte)(((byte)((uint)(temp898)))))));
                            var temp900 = ((((uint)((byte)((s)._1)) << 8) | (uint)((byte)((s)._2)) << 8) | (uint)((byte)((s)._3)) << 8) | (uint)((byte)(temp899));
                            var temp901 = (((uint)(temp900)) == ((uint)((s)._4)));
                            if (temp901)
                            {
                                if (oIndex > 16383)
                                {
                                    output.Write(oBuf, 0, oIndex);
                                    oIndex = 0;
                                }

                                oBuf[oIndex + 0] = (Byte)((byte)48U);
                                oIndex += 1;
                                s._4 = ((uint)(temp900));
                                s._3 = ((byte)((byte)0U));
                                s._2 = ((byte)((byte)0U));
                                s._1 = ((byte)((byte)0U));
                                s._0 = ((byte)((byte)0U));
                                goto M0;
                            }
                            else
                            {
                                var temp902 = ((uint)(((uint)((uint)4294967295U)) * ((uint)((s)._4))));
                                var temp903 = ((uint)(((uint)(temp900)) + ((uint)(temp902))));
                                var temp904 = ((int)((uint)((uint)0U)) <= (int)((uint)(temp903)));
                                var temp905 = !(temp904);
                                if (temp905)
                                {
                                    var temp906 = ((byte)(((uint)(temp903)) >> 31));
                                    var temp907 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 1) | (ulong)((byte)(temp906 & 1L)) << 32) | (ulong)((uint)(temp903));
                                    var temp908 = ((ulong)(((ulong)((ulong)18446744073709551615UL)) * ((ulong)(temp907))));
                                    var temp909 = Fun1(((ulong)(temp908)));
                                    var temp910 = ((uint)(((uint)((uint)4294967295U)) + ((uint)(temp909))));
                                    var temp911 = ((int)((uint)(temp910)) <= (int)((uint)((uint)0U)));
                                    var temp912 = !(temp911);
                                    if (temp912)
                                    {
                                        var temp913 = ((int)((uint)(temp910)) <= (int)((uint)((uint)1U)));
                                        var temp914 = !(temp913);
                                        if (temp914)
                                        {
                                            var temp915 = ((int)((uint)(temp910)) <= (int)((uint)((uint)2U)));
                                            var temp916 = !(temp915);
                                            if (temp916)
                                            {
                                                var temp917 = ((int)((uint)(temp910)) <= (int)((uint)((uint)3U)));
                                                var temp918 = !(temp917);
                                                if (temp918)
                                                {
                                                    var temp919 = ((int)((uint)(temp910)) <= (int)((uint)((uint)4U)));
                                                    var temp920 = !(temp919);
                                                    if (temp920)
                                                    {
                                                        var temp921 = ((int)((uint)(temp910)) <= (int)((uint)((uint)5U)));
                                                        var temp922 = !(temp921);
                                                        if (temp922)
                                                        {
                                                            var temp923 = ((int)((uint)(temp910)) <= (int)((uint)((uint)6U)));
                                                            var temp924 = !(temp923);
                                                            if (temp924)
                                                            {
                                                                var temp925 = ((int)((uint)(temp910)) <= (int)((uint)((uint)7U)));
                                                                var temp926 = !(temp925);
                                                                if (temp926)
                                                                {
                                                                    var temp927 = ((int)((uint)(temp910)) <= (int)((uint)((uint)8U)));
                                                                    var temp928 = !(temp927);
                                                                    if (temp928)
                                                                    {
                                                                        if (oIndex > 16372)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                        var temp929 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000000U))));
                                                                        var temp930 = ((uint)((int)((uint)(temp929)) % (int)((uint)((uint)10U))));
                                                                        var temp931 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp930)))))));
                                                                        var temp932 = ((byte)(((byte)((byte)48U)) + ((byte)(temp931))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp932);
                                                                        var temp933 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000000U))));
                                                                        var temp934 = ((uint)((int)((uint)(temp933)) % (int)((uint)((uint)10U))));
                                                                        var temp935 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp934)))))));
                                                                        var temp936 = ((byte)(((byte)((byte)48U)) + ((byte)(temp935))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp936);
                                                                        var temp937 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000000U))));
                                                                        var temp938 = ((uint)((int)((uint)(temp937)) % (int)((uint)((uint)10U))));
                                                                        var temp939 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp938)))))));
                                                                        var temp940 = ((byte)(((byte)((byte)48U)) + ((byte)(temp939))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp940);
                                                                        var temp941 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                        var temp942 = ((uint)((int)((uint)(temp941)) % (int)((uint)((uint)10U))));
                                                                        var temp943 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp942)))))));
                                                                        var temp944 = ((byte)(((byte)((byte)48U)) + ((byte)(temp943))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp944);
                                                                        var temp945 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                        var temp946 = ((uint)((int)((uint)(temp945)) % (int)((uint)((uint)10U))));
                                                                        var temp947 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp946)))))));
                                                                        var temp948 = ((byte)(((byte)((byte)48U)) + ((byte)(temp947))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp948);
                                                                        var temp949 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                        var temp950 = ((uint)((int)((uint)(temp949)) % (int)((uint)((uint)10U))));
                                                                        var temp951 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp950)))))));
                                                                        var temp952 = ((byte)(((byte)((byte)48U)) + ((byte)(temp951))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp952);
                                                                        var temp953 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                        var temp954 = ((uint)((int)((uint)(temp953)) % (int)((uint)((uint)10U))));
                                                                        var temp955 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp954)))))));
                                                                        var temp956 = ((byte)(((byte)((byte)48U)) + ((byte)(temp955))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp956);
                                                                        var temp957 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                        var temp958 = ((uint)((int)((uint)(temp957)) % (int)((uint)((uint)10U))));
                                                                        var temp959 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp958)))))));
                                                                        var temp960 = ((byte)(((byte)((byte)48U)) + ((byte)(temp959))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp960);
                                                                        var temp961 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                        var temp962 = ((uint)((int)((uint)(temp961)) % (int)((uint)((uint)10U))));
                                                                        var temp963 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp962)))))));
                                                                        var temp964 = ((byte)(((byte)((byte)48U)) + ((byte)(temp963))));
                                                                        oBuf[oIndex + 9] = (Byte)(temp964);
                                                                        var temp965 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                        var temp966 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp965)))))));
                                                                        var temp967 = ((byte)(((byte)((byte)48U)) + ((byte)(temp966))));
                                                                        oBuf[oIndex + 10] = (Byte)(temp967);
                                                                        oBuf[oIndex + 11] = (Byte)((byte)10U);
                                                                        oIndex += 12;
                                                                        s._4 = ((uint)(temp900));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)((byte)0U));
                                                                        goto M0;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (oIndex > 16373)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                        var temp968 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000000U))));
                                                                        var temp969 = ((uint)((int)((uint)(temp968)) % (int)((uint)((uint)10U))));
                                                                        var temp970 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp969)))))));
                                                                        var temp971 = ((byte)(((byte)((byte)48U)) + ((byte)(temp970))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp971);
                                                                        var temp972 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000000U))));
                                                                        var temp973 = ((uint)((int)((uint)(temp972)) % (int)((uint)((uint)10U))));
                                                                        var temp974 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp973)))))));
                                                                        var temp975 = ((byte)(((byte)((byte)48U)) + ((byte)(temp974))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp975);
                                                                        var temp976 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                        var temp977 = ((uint)((int)((uint)(temp976)) % (int)((uint)((uint)10U))));
                                                                        var temp978 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp977)))))));
                                                                        var temp979 = ((byte)(((byte)((byte)48U)) + ((byte)(temp978))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp979);
                                                                        var temp980 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                        var temp981 = ((uint)((int)((uint)(temp980)) % (int)((uint)((uint)10U))));
                                                                        var temp982 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp981)))))));
                                                                        var temp983 = ((byte)(((byte)((byte)48U)) + ((byte)(temp982))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp983);
                                                                        var temp984 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                        var temp985 = ((uint)((int)((uint)(temp984)) % (int)((uint)((uint)10U))));
                                                                        var temp986 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp985)))))));
                                                                        var temp987 = ((byte)(((byte)((byte)48U)) + ((byte)(temp986))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp987);
                                                                        var temp988 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                        var temp989 = ((uint)((int)((uint)(temp988)) % (int)((uint)((uint)10U))));
                                                                        var temp990 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp989)))))));
                                                                        var temp991 = ((byte)(((byte)((byte)48U)) + ((byte)(temp990))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp991);
                                                                        var temp992 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                        var temp993 = ((uint)((int)((uint)(temp992)) % (int)((uint)((uint)10U))));
                                                                        var temp994 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp993)))))));
                                                                        var temp995 = ((byte)(((byte)((byte)48U)) + ((byte)(temp994))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp995);
                                                                        var temp996 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                        var temp997 = ((uint)((int)((uint)(temp996)) % (int)((uint)((uint)10U))));
                                                                        var temp998 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp997)))))));
                                                                        var temp999 = ((byte)(((byte)((byte)48U)) + ((byte)(temp998))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp999);
                                                                        var temp1000 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                        var temp1001 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1000)))))));
                                                                        var temp1002 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1001))));
                                                                        oBuf[oIndex + 9] = (Byte)(temp1002);
                                                                        oBuf[oIndex + 10] = (Byte)((byte)10U);
                                                                        oIndex += 11;
                                                                        s._4 = ((uint)(temp900));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)((byte)0U));
                                                                        goto M0;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (oIndex > 16374)
                                                                    {
                                                                        output.Write(oBuf, 0, oIndex);
                                                                        oIndex = 0;
                                                                    }

                                                                    oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                    var temp1003 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000000U))));
                                                                    var temp1004 = ((uint)((int)((uint)(temp1003)) % (int)((uint)((uint)10U))));
                                                                    var temp1005 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1004)))))));
                                                                    var temp1006 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1005))));
                                                                    oBuf[oIndex + 1] = (Byte)(temp1006);
                                                                    var temp1007 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                    var temp1008 = ((uint)((int)((uint)(temp1007)) % (int)((uint)((uint)10U))));
                                                                    var temp1009 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1008)))))));
                                                                    var temp1010 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1009))));
                                                                    oBuf[oIndex + 2] = (Byte)(temp1010);
                                                                    var temp1011 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                    var temp1012 = ((uint)((int)((uint)(temp1011)) % (int)((uint)((uint)10U))));
                                                                    var temp1013 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1012)))))));
                                                                    var temp1014 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1013))));
                                                                    oBuf[oIndex + 3] = (Byte)(temp1014);
                                                                    var temp1015 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                    var temp1016 = ((uint)((int)((uint)(temp1015)) % (int)((uint)((uint)10U))));
                                                                    var temp1017 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1016)))))));
                                                                    var temp1018 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1017))));
                                                                    oBuf[oIndex + 4] = (Byte)(temp1018);
                                                                    var temp1019 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                    var temp1020 = ((uint)((int)((uint)(temp1019)) % (int)((uint)((uint)10U))));
                                                                    var temp1021 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1020)))))));
                                                                    var temp1022 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1021))));
                                                                    oBuf[oIndex + 5] = (Byte)(temp1022);
                                                                    var temp1023 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                    var temp1024 = ((uint)((int)((uint)(temp1023)) % (int)((uint)((uint)10U))));
                                                                    var temp1025 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1024)))))));
                                                                    var temp1026 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1025))));
                                                                    oBuf[oIndex + 6] = (Byte)(temp1026);
                                                                    var temp1027 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                    var temp1028 = ((uint)((int)((uint)(temp1027)) % (int)((uint)((uint)10U))));
                                                                    var temp1029 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1028)))))));
                                                                    var temp1030 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1029))));
                                                                    oBuf[oIndex + 7] = (Byte)(temp1030);
                                                                    var temp1031 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                    var temp1032 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1031)))))));
                                                                    var temp1033 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1032))));
                                                                    oBuf[oIndex + 8] = (Byte)(temp1033);
                                                                    oBuf[oIndex + 9] = (Byte)((byte)10U);
                                                                    oIndex += 10;
                                                                    s._4 = ((uint)(temp900));
                                                                    s._3 = ((byte)((byte)0U));
                                                                    s._2 = ((byte)((byte)0U));
                                                                    s._1 = ((byte)((byte)0U));
                                                                    s._0 = ((byte)((byte)0U));
                                                                    goto M0;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (oIndex > 16375)
                                                                {
                                                                    output.Write(oBuf, 0, oIndex);
                                                                    oIndex = 0;
                                                                }

                                                                oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                                var temp1034 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                var temp1035 = ((uint)((int)((uint)(temp1034)) % (int)((uint)((uint)10U))));
                                                                var temp1036 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1035)))))));
                                                                var temp1037 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1036))));
                                                                oBuf[oIndex + 1] = (Byte)(temp1037);
                                                                var temp1038 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                var temp1039 = ((uint)((int)((uint)(temp1038)) % (int)((uint)((uint)10U))));
                                                                var temp1040 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1039)))))));
                                                                var temp1041 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1040))));
                                                                oBuf[oIndex + 2] = (Byte)(temp1041);
                                                                var temp1042 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                var temp1043 = ((uint)((int)((uint)(temp1042)) % (int)((uint)((uint)10U))));
                                                                var temp1044 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1043)))))));
                                                                var temp1045 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1044))));
                                                                oBuf[oIndex + 3] = (Byte)(temp1045);
                                                                var temp1046 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                var temp1047 = ((uint)((int)((uint)(temp1046)) % (int)((uint)((uint)10U))));
                                                                var temp1048 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1047)))))));
                                                                var temp1049 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1048))));
                                                                oBuf[oIndex + 4] = (Byte)(temp1049);
                                                                var temp1050 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                var temp1051 = ((uint)((int)((uint)(temp1050)) % (int)((uint)((uint)10U))));
                                                                var temp1052 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1051)))))));
                                                                var temp1053 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1052))));
                                                                oBuf[oIndex + 5] = (Byte)(temp1053);
                                                                var temp1054 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                var temp1055 = ((uint)((int)((uint)(temp1054)) % (int)((uint)((uint)10U))));
                                                                var temp1056 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1055)))))));
                                                                var temp1057 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1056))));
                                                                oBuf[oIndex + 6] = (Byte)(temp1057);
                                                                var temp1058 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                var temp1059 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1058)))))));
                                                                var temp1060 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1059))));
                                                                oBuf[oIndex + 7] = (Byte)(temp1060);
                                                                oBuf[oIndex + 8] = (Byte)((byte)10U);
                                                                oIndex += 9;
                                                                s._4 = ((uint)(temp900));
                                                                s._3 = ((byte)((byte)0U));
                                                                s._2 = ((byte)((byte)0U));
                                                                s._1 = ((byte)((byte)0U));
                                                                s._0 = ((byte)((byte)0U));
                                                                goto M0;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (oIndex > 16376)
                                                            {
                                                                output.Write(oBuf, 0, oIndex);
                                                                oIndex = 0;
                                                            }

                                                            oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                            var temp1061 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                            var temp1062 = ((uint)((int)((uint)(temp1061)) % (int)((uint)((uint)10U))));
                                                            var temp1063 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1062)))))));
                                                            var temp1064 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1063))));
                                                            oBuf[oIndex + 1] = (Byte)(temp1064);
                                                            var temp1065 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                            var temp1066 = ((uint)((int)((uint)(temp1065)) % (int)((uint)((uint)10U))));
                                                            var temp1067 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1066)))))));
                                                            var temp1068 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1067))));
                                                            oBuf[oIndex + 2] = (Byte)(temp1068);
                                                            var temp1069 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                            var temp1070 = ((uint)((int)((uint)(temp1069)) % (int)((uint)((uint)10U))));
                                                            var temp1071 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1070)))))));
                                                            var temp1072 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1071))));
                                                            oBuf[oIndex + 3] = (Byte)(temp1072);
                                                            var temp1073 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                            var temp1074 = ((uint)((int)((uint)(temp1073)) % (int)((uint)((uint)10U))));
                                                            var temp1075 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1074)))))));
                                                            var temp1076 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1075))));
                                                            oBuf[oIndex + 4] = (Byte)(temp1076);
                                                            var temp1077 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                            var temp1078 = ((uint)((int)((uint)(temp1077)) % (int)((uint)((uint)10U))));
                                                            var temp1079 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1078)))))));
                                                            var temp1080 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1079))));
                                                            oBuf[oIndex + 5] = (Byte)(temp1080);
                                                            var temp1081 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                            var temp1082 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1081)))))));
                                                            var temp1083 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1082))));
                                                            oBuf[oIndex + 6] = (Byte)(temp1083);
                                                            oBuf[oIndex + 7] = (Byte)((byte)10U);
                                                            oIndex += 8;
                                                            s._4 = ((uint)(temp900));
                                                            s._3 = ((byte)((byte)0U));
                                                            s._2 = ((byte)((byte)0U));
                                                            s._1 = ((byte)((byte)0U));
                                                            s._0 = ((byte)((byte)0U));
                                                            goto M0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (oIndex > 16377)
                                                        {
                                                            output.Write(oBuf, 0, oIndex);
                                                            oIndex = 0;
                                                        }

                                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                        var temp1084 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                        var temp1085 = ((uint)((int)((uint)(temp1084)) % (int)((uint)((uint)10U))));
                                                        var temp1086 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1085)))))));
                                                        var temp1087 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1086))));
                                                        oBuf[oIndex + 1] = (Byte)(temp1087);
                                                        var temp1088 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                        var temp1089 = ((uint)((int)((uint)(temp1088)) % (int)((uint)((uint)10U))));
                                                        var temp1090 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1089)))))));
                                                        var temp1091 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1090))));
                                                        oBuf[oIndex + 2] = (Byte)(temp1091);
                                                        var temp1092 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                        var temp1093 = ((uint)((int)((uint)(temp1092)) % (int)((uint)((uint)10U))));
                                                        var temp1094 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1093)))))));
                                                        var temp1095 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1094))));
                                                        oBuf[oIndex + 3] = (Byte)(temp1095);
                                                        var temp1096 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                        var temp1097 = ((uint)((int)((uint)(temp1096)) % (int)((uint)((uint)10U))));
                                                        var temp1098 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1097)))))));
                                                        var temp1099 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1098))));
                                                        oBuf[oIndex + 4] = (Byte)(temp1099);
                                                        var temp1100 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                        var temp1101 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1100)))))));
                                                        var temp1102 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1101))));
                                                        oBuf[oIndex + 5] = (Byte)(temp1102);
                                                        oBuf[oIndex + 6] = (Byte)((byte)10U);
                                                        oIndex += 7;
                                                        s._4 = ((uint)(temp900));
                                                        s._3 = ((byte)((byte)0U));
                                                        s._2 = ((byte)((byte)0U));
                                                        s._1 = ((byte)((byte)0U));
                                                        s._0 = ((byte)((byte)0U));
                                                        goto M0;
                                                    }
                                                }
                                                else
                                                {
                                                    if (oIndex > 16378)
                                                    {
                                                        output.Write(oBuf, 0, oIndex);
                                                        oIndex = 0;
                                                    }

                                                    oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                    var temp1103 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                    var temp1104 = ((uint)((int)((uint)(temp1103)) % (int)((uint)((uint)10U))));
                                                    var temp1105 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1104)))))));
                                                    var temp1106 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1105))));
                                                    oBuf[oIndex + 1] = (Byte)(temp1106);
                                                    var temp1107 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                    var temp1108 = ((uint)((int)((uint)(temp1107)) % (int)((uint)((uint)10U))));
                                                    var temp1109 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1108)))))));
                                                    var temp1110 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1109))));
                                                    oBuf[oIndex + 2] = (Byte)(temp1110);
                                                    var temp1111 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                    var temp1112 = ((uint)((int)((uint)(temp1111)) % (int)((uint)((uint)10U))));
                                                    var temp1113 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1112)))))));
                                                    var temp1114 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1113))));
                                                    oBuf[oIndex + 3] = (Byte)(temp1114);
                                                    var temp1115 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                    var temp1116 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1115)))))));
                                                    var temp1117 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1116))));
                                                    oBuf[oIndex + 4] = (Byte)(temp1117);
                                                    oBuf[oIndex + 5] = (Byte)((byte)10U);
                                                    oIndex += 6;
                                                    s._4 = ((uint)(temp900));
                                                    s._3 = ((byte)((byte)0U));
                                                    s._2 = ((byte)((byte)0U));
                                                    s._1 = ((byte)((byte)0U));
                                                    s._0 = ((byte)((byte)0U));
                                                    goto M0;
                                                }
                                            }
                                            else
                                            {
                                                if (oIndex > 16379)
                                                {
                                                    output.Write(oBuf, 0, oIndex);
                                                    oIndex = 0;
                                                }

                                                oBuf[oIndex + 0] = (Byte)((byte)45U);
                                                var temp1118 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                var temp1119 = ((uint)((int)((uint)(temp1118)) % (int)((uint)((uint)10U))));
                                                var temp1120 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1119)))))));
                                                var temp1121 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1120))));
                                                oBuf[oIndex + 1] = (Byte)(temp1121);
                                                var temp1122 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                var temp1123 = ((uint)((int)((uint)(temp1122)) % (int)((uint)((uint)10U))));
                                                var temp1124 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1123)))))));
                                                var temp1125 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1124))));
                                                oBuf[oIndex + 2] = (Byte)(temp1125);
                                                var temp1126 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                var temp1127 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1126)))))));
                                                var temp1128 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1127))));
                                                oBuf[oIndex + 3] = (Byte)(temp1128);
                                                oBuf[oIndex + 4] = (Byte)((byte)10U);
                                                oIndex += 5;
                                                s._4 = ((uint)(temp900));
                                                s._3 = ((byte)((byte)0U));
                                                s._2 = ((byte)((byte)0U));
                                                s._1 = ((byte)((byte)0U));
                                                s._0 = ((byte)((byte)0U));
                                                goto M0;
                                            }
                                        }
                                        else
                                        {
                                            if (oIndex > 16380)
                                            {
                                                output.Write(oBuf, 0, oIndex);
                                                oIndex = 0;
                                            }

                                            oBuf[oIndex + 0] = (Byte)((byte)45U);
                                            var temp1129 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                            var temp1130 = ((uint)((int)((uint)(temp1129)) % (int)((uint)((uint)10U))));
                                            var temp1131 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1130)))))));
                                            var temp1132 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1131))));
                                            oBuf[oIndex + 1] = (Byte)(temp1132);
                                            var temp1133 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                            var temp1134 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1133)))))));
                                            var temp1135 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1134))));
                                            oBuf[oIndex + 2] = (Byte)(temp1135);
                                            oBuf[oIndex + 3] = (Byte)((byte)10U);
                                            oIndex += 4;
                                            s._4 = ((uint)(temp900));
                                            s._3 = ((byte)((byte)0U));
                                            s._2 = ((byte)((byte)0U));
                                            s._1 = ((byte)((byte)0U));
                                            s._0 = ((byte)((byte)0U));
                                            goto M0;
                                        }
                                    }
                                    else
                                    {
                                        if (oIndex > 16381)
                                        {
                                            output.Write(oBuf, 0, oIndex);
                                            oIndex = 0;
                                        }

                                        oBuf[oIndex + 0] = (Byte)((byte)45U);
                                        var temp1136 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                        var temp1137 = ((byte)(((byte)((byte)255U)) * ((byte)(((byte)((uint)(temp1136)))))));
                                        var temp1138 = ((byte)(((byte)((byte)48U)) + ((byte)(temp1137))));
                                        oBuf[oIndex + 1] = (Byte)(temp1138);
                                        oBuf[oIndex + 2] = (Byte)((byte)10U);
                                        oIndex += 3;
                                        s._4 = ((uint)(temp900));
                                        s._3 = ((byte)((byte)0U));
                                        s._2 = ((byte)((byte)0U));
                                        s._1 = ((byte)((byte)0U));
                                        s._0 = ((byte)((byte)0U));
                                        goto M0;
                                    }
                                }
                                else
                                {
                                    var temp1139 = ((byte)(((uint)(temp903)) >> 31));
                                    var temp1140 = (((((((((((((((((((((((((((((((((ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 1) | (ulong)((byte)(temp1139 & 1L)) << 32) | (ulong)((uint)(temp903));
                                    var temp1141 = Fun1(((ulong)(temp1140)));
                                    var temp1142 = ((uint)(((uint)((uint)4294967295U)) + ((uint)(temp1141))));
                                    var temp1143 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)0U)));
                                    var temp1144 = !(temp1143);
                                    if (temp1144)
                                    {
                                        var temp1145 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)1U)));
                                        var temp1146 = !(temp1145);
                                        if (temp1146)
                                        {
                                            var temp1147 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)2U)));
                                            var temp1148 = !(temp1147);
                                            if (temp1148)
                                            {
                                                var temp1149 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)3U)));
                                                var temp1150 = !(temp1149);
                                                if (temp1150)
                                                {
                                                    var temp1151 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)4U)));
                                                    var temp1152 = !(temp1151);
                                                    if (temp1152)
                                                    {
                                                        var temp1153 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)5U)));
                                                        var temp1154 = !(temp1153);
                                                        if (temp1154)
                                                        {
                                                            var temp1155 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)6U)));
                                                            var temp1156 = !(temp1155);
                                                            if (temp1156)
                                                            {
                                                                var temp1157 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)7U)));
                                                                var temp1158 = !(temp1157);
                                                                if (temp1158)
                                                                {
                                                                    var temp1159 = ((int)((uint)(temp1142)) <= (int)((uint)((uint)8U)));
                                                                    var temp1160 = !(temp1159);
                                                                    if (temp1160)
                                                                    {
                                                                        if (oIndex > 16373)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        var temp1161 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000000U))));
                                                                        var temp1162 = ((uint)((int)((uint)(temp1161)) % (int)((uint)((uint)10U))));
                                                                        var temp1163 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1162)))))));
                                                                        oBuf[oIndex + 0] = (Byte)(temp1163);
                                                                        var temp1164 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000000U))));
                                                                        var temp1165 = ((uint)((int)((uint)(temp1164)) % (int)((uint)((uint)10U))));
                                                                        var temp1166 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1165)))))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp1166);
                                                                        var temp1167 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000000U))));
                                                                        var temp1168 = ((uint)((int)((uint)(temp1167)) % (int)((uint)((uint)10U))));
                                                                        var temp1169 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1168)))))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp1169);
                                                                        var temp1170 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                        var temp1171 = ((uint)((int)((uint)(temp1170)) % (int)((uint)((uint)10U))));
                                                                        var temp1172 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1171)))))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp1172);
                                                                        var temp1173 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                        var temp1174 = ((uint)((int)((uint)(temp1173)) % (int)((uint)((uint)10U))));
                                                                        var temp1175 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1174)))))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp1175);
                                                                        var temp1176 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                        var temp1177 = ((uint)((int)((uint)(temp1176)) % (int)((uint)((uint)10U))));
                                                                        var temp1178 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1177)))))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp1178);
                                                                        var temp1179 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                        var temp1180 = ((uint)((int)((uint)(temp1179)) % (int)((uint)((uint)10U))));
                                                                        var temp1181 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1180)))))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp1181);
                                                                        var temp1182 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                        var temp1183 = ((uint)((int)((uint)(temp1182)) % (int)((uint)((uint)10U))));
                                                                        var temp1184 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1183)))))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp1184);
                                                                        var temp1185 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                        var temp1186 = ((uint)((int)((uint)(temp1185)) % (int)((uint)((uint)10U))));
                                                                        var temp1187 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1186)))))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp1187);
                                                                        var temp1188 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                        var temp1189 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1188)))))));
                                                                        oBuf[oIndex + 9] = (Byte)(temp1189);
                                                                        oBuf[oIndex + 10] = (Byte)((byte)10U);
                                                                        oIndex += 11;
                                                                        s._4 = ((uint)(temp900));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)((byte)0U));
                                                                        goto M0;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (oIndex > 16374)
                                                                        {
                                                                            output.Write(oBuf, 0, oIndex);
                                                                            oIndex = 0;
                                                                        }

                                                                        var temp1190 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000000U))));
                                                                        var temp1191 = ((uint)((int)((uint)(temp1190)) % (int)((uint)((uint)10U))));
                                                                        var temp1192 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1191)))))));
                                                                        oBuf[oIndex + 0] = (Byte)(temp1192);
                                                                        var temp1193 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000000U))));
                                                                        var temp1194 = ((uint)((int)((uint)(temp1193)) % (int)((uint)((uint)10U))));
                                                                        var temp1195 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1194)))))));
                                                                        oBuf[oIndex + 1] = (Byte)(temp1195);
                                                                        var temp1196 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                        var temp1197 = ((uint)((int)((uint)(temp1196)) % (int)((uint)((uint)10U))));
                                                                        var temp1198 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1197)))))));
                                                                        oBuf[oIndex + 2] = (Byte)(temp1198);
                                                                        var temp1199 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                        var temp1200 = ((uint)((int)((uint)(temp1199)) % (int)((uint)((uint)10U))));
                                                                        var temp1201 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1200)))))));
                                                                        oBuf[oIndex + 3] = (Byte)(temp1201);
                                                                        var temp1202 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                        var temp1203 = ((uint)((int)((uint)(temp1202)) % (int)((uint)((uint)10U))));
                                                                        var temp1204 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1203)))))));
                                                                        oBuf[oIndex + 4] = (Byte)(temp1204);
                                                                        var temp1205 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                        var temp1206 = ((uint)((int)((uint)(temp1205)) % (int)((uint)((uint)10U))));
                                                                        var temp1207 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1206)))))));
                                                                        oBuf[oIndex + 5] = (Byte)(temp1207);
                                                                        var temp1208 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                        var temp1209 = ((uint)((int)((uint)(temp1208)) % (int)((uint)((uint)10U))));
                                                                        var temp1210 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1209)))))));
                                                                        oBuf[oIndex + 6] = (Byte)(temp1210);
                                                                        var temp1211 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                        var temp1212 = ((uint)((int)((uint)(temp1211)) % (int)((uint)((uint)10U))));
                                                                        var temp1213 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1212)))))));
                                                                        oBuf[oIndex + 7] = (Byte)(temp1213);
                                                                        var temp1214 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                        var temp1215 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1214)))))));
                                                                        oBuf[oIndex + 8] = (Byte)(temp1215);
                                                                        oBuf[oIndex + 9] = (Byte)((byte)10U);
                                                                        oIndex += 10;
                                                                        s._4 = ((uint)(temp900));
                                                                        s._3 = ((byte)((byte)0U));
                                                                        s._2 = ((byte)((byte)0U));
                                                                        s._1 = ((byte)((byte)0U));
                                                                        s._0 = ((byte)((byte)0U));
                                                                        goto M0;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (oIndex > 16375)
                                                                    {
                                                                        output.Write(oBuf, 0, oIndex);
                                                                        oIndex = 0;
                                                                    }

                                                                    var temp1216 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000000U))));
                                                                    var temp1217 = ((uint)((int)((uint)(temp1216)) % (int)((uint)((uint)10U))));
                                                                    var temp1218 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1217)))))));
                                                                    oBuf[oIndex + 0] = (Byte)(temp1218);
                                                                    var temp1219 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                    var temp1220 = ((uint)((int)((uint)(temp1219)) % (int)((uint)((uint)10U))));
                                                                    var temp1221 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1220)))))));
                                                                    oBuf[oIndex + 1] = (Byte)(temp1221);
                                                                    var temp1222 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                    var temp1223 = ((uint)((int)((uint)(temp1222)) % (int)((uint)((uint)10U))));
                                                                    var temp1224 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1223)))))));
                                                                    oBuf[oIndex + 2] = (Byte)(temp1224);
                                                                    var temp1225 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                    var temp1226 = ((uint)((int)((uint)(temp1225)) % (int)((uint)((uint)10U))));
                                                                    var temp1227 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1226)))))));
                                                                    oBuf[oIndex + 3] = (Byte)(temp1227);
                                                                    var temp1228 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                    var temp1229 = ((uint)((int)((uint)(temp1228)) % (int)((uint)((uint)10U))));
                                                                    var temp1230 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1229)))))));
                                                                    oBuf[oIndex + 4] = (Byte)(temp1230);
                                                                    var temp1231 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                    var temp1232 = ((uint)((int)((uint)(temp1231)) % (int)((uint)((uint)10U))));
                                                                    var temp1233 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1232)))))));
                                                                    oBuf[oIndex + 5] = (Byte)(temp1233);
                                                                    var temp1234 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                    var temp1235 = ((uint)((int)((uint)(temp1234)) % (int)((uint)((uint)10U))));
                                                                    var temp1236 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1235)))))));
                                                                    oBuf[oIndex + 6] = (Byte)(temp1236);
                                                                    var temp1237 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                    var temp1238 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1237)))))));
                                                                    oBuf[oIndex + 7] = (Byte)(temp1238);
                                                                    oBuf[oIndex + 8] = (Byte)((byte)10U);
                                                                    oIndex += 9;
                                                                    s._4 = ((uint)(temp900));
                                                                    s._3 = ((byte)((byte)0U));
                                                                    s._2 = ((byte)((byte)0U));
                                                                    s._1 = ((byte)((byte)0U));
                                                                    s._0 = ((byte)((byte)0U));
                                                                    goto M0;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (oIndex > 16376)
                                                                {
                                                                    output.Write(oBuf, 0, oIndex);
                                                                    oIndex = 0;
                                                                }

                                                                var temp1239 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000000U))));
                                                                var temp1240 = ((uint)((int)((uint)(temp1239)) % (int)((uint)((uint)10U))));
                                                                var temp1241 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1240)))))));
                                                                oBuf[oIndex + 0] = (Byte)(temp1241);
                                                                var temp1242 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                                var temp1243 = ((uint)((int)((uint)(temp1242)) % (int)((uint)((uint)10U))));
                                                                var temp1244 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1243)))))));
                                                                oBuf[oIndex + 1] = (Byte)(temp1244);
                                                                var temp1245 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                                var temp1246 = ((uint)((int)((uint)(temp1245)) % (int)((uint)((uint)10U))));
                                                                var temp1247 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1246)))))));
                                                                oBuf[oIndex + 2] = (Byte)(temp1247);
                                                                var temp1248 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                                var temp1249 = ((uint)((int)((uint)(temp1248)) % (int)((uint)((uint)10U))));
                                                                var temp1250 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1249)))))));
                                                                oBuf[oIndex + 3] = (Byte)(temp1250);
                                                                var temp1251 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                                var temp1252 = ((uint)((int)((uint)(temp1251)) % (int)((uint)((uint)10U))));
                                                                var temp1253 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1252)))))));
                                                                oBuf[oIndex + 4] = (Byte)(temp1253);
                                                                var temp1254 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                                var temp1255 = ((uint)((int)((uint)(temp1254)) % (int)((uint)((uint)10U))));
                                                                var temp1256 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1255)))))));
                                                                oBuf[oIndex + 5] = (Byte)(temp1256);
                                                                var temp1257 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                                var temp1258 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1257)))))));
                                                                oBuf[oIndex + 6] = (Byte)(temp1258);
                                                                oBuf[oIndex + 7] = (Byte)((byte)10U);
                                                                oIndex += 8;
                                                                s._4 = ((uint)(temp900));
                                                                s._3 = ((byte)((byte)0U));
                                                                s._2 = ((byte)((byte)0U));
                                                                s._1 = ((byte)((byte)0U));
                                                                s._0 = ((byte)((byte)0U));
                                                                goto M0;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (oIndex > 16377)
                                                            {
                                                                output.Write(oBuf, 0, oIndex);
                                                                oIndex = 0;
                                                            }

                                                            var temp1259 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100000U))));
                                                            var temp1260 = ((uint)((int)((uint)(temp1259)) % (int)((uint)((uint)10U))));
                                                            var temp1261 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1260)))))));
                                                            oBuf[oIndex + 0] = (Byte)(temp1261);
                                                            var temp1262 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                            var temp1263 = ((uint)((int)((uint)(temp1262)) % (int)((uint)((uint)10U))));
                                                            var temp1264 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1263)))))));
                                                            oBuf[oIndex + 1] = (Byte)(temp1264);
                                                            var temp1265 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                            var temp1266 = ((uint)((int)((uint)(temp1265)) % (int)((uint)((uint)10U))));
                                                            var temp1267 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1266)))))));
                                                            oBuf[oIndex + 2] = (Byte)(temp1267);
                                                            var temp1268 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                            var temp1269 = ((uint)((int)((uint)(temp1268)) % (int)((uint)((uint)10U))));
                                                            var temp1270 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1269)))))));
                                                            oBuf[oIndex + 3] = (Byte)(temp1270);
                                                            var temp1271 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                            var temp1272 = ((uint)((int)((uint)(temp1271)) % (int)((uint)((uint)10U))));
                                                            var temp1273 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1272)))))));
                                                            oBuf[oIndex + 4] = (Byte)(temp1273);
                                                            var temp1274 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                            var temp1275 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1274)))))));
                                                            oBuf[oIndex + 5] = (Byte)(temp1275);
                                                            oBuf[oIndex + 6] = (Byte)((byte)10U);
                                                            oIndex += 7;
                                                            s._4 = ((uint)(temp900));
                                                            s._3 = ((byte)((byte)0U));
                                                            s._2 = ((byte)((byte)0U));
                                                            s._1 = ((byte)((byte)0U));
                                                            s._0 = ((byte)((byte)0U));
                                                            goto M0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (oIndex > 16378)
                                                        {
                                                            output.Write(oBuf, 0, oIndex);
                                                            oIndex = 0;
                                                        }

                                                        var temp1276 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10000U))));
                                                        var temp1277 = ((uint)((int)((uint)(temp1276)) % (int)((uint)((uint)10U))));
                                                        var temp1278 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1277)))))));
                                                        oBuf[oIndex + 0] = (Byte)(temp1278);
                                                        var temp1279 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                        var temp1280 = ((uint)((int)((uint)(temp1279)) % (int)((uint)((uint)10U))));
                                                        var temp1281 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1280)))))));
                                                        oBuf[oIndex + 1] = (Byte)(temp1281);
                                                        var temp1282 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                        var temp1283 = ((uint)((int)((uint)(temp1282)) % (int)((uint)((uint)10U))));
                                                        var temp1284 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1283)))))));
                                                        oBuf[oIndex + 2] = (Byte)(temp1284);
                                                        var temp1285 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                        var temp1286 = ((uint)((int)((uint)(temp1285)) % (int)((uint)((uint)10U))));
                                                        var temp1287 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1286)))))));
                                                        oBuf[oIndex + 3] = (Byte)(temp1287);
                                                        var temp1288 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                        var temp1289 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1288)))))));
                                                        oBuf[oIndex + 4] = (Byte)(temp1289);
                                                        oBuf[oIndex + 5] = (Byte)((byte)10U);
                                                        oIndex += 6;
                                                        s._4 = ((uint)(temp900));
                                                        s._3 = ((byte)((byte)0U));
                                                        s._2 = ((byte)((byte)0U));
                                                        s._1 = ((byte)((byte)0U));
                                                        s._0 = ((byte)((byte)0U));
                                                        goto M0;
                                                    }
                                                }
                                                else
                                                {
                                                    if (oIndex > 16379)
                                                    {
                                                        output.Write(oBuf, 0, oIndex);
                                                        oIndex = 0;
                                                    }

                                                    var temp1290 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)1000U))));
                                                    var temp1291 = ((uint)((int)((uint)(temp1290)) % (int)((uint)((uint)10U))));
                                                    var temp1292 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1291)))))));
                                                    oBuf[oIndex + 0] = (Byte)(temp1292);
                                                    var temp1293 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                    var temp1294 = ((uint)((int)((uint)(temp1293)) % (int)((uint)((uint)10U))));
                                                    var temp1295 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1294)))))));
                                                    oBuf[oIndex + 1] = (Byte)(temp1295);
                                                    var temp1296 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                    var temp1297 = ((uint)((int)((uint)(temp1296)) % (int)((uint)((uint)10U))));
                                                    var temp1298 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1297)))))));
                                                    oBuf[oIndex + 2] = (Byte)(temp1298);
                                                    var temp1299 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                    var temp1300 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1299)))))));
                                                    oBuf[oIndex + 3] = (Byte)(temp1300);
                                                    oBuf[oIndex + 4] = (Byte)((byte)10U);
                                                    oIndex += 5;
                                                    s._4 = ((uint)(temp900));
                                                    s._3 = ((byte)((byte)0U));
                                                    s._2 = ((byte)((byte)0U));
                                                    s._1 = ((byte)((byte)0U));
                                                    s._0 = ((byte)((byte)0U));
                                                    goto M0;
                                                }
                                            }
                                            else
                                            {
                                                if (oIndex > 16380)
                                                {
                                                    output.Write(oBuf, 0, oIndex);
                                                    oIndex = 0;
                                                }

                                                var temp1301 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)100U))));
                                                var temp1302 = ((uint)((int)((uint)(temp1301)) % (int)((uint)((uint)10U))));
                                                var temp1303 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1302)))))));
                                                oBuf[oIndex + 0] = (Byte)(temp1303);
                                                var temp1304 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                                var temp1305 = ((uint)((int)((uint)(temp1304)) % (int)((uint)((uint)10U))));
                                                var temp1306 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1305)))))));
                                                oBuf[oIndex + 1] = (Byte)(temp1306);
                                                var temp1307 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                                var temp1308 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1307)))))));
                                                oBuf[oIndex + 2] = (Byte)(temp1308);
                                                oBuf[oIndex + 3] = (Byte)((byte)10U);
                                                oIndex += 4;
                                                s._4 = ((uint)(temp900));
                                                s._3 = ((byte)((byte)0U));
                                                s._2 = ((byte)((byte)0U));
                                                s._1 = ((byte)((byte)0U));
                                                s._0 = ((byte)((byte)0U));
                                                goto M0;
                                            }
                                        }
                                        else
                                        {
                                            if (oIndex > 16381)
                                            {
                                                output.Write(oBuf, 0, oIndex);
                                                oIndex = 0;
                                            }

                                            var temp1309 = ((uint)((int)((uint)(temp903)) / (int)((uint)((uint)10U))));
                                            var temp1310 = ((uint)((int)((uint)(temp1309)) % (int)((uint)((uint)10U))));
                                            var temp1311 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1310)))))));
                                            oBuf[oIndex + 0] = (Byte)(temp1311);
                                            var temp1312 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                            var temp1313 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1312)))))));
                                            oBuf[oIndex + 1] = (Byte)(temp1313);
                                            oBuf[oIndex + 2] = (Byte)((byte)10U);
                                            oIndex += 3;
                                            s._4 = ((uint)(temp900));
                                            s._3 = ((byte)((byte)0U));
                                            s._2 = ((byte)((byte)0U));
                                            s._1 = ((byte)((byte)0U));
                                            s._0 = ((byte)((byte)0U));
                                            goto M0;
                                        }
                                    }
                                    else
                                    {
                                        if (oIndex > 16382)
                                        {
                                            output.Write(oBuf, 0, oIndex);
                                            oIndex = 0;
                                        }

                                        var temp1314 = ((uint)((int)((uint)(temp903)) % (int)((uint)((uint)10U))));
                                        var temp1315 = ((byte)(((byte)((byte)48U)) + ((byte)(((byte)((uint)(temp1314)))))));
                                        oBuf[oIndex + 0] = (Byte)(temp1315);
                                        oBuf[oIndex + 1] = (Byte)((byte)10U);
                                        oIndex += 2;
                                        s._4 = ((uint)(temp900));
                                        s._3 = ((byte)((byte)0U));
                                        s._2 = ((byte)((byte)0U));
                                        s._1 = ((byte)((byte)0U));
                                        s._0 = ((byte)((byte)0U));
                                        goto M0;
                                    }
                                }
                            }
                        }
                    }
                }

                M23:
                {
                    if (++iIndex >= input.Length)
                        goto F23;
                    i = input[iIndex];
                    throw new Exception();
                }

                M24:
                {
                    if (++iIndex >= input.Length)
                        goto F24;
                    i = input[iIndex];
                    throw new Exception();
                }

                M25:
                {
                    if (++iIndex >= input.Length)
                        goto F25;
                    i = input[iIndex];
                    throw new Exception();
                }

                M26:
                {
                    if (++iIndex >= input.Length)
                        goto F26;
                    i = input[iIndex];
                    throw new Exception();
                }

                M27:
                {
                    if (++iIndex >= input.Length)
                        goto F27;
                    i = input[iIndex];
                    throw new Exception();
                }

                F0:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F1:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F2:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F3:
                    throw new Exception();
                F4:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F5:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F6:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F7:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F8:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F9:
                    throw new Exception();
                F10:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F11:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F12:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F13:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F14:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F15:
                    throw new Exception();
                F16:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F17:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F18:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F19:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F20:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F21:
                    throw new Exception();
                F22:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F23:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F24:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F25:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F26:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }

                F27:
                {
                    if (oIndex > 0)
                        output.Write(oBuf, 0, oIndex);
                    return;
                }
            }
        }
    }
}