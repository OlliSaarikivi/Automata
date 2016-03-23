using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();

            if (args.Length < 2)
            {
                Console.Error.WriteLine("Two arguments are required: a project file and an output directory.");
            }

#if !DEBUG
            try
            {
#endif
                if (args.Length > 2)
                    Compiler.Compile(args[0], args[1], false, args.Skip(2));
                else
                    Compiler.Compile(args[0], args[1], false);
#if !DEBUG
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
#endif
            sw.Stop();
            Console.WriteLine("Process took " + sw.Elapsed.TotalSeconds + " seconds (" + sw.Elapsed + ")");

            Console.WriteLine("Done");
        }
    }
}
