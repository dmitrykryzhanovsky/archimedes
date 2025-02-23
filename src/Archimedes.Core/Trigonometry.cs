namespace Archimedes
{
    public static class Trigonometry
    {
        public static double DegToRad (double deg)
        {
            return deg * MathConst.DEG_TO_RAD;
        }

        public static double MinToRad (double min)
        {
            return min * MathConst.MIN_TO_RAD;
        }

        public static double SecToRad (double sec)
        {
            return sec * MathConst.SEC_TO_RAD;
        }

        public static double HourToRad (double hour)
        {
            return hour * MathConst.HOUR_TO_RAD;
        }

        public static double HMinToRad (double hmin)
        {
            return hmin * MathConst.HMIN_TO_RAD;
        }

        public static double HSecToRad (double hsec)
        {
            return hsec * MathConst.HSEC_TO_RAD;
        }

        public static double RotationToRad (double rotation)
        {
            return rotation * double.Tau;
        }

        public static double RadToDeg (double rad)
        {
            return rad * MathConst.RAD_TO_DEG;
        }

        public static double RadToMin (double rad)
        {
            return rad * MathConst.RAD_TO_MIN;
        }

        public static double RadToSec (double rad)
        {
            return rad * MathConst.RAD_TO_SEC;
        }

        public static double RadToHour (double rad)
        {
            return rad * MathConst.RAD_TO_HOUR;
        }

        public static double RadToHMin (double rad)
        {
            return rad * MathConst.RAD_TO_HMIN;
        }

        public static double RadToHSec (double rad)
        {
            return rad * MathConst.RAD_TO_HSEC;
        }
        
        public static double RadToRotation (double rad)
        {
            return rad / double.Tau;
        }

        /// <summary>
        /// Пусть x задаёт число оборотов (включая и дробную часть). Тогда этот метод возвращает угол, соответствующий заданному числу 
        /// оборотов, приведённый к интервалу [0; 2π).
        /// </summary>
        public static double RotationFraction (double x)
        {
            return x.Fraction () * double.Tau;
        }

        /// <summary>
        /// Возвращает арксинус sinValue с сохранением особых значений.
        /// </summary>
        /// <remarks>Если sinValue отличается от особых значений 0 или ±1 на величину меньшую, чем epsilon, возвращается соответствующий 
        /// «особый» угол 0 или ±π/2. Это делается для сохранения особых значений углов и их тригонометрических функций при ошибках 
        /// округления.</remarks>
        public static double AsinSmall (double sinValue, double epsilon = ComputingSettings.SmallAngleEpsilon)
        {
            if ((-epsilon < sinValue) && (sinValue < epsilon)) return 0.0;
            else if (sinValue > 1.0 - epsilon) return MathConst.PI_2;
            else if (sinValue < -1.0 + epsilon) return -MathConst.PI_2;

            else return double.Asin (sinValue);
        }

        /// <summary>
        /// Возвращает арктангенс (работает как Atan2) с сохранением особых значений.
        /// </summary>
        /// <remarks>Если dy и dx малы (меньше малого значения epsilon по абсолютной величине), скорее всего это означает, что их 
        /// следует считать равными 0, и соответственно Atan2 (dy, dx) тоже следует считать равным 0. Однако если мы просто возьмём 
        /// отношение dy / dx для малых dy и dx, оно может оказаться существенно больше epsilon и, как результат, мы получим 
        /// произвольный угол, существенно отличный от 0. 
        /// Если же только один из аргументов функции (dy или dx) меньше малого epsilon по абсолютной величине, это всё равно служит 
        /// признаком «особого» значения (0, ±π/2, π). 
        /// Поэтому во всех этих случаях мы принудительно возвращаем соответствующее особое значение.Если же dy и dx ≥ epsilon по 
        /// абсолютному значению, мы просто возвращаем Atan2 (dy, dx).</remarks>
        public static double Atan2Small (double dy, double dx, double epsilon = ComputingSettings.SmallAngleEpsilon)
        {
            if (double.Abs (dy) < epsilon)
            {
                if (dx >= 0.0) return 0.0;
                else return double.Pi;
            }

            else if (double.Abs (dx) < epsilon)
            {
                if (dy >= 0.0) return MathConst.PI_2;
                else return -MathConst.PI_2;
            }

            else return double.Atan2 (dy, dx);
        }
    }
}