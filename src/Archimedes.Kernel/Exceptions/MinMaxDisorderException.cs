using System;

namespace Archimedes
{
    /// <summary>
    /// Нарушен порядок минимального и максимального значений из пары значений.
    /// </summary>
    /// <remarks>Генерируется, когда в паре значений минимальный элемент больше максимального.</remarks>
    public class MinMaxDisorderException : ArgumentException
    {
        private const string MessageText = "The parameter {0} must be less or equal to the parameter {1}.";

        public MinMaxDisorderException (string? paramName1, string? paramName2) : 
            base (String.Format (MessageText, paramName1, paramName2))
        {
        }
    }
}
