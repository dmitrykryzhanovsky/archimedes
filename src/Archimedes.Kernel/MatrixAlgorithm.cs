namespace Archimedes
{
    public static class MatrixAlgorithm
    {
        public static Matrix ConventionalMultiplication (Matrix m1, Matrix m2)
        {
            Matrix result     = new Matrix (m1.Height, m2.Width);
            int    commonSize = m1.Width;

            for (int i = 0; i < m1.Height; i++)
            {
                for (int j = 0; j < m2.Width; j++)
                {
                    double c = 0.0;

                    for (int k = 0; k < commonSize; k++)
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