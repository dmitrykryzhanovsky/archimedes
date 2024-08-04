namespace Archimedes
{
    public class Matrix3 : Matrix, IEquatable<Matrix3>
    {
        private const int Matrix3Dimension = 3;

        /// <summary>
        /// Возвращает высоту матрицы.
        /// </summary>
        public override int Height
        {
            get => Matrix3Dimension;
        }

        /// <summary>
        /// Возвращает ширину матрицы.
        /// </summary>
        public override int Width
        {
            get => Matrix3Dimension;
        }

        #region Constructors

        public Matrix3 (double x00, double x01, double x02, 
                        double x10, double x11, double x12, 
                        double x20, double x21, double x22) : base (Matrix3Dimension, Matrix3Dimension)
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

        public Matrix3 (double [] x) : this (x [0], x [1], x [2], 
                                             x [3], x [4], x [5], 
                                             x [6], x [7], x [8])
        {
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

        #endregion

        #region Comparison

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

        public override bool Equals (object? obj)
        {
            return Equals (obj as Matrix3);
        }

        public override int GetHashCode ()
        {
            return _x.GetHashCode ();
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
            return new Matrix3 (m [0, 0] * coefficient, m [0, 1] * coefficient, m [0, 2] * coefficient,
                                m [1, 0] * coefficient, m [1, 1] * coefficient, m [1, 2] * coefficient,
                                m [2, 0] * coefficient, m [2, 1] * coefficient, m [2, 2] * coefficient);
        }

        public static Matrix3 operator / (Matrix3 m, double coefficient)
        {
            return new Matrix3 (m [0, 0] / coefficient, m [0, 1] / coefficient, m [0, 2] / coefficient,
                                m [1, 0] / coefficient, m [1, 1] / coefficient, m [1, 2] / coefficient,
                                m [2, 0] / coefficient, m [2, 1] / coefficient, m [2, 2] / coefficient);
        }

        public static Matrix3 operator * (Matrix3 m1, Matrix3 m2)
        {
            return new Matrix3 (m1 [0, 0] * m2 [0, 0] + m1 [0, 1] * m2 [1, 0] + m1 [0, 2] * m2 [2, 0],
                                m1 [0, 0] * m2 [0, 1] + m1 [0, 1] * m2 [1, 1] + m1 [0, 2] * m2 [2, 1],
                                m1 [0, 0] * m2 [0, 2] + m1 [0, 1] * m2 [1, 2] + m1 [0, 2] * m2 [2, 2],

                                m1 [1, 0] * m2 [0, 0] + m1 [1, 1] * m2 [1, 0] + m1 [1, 2] * m2 [2, 0],
                                m1 [1, 0] * m2 [0, 1] + m1 [1, 1] * m2 [1, 1] + m1 [1, 2] * m2 [2, 1],
                                m1 [1, 0] * m2 [0, 2] + m1 [1, 1] * m2 [1, 2] + m1 [1, 2] * m2 [2, 2],

                                m1 [2, 0] * m2 [0, 0] + m1 [2, 1] * m2 [1, 0] + m1 [2, 2] * m2 [2, 0],
                                m1 [2, 0] * m2 [0, 1] + m1 [2, 1] * m2 [1, 1] + m1 [2, 2] * m2 [2, 1],
                                m1 [2, 0] * m2 [0, 2] + m1 [2, 1] * m2 [1, 2] + m1 [2, 2] * m2 [2, 2]);
        }

        public static Vector3 operator * (Matrix3 m, Vector3 v)
        {
            return new Vector3 (m [0, 0] * v [0] + m [0, 1] * v [1] + m [0, 2] * v [2],
                                m [1, 0] * v [0] + m [1, 1] * v [1] + m [1, 2] * v [2],
                                m [2, 0] * v [0] + m [2, 1] * v [1] + m [2, 2] * v [2]);
        }

        public static Vector3 operator * (Vector3 v, Matrix3 m)
        {
            return new Vector3 (v [0] * m [0, 0] + v [1] * m [1, 0] + v [2] * m [2, 0],
                                v [0] * m [0, 1] + v [1] * m [1, 1] + v [2] * m [2, 1],
                                v [0] * m [0, 2] + v [1] * m [1, 2] + v [2] * m [2, 2]);
        }
    }
}