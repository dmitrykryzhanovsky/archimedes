﻿using System.Numerics;

namespace Archimedes
{
    /// <summary>
    /// d-арная невозрастающая пирамида.
    /// </summary>
    public class DaryMaxHeap<TKey, TValue> : MaxHeap<TKey, TValue> where TKey : INumber<TKey>
    {
        #region Constructors

        public DaryMaxHeap (int d) : base (d)
        {
        }

        public DaryMaxHeap (int d, List<TKey> keys, List<TValue> values) : base (d, keys, values)
        {
        }

        public DaryMaxHeap (int d, params (TKey key, TValue value) [] items) : base (d, items)
        {
        }

        #endregion

        /// <summary>
        /// Поддержание свойства невозрастающей пирамиды для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>.
        /// </summary>
        /// <param name="firstLeafIndex">Индекс первого листа пирамиды.</param>
        /// <param name="lastLeafIndex">Индекс последнего элемента пирамиды.</param>
        /// <remarks>Этот метод предназначен не для построения невозрастающей пирамиды с корнем в индексе <paramref name="subtreeRootIndex"/>, 
        /// а именно для поддержания свойства невозрастания для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>.</remarks>
        protected override void Heapify (int subtreeRootIndex, int firstLeafIndex, int lastLeafIndex)
        {
            int i = subtreeRootIndex;

            // Спускаемся по пирамиде, пока не будут достигнуты листья (элементы, не имеющие дочерних) или пока в поддереве с корнем в
            // индексе subtreeRootIndex не будет поддерживаться свойство невозрастания.
            while (i < firstLeafIndex)
            {
                // Определяем индекс наибольшего из потомков элемента с индексом i.
                int leftChildIndex   = DaryHeapAlgorithm.GetChildIndex (i, 0, _d);
                int rightChildIndex  = leftChildIndex + _d - 1;

                if (rightChildIndex > lastLeafIndex) rightChildIndex = lastLeafIndex;

                int excessChildIndex = _keys.MaxIndexInSubarray (leftChildIndex, rightChildIndex);

                // Если элемент с индексом i нарушил порядок невозрастания, проталкиваем его вниз.
                if (_keys [excessChildIndex] > _keys [i])
                {
                    _keys.Swap (i, excessChildIndex);
                    _values.Swap (i, excessChildIndex);

                    i = excessChildIndex;
                }

                // Если элемент с индексом i не нарушил порядок невозрастания, свойство невозрастания поддерживается, выходим из цикла.
                else break;
            }
        }

        /// <summary>
        /// Размещает элемент с ключом <paramref name="itemKey"/>, расположенный перед вызовом метода по индексу <paramref name="itemIndex"/>, 
        /// на корректную позицию в пирамиде, чтобы сохранялось свойство невозрастания.
        /// </summary>
        protected override void PutItem (TKey itemKey, int itemIndex)
        {
            // Пока элемент не окажется на корректной позиции или не будет достигнут корень пирамиды.
            while (itemIndex > 0)
            {
                int parentIndex = DaryHeapAlgorithm.GetParentIndex (itemIndex, _d);

                // Если нарушается порядок (текущий элемент больше родительского элемента), меняем их местами (поднимаем текущий
                // элемент наверх к корню пирамиды).
                if (itemKey > _keys [parentIndex])
                {
                    _keys.Swap (itemIndex, parentIndex);
                    _values.Swap (itemIndex, parentIndex);

                    itemIndex = parentIndex;
                }

                // Если порядок не нарушается, значит, элемент находится на корректной позиции – выходим из цикла.
                else itemIndex = 0;
            }
        }
    }
}