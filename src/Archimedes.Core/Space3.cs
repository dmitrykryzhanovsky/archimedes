namespace Archimedes
{
    public static class Space3
    {
        /// <summary>
        /// Вычисляет координаты вектора <paramref name="v"/> после поворота системы координат вокруг оси OX на угол 
        /// <paramref name="angle"/>.
        /// </summary>
        /// <remarks>Поворот системы координат на угол <paramref name="angle"/> равносилен повороту вектора на противоположный угол 
        /// −<paramref name="angle"/>.</remarks>
        public static Vector3 RotateCoordinateSystemAroundOX (double angle, Vector3 v)
        {
            (double sin, double cos) = double.SinCos (angle);

            return RotateCoordinateSystemAroundOX (sin, cos, v);
        }

        /// <summary>
        /// Вычисляет координаты вектора <paramref name="v"/> после поворота системы координат вокруг оси OX на угол, заданный его 
        /// синусом <paramref name="sin"/> и косинусом <paramref name="cos"/>.
        /// </summary>
        /// <remarks><list type="bullet">
        /// <item>Поворот системы координат на угол, заданный синусом и косинусом (<paramref name="sin"/>; <paramref name="cos"/>), 
        /// равносилен повороту вектора на противоположный угол (−<paramref name="sin"/>; <paramref name="cos"/>).</item>
        /// <item>В методе не производится проверка на соответствие синуса <paramref name="sin"/> и косинуса <paramref name="cos"/> 
        /// основному тригонометрическому тождеству.</item>
        /// </list></remarks>
        public static Vector3 RotateCoordinateSystemAroundOX (double sin, double cos, Vector3 v)
        {
            return v.RotateAroundOX (-sin, cos);
        }

        /// <summary>
        /// Вычисляет координаты вектора <paramref name="v"/> после поворота системы координат вокруг оси OY на угол 
        /// <paramref name="angle"/>.
        /// </summary>
        /// <remarks>Поворот системы координат на угол <paramref name="angle"/> равносилен повороту вектора на противоположный угол 
        /// −<paramref name="angle"/>.</remarks>
        public static Vector3 RotateCoordinateSystemAroundOY (double angle, Vector3 v)
        {
            (double sin, double cos) = double.SinCos (angle);

            return RotateCoordinateSystemAroundOY (sin, cos, v);
        }

        /// <summary>
        /// Вычисляет координаты вектора <paramref name="v"/> после поворота системы координат вокруг оси OY на угол, заданный его 
        /// синусом <paramref name="sin"/> и косинусом <paramref name="cos"/>.
        /// </summary>
        /// <remarks><list type="bullet">
        /// <item>Поворот системы координат на угол, заданный синусом и косинусом (<paramref name="sin"/>; <paramref name="cos"/>), 
        /// равносилен повороту вектора на противоположный угол (−<paramref name="sin"/>; <paramref name="cos"/>).</item>
        /// <item>В методе не производится проверка на соответствие синуса <paramref name="sin"/> и косинуса <paramref name="cos"/> 
        /// основному тригонометрическому тождеству.</item>
        /// </list></remarks>
        public static Vector3 RotateCoordinateSystemAroundOY (double sin, double cos, Vector3 v)
        {
            return v.RotateAroundOY (-sin, cos);
        }

        /// <summary>
        /// Вычисляет координаты вектора <paramref name="v"/> после поворота системы координат вокруг оси OZ на угол 
        /// <paramref name="angle"/>.
        /// </summary>
        /// <remarks>Поворот системы координат на угол <paramref name="angle"/> равносилен повороту вектора на противоположный угол 
        /// −<paramref name="angle"/>.</remarks>
        public static Vector3 RotateCoordinateSystemAroundOZ (double angle, Vector3 v)
        {
            (double sin, double cos) = double.SinCos (angle);

            return RotateCoordinateSystemAroundOZ (sin, cos, v);
        }

        /// <summary>
        /// Вычисляет координаты вектора <paramref name="v"/> после поворота системы координат вокруг оси OZ на угол, заданный его 
        /// синусом <paramref name="sin"/> и косинусом <paramref name="cos"/>.
        /// </summary>
        /// <remarks><list type="bullet">
        /// <item>Поворот системы координат на угол, заданный синусом и косинусом (<paramref name="sin"/>; <paramref name="cos"/>), 
        /// равносилен повороту вектора на противоположный угол (−<paramref name="sin"/>; <paramref name="cos"/>).</item>
        /// <item>В методе не производится проверка на соответствие синуса <paramref name="sin"/> и косинуса <paramref name="cos"/> 
        /// основному тригонометрическому тождеству.</item>
        /// </list></remarks>
        public static Vector3 RotateCoordinateSystemAroundOZ (double sin, double cos, Vector3 v)
        {
            return v.RotateAroundOZ (-sin, cos);
        }
    }
}