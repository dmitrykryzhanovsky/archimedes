using BenchmarkDotNet.Attributes;

namespace Archimedes.Benchmarks
{
    [MemoryDiagnoser]
    public class PolynomialBenchmark
    {
        private readonly int iterations = 1000;

        [Benchmark (Baseline = true)]
        public void Horner_ByOperations ()
        {
            double [] a = new double [] { 2, -3, 5, 8, -13 };
            double    x = 2;

            for (int loop = 0; loop < iterations; loop++)
            {
                double y = a [a.Length - 1];

                for (int i = a.Length - 2; i >= 0; i--)
                {
                    y = x * y + a [i];
                }
            }
        }

        [Benchmark]
        public void Horner_ByFusedMultiplyAdd ()
        {
            double [] a = new double [] { 2, -3, 5, 8, -13 };
            double    x = 2;

            for (int loop = 0; loop < iterations; loop++)
            {
                double y = a [a.Length - 1];

                for (int i = a.Length - 2; i >= 0; i--)
                {
                    y = double.FusedMultiplyAdd (x, y, a [i]);
                }
            }
        }
    }
}