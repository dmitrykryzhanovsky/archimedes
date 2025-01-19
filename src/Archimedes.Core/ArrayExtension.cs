namespace Archimedes
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Копирует элементы из 2-мерного массива source в 2-мерный массив destination.
        /// </summary>
        /// <remarks>Размеры массивов source и destination должны совпадать по обоим измерениям.</remarks>
        public static void CopyTo<T> (this T [,] source, T [,] destination)
        {
            for (int i = 0; i < source.GetLength (0); i++)
            {
                for (int j = 0; j < source.GetLength (1); j++)
                {
                    destination [i, j] = source [i, j];
                }
            }
        }

        /// <summary>
        /// Возвращает TRUE, если массивы array1 и array2 равны, то есть имеют одинаковый размер и содержат на одинаковых позициях 
        /// одинаковые элементы. В противном случае FALSE.
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
        /// Возвращает TRUE, если массивы array1 и array2 равны, то есть имеют одинаковые размеры по обоим измерениям и содержат на 
        /// одинаковых позициях одинаковые элементы. В противном случае FALSE.
        /// </summary>
        public static bool Equals<T> (this T [,] array1, T [,] array2)
        {
            if ((array1.GetLength (0) == array2.GetLength (0)) &&
                (array1.GetLength (1) == array2.GetLength (1)))
            {
                for (int i = 0; i < array1.GetLength (0); i++)
                {
                    for (int j = 0; j < array1.GetLength (1); j++)
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