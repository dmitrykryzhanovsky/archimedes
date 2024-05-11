using System.Numerics;

namespace Archimedes
{
    /// <summary>
    /// Невозрастающая пирамида.
    /// </summary>
    public abstract class MaxHeap<TKey, TValue> : Heap<TKey, TValue> where TKey : INumber<TKey>
    {
        #region Constructors

        protected MaxHeap (int _d) : base (_d)
        {
        }

        protected MaxHeap (int _d, List<TKey> keys, List<TValue> values) : base (_d, keys, values)
        {
        }

        protected MaxHeap (int _d, params (TKey key, TValue value) [] items) : base (_d, items)
        {
        }

        #endregion

        /// <summary>
        /// Извлекает из пирамиды максимальный элемент (удаляет его из пирамиды и возвращает в качестве результата работы метода).
        /// </summary>
        public (TKey key, TValue value) PopMax ()
        {
            return PopRoot ();
        }

        /// <summary>
        /// Увеличивает значение ключа для элемента, расположенного по индексу <paramref name="itemIndex"/>.
        /// </summary>
        /// <param name="newKey">Новое значение ключа.</param>
        /// <param name="newValue">Новое значение сопутствующей информации.</param>
        /// <remarks>Если новое значение ключа <paramref name="newKey"/> меньше или равно текущему, то ничего не будет происходить, 
        /// метод отработает вхолостую.</remarks>
        public void IncreaseKeyAt (TKey newKey, TValue newValue, int itemIndex)
        {
            if (newKey > _keys [itemIndex]) ChangeItemAt (newKey, newValue, itemIndex);
        }

        /// <summary>
        /// Увеличивает значение ключа для элемента, расположенного по индексу <paramref name="itemIndex"/>.
        /// </summary>
        /// <param name="increasedItem">Кортеж, содержащий новые значения ключа и сопутствующей информации для элемента по индексу <paramref name="itemIndex"/>.</param>
        /// <remarks>Если новое значение ключа <paramref name="increasedItem.key"/> меньше или равно текущему, то ничего не будет 
        /// происходить, метод отработает вхолостую.</remarks>
        public void IncreaseKeyAt ((TKey key, TValue value) increasedItem, int itemIndex)
        {
            IncreaseKeyAt (increasedItem.key, increasedItem.value, itemIndex);
        }
    }
}