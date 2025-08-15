namespace Archimedes
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Поэлементное сравнение одномерных массивов.
        /// </summary>
        /// <returns>Возвращает TRUE, если массивы array1 и array2 имеют одинаковую длину и на одних и тех же позициях содержат 
        /// одинаковые элементы. В противном случае FALSE.</returns>
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
        /// Поэлементное сравнение двумерных массивов.
        /// </summary>
        /// <returns>Возвращает TRUE, если массивы array1 и array2 имеют одинаковые длины по обоим измерениям и на одних и тех же 
        /// позициях содержат одинаковые элементы. В противном случае FALSE.</returns>
        public static bool Equals<T> (this T [,] array1, T [,] array2)
        {
            int height = array1.GetLength (0);
            int width  = array1.GetLength (1);

            if ((height == array2.GetLength (0)) && (width == array2.GetLength (1)))
            {
                for (int i = 0; i < height; i++)
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