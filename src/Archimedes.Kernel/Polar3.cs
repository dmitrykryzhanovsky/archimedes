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

        private Polar3 ()
        {
        }

        public Polar3 (Polar3 other)
        {
            _r         = other._r;
            _longitude = other._longitude;
            _latitude  = other._latitude;
        }

        public object Clone ()
        {
            return new Polar3 (this);
        }

        public static Polar3 CartesianToPolar (Vector3 v)
        {
            Polar3 p = new Polar3 ();

            p._r         = v.GetLength ();
            p._longitude = Math.Atan2 (v.Y, v.X);
            p._latitude  = Math.Asin (v.Z / p._r);

            return p;
        }

        public static Vector3 PolarToCartesian (Polar3 p)
        {
            (double sinB, double cosB) = Math.SinCos (p._latitude);
            (double sinL, double cosL) = Math.SinCos (p._longitude);

            return new Vector3 (p._r * cosB * cosL, 
                                p._r * cosB * sinL, 
                                p._r * sinB);
        }
    }
}