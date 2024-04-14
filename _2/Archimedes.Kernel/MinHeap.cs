using System.Numerics;

namespace Archimedes
{
    /// <summary>
    /// Неубывающая бинарная пирамида.
    /// </summary>
    /// <remarks>Минимальный элемент находится в корне.</remarks>
    public class MinHeap<T> : Heap<T> where T : INumber<T>
    {
        #region Constructors

        public MinHeap () : base ()
        {
        }

        public MinHeap (T onlyItem) : base (onlyItem)
        {
        }

        public MinHeap (params T [] array) : base (array)
        {
        }

        public MinHeap (List<T> list) : base (list)
        {
        }

        #endregion

        public T GetMinimum ()
        {
            return GetRoot ();
        }

        public T PopMinimum ()
        {
            return PopRoot ();
        }

        public void DecreaseItem (int index, T newValue)
        {
            ChangeItem (index, newValue);
        }

        protected override void ChangeItem (int index, T newValue)
        {
            throw new NotImplementedException ();
        }

        public void MinHeapInsert (T insertedValue)
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