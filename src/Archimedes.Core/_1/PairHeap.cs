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
        public abstract void Insert (TKEY key, TDATA data);
    }
}