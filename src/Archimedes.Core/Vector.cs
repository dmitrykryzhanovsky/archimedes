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
        /// Возвращает массив координат (компонент) вектора.
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

        #region Comparison

        public bool Equals (Vector? other)
        {
            return _x.Equals<double> (other._x);
        }

        public override bool Equals (object? obj)
        {
            return (obj is Vector) ? Equals (obj as Vector) : base.Equals (obj);
        }

        public override int GetHashCode ()
        {
            return base.GetHashCode ();
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
            Vector result = new Vector (v1._x.Length);

            v1._x.Add (v2._x, result._x);

            return result;
        }

        public static Vector operator - (Vector v1, Vector v2)
        {
            Vector result = new Vector (v1._x.Length);

            v1._x.Subtract (v2._x, result._x);

            return result;
        }

        public static Vector operator - (Vector v)
        {
            Vector result = new Vector (v._x.Length);

            v._x.Negate (result._x);

            return result;
        }

        public static Vector operator * (Vector v, double coefficient)
        {
            Vector result = new Vector (v._x.Length);

            v._x.Multiply (coefficient, result._x);

            return result;
        }

        public static Vector operator * (double coefficient, Vector v)
        {
            return v * coefficient;
        }

        public static Vector operator / (Vector v, double coefficient)
        {
            Vector result = new Vector (v._x.Length);

            v._x.Divide (coefficient, result._x);

            return result;
        }

        public static double operator * (Vector v1, Vector v2)
        {
            return DotProduct (v1, v2);
        }

        public static double DotProduct (Vector v1, Vector v2)
        {
            return v1._x.InnerProduct (v2._x);
        }

        public virtual double GetNorm2 ()
        {
            return DotProduct (this, this);
        }

        public virtual double GetLength ()
        {
            return double.Sqrt (GetNorm2 ());
        }
    }
}