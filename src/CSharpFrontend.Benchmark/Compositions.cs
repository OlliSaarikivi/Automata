using Microsoft.Automata.CSharpFrontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    [SuppressCodeGeneration()] partial class B64ToInts : Composition<Base64Decoder, BytesToInt32> { }

    //// Base64 windowed average pipeline Min=64
    [SuppressCodeGeneration()] partial class IntsToB64 : Composition<Int32ToBytes, Base64Encoder> { }
    [SuppressCodeGeneration()] partial class WindowedAverageB64 : Composition<WindowedAverage10, IntsToB64> { }
    partial class B64ToWindowedAverageToB64 : Composition<B64ToInts, WindowedAverageB64> { }//Top

    ////Remember to limit simplify to depth 3 oslt.
    [ParsingMatcher(@"(([^,\n]*,){3}(?<value>\d+)(\n|(,[^\n]*\n)))*", "int")]
    [SuppressCodeGeneration()] partial class Col3Int : SpecialTransducer { }
    [SuppressCodeGeneration()] partial class UTF8Col3Int : Composition<UTF8ToUTF16, Col3Int> { }
    [SuppressCodeGeneration()] partial class UTF8MaxCol3Int : Composition<UTF8Col3Int, Maximum> { }
    [SuppressCodeGeneration()] partial class UTF8MaxCol3IntFormat : Composition<UTF8MaxCol3Int, FormatInt32Lines> { }
    partial class UTF8MaxCol3IntB64 : Composition<UTF8MaxCol3IntFormat, UTF16ToUTF8> { }//Top

    // B64 delta min=10
    [SuppressCodeGeneration()] partial class FormattedDelta : Composition<Delta, FormatInt32Lines> { }
    [SuppressCodeGeneration()] partial class FormattedDeltaUTF8 : Composition<FormattedDelta, UTF16ToUTF8> { }
    partial class B64FormattedDeltaUTF8 : Composition<B64ToInts, FormattedDeltaUTF8> { }//Top

    // Line count to formatted int
    [SuppressCodeGeneration()] partial class UTF8ToFormattedLineCount : Composition<FormatInt32Lines, UTF16ToUTF8> { }
    [SuppressCodeGeneration()] partial class FormattedLineCountUTF8 : Composition<UTF8ToUTF16, LineCount> { }
    partial class FormattedLineCount : Composition<FormattedLineCountUTF8, UTF8ToFormattedLineCount> { }//Top

    [HuffmanDecoder(@"datasets\pg2701.txt")]
    partial class EnglishHuffmanDecoder : SpecialTransducer { }

    [HuffmanEncoder(@"datasets\pg2701.txt")]
    partial class EnglishHuffmanEncoder : SpecialTransducer { }

    [SuppressCodeGeneration()] partial class UTF8ToLC : Composition<UTF8ToUTF16, LineCount> { }
    [SuppressCodeGeneration()] partial class UTF8ToLCBytes : Composition<UTF8ToLC, Int32ToBytes> { }
    partial class HuffmanToLCBytes : Composition<EnglishHuffmanDecoder, UTF8ToLCBytes> { }//Top

    // Fibonacci simp=1
    [SuppressCodeGeneration()] partial class SafeFibonacci : Composition<FibonacciGenerator, OnlyFibonacci> { }
    partial class SafeFibonacciBytes : Composition<SafeFibonacci, Int32ToBytes> { }//Top


    // CSV table

    // Maximum ID
    [ParsingMatcher("((?<value>\\d+)(,([^\\n,]*)|(\"[^\\n\"]*\")){12},([^\\n]*)\\n)*", "int")]
    [SuppressCodeGeneration()] partial class CCCol1Int : SpecialTransducer { }
    [SuppressCodeGeneration()] partial class CSV1a : Composition<UTF8ToUTF16, CCCol1Int> { }
    [SuppressCodeGeneration()] partial class CSV1ab : Composition<CSV1a, Maximum> { }
    partial class CSV1abc : Composition<CSV1ab, Int32ToBytes> { }//Top

    // Minimum total births
    [ParsingMatcher("(([^,]*,){138}-?(?<value>\\d+)(\\.\\d+)?,[^\\n]*\\n)*", "int")]
    [SuppressCodeGeneration()] partial class CHSITotalBirths : SpecialTransducer { }
    [SuppressCodeGeneration()] partial class CSV2a : Composition<UTF8ToUTF16, CHSITotalBirths> { }
    [SuppressCodeGeneration()] partial class CSV2ab : Composition<CSV2a, Minimum> { }
    partial class CSV2abc : Composition<CSV2ab, Int32ToBytes> { }//Top

    // Maximum deaths
    [ParsingMatcher("(([^,]*,){139}-?(?<value>\\d+)(\\.\\d+)?,[^\\n]*\\n)*", "int")]
    [SuppressCodeGeneration()] partial class CHSITotalDeaths : SpecialTransducer { }
    [SuppressCodeGeneration()] partial class CSV3a : Composition<UTF8ToUTF16, CHSITotalDeaths> { }
    [SuppressCodeGeneration()] partial class CSV3ab : Composition<CSV3a, Maximum> { }
    partial class CSV3abc : Composition<CSV3ab, Int32ToBytes> { }//Top

    // Average lung cancer
    [ParsingMatcher("(([^,]*,){108}-?(?<value>\\d+)(\\.\\d+)?,[^\\n]*\\n)*", "int")]
    [SuppressCodeGeneration()] partial class CHSILungCancer : SpecialTransducer { }
    [SuppressCodeGeneration()] partial class CSV4a : Composition<UTF8ToUTF16, CHSILungCancer> { }
    [SuppressCodeGeneration()] partial class CSV4ab : Composition<CSV4a, Average> { }
    partial class CSV4abc : Composition<CSV4ab, Int32ToBytes> { }//Top

    //Maximum num employees
    [ParsingMatcher("(([^,]*,){5}(?<value>\\d+),[^\\n]*\\n)*", "int")]
    [SuppressCodeGeneration()] partial class SBOEmployees : SpecialTransducer { }
    [SuppressCodeGeneration()] partial class CSV5a : Composition<UTF8ToUTF16, SBOEmployees> { }
    [SuppressCodeGeneration()] partial class CSV5ab : Composition<CSV5a, Maximum> { }
    partial class CSV5abc : Composition<CSV5ab, Int32ToBytes> { }//Top

    //Average total payroll
    [ParsingMatcher("(([^,]*,){6}(?<value>\\d+)(\\.\\d+)?,[^\\n]*\\n)*", "int")]
    [SuppressCodeGeneration()] partial class SBOPayroll : SpecialTransducer { }
    [SuppressCodeGeneration()] partial class CSV6a : Composition<UTF8ToUTF16, SBOPayroll> { }
    [SuppressCodeGeneration()] partial class CSV6ab : Composition<CSV6a, Average> { }
    partial class CSV6abc : Composition<CSV6ab, Int32ToBytes> { }//Top

    //Minimum gross receipts
    [ParsingMatcher("(([^,]*,){7}(?<value>\\d+)(\\.\\d+)?,[^\\n]*\\n)*", "int")]
    [SuppressCodeGeneration()] partial class SBOGrossReceipts : SpecialTransducer { }
    [SuppressCodeGeneration()] partial class CSV7a : Composition<UTF8ToUTF16, SBOGrossReceipts> { }
    [SuppressCodeGeneration()] partial class CSV7ab : Composition<CSV7a, Minimum> { }
    partial class CSV7abc : Composition<CSV7ab, Int32ToBytes> { }//Top


    // XML

    [XPathMatcher("/TPCDI:Actions/TPCDI:Action/Customer/Account/CA_B_ID", "int")]
    [SuppressCodeGeneration()] partial class TPCDICustomerIds : SpecialTransducer { }
    [SuppressCodeGeneration()] partial class XML1a : Composition<UTF8ToUTF16, TPCDICustomerIds> { }
    [SuppressCodeGeneration()] partial class XML1ab : Composition<XML1a, SQLInsertInt32> { }
    partial class XML1abc : Composition<XML1ab, UTF16ToUTF8> { }

    [XPathMatcher("/ProteinDatabase/ProteinEntry/summary/length", "int")]
    [SuppressCodeGeneration()] partial class ProteinLengths : SpecialTransducer { }
    [SuppressCodeGeneration()] partial class XML2a : Composition<UTF8ToUTF16, ProteinLengths> { }
    [SuppressCodeGeneration()] partial class XML2ab : Composition<XML2a, Average> { }
    partial class XML2abc : Composition<XML2ab, Int32ToBytes> { }

    [XPathMatcher("/dblp/article/year", "int")]
    [SuppressCodeGeneration()] partial class DBLPYear : SpecialTransducer { }
    [SuppressCodeGeneration()] partial class XML3a : Composition<UTF8ToUTF16, DBLPYear> { }
    [SuppressCodeGeneration()] partial class XML3ab : Composition<XML3a, Minimum> { }
    partial class XML3abc : Composition<XML3ab, Int32ToBytes> { }

    [XPathMatcher("/mondial/country/city/population", "int")]
    [SuppressCodeGeneration()] partial class MondialCityPopulation : SpecialTransducer { }
    [SuppressCodeGeneration()] partial class XML4a : Composition<UTF8ToUTF16, MondialCityPopulation> { }
    [SuppressCodeGeneration()] partial class XML4ab : Composition<XML4a, Maximum> { }
    partial class XML4abc : Composition<XML4ab, Int32ToBytes> { }


    partial class FixUTF16ToHTMLEncode : Composition<UTF16FixSurrogates, HTMLEncode> { }


    // Windowed average length of issue description
    // The following is currently broken by the compiler
    //[ParsingMatcher("((\\d+),(([^\\n,]*)|(\"[^\\n\"]*\")),(([^\\n,]*)|(\"[^\\n\"]*\")),(?<value>([^\\n,]*)|(\"[^\\n\"]*\")),(([^\\n,]*)|(\"[^\\n\"]*\")),(([^\\n,]*)|(\"[^\\n\"]*\")),(\\d+),(([^\\n,]*)|(\"[^\\n\"]*\")),(([^\\n,]*)|(\"[^\\n\"]*\")),(([^\\n,]*)|(\"[^\\n\"]*\")),(([^\\n,]*)|(\"[^\\n\"]*\")),(([^\\n,]*)|(\"[^\\n\"]*\")),(([^\\n,]*)|(\"[^\\n\"]*\")),([^\\n]*)\\n)*", "length")]
    //partial class CCCol4Length : SpecialTransducer { }
    //partial class CSV2a : Composition<AssumeSingleByteChars, CCCol4Length> { }
    //partial class CSV2ab : Composition<CSV2a, WindowedAverage10> { }
    //partial class CSV2abc : Composition<CSV2ab, Int32ToBytes> { }




    // PROBABLY NOT

    //partial class UTF8CRPositions : Composition<UTF8ToUTF16, CRPositions> { }
    //partial class UTF8CRPositionsFormatted : Composition<UTF8CRPositions, FormatInt32Lines> { }
    //partial class UTF8CRPositionsFormattedUTF8 : Composition<UTF8CRPositionsFormatted, UTF16ToUTF8> { }

    // Huffman Col3 formatted maximum
    //partial class UTF8ToCol3Int : Composition<UTF8ToUTF16, Col3Length> { }
    //partial class UTF8ToCol3IntMaximum : Composition<UTF8ToCol3Int, Maximum> { }
    //partial class UTF8ToCol3IntMaximumBytes : Composition<UTF8ToCol3IntMaximum, Int32ToBytes> { }
    //partial class HuffmanToCol3IntFormattedMaximumUTF8 : Composition<EnglishHuffmanDecoder, UTF8ToCol3IntMaximumBytes> { }

    // HTML to unix line endings
    //partial class UTF8HTML : Composition<UTF8ToUTF16, HTMLDecode> { }
    //partial class HTMLUnixLE : Composition<UTF8HTML, ToUnixLineEndings> { }
    //partial class HTMLUnixLEUTF8 : Composition<HTMLUnixLE, UTF16ToUTF8> { }

    // HTML line count
    //partial class ASCIIHTML : Composition<AssumeSingleByteChars, HTMLDecode> { }
    //partial class ASCIIHTMLLC : Composition<ASCIIHTML, LineCount> { }
    //partial class ASCIIHTMLLCBytes : Composition<ASCIIHTMLLC, Int32ToBytes> { }
}
