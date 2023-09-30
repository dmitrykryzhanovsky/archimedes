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

        public Polar2 (double r, double heading)
        {
            _r       = r;
            _heading = heading;
        }

        public Polar2 (Polar2 other) : this (other._r, other._heading)
        {
        }

        public object Clone ()
        {
            return new Polar2 (this);
        }

        public Vector2 PolarToCartesian ()
        {
            (double sin, double cos) = Math.SinCos (_heading);

            return new Vector2 (_r * cos, _r * sin);
        }
    }
}