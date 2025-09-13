namespace Archimedes
{
    public static class MatrixAlgorithms
    {
        public static void MatrixVectorMultiplication (double [,] m1, double [] v2, double [] result, int height1, int width1length2)
        {
            double sum;

            for (int i = 0; i < height1; i++)
            {                
                sum = 0.0;

                for (int k = 0; k < width1length2; k++)
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
        /// <param name="length1height2">Длина вектора v1 = высота матрицы m2.</param>
        /// <param name="width2">Ширина матрицы m2.</param>
        /// <remarks><list type="bullet">
        /// <item>Длина массива v1 должна быть равна количеству строк (0-е измерение) в массиве m2.</item>
        /// <item>Длина массива result должна быть равна количеству столбцов (1-е измерение) в массиве m2.</item>
        /// </list></remarks>
        public static void VectorMatrixMultiplication (double [] v1, double [,] m2, double [] result, int length1height2, int width2)
        {
            double sum;
            
            for (int j = 0; j < width2; j++)
            {
                sum = 0.0;

                for (int k = 0; k < length1height2; k++)
                {
                    sum += v1 [k] * m2 [k, j];
                }

                result [j] = sum;
            }
        }

        public static void CommonMultiplication (double [,] m1, double [,] m2, double [,] result, int height1, int width1height2, 
            int width2)
        {
            double sum;

            for (int i = 0; i < height1; i++)
            {
                for (int j = 0; j < width2; j++)
                {
                    sum = 0.0;

                    for (int k = 0; k < width1height2; k++)
                    {
                        sum += m1 [i, k] * m2 [k, j];
                    }

                    result [i, j] = sum;
                }
            }
        }
    }
}