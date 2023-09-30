using System;

namespace Archimedes
{
    /// <summary>
    /// Матрицы несовместимы для данной алгебраической операции.
    /// </summary>
    /// <remarks>Генерируется, когда две матрицы (или матрица и вектор) имеют размеры, несовместимые для данной алгебраической операции.</remarks>
    public class IncompatibleMatrixException : ArithmeticException
    {
        public IncompatibleMatrixException (Vector v1, Matrix m2, string? message) : base (message)
        {
        }

        public IncompatibleMatrixException (Matrix m1, Vector v2, string? message) : base (message)
        {
        }

        public IncompatibleMatrixException (Matrix m1, Matrix m2, string? message) : base (message)
        {
        }
    }
}