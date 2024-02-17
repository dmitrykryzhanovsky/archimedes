using System.Numerics;

namespace Archimedes
{
    public static class ArrayExtension
    {
        #region Relations

        /// <summary>
        /// Поэлементное сравнение массивов <paramref name="array1"/> и <paramref name="array2"/>.
        /// </summary>
        /// <returns>Возвращает TRUE, если оба массива имеют одинаковую длину и поэлементно равны друг другу. В противном случае FALSE.</returns>
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

        #endregion

        /// <summary>
        /// Возвращает индекс элемента, минимального на подмассиве [<paramref name="beginIndex"/> .. <paramref name="endIndex"/>].
        /// </summary>
        public static int FindMinIndex<T> (this T [] array, int beginIndex, int endIndex) where T : INumber<T>
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

        public static int MaxIndex2<T> (this T [] array, int index1, int index2) where T : INumber<T>
        {
            return (array [index1] >= array [index2]) ? index1 : index2;
        }

        public static int MaxIndex3<T> (this T [] array, int index1, int index2, int index3) where T : INumber<T>
        {
            int maxIndex12 = array.MaxIndex2 (index1, index2);

            return array.MaxIndex2 (maxIndex12, index3);
        }
    }
}