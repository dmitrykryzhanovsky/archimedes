using System;

namespace Archimedes
{
    public class Vector3 : Vector, IEquatable<Vector3>, IDotProductable<Vector3>
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

        public Vector3 () : base (Size)
        {
        }

        public Vector3 (double x, double y, double z) : this ()
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

        public bool Equals (Vector3? other)
        {
            return ((X == other.X) && (Y == other.Y) && (Z == other.Z));
        }

        public override bool Equals (object? other)
        {
            if (other is Vector3) return Equals (other as Vector3);

            else throw new InvalidCastException ();
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

        public double DotProduct (Vector3 other)
        {
            return X * other.X + Y * other.Y + Z * other.Z;
        }

        public override double GetNorm2 ()
        {
            return DotProduct (this);
        }
    }
}