using System;

namespace Archimedes
{
    /// <summary>
    /// Исключение «Матрицы несовместимы для данной операции».
    /// </summary>
    /// <remarks>Генерируется, когда:
    /// <list type="bullet">
    /// <item>совершается попытка сложения / вычитания матриц разного размера</item>
    /// <item>совершается попытка умножения матриц (или матрицы и вектора), размеры которых несовместимы для умножения</item>
    /// </list></remarks>
    public class MatrixNotCompatibleException : ArithmeticException
    {
    }
}