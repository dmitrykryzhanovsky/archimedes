﻿namespace Archimedes
{
    /// <summary>
    /// Квадратная матрица размером 2x2.
    /// </summary>
    public class Matrix2 : Matrix, IEquatable<Matrix2>
    {
        private const int Matrix2Size = 2;

        public override int Height
        {
            get => Matrix2Size;
        }

        public override int Width
        {
            get => Matrix2Size;
        }

        #region constructors

        public Matrix2 (double x00, double x01, double x10, double x11) : base (Matrix2Size, Matrix2Size)
        {
            _x [0, 0] = x00;
            _x [0, 1] = x01;
            _x [1, 0] = x10;
            _x [1, 1] = x11;
        }

        public Matrix2 (double [] x) : base (Matrix2Size, Matrix2Size)
        {
            _x [0, 0] = x [0];
            _x [0, 1] = x [1];
            _x [1, 0] = x [2];
            _x [1, 1] = x [3];
        }

        public Matrix2 (double [,] x) : base (Matrix2Size, Matrix2Size)
        {
            _x [0, 0] = x [0, 0];
            _x [0, 1] = x [0, 1];
            _x [1, 0] = x [1, 0];
            _x [1, 1] = x [1, 1];
        }

        public Matrix2 (Matrix2 other) : this (other._x)
        {
        }

        public override object Clone ()
        {
            return new Matrix2 (this);
        }

        #endregion

        #region comparison

        public override bool Equals (object? obj)
        {
            return base.Equals (obj as Matrix2);
        }

        public bool Equals (Matrix2? other)
        {
            return ((_x [0, 0] == other._x [0, 0]) && (_x [0, 1] == other._x [0, 1]) && 
                    (_x [1, 0] == other._x [1, 0]) && (_x [1, 1] == other._x [1, 1]));
        }

        public static bool operator == (Matrix2 m1, Matrix2 m2)
        {
            return m1.Equals (m2);
        }

        public static bool operator != (Matrix2 m1, Matrix2 m2)
        {
            return !m1.Equals (m2);
        }

        #endregion

        #region operators

        public static Matrix2 operator + (Matrix2 m1, Matrix2 m2)
        {
            return new Matrix2 (m1 [0, 0] + m2 [0, 0], 
                                m1 [0, 1] + m2 [0, 1],

                                m1 [1, 0] + m2 [1, 0], 
                                m1 [1, 1] + m2 [1, 1]);
        }

        public static Matrix2 operator - (Matrix2 m1, Matrix2 m2)
        {
            return new Matrix2 (m1 [0, 0] - m2 [0, 0], 
                                m1 [0, 1] - m2 [0, 1],

                                m1 [1, 0] - m2 [1, 0], 
                                m1 [1, 1] - m2 [1, 1]);
        }

        public static Matrix2 operator - (Matrix2 m)
        {
            return new Matrix2 (-m [0, 0], -m [0, 1],
                                -m [1, 0], -m [1, 1]);
        }

        public static Matrix2 operator * (Matrix2 m, double coefficient)
        {
            return new Matrix2 (m [0, 0] * coefficient, m [0, 1] * coefficient,
                                m [1, 0] * coefficient, m [1, 1] * coefficient);
        }

        public static Matrix2 operator * (double coefficient, Matrix2 m)
        {
            return new Matrix2 (m [0, 0] * coefficient, m [0, 1] * coefficient,
                                m [1, 0] * coefficient, m [1, 1] * coefficient);
        }

        public static Matrix2 operator / (Matrix2 m, double coefficient)
        {
            return new Matrix2 (m [0, 0] / coefficient, m [0, 1] / coefficient,
                                m [1, 0] / coefficient, m [1, 1] / coefficient);
        }

        public static Vector2 operator * (Matrix2 m, Vector2 v)
        {
            return new Vector2 (m [0, 0] * v [0] + m [0, 1] * v [1], 
                                m [1, 0] * v [0] + m [1, 1] * v [1]);
        }

        public static Vector2 operator * (Vector2 v, Matrix2 m)
        {
            return new Vector2 (v [0] * m [0, 0] + v [1] * m [1, 0],
                                v [0] * m [0, 1] + v [1] * m [1, 1]);
        }

        public static Matrix2 operator * (Matrix2 m1, Matrix2 m2)
        {
            return new Matrix2 (m1 [0, 0] * m2 [0, 0] + m1 [0, 1] * m2 [1, 0],
                                m1 [0, 0] * m2 [0, 1] + m1 [0, 1] * m2 [1, 1],

                                m1 [1, 0] * m2 [0, 0] + m1 [1, 1] * m2 [1, 0],
                                m1 [1, 0] * m2 [0, 1] + m1 [1, 1] * m2 [1, 1]);
        }

        #endregion
    }
}