using System;

namespace Archimedes
{
    /// <summary>
    /// Математические константы.
    /// </summary>
    public static class MathConst
    {
        /// <summary>
        /// PI / 2.
        /// </summary>
        public const double M_PI_2 = Double.Pi / 2.0;

        /// <summary>
        /// Коэффициент для преобразования градусов в радианы.
        /// </summary>
        public const double DegToRad = Double.Pi / 180.0;

        /// <summary>
        /// Коэффициент для преобразования секунд в радианы.
        /// </summary>
        public const double SecToRad = Double.Pi / (180.0 * 60.0 * 60.0);
    }
}