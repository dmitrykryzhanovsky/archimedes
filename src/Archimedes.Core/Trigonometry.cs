namespace Archimedes
{
    public static class Trigonometry
    {
        public static double PhaseInDeg (double deg)
        {
            return deg.Phase (MathConst.DegInOrbit);
        }

        public static double PhaseInHour (double hour)
        {
            return hour.Phase (MathConst.HourInOrbit);
        }

        public static double PhaseInRad (double rad)
        {
            return rad.Phase (double.Tau);
        }

        public static double PhaseInOrbit (double orbit)
        {
            return orbit.Fraction ();
        }
    }
}