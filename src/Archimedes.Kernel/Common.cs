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

        public static void Swap<T> (ref T a, ref T b)
        {
            T temp = a;
            a = b; 
            b = temp;
        }

        public static void Swap<T> (this T [] array, int index1, int index2)
        {
            Swap<T> (ref array [index1], ref array [index2]);
        }
    }
}