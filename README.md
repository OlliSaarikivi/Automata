# Automata
Automata is a .NET library that provides algorithms for composing and analyzing _regular expressions_, _automata_, and _transducers_. In addition to classical word automata, it also includes algorithms for analysis of _tree automata_ and _tree transducers_. The library covers algorithms over finite alphabets as well as their _symbolic_ counterparts. In symbolic automata concrete characters have been replaced by _character predicates_. Such predicates can range over very large or even _infinite_ alphabets, like integers. Predicates can be supported by an SMT solver as a plugin.

# PLDI 2017

This branch includes the benchmarks described in the paper:

Olli Saarikivi, Margus Veanes, Todd Mytkowicz and Madan Musuvathi. Fusing Effectful Comprehensions. In *Proceedings of the 38th ACM SIGPLAN Conference on Programming Language Design and Implementation (PLDI'17)*. ACM, 2017.

To get started unpack the archive. The tool and benchmarks have been verified to work with:

-Windows 10
-.NET Framework 4.6

## Running the benchmarks

The `Main.sln` solution builds an executable containing all the benchmarks. To run this executable:

1. Run the native image generator (NGen) in the root folder with the command: `<ngen> install bin/Release/CSharpFrontend.Benchmark.exe` . NGen can be found in the .NET framework, typically under a path like `C:\Windows\Microsoft.NET\Framework\<latest version>\ngen.exe` . This step is necessary to replicate the test setup in the paper's evaluation.
2. Run the `<root>/RunBenchmarks.bat` batch script, which will invoke the benchmark executable.
\end{enumerate}

The benchmark program offers a choice of benchmarks to run (as a comma separated list of benchmark numbers), or one can run all benchmarks just by pressing enter. Note that benchmark number 62 is expected to crash with an OutOfMemoryException (as was reported in the paper).

For each benchmark a sufficient number of runs is measured until a 0.5 MB/s confidence interval at a 95\% confidence level has been achieved. The measurements for each benchmark are written to a separate timestamped file in `<root>/results/` .

\section{Modifying the benchmarks}

To get started with modifying the benchmarks open the `<root>/Main.sln` solution in Visual Studio 2015. The benchmarks are found in the `CSharpFrontend.Benchmark` project. Some source files of interest are:

-`Program.cs` includes the benchmarking framework as well as all the benchmark selection entry definitions.
-`Compositions.cs` defines the pipelines of transducers.
-`HandFused/All.cs` includes pipelines that have been composed with the method call fusion approach. These fusions do not currently have a code generator to produce them and have been produced by hand.
-`Manual*.cs` include the hand written pipelines that we compare against.
-`gen/*.cs` are generated source code for all pipelines in the project (that do not have the `[SuppressCodeGeneration()]` attribute).

Fusions of transducers are specified by extending `Composition<TInner, TOuter>`. No members for the class have to be defined, as the code generation will produce functions implementing the transduction in a separate file (note that the class must be declared `partial` to support the code generation).

After transducers have been modified the code generation process must be run again. The `<root>/RunCodeGeneration.bat` batch script will call `AutomataCSharpCLI.exe`, which will parse the `CSharpFrontend.Benchmark` project and find any transducer (or their fusion) definitions. For any transducers found the appropriate internal representation will be created, possibly fused with other transducers, pruned with reachability based branch elimination, and finally have code generated for it.

Finally after the code generation is done the solution should be rebuilt in Release mode. Note that the generated code can be large, which makes compiling the `CSharpFrontend.Benchmark` project slower than is common for C# projects.

## Compiler benchmarks

To benchmark the transducer compilation process itself there is a PowerShell script at `<root>/src/CSharpFrontend.Benchmark/benchmark_compiler.ps1`. It will do the code generation process for each transducer in a predefined list (at the top of the script) separately without sharing any work. For each transducer it will pipe output and the total runtime to files in the folder `<root>/src/CSharpFrontend.Benchmark/compiler_bench/`.

To run the script invoke it in Windows PowerShell.
