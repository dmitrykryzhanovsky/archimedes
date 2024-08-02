namespace Archimedes
{
    public class Matrix2: Matrix, IEquatable<Matrix2>
    {
        private const int ThisTypeDimension = 2;

        public override int Height
        {
            get => ThisTypeDimension;
        }

        public override int Width
        {
            get => ThisTypeDimension;
        }

        #region Constructors

        public Matrix2 (double x00, double x01, double x10, double x11) : base (ThisTypeDimension, ThisTypeDimension)
        {
            _x [0, 0] = x00;
            _x [0, 1] = x01;
            _x [1, 0] = x10;
            _x [1, 1] = x11;
        }

        public Matrix2 (Matrix2 other) : this (other [0, 0], other [0, 1], other [1, 0], other [1, 1])
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

        public static bool operator == (Matrix2 v1, Matrix2 v2)
        {
            return v1.Equals (v2);
        }

        public static bool operator != (Matrix2 v1, Matrix2 v2)
        {
            return !v1.Equals (v2);
        }

        #endregion
    }
}