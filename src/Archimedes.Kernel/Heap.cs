using System.Numerics;

namespace Archimedes
{
    public abstract class Heap<T> where T : INumber<T>
    {
        protected List<T> _a;

        private int _heapSize;
        private int _firstLeaf;

        protected int HeapSize
        {
            get => _heapSize;
        }

        protected int FirstLeaf
        {
            get => _firstLeaf;
        }

        protected Heap ()
        {
            _a = new List<T> ();

            _heapSize  = 0;
            _firstLeaf = -1;
        }

        protected Heap (T onlyItem) : this ()
        {
            _a.Add (onlyItem);

            _heapSize  = 1;
            _firstLeaf = 0;
        }

        protected Heap (params T [] array) : this ()
        {
            BuildHeap (array);

            _heapSize  = _a.Count;
            _firstLeaf = GetFirstLeaf ();
        }

        protected Heap (List<T> list) : this ()
        {
            BuildHeap (list);

            _heapSize  = _a.Count;
            _firstLeaf = GetFirstLeaf ();
        }

        protected abstract void Heapify (int subtreeRoot);

        protected abstract void BuildHeap (params T [] array);

        protected abstract void BuildHeap (List<T> list);

        protected T GetRoot ()
        {
            return _a [0];
        }

        protected T PopRoot ()
        {
            throw new NotImplementedException ();
            //firstleaf
        }

        protected abstract void ChangeItem (int index, T newValue);

        protected abstract void InsertItem (T insertedValue);

        public int GetFirstLeaf ()
        {
            return HeapAlgorithm.GetFirstLeafIndex (HeapSize);
        }

        public int GetLeftChild (int index)
        {
            return HeapAlgorithm.GetLeftChildIndex (index);
        }

        public int GetRightChild (int index)
        {
            return HeapAlgorithm.GetRightChildIndex (index);
        }

        public int Parent (int index)
        {
            return HeapAlgorithm.GetParentIndex (index);
        }

        public int HowManyChildren (int index)
        {
            return HeapAlgorithm.HowManyChildren (index, HeapSize, FirstLeaf);
        }
    }
}