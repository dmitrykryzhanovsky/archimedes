namespace Archimedes.Numerical
{
    public static class Equation
    {
        public static double Newton (RealFunction f, RealFunction fd, double [] a, double epsilon, double x0)
        {
            double x1, dx;

            do
            {
                x1 = x0 - f (x0, a) / fd (x0, a);
                dx = x1 - x0;
                x0 = x1;

            } while (double.Abs (dx) >= epsilon);

            return x1;
        }
    }
}