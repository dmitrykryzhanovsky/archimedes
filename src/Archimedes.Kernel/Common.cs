using System.Numerics;

namespace Archimedes
{
    public static class Common
    {
        /// <summary>
        /// Возвращает пару чисел, в которой первым компонентом будет записан минимум от (a, b), а вторым – максимум от (a, b).
        /// </summary>
        public static (T min, T max) PairMinMax<T> (T a, T b) where T : INumber<T>
        {
            return (a < b) ? (a, b) : (b, a);
        }

        public static void Swap<T> (this T [] array, int index1, int index2)
        {
            (array [index2], array [index1]) = (array [index1], array [index2]);
        }
    }
}