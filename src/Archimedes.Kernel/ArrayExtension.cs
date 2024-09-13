﻿using System.Numerics;

namespace Archimedes
{
    public static class ArrayExtension
    {
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

        public static T [] Add<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            T [] output = new T [array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                output [i] = array1 [i] + array2 [i];
            }

            return output;
        }

        public static void AddTo<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            for (int i = 0; i < array1.Length; i++)
            {
                array1 [i] += array2 [i];
            }
        }

        public static T [,] Add<T> (this T [,] array1, T [,] array2) where T : INumber<T>
        {
            T [,] output = new T [array1.GetLength (0), array2.GetLength (1)];

            for (int i = 0; i < array1.GetLength (0); i++)
            {
                for (int j = 0; j < array1.GetLength (1); j++)
                {
                    output [i, j] = array1 [i, j] + array2 [i, j];
                }
            }

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

        public static T [] Subtract<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            T [] output = new T [array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                output [i] = array1 [i] - array2 [i];
            }

            return output;
        }

        public static void SubtractTo<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            for (int i = 0; i < array1.Length; i++)
            {
                array1 [i] -= array2 [i];
            }
        }

        public static T [,] Subtract<T> (this T [,] array1, T [,] array2) where T : INumber<T>
        {
            T [,] output = new T [array1.GetLength (0), array2.GetLength (1)];

            for (int i = 0; i < array1.GetLength (0); i++)
            {
                for (int j = 0; j < array1.GetLength (1); j++)
                {
                    output [i, j] = array1 [i, j] - array2 [i, j];
                }
            }

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

        public static T [] Negate<T> (this T [] array) where T : INumber<T>
        {
            T [] output = new T [array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                output [i] = -array [i];
            }

            return output;
        }

        public static void NegateTo<T> (this T [] array) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                array [i] = -array [i];
            }
        }

        public static T [,] Negate<T> (this T [,] array) where T : INumber<T>
        {
            T [,] output = new T [array.GetLength (0), array.GetLength (1)];

            for (int i = 0; i < array.GetLength (0); i++)
            {
                for (int j = 0; j < array.GetLength (1); j++)
                {
                    output [i, j] = -array [i, j];
                }
            }

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

        public static T [] Multiply<T> (this T [] array, T coefficient) where T : INumber<T>
        {
            T [] output = new T [array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                output [i] = array [i] * coefficient;
            }

            return output;
        }

        public static void MultiplyTo<T> (this T [] array, T coefficient) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                array [i] *= coefficient;
            }
        }

        public static T [,] Multiply<T> (this T [,] array, T coefficient) where T : INumber<T>
        {
            T [,] output = new T [array.GetLength (0), array.GetLength (1)];

            for (int i = 0; i < array.GetLength (0); i++)
            {
                for (int j = 0; j < array.GetLength (1); j++)
                {
                    output [i, j] = array [i, j] * coefficient;
                }
            }

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

        public static T [] Divide<T> (this T [] array, T coefficient) where T : INumber<T>
        {
            T [] output = new T [array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                output [i] = array [i] / coefficient;
            }

            return output;
        }

        public static void DivideTo<T> (this T [] array, T coefficient) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                array [i] /= coefficient;
            }
        }

        public static T [,] Divide<T> (this T [,] array, T coefficient) where T : INumber<T>
        {
            T [,] output = new T [array.GetLength (0), array.GetLength (1)];

            for (int i = 0; i < array.GetLength (0); i++)
            {
                for (int j = 0; j < array.GetLength (1); j++)
                {
                    output [i, j] = array [i, j] / coefficient;
                }
            }

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