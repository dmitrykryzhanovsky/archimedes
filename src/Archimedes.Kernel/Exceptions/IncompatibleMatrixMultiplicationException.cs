namespace Archimedes
{
    /// <summary>
    /// Две матрицы (или матрица и вектор) несовместимы для умножения.
    /// </summary>
    public class IncompatibleMatrixMultiplicationException : IncompatibleMatrixException
    {
        private const string MessageText = "The dimensions of the matrices are incompatible for multiplication.";

        public IncompatibleMatrixMultiplicationException (Vector v1, Matrix m2) : base (v1, m2, MessageText)
        {
        }

        public IncompatibleMatrixMultiplicationException (Matrix m1, Vector v2) : base (m1, v2, MessageText)
        {
        }

        public IncompatibleMatrixMultiplicationException (Matrix m1, Matrix m2) : base (m1, m2, MessageText)
        {
        }
    }
}