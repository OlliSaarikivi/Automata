using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class CHSITotalBirths : SpecialTransducer
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
                        var temp138 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                        var temp139 = ((ushort)(((ushort)(i)) >> 6));
                        var temp140 = (((ushort)(temp139 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                        var temp141 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                        var temp142 = (((temp138) && (temp140)) && (temp141));
                        var temp143 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                        var temp144 = ((byte)(((ushort)(i)) >> 11));
                        var temp145 = (((byte)(temp144 & 31L)) == ((byte)((byte)0U & 31L)));
                        var temp146 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                        var temp147 = (((temp143) && (temp145)) && (temp146));
                        var temp148 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                        var temp149 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                        var temp150 = (((temp148) && (temp145)) && (temp149));
                        var temp151 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                        var temp152 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                        var temp153 = (((temp151) && (temp145)) && (temp152));
                        var temp154 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                        var temp155 = ((byte)(((ushort)(i)) >> 12));
                        var temp156 = (((byte)(temp155 & 15L)) == ((byte)((byte)0U & 15L)));
                        var temp157 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                        var temp158 = (((temp154) && (temp156)) && (temp157));
                        var temp159 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                        var temp160 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                        var temp161 = (((temp159) && (temp156)) && (temp160));
                        var temp162 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                        var temp163 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                        var temp164 = (((temp162) && (temp156)) && (temp163));
                        var temp165 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                        var temp166 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                        var temp167 = (((temp165) && (temp156)) && (temp166));
                        var temp168 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                        var temp169 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                        var temp170 = (((temp168) && (temp156)) && (temp169));
                        var temp171 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                        var temp172 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                        var temp173 = (((temp171) && (temp156)) && (temp172));
                        var temp174 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                        var temp175 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                        var temp176 = (((temp174) && (temp156)) && (temp175));
                        var temp177 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                        var temp178 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                        var temp179 = (((temp177) && (temp156)) && (temp178));
                        var temp180 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                        var temp181 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                        var temp182 = (((temp180) && (temp156)) && (temp181));
                        var temp183 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                        var temp184 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                        var temp185 = (((temp183) && (temp156)) && (temp184));
                        var temp186 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                        var temp187 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                        var temp188 = (((temp186) && (temp156)) && (temp187));
                        var temp189 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                        var temp190 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                        var temp191 = (((temp189) && (temp156)) && (temp190));
                        var temp192 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                        var temp193 = ((byte)(((ushort)(i)) >> 13));
                        var temp194 = (((byte)(temp193 & 7L)) == ((byte)((byte)0U & 7L)));
                        var temp195 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                        var temp196 = (((temp192) && (temp194)) && (temp195));
                        var temp197 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                        var temp198 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                        var temp199 = (((temp197) && (temp194)) && (temp198));
                        var temp200 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                        var temp201 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                        var temp202 = (((temp200) && (temp194)) && (temp201));
                        var temp203 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                        var temp204 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                        var temp205 = (((temp203) && (temp194)) && (temp204));
                        var temp206 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                        var temp207 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                        var temp208 = (((temp206) && (temp194)) && (temp207));
                        var temp209 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                        var temp210 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                        var temp211 = (((temp209) && (temp194)) && (temp210));
                        var temp212 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                        var temp213 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                        var temp214 = (((temp212) && (temp194)) && (temp213));
                        var temp215 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                        var temp216 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                        var temp217 = (((temp215) && (temp194)) && (temp216));
                        var temp218 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                        var temp219 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                        var temp220 = (((temp218) && (temp194)) && (temp219));
                        var temp221 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                        var temp222 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                        var temp223 = (((temp221) && (temp194)) && (temp222));
                        var temp224 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                        var temp225 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                        var temp226 = ((temp224) && (temp225));
                        var temp227 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                        var temp228 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                        var temp229 = ((temp227) && (temp228));
                        var temp230 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                        var temp231 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                        var temp232 = ((temp230) && (temp231));
                        var temp233 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                        var temp234 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                        var temp235 = ((temp233) && (temp234));
                        var temp236 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                        var temp237 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                        var temp238 = ((temp236) && (temp237));
                        var temp239 = (((((((((((((((((((((((((((((((temp142) || (temp147)) || (temp150)) || (temp153)) || (temp158)) || (temp161)) || (temp164)) || (temp167)) || (temp170)) || (temp173)) || (temp176)) || (temp179)) || (temp182)) || (temp185)) || (temp188)) || (temp191)) || (temp196)) || (temp199)) || (temp202)) || (temp205)) || (temp208)) || (temp211)) || (temp214)) || (temp217)) || (temp220)) || (temp223)) || (temp226)) || (temp229)) || (temp232)) || (temp235)) || (temp238));
                        if (temp239)
                        {
                            var temp240 = ((uint)(((uint)((uint)10U)) * ((uint)(s))));
                            var temp241 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                            var temp242 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp240))) + ((uint)(temp241))));
                            s = (uint)(temp242);
                            goto M139;
                        }
                        else
                        {
                            var temp243 = (((ushort)(i)) == ((ushort)((ushort)45U)));
                            if (temp243)
                            {
                                goto M140;
                            }
                            else
                                throw new Exception();
                        }
                    }
                }

                M139:
                {
                    if (!ie.MoveNext())
                        goto F139;
                    i = ie.Current;
                    {
                        var temp244 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp244)
                        {
                            goto M141;
                        }
                        else
                        {
                            var temp245 = (((ushort)(i)) == ((ushort)((ushort)46U)));
                            if (temp245)
                            {
                                goto M142;
                            }
                            else
                            {
                                var temp246 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                                var temp247 = ((ushort)(((ushort)(i)) >> 6));
                                var temp248 = (((ushort)(temp247 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                var temp249 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp250 = (((temp246) && (temp248)) && (temp249));
                                var temp251 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                                var temp252 = ((byte)(((ushort)(i)) >> 11));
                                var temp253 = (((byte)(temp252 & 31L)) == ((byte)((byte)0U & 31L)));
                                var temp254 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                var temp255 = (((temp251) && (temp253)) && (temp254));
                                var temp256 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                                var temp257 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                var temp258 = (((temp256) && (temp253)) && (temp257));
                                var temp259 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                                var temp260 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                var temp261 = (((temp259) && (temp253)) && (temp260));
                                var temp262 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                                var temp263 = ((byte)(((ushort)(i)) >> 12));
                                var temp264 = (((byte)(temp263 & 15L)) == ((byte)((byte)0U & 15L)));
                                var temp265 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                var temp266 = (((temp262) && (temp264)) && (temp265));
                                var temp267 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                                var temp268 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                var temp269 = (((temp267) && (temp264)) && (temp268));
                                var temp270 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                                var temp271 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                var temp272 = (((temp270) && (temp264)) && (temp271));
                                var temp273 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                                var temp274 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                var temp275 = (((temp273) && (temp264)) && (temp274));
                                var temp276 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                                var temp277 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                var temp278 = (((temp276) && (temp264)) && (temp277));
                                var temp279 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                                var temp280 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                var temp281 = (((temp279) && (temp264)) && (temp280));
                                var temp282 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                                var temp283 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                var temp284 = (((temp282) && (temp264)) && (temp283));
                                var temp285 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                                var temp286 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                var temp287 = (((temp285) && (temp264)) && (temp286));
                                var temp288 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                                var temp289 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                var temp290 = (((temp288) && (temp264)) && (temp289));
                                var temp291 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                                var temp292 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                var temp293 = (((temp291) && (temp264)) && (temp292));
                                var temp294 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                                var temp295 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                var temp296 = (((temp294) && (temp264)) && (temp295));
                                var temp297 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                                var temp298 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                var temp299 = (((temp297) && (temp264)) && (temp298));
                                var temp300 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                                var temp301 = ((byte)(((ushort)(i)) >> 13));
                                var temp302 = (((byte)(temp301 & 7L)) == ((byte)((byte)0U & 7L)));
                                var temp303 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                var temp304 = (((temp300) && (temp302)) && (temp303));
                                var temp305 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                                var temp306 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                var temp307 = (((temp305) && (temp302)) && (temp306));
                                var temp308 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                                var temp309 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                var temp310 = (((temp308) && (temp302)) && (temp309));
                                var temp311 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                                var temp312 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                var temp313 = (((temp311) && (temp302)) && (temp312));
                                var temp314 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                                var temp315 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                var temp316 = (((temp314) && (temp302)) && (temp315));
                                var temp317 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                                var temp318 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                var temp319 = (((temp317) && (temp302)) && (temp318));
                                var temp320 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                                var temp321 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                var temp322 = (((temp320) && (temp302)) && (temp321));
                                var temp323 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                                var temp324 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                var temp325 = (((temp323) && (temp302)) && (temp324));
                                var temp326 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                                var temp327 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                var temp328 = (((temp326) && (temp302)) && (temp327));
                                var temp329 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                                var temp330 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                var temp331 = (((temp329) && (temp302)) && (temp330));
                                var temp332 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                                var temp333 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                                var temp334 = ((temp332) && (temp333));
                                var temp335 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                                var temp336 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                                var temp337 = ((temp335) && (temp336));
                                var temp338 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                                var temp339 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                                var temp340 = ((temp338) && (temp339));
                                var temp341 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                                var temp342 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                                var temp343 = ((temp341) && (temp342));
                                var temp344 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                                var temp345 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                                var temp346 = ((temp344) && (temp345));
                                var temp347 = (((((((((((((((((((((((((((((((temp250) || (temp255)) || (temp258)) || (temp261)) || (temp266)) || (temp269)) || (temp272)) || (temp275)) || (temp278)) || (temp281)) || (temp284)) || (temp287)) || (temp290)) || (temp293)) || (temp296)) || (temp299)) || (temp304)) || (temp307)) || (temp310)) || (temp313)) || (temp316)) || (temp319)) || (temp322)) || (temp325)) || (temp328)) || (temp331)) || (temp334)) || (temp337)) || (temp340)) || (temp343)) || (temp346));
                                if (temp347)
                                {
                                    var temp348 = ((uint)(((uint)((uint)10U)) * ((uint)(s))));
                                    var temp349 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                                    var temp350 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp348))) + ((uint)(temp349))));
                                    s = (uint)(temp350);
                                    goto M139;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                    }
                }

                M140:
                {
                    if (!ie.MoveNext())
                        goto F140;
                    i = ie.Current;
                    {
                        var temp351 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                        var temp352 = ((ushort)(((ushort)(i)) >> 6));
                        var temp353 = (((ushort)(temp352 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                        var temp354 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                        var temp355 = (((temp351) && (temp353)) && (temp354));
                        var temp356 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                        var temp357 = ((byte)(((ushort)(i)) >> 11));
                        var temp358 = (((byte)(temp357 & 31L)) == ((byte)((byte)0U & 31L)));
                        var temp359 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                        var temp360 = (((temp356) && (temp358)) && (temp359));
                        var temp361 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                        var temp362 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                        var temp363 = (((temp361) && (temp358)) && (temp362));
                        var temp364 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                        var temp365 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                        var temp366 = (((temp364) && (temp358)) && (temp365));
                        var temp367 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                        var temp368 = ((byte)(((ushort)(i)) >> 12));
                        var temp369 = (((byte)(temp368 & 15L)) == ((byte)((byte)0U & 15L)));
                        var temp370 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                        var temp371 = (((temp367) && (temp369)) && (temp370));
                        var temp372 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                        var temp373 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                        var temp374 = (((temp372) && (temp369)) && (temp373));
                        var temp375 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                        var temp376 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                        var temp377 = (((temp375) && (temp369)) && (temp376));
                        var temp378 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                        var temp379 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                        var temp380 = (((temp378) && (temp369)) && (temp379));
                        var temp381 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                        var temp382 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                        var temp383 = (((temp381) && (temp369)) && (temp382));
                        var temp384 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                        var temp385 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                        var temp386 = (((temp384) && (temp369)) && (temp385));
                        var temp387 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                        var temp388 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                        var temp389 = (((temp387) && (temp369)) && (temp388));
                        var temp390 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                        var temp391 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                        var temp392 = (((temp390) && (temp369)) && (temp391));
                        var temp393 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                        var temp394 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                        var temp395 = (((temp393) && (temp369)) && (temp394));
                        var temp396 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                        var temp397 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                        var temp398 = (((temp396) && (temp369)) && (temp397));
                        var temp399 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                        var temp400 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                        var temp401 = (((temp399) && (temp369)) && (temp400));
                        var temp402 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                        var temp403 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                        var temp404 = (((temp402) && (temp369)) && (temp403));
                        var temp405 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                        var temp406 = ((byte)(((ushort)(i)) >> 13));
                        var temp407 = (((byte)(temp406 & 7L)) == ((byte)((byte)0U & 7L)));
                        var temp408 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                        var temp409 = (((temp405) && (temp407)) && (temp408));
                        var temp410 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                        var temp411 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                        var temp412 = (((temp410) && (temp407)) && (temp411));
                        var temp413 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                        var temp414 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                        var temp415 = (((temp413) && (temp407)) && (temp414));
                        var temp416 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                        var temp417 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                        var temp418 = (((temp416) && (temp407)) && (temp417));
                        var temp419 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                        var temp420 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                        var temp421 = (((temp419) && (temp407)) && (temp420));
                        var temp422 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                        var temp423 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                        var temp424 = (((temp422) && (temp407)) && (temp423));
                        var temp425 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                        var temp426 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                        var temp427 = (((temp425) && (temp407)) && (temp426));
                        var temp428 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                        var temp429 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                        var temp430 = (((temp428) && (temp407)) && (temp429));
                        var temp431 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                        var temp432 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                        var temp433 = (((temp431) && (temp407)) && (temp432));
                        var temp434 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                        var temp435 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                        var temp436 = (((temp434) && (temp407)) && (temp435));
                        var temp437 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                        var temp438 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                        var temp439 = ((temp437) && (temp438));
                        var temp440 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                        var temp441 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                        var temp442 = ((temp440) && (temp441));
                        var temp443 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                        var temp444 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                        var temp445 = ((temp443) && (temp444));
                        var temp446 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                        var temp447 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                        var temp448 = ((temp446) && (temp447));
                        var temp449 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                        var temp450 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                        var temp451 = ((temp449) && (temp450));
                        var temp452 = (((((((((((((((((((((((((((((((temp355) || (temp360)) || (temp363)) || (temp366)) || (temp371)) || (temp374)) || (temp377)) || (temp380)) || (temp383)) || (temp386)) || (temp389)) || (temp392)) || (temp395)) || (temp398)) || (temp401)) || (temp404)) || (temp409)) || (temp412)) || (temp415)) || (temp418)) || (temp421)) || (temp424)) || (temp427)) || (temp430)) || (temp433)) || (temp436)) || (temp439)) || (temp442)) || (temp445)) || (temp448)) || (temp451));
                        if (temp452)
                        {
                            var temp453 = ((uint)(((uint)((uint)10U)) * ((uint)(s))));
                            var temp454 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                            var temp455 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp453))) + ((uint)(temp454))));
                            s = (uint)(temp455);
                            goto M139;
                        }
                        else
                            throw new Exception();
                    }
                }

                M141:
                {
                    if (!ie.MoveNext())
                        goto F141;
                    i = ie.Current;
                    {
                        var temp456 = (((ushort)(i)) == ((ushort)((ushort)10U)));
                        if (temp456)
                        {
                            yield return (Int32)(s);
                            s = (uint)((uint)0U);
                            goto M0;
                        }
                        else
                        {
                            goto M141;
                        }
                    }
                }

                M142:
                {
                    if (!ie.MoveNext())
                        goto F142;
                    i = ie.Current;
                    {
                        var temp457 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                        var temp458 = ((ushort)(((ushort)(i)) >> 6));
                        var temp459 = (((ushort)(temp458 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                        var temp460 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                        var temp461 = (((temp457) && (temp459)) && (temp460));
                        var temp462 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                        var temp463 = ((byte)(((ushort)(i)) >> 11));
                        var temp464 = (((byte)(temp463 & 31L)) == ((byte)((byte)0U & 31L)));
                        var temp465 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                        var temp466 = (((temp462) && (temp464)) && (temp465));
                        var temp467 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                        var temp468 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                        var temp469 = (((temp467) && (temp464)) && (temp468));
                        var temp470 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                        var temp471 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                        var temp472 = (((temp470) && (temp464)) && (temp471));
                        var temp473 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                        var temp474 = ((byte)(((ushort)(i)) >> 12));
                        var temp475 = (((byte)(temp474 & 15L)) == ((byte)((byte)0U & 15L)));
                        var temp476 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                        var temp477 = (((temp473) && (temp475)) && (temp476));
                        var temp478 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                        var temp479 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                        var temp480 = (((temp478) && (temp475)) && (temp479));
                        var temp481 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                        var temp482 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                        var temp483 = (((temp481) && (temp475)) && (temp482));
                        var temp484 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                        var temp485 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                        var temp486 = (((temp484) && (temp475)) && (temp485));
                        var temp487 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                        var temp488 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                        var temp489 = (((temp487) && (temp475)) && (temp488));
                        var temp490 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                        var temp491 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                        var temp492 = (((temp490) && (temp475)) && (temp491));
                        var temp493 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                        var temp494 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                        var temp495 = (((temp493) && (temp475)) && (temp494));
                        var temp496 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                        var temp497 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                        var temp498 = (((temp496) && (temp475)) && (temp497));
                        var temp499 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                        var temp500 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                        var temp501 = (((temp499) && (temp475)) && (temp500));
                        var temp502 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                        var temp503 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                        var temp504 = (((temp502) && (temp475)) && (temp503));
                        var temp505 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                        var temp506 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                        var temp507 = (((temp505) && (temp475)) && (temp506));
                        var temp508 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                        var temp509 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                        var temp510 = (((temp508) && (temp475)) && (temp509));
                        var temp511 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                        var temp512 = ((byte)(((ushort)(i)) >> 13));
                        var temp513 = (((byte)(temp512 & 7L)) == ((byte)((byte)0U & 7L)));
                        var temp514 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                        var temp515 = (((temp511) && (temp513)) && (temp514));
                        var temp516 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                        var temp517 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                        var temp518 = (((temp516) && (temp513)) && (temp517));
                        var temp519 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                        var temp520 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                        var temp521 = (((temp519) && (temp513)) && (temp520));
                        var temp522 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                        var temp523 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                        var temp524 = (((temp522) && (temp513)) && (temp523));
                        var temp525 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                        var temp526 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                        var temp527 = (((temp525) && (temp513)) && (temp526));
                        var temp528 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                        var temp529 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                        var temp530 = (((temp528) && (temp513)) && (temp529));
                        var temp531 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                        var temp532 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                        var temp533 = (((temp531) && (temp513)) && (temp532));
                        var temp534 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                        var temp535 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                        var temp536 = (((temp534) && (temp513)) && (temp535));
                        var temp537 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                        var temp538 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                        var temp539 = (((temp537) && (temp513)) && (temp538));
                        var temp540 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                        var temp541 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                        var temp542 = (((temp540) && (temp513)) && (temp541));
                        var temp543 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                        var temp544 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                        var temp545 = ((temp543) && (temp544));
                        var temp546 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                        var temp547 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                        var temp548 = ((temp546) && (temp547));
                        var temp549 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                        var temp550 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                        var temp551 = ((temp549) && (temp550));
                        var temp552 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                        var temp553 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                        var temp554 = ((temp552) && (temp553));
                        var temp555 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                        var temp556 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                        var temp557 = ((temp555) && (temp556));
                        var temp558 = (((((((((((((((((((((((((((((((temp461) || (temp466)) || (temp469)) || (temp472)) || (temp477)) || (temp480)) || (temp483)) || (temp486)) || (temp489)) || (temp492)) || (temp495)) || (temp498)) || (temp501)) || (temp504)) || (temp507)) || (temp510)) || (temp515)) || (temp518)) || (temp521)) || (temp524)) || (temp527)) || (temp530)) || (temp533)) || (temp536)) || (temp539)) || (temp542)) || (temp545)) || (temp548)) || (temp551)) || (temp554)) || (temp557));
                        if (temp558)
                        {
                            goto M143;
                        }
                        else
                            throw new Exception();
                    }
                }

                M143:
                {
                    if (!ie.MoveNext())
                        goto F143;
                    i = ie.Current;
                    {
                        var temp559 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp559)
                        {
                            goto M141;
                        }
                        else
                        {
                            var temp560 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                            var temp561 = ((ushort)(((ushort)(i)) >> 6));
                            var temp562 = (((ushort)(temp561 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp563 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp564 = (((temp560) && (temp562)) && (temp563));
                            var temp565 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                            var temp566 = ((byte)(((ushort)(i)) >> 11));
                            var temp567 = (((byte)(temp566 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp568 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp569 = (((temp565) && (temp567)) && (temp568));
                            var temp570 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                            var temp571 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp572 = (((temp570) && (temp567)) && (temp571));
                            var temp573 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                            var temp574 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp575 = (((temp573) && (temp567)) && (temp574));
                            var temp576 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                            var temp577 = ((byte)(((ushort)(i)) >> 12));
                            var temp578 = (((byte)(temp577 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp579 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp580 = (((temp576) && (temp578)) && (temp579));
                            var temp581 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                            var temp582 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp583 = (((temp581) && (temp578)) && (temp582));
                            var temp584 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                            var temp585 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp586 = (((temp584) && (temp578)) && (temp585));
                            var temp587 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                            var temp588 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp589 = (((temp587) && (temp578)) && (temp588));
                            var temp590 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                            var temp591 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp592 = (((temp590) && (temp578)) && (temp591));
                            var temp593 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                            var temp594 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp595 = (((temp593) && (temp578)) && (temp594));
                            var temp596 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                            var temp597 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp598 = (((temp596) && (temp578)) && (temp597));
                            var temp599 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                            var temp600 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp601 = (((temp599) && (temp578)) && (temp600));
                            var temp602 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                            var temp603 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp604 = (((temp602) && (temp578)) && (temp603));
                            var temp605 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                            var temp606 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp607 = (((temp605) && (temp578)) && (temp606));
                            var temp608 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                            var temp609 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp610 = (((temp608) && (temp578)) && (temp609));
                            var temp611 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                            var temp612 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp613 = (((temp611) && (temp578)) && (temp612));
                            var temp614 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                            var temp615 = ((byte)(((ushort)(i)) >> 13));
                            var temp616 = (((byte)(temp615 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp617 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp618 = (((temp614) && (temp616)) && (temp617));
                            var temp619 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                            var temp620 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp621 = (((temp619) && (temp616)) && (temp620));
                            var temp622 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                            var temp623 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp624 = (((temp622) && (temp616)) && (temp623));
                            var temp625 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                            var temp626 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp627 = (((temp625) && (temp616)) && (temp626));
                            var temp628 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                            var temp629 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp630 = (((temp628) && (temp616)) && (temp629));
                            var temp631 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                            var temp632 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp633 = (((temp631) && (temp616)) && (temp632));
                            var temp634 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                            var temp635 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp636 = (((temp634) && (temp616)) && (temp635));
                            var temp637 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                            var temp638 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp639 = (((temp637) && (temp616)) && (temp638));
                            var temp640 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                            var temp641 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp642 = (((temp640) && (temp616)) && (temp641));
                            var temp643 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                            var temp644 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp645 = (((temp643) && (temp616)) && (temp644));
                            var temp646 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                            var temp647 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                            var temp648 = ((temp646) && (temp647));
                            var temp649 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                            var temp650 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                            var temp651 = ((temp649) && (temp650));
                            var temp652 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                            var temp653 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                            var temp654 = ((temp652) && (temp653));
                            var temp655 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                            var temp656 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                            var temp657 = ((temp655) && (temp656));
                            var temp658 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                            var temp659 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                            var temp660 = ((temp658) && (temp659));
                            var temp661 = (((((((((((((((((((((((((((((((temp564) || (temp569)) || (temp572)) || (temp575)) || (temp580)) || (temp583)) || (temp586)) || (temp589)) || (temp592)) || (temp595)) || (temp598)) || (temp601)) || (temp604)) || (temp607)) || (temp610)) || (temp613)) || (temp618)) || (temp621)) || (temp624)) || (temp627)) || (temp630)) || (temp633)) || (temp636)) || (temp639)) || (temp642)) || (temp645)) || (temp648)) || (temp651)) || (temp654)) || (temp657)) || (temp660));
                            if (temp661)
                            {
                                goto M143;
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
            }
        }
    }
}