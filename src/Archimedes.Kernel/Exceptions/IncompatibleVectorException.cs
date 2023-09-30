using System;

namespace Archimedes
{
    /// <summary>
    /// Вектора несовместимы для данной алгебраической операции.
    /// </summary>
    /// <remarks>Генерируется, когда два вектора имеют размеры, несовместимые для сложения / вычитания / скалярного умножения.</remarks>
    public class IncompatibleVectorException : ArithmeticException
    {
        private const string MessageText = "The dimensions of the vectors are incompatible for addition / subtraction / multiplication.";

        public IncompatibleVectorException (Vector v1, Vector v2) : base (MessageText)
        {
        }
    }
}