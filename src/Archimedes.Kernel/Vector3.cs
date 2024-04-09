namespace Archimedes
{
    public class Vector3 : Vector, IEquatable<Vector3>
    {
        private const int Size = 3;

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
            get => Size;
        }

        public Vector3 (double x, double y, double z) : base (Size)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3 (double [] x) : this (x [0], x [1], x [2])
        {
        }

        public Vector3 (Vector3 other) : this (other._x)
        {
        }

        public override object Clone ()
        {
            return new Vector3 (this);
        }

        public bool Equals (Vector3? other)
        {
            return ((X == other.X) &&
                    (Y == other.Y) &&
                    (Z == other.Z));
        }

        public static bool operator == (Vector3 v1, Vector3 v2)
        {
            return v1.Equals (v2);
        }

        public static bool operator != (Vector3 v1, Vector3 v2)
        {
            return !v1.Equals (v2);
        }

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
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        public override double GetNorm2 ()
        {
            return X * X + Y * Y + Z * Z;
        }
    }
}