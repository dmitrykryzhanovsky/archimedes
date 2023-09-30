namespace Archimedes
{
    public static class VectorAlgorithm
    {
        /// <summary>
        /// Возвращает true, если вектора по своим размерам подходят для алгебраических операций (сложения, вычитания, скалярного 
        /// произведения). В противном случае false.
        /// </summary>
        /// <remarks>Метод проверяет, равна ли размерность вектора v1 размерности вектора v2.</remarks>
        public static bool AreSuitableForAlgebra (Vector v1, Vector v2)
        {
            return (v1.Dimension == v2.Dimension);
        }
    }
}