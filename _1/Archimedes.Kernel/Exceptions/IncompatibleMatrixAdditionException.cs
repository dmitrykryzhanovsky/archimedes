namespace Archimedes
{
    /// <summary>
    /// Две матрицы несовместимы для сложения / вычитания.
    /// </summary>
    public class IncompatibleMatrixAdditionException : IncompatibleMatrixException
    {
        private const string MessageText = "The dimensions of the matrices are incompatible for addition / subtraction.";

        public IncompatibleMatrixAdditionException (Matrix m1, Matrix m2) : base (m1, m2, MessageText)
        {
        }
    }
}