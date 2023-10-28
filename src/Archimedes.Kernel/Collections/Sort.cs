using System.Numerics;

namespace Archimedes
{
    public static class Sort
    {
        #region No-loop сортировки для массивов длиной 2, 3 и 4

        // No-loop сортировки для массивов очень малой длины реализованы, чтобы избежать для них вызова общих алгоритмов.
        // Фактически в этом коде выполнена развёртка цикла, что позволяет сократить количество выполняемых операций.

        /// <summary>
        /// Сортировка подмассива из 2 элементов по возрастанию.
        /// </summary>
        /// <param name="startIndex">Стартовый индекс сортируемого подмассива.</param>
        public static void Sort2<T> (this T [] array, int startIndex = 0) where T : INumber<T>
        {
            if (array [startIndex + 1] < array [startIndex]) array.Swap (startIndex, startIndex + 1);
        }

        /// <summary>
        /// Сортировка подмассива из 2 элементов по убыванию.
        /// </summary>
        /// <param name="startIndex">Стартовый индекс сортируемого подмассива.</param>
        public static void Sort2Desc<T> (this T [] array, int startIndex = 0) where T : INumber<T>
        {
            if (array [startIndex + 1] > array [startIndex]) array.Swap (startIndex, startIndex + 1);
        }

        /// <summary>
        /// Сортировка подмассива из 3 элементов по возрастанию.
        /// </summary>
        /// <param name="startIndex">Стартовый индекс сортируемого подмассива.</param>
        public static void Sort3<T> (this T [] array, int startIndex = 0) where T : INumber<T>
        {
            array.Sort2 (startIndex);
            
            if (array [startIndex + 2] < array [startIndex])
            {
                T temp = array [startIndex + 2];

                array [startIndex + 2] = array [startIndex + 1];
                array [startIndex + 1] = array [startIndex];
                array [startIndex]     = temp;
            }

            else if (array [startIndex + 2] < array [startIndex + 1]) array.Swap (startIndex + 1, startIndex + 2);
        }

        /// <summary>
        /// Сортировка подмассива из 3 элементов по убыванию.
        /// </summary>
        /// <param name="startIndex">Стартовый индекс сортируемого подмассива.</param>
        public static void Sort3Desc<T> (this T [] array, int startIndex = 0) where T : INumber<T>
        {
            array.Sort2Desc (startIndex);

            if (array [startIndex + 2] > array [startIndex])
            {
                T temp = array [startIndex + 2];

                array [startIndex + 2] = array [startIndex + 1];
                array [startIndex + 1] = array [startIndex];
                array [startIndex]     = temp;
            }

            else if (array [startIndex + 2] > array [startIndex + 1]) array.Swap (startIndex + 1, startIndex + 2);
        }

        /// <summary>
        /// Сортировка подмассива из 4 элементов по возрастанию.
        /// </summary>
        /// <param name="startIndex">Стартовый индекс сортируемого подмассива.</param>
        public static void Sort4<T> (this T [] array, int startIndex = 0) where T : INumber<T>
        {
            array.Sort3 (startIndex);

            if (array [startIndex + 3] < array [startIndex])
            {
                T temp = array [startIndex + 3];

                array [startIndex + 3] = array [startIndex + 2];
                array [startIndex + 2] = array [startIndex + 1];
                array [startIndex + 1] = array [startIndex];
                array [startIndex]     = temp;
            }

            else if (array [startIndex + 3] < array [startIndex + 1])
            {
                T temp = array [startIndex + 3];

                array [startIndex + 3] = array [startIndex + 2];
                array [startIndex + 2] = array [startIndex + 1];
                array [startIndex + 1] = temp;
            }

            else if (array [startIndex + 3] < array [startIndex + 2]) array.Swap (startIndex + 2, startIndex + 3);
        }

        /// <summary>
        /// Сортировка подмассива из 4 элементов по убыванию.
        /// </summary>
        /// <param name="startIndex">Стартовый индекс сортируемого подмассива.</param>
        public static void Sort4Desc<T> (this T [] array, int startIndex = 0) where T : INumber<T>
        {
            array.Sort3Desc (startIndex);

            if (array [startIndex + 3] > array [startIndex])
            {
                T temp = array [startIndex + 3];

                array [startIndex + 3] = array [startIndex + 2];
                array [startIndex + 2] = array [startIndex + 1];
                array [startIndex + 1] = array [startIndex];
                array [startIndex]     = temp;
            }

            else if (array [startIndex + 3] > array [startIndex + 1])
            {
                T temp = array [startIndex + 3];

                array [startIndex + 3] = array [startIndex + 2];
                array [startIndex + 2] = array [startIndex + 1];
                array [startIndex + 1] = temp;
            }

            else if (array [startIndex + 3] > array [startIndex + 2]) array.Swap (startIndex + 2, startIndex + 3);
        }

        #endregion

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