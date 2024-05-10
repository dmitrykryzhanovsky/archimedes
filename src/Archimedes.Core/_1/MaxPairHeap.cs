using System.Numerics;

namespace Archimedes
{
    /// <summary>
    /// Неубывающая бинарная пирамида пар (значение, сопутствующие данные).
    /// </summary>
    public class MaxPairHeap<TKEY, TDATA> : PairHeap<TKEY, TDATA> where TKEY : INumber<TKEY>
    {
        public MaxPairHeap () : base ()
        {
        }

        public MaxPairHeap (List<TKEY> keyList, List<TDATA> dataList) : base (keyList, dataList)
        {
            HeapAlgorithm.BuildMaxHeap (_list, _dataList);
        }

        public override void Insert (TKEY key, TDATA data)
        {
            HeapAlgorithm.InsertInMaxHeap (_list, _dataList, key, data);
        }

        public override void Delete (int deletedIndex)
        {
            HeapAlgorithm.DeleteFromMaxHeap (_list, _dataList, deletedIndex, FirstLeafIndex, LastLeafIndex);
        }
    }
}