using System.Numerics;

namespace Archimedes
{
    public static class Sort
    {
        /// <summary>
        /// Сортировка вставкой массива <paramref name="array"/> по возрастанию.
        /// </summary>
        public static void InsertionSort<T> (this T [] array) where T : INumber<T>
        {
            InsertionSort (array, 0, array.Length - 1);
        }

        /// <summary>
        /// Сортировка вставкой подмассива <paramref name="array"/> [<paramref name="beginIndex"/> .. <paramref name="endIndex"/>] по 
        /// возрастанию.
        /// </summary>
        public static void InsertionSort<T> (this T [] array, int beginIndex, int endIndex) where T : INumber<T>
        {
            for (int i = beginIndex + 1; i <= endIndex; i++)
            {
                T   key = array [i];
                int j   = i - 1;
                
                while ((key < array [j]) && (j >= beginIndex))
                {
                    array [j + 1] = array [j];
                    j--;
                }

                array [j + 1] = key;
            }
        }
    }
}