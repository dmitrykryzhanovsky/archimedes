using Archimedes;

using BenchmarkDotNet.Attributes;

using System;

namespace Archimedes.Benchmark.Collections
{
    [MemoryDiagnoser]
    public class Sort
    {
        private int N = 1024;

        private int Iterations = 10000000;

        int [] selection;
        int [] insertion;
        int [] merge;

        private Random random = new Random ();

        public Sort (int x)
        {
            int [] selection = new int [N];
            int [] insertion = new int [N];
            int [] merge     = new int [N];

            for (int i = 0; i < N; i++)
            {
                int next = random.Next ();

                selection [i] = next;
                insertion [i] = next;
                merge [i]     = next;
            }
        }

        [Benchmark]
        public void SelectionSort ()
        {
            selection.SelectionSort ();
        }

        [Benchmark(Baseline = true)]
        public void InsertionSort ()
        {
            insertion.InsertionSort ();
        }

        [Benchmark]
        public void MergeSort ()
        {
            merge.MergeSort ();
        }
    }
}