namespace Archimedes
{
    public class Polar2 : ICloneable
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
                CheckR (value);

                _r = value;
            }
        }

        public double Heading
        {
            get => _heading;

            set => _heading = value;
        }

        public Polar2 (double r, double heading)
        {
            CheckR (r);

            Init (r, heading);
        }

        public Polar2 (Polar2 other)
        {
            Init (other._r, other._heading);
        }

        public object Clone ()
        {
            return new Polar2 (this);
        }

        private static void CheckR (double r)
        {
            if (r < 0.0) throw new ArgumentOutOfRangeException (nameof (r));
        }

        private void Init (double r, double heading)
        {
            _r       = r;
            _heading = heading;
        }        
    }
}