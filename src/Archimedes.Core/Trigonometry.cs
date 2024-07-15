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
    }
}