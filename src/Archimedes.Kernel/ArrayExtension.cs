using System.Numerics;

namespace Archimedes
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Копирует элементы из 1-мерного массива source в 2-мерный массив destination.
        /// </summary>
        /// <remarks>Количество элементов в массиве destination должно быть не меньше, чем в исходном массиве source.</remarks>
        public static void CopyTo<T> (this T [] source, T [,] destination)
        {
            int sourceInterator = 0;

            for (int i = 0; i < destination.GetLength (0); i++)
            {
                for (int j = 0; j < destination.GetLength (1); j++)
                {
                    destination [i, j] = source [sourceInterator++];
                }
            }
        }

        /// <summary>
        /// Копирует элементы из 2-мерного массива source в 1-мерный массив destination.
        /// </summary>
        /// <remarks>Количество элементов в массиве destination должно быть не меньше, чем в исходном массиве source.</remarks>
        public static void CopyTo<T> (this T [,] source, T [] destination)
        {
            int destinationIterator = 0;

            for (int i = 0; i < source.GetLength (0); i++)
            {
                for (int j = 0; j < source.GetLength (1); j++)
                {
                    destination [destinationIterator++] = source [i, j];
                }
            }
        }

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

        public static void Add<T> (this T [] array1, T [] array2, ref T [] output) where T : INumber<T>
        {
            for (int i = 0; i < array1.Length; i++)
            {
                output [i] = array1 [i] + array2 [i];
            }
        }

        public static T [] Add<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            T [] output = new T [array1.Length];

            array1.Add (array2, ref output);

            return output;
        }

        public static void AddTo<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            for (int i = 0; i < array1.Length; i++)
            {
                array1 [i] += array2 [i];
            }
        }

        public static void Add<T> (this T [,] array1, T [,] array2, ref T [,] output) where T : INumber<T>
        {
            for (int i = 0; i < array1.GetLength (0); i++)
            {
                for (int j = 0; j < array1.GetLength (1); j++)
                {
                    output [i, j] = array1 [i, j] + array2 [i, j];
                }
            }
        }

        public static T [,] Add<T> (this T [,] array1, T [,] array2) where T : INumber<T>
        {
            T [,] output = new T [array1.GetLength (0), array1.GetLength (1)];

            array1.Add (array2, ref output);

            return output;
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

        public static void Subtract<T> (this T [] array1, T [] array2, ref T [] output) where T : INumber<T>
        {
            for (int i = 0; i < array1.Length; i++)
            {
                output [i] = array1 [i] - array2 [i];
            }
        }

        public static T [] Subtract<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            T [] output = new T [array1.Length];

            array1.Subtract (array2, ref output);

            return output;
        }

        public static void SubtractTo<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            for (int i = 0; i < array1.Length; i++)
            {
                array1 [i] -= array2 [i];
            }
        }

        public static void Subtract<T> (this T [,] array1, T [,] array2, ref T [,] output) where T : INumber<T>
        {
            for (int i = 0; i < array1.GetLength (0); i++)
            {
                for (int j = 0; j < array1.GetLength (1); j++)
                {
                    output [i, j] = array1 [i, j] - array2 [i, j];
                }
            }
        }

        public static T [,] Subtract<T> (this T [,] array1, T [,] array2) where T : INumber<T>
        {
            T [,] output = new T [array1.GetLength (0), array1.GetLength (1)];

            array1.Subtract (array2, ref output);

            return output;
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

        public static void Negate<T> (this T [] array, ref T [] output) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                output [i] = -array [i];
            }
        }

        public static T [] Negate<T> (this T [] array) where T : INumber<T>
        {
            T [] output = new T [array.Length];

            array.Negate (ref output);

            return output;
        }

        public static void NegateTo<T> (this T [] array) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                array [i] = -array [i];
            }
        }

        public static void Negate<T> (this T [,] array, ref T [,] output) where T : INumber<T>
        {
            for (int i = 0; i < array.GetLength (0); i++)
            {
                for (int j = 0; j < array.GetLength (1); j++)
                {
                    output [i, j] = -array [i, j];
                }
            }
        }

        public static T [,] Negate<T> (this T [,] array) where T : INumber<T>
        {
            T [,] output = new T [array.GetLength (0), array.GetLength (1)];

            array.Negate (ref output);

            return output;
        }

        public static void NegateTo<T> (this T [,] array) where T : INumber<T>
        {
            for (int i = 0; i < array.GetLength (0); i++)
            {
                for (int j = 0; j < array.GetLength (1); j++)
                {
                    array [i, j] = -array [i, j];
                }
            }
        }

        public static void Multiply<T> (this T [] array, T coefficient, ref T [] output) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                output [i] = array [i] * coefficient;
            }
        }

        public static T [] Multiply<T> (this T [] array, T coefficient) where T : INumber<T>
        {
            T [] output = new T [array.Length];

            array.Multiply (coefficient, ref output);

            return output;
        }

        public static void MultiplyTo<T> (this T [] array, T coefficient) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                array [i] *= coefficient;
            }
        }

        public static void Multiply<T> (this T [,] array, T coefficient, ref T [,] output) where T : INumber<T>
        {
            for (int i = 0; i < array.GetLength (0); i++)
            {
                for (int j = 0; j < array.GetLength (1); j++)
                {
                    output [i, j] = array [i, j] * coefficient;
                }
            }
        }

        public static T [,] Multiply<T> (this T [,] array, T coefficient) where T : INumber<T>
        {
            T [,] output = new T [array.GetLength (0), array.GetLength (1)];

            array.Multiply (coefficient, ref output);

            return output;
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

        public static void Divide<T> (this T [] array, T coefficient, ref T [] output) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                output [i] = array [i] / coefficient;
            }
        }

        public static T [] Divide<T> (this T [] array, T coefficient) where T : INumber<T>
        {
            T [] output = new T [array.Length];

            array.Divide (coefficient, ref output);

            return output;
        }

        public static void DivideTo<T> (this T [] array, T coefficient) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                array [i] /= coefficient;
            }
        }

        public static void Divide<T> (this T [,] array, T coefficient, ref T [,] output) where T : INumber<T>
        {
            for (int i = 0; i < array.GetLength (0); i++)
            {
                for (int j = 0; j < array.GetLength (1); j++)
                {
                    output [i, j] = array [i, j] / coefficient;
                }
            }
        }

        public static T [,] Divide<T> (this T [,] array, T coefficient) where T : INumber<T>
        {
            T [,] output = new T [array.GetLength (0), array.GetLength (1)];

            array.Divide (coefficient, ref output);

            return output;
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

        /// <summary>
        /// Возвращает скалярное произведение двух массивов.
        /// </summary>
        /// <remarks>Массивы array1 и array2 должны иметь одинаковую длину. Проверка на выполнение этого условия в методе не производится.</remarks>
        public static T InnerProduct<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            T output = T.Zero;

            for (int i = 0; i < array1.Length; i++)
            {
                output += array1 [i] * array2 [i];
            }

            return output;
        }

        /// <summary>
        /// Возвращает сумму элементов массива array.
        /// </summary>
        public static T Sum<T> (this T [] array) where T : INumber<T>
        {
            T output = T.Zero;

            for (int i = 0; i < array.Length; i++)
            {
                output += array [i];
            }

            return output;
        }

        /// <summary>
        /// Возвращает сумму квадратов элементов массива array.
        /// </summary>
        public static T SumOfSquares<T> (this T [] array) where T : INumber<T>
        {
            T output = T.Zero;

            for (int i = 0; i < array.Length; i++)
            {
                output += array [i] * array [i];
            }

            return output;
        }
    }
}