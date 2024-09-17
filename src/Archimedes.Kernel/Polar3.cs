namespace Archimedes
{
    public class Polar3 : ICloneable, IEquatable<Polar3>
    {
        private double _r;

        private double _latitude;

        private double _longitude;

        /// <summary>
        /// Расстояние от начала координат.
        /// </summary>
        /// <remarks>Должно быть больше или равно 0.</remarks>
        public double R
        {
            get => _r;

            set
            {
                if (value >= 0.0) _r = value;

                else throw new ArgumentOutOfRangeException ();
            }
        }

        /// <summary>
        /// Широта.
        /// </summary>
        /// <remarks>Должна быть на отрезке [−π/2; + π/2].</remarks>
        public double Latitide
        {
            get => _latitude;

            set
            {
                if ((-MathConst.M_PI_2 <= _latitude) && (Latitide <= MathConst.M_PI_2)) _latitude = value;

                else throw new ArgumentOutOfRangeException ();
            }
        }

        /// <summary>
        /// Долгота.
        /// </summary>
        public double Longitude
        {
            get => _longitude;

            set => _longitude = value;
        }

        #region Constructors

        private Polar3 ()
        {
        }

        public Polar3 (double r, double latitude, double longitude)
        {
            R         = r;
            Latitide  = latitude;
            Longitude = longitude;
        }

        public Polar3 (Polar3 other)
        {
            _r         = other._r;
            _latitude  = other._latitude;
            _longitude = other._longitude;
        }

        public object Clone ()
        {
            return new Polar3 (this);
        }

        internal static Polar3 DirectInit (double r, double latitude, double longitude)
        {
            Polar3 output = new Polar3 ();

            output._r         = r;
            output._latitude  = latitude;
            output._longitude = longitude;

            return output;
        }

        #endregion

        #region Comparisons

        public bool Equals (Polar3? other)
        {
            //return ((_r == other._r) && ((Trigonometry.AreEqualAngles (_heading, other._heading)) ||
            //                             (_r == 0.0)));
        }

        public static bool operator == (Polar3 p1, Polar3 p2)
        {
            return p1.Equals (p2);
        }

        public static bool operator != (Polar3 p1, Polar3 p2)
        {
            return !p1.Equals (p2);
        }

        #endregion

        /// <summary>
        /// Преобразование из полярных координат в декартовы.
        /// </summary>
        public Vector3 ToCartesian ()
        {
            (double sinB, double cosB) = double.SinCos (_latitude);
            (double sinL, double cosL) = double.SinCos (_longitude);

            double oxyProjection = _r * cosB;

            return new Vector3 (x: oxyProjection * cosL,
                                y: oxyProjection * sinL, 
                                z: _r * sinB);
        }
    }
}