namespace Archimedes
{
    /// <summary>
    /// Полярные (сферические) координаты в 3-мерном евклидовом пространстве.
    /// </summary>
    public class Polar3 : ICloneable
    {
        protected double _r;
        protected double _lat;
        protected double _long;

        /// <summary>
        /// Радиальное расстояние.
        /// </summary>
        /// <remarks>Должно быть больше или равно 0.</remarks>
        public virtual double R
        {
            get => _r;

            set
            {
                if (value >= 0.0) _r = value;

                else throw new ArgumentOutOfRangeException ();
            }
        }

        /// <summary>
        /// Широта в радианах.
        /// </summary>
        /// <remarks>Должна быть на отрезке [−π/2; + π/2].</remarks>
        public double Latitude
        {
            get => _lat;

            set
            {
                if ((-MathConst.M_PI_2 <= value) && (value <= MathConst.M_PI_2)) _lat = value;

                else throw new ArgumentOutOfRangeException ();
            }
        }

        /// <summary>
        /// Долгота в радианах.
        /// </summary>
        public double Longitude
        {
            get => _long;

            set => _long = value;
        }

        #region Constructors

        public Polar3 (double r, double latitude, double longitude)
        {
            R         = r;
            Latitude  = latitude;
            Longitude = longitude;
        }

        public Polar3 (Polar3 other)
        {
            Init (other._r, other._lat, other._long);
        }

        public virtual object Clone ()
        {
            return new Polar3 (this);
        }

        /// <summary>
        /// Прямая инициализация объекта. Использовать только в тех случаях, когда мы уверены, что в метод передаются корректные значения 
        /// инициализирующих параметров.
        /// </summary>
        /// <param name="r">Должно быть больше или равно 0.</param>
        /// <param name="latitude">Должно быть на отрезке [−π/2; + π/2].</param>
        internal static Polar3 InitDirect (double r, double latitude, double longitude)
        {
            Polar3 p = new Polar3 ();

            p.Init (r, latitude, longitude);

            return p;
        }

        protected Polar3 ()
        {
        }

        private void Init (double r, double latitude, double longitude)
        {
            _r    = r;
            _lat  = latitude;
            _long = longitude;
        }

        #endregion
    }
}