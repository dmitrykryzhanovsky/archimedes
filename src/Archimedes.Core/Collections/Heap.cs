using System.Numerics;

namespace Archimedes
{
    /// <summary>
    /// Бинарная пирамида.
    /// </summary>
    public abstract class Heap<TKey, TValue> where TKey : INumber<TKey>
    {
        protected readonly List<TKey>   _keys;
        protected readonly List<TValue> _values;

        private int _heapSize;
        private int _firstLeafIndex;
        private int _lastLeafIndex;

        public (TKey key, TValue value) this [int index]
        {
            get => (_keys [index], _values [index]);
        }

        #region Constructors

        protected Heap ()
        {
            _keys   = new List<TKey> ();
            _values = new List<TValue> ();
        }

        protected Heap (List<TKey> keys, List<TValue> values) : this ()
        {
            keys.CopyTo (_keys);
            values.CopyTo (_values);

            UpdateHeapSize ();

            BuildHeap ();
        }

        protected Heap (params (TKey key, TValue value) [] items) : this ()
        {
            foreach (var item in items)
            {
                _keys.Add (item.key);
                _values.Add (item.value);
            }

            UpdateHeapSize ();

            BuildHeap ();
        }

        #endregion

        /// <summary>
        /// Актуализирует размер пирамиды и связанные с ним переменные после добавления / удаления элементов.
        /// </summary>
        private void UpdateHeapSize ()
        {
            _heapSize       = _keys.Count;
            _firstLeafIndex = HeapAlgorithm.GetFirstLeafIndex (_heapSize);
            _lastLeafIndex  = _heapSize - 1;
        }

        /// <summary>
        /// Преобразует внутренние списки <see cref="_keys"/> и <see cref="_values"/> в бинарную пирамиду.
        /// </summary>
        private void BuildHeap ()
        {
            for (int i = _firstLeafIndex - 1; i >= 0; i--)
            {
                Heapify (i, _firstLeafIndex, _lastLeafIndex);
            }
        }

        /// <summary>
        /// Поддержание свойства пирамиды для поддерева с корнем в индексе <paramref name="subtreeRootIndex"/>.
        /// </summary>
        /// <param name="firstLeafIndex">Индекс первого листа пирамиды.</param>
        /// <param name="lastLeafIndex">Индекс последнего элемента пирамиды.</param>
        /// <remarks>Этот метод предназначен не для построения пирамиды с корнем в индексе <paramref name="subtreeRootIndex"/>, 
        /// а именно для поддержания свойства невозрастания / неубывания (в зависимости от типа пирамиды) для поддерева с корнем в 
        /// индексе <paramref name="subtreeRootIndex"/>.</remarks>
        protected abstract void Heapify (int subtreeRootIndex, int firstLeafIndex, int lastLeafIndex);

        /// <summary>
        /// Добавляет новый элемент, заданный ключом <paramref name="newKey"/> и значением <paramref name="newValue"/>, в пирамиду.
        /// </summary>
        public void Insert (TKey newKey, TValue newValue)
        {
            _keys.Add (newKey);
            _values.Add (newValue);

            UpdateHeapSize ();

            PutItem (newKey, _lastLeafIndex);
        }

        /// <summary>
        /// Добавляет новый элемент <paramref name="newItem"/> в пирамиду.
        /// </summary>
        public void Insert ((TKey key, TValue value) newItem)
        {
            Insert (newItem.key, newItem.value);
        }

        /// <summary>
        /// Удаляет из пирамиды элемент, расположенный по индексу <paramref name="deletedIndex"/>.
        /// </summary>
        public void Delete (int deletedIndex)
        {
            TKey   deletedKey    = _keys [deletedIndex];

            TKey   lastLeafKey   = _keys [_lastLeafIndex];
            TValue lastLeafValue = _values [_lastLeafIndex];

            _keys [deletedIndex]   = lastLeafKey;
            _values [deletedIndex] = lastLeafValue;

            if (deletedKey > lastLeafKey) Heapify (deletedIndex, _firstLeafIndex, _lastLeafIndex);

            else PutItem (lastLeafKey, deletedIndex);

            _keys.RemoveAt (_lastLeafIndex);
            _values.RemoveAt (_lastLeafIndex);

            UpdateHeapSize ();
        }

        /// <summary>
        /// Размещает элемент с ключом <paramref name="itemKey"/>, расположенный перед вызовом метода по индексу <paramref name="itemIndex"/>, 
        /// на корректную позицию в пирамиде, чтобы сохранялось свойство невозрастания / неубывания (в зависимости от типа пирамиды).
        /// </summary>
        protected abstract void PutItem (TKey itemKey, int itemIndex);
    }
}