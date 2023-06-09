﻿namespace Archimedes
{
    public class Matrix3 : Matrix, IEquatable<Matrix3>
    {
        private Matrix3 () : base (3, 3)
        {
        }

        public Matrix3 (double x00, double x01, double x02, 
                        double x10, double x11, double x12, 
                        double x20, double x21, double x22) : this ()
        {
            _x [0, 0] = x00;
            _x [0, 1] = x01;
            _x [0, 2] = x02;

            _x [1, 0] = x10;
            _x [1, 1] = x11;
            _x [1, 2] = x12;

            _x [2, 0] = x20;
            _x [2, 1] = x21;
            _x [2, 2] = x22;
        }

        public Matrix3 (double [,] x) : this (x [0, 0], x [0, 1], x [0, 2], 
                                              x [1, 0], x [1, 1], x [1, 2], 
                                              x [2, 0], x [2, 1], x [2, 2])
        {
        }

        public Matrix3 (Matrix3 other) : this (other._x)
        {
        }

        public override object Clone ()
        {
            return new Matrix3 (this);
        }

        public bool Equals (Matrix3? other)
        {
            return ((_x [0, 0] == other._x [0, 0]) && (_x [0, 1] == other._x [0, 1]) && (_x [0, 2] == other._x [0, 2]) &&
                    (_x [1, 0] == other._x [1, 0]) && (_x [1, 1] == other._x [1, 1]) && (_x [1, 2] == other._x [1, 2]) &&
                    (_x [2, 0] == other._x [2, 0]) && (_x [2, 1] == other._x [2, 1]) && (_x [2, 2] == other._x [2, 2]));
        }

        public override bool Equals (object? obj)
        {
            if (obj is Matrix3) return Equals ((Matrix3)obj);
            else return base.Equals (obj);
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
            return m * coefficient;
        }

        public static Matrix3 operator / (Matrix3 m, double coefficient)
        {
            throw new NotImplementedException ();
        }

        public static double operator * (Matrix3 m1, Matrix3 m2)
        {
            throw new NotImplementedException ();
        }

        // TODO: перемножение матриц и векторок
    }
}