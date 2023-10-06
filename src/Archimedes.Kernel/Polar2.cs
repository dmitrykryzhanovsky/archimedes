using System;

namespace Archimedes
{
    public class Polar2 : ICloneable
    {
        private readonly double _r;
        private readonly double _heading;

        public double R
        {
            get => _r;
        }

        public double Heading
        {
            get => _heading;
        }

        public static (EValid, EAngleValid) CheckValidity (double r, double heading)
        {
            EValid rValid = (r >= 0.0) ? EValid.Valid : EValid.Invalid;

            EAngleValid headingValid = ((-Math.PI < heading) && (heading <= Math.PI)) ? EAngleValid.Normalized : 
                                                                                        EAngleValid.NotNormalized;

            return (rValid, headingValid);
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