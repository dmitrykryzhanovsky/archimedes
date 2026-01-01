namespace Archimedes.Numerical
{
    /// <summary>
    /// Численные методы решения уравнений.
    /// </summary>
    public static class Equation
    {
        /// <summary>
        /// Метод Ньютона (касательных).
        /// </summary>
        /// <param name="equation">Уравнение, которое нужно решить, в виде f (x) = 0.</param>
        /// <param name="derivative">Производная уравнения, которое нужно решить, в виде f' (x) = 0.</param>
        /// <param name="halfEpsilon">Полуточность решения.</param>
        /// <param name="x0">Начальное значение решения.</param>
        /// <param name="param">Числовые параметры уравнения.</param>
        public static double Newton (EquationDelegate equation, EquationDelegate derivative, double halfEpsilon,
            double x0, params double [] param)
        {
            double x1, x2 = x0;
            double f1, f2 = equation (x2, param);

            do
            {
                x1 = x2;
                f1 = f2;

                x2  = x1 - f1 / derivative (x1, param);
                f2  = equation (x2, param);

            } while (double.Abs (x2 - x1) >= halfEpsilon);

            return x2;
        }
    }
}