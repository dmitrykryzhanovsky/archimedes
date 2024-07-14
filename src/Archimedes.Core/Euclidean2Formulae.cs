namespace Archimedes
{
    public static class Euclidean2Formulae
    {
        /// <summary>
        /// Вычисляет координаты (x2; y2), которые будут у вектора (<paramref name="x1"/>; <paramref name="y1"/>) после его поворота на 
        /// угол, заданный синусом <paramref name="sin"/> и косинусом <paramref name="cos"/>.
        /// </summary>
        /// <remarks>Это базовый метод, используемый для расчётов поворотов на плоскости. В нём не производится проверка на соответствие 
        /// синуса <paramref name="sin"/> и косинуса <paramref name="cos"/> основному тригонометрическому тождеству.</remarks>
        public static (double x2, double y2) RotateVector (double sin, double cos, double x1, double y1)
        {
            return (x2: x1 * cos - y1 * sin,
                    y2: x1 * sin + y1 * cos);
        }
    }
}