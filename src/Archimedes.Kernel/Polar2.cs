namespace Archimedes
{
    public class Polar2 : ICloneable, IEquatable<Polar2>
    {
        private double _r;

        private double _heading;

        public double R
        {
            get => _r;

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

        #region Constructors

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
            Polar2 output = new Polar2 ();

            output._r       = r;
            output._heading = heading;

            return output;
        }

        #endregion

        #region Comparisons

        public bool Equals (Polar2? other)
        {
            return ((_r == other._r) && ((Trigonometry.AreEqualAngles (_heading, other._heading)) || 
                                         (_r == 0.0)));
        }

        public static bool operator == (Polar2 p1, Polar2 p2)
        {
            return p1.Equals (p2);
        }

        public static bool operator != (Polar2 p1, Polar2 p2)
        {
            return !p1.Equals (p2);
        }

        #endregion

        public Vector2 ToCartesian ()
        {
            (double sin, double cos) = double.SinCos (_heading);

            return new Vector2 (x: _r * cos, 
                                y: _r * sin);
        }        
    }
}