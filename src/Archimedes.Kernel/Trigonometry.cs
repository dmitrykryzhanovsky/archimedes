namespace Archimedes
{
    public static class Trigonometry
    {
        public static bool AreEqualAngles (double x, double y)
        {
            return (double.Ieee754Remainder (x - y, double.Tau) == 0.0);
        }

        public static double NormalizeAngle (double x)
        {
            return double.Ieee754Remainder (x, double.Tau);
        }
    }
}