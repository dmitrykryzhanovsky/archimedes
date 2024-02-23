using BenchmarkDotNet.Running;

namespace Archimedes.Benchmarks
{
    internal class Program
    {
        private static void Main (string [] args)
        {
            BenchmarkRunner.Run<HeapBenchmark> ();
        }
    }
}