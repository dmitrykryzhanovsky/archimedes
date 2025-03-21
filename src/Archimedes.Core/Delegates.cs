namespace Archimedes
{
    /// <summary>
    /// Делегат для вещественных функций одной переменной.
    /// </summary>
    /// <param name="x">Вещественная переменная.</param>
    /// <param name="a">Коэффициенты функции.</param>
    public delegate double RealFunction (double x, params double [] a);
}