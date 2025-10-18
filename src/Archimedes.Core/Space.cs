namespace Archimedes
{
    public static class Space
    {
        /// <summary>
        /// Проверяет, что значение расстояния r, переданное в метод, неотрицательное.
        /// </summary>
        public static void CheckR (double r)
        {
            ArgumentOutOfRangeCheckers.CheckNotNegative (r);
        }
    }
}