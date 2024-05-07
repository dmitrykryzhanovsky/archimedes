using System.Numerics;

namespace Archimedes
{
    /// <summary>
    /// Бинарная пирамида пар (значение, сопутствующие данные).
    /// </summary>
    public abstract class PairHeap<TKEY, TDATA> : Heap<TKEY> where TKEY : INumber<TKEY>
    {
        protected readonly List<TDATA> _dataList;

        public new (TKEY, TDATA) this [int index]
        {
            get => (_list [index], _dataList [index]);
        }

        protected PairHeap () : base ()
        {
            _dataList = new List<TDATA> ();
        }

        protected PairHeap (List<TKEY> keyList, List<TDATA> dataList) : this ()
        {
            keyList.CopyTo (_list);
            dataList.CopyTo (_dataList);

            BuildHeapMethod ();
        }

        /// <summary>
        /// Так как для пирамиды пар (значение, сопутствующие данные) метод <see cref="Insert"/> с одним параметром, без указания 
        /// сопутствующих данных, нарушит целостность данных, в данном классе его перегрузка генерирует исключение 
        /// <see cref="InvalidOperationException"/>.
        /// </summary>
        public override void Insert (TKEY value)
        {
            throw new InvalidOperationException ();
        }

        /// <summary>
        /// Добавляет значение <paramref name="key"/> и сопутствующие данные <paramref name="data"/> в пирамиду, вставляя их на 
        /// корректную позицию для сохранения свойства невозрастания / неубывания (в зависимости от типа пирамиды).
        /// </summary>
        public void Insert (TKEY key, TDATA data)
        {
            _list.Add (key);
            _dataList.Add (data);

            int valueIndex = LastLeafIndex;
            
            PutValueProperly (key, valueIndex);
        }

        public override void Delete (int deletedIndex)
        {
            TKEY deletedKey  = _list [deletedIndex];
            TKEY lastLeafKey = _list [LastLeafIndex];

            _list [deletedIndex] = lastLeafKey;

            if (deletedKey > lastLeafKey) HeapifyMethod (deletedIndex);
            else PutValueProperly (lastLeafKey, deletedIndex);

            _list.RemoveAt (LastLeafIndex);
            _dataList.RemoveAt (LastLeafIndex);
        }

        protected override void PutValueProperly (TKEY value, int valueIndex)
        {
            while (valueIndex > 0)
            {
                int parentIndex = HeapAlgorithm.GetParentIndex (valueIndex);

                if (IsOrderInvalid (value, _list [parentIndex]))
                {
                    _list.Swap (valueIndex, parentIndex);
                    _dataList.Swap (valueIndex, parentIndex);
                    valueIndex = parentIndex;
                }

                else valueIndex = 0;
            }
        }
    }
}