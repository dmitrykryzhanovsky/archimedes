using System.Numerics;

namespace Archimedes
{
    public static class Sort
    {
        // Значение по-умолчанию для чанка при сортировке вставкой.
        private const int MergeSortChunk = 64;

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

        /// <summary>
        /// Сортировка слиянием массива <paramref name="array"/> по возрастанию.
        /// </summary>
        /// <param name="chunk">Рекурсивный спуск продолжается до тех пор, пока длина подмассива больше <paramref name="chunk"/>. Как 
        /// только она становится равной <paramref name="chunk"/>, рекурсивный спуск останавливается и подмассив сортируется 
        /// сортировкой вставкой.</param>
        public static void MergeSort<T> (this T [] array, int chunk = MergeSortChunk) where T : INumber<T>
        {
            array.MergeSort (0, array.Length - 1, chunk);
        }

        /// <summary>
        /// Сортировка слиянием подмассива <paramref name="array"/> [<paramref name="beginIndex"/> .. <paramref name="endIndex"/>] по 
        /// возрастанию.
        /// </summary>
        /// <param name="chunk">Рекурсивный спуск продолжается до тех пор, пока длина подмассива больше <paramref name="chunk"/>. Как 
        /// только она становится равной <paramref name="chunk"/>, рекурсивный спуск останавливается и подмассив сортируется 
        /// сортировкой вставкой.</param>
        public static void MergeSort<T> (this T [] array, int beginIndex, int endIndex, int chunk) where T : INumber<T>
        {
            int subarrayLength = endIndex - beginIndex + 1;

            if (subarrayLength > chunk)
            {
                // Разделение сортируемого подмассива на два «равных» подмассива left и right.

                int leftSubarrayEndIndex = (beginIndex + endIndex) >> 1;

                array.MergeSort (beginIndex, leftSubarrayEndIndex, chunk);
                array.MergeSort (leftSubarrayEndIndex + 1, endIndex, chunk);

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

            else array.InsertionSort (beginIndex, endIndex);
        }

        /// <summary>
        /// Пирамидальная сортировка массива <paramref name="array"/> по возрастанию.
        /// </summary>
        public static void HeapSort<T> (this T [] array) where T : INumber<T>
        {
            int lastHeapIndex  = array.Length - 1;

            array.BuildMaxHeap (HeapExtension.GetFirstLeafIndex (array.Length), lastHeapIndex);

            while (lastHeapIndex >= 1)
            {
                array.Swap (0, lastHeapIndex);
                lastHeapIndex--;
                array.MaxHeapify (0, HeapExtension.GetFirstLeafIndex (lastHeapIndex + 1), lastHeapIndex);
            }
        }
    }
}