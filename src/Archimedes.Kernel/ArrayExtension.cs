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
    }
}