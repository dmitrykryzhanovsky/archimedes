namespace Archimedes
{
    /// <summary>
    /// Генерируется, если размеры вектора и матрицы не подходят для умножения вектора на матрицу.
    /// </summary>
    public class VectorMatrixNotCompatibleToMultiplyDimensionException : NotCompatibleDimensionException
    {
        public VectorMatrixNotCompatibleToMultiplyDimensionException () : base ()
        {
        }
    }
}