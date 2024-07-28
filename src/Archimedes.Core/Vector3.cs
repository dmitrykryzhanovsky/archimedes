namespace Archimedes
{
    public class Vector3: Vector, IEquatable<Vector3>
    {
        private const int ThisTypeDimension = 3;

        public double X
        {
            get => _x [0];

            set => _x [0] = value;
        }

        public double Y
        {
            get => _x [1];

            set => _x [1] = value;
        }

        public double Z
        {
            get => _x [2];

            set => _x [2] = value;
        }

        public override int Dimension
        {
            get => ThisTypeDimension;
        }

        #region Constructors

        public Vector3 (double x, double y, double z) : base (ThisTypeDimension)
        {
            _x [0] = x;
            _x [1] = y;
            _x [2] = z;
        }

        public Vector3 (Vector3 other) : this (other.X, other.Y, other.Z)
        {
        }

        public override object Clone ()
        {
            return new Vector3 (this);
        }

        #endregion

        #region Comparison

        public bool Equals (Vector3? other)
        {
            return ((X == other.X) && (Y == other.Y) && (Z == other.Z));
        }

        public static bool operator == (Vector3 v1, Vector3 v2)
        {
            return v1.Equals (v2);
        }

        public static bool operator != (Vector3 v1, Vector3 v2)
        {
            return !v1.Equals (v2);
        }

        #endregion

        public override double GetNorm2 ()
        {
            return X * X + Y * Y + Z * Z;
        }

        /// <summary>
        /// Преобразует текущий вектор к полярным координатам.
        /// </summary>
        public Polar3 ToPolar ()
        {
            double xoy = double.Hypot (X, Y);

            return Polar3.DirectInit (r: GetLength (),
               latitude: double.Atan2 (Z, xoy),
               longitude: double.Atan2 (Y, X));
        }

        ///// <summary>
        ///// Поворот текущего вектора на угол <paramref name="angle"/>. Координаты после поворота записываются в текущий объект.
        ///// </summary>
        //public void RotateThis (double angle)
        //{
        //    (double sin, double cos) = double.SinCos (angle);

        //    RotateThis (sin, cos);
        //}

        ///// <summary>
        ///// Поворот текущего вектора на угол, заданный синусом <paramref name="sin"/> и косинусом <paramref name="cos"/>. Координаты после 
        ///// поворота записываются в текущий объект.
        ///// </summary>
        ///// <remarks>В методе не производится проверка на соответствие синуса <paramref name="sin"/> и косинуса <paramref name="cos"/> 
        ///// основному тригонометрическому тождеству.</remarks>
        //public void RotateThis (double sin, double cos)
        //{
        //    (_x [0], _x [1]) = Euclidean2Formulae.RotateVector (sin, cos, _x [0], _x [1]);
        //}

        ///// <summary>
        ///// Поворот вектора на угол <paramref name="angle"/>. Координаты после поворота записываются в возвращаемый объект.
        ///// </summary>
        //public Vector2 Rotate (double angle)
        //{
        //    (double sin, double cos) = double.SinCos (angle);

        //    return Rotate (sin, cos);
        //}

        ///// <summary>
        ///// Поворот вектора на угол, заданный синусом <paramref name="sin"/> и косинусом <paramref name="cos"/>. Координаты после поворота 
        ///// записываются в возвращаемый объект.
        ///// </summary>
        ///// <remarks>В методе не производится проверка на соответствие синуса <paramref name="sin"/> и косинуса <paramref name="cos"/> 
        ///// основному тригонометрическому тождеству.</remarks>
        //public Vector2 Rotate (double sin, double cos)
        //{
        //    (double rotatedX, double rotatedY) = Euclidean2Formulae.RotateVector (sin, cos, _x [0], _x [1]);

        //    return new Vector2 (rotatedX, rotatedY);
        //}
    }
}