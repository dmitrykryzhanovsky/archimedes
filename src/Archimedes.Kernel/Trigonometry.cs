﻿namespace Archimedes
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
    }
}