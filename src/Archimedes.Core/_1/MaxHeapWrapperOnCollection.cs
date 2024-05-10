using System.Numerics;

namespace Archimedes
{
    internal class MaxHeapWrapperOnCollection<T> : HeapWrapperOnCollection<T> where T : INumber<T>
    {
        internal MaxHeapWrapperOnCollection (int length) : base (length)
        {
        }

        protected override int ExcessSiblingIndex (int leftChildIndex, T [] collection)
        {
            return collection.MaxIndex (leftChildIndex, leftChildIndex + 1);
        }

        protected override int ExcessSiblingIndex (int leftChildIndex, List<T> collection)
        {
            return collection.MaxIndex (leftChildIndex, leftChildIndex + 1);
        }

        internal override bool IsOrderInvalid (T child, T parent)
        {
            return (child > parent);
        }
    }
}