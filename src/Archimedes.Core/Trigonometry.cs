namespace Archimedes
{
    public static class Trigonometry
    {
        /// <summary>
        /// Возвращает TRUE, если фазы углов angle1 и angle2 равны. В противном случае FALSE.
        /// </summary>
        public static bool AreEqualPhaseInRad (double angle1, double angle2)
        {
            return (double.Ieee754Remainder (angle1 - angle2, double.Tau) == 0.0);
        }
    }
}