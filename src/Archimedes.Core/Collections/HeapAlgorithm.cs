using System.Numerics;

namespace Archimedes
{
    public static class HeapAlgorithm
    {
        /// <summary>
        /// Возвращает индекс первого листа для пирамиды размером <paramref name="length"/> (при условии, что индексация начинается с 
        /// 0).
        /// </summary>
        public static int GetFirstLeafIndex (int length)
        {
            return length >> 1;
        }

        /// <summary>
        /// Возвращает индекс родителя для элемента с индексом <paramref name="index"/>.
        /// </summary>
        public static int GetParentIndex (int index)
        {
            return (index - 1) >> 1;
        }

        /// <summary>
        /// Возвращает индекс левого потомка для элемента с индексом <paramref name="index"/>.
        /// </summary>
        public static int GetLeftChildIndex (int index)
        {
            return (index << 1) + 1;
        }

        /// <summary>
        /// Поддержание свойства невозрастающей пирамиды для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>.
        /// </summary>
        /// <param name="firstLeafIndex">Индекс первого листа пирамиды.</param>
        /// <param name="lastLeafIndex">Индекс последнего элемента пирамиды.</param>
        /// <remarks>Этот метод предназначен не для построения невозрастающей пирамиды с корнем в индексе <paramref name="subtreeRootIndex"/>, 
        /// а именно для поддержания свойства невозрастания для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>.</remarks>
        public static void MaxHeapify<T> (this T [] array, int subtreeRootIndex, int firstLeafIndex, int lastLeafIndex) where T : INumber<T>
        {
            int i = subtreeRootIndex;

            // Спускаемся по пирамиде, пока не будут достигнуты листья (элементы, не имеющие дочерних) или пока в поддереве с корнем в
            // индексе subtreeRootIndex не будет поддерживаться свойство невозрастания.
            while (i < firstLeafIndex)
            {
                int leftChildIndex   = GetLeftChildIndex (i);
                int excessChildIndex = (leftChildIndex < lastLeafIndex) ? array.MaxIndex (leftChildIndex, leftChildIndex + 1) : 
                    leftChildIndex;

                // Если элемент с индексом i нарушил порядок невозрастания, проталкиваем его вниз.
                if (array [excessChildIndex] > array [i])
                {
                    array.Swap (i, excessChildIndex);

                    i = excessChildIndex;
                }

                // Если элемент с индексом i не нарушил порядок невозрастания, свойство невозрастания поддерживается, выходим из цикла.
                else break;
            }
        }

        /// <summary>
        /// Поддержание свойства неубывающей пирамиды для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>.
        /// </summary>
        /// <param name="firstLeafIndex">Индекс первого листа пирамиды.</param>
        /// <param name="lastLeafIndex">Индекс последнего элемента пирамиды.</param>
        /// <remarks>Этот метод предназначен не для построения неубывающей пирамиды с корнем в индексе <paramref name="subtreeRootIndex"/>, 
        /// а именно для поддержания свойства неубывания для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>.</remarks>
        public static void MinHeapify<T> (this T [] array, int subtreeRootIndex, int firstLeafIndex, int lastLeafIndex) where T : INumber<T>
        {
            int i = subtreeRootIndex;

            // Спускаемся по пирамиде, пока не будут достигнуты листья (элементы, не имеющие дочерних) или пока в поддереве с корнем в
            // индексе subtreeRootIndex не будет поддерживаться свойство неубывания.
            while (i < firstLeafIndex)
            {
                int leftChildIndex   = GetLeftChildIndex (i);
                int excessChildIndex = (leftChildIndex < lastLeafIndex) ? array.MinIndex (leftChildIndex, leftChildIndex + 1) :
                    leftChildIndex;

                // Если элемент с индексом i нарушил порядок неубывания, проталкиваем его вниз.
                if (array [excessChildIndex] < array [i])
                {
                    array.Swap (i, excessChildIndex);

                    i = excessChildIndex;
                }

                // Если элемент с индексом i не нарушил порядок неубывания, свойство неубывания поддерживается, выходим из цикла.
                else break;
            }
        }

        /// <summary>
        /// Преобразует массив <paramref name="array"/> в невозрастающую бинарную пирамиду.
        /// </summary>
        /// <param name="firstLeafIndex">Индекс первого листа пирамиды.</param>
        /// <param name="lastLeafIndex">Индекс последнего элемента пирамиды.</param>
        /// <remarks>Время работы O (n) (см. [Кормен], раздел 6.3).</remarks>
        public static void BuildMaxHeap<T> (this T [] array, int firstLeafIndex, int lastLeafIndex) where T : INumber<T>
        {
            for (int i = firstLeafIndex - 1; i >= 0; i--)
            {
                array.MaxHeapify (i, firstLeafIndex, lastLeafIndex);
            }
        }

        /// <summary>
        /// Преобразует массив <paramref name="array"/> в неубывающую бинарную пирамиду.
        /// </summary>
        /// <param name="firstLeafIndex">Индекс первого листа пирамиды.</param>
        /// <param name="lastLeafIndex">Индекс последнего элемента пирамиды.</param>
        /// <remarks>Время работы O (n) (см. [Кормен], раздел 6.3).</remarks>
        public static void BuildMinHeap<T> (this T [] array, int firstLeafIndex, int lastLeafIndex) where T : INumber<T>
        {
            for (int i = firstLeafIndex - 1; i >= 0; i--)
            {
                array.MinHeapify (i, firstLeafIndex, lastLeafIndex);
            }
        }
    }
}