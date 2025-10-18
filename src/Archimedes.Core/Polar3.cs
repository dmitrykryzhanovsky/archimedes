namespace Archimedes
{
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
                Space.CheckR (value);

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
                Space3.CheckLatitude (value);

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

        #region Сonstructors

        private Polar3 ()
        {
        }

        public Polar3 (double r, double latitude, double longitude)
        {
            Space.CheckR (r);
            Space3.CheckLatitude (latitude);

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

        internal static Polar3 CreateUnsafe (double r, double latitude, double longitude)
        {
            Polar3 p = new Polar3 ();

            p.Init (r, latitude, longitude);

            return p;
        }

        private void Init (double r, double latitude, double longitude)
        {
            _r    = r;
            _lat  = latitude;
            _long = longitude;
        }

        #endregion

        #region Сomparison

        public bool Equals (Polar3? other)
        {
            return ((_r == other._r) && (_lat == other._lat) && (Trigonometry.AreEqualPhaseInRad (_long, other._long)));
        }

        public override bool Equals (object? obj)
        {
            return (obj is Polar3) ? Equals (obj as Polar3) : base.Equals (obj);
        }

        public override int GetHashCode ()
        {
            return (new double [] { _r, _lat, _long }).GetHashCode ();
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
        /// Возвращает вектор декартовых координат, соответствующих данным полярным координатам.
        /// </summary>
        public Vector3 GetCartesian ()
        {
            (double x, double y, double z) = Space3.GetCartesianCoordinates (_r, _lat, _long);

            return new Vector3 (x, y, z);
        }
    }
}