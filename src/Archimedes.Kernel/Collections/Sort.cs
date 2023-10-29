using System.Numerics;

namespace Archimedes
{
    public static class Sort
    {       
        #region Сортировка вставкой

        /// <summary>
        /// Сортировка вставкой массива чисел по возрастанию.
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

        /// <summary>
        /// Сортировка вставкой массива чисел по убыванию.
        /// </summary>
        public static void InsertionSortDesc<T> (this T [] array) where T : INumber<T>
        {
            for (int i = 1; i < array.Length; i++)
            {
                T   key = array [i];
                int j   = i - 1;

                while ((j >= 0) && (key > array [j]))
                {
                    array [j + 1] = array [j];
                    j--;
                }

                array [j + 1] = key;
            }
        }

        /// <summary>
        /// Сортировка вставкой массива элементов произвольного типа по возрастанию.
        /// </summary>
        /// <param name="comparer">Компаратор для сравнения объектов типа <typeparamref name="T"/>.</param>
        public static void InsertionSort<T> (this T [] array, IComparer<T> comparer)
        {
            for (int i = 1; i < array.Length; i++)
            {
                T   key = array [i];
                int j   = i - 1;

                while ((j >= 0) && (comparer.Compare (key, array [j]) < 0))
                {
                    array [j + 1] = array [j];
                    j--;
                }

                array [j + 1] = key;
            }
        }

        /// <summary>
        /// Сортировка вставкой массива элементов произвольного типа по убыванию.
        /// </summary>
        /// <param name="comparer">Компаратор для сравнения объектов типа <typeparamref name="T"/>.</param>
        public static void InsertionSortDesc<T> (this T [] array, IComparer<T> comparer)
        {
            for (int i = 1; i < array.Length; i++)
            {
                T   key = array [i];
                int j   = i - 1;

                while ((j >= 0) && (comparer.Compare (key, array [j]) > 0))
                {
                    array [j + 1] = array [j];
                    j--;
                }

                array [j + 1] = key;
            }
        }

        #endregion
    }
}