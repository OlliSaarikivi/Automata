using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Automata.Z3;
using Microsoft.Automata.CSharpFrontend;

namespace CSharpFrontend.Test
{
    [TestClass]
    public class BaseTests
    {
        [TestMethod]
        public void TestStringToTransducer()
        {
            string program = @"
class LineCount : Transducer<char, int>
{
    int count = 0;

    public override IEnumerable<int> Update(char c)
    {
        if (c == '\n')
        {
            count += 1;
        }
        yield break;
    }

    public override IEnumerable<int> Finish()
    {
        yield return count;
    }
}
";
            Z3Provider solver = new Z3Provider();
            var stbs = CSharpParser.FromString(solver, program);
            //stbs.First().ShowGraph();
        }
    }
}
