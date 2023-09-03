using System;

namespace Archimedes
{
    public static class Trigonometry
    {
        #region // Преобразования между градусной (часовой) и радианной мерами //

        public static double DegToRad (double deg)
        {
            return deg * MathConst.DegToRad;
        }

        public static double MinToRad (double min)
        {
            return min * MathConst.MinToRad;
        }

        public static double SecToRad (double sec)
        {
            return sec * MathConst.SecToRad;
        }

        public static double HourToRad (double hour)
        {
            return hour * MathConst.HourToRad;
        }

        public static double HMinToRad (double hmin)
        {
            return hmin * MathConst.HMinToRad;
        }

        public static double HSecToRad (double hsec)
        {
            return hsec * MathConst.HSecToRad;
        }

        public static double RadToDeg (double rad)
        {
            return rad * MathConst.RadToDeg;
        }

        public static double RadToMin (double rad)
        {
            return rad * MathConst.RadToMin;
        }

        public static double RadToSec (double rad)
        {
            return rad * MathConst.RadToSec;
        }

        public static double RadToHour (double rad)
        {
            return rad * MathConst.RadToHour;
        }

        public static double RadToHMin (double rad)
        {
            return rad * MathConst.RadToHMin;
        }

        public static double RadToHSec (double rad)
        {
            return rad * MathConst.RadToHSec;
        }

        #endregion

        /// <summary>
        /// Приводит угол x в диапазон (-π; +π].
        /// </summary>
        /// <remarks>Хотя в большинстве случаев в вычислениях удобнее пользоваться полуинтервалами, открытыми справа, в данном случае 
        /// используется полуинтервал, открытый слева, для удобства представления углов равных ±180°.</remarks>
        public static double NormalizePM180 (double x)
        {
            double result = Math.IEEERemainder (x, Math.Tau);

            if (result == -Math.PI) result = Math.PI;

            return result;
        }

        /// <summary>
        /// Приводит угол x в диапазон [0; 2π).
        /// </summary>
        public static double Normalize360 (double x)
        {
            double result = Math.IEEERemainder (x, Math.Tau);

            if (result < 0.0) result += Math.Tau;

            return result;
        }

        #region // Разделение градусной (часовой) меры угла на компоненты и сборка градусной (часовой) меры из компонент //

        public static (ESign sign, int deg, double min) GetDegMin (double x)
        {
            throw new NotImplementedException ();
        }

        public static (ESign sign, int deg, int min, double sec) GetDegMinSec (double x)
        {
            throw new NotImplementedException ();
        }

        public static (ESign sign, int deg, int min, int sec, double fraction) GetDegMinSecFraction (double x)
        {
            throw new NotImplementedException ();
        }

        public static (ESign sign, int hour, double hmin) GetHourHMin (double x)
        {
            throw new NotImplementedException ();
        }

        public static (ESign sign, int hour, int hmin, double hsec) GetHourHMinHSec (double x)
        {
            throw new NotImplementedException ();
        }

        public static (ESign sign, int hour, int hmin, int hsec, double fraction) GetHourHMinHSecFraction (double x)
        {
            throw new NotImplementedException ();
        }

        public static double GetDeg (ESign sign, int deg, double min)
        {
            throw new NotImplementedException ();
        }

        public static double GetDeg (ESign sign, int deg, int min, double sec)
        {
            throw new NotImplementedException ();
        }

        public static double GetDeg (ESign sign, int deg, int min, int sec, double fraction)
        {
            throw new NotImplementedException ();
        }

        public static double GetHour (ESign sign, int hour, double hmin)
        {
            throw new NotImplementedException ();
        }

        public static double GetHour (ESign sign, int hour, int hmin, double hsec)
        {
            throw new NotImplementedException ();
        }

        public static double GetHour (ESign sign, int hour, int hmin, int hsec, double fraction)
        {
            throw new NotImplementedException ();
        }

        #endregion
    }
}