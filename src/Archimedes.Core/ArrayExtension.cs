using System.Numerics;

namespace Archimedes
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Копирует одномерный массив source в одномерный массив destination.
        /// </summary>
        /// <remarks>Память под массив destination уже должна быть выделена.</remarks>
        public static void CopyTo<T> (this T [] source, T [] destination)
        {
            source.CopyTo (destination, 0);
        }

        /// <summary>
        /// Копирует одномерный массив source в двумерный массив destination. Длина массива source должна быть равна общей длине 
        /// массива destination.
        /// </summary>
        /// <remarks>Память под массив destination уже должна быть выделена.</remarks>
        public static void CopyTo<T> (this T [] source, T [,] destination)
        {
            int height = destination.GetLength (0);
            int width  = destination.GetLength (1);

            int sourceIterator = 0;

            for (int i = 0; i < height; i++)
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
        /// <remarks>Память под массив destination уже должна быть выделена.</remarks>
        public static void CopyTo<T> (this T [,] source, T [,] destination)
        {
            int height = source.GetLength (0);
            int width  = source.GetLength (1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    destination [i, j] = source [i, j];
                }
            }
        }

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

        public static void Add<T> (this T [] array1, T [] array2, T [] sum) where T : INumber<T>
        {
            for (int i = 0; i < array1.Length; i++)
            {
                sum [i] = array1 [i] + array2 [i];
            }
        }

        public static void Add<T> (this T [,] array1, T [,] array2, T [,] sum) where T : INumber<T>
        {
            int height = array1.GetLength (0);
            int width  = array1.GetLength (1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    sum [i, j] = array1 [i, j] + array2 [i, j];
                }
            }
        }

        public static void AddTo<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            for (int i = 0; i < array1.Length; i++)
            {
                array1 [i] += array2 [i];
            }
        }

        public static void AddTo<T> (this T [,] array1, T [,] array2) where T : INumber<T>
        {
            int height = array1.GetLength (0);
            int width  = array1.GetLength (1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    array1 [i, j] += array2 [i, j];
                }
            }
        }

        public static void Subtract<T> (this T [] array1, T [] array2, T [] difference) where T : INumber<T>
        {
            for (int i = 0; i < array1.Length; i++)
            {
                difference [i] = array1 [i] - array2 [i];
            }
        }

        public static void Subtract<T> (this T [,] array1, T [,] array2, T [,] difference) where T : INumber<T>
        {
            int height = array1.GetLength (0);
            int width  = array1.GetLength (1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    difference [i, j] = array1 [i, j] - array2 [i, j];
                }
            }
        }

        public static void SubtractTo<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            for (int i = 0; i < array1.Length; i++)
            {
                array1 [i] -= array2 [i];
            }
        }

        public static void SubtractTo<T> (this T [,] array1, T [,] array2) where T : INumber<T>
        {
            int height = array1.GetLength (0);
            int width  = array1.GetLength (1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    array1 [i, j] -= array2 [i, j];
                }
            }
        }

        public static void Negate<T> (this T [] array, T [] negated) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                negated [i] = -array [i];
            }
        }

        public static void NegateTo<T> (this T [] array) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                array [i] = -array [i];
            }
        }

        public static void Multiply<T> (this T [] array, T coefficient, T [] product) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                product [i] = array [i] * coefficient;
            }
        }

        public static void MultiplyTo<T> (this T [] array, T coeffcieitn) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                array [i] *= coeffcieitn;
            }
        }

        public static void Divide<T> (this T [] array, T coefficient, T [] quotient) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                quotient [i] = array [i] / coefficient;
            }
        }

        public static void DivideTo<T> (this T [] array, T coeffcieitn) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                array [i] /= coeffcieitn;
            }
        }
    }
}