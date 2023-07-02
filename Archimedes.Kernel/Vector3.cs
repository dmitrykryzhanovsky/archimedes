using System;

namespace Archimedes
{
    /// <summary>
    /// 3-мерный вектор на евклидовой плоскости.
    /// </summary>
    public class Vector3 : Vector, IEquatable<Vector3>, IDotProductable<Vector3>
    {
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

        private Vector3 () : base (3)
        {
        }

        public Vector3 (double x, double y, double z) : this ()
        {
            _x [0] = x;
            _x [1] = y;
            _x [2] = z;
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
            return ((X == other.X) && (Y == other.Y) && (Z == other.Z));
        }

        public override bool Equals (object? obj)
        {
            if (obj is Vector3) return Equals ((Vector3)obj);
            else return base.Equals (obj);
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
            return v1.DotProduct (v2);
        }

        /// <summary>
        /// Скалярное произведение текущего вектора на вектор <paramref name="other"/>.
        /// </summary>
        public double DotProduct (Vector3 other)
        {
            return X * other.X + Y * other.Y + Z * other.Z;
        }

        /// <summary>
        /// Квадрат длины вектора.
        /// </summary>
        public override double GetNorm2 ()
        {
            return X * X + Y * Y + Z * Z;
        }
    }
}