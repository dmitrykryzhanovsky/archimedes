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

        #region Comparisons

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

        #endregion

        public static Matrix operator + (Matrix m1, Matrix m2)
        {
            if ((m1.Height == m2.Height) && (m1.Width == m2.Width))
            {
                Matrix output = new Matrix (m1.Height, m1.Width);

                m1._x.Add (m2._x, ref output._x);

                return output;
            }

            else throw new ArithmeticException ();
        }

        public static Matrix operator - (Matrix m1, Matrix m2)
        {
            if ((m1.Height == m2.Height) && (m1.Width == m2.Width))
            {
                Matrix output = new Matrix (m1.Height, m1.Width);

                m1._x.Subtract (m2._x, ref output._x);

                return output;
            }

            else throw new ArithmeticException ();
        }

        public static Matrix operator - (Matrix m)
        {
            Matrix output = new Matrix (m.Height, m.Width);

            m._x.Negate (ref output._x);

            return output;
        }

        public static Matrix operator * (Matrix m, double coefficient)
        {
            Matrix output = new Matrix (m.Height, m.Width);

            m._x.Multiply (coefficient, ref output._x);

            return output;
        }

        public static Matrix operator * (double coefficient, Matrix m)
        {
            return m * coefficient;
        }

        public static Matrix operator / (Matrix m, double coefficient)
        {
            Matrix output = new Matrix (m.Height, m.Width);

            m._x.Divide (coefficient, ref output._x);

            return output;
        }

        public static Matrix operator * (Matrix m1, Matrix m2)
        {
            if (m1.Width == m2.Height)
            {
                Matrix output = new Matrix (m1.Height, m2.Width);

                MatrixAlgorithm.StandardMultiplication (m1._x, m2._x, ref output._x, m1.Height, m2.Width, m1.Width);

                return output;
            }

            else throw new ArithmeticException ();
        }
    }
}