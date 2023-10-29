using System.Diagnostics;

using Archimedes.DeprecatedBranch;

namespace Archimedes.Debug
{
    internal static class SortComputing
    {        
        internal static void Sort4Performance (Random random)
        {
            int iterations = 1000000;

            Stopwatch stopwatch = Stopwatch.StartNew ();

            for (int i = 0; i < iterations; i++)
            {
                int [] array = new int [4];

                array [0] = random.Next ();
                array [1] = random.Next ();
                array [2] = random.Next ();
                array [3] = random.Next ();

                stopwatch.Start ();

                array.Sort4 ();

                stopwatch.Stop ();
            }

            double noloopTime = (double)stopwatch.ElapsedTicks / (double)TimeSpan.TicksPerSecond;

            stopwatch.Reset ();

            for (int i = 0; i < iterations; i++)
            {
                int [] array = new int [4];

                array [0] = random.Next ();
                array [1] = random.Next ();
                array [2] = random.Next ();
                array [3] = random.Next ();

                stopwatch.Start ();

                array.InsertionSort ();

                stopwatch.Stop ();
            }

            double loopTime = (double)stopwatch.ElapsedTicks / (double)TimeSpan.TicksPerSecond;

            Console.WriteLine ("noloop time = {0} sec", noloopTime);
            Console.WriteLine ("loop time = {0} sec", loopTime);
            Console.WriteLine ("noloop acceleration = {0:F3}", loopTime / noloopTime);
        }
    }
}