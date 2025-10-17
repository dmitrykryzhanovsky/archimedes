namespace Archimedes
{
    public static class Trigonometry
    {
        /// <summary>
        /// Возвращает TRUE, если фазы углов angle1 и angle2 равны. В противном случае FALSE.
        /// </summary>
        public static bool AreEqualPhaseInRad (double angle1, double angle2)
        {
            return (double.Ieee754Remainder (angle1 - angle2, double.Tau) == 0.0);
        }

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
        public static double NormalizeHalfTurnInDeg (double deg)
        {
            return NormalizeHalfTurn (deg, MathConst.DegInOrbit, MathConst.DegInHalfOrbit);
        }

        /// <summary>
        /// Приводит угол, выраженный в часах, в диапазон (-12h; +12h].
        /// </summary>
        public static double NormalizeHalfTurnInHour (double hour)
        {
            return NormalizeHalfTurn (hour, MathConst.HourInOrbit, MathConst.HourInHalfOrbit);
        }

        /// <summary>
        /// Приводит угол, выраженный в радианах, в диапазон (-π; +π].
        /// </summary>
        public static double NormalizeHalfTurnInRad (double rad)
        {
            return NormalizeHalfTurn (rad, double.Tau, double.Pi);
        }

        /// <summary>
        /// Приводит угол, выраженный в долях оборота, в диапазон (-0.5; +0.5].
        /// </summary>
        public static double NormalizeHalfTurnInOrbit (double orbit)
        {
            double normalized = orbit.Fraction ();

            if (normalized > 0.5)
            {
                normalized--;
            }

            return normalized;
        }

        private static double NormalizeHalfTurn (double x, double unitsInOrbit, double unitsInHalfOrbit)
        {
            double normalized = x.Phase (unitsInOrbit);

            if (normalized > unitsInHalfOrbit)
            {
                normalized -= unitsInOrbit;
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

        /// <summary>
        /// Возвращает арксинус sinValue с сохранением особых значений.
        /// </summary>
        /// <param name="epsilon">Должно быть положительным, иначе метод может вернуть некорректное значение.</param>
        /// <remarks>Если sinValue отличается от особых значений 0 или ±1 на величину меньшую, чем epsilon, возвращается 
        /// соответствующий «особый» угол 0 или ±π/2. Это делается для сохранения особых значений углов и их тригонометрических 
        /// функций при ошибках округления.</remarks>
        public static double AsinEpsilon (double sinValue, double epsilon = ComputingSettings.ZeroAngleEpsilon)
        {
            if ((-epsilon < sinValue) && (sinValue < epsilon)) return 0.0;
            else if (sinValue > 1.0 - epsilon) return MathConst.M_PI_2;
            else if (sinValue < -1.0 + epsilon) return -MathConst.M_PI_2;

            else return double.Asin (sinValue);
        }

        /// <summary>
        /// Возвращает арктангенс (работает как Atan2) с сохранением особых значений.
        /// </summary>
        /// <param name="epsilon">Должно быть положительным, иначе метод может вернуть некорректное значение.</param>
        /// <remarks>Если dy и dx малы (меньше малого значения epsilon по абсолютной величине), скорее всего это означает, что их 
        /// следует считать равными 0, и соответственно Atan2 (dy, dx) тоже следует считать равным 0. Однако если мы просто возьмём 
        /// отношение dy / dx для малых dy и dx, оно может оказаться существенно больше epsilon и, как результат, мы получим 
        /// произвольный угол, существенно отличный от 0. 
        /// Если же только один из аргументов функции (dy или dx) меньше малого epsilon по абсолютной величине, это всё равно служит 
        /// признаком «особого» значения (0, ±π/2, π). 
        /// Поэтому во всех этих случаях мы принудительно возвращаем соответствующее особое значение.Если же dy и dx ≥ epsilon по 
        /// абсолютному значению, мы просто возвращаем Atan2 (dy, dx).</remarks>
        public static double Atan2Epsilon (double dy, double dx, double epsilon = ComputingSettings.ZeroAngleEpsilon)
        {
            if (double.Abs (dy) < epsilon)
            {
                if (dx > -epsilon) return 0.0;
                else return double.Pi;
            }

            else if (double.Abs (dx) < epsilon)
            {
                if (dy >= epsilon) return MathConst.M_PI_2;
                else return -MathConst.M_PI_2;
            }

            else return double.Atan2 (dy, dx);
        }
    }
}