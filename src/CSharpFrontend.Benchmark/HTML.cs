using Microsoft.Automata.CSharpFrontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    partial class HTMLEncode : Transducer<char, char>
    {
        char CP(char h, char l) { return (char)((((h & 0x3FF) + 0x40) << 10) | (l & 0x3FF)); }
        char D5(char x) { return (char)((((x / 100) / 1000) % 10) + '0'); }
        char D4(char x) { return (char)(((x / 10000) % 10) + '0'); }
        char D3(char x) { return (char)(((x / 1000) % 10) + '0'); }
        char D2(char x) { return (char)(((x / 100) % 10) + '0'); }
        char D1(char x) { return (char)(((x / 10) % 10) + '0'); }
        char D0(char x) { return (char)((x % 10) + '0'); }

        char prev = '\0';

        bool s0 = false;
        bool s1 = false;
        bool s2 = false;

        public override IEnumerable<char> Update(char c)
        {
            if (!s2 & !s1 & !s0) {
                if ((c == '\x20') |
                    (c == '\x21') |
                    ('\x23' <= c & c <= '\x25') |
                    ('\x28' <= c & c <= '\x3B') |
                    (c == '\x3D') |
                    ('\x3F' <= c & c <= '\x7E') |
                    ('\xA1' <= c & c <= '\xAC') |
                    ('\xAE' <= c & c <= '\u036F')) {
                    yield return c;
                }
                else if (c == '<') {
                    yield return '&'; yield return 'l'; yield return 't'; yield return ';';
                }
                else if (c == '>') {
                    yield return '&'; yield return 'g'; yield return 't'; yield return ';';
                }
                else if (c == '&') {
                    yield return '&'; yield return 'a'; yield return 'm'; yield return 'p'; yield return ';';
                }
                else if (c == '\"') {
                    yield return '&'; yield return 'q'; yield return 'u'; yield return 'o'; yield return 't'; yield return ';';
                }
                else if ('\0' <= c & c <= '\x09') {
                    yield return '&'; yield return '#'; yield return D0(c); yield return ';';
                }
                else if ('\x0A' <= c & c <= '\x63') {
                    yield return '&'; yield return '#'; yield return D1(c); yield return D0(c); yield return ';';
                }
                else if ('\x64' <= c & c <= '\u03E7') {
                    yield return '&'; yield return '#'; yield return D2(c); yield return D1(c); yield return D0(c); yield return ';';
                }
                else if ('\u03E8' <= c & c <= '\u270F') {
                    yield return '&'; yield return '#'; yield return D3(c); yield return D2(c); yield return D1(c); yield return D0(c); yield return ';';
                }
                else if (('\u2710' <= c & c <= '\uD7FF') | ('\uE000' <= c & c <= '\uFFFF')) {
                    yield return '&'; yield return '#'; yield return D4(c); yield return D3(c); yield return D2(c); yield return D1(c); yield return D0(c); yield return ';';
                }
                else if ('\uD800' <= c & c <= '\uD820') {
                    prev = c;
                    s2 = false; s1 = false; s0 = true;
                }
                else if (c == '\uD821') {
                    prev = c;
                    s2 = false; s1 = true; s0 = false;
                }
                else if (c == '\uD821') {
                    prev = c;
                    s2 = false; s1 = true; s0 = false;
                }
                else if ('\uD822' <= c & c <= '\uDB8F') {
                    prev = c;
                    s2 = false; s1 = true; s0 = true;
                }
                else if (c == '\uDB90') {
                    prev = c;
                    s2 = true; s1 = false; s0 = false;
                }
                else if (c == '\uDB90') {
                    prev = c;
                    s2 = true; s1 = false; s0 = false;
                }
                else if ('\uDB91' <= c & c <= '\uDBFF') {
                    prev = c;
                    s2 = true; s1 = false; s0 = true;
                }
                else throw new Exception();
            } else if (!s2 & !s1 & s0) {
                s2 = false; s1 = false; s0 = false;
                if ('\uDC00' <= c & c <= '\uDFFF') {
                    yield return '&'; yield return '#'; yield return D4(CP(prev,c)); yield return D3(CP(prev,c)); yield return D2(CP(prev,c)); yield return D1(CP(prev,c)); yield return D0(CP(prev,c)); yield return ';';
                } else throw new Exception();
            } else if (!s2 & s1 & !s0) {
                s2 = false; s1 = false; s0 = false;
                if ('\uDC00' <= c & c <= '\uDE9F') {
                    yield return '&'; yield return '#'; yield return D4(CP(prev,c)); yield return D3(CP(prev,c)); yield return D2(CP(prev,c)); yield return D1(CP(prev,c)); yield return D0(CP(prev,c)); yield return ';';
                } else if ('\uDEA0' <= c & c <= '\uDFFF') {
                    yield return '&'; yield return '#'; yield return '1'; yield return '0'; yield return '0'; yield return D2(CP(prev,c)); yield return D1(CP(prev,c)); yield return D0(CP(prev,c)); yield return ';';
                } else throw new Exception();
            } else if (!s2 & s1 & s0) {
                s2 = false; s1 = false; s0 = false;
                if ('\uDC00' <= c & c <= '\uDFFF') {
                    yield return '&'; yield return '#'; yield return D5(CP(prev,c)); yield return D4(CP(prev,c)); yield return D3(CP(prev,c)); yield return D2(CP(prev,c)); yield return D1(CP(prev,c)); yield return D0(CP(prev,c)); yield return ';';
                } else throw new Exception();
            } else if (s2 & !s1 & !s0) {
                s2 = false; s1 = false; s0 = false;
                if ('\uDC00' <= c & c <= '\uDE3F') {
                    yield return '&'; yield return '#'; yield return D5(CP(prev,c)); yield return D4(CP(prev,c)); yield return D3(CP(prev,c)); yield return D2(CP(prev,c)); yield return D1(CP(prev,c)); yield return D0(CP(prev,c)); yield return ';';
                } else if ('\uDE40' <= c & c <= '\uDFFF') {
                    yield return '&'; yield return '#'; yield return '1'; yield return '0'; yield return '0'; yield return '0'; yield return D2(CP(prev,c)); yield return D1(CP(prev,c)); yield return D0(CP(prev,c)); yield return ';';
                } else throw new Exception();
            } else if (s2 & !s1 & s0) {
                s2 = false; s1 = false; s0 = false;
                if ('\uDC00' <= c & c <= '\uDFFF') {
                    yield return '&'; yield return '#'; yield return '1'; yield return D5(CP(prev,c)); yield return D4(CP(prev,c)); yield return D3(CP(prev,c)); yield return D2(CP(prev,c)); yield return D1(CP(prev,c)); yield return D0(CP(prev,c)); yield return ';';
                } else throw new Exception();
            }
        }
    }
    
    partial class HTMLDecode : Transducer<char, char>
    {
        char F(char x, char y)
        {
            return (char)((10 * x) + (y - '0'));
        }
        char D1(char x)
        {
            return (char)((x % 10) + '0');
        }
        char D2(char x)
        {
            return (char)(((x / 10) % 10) + '0');
        }
        char D3(char x)
        {
            return (char)(((x / 100) % 10) + '0');
        }
        char D4(char x)
        {
            return (char)(((x / 1000) % 10) + '0');
        }
        char D5(char x)
        {
            return (char)(((x / 10000) % 10) + '0');
        }
        bool IsDecDig(char x)
        {
            return (('0' <= x) & (x <= '9'));
        }
        bool IsDec(char x)
        {
            return ((0 <= x) & (x <= 9));
        }
        bool IsHexDig(char x)
        {
            return ((('0' <= x) & (x <= '9')) | (('A' <= x) & (x <= 'F')));
        }
        char H1(char x)
        {
            if (IsDec((char)(x & 0xF)))
            {
                return (char)((x & 0xF) + '0');
            }
            else
            {
                return (char)((x & 0xF) + 55);
            }
        }
        char H2(char x)
        {
            if (IsDec((char)((x >> 4) & 0xF)))
            {
                return (char)(((x >> 4) & 0xF) + '0');
            }
            else
            {
                return (char)(((x >> 4) & 0xF) + 55);
            }
        }
        char H3(char x)
        {
            if (IsDec((char)((x >> 8) & 0xF)))
            {
                return (char)(((x >> 8) & 0xF) + '0');
            }
            else
            {
                return (char)(((x >> 8) & 0xF) + 55);
            }
        }
        char H4(char x)
        {
            if (IsDec((char)((x >> 12) & 0xF)))
            {
                return (char)(((x >> 12) & 0xF) + '0');
            }
            else
            {
                return (char)(((x >> 12) & 0xF) + 55);
            }
        }
        char Fx(char x, char y)
        {
            if (IsDecDig(y))
            {
                return (char)((x << 4) | (y - '0'));
            }
            else
            {
                return (char)((x << 4) | (y - 55));
            }
        }

        char q = (char)0;
        char d = (char)0;
        public override IEnumerable<char> Update(char c)
        {
            if ((q == 0) & (c == '&'))
            {
                q = '&';
                yield break;
            }
            if (q == 0)
            {
                yield return c;
                yield break;
            }

            if ((q == '&') & (c == '#'))
            {
                q = '#';   // &#
                yield break;
            }
            if ((q == '&') & (c == 'a'))
            {
                q = 'a';   // &a
                yield break;
            }
            if ((q == '&') & (c == 'q'))
            {
                q = 'q';   // &q
                yield break;
            }
            if ((q == '&') & (c == 'l'))
            {
                q = 'l';   // &l
                yield break;
            }
            if ((q == '&') & (c == 'g'))
            {
                q = 'g';   // &g
                yield break;
            }
            if ((q == '&') & (c == '&'))
            {
                yield return '&'; // &
                yield break;
            }
            if (q == '&')
            {
                yield return '&'; yield return c; q = (char)0;       // e.g. &3
                yield break;
            }

            if ((q == '#') & (c == 'X'))
            {
                q = 'X';                       //switch to hexadecimal decoding
                yield break;
            }

            //decimal decoding up to five decimal digits
            if ((q == '#') & (c == '&'))
            {
                yield return '&'; yield return '#'; q = '&';      // &#&        
                yield break;
            }
            if ((q == '#') & IsDecDig(c))
            {
                q = (char)1; d = (char)(c - '0');        //e.g. &#6
                yield break;
            }
            if (q == '#')
            {
                yield return '&'; yield return '#'; yield return c; q = (char)0;                     //e.g. &#t
                yield break;
            }

            if ((q == 1) & IsDecDig(c))
            {
                q = (char)2; d = F(d, c);                  //e.g. &#65
                yield break;
            }
            if ((q == 1) & (c == ';'))
            {
                yield return d; q = (char)0; d = (char)0;             //e.g. &#7;
                yield break;
            }
            if ((q == 1) & (c == '&'))
            {
                yield return '&'; yield return '#'; yield return D1(d); q = '&'; d = (char)0; //e.g. &#4&
                yield break;
            }
            if (q == 1)
            {
                yield return '&'; yield return '#'; yield return D1(d); yield return c; q = (char)0; d = (char)0;            //e.g. &#6e
                yield break;
            }

            if ((q == 2) & IsDecDig(c))
            {
                q = (char)3; d = F(d, c);                  //e.g. &#654
                yield break;
            }
            if ((q == 2) & (c == ';'))
            {
                yield return d; q = (char)0; d = (char)0;              //e.g. &#38; 
                yield break;
            }
            if ((q == 2) & (c == '&'))
            {
                yield return '&'; yield return '#'; yield return D2(d); yield return D1(d); q = '&'; d = (char)0; //e.g. &#38&
                yield break;
            }
            if (q == 2)
            {
                yield return '&'; yield return '#'; yield return D2(d); yield return D1(d); yield return c; q = (char)0; d = (char)0;    //e.g. &#38a
                yield break;
            }

            if ((q == 3) & IsDecDig(c))
            {
                q = (char)4; d = F(d, c);                  //e.g. &#6543
                yield break;
            }
            if ((q == 3) & (c == ';'))
            {
                yield return d; q = (char)0; d = (char)0;              //e.g. &#654; 
                yield break;
            }
            if ((q == 3) & (c == '&'))
            {
                yield return '&'; yield return '#'; yield return D3(d); yield return D2(d); yield return D1(d); q = '&'; d = (char)0; //e.g. &#654&
                yield break;
            }
            if (q == 3)
            {
                yield return '&'; yield return '#'; yield return D3(d); yield return D2(d); yield return D1(d); yield return c; q = (char)0; d = (char)0;  //e.g. &#654a
                yield break;
            }

            if ((q == 4) & IsDecDig(c) & (F(d, c) <= 0xFFFF))
            {
                q = (char)5; d = F(d, c);  //e.g. &#65532
                yield break;
            }
            if ((q == 4) & (c == ';'))
            {
                yield return d; q = (char)0; d = (char)0;              //e.g. &#6553; 
                yield break;
            }
            if ((q == 4) & (c == '&'))
            {
                yield return '&'; yield return '#'; yield return D4(d); yield return D3(d); yield return D2(d); yield return D1(d); q = '&'; d = (char)0; //e.g. &#6553&
                yield break;
            }
            if (q == 4)
            {
                yield return '&'; yield return '#'; yield return D4(d); yield return D3(d); yield return D2(d); yield return D1(d); yield return c; q = (char)0; d = (char)0;  //e.g. &#65536
                yield break;
            }

            if ((q == 5) & (c == ';'))
            {
                yield return d; q = (char)0; d = (char)0;              //e.g. &#65532; 
                yield break;
            }
            if ((q == 5) & (c == '&'))
            {
                yield return '&'; yield return '#'; yield return D5(d); yield return D4(d); yield return D3(d); yield return D2(d); yield return D1(d); q = '&'; d = (char)0; //e.g. &#65532&
                yield break;
            }
            if (q == 5)
            {
                yield return '&'; yield return '#'; yield return D5(d); yield return D4(d); yield return D3(d); yield return D2(d); yield return D1(d); yield return c; q = (char)0; d = (char)0;  //e.g. &#65536
                yield break;
            }

            //hexadecimal decoding up to 4 hex digits
            if ((q == 'X') & (c == '&'))
            {
                yield return '&'; yield return '#'; yield return 'X'; q = '&';      // &#x&    
                yield break;
            }
            if ((q == 'X') & IsHexDig(c))
            {
                q = (char)6; d = Fx((char)0, c);              //e.g. &#xa
                yield break;
            }
            if (q == 'X')
            {
                q = (char)0; yield return '&'; yield return '#'; yield return 'X'; yield return c; d = (char)0;                //e.g. &#xr
                yield break;
            }

            if ((q == 6) & IsHexDig(c))
            {
                q = (char)7; d = Fx(d, c);                 //e.g. &#af
                yield break;
            }
            if ((q == 6) & (c == ';'))
            {
                yield return d; q = (char)0; d = (char)0;             //e.g. &#a;
                yield break;
            }
            if ((q == 6) & (c == '&'))
            {
                yield return '&'; yield return '#'; yield return 'X'; yield return H1(d); q = '&'; d = (char)0; //e.g. &#a&
                yield break;
            }
            if (q == 6)
            {
                yield return '&'; yield return '#'; yield return 'X'; yield return H1(d); yield return c; q = (char)0; d = (char)0;              //e.g. &#ag
                yield break;
            }

            if ((q == 7) & IsHexDig(c))
            {
                q = (char)8; d = Fx(d, c);                 //e.g. &#afe
                yield break;
            }
            if ((q == 7) & (c == ';'))
            {
                yield return d; q = (char)0; d = (char)0;             //e.g. &#af;
                yield break;
            }
            if ((q == 7) & (c == '&'))
            {
                yield return '&'; yield return '#'; yield return 'X'; yield return H2(d); yield return H1(d); q = '&'; d = (char)0; //e.g. &#af&
                yield break;
            }
            if (q == 7)
            {
                yield return '&'; yield return '#'; yield return 'X'; yield return H2(d); yield return H1(d); yield return c; q = (char)0; d = (char)0;              //e.g. &#afg
                yield break;
            }

            if ((q == 8) & IsHexDig(c))
            {
                q = (char)9; d = Fx(d, c);                 //e.g. &#afed
                yield break;
            }
            if ((q == 8) & (c == ';'))
            {
                yield return d; q = (char)0; d = (char)0;             //e.g. &#afe;
                yield break;
            }
            if ((q == 8) & (c == '&'))
            {
                yield return '&'; yield return '#'; yield return 'X'; yield return H3(d); yield return H2(d); yield return H1(d); q = '&'; d = (char)0; //e.g. &#afe&
                yield break;
            }
            if (q == 8)
            {
                yield return '&'; yield return '#'; yield return 'X'; yield return H3(d); yield return H2(d); yield return H1(d); yield return c; q = (char)0; d = (char)0;  //e.g. &#afeg
                yield break;
            }

            if ((q == 9) & (c == ';'))
            {
                yield return d; q = (char)0; d = (char)0;             //e.g. &#afed;
                yield break;
            }
            if ((q == 9) & (c == '&'))
            {
                yield return '&'; yield return '#'; yield return 'X'; yield return H4(d); yield return H3(d); yield return H2(d); yield return H1(d); q = '&'; d = (char)0; //e.g. &#afed&
                yield break;
            }
            if (q == 9)
            {
                yield return '&'; yield return '#'; yield return 'X'; yield return H4(d); yield return H3(d); yield return H2(d); yield return H1(d); yield return c; q = (char)0; d = (char)0;  //e.g. &#afeda
                yield break;
            }

            // ---- special fixed patterns ----

            //case : &lt;
            if ((q == 'l') & (c == 't'))
            {
                q = 'L';                  // &lt
                yield break;
            }
            if ((q == 'l') & (c == '&'))
            {
                yield return '&'; yield return 'l'; q = '&';  // &l&
                yield break;
            }
            if (q == 'l')
            {
                yield return '&'; yield return 'l'; yield return c; q = (char)0;               //e.g. &la
                yield break;
            }

            if ((q == 'L') & (c == ';'))
            {
                yield return '<'; q = (char)0;       // &lt;
                yield break;
            }
            if ((q == 'L') & (c == '&'))
            {
                yield return '&'; yield return 'l'; yield return 't'; q = '&';  // &lt&
                yield break;
            }
            if (q == 'L')
            {
                yield return '&'; yield return 'l'; yield return 't'; yield return c; q = (char)0;           //e.g. &lta
                yield break;
            }

            //case : &gt;
            if ((q == 'g') & (c == 't'))
            {
                q = 'G';                 // &gt
                yield break;
            }
            if ((q == 'g') & (c == '&'))
            {
                yield return '&'; yield return 'g'; q = '&';  // &g&
                yield break;
            }
            if (q == 'g')
            {
                yield return '&'; yield return 'g'; yield return c; q = (char)0;              //e.g. &ga
                yield break;
            }

            if ((q == 'G') & (c == ';'))
            {
                yield return '>'; q = (char)0;       // &gt;
                yield break;
            }
            if ((q == 'G') & (c == '&'))
            {
                yield return '&'; yield return 'g'; yield return 't'; q = '&';  // &gt&
                yield break;
            }
            if (q == 'G')
            {
                yield return '&'; yield return 'g'; yield return 't'; yield return c; q = (char)0;           //e.g. &gta
                yield break;
            }

            //case : &quot;
            if ((q == 'q') & (c == 'u'))
            {
                q = 'u';                 // &qu
                yield break;
            }
            if ((q == 'q') & (c == '&'))
            {
                yield return '&'; yield return 'q'; q = '&';  // &q&
                yield break;
            }
            if (q == 'q')
            {
                yield return '&'; yield return 'q'; yield return c; q = (char)0;                //e.g. &qa
                yield break;
            }

            if ((q == 'u') & (c == 'o'))
            {
                q = 'o';                 // &quo
                yield break;
            }
            if ((q == 'u') & (c == '&'))
            {
                yield return '&'; yield return 'q'; yield return 'u'; q = '&'; // &qu&
                yield break;
            }
            if (q == 'u')
            {
                yield return '&'; yield return 'q'; yield return 'u'; yield return c; q = (char)0;              //e.g. &qua
                yield break;
            }

            if ((q == 'o') & (c == 't'))
            {
                q = 't';               // &quot
                yield break;
            }
            if ((q == 'o') & (c == '&'))
            {
                yield return '&'; yield return 'q'; yield return 'u'; yield return 'o'; q = '&';  // &quo&
                yield break;
            }
            if (q == 'o')
            {
                yield return '&'; yield return 'q'; yield return 'u'; yield return 'o'; yield return c; q = (char)0;             //e.g. &quoa
                yield break;
            }

            if ((q == 't') & (c == ';'))
            {
                yield return (char)0x22; q = (char)0;          // &quot;
                yield break;
            }
            if ((q == 't') & (c == '&'))
            {
                yield return '&'; yield return 'q'; yield return 'u'; yield return 'o'; yield return 't'; q = '&';  // &quot&
                yield break;
            }
            if (q == 't')
            {
                yield return '&'; yield return 'q'; yield return 'u'; yield return 'o'; yield return 't'; yield return c; q = (char)0;    //e.g. &quota
                yield break;
            }

            //case : &amp; or &apos;
            if ((q == 'a') & (c == 'm'))
            {
                q = 'm';                 // &am
                yield break;
            }
            if ((q == 'a') & (c == 'p'))
            {
                q = 'P';                 // &ap
                yield break;
            }
            if ((q == 'a') & (c == '&'))
            {
                yield return '&'; yield return 'a'; q = '&'; // &a&
                yield break;
            }
            if (q == 'a')
            {
                yield return '&'; yield return 'a'; yield return c; q = (char)0;              //e.g. &aa
                yield break;
            }

            if ((q == 'm') & (c == 'p'))
            {
                q = 'p';                     // &amp
                yield break;
            }
            if ((q == 'm') & (c == '&'))
            {
                yield return '&'; yield return 'a'; yield return 'm'; q = '&'; // &am&
                yield break;
            }
            if (q == 'm')
            {
                yield return '&'; yield return 'a'; yield return 'm'; yield return c; q = (char)0;              //e.g. &ama
                yield break;
            }

            if ((q == 'p') & (c == ';'))
            {
                yield return '&'; q = (char)0;                 // &amp;
                yield break;
            }
            if ((q == 'p') & (c == '&'))
            {
                yield return '&'; yield return 'a'; yield return 'm'; yield return 'p'; q = '&'; // &amp&
                yield break;
            }
            if (q == 'p')
            {
                yield return '&'; yield return 'a'; yield return 'm'; yield return 'p'; yield return c; q = (char)0;                 //e.g. &ampa
                yield break;
            }

            if ((q == 'P') & (c == 'o'))
            {
                q = 'O';           // &apo
                yield break;
            }
            if ((q == 'P') & (c == '&'))
            {
                yield return '&'; yield return 'a'; yield return 'p'; q = '&';// &ap&
                yield break;
            }
            if (q == 'P')
            {
                yield return '&'; yield return 'a'; yield return 'p'; yield return c; q = (char)0;           //e.g. &apa
                yield break;
            }

            if ((q == 'O') & (c == 's'))
            {
                q = 'S';         // &apos
                yield break;
            }
            if ((q == 'O') & (c == '&'))
            {
                yield return '&'; yield return 'a'; yield return 'p'; yield return 'o'; q = '&'; // &apo&
                yield break;
            }
            if (q == 'O')
            {
                yield return '&'; yield return 'a'; yield return 'p'; yield return 'o'; yield return c; q = (char)0;           //e.g. &apoa
                yield break;
            }

            if ((q == 'S') & (c == ';'))
            {
                yield return (char)0x27; q = (char)0;     // &apos;
                yield break;
            }
            if ((q == 'S') & (c == '&'))
            {
                yield return '&'; yield return 'a'; yield return 'p'; yield return 'o'; yield return 's'; q = '&'; // &apos&
                yield break;
            }
            if (q == 'S')
            {
                yield return '&'; yield return 'a'; yield return 'p'; yield return 'o'; yield return 's'; yield return c; q = (char)0;    //e.g. &aposa
                yield break;
            }

            if (true)
            {
                q = (char)0; d = (char)0;
                yield break;
            }
        }

        public override IEnumerable<char> Finish()
        {
            if (q == 0)
            {

                yield break;
            }
            if (q == '&')
            {
                yield return '&';
                yield break;
            }
            if (q == '#')
            {
                yield return '&'; yield return '#';
                yield break;
            }
            if (q == 'X')
            {
                yield return '&'; yield return '#'; yield return 'X';
                yield break;
            }
            if (q == 1)
            {
                yield return '&'; yield return '#'; yield return D1(d);
                yield break;
            }
            if (q == 2)
            {
                yield return '&'; yield return '#'; yield return D2(d); yield return D1(d);
                yield break;
            }
            if (q == 3)
            {
                yield return '&'; yield return '#'; yield return D3(d); yield return D2(d); yield return D1(d);
                yield break;
            }
            if (q == 4)
            {
                yield return '&'; yield return '#'; yield return D4(d); yield return D3(d); yield return D2(d); yield return D1(d);
                yield break;
            }
            if (q == 5)
            {
                yield return '&'; yield return '#'; yield return D5(d); yield return D4(d); yield return D3(d); yield return D2(d); yield return D1(d);
                yield break;
            }
            if (q == 6)
            {
                yield return '&'; yield return '#'; yield return 'X'; yield return H1(d);
                yield break;
            }
            if (q == 7)
            {
                yield return '&'; yield return '#'; yield return 'X'; yield return H2(d); yield return H1(d);
                yield break;
            }
            if (q == 8)
            {
                yield return '&'; yield return '#'; yield return 'X'; yield return H3(d); yield return H2(d); yield return H1(d);
                yield break;
            }
            if (q == 9)
            {
                yield return '&'; yield return '#'; yield return 'X'; yield return H4(d); yield return H3(d); yield return H2(d); yield return H1(d);
                yield break;
            }
            if (q == 'l')
            {
                yield return '&'; yield return 'l';
                yield break;
            }
            if (q == 'L')
            {
                yield return '&'; yield return 'l'; yield return 't';
                yield break;
            }
            if (q == 'g')
            {
                yield return '&'; yield return 'g';
                yield break;
            }
            if (q == 'G')
            {
                yield return '&'; yield return 'g'; yield return 't';
                yield break;
            }
            if (q == 'q')
            {
                yield return '&'; yield return 'q';
                yield break;
            }
            if (q == 'u')
            {
                yield return '&'; yield return 'q'; yield return 'u';
                yield break;
            }
            if (q == 'o')
            {
                yield return '&'; yield return 'q'; yield return 'u'; yield return 'o';
                yield break;
            }
            if (q == 't')
            {
                yield return '&'; yield return 'q'; yield return 'u'; yield return 'o'; yield return 't';
                yield break;
            }
            if (q == 'a')
            {
                yield return '&'; yield return 'a';
                yield break;
            }
            if (q == 'm')
            {
                yield return '&'; yield return 'a'; yield return 'm';
                yield break;
            }
            if (q == 'p')
            {
                yield return '&'; yield return 'a'; yield return 'm'; yield return 'p';
                yield break;
            }
            if (q == 'P')
            {
                yield return '&'; yield return 'a'; yield return 'p';
                yield break;
            }
            if (q == 'O')
            {
                yield return '&'; yield return 'a'; yield return 'p'; yield return 'o';
                yield break;
            }
            if (q == 'S')
            {
                yield return '&'; yield return 'a'; yield return 'p'; yield return 'o'; yield return 's';
                yield break;
            }
            if (true)
            {

                yield break;
            }
        }


    }
}
