using System;

namespace Archimedes
{
    public static class MathConst
    {
        public const double PI_2 = Math.PI / 2.0;

        public const double PI_3 = Math.PI / 3.0;

        private const double RadPerSemicircle = Math.PI;

        private const double DegPerSemicicrle = 180.0;        

        private const double MinPerDeg = 60.0;        

        private const double SecPerMin = 60.0;

        private const double HourPerSemicicrle = 12.0;

        private const double HMinPerHour = 60.0;

        private const double HSecPerHMin = 60.0;

        public const double DegToRad = RadPerSemicircle / DegPerSemicicrle;

        public const double MinToRad = RadPerSemicircle / (DegPerSemicicrle * MinPerDeg);

        public const double SecToRad = RadPerSemicircle / (DegPerSemicicrle * MinPerDeg * SecPerMin);

        public const double HourToRad = RadPerSemicircle / HourPerSemicicrle;

        public const double HMinToRad = RadPerSemicircle / (HourPerSemicicrle * HMinPerHour);

        public const double HSecToRad = RadPerSemicircle / (HourPerSemicicrle * HMinPerHour * HSecPerHMin);

        public const double RadToDeg = DegPerSemicicrle / RadPerSemicircle;

        public const double RadToMin = (DegPerSemicicrle * MinPerDeg) / RadPerSemicircle;

        public const double RadToSec = (DegPerSemicicrle * MinPerDeg * SecPerMin) / RadPerSemicircle;

        public const double RadToHour = HourPerSemicicrle / RadPerSemicircle;

        public const double RadToHMin = (HourPerSemicicrle * HMinPerHour) / RadPerSemicircle;

        public const double RadToHSec = (HourPerSemicicrle * HMinPerHour * HSecPerHMin) / RadPerSemicircle;
    }
}