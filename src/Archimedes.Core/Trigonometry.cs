namespace Archimedes
{
    public static class Trigonometry
    {
        public static double SecToRad (double sec)
        {
            return sec * MathConst.SEC_TO_RAD;
        }

        /// <summary>
        /// Возвращает арксинус sinValue с сохранением особых значений.
        /// </summary>
        /// <remarks>Если sinValue отличается от особых значений 0 или ±1 на величину меньшую, чем epsilon, возвращается соответствующий 
        /// «особый» угол 0 или ±π/2. Это делается для сохранения особых значений углов и их тригонометрических функций при ошибках 
        /// округления.</remarks>
        public static double AsinSmall (double sinValue, double epsilon)
        {
            if ((-epsilon < sinValue) && (sinValue < epsilon)) return 0.0;
            else if (sinValue > 1.0 - epsilon) return MathConst.M_PI_2;
            else if (sinValue < -1.0 + epsilon) return -MathConst.M_PI_2;

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
        public static double Atan2Small (double dy, double dx, double epsilon)
        {
            if (double.Abs (dy) < epsilon)
            {
                if (dx >= 0.0) return 0.0;
                else return double.Pi;
            }

            else if (double.Abs (dx) < epsilon)
            {
                if (dy >= 0.0) return MathConst.M_PI_2;
                else return -MathConst.M_PI_2;
            }

            else return double.Atan2 (dy, dx);
        }
    }
}