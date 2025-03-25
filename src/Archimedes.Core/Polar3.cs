namespace Archimedes
{
    public class Polar3 : ICloneable
    {
        private double _r;
        private double _lat;
        private double _long;

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

        public double Lat
        {
            get
            {
                return _lat;
            }

            set
            {
                CheckLatitude (value);

                _lat = value;
            }
        }

        public double Long
        {
            get => _long;

            set => _long = value;
        }

        public Polar3 (double r, double latitude, double longitude)
        {
            CheckR (r);
            CheckLatitude (latitude);

            Init (r, latitude, longitude);
        }

        public Polar3 (Polar3 other)
        {
            Init (other._r, other._lat, other._long);
        }

        public object Clone ()
        {
            return new Polar3 (this);
        }

        private static void CheckR (double r)
        {
            if (r < 0.0) throw new ArgumentOutOfRangeException (nameof (r));
        }

        private static void CheckLatitude (double latitude)
        {
            if ((latitude < -MathConst.Pi_2) || (latitude > MathConst.Pi_2)) throw new ArgumentOutOfRangeException (nameof (latitude));
        }

        private void Init (double r, double latitude, double longitude)
        {
            _r    = r;
            _lat  = latitude;
            _long = longitude;
        }        
    }
}