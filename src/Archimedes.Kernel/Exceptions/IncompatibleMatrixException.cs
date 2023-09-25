using System;

namespace Archimedes
{
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