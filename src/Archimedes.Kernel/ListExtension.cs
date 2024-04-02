using System.Numerics;

namespace Archimedes
{
    public static class ListExtension
    {
        #region Relations

        /// <summary>
        /// Поэлементное сравнение списков <paramref name="list1"/> и <paramref name="list2"/>.
        /// </summary>
        /// <returns>Возвращает TRUE, если оба списка имеют одинаковую длину и поэлементно равны друг другу. В противном случае FALSE.</returns>
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

        #endregion

        /// <summary>
        /// Возвращает индекс, который соответствует наибольшему из элементов списка list [index1] и list [index2].
        /// </summary>
        /// <remarks>Если list [index1] = list [index2], то возвращается index1.</remarks>
        public static int MaxIndex<T> (this List<T> list, int index1, int index2) where T : INumber<T>
        {
            return (list [index1] >= list [index2]) ? index1 : index2;
        }

        /// <summary>
        /// Возвращает индекс, который соответствует наименьшему из элементов списка list [index1] и list [index2].
        /// </summary>
        /// <remarks>Если list [index1] = list [index2], то возвращается index1.</remarks>
        public static int MinIndex<T> (this List<T> list, int index1, int index2) where T : INumber<T>
        {
            return (list [index1] <= list [index2]) ? index1 : index2;
        }

        /// <summary>
        /// Возвращает индекс, который соответствует наибольшему из элементов списка list [index1], list [index2] и list [index3].
        /// </summary>
        /// <remarks><list type="bullet">
        /// <item>Если list [index1] = list [index2] = list [index3], возвращается index1.</item>
        /// <item>Если list [index1] = list [index2] > list [index3], возвращается index1.</item>
        /// <item>Если list [index1] = list [index3] > list [index2], возвращается index1.</item>
        /// <item>Если list [index2] = list [index3] > list [index1], возвращается index2.</item>
        /// </list></remarks>
        public static int MaxIndex<T> (this List<T> list, int index1, int index2, int index3) where T : INumber<T>
        {
            int maxIndex12 = list.MaxIndex (index1, index2);

            return list.MaxIndex (maxIndex12, index3);
        }

        /// <summary>
        /// Возвращает индекс, который соответствует наименьшему из элементов списка list [index1], list [index2] и list [index3].
        /// </summary>
        /// <remarks><list type="bullet">
        /// <item>Если list [index1] = list [index2] = list [index3], возвращается index1.</item>
        /// <item>Если list [index1] = list [index2] < list [index3], возвращается index1.</item>
        /// <item>Если list [index1] = list [index3] < list [index2], возвращается index1.</item>
        /// <item>Если list [index2] = list [index3] < list [index1], возвращается index2.</item>
        /// </list></remarks>
        public static int MinIndex<T> (this List<T> list, int index1, int index2, int index3) where T : INumber<T>
        {
            int maxIndex12 = list.MinIndex (index1, index2);

            return list.MinIndex (maxIndex12, index3);
        }
    }
}