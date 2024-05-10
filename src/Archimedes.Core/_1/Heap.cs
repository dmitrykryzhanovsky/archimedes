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
        }

        protected Heap (params T [] values) : this ()
        {
            values.CopyTo (_list);
        }

        /// <summary>
        /// Добавляет элемент <paramref name="value"/> в пирамиду, вставляя его на корректную позицию для сохранения свойства 
        /// невозрастания / неубывания (в зависимости от типа пирамиды).
        /// </summary>
        public abstract void Insert (T value);

        /// <summary>
        /// Удаляет из пирамиды элемент, расположенный по индексу <paramref name="deletedIndex"/>.
        /// </summary>
        public abstract void Delete (int deletedIndex);
    }
}