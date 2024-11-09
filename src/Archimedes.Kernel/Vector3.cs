namespace Archimedes
{
    public class Vector3 : Vector, IEquatable<Vector3>
    {
        private const int Vector3Dimension = 3;

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
            get => Vector3Dimension;
        }

        #region Constructors

        public Vector3 (double x, double y, double z) : base (Vector3Dimension)
        {
            _x [0] = x;
            _x [1] = y;
            _x [2] = z;
        }

        public Vector3 (double [] array) : base (array [0], array [1], array [2])
        {
        }

        public Vector3 (Vector3 other) : this (other._x)
        {
        }

        public override object Clone ()
        {
            return new Vector3 (this);
        }

        #endregion

        #region Comparisons

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

        public static Vector3 operator + (Vector3 v1, Vector3 v2)
        {
            return new Vector3 (v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector3 operator - (Vector3 v1, Vector3 v2)
        {
            return new Vector3 (v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector3 operator - (Vector3 v)
        {
            return new Vector3 (-v.X, -v.Y, -v.Z);
        }

        public static Vector3 operator * (Vector3 v, double coefficient)
        {
            return new Vector3 (v.X * coefficient, v.Y * coefficient, v.Z * coefficient);
        }

        public static Vector3 operator * (double coefficient, Vector3 v)
        {
            return v * coefficient;
        }

        public static Vector3 operator / (Vector3 v, double coefficient)
        {
            return new Vector3 (v.X / coefficient, v.Y / coefficient, v.Z / coefficient);
        }

        /// <summary>
        /// Возвращает скалярное произведение векторов.
        /// </summary>
        public static double operator * (Vector3 v1, Vector3 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        /// <summary>
        /// Возвращает векторное произведение векторов в правом базисе.
        /// </summary>
        public static Vector3 CrossProduct (Vector3 v1, Vector3 v2)
        {
            return new Vector3 (v1.Y * v2.Z - v1.Z * v2.Y,
                                v1.Z * v2.X - v1.X * v2.Z,
                                v1.X * v2.Y - v1.Y * v2.X);
        }

        /// <summary>
        /// Возвращает квадрат нормы вектора.
        /// </summary>
        public override double GetNorm2 ()
        {
            return X * X + Y * Y + Z * Z;
        }

        /// <summary>
        /// Возвращает единичный вектор, сонаправленный данному.
        /// </summary>
        public new Vector3 GetUnit ()
        {
            double length = GetLength ();

            return this / length;
        }

        public Vector3 RotateAroundOX (double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            return RotateAroundOX (sin, cos);
        }

        public Vector3 RotateAroundOX (double sin, double cos)
        {
            return new Vector3 (X,
                                Y * cos - Z * sin,
                                Y * sin + Z * cos);
        }

        public Vector3 RotateAroundOY (double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            return RotateAroundOY (sin, cos);
        }

        public Vector3 RotateAroundOY (double sin, double cos)
        {
            return new Vector3 ( X * cos + Z * sin,
                                 Y,
                                -X * sin + Z * cos);
        }

        public Vector3 RotateAroundOZ (double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            return RotateAroundOZ (sin, cos);
        }

        public Vector3 RotateAroundOZ (double sin, double cos)
        {
            return new Vector3 (X * cos - Y * sin,
                                X * sin + Y * cos,
                                Z);
        }

        public Vector3 Rotate (Matrix3 rotationMatrix)
        {
            return rotationMatrix * this;
        }

        public Vector3 Rotate (double angle, Vector3 axis)
        {
            (Quaternion rotating, Quaternion reciprocal) = Rotation3.GetRotationQuaternionsForVector (angle, axis);

            return Rotate (rotating, reciprocal);
        }

        public Vector3 Rotate (double sin, double cos, Vector3 u)
        {
            (Quaternion rotating, Quaternion reciprocal) = Rotation3.GetRotationQuaternionsForVector (sin, cos, u);

            return Rotate (rotating, reciprocal);
        }

        public Vector3 Rotate (Quaternion rotating, Quaternion reciprocal)
        {
            return (rotating * this * reciprocal).U;
        }

        /// <summary>
        /// Преобразование из декартовых координат в полярные.
        /// </summary>
        public Polar3 ToPolar ()
        {
            return Polar3.DirectInit (r: GetLength (), 
                latitude:  double.Atan2 (Z, double.Hypot (X, Y)), 
                longitude: double.Atan2 (Y, X));
        }
    }
}