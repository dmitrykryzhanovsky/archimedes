using System.Numerics;

namespace Archimedes
{
    /// <summary>
    /// Неубывающая бинарная пирамида пар (значение, сопутствующие данные).
    /// </summary>
    public class MinPairHeap<TKEY, TDATA> : PairHeap<TKEY, TDATA> where TKEY : INumber<TKEY>
    {
        public MinPairHeap () : base ()
        {
        }

        public MinPairHeap (List<TKEY> keyList, List<TDATA> dataList) : base (keyList, dataList)
        {
        }

        protected override void BuildHeapMethod ()
        {
            HeapAlgorithm.BuildMinHeap (_list, _dataList);
        }

        protected override void HeapifyMethod (int subtreeRootIndex)
        {
            HeapAlgorithm.MinHeapify (_list, _dataList, subtreeRootIndex, FirstLeafIndex, LastLeafIndex);
        }

        protected override bool IsOrderInvalid (TKEY children, TKEY parent)
        {
            return children < parent;
        }
    }
}