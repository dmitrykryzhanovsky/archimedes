namespace Archimedes
{
    /// <summary>
    /// Интерфейс для типов, поддерживающих скалярное произведение.
    /// </summary>
    public interface IDotProductable<T>
    {
        double DotProduct (T other);
    }
}