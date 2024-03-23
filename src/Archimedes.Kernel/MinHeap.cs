using System.Numerics;

namespace Archimedes
{
    public class MinHeap<T> : Heap<T> where T : INumber<T>
    {
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

        public void MinHeapify (int subtreeRoot)
        {
            Heapify (subtreeRoot);
        }

        protected override void Heapify (int subtreeRoot)
        {
            throw new NotImplementedException ();
        }

        public void BuildMinHeap (params T [] array)
        {
            BuildHeap (array);
        }

        protected override void BuildHeap (params T [] array)
        {
            throw new NotImplementedException ();
        }

        public void BuildMinHeap (List<T> list)
        {
            BuildHeap (list);
        }

        protected override void BuildHeap (List<T> list)
        {
            throw new NotImplementedException ();
        }

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
        }
    }
}