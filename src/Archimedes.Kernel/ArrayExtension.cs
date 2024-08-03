using System.Numerics;

namespace Archimedes
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Копирует массив source в массив destination.
        /// </summary>
        /// <remarks>Массивы source и destination должны иметь одинаковые размеры по всем измерениям. В методе не производится проверка 
        /// на их равенство. В том случае, если по какому-то измерению размеры будут неравны, метод может отработать некорректно 
        /// (возможна генерация исключения).</remarks>
        public static void CopyTo<T> (this T [,] source, T [,] destination) where T : INumber<T>
        {
            for (int i = 0; i < source.GetLength (0); i++)
            {
                for (int j = 0; j < destination.GetLength (1); j++)
                {
                    destination [i, j] = source [i, j];
                }
            }
        }

        /// <summary>
        /// Возвращает TRUE, если массивы array1 и array2 равны. В противном случае FALSE.
        /// </summary>
        /// <remarks>Одномерные массивы считаются равными друг другу, если равны их длины, и элементы, содержащиеся на одних и тех же 
        /// позициях в массивах, имеют равные значения.</remarks>
        public static bool Equals<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1 [i] != array2 [i]) return false;
                }

                return true;
            }

            else return false;
        }

        /// <summary>
        /// Возвращает TRUE, если массивы array1 и array2 равны. В противном случае FALSE.
        /// </summary>
        /// <remarks>Двумерные массивы считаются равными друг другу, если равны их размеры по всем измерениям, и элементы, содержащиеся 
        /// на одних и тех же позициях в массивах, имеют равные значения.</remarks>
        public static bool Equals<T> (this T [,] array1, T [,] array2) where T : INumber<T>
        {
            if ((array1.GetLength (0) == array2.GetLength (0)) &&
                (array1.GetLength (1) == array2.GetLength (1)))
            {
                for (int i = 0; i < array1.GetLength (0); i++)
                {
                    for (int j = 0; j < array1.GetLength (1); j++)
                    {
                        if (array1 [i, j] != array2 [i, j]) return false;
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
            for (int i = 0; i < array1.GetLength (0); i++)
            {
                for (int j = 0; j < array1.GetLength (1); j++)
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
            for (int i = 0; i < array1.GetLength (0); i++)
            {
                for (int j = 0; j < array1.GetLength (1); j++)
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
            for (int i = 0; i < array1.GetLength (0); i++)
            {
                for (int j = 0; j < array1.GetLength (1); j++)
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
            for (int i = 0; i < array1.GetLength (0); i++)
            {
                for (int j = 0; j < array1.GetLength (1); j++)
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

        public static void Negate<T> (this T [,] array, T [,] negated) where T : INumber<T>
        {
            for (int i = 0; i < array.GetLength (0); i++)
            {
                for (int j = 0; j < array.GetLength (1); j++)
                {
                    negated [i, j] = -array [i, j];
                }
            }
        }

        public static void Negate<T> (this T [] array) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                array [i] = -array [i];
            }
        }

        public static void Negate<T> (this T [,] array) where T : INumber<T>
        {
            for (int i = 0; i < array.GetLength (0); i++)
            {
                for (int j = 0; j < array.GetLength (1); j++)
                {
                    array [i, j] = -array [i, j];
                }
            }
        }

        public static void Multiply<T> (this T [] array, T coefficient, T [] product) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                product [i] = array [i] * coefficient;
            }
        }

        public static void Multiply<T> (this T [,] array, T coefficient, T [,] product) where T : INumber<T>
        {
            for (int i = 0; i < array.GetLength (0); i++)
            {
                for (int j = 0; j < array.GetLength (1); j++)
                {
                    product [i, j] = array [i, j] * coefficient;
                }
            }
        }

        public static void MultiplyTo<T> (this T [] array, T coefficient) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                array [i] *= coefficient;
            }
        }

        public static void MultiplyTo<T> (this T [,] array, T coefficient) where T : INumber<T>
        {
            for (int i = 0; i < array.GetLength (0); i++)
            {
                for (int j = 0; j < array.GetLength (1); j++)
                {
                    array [i, j] *= coefficient;
                }
            }
        }

        public static void Divide<T> (this T [] array, T coefficient, T [] quotient) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                quotient [i] = array [i] / coefficient;
            }
        }

        public static void Divide<T> (this T [,] array, T coefficient, T [,] quotient) where T : INumber<T>
        {
            for (int i = 0; i < array.GetLength (0); i++)
            {
                for (int j = 0; j < array.GetLength (1); j++)
                {
                    quotient [i, j] = array [i, j] / coefficient;
                }
            }
        }

        public static void DivideTo<T> (this T [] array, T coefficient) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                array [i] /= coefficient;
            }
        }

        public static void DivideTo<T> (this T [,] array, T coefficient) where T : INumber<T>
        {
            for (int i = 0; i < array.GetLength (0); i++)
            {
                for (int j = 0; j < array.GetLength (1); j++)
                {
                    array [i, j] /= coefficient;
                }
            }
        }

        public static T InnerProduct<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            T innerProduct = T.Zero;

            for (int i = 0; i < array1.Length; i++)
            {
                innerProduct += array1 [i] * array2 [i];
            }

            return innerProduct;
        }

        public static T SumOfSquares<T> (this T [] array) where T : INumber<T>
        {
            T sumOfSquares = T.Zero;

            for (int i = 0; i < array.Length; i++)
            {
                sumOfSquares += array [i] * array [i];
            }

            return sumOfSquares;
        }
    }
}