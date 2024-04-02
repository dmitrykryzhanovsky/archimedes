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

        /// <summary>
        /// Возвращает TRUE, если углы <paramref name="x"/> и <paramref name="y"/> в нормализованном представлении равны между собой 
        /// (то есть отличаются на целое число периодов: x – y = k · 2π, где k – целое число). В противном случае FALSE.
        /// </summary>
        public static bool AreNormalizedAnglesEqual (double x, double y)
        {
            return (double.Ieee754Remainder (x - y, double.Tau) == 0.0);
        }
    }
}