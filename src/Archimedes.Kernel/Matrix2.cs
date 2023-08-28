using System;

namespace Archimedes
{
    public class Matrix2 : Matrix, IEquatable<Matrix2>
    {
        private const int Size = 2;

        public override int Height
        {
            get => Size;
        }

        public override int Width
        {
            get => Size;
        }

        public Matrix2 (double x00, double x01, double x10, double x11) : base (Size, Size)
        {
            throw new NotImplementedException ();
        }

        public Matrix2 (Matrix2 other) : this (other._x [0, 0], other._x [0, 1], 
                                               other._x [1, 0], other._x [1, 1])
        {
        }

        public override object Clone ()
        {
            return new Matrix2 (this);
        }

        public bool Equals (Matrix2? other)
        {
            throw new NotImplementedException ();
        }

        public override bool Equals (object? other)
        {
            if (other is Matrix2) return Equals (other as Matrix2);
            else throw new InvalidCastException ();
        }

        public override int GetHashCode ()
        {
            return base.GetHashCode ();
        }

        public static bool operator == (Matrix2 m1, Matrix2 m2)
        {
            return m1.Equals (m2);
        }

        public static bool operator != (Matrix2 m1, Matrix2 m2)
        {
            return !m1.Equals (m2);
        }

        public static Matrix2 operator + (Matrix2 m1, Matrix2 m2)
        {
            throw new NotImplementedException ();
        }

        public static Matrix2 operator - (Matrix2 m1, Matrix2 m2)
        {
            throw new NotImplementedException ();
        }

        public static Matrix2 operator - (Matrix2 m)
        {
            throw new NotImplementedException ();
        }

        public static Matrix2 operator * (Matrix2 m, double coefficient)
        {
            throw new NotImplementedException ();
        }

        public static Matrix2 operator * (double coefficient, Matrix2 m)
        {
            throw new NotImplementedException ();
        }

        public static Matrix2 operator / (Matrix2 m, double coefficient)
        {
            throw new NotImplementedException ();
        }

        public static Matrix2 operator * (Matrix2 m1, Matrix2 m2)
        {
            throw new NotImplementedException ();
        }
    }
}