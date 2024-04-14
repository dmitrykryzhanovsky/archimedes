using BenchmarkDotNet.Attributes;

namespace Archimedes.Benchmarks
{
    [MemoryDiagnoser]
    public class SortBenchmark
    {
        private readonly Random random = new Random ();

        private readonly int N = 1000;

        [Benchmark]
        public void SelectionSort ()
        {
            int [] array = new int [N];

            for (int i = 0; i < N; i++)
            {
                array [i] = random.Next ();
            }

            array.SelectionSort ();
        }

        [Benchmark (Baseline = true)]
        public void InsertionSort ()
        {
            int [] array = new int [N];

            for (int i = 0; i < N; i++)
            {
                array [i] = random.Next ();
            }

            array.InsertionSort ();
        }

        [Benchmark]
        public void MergeSort ()
        {
            int [] array = new int [N];

            for (int i = 0; i < N; i++)
            {
                array [i] = random.Next ();
            }

            array.MergeSort (64);
        }

        //[Benchmark (Baseline = true)]
        //public void MergeSort_Chunk_1 ()
        //{
        //    int [] array = new int [N];

        //    for (int i = 0; i < N; i++)
        //    {
        //        array [i] = random.Next ();
        //    }

        //    array.MergeSort (1);
        //}

        //[Benchmark]
        //public void MergeSort_Chunk_2 ()
        //{
        //    int [] array = new int [N];

        //    for (int i = 0; i < N; i++)
        //    {
        //        array [i] = random.Next ();
        //    }

        //    array.MergeSort (2);
        //}

        //[Benchmark]
        //public void MergeSort_Chunk_4 ()
        //{
        //    int [] array = new int [N];

        //    for (int i = 0; i < N; i++)
        //    {
        //        array [i] = random.Next ();
        //    }

        //    array.MergeSort (4);
        //}

        //[Benchmark]
        //public void MergeSort_Chunk_8 ()
        //{
        //    int [] array = new int [N];

        //    for (int i = 0; i < N; i++)
        //    {
        //        array [i] = random.Next ();
        //    }

        //    array.MergeSort (8);
        //}

        //[Benchmark]
        //public void MergeSort_Chunk_16 ()
        //{
        //    int [] array = new int [N];

        //    for (int i = 0; i < N; i++)
        //    {
        //        array [i] = random.Next ();
        //    }

        //    array.MergeSort (16);
        //}

        //[Benchmark]
        //public void MergeSort_Chunk_32 ()
        //{
        //    int [] array = new int [N];

        //    for (int i = 0; i < N; i++)
        //    {
        //        array [i] = random.Next ();
        //    }

        //    array.MergeSort (32);
        //}

        //[Benchmark]
        //public void MergeSort_Chunk_64 ()
        //{
        //    int [] array = new int [N];

        //    for (int i = 0; i < N; i++)
        //    {
        //        array [i] = random.Next ();
        //    }

        //    array.MergeSort (64);
        //}

        //[Benchmark]
        //public void MergeSort_Chunk_128 ()
        //{
        //    int [] array = new int [N];

        //    for (int i = 0; i < N; i++)
        //    {
        //        array [i] = random.Next ();
        //    }

        //    array.MergeSort (128);
        //}

        //[Benchmark]
        //public void MergeSort_Chunk_256 ()
        //{
        //    int [] array = new int [N];

        //    for (int i = 0; i < N; i++)
        //    {
        //        array [i] = random.Next ();
        //    }

        //    array.MergeSort (256);
        //}

        //[Benchmark]
        //public void MergeSort_Chunk_512 ()
        //{
        //    int [] array = new int [N];

        //    for (int i = 0; i < N; i++)
        //    {
        //        array [i] = random.Next ();
        //    }

        //    array.MergeSort (512);
        //}
    }
}