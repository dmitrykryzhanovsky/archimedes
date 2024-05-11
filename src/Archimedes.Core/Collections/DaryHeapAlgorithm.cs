namespace Archimedes
{
    /// <summary>
    /// Функции для работы с d-арными пирамидами.
    /// </summary>
    public static class DaryHeapAlgorithm
    {
        /// <summary>
        /// Возвращает индекс первого листа для <paramref name="d"/>-арной пирамиды размером <paramref name="length"/> (при условии, 
        /// что индексация начинается с 0).
        /// </summary>
        public static int GetFirstLeafIndex (int length, int d)
        {
            return (length + d - 2) / d;
        }

        /// <summary>
        /// Возвращает индекс родителя для элемента с индексом <paramref name="index"/> в <paramref name="d"/>-арной пирамиде.
        /// </summary>
        public static int GetParentIndex (int index, int d)
        {
            return (index - 1) / d;
        }

        /// <summary>
        /// Возвращает индекс потомка номер <paramref name="childNumber"/> для элемента с индексом <paramref name="index"/> в 
        /// <paramref name="d"/>-арной пирамиде.
        /// </summary>
        public static int GetChildIndex (int index, int childNumber, int d)
        {
            return index * d + 1 + childNumber;
        }
    }
}