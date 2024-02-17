﻿using System.Numerics;

namespace Archimedes
{
    public static class Sort
    {
        // Значение по-умолчанию для чанка при сортировке вставкой.
        private const int MergeSortChunk = 64;

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
            array.InsertionSortSubarray (0, array.Length - 1);
        }

        /// <summary>
        /// Сортировка вставкой по возрастанию подмассива [<paramref name="beginIndex"/> .. <paramref name="endIndex"/>].
        /// </summary>
        private static void InsertionSortSubarray<T> (this T [] array, int beginIndex, int endIndex) where T : INumber<T>
        {
            for (int i = beginIndex + 1; i <= endIndex; i++)
            {
                T   key = array [i];
                int j   = i - 1;

                while ((j >= beginIndex) && (key < array [j]))
                {
                    array [j + 1] = array [j];
                    j--;
                }

                array [j + 1] = key;
            }
        }

        /// <summary>
        /// Сортировка слиянием по возрастанию.
        /// </summary>
        /// <param name="chunk">Рекурсивный спуск продолжается до тех пор, пока длина подмассива больше <paramref name="chunk"/>. Как 
        /// только она становится равной <paramref name="chunk"/>, рекурсивный спуск останавливается и подмассив сортируется 
        /// сортировкой вставкой.</param>
        public static void MergeSort<T> (this T [] array, int chunk = MergeSortChunk) where T : INumber<T>
        {
            array.MergeSortSubarray (0, array.Length - 1, chunk);
        }

        /// <summary>
        /// Сортировка слиянием по возрастанию подмассива [<paramref name="beginIndex"/> .. <paramref name="endIndex"/>].
        /// </summary>
        /// <param name="chunk">Рекурсивный спуск продолжается до тех пор, пока длина подмассива больше <paramref name="chunk"/>. Как 
        /// только она становится равной <paramref name="chunk"/>, рекурсивный спуск останавливается и подмассив сортируется 
        /// сортировкой вставкой.</param>
        private static void MergeSortSubarray<T> (this T [] array, int beginIndex, int endIndex, int chunk) where T : INumber<T>
        {
            int subarrayLength = endIndex - beginIndex + 1;

            if (subarrayLength > chunk)
            {
                // Разделение сортируемого подмассива на два «равных» подмассива left и right.

                int leftSubarrayEndIndex = (beginIndex + endIndex) >> 1;

                array.MergeSortSubarray (beginIndex, leftSubarrayEndIndex, chunk);
                array.MergeSortSubarray (leftSubarrayEndIndex + 1, endIndex, chunk);

                T [] left  = new T [leftSubarrayEndIndex - beginIndex + 1];
                T [] right = new T [endIndex - leftSubarrayEndIndex];

                Array.Copy (array, beginIndex, left, 0, left.Length);
                Array.Copy (array, leftSubarrayEndIndex + 1, right, 0, right.Length);

                // Комбинирование – слияние подмассивов left и right.

                int leftIterator     = 0;
                int rightIterator    = 0;
                int subarrayIterator = beginIndex;

                while ((leftIterator < left.Length) && (rightIterator < right.Length))
                {
                    if (left [leftIterator] <= right [rightIterator])
                    {
                        array [subarrayIterator++] = left [leftIterator++];
                    }

                    else
                    {
                        array [subarrayIterator++] = right [rightIterator++];
                    }
                }

                while (leftIterator < left.Length)
                {
                    array [subarrayIterator++] = left [leftIterator++];
                }

                while (rightIterator < right.Length)
                {
                    array [subarrayIterator++] = right [rightIterator++];
                }
            }

            else array.InsertionSortSubarray (beginIndex, endIndex);
        }

        /// <summary>
        /// Пирамидальная сортировка по возрастанию.
        /// </summary>
        public static void HeapSort<T> (this T [] array) where T : INumber<T>
        {
            int lastHeapIndex = array.Length - 1;

            array.BuildMaxHeap ();

            while (lastHeapIndex >= 1)
            {
                array.Swap (0, lastHeapIndex);
                lastHeapIndex--;
                array.MaxHeapify (0, (lastHeapIndex + 1) >> 1 , lastHeapIndex);
            }
        }
    }
}