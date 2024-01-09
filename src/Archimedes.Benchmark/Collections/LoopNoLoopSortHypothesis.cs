using Archimedes.DeprecatedBranch;

using BenchmarkDotNet.Attributes;

using System;

namespace Archimedes.Benchmark.Collections
{
    // ГИПОТЕЗА. No-loop сортировки для массивов очень малой длины реализованы, чтобы избежать для них вызова общих алгоритмов.
    // Фактически в этом коде выполнена развёртка цикла, что позволяет сократить количество выполняемых операций.

    // РЕЗУЛЬТАТ. Гипотеза не оправдалась. Все запущенные численные эксперименты показывают, что обычный InsertionSort работает в
    // среднем в 1.05 раза быстрее, чем no-loop варианты. (Возможно, это связано с тем, что в InsertionSort нет Swap в чистом
    // виде).
    [MemoryDiagnoser]
    public class LoopNoLoopSortHypothesis
    {
        private Random random = new Random ();

        [Benchmark(Baseline = true)]
        public void NoLoop ()
        {
            int iterations = 10000000;

            for (int i = 0; i < iterations; i++)
            {
                int [] array = new int [4];

                array [0] = random.Next ();
                array [1] = random.Next ();
                array [2] = random.Next ();
                array [3] = random.Next ();

                array.Sort4 ();
            }
        }

        [Benchmark]
        public void Loop ()
        {
            int iterations = 10000000;

            for (int i = 0; i < iterations; i++)
            {
                int [] array = new int [4];

                array [0] = random.Next ();
                array [1] = random.Next ();
                array [2] = random.Next ();
                array [3] = random.Next ();

                array.InsertionSort ();
            }
        }
    }
}