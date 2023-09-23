namespace Archimedes
{
    public static class MatrixAlgorithm
    {
        /// <summary>
        /// Возвращает true, если матрицы по своим размерам подходят для сложения / вычитания. В противном случае false.
        /// </summary>
        /// <remarks>Метод проверяет, равна ли высота матрицы m1 высоте матрицы m2 и равна ли ширина матрицы m1 ширине матрицы m2.</remarks>
        public static bool AreSuitableForAddition (Matrix m1, Matrix m2)
        {
            return (m1.Height == m2.Height) && (m1.Width == m2.Width);
        }

        /// <summary>
        /// Возвращает true, если матрицы по своим размерам подходят для умножения. В противном случае false.
        /// </summary>
        /// <remarks>Метод проверяет, равна ли ширина матрицы m1 высоте матрицы m2.</remarks>
        public static bool AreSuitableForMultiplication (Matrix m1, Matrix m2)
        {
            return (m1.Width == m2.Height);
        }

        /// <summary>
        /// Стандартный алгоритм умножения матриц O (n^3). Перемножает матрицы A и B и сохраняет результат в матрицу C.
        /// </summary>
        /// <param name="height">Высота матрицы-произведения C (и матрицы A).</param>
        /// <param name="innerSize">Совпадающий размер матриц-множителей: ширина матрицы A = высота матрицы B.</param>
        /// <param name="width">Ширина матрицы-произведения C (и матрицы B).</param>
        /// <remarks>Массивы, соответствующие матрицам (A, B, C), должны быть уже созданы перед вызовом метода и иметь корректные 
        /// размеры: A {height x innerSize}, B {innerSize x width}, C {height x width}.</remarks>
        public static void StandardMultiplication (double [] C, double [] A, double [] B, int height, int innerSize, int width)
        {
            int cIterator = 0;
            int aRow      = 0;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int aIterator = aRow;
                    int bIterator = j;

                    double item = 0.0;

                    for (int k = 0; k < innerSize; k++)
                    {
                        item      += A [aIterator++] * B [bIterator];
                        bIterator += width;
                    }

                    C [cIterator++] = item;
                }

                aRow += innerSize;
            }
        }
    }
}