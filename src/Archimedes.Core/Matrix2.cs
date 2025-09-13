namespace Archimedes
{
    public class Matrix2 : Matrix, IEquatable<Matrix2>
    {
        private const int M2Dimension = 2;

        public override int Height
        {
            get => M2Dimension;
        }

        public override int Width
        {
            get => M2Dimension;
        }

        #region Constructors

        public Matrix2 (double x00, double x01, double x10, double x11) : base (M2Dimension, M2Dimension)
        {
            _x [0, 0] = x00;
            _x [0, 1] = x01;
            _x [1, 0] = x10;
            _x [1, 1] = x11;
        }

        public Matrix2 (Matrix2 other) : this (other._x [0, 0], other._x [0, 1], 
                                               other._x [1, 0], other._x [1, 1])
        {
        }

        public override object Clone ()
        {
            return new Matrix2 (this);
        }

        #endregion

        #region Comparison

        public bool Equals (Matrix2? other)
        {
            return ((_x [0, 0] == other._x [0, 0]) && (_x [0, 1] == other._x [0, 1]) &&
                    (_x [1, 0] == other._x [1, 0]) && (_x [1, 1] == other._x [1, 1]));
        }

        public override bool Equals (object? obj)
        {
            return (obj is Matrix2) ? Equals (obj as Matrix2) :
                   (obj is Matrix)  ? Equals (obj as Matrix)  : base.Equals (obj);
        }

        public override int GetHashCode ()
        {
            return base.GetHashCode ();
        }

        public static bool operator == (Matrix2 v1, Matrix2 v2)
        {
            return v1.Equals (v2);
        }

        public static bool operator != (Matrix2 v1, Matrix2 v2)
        {
            return !v1.Equals (v2);
        }

        #endregion

        #region Operators

        public static Matrix2 operator + (Matrix2 m1, Matrix2 m2)
        {
            return new Matrix2 (m1 [0, 0] + m2 [0, 0], m1 [0, 1] + m2 [0, 1],
                                m1 [1, 0] + m2 [1, 0], m1 [1, 1] + m2 [1, 1]);
        }

        public static Matrix2 operator - (Matrix2 m1, Matrix2 m2)
        {
            return new Matrix2 (m1 [0, 0] - m2 [0, 0], m1 [0, 1] - m2 [0, 1],
                                m1 [1, 0] - m2 [1, 0], m1 [1, 1] - m2 [1, 1]);
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
            return m * coefficient;
        }

        public static Matrix2 operator / (Matrix2 m, double coefficient)
        {
            return new Matrix2 (m [0, 0] / coefficient, m [0, 1] / coefficient,
                                m [1, 0] / coefficient, m [1, 1] / coefficient);
        }

        public static Vector2 operator * (Matrix2 m1, Vector2 v2)
        {
            return new Vector2 (m1 [0, 0] * v2 [0] + m1 [0, 1] * v2 [1],
                                m1 [1, 0] * v2 [0] + m1 [1, 1] * v2 [1]);
        }

        public static Vector2 operator * (Vector2 v1, Matrix2 m2)
        {
            return new Vector2 (v1 [0] * m2 [0, 0] + v1 [1] * m2 [1, 0],
                                v1 [0] * m2 [0, 1] + v1 [1] * m2 [1, 1]);
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