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
            HeapAlgorithm.BuildMinHeap (_list, _dataList);
        }

        public override void Insert (TKEY key, TDATA data)
        {
            HeapAlgorithm.InsertInMinHeap (_list, _dataList, key, data);
        }

        public override void Delete (int deletedIndex)
        {
            HeapAlgorithm.DeleteFromMinHeap (_list, _dataList, deletedIndex, FirstLeafIndex, LastLeafIndex);
        }
    }
}