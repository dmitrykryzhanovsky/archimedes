namespace Archimedes
{
    /// <summary>
    /// Генерируется, если размеры векторов не подходят для арифметических операций (сложения, вычитания, скалярного произведения).
    /// </summary>
    public class VectorVectorNotCompatibleDimensionException : NotCompatibleDimensionException
    {
        public VectorVectorNotCompatibleDimensionException () : base ()
        {
        }
    }
}