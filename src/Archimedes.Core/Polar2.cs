namespace Archimedes
{
    /// <summary>
    /// Полярные координаты на плоскости.
    /// </summary>
    public class Polar2 : ICloneable, IEquatable<Polar2>
    {
        private double _r;

        private double _heading;

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
        /// Полярный угол.
        /// </summary>
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

        /// <summary>
        /// Прямая инициализация объекта без проверки корректности устанавливаемых значений.
        /// </summary>
        internal static Polar2 DirectInit (double r, double heading)
        {
            Polar2 result = new Polar2 ();

            result._r       = r;
            result._heading = heading;

            return result;
        }

        #endregion

        #region Comparison

        /// <summary>
        /// Две полярные координаты считаются равными друг другу, если выполняется какое-то из нижеперечисленных условий:
        /// <list type="bullet">
        /// <item>радиусы R равны, а полярные углы Heading равны с точностью до 2π;</item>
        /// <item>у обеих полярных координат радиусы R = 0 (вне зависимости от значений полярных углов Heading).</item>
        /// </list>
        /// </summary>
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

        /// <summary>
        /// Нормализация полярного угла Heading – приведение его к диапазону [−π; +π].
        /// </summary>
        public void Normalize ()
        {
            _heading = Trigonometry.NormalizeAngle (_heading);
        }

        /// <summary>
        /// Преобразует полярные координаты к декартовым.
        /// </summary>
        public Vector2 ToCartesian ()
        {
            (double sin, double cos) = double.SinCos (_heading);

            return new Vector2 (x: _r * cos, y: _r * sin);
        }
    }
}