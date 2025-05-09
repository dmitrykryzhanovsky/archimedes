namespace Archimedes
{
    /// <summary>
    /// Генерируется, если размеры матриц не подходят для умножения.
    /// </summary>
    public class MatrixMatrixNotCompatibleToMultiplyDimensionException : NotCompatibleDimensionException
    {
        public MatrixMatrixNotCompatibleToMultiplyDimensionException () : base ()
        {
        }
    }
}