namespace Archimedes
{
    public static class Space3
    {
        /// <summary>
        /// Вычисляет декартовы координаты для полярных координат (r; latitude; longitude).
        /// </summary>
        /// <param name="r">Полярное расстояние (от начала координат).</param>
        /// <param name="latitude">Широта, в радианах.</param>
        /// <param name="longitude">Долгота, в радианах.</param>
        public static (double x, double y, double z) GetCartesianCoordinates (double r, double latitude, double longitude)
        {
            (double sinL, double cosL) = double.SinCos (longitude);
            (double sinB, double cosB) = double.SinCos (latitude);
            
            double oxy = r * cosB;

            return (oxy * cosL, oxy * sinL, r * sinB);
        }

        /// <summary>
        /// Вычисляет полярные координаты для декартовых координат (x; y; z).
        /// </summary>
        public static (double r, double latitude, double longitude) GetPolarCoordinates (double x, double y, double z)
        {
            double r         = double.Sqrt (x * x + y * y + z * z);
            double latitude  = double.Atan2 (z, double.Hypot (x, y));
            double longitude = double.Atan2 (y, x);

            return (r, latitude, longitude);
        }

        /// <summary>
        /// Проверяет, что значение широты latitude, переданное в метод, лежит на интервале [-π/2; + π/2].
        /// </summary>
        public static void CheckLatitude (double latitude)
        {
            ArgumentOutOfRangeCheckers.CheckInterval (latitude, -MathConst.M_PI_2, MathConst.M_PI_2);
        }
    }
}