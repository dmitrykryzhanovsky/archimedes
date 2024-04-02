using System.Numerics;

namespace Archimedes
{
    /// <summary>
    /// Бинарная пирамида.
    /// </summary>
    public abstract class Heap<T> where T : INumber<T>
    {
        protected List<T> _a;

        private int _heapSize;
        private int _firstLeafIndex;

        public List<T> Items
        {
            get => _a;
        }

        public int HeapSize
        {
            get => _heapSize;
        }

        public int FirstLeafIndex
        {
            get => _firstLeafIndex;
        }

        #region Constructors

        protected Heap ()
        {
            _a = new List<T> ();

            _heapSize       =  0;
            _firstLeafIndex = -1;
        }

        protected Heap (T onlyItem)
        {
            _a = new List<T> { onlyItem };

            _heapSize       = 1;
            _firstLeafIndex = 0;
        }

        protected Heap (params T [] array)
        {
            BuildHeap (array);

            _a = new List<T> (array);

            _heapSize       = _a.Count;
            _firstLeafIndex = GetFirstLeafIndex ();
        }

        protected Heap (List<T> list)
        {
            BuildHeap (list);

            _a = new List<T> (list);

            _heapSize       = _a.Count;
            _firstLeafIndex = GetFirstLeafIndex ();
        }

        #endregion

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

        public int GetFirstLeafIndex ()
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
            return HeapAlgorithm.HowManyChildren (index, HeapSize, FirstLeafIndex);
        }
    }
}