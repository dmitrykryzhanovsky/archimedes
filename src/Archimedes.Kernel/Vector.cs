namespace Archimedes
{
    public class Vector : ICloneable, IEquatable<Vector>
    {
        protected double [] _x;

        public double this [int index]
        {
            get => _x [index];

            set => _x [index] = value;
        }

        public double [] Components
        {
            get => _x;
        }

        public virtual int Dimension
        {
            get => _x.Length;
        }

        #region Constructors

        protected Vector (int dimension)
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

        #endregion

        #region Comparisons

        public bool Equals (Vector? other)
        {
            return _x.Equals<double> (other._x);
        }

        public static bool operator == (Vector v1, Vector v2)
        {
            return v1.Equals (v2);
        }

        public static bool operator != (Vector v1, Vector v2)
        {
            return !v1.Equals (v2);
        }

        #endregion

        public static Vector operator + (Vector v1, Vector v2)
        {
            if (v1.Dimension == v2.Dimension)
            {
                Vector output = new Vector (v1.Dimension);

                for (int i = 0; i < v1.Dimension; i++)
                {
                    output [i] = v1 [i] + v2 [i];
                }

                return output;
            }

            else throw new ArithmeticException ();
        }

        public static Vector operator - (Vector v1, Vector v2)
        {
            if (v1.Dimension == v2.Dimension)
            {
                Vector output = new Vector (v1.Dimension);

                for (int i = 0; i < v1.Dimension; i++)
                {
                    output [i] = v1 [i] - v2 [i];
                }

                return output;
            }

            else throw new ArithmeticException ();
        }

        public static Vector operator - (Vector v)
        {
            Vector output = new Vector (v.Dimension);

            for (int i = 0; i < v.Dimension; i++)
            {
                output [i] = -v [i];
            }

            return output;
        }

        public static Vector operator * (Vector v, double coefficient)
        {
            Vector output = new Vector (v.Dimension);

            for (int i = 0; i < v.Dimension; i++)
            {
                output [i] = v [i] * coefficient;
            }

            return output;
        }

        public static Vector operator * (double coefficient, Vector v)
        {
            return v * coefficient;
        }

        public static Vector operator / (Vector v, double coefficient)
        {
            Vector output = new Vector (v.Dimension);

            for (int i = 0; i < v.Dimension; i++)
            {
                output [i] = v [i] / coefficient;
            }

            return output;
        }

        /// <summary>
        /// Возвращает скалярное произведение векторов.
        /// </summary>
        /// <remarks>Векторы v1 и v2 должны иметь одинаковую размерность. В противном случае будет сгенерировано исключение.</remarks>
        /// <exception cref="ArithmeticException">Генерируется, если векторы v1 и v2 имеют разную размерность.</exception>
        public static double operator * (Vector v1, Vector v2)
        {
            if (v1.Dimension == v2.Dimension)
            {
                return v1.Components.InnerProduct (v2.Components);
            }

            else throw new ArithmeticException ();
        }

        /// <summary>
        /// Возвращает квадрат нормы вектора.
        /// </summary>
        public virtual double GetNorm2 ()
        {
            return _x.SumOfSquares ();
        }

        /// <summary>
        /// Возвращает длину вектора.
        /// </summary>
        public virtual double GetLength ()
        {
            return double.Sqrt (GetNorm2 ());
        }
    }
}