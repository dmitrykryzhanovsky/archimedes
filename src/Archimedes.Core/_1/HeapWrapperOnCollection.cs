using System.Numerics;

namespace Archimedes
{
    internal abstract class HeapWrapperOnCollection<T> where T : INumber<T>
    {
        private int _length;

        private int _firstLeafIndex;

        protected int _lastLeafIndex;

        protected HeapWrapperOnCollection (int length)
        {
            _length         = length;
            _firstLeafIndex = HeapAlgorithm.GetFirstLeafIndex (_length);
            _lastLeafIndex  = _length - 1;
        }

        internal void IncreaseLength ()
        {
            _length++;
            _firstLeafIndex = HeapAlgorithm.GetFirstLeafIndex (_length);
            _lastLeafIndex++;
        }

        internal void DecreaseLength ()
        {
            _length--;
            _firstLeafIndex = HeapAlgorithm.GetFirstLeafIndex (_length);
            _lastLeafIndex--;
        }

        internal bool IsItemNotLeaf (int index)
        {
            return index < _firstLeafIndex;
        }

        protected bool IsNotLastLeaf (int index)
        {
            return index < _lastLeafIndex;
        }

        internal int ExcessChildIndex (int parentIndex, T [] collection)
        {
            int leftChildIndex = HeapAlgorithm.GetLeftChildIndex (parentIndex);

            return (IsNotLastLeaf (leftChildIndex)) ? ExcessSiblingIndex (leftChildIndex, collection) : leftChildIndex;
        }

        internal int ExcessChildIndex (int parentIndex, List<T> collection)
        {
            int leftChildIndex = HeapAlgorithm.GetLeftChildIndex (parentIndex);

            return (IsNotLastLeaf (leftChildIndex)) ? ExcessSiblingIndex (leftChildIndex, collection) : leftChildIndex;
        }

        protected abstract int ExcessSiblingIndex (int leftChildIndex, T [] collection);

        protected abstract int ExcessSiblingIndex (int leftChildIndex, List<T> collection);

        internal abstract bool IsOrderInvalid (T child, T parent);
    }
}