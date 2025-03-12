namespace Archimedes
{
    public static class PolynomialAlgorithms
    {
        /// <summary>
        /// Вычисление полинома a [0] + a [1] * x + a [2] * x^2 + .. + a [n – 1] * x^(n – 1).
        /// </summary>
        public static double Compute (double x, params double [] a)
        {
            return Horner (x, a);
        }

        private static double Horner (double x, params double [] a)
        {
            return HornerNoConstantTerm (x, a) + a [0];
        }

        /// <summary>
        /// Вычисление полинома a [0] + a [1] * x + a [2] * x^2.
        /// </summary>
        public static double ComputeSquare (double x, params double [] a)
        {
            return ComputeSquareNoConstantTerm (x, a) + a [0];
        }

        /// <summary>
        /// Вычисление полинома a [0] + a [1] * x + a [2] * x^2 + a [3] * x^3.
        /// </summary>
        public static double ComputeCube (double x, params double [] a)
        {
            return ComputeCubeNoConstantTerm (x, a) + a [0];
        }

        private static double HornerNoConstantTerm (double x, params double [] a)
        {
            double sum = 0.0;

            for (int i = a.Length - 1; i >= 1; i--)
            {
                sum = (sum + a [i]) * x;
            }

            return sum;
        }

        private static double ComputeSquareNoConstantTerm (double x, params double [] a)
        {
            return (a [2] * x + a [1]) * x;
        }

        private static double ComputeCubeNoConstantTerm (double x, params double [] a)
        {
            return ((a [3] * x + a [2]) * x + a [1]) * x;
        }
    }
}