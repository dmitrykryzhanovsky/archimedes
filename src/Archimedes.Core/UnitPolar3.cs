namespace Archimedes
{
    /// <summary>
    /// Единичный вектор в 3-мерном евклидовом пространстве, заданный полярными координатами.
    /// </summary>
    /// <remarks>В классе поддерживается сохранение значения радиального расстояния R = 1.</remarks>
    public class UnitPolar3 : Polar3
    {
        public override double R
        {
            // Перегрузка свойства базового класса нужна только для setter’а, чтобы запретить его использование и предотвратить изменение
            // значения радиального расстояния.
            set
            {
                throw new InvalidOperationException ();
            }
        }

        #region Constructors

        private UnitPolar3 () : base ()
        {
            _r = 1.0;
        }

        public UnitPolar3 (double latitude, double longitude) : this ()
        {
            Latitude  = latitude;
            Longitude = longitude;
        }

        public UnitPolar3 (UnitPolar3 other) : this ()
        {
            Init (other._lat, other._long);
        }

        public override object Clone ()
        {
            return new UnitPolar3 (this);
        }

        /// <summary>
        /// Прямая инициализация объекта. Использовать только в тех случаях, когда мы уверены, что в метод передаются корректные значения 
        /// инициализирующих параметров.
        /// </summary>
        /// <param name="latitude">Должно быть на отрезке [−π/2; + π/2].</param>
        internal static UnitPolar3 InitDirect (double latitude, double longitude)
        {
            UnitPolar3 p = new UnitPolar3 ();

            p.Init (latitude, longitude);

            return p;
        }

        private void Init (double latitude, double longitude)
        {
            _lat  = latitude;
            _long = longitude;
        }

        #endregion
    }
}