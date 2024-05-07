using System.Numerics;

namespace Archimedes
{
    /// <summary>
    /// Бинарная пирамида.
    /// </summary>
    public abstract class Heap<T> where T : INumber<T> 
    {
        protected readonly List<T> _list;

        public T this [int index]
        {
            get => _list [index];
        }

        /// <summary>
        /// Возвращает индекс первого листа для пирамиды.
        /// </summary>
        protected int FirstLeafIndex
        {
            get => HeapAlgorithm.GetFirstLeafIndex (_list.Count);
        }

        /// <summary>
        /// Возвращает индекс последнего листа для пирамиды.
        /// </summary>
        protected int LastLeafIndex
        { 
            get => _list.Count - 1;
        }

        protected Heap ()
        {
            _list = new List<T> ();
        }

        protected Heap (List<T> list) : this ()
        {
            list.CopyTo (_list);

            BuildHeapMethod ();
        }

        protected Heap (params T [] values) : this ()
        {
            values.CopyTo (_list);

            BuildHeapMethod ();
        }        

        /// <summary>
        /// Добавляет элемент <paramref name="value"/> в пирамиду, вставляя его на корректную позицию для сохранения свойства 
        /// невозрастания / неубывания (в зависимости от типа пирамиды).
        /// </summary>
        public virtual void Insert (T value)
        {
            _list.Add (value);

            int valueIndex = LastLeafIndex;
            
            PutValueProperly (value, valueIndex);
        }

        /// <summary>
        /// Удаляет из пирамиды элемент, расположенный по индексу <paramref name="deletedIndex"/>.
        /// </summary>
        public virtual void Delete (int deletedIndex)
        {
            T deletedValue  = _list [deletedIndex];
            T lastLeafValue = _list [LastLeafIndex];

            _list [deletedIndex] = lastLeafValue;

            if (deletedValue > lastLeafValue) HeapifyMethod (deletedIndex);
            else PutValueProperly (lastLeafValue, deletedIndex);

            _list.RemoveAt (LastLeafIndex);
        }

        /// <summary>
        /// Размещает элемент <paramref name="value"/>, расположенный при вызове методы по индексу <paramref name="valueIndex"/>, 
        /// таким образом, чтобы сохранялось свойство невозрастания / неубывания (в зависимости от типа пирамиды).
        /// </summary>
        protected virtual void PutValueProperly (T value, int valueIndex)
        {
            while (valueIndex > 0)
            {
                int parentIndex = HeapAlgorithm.GetParentIndex (valueIndex);

                if (IsOrderInvalid (value, _list [parentIndex]))
                {
                    _list.Swap (valueIndex, parentIndex);
                    valueIndex = parentIndex;
                }

                else valueIndex = 0;
            }
        }

        /// <summary>
        /// Виртуальный метод, выполняющий построение пирамиды (невозрастающей или неубывающей).
        /// </summary>
        protected abstract void BuildHeapMethod ();

        /// <summary>
        /// Виртуальный метод, восстанавливающий свойство невозрастания / неубывания (в зависимости от типа пирамиды) для поддерева с 
        /// корнем в индексе <paramref name="subtreeRootIndex"/>.
        /// </summary>
        protected abstract void HeapifyMethod (int subtreeRootIndex);

        /// <summary>
        /// Возвращает TRUE, если элементы <paramref name="children"/> и <paramref name="parent"/> нарушают порядок невозрастания / 
        /// неубывания (в зависимости от типа пирамиды). В противном случае FALSE.
        /// </summary>
        protected abstract bool IsOrderInvalid (T children, T parent);
    }
}