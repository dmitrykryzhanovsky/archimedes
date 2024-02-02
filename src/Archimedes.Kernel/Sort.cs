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
    }
}