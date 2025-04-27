namespace Archimedes
{
    public class Vector : ICloneable, IEquatable<Vector>
    {
        protected readonly double [] _x;

        public double this [int index]
        {
            get => _x [index];

            set => _x [index] = value;
        }

        /// <summary>
        /// Возвращает координаты (компоненты) вектора.
        /// </summary>
        public double [] Coordinates
        {
            get => _x;
        }

        /// <summary>
        /// Возвращает размерность вектора.
        /// </summary>
        public virtual int Dimension
        {
            get => _x.Length;
        }

        #region constructors

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

        #region comparison

        public override bool Equals (object? obj)
        {
            return Equals (obj as Vector);
        }

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

        public override int GetHashCode ()
        {
            return _x.GetHashCode ();
        }

        #endregion

        #region operators

        public static Vector operator + (Vector v1, Vector v2)
        {
            CheckDimension (v1, v2);

            Vector result = new Vector (v1.Dimension);

            for (int i = 0; i < v1.Dimension; i++)
            {
                result [i] = v1 [i] + v2 [i];
            }

            return result;
        }

        public static Vector operator - (Vector v1, Vector v2)
        {
            CheckDimension (v1, v2);

            Vector result = new Vector (v1.Dimension);

            for (int i = 0; i < v1.Dimension; i++)
            {
                result [i] = v1 [i] - v2 [i];
            }

            return result;
        }

        public static Vector operator - (Vector v)
        {
            Vector result = new Vector (v.Dimension);

            for (int i = 0; i < v.Dimension; i++)
            {
                result [i] = -v [i];
            }

            return result;
        }

        public static Vector operator * (Vector v, double coefficient)
        {
            Vector result = new Vector (v.Dimension);

            for (int i = 0; i < v.Dimension; i++)
            {
                result [i] = v [i] * coefficient;
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
                result [i] = v [i] / coefficient;
            }

            return result;
        }

        public static double operator * (Vector v1, Vector v2)
        {
            return DotProduct (v1, v2);
        }

        #endregion

        public static double DotProduct (Vector v1, Vector v2)
        {
            CheckDimension (v1, v2);

            return v1._x.DotProduct (v2._x);
        }

        private static void CheckDimension (Vector v1, Vector v2)
        {
            if (v1.Dimension != v2.Dimension) throw new InvalidOperationException ();
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