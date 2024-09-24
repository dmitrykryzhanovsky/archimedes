namespace Archimedes
{
    public class Matrix3 : Matrix, IEquatable<Matrix3>
    {
        private const int Matrix3Dimension = 3;

        public override int Height
        {
            get => Matrix3Dimension;
        }

        public override int Width
        {
            get => Matrix3Dimension;
        }

        #region Constructors

        public Matrix3 (double a00, double a01, double a02, 
                        double a10, double a11, double a12, 
                        double a20, double a21, double a22) : base (Matrix3Dimension, Matrix3Dimension)
        {
            _x [0, 0] = a00;
            _x [0, 1] = a01;
            _x [0, 2] = a02;

            _x [1, 0] = a10;
            _x [1, 1] = a11;
            _x [1, 2] = a12;

            _x [2, 0] = a20;
            _x [2, 1] = a21;
            _x [2, 2] = a22;
        }

        public Matrix3 (double [] array) : this (array [0], array [1], array [2], 
                                                 array [3], array [4], array [5], 
                                                 array [6], array [7], array [8])
        {
        }

        public Matrix3 (double [,] array) : this (array [0, 0], array [0, 1], array [0, 2], 
                                                  array [1, 0], array [1, 1], array [1, 2], 
                                                  array [2, 0], array [2, 1], array [2, 2])
        {
        }

        public Matrix3 (Matrix3 other) : this (other._x)
        {
        }

        public override object Clone ()
        {
            return new Matrix3 (this);
        }

        #endregion

        #region Comparisons

        public bool Equals (Matrix3? other)
        {
            return ((_x [0, 0] == other._x [0, 0]) && (_x [0, 1] == other._x [0, 1]) && (_x [0, 2] == other._x [0, 2]) &&
                    (_x [1, 0] == other._x [1, 0]) && (_x [1, 1] == other._x [1, 1]) && (_x [1, 2] == other._x [1, 2]) &&
                    (_x [2, 0] == other._x [2, 0]) && (_x [2, 1] == other._x [2, 1]) && (_x [2, 2] == other._x [2, 2]));
        }

        public static bool operator == (Matrix3 m1, Matrix3 m2)
        {
            return m1.Equals (m2);
        }

        public static bool operator != (Matrix3 m1, Matrix3 m2)
        {
            return !m1.Equals (m2);
        }

        #endregion

        public static Matrix3 operator + (Matrix3 m1, Matrix3 m2)
        {
            return new Matrix3 (m1 [0, 0] + m2 [0, 0], m1 [0, 1] + m2 [0, 1], m1 [0, 2] + m2 [0, 2],
                                m1 [1, 0] + m2 [1, 0], m1 [1, 1] + m2 [1, 1], m1 [1, 2] + m2 [1, 2],
                                m1 [2, 0] + m2 [2, 0], m1 [2, 1] + m2 [2, 1], m1 [2, 2] + m2 [2, 2]);
        }

        public static Matrix3 operator - (Matrix3 m1, Matrix3 m2)
        {
            return new Matrix3 (m1 [0, 0] - m2 [0, 0], m1 [0, 1] - m2 [0, 1], m1 [0, 2] - m2 [0, 2],
                                m1 [1, 0] - m2 [1, 0], m1 [1, 1] - m2 [1, 1], m1 [1, 2] - m2 [1, 2],
                                m1 [2, 0] - m2 [2, 0], m1 [2, 1] - m2 [2, 1], m1 [2, 2] - m2 [2, 2]);
        }

        public static Matrix3 operator - (Matrix3 m)
        {
            return new Matrix3 (-m [0, 0], -m [0, 1], -m [0, 2], 
                                -m [1, 0], -m [1, 1], -m [1, 2], 
                                -m [2, 0], -m [2, 1], -m [2, 2]);
        }

        public static Matrix3 operator * (Matrix3 m, double coefficient)
        {
            return new Matrix3 (m [0, 0] * coefficient, m [0, 1] * coefficient, m [0, 2] * coefficient,
                                m [1, 0] * coefficient, m [1, 1] * coefficient, m [1, 2] * coefficient,
                                m [2, 0] * coefficient, m [2, 1] * coefficient, m [2, 2] * coefficient);
        }

        public static Matrix3 operator * (double coefficient, Matrix3 m)
        {
            return m * coefficient;
        }

        public static Matrix3 operator / (Matrix3 m, double coefficient)
        {
            return new Matrix3 (m [0, 0] / coefficient, m [0, 1] / coefficient, m [0, 2] / coefficient,
                                m [1, 0] / coefficient, m [1, 1] / coefficient, m [1, 2] / coefficient,
                                m [2, 0] / coefficient, m [2, 1] / coefficient, m [2, 2] / coefficient);
        }
    }
}