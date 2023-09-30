using System;

namespace Archimedes
{
    public class Polar2 : ICloneable
    {
        private double _r;
        private double _heading;

        public double R
        {
            get => _r;
        }

        public double Heading
        {
            get => _heading;
        }

        private Polar2 ()
        {
        }

        public Polar2 (Polar2 other)
        {
            _r       = other._r;
            _heading = other._heading;
        }

        public object Clone ()
        {
            return new Polar2 (this);
        }

        public static Polar2 CartesianToPolar (Vector2 v)
        {
            Polar2 p = new Polar2 ();

            p._r       = v.GetLength ();
            p._heading = v.GetHeading ();

            return p;
        }

        public static Vector2 PolarToCartesian (Polar2 p)
        {
            (double sin, double cos) = Math.SinCos (p._heading);

            return new Vector2 (p._r * cos, p._r * sin);
        }
    }
}