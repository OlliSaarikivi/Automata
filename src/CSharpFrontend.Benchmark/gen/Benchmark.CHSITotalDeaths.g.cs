using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class CHSITotalDeaths : SpecialTransducer
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
                        var temp7 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp7)
                        {
                            goto M8;
                        }
                        else
                        {
                            goto M7;
                        }
                    }
                }

                M8:
                {
                    if (!ie.MoveNext())
                        goto F8;
                    i = ie.Current;
                    {
                        var temp8 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp8)
                        {
                            goto M9;
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
                        var temp9 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp9)
                        {
                            goto M10;
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
                        var temp10 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp10)
                        {
                            goto M11;
                        }
                        else
                        {
                            goto M10;
                        }
                    }
                }

                M11:
                {
                    if (!ie.MoveNext())
                        goto F11;
                    i = ie.Current;
                    {
                        var temp11 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp11)
                        {
                            goto M12;
                        }
                        else
                        {
                            goto M11;
                        }
                    }
                }

                M12:
                {
                    if (!ie.MoveNext())
                        goto F12;
                    i = ie.Current;
                    {
                        var temp12 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp12)
                        {
                            goto M13;
                        }
                        else
                        {
                            goto M12;
                        }
                    }
                }

                M13:
                {
                    if (!ie.MoveNext())
                        goto F13;
                    i = ie.Current;
                    {
                        var temp13 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp13)
                        {
                            goto M14;
                        }
                        else
                        {
                            goto M13;
                        }
                    }
                }

                M14:
                {
                    if (!ie.MoveNext())
                        goto F14;
                    i = ie.Current;
                    {
                        var temp14 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp14)
                        {
                            goto M15;
                        }
                        else
                        {
                            goto M14;
                        }
                    }
                }

                M15:
                {
                    if (!ie.MoveNext())
                        goto F15;
                    i = ie.Current;
                    {
                        var temp15 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp15)
                        {
                            goto M16;
                        }
                        else
                        {
                            goto M15;
                        }
                    }
                }

                M16:
                {
                    if (!ie.MoveNext())
                        goto F16;
                    i = ie.Current;
                    {
                        var temp16 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp16)
                        {
                            goto M17;
                        }
                        else
                        {
                            goto M16;
                        }
                    }
                }

                M17:
                {
                    if (!ie.MoveNext())
                        goto F17;
                    i = ie.Current;
                    {
                        var temp17 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp17)
                        {
                            goto M18;
                        }
                        else
                        {
                            goto M17;
                        }
                    }
                }

                M18:
                {
                    if (!ie.MoveNext())
                        goto F18;
                    i = ie.Current;
                    {
                        var temp18 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp18)
                        {
                            goto M19;
                        }
                        else
                        {
                            goto M18;
                        }
                    }
                }

                M19:
                {
                    if (!ie.MoveNext())
                        goto F19;
                    i = ie.Current;
                    {
                        var temp19 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp19)
                        {
                            goto M20;
                        }
                        else
                        {
                            goto M19;
                        }
                    }
                }

                M20:
                {
                    if (!ie.MoveNext())
                        goto F20;
                    i = ie.Current;
                    {
                        var temp20 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp20)
                        {
                            goto M21;
                        }
                        else
                        {
                            goto M20;
                        }
                    }
                }

                M21:
                {
                    if (!ie.MoveNext())
                        goto F21;
                    i = ie.Current;
                    {
                        var temp21 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp21)
                        {
                            goto M22;
                        }
                        else
                        {
                            goto M21;
                        }
                    }
                }

                M22:
                {
                    if (!ie.MoveNext())
                        goto F22;
                    i = ie.Current;
                    {
                        var temp22 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp22)
                        {
                            goto M23;
                        }
                        else
                        {
                            goto M22;
                        }
                    }
                }

                M23:
                {
                    if (!ie.MoveNext())
                        goto F23;
                    i = ie.Current;
                    {
                        var temp23 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp23)
                        {
                            goto M24;
                        }
                        else
                        {
                            goto M23;
                        }
                    }
                }

                M24:
                {
                    if (!ie.MoveNext())
                        goto F24;
                    i = ie.Current;
                    {
                        var temp24 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp24)
                        {
                            goto M25;
                        }
                        else
                        {
                            goto M24;
                        }
                    }
                }

                M25:
                {
                    if (!ie.MoveNext())
                        goto F25;
                    i = ie.Current;
                    {
                        var temp25 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp25)
                        {
                            goto M26;
                        }
                        else
                        {
                            goto M25;
                        }
                    }
                }

                M26:
                {
                    if (!ie.MoveNext())
                        goto F26;
                    i = ie.Current;
                    {
                        var temp26 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp26)
                        {
                            goto M27;
                        }
                        else
                        {
                            goto M26;
                        }
                    }
                }

                M27:
                {
                    if (!ie.MoveNext())
                        goto F27;
                    i = ie.Current;
                    {
                        var temp27 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp27)
                        {
                            goto M28;
                        }
                        else
                        {
                            goto M27;
                        }
                    }
                }

                M28:
                {
                    if (!ie.MoveNext())
                        goto F28;
                    i = ie.Current;
                    {
                        var temp28 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp28)
                        {
                            goto M29;
                        }
                        else
                        {
                            goto M28;
                        }
                    }
                }

                M29:
                {
                    if (!ie.MoveNext())
                        goto F29;
                    i = ie.Current;
                    {
                        var temp29 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp29)
                        {
                            goto M30;
                        }
                        else
                        {
                            goto M29;
                        }
                    }
                }

                M30:
                {
                    if (!ie.MoveNext())
                        goto F30;
                    i = ie.Current;
                    {
                        var temp30 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp30)
                        {
                            goto M31;
                        }
                        else
                        {
                            goto M30;
                        }
                    }
                }

                M31:
                {
                    if (!ie.MoveNext())
                        goto F31;
                    i = ie.Current;
                    {
                        var temp31 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp31)
                        {
                            goto M32;
                        }
                        else
                        {
                            goto M31;
                        }
                    }
                }

                M32:
                {
                    if (!ie.MoveNext())
                        goto F32;
                    i = ie.Current;
                    {
                        var temp32 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp32)
                        {
                            goto M33;
                        }
                        else
                        {
                            goto M32;
                        }
                    }
                }

                M33:
                {
                    if (!ie.MoveNext())
                        goto F33;
                    i = ie.Current;
                    {
                        var temp33 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp33)
                        {
                            goto M34;
                        }
                        else
                        {
                            goto M33;
                        }
                    }
                }

                M34:
                {
                    if (!ie.MoveNext())
                        goto F34;
                    i = ie.Current;
                    {
                        var temp34 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp34)
                        {
                            goto M35;
                        }
                        else
                        {
                            goto M34;
                        }
                    }
                }

                M35:
                {
                    if (!ie.MoveNext())
                        goto F35;
                    i = ie.Current;
                    {
                        var temp35 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp35)
                        {
                            goto M36;
                        }
                        else
                        {
                            goto M35;
                        }
                    }
                }

                M36:
                {
                    if (!ie.MoveNext())
                        goto F36;
                    i = ie.Current;
                    {
                        var temp36 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp36)
                        {
                            goto M37;
                        }
                        else
                        {
                            goto M36;
                        }
                    }
                }

                M37:
                {
                    if (!ie.MoveNext())
                        goto F37;
                    i = ie.Current;
                    {
                        var temp37 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp37)
                        {
                            goto M38;
                        }
                        else
                        {
                            goto M37;
                        }
                    }
                }

                M38:
                {
                    if (!ie.MoveNext())
                        goto F38;
                    i = ie.Current;
                    {
                        var temp38 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp38)
                        {
                            goto M39;
                        }
                        else
                        {
                            goto M38;
                        }
                    }
                }

                M39:
                {
                    if (!ie.MoveNext())
                        goto F39;
                    i = ie.Current;
                    {
                        var temp39 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp39)
                        {
                            goto M40;
                        }
                        else
                        {
                            goto M39;
                        }
                    }
                }

                M40:
                {
                    if (!ie.MoveNext())
                        goto F40;
                    i = ie.Current;
                    {
                        var temp40 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp40)
                        {
                            goto M41;
                        }
                        else
                        {
                            goto M40;
                        }
                    }
                }

                M41:
                {
                    if (!ie.MoveNext())
                        goto F41;
                    i = ie.Current;
                    {
                        var temp41 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp41)
                        {
                            goto M42;
                        }
                        else
                        {
                            goto M41;
                        }
                    }
                }

                M42:
                {
                    if (!ie.MoveNext())
                        goto F42;
                    i = ie.Current;
                    {
                        var temp42 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp42)
                        {
                            goto M43;
                        }
                        else
                        {
                            goto M42;
                        }
                    }
                }

                M43:
                {
                    if (!ie.MoveNext())
                        goto F43;
                    i = ie.Current;
                    {
                        var temp43 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp43)
                        {
                            goto M44;
                        }
                        else
                        {
                            goto M43;
                        }
                    }
                }

                M44:
                {
                    if (!ie.MoveNext())
                        goto F44;
                    i = ie.Current;
                    {
                        var temp44 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp44)
                        {
                            goto M45;
                        }
                        else
                        {
                            goto M44;
                        }
                    }
                }

                M45:
                {
                    if (!ie.MoveNext())
                        goto F45;
                    i = ie.Current;
                    {
                        var temp45 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp45)
                        {
                            goto M46;
                        }
                        else
                        {
                            goto M45;
                        }
                    }
                }

                M46:
                {
                    if (!ie.MoveNext())
                        goto F46;
                    i = ie.Current;
                    {
                        var temp46 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp46)
                        {
                            goto M47;
                        }
                        else
                        {
                            goto M46;
                        }
                    }
                }

                M47:
                {
                    if (!ie.MoveNext())
                        goto F47;
                    i = ie.Current;
                    {
                        var temp47 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp47)
                        {
                            goto M48;
                        }
                        else
                        {
                            goto M47;
                        }
                    }
                }

                M48:
                {
                    if (!ie.MoveNext())
                        goto F48;
                    i = ie.Current;
                    {
                        var temp48 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp48)
                        {
                            goto M49;
                        }
                        else
                        {
                            goto M48;
                        }
                    }
                }

                M49:
                {
                    if (!ie.MoveNext())
                        goto F49;
                    i = ie.Current;
                    {
                        var temp49 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp49)
                        {
                            goto M50;
                        }
                        else
                        {
                            goto M49;
                        }
                    }
                }

                M50:
                {
                    if (!ie.MoveNext())
                        goto F50;
                    i = ie.Current;
                    {
                        var temp50 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp50)
                        {
                            goto M51;
                        }
                        else
                        {
                            goto M50;
                        }
                    }
                }

                M51:
                {
                    if (!ie.MoveNext())
                        goto F51;
                    i = ie.Current;
                    {
                        var temp51 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp51)
                        {
                            goto M52;
                        }
                        else
                        {
                            goto M51;
                        }
                    }
                }

                M52:
                {
                    if (!ie.MoveNext())
                        goto F52;
                    i = ie.Current;
                    {
                        var temp52 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp52)
                        {
                            goto M53;
                        }
                        else
                        {
                            goto M52;
                        }
                    }
                }

                M53:
                {
                    if (!ie.MoveNext())
                        goto F53;
                    i = ie.Current;
                    {
                        var temp53 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp53)
                        {
                            goto M54;
                        }
                        else
                        {
                            goto M53;
                        }
                    }
                }

                M54:
                {
                    if (!ie.MoveNext())
                        goto F54;
                    i = ie.Current;
                    {
                        var temp54 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp54)
                        {
                            goto M55;
                        }
                        else
                        {
                            goto M54;
                        }
                    }
                }

                M55:
                {
                    if (!ie.MoveNext())
                        goto F55;
                    i = ie.Current;
                    {
                        var temp55 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp55)
                        {
                            goto M56;
                        }
                        else
                        {
                            goto M55;
                        }
                    }
                }

                M56:
                {
                    if (!ie.MoveNext())
                        goto F56;
                    i = ie.Current;
                    {
                        var temp56 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp56)
                        {
                            goto M57;
                        }
                        else
                        {
                            goto M56;
                        }
                    }
                }

                M57:
                {
                    if (!ie.MoveNext())
                        goto F57;
                    i = ie.Current;
                    {
                        var temp57 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp57)
                        {
                            goto M58;
                        }
                        else
                        {
                            goto M57;
                        }
                    }
                }

                M58:
                {
                    if (!ie.MoveNext())
                        goto F58;
                    i = ie.Current;
                    {
                        var temp58 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp58)
                        {
                            goto M59;
                        }
                        else
                        {
                            goto M58;
                        }
                    }
                }

                M59:
                {
                    if (!ie.MoveNext())
                        goto F59;
                    i = ie.Current;
                    {
                        var temp59 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp59)
                        {
                            goto M60;
                        }
                        else
                        {
                            goto M59;
                        }
                    }
                }

                M60:
                {
                    if (!ie.MoveNext())
                        goto F60;
                    i = ie.Current;
                    {
                        var temp60 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp60)
                        {
                            goto M61;
                        }
                        else
                        {
                            goto M60;
                        }
                    }
                }

                M61:
                {
                    if (!ie.MoveNext())
                        goto F61;
                    i = ie.Current;
                    {
                        var temp61 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp61)
                        {
                            goto M62;
                        }
                        else
                        {
                            goto M61;
                        }
                    }
                }

                M62:
                {
                    if (!ie.MoveNext())
                        goto F62;
                    i = ie.Current;
                    {
                        var temp62 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp62)
                        {
                            goto M63;
                        }
                        else
                        {
                            goto M62;
                        }
                    }
                }

                M63:
                {
                    if (!ie.MoveNext())
                        goto F63;
                    i = ie.Current;
                    {
                        var temp63 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp63)
                        {
                            goto M64;
                        }
                        else
                        {
                            goto M63;
                        }
                    }
                }

                M64:
                {
                    if (!ie.MoveNext())
                        goto F64;
                    i = ie.Current;
                    {
                        var temp64 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp64)
                        {
                            goto M65;
                        }
                        else
                        {
                            goto M64;
                        }
                    }
                }

                M65:
                {
                    if (!ie.MoveNext())
                        goto F65;
                    i = ie.Current;
                    {
                        var temp65 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp65)
                        {
                            goto M66;
                        }
                        else
                        {
                            goto M65;
                        }
                    }
                }

                M66:
                {
                    if (!ie.MoveNext())
                        goto F66;
                    i = ie.Current;
                    {
                        var temp66 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp66)
                        {
                            goto M67;
                        }
                        else
                        {
                            goto M66;
                        }
                    }
                }

                M67:
                {
                    if (!ie.MoveNext())
                        goto F67;
                    i = ie.Current;
                    {
                        var temp67 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp67)
                        {
                            goto M68;
                        }
                        else
                        {
                            goto M67;
                        }
                    }
                }

                M68:
                {
                    if (!ie.MoveNext())
                        goto F68;
                    i = ie.Current;
                    {
                        var temp68 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp68)
                        {
                            goto M69;
                        }
                        else
                        {
                            goto M68;
                        }
                    }
                }

                M69:
                {
                    if (!ie.MoveNext())
                        goto F69;
                    i = ie.Current;
                    {
                        var temp69 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp69)
                        {
                            goto M70;
                        }
                        else
                        {
                            goto M69;
                        }
                    }
                }

                M70:
                {
                    if (!ie.MoveNext())
                        goto F70;
                    i = ie.Current;
                    {
                        var temp70 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp70)
                        {
                            goto M71;
                        }
                        else
                        {
                            goto M70;
                        }
                    }
                }

                M71:
                {
                    if (!ie.MoveNext())
                        goto F71;
                    i = ie.Current;
                    {
                        var temp71 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp71)
                        {
                            goto M72;
                        }
                        else
                        {
                            goto M71;
                        }
                    }
                }

                M72:
                {
                    if (!ie.MoveNext())
                        goto F72;
                    i = ie.Current;
                    {
                        var temp72 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp72)
                        {
                            goto M73;
                        }
                        else
                        {
                            goto M72;
                        }
                    }
                }

                M73:
                {
                    if (!ie.MoveNext())
                        goto F73;
                    i = ie.Current;
                    {
                        var temp73 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp73)
                        {
                            goto M74;
                        }
                        else
                        {
                            goto M73;
                        }
                    }
                }

                M74:
                {
                    if (!ie.MoveNext())
                        goto F74;
                    i = ie.Current;
                    {
                        var temp74 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp74)
                        {
                            goto M75;
                        }
                        else
                        {
                            goto M74;
                        }
                    }
                }

                M75:
                {
                    if (!ie.MoveNext())
                        goto F75;
                    i = ie.Current;
                    {
                        var temp75 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp75)
                        {
                            goto M76;
                        }
                        else
                        {
                            goto M75;
                        }
                    }
                }

                M76:
                {
                    if (!ie.MoveNext())
                        goto F76;
                    i = ie.Current;
                    {
                        var temp76 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp76)
                        {
                            goto M77;
                        }
                        else
                        {
                            goto M76;
                        }
                    }
                }

                M77:
                {
                    if (!ie.MoveNext())
                        goto F77;
                    i = ie.Current;
                    {
                        var temp77 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp77)
                        {
                            goto M78;
                        }
                        else
                        {
                            goto M77;
                        }
                    }
                }

                M78:
                {
                    if (!ie.MoveNext())
                        goto F78;
                    i = ie.Current;
                    {
                        var temp78 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp78)
                        {
                            goto M79;
                        }
                        else
                        {
                            goto M78;
                        }
                    }
                }

                M79:
                {
                    if (!ie.MoveNext())
                        goto F79;
                    i = ie.Current;
                    {
                        var temp79 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp79)
                        {
                            goto M80;
                        }
                        else
                        {
                            goto M79;
                        }
                    }
                }

                M80:
                {
                    if (!ie.MoveNext())
                        goto F80;
                    i = ie.Current;
                    {
                        var temp80 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp80)
                        {
                            goto M81;
                        }
                        else
                        {
                            goto M80;
                        }
                    }
                }

                M81:
                {
                    if (!ie.MoveNext())
                        goto F81;
                    i = ie.Current;
                    {
                        var temp81 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp81)
                        {
                            goto M82;
                        }
                        else
                        {
                            goto M81;
                        }
                    }
                }

                M82:
                {
                    if (!ie.MoveNext())
                        goto F82;
                    i = ie.Current;
                    {
                        var temp82 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp82)
                        {
                            goto M83;
                        }
                        else
                        {
                            goto M82;
                        }
                    }
                }

                M83:
                {
                    if (!ie.MoveNext())
                        goto F83;
                    i = ie.Current;
                    {
                        var temp83 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp83)
                        {
                            goto M84;
                        }
                        else
                        {
                            goto M83;
                        }
                    }
                }

                M84:
                {
                    if (!ie.MoveNext())
                        goto F84;
                    i = ie.Current;
                    {
                        var temp84 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp84)
                        {
                            goto M85;
                        }
                        else
                        {
                            goto M84;
                        }
                    }
                }

                M85:
                {
                    if (!ie.MoveNext())
                        goto F85;
                    i = ie.Current;
                    {
                        var temp85 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp85)
                        {
                            goto M86;
                        }
                        else
                        {
                            goto M85;
                        }
                    }
                }

                M86:
                {
                    if (!ie.MoveNext())
                        goto F86;
                    i = ie.Current;
                    {
                        var temp86 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp86)
                        {
                            goto M87;
                        }
                        else
                        {
                            goto M86;
                        }
                    }
                }

                M87:
                {
                    if (!ie.MoveNext())
                        goto F87;
                    i = ie.Current;
                    {
                        var temp87 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp87)
                        {
                            goto M88;
                        }
                        else
                        {
                            goto M87;
                        }
                    }
                }

                M88:
                {
                    if (!ie.MoveNext())
                        goto F88;
                    i = ie.Current;
                    {
                        var temp88 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp88)
                        {
                            goto M89;
                        }
                        else
                        {
                            goto M88;
                        }
                    }
                }

                M89:
                {
                    if (!ie.MoveNext())
                        goto F89;
                    i = ie.Current;
                    {
                        var temp89 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp89)
                        {
                            goto M90;
                        }
                        else
                        {
                            goto M89;
                        }
                    }
                }

                M90:
                {
                    if (!ie.MoveNext())
                        goto F90;
                    i = ie.Current;
                    {
                        var temp90 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp90)
                        {
                            goto M91;
                        }
                        else
                        {
                            goto M90;
                        }
                    }
                }

                M91:
                {
                    if (!ie.MoveNext())
                        goto F91;
                    i = ie.Current;
                    {
                        var temp91 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp91)
                        {
                            goto M92;
                        }
                        else
                        {
                            goto M91;
                        }
                    }
                }

                M92:
                {
                    if (!ie.MoveNext())
                        goto F92;
                    i = ie.Current;
                    {
                        var temp92 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp92)
                        {
                            goto M93;
                        }
                        else
                        {
                            goto M92;
                        }
                    }
                }

                M93:
                {
                    if (!ie.MoveNext())
                        goto F93;
                    i = ie.Current;
                    {
                        var temp93 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp93)
                        {
                            goto M94;
                        }
                        else
                        {
                            goto M93;
                        }
                    }
                }

                M94:
                {
                    if (!ie.MoveNext())
                        goto F94;
                    i = ie.Current;
                    {
                        var temp94 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp94)
                        {
                            goto M95;
                        }
                        else
                        {
                            goto M94;
                        }
                    }
                }

                M95:
                {
                    if (!ie.MoveNext())
                        goto F95;
                    i = ie.Current;
                    {
                        var temp95 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp95)
                        {
                            goto M96;
                        }
                        else
                        {
                            goto M95;
                        }
                    }
                }

                M96:
                {
                    if (!ie.MoveNext())
                        goto F96;
                    i = ie.Current;
                    {
                        var temp96 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp96)
                        {
                            goto M97;
                        }
                        else
                        {
                            goto M96;
                        }
                    }
                }

                M97:
                {
                    if (!ie.MoveNext())
                        goto F97;
                    i = ie.Current;
                    {
                        var temp97 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp97)
                        {
                            goto M98;
                        }
                        else
                        {
                            goto M97;
                        }
                    }
                }

                M98:
                {
                    if (!ie.MoveNext())
                        goto F98;
                    i = ie.Current;
                    {
                        var temp98 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp98)
                        {
                            goto M99;
                        }
                        else
                        {
                            goto M98;
                        }
                    }
                }

                M99:
                {
                    if (!ie.MoveNext())
                        goto F99;
                    i = ie.Current;
                    {
                        var temp99 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp99)
                        {
                            goto M100;
                        }
                        else
                        {
                            goto M99;
                        }
                    }
                }

                M100:
                {
                    if (!ie.MoveNext())
                        goto F100;
                    i = ie.Current;
                    {
                        var temp100 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp100)
                        {
                            goto M101;
                        }
                        else
                        {
                            goto M100;
                        }
                    }
                }

                M101:
                {
                    if (!ie.MoveNext())
                        goto F101;
                    i = ie.Current;
                    {
                        var temp101 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp101)
                        {
                            goto M102;
                        }
                        else
                        {
                            goto M101;
                        }
                    }
                }

                M102:
                {
                    if (!ie.MoveNext())
                        goto F102;
                    i = ie.Current;
                    {
                        var temp102 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp102)
                        {
                            goto M103;
                        }
                        else
                        {
                            goto M102;
                        }
                    }
                }

                M103:
                {
                    if (!ie.MoveNext())
                        goto F103;
                    i = ie.Current;
                    {
                        var temp103 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp103)
                        {
                            goto M104;
                        }
                        else
                        {
                            goto M103;
                        }
                    }
                }

                M104:
                {
                    if (!ie.MoveNext())
                        goto F104;
                    i = ie.Current;
                    {
                        var temp104 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp104)
                        {
                            goto M105;
                        }
                        else
                        {
                            goto M104;
                        }
                    }
                }

                M105:
                {
                    if (!ie.MoveNext())
                        goto F105;
                    i = ie.Current;
                    {
                        var temp105 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp105)
                        {
                            goto M106;
                        }
                        else
                        {
                            goto M105;
                        }
                    }
                }

                M106:
                {
                    if (!ie.MoveNext())
                        goto F106;
                    i = ie.Current;
                    {
                        var temp106 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp106)
                        {
                            goto M107;
                        }
                        else
                        {
                            goto M106;
                        }
                    }
                }

                M107:
                {
                    if (!ie.MoveNext())
                        goto F107;
                    i = ie.Current;
                    {
                        var temp107 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp107)
                        {
                            goto M108;
                        }
                        else
                        {
                            goto M107;
                        }
                    }
                }

                M108:
                {
                    if (!ie.MoveNext())
                        goto F108;
                    i = ie.Current;
                    {
                        var temp108 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp108)
                        {
                            goto M109;
                        }
                        else
                        {
                            goto M108;
                        }
                    }
                }

                M109:
                {
                    if (!ie.MoveNext())
                        goto F109;
                    i = ie.Current;
                    {
                        var temp109 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp109)
                        {
                            goto M110;
                        }
                        else
                        {
                            goto M109;
                        }
                    }
                }

                M110:
                {
                    if (!ie.MoveNext())
                        goto F110;
                    i = ie.Current;
                    {
                        var temp110 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp110)
                        {
                            goto M111;
                        }
                        else
                        {
                            goto M110;
                        }
                    }
                }

                M111:
                {
                    if (!ie.MoveNext())
                        goto F111;
                    i = ie.Current;
                    {
                        var temp111 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp111)
                        {
                            goto M112;
                        }
                        else
                        {
                            goto M111;
                        }
                    }
                }

                M112:
                {
                    if (!ie.MoveNext())
                        goto F112;
                    i = ie.Current;
                    {
                        var temp112 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp112)
                        {
                            goto M113;
                        }
                        else
                        {
                            goto M112;
                        }
                    }
                }

                M113:
                {
                    if (!ie.MoveNext())
                        goto F113;
                    i = ie.Current;
                    {
                        var temp113 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp113)
                        {
                            goto M114;
                        }
                        else
                        {
                            goto M113;
                        }
                    }
                }

                M114:
                {
                    if (!ie.MoveNext())
                        goto F114;
                    i = ie.Current;
                    {
                        var temp114 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp114)
                        {
                            goto M115;
                        }
                        else
                        {
                            goto M114;
                        }
                    }
                }

                M115:
                {
                    if (!ie.MoveNext())
                        goto F115;
                    i = ie.Current;
                    {
                        var temp115 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp115)
                        {
                            goto M116;
                        }
                        else
                        {
                            goto M115;
                        }
                    }
                }

                M116:
                {
                    if (!ie.MoveNext())
                        goto F116;
                    i = ie.Current;
                    {
                        var temp116 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp116)
                        {
                            goto M117;
                        }
                        else
                        {
                            goto M116;
                        }
                    }
                }

                M117:
                {
                    if (!ie.MoveNext())
                        goto F117;
                    i = ie.Current;
                    {
                        var temp117 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp117)
                        {
                            goto M118;
                        }
                        else
                        {
                            goto M117;
                        }
                    }
                }

                M118:
                {
                    if (!ie.MoveNext())
                        goto F118;
                    i = ie.Current;
                    {
                        var temp118 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp118)
                        {
                            goto M119;
                        }
                        else
                        {
                            goto M118;
                        }
                    }
                }

                M119:
                {
                    if (!ie.MoveNext())
                        goto F119;
                    i = ie.Current;
                    {
                        var temp119 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp119)
                        {
                            goto M120;
                        }
                        else
                        {
                            goto M119;
                        }
                    }
                }

                M120:
                {
                    if (!ie.MoveNext())
                        goto F120;
                    i = ie.Current;
                    {
                        var temp120 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp120)
                        {
                            goto M121;
                        }
                        else
                        {
                            goto M120;
                        }
                    }
                }

                M121:
                {
                    if (!ie.MoveNext())
                        goto F121;
                    i = ie.Current;
                    {
                        var temp121 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp121)
                        {
                            goto M122;
                        }
                        else
                        {
                            goto M121;
                        }
                    }
                }

                M122:
                {
                    if (!ie.MoveNext())
                        goto F122;
                    i = ie.Current;
                    {
                        var temp122 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp122)
                        {
                            goto M123;
                        }
                        else
                        {
                            goto M122;
                        }
                    }
                }

                M123:
                {
                    if (!ie.MoveNext())
                        goto F123;
                    i = ie.Current;
                    {
                        var temp123 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp123)
                        {
                            goto M124;
                        }
                        else
                        {
                            goto M123;
                        }
                    }
                }

                M124:
                {
                    if (!ie.MoveNext())
                        goto F124;
                    i = ie.Current;
                    {
                        var temp124 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp124)
                        {
                            goto M125;
                        }
                        else
                        {
                            goto M124;
                        }
                    }
                }

                M125:
                {
                    if (!ie.MoveNext())
                        goto F125;
                    i = ie.Current;
                    {
                        var temp125 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp125)
                        {
                            goto M126;
                        }
                        else
                        {
                            goto M125;
                        }
                    }
                }

                M126:
                {
                    if (!ie.MoveNext())
                        goto F126;
                    i = ie.Current;
                    {
                        var temp126 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp126)
                        {
                            goto M127;
                        }
                        else
                        {
                            goto M126;
                        }
                    }
                }

                M127:
                {
                    if (!ie.MoveNext())
                        goto F127;
                    i = ie.Current;
                    {
                        var temp127 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp127)
                        {
                            goto M128;
                        }
                        else
                        {
                            goto M127;
                        }
                    }
                }

                M128:
                {
                    if (!ie.MoveNext())
                        goto F128;
                    i = ie.Current;
                    {
                        var temp128 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp128)
                        {
                            goto M129;
                        }
                        else
                        {
                            goto M128;
                        }
                    }
                }

                M129:
                {
                    if (!ie.MoveNext())
                        goto F129;
                    i = ie.Current;
                    {
                        var temp129 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp129)
                        {
                            goto M130;
                        }
                        else
                        {
                            goto M129;
                        }
                    }
                }

                M130:
                {
                    if (!ie.MoveNext())
                        goto F130;
                    i = ie.Current;
                    {
                        var temp130 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp130)
                        {
                            goto M131;
                        }
                        else
                        {
                            goto M130;
                        }
                    }
                }

                M131:
                {
                    if (!ie.MoveNext())
                        goto F131;
                    i = ie.Current;
                    {
                        var temp131 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp131)
                        {
                            goto M132;
                        }
                        else
                        {
                            goto M131;
                        }
                    }
                }

                M132:
                {
                    if (!ie.MoveNext())
                        goto F132;
                    i = ie.Current;
                    {
                        var temp132 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp132)
                        {
                            goto M133;
                        }
                        else
                        {
                            goto M132;
                        }
                    }
                }

                M133:
                {
                    if (!ie.MoveNext())
                        goto F133;
                    i = ie.Current;
                    {
                        var temp133 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp133)
                        {
                            goto M134;
                        }
                        else
                        {
                            goto M133;
                        }
                    }
                }

                M134:
                {
                    if (!ie.MoveNext())
                        goto F134;
                    i = ie.Current;
                    {
                        var temp134 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp134)
                        {
                            goto M135;
                        }
                        else
                        {
                            goto M134;
                        }
                    }
                }

                M135:
                {
                    if (!ie.MoveNext())
                        goto F135;
                    i = ie.Current;
                    {
                        var temp135 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp135)
                        {
                            goto M136;
                        }
                        else
                        {
                            goto M135;
                        }
                    }
                }

                M136:
                {
                    if (!ie.MoveNext())
                        goto F136;
                    i = ie.Current;
                    {
                        var temp136 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp136)
                        {
                            goto M137;
                        }
                        else
                        {
                            goto M136;
                        }
                    }
                }

                M137:
                {
                    if (!ie.MoveNext())
                        goto F137;
                    i = ie.Current;
                    {
                        var temp137 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp137)
                        {
                            goto M138;
                        }
                        else
                        {
                            goto M137;
                        }
                    }
                }

                M138:
                {
                    if (!ie.MoveNext())
                        goto F138;
                    i = ie.Current;
                    {
                        var temp138 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp138)
                        {
                            goto M139;
                        }
                        else
                        {
                            goto M138;
                        }
                    }
                }

                M139:
                {
                    if (!ie.MoveNext())
                        goto F139;
                    i = ie.Current;
                    {
                        var temp139 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                        var temp140 = ((ushort)(((ushort)(i)) >> 6));
                        var temp141 = (((ushort)(temp140 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                        var temp142 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                        var temp143 = (((temp139) && (temp141)) && (temp142));
                        var temp144 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                        var temp145 = ((byte)(((ushort)(i)) >> 11));
                        var temp146 = (((byte)(temp145 & 31L)) == ((byte)((byte)0U & 31L)));
                        var temp147 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                        var temp148 = (((temp144) && (temp146)) && (temp147));
                        var temp149 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                        var temp150 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                        var temp151 = (((temp149) && (temp146)) && (temp150));
                        var temp152 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                        var temp153 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                        var temp154 = (((temp152) && (temp146)) && (temp153));
                        var temp155 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                        var temp156 = ((byte)(((ushort)(i)) >> 12));
                        var temp157 = (((byte)(temp156 & 15L)) == ((byte)((byte)0U & 15L)));
                        var temp158 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                        var temp159 = (((temp155) && (temp157)) && (temp158));
                        var temp160 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                        var temp161 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                        var temp162 = (((temp160) && (temp157)) && (temp161));
                        var temp163 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                        var temp164 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                        var temp165 = (((temp163) && (temp157)) && (temp164));
                        var temp166 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                        var temp167 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                        var temp168 = (((temp166) && (temp157)) && (temp167));
                        var temp169 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                        var temp170 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                        var temp171 = (((temp169) && (temp157)) && (temp170));
                        var temp172 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                        var temp173 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                        var temp174 = (((temp172) && (temp157)) && (temp173));
                        var temp175 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                        var temp176 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                        var temp177 = (((temp175) && (temp157)) && (temp176));
                        var temp178 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                        var temp179 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                        var temp180 = (((temp178) && (temp157)) && (temp179));
                        var temp181 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                        var temp182 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                        var temp183 = (((temp181) && (temp157)) && (temp182));
                        var temp184 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                        var temp185 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                        var temp186 = (((temp184) && (temp157)) && (temp185));
                        var temp187 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                        var temp188 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                        var temp189 = (((temp187) && (temp157)) && (temp188));
                        var temp190 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                        var temp191 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                        var temp192 = (((temp190) && (temp157)) && (temp191));
                        var temp193 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                        var temp194 = ((byte)(((ushort)(i)) >> 13));
                        var temp195 = (((byte)(temp194 & 7L)) == ((byte)((byte)0U & 7L)));
                        var temp196 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                        var temp197 = (((temp193) && (temp195)) && (temp196));
                        var temp198 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                        var temp199 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                        var temp200 = (((temp198) && (temp195)) && (temp199));
                        var temp201 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                        var temp202 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                        var temp203 = (((temp201) && (temp195)) && (temp202));
                        var temp204 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                        var temp205 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                        var temp206 = (((temp204) && (temp195)) && (temp205));
                        var temp207 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                        var temp208 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                        var temp209 = (((temp207) && (temp195)) && (temp208));
                        var temp210 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                        var temp211 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                        var temp212 = (((temp210) && (temp195)) && (temp211));
                        var temp213 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                        var temp214 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                        var temp215 = (((temp213) && (temp195)) && (temp214));
                        var temp216 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                        var temp217 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                        var temp218 = (((temp216) && (temp195)) && (temp217));
                        var temp219 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                        var temp220 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                        var temp221 = (((temp219) && (temp195)) && (temp220));
                        var temp222 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                        var temp223 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                        var temp224 = (((temp222) && (temp195)) && (temp223));
                        var temp225 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                        var temp226 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                        var temp227 = ((temp225) && (temp226));
                        var temp228 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                        var temp229 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                        var temp230 = ((temp228) && (temp229));
                        var temp231 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                        var temp232 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                        var temp233 = ((temp231) && (temp232));
                        var temp234 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                        var temp235 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                        var temp236 = ((temp234) && (temp235));
                        var temp237 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                        var temp238 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                        var temp239 = ((temp237) && (temp238));
                        var temp240 = (((((((((((((((((((((((((((((((temp143) || (temp148)) || (temp151)) || (temp154)) || (temp159)) || (temp162)) || (temp165)) || (temp168)) || (temp171)) || (temp174)) || (temp177)) || (temp180)) || (temp183)) || (temp186)) || (temp189)) || (temp192)) || (temp197)) || (temp200)) || (temp203)) || (temp206)) || (temp209)) || (temp212)) || (temp215)) || (temp218)) || (temp221)) || (temp224)) || (temp227)) || (temp230)) || (temp233)) || (temp236)) || (temp239));
                        if (temp240)
                        {
                            var temp241 = ((uint)(((uint)((uint)10U)) * ((uint)(s))));
                            var temp242 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                            var temp243 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp241))) + ((uint)(temp242))));
                            s = (uint)(temp243);
                            goto M140;
                        }
                        else
                        {
                            var temp244 = (((ushort)(i)) == ((ushort)((ushort)45U)));
                            if (temp244)
                            {
                                goto M141;
                            }
                            else
                                throw new Exception();
                        }
                    }
                }

                M140:
                {
                    if (!ie.MoveNext())
                        goto F140;
                    i = ie.Current;
                    {
                        var temp245 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp245)
                        {
                            goto M142;
                        }
                        else
                        {
                            var temp246 = (((ushort)(i)) == ((ushort)((ushort)46U)));
                            if (temp246)
                            {
                                goto M143;
                            }
                            else
                            {
                                var temp247 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                                var temp248 = ((ushort)(((ushort)(i)) >> 6));
                                var temp249 = (((ushort)(temp248 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                var temp250 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp251 = (((temp247) && (temp249)) && (temp250));
                                var temp252 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                                var temp253 = ((byte)(((ushort)(i)) >> 11));
                                var temp254 = (((byte)(temp253 & 31L)) == ((byte)((byte)0U & 31L)));
                                var temp255 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                var temp256 = (((temp252) && (temp254)) && (temp255));
                                var temp257 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                                var temp258 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                var temp259 = (((temp257) && (temp254)) && (temp258));
                                var temp260 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                                var temp261 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                var temp262 = (((temp260) && (temp254)) && (temp261));
                                var temp263 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                                var temp264 = ((byte)(((ushort)(i)) >> 12));
                                var temp265 = (((byte)(temp264 & 15L)) == ((byte)((byte)0U & 15L)));
                                var temp266 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                var temp267 = (((temp263) && (temp265)) && (temp266));
                                var temp268 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                                var temp269 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                var temp270 = (((temp268) && (temp265)) && (temp269));
                                var temp271 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                                var temp272 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                var temp273 = (((temp271) && (temp265)) && (temp272));
                                var temp274 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                                var temp275 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                var temp276 = (((temp274) && (temp265)) && (temp275));
                                var temp277 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                                var temp278 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                var temp279 = (((temp277) && (temp265)) && (temp278));
                                var temp280 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                                var temp281 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                var temp282 = (((temp280) && (temp265)) && (temp281));
                                var temp283 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                                var temp284 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                var temp285 = (((temp283) && (temp265)) && (temp284));
                                var temp286 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                                var temp287 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                var temp288 = (((temp286) && (temp265)) && (temp287));
                                var temp289 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                                var temp290 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                var temp291 = (((temp289) && (temp265)) && (temp290));
                                var temp292 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                                var temp293 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                var temp294 = (((temp292) && (temp265)) && (temp293));
                                var temp295 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                                var temp296 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                var temp297 = (((temp295) && (temp265)) && (temp296));
                                var temp298 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                                var temp299 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                var temp300 = (((temp298) && (temp265)) && (temp299));
                                var temp301 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                                var temp302 = ((byte)(((ushort)(i)) >> 13));
                                var temp303 = (((byte)(temp302 & 7L)) == ((byte)((byte)0U & 7L)));
                                var temp304 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                var temp305 = (((temp301) && (temp303)) && (temp304));
                                var temp306 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                                var temp307 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                var temp308 = (((temp306) && (temp303)) && (temp307));
                                var temp309 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                                var temp310 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                var temp311 = (((temp309) && (temp303)) && (temp310));
                                var temp312 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                                var temp313 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                var temp314 = (((temp312) && (temp303)) && (temp313));
                                var temp315 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                                var temp316 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                var temp317 = (((temp315) && (temp303)) && (temp316));
                                var temp318 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                                var temp319 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                var temp320 = (((temp318) && (temp303)) && (temp319));
                                var temp321 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                                var temp322 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                var temp323 = (((temp321) && (temp303)) && (temp322));
                                var temp324 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                                var temp325 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                var temp326 = (((temp324) && (temp303)) && (temp325));
                                var temp327 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                                var temp328 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                var temp329 = (((temp327) && (temp303)) && (temp328));
                                var temp330 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                                var temp331 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                var temp332 = (((temp330) && (temp303)) && (temp331));
                                var temp333 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                                var temp334 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                                var temp335 = ((temp333) && (temp334));
                                var temp336 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                                var temp337 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                                var temp338 = ((temp336) && (temp337));
                                var temp339 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                                var temp340 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                                var temp341 = ((temp339) && (temp340));
                                var temp342 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                                var temp343 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                                var temp344 = ((temp342) && (temp343));
                                var temp345 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                                var temp346 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                                var temp347 = ((temp345) && (temp346));
                                var temp348 = (((((((((((((((((((((((((((((((temp251) || (temp256)) || (temp259)) || (temp262)) || (temp267)) || (temp270)) || (temp273)) || (temp276)) || (temp279)) || (temp282)) || (temp285)) || (temp288)) || (temp291)) || (temp294)) || (temp297)) || (temp300)) || (temp305)) || (temp308)) || (temp311)) || (temp314)) || (temp317)) || (temp320)) || (temp323)) || (temp326)) || (temp329)) || (temp332)) || (temp335)) || (temp338)) || (temp341)) || (temp344)) || (temp347));
                                if (temp348)
                                {
                                    var temp349 = ((uint)(((uint)((uint)10U)) * ((uint)(s))));
                                    var temp350 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                                    var temp351 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp349))) + ((uint)(temp350))));
                                    s = (uint)(temp351);
                                    goto M140;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                    }
                }

                M141:
                {
                    if (!ie.MoveNext())
                        goto F141;
                    i = ie.Current;
                    {
                        var temp352 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                        var temp353 = ((ushort)(((ushort)(i)) >> 6));
                        var temp354 = (((ushort)(temp353 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                        var temp355 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                        var temp356 = (((temp352) && (temp354)) && (temp355));
                        var temp357 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                        var temp358 = ((byte)(((ushort)(i)) >> 11));
                        var temp359 = (((byte)(temp358 & 31L)) == ((byte)((byte)0U & 31L)));
                        var temp360 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                        var temp361 = (((temp357) && (temp359)) && (temp360));
                        var temp362 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                        var temp363 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                        var temp364 = (((temp362) && (temp359)) && (temp363));
                        var temp365 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                        var temp366 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                        var temp367 = (((temp365) && (temp359)) && (temp366));
                        var temp368 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                        var temp369 = ((byte)(((ushort)(i)) >> 12));
                        var temp370 = (((byte)(temp369 & 15L)) == ((byte)((byte)0U & 15L)));
                        var temp371 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                        var temp372 = (((temp368) && (temp370)) && (temp371));
                        var temp373 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                        var temp374 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                        var temp375 = (((temp373) && (temp370)) && (temp374));
                        var temp376 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                        var temp377 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                        var temp378 = (((temp376) && (temp370)) && (temp377));
                        var temp379 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                        var temp380 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                        var temp381 = (((temp379) && (temp370)) && (temp380));
                        var temp382 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                        var temp383 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                        var temp384 = (((temp382) && (temp370)) && (temp383));
                        var temp385 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                        var temp386 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                        var temp387 = (((temp385) && (temp370)) && (temp386));
                        var temp388 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                        var temp389 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                        var temp390 = (((temp388) && (temp370)) && (temp389));
                        var temp391 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                        var temp392 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                        var temp393 = (((temp391) && (temp370)) && (temp392));
                        var temp394 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                        var temp395 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                        var temp396 = (((temp394) && (temp370)) && (temp395));
                        var temp397 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                        var temp398 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                        var temp399 = (((temp397) && (temp370)) && (temp398));
                        var temp400 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                        var temp401 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                        var temp402 = (((temp400) && (temp370)) && (temp401));
                        var temp403 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                        var temp404 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                        var temp405 = (((temp403) && (temp370)) && (temp404));
                        var temp406 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                        var temp407 = ((byte)(((ushort)(i)) >> 13));
                        var temp408 = (((byte)(temp407 & 7L)) == ((byte)((byte)0U & 7L)));
                        var temp409 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                        var temp410 = (((temp406) && (temp408)) && (temp409));
                        var temp411 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                        var temp412 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                        var temp413 = (((temp411) && (temp408)) && (temp412));
                        var temp414 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                        var temp415 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                        var temp416 = (((temp414) && (temp408)) && (temp415));
                        var temp417 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                        var temp418 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                        var temp419 = (((temp417) && (temp408)) && (temp418));
                        var temp420 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                        var temp421 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                        var temp422 = (((temp420) && (temp408)) && (temp421));
                        var temp423 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                        var temp424 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                        var temp425 = (((temp423) && (temp408)) && (temp424));
                        var temp426 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                        var temp427 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                        var temp428 = (((temp426) && (temp408)) && (temp427));
                        var temp429 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                        var temp430 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                        var temp431 = (((temp429) && (temp408)) && (temp430));
                        var temp432 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                        var temp433 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                        var temp434 = (((temp432) && (temp408)) && (temp433));
                        var temp435 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                        var temp436 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                        var temp437 = (((temp435) && (temp408)) && (temp436));
                        var temp438 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                        var temp439 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                        var temp440 = ((temp438) && (temp439));
                        var temp441 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                        var temp442 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                        var temp443 = ((temp441) && (temp442));
                        var temp444 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                        var temp445 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                        var temp446 = ((temp444) && (temp445));
                        var temp447 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                        var temp448 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                        var temp449 = ((temp447) && (temp448));
                        var temp450 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                        var temp451 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                        var temp452 = ((temp450) && (temp451));
                        var temp453 = (((((((((((((((((((((((((((((((temp356) || (temp361)) || (temp364)) || (temp367)) || (temp372)) || (temp375)) || (temp378)) || (temp381)) || (temp384)) || (temp387)) || (temp390)) || (temp393)) || (temp396)) || (temp399)) || (temp402)) || (temp405)) || (temp410)) || (temp413)) || (temp416)) || (temp419)) || (temp422)) || (temp425)) || (temp428)) || (temp431)) || (temp434)) || (temp437)) || (temp440)) || (temp443)) || (temp446)) || (temp449)) || (temp452));
                        if (temp453)
                        {
                            var temp454 = ((uint)(((uint)((uint)10U)) * ((uint)(s))));
                            var temp455 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                            var temp456 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp454))) + ((uint)(temp455))));
                            s = (uint)(temp456);
                            goto M140;
                        }
                        else
                            throw new Exception();
                    }
                }

                M142:
                {
                    if (!ie.MoveNext())
                        goto F142;
                    i = ie.Current;
                    {
                        var temp457 = (((ushort)(i)) == ((ushort)((ushort)10U)));
                        if (temp457)
                        {
                            yield return (Int32)(s);
                            s = (uint)((uint)0U);
                            goto M0;
                        }
                        else
                        {
                            goto M142;
                        }
                    }
                }

                M143:
                {
                    if (!ie.MoveNext())
                        goto F143;
                    i = ie.Current;
                    {
                        var temp458 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                        var temp459 = ((ushort)(((ushort)(i)) >> 6));
                        var temp460 = (((ushort)(temp459 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                        var temp461 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                        var temp462 = (((temp458) && (temp460)) && (temp461));
                        var temp463 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                        var temp464 = ((byte)(((ushort)(i)) >> 11));
                        var temp465 = (((byte)(temp464 & 31L)) == ((byte)((byte)0U & 31L)));
                        var temp466 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                        var temp467 = (((temp463) && (temp465)) && (temp466));
                        var temp468 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                        var temp469 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                        var temp470 = (((temp468) && (temp465)) && (temp469));
                        var temp471 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                        var temp472 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                        var temp473 = (((temp471) && (temp465)) && (temp472));
                        var temp474 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                        var temp475 = ((byte)(((ushort)(i)) >> 12));
                        var temp476 = (((byte)(temp475 & 15L)) == ((byte)((byte)0U & 15L)));
                        var temp477 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                        var temp478 = (((temp474) && (temp476)) && (temp477));
                        var temp479 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                        var temp480 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                        var temp481 = (((temp479) && (temp476)) && (temp480));
                        var temp482 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                        var temp483 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                        var temp484 = (((temp482) && (temp476)) && (temp483));
                        var temp485 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                        var temp486 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                        var temp487 = (((temp485) && (temp476)) && (temp486));
                        var temp488 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                        var temp489 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                        var temp490 = (((temp488) && (temp476)) && (temp489));
                        var temp491 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                        var temp492 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                        var temp493 = (((temp491) && (temp476)) && (temp492));
                        var temp494 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                        var temp495 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                        var temp496 = (((temp494) && (temp476)) && (temp495));
                        var temp497 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                        var temp498 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                        var temp499 = (((temp497) && (temp476)) && (temp498));
                        var temp500 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                        var temp501 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                        var temp502 = (((temp500) && (temp476)) && (temp501));
                        var temp503 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                        var temp504 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                        var temp505 = (((temp503) && (temp476)) && (temp504));
                        var temp506 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                        var temp507 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                        var temp508 = (((temp506) && (temp476)) && (temp507));
                        var temp509 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                        var temp510 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                        var temp511 = (((temp509) && (temp476)) && (temp510));
                        var temp512 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                        var temp513 = ((byte)(((ushort)(i)) >> 13));
                        var temp514 = (((byte)(temp513 & 7L)) == ((byte)((byte)0U & 7L)));
                        var temp515 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                        var temp516 = (((temp512) && (temp514)) && (temp515));
                        var temp517 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                        var temp518 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                        var temp519 = (((temp517) && (temp514)) && (temp518));
                        var temp520 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                        var temp521 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                        var temp522 = (((temp520) && (temp514)) && (temp521));
                        var temp523 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                        var temp524 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                        var temp525 = (((temp523) && (temp514)) && (temp524));
                        var temp526 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                        var temp527 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                        var temp528 = (((temp526) && (temp514)) && (temp527));
                        var temp529 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                        var temp530 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                        var temp531 = (((temp529) && (temp514)) && (temp530));
                        var temp532 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                        var temp533 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                        var temp534 = (((temp532) && (temp514)) && (temp533));
                        var temp535 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                        var temp536 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                        var temp537 = (((temp535) && (temp514)) && (temp536));
                        var temp538 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                        var temp539 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                        var temp540 = (((temp538) && (temp514)) && (temp539));
                        var temp541 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                        var temp542 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                        var temp543 = (((temp541) && (temp514)) && (temp542));
                        var temp544 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                        var temp545 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                        var temp546 = ((temp544) && (temp545));
                        var temp547 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                        var temp548 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                        var temp549 = ((temp547) && (temp548));
                        var temp550 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                        var temp551 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                        var temp552 = ((temp550) && (temp551));
                        var temp553 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                        var temp554 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                        var temp555 = ((temp553) && (temp554));
                        var temp556 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                        var temp557 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                        var temp558 = ((temp556) && (temp557));
                        var temp559 = (((((((((((((((((((((((((((((((temp462) || (temp467)) || (temp470)) || (temp473)) || (temp478)) || (temp481)) || (temp484)) || (temp487)) || (temp490)) || (temp493)) || (temp496)) || (temp499)) || (temp502)) || (temp505)) || (temp508)) || (temp511)) || (temp516)) || (temp519)) || (temp522)) || (temp525)) || (temp528)) || (temp531)) || (temp534)) || (temp537)) || (temp540)) || (temp543)) || (temp546)) || (temp549)) || (temp552)) || (temp555)) || (temp558));
                        if (temp559)
                        {
                            goto M144;
                        }
                        else
                            throw new Exception();
                    }
                }

                M144:
                {
                    if (!ie.MoveNext())
                        goto F144;
                    i = ie.Current;
                    {
                        var temp560 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp560)
                        {
                            goto M142;
                        }
                        else
                        {
                            var temp561 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                            var temp562 = ((ushort)(((ushort)(i)) >> 6));
                            var temp563 = (((ushort)(temp562 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp564 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp565 = (((temp561) && (temp563)) && (temp564));
                            var temp566 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                            var temp567 = ((byte)(((ushort)(i)) >> 11));
                            var temp568 = (((byte)(temp567 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp569 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp570 = (((temp566) && (temp568)) && (temp569));
                            var temp571 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                            var temp572 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp573 = (((temp571) && (temp568)) && (temp572));
                            var temp574 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                            var temp575 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp576 = (((temp574) && (temp568)) && (temp575));
                            var temp577 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                            var temp578 = ((byte)(((ushort)(i)) >> 12));
                            var temp579 = (((byte)(temp578 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp580 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp581 = (((temp577) && (temp579)) && (temp580));
                            var temp582 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                            var temp583 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp584 = (((temp582) && (temp579)) && (temp583));
                            var temp585 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                            var temp586 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp587 = (((temp585) && (temp579)) && (temp586));
                            var temp588 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                            var temp589 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp590 = (((temp588) && (temp579)) && (temp589));
                            var temp591 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                            var temp592 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp593 = (((temp591) && (temp579)) && (temp592));
                            var temp594 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                            var temp595 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp596 = (((temp594) && (temp579)) && (temp595));
                            var temp597 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                            var temp598 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp599 = (((temp597) && (temp579)) && (temp598));
                            var temp600 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                            var temp601 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp602 = (((temp600) && (temp579)) && (temp601));
                            var temp603 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                            var temp604 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp605 = (((temp603) && (temp579)) && (temp604));
                            var temp606 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                            var temp607 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp608 = (((temp606) && (temp579)) && (temp607));
                            var temp609 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                            var temp610 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp611 = (((temp609) && (temp579)) && (temp610));
                            var temp612 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                            var temp613 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp614 = (((temp612) && (temp579)) && (temp613));
                            var temp615 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                            var temp616 = ((byte)(((ushort)(i)) >> 13));
                            var temp617 = (((byte)(temp616 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp618 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp619 = (((temp615) && (temp617)) && (temp618));
                            var temp620 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                            var temp621 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp622 = (((temp620) && (temp617)) && (temp621));
                            var temp623 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                            var temp624 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp625 = (((temp623) && (temp617)) && (temp624));
                            var temp626 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                            var temp627 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp628 = (((temp626) && (temp617)) && (temp627));
                            var temp629 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                            var temp630 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp631 = (((temp629) && (temp617)) && (temp630));
                            var temp632 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                            var temp633 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp634 = (((temp632) && (temp617)) && (temp633));
                            var temp635 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                            var temp636 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp637 = (((temp635) && (temp617)) && (temp636));
                            var temp638 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                            var temp639 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp640 = (((temp638) && (temp617)) && (temp639));
                            var temp641 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                            var temp642 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp643 = (((temp641) && (temp617)) && (temp642));
                            var temp644 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                            var temp645 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp646 = (((temp644) && (temp617)) && (temp645));
                            var temp647 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                            var temp648 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                            var temp649 = ((temp647) && (temp648));
                            var temp650 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                            var temp651 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                            var temp652 = ((temp650) && (temp651));
                            var temp653 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                            var temp654 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                            var temp655 = ((temp653) && (temp654));
                            var temp656 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                            var temp657 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                            var temp658 = ((temp656) && (temp657));
                            var temp659 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                            var temp660 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                            var temp661 = ((temp659) && (temp660));
                            var temp662 = (((((((((((((((((((((((((((((((temp565) || (temp570)) || (temp573)) || (temp576)) || (temp581)) || (temp584)) || (temp587)) || (temp590)) || (temp593)) || (temp596)) || (temp599)) || (temp602)) || (temp605)) || (temp608)) || (temp611)) || (temp614)) || (temp619)) || (temp622)) || (temp625)) || (temp628)) || (temp631)) || (temp634)) || (temp637)) || (temp640)) || (temp643)) || (temp646)) || (temp649)) || (temp652)) || (temp655)) || (temp658)) || (temp661));
                            if (temp662)
                            {
                                goto M144;
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
                F60:
                    throw new Exception();
                F61:
                    throw new Exception();
                F62:
                    throw new Exception();
                F63:
                    throw new Exception();
                F64:
                    throw new Exception();
                F65:
                    throw new Exception();
                F66:
                    throw new Exception();
                F67:
                    throw new Exception();
                F68:
                    throw new Exception();
                F69:
                    throw new Exception();
                F70:
                    throw new Exception();
                F71:
                    throw new Exception();
                F72:
                    throw new Exception();
                F73:
                    throw new Exception();
                F74:
                    throw new Exception();
                F75:
                    throw new Exception();
                F76:
                    throw new Exception();
                F77:
                    throw new Exception();
                F78:
                    throw new Exception();
                F79:
                    throw new Exception();
                F80:
                    throw new Exception();
                F81:
                    throw new Exception();
                F82:
                    throw new Exception();
                F83:
                    throw new Exception();
                F84:
                    throw new Exception();
                F85:
                    throw new Exception();
                F86:
                    throw new Exception();
                F87:
                    throw new Exception();
                F88:
                    throw new Exception();
                F89:
                    throw new Exception();
                F90:
                    throw new Exception();
                F91:
                    throw new Exception();
                F92:
                    throw new Exception();
                F93:
                    throw new Exception();
                F94:
                    throw new Exception();
                F95:
                    throw new Exception();
                F96:
                    throw new Exception();
                F97:
                    throw new Exception();
                F98:
                    throw new Exception();
                F99:
                    throw new Exception();
                F100:
                    throw new Exception();
                F101:
                    throw new Exception();
                F102:
                    throw new Exception();
                F103:
                    throw new Exception();
                F104:
                    throw new Exception();
                F105:
                    throw new Exception();
                F106:
                    throw new Exception();
                F107:
                    throw new Exception();
                F108:
                    throw new Exception();
                F109:
                    throw new Exception();
                F110:
                    throw new Exception();
                F111:
                    throw new Exception();
                F112:
                    throw new Exception();
                F113:
                    throw new Exception();
                F114:
                    throw new Exception();
                F115:
                    throw new Exception();
                F116:
                    throw new Exception();
                F117:
                    throw new Exception();
                F118:
                    throw new Exception();
                F119:
                    throw new Exception();
                F120:
                    throw new Exception();
                F121:
                    throw new Exception();
                F122:
                    throw new Exception();
                F123:
                    throw new Exception();
                F124:
                    throw new Exception();
                F125:
                    throw new Exception();
                F126:
                    throw new Exception();
                F127:
                    throw new Exception();
                F128:
                    throw new Exception();
                F129:
                    throw new Exception();
                F130:
                    throw new Exception();
                F131:
                    throw new Exception();
                F132:
                    throw new Exception();
                F133:
                    throw new Exception();
                F134:
                    throw new Exception();
                F135:
                    throw new Exception();
                F136:
                    throw new Exception();
                F137:
                    throw new Exception();
                F138:
                    throw new Exception();
                F139:
                    throw new Exception();
                F140:
                    throw new Exception();
                F141:
                    throw new Exception();
                F142:
                    throw new Exception();
                F143:
                    throw new Exception();
                F144:
                    throw new Exception();
            }
        }
    }
}