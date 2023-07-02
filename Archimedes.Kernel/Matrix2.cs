namespace Archimedes
{
    public class Matrix2 : Matrix, IEquatable<Matrix2>
    {
        private Matrix2 () : base (2, 2)
        {
        }

        public Matrix2 (double x00, double x01, double x10, double x11) : this ()
        {
            _x [0, 0] = x00;
            _x [0, 1] = x01;
            _x [1, 0] = x10;
            _x [1, 1] = x11;
        }

        public Matrix2 (double [,] x) : this (x [0, 0], x [0, 1], x [1, 0], x [1, 1])
        {
        }

        public Matrix2 (Matrix2 other) : this (other._x)
        {
        }

        public override object Clone ()
        {
            return new Matrix2 (this);
        }

        public bool Equals (Matrix2? other)
        {
            return ((_x [0, 0] == other._x [0, 0]) && (_x [0, 1] == other._x [0, 1]) &&
                    (_x [1, 0] == other._x [1, 0]) && (_x [1, 1] == other._x [1, 1]));
        }

        public override bool Equals (object? obj)
        {
            if (obj is Matrix2) return Equals ((Matrix2)obj);
            else return base.Equals (obj);
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
            return m * coefficient;
        }

        public static Matrix2 operator / (Matrix2 m, double coefficient)
        {
            throw new NotImplementedException ();
        }

        public static double operator * (Matrix2 m1, Matrix2 m2)
        {
            throw new NotImplementedException ();
        }
    }
}