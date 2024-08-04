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
        /// Возвращает массив координат вектора.
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

        #region Constructors

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

        #endregion

        #region Comparison

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

        public override bool Equals (object? obj)
        {
            return Equals (obj as Vector);
        }

        public override int GetHashCode ()
        {
            return _x.GetHashCode ();
        }

        #endregion

        public static Vector operator + (Vector v1, Vector v2)
        {
            if (v1.Dimension != v2.Dimension) throw new ArithmeticException ();

            Vector result = new Vector (v1.Dimension);

            v1._x.Add (v2._x, result._x);

            return result;
        }

        public static Vector operator - (Vector v1, Vector v2)
        {
            if (v1.Dimension != v2.Dimension) throw new ArithmeticException ();

            Vector result = new Vector (v1.Dimension);

            v1._x.Subtract (v2._x, result._x);

            return result;
        }

        public static Vector operator - (Vector v)
        {
            Vector result = new Vector (v.Dimension);

            v._x.Negate (result._x);

            return result;
        }

        public static Vector operator * (Vector v, double coefficient)
        {
            Vector result = new Vector (v.Dimension);

            v._x.Multiply (coefficient, result._x);

            return result;
        }

        public static Vector operator * (double coefficient, Vector v)
        {
            Vector result = new Vector (v.Dimension);

            v._x.Multiply (coefficient, result._x);

            return result;
        }

        public static Vector operator / (Vector v, double coefficient)
        {
            Vector result = new Vector (v.Dimension);

            v._x.Divide (coefficient, result._x);

            return result;
        }

        public static double operator * (Vector v1, Vector v2)
        {
            if (v1.Dimension != v2.Dimension) throw new ArithmeticException ();

            return v1._x.InnerProduct (v2._x);
        }

        /// <summary>
        /// Возвращает длину вектора.
        /// </summary>
        public virtual double GetLength ()
        {
            return double.Sqrt (GetNorm2 ());
        }

        /// <summary>
        /// Возвращает квадрат длины вектора.
        /// </summary>
        public virtual double GetNorm2 ()
        {
            return _x.SumOfSquares ();
        }
    }
}