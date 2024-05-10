using System.Numerics;

namespace Archimedes
{
    /// <summary>
    /// Невозрастающая бинарная пирамида.
    /// </summary>
    public class MaxHeap<T> : Heap<T> where T : INumber<T>
    {
        public MaxHeap () : base ()
        {
        }

        public MaxHeap (List<T> list) : base (list)
        {
            HeapAlgorithm.BuildMaxHeap (_list);
        }

        public MaxHeap (params T [] values) : base (values)
        {
            HeapAlgorithm.BuildMaxHeap (_list);
        }

        public override void Insert (T value)
        {
            HeapAlgorithm.InsertInMaxHeap (_list, value);
        }

        public override void Delete (int deletedIndex)
        {
            HeapAlgorithm.DeleteFromMaxHeap (_list, deletedIndex, FirstLeafIndex, LastLeafIndex);
        }
    }
}