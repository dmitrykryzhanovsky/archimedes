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
        }

        public MaxHeap (params T [] values) : base (values)
        {
        }

        protected override void BuildHeapMethod ()
        {
            HeapAlgorithm.BuildMaxHeap (_list);
        }

        protected override bool IsOrderInvalid (T children, T parent)
        {
            return children > parent;
        }
    }
}