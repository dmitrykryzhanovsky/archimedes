namespace Archimedes
{
    public static class Function
    {
        /// <summary>
        /// (a[0] + a [1] * x + a [2] * x^2) + (a [3] + a [4] * x) * y + a [5] * y^2
        /// </summary>
        public static double Series_02 (double x, double y, params double [] a)
        {
            return y * (y * a [5] + (x * a [4] + a [3])) + x * (x * a [2] + a [1]) + a [0];
        }

        /// <summary>
        /// (a[0] + a [1] * x + a [2] * x^2) * y + (a [3] + a [4] * x) * y^2 + a [5] * y^3
        /// </summary>
        public static double Series_13 (double x, double y, params double [] a)
        {
            return y * (y * (y * a [5] + (x * a [4] + a [3])) + (x * (x * a [2] + a [1]) + a [0]));
        }
    }
}