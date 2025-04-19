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
    }
}