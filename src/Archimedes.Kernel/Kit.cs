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
            Swap (ref array [index1], ref array [index2]);
        }

        /// <summary>
        /// Обмен значениями между элементами списка, расположенными под индексами <paramref name="index1"/> и <paramref name="index2"/>.
        /// </summary>
        public static void Swap<T> (this List<T> list, int index1, int index2)
        {
            (list [index1], list [index2]) = (list [index2], list [index1]);
        }
    }
}