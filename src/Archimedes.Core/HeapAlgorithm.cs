using System.Numerics;

namespace Archimedes
{
    public static class HeapAlgorithm
    {
        /// <summary>
        /// Поддержание свойства невозрастающей пирамиды для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>.
        /// </summary>
        /// <param name="firstLeafIndex">Индекс первого листа пирамиды.</param>
        /// <param name="lastLeafIndex">Индекс последнего элемента пирамиды.</param>
        /// <remarks>Этот метод предназначен не для построения невозрастающей пирамиды с корнем в индексе <paramref name="subtreeRootIndex"/>, 
        /// а именно для поддержания свойства невозрастания для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>. Он будет 
        /// корректно работать только в том случае, если левое и правое дочерние поддеревья для элемента с индексом 
        /// <paramref name="subtreeRootIndex"/> уже поддерживают свойство невозрастания.</remarks>
        public static void MaxHeapify<T> (this T [] array, int subtreeRootIndex, int firstLeafIndex, int lastLeafIndex) where T : INumber<T>
        {
            int i = subtreeRootIndex;

            // Спускаемся по пирамиде, пока не будут достигнуты листья (элементы, не имеющие дочерних) или пока в поддереве с корнем в
            // индексе subtreeRootIndex не будет поддерживаться свойство невозрастания.
            while (i < firstLeafIndex)
            {
                int leftChildIndex = GetLeftChildIndex (i);
                int largestIndex   = (leftChildIndex < lastLeafIndex) ? array.MaxIndex (i, leftChildIndex, leftChildIndex + 1) :
                                                                        array.MaxIndex (i, leftChildIndex);

                // Если элемент с индексом i нарушил порядок невозрастания, проталкиваем его вниз.
                if (array [largestIndex] > array [i])
                {
                    array.Swap (i, largestIndex);

                    i = largestIndex;
                }

                // Если элемент с индексом i не нарушил порядок невозрастания, свойство невозрастания поддерживается, выходим из цикла.
                else break;
            }
        }

        /// <summary>
        /// Возвращает индекс левого потомка для элемента с индексом <paramref name="index"/>.
        /// </summary>
        public static int GetLeftChildIndex (int index)
        {
            return (index << 1) + 1;
        }
    }
}