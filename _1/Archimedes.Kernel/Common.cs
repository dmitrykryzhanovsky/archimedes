using System.Numerics;

namespace Archimedes
{
    public static class Common
    {
        /// <summary>
        /// Возвращает пару чисел, в которой первым компонентом будет записан минимум от (x, y), а вторым – максимум от (y, x).
        /// </summary>
        public static (T min, T max) MinMax<T> (T x, T y) where T : INumber<T>
        {
            return (x < y) ? (x, y) : (y, x);
        }

        /// <summary>
        /// Обмен значениями переменных x и y.
        /// </summary>
        public static void Swap<T> (ref T x, ref T y)
        {
            (y, x) = (x, y);
        }

        /// <summary>
        /// Обмен значениями элементов массива array, расположенных под индексами index1 и index2.
        /// </summary>
        public static void Swap<T> (this T [] array, int index1, int index2)
        {
            Swap (ref array [index1], ref array [index2]);
        }
    }
}