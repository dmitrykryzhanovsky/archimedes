using System.Numerics;

namespace Archimedes
{
    /// <summary>
    /// Невозрастающая очередь с приоритетами.
    /// </summary>
    /// <remarks>Реализована как бинарная пирамида, поддерживающая свойство невозрастания.</remarks>
    public class PriorityQueueDescending<TPriority, TItem> where TPriority : INumber<TPriority>
    {
        private readonly List<NonUniqueKeyValuePair<TPriority, TItem>> _heap;

        #region Constructors

        public PriorityQueueDescending ()
        {
            _heap = new List<NonUniqueKeyValuePair<TPriority, TItem>> ();
        }

        #endregion

        /// <summary>
        /// Возвращает головной элемент очереди (имеющий максимальный приоритет).
        /// </summary>
        public NonUniqueKeyValuePair<TPriority, TItem> GetMaximumPriority ()
        {
            return _heap [0];
        }

        /// <summary>
        /// Извлекает из очереди головной элемент (имеющий максимальный приоритет) и возвращает его.
        /// </summary>
        public NonUniqueKeyValuePair<TPriority, TItem> DequeueMaximumPriority ()
        {
            // А здесь точно не нужно перепроверить?
            NonUniqueKeyValuePair<TPriority, TItem> maximum = GetMaximumPriority ();

            _heap.RemoveAt (0);            

            return maximum;
        }

        /// <summary>
        /// Повышает приоритет элемента с индексом <paramref name="index"/> до значения <paramref name="newPriority"/>.
        /// </summary>
        /// <remarks><para>Если новый приоритет <paramref name="newPriority"/> элемента с индексом <paramref name="index"/> меньше 
        /// предыдущего, генерируется исключение.</para>
        /// <para>Если новый приоритет <paramref name="newPriority"/> нарушает свойство невозрастания, то элемент с индексом 
        /// <paramref name="index"/> перемещается к корню пирамиды, пока свойство невозрастания не будет восстановлено.</para></remarks>
        /// <exception cref="ArgumentException">Генерируется, если новый приоритет <paramref name="newPriority"/> элемента с индексом 
        /// <paramref name="index"/> меньше предыдущего.</exception>
        public void IncreasePriority (int index, TPriority newPriority)
        {
            if (newPriority < _heap [index].Key) throw new ArgumentException ();

            // Пока нарушается свойство невозрастания и не достигнут корень пирамиды.
            while (index > 0)
            {
                int parent = HeapAlgorithm.GetParentIndex (index);

                // Проверяем, нарушается ли свойство невозрастания. Если да, то меняем текущий элемент с его родительским и
                // поднимаемся на 1 уровень вверх.
                if (newPriority > _heap [parent].Key)
                {
                    _heap [index] = _heap [parent];

                    index = parent;
                }

                // Если свойство невозрастания не нарушается, выходим из цикла.
                else break;
            }

            _heap [index].Key = newPriority;
        }

        /// <summary>
        /// Добавляет в очередь новый элемент <paramref name="newItem"/> с приоритетом <paramref name="newItemPriority"/> и ставит его 
        /// на корректное место, чтобы сохранялось свойство невозрастания.
        /// </summary>
        public void Add (TPriority newItemPriority, TItem newItem)
        {
            // Переписать
            //_heap.Add (new NonUniqueKeyValuePair<TPriority, TItem> (newItemPriority, newItem));

            //int index = _heap.Count - 1;

            //// Пока нарушается свойство невозрастания и не достигнут корень пирамиды.
            //while (index > 0)
            //{
            //    int parent = HeapAlgorithm.GetParent (index);

            //    // Проверяем, нарушается ли свойство невозрастания. Если да, то меняем текущий элемент с его родительским и
            //    // поднимаемся на 1 уровень вверх.
            //    if (_heap [index].Key > _heap [parent].Key)
            //    {
            //        _heap.Swap (index, parent);

            //        index = parent;
            //    }

            //    // Если свойство невозрастания не нарушается, выходим из цикла.
            //    else index = 0;
            //}
        }
    }
}