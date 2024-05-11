using System.Numerics;

namespace Archimedes
{
    /// <summary>
    /// Неубывающая бинарная пирамида.
    /// </summary>
    public class MinHeap<TKey, TValue> : Heap<TKey, TValue> where TKey : INumber<TKey>
    {
        #region Constructors

        public MinHeap () : base ()
        {
        }

        public MinHeap (List<TKey> keys, List<TValue> values) : base (keys, values)
        {
        }

        public MinHeap (params (TKey key, TValue value) [] items) : base (items)
        {
        }

        #endregion

        /// <summary>
        /// Поддержание свойства неубывающей пирамиды для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>.
        /// </summary>
        /// <param name="firstLeafIndex">Индекс первого листа пирамиды.</param>
        /// <param name="lastLeafIndex">Индекс последнего элемента пирамиды.</param>
        /// <remarks>Этот метод предназначен не для построения неубывающей пирамиды с корнем в индексе <paramref name="subtreeRootIndex"/>, 
        /// а именно для поддержания свойства неубывания для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>.</remarks>
        protected override void Heapify (int subtreeRootIndex, int firstLeafIndex, int lastLeafIndex)
        {
            int i = subtreeRootIndex;

            // Спускаемся по пирамиде, пока не будут достигнуты листья (элементы, не имеющие дочерних) или пока в поддереве с корнем в
            // индексе subtreeRootIndex не будет поддерживаться свойство неубывания.
            while (i < firstLeafIndex)
            {
                int leftChildIndex   = HeapAlgorithm.GetLeftChildIndex (i);
                int excessChildIndex = (leftChildIndex < lastLeafIndex) ? _keys.MinIndex (leftChildIndex, leftChildIndex + 1) :
                    leftChildIndex;

                // Если элемент с индексом i нарушил порядок неубывания, проталкиваем его вниз.
                if (_keys [excessChildIndex] < _keys [i])
                {
                    _keys.Swap (i, excessChildIndex);
                    _values.Swap (i, excessChildIndex);

                    i = excessChildIndex;
                }

                // Если элемент с индексом i не нарушил порядок неубывания, свойство неубывания поддерживается, выходим из цикла.
                else break;
            }
        }

        /// <summary>
        /// Извлекает из пирамиды минимальный элемент (удаляет его из пирамиды и возвращает в качестве результата работы метода).
        /// </summary>
        public (TKey key, TValue value) PopMin ()
        {
            return PopRoot ();
        }

        /// <summary>
        /// Уменьшает значение ключа для элемента, расположенного по индексу <paramref name="itemIndex"/>.
        /// </summary>
        /// <param name="newKey">Новое значение ключа.</param>
        /// <param name="newValue">Новое значение сопутствующей информации.</param>
        /// <remarks>Если новое значение ключа <paramref name="newKey"/> больше или равно текущему, то ничего не будет происходить, 
        /// метод отработает вхолостую.</remarks>
        public void DecreaseKeyAt (TKey newKey, TValue newValue, int itemIndex)
        {
            if (newKey < _keys [itemIndex]) ChangeItemAt (newKey, newValue, itemIndex);
        }

        /// <summary>
        /// Уменьшает значение ключа для элемента, расположенного по индексу <paramref name="itemIndex"/>.
        /// </summary>
        /// <param name="decreasedItem">Кортеж, содержащий новые значения ключа и сопутствующей информации для элемента по индексу <paramref name="itemIndex"/>.</param>
        /// <remarks>Если новое значение ключа <paramref name="decreasedItem.key"/> больше или равно текущему, то ничего не будет 
        /// происходить, метод отработает вхолостую.</remarks>
        public void DecreaseKeyAt ((TKey key, TValue value) decreasedItem, int itemIndex)
        {
            DecreaseKeyAt (decreasedItem.key, decreasedItem.value, itemIndex);
        }

        /// <summary>
        /// Размещает элемент с ключом <paramref name="itemKey"/>, расположенный перед вызовом метода по индексу <paramref name="itemIndex"/>, 
        /// на корректную позицию в пирамиде, чтобы сохранялось свойство неубывания.
        /// </summary>
        protected override void PutItem (TKey itemKey, int itemIndex)
        {
            // Пока элемент не окажется на корректной позиции или не будет достигнут корень пирамиды.
            while (itemIndex > 0)
            {
                int parentIndex = HeapAlgorithm.GetParentIndex (itemIndex);

                // Если нарушается порядок (текущий элемент меньше родительского элемента), меняем их местами (поднимаем текущий
                // элемент наверх к корню пирамиды).
                if (itemKey < _keys [parentIndex])
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