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

        public Matrix (int height, int width)
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

        #region comparison

        public override bool Equals (object? obj)
        {
            return base.Equals (obj as Matrix);
        }

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

        public override int GetHashCode ()
        {
            return _x.GetHashCode ();
        }

        #endregion

        #region operators

        public static Matrix operator + (Matrix m1, Matrix m2)
        {
            CheckDimensionForAddition (m1, m2);

            Matrix result = new Matrix (m1.Height, m1.Width);

            ArrayExtension.Add (m1._x, m2._x, result._x, result.Height, result.Width);

            return result;
        }

        public static Matrix operator - (Matrix m1, Matrix m2)
        {
            CheckDimensionForAddition (m1, m2);

            Matrix result = new Matrix (m1.Height, m1.Width);

            ArrayExtension.Subtract (m1._x, m2._x, result._x, result.Height, result.Width);

            return result;
        }

        public static Matrix operator - (Matrix m)
        {
            Matrix result = new Matrix (m.Height, m.Width);

            ArrayExtension.Negate (m._x, result._x, result.Height, result.Width);

            return result;
        }

        public static Matrix operator * (Matrix m, double coefficient)
        {
            Matrix result = new Matrix (m.Height, m.Width);

            ArrayExtension.Multiply (m._x, coefficient, result._x, result.Height, result.Width);

            return result;
        }

        public static Matrix operator * (double coefficient, Matrix m)
        {
            Matrix result = new Matrix (m.Height, m.Width);

            ArrayExtension.Multiply (m._x, coefficient, result._x, result.Height, result.Width);

            return result;
        }

        public static Matrix operator / (Matrix m, double coefficient)
        {
            Matrix result = new Matrix (m.Height, m.Width);

            ArrayExtension.Divide (m._x, coefficient, result._x, result.Height, result.Width);

            return result;
        }

        public static Vector operator * (Matrix m, Vector v)
        {
            CheckDimensionForMultiplication (m, v);

            Vector result = new Vector (m.Height);

            ArrayExtension.OuterProduct (m._x, v.Coordinates, result.Coordinates);

            return result;
        }

        public static Vector operator * (Vector v, Matrix m)
        {
            CheckDimensionForMultiplication (v, m);

            Vector result = new Vector (m.Width);

            ArrayExtension.OuterProduct (v.Coordinates, m._x, result.Coordinates);

            return result;
        }

        public static Matrix operator * (Matrix m1, Matrix m2)
        {
            CheckDimensionForMultiplication (m1, m2);

            Matrix result = new Matrix (m1.Height, m2.Width);

            MatrixAlgorithms.StandardMultiplication (m1._x, m2._x, result._x, m1.Height, m1.Width, m2.Width);

            return result;
        }

        #endregion

        private static void CheckDimensionForAddition (Matrix m1, Matrix m2)
        {
            if ((m1.Height != m2.Height) || (m1.Width != m2.Width)) throw new MatrixMatrixNotCompatibleToAddDimensionException ();
        }

        private static void CheckDimensionForMultiplication (Matrix m, Vector v)
        {
            if (m.Width != v.Dimension) throw new MatrixVectorNotCompatibleToMultiplyDimensionException ();
        }

        private static void CheckDimensionForMultiplication (Vector v, Matrix m)
        {
            if (v.Dimension != m.Height) throw new VectorMatrixNotCompatibleToMultiplyDimensionException ();
        }

        private static void CheckDimensionForMultiplication (Matrix m1, Matrix m2)
        {
            if (m1.Width != m2.Height) throw new MatrixMatrixNotCompatibleToMultiplyDimensionException ();
        }
    }
}