namespace Archimedes
{
    public static class Trigonometry
    {
        public static double PhaseInDeg (double deg)
        {
            return double.Ieee754Remainder (deg, MathConst.DegInOrbit);
        }

        public static double PhaseInHour (double hour)
        {
            return double.Ieee754Remainder (hour, MathConst.HourInOrbit);
        }

        public static double PhaseInRad (double rad)
        {
            return double.Ieee754Remainder (rad, double.Tau);
        }

        public static double PhaseInOrbit (double orbit)
        {
            return orbit.Fraction ();
        }
    }
}