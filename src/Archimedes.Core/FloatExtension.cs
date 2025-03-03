using System.Numerics;

namespace Archimedes
{
    public static class FloatExtension
    {
        /// <summary>
        /// Возвращает дробную часть вещественного числа.
        /// </summary>
        public static T Fraction<T> (this T x) where T : IFloatingPoint<T>
        {
            return x - T.Floor (x);
        }

        /// <summary>
        /// Возвращает остаток от деления dividend на divisor, определённый на положительном полуинтервале [0; divisor) (как для 
        /// положительных целых чисел).
        /// </summary>
        /// <remarks>Для ситуаций, когда остаток от деления должен находиться строго на полуинтервале [0; divisor) операция % и метод 
        /// IEEERemainder не подходят, так как операция % для отрицательных dividend возвращает отрицательное значение, а метод 
        /// IEEERemainder возвращает значение на отрезке [-divisor/2; +divisor/2] с неочевидным правилом выбора между граничными 
        /// значениями.
        /// Подробнее см. https://learn.microsoft.com/en-us/dotnet/api/system.math.ieeeremainder?view=net-9.0&redirectedfrom=MSDN#System_Math_IEEERemainder_System_Double_System_Double_ 
        /// и https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/expressions#12104-remainder-operator.</remarks>
        public static T Phase<T> (this T dividend, T divisor) where T : IFloatingPoint<T>
        {
            T remainder = dividend % divisor;

            if (remainder < T.Zero)
            {
                remainder += divisor;
            }

            return remainder;
        }
    }
}