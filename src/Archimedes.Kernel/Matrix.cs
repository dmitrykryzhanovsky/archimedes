namespace Archimedes
{
    public class Matrix : ICloneable, IEquatable<Matrix>
    {
        protected double [,] _x;

        public double this [int row, int column]
        {
            get => _x [row, column];
            set => _x [row, column] = value;
        }

        public double [,] Components
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

        protected Matrix (int height, int width)
        {
            _x = new double [height, width];
        }

        public Matrix (int height, int width, params double [] x) : this (height, width)
        {
            throw new NotImplementedException ();
        }

        public Matrix (double [,] x) : this (x.GetLength (0), x.GetLength (1))
        {
            throw new NotImplementedException ();
        }

        public Matrix (Matrix other) : this (other._x)
        {
        }

        public virtual object Clone ()
        {
            return new Matrix (this);
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

        private static bool AreSuitableForAddition (Matrix m1, Matrix m2)
        {
            return ((m1.Height == m2.Height) &&
                    (m1.Width  == m2.Width));
        }

        private static bool AreSuitableForMultiplication (Matrix m1, Matrix m2)
        {
            return (m1.Width == m2.Height);
        }

        private static bool AreSuitableForMultiplication (Matrix m, Vector v)
        {
            return (m.Width == v.Dimension);
        }

        private static bool AreSuitableForMultiplication (Vector v, Matrix m)
        {
            return (v.Dimension == m.Height);
        }

        public static Matrix operator + (Matrix m1, Matrix m2)
        {
            if (AreSuitableForAddition (m1, m2))
            {
                Matrix result = new Matrix (m1.Height, m1.Width);

                result._x = m1._x.Add (m2._x);

                return result;
            }

            else throw new MatricesNotForAdditionException ();
        }

        public static Matrix operator - (Matrix m1, Matrix m2)
        {
            if (AreSuitableForAddition (m1, m2))
            {
                Matrix result = new Matrix (m1.Height, m1.Width);

                result._x = m1._x.Subtract (m2._x);

                return result;
            }

            else throw new MatricesNotForAdditionException ();
        }

        public static Matrix operator - (Matrix m)
        {
            Matrix result = new Matrix (m.Height, m.Width);

            result._x = m._x.Negate ();

            return result;
        }

        public static Matrix operator * (Matrix m, double coefficient)
        {
            Matrix result = new Matrix (m.Height, m.Width);

            result._x = m._x.Multiply (coefficient);

            return result;
        }

        public static Matrix operator * (double coefficient, Matrix m)
        {
            return m * coefficient;
        }

        public static Matrix operator / (Matrix m, double coefficient)
        {
            Matrix result = new Matrix (m.Height, m.Width);

            result._x = m._x.Divide (coefficient);

            return result;
        }

        public static Matrix operator * (Matrix m1, Matrix m2)
        {
            if (AreSuitableForMultiplication (m1, m2))
            {
                return MatrixAlgorithm.ConventionalMultiplication (m1, m2);
            }

            else throw new MatricesNotForMultiplicationException ();
        }

        public static Vector operator * (Matrix m, Vector v)
        {
            if (AreSuitableForMultiplication (m, v))
            {
                throw new NotImplementedException ();
            }

            else throw new MatricesNotForMultiplicationException ();
        }

        public static Vector operator * (Vector v, Matrix m)
        {
            if (AreSuitableForMultiplication (v, m))
            {
                throw new NotImplementedException ();
            }

            else throw new MatricesNotForMultiplicationException ();
        }
    }
}