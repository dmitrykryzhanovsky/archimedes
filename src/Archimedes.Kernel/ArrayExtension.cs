namespace Archimedes
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Копирует одномерный массив source в двумерный массив destination.
        /// </summary>
        /// <remarks>Длины (общее количество элементов) массивов source и destination должны быть одинаковыми. Если длины будут разными, 
        /// поведение метода не документируется.</remarks>
        public static void CopyTo<T> (this T [] source, T [,] destination)
        {
            int heigth = destination.GetLength (0);
            int width  = destination.GetLength (1);

            int sourceIterator = 0;

            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    destination [i, j] = source [sourceIterator++];
                }
            }
        }

        /// <summary>
        /// Копирует двумерный массив source в двумерный массив destination.
        /// </summary>
        /// <remarks>Массивы source и destination должны иметь одинаковые размеры по обоим измерениям. Если размеры будут разными, 
        /// поведение метода не документируется.</remarks>
        public static void CopyTo<T> (this T [,] source, T [,] destination)
        {
            int heigth = destination.GetLength (0);
            int width  = destination.GetLength (1);

            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    destination [i, j] = source [i, j];
                }
            }
        }

        /// <summary>
        /// Возвращает true, если массивы array1 и array2 имеют одинаковую длину и поэлементно равны; в противном случае false.
        /// </summary>
        public static bool Equals<T> (this T [] array1, T [] array2)
        {
            if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (!array1 [i].Equals (array2 [i])) return false;
                }

                return true;
            }

            else return false;
        }

        /// <summary>
        /// Возвращает true, если массивы array1 и array2 имеют одинаковые размеры по каждому измерению и поэлементно равны; в противном 
        /// случае false.
        /// </summary>
        public static bool Equals<T> (this T [,] array1, T [,] array2)
        {
            if ((array1.GetLength (0) == array2.GetLength (0)) && 
                (array1.GetLength (1) == array2.GetLength (1)))
            {
                int heigth = array1.GetLength (0);
                int width  = array1.GetLength (1);

                for (int i = 0; i < heigth; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (!array1 [i, j].Equals (array2 [i, j])) return false;
                    }
                }

                return true;
            }

            else return false;
        }
    }
}