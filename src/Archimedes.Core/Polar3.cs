namespace Archimedes
{
    /// <summary>
    /// Полярные (сферические) координаты в 3-мерном пространстве.
    /// </summary>
    public class Polar3 : ICloneable, IEquatable<Polar3>
    {
        private double _r;
        private double _lat;
        private double _long;

        /// <summary>
        /// Полярный радиус.
        /// </summary>
        /// <remarks>Должен быть большим или равным 0.</remarks>
        /// <exception cref="ArgumentOutOfRangeException">Генерируется при попытке установить значение полярного радиуса меньше 0.</exception>
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

        /// <summary>
        /// Широта.
        /// </summary>
        /// <remarks>Должна быть на отрезке [-π/2; +π/2].</remarks>
        /// <exception cref="ArgumentOutOfRangeException">Генерируется при попытке установить значение широты меньше -π/2 или больше 
        /// +π/2.</exception>
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

        /// <summary>
        /// Долгота.
        /// </summary>
        /// <remarks>Может принимать любое значение в радианах. Контроль / нормализация к диапазонам [0; 2π) или [-π; +π] в данном 
        /// методе не производится.</remarks>
        public double Long
        {
            get => _long;

            set => _long = value;
        }

        #region constructors

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

        #endregion

        public bool Equals (Polar3? other)
        {
            double dRemainedr = double.Ieee754Remainder (_long - other._long, double.Tau);

            return ((_r == other._r) && (_lat == other._lat) && (dRemainedr == 0.0));
        }

        public static bool operator == (Polar3 p1, Polar3 p2)
        {
            return p1.Equals (p2);
        }

        public static bool operator != (Polar3 p1, Polar3 p2)
        {
            return !p1.Equals (p2);
        }
    }
}