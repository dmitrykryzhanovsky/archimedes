namespace Archimedes
{
    /// <summary>
    /// Полярные координаты в 3-мерном пространстве.
    /// </summary>
    public class Polar3 : ICloneable, IEquatable<Polar3>
    {
        private double _r;

        private double _b;

        private double _l;

        /// <summary>
        /// Радиус.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">При присваивании радиуса происходит проверка: если присваиваемое значение < 
        /// 0, генерируется исключение.</exception>
        public double R
        {
            get
            {
                return _r;
            }

            set
            {
                if (value >= 0.0) _r = value;

                else throw new ArgumentOutOfRangeException (nameof(value));
            }
        }

        /// <summary>
        /// Широта.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">При присваивании широты происходит проверка: если присваиваемое значение < 
        /// −π/2 или > +π/2, генерируется исключение.</exception>
        public double Latitude
        {
            get
            {
                return _b;
            }

            set
            {
                if ((-MathConst.M_PI_2 <= value) && (value <= MathConst.M_PI_2)) _b = value;

                else throw new ArgumentOutOfRangeException (nameof (value));
            }
        }

        /// <summary>
        /// Долгота.
        /// </summary>
        public double Longitude
        {
            get => _l;

            set => _l = value;
        }

        #region Constructors

        private Polar3 ()
        {
        }

        public Polar3 (double r, double latitude, double longitude)
        {
            R         = r;
            Latitude  = latitude;
            Longitude = longitude;
        }

        public Polar3 (Polar3 other)
        {
            _r = other._r;
            _b = other._b;
            _l = other._l;
        }

        public object Clone ()
        {
            return new Polar3 (this);
        }

        /// <summary>
        /// Прямая инициализация объекта без проверки корректности устанавливаемых значений.
        /// </summary>
        internal static Polar3 DirectInit (double r, double latitude, double longitude)
        {
            Polar3 result = new Polar3 ();

            result._r = r;
            result._b = latitude;
            result._l = longitude;

            return result;
        }

        #endregion

        #region Comparison

        /// <summary>
        /// Две полярные координаты считаются равными друг другу, если выполняется какое-то из нижеперечисленных условий:
        /// <list type="bullet">
        /// <item>радиусы R и широты Latitude равны, а долготы Longitude равны с точностью до 2π;</item>
        /// <item>радиусы R и широты Latitude равны, причём значения Latitude соответствуют или +90°, или −90° (вне зависимости от 
        /// значений долгот Longitude);</item>
        /// <item>у обеих полярных координат радиусы R = 0 (вне зависимости от значений широт Latitude и долгот Longitude).</item>
        /// </list>
        /// </summary>
        public bool Equals (Polar3? other)
        {
            return ((_r == other._r) && ((_b == other._b) && ((Trigonometry.AreEqualAngles (_l, other._l)) || 
                                                             ((_b == MathConst.M_PI_2) || (_b == -MathConst.M_PI_2)))) ||
                                        (_r == 0.0));
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
        /// Нормализация долготы Longitude – приведение её к диапазону [−π; +π].
        /// </summary>
        public void Normalize ()
        {
            _l = Trigonometry.NormalizeAngle (_l);
        }

        /// <summary>
        /// Преобразует полярные координаты к декартовым.
        /// </summary>
        public Vector3 ToCartesian ()
        {
            (double sinB, double cosB) = double.SinCos (_b);
            (double sinL, double cosL) = double.SinCos (_l);

            return new Vector3 (x: _r * cosB * cosL, y: _r * cosB * sinL, z: _r * sinB);
        }
    }
}