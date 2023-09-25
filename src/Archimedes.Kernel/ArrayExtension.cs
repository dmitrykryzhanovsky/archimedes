namespace Archimedes
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Возвращает true, если массив array1 поэлементно равен массиву array2. Если хотя бы одна пара элементов в массивах array1 и 
        /// array2 неравна, возвращается false.
        /// </summary>
        /// <remarks>Предполагается, что массивы array1 и array2 имеют одинаковую длину. Проверка на данное условие внутри метода не 
        /// производится. Если окажется, что массивы, переданные в метод, имеют разную длину, то либо будет сгенерировано исключение, 
        /// либо «лишние» элементы одного из массивов никак не будут учтены при сравнении. В любом случае, поведение метода в данной 
        /// ситуации не документируется.</remarks>
        public static bool Equals (this double [] array1, double [] array2)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1 [i] != array2 [i]) return false;
            }

            return true;
        }

        /// <summary>
        /// Возвращает true, если 2-элементный массив array1 поэлементно равен массиву array2. Если хотя бы одна пара элементов в массивах 
        /// array1 и array2 неравна, возвращается false.
        /// </summary>
        /// <remarks>Если хотя бы один из массивов array1 и array2 содержит меньше 2 элементов, сгенерируется исключение. Если какой-то из 
        /// массивов array1 и array2 содержит больше 2 элементов, они просто никак не учитываются при вызове метода. Сравнение 
        /// осуществляется по первым двум элементам.</remarks>
        public static bool EqualsTwoItems (this double [] array1, double [] array2)
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
        public static bool EqualsThreeItems (this double [] array1, double [] array2)
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
        public static bool EqualsFourItems (this double [] array1, double [] array2)
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
        public static bool EqualsNineItems (this double [] array1, double [] array2)
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

        /// <summary>
        /// Складывает попарно элементы массивов array1 и array2 и сохраняет суммы пар элементов в массив sum.
        /// </summary>
        /// <remarks>Предполагается, что массивы array1 и array2 имеют одинаковую длину. Проверка на данное условие внутри метода не 
        /// производится. Если окажется, что массивы, переданные в метод, имеют разную длину, то либо будет сгенерировано исключение, 
        /// либо «лишние» элементы одного из массивов никак не будут учтены при сложении. В любом случае, поведение метода в данной 
        /// ситуации не документируется.</remarks>
        public static void Add (this double [] sum, double [] array1, double [] array2)
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
        public static void Subtract (this double [] difference, double [] array1, double [] array2)
        {
            for (int i = 0; i < difference.Length; i++)
            {
                difference [i] = array1 [i] - array2 [i];
            }
        }

        /// <summary>
        /// Заполняет массив negate числами, противоположными элементам массива array.
        /// </summary>
        public static void Negate (this double [] negation, double [] array)
        {
            for (int i = 0; i < negation.Length; i++)
            {
                negation [i] = -array [i];
            }
        }

        /// <summary>
        /// Умножает элементы массива array на число coefficient и сохраняет произведения в массив product.
        /// </summary>
        public static void Multiply (this double [] product, double [] array, double coefficient)
        {
            for (int i = 0; i < product.Length; i++)
            {
                product [i] = array [i] * coefficient;
            }
        }

        /// <summary>
        /// Делит элементы массива array на число coefficient и сохраняет произведения в массив quotient.
        /// </summary>
        public static void Divide (this double [] quotient, double [] array, double coefficient)
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
        public static double InnerProduct (this double [] array1, double [] array2)
        {
            double result = 0.0;

            for (int i = 0; i < array1.Length; i++)
            {
                result += array1 [i] * array2 [i];
            }

            return result;
        }

        public static double SumOfSquares (this double [] array)
        {
            return array.InnerProduct (array);
        }
    }
}