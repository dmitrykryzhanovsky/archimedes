using System;

namespace Archimedes
{
    public class Vector3 : Vector, IEquatable<Vector3>, IDotProductable<Vector3>
    {
        private const int Size = 3;

        public override int Dimension
        {
            get => Size;
        }

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

        public Vector3 (double x, double y, double z) : base (Size)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3 (Vector3 other) : this (other.X, other.Y, other.Z)
        {
        }

        public override object Clone ()
        {
            return new Vector3 (this);
        }

        public static explicit operator Matrix (Vector3 v)
        {
            throw new NotImplementedException ();
        }

        public bool Equals (Vector3? other)
        {
            throw new NotImplementedException ();
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
            throw new NotImplementedException ();
        }

        public static Vector3 operator - (Vector3 v1, Vector3 v2)
        {
            throw new NotImplementedException ();
        }

        public static Vector3 operator - (Vector3 v)
        {
            throw new NotImplementedException ();
        }

        public static Vector3 operator * (Vector3 v, double coefficient)
        {
            throw new NotImplementedException ();
        }

        public static Vector3 operator * (double coefficient, Vector3 v)
        {
            throw new NotImplementedException ();
        }

        public static Vector3 operator / (Vector3 v, double coefficient)
        {
            throw new NotImplementedException ();
        }

        public static double operator * (Vector3 v1, Vector3 v2)
        {
            return v1.DotProduct (v2);
        }

        public static Vector3 operator * (Matrix3 m1, Vector3 v2)
        {
            throw new NotImplementedException ();
        }
        public static Vector3 operator * (Vector3 v1, Matrix3 m2)
        {
            throw new NotImplementedException ();
        }

        public double DotProduct (Vector3 other)
        {
            throw new NotImplementedException ();
        }

        public Vector3 CrossProduct (Vector3 other)
        {
            throw new NotImplementedException ();
        }

        //public override double GetNorm2 ()
        //{
        //    return X * X + Y * Y + Z * Z;
        //}

        public Polar3 CartesianToPolar ()
        {
            throw new NotImplementedException ();
        }
    }
}