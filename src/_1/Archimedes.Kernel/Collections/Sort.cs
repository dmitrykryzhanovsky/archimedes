using System.Numerics;

namespace Archimedes
{
    public static class Sort
    {
        /// <summary>
        /// Сортировка выбором массива чисел по возрастанию.
        /// </summary>
        public static void SelectionSort<T> (this T [] array) where T : INumber<T>
        {
            int endIndex = array.Length - 1;

            for (int i = 0; i < endIndex; i++)
            {
                array.Swap (i, array.FindMinIndex (i, endIndex));
            }
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

        public static void MergeSort<T> (this T [] array, int chunk = 1) where T : INumber<T>
        {
            MergeSortSubarray (array, 0, array.Length - 1, chunk);
        }

        private static void MergeSortSubarray<T> (this T [] subarray, int beginIndex, int endIndex, int chunk) where T : INumber<T>
        {
            // Если длина сортируемого подмассива больше chunk, осуществляем рекурсивный спуск.

            if (subarray.Length > chunk)
            {
                // Разделение массива на два равных подмассива.

                int partLength   = subarray.Length / 2;
                int leftEndIndex = beginIndex + partLength - 1;

                MergeSortSubarray (subarray, beginIndex, leftEndIndex, chunk);
                MergeSortSubarray (subarray, leftEndIndex + 1, endIndex, chunk);

                // Слияние (merge) двух отсортированных подмассивов следующего уровня left и right.

                T [] left  = new T [partLength];
                T [] right = new T [subarray.Length - partLength];

                subarray.CopyToSubarray (left, beginIndex, leftEndIndex);
                subarray.CopyToSubarray (right, leftEndIndex + 1, endIndex);

                int leftIterator     = 0;
                int rightIterator    = 0;
                int subarrayIterator = beginIndex;

                while ((leftIterator < left.Length) && (rightIterator < right.Length))
                {
                    if (left [leftIterator] <= right [rightIterator])
                    {
                        subarray [subarrayIterator++] = left [leftIterator++];
                    }

                    else
                    {
                        subarray [subarrayIterator++] = right [rightIterator++];
                    }
                }

                if (leftIterator < left.Length)
                {
                    for (int i = leftIterator; i < left.Length; i++)
                    {
                        subarray [subarrayIterator++] = left [i];
                    }
                }

                else
                {
                    for (int i = rightIterator; i < right.Length; i++)
                    {
                        subarray [subarrayIterator++] = right [i];
                    }
                }
            }

            // Если длина сортируемого подмассива равна chunk, то рекурсивный спуск останавливаем и сортируем подмассив InsertionSort.
        }
    }
}