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

        private static double NormalizeMinusPlus (double x, double unitsInOrbit, double unitsInHalfTurn)
        {
            double normalized = x.Phase (unitsInOrbit);

            if (normalized > unitsInHalfTurn)
            {
                normalized -= unitsInOrbit;
            }

            return normalized;
        }

        public static double NormalizeMinusPlusInDeg (double deg)
        {
            return NormalizeMinusPlus (deg, MathConst.DegInOrbit, MathConst.DegInHalfTurn);
        }

        public static double NormalizeMinusPlusInHour (double hour)
        {
            return NormalizeMinusPlus (hour, MathConst.HourInOrbit, MathConst.HourInHalfTurn);
        }

        public static double NormalizeMinusPlusInRad (double rad)
        {
            return NormalizeMinusPlus (rad, double.Tau, double.Pi);
        }

        public static double NormalizedMinusPlusInOrbit (double orbit)
        {
            double normalized = orbit.Fraction ();

            if (normalized > 0.5)
            {
                normalized--;
            }

            return normalized;
        }

        public static double NormalizePositiveInDeg (double deg)
        {
            return PhaseInDeg (deg);
        }
    }
}