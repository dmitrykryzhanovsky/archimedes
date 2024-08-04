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

        #region Comparison

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

        public override bool Equals (object? obj)
        {
            return Equals (obj as Matrix);
        }

        public override int GetHashCode ()
        {
            return _x.GetHashCode ();
        }

        #endregion

        public static Matrix operator + (Matrix m1, Matrix m2)
        {
            if (!AreMatricesSuitableForAdding (m1, m2)) throw new ArithmeticException ();

            Matrix result = new Matrix (m1.Height, m1.Width);

            m1._x.Add (m2._x, result._x);

            return result;
        }

        public static Matrix operator - (Matrix m1, Matrix m2)
        {
            if (!AreMatricesSuitableForAdding (m1, m2)) throw new ArithmeticException ();

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
            Matrix result = new Matrix (m.Height, m.Width);

            m._x.Multiply (coefficient, result._x);

            return result;
        }

        public static Matrix operator / (Matrix m, double coefficient)
        {
            Matrix result = new Matrix (m.Height, m.Width);

            m._x.Divide (coefficient, result._x);

            return result;
        }

        public static Matrix operator * (Matrix m1, Matrix m2)
        {
            if (!AreMatricesSuitableForMultiplying (m1, m2)) throw new ArithmeticException ();

            return MatrixAlgorithms.O3Multiplication (m1, m2);
        }

        private static bool AreMatricesSuitableForAdding (Matrix m1, Matrix m2)
        {
            return ((m1.Height == m2.Height) && 
                    (m1.Width == m2.Width));
        }

        private static bool AreMatricesSuitableForMultiplying (Matrix m1, Matrix m2)
        {
            return (m1.Width == m2.Height);
        }
    }
}