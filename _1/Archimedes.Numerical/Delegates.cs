namespace Archimedes.Numerical
{
    /// <summary>
    /// Делегат для нелинейного уравнения.
    /// </summary>
    /// <param name="x">Значение переменной уравнения.</param>
    /// <param name="param">Числовые параметры уравнения.</param>
    public delegate double NonLinearEquationDelegate (double x, params double [] param);

    /// <summary>
    /// Делегат для дифференциального уравнения.
    /// </summary>
    /// <param name="x">Аргумент функции, которую нужно найти.</param>
    /// <param name="y">Значение функции, которую нужно найти.</param>
    /// <param name="param">Числовые параметры функции, которую нужно найти.</param>
    public delegate double DiffEquationDelegate (double x, double y, double [] param);
}