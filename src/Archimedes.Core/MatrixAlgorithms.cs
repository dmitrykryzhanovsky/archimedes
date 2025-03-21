namespace Archimedes
{
    public static class MatrixAlgorithms
    {
        public static double [,] StandardMultiplication (double [,] a, double [,] b, int height, int commonSize, int width)
        {
            double [,] c = new double [height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    double sum = 0.0;

                    for (int k = 0; k < commonSize; k++)
                    {
                        sum += a [i, k] * b [k, j];
                    }

                    c [i, j] = sum;
                }
            }

            return c;
        }
    }
}