namespace Archimedes
{
    public static class Trigonometry
    {
        /// <summary>
        /// Возвращает TRUE, если углы x и y равны с точностью до 2π. В противном случае FALSE.
        /// </summary>
        public static bool AreEqualAngles (double x, double y)
        {
            return (double.Ieee754Remainder (x - y, double.Tau) == 0.0);
        }

        /// <summary>
        /// Нормализует угол x – приводит его к диапазону [−π; +π].
        /// </summary>
        public static double NormalizeAngle (double x)
        {
            return double.Ieee754Remainder (x, double.Tau);
        }

        public static double DegToRad (double x)
        {
            return x * MathConst.DegToRad;
        }

        public static double MinToRad (double x)
        {
            return x * MathConst.MinToRad;
        }

        public static double SecToRad (double x)
        {
            return x * MathConst.SecToRad;
        }

        public static double RadToDeg (double x)
        {
            return x * MathConst.RadToDeg;
        }

        public static double RadToMin (double x)
        {
            return x * MathConst.RadToMin;
        }

        public static double RadToSec (double x)
        {
            return x * MathConst.RadToSec;
        }
    }
}