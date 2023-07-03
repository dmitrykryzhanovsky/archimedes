using System;

namespace Archimedes.Debug
{
    internal static class Program
    {
        private static void Main ()
        {
            RunTimeDebug.MultidimensionalArray ();

            Console.WriteLine ("\nPress any key...");
            Console.ReadKey ();
        }
    }
}