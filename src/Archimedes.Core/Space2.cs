namespace Archimedes
{
    public static class Space2
    {
        /// <summary>
        /// Вычисляет декартовы координаты для пары полярных координат (r; heading).
        /// </summary>
        /// <param name="r">Полярное расстояние (от начала координат).</param>
        /// <param name="heading">Полярный угол, в радианах.</param>
        public static (double x, double y) GetCartesianCoordinates (double r, double heading)
        {
            (double sin, double cos) = double.SinCos (heading);

            return (r * cos, r * sin);
        }

        /// <summary>
        /// Вычисляет полярные координаты для пары декартовых координат (x; y).
        /// </summary>
        public static (double r, double heading) GetPolarCoordinates (double x, double y)
        {
            double r       = double.Hypot (x, y);
            double heading = double.Atan2 (y, x);

            return (r, heading);
        }
    }
}