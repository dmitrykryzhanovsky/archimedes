using System.Numerics;

namespace Archimedes
{
    public class MaxHeap<T> : Heap<T> where T : INumber<T>
    {
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

        public void MaxHeapify (int subtreeRoot)
        {
            Heapify (subtreeRoot);
        }

        protected override void Heapify (int subtreeRoot)
        {
            HeapAlgorithm.MaxHeapify (_a, subtreeRoot, FirstLeaf, HeapSize - 1);
        }

        public void BuildMaxHeap (params T [] array)
        {
            BuildHeap (array);
        }

        protected override void BuildHeap (params T [] array)
        {
            HeapAlgorithm.BuildMaxHeap (array);
        }

        public void BuildMaxHeap (List<T> list)
        {
            BuildHeap (list);
        }

        protected override void BuildHeap (List<T> list)
        {
            HeapAlgorithm.BuildMaxHeap (list);
        }

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