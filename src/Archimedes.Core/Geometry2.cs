namespace Archimedes
{
    public static class Geometry2
    {
        public static class Ellipse
        {
            /// <summary>
            /// Возвращает периметр эллипса.
            /// </summary>
            /// <param name="a">Большая полуось a.</param>
            /// <param name="sqrt1me2">Вспомогательная величина sqrt(1 - e^2), где e – эксцентриситет эллипса.</param>
            /// <remarks>Вычисляет приближённое значение периметра Эллипса по второй формуле Рамануджана: 
            /// https://ru.wikipedia.org/wiki/Эллипс#Длина_дуги_эллипса</remarks>
            public static double Length (double a, double sqrt1me2)
            {
                double q = (1.0 - sqrt1me2) / (1.0 + sqrt1me2);
                double s = 3.0 * q * q;

                return double.Pi * a * (1.0 + sqrt1me2) * (1.0 + s / (10.0 + double.Sqrt (4.0 - s)));
            }
        }
    }
}