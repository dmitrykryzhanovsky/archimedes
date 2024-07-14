namespace Archimedes
{
    public class Polar2 : ICloneable, IEquatable<Polar2>
    {
        private double _r;

        private double _heading;

        public double R
        {
            get
            {
                return _r;
            }

            set
            {
                if (value >= 0.0) _r = value;

                else throw new ArgumentOutOfRangeException (nameof(value));
            }
        }

        public double Heading
        {
            get => _heading;

            set => _heading = value;
        }

        private Polar2 ()
        {
        }

        public Polar2 (double r, double heading)
        {
            R       = r;
            Heading = heading;
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

        internal static Polar2 DirectInit (double r, double heading)
        {
            Polar2 result = new Polar2 ();

            result._r       = r;
            result._heading = heading;

            return result;
        }

        public bool Equals (Polar2? other)
        {
            if (_r == other._r)
            {
                if (Trigonometry.AreEqualAngles (_heading, other._heading)) return true;

                else return (_r == 0.0);
            }

            else return false;
        }

        public static bool operator == (Polar2 p1, Polar2 p2)
        {
            return p1.Equals (p2);
        }

        public static bool operator != (Polar2 p1, Polar2 p2)
        {
            return !p1.Equals (p2);
        }

        public void Normalize ()
        {
            Trigonometry.NormalizeAngle (_heading);
        }

        public Vector2 ToCartesian ()
        {
            (double sin, double cos) = double.SinCos (_heading);

            return new Vector2 (x: _r * cos, y: _r * sin);
        }
    }
}