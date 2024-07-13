using System.Numerics;

namespace Archimedes
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Возвращает TRUE, если два массива поэлементно равны. В противном случае FALSE.
        /// </summary>
        public static bool Equals<T> (this T [] array1, T [] array2) where T : INumber<T>
        {
            if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1 [i] != array2 [i]) return false;
                }

                return true;
            }

            else return false;
        }

        /// <summary>
        /// Возвращает индекс, который соответствует наибольшему из элементов массива <paramref name="array"/> [<paramref name="index1"/>] 
        /// и <paramref name="array"/> [<paramref name="index2"/>].
        /// </summary>
        /// <remarks>Если array [index1] = array [index2], то возвращается <paramref name="index1"/>.</remarks>
        public static int MaxIndex<T> (this T [] array, int index1, int index2) where T : INumber<T>
        {
            return (array [index1] >= array [index2]) ? index1 : index2;
        }

        /// <summary>
        /// Возвращает индекс, который соответствует наибольшему из элементов массива <paramref name="array"/> [<paramref name="index1"/>], 
        /// <paramref name="array"/> [<paramref name="index2"/>] и <paramref name="array"/> [<paramref name="index3"/>].
        /// </summary>
        /// <remarks><list type="bullet">
        /// <item>Если array [index1] = array [index2] = array [index3], возвращается <paramref name="index1"/>.</item>
        /// <item>Если array [index1] = array [index2] > array [index3], возвращается <paramref name="index1"/>.</item>
        /// <item>Если array [index1] = array [index3] > array [index2], возвращается <paramref name="index1"/>.</item>
        /// <item>Если array [index2] = array [index3] > array [index1], возвращается <paramref name="index2"/>.</item>
        /// </list></remarks>
        public static int MaxIndex<T> (this T [] array, int index1, int index2, int index3) where T : INumber<T>
        {
            int maxIndex12 = array.MaxIndex (index1, index2);

            return array.MaxIndex (maxIndex12, index3);
        }

        /// <summary>
        /// Возвращает индекс элемента максимального на подмассиве [<paramref name="beginIndex"/> .. <paramref name="endIndex"/>].
        /// </summary>
        public static int MaxIndexInSubarray<T> (this T [] array, int beginIndex, int endIndex) where T : INumber<T>
        {
            T   max      = array [beginIndex];
            int maxIndex = beginIndex;

            for (int i = beginIndex + 1; i <= endIndex; i++)
            {
                if (array [i] > max)
                {
                    max      = array [i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        /// <summary>
        /// Возвращает индекс, который соответствует наименьшему из элементов массива <paramref name="array"/> [<paramref name="index1"/>] 
        /// и <paramref name="array"/> [<paramref name="index2"/>].
        /// </summary>
        /// <remarks>Если array [index1] = array [index2], то возвращается <paramref name="index2"/>.</remarks>
        public static int MinIndex<T> (this T [] array, int index1, int index2) where T : INumber<T>
        {
            return (array [index1] <= array [index2]) ? index1 : index2;
        }

        /// <summary>
        /// Возвращает индекс, который соответствует наименьшему из элементов массива <paramref name="array"/> [<paramref name="index1"/>], 
        /// <paramref name="array"/> [<paramref name="index2"/>] и <paramref name="array"/> [<paramref name="index3"/>].
        /// </summary>
        /// <remarks><list type="bullet">
        /// <item>Если array [index1] = array [index2] = array [index3], возвращается <paramref name="index1"/>.</item>
        /// <item>Если array [index1] = array [index2] > array [index3], возвращается <paramref name="index1"/>.</item>
        /// <item>Если array [index1] = array [index3] > array [index2], возвращается <paramref name="index1"/>.</item>
        /// <item>Если array [index2] = array [index3] > array [index1], возвращается <paramref name="index2"/>.</item>
        /// </list></remarks>
        public static int MinIndex<T> (this T [] array, int index1, int index2, int index3) where T : INumber<T>
        {
            int minIndex12 = array.MinIndex (index1, index2);

            return array.MinIndex (minIndex12, index3);
        }

        /// <summary>
        /// Возвращает индекс элемента минимального на подмассиве [<paramref name="beginIndex"/> .. <paramref name="endIndex"/>].
        /// </summary>
        public static int MinIndexInSubarray<T> (this T [] array, int beginIndex, int endIndex) where T : INumber<T>
        {
            T   min      = array [beginIndex];
            int minIndex = beginIndex;

            for (int i = beginIndex + 1; i <= endIndex; i++)
            {
                if (array [i] < min)
                {
                    min      = array [i];
                    minIndex = i;
                }
            }

            return minIndex;
        }
    }
}