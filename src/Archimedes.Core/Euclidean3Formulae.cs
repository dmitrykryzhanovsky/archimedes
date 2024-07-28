namespace Archimedes
{
    public static class Euclidean3Formulae
    {
        /// <summary>
        /// Вычисляет координаты (x2; y2; z2), которые будут у вектора (<paramref name="x1"/>; <paramref name="y1"/>; <paramref name="z1"/>) 
        /// после его поворота вокруг оси OX на угол, заданный синусом <paramref name="sin"/> и косинусом <paramref name="cos"/>.
        /// </summary>
        /// <remarks>Это базовый метод, используемый для расчётов поворотов вокруг оси OX. В нём не производится проверка на соответствие 
        /// синуса <paramref name="sin"/> и косинуса <paramref name="cos"/> основному тригонометрическому тождеству.</remarks>
        public static (double x2, double y2, double z2) RotateVectorAroundOX (double sin, double cos, double x1, double y1, double z1)
        {
            return (x2: x1,
                    y2: y1 * cos - z1 * sin,
                    z2: y1 * sin + z1 * cos);
        }

        /// <summary>
        /// Вычисляет координаты (x2; y2; z2), которые будут у вектора (<paramref name="x1"/>; <paramref name="y1"/>; <paramref name="z1"/>) 
        /// после его поворота вокруг оси OY на угол, заданный синусом <paramref name="sin"/> и косинусом <paramref name="cos"/>.
        /// </summary>
        /// <remarks>Это базовый метод, используемый для расчётов поворотов вокруг оси OY. В нём не производится проверка на соответствие 
        /// синуса <paramref name="sin"/> и косинуса <paramref name="cos"/> основному тригонометрическому тождеству.</remarks>
        public static (double x2, double y2, double z2) RotateVectorAroundOY (double sin, double cos, double x1, double y1, double z1)
        {
            return (x2: x1 * cos - z1 * sin,
                    y2: y1,
                    z2: x1 * sin + z1 * cos);
        }

        /// <summary>
        /// Вычисляет координаты (x2; y2; z2), которые будут у вектора (<paramref name="x1"/>; <paramref name="y1"/>; <paramref name="z1"/>) 
        /// после его поворота вокруг оси OZ на угол, заданный синусом <paramref name="sin"/> и косинусом <paramref name="cos"/>.
        /// </summary>
        /// <remarks>Это базовый метод, используемый для расчётов поворотов вокруг оси OZ. В нём не производится проверка на соответствие 
        /// синуса <paramref name="sin"/> и косинуса <paramref name="cos"/> основному тригонометрическому тождеству.</remarks>
        public static (double x2, double y2, double z2) RotateVectorAroundOZ (double sin, double cos, double x1, double y1, double z1)
        {
            return (x2: x1 * cos - y1 * sin,
                    y2: x1 * sin + y1 * cos,
                    z2: z1);
        }
    }
}