namespace Archimedes
{
    public static class MatrixAlgorithms
    {
        /// <summary>
        /// Умножение матрицы m1 на вектор v2.
        /// </summary> 
        /// <param name="result">Одномерный массив, в который записывается вектор – результат умножения.</param>
        /// <param name="height1">Высота матрицы m1.</param>
        /// <param name="width1Length2">Ширина матрицы m1 = длина вектора v2.</param> 
        /// <remarks>Проверка на совместимость размеров матрицы и вектора внутри метода не производится.
        /// <list type="bullet">
        /// <item>Длина массива v2 должна быть равна количеству столбцов (1-е измерение) в массиве m1.</item>
        /// <item>Длина массива result должна быть равна количеству строк (0-е измерение) в массиве m1.</item>
        /// </list></remarks>
        public static void MatrixVectorMultiplication (double [,] m1, double [] v2, double [] result, int height1, int width1Length2)
        {
            double sum;

            for (int i = 0; i < height1; i++)
            {                
                sum = 0.0;

                for (int k = 0; k < width1Length2; k++)
                {
                    sum += m1 [i, k] * v2 [k];
                }

                result [i] = sum;
            }
        }

        /// <summary>
        /// Умножение вектора v1 на матрицу m2.
        /// </summary> 
        /// <param name="result">Одномерный массив, в который записывается вектор – результат умножения.</param>
        /// <param name="length1Height2">Длина вектора v1 = высота матрицы m2.</param>
        /// <param name="width2">Ширина матрицы m2.</param>
        /// <remarks>Проверка на совместимость размеров вектора и матрицы внутри метода не производится.
        /// <list type="bullet">
        /// <item>Длина массива v1 должна быть равна количеству строк (0-е измерение) в массиве m2.</item>
        /// <item>Длина массива result должна быть равна количеству столбцов (1-е измерение) в массиве m2.</item>
        /// </list></remarks>
        public static void VectorMatrixMultiplication (double [] v1, double [,] m2, double [] result, int length1Height2, int width2)
        {
            double sum;
            
            for (int j = 0; j < width2; j++)
            {
                sum = 0.0;

                for (int k = 0; k < length1Height2; k++)
                {
                    sum += v1 [k] * m2 [k, j];
                }

                result [j] = sum;
            }
        }

        /// <summary>
        /// Умножение матрицы m1 на матрицу m2.
        /// </summary>
        /// <param name="result">Двумерный массив, в который записывается матрица – результат умножения.</param>
        /// <param name="height1">Высота матрицы m1.</param>
        /// <param name="width1Height2">Ширина матрицы m1 = высота матрицы m2.</param>
        /// <param name="width2">Ширина матрицы m2.</param>
        /// <remarks>Проверка на совместимость размеров матриц внутри метода не производится.
        /// <list type="bullet">
        /// <item>Количество столбцов в массиве m1 (1-е измерение) должно быть равно количеству строк в массиве m2 (0-е измерение).</item>
        /// <item>Количество строк в массиве result (0-е измерение) должно быть равно количеству строк в массиве m1 (0-е измерение), а 
        /// количество столбцов в массиве result (1-е измерение) должно быть равно количеству столбцов в массиве m2 (1-е измерение).</item>
        /// </list></remarks>
        public static void CommonMultiplication (double [,] m1, double [,] m2, double [,] result, int height1, int width1Height2, 
            int width2)
        {
            double sum;

            for (int i = 0; i < height1; i++)
            {
                for (int j = 0; j < width2; j++)
                {
                    sum = 0.0;

                    for (int k = 0; k < width1Height2; k++)
                    {
                        sum += m1 [i, k] * m2 [k, j];
                    }

                    result [i, j] = sum;
                }
            }
        }
    }
}