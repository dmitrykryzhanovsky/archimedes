namespace Archimedes
{
    public static class Common
    {
        public static (ESign sign, int unit0, double total1) SplitIntoComponents (double x, int unit0PerUnit1)
        {
            ESign  sign;
            int    unit0;
            double total1;

            if (x >= 0.0) sign = ESign.NonNegative;

            else
            {
                sign = ESign.Negative;
                x    = -x;
            }

            (unit0, total1) = SplitNonNegativeIntoComponents (x, unit0PerUnit1);

            return (sign, unit0, total1);
        }

        /// <summary>
        /// Разделят неотрицательную величину x на два компонента (например, градусы на целое число градусов и минуты).
        /// </summary>
        /// <param name="unit0PerUnit1">Сколько единиц измерения младшего порядка содержится в одной единице измерения старшого порядка 
        /// (например, сколько минут в одном градусе).</param>
        /// <returns>На примере градусов: для x = 73.426°, unit0 = 73°, total1 = 25.56ʹ (что соответствует 0.426°).</returns>
        public static (int unit0, double total1) SplitNonNegativeIntoComponents (double x, int unit0PerUnit1)
        {
            int    unit0  = (int)x;
            double total1 = (x - unit0) * unit0PerUnit1;

            return (unit0, total1);
        }

        public static (ESign sign, int unit0, int unit1, double total2) SplitIntoComponents (double x, int unit0PerUnit1, int unit1PerUnit2)
        {
            ESign  sign;
            int    unit0;
            int    unit1;
            double total2;

            if (x >= 0.0) sign = ESign.NonNegative;

            else
            {
                sign = ESign.Negative;
                x    = -x;
            }

            (unit0, unit1, total2) = SplitNonNegativeIntoComponents (x, unit0PerUnit1, unit1PerUnit2);

            return (sign, unit0, unit1, total2);
        }

        /// <summary>
        /// Разделят неотрицательную величину x на три компонента (например, градусы на целое число градусов, целое число минут и секунды).
        /// </summary>
        /// <param name="unit0PerUnit1">Сколько единиц измерения первого порядка содержится в одной единице измерения нулевого порядка 
        /// (например, сколько минут в одном градусе).</param>
        /// <param name="unit1PerUnit2">Сколько единиц измерения второго порядка содержится в одной единице измерения первого порядка 
        /// (например, сколько секунд в одной минуте).</param>
        /// <returns>На примере градусов: для x = 73.426°, unit0 = 73°, unit1 = 25ʹ, total2 = 33.6ʺ.</returns>
        public static (int unit0, int unit1, double total2) SplitNonNegativeIntoComponents (double x, int unit0PerUnit1, int unit1PerUnit2)
        {
            int    unit0  = (int)x;
            double total1 = (x - unit0) * unit0PerUnit1;
            int    unit1  = (int)total1;
            double total2 = (total1 - unit1) * unit1PerUnit2;

            return (unit0, unit1, total2);
        }
    }
}