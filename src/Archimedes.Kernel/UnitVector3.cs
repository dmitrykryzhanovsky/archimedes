namespace Archimedes
{
    public class UnitVector3 : Vector3
    {
        private UnitVector3 () : base ()
        {
        }

        public UnitVector3 (double x, double y, double z) : base ()
        {
            double hypot = double.Sqrt (x * x + y * y + z * z);

            _x [0] = x / hypot;
            _x [1] = y / hypot;
            _x [2] = z / hypot;
        }

        public static UnitVector3 CreateDirect (double x, double y, double z)
        {
            UnitVector3 result = new UnitVector3 ();

            result.X = x;
            result.Y = y;
            result.Z = z;

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

        ///// <summary>
        ///// Преобразование из декартовых координат в полярные.
        ///// </summary>
        //public Polar2 ToPolar ()
        //{
        //    return Polar2.CreateDirect (1.0, double.Atan2 (Y, X));
        //}
    }
}