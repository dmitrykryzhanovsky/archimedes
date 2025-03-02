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
    }
}