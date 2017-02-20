$targets = @("B64ToWindowedAverageToB64","UTF8MaxCol3IntB64","B64FormattedDeltaUTF8","FormattedLineCount","HuffmanToLCBytes","SafeFibonacciBytes","CSV1abc","CSV2abc","CSV3abc","CSV4abc","CSV5abc","CSV6abc","CSV7abc","XML1abc","XML2abc","XML3abc","XML4abc")

if ($Args.Count -gt 0) {
    $targets = $args
}

foreach ($target in $targets) {
    echo $target
    $sw = [Diagnostics.Stopwatch]::StartNew()
    $app = Start-Process -PassThru -RedirectStandardOutput "compiler_bench\$target.out" -RedirectStandardError "compiler_bench\$target.err" -FilePath '..\TransducerCompiler\ConsoleApp\bin\Release\TransducerCompiler.exe' -ArgumentList "TransducerBenchmarks.csproj","compiler_bench\",$target
    $app.WaitForExit(3600*1000)
    $sw.Stop()
    if ($app.HasExited) {
        $sw.Elapsed > "compiler_bench\$target.result"
    } else {
        "Timeout" > "compiler_bench\$target.result"
    }
    $app.Kill()
}