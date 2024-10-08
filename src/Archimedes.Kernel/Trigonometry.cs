namespace Archimedes
{
    public static class Trigonometry
    {
        /// <summary>
        /// Возвращает TRUE, если два угла x и y равны с точностью до 2π. В противном случае FALSE.
        /// </summary>
        public static bool AreEqualAngles (double x, double y)
        {
            return (double.Ieee754Remainder (x - y, double.Tau) == 0.0);
        }

        /// <summary>
        /// Преобразует градусы в радианы.
        /// </summary>
        public static double DegToRad (double x)
        {
            return x * MathConst.DegToRad;
        }

        /// <summary>
        /// Преобразует минуты в радианы.
        /// </summary>
        public static double MinToRad (double x)
        {
            return x * MathConst.MinToRad;
        }

        /// <summary>
        /// Преобразует секунды в радианы.
        /// </summary>
        public static double SecToRad (double x)
        {
            return x * MathConst.SecToRad;
        }

        /// <summary>
        /// Преобразует радианы в градусы.
        /// </summary>
        public static double RadToDeg (double x)
        {
            return x * MathConst.RadToDeg;
        }

        /// <summary>
        /// Нормализует угол – приводит его к диапазону [−π; +π].
        /// </summary>
        public static double NormalizeAngle (double x)
        {
            return double.Ieee754Remainder (x, MathConst.M_2_PI);
        }

        /// <summary>
        /// Нормализует угол – приводит его к диапазону [0; 2π).
        /// </summary>
        public static double NormalizeAngle2PI (double x)
        {
            double normalized = double.Ieee754Remainder (x, MathConst.M_2_PI);

            return (normalized >= 0.0) ? normalized : normalized + MathConst.M_2_PI;
        }

        /// <summary>
        /// Возвращает арксинус sinValue с сохранением особых значений.
        /// </summary>
        /// <remarks>Если sinValue отличается от особых значений – 0, ±1 – на величину меньшую, чем epsilon, возвращается 
        /// соответствующий «особый» угол – 0, ±π/2. Это делается для сохранения особых значений углов и тригонометрических функций 
        /// при ошибках округления.</remarks>
        public static double AsinSmall (double sinValue, double epsilon)
        {
            if ((-epsilon < sinValue) && (sinValue < epsilon)) return 0.0;
            else if (sinValue >  1.0 - epsilon) return  MathConst.M_PI_2;
            else if (sinValue < -1.0 + epsilon) return -MathConst.M_PI_2;

            else return double.Asin (sinValue);
        }
         
        // TODO: комментарии, исправить порядок dx и dy в вызовах метода
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