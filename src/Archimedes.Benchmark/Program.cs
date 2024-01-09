using Archimedes.Benchmark.Collections;

using BenchmarkDotNet.Running;

namespace Archimedes.Benchmark
{
    internal class Program
    {
        static void Main (string [] args)
        {
            BenchmarkRunner.Run<LoopNoLoopSortHypothesis> ();
        }
    }
}