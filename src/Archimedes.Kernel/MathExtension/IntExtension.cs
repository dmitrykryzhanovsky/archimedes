namespace Archimedes.MathExtension
{
    public static class IntExtension
    {
        /// <summary>
        /// Возвращает true, если n чётное, и false, если n нечётное.
        /// </summary>
        public static bool IsEven (this int n)
        {
            return ((n & 1) == 0);
        }

        /// <summary>
        /// Возвращает true, если n нечётное, и false, если n чётное.
        /// </summary>
        public static bool IsOdd (this int n)
        {
            return ((n & 1) == 1);
        }
    }
}