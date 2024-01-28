using System.Numerics;

namespace Archimedes
{
    public static class ArrayExtension
    {
        public static void CopyToSubarray<T> (this T [] sourceArray, T [] destinationArray, int beginIndex, int endIndex)
        {
            int iterator = 0;

            for (int i = beginIndex; i <= endIndex; i++)
            {
                destinationArray [iterator++] = sourceArray [i];
            }
        }

        #region Relations

        /// <summary>
        /// Возвращает true, если массив array1 поэлементно равен массиву array2. Если хотя бы одна пара элементов в массивах array1 и 
        /// array2 неравна, возвращается false.
        /// </summary>
        /// <remarks>Предполагается, что массивы array1 и array2 имеют одинаковую длину. Проверка на данное условие внутри метода не 
        /// производится. Если окажется, что массивы, переданные в метод, имеют разную длину, то либо будет сгенерировано исключение, 
        /// либо «лишние» элементы одного из массивов никак не будут учтены при сравнении. В любом случае, поведение метода в данной 
        /// ситуации не документируется.</remarks>
        public static bool Equals<T> (this T [] array1, T [] array2) where T : IEquatable<T>
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (!array1 [i].Equals (array2 [i])) return false;
            }

            return true;
        }

        #region No-loop сравнение массивов чисел длиной 2, 3, 4 и 9

        // No-loop сравнение массивов чисел очень малой длины реализовано, чтобы избежать для них вызова общих алгоритмов.
        // Фактически в этом коде выполнена развёртка цикла, что позволяет сократить количество выполняемых операций. Это особенно
        // актуально, так как сравнение массивов длиной 2, 3, 4 и 9 применяется для векторов размерности 2 и 3 и матриц размерности
        // 2х2 и 3х3 – то есть, наиболее часто используемых.

        /// <summary>
        /// Возвращает true, если 2-элементный массив array1 поэлементно равен массиву array2. Если хотя бы одна пара элементов в массивах 
        /// array1 и array2 неравна, возвращается false.
        /// </summary>
        /// <remarks>Если хотя бы один из массивов array1 и array2 содержит меньше 2 элементов, сгенерируется исключение. Если какой-то из 
        /// массивов array1 и array2 содержит больше 2 элементов, они просто никак не учитываются при вызове метода. Сравнение 
        /// осуществляется по первым двум элементам.</remarks>
        public static bool Equals2<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            return ((array1 [0] == array2 [0]) &&
                    (array1 [1] == array2 [1]));
        }

        /// <summary>
        /// Возвращает true, если 3-элементный массив array1 поэлементно равен массиву array2. Если хотя бы одна пара элементов в массивах 
        /// array1 и array2 неравна, возвращается false.
        /// </summary>
        /// <remarks>Если хотя бы один из массивов array1 и array2 содержит меньше 3 элементов, сгенерируется исключение. Если какой-то из 
        /// массивов array1 и array2 содержит больше 3 элементов, они просто никак не учитываются при вызове метода. Сравнение 
        /// осуществляется по первым трём элементам.</remarks>
        public static bool Equals3<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            return ((array1 [0] == array2 [0]) &&
                    (array1 [1] == array2 [1]) &&
                    (array1 [2] == array2 [2]));
        }

        /// <summary>
        /// Возвращает true, если 4-элементный массив array1 поэлементно равен массиву array2. Если хотя бы одна пара элементов в массивах 
        /// array1 и array2 неравна, возвращается false.
        /// </summary>
        /// <remarks>Если хотя бы один из массивов array1 и array2 содержит меньше 4 элементов, сгенерируется исключение. Если какой-то из 
        /// массивов array1 и array2 содержит больше 4 элементов, они просто никак не учитываются при вызове метода. Сравнение 
        /// осуществляется по первым четырём элементам.</remarks>
        public static bool Equals4<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            return ((array1 [0] == array2 [0]) &&
                    (array1 [1] == array2 [1]) &&
                    (array1 [2] == array2 [2]) &&
                    (array1 [3] == array2 [3]));
        }

        /// <summary>
        /// Возвращает true, если 9-элементный массив array1 поэлементно равен массиву array2. Если хотя бы одна пара элементов в массивах 
        /// array1 и array2 неравна, возвращается false.
        /// </summary>
        /// <remarks>Если хотя бы один из массивов array1 и array2 содержит меньше 9 элементов, сгенерируется исключение. Если какой-то из 
        /// массивов array1 и array2 содержит больше 9 элементов, они просто никак не учитываются при вызове метода. Сравнение 
        /// осуществляется по первым девяти элементам.</remarks>
        public static bool Equals9<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            return ((array1 [0] == array2 [0]) &&
                    (array1 [1] == array2 [1]) &&
                    (array1 [2] == array2 [2]) &&
                    (array1 [3] == array2 [3]) &&
                    (array1 [4] == array2 [4]) &&
                    (array1 [5] == array2 [5]) &&
                    (array1 [6] == array2 [6]) &&
                    (array1 [7] == array2 [7]) &&
                    (array1 [8] == array2 [8]));
        }

        #endregion

        #endregion

        public static int FindMinIndex<T> (this T [] array, int beginIndex, int endIndex) where T : INumber<T>
        {
            int minIndex = beginIndex;

            for (int i = beginIndex + 1; i <= endIndex; i++)
            {
                if (array [i] < array [minIndex]) minIndex = i;
            }

            return minIndex;
        }

        /// <summary>
        /// Возвращает значения минимального и максимального элементов массива array.
        /// </summary>
        /// <remarks>Массив array должен иметь длину больше 0. В противном случае будет сгенерировано исключение.</remarks>
        public static (T min, T max) FindMinMax<T> (this T [] array) where T : INumber<T>
        {
            T   min, max;            
            int begin;

            if (array.Length.IsEven ())
            {
                (min, max) = Common.MinMax (array [0], array [1]);
                begin = 2;
            }

            else
            {
                min   = array [0];
                max   = array [0];               
                begin = 1;
            }

            for (int i = begin; i < array.Length; i+=2) 
            {
                (T a, T b) = Common.MinMax (array [i], array [i + 1]);

                if (a < min) min = a;

                if (b > max) max = b;
            }

            return (min, max);
        }

        #region Арифметические операции над массивами чисел

        /// <summary>
        /// Складывает попарно элементы массивов array1 и array2 и сохраняет суммы пар элементов в массив sum.
        /// </summary>
        /// <remarks>Предполагается, что массивы array1 и array2 имеют одинаковую длину. Проверка на данное условие внутри метода не 
        /// производится. Если окажется, что массивы, переданные в метод, имеют разную длину, то либо будет сгенерировано исключение, 
        /// либо «лишние» элементы одного из массивов никак не будут учтены при сложении. В любом случае, поведение метода в данной 
        /// ситуации не документируется.</remarks>
        public static void Add<T> (this T [] sum, T [] array1, T [] array2) where T : INumber<T>
        {
            for (int i = 0; i < sum.Length; i++)
            {
                sum [i] = array1 [i] + array2 [i];
            }
        }

        /// <summary>
        /// Вычитает попарно из элементов массива array1 элементы массива array2 и сохраняет разности пар элементов в массив difference.
        /// </summary>
        /// <remarks>Предполагается, что массивы array1 и array2 имеют одинаковую длину. Проверка на данное условие внутри метода не 
        /// производится. Если окажется, что массивы, переданные в метод, имеют разную длину, то либо будет сгенерировано исключение, 
        /// либо «лишние» элементы одного из массивов никак не будут учтены при вычитании. В любом случае, поведение метода в данной 
        /// ситуации не документируется.</remarks>
        public static void Subtract<T> (this T [] difference, T [] array1, T [] array2) where T : INumber<T>
        {
            for (int i = 0; i < difference.Length; i++)
            {
                difference [i] = array1 [i] - array2 [i];
            }
        }

        /// <summary>
        /// Заполняет массив negate числами, противоположными элементам массива array.
        /// </summary>
        public static void Negate<T> (this T [] negation, T [] array) where T : INumber<T>
        {
            for (int i = 0; i < negation.Length; i++)
            {
                negation [i] = -array [i];
            }
        }

        /// <summary>
        /// Умножает элементы массива array на число coefficient и сохраняет произведения в массив product.
        /// </summary>
        public static void Multiply<T> (this T [] product, T [] array, T coefficient) where T : INumber<T>
        {
            for (int i = 0; i < product.Length; i++)
            {
                product [i] = array [i] * coefficient;
            }
        }

        /// <summary>
        /// Делит элементы массива array на число coefficient и сохраняет произведения в массив quotient.
        /// </summary>
        public static void Divide<T> (this T [] quotient, T [] array, T coefficient) where T : INumber<T>
        {
            for (int i = 0; i < quotient.Length; i++)
            {
                quotient [i] = array [i] / coefficient;
            }
        }

        /// <summary>
        /// Скалярное произведение массивов array1 и array2.
        /// </summary>
        /// <remarks>Скалярное произведение двух массивов = сумма попарных произведений их элементов. Предполагается, что массивы 
        /// array1 и array2 имеют одинаковую длину. Проверка на данное условие внутри метода не производится. Если окажется, что 
        /// массивы, переданные в метод, имеют разную длину, то либо будет сгенерировано исключение, либо «лишние» элементы одного из 
        /// массивов никак не будут учтены при умножении. В любом случае, поведение метода в данной ситуации не документируется.</remarks>
        public static T InnerProduct<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            T result = T.Zero;

            for (int i = 0; i < array1.Length; i++)
            {
                result += array1 [i] * array2 [i];
            }

            return result;
        }

        /// <summary>
        /// Сумма квадратов элементов массива array.
        /// </summary>
        /// <remarks>Фактически сумма квадратов элементов массива равна его скалярному произведению на самого себя.</remarks>
        public static T SumOfSquares<T> (this T [] array) where T : INumber<T>
        {
            return array.InnerProduct (array);
        }

        #endregion
    }
}