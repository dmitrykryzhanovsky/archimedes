namespace Archimedes
{
    /// <summary>
    /// Математические константы.
    /// </summary>
    public static class MathConst
    {
        /// <summary>
        /// π/4.
        /// </summary>
        public const double PI_4 = double.Pi / 4.0;

        /// <summary>
        /// π/2.
        /// </summary>
        public const double PI_2 = double.Pi / 2.0;

        /// <summary>
        /// 3/2 π.
        /// </summary>
        public const double _3_PI_2 = 3.0 * double.Pi / 2.0;

        /// <summary>
        /// Коэффициент для преобразования градусов в радианы.
        /// </summary>
        public const double DEG_TO_RAD = double.Pi / 180.0;

        /// <summary>
        /// Коэффициент для преобразования минут в радианы.
        /// </summary>
        public const double MIN_TO_RAD = double.Pi / (180.0 * 60.0);

        /// <summary>
        /// Коэффициент для преобразования секунд в радианы.
        /// </summary>
        public const double SEC_TO_RAD = double.Pi / (180.0 * 60.0 * 60.0);

        /// <summary>
        /// Коэффициент для преобразования часов в радианы.
        /// </summary>
        public const double HOUR_TO_RAD = double.Pi / 12.0;

        /// <summary>
        /// Коэффициент для преобразования часовых минут в радианы.
        /// </summary>
        public const double HMIN_TO_RAD = double.Pi / (12.0 * 60.0);

        /// <summary>
        /// Коэффициент для преобразования часовых секунд в радианы.
        /// </summary>
        public const double HSEC_TO_RAD = double.Pi / (12.0 * 60.0 * 60.0);

        /// <summary>
        /// Коэффициент для преобразования радиан в градусы.
        /// </summary>
        public const double RAD_TO_DEG = 180.0 / double.Pi;

        /// <summary>
        /// Коэффициент для преобразования радиан в минуты.
        /// </summary>
        public const double RAD_TO_MIN = (180.0 * 60.0) / double.Pi;

        /// <summary>
        /// Коэффициент для преобразования радиан в секунды.
        /// </summary>
        public const double RAD_TO_SEC = (180.0 * 60.0 * 60.0) / double.Pi;

        /// <summary>
        /// Коэффициент для преобразования радиан в часы.
        /// </summary>
        public const double RAD_TO_HOUR = 12.0 / double.Pi;

        /// <summary>
        /// Коэффициент для преобразования радиан в часовые минуты.
        /// </summary>
        public const double RAD_TO_HMIN = (12.0 * 60.0) / double.Pi;

        /// <summary>
        /// Коэффициент для преобразования радиан в часовые секунды.
        /// </summary>
        public const double RAD_TO_HSEC = (12.0 * 60.0 * 60.0) / double.Pi;

        /// <summary>
        /// Количество секунд в одном полном обороте на 360°.
        /// </summary>
        public const double SEC_PER_ROTATION = 360.0 * 60.0 * 60.0;
    }
}