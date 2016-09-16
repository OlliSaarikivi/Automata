using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimizationBenchmark
{
    static partial class Transducers
    {
        public const string EnglishHuffmanDecoder = @"
[HuffmanDecoder(@""C:\Users\ollis\Desktop\datasets\pg2701.txt"")]
partial class EnglishHuffmanDecoder : SpecialTransducer { }";
        public const string B64ToInts = Base64Decoder + BytesToInt32 + @"
partial class B64ToInts : Composition<Base64Decoder, BytesToInt32> { }";

        public const string Huffman = UTF8ToUTF16 + LineCount + EnglishHuffmanDecoder + @"
partial class UTF8ToLC : Composition<UTF8ToUTF16, LineCount> { }
partial class HuffmanToUTF8ToLC : Composition<EnglishHuffmanDecoder, UTF8ToLC> { }";
        public const string Base64_delta = Delta + FormatInt32Lines + UTF16ToUTF8 + B64ToInts + @"
partial class FormattedDelta : Composition<Delta, FormatInt32Lines> { }
partial class FormattedDeltaUTF8 : Composition<FormattedDelta, UTF16ToUTF8> { }
partial class B64FormattedDeltaUTF8 : Composition<B64ToInts, FormattedDeltaUTF8> { }";
        public const string CSV_max = UTF8ToUTF16 + Maximum + FormatInt32Lines + UTF16ToUTF8 + @"//Remember to limit simplify to depth 3 oslt.
[ParsingMatcher(@""(([^,\n]*,){3}(?<value>\d+)(\n|(,[^\n]*\n)))*"", ""int"")]
partial class Col3Int : SpecialTransducer { }
partial class UTF8Col3Int : Composition<UTF8ToUTF16, Col3Int> { }
partial class UTF8MaxCol3Int : Composition<UTF8Col3Int, Maximum> { }
partial class UTF8MaxCol3IntFormat : Composition<UTF8MaxCol3Int, FormatInt32Lines> { }
partial class UTF8MaxCol3IntB64 : Composition<UTF8MaxCol3IntFormat, UTF16ToUTF8> { }";
        public const string Base64_avg = Int32ToBytes + Base64Encoder + WindowedAverage10 + B64ToInts + @"
partial class IntsToB64 : Composition<Int32ToBytes, Base64Encoder> { }
partial class WindowedAverageB64 : Composition<WindowedAverage10, IntsToB64> { }
partial class B64ToWindowedAverageToB64 : Composition<B64ToInts, WindowedAverageB64> { }";
        public const string UTF8_lines = FormatInt32Lines + UTF16ToUTF8 + UTF8ToUTF16 + LineCount + @"
partial class FormattedLineCount : Composition<FormattedLineCountUTF8, UTF8ToFormattedLineCount> { }//Top
partial class UTF8ToFormattedLineCount : Composition<FormatInt32Lines, UTF16ToUTF8> { }
partial class FormattedLineCountUTF8 : Composition<UTF8ToUTF16, LineCount> { }";
        public const string CC_id = UTF8ToUTF16 + Int32ToBytes + Maximum + @"
[ParsingMatcher(""((?<value>\\d+)(,([^\\n,]*)|(\""[^\\n\""]*\"")){12},([^\\n]*)\\n)*"", ""int"")]
partial class CCCol1Int : SpecialTransducer { }
partial class CSV1a : Composition<UTF8ToUTF16, CCCol1Int> { }
partial class CSV1ab : Composition<CSV1a, Maximum> { }
partial class CSV1abc : Composition<CSV1ab, Int32ToBytes> { }";
        public const string CHSI_cancer = UTF8ToUTF16 + Int32ToBytes + Minimum + @"
[ParsingMatcher(""(([^,]*,){138}-?(?<value>\\d+)(\\.\\d+)?,[^\\n]*\\n)*"", ""int"")]
partial class CHSITotalBirths : SpecialTransducer { }
partial class CSV2a : Composition<UTF8ToUTF16, CHSITotalBirths> { }
partial class CSV2ab : Composition<CSV2a, Minimum> { }
partial class CSV2abc : Composition<CSV2ab, Int32ToBytes> { }";
        public const string CHSI_births = UTF8ToUTF16 + Int32ToBytes + Maximum + @"
[ParsingMatcher(""(([^,]*,){139}-?(?<value>\\d+)(\\.\\d+)?,[^\\n]*\\n)*"", ""int"")]
partial class CHSITotalDeaths : SpecialTransducer { }
partial class CSV3a : Composition<UTF8ToUTF16, CHSITotalDeaths> { }
partial class CSV3ab : Composition<CSV3a, Maximum> { }
partial class CSV3abc : Composition<CSV3ab, Int32ToBytes> { }";
        public const string CHSI_deaths = UTF8ToUTF16 + Int32ToBytes + Average + @"
[ParsingMatcher(""(([^,]*,){108}-?(?<value>\\d+)(\\.\\d+)?,[^\\n]*\\n)*"", ""int"")]
partial class CHSILungCancer : SpecialTransducer { }
partial class CSV4a : Composition<UTF8ToUTF16, CHSILungCancer> { }
partial class CSV4ab : Composition<CSV4a, Average> { }
partial class CSV4abc : Composition<CSV4ab, Int32ToBytes> { }";
        public const string SBO_employees = UTF8ToUTF16 + Int32ToBytes + Maximum + @"
[ParsingMatcher(""(([^,]*,){5}(?<value>\\d+),[^\\n]*\\n)*"", ""int"")]
partial class SBOEmployees : SpecialTransducer { }
partial class CSV5a : Composition<UTF8ToUTF16, SBOEmployees> { }
partial class CSV5ab : Composition<CSV5a, Maximum> { }
partial class CSV5abc : Composition<CSV5ab, Int32ToBytes> { }";
        public const string SBO_receipts = UTF8ToUTF16 + Int32ToBytes + Average + @"
[ParsingMatcher(""(([^,]*,){6}(?<value>\\d+)(\\.\\d+)?,[^\\n]*\\n)*"", ""int"")]
partial class SBOPayroll : SpecialTransducer { }
partial class CSV6a : Composition<UTF8ToUTF16, SBOPayroll> { }
partial class CSV6ab : Composition<CSV6a, Average> { }
partial class CSV6abc : Composition<CSV6ab, Int32ToBytes> { }";
        public const string SBO_payroll = UTF8ToUTF16 + Int32ToBytes + Minimum + @"
[ParsingMatcher(""(([^,]*,){7}(?<value>\\d+)(\\.\\d+)?,[^\\n]*\\n)*"", ""int"")]
partial class SBOGrossReceipts : SpecialTransducer { }
partial class CSV7a : Composition<UTF8ToUTF16, SBOGrossReceipts> { }
partial class CSV7ab : Composition<CSV7a, Minimum> { }
partial class CSV7abc : Composition<CSV7ab, Int32ToBytes> { }";
        public const string TPC_DI_SQL = UTF8ToUTF16 + Int32ToBytes + SQLInsertInt32 + UTF16ToUTF8 + @"
[XPathMatcher(""/TPCDI:Actions/TPCDI:Action/Customer/Account/CA_B_ID"", ""int"")]
partial class TPCDICustomerIds : SpecialTransducer { }
partial class XML1a : Composition<UTF8ToUTF16, TPCDICustomerIds> { }
partial class XML1ab : Composition<XML1a, SQLInsertInt32> { }
partial class XML1abc : Composition<XML1ab, UTF16ToUTF8> { }";
        public const string PIR_proteins = UTF8ToUTF16 + Int32ToBytes + Average + @"
[XPathMatcher(""/ProteinDatabase/ProteinEntry/summary/length"", ""int"")]
partial class ProteinLengths : SpecialTransducer { }
partial class XML2a : Composition<UTF8ToUTF16, ProteinLengths> { }
partial class XML2ab : Composition<XML2a, Average> { }
partial class XML2abc : Composition<XML2ab, Int32ToBytes> { }";
        public const string DBLP_oldest = UTF8ToUTF16 + Int32ToBytes + Minimum + @"
[XPathMatcher(""/dblp/article/year"", ""int"")]
partial class DBLPYear : SpecialTransducer { }
partial class XML3a : Composition<UTF8ToUTF16, DBLPYear> { }
partial class XML3ab : Composition<XML3a, Minimum> { }
partial class XML3abc : Composition<XML3ab, Int32ToBytes> { }";
        public const string MONDIAL_pop = UTF8ToUTF16 + Int32ToBytes + Maximum + @"
[XPathMatcher(""/mondial/country/city/population"", ""int"")]
partial class MondialCityPopulation : SpecialTransducer { }
partial class XML4a : Composition<UTF8ToUTF16, MondialCityPopulation> { }
partial class XML4ab : Composition<XML4a, Maximum> { }
partial class XML4abc : Composition<XML4ab, Int32ToBytes> { }";
    }
}
