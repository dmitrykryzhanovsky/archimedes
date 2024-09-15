namespace Archimedes
{
    public class Matrix2 : Matrix, IEquatable<Matrix2>
    {
        private const int Matrix2Dimension = 2;

        public override int Height
        {
            get => Matrix2Dimension;
        }

        public override int Width
        {
            get => Matrix2Dimension;
        }

        #region Constructors

        public Matrix2 (double a00, double a01, double a10, double a11) : base (Matrix2Dimension, Matrix2Dimension)
        {
            _x [0, 0] = a00;
            _x [0, 1] = a01;
            _x [1, 0] = a10;
            _x [1, 1] = a11;
        }

        public Matrix2 (double [] array) : this (array [0], array [1], array [2], array [3])
        {
        }

        public Matrix2 (double [,] array) : this (array [0, 0], array [0, 1], array [1, 0], array [1, 1])
        {
        }

        public Matrix2 (Matrix2 other) : this (other._x)
        {
        }

        public override object Clone ()
        {
            return new Matrix2 (this);
        }

        #endregion

        #region Comparisons

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
    }
}