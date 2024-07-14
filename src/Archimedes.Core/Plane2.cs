namespace Archimedes
{
    public static class Plane2
    {
        /// <summary>
        /// Вычисляет координаты вектора <paramref name="v"/> после поворота системы координат на угол <paramref name="angle"/>.
        /// </summary>
        /// <remarks>Поворот системы координат на угол <paramref name="angle"/> равносилен повороту вектора на противоположный угол 
        /// −<paramref name="angle"/>.</remarks>
        public static Vector2 RotateCoordinateSystem (double angle, Vector2 v)
        {
            (double sin, double cos) = double.SinCos (angle);

            return RotateCoordinateSystem (sin, cos, v);
        }

        /// <summary>
        /// Вычисляет координаты вектора <paramref name="v"/> после поворота системы координат на угол, заданный его синусом 
        /// <paramref name="sin"/> и косинусом <paramref name="cos"/>.
        /// </summary>
        /// <remarks><list type="bullet">
        /// <item>Поворот системы координат на угол, заданный синусом и косинусом (<paramref name="sin"/>; <paramref name="cos"/>), 
        /// равносилен повороту вектора на противоположный угол (−<paramref name="sin"/>; <paramref name="cos"/>).</item>
        /// <item>В методе не производится проверка на соответствие синуса <paramref name="sin"/> и косинуса <paramref name="cos"/> 
        /// основному тригонометрическому тождеству.</item>
        /// </list></remarks>
        public static Vector2 RotateCoordinateSystem (double sin, double cos, Vector2 v)
        {
            return v.Rotate (-sin, cos);
        }
    }
}