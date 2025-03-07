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
        /// - Item2 (int) - целая число градусов (часов).
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

        private static (int, int, double) Split6060 (double x)
        {
            double totalSecF   = x * MathConst.SecInUnit;
            int    totalSecInt = (int)totalSecF;

            (int unit, int secInsideHour)   = int.DivRem (totalSecInt, MathConst.SecInUnit);
            (int min,  int secInsideMinute) = int.DivRem (secInsideHour, MathConst.SecInMin);

            double sec = secInsideMinute + (totalSecF - totalSecInt);

            return (unit, min, sec);
        }
    }
}