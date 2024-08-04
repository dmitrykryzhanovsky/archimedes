namespace Archimedes
{
    public static class MatrixAlgorithms
    {
        /// <summary>
        /// Стандартный алгоритм умножения матриц, работающий за время Θ (n^3).
        /// </summary>
        /// <remarks>Проверка на то, подходят ли матрицы для умножения по размерам или нет, в методе не производится. Если матрицы не 
        /// подходят по размерам для умножения, метод может отработать некорректно (возможна генерация исключения).</remarks>
        public static Matrix O3Multiplication (Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix (m1.Height, m2.Width);

            for (int i = 0; i < m1.Height; i++)
            {
                for (int j = 0; j < m2.Width; j++)
                {
                    double c = 0.0;

                    for (int k = 0; k < m1.Width; k++)
                    {
                        c += m1 [i, k] * m2 [k, j];
                    }

                    result [i, j] = c;
                }
            }

            return result;
        }
    }
}