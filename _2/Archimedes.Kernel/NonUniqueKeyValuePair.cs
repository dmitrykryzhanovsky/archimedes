namespace Archimedes
{
    /// <summary>
    /// Тип для работы с парами (ключ; значение). Принципиальное отличие от стандартного типа 
    /// <see cref="System.Collections.Generic.KeyValuePair"/> в том, что поля <typeparamref name="TKey"/> и 
    /// <typeparamref name="TValue"/> данного типа изменяемы.
    /// </summary>
    public class NonUniqueKeyValuePair<TKey, TValue> : ICloneable, IEquatable<NonUniqueKeyValuePair<TKey, TValue>>
    {
        public TKey Key { get; set; }

        public TValue Value { get; set; }

        public NonUniqueKeyValuePair (TKey key, TValue value)
        {
            Key   = key;
            Value = value;
        }

        public NonUniqueKeyValuePair (NonUniqueKeyValuePair<TKey, TValue> other) : this (other.Key, other.Value)
        {
        }

        public object Clone ()
        {
            return new NonUniqueKeyValuePair<TKey, TValue> (this);
        }

        public bool Equals (NonUniqueKeyValuePair<TKey, TValue> other)
        {
            return ((Key.Equals (other.Key)) && (Value.Equals (other.Value)));
        }
    }
}