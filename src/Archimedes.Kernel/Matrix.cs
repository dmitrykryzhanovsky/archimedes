using System;

namespace Archimedes
{
    /// <summary>
    /// Матрица произвольного размера.
    /// </summary>
    public class Matrix : ICloneable, IEquatable<Matrix>, IEquatable<Matrix2>, IEquatable<Matrix3>
    {
        protected readonly double [] _x;

        private readonly int _height;
        private readonly int _width;

        public double this [int row, int column]
        {
            get => _x [_width * row + column];
            set => _x [_width * row + column] = value;
        }

        public virtual int Height
        {
            get => _height;
        }

        public virtual int Width
        {
            get => _width;
        }

        /// <summary>
        /// Возвращает одномерный массив элементов матрицы.
        /// </summary>
        /// <remarks>Внутри объекта типа Matrix элементы хранятся в виде одномерного массива (сначала 0-я строка, потом 1-я и т.д.), так 
        /// как это позволяет более оптимально организовать вычисления.</remarks>
        public double [] Items
        {
            get => _x;
        }

        #region Constructors

        public Matrix (int height, int width)
        {
            _x = new double [height * width];

            _height = height;
            _width  = width;
        }

        public Matrix (int height, int width, params double [] x) : this (height, width)
        {
            x.CopyTo (_x, 0);
        }

        public Matrix (double [,] x) : this (x.GetLength (0), x.GetLength (1))
        {
            int iterator = 0;

            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    _x [iterator++] = x [i, j];
                }
            }
        }

        public Matrix (Matrix other) : this (other._height, other._width, other._x)
        {
        }

        public virtual object Clone ()
        {
            return new Matrix (this);
        }

        #endregion

        #region Relations

        /// <summary>
        /// Возвращает true, если количество строк и столбцов в текущей матрице равно 2 (то есть фактически она является матрицей 
        /// 2 х 2), и её элементы равны элементам матрицы other. В противном случае false.
        /// </summary>
        public bool Equals (Matrix2? other)
        {
            return ((_height == 2) &&
                    (_width  == 2) &&
                    (_x.EqualsFourItems (other._x)));
        }

        /// <summary>
        /// Возвращает true, если количество строк и столбцов в текущей матрице равно 3 (то есть фактически она является матрицей 
        /// 3 х 3), и её элементы равны элементам матрицы other. В противном случае false.
        /// </summary>
        public bool Equals (Matrix3? other)
        {
            return ((_height == 3) &&
                    (_width  == 3) &&
                    (_x.EqualsNineItems (other._x)));
        }

        public bool Equals (Matrix? other)
        {
            return ((_height == other._height) &&
                    (_width  == other._width)  &&
                    (ArrayExtension.Equals (_x, other._x)));
        }

        public override bool Equals (object? other)
        {
            if (other is Matrix2) return Equals (other as Matrix2);

            else if (other is Matrix3) return Equals (other as Matrix3);

            else if (other is Matrix) return Equals (other as Matrix);

            else return false;
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

        public static Matrix operator + (Matrix m1, Matrix m2)
        {
            if (MatrixAlgorithm.AreSuitableForAddition (m1, m2))
            {
                Matrix result = new Matrix (m1.Height, m1.Width);

                result._x.Add (m1._x, m2._x);

                return result;
            }

            else throw new IncompatibleMatrixAdditionException (m1, m2);
        }

        public static Matrix operator - (Matrix m1, Matrix m2)
        {
            if (MatrixAlgorithm.AreSuitableForAddition (m1, m2))
            {
                Matrix result = new Matrix (m1.Height, m1.Width);

                result._x.Subtract (m1._x, m2._x);

                return result;
            }

            else throw new IncompatibleMatrixAdditionException (m1, m2);
        }

        public static Matrix operator - (Matrix m)
        {
            Matrix result = new Matrix (m.Height, m.Width);

            result._x.Negate (m._x);

            return result;
        }

        public static Matrix operator * (Matrix m, double coefficient)
        {
            Matrix result = new Matrix (m.Height, m.Width);

            result._x.Multiply (m._x, coefficient);

            return result;
        }

        public static Matrix operator * (double coefficient, Matrix m)
        {
            return m * coefficient;
        }

        public static Matrix operator / (Matrix m, double coefficient)
        {
            Matrix result = new Matrix (m.Height, m.Width);

            result._x.Divide (m._x, coefficient);

            return result;
        }

        public static Vector operator * (Vector v1, Matrix m2)
        {
            if (v1.Dimension == m2.Height)
            {
                Vector result = new Vector (m2.Width);

                for (int j = 0; j < m2.Width; j++)
                {
                    int m2Iterator = j;

                    double item = 0.0;

                    for (int k = 0; k < m2.Height; k++)
                    {
                        item       += v1 [k] * m2._x [m2Iterator];
                        m2Iterator += m2.Width;
                    }

                    result [j] = item;
                }

                return result;
            }

            else throw new IncompatibleMatrixMultiplicationException (v1, m2);
        }

        public static Vector operator * (Matrix m1, Vector v2)
        {
            if (m1.Width == v2.Dimension)
            {
                Vector result = new Vector (m1.Height);

                int m1Iterator = 0;

                for (int i = 0; i < m1.Height; i++)
                {
                    double item = 0.0;

                    for (int k = 0; k < m1.Width; k++)
                    {
                        item += m1._x [m1Iterator++] * v2 [k];
                    }

                    result [i] = item;
                }

                return result;
            }

            else throw new IncompatibleMatrixMultiplicationException (m1, v2);
        }

        public static Matrix operator * (Matrix m1, Matrix m2)
        {
            if (MatrixAlgorithm.AreSuitableForMultiplication (m1, m2))
            {
                Matrix result = new Matrix (m1.Height, m2.Width);

                MatrixAlgorithm.StandardMultiplication (result._x, m1._x, m2._x, result.Height, m1.Width, result.Width);

                return result;
            }

            else throw new IncompatibleMatrixMultiplicationException (m1, m2);
        }
    }
}