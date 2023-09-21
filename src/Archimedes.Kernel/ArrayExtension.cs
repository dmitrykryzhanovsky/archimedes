namespace Archimedes
{
    public static class ArrayExtension
    {
        public static bool EqualsByItems (this double [] array1, double [] array2)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1 [i] != array2 [i]) return false;
            }

            return true;
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
    }
}