using System.Collections.Generic;
using System.Numerics;

namespace Archimedes
{
    public static class Sort
    {
        public static void Sort2<T> (this T [] array, int start = 0) where T : INumber<T>
        {
            if (array [start + 1] < array [start]) array.Swap (start, start + 1);
        }

        public static void Sort2Desc<T> (this T [] array, int start = 0) where T : INumber<T>
        {
            if (array [start + 1] > array [start]) array.Swap (start, start + 1);
        }

        public static void Sort3<T> (this T [] array, int start = 0) where T : INumber<T>
        {
            array.Sort2 ();
            
            if (array [start + 2] < array [start])
            {
                T temp = array [start + 2];

                array [start + 2] = array [start + 1];
                array [start + 1] = array [start];
                array [start]     = temp;
            }

            else if (array [start + 2] < array [start + 1]) array.Swap (start + 1, start + 2);
        }

        public static void Sort4<T> (this T [] array, int start = 0) where T : INumber<T>
        {
            array.Sort3 ();

            if (array [start + 3] < array [start])
            {
                T temp = array [start + 3];

                array [start + 3] = array [start + 2];
                array [start + 2] = array [start + 1];
                array [start + 1] = array [start];
                array [start]     = temp;
            }

            else if (array [start + 3] < array [start + 1])
            {
                T temp = array [start + 3];

                array [start + 3] = array [start + 2];
                array [start + 2] = array [start + 1];
                array [start + 1] = temp;
            }

            else if (array [start + 3] < array [start + 2]) array.Swap (start + 2, start + 3);
        }

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