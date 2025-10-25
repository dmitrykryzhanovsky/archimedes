namespace Archimedes.Numerical
{
    /// <summary>
    /// Делегат для уравнения.
    /// </summary>
    /// <param name="x">Значение переменной уравнения.</param>
    /// <param name="param">Числовые параметры уравнения.</param>
    public delegate double EquationDelegate (double x, params double [] param);
}