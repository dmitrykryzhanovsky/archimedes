namespace Archimedes
{
    public static class Function
    {
        public static double Series_02 (double x, double y, params double [] a)
        {
            return y * (y * a [5] + (x * a [4] + a [3])) + x * (x * a [2] + a [1]) + a [0];
        }

        public static double Series_13 (double x, double y, params double [] a)
        {
            return y * (y * (y * a [5] + (x * a [4] + a [3])) + (x * (x * a [2] + a [1]) + a [0]));
        }
    }
}