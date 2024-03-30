using System.Numerics;

namespace Archimedes
{
    public static class HeapAlgorithm
    {
        /// <summary>
        /// Поддержание свойства невозрастающей пирамиды для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>.
        /// </summary>
        /// <param name="firstLeafIndex">Индекс первого листа. Равен (int)((lastLeafIndex + 1) / 2), где <paramref name="lastLeafIndex"/> 
        /// – индекс последнего элемента пирамиды. В том случае, если размер пирамиды равен размеру массива <paramref name="array"/>, 
        /// значение firstLeafIndex = (int)(array.Length / 2).</param>
        /// <param name="lastLeafIndex">Индекс последнего элемента пирамиды. В том случае, если размер пирамиды равен размеру массива 
        /// <paramref name="array"/>, значение lastLeafIndex = array.Length – 1.</param>
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
        /// Поддержание свойства невозрастающей пирамиды для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>.
        /// </summary>
        /// <param name="firstLeafIndex">Индекс первого листа. Равен (int)((lastLeafIndex + 1) / 2), где <paramref name="lastLeafIndex"/> 
        /// – индекс последнего элемента пирамиды. В том случае, если размер пирамиды равен размеру списка <paramref name="list"/>, 
        /// значение firstLeafIndex = (int)(list.Count / 2).</param>
        /// <param name="lastLeafIndex">Индекс последнего элемента пирамиды. В том случае, если размер пирамиды равен размеру списка 
        /// <paramref name="list"/>, значение lastLeafIndex = list.Count – 1.</param>
        /// <remarks>Этот метод предназначен не для построения невозрастающей пирамиды с корнем в индексе <paramref name="subtreeRootIndex"/>, 
        /// а именно для поддержания свойства невозрастания для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>. Он будет 
        /// корректно работать только в том случае, если левое и правое дочерние поддеревья для элемента с индексом 
        /// <paramref name="subtreeRootIndex"/> уже поддерживают свойство невозрастания.</remarks>
        public static void MaxHeapify<T> (this List<T> list, int subtreeRootIndex, int firstLeafIndex, int lastLeafIndex) where T : INumber<T>
        {
            int i = subtreeRootIndex;

            // Спускаемся по пирамиде, пока не будут достигнуты листья (элементы, не имеющие дочерних) или пока в поддереве с корнем в
            // индексе subtreeRootIndex не будет поддерживаться свойство невозрастания.
            while (i < firstLeafIndex)
            {
                int leftChildIndex = GetLeftChildIndex (i);
                int largestIndex   = (leftChildIndex < lastLeafIndex) ? list.MaxIndex (i, leftChildIndex, leftChildIndex + 1) :
                                                                        list.MaxIndex (i, leftChildIndex);

                // Если элемент с индексом i нарушил порядок невозрастания, проталкиваем его вниз.
                if (list [largestIndex] > list [i])
                {
                    list.Swap (i, largestIndex);

                    i = largestIndex;
                }

                // Если элемент с индексом i не нарушил порядок невозрастания, свойство невозрастания поддерживается, выходим из цикла.
                else break;
            }
        }

        /// <summary>
        /// Поддержание свойства неубывающей пирамиды для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>.
        /// </summary>
        /// <param name="firstLeafIndex">Индекс первого листа. Равен (int)((lastLeafIndex + 1) / 2), где <paramref name="lastLeafIndex"/> 
        /// – индекс последнего элемента пирамиды. В том случае, если размер пирамиды равен размеру массива <paramref name="array"/>, 
        /// значение firstLeafIndex = (int)(array.Length / 2).</param>
        /// <param name="lastLeafIndex">Индекс последнего элемента пирамиды. В том случае, если размер пирамиды равен размеру массива 
        /// <paramref name="array"/>, значение lastLeafIndex = array.Length – 1.</param>
        /// <remarks>Этот метод предназначен не для построения неубывающей пирамиды с корнем в индексе <paramref name="subtreeRootIndex"/>, 
        /// а именно для поддержания свойства неубывания для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>. Он будет 
        /// корректно работать только в том случае, если левое и правое дочерние поддеревья для элемента с индексом 
        /// <paramref name="subtreeRootIndex"/> уже поддерживают свойство неубывания.</remarks>
        public static void MinHeapify<T> (this T [] array, int subtreeRootIndex, int firstLeafIndex, int lastLeafIndex) where T : INumber<T>
        {
            int i = subtreeRootIndex;

            // Спускаемся по пирамиде, пока не будут достигнуты листья (элементы, не имеющие дочерних) или пока в поддереве с корнем в
            // индексе subtreeRootIndex не будет поддерживаться свойство неубывания.
            while (i < firstLeafIndex)
            {
                int leftChildIndex = GetLeftChildIndex (i);
                int smallestIndex  = (leftChildIndex < lastLeafIndex) ? array.MinIndex (i, leftChildIndex, leftChildIndex + 1) :
                                                                        array.MinIndex (i, leftChildIndex);

                // Если элемент с индексом i нарушил порядок неубывания, проталкиваем его вниз.
                if (array [smallestIndex] < array [i])
                {
                    array.Swap (i, smallestIndex);

                    i = smallestIndex;
                }

                // Если элемент с индексом i не нарушил порядок неубывания, свойство неубывания поддерживается, выходим из цикла.
                else break;
            }
        }

        /// <summary>
        /// Поддержание свойства неубывающей пирамиды для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>.
        /// </summary>
        /// <param name="firstLeafIndex">Индекс первого листа. Равен (int)((lastLeafIndex + 1) / 2), где <paramref name="lastLeafIndex"/> 
        /// – индекс последнего элемента пирамиды. В том случае, если размер пирамиды равен размеру списка <paramref name="list"/>, 
        /// значение firstLeafIndex = (int)(list.Count / 2).</param>
        /// <param name="lastLeafIndex">Индекс последнего элемента пирамиды. В том случае, если размер пирамиды равен размеру списка 
        /// <paramref name="list"/>, значение lastLeafIndex = list.Count – 1.</param>
        /// <remarks>Этот метод предназначен не для построения неубывающей пирамиды с корнем в индексе <paramref name="subtreeRootIndex"/>, 
        /// а именно для поддержания свойства неубывания для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>. Он будет 
        /// корректно работать только в том случае, если левое и правое дочерние поддеревья для элемента с индексом 
        /// <paramref name="subtreeRootIndex"/> уже поддерживают свойство неубывания.</remarks>
        public static void MinHeapify<T> (this List<T> list, int subtreeRootIndex, int firstLeafIndex, int lastLeafIndex) where T : INumber<T>
        {
            int i = subtreeRootIndex;

            // Спускаемся по пирамиде, пока не будут достигнуты листья (элементы, не имеющие дочерних) или пока в поддереве с корнем в
            // индексе subtreeRootIndex не будет поддерживаться свойство неубывания.
            while (i < firstLeafIndex)
            {
                int leftChildIndex = GetLeftChildIndex (i);
                int smallestIndex  = (leftChildIndex < lastLeafIndex) ? list.MinIndex (i, leftChildIndex, leftChildIndex + 1) :
                                                                        list.MinIndex (i, leftChildIndex);

                // Если элемент с индексом i нарушил порядок неубывания, проталкиваем его вниз.
                if (list [smallestIndex] < list [i])
                {
                    list.Swap (i, smallestIndex);

                    i = smallestIndex;
                }

                // Если элемент с индексом i не нарушил порядок неубывания, свойство неубывания поддерживается, выходим из цикла.
                else break;
            }
        }

        /// <summary>
        /// Преобразует массив <paramref name="array"/> в невозрастающую бинарную пирамиду.
        /// </summary>
        /// <remarks>Время работы O (n) (см. [Кормен], раздел 6.3).</remarks>
        public static void BuildMaxHeap<T> (this T [] array) where T : INumber<T>
        {
            int firstLeafIndex = GetFirstLeafIndex (array.Length);
            int lastLeafIndex  = array.Length - 1;

            for (int i = firstLeafIndex - 1; i >= 0; i--)
            {
                array.MaxHeapify (i, firstLeafIndex, lastLeafIndex);
            }
        }

        /// <summary>
        /// Преобразует список <paramref name="list"/> в невозрастающую бинарную пирамиду.
        /// </summary>
        /// <remarks>Время работы O (n) (см. [Кормен], раздел 6.3).</remarks>
        public static void BuildMaxHeap<T> (this List<T> list) where T : INumber<T>
        {
            int firstLeafIndex = GetFirstLeafIndex (list.Count);
            int lastLeafIndex  = list.Count - 1;

            for (int i = firstLeafIndex - 1; i >= 0; i--)
            {
                list.MaxHeapify (i, firstLeafIndex, lastLeafIndex);
            }
        }

        /// <summary>
        /// Преобразует массив <paramref name="array"/> в неубывающую бинарную пирамиду.
        /// </summary>
        /// <remarks>Время работы O (n) (см. [Кормен], раздел 6.3).</remarks>
        public static void BuildMinHeap<T> (this T [] array) where T : INumber<T>
        {
            int firstLeafIndex = GetFirstLeafIndex (array.Length);
            int lastLeafIndex  = array.Length - 1;

            for (int i = firstLeafIndex - 1; i >= 0; i--)
            {
                array.MinHeapify (i, firstLeafIndex, lastLeafIndex);
            }
        }

        /// <summary>
        /// Преобразует список <paramref name="list"/> в неубывающую бинарную пирамиду.
        /// </summary>
        /// <remarks>Время работы O (n) (см. [Кормен], раздел 6.3).</remarks>
        public static void BuildMinHeap<T> (this List<T> list) where T : INumber<T>
        {
            int firstLeafIndex = GetFirstLeafIndex (list.Count);
            int lastLeafIndex  = list.Count - 1;

            for (int i = firstLeafIndex - 1; i >= 0; i--)
            {
                list.MinHeapify (i, firstLeafIndex, lastLeafIndex);
            }
        }

        /// <summary>
        /// Возвращает индекс первого листа для пирамиды размером <paramref name="length"/> (при условии, что индексация начинается с 0).
        /// </summary>
        public static int GetFirstLeafIndex (int length)
        {
            return length >> 1;
        }

        /// <summary>
        /// Возвращает индекс левого потомка для элемента с индексом <paramref name="index"/>.
        /// </summary>
        public static int GetLeftChildIndex (int index)
        {
            return (index << 1) + 1;
        }

        /// <summary>
        /// Возвращает индекс правого потомка для элемента с индексом <paramref name="index"/>.
        /// </summary>
        public static int GetRightChild (int index)
        {
            return (index << 1) + 2;
        }

        /// <summary>
        /// Возвращает индекс родителя для элемента с индексом <paramref name="index"/>.
        /// </summary>
        public static int GetParent (int index)
        {
            return (index - 1) >> 1;
        }

        public static int HowManyChildren (int index, int length, int firstLeaf)
        {
            if (index >= firstLeaf) return 0;
            else if ((length % 2 == 0) && (index == (firstLeaf - 1))) return 1;
            else return 2;
        }
    }
}