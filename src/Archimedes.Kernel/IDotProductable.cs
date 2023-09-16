namespace Archimedes
{
    /// <summary>
    /// Интерфейс для типов, поддерживающих операцию скалярного умножения.
    /// </summary>
    public interface IDotProductable<T>
    {
        double DotProduct (T other);
    }
}