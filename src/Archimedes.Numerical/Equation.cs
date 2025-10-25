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
        /// <param name="xCurrent">Начальное значение решения.</param>
        /// <param name="param">Числовые параметры уравнения.</param>
        public static double Newton (EquationDelegate equation, EquationDelegate derivative, double halfEpsilon,
            double xCurrent, params double [] param)
        {
            double xPrevious;

            do
            {
                xPrevious = xCurrent;
                xCurrent  = xPrevious - equation (xPrevious, param) / derivative (xPrevious, param);

            } while (double.Abs (xCurrent - xPrevious) >= halfEpsilon);

            return xCurrent;
        }
    }
}