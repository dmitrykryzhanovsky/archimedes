using System;

namespace Archimedes
{
    /// <summary>
    /// Сферические координаты в 3-мерном пространстве.
    /// </summary>
    public class Polar3 : ICloneable
    {
        private readonly double _r;
        private readonly double _longitude;
        private readonly double _latitude;

        /// <summary>
        /// Радиус.
        /// </summary>
        public double R
        {
            get => _r;
        }

        /// <summary>
        /// Долгота.
        /// </summary>
        public double Longitude
        {
            get => _longitude;
        }

        /// <summary>
        /// Широта.
        /// </summary>
        public double Latitude
        {
            get => _latitude;
        }

        /// <summary>
        /// Проверяет радиус r на валидность.
        /// </summary>
        /// <remarks>Валидным является неотрицательное значение радиуса.</remarks>
        public static EValid CheckRadius (double r)
        {
            return (r >= 0.0) ? EValid.Valid : EValid.Invalid;
        }

        /// <summary>
        /// Проверяет долготу longitude на валидность.
        /// </summary>
        /// <remarks>Любые значения долготы валидны, однако нормализованным считается значение в диапазоне (-180°; +180°] = (–π; +π]. 
        /// Значения вне этого диапазона считаются ненормализованными.</remarks>
        public static EAngleValid CheckLongitude (double longitude)
        {
            return ((-Double.Pi < longitude) && (longitude <= Double.Pi)) ? EAngleValid.Normalized :
                                                                            EAngleValid.NotNormalized;
        }

        /// <summary>
        /// Проверяет широту latitude на валидность.
        /// </summary>
        /// <remarks>Валидным является значение широты в диапазоне [–90°; +90°] = [–π/2; +π/2].</remarks>
        public static EAngleValid CheckLatitude (double latitude)
        {
            return ((-MathConst.M_PI_2 <= latitude) && (latitude <= MathConst.M_PI_2)) ? EAngleValid.Normalized : 
                                                                                         EAngleValid.Invalid;
        }

        #region Constructors

        public Polar3 (double r, double longitude, double latitude)
        {
            _r         = r;
            _longitude = longitude;
            _latitude  = latitude;
        }

        public Polar3 (Polar3 other) : this (other._r, other._longitude, other._latitude)
        {
        }

        public object Clone ()
        {
            return new Polar3 (this);
        }

        #endregion

        /// <summary>
        /// Преобразует полярные координаты в декартовы.
        /// </summary>
        public Vector3 PolarToCartesian ()
        {
            (double sinB, double cosB) = Double.SinCos (_latitude);
            (double sinL, double cosL) = Double.SinCos (_longitude);

            return new Vector3 (_r * cosB * cosL, 
                                _r * cosB * sinL, 
                                _r * sinB);
        }
    }
}