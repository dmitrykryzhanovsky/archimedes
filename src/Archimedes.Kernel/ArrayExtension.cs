﻿namespace Archimedes
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Возвращает true, если массивы array1 и array2 имеют одинаковую длину и поэлементно равны; в противном случае false.
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
    }
}