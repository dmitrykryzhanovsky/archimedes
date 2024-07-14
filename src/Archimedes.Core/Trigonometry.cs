namespace Archimedes
{
    public static class Trigonometry
    {
        public static bool AreEqualAngles (double angle1, double angle2)
        {
            return (double.Ieee754Remainder (angle1 - angle2, double.Tau) == 0.0);
        }
        
        public static double NormalizeAngle (double x)
        {
            return double.Ieee754Remainder (x, double.Tau);
        }
    }
}