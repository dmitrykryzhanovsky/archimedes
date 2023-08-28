using System;

namespace Archimedes
{
    public class Matrix3 : Matrix, IEquatable<Matrix3>
    {
        private const int Size = 3;

        public override int Height
        {
            get => Size;
        }

        public override int Width
        {
            get => Size;
        }

        public Matrix3 (double x00, double x01, double x02, 
                        double x10, double x11, double x12, 
                        double x20, double x21, double x22) : base (Size, Size)
        {
            throw new NotImplementedException ();
        }

        public Matrix3 (Matrix3 other) : this (other._x [0, 0], other._x [0, 1], other._x [0, 2],
                                               other._x [1, 0], other._x [1, 1], other._x [1, 2],
                                               other._x [2, 0], other._x [2, 1], other._x [2, 2])
        {
        }

        public override object Clone ()
        {
            return new Matrix3 (this);
        }

        public bool Equals (Matrix3? other)
        {
            throw new NotImplementedException ();
        }

        public override bool Equals (object? other)
        {
            if (other is Matrix3) return Equals (other as Matrix3);
            else throw new InvalidCastException ();
        }

        public override int GetHashCode ()
        {
            return base.GetHashCode ();
        }

        public static bool operator == (Matrix3 m1, Matrix3 m2)
        {
            return m1.Equals (m2);
        }

        public static bool operator != (Matrix3 m1, Matrix3 m2)
        {
            return !m1.Equals (m2);
        }

        public static Matrix3 operator + (Matrix3 m1, Matrix3 m2)
        {
            throw new NotImplementedException ();
        }

        public static Matrix3 operator - (Matrix3 m1, Matrix3 m2)
        {
            throw new NotImplementedException ();
        }

        public static Matrix3 operator - (Matrix3 m)
        {
            throw new NotImplementedException ();
        }

        public static Matrix3 operator * (Matrix3 m, double coefficient)
        {
            throw new NotImplementedException ();
        }

        public static Matrix3 operator * (double coefficient, Matrix3 m)
        {
            throw new NotImplementedException ();
        }

        public static Matrix3 operator / (Matrix3 m, double coefficient)
        {
            throw new NotImplementedException ();
        }

        public static Matrix3 operator * (Matrix3 m1, Matrix3 m2)
        {
            throw new NotImplementedException ();
        }
    }
}