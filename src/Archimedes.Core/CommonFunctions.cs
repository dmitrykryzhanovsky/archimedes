namespace Archimedes
{
    public static class CommonFunctions
    {
        /// <summary>
        /// Выделяет компоненты угла, выраженного в градусах или часах.
        /// </summary>
        /// <returns>
        /// Компоненты кортежа:
        /// - Item1 (int) - знак: +1 для положительных углов и 0, -1 для отрицательных.
        /// - Item2 (int) - целое число градусов (часов).
        /// - Item3 (int) - целое число минут в градусе (часе).
        /// - Item4 (double) - вещественное число секунд в минуте.
        /// </returns>
        public static (int, int, int, double) SplitAngle (double x)
        {
            int sign;

            if (x >= 0.0) sign = 1;
            
            else
            {
                x    = -x;
                sign = -1;
            }

            (int unit, int min, double sec) = Split6060 (x);

            return (sign, unit, min, sec);
        }

        /// <summary>
        /// Выделяет компоненты времени суток, выраженного в часах.
        /// </summary>
        /// <returns>
        /// Компоненты кортежа:
        /// - Item1 (int) - целое число часов.
        /// - Item2 (int) - целое число минут в часе.
        /// - Item3 (double) - вещественное число секунд в минуте.
        /// </returns>
        public static (int, int, double) SplitDayTimeBySec (double x)
        {
            return Split6060 (x);
        }

        /// <summary>
        /// Выделяет компоненты времени суток, выраженного в часах.
        /// </summary>
        /// <returns>
        /// Компоненты кортежа:
        /// - Item1 (int) - целое число часов.
        /// - Item2 (int) - целое число минут в часе.
        /// - Item3 (int) - целое число секунд в минуте.
        /// - Item4 (int) - целое число миллисекунд в секунде.
        /// </returns>
        public static (int, int, int, int) SplitDayTimeByMillisec (double x)
        {
            int totalMillisecInt = (int)(x * MathConst.MillisecInHour);

            (int hour, int millisecInsideHour)   = int.DivRem (totalMillisecInt, MathConst.MillisecInHour);
            (int min,  int millisecInsideMinute) = int.DivRem (millisecInsideHour, MathConst.MillisecInMin);
            (int sec,  int millisec)             = int.DivRem (millisecInsideMinute, MathConst.MillisecInSec);

            return (hour, min, sec, millisec);
        }

        private static (int, int, double) Split6060 (double x)
        {
            double totalSecF   = x * MathConst.SecInUnit;
            int    totalSecInt = (int)totalSecF;

            (int unit, int secInsideHour)   = int.DivRem (totalSecInt, MathConst.SecInUnit);
            (int min,  int secInsideMinute) = int.DivRem (secInsideHour, MathConst.SecInMin);

            double sec = secInsideMinute + (totalSecF - totalSecInt);

            return (unit, min, sec);
        }

        public static double ComposeAngle (int sign, int unit, int min, double sec)
        {
            double angle = Compose6060 (unit, min, sec);

            if (sign < 0) angle = -angle;

            return angle;
        }

        public static double ComposeDayTime (int hour, int min, double sec)
        {
            return Compose6060 (hour, min, sec);
        }

        private static double Compose6060 (int unit, int min, double sec)
        {
            return (unit * MathConst.SecInUnit + min * MathConst.MinInUnit + sec) / (double)MathConst.SecInUnit;
        }
    }
}