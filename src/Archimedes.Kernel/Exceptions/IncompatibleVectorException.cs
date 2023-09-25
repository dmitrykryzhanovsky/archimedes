using System;

namespace Archimedes
{
    public class IncompatibleVectorException : ArithmeticException
    {
        private const string MessageText = "The dimensions of the vectors are incompatible for addition / subtraction / multiplication.";

        public IncompatibleVectorException (Vector v1, Vector v2) : base (MessageText)
        {
        }
    }
}