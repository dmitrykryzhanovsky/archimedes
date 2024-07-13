using System.Numerics;

namespace Archimedes
{
    public static class ListExtension
    {
        /// <summary>
        /// Копирует элементы списка <paramref name="source"/> в список <paramref name="destination"/>.
        /// </summary>
        public static void CopyTo<T> (this List<T> source, List<T> destination)
        {
            foreach (T item in source)
            {
                destination.Add (item);
            }
        }

        /// <summary>
        /// Копирует элементы массива <paramref name="source"/> в список <paramref name="destination"/>.
        /// </summary>
        public static void CopyTo<T> (this T [] source, List<T> destination)
        {
            foreach (T item in source)
            {
                destination.Add (item);
            }
        }

        /// <summary>
        /// Возвращает TRUE, если два списка поэлементно равны. В противном случае FALSE.
        /// </summary>
        public static bool Equals<T> (this List<T> list1, List<T> list2) where T : INumber<T>
        {
            if (list1.Count == list2.Count)
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    if (list1 [i] != list2 [i]) return false;
                }

                return true;
            }

            else return false;
        }

        /// <summary>
        /// Возвращает индекс, который соответствует наибольшему из элементов списка <paramref name="list"/> [<paramref name="index1"/>] 
        /// и <paramref name="list"/> [<paramref name="index2"/>].
        /// </summary>
        /// <remarks>Если list [index1] = list [index2], то возвращается <paramref name="index1"/>.</remarks>
        public static int MaxIndex<T> (this List<T> list, int index1, int index2) where T : INumber<T>
        {
            return (list [index1] >= list [index2]) ? index1 : index2;
        }

        /// <summary>
        /// Возвращает индекс, который соответствует наибольшему из элементов списка <paramref name="list"/> [<paramref name="index1"/>], 
        /// <paramref name="list"/> [<paramref name="index2"/>] и <paramref name="list"/> [<paramref name="index3"/>].
        /// </summary>
        /// <remarks><list type="bullet">
        /// <item>Если list [index1] = list [index2] = list [index3], возвращается <paramref name="index1"/>.</item>
        /// <item>Если list [index1] = list [index2] > list [index3], возвращается <paramref name="index1"/>.</item>
        /// <item>Если list [index1] = list [index3] > list [index2], возвращается <paramref name="index1"/>.</item>
        /// <item>Если list [index2] = list [index3] > list [index1], возвращается <paramref name="index2"/>.</item>
        /// </list></remarks>
        public static int MaxIndex<T> (this List<T> list, int index1, int index2, int index3) where T : INumber<T>
        {
            int maxIndex12 = list.MaxIndex (index1, index2);

            return list.MaxIndex (maxIndex12, index3);
        }

        /// <summary>
        /// Возвращает индекс элемента максимального на подсписке [<paramref name="beginIndex"/> .. <paramref name="endIndex"/>].
        /// </summary>
        public static int MaxIndexInSubarray<T> (this List<T> list, int beginIndex, int endIndex) where T : INumber<T>
        {
            T   max      = list [beginIndex];
            int maxIndex = beginIndex;

            for (int i = beginIndex + 1; i <= endIndex; i++)
            {
                if (list [i] > max)
                {
                    max      = list [i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        /// <summary>
        /// Возвращает индекс, который соответствует наименьшему из элементов списка <paramref name="list"/> [<paramref name="index1"/>] 
        /// и <paramref name="list"/> [<paramref name="index2"/>].
        /// </summary>
        /// <remarks>Если list [index1] = list [index2], то возвращается <paramref name="index2"/>.</remarks>
        public static int MinIndex<T> (this List<T> list, int index1, int index2) where T : INumber<T>
        {
            return (list [index1] <= list [index2]) ? index1 : index2;
        }

        /// <summary>
        /// Возвращает индекс, который соответствует наименьшему из элементов списка <paramref name="list"/> [<paramref name="index1"/>], 
        /// <paramref name="list"/> [<paramref name="index2"/>] и <paramref name="list"/> [<paramref name="index3"/>].
        /// </summary>
        /// <remarks><list type="bullet">
        /// <item>Если list [index1] = list [index2] = list [index3], возвращается <paramref name="index1"/>.</item>
        /// <item>Если list [index1] = list [index2] > list [index3], возвращается <paramref name="index1"/>.</item>
        /// <item>Если list [index1] = list [index3] > list [index2], возвращается <paramref name="index1"/>.</item>
        /// <item>Если list [index2] = list [index3] > list [index1], возвращается <paramref name="index2"/>.</item>
        /// </list></remarks>
        public static int MinIndex<T> (this List<T> list, int index1, int index2, int index3) where T : INumber<T>
        {
            int minIndex12 = list.MinIndex (index1, index2);

            return list.MinIndex (minIndex12, index3);
        }

        /// <summary>
        /// Возвращает индекс элемента минимального на подсписке [<paramref name="beginIndex"/> .. <paramref name="endIndex"/>].
        /// </summary>
        public static int MinIndexInSubarray<T> (this List<T> list, int beginIndex, int endIndex) where T : INumber<T>
        {
            T   min      = list [beginIndex];
            int minIndex = beginIndex;

            for (int i = beginIndex + 1; i <= endIndex; i++)
            {
                if (list [i] < min)
                {
                    min      = list [i];
                    minIndex = i;
                }
            }

            return minIndex;
        }
    }
}