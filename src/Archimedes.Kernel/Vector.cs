using System;

namespace Archimedes
{
    /// <summary>
    /// Вектор произвольного размера.
    /// </summary>
    public class Vector : ICloneable, IEquatable<Vector>, IDotProductable<Vector>
    {
        protected double [] _x;

        public double this [int index]
        {
            get => _x [index];
            set => _x [index] = value;
        }

        /// <summary>
        /// Возвращает размер вектора.
        /// </summary>
        public virtual int Dimension
        {
            get => _x.Length;
        }

        /// <summary>
        /// Возвращает компоненты вектора.
        /// </summary>
        public double [] Components
        {
            get => _x;
        }

        /// <summary>
        /// Создаёт вектор размера dimension, не инициализируя его элементы.
        /// </summary>
        public Vector (int dimension)
        {
            _x = new double [dimension];
        }

        public Vector (params double [] x) : this (x.Length)
        {
            x.CopyTo (_x, 0);
        }

        public Vector (Vector other) : this (other._x)
        {
        }

        public virtual object Clone ()
        {
            return new Vector (this);
        }

        /// <summary>
        /// Преобразует вектор v размером Dimension в матрицу-столбец размером {Dimension x 1}.
        /// </summary>
        public static explicit operator Matrix (Vector v)
        {
            return new Matrix (v.Dimension, v.Components);
        }

        public bool Equals (Vector? other)
        {
            return _x.Equals<double> (other._x);
        }

        public override bool Equals (object? other)
        {
            if (other is Vector) return Equals (other as Vector);
            else throw new InvalidCastException ();
        }

        public override int GetHashCode ()
        {
            return _x.GetHashCode ();
        }

        public static bool operator == (Vector v1, Vector v2)
        {
            return v1.Equals (v2);
        }

        public static bool operator != (Vector v1, Vector v2)
        {
            return !v1.Equals (v2);
        }

        public static Vector operator + (Vector v1, Vector v2)
        {
            if (v1.Dimension == v2.Dimension)
            {
                Vector result = new Vector (v1.Dimension);

                for (int i = 0; i < v1.Dimension; i++)
                {
                    result._x [i] = v1._x [i] + v2._x [i];
                }

                return result;
            }

            else throw new VectorNotCompatibleException ();
        }

        public static Vector operator - (Vector v1, Vector v2)
        {
            if (v1.Dimension == v2.Dimension)
            {
                Vector result = new Vector (v1.Dimension);

                for (int i = 0; i < v1.Dimension; i++)
                {
                    result._x [i] = v1._x [i] - v2._x [i];
                }

                return result;
            }

            else throw new VectorNotCompatibleException ();
        }

        public static Vector operator - (Vector v)
        {
            Vector result = new Vector (v.Dimension);

            for (int i = 0; i < v.Dimension; i++)
            {
                result._x [i] = -v._x [i];
            }

            return result;
        }

        public static Vector operator * (Vector v, double coefficient)
        {
            Vector result = new Vector (v.Dimension);

            for (int i = 0; i < v.Dimension; i++)
            {
                result._x [i] = v._x [i] * coefficient;
            }

            return result;
        }

        public static Vector operator * (double coefficient, Vector v)
        {
            return v * coefficient;
        }

        public static Vector operator / (Vector v, double coefficient)
        {
            Vector result = new Vector (v.Dimension);

            for (int i = 0; i < v.Dimension; i++)
            {
                result._x [i] = v._x [i] / coefficient;
            }

            return result;
        }

        public static double operator * (Vector v1, Vector v2)
        {
            return v1.DotProduct (v2);
        }

        public static Vector operator * (Matrix m1, Vector v2) // mx1
        {
            if (m1.Width == v2.Dimension)
            {
                Vector result = new Vector (m1.Height);

                for (int i = 0; i < m1.Height; i++)
                {
                    double sum = 0.0;

                    for (int j = 0; j < m1.Width; j++)
                    {
                        sum += m1 [i, j] * v2 [j];
                    }

                    result [i] = sum;
                }

                return result;
            }

            else throw new MatrixNotCompatibleException ();
        }
        public static Vector operator * (Vector v1, Matrix m2) // 1xn
        {
            if (v1.Dimension == m2.Height)
            {
                Vector result = new Vector (m2.Width);

                for (int j = 0; j < m2.Width; j++)
                {
                    double sum = 0.0;

                    for (int i = 0; i < m2.Height; i++)
                    {
                        sum += v1 [i] * m2 [i, j];
                    }

                    result [j] = sum;
                }

                return result;
            }

            else throw new MatrixNotCompatibleException ();
        }

        /// <summary>
        /// Возвращает скалярное произведение текущего вектора и вектора other.
        /// </summary>
        /// <exception cref="VectorNotCompatibleException">Текущий вектор и вектор other должны иметь одинаковый размер. В противном 
        /// случае генерируется исключение VectorNotCompatibleException.</exception>
        public virtual double DotProduct (Vector other)
        {
            if (Dimension == other.Dimension)
            {
                return _x.DotProduct (other._x);
            }

            else throw new VectorNotCompatibleException ();
        }

        /// <summary>
        /// Возвращает квадрат длины вектора.
        /// </summary>
        public double GetNorm2 ()
        {
            return DotProduct (this);
        }

        /// <summary>
        /// Возвращает длину вектора.
        /// </summary>
        public double GetLength ()
        {
            return Math.Sqrt (GetNorm2 ());
        }
    }
}