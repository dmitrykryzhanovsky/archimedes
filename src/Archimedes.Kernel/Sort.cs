using System.Numerics;

namespace Archimedes
{
    public static class Sort
    {
        /// <summary>
        /// Сортировка выбором по возрастанию.
        /// </summary>
        public static void SelectionSort<T> (this T [] array) where T : INumber<T>
        {
            int lastIndex = array.Length - 1;

            for (int i = 0; i < lastIndex; i++)
            {
                int minIndex = array.FindMinIndex (i, lastIndex);

                array.Swap (i, minIndex);
            }
        }

        /// <summary>
        /// Сортировка вставкой по возрастанию.
        /// </summary>
        public static void InsertionSort<T> (this T [] array) where T : INumber<T>
        {
            for (int i = 1; i < array.Length; i++)
            {
                T   key = array [i];
                int j   = i - 1;

                while ((j >= 0) && (key < array [j]))
                {
                    array [j + 1] = array [j];
                    j--;
                }

                array [j + 1] = key;
            }
        }
    }
}