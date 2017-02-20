using GotDotNet.XPath;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Microsoft.Automata.CSharpFrontend.Benchmark
{
    class ManualXML1abc
    {

        public static void GeneratedStages(byte[] input, Stream output)
        {
            var result = UTF16ToUTF8.Transduce(SQLInsertInt32.Transduce(TPCDICustomerIds.Transduce(UTF8ToUTF16.Transduce(input)))).ToArray();
            output.Write(result, 0, result.Length);
        }

        public static void HandOptimized(byte[] input, Stream output)
        {
            var asString = System.Text.Encoding.UTF8.GetString(input);
            var doc = new XmlDocument();
            doc.LoadXml(asString);
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("TPCDI", "http://www.tpc.org/tpc-di");
            var nodes = doc.DocumentElement.SelectNodes("/TPCDI:Actions/TPCDI:Action/Customer/Account/CA_B_ID", nsmgr);
            foreach (XmlNode idNode in nodes)
            {
                int id = int.Parse(idNode.InnerText);
                var formatted = System.Text.Encoding.UTF8.GetBytes("INSERT INTO Accounts\nVALUES (" + id + ");\n");
                output.Write(formatted, 0, formatted.Length);
            }
        }

        public static void XPathReaderVersion(Stream input, Stream output)
        {
            var reader = new XPathReader(new StreamReader(input), "/TPCDI:Actions/TPCDI:Action/Customer/Account/CA_B_ID");

            while (reader.ReadUntilMatch())
            {
                var id = reader.ReadElementContentAsInt();
                var formatted = System.Text.Encoding.UTF8.GetBytes("INSERT INTO Accounts\nVALUES (" + id + ");\n");
                output.Write(formatted, 0, formatted.Length);
            }
        }
    }

    class ManualXML2
    {

        public static void GeneratedStages(byte[] input, Stream output)
        {
            var result = Int32ToBytes.Transduce(Average.Transduce(ProteinLengths.Transduce(UTF8ToUTF16.Transduce(input)))).ToArray();
            output.Write(result, 0, result.Length);
        }

        public static void HandOptimized(byte[] input, Stream output)
        {
            var asString = System.Text.Encoding.UTF8.GetString(input);
            var doc = new XmlDocument();
            doc.LoadXml(asString);
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            var nodes = doc.DocumentElement.SelectNodes("/ProteinDatabase/ProteinEntry/summary/length", nsmgr);
            long sum = 0L;
            int count = 0;
            foreach (XmlNode lengthNode in nodes)
            {
                sum += int.Parse(lengthNode.InnerText);
                ++count;
            }
            var bytes = BitConverter.GetBytes((int)(sum / count));
            output.Write(bytes, 0, bytes.Length);
        }

        public static void XPathReaderVersion(Stream input, Stream output)
        {
            var reader = new XPathReader(new StreamReader(input), "/ProteinDatabase/ProteinEntry/summary/length");
            long sum = 0L;
            int count = 0;
            while (reader.ReadUntilMatch())
            {
                sum += reader.ReadElementContentAsInt();
                ++count;
            }
            var bytes = BitConverter.GetBytes((int)(sum / count));
            output.Write(bytes, 0, bytes.Length);
        }
    }

    class ManualXML3
    {

        public static void GeneratedStages(byte[] input, Stream output)
        {
            var result = Int32ToBytes.Transduce(Minimum.Transduce(DBLPYear.Transduce(UTF8ToUTF16.Transduce(input)))).ToArray();
            output.Write(result, 0, result.Length);
        }

        public static void HandOptimized(byte[] input, Stream output)
        {
            var asString = System.Text.Encoding.UTF8.GetString(input);
            var doc = new XmlDocument();
            doc.LoadXml(asString);
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            var nodes = doc.DocumentElement.SelectNodes("/dblp/article/year", nsmgr);
            int minimum = 2147483647;
            foreach (XmlNode yearNode in nodes)
            {
                int year = int.Parse(yearNode.InnerText);
                if (year < minimum)
                {
                    minimum = year;
                }
            }
            var bytes = BitConverter.GetBytes(minimum);
            output.Write(bytes, 0, bytes.Length);
        }

        public static void XPathReaderVersion(Stream input, Stream output)
        {
            var reader = new XPathReader(new StreamReader(input), "/dblp/article/year");
            int minimum = 2147483647;
            while (reader.ReadUntilMatch())
            {
                int year = reader.ReadElementContentAsInt();
                if (year < minimum)
                {
                    minimum = year;
                }
            }
            var bytes = BitConverter.GetBytes(minimum);
            output.Write(bytes, 0, bytes.Length);
        }
    }

    class ManualXML4
    {

        public static void GeneratedStages(byte[] input, Stream output)
        {
            var result = Int32ToBytes.Transduce(Minimum.Transduce(MondialCityPopulation.Transduce(UTF8ToUTF16.Transduce(input)))).ToArray();
            output.Write(result, 0, result.Length);
        }

        public static void HandOptimized(byte[] input, Stream output)
        {
            var asString = System.Text.Encoding.UTF8.GetString(input);
            var doc = new XmlDocument();
            doc.LoadXml(asString);
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            var nodes = doc.DocumentElement.SelectNodes("/mondial/country/city/population", nsmgr);
            int maximum = -2147483648;
            foreach (XmlNode popNode in nodes)
            {
                int pop = int.Parse(popNode.InnerText);
                if (pop > maximum)
                {
                    maximum = pop;
                }
            }
            var bytes = BitConverter.GetBytes(maximum);
            output.Write(bytes, 0, bytes.Length);
        }

        public static void XPathReaderVersion(Stream input, Stream output)
        {
            var reader = new XPathReader(new StreamReader(input), "/mondial/country/city/population");
            int maximum = -2147483648;
            while (reader.ReadUntilMatch())
            {
                int pop = reader.ReadElementContentAsInt();
                if (pop > maximum)
                {
                    maximum = pop;
                }
            }
            var bytes = BitConverter.GetBytes(maximum);
            output.Write(bytes, 0, bytes.Length);
        }
    }
}
