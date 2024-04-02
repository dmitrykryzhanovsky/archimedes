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

                else throw new ArgumentOutOfRangeException ();
            }
        }

        public double Heading
        {
            get => _heading;
            set => _heading = value;
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

        public override bool Equals (object? obj)
        {
            if (obj is Polar2) return Equals (obj as Polar2);

            else return base.Equals (obj);
        }

        public bool Equals (Polar2? other)
        {
            return ((_r == other._r) &&
                    (Trigonometry.AreNormalizedAnglesEqual (_heading, other._heading)));
        }

        public static bool operator == (Polar2 p1, Polar2 p2)
        {
            return p1.Equals (p2);
        }

        public static bool operator != (Polar2 p1, Polar2 p2)
        {
            return p1.Equals (p2);
        }
    }
}