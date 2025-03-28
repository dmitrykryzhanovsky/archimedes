namespace Archimedes
{
    /// <summary>
    /// Квадратная матрица размером 2x2.
    /// </summary>
    public class Matrix2 : Matrix
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
    }
}