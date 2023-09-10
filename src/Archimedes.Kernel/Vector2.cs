using System;

namespace Archimedes
{
    public class Vector2 : Vector, IEquatable<Vector2>, IDotProductable<Vector2>
    {
        private const int Size = 2;

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

        public Vector2 (double x, double y) : base (Size)
        {
            X = x;
            Y = y;
        }

        public Vector2 (Vector2 other) : this (other.X, other.Y)
        {
        }

        public override object Clone ()
        {
            return new Vector2 (this);
        }

        public static explicit operator Matrix (Vector2 v)
        {
            throw new NotImplementedException ();
        }

        public static explicit operator Complex (Vector2 v)
        {
            throw new NotImplementedException ();
        }

        public bool Equals (Vector2? other)
        {
            throw new NotImplementedException ();
        }

        public override bool Equals (object? other)
        {
            if (other is Vector2) return Equals (other as Vector2);
            else throw new InvalidCastException ();
        }

        public override int GetHashCode ()
        {
            return base.GetHashCode ();
        }

        public static bool operator == (Vector2 v1, Vector2 v2)
        {
            return v1.Equals (v2);
        }

        public static bool operator != (Vector2 v1, Vector2 v2)
        {
            return !v1.Equals (v2);
        }

        public static Vector2 operator + (Vector2 v1, Vector2 v2)
        {
            throw new NotImplementedException ();
        }

        public static Vector2 operator - (Vector2 v1, Vector2 v2)
        {
            throw new NotImplementedException ();
        }

        public static Vector2 operator - (Vector2 v)
        {
            throw new NotImplementedException ();
        }

        public static Vector2 operator * (Vector2 v, double coefficient)
        {
            throw new NotImplementedException ();
        }

        public static Vector2 operator * (double coefficient, Vector2 v)
        {
            throw new NotImplementedException ();
        }

        public static Vector2 operator / (Vector2 v, double coefficient)
        {
            throw new NotImplementedException ();
        }

        public static double operator * (Vector2 v1, Vector2 v2)
        {
            return v1.DotProduct (v2);
        }

        public static Vector2 operator * (Matrix2 m1, Vector2 v2)
        {
            throw new NotImplementedException ();
        }
        public static Vector2 operator * (Vector2 v1, Matrix2 m2)
        {
            throw new NotImplementedException ();
        }

        public double DotProduct (Vector2 other)
        {
            throw new NotImplementedException ();
        }

        //public override double GetNorm2 ()
        //{
        //    return X * X + Y * Y;
        //}

        public double GetHeading ()
        {
            throw new NotImplementedException ();
        }

        public Polar2 CartesianToPolar ()
        {
            throw new NotImplementedException ();
        }
    }
}