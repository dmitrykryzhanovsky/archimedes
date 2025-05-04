namespace Archimedes
{
    /// <summary>
    /// Квадратная матрица размером 3x3.
    /// </summary>
    public class Matrix3 : Matrix, IEquatable<Matrix3>
    {
        private const int Matrix3Size = 3;

        public override int Height
        {
            get => Matrix3Size;
        }

        public override int Width
        {
            get => Matrix3Size;
        }

        #region constructors

        public Matrix3 (double x00, double x01, double x02, 
                        double x10, double x11, double x12, 
                        double x20, double x21, double x22) : base (Matrix3Size, Matrix3Size)
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

        public Matrix3 (double [] x) : base (Matrix3Size, Matrix3Size)
        {
            _x [0, 0] = x [0];
            _x [0, 1] = x [1];
            _x [0, 2] = x [2];

            _x [1, 0] = x [3];
            _x [1, 1] = x [4];
            _x [1, 2] = x [5];

            _x [2, 0] = x [6];
            _x [2, 1] = x [7];
            _x [2, 2] = x [8];
        }

        public Matrix3 (double [,] x) : base (Matrix3Size, Matrix3Size)
        {
            _x [0, 0] = x [0, 0];
            _x [0, 1] = x [0, 1];
            _x [0, 2] = x [0, 2];

            _x [1, 0] = x [1, 0];
            _x [1, 1] = x [1, 1];
            _x [1, 2] = x [1, 2];

            _x [2, 0] = x [2, 0];
            _x [2, 1] = x [2, 1];
            _x [2, 2] = x [2, 2];
        }

        public Matrix3 (Matrix3 other) : this (other._x)
        {
        }

        public override object Clone ()
        {
            return new Matrix3 (this);
        }

        #endregion

        #region comparison

        public override bool Equals (object? obj)
        {
            return base.Equals (obj as Matrix3);
        }

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

        #region operators

        public static Matrix3 operator + (Matrix3 m1, Matrix3 m2)
        {
            return new Matrix3 (m1 [0, 0] + m2 [0, 0],
                                m1 [0, 1] + m2 [0, 1],
                                m1 [0, 2] + m2 [0, 2],

                                m1 [1, 0] + m2 [1, 0],
                                m1 [1, 1] + m2 [1, 1],
                                m1 [1, 2] + m2 [1, 2],

                                m1 [2, 0] + m2 [2, 0],
                                m1 [2, 1] + m2 [2, 1],
                                m1 [2, 2] + m2 [2, 2]);
        }

        public static Matrix3 operator - (Matrix3 m1, Matrix3 m2)
        {
            return new Matrix3 (m1 [0, 0] - m2 [0, 0],
                                m1 [0, 1] - m2 [0, 1],
                                m1 [0, 2] - m2 [0, 2],

                                m1 [1, 0] - m2 [1, 0],
                                m1 [1, 1] - m2 [1, 1],
                                m1 [1, 2] - m2 [1, 2],

                                m1 [2, 0] - m2 [2, 0],
                                m1 [2, 1] - m2 [2, 1],
                                m1 [2, 2] - m2 [2, 2]);
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

        #endregion
    }
} 