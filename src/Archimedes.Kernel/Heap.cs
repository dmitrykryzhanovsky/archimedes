using System.Numerics;

namespace Archimedes
{
    public static class Heap
    {
        /// <summary>
        /// Поддержание свойства невозрастающей пирамиды для поддерева с корнем в индексе <paramref name="subtreeRoot"/>.
        /// </summary>
        /// <param name="firstLeaf">Индекс первого листа. Равен (int)((lastLeaf + 1) / 2), где <paramref name="lastLeaf"/> – индекс 
        /// последнего элемента пирамиды. В том случае, если размер пирамиды равен размеру массива <paramref name="array"/>, значение 
        /// firstLeaf = (int)(array.Length / 2).</param>
        /// <param name="lastLeaf">Индекс последнего элемента пирамиды. В том случае, если размер пирамиды равен размеру массива 
        /// <paramref name="array"/>, значение lastLeaf = array.Length – 1.</param>
        /// <remarks>Этот метод предназначен не для построения невозрастающей пирамиды с корнем в индексе <paramref name="subtreeRoot"/>, 
        /// а именно для поддержания свойства невозрастания для поддерева с корнем в индексе <paramref name="subtreeRoot"/>. Он будет 
        /// корректно работать только в том случае, если левое и правое дочерние поддеревья для корневого элемента уже поддерживают 
        /// свойство невозрастания.</remarks>
        public static void MaxHeapify<T> (this T [] array, int subtreeRoot, int firstLeaf, int lastLeaf) where T : INumber<T>
        {
            int i = subtreeRoot;

            // Спускаемся по пирамиде, пока не будут достигнуты листья (элементы, не имеющие дочерних) или пока в поддереве с корнем в
            // индексе subtreeRoot не будет поддерживаться свойство невозрастания.
            while (i < firstLeaf)
            {
                int leftChild = (i << 1) + 1;
                int largest   = (leftChild < lastLeaf) ? array.MaxIndex3 (i, leftChild, leftChild + 1) : 
                                                         array.MaxIndex2 (i, leftChild);

                // Если элемент с индексом i нарушил порядок невозрастания, проталкиваем его вниз.
                if (largest > i)
                {
                    array.Swap (i, largest);

                    i = largest;
                }

                // Если элемент с индексом i не нарушил порядок невозрастания, свойство невозрастания поддерживается, выходим из цикла.
                else break;
            }
        }

        /// <summary>
        /// Преобразует массив <paramref name="array"/> в невозрастающую бинарную пирамиду.
        /// </summary>
        /// <remarks>Время работы O (n) (см. [Кормен], раздел 6.3).</remarks>
        public static void BuildMaxHeap<T> (this T [] array) where T : INumber<T>
        {
            int firstLeaf = array.Length >> 1;
            int lastLeaf  = array.Length - 1;

            for (int i = firstLeaf - 1; i >= 0; i--)
            {
                array.MaxHeapify (i, firstLeaf, lastLeaf);
            }
        }
    }
}