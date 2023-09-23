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
    }
}