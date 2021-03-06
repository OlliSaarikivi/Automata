﻿using System;
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
                Console.WriteLine("Usage: tool.exe <project.csproj> <output_directory>");
                return;
            }

#if !DEBUG
            try
            {
#endif
                if (args.Length > 2)
                    CSharpParser.GenerateCodeForProject(args[0], args[1], onlyTypes: args.Skip(2));
                else
                    CSharpParser.GenerateCodeForProject(args[0], args[1]);
#if !DEBUG
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
#endif

            sw.Stop();
            Console.WriteLine("Process took " + sw.Elapsed.TotalSeconds + " seconds (" + sw.Elapsed + ")");
        }
    }
}
