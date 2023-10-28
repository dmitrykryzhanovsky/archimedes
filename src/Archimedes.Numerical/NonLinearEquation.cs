namespace Archimedes.Numerical
{
    /// <summary>
    /// Численные методы решения нелинейных уравнений.
    /// </summary>
    public static class NonLinearEquation
    {
        /// <summary>
        /// Метод Ньютона (касательных).
        /// </summary>
        /// <param name="equation">Уравнение, которое нужно решить, в виде f (x) = 0.</param>
        /// <param name="derivative">Производная уравнения, которое нужно решить, в виде f' (x) = 0.</param>
        /// <param name="epsilon">Полуточность решения.</param>
        /// <param name="xcurrent">Начальное значение решения.</param>
        /// <param name="param">Числовые параметры уравнения.</param>
        /// <returns>Решение уравнения equation с точность 2 * epsilon.</returns>
        public static double Newton (NonLinearEquationDelegate equation, NonLinearEquationDelegate derivative, double epsilon, 
            double xcurrent, params double [] param)
        {
            double xprevious;

            do
            {
                xprevious = xcurrent;
                xcurrent  = xprevious - equation (xprevious, param) / derivative (xprevious, param);

            } while (Double.Abs (xcurrent - xprevious) >= epsilon);

            return xcurrent;
        }
    }
}