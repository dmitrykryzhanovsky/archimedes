namespace Archimedes
{
    public static class Trigonometry
    {
        /// <summary>
        /// Возвращает TRUE, если углы <paramref name="angle1"/> и <paramref name="angle2"/> равны с точностью до 2π. В противном 
        /// случае FALSE.
        /// </summary>
        public static bool AreEqualAngles (double angle1, double angle2)
        {
            return (double.Ieee754Remainder (angle1 - angle2, double.Tau) == 0.0);
        }

        /// <summary>
        /// Нормализует угол <paramref name="x"/> – приводит его к диапазону [−π; +π].
        /// </summary>
        public static double NormalizeAngle (double x)
        {
            return double.Ieee754Remainder (x, double.Tau);
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
        /// Преобразует радианы в минуты.
        /// </summary>
        public static double RadToMin (double x)
        {
            return x * MathConst.RadToMin;
        }

        /// <summary>
        /// Преобразует радианы в секунды.
        /// </summary>
        public static double RadToSec (double x)
        {
            return x * MathConst.RadToSec;
        }
    }
}