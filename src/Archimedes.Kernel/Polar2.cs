using System;

namespace Archimedes
{
    public class Polar2 : ICloneable, IEquatable<Polar2>
    {
        private double _r;
        private double _t;

        public double Radius
        {
            get => _r;
            set => throw new NotImplementedException ();
        }
        public double Heading
        {
            get => _t;
            set => throw new NotImplementedException ();
        }

        private Polar2 ()
        {
        }

        public Polar2 (double radius, double heading)
        {
            Radius  = radius;
            Heading = heading;
        }

        public Polar2 (Polar2 other) : this ()
        {
            _r = other._r;
            _t = other._t;
        }

        public object Clone ()
        {
            return new Polar2 (this);
        }

        public Polar2 InitPolar2 (double radius, double heading)
        {
            Polar2 result = new Polar2 ();

            result._r = radius;
            result._t = heading;

            return result;
        }

        public bool Equals (Polar2? other)
        {
            throw new NotImplementedException ();
        }

        public override bool Equals (object? other)
        {
            if (other is Polar2) return Equals (other as Polar2);
            else throw new InvalidCastException ();
        }

        public override int GetHashCode ()
        {
            return base.GetHashCode ();
        }

        public static bool operator == (Polar2 p1, Polar2 p2)
        {
            return p1.Equals (p2);
        }

        public static bool operator != (Polar2 p1, Polar2 p2)
        {
            return !p1.Equals (p2);
        }

        public Vector2 PolarToCartesian ()
        {
            throw new NotImplementedException ();
        }
    }
}