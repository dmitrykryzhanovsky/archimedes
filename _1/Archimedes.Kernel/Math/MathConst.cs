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
        public const double M_PI_2 = double.Pi / 2.0;

        /// <summary>
        /// 4 * PI^2.
        /// </summary>
        public const double M_4_PI_SQR = 4.0 * double.Pi * double.Pi;

        /// <summary>
        /// Коэффициент для преобразования градусов в радианы.
        /// </summary>
        public const double DegToRad = double.Pi / 180.0;

        /// <summary>
        /// Коэффициент для преобразования секунд в радианы.
        /// </summary>
        public const double SecToRad = double.Pi / (180.0 * 60.0 * 60.0);
    }
}