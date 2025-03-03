namespace Archimedes
{
    public static class Trigonometry
    {
        /// <summary>
        /// Возвращает фазу угла, выраженного в градусах, на полуинтервале [0°; 360°).
        /// </summary>
        public static double PhaseInDeg (double deg)
        {
            return deg.Phase (MathConst.DegInOrbit);
        }

        /// <summary>
        /// Возвращает фазу угла, выраженного в часах, на полуинтервале [0h; 24h).
        /// </summary>
        public static double PhaseInHour (double hour)
        {
            return hour.Phase (MathConst.HourInOrbit);
        }

        /// <summary>
        /// Возвращает фазу угла, выраженного в радианах, на полуинтервале [0; 2π).
        /// </summary>
        public static double PhaseInRad (double rad)
        {
            return rad.Phase (double.Tau);
        }

        /// <summary>
        /// Возвращает фазу угла, выраженного в долях оборота, на полуинтервале [0; 1).
        /// </summary>
        public static double PhaseInOrbit (double orbit)
        {
            return orbit.Fraction ();
        }

        /// <summary>
        /// Приводит угол, выраженный в градусах, в диапазон (-180°; +180°].
        /// </summary>
        public static double NormalizeMinusPlusInDeg (double deg)
        {
            return NormalizeMinusPlus (deg, MathConst.DegInOrbit, MathConst.DegInHalfTurn);
        }

        /// <summary>
        /// Приводит угол, выраженный в часах, в диапазон (-12h; +12h].
        /// </summary>
        public static double NormalizeMinusPlusInHour (double hour)
        {
            return NormalizeMinusPlus (hour, MathConst.HourInOrbit, MathConst.HourInHalfTurn);
        }

        /// <summary>
        /// Приводит угол, выраженный в радианах, в диапазон (-π; +π].
        /// </summary>
        public static double NormalizeMinusPlusInRad (double rad)
        {
            return NormalizeMinusPlus (rad, double.Tau, double.Pi);
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

        /// <summary>
        /// Приводит угол, выраженный в долях оборота, в диапазон (-0.5; +0.5].
        /// </summary>
        public static double NormalizeMinusPlusInOrbit (double orbit)
        {
            double normalized = orbit.Fraction ();

            if (normalized > 0.5)
            {
                normalized--;
            }

            return normalized;
        }

        /// <summary>
        /// Приводит угол, выраженный в градусах, в диапазон [0°; 360°).
        /// </summary>
        public static double NormalizePositiveInDeg (double deg)
        {
            return PhaseInDeg (deg);
        }

        /// <summary>
        /// Приводит угол, выраженный в часах, в диапазон [0h; 24h).
        /// </summary>
        public static double NormalizePositiveInHour (double hour)
        {
            return PhaseInHour (hour);
        }

        /// <summary>
        /// Приводит угол, выраженный в радианах, в диапазон [0; 2π).
        /// </summary>
        public static double NormalizePositiveInRad (double rad)
        {
            return PhaseInRad (rad);
        }

        /// <summary>
        /// Приводит угол, выраженный в долях оборота, в диапазон [0; 1).
        /// </summary>
        public static double NormalizePositiveInOrbit (double rad)
        {
            return PhaseInOrbit (rad);
        }
    }
}