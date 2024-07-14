namespace Archimedes
{
    public static class Trigonometry
    {
        public static double NormalizeAngle (double x)
        {
            return double.Ieee754Remainder (x, double.Tau);
        }
    }
}