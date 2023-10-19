namespace Archimedes
{
    public static class Trigonometry
    {
        /// <summary>
        /// Преобразование градусов в радианы.
        /// </summary>
        public static double DegToRad(double deg)
        {
            return deg * MathConst.DegToRad;
        }

        /// <summary>
        /// Преобразование секунд в радианы.
        /// </summary>
        public static double SecToRad(double sec)
        {
            return sec * MathConst.SecToRad;
        }
    }
}