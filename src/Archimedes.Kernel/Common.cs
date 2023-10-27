using System.Numerics;

namespace Archimedes
{
    public static class Common
    {
        /// <summary>
        /// Возвращает пару чисел, в которой первым компонентом будет записан минимум от (x, y), а вторым – максимум от (y, x).
        /// </summary>
        public static (T min, T max) PairMinMax<T> (T x, T y) where T : INumber<T>
        {
            return (x < y) ? (x, y) : (y, x);
        }

        public static void Swap<T> (this T [] array, int index1, int index2)
        {
            (array [index2], array [index1]) = (array [index1], array [index2]);
        }
    }
}