namespace Archimedes.Numerical
{
    /// <summary>
    /// Численные методы решения дифференциальных уравнений.
    /// </summary>
    public static class DiffEquation
    {
        /// <summary>
        /// Метод Рунге – Кутта четвёртого порядка.
        /// </summary>
        /// <param name="equation">Решаемое дифференциальное уравнение f: y' = f (x, y).</param>
        /// <param name="param">Числовые параметры функции y = y (x), которую нужно найти.</param>
        /// <param name="x0">Граничные условия: x0 - начальное значение аргумента функции y.</param>
        /// <param name="y0">Граничные условия: y0 = y (x0) - значение функции y в точке x0.</param>
        /// <param name="step">Параметры итерационной процедуры: длина шага по переменной x.</param>
        /// <param name="iterations">Параметры итерационной процедуры: количество итераций.</param>
        /// <returns>Массив значений функции y в точках {x0, x0 + step, x0 + 2 * step ... x0 + iterations * step}. Массив содержит 
        /// iterations + 1 значений.</returns>
        public static double [] RungeKutta (DiffEquationDelegate equation, double [] param, 
            double x0, double y0, double step, int iterations)
        {
            double xn = x0;
            double yn = y0;

            double half  = step / 2.0;
            double sixth = step / 6.0;

            double [] y = new double [iterations + 1];

            y [0] = yn;

            for (int i = 1; i <= iterations; i++)
            {
                yn  = RungeKuttaNextValue (equation, param, xn, yn, step, half, sixth);
                xn += step;

                y [i] = yn;
            }

            return y;
        }

        /// <summary>
        /// Выполняет одну итерацию метода Рунге – Кутта четвёртого порядка.
        /// </summary>
        /// <param name="equation">Решаемое дифференциальное уравнение f: y' = f (x, y).</param>
        /// <param name="param">Числовые параметры функции y = y (x), которую нужно найти.</param>
        /// <param name="xn">Значение аргумента функции xn для данной итерации.</param>
        /// <param name="yn">Значение функции yn для данной итерации: yn = y (xn).</param>
        /// <param name="step">Длина шага по переменной x.</param>
        /// <param name="half">Половина длины шага, step / 2.</param>
        /// <param name="sixth">Одна шестая длины шага, step / 6.</param>
        /// <returns>Значение функции y_n+1 в точке x_n+1: y_n+1 = y (x_n+1), x_n+1 = x_n + step.</returns>
        private static double RungeKuttaNextValue (DiffEquationDelegate equation, double [] param, 
            double xn, double yn, double step, double half, double sixth)
        {
            double k1 = equation (xn, yn, param);
            double k2 = equation (xn + half, yn + half * k1, param);
            double k3 = equation (xn + half, yn + half * k2, param);
            double k4 = equation (xn + step, yn + step * k3, param);

            return yn + sixth * (k1 + 2.0 * k2 + 2.0 * k3 + k4);
        }
    }
}