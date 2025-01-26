namespace Archimedes
{
    public static class MeasurementUnit
    {
        private const double DegMinCoefficient  = 60.0;
        private const double HourMinCoefficient = 60.0;
        private const double MinSecCoefficient  = 60.0;
        private const double DegSecCoefficient  = DegMinCoefficient * MinSecCoefficient;
        private const double HourSecCoefficient = HourMinCoefficient * MinSecCoefficient;

        private const int DegMinCoefficientInteger  = 60;
        private const int HourMinCoefficientInteger = 60;
        private const int MinSecCoefficientInteger  = 60;
        private const int DegSecCoefficientInteger  = DegMinCoefficientInteger * MinSecCoefficientInteger;
        private const int HourSecCoefficientInteger = HourMinCoefficientInteger * MinSecCoefficientInteger;

        public static (double sign, int deg, int min, double sec) SplitDegree (double degree)
        {
            int    deg, min;
            double sec;

            if (degree > 0.0)
            {
                (deg, min, sec) = ExtractComponents (degree, DegMinCoefficient, DegMinCoefficientInteger, MinSecCoefficient);

                return (1.0, deg, min, sec);
            }

            else if (degree < 0.0)
            {
                (deg, min, sec) = ExtractComponents (double.Abs (degree), DegMinCoefficient, DegMinCoefficientInteger, MinSecCoefficient);

                return (-1.0, deg, min, sec);
            }

            else return (0.0, 0, 0, 0.0);
        }

        public static (double sign, int hour, int min, double sec) SplitHour (double archour)
        {
            int    hour, min;
            double sec;

            if (archour > 0.0)
            {
                (hour, min, sec) = ExtractComponents (archour, HourMinCoefficient, HourMinCoefficientInteger, MinSecCoefficient);

                return (1.0, hour, min, sec);
            }

            else if (archour < 0.0)
            {
                (hour, min, sec) = ExtractComponents (double.Abs (archour), HourMinCoefficient, HourMinCoefficientInteger, MinSecCoefficient);

                return (-1.0, hour, min, sec);
            }

            else return (0.0, 0, 0, 0.0);
        }

        public static double AssembleDegree (double sign, int deg, int min, double sec)
        {
            return sign * AssembleComponents (deg, min, sec, DegSecCoefficient, DegSecCoefficientInteger, MinSecCoefficientInteger);
        }

        public static double AssembleHour (double sign, int hour, int min, double sec)
        {
            return sign * AssembleComponents (hour, min, sec, HourSecCoefficient, HourSecCoefficientInteger, MinSecCoefficientInteger);
        }

        private static (int component0, int component1, double component2) ExtractComponents (double positiveValue, double coefficient01, 
            int coefficient01Integer, double coefficient12)
        {
            double component1InTotal        = positiveValue * coefficient01;
            int    component1InTotalInteger = (int)component1InTotal;

            (int component0, int component1) = int.DivRem (component1InTotalInteger, coefficient01Integer);
            double component2 = (component1InTotal - component1InTotalInteger) * coefficient12;

            return (component0, component1, component2);
        }

        private static double AssembleComponents (int component0, int component1, double component2, double coefficient02, 
            int coefficient02Integer, int coefficient12Integer)
        {
            return (component0 * coefficient02Integer + component1 * coefficient12Integer + component2) / coefficient02;
        }
    }
}