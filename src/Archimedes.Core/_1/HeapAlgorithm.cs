using System.Numerics;

namespace Archimedes
{
    public static class HeapAlgorithm
    {
        

        //***

        /// <summary>
        /// Поддержание свойства невозрастающей пирамиды для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>.
        /// </summary>
        /// <param name="firstLeafIndex">Индекс первого листа пирамиды.</param>
        /// <param name="lastLeafIndex">Индекс последнего элемента пирамиды.</param>
        /// <remarks>Этот метод предназначен не для построения невозрастающей пирамиды с корнем в индексе <paramref name="subtreeRootIndex"/>, 
        /// а именно для поддержания свойства невозрастания для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>. Он будет 
        /// корректно работать только в том случае, если левое и правое дочерние поддеревья для элемента с индексом 
        /// <paramref name="subtreeRootIndex"/> уже поддерживают свойство невозрастания.</remarks>
        public static void MaxHeapify<T> (this T [] collection, int subtreeRootIndex, HeapWrapperOnCollection<T> heapWrapper) where T : INumber<T>
        {
            int i = subtreeRootIndex;

            // Спускаемся по пирамиде, пока не будут достигнуты листья (элементы, не имеющие дочерних) или пока в поддереве с корнем в
            // индексе subtreeRootIndex не будет поддерживаться свойство невозрастания.
            while (heapWrapper.IsItemNotLeaf (i))
            {
                int excessChildIndex = heapWrapper.ExcessChildIndex (i, collection);

                // Если элемент с индексом i нарушил порядок невозрастания, проталкиваем его вниз.
                if (heapWrapper.IsOrderInvalid (collection [excessChildIndex], collection [i]))
                {
                    collection.Swap (i, excessChildIndex);

                    i = excessChildIndex;
                }

                // Если элемент с индексом i не нарушил порядок невозрастания, свойство невозрастания поддерживается, выходим из цикла.
                else break;
            }
        }

        /// <summary>
        /// Поддержание свойства невозрастающей пирамиды для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>.
        /// </summary>
        /// <param name="firstLeafIndex">Индекс первого листа пирамиды.</param>
        /// <param name="lastLeafIndex">Индекс последнего элемента пирамиды.</param>
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
        /// Поддержание свойства невозрастающей пирамиды для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/> для пар 
        /// (ключ <paramref name="keyArray"/>, сопутствующие данные <paramref name="dataArray"/>).
        /// </summary>
        /// <param name="firstLeafIndex">Индекс первого листа пирамиды.</param>
        /// <param name="lastLeafIndex">Индекс последнего элемента пирамиды.</param>
        /// <remarks>Этот метод предназначен не для построения невозрастающей пирамиды с корнем в индексе <paramref name="subtreeRootIndex"/>, 
        /// а именно для поддержания свойства невозрастания для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>. Он будет 
        /// корректно работать только в том случае, если левое и правое дочерние поддеревья для элемента с индексом 
        /// <paramref name="subtreeRootIndex"/> уже поддерживают свойство невозрастания.</remarks>
        public static void MaxHeapify<TKEY, TDATA> (this TKEY [] keyArray, TDATA [] dataArray, int subtreeRootIndex, 
            int firstLeafIndex, int lastLeafIndex) where TKEY : INumber<TKEY>
        {
            int i = subtreeRootIndex;

            // Спускаемся по пирамиде, пока не будут достигнуты листья (элементы, не имеющие дочерних) или пока в поддереве с корнем в
            // индексе subtreeRootIndex не будет поддерживаться свойство невозрастания.
            while (i < firstLeafIndex)
            {
                int leftChildIndex = GetLeftChildIndex (i);
                int largestIndex   = (leftChildIndex < lastLeafIndex) ? keyArray.MaxIndex (i, leftChildIndex, leftChildIndex + 1) :
                                                                        keyArray.MaxIndex (i, leftChildIndex);

                // Если элемент с индексом i нарушил порядок невозрастания, проталкиваем его вниз.
                if (keyArray [largestIndex] > keyArray [i])
                {
                    keyArray.Swap (i, largestIndex);
                    dataArray.Swap (i, largestIndex);

                    i = largestIndex;
                }

                // Если элемент с индексом i не нарушил порядок невозрастания, свойство невозрастания поддерживается, выходим из цикла.
                else break;
            }
        }

        /// <summary>
        /// Поддержание свойства невозрастающей пирамиды для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/> для пар 
        /// (ключ <paramref name="keyList"/>, сопутствующие данные <paramref name="dataList"/>).
        /// </summary>
        /// <param name="firstLeafIndex">Индекс первого листа пирамиды.</param>
        /// <param name="lastLeafIndex">Индекс последнего элемента пирамиды.</param>
        /// <remarks>Этот метод предназначен не для построения невозрастающей пирамиды с корнем в индексе <paramref name="subtreeRootIndex"/>, 
        /// а именно для поддержания свойства невозрастания для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>. Он будет 
        /// корректно работать только в том случае, если левое и правое дочерние поддеревья для элемента с индексом 
        /// <paramref name="subtreeRootIndex"/> уже поддерживают свойство невозрастания.</remarks>
        public static void MaxHeapify<TKEY, TDATA> (this List<TKEY> keyList, List<TDATA> dataList, int subtreeRootIndex, 
            int firstLeafIndex, int lastLeafIndex) where TKEY : INumber<TKEY>
        {
            int i = subtreeRootIndex;

            // Спускаемся по пирамиде, пока не будут достигнуты листья (элементы, не имеющие дочерних) или пока в поддереве с корнем в
            // индексе subtreeRootIndex не будет поддерживаться свойство невозрастания.
            while (i < firstLeafIndex)
            {
                int leftChildIndex = GetLeftChildIndex (i);
                int largestIndex   = (leftChildIndex < lastLeafIndex) ? keyList.MaxIndex (i, leftChildIndex, leftChildIndex + 1) :
                                                                        keyList.MaxIndex (i, leftChildIndex);

                // Если элемент с индексом i нарушил порядок невозрастания, проталкиваем его вниз.
                if (keyList [largestIndex] > keyList [i])
                {
                    keyList.Swap (i, largestIndex);
                    dataList.Swap (i, largestIndex);

                    i = largestIndex;
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
        /// <param name="firstLeafIndex">Индекс первого листа пирамиды.</param>
        /// <param name="lastLeafIndex">Индекс последнего элемента пирамиды.</param>
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
        /// Поддержание свойства неубывающей пирамиды для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/> для пар 
        /// (ключ <paramref name="keyArray"/>, сопутствующие данные <paramref name="dataArray"/>).
        /// </summary>
        /// <param name="firstLeafIndex">Индекс первого листа пирамиды.</param>
        /// <param name="lastLeafIndex">Индекс последнего элемента пирамиды.</param>
        /// <remarks>Этот метод предназначен не для построения неубывающей пирамиды с корнем в индексе <paramref name="subtreeRootIndex"/>, 
        /// а именно для поддержания свойства неубывания для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>. Он будет 
        /// корректно работать только в том случае, если левое и правое дочерние поддеревья для элемента с индексом 
        /// <paramref name="subtreeRootIndex"/> уже поддерживают свойство неубывания.</remarks>
        public static void MinHeapify<TKEY, TDATA> (this TKEY [] keyArray, TDATA [] dataArray, int subtreeRootIndex,
            int firstLeafIndex, int lastLeafIndex) where TKEY : INumber<TKEY>
        {
            int i = subtreeRootIndex;

            // Спускаемся по пирамиде, пока не будут достигнуты листья (элементы, не имеющие дочерних) или пока в поддереве с корнем в
            // индексе subtreeRootIndex не будет поддерживаться свойство неубывания.
            while (i < firstLeafIndex)
            {
                int leftChildIndex = GetLeftChildIndex (i);
                int smallestIndex  = (leftChildIndex < lastLeafIndex) ? keyArray.MinIndex (i, leftChildIndex, leftChildIndex + 1) :
                                                                        keyArray.MinIndex (i, leftChildIndex);

                // Если элемент с индексом i нарушил порядок неубывания, проталкиваем его вниз.
                if (keyArray [smallestIndex] < keyArray [i])
                {
                    keyArray.Swap (i, smallestIndex);
                    dataArray.Swap (i, smallestIndex);

                    i = smallestIndex;
                }

                // Если элемент с индексом i не нарушил порядок неубывания, свойство невозрастания поддерживается, выходим из цикла.
                else break;
            }
        }

        /// <summary>
        /// Поддержание свойства неубывающей пирамиды для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/> для пар 
        /// (ключ <paramref name="keyList"/>, сопутствующие данные <paramref name="dataList"/>).
        /// </summary>
        /// <param name="firstLeafIndex">Индекс первого листа пирамиды.</param>
        /// <param name="lastLeafIndex">Индекс последнего элемента пирамиды.</param>
        /// <remarks>Этот метод предназначен не для построения неубывающей пирамиды с корнем в индексе <paramref name="subtreeRootIndex"/>, 
        /// а именно для поддержания свойства неубывания для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>. Он будет 
        /// корректно работать только в том случае, если левое и правое дочерние поддеревья для элемента с индексом 
        /// <paramref name="subtreeRootIndex"/> уже поддерживают свойство неубывания.</remarks>
        public static void MinHeapify<TKEY, TDATA> (this List<TKEY> keyList, List<TDATA> dataList, int subtreeRootIndex,
            int firstLeafIndex, int lastLeafIndex) where TKEY : INumber<TKEY>
        {
            int i = subtreeRootIndex;

            // Спускаемся по пирамиде, пока не будут достигнуты листья (элементы, не имеющие дочерних) или пока в поддереве с корнем в
            // индексе subtreeRootIndex не будет поддерживаться свойство неубывания.
            while (i < firstLeafIndex)
            {
                int leftChildIndex = GetLeftChildIndex (i);
                int smallestIndex  = (leftChildIndex < lastLeafIndex) ? keyList.MinIndex (i, leftChildIndex, leftChildIndex + 1) :
                                                                        keyList.MinIndex (i, leftChildIndex);

                // Если элемент с индексом i нарушил порядок неубывания, проталкиваем его вниз.
                if (keyList [smallestIndex] < keyList [i])
                {
                    keyList.Swap (i, smallestIndex);
                    dataList.Swap (i, smallestIndex);

                    i = smallestIndex;
                }

                // Если элемент с индексом i не нарушил порядок неубывания, свойство невозрастания поддерживается, выходим из цикла.
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
        /// Преобразует массив <paramref name="keyArray"/> в невозрастающую бинарную пирамиду с сохранением сопутствующих данных в 
        /// <paramref name="dataArray"/>.
        /// </summary>
        /// <remarks>Время работы O (n) (см. [Кормен], раздел 6.3).</remarks>
        public static void BuildMaxHeap<TKEY, TDATA> (this TKEY [] keyArray, TDATA [] dataArray) where TKEY : INumber<TKEY>
        {
            int firstLeafIndex = GetFirstLeafIndex (keyArray.Length);
            int lastLeafIndex  = keyArray.Length - 1;

            for (int i = firstLeafIndex - 1; i >= 0; i--)
            {
                keyArray.MaxHeapify (dataArray, i, firstLeafIndex, lastLeafIndex);
            }
        }

        /// <summary>
        /// Преобразует список <paramref name="keyList"/> в невозрастающую бинарную пирамиду с сохранением сопутствующих данных в 
        /// <paramref name="dataList"/>.
        /// </summary>
        /// <remarks>Время работы O (n) (см. [Кормен], раздел 6.3).</remarks>
        public static void BuildMaxHeap<TKEY, TDATA> (this List<TKEY> keyList, List<TDATA> dataList) where TKEY : INumber<TKEY>
        {
            int firstLeafIndex = GetFirstLeafIndex (keyList.Count);
            int lastLeafIndex  = keyList.Count - 1;

            for (int i = firstLeafIndex - 1; i >= 0; i--)
            {
                keyList.MaxHeapify (dataList, i, firstLeafIndex, lastLeafIndex);
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
        /// Преобразует массив <paramref name="keyArray"/> в неубывающую бинарную пирамиду с сохранением сопутствующих данных в 
        /// <paramref name="dataArray"/>.
        /// </summary>
        /// <remarks>Время работы O (n) (см. [Кормен], раздел 6.3).</remarks>
        public static void BuildMinHeap<TKEY, TDATA> (this TKEY [] keyArray, TDATA [] dataArray) where TKEY : INumber<TKEY>
        {
            int firstLeafIndex = GetFirstLeafIndex (keyArray.Length);
            int lastLeafIndex  = keyArray.Length - 1;

            for (int i = firstLeafIndex - 1; i >= 0; i--)
            {
                keyArray.MinHeapify (dataArray, i, firstLeafIndex, lastLeafIndex);
            }
        }

        /// <summary>
        /// Преобразует список <paramref name="keyList"/> в неубывающую бинарную пирамиду с сохранением сопутствующих данных в 
        /// <paramref name="dataList"/>.
        /// </summary>
        /// <remarks>Время работы O (n) (см. [Кормен], раздел 6.3).</remarks>
        public static void BuildMinHeap<TKEY, TDATA> (this List<TKEY> keyList, List<TDATA> dataList) where TKEY : INumber<TKEY>
        {
            int firstLeafIndex = GetFirstLeafIndex (keyList.Count);
            int lastLeafIndex  = keyList.Count - 1;

            for (int i = firstLeafIndex - 1; i >= 0; i--)
            {
                keyList.MinHeapify (dataList, i, firstLeafIndex, lastLeafIndex);
            }
        }

        

        public static void InsertInMaxHeap<T> (this List<T> list, T value) where T : INumber<T>
        {
            list.Add (value);

            PutValueInMaxHeap (list, value, list.Count - 1);
        }

        public static void InsertInMaxHeap<TKEY, TDATA> (this List<TKEY> keyList, List<TDATA> dataList, TKEY key, TDATA data) 
            where TKEY : INumber<TKEY>
        {
            keyList.Add (key);
            dataList.Add (data);

            PutValueInMaxHeap (keyList, dataList, key, keyList.Count - 1);
        }

        public static void InsertInMinHeap<T> (this List<T> list, T value) where T : INumber<T>
        {
            list.Add (value);

            PutValueInMinHeap (list, value, list.Count - 1);
        }

        public static void InsertInMinHeap<TKEY, TDATA> (this List<TKEY> keyList, List<TDATA> dataList, TKEY key, TDATA data) 
            where TKEY : INumber<TKEY>
        {
            keyList.Add (key);
            dataList.Add (data);

            PutValueInMinHeap (keyList, dataList, key, keyList.Count - 1);
        }

        public static void DeleteFromMaxHeap<T> (this List<T> list, int deletedIndex, int firstLeafIndex, int lastLeafIndex) where T : INumber<T>
        {
            T deletedValue  = list [deletedIndex];
            T lastLeafValue = list [lastLeafIndex];

            list [deletedIndex] = lastLeafValue;

            if (deletedValue > lastLeafValue) MaxHeapify (list, deletedIndex, firstLeafIndex, lastLeafIndex);
            else PutValueInMaxHeap (list, lastLeafValue, deletedIndex);

            list.RemoveAt (lastLeafIndex);
        }

        public static void DeleteFromMaxHeap<TKEY, TDATA> (this List<TKEY> keyList, List<TDATA> dataList, int deletedIndex, 
            int firstLeafIndex, int lastLeafIndex) where TKEY : INumber<TKEY>
        {
            TKEY  deletedKey   = keyList [deletedIndex];
            TKEY  lastLeafKey  = keyList [lastLeafIndex];
            TDATA lastLeafData = dataList [lastLeafIndex];

            keyList [deletedIndex]  = lastLeafKey;
            dataList [deletedIndex] = lastLeafData;

            if (deletedKey > lastLeafKey) MaxHeapify (keyList, dataList, deletedIndex, firstLeafIndex, lastLeafIndex);
            else PutValueInMaxHeap (keyList, dataList, lastLeafKey, deletedIndex);

            keyList.RemoveAt (lastLeafIndex);
            dataList.RemoveAt (lastLeafIndex);
        }

        public static void DeleteFromMinHeap<T> (this List<T> list, int deletedIndex, int firstLeafIndex, int lastLeafIndex) where T : INumber<T>
        {
            T deletedValue  = list [deletedIndex];
            T lastLeafValue = list [lastLeafIndex];

            list [deletedIndex] = lastLeafValue;

            if (deletedValue < lastLeafValue) MinHeapify (list, deletedIndex, firstLeafIndex, lastLeafIndex);
            else PutValueInMinHeap (list, lastLeafValue, deletedIndex);

            list.RemoveAt (lastLeafIndex);
        }

        public static void DeleteFromMinHeap<TKEY, TDATA> (this List<TKEY> keyList, List<TDATA> dataList, int deletedIndex,
            int firstLeafIndex, int lastLeafIndex) where TKEY : INumber<TKEY>
        {
            TKEY  deletedKey   = keyList [deletedIndex];
            TKEY  lastLeafKey  = keyList [lastLeafIndex];
            TDATA lastLeafData = dataList [lastLeafIndex];

            keyList [deletedIndex]  = lastLeafKey;
            dataList [deletedIndex] = lastLeafData;

            if (deletedKey < lastLeafKey) MinHeapify (keyList, dataList, deletedIndex, firstLeafIndex, lastLeafIndex);
            else PutValueInMinHeap (keyList, dataList, lastLeafKey, deletedIndex);

            keyList.RemoveAt (lastLeafIndex);
            dataList.RemoveAt (lastLeafIndex);
        }

        /// <summary>
        /// Размещает элемент <paramref name="value"/>, расположенный при вызове методы по индексу <paramref name="valueIndex"/>, 
        /// таким образом, чтобы сохранялось свойство невозрастания / неубывания (в зависимости от типа пирамиды).
        /// </summary>
        private static void PutValueInMaxHeap<T> (this List<T> list, T value, int valueIndex) where T : INumber<T>
        {
            while (valueIndex > 0)
            {
                int parentIndex = GetParentIndex (valueIndex);

                if (value > list [parentIndex])
                {
                    list.Swap (valueIndex, parentIndex);
                    valueIndex = parentIndex;
                }

                else valueIndex = 0;
            }
        }

        private static void PutValueInMaxHeap<TKEY, TDATA> (this List<TKEY> keyList, List<TDATA> dataList, TKEY value, int valueIndex) 
            where TKEY : INumber<TKEY>
        {
            while (valueIndex > 0)
            {
                int parentIndex = GetParentIndex (valueIndex);

                if (value > keyList [parentIndex])
                {
                    keyList.Swap (valueIndex, parentIndex);
                    dataList.Swap (valueIndex, parentIndex);
                    valueIndex = parentIndex;
                }

                else valueIndex = 0;
            }
        }

        private static void PutValueInMinHeap<T> (this List<T> list, T value, int valueIndex) where T : INumber<T>
        {
            while (valueIndex > 0)
            {
                int parentIndex = GetParentIndex (valueIndex);

                if (value < list [parentIndex])
                {
                    list.Swap (valueIndex, parentIndex);
                    valueIndex = parentIndex;
                }

                else valueIndex = 0;
            }
        }

        private static void PutValueInMinHeap<TKEY, TDATA> (this List<TKEY> keyList, List<TDATA> dataList, TKEY value, int valueIndex)
            where TKEY : INumber<TKEY>
        {
            while (valueIndex > 0)
            {
                int parentIndex = GetParentIndex (valueIndex);

                if (value < keyList [parentIndex])
                {
                    keyList.Swap (valueIndex, parentIndex);
                    dataList.Swap (valueIndex, parentIndex);
                    valueIndex = parentIndex;
                }

                else valueIndex = 0;
            }
        }
    }
}