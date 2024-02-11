namespace Archimedes
{
    /// <summary>
    /// Геометрия в трёхмерном евклидовом пространстве.
    /// </summary>
    public static class Space3
    {
        /// <summary>
        /// Поворот системы координат на угол <paramref name="phi"/> вокруг оси OX.
        /// </summary>
        /// <param name="v">Вектор в старой системе координат (до поворота).</param>
        /// <returns>Координаты вектора <paramref name="v"/> в новой системе координат (после поворота).</returns>
        public static Vector3 RotateCoordinateSystemAroundOX (Vector3 v, double phi)
        {
            return Vector3.RotateAroundOX (v, -phi);
        }

        /// <summary>
        /// Поворот системы координат вокруг оси OX на угол, заданный своими синусом <paramref name="sin"/> и косинусом 
        /// <paramref name="cos"/>.
        /// </summary>
        /// <param name="v">Вектор в старой системе координат (до поворота).</param>
        /// <returns>Координаты вектора <paramref name="v"/> в новой системе координат (после поворота).</returns>
        public static Vector3 RotateCoordinateSystemAroundOX (Vector3 v, double sin, double cos)
        {
            return Vector3.RotateAroundOX (v, -sin, cos);
        }

        public static Polar3 RotateCoordinateSystemAroundOX (Polar3 p, double phi)
        {
            return Polar3.RotateAroundOX (p, -phi);
        }

        public static Polar3 RotateCoordinateSystemAroundOX (Polar3 p, double sin, double cos)
        {
            return Polar3.RotateAroundOX (p, -sin, cos);
        }
    }
}