namespace Archimedes
{
    public static class FloatExtension
    {
        /// <summary>
        /// Возвращает целую (integer) и дробную (fraction) части вещественного числа x.
        /// </summary>
        public static (int integer, double fraction) IntFractionComponents(this double x)
        {
            double floor = Double.Floor(x);

            return ((int)floor, x - floor);
        }

        /// <summary>
        /// Возвращает дробную часть вещественного числа x.
        /// </summary>
        public static double Fraction(this double x)
        {
            return x - Double.Floor(x);
        }
    }
}