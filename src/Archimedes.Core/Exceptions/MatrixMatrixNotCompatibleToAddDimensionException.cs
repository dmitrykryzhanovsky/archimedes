namespace Archimedes
{
    /// <summary>
    /// Генерируется, если размеры матриц не подходят для сложения / вычитания.
    /// </summary>
    public class MatrixMatrixNotCompatibleToAddDimensionException : NotCompatibleDimensionException
    {
        public MatrixMatrixNotCompatibleToAddDimensionException () : base ()
        {
        }
    }
}