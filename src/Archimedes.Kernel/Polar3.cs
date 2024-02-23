namespace Archimedes
{
    public class Polar3 : ICloneable, IEquatable<Polar3>
    {
        private double _r;
        private double _theta;
        private double _l;

        private double _sinB; 
        private double _cosB;
        private double _sinL;
        private double _cosL;

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

        public double Theta
        {
            get
            {
                return _theta;
            }

            set
            {
                if ((-MatConst.M_PI_2 <= _theta) && (_theta <= MatConst.M_PI_2))
                {
                    _theta = value;
                    (_sinB, _cosB) = double.SinCos (_theta);
                }

                else throw new ArgumentOutOfRangeException ();
            }
        }

        public double L
        {
            get
            {
                return _l;
            }

            set
            {
                _l = value;
                (_sinL, _cosL) = double.SinCos (_l);
            }
        }

        private Polar3 ()
        {
        }

        public Polar3 (double r, double theta, double l)
        {
            R     = r;
            Theta = theta;
            L     = l;
        }

        public Polar3 (Polar3 other)
        {
            _r     = other._r;
            _theta = other._theta;
            _l     = other._l;

            _sinB = other._sinB;
            _cosB = other._cosB;
            _sinL = other._sinL;
            _cosL = other._cosL;
        }

        public object Clone ()
        {
            return new Polar3 (this);
        }

        internal static Polar3 Init (double r, double theta, double l, double sinB, double cosB, double sinL, double cosL)
        {
            Polar3 p = new Polar3 ();

            p._r     = r;
            p._theta = theta;
            p._l     = l;

            p._sinB = sinB;
            p._cosB = cosB;
            p._sinL = sinL;
            p._cosL = cosL;

            return p;
        }

        public override bool Equals (object? obj)
        {
            if (obj is Polar3) return Equals (obj as Polar3);

            else return base.Equals (obj);
        }

        public bool Equals (Polar3? other)
        {
            return ((_r == other._r) &&
                    (_theta == other._theta) &&
                    (Trigonometry.AreNormalizedAnglesEqual (_l, other._l)));
        }

        public static bool operator == (Polar3 p1, Polar3 p2)
        {
            return p1.Equals (p2);
        }

        public static bool operator != (Polar3 p1, Polar3 p2)
        {
            return p1.Equals (p2);
        }

        public static Polar3 RotateAroundOX (Polar3 p, double phi)
        {
            (double sin, double cos) = double.SinCos (phi);

            return RotateAroundOX (p, sin, cos);
        }

        public static Polar3 RotateAroundOX (Polar3 p, double sin, double cos)
        {
            double r     = p._r;
            
            double sinB  = p._cosB * p._sinL * sin + p._sinB * cos;
            
            if ((-ComputingSettings.ZeroAccuracy <= sinB) && (sinB <= ComputingSettings.ZeroAccuracy)) sinB = 0.0;
            else if ((1.0 - sinB) <= ComputingSettings.ZeroAccuracy) sinB =  1.0;
            else if ((sinB + 1.0) <= ComputingSettings.ZeroAccuracy) sinB = -1.0;

            double cosB  = double.Sqrt (1.0 - sinB * sinB);
            double theta = double.Asin (sinB);

            double sinL  = (p._cosB * p._sinL * cos - p._sinB * sin) / cosB;
            double cosL  = p._cosB * p._cosL / cosB;
            
            if ((-ComputingSettings.ZeroAccuracy <= sinL) && (sinL <= ComputingSettings.ZeroAccuracy)) sinL = 0.0;
            if ((-ComputingSettings.ZeroAccuracy <= cosL) && (cosL <= ComputingSettings.ZeroAccuracy)) cosL = 0.0;

            double l     = double.Atan2 (sinL, cosL);

            return Init (r, theta, l, sinB, cosB, sinL, cosL);
        }

        public Vector3 ToCartesian ()
        {
            double x = _r * _cosB * _cosL;
            double y = _r * _cosB * _sinL;
            double z = _r * _sinB;

            return new Vector3 (x, y, z);
        }
    }
}