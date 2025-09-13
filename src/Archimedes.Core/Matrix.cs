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

        public double [,] Items
        {
            get => _x;
        }

        public virtual int Height
        {
            get => _x.GetLength (0);
        }

        public virtual int Width
        {
            get => _x.GetLength (1);
        }

        #region Constructors

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

        #region Comparison

        public bool Equals (Matrix? other)
        {
            return _x.Equals<double> (other._x);
        }

        public override bool Equals (object? obj)
        {
            return (obj is Matrix) ? Equals (obj as Matrix) : base.Equals (obj);
        }

        public override int GetHashCode ()
        {
            return _x.GetHashCode ();
        }

        public static bool operator == (Matrix m1, Matrix m2)
        {
            return m1.Equals (m2);
        }

        public static bool operator != (Matrix m1, Matrix m2)
        {
            return !m1.Equals (m2);
        }

        #endregion

        #region Operators

        public static Matrix operator + (Matrix m1, Matrix m2)
        {
            if (!AreCompatibleForSummation (m1, m2)) throw new ArithmeticException ();

            Matrix result = new Matrix (m1.Height, m1.Width);

            m1._x.Add (m2._x, result._x);

            return result;
        }

        public static Matrix operator - (Matrix m1, Matrix m2)
        {
            if (!AreCompatibleForSummation (m1, m2)) throw new ArithmeticException ();

            Matrix result = new Matrix (m1.Height, m1.Width);

            m1._x.Subtract (m2._x, result._x);

            return result;
        }

        public static Matrix operator - (Matrix m)
        {
            Matrix result = new Matrix (m.Height, m.Width);

            m._x.Negate (result._x);

            return result;
        }

        public static Matrix operator * (Matrix m, double coefficient)
        {
            Matrix result = new Matrix (m.Height, m.Width);

            m._x.Multiply (coefficient, result._x);

            return result;
        }

        public static Matrix operator * (double coefficient, Matrix m)
        {
            return m * coefficient;
        }

        public static Matrix operator / (Matrix m, double coefficient)
        {
            Matrix result = new Matrix (m.Height, m.Width);

            m._x.Divide (coefficient, result._x);

            return result;
        }

        public static Vector operator * (Matrix m1, Vector v2)
        {
            if (!AreCompatibleForMultiplication (m1, v2)) throw new ArithmeticException ();

            Vector result = new Vector (m1.Height);

            MatrixAlgorithms.MatrixVectorMultiplication (m1._x, v2.Coordinates, result.Coordinates, m1.Height, m1.Width);

            return result;
        }

        public static Vector operator * (Vector v1, Matrix m2)
        {
            if (!AreCompatibleForMultiplication (v1, m2)) throw new ArithmeticException ();

            Vector result = new Vector (m2.Width);

            MatrixAlgorithms.VectorMatrixMultiplication (v1.Coordinates, m2._x, result.Coordinates, m2.Height, m2.Width);

            return result;
        }

        public static Matrix operator * (Matrix m1, Matrix m2)
        {
            if (!AreCompatibleForMultiplication (m1, m2)) throw new ArithmeticException ();

            Matrix result = new Matrix (m1.Height, m2.Width);

            MatrixAlgorithms.CommonMultiplication (m1._x, m2._x, result._x, m1.Height, m1.Width, m2.Width);

            return result;
        }

        #endregion

        private static bool AreCompatibleForSummation (Matrix m1, Matrix m2)
        {
            return ((m1.Height == m2.Height) && (m1.Width == m2.Width));
        }

        private static bool AreCompatibleForMultiplication (Matrix m1, Vector v2)
        {
            return (m1.Width == v2.Dimension);
        }

        private static bool AreCompatibleForMultiplication (Vector v1, Matrix m2)
        {
            return (v1.Dimension == m2.Height);
        }

        private static bool AreCompatibleForMultiplication (Matrix m1, Matrix m2)
        {
            return (m1.Width == m2.Height);
        }
    }
}