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
        /// корректно работать только в том случае, если левое и правое дочерние поддеревья для элемента с индексом 
        /// <paramref name="subtreeRoot"/> уже поддерживают свойство невозрастания.</remarks>
        public static void MaxHeapify<T> (this T [] array, int subtreeRoot, int firstLeaf, int lastLeaf) where T : INumber<T>
        {
            int i = subtreeRoot;

            // Спускаемся по пирамиде, пока не будут достигнуты листья (элементы, не имеющие дочерних) или пока в поддереве с корнем в
            // индексе subtreeRoot не будет поддерживаться свойство невозрастания.
            while (i < firstLeaf)
            {
                int leftChild = GetLeftChild (i);
                int largest   = (leftChild < lastLeaf) ? array.MaxIndex (i, leftChild, leftChild + 1) : 
                                                         array.MaxIndex (i, leftChild);

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
        /// Поддержание свойства невозрастающей пирамиды для поддерева с корнем в индексе <paramref name="subtreeRoot"/>.
        /// </summary>
        /// <param name="firstLeaf">Индекс первого листа. Равен (int)((lastLeaf + 1) / 2), где <paramref name="lastLeaf"/> – индекс 
        /// последнего элемента пирамиды. В том случае, если размер пирамиды равен размеру списка <paramref name="list"/>, значение 
        /// firstLeaf = (int)(list.Count / 2).</param>
        /// <param name="lastLeaf">Индекс последнего элемента пирамиды. В том случае, если размер пирамиды равен размеру списка 
        /// <paramref name="list"/>, значение lastLeaf = list.Count – 1.</param>
        /// <remarks>Этот метод предназначен не для построения невозрастающей пирамиды с корнем в индексе <paramref name="subtreeRoot"/>, 
        /// а именно для поддержания свойства невозрастания для поддерева с корнем в индексе <paramref name="subtreeRoot"/>. Он будет 
        /// корректно работать только в том случае, если левое и правое дочерние поддеревья для элемента с индексом 
        /// <paramref name="subtreeRoot"/> уже поддерживают свойство невозрастания.</remarks>
        public static void MaxHeapify<T> (this List<T> list, int subtreeRoot, int firstLeaf, int lastLeaf) where T : INumber<T>
        {
            int i = subtreeRoot;

            // Спускаемся по пирамиде, пока не будут достигнуты листья (элементы, не имеющие дочерних) или пока в поддереве с корнем в
            // индексе subtreeRoot не будет поддерживаться свойство невозрастания.
            while (i < firstLeaf)
            {
                int leftChild = GetLeftChild (i);
                int largest   = (leftChild < lastLeaf) ? list.MaxIndex (i, leftChild, leftChild + 1) :
                                                         list.MaxIndex (i, leftChild);

                // Если элемент с индексом i нарушил порядок невозрастания, проталкиваем его вниз.
                if (largest > i)
                {
                    list.Swap (i, largest);

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
            int firstLeaf = GetFirstLeaf (array.Length);
            int lastLeaf  = array.Length - 1;

            for (int i = firstLeaf - 1; i >= 0; i--)
            {
                array.MaxHeapify (i, firstLeaf, lastLeaf);
            }
        }

        /// <summary>
        /// Возвращает индекс первого листа для пирамиды размером <paramref name="length"/> (при условии, что индексация начинается с 0).
        /// </summary>
        public static int GetFirstLeaf (int length)
        {
            return length >> 1;
        }

        /// <summary>
        /// Возвращает индекс левого потомка для элемента с индексом <paramref name="index"/>.
        /// </summary>
        public static int GetLeftChild (int index)
        {
            return (index << 1) + 1;
        }

        /// <summary>
        /// Возвращает индекс родителя для элемента с индексом <paramref name="index"/>.
        /// </summary>
        public static int GetParent (int index)
        {
            return (index - 1) >> 1;
        }
    }
}