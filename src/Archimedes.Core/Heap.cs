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
        /// Виртуальный метод, выполняющий построение пирамиды (невозрастающей или неубывающей).
        /// </summary>
        protected abstract void BuildHeapMethod ();

        /// <summary>
        /// Добавляет элемент <paramref name="value"/> в пирамиду, вставляя его на корректную позицию для сохранения свойства 
        /// невозрастания / неубывания (в зависимости от типа пирамиды).
        /// </summary>
        public void Insert (T value)
        {
            _list.Add (value);

            int valueIndex = _list.Count - 1;
            
            while (valueIndex > 0)
            {
                int parentIndex = HeapAlgorithm.GetParentIndex (valueIndex);

                if (IsOrderInvalid (_list [valueIndex], _list [parentIndex]))
                {
                    _list.Swap (valueIndex, parentIndex);
                    valueIndex = parentIndex;
                }

                else valueIndex = 0;
            }
        }

        /// <summary>
        /// Возвращает TRUE, если элементы <paramref name="children"/> и <paramref name="parent"/> нарушают порядок невозрастания / 
        /// неубывания (в зависимости от типа пирамиды). В противном случае FALSE.
        /// </summary>
        protected abstract bool IsOrderInvalid (T children, T parent);
    }
}