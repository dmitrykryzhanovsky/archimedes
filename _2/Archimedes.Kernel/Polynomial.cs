namespace Archimedes
{
    public static class Polynomial
    {
        /// <summary>
        /// Вычисление значение полинома, заданного массивом вещественных коэффициентов <paramref name="a"/> в точке <paramref name="x"/>.
        /// </summary>
        /// <param name="a">Элемент массива a [i] соответствует коэффициенту при x^i.</param>
        /// <remarks>Вычисление происходит по схеме Горнера θ (n).</remarks>
        public static double Compute (double [] a, double x)
        {
            double y = a [a.Length - 1];

            for (int i = a.Length - 2; i >= 0; i--)
            {
                y = double.FusedMultiplyAdd (x, y, a [i]);
            }

            return y;
        }
    }
}