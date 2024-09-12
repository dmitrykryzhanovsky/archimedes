namespace Archimedes
{
    /// <summary>
    /// Полярные координаты на плоскости.
    /// </summary>
    public class Polar2 : ICloneable, IEquatable<Polar2>
    {
        protected double _r;

        protected double _heading;

        /// <summary>
        /// Длина (радиус).
        /// </summary>
        /// <remarks>Должен быть положительным или равным 0. При попытке установить отрицательное значение будет сгенерировано 
        /// исключение.</remarks>
        public double R
        {
            get
            {
                return _r;
            }

            set
            {
                if (value < 0.0) throw new ArgumentOutOfRangeException ();

                _r = value;
            }
        }

        /// <summary>
        /// Полярный угол.
        /// </summary>
        /// <remarks>На значение полярного угла не накладывается ограничений. Он может быть и меньше −π, и больше +π, и находиться в 
        /// основном диапазоне от −π до +π.</remarks>
        public double Heading
        {
            get => _heading;

            set => _heading = value;
        }

        #region Constructors

        /// <summary>
        /// Пустой конструктор. Нужен для создания объекта при последующей прямой инициализации (без проверки допустимости значений).
        /// </summary>
        protected Polar2 ()
        {
        }

        /// <summary>
        /// В данном конструкторе производится проверка допустимости передаваемых значений. Если радиус r отрицательный, будет 
        /// сгенерировано исключение.
        /// </summary>
        public Polar2 (double r, double heading)
        {
            R       = r;
            Heading = heading;
        }

        public Polar2 (Polar2 other) : this ()
        {
            InitDirect (other._r, other._heading);
        }

        public object Clone ()
        {
            return new Polar2 (this);
        }

        /// <summary>
        /// Создаёт объект прямой инициализацией, без проверки допустимости значений.
        /// </summary>
        public static Polar2 CreateDirect (double r, double heading)
        {
            Polar2 result = new Polar2 ();

            result.InitDirect (r, heading);

            return result;
        }

        private void InitDirect (double r, double heading)
        {
            _r       = r;
            _heading = heading;
        }

        #endregion

        #region Comparisons

        public bool Equals (Polar2? other)
        {
            return ((_r == other._r) && ((Trigonometry.AreEqualAngles (_heading, other.Heading)) || (_r == 0.0)));
        }

        public static bool operator == (Polar2 p1, Polar2 p2)
        {
            return p1.Equals (p2);
        }

        public static bool operator != (Polar2 p1, Polar2 p2)
        {
            return !p1.Equals (p2);
        }

        public override bool Equals (object? obj)
        {
            return Equals (obj as Polar2);
        }

        public override int GetHashCode ()
        {
            return (new double [] { _r, _heading }).GetHashCode ();
        }

        #endregion

        /// <summary>
        /// Нормализация полярных координат: 
        /// <list type="bullet"><item>для радиуса больше 0 приводит полярный угол в диапазон [−π; +π];</item>
        /// <item>для радиуса равного 0 устанавливает полярный угол тоже равным 0.</item>
        /// </list></summary>
        public void Normalize ()
        {
            if (_r > 0.0) _heading = Trigonometry.NormalizeAngle (_heading);

            else _heading = 0.0;
        }

        /// <summary>
        /// Преобразование из полярных координат в декартовы.
        /// </summary>
        /// <remarks>В методе производится проверка на особые случаи – равенство радиуса 0 или равенство полярного угла 0, ±π/2, ±π, 
        /// 2π, – чтобы для них значения синуса и косинуса сохранялись строго равными 0 и ±1, без ошибок округления.</remarks>
        public Vector2 ToCartesian ()
        {
            if (_r > 0.0)
            {
                if ((_heading == 0.0) || (_heading == double.Tau)) return new Vector2 (_r, 0.0);
                else if (_heading == MathConst.M_PI_2) return new Vector2 (0.0, _r);
                else if ((_heading == double.Pi) || (_heading == -double.Pi)) return new Vector2 (-_r, 0.0);
                else if ((_heading == -MathConst.M_PI_2) || (_heading == 3.0 * MathConst.M_PI_2)) return new Vector2 (0.0, -_r);

                (double sin, double cos) = double.SinCos (_heading);

                return new Vector2 (_r * cos, _r * sin);
            }

            else return new Vector2 (0.0, 0.0);
        }
    }
}