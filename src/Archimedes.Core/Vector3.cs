namespace Archimedes
{
    public class Vector3 : Vector, IEquatable<Vector3>
    {
        private const int V3Dimension = 3;

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
            get => V3Dimension;
        }

        #region Constructors

        public Vector3 (double x, double y, double z) : base (V3Dimension)
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

        public override bool Equals (object? obj)
        {
            return (obj is Vector3) ? Equals (obj as Vector3) :
                   (obj is Vector)  ? Equals (obj as Vector)  : base.Equals (obj);
        }

        public override int GetHashCode ()
        {
            return base.GetHashCode ();
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

        #region Operators

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

        public static double operator * (Vector3 v1, Vector3 v2)
        {
            return DotProduct (v1, v2);
        }

        #endregion

        public static double DotProduct (Vector3 v1, Vector3 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        /// <summary>
        /// Возвращает векторное произведение векторов v1 и v2.
        /// </summary>
        public static Vector3 CrossProduct (Vector3 v1, Vector3 v2)
        {
            return new Vector3 (v1.Y * v2.Z - v2.Y * v1.Z,
                                v1.Z * v2.X - v2.Z * v1.X,
                                v1.X * v2.Y - v2.X * v1.Y);
        }

        public override double GetNorm2 ()
        {
            return DotProduct (this, this);
        }

        /// <summary>
        /// Возвращает полярные координаты, соответствующие данному вектору декартовых координат.
        /// </summary>
        public Polar3 GetPolar ()
        {
            (double r, double latitude, double longitude) = Space3.GetPolarCoordinates (X, Y, Z);

            return Polar3.CreateUnsafe (r, latitude, longitude);
        }
    }
}