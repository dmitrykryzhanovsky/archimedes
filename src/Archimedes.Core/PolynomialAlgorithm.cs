namespace Archimedes
{
    public static class PolynomialAlgorithm
    {
        public static double Compute (double x, params double [] a)
        {
            return Horner (x, a);
        }

        public static double Horner (double x, params double [] a)
        {
            return HornerNoConstantTerm (x, a) + a [0];
        }

        public static double ComputeSquare (double x, params double [] a)
        {
            return ComputeSquareNoConstantTerm (x, a) + a [0];
        }

        public static double ComputeCube (double x, params double [] a)
        {
            return ComputeCubeNoConstantTerm (x, a) + a [0];
        }

        public static double ComputeNoConstantTerm (double x, params double [] a)
        {
            return HornerNoConstantTerm (x, a);
        }

        public static double HornerNoConstantTerm (double x, params double [] a)
        {
            double sum = 0.0;

            for (int i = a.Length - 1; i >= 1; i--)
            {
                sum = (sum + a [i]) * x;
            }

            return sum;
        }

        public static double ComputeSquareNoConstantTerm (double x, params double [] a)
        {
            return (a [2] * x + a [1]) * x;
        }

        public static double ComputeCubeNoConstantTerm (double x, params double [] a)
        {
            return ((a [3] * x + a [2]) * x + a [1]) * x;
        }
    }
}