using System.Numerics;

namespace Archimedes
{
    /// <summary>
    /// Неубывающая бинарная пирамида.
    /// </summary>
    public class MinHeap<T> : Heap<T> where T : INumber<T>
    {
        public MinHeap () : base ()
        {
        }

        public MinHeap (List<T> list) : base (list)
        {
        }

        public MinHeap (params T [] values) : base (values)
        {
        }

        protected override void BuildHeapMethod ()
        {
            HeapAlgorithm.BuildMinHeap (_list);
        }

        protected override void HeapifyMethod (int subtreeRootIndex)
        {
            HeapAlgorithm.MinHeapify (_list, subtreeRootIndex, FirstLeafIndex, LastLeafIndex);
        }

        protected override bool IsOrderInvalid (T children, T parent)
        {
            return children < parent;
        }
    }
}