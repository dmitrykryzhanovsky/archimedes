namespace Archimedes
{
    public static class Trigonometry
    {
        /// <summary>
        /// Возвращает TRUE, если два угла x и y равны с точностью до 2π. В противном случае FALSE.
        /// </summary>
        public static bool AreEqualAngles (double x, double y)
        {
            return (double.Ieee754Remainder (x - y, double.Tau) == 0.0);
        }

        public static double AsinSmall (double sinValue, double epsilon)
        {
            if ((-epsilon < sinValue) && (sinValue < epsilon)) return 0.0;
            else if (sinValue >  1.0 - epsilon) return  MathConst.M_PI_2;
            else if (sinValue < -1.0 + epsilon) return -MathConst.M_PI_2;

            else return double.Asin (sinValue);
        }
         
        public static double Atan2Small (double dx, double dy, double epsilon)
        {
            if (dy < epsilon)
            {
                if (dx >= 0.0) return 0.0;
                else return double.Pi;
            }

            else if (dx < epsilon)
            {
                if (dy >= 0.0) return MathConst.M_PI_2;
                else return -MathConst.M_PI_2;
            }

            else return double.Atan2 (dy, dx);
        }
    }
}