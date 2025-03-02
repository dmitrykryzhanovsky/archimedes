using System.Numerics;

namespace Archimedes
{
    public static class FloatExtension
    {
        public static T Fraction<T> (this T x) where T : IFloatingPoint<T>
        {
            return x - T.Floor (x);
        }
    }
}