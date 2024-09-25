namespace Archimedes
{
    public static class MatrixAlgorithm
    {
        public static void StandardMultiplication (double [,] m1, double [,] m2, ref double [,] output, int height, int width, 
            int jointSize)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0;j < width; j++)
                {
                    double c = 0.0;

                    for (int k = 0; k < jointSize; k++)
                    {
                        c += m1 [i, k] * m2 [k, j];
                    }

                    output [i, j] = c;
                }
            }
        }
    }
}