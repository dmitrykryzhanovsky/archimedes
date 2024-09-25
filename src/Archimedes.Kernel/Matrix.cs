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

                for (int i = 0; i < m1.Height; i++)
                {
                    for (int j = 0; j < m1.Width; j++)
                    {
                        output [i, j] = m1 [i, j] + m2 [i, j];
                    }
                }

                return output;
            }

            else throw new ArithmeticException ();
        }

        public static Matrix operator - (Matrix m1, Matrix m2)
        {
            if ((m1.Height == m2.Height) && (m1.Width == m2.Width))
            {
                Matrix output = new Matrix (m1.Height, m1.Width);

                for (int i = 0; i < m1.Height; i++)
                {
                    for (int j = 0; j < m1.Width; j++)
                    {
                        output [i, j] = m1 [i, j] - m2 [i, j];
                    }
                }

                return output;
            }

            else throw new ArithmeticException ();
        }

        public static Matrix operator - (Matrix m)
        {
            Matrix output = new Matrix (m.Height, m.Width);

            for (int i = 0; i < m.Height; i++)
            {
                for (int j = 0; j < m.Width; j++)
                {
                    output [i, j] = -m [i, j];
                }
            }

            return output;
        }

        public static Matrix operator * (Matrix m, double coefficient)
        {
            Matrix output = new Matrix (m.Height, m.Width);

            for (int i = 0; i < m.Height; i++)
            {
                for (int j = 0; j < m.Width; j++)
                {
                    output [i, j] = m [i, j] * coefficient;
                }
            }

            return output;
        }

        public static Matrix operator * (double coefficient, Matrix m)
        {
            return m * coefficient;
        }

        public static Matrix operator / (Matrix m, double coefficient)
        {
            Matrix output = new Matrix (m.Height, m.Width);

            for (int i = 0; i < m.Height; i++)
            {
                for (int j = 0; j < m.Width; j++)
                {
                    output [i, j] = m [i, j] / coefficient;
                }
            }

            return output;
        }
    }
}