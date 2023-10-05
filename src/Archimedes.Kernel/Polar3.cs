using System;

namespace Archimedes
{
    public class Polar3 : ICloneable
    {
        private double _r;
        private double _longitude;
        private double _latitude;

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

        // TODO: проверка на валидность данных

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