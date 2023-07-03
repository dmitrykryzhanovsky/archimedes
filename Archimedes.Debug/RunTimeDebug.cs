using System;

namespace Archimedes.Debug
{
    internal static class RunTimeDebug
    {
        /// <summary>
        /// Так как я не могу запомнить, в каком порядке метод GetLength () выдаёт размеры массива, пришлось написать этот короткий 
        /// тестик-напоминалку.
        /// </summary>
        internal static void MultidimensionalArray ()
        {
            int [,,,] array = new int [2, 3, 5, 7];

            Console.WriteLine ("GetLength (0) = {0}", array.GetLength (0));
            Console.WriteLine ("GetLength (1) = {0}", array.GetLength (1));
            Console.WriteLine ("GetLength (2) = {0}", array.GetLength (2));
            Console.WriteLine ("GetLength (3) = {0}", array.GetLength (3));
            Console.WriteLine ("Length = {0}", array.Length);
        }
    }
}