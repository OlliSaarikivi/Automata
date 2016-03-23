// TODO: fix this. I (Olli Saarikivi) gave up getting the compiler to be called as a proper MSBuild task
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Build.Utilities;
using Microsoft.Build.Framework;

namespace Microsoft.Automata.CSharpFrontend
{
    public class CompileTransducerTask : Task
    {
        [Required]
        public string OutDir { get; set; }

        public override bool Execute()
        {
            try
            {
                var projectFileName = BuildEngine.ProjectFileOfTaskNode;
                Compiler.Compile(projectFileName, OutDir);
            }
            catch (Exception e)
            {
                Log.LogErrorFromException(e);
                return false;
            }
            return true;
        }
    }
}
*/