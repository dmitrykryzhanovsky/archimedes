namespace Archimedes
{
    public class UnitVector2 : Vector2
    {
        private UnitVector2 () : base ()
        {
        }

        public UnitVector2 (double x, double y) : base ()
        {
            double hypot = double.Hypot (x, y);

            _x [0] = x / hypot;
            _x [1] = y / hypot;
        }

        public static UnitVector2 CreateDirect (double x, double y)
        {
            UnitVector2 result = new UnitVector2 ();

            result.X = x;
            result.Y = y;

            return result;
        }

        /// <summary>
        /// Возвращает длину вектора.
        /// </summary>
        public override double GetLength ()
        {
            return 1.0;
        }

        /// <summary>
        /// Возвращает квадрат длины вектора.
        /// </summary>
        public override double GetNorm2 ()
        {
            return 1.0;
        }

        /// <summary>
        /// Преобразование из декартовых координат в полярные.
        /// </summary>
        public new UnitPolar2 ToPolar ()
        {
            return new UnitPolar2 (double.Atan2 (Y, X));
        }
    }
}