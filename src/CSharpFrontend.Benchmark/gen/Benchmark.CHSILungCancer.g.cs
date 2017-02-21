using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Automata.CSharpFrontend;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class CHSILungCancer : SpecialTransducer
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
                        var temp108 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                        var temp109 = ((ushort)(((ushort)(i)) >> 6));
                        var temp110 = (((ushort)(temp109 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                        var temp111 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                        var temp112 = (((temp108) && (temp110)) && (temp111));
                        var temp113 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                        var temp114 = ((byte)(((ushort)(i)) >> 11));
                        var temp115 = (((byte)(temp114 & 31L)) == ((byte)((byte)0U & 31L)));
                        var temp116 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                        var temp117 = (((temp113) && (temp115)) && (temp116));
                        var temp118 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                        var temp119 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                        var temp120 = (((temp118) && (temp115)) && (temp119));
                        var temp121 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                        var temp122 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                        var temp123 = (((temp121) && (temp115)) && (temp122));
                        var temp124 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                        var temp125 = ((byte)(((ushort)(i)) >> 12));
                        var temp126 = (((byte)(temp125 & 15L)) == ((byte)((byte)0U & 15L)));
                        var temp127 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                        var temp128 = (((temp124) && (temp126)) && (temp127));
                        var temp129 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                        var temp130 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                        var temp131 = (((temp129) && (temp126)) && (temp130));
                        var temp132 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                        var temp133 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                        var temp134 = (((temp132) && (temp126)) && (temp133));
                        var temp135 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                        var temp136 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                        var temp137 = (((temp135) && (temp126)) && (temp136));
                        var temp138 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                        var temp139 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                        var temp140 = (((temp138) && (temp126)) && (temp139));
                        var temp141 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                        var temp142 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                        var temp143 = (((temp141) && (temp126)) && (temp142));
                        var temp144 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                        var temp145 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                        var temp146 = (((temp144) && (temp126)) && (temp145));
                        var temp147 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                        var temp148 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                        var temp149 = (((temp147) && (temp126)) && (temp148));
                        var temp150 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                        var temp151 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                        var temp152 = (((temp150) && (temp126)) && (temp151));
                        var temp153 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                        var temp154 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                        var temp155 = (((temp153) && (temp126)) && (temp154));
                        var temp156 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                        var temp157 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                        var temp158 = (((temp156) && (temp126)) && (temp157));
                        var temp159 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                        var temp160 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                        var temp161 = (((temp159) && (temp126)) && (temp160));
                        var temp162 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                        var temp163 = ((byte)(((ushort)(i)) >> 13));
                        var temp164 = (((byte)(temp163 & 7L)) == ((byte)((byte)0U & 7L)));
                        var temp165 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                        var temp166 = (((temp162) && (temp164)) && (temp165));
                        var temp167 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                        var temp168 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                        var temp169 = (((temp167) && (temp164)) && (temp168));
                        var temp170 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                        var temp171 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                        var temp172 = (((temp170) && (temp164)) && (temp171));
                        var temp173 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                        var temp174 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                        var temp175 = (((temp173) && (temp164)) && (temp174));
                        var temp176 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                        var temp177 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                        var temp178 = (((temp176) && (temp164)) && (temp177));
                        var temp179 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                        var temp180 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                        var temp181 = (((temp179) && (temp164)) && (temp180));
                        var temp182 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                        var temp183 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                        var temp184 = (((temp182) && (temp164)) && (temp183));
                        var temp185 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                        var temp186 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                        var temp187 = (((temp185) && (temp164)) && (temp186));
                        var temp188 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                        var temp189 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                        var temp190 = (((temp188) && (temp164)) && (temp189));
                        var temp191 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                        var temp192 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                        var temp193 = (((temp191) && (temp164)) && (temp192));
                        var temp194 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                        var temp195 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                        var temp196 = ((temp194) && (temp195));
                        var temp197 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                        var temp198 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                        var temp199 = ((temp197) && (temp198));
                        var temp200 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                        var temp201 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                        var temp202 = ((temp200) && (temp201));
                        var temp203 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                        var temp204 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                        var temp205 = ((temp203) && (temp204));
                        var temp206 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                        var temp207 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                        var temp208 = ((temp206) && (temp207));
                        var temp209 = (((((((((((((((((((((((((((((((temp112) || (temp117)) || (temp120)) || (temp123)) || (temp128)) || (temp131)) || (temp134)) || (temp137)) || (temp140)) || (temp143)) || (temp146)) || (temp149)) || (temp152)) || (temp155)) || (temp158)) || (temp161)) || (temp166)) || (temp169)) || (temp172)) || (temp175)) || (temp178)) || (temp181)) || (temp184)) || (temp187)) || (temp190)) || (temp193)) || (temp196)) || (temp199)) || (temp202)) || (temp205)) || (temp208));
                        if (temp209)
                        {
                            var temp210 = ((uint)(((uint)((uint)10U)) * ((uint)(s))));
                            var temp211 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                            var temp212 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp210))) + ((uint)(temp211))));
                            s = (uint)(temp212);
                            goto M109;
                        }
                        else
                        {
                            var temp213 = (((ushort)(i)) == ((ushort)((ushort)45U)));
                            if (temp213)
                            {
                                goto M110;
                            }
                            else
                                throw new Exception();
                        }
                    }
                }

                M109:
                {
                    if (!ie.MoveNext())
                        goto F109;
                    i = ie.Current;
                    {
                        var temp214 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp214)
                        {
                            goto M111;
                        }
                        else
                        {
                            var temp215 = (((ushort)(i)) == ((ushort)((ushort)46U)));
                            if (temp215)
                            {
                                goto M112;
                            }
                            else
                            {
                                var temp216 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                                var temp217 = ((ushort)(((ushort)(i)) >> 6));
                                var temp218 = (((ushort)(temp217 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                                var temp219 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                                var temp220 = (((temp216) && (temp218)) && (temp219));
                                var temp221 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                                var temp222 = ((byte)(((ushort)(i)) >> 11));
                                var temp223 = (((byte)(temp222 & 31L)) == ((byte)((byte)0U & 31L)));
                                var temp224 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                                var temp225 = (((temp221) && (temp223)) && (temp224));
                                var temp226 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                                var temp227 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                                var temp228 = (((temp226) && (temp223)) && (temp227));
                                var temp229 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                                var temp230 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                                var temp231 = (((temp229) && (temp223)) && (temp230));
                                var temp232 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                                var temp233 = ((byte)(((ushort)(i)) >> 12));
                                var temp234 = (((byte)(temp233 & 15L)) == ((byte)((byte)0U & 15L)));
                                var temp235 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                                var temp236 = (((temp232) && (temp234)) && (temp235));
                                var temp237 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                                var temp238 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                                var temp239 = (((temp237) && (temp234)) && (temp238));
                                var temp240 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                                var temp241 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                                var temp242 = (((temp240) && (temp234)) && (temp241));
                                var temp243 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                                var temp244 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                                var temp245 = (((temp243) && (temp234)) && (temp244));
                                var temp246 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                                var temp247 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                                var temp248 = (((temp246) && (temp234)) && (temp247));
                                var temp249 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                                var temp250 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                                var temp251 = (((temp249) && (temp234)) && (temp250));
                                var temp252 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                                var temp253 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                                var temp254 = (((temp252) && (temp234)) && (temp253));
                                var temp255 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                                var temp256 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                                var temp257 = (((temp255) && (temp234)) && (temp256));
                                var temp258 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                                var temp259 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                                var temp260 = (((temp258) && (temp234)) && (temp259));
                                var temp261 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                                var temp262 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                                var temp263 = (((temp261) && (temp234)) && (temp262));
                                var temp264 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                                var temp265 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                                var temp266 = (((temp264) && (temp234)) && (temp265));
                                var temp267 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                                var temp268 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                                var temp269 = (((temp267) && (temp234)) && (temp268));
                                var temp270 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                                var temp271 = ((byte)(((ushort)(i)) >> 13));
                                var temp272 = (((byte)(temp271 & 7L)) == ((byte)((byte)0U & 7L)));
                                var temp273 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                                var temp274 = (((temp270) && (temp272)) && (temp273));
                                var temp275 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                                var temp276 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                                var temp277 = (((temp275) && (temp272)) && (temp276));
                                var temp278 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                                var temp279 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                                var temp280 = (((temp278) && (temp272)) && (temp279));
                                var temp281 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                                var temp282 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                                var temp283 = (((temp281) && (temp272)) && (temp282));
                                var temp284 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                                var temp285 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                                var temp286 = (((temp284) && (temp272)) && (temp285));
                                var temp287 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                                var temp288 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                                var temp289 = (((temp287) && (temp272)) && (temp288));
                                var temp290 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                                var temp291 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                                var temp292 = (((temp290) && (temp272)) && (temp291));
                                var temp293 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                                var temp294 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                                var temp295 = (((temp293) && (temp272)) && (temp294));
                                var temp296 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                                var temp297 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                                var temp298 = (((temp296) && (temp272)) && (temp297));
                                var temp299 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                                var temp300 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                                var temp301 = (((temp299) && (temp272)) && (temp300));
                                var temp302 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                                var temp303 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                                var temp304 = ((temp302) && (temp303));
                                var temp305 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                                var temp306 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                                var temp307 = ((temp305) && (temp306));
                                var temp308 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                                var temp309 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                                var temp310 = ((temp308) && (temp309));
                                var temp311 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                                var temp312 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                                var temp313 = ((temp311) && (temp312));
                                var temp314 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                                var temp315 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                                var temp316 = ((temp314) && (temp315));
                                var temp317 = (((((((((((((((((((((((((((((((temp220) || (temp225)) || (temp228)) || (temp231)) || (temp236)) || (temp239)) || (temp242)) || (temp245)) || (temp248)) || (temp251)) || (temp254)) || (temp257)) || (temp260)) || (temp263)) || (temp266)) || (temp269)) || (temp274)) || (temp277)) || (temp280)) || (temp283)) || (temp286)) || (temp289)) || (temp292)) || (temp295)) || (temp298)) || (temp301)) || (temp304)) || (temp307)) || (temp310)) || (temp313)) || (temp316));
                                if (temp317)
                                {
                                    var temp318 = ((uint)(((uint)((uint)10U)) * ((uint)(s))));
                                    var temp319 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                                    var temp320 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp318))) + ((uint)(temp319))));
                                    s = (uint)(temp320);
                                    goto M109;
                                }
                                else
                                    throw new Exception();
                            }
                        }
                    }
                }

                M110:
                {
                    if (!ie.MoveNext())
                        goto F110;
                    i = ie.Current;
                    {
                        var temp321 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                        var temp322 = ((ushort)(((ushort)(i)) >> 6));
                        var temp323 = (((ushort)(temp322 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                        var temp324 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                        var temp325 = (((temp321) && (temp323)) && (temp324));
                        var temp326 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                        var temp327 = ((byte)(((ushort)(i)) >> 11));
                        var temp328 = (((byte)(temp327 & 31L)) == ((byte)((byte)0U & 31L)));
                        var temp329 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                        var temp330 = (((temp326) && (temp328)) && (temp329));
                        var temp331 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                        var temp332 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                        var temp333 = (((temp331) && (temp328)) && (temp332));
                        var temp334 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                        var temp335 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                        var temp336 = (((temp334) && (temp328)) && (temp335));
                        var temp337 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                        var temp338 = ((byte)(((ushort)(i)) >> 12));
                        var temp339 = (((byte)(temp338 & 15L)) == ((byte)((byte)0U & 15L)));
                        var temp340 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                        var temp341 = (((temp337) && (temp339)) && (temp340));
                        var temp342 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                        var temp343 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                        var temp344 = (((temp342) && (temp339)) && (temp343));
                        var temp345 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                        var temp346 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                        var temp347 = (((temp345) && (temp339)) && (temp346));
                        var temp348 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                        var temp349 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                        var temp350 = (((temp348) && (temp339)) && (temp349));
                        var temp351 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                        var temp352 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                        var temp353 = (((temp351) && (temp339)) && (temp352));
                        var temp354 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                        var temp355 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                        var temp356 = (((temp354) && (temp339)) && (temp355));
                        var temp357 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                        var temp358 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                        var temp359 = (((temp357) && (temp339)) && (temp358));
                        var temp360 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                        var temp361 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                        var temp362 = (((temp360) && (temp339)) && (temp361));
                        var temp363 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                        var temp364 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                        var temp365 = (((temp363) && (temp339)) && (temp364));
                        var temp366 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                        var temp367 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                        var temp368 = (((temp366) && (temp339)) && (temp367));
                        var temp369 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                        var temp370 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                        var temp371 = (((temp369) && (temp339)) && (temp370));
                        var temp372 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                        var temp373 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                        var temp374 = (((temp372) && (temp339)) && (temp373));
                        var temp375 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                        var temp376 = ((byte)(((ushort)(i)) >> 13));
                        var temp377 = (((byte)(temp376 & 7L)) == ((byte)((byte)0U & 7L)));
                        var temp378 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                        var temp379 = (((temp375) && (temp377)) && (temp378));
                        var temp380 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                        var temp381 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                        var temp382 = (((temp380) && (temp377)) && (temp381));
                        var temp383 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                        var temp384 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                        var temp385 = (((temp383) && (temp377)) && (temp384));
                        var temp386 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                        var temp387 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                        var temp388 = (((temp386) && (temp377)) && (temp387));
                        var temp389 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                        var temp390 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                        var temp391 = (((temp389) && (temp377)) && (temp390));
                        var temp392 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                        var temp393 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                        var temp394 = (((temp392) && (temp377)) && (temp393));
                        var temp395 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                        var temp396 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                        var temp397 = (((temp395) && (temp377)) && (temp396));
                        var temp398 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                        var temp399 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                        var temp400 = (((temp398) && (temp377)) && (temp399));
                        var temp401 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                        var temp402 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                        var temp403 = (((temp401) && (temp377)) && (temp402));
                        var temp404 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                        var temp405 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                        var temp406 = (((temp404) && (temp377)) && (temp405));
                        var temp407 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                        var temp408 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                        var temp409 = ((temp407) && (temp408));
                        var temp410 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                        var temp411 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                        var temp412 = ((temp410) && (temp411));
                        var temp413 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                        var temp414 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                        var temp415 = ((temp413) && (temp414));
                        var temp416 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                        var temp417 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                        var temp418 = ((temp416) && (temp417));
                        var temp419 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                        var temp420 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                        var temp421 = ((temp419) && (temp420));
                        var temp422 = (((((((((((((((((((((((((((((((temp325) || (temp330)) || (temp333)) || (temp336)) || (temp341)) || (temp344)) || (temp347)) || (temp350)) || (temp353)) || (temp356)) || (temp359)) || (temp362)) || (temp365)) || (temp368)) || (temp371)) || (temp374)) || (temp379)) || (temp382)) || (temp385)) || (temp388)) || (temp391)) || (temp394)) || (temp397)) || (temp400)) || (temp403)) || (temp406)) || (temp409)) || (temp412)) || (temp415)) || (temp418)) || (temp421));
                        if (temp422)
                        {
                            var temp423 = ((uint)(((uint)((uint)10U)) * ((uint)(s))));
                            var temp424 = ((uint)((ushort)((ushort)0U)) << 16) | (uint)((ushort)(i));
                            var temp425 = ((uint)((((uint)((uint)4294967248U)) + ((uint)(temp423))) + ((uint)(temp424))));
                            s = (uint)(temp425);
                            goto M109;
                        }
                        else
                            throw new Exception();
                    }
                }

                M111:
                {
                    if (!ie.MoveNext())
                        goto F111;
                    i = ie.Current;
                    {
                        var temp426 = (((ushort)(i)) == ((ushort)((ushort)10U)));
                        if (temp426)
                        {
                            yield return (Int32)(s);
                            s = (uint)((uint)0U);
                            goto M0;
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
                        var temp427 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                        var temp428 = ((ushort)(((ushort)(i)) >> 6));
                        var temp429 = (((ushort)(temp428 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                        var temp430 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                        var temp431 = (((temp427) && (temp429)) && (temp430));
                        var temp432 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                        var temp433 = ((byte)(((ushort)(i)) >> 11));
                        var temp434 = (((byte)(temp433 & 31L)) == ((byte)((byte)0U & 31L)));
                        var temp435 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                        var temp436 = (((temp432) && (temp434)) && (temp435));
                        var temp437 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                        var temp438 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                        var temp439 = (((temp437) && (temp434)) && (temp438));
                        var temp440 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                        var temp441 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                        var temp442 = (((temp440) && (temp434)) && (temp441));
                        var temp443 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                        var temp444 = ((byte)(((ushort)(i)) >> 12));
                        var temp445 = (((byte)(temp444 & 15L)) == ((byte)((byte)0U & 15L)));
                        var temp446 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                        var temp447 = (((temp443) && (temp445)) && (temp446));
                        var temp448 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                        var temp449 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                        var temp450 = (((temp448) && (temp445)) && (temp449));
                        var temp451 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                        var temp452 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                        var temp453 = (((temp451) && (temp445)) && (temp452));
                        var temp454 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                        var temp455 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                        var temp456 = (((temp454) && (temp445)) && (temp455));
                        var temp457 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                        var temp458 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                        var temp459 = (((temp457) && (temp445)) && (temp458));
                        var temp460 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                        var temp461 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                        var temp462 = (((temp460) && (temp445)) && (temp461));
                        var temp463 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                        var temp464 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                        var temp465 = (((temp463) && (temp445)) && (temp464));
                        var temp466 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                        var temp467 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                        var temp468 = (((temp466) && (temp445)) && (temp467));
                        var temp469 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                        var temp470 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                        var temp471 = (((temp469) && (temp445)) && (temp470));
                        var temp472 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                        var temp473 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                        var temp474 = (((temp472) && (temp445)) && (temp473));
                        var temp475 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                        var temp476 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                        var temp477 = (((temp475) && (temp445)) && (temp476));
                        var temp478 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                        var temp479 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                        var temp480 = (((temp478) && (temp445)) && (temp479));
                        var temp481 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                        var temp482 = ((byte)(((ushort)(i)) >> 13));
                        var temp483 = (((byte)(temp482 & 7L)) == ((byte)((byte)0U & 7L)));
                        var temp484 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                        var temp485 = (((temp481) && (temp483)) && (temp484));
                        var temp486 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                        var temp487 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                        var temp488 = (((temp486) && (temp483)) && (temp487));
                        var temp489 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                        var temp490 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                        var temp491 = (((temp489) && (temp483)) && (temp490));
                        var temp492 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                        var temp493 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                        var temp494 = (((temp492) && (temp483)) && (temp493));
                        var temp495 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                        var temp496 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                        var temp497 = (((temp495) && (temp483)) && (temp496));
                        var temp498 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                        var temp499 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                        var temp500 = (((temp498) && (temp483)) && (temp499));
                        var temp501 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                        var temp502 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                        var temp503 = (((temp501) && (temp483)) && (temp502));
                        var temp504 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                        var temp505 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                        var temp506 = (((temp504) && (temp483)) && (temp505));
                        var temp507 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                        var temp508 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                        var temp509 = (((temp507) && (temp483)) && (temp508));
                        var temp510 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                        var temp511 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                        var temp512 = (((temp510) && (temp483)) && (temp511));
                        var temp513 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                        var temp514 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                        var temp515 = ((temp513) && (temp514));
                        var temp516 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                        var temp517 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                        var temp518 = ((temp516) && (temp517));
                        var temp519 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                        var temp520 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                        var temp521 = ((temp519) && (temp520));
                        var temp522 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                        var temp523 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                        var temp524 = ((temp522) && (temp523));
                        var temp525 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                        var temp526 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                        var temp527 = ((temp525) && (temp526));
                        var temp528 = (((((((((((((((((((((((((((((((temp431) || (temp436)) || (temp439)) || (temp442)) || (temp447)) || (temp450)) || (temp453)) || (temp456)) || (temp459)) || (temp462)) || (temp465)) || (temp468)) || (temp471)) || (temp474)) || (temp477)) || (temp480)) || (temp485)) || (temp488)) || (temp491)) || (temp494)) || (temp497)) || (temp500)) || (temp503)) || (temp506)) || (temp509)) || (temp512)) || (temp515)) || (temp518)) || (temp521)) || (temp524)) || (temp527));
                        if (temp528)
                        {
                            goto M113;
                        }
                        else
                            throw new Exception();
                    }
                }

                M113:
                {
                    if (!ie.MoveNext())
                        goto F113;
                    i = ie.Current;
                    {
                        var temp529 = (((ushort)(i)) == ((ushort)((ushort)44U)));
                        if (temp529)
                        {
                            goto M111;
                        }
                        else
                        {
                            var temp530 = (((ushort)((ushort)48U)) <= ((ushort)(i)));
                            var temp531 = ((ushort)(((ushort)(i)) >> 6));
                            var temp532 = (((ushort)(temp531 & 1023L)) == ((ushort)((ushort)0U & 1023L)));
                            var temp533 = (((byte)(((byte)((ushort)(i))) & 63L)) <= ((byte)((byte)57U & 63L)));
                            var temp534 = (((temp530) && (temp532)) && (temp533));
                            var temp535 = (((ushort)((ushort)1632U)) <= ((ushort)(i)));
                            var temp536 = ((byte)(((ushort)(i)) >> 11));
                            var temp537 = (((byte)(temp536 & 31L)) == ((byte)((byte)0U & 31L)));
                            var temp538 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1641U & 2047L)));
                            var temp539 = (((temp535) && (temp537)) && (temp538));
                            var temp540 = (((ushort)((ushort)1776U)) <= ((ushort)(i)));
                            var temp541 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1785U & 2047L)));
                            var temp542 = (((temp540) && (temp537)) && (temp541));
                            var temp543 = (((ushort)((ushort)1984U)) <= ((ushort)(i)));
                            var temp544 = (((ushort)(((ushort)((ushort)(i))) & 2047L)) <= ((ushort)((ushort)1993U & 2047L)));
                            var temp545 = (((temp543) && (temp537)) && (temp544));
                            var temp546 = (((ushort)((ushort)2406U)) <= ((ushort)(i)));
                            var temp547 = ((byte)(((ushort)(i)) >> 12));
                            var temp548 = (((byte)(temp547 & 15L)) == ((byte)((byte)0U & 15L)));
                            var temp549 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2415U & 4095L)));
                            var temp550 = (((temp546) && (temp548)) && (temp549));
                            var temp551 = (((ushort)((ushort)2534U)) <= ((ushort)(i)));
                            var temp552 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2543U & 4095L)));
                            var temp553 = (((temp551) && (temp548)) && (temp552));
                            var temp554 = (((ushort)((ushort)2662U)) <= ((ushort)(i)));
                            var temp555 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2671U & 4095L)));
                            var temp556 = (((temp554) && (temp548)) && (temp555));
                            var temp557 = (((ushort)((ushort)2790U)) <= ((ushort)(i)));
                            var temp558 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2799U & 4095L)));
                            var temp559 = (((temp557) && (temp548)) && (temp558));
                            var temp560 = (((ushort)((ushort)2918U)) <= ((ushort)(i)));
                            var temp561 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)2927U & 4095L)));
                            var temp562 = (((temp560) && (temp548)) && (temp561));
                            var temp563 = (((ushort)((ushort)3046U)) <= ((ushort)(i)));
                            var temp564 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3055U & 4095L)));
                            var temp565 = (((temp563) && (temp548)) && (temp564));
                            var temp566 = (((ushort)((ushort)3174U)) <= ((ushort)(i)));
                            var temp567 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3183U & 4095L)));
                            var temp568 = (((temp566) && (temp548)) && (temp567));
                            var temp569 = (((ushort)((ushort)3302U)) <= ((ushort)(i)));
                            var temp570 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3311U & 4095L)));
                            var temp571 = (((temp569) && (temp548)) && (temp570));
                            var temp572 = (((ushort)((ushort)3430U)) <= ((ushort)(i)));
                            var temp573 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3439U & 4095L)));
                            var temp574 = (((temp572) && (temp548)) && (temp573));
                            var temp575 = (((ushort)((ushort)3664U)) <= ((ushort)(i)));
                            var temp576 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3673U & 4095L)));
                            var temp577 = (((temp575) && (temp548)) && (temp576));
                            var temp578 = (((ushort)((ushort)3792U)) <= ((ushort)(i)));
                            var temp579 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3801U & 4095L)));
                            var temp580 = (((temp578) && (temp548)) && (temp579));
                            var temp581 = (((ushort)((ushort)3872U)) <= ((ushort)(i)));
                            var temp582 = (((ushort)(((ushort)((ushort)(i))) & 4095L)) <= ((ushort)((ushort)3881U & 4095L)));
                            var temp583 = (((temp581) && (temp548)) && (temp582));
                            var temp584 = (((ushort)((ushort)4160U)) <= ((ushort)(i)));
                            var temp585 = ((byte)(((ushort)(i)) >> 13));
                            var temp586 = (((byte)(temp585 & 7L)) == ((byte)((byte)0U & 7L)));
                            var temp587 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4169U & 8191L)));
                            var temp588 = (((temp584) && (temp586)) && (temp587));
                            var temp589 = (((ushort)((ushort)4240U)) <= ((ushort)(i)));
                            var temp590 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)4249U & 8191L)));
                            var temp591 = (((temp589) && (temp586)) && (temp590));
                            var temp592 = (((ushort)((ushort)6112U)) <= ((ushort)(i)));
                            var temp593 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6121U & 8191L)));
                            var temp594 = (((temp592) && (temp586)) && (temp593));
                            var temp595 = (((ushort)((ushort)6160U)) <= ((ushort)(i)));
                            var temp596 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6169U & 8191L)));
                            var temp597 = (((temp595) && (temp586)) && (temp596));
                            var temp598 = (((ushort)((ushort)6470U)) <= ((ushort)(i)));
                            var temp599 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6479U & 8191L)));
                            var temp600 = (((temp598) && (temp586)) && (temp599));
                            var temp601 = (((ushort)((ushort)6608U)) <= ((ushort)(i)));
                            var temp602 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)6617U & 8191L)));
                            var temp603 = (((temp601) && (temp586)) && (temp602));
                            var temp604 = (((ushort)((ushort)6992U)) <= ((ushort)(i)));
                            var temp605 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7001U & 8191L)));
                            var temp606 = (((temp604) && (temp586)) && (temp605));
                            var temp607 = (((ushort)((ushort)7088U)) <= ((ushort)(i)));
                            var temp608 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7097U & 8191L)));
                            var temp609 = (((temp607) && (temp586)) && (temp608));
                            var temp610 = (((ushort)((ushort)7232U)) <= ((ushort)(i)));
                            var temp611 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7241U & 8191L)));
                            var temp612 = (((temp610) && (temp586)) && (temp611));
                            var temp613 = (((ushort)((ushort)7248U)) <= ((ushort)(i)));
                            var temp614 = (((ushort)(((ushort)((ushort)(i))) & 8191L)) <= ((ushort)((ushort)7257U & 8191L)));
                            var temp615 = (((temp613) && (temp586)) && (temp614));
                            var temp616 = (((ushort)((ushort)42528U)) <= ((ushort)(i)));
                            var temp617 = (((ushort)(i)) <= ((ushort)((ushort)42537U)));
                            var temp618 = ((temp616) && (temp617));
                            var temp619 = (((ushort)((ushort)43216U)) <= ((ushort)(i)));
                            var temp620 = (((ushort)(i)) <= ((ushort)((ushort)43225U)));
                            var temp621 = ((temp619) && (temp620));
                            var temp622 = (((ushort)((ushort)43264U)) <= ((ushort)(i)));
                            var temp623 = (((ushort)(i)) <= ((ushort)((ushort)43273U)));
                            var temp624 = ((temp622) && (temp623));
                            var temp625 = (((ushort)((ushort)43600U)) <= ((ushort)(i)));
                            var temp626 = (((ushort)(i)) <= ((ushort)((ushort)43609U)));
                            var temp627 = ((temp625) && (temp626));
                            var temp628 = (((ushort)((ushort)65296U)) <= ((ushort)(i)));
                            var temp629 = (((ushort)(i)) <= ((ushort)((ushort)65305U)));
                            var temp630 = ((temp628) && (temp629));
                            var temp631 = (((((((((((((((((((((((((((((((temp534) || (temp539)) || (temp542)) || (temp545)) || (temp550)) || (temp553)) || (temp556)) || (temp559)) || (temp562)) || (temp565)) || (temp568)) || (temp571)) || (temp574)) || (temp577)) || (temp580)) || (temp583)) || (temp588)) || (temp591)) || (temp594)) || (temp597)) || (temp600)) || (temp603)) || (temp606)) || (temp609)) || (temp612)) || (temp615)) || (temp618)) || (temp621)) || (temp624)) || (temp627)) || (temp630));
                            if (temp631)
                            {
                                goto M113;
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
            }
        }
    }
}