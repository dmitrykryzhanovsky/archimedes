using System.Numerics;

namespace Archimedes
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Копирует 1-мерный массив sourceArray в 2-мерный массив destinationArray.
        /// </summary>
        /// <remarks>Длина 1-мерной массива sourceArray и полная длина 2-мерного массива destinationArray должны быть равны; в 
        /// противном случае корректная работа метода не гарантируется.</remarks>
        public static void CopyTo<T> (this T [] sourceArray, T [,] destinationArray)
        {
            int height   = destinationArray.GetLength (0);
            int width    = destinationArray.GetLength (1);
            int iterator = 0;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    destinationArray [i, j] = sourceArray [iterator++];
                }
            }
        }

        /// <summary>
        /// Копирует 2-мерный массив sourceArray в 2-мерный массив destinationArray.
        /// </summary>
        /// <remarks>Размеры массива sourceArray и размеры массива destinationArray должны быть равны; в противном случае корректная 
        /// работа метода не гарантируется.</remarks>
        public static void CopyTo<T> (this T [,] sourceArray, T [,] destinationArray)
        {
            int height = destinationArray.GetLength (0);
            int width  = destinationArray.GetLength (1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    destinationArray [i, j] = sourceArray [i, j];
                }
            }
        }

        /// <summary>
        /// Возвращает TRUE, если два массива поэлементно равны. В противном случае FALSE.
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
        /// Возвращает TRUE, если два массива поэлементно равны. В противном случае FALSE.
        /// </summary>
        /// <remarks>Размеры массивов array1 и array2 тоже должны совпадать. Например, если массив array1 будет иметь размеры 2 х 3, а 
        /// массив array2 3 х 2 (то есть их общие количества элементов будут совпадать, но при этом не будет совпадать их распределение 
        /// по строкам и столбцам), и оба массива будут содержать равные элементы в одинаковом порядке, массивы равными считаться не будут.</remarks>
        public static bool Equals<T> (this T [,] array1, T [,] array2)
        {
            int height = array1.GetLength (0);
            int width  = array1.GetLength (1);

            if ((height == array2.GetLength (0)) && 
                (width  == array2.GetLength (1)))
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

        public static void Add<T> (T [] addend1, T [] addend2, T [] sum) where T : INumber<T>
        {
            for (int i = 0; i < sum.Length; i++)
            {
                sum [i] = addend1 [i] + addend2 [i];
            }
        }

        public static void Add<T> (T [,] addend1, T [,] addend2, T [,] sum, int height, int width) where T : INumber<T>
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    sum [i, j] = addend1 [i, j] + addend2 [i, j];
                }
            }
        }

        public static void Subtract<T> (T [] minuend, T [] subtrahend, T [] difference) where T : INumber<T>
        {
            for (int i = 0; i < difference.Length; i++)
            {
                difference [i] = minuend [i] - subtrahend [i];
            }
        }

        public static void Subtract<T> (T [,] minuend, T [,] subtrahend, T [,] difference, int height, int width) where T : INumber<T>
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    difference [i, j] = minuend [i, j] - subtrahend [i, j];
                }
            }
        }

        public static void Negate<T> (T [] array, T [] result) where T : INumber<T>
        {
            for (int i = 0; i < result.Length; i++)
            {
                result [i] = -array [i];
            }
        }

        public static void Negate<T> (T [,] array, T [,] result, int height, int width) where T : INumber<T>
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    result [i, j] = -array [i, j];
                }
            }
        }

        public static void Multiply<T> (T [] array, T coefficient, T [] product) where T : INumber<T>
        {
            for (int i = 0; i < product.Length; i++)
            {
                product [i] = array [i] * coefficient;
            }
        }

        public static void Multiply<T> (T [,] array, T coefficient, T [,] product, int height, int width) where T : INumber<T>
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    product [i, j] = array [i, j] * coefficient;
                }
            }
        }

        public static void Divide<T> (T [] array, T coefficient, T [] quotient) where T : INumber<T>
        {
            for (int i = 0; i < quotient.Length; i++)
            {
                quotient [i] = array [i] / coefficient;
            }
        }

        public static void Divide<T> (T [,] array, T coefficient, T [,] quotient, int height, int width) where T : INumber<T>
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    quotient [i, j] = array [i, j] / coefficient;
                }
            }
        }

        public static void OuterProduct<T> (T [,] matrix, T [] vector, T [] product) where T : INumber<T>
        {
            for (int i = 0; i < product.Length; i++)
            {
                T sum = T.Zero;

                for (int j = 0; j < vector.Length; j++)
                {
                    sum += matrix [i, j] * vector [j];
                }

                product [i] = sum;
            }
        }

        public static void OuterProduct<T> (T [] vector, T [,] matrix, T [] product) where T : INumber<T>
        {
            for (int i = 0; i < product.Length; i++)
            {
                T sum = T.Zero;

                for (int j = 0; j < vector.Length; j++)
                {
                    sum += vector [j] * matrix [j, i];
                }

                product [i] = sum;
            }
        }

        /// <summary>
        /// Возвращает сумму попарных произведений элементов массивов array1 и array2. (Скалярное или внутреннее произведение массивов).
        /// </summary>
        /// <remarks>Массивы array1 и array2 должны иметь одинаковый размер. В противном случае корректная работа метода не гарантируется.</remarks>
        public static T InnerProduct<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            T sum = T.Zero;

            for (int i = 0; i < array1.Length; i++)
            {
                sum += array1 [i] * array2 [i];
            }

            return sum;
        }

        /// <summary>
        /// Возвращает сумму квадратов элементов массива.
        /// </summary>
        public static T SumOfSquares<T> (this T [] array) where T : INumber<T>
        {
            T sum = T.Zero;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array [i] * array [i];
            }

            return sum;
        }
    }
}