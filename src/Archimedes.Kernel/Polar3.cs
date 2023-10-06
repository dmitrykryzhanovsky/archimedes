using System;

namespace Archimedes
{
    public class Polar3 : ICloneable
    {
        private readonly double _r;
        private readonly double _longitude;
        private readonly double _latitude;

        public double R
        {
            get => _r;
        }

        public double Longitude
        {
            get => _longitude;
        }

        public double Latitude
        {
            get => _latitude;
        }

        public static (EValid, EAngleValid, EAngleValid) CheckValidity (double r, double longitude, double latitude)
        {
            EValid rValid = (r >= 0.0) ? EValid.Valid : EValid.Invalid;

            EAngleValid longitudeValid = ((-Math.PI < longitude) && (longitude <= Math.PI)) ? EAngleValid.Normalized : 
                                                                                              EAngleValid.NotNormalized;

            EAngleValid latitudeValid = ((-MathConst.M_PI_2 <= latitude) && (latitude <= MathConst.M_PI_2)) ? EAngleValid.Normalized : 
                                                                                                          EAngleValid.Invalid;

            return (rValid, longitudeValid, latitudeValid);
        }

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

        public Vector3 PolarToCartesian ()
        {
            (double sinB, double cosB) = Math.SinCos (_latitude);
            (double sinL, double cosL) = Math.SinCos (_longitude);

            return new Vector3 (_r * cosB * cosL, 
                                _r * cosB * sinL, 
                                _r * sinB);
        }
    }
}