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