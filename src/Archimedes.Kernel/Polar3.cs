using System;

namespace Archimedes
{
    public class Polar3 : ICloneable, IEquatable<Polar3>
    {
        private double _r;
        private double _l;
        private double _b;

        public double Radius
        {
            get => _r;
            set => throw new NotImplementedException ();
        }
        public double Longitude
        {
            get => _l;
            set => throw new NotImplementedException ();
        }

        public double Latitude
        {
            get => _b;
            set => throw new NotImplementedException ();
        }

        private Polar3 ()
        {
        }

        public Polar3 (double radius, double longitude, double latitude)
        {
            Radius    = radius;
            Longitude = longitude;
            Latitude  = latitude;
        }

        public Polar3 (Polar3 other) : this ()
        {
            _r = other._r;
            _l = other._l;
            _b = other._b;
        }

        public object Clone ()
        {
            return new Polar3 (this);
        }

        public Polar3 InitPolar3 (double radius, double longitude, double latitude)
        {
            Polar3 result = new Polar3 ();

            result._r = radius;
            result._l = longitude;
            result._b = latitude;

            return result;
        }

        public bool Equals (Polar3? other)
        {
            throw new NotImplementedException ();
        }

        public override bool Equals (object? other)
        {
            if (other is Polar3) return Equals (other as Polar3);
            else throw new InvalidCastException ();
        }

        public override int GetHashCode ()
        {
            return base.GetHashCode ();
        }

        public static bool operator == (Polar3 p1, Polar3 p2)
        {
            return p1.Equals (p2);
        }

        public static bool operator != (Polar3 p1, Polar3 p2)
        {
            return !p1.Equals (p2);
        }

        public Vector3 PolarToCartesian ()
        {
            throw new NotImplementedException ();
        }
    }
}