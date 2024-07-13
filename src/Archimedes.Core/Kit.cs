using System;
using System.Numerics;

namespace Archimedes
{
    public static class Kit
    {
        /// <summary>
        /// Обмен значениями между переменными <paramref name="a"/> и <paramref name="b"/>.
        /// </summary>
        public static void Swap<T> (ref T a, ref T b)
        {
            (a, b) = (b, a);
        }

        /// <summary>
        /// Обмен значениями между элементами массива, расположенными под индексами <paramref name="index1"/> и <paramref name="index2"/>.
        /// </summary>
        public static void Swap<T> (this T [] array, int index1, int index2)
        {
            (array [index1], array [index2]) = (array [index2], array [index1]);
        }

        /// <summary>
        /// Обмен значениями между элементами списка, расположенными под индексами <paramref name="index1"/> и <paramref name="index2"/>.
        /// </summary>
        public static void Swap<T> (this List<T> list, int index1, int index2)
        {
            (list [index1], list [index2]) = (list [index2], list [index1]);
        }

        public static void Swap<T> (this T [,] array, int row1, int column1, int row2, int column2)
        {
            (array [row1, column1], array [row2, column2]) = (array [row2, column2], array [row1, column1]);
        }
    }
}