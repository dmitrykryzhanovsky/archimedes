namespace Archimedes
{
    public class IncompatibleMatrixMultiplicationException : IncompatibleMatrixException
    {
        private const string MessageText = "The dimensions of the matrices are incompatible for multiplication.";

        public IncompatibleMatrixMultiplicationException (Matrix m1, Matrix m2) : base (m1, m2, MessageText)
        {
        }
    }
}