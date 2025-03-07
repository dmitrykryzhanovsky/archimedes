namespace Archimedes
{
    public static class MathConst
    {
        /// <summary>
        /// π / 2.
        /// </summary>
        public const double PI_2 = double.Pi / 2.0;

        /// <summary>
        /// Количество градусов в полном обороте.
        /// </summary>
        public const double DegInOrbit = 360.0;

        /// <summary>
        /// Количество градусов в полуобороте.
        /// </summary>
        public const double DegInHalfTurn = 180.0;

        /// <summary>
        /// Количество часов в полном обороте.
        /// </summary>
        public const double HourInOrbit = 24.0;

        /// <summary>
        /// Количество часов в полуобороте.
        /// </summary>
        public const double HourInHalfTurn = 12.0;

        /// <summary>
        /// Количество минут в основной единице измерения (градусе, часе).
        /// </summary>
        public const int MinInUnit = 60;

        /// <summary>
        /// Количество секунд в минуте.
        /// </summary>
        public const int SecInMin = 60;

        /// <summary>
        /// Количество секунд в основной единице измерения (градусе, часе).
        /// </summary>
        public const int SecInUnit = MinInUnit * SecInMin;

        /// <summary>
        /// Количество миллисекунд в секунде.
        /// </summary>
        public const int MillisecInSec = 1000;

        /// <summary>
        /// Количество миллисекунд в минуте.
        /// </summary>
        public const int MillisecInMin = SecInMin * MillisecInSec;

        /// <summary>
        /// Количество миллисекунд в часе.
        /// </summary>
        public const int MillisecInHour = SecInUnit * MillisecInSec;

        /// <summary>
        /// Коэффициенты для преобразований угловых единиц измерений.
        /// </summary>
        public static class AngularConversions
        {
            // Преобразование в градусы.

            public const double MinToDeg    =   1.0 / DegToMin;
            public const double SecToDeg    =   1.0 / DegToSec;
            public const double HourToDeg   =  15.0;
            public const double HMinToDeg   =   1.0 / DegToHMin;
            public const double HSecToDeg   =   1.0 / DegToHSec;
            public const double RadToDeg    = 180.0 / double.Pi;
            public const double OrbitToDeg  = 360.0;

            // Преобразование в минуты.

            public const double DegToMin    =    60.0;
            public const double SecToMin    =     1.0 / MinToSec;
            public const double HourToMin   =   900.0;
            public const double HMinToMin   =    15.0;
            public const double HSecToMin   =     1.0 / MinToHSec;
            public const double RadToMin    = 10800.0 / double.Pi;
            public const double OrbitToMin  = 21600.0;

            // Преобразование в секунды.

            public const double DegToSec    =    3600.0;
            public const double MinToSec    =      60.0;
            public const double HourToSec   =   54000.0;
            public const double HMinToSec   =     900.0;
            public const double HSecToSec   =      15.0;
            public const double RadToSec    =  648000.0 / double.Pi;
            public const double OrbitToSec  = 1296000.0;

            // Преобразование в часы.

            public const double DegToHour   =  1.0 / HourToDeg;
            public const double MinToHour   =  1.0 / HourToMin;
            public const double SecToHour   =  1.0 / HourToSec;
            public const double HMinToHour  =  1.0 / HourToHMin;
            public const double HSecToHour  =  1.0 / HourToHSec;
            public const double RadToHour   = 12.0 / double.Pi;
            public const double OrbitToHour = 24.0;

            // Преобразование в угловые минуты.

            public const double DegToHMin   =    4.0;
            public const double MinToHMin   =    1.0 / HMinToMin;
            public const double SecToHMin   =    1.0 / HMinToSec;
            public const double HourToHMin  =   60.0;
            public const double HSecToHMin  =    1.0 / HMinToHSec;
            public const double RadToHMin   =  720.0 / double.Pi;
            public const double OrbitToHMin = 1440.0;

            // Преобразование в угловые секунды.

            public const double DegToHSec   =   240.0;
            public const double MinToHSec   =     4.0;
            public const double SecToHSec   =     1.0 / HSecToSec;
            public const double HourToHSec  =  3600.0;
            public const double HMinToHSec  =    60.0;
            public const double RadToHSec   = 43200.0 / double.Pi;
            public const double OrbitToHSec = 86400.0;

            // Преобразование в радианы.

            public const double DegToRad    = double.Pi /    180.0;
            public const double MinToRad    = double.Pi /  10800.0;
            public const double SecToRad    = double.Pi / 648000.0;
            public const double HourToRad   = double.Pi /     12.0;
            public const double HMinToRad   = double.Pi /    720.0;
            public const double HSecToRad   = double.Pi /  43200.0;
            public const double OrbitToRad  = double.Tau;

            // Преобразование в доли оборота.

            public const double DegToOrbit  = 1.0 / OrbitToDeg;
            public const double MinToOrbit  = 1.0 / OrbitToMin;
            public const double SecToOrbit  = 1.0 / OrbitToSec;
            public const double HourToOrbit = 1.0 / OrbitToHour;
            public const double HMinToOrbit = 1.0 / OrbitToHMin;
            public const double HSecToOrbit = 1.0 / OrbitToHSec;
            public const double RadToOrbit  = 1.0 / double.Tau;
        }
    }
}