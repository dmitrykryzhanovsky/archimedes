using System.Numerics;

namespace Archimedes
{
    /// <summary>
    /// Неубывающая пирамида.
    /// </summary>
    public abstract class MinHeap<TKey, TValue> : Heap<TKey, TValue> where TKey : INumber<TKey>
    {
        #region Constructors
        
        protected MinHeap (int _d) : base (_d)
        {
        }

        protected MinHeap (int _d, List<TKey> keys, List<TValue> values) : base (_d, keys, values)
        {
        }

        protected MinHeap (int _d, params (TKey key, TValue value) [] items) : base (_d, items)
        {
        }

        #endregion

        /// <summary>
        /// Извлекает из пирамиды минимальный элемент (удаляет его из пирамиды и возвращает в качестве результата работы метода).
        /// </summary>
        public (TKey key, TValue value) PopMin ()
        {
            return PopRoot ();
        }

        /// <summary>
        /// Уменьшает значение ключа для элемента, расположенного по индексу <paramref name="itemIndex"/>.
        /// </summary>
        /// <param name="newKey">Новое значение ключа.</param>
        /// <param name="newValue">Новое значение сопутствующей информации.</param>
        /// <remarks>Если новое значение ключа <paramref name="newKey"/> больше или равно текущему, то ничего не будет происходить, 
        /// метод отработает вхолостую.</remarks>
        public void DecreaseKeyAt (TKey newKey, TValue newValue, int itemIndex)
        {
            if (newKey < _keys [itemIndex]) ChangeItemAt (newKey, newValue, itemIndex);
        }

        /// <summary>
        /// Уменьшает значение ключа для элемента, расположенного по индексу <paramref name="itemIndex"/>.
        /// </summary>
        /// <param name="decreasedItem">Кортеж, содержащий новые значения ключа и сопутствующей информации для элемента по индексу <paramref name="itemIndex"/>.</param>
        /// <remarks>Если новое значение ключа <paramref name="decreasedItem.key"/> больше или равно текущему, то ничего не будет 
        /// происходить, метод отработает вхолостую.</remarks>
        public void DecreaseKeyAt ((TKey key, TValue value) decreasedItem, int itemIndex)
        {
            DecreaseKeyAt (decreasedItem.key, decreasedItem.value, itemIndex);
        }
    }
}