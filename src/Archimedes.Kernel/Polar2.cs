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
                if (value < 0.0) throw new ArgumentOutOfRangeException ();

                _r = value;
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

        public Polar2 (Polar2 other) : this ()
        {
            InitDirect (other._r, other._heading);
        }

        public object Clone ()
        {
            return new Polar2 (this);
        }

        public static Polar2 CreateDirect (double r, double heading)
        {
            Polar2 result = new Polar2 ();

            result.InitDirect (r, heading);

            return result;
        }

        private void InitDirect (double r, double heading)
        {
            _r       = r;
            _heading = heading;
        }

        public bool Equals (Polar2? other)
        {
            return ((_r == other._r) && ((Trigonometry.AreEqualAngles (_heading, other.Heading)) || (_r == 0.0)));
        }

        public static bool operator == (Polar2 p1, Polar2 p2)
        {
            return p1.Equals (p2);
        }

        public static bool operator != (Polar2 p1, Polar2 p2)
        {
            return !p1.Equals (p2);
        }

        public override bool Equals (object? obj)
        {
            return Equals (obj as Polar2);
        }

        public override int GetHashCode ()
        {
            return (new double [] { _r, _heading }).GetHashCode ();
        }

        public void Normalize ()
        {
            if (_r > 0.0) Trigonometry.NormalizeAngle (_heading);

            else _heading = 0.0;
        }

        public Vector2 ToCartesian ()
        {
            if (_r > 0.0)
            {
                if ((_heading == 0.0) || (_heading == double.Tau)) return new Vector2 (_r, 0.0);
                else if (_heading == MathConst.M_PI_2) return new Vector2 (0.0, _r);
                else if ((_heading == double.Pi) || (_heading == -double.Pi)) return new Vector2 (-_r, 0.0);
                else if ((_heading == -MathConst.M_PI_2) || (_heading == 3.0 * MathConst.M_PI_2)) return new Vector2 (0.0, -_r);

                (double sin, double cos) = double.SinCos (_heading);

                return new Vector2 (_r * cos, _r * sin);
            }

            else return new Vector2 (0.0, 0.0);
        }
    }
}