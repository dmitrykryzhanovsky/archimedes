using System;

namespace Archimedes
{
    public class IncompatibleMatrixException : ArithmeticException
    {
        public IncompatibleMatrixException (Matrix m1, Matrix m2, string? message) : base (message)
        {
        }
    }
}