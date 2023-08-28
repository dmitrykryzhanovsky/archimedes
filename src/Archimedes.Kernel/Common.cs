namespace Archimedes
{
    public static class Common
    {
        public static (int unit0, double total1) SplitPositiveIntoComponents (double x, int unit0PerUnit1)
        {
            int    unit0  = (int)x;
            double total1 = (x - unit0) * unit0PerUnit1;

            return (unit0, total1);
        }

        public static (int unit0, int unit1, double total2) SplitPositiveIntoComponents (double x, int unit0PerUnit1, int unit1PerUnit2)
        {
            int    unit0  = (int)x;
            double total1 = (x - unit0) * unit0PerUnit1;
            int    unit1  = (int)total1;
            double total2 = (total1 - unit1) * unit1PerUnit2;

            return (unit0, unit1, total2);
        }
    }
}