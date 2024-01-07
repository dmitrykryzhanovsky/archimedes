namespace Archimedes
{
    public static class Trigonometry
    {
        /// <summary>
        /// Преобразование градусов в радианы.
        /// </summary>
        public static double DegToRad (double deg)
        {
            return deg * MathConst.DegToRad;
        }

        /// <summary>
        /// Преобразование секунд в радианы.
        /// </summary>
        public static double SecToRad (double sec)
        {
            return sec * MathConst.SecToRad;
        }

        /// <summary>
        /// Приводит угол angle в диапазон [–π; +π].
        /// </summary>
        public static double Normalize (double angle)
        {
            return double.Ieee754Remainder (angle, double.Tau);
        }
    }
}