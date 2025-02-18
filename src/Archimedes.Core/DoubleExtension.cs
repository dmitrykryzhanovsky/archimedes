using System.Numerics;

namespace Archimedes
{
    public static class DoubleExtension
    {
        /// <summary>
        /// Возвращает дробную часть числа x.
        /// </summary>
        public static T Fraction<T> (this T x) where T : IFloatingPoint<T>
        {
            return x - T.Floor (x);
        }
    }
}