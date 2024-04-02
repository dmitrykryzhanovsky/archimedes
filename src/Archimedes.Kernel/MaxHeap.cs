using System.Numerics;

namespace Archimedes
{
    /// <summary>
    /// Невозрастающая бинарная пирамида.
    /// </summary>
    /// <remarks>Максимальный элемент находится в корне.</remarks>
    public class MaxHeap<T> : Heap<T> where T : INumber<T>
    {
        #region Constructors

        public MaxHeap () : base ()
        {
        }

        public MaxHeap (T onlyItem) : base (onlyItem)
        {
        }

        public MaxHeap (params T [] array ) : base (array)
        {
        }

        public MaxHeap (List<T> list) : base (list)
        {
        }

        #endregion

        public T GetMaximum ()
        {
            return GetRoot ();
        }

        public T PopMaximum ()
        {
            return PopRoot ();
        }

        public void IncreaseItem (int index, T newValue)
        {
            ChangeItem (index, newValue);
        }

        protected override void ChangeItem (int index, T newValue)
        {
            throw new NotImplementedException ();
        }

        public void MaxHeapInsert (T insertedValue)
        {
            InsertItem (insertedValue);
        }

        protected override void InsertItem (T insertedValue)
        {
            throw new NotImplementedException ();
            // firstleaf
        }
    }
}