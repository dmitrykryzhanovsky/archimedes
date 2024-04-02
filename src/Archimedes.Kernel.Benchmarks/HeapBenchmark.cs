using BenchmarkDotNet.Attributes;

namespace Archimedes.Benchmarks
{
    [MemoryDiagnoser]
    public class HeapBenchmark
    {
        private readonly int iterations = 1000;

        [Benchmark (Baseline = true)]
        public void MaxHeapify_Array ()
        {
            int [] array     = new int [] { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };
            int    firstLeaf = array.Length / 2;
            int    lastLeaf  = array.Length - 1;

            for (int loop = 0; loop < iterations; loop++)
            {
                array.MaxHeapify (0, firstLeaf, lastLeaf);

                array [0] = 0;
                array [lastLeaf] = 27;
            }
        }

        [Benchmark]
        public void MaxHeapify_List ()
        {
            List<int> list      = new List<int> { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };
            int       firstLeaf = list.Count / 2;
            int       lastLeaf  = list.Count - 1;

            for (int loop = 0; loop < iterations; loop++)
            {
                list.MaxHeapify (0, firstLeaf, lastLeaf);

                list [0] = 0;
                list [lastLeaf] = 27;
            }
        }
    }
}