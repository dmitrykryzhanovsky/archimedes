namespace Archimedes
{
    /// <summary>
    /// Полярные координаты на плоскости.
    /// </summary>
    public class Polar2 : ICloneable
    {
        private double _r;
        private double _heading;

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
        /// Полярный угол.
        /// </summary>
        /// <remarks>Может принимать любое значение в радианах. Контроль / нормализация к диапазонам [0; 2π) или [-π; +π] в данном 
        /// методе не производится.</remarks>
        public double Heading
        {
            get => _heading;

            set => _heading = value;
        }

        #region constructors

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

        #endregion
    }
}