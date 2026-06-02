namespace Archimedes
{
    public class Matrix3 : Matrix, IEquatable<Matrix3>
    {
        private const int M3Dimension = 3;

        public override int Height
        {
            get => M3Dimension;
        }

        public override int Width
        {
            get => M3Dimension;
        }

        #region Constructors

        public Matrix3 (double x00, double x01, double x02, 
                        double x10, double x11, double x12, 
                        double x20, double x21, double x22) : base (M3Dimension, M3Dimension)
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

        public Matrix3 (Matrix3 other) : this (other._x [0, 0], other._x [0, 1], other._x [0, 2], 
                                               other._x [1, 0], other._x [1, 1], other._x [1, 2],
                                               other._x [2, 0], other._x [2, 1], other._x [2, 2])
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

        public override bool Equals (object? obj)
        {
            return (obj is Matrix3) ? Equals (obj as Matrix3) :
                   (obj is Matrix)  ? Equals (obj as Matrix)  : base.Equals (obj);
        }

        public override int GetHashCode ()
        {
            return base.GetHashCode ();
        }

        public static bool operator == (Matrix3 v1, Matrix3 v2)
        {
            return v1.Equals (v2);
        }

        public static bool operator != (Matrix3 v1, Matrix3 v2)
        {
            return !v1.Equals (v2);
        }

        #endregion

        #region Operators

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

        public static Vector3 operator * (Matrix3 m1, Vector3 v2)
        {
            return new Vector3 (m1 [0, 0] * v2 [0] + m1 [0, 1] * v2 [1] + m1 [0, 2] * v2 [2],
                                m1 [1, 0] * v2 [0] + m1 [1, 1] * v2 [1] + m1 [1, 2] * v2 [2],
                                m1 [2, 0] * v2 [0] + m1 [2, 1] * v2 [1] + m1 [2, 2] * v2 [2]);
        }

        public static Vector3 operator * (Vector3 v1, Matrix3 m2)
        {
            return new Vector3 (v1 [0] * m2 [0, 0] + v1 [1] * m2 [1, 0] + v1 [2] * m2 [2, 0],
                                v1 [0] * m2 [0, 1] + v1 [1] * m2 [1, 1] + v1 [2] * m2 [2, 1],
                                v1 [0] * m2 [0, 2] + v1 [1] * m2 [1, 2] + v1 [2] * m2 [2, 2]);
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