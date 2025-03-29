namespace Archimedes
{
    public class Matrix : ICloneable, IEquatable<Matrix>
    {
        protected readonly double [,] _x;

        public double this [int row, int column]
        {
            get => _x [row, column];

            set => _x [row, column] = value;
        }

        /// <summary>
        /// Возвращает элементы матрицы.
        /// </summary>
        public double [,] Items
        {
            get => _x;
        }

        /// <summary>
        /// Возвращает высоту матрицы.
        /// </summary>
        public virtual int Height
        {
            get => _x.GetLength (0);
        }

        /// <summary>
        /// Возвращает ширину матрицы.
        /// </summary>
        public virtual int Width
        {
            get => _x.GetLength (1);
        }

        #region constructors

        protected Matrix (int height, int width)
        {
            _x = new double [height, width];
        }

        public Matrix (int height, int width, params double [] x) : this (height, width)
        {
            x.CopyTo (_x);
        }

        public Matrix (double [,] x) : this (x.GetLength (0), x.GetLength (1))
        {
            x.CopyTo (_x);
        }

        public Matrix (Matrix other) : this (other._x)
        {
        }

        public virtual object Clone ()
        {
            return new Matrix (this);
        }

        #endregion

        public bool Equals (Matrix? other)
        {
            return _x.Equals<double> (other._x);
        }

        public static bool operator == (Matrix m1, Matrix m2)
        {
            return m1.Equals (m2);
        }

        public static bool operator != (Matrix m1, Matrix m2)
        {
            return !m1.Equals (m2);
        }
    }
}