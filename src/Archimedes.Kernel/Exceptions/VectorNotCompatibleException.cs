using System;

namespace Archimedes
{
    /// <summary>
    /// Исключение «Векторы несовместимы для данной операции».
    /// </summary>
    /// <remarks>Генерируется, когда:
    /// <list type="bullet">
    /// <item>совершается попытка сложения / вычитания векторов разного размера</item>
    /// <item>совершается попытка скалярного умножения векторов разного размера</item>
    /// </list></remarks>
    public class VectorNotCompatibleException : ArithmeticException
    {
    }
}