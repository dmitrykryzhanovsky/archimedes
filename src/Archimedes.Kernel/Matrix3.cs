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
    }
}