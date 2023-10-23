namespace Archimedes
{
    public static class Common
    {
        /// <summary>
        /// Возвращает пару чисел, в которой первым компонентом будет записан минимум от (a, b), а вторым – максимум от (a, b).
        /// </summary>
        public static (int min, int max) PairMinMax (int a, int b)
        {
            if (a < b) return (a, b);

            else return (b, a);
        }
    }
}