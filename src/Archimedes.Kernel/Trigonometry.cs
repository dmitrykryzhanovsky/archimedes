namespace Archimedes
{
    public static class Trigonometry
    {
        /// <summary>
        /// Преобразует градусы в радианы.
        /// </summary>
        public static double DegToRad (double x)
        {
            return x * MatConst.DegToRad;
        }

        /// <summary>
        /// Преобразует минуты в радианы.
        /// </summary>
        public static double MinToRad (double x)
        {
            return x * MatConst.MinToRad;
        }

        /// <summary>
        /// Преобразует секунды в радианы.
        /// </summary>
        public static double SecToRad (double x)
        {
            return x * MatConst.SecToRad;
        }
    }
}