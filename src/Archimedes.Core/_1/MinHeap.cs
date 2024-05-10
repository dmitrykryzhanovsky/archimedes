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
            HeapAlgorithm.BuildMinHeap (_list);
        }

        public MinHeap (params T [] values) : base (values)
        {
            HeapAlgorithm.BuildMinHeap (_list);
        }

        public override void Insert (T value)
        {
            HeapAlgorithm.InsertInMinHeap (_list, value);
        }

        public override void Delete (int deletedIndex)
        {
            HeapAlgorithm.DeleteFromMinHeap (_list, deletedIndex, FirstLeafIndex, LastLeafIndex);
        }
    }
}