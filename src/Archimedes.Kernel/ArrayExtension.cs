using System.Numerics;

namespace Archimedes
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Копирует одномерный массив source в двумерный массив destination.
        /// </summary>
        /// <remarks>Длина массива source должна быть равна количеству элементов в массиве destination (то есть произведению его 
        /// высоты и ширины). В методе не производится проверка на их равенство. В том случае, если по какому-то измерению размеры 
        /// будут неравны, метод может отработать некорректно (возможна генерация исключения).</remarks>
        public static void CopyTo<T> (this T [] source, T [,] destination) where T : INumber<T>
        {
            int sourceIterator = 0;

            for (int i = 0; i < destination.GetLength (0); i++)
            {
                for (int j = 0; j < destination.GetLength (1); j++)
                {
                    destination [i, j] = source [sourceIterator++];
                }
            }
        }

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

        /// <summary>
        /// Поэлементное сложение массивов array1 и array2. Результат сохраняется в массиве sum.
        /// </summary>
        /// <remarks>Размеры массивов должны быть одинаковые. В методе не производится проверка на их равенство. В том случае, если 
        /// размеры будут неравны, метод может отработать некорректно (возможна генерация исключения).</remarks>
        public static void Add<T> (this T [] array1, T [] array2, T [] sum) where T : INumber<T>
        {
            for (int i = 0; i < array1.Length; i++)
            {
                sum [i] = array1 [i] + array2 [i];
            }
        }

        /// <summary>
        /// Поэлементное сложение массивов array1 и array2. Результат сохраняется в массиве sum.
        /// </summary>
        /// <remarks>Размеры массивов должны быть одинаковые. В методе не производится проверка на их равенство. В том случае, если 
        /// размеры будут неравны, метод может отработать некорректно (возможна генерация исключения).</remarks>
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

        /// <summary>
        /// Поэлементное сложение массивов array1 и array2. Результат сохраняется в массиве array1.
        /// </summary>
        /// <remarks>Размеры массивов должны быть одинаковые. В методе не производится проверка на их равенство. В том случае, если 
        /// размеры будут неравны, метод может отработать некорректно (возможна генерация исключения).</remarks>
        public static void AddTo<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            for (int i = 0; i < array1.Length; i++)
            {
                array1 [i] += array2 [i];
            }
        }

        /// <summary>
        /// Поэлементное сложение массивов array1 и array2. Результат сохраняется в массиве array1.
        /// </summary>
        /// <remarks>Размеры массивов должны быть одинаковые. В методе не производится проверка на их равенство. В том случае, если 
        /// размеры будут неравны, метод может отработать некорректно (возможна генерация исключения).</remarks>
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

        /// <summary>
        /// Поэлементное вычитание массивов array1 и array2. Результат сохраняется в массиве difference.
        /// </summary>
        /// <remarks>Размеры массивов должны быть одинаковые. В методе не производится проверка на их равенство. В том случае, если 
        /// размеры будут неравны, метод может отработать некорректно (возможна генерация исключения).</remarks>
        public static void Subtract<T> (this T [] array1, T [] array2, T [] difference) where T : INumber<T>
        {
            for (int i = 0; i < array1.Length; i++)
            {
                difference [i] = array1 [i] - array2 [i];
            }
        }

        /// <summary>
        /// Поэлементное вычитание массивов array1 и array2. Результат сохраняется в массиве difference.
        /// </summary>
        /// <remarks>Размеры массивов должны быть одинаковые. В методе не производится проверка на их равенство. В том случае, если 
        /// размеры будут неравны, метод может отработать некорректно (возможна генерация исключения).</remarks>
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

        /// <summary>
        /// Поэлементное вычитание массивов array1 и array2. Результат сохраняется в массиве array1.
        /// </summary>
        /// <remarks>Размеры массивов должны быть одинаковые. В методе не производится проверка на их равенство. В том случае, если 
        /// размеры будут неравны, метод может отработать некорректно (возможна генерация исключения).</remarks>
        public static void SubtractTo<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            for (int i = 0; i < array1.Length; i++)
            {
                array1 [i] -= array2 [i];
            }
        }

        /// <summary>
        /// Поэлементное вычитание массивов array1 и array2. Результат сохраняется в массиве array1.
        /// </summary>
        /// <remarks>Размеры массивов должны быть одинаковые. В методе не производится проверка на их равенство. В том случае, если 
        /// размеры будут неравны, метод может отработать некорректно (возможна генерация исключения).</remarks>
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

        /// <summary>
        /// Отрицание массива array – сохраняет в массиве negated элементы, противоположные элементам массива array.
        /// </summary>
        /// <remarks>Размеры массивов должны быть одинаковые. В методе не производится проверка на их равенство. В том случае, если 
        /// размеры будут неравны, метод может отработать некорректно (возможна генерация исключения).</remarks>
        public static void Negate<T> (this T [] array, T [] negated) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                negated [i] = -array [i];
            }
        }

        /// <summary>
        /// Отрицание массива array – сохраняет в массиве negated элементы, противоположные элементам массива array.
        /// </summary>
        /// <remarks>Размеры массивов должны быть одинаковые. В методе не производится проверка на их равенство. В том случае, если 
        /// размеры будут неравны, метод может отработать некорректно (возможна генерация исключения).</remarks>
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

        /// <summary>
        /// Отрицание массива array – заменяет значения его элементов на противоположные.
        /// </summary>
        public static void Negate<T> (this T [] array) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                array [i] = -array [i];
            }
        }

        /// <summary>
        /// Отрицание массива array – заменяет значения его элементов на противоположные.
        /// </summary>
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

        /// <summary>
        /// Поэлементное умножение массива array на число coefficient. Результат сохраняется в массиве product.
        /// </summary>
        /// <remarks>Размеры массивов должны быть одинаковые. В методе не производится проверка на их равенство. В том случае, если 
        /// размеры будут неравны, метод может отработать некорректно (возможна генерация исключения).</remarks>
        public static void Multiply<T> (this T [] array, T coefficient, T [] product) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                product [i] = array [i] * coefficient;
            }
        }

        /// <summary>
        /// Поэлементное умножение массива array на число coefficient. Результат сохраняется в массиве product.
        /// </summary>
        /// <remarks>Размеры массивов должны быть одинаковые. В методе не производится проверка на их равенство. В том случае, если 
        /// размеры будут неравны, метод может отработать некорректно (возможна генерация исключения).</remarks>
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

        /// <summary>
        /// Поэлементное умножение массива array на число coefficient. Результат сохраняется в массиве array.
        /// </summary>
        public static void MultiplyTo<T> (this T [] array, T coefficient) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                array [i] *= coefficient;
            }
        }

        /// <summary>
        /// Поэлементное умножение массива array на число coefficient. Результат сохраняется в массиве array.
        /// </summary>
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

        /// <summary>
        /// Поэлементное деление массива array на число coefficient. Результат сохраняется в массиве quotient.
        /// </summary>
        /// <remarks>Размеры массивов должны быть одинаковые. В методе не производится проверка на их равенство. В том случае, если 
        /// размеры будут неравны, метод может отработать некорректно (возможна генерация исключения).</remarks>
        public static void Divide<T> (this T [] array, T coefficient, T [] quotient) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                quotient [i] = array [i] / coefficient;
            }
        }

        /// <summary>
        /// Поэлементное деление массива array на число coefficient. Результат сохраняется в массиве quotient.
        /// </summary>
        /// <remarks>Размеры массивов должны быть одинаковые. В методе не производится проверка на их равенство. В том случае, если 
        /// размеры будут неравны, метод может отработать некорректно (возможна генерация исключения).</remarks>
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

        /// <summary>
        /// Поэлементное деление массива array на число coefficient. Результат сохраняется в массиве array.
        /// </summary>
        public static void DivideTo<T> (this T [] array, T coefficient) where T : INumber<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                array [i] /= coefficient;
            }
        }

        /// <summary>
        /// Поэлементное деление массива array на число coefficient. Результат сохраняется в массиве array.
        /// </summary>
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
        /// Возвращает внутреннее (скалярное) произведение массивов array1 и array1.
        /// </summary>
        /// <remarks>Размеры массивов должны быть одинаковые. В методе не производится проверка на их равенство. В том случае, если 
        /// размеры будут неравны, метод может отработать некорректно (возможна генерация исключения).</remarks>
        public static T InnerProduct<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            T innerProduct = T.Zero;

            for (int i = 0; i < array1.Length; i++)
            {
                innerProduct += array1 [i] * array2 [i];
            }

            return innerProduct;
        }

        /// <summary>
        /// Возвращает сумму квадратов элементов массива array.
        /// </summary>
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