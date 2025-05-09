namespace Archimedes
{
    /// <summary>
    /// Генерируется, если размеры матрицы и вектора не подходят для умножения матрицы на вектор.
    /// </summary>
    public class MatrixVectorNotCompatibleToMultiplyDimensionException : NotCompatibleDimensionException
    {
        public MatrixVectorNotCompatibleToMultiplyDimensionException () : base ()
        {
        }
    }
}