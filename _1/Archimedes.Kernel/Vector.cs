namespace Archimedes
{
    /// <summary>
    /// Вектор произвольного размера.
    /// </summary>
    public class Vector : ICloneable, IEquatable<Vector>, IEquatable<Vector2>, IEquatable<Vector3>, IDotProductable<Vector>
    {
        protected readonly double [] _x;

        public double this [int index]
        {
            get => _x [index];
            set => _x [index] = value;
        }

        public virtual int Dimension
        {
            get => _x.Length;
        }

        /// <summary>
        /// Возвращает массив элементов вектора.
        /// </summary>
        public double [] Items
        {
            get => _x;
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

        #region Relations

        /// <summary>
        /// Возвращает true, если количество элементов в текущем векторе равно 2 и его элементы равны элементам вектора other. 
        /// В противном случае false.
        /// </summary>
        public bool Equals (Vector2? other)
        {
            return ((Dimension == 2) &&
                    (_x.Equals2 (other._x)));
        }

        /// <summary>
        /// Возвращает true, если количество элементов в текущем векторе равно 3 и его элементы равны элементам вектора other. 
        /// В противном случае false.
        /// </summary>
        public bool Equals (Vector3? other)
        {
            return ((Dimension == 3) &&
                    (_x.Equals3 (other._x)));
        }

        public bool Equals (Vector? other)
        {
            return ((Dimension == other.Dimension) &&
                    (ArrayExtension.Equals (_x, other._x)));
        }

        public override bool Equals (object? other)
        {
            if (other is Vector2) return Equals (other as Vector2);
            
            else if (other is Vector3) return Equals (other as Vector3);

            else if (other is Vector) return Equals (other as Vector);

            else return false;
        }

        public override int GetHashCode ()
        {
            return _x.GetHashCode ();
        }

        public static bool operator == (Vector v1, Vector v2)
        {
            return v1.Equals (v2);
        }

        public static bool operator != (Vector m1, Vector m2)
        {
            return !m1.Equals (m2);
        }

        #endregion

        public static Vector operator + (Vector v1, Vector v2)
        {
            if (VectorAlgorithm.AreSuitableForAlgebra (v1, v2))
            {
                Vector result = new Vector (v1.Dimension);

                result._x.Add (v1._x, v2._x);

                return result;
            }

            else throw new IncompatibleVectorException (v1, v2);
        }

        public static Vector operator - (Vector v1, Vector v2)
        {
            if (VectorAlgorithm.AreSuitableForAlgebra (v1, v2))
            {
                Vector result = new Vector (v1.Dimension);

                result._x.Subtract (v1._x, v2._x);

                return result;
            }

            else throw new IncompatibleVectorException (v1, v2);
        }

        public static Vector operator - (Vector v)
        {
            Vector result = new Vector (v.Dimension);

            result._x.Negate (v._x);

            return result;
        }

        public static Vector operator * (Vector v, double coefficient)
        {
            Vector result = new Vector (v.Dimension);

            result._x.Multiply (v._x, coefficient);

            return result;
        }

        public static Vector operator * (double coefficient, Vector v)
        {
            return v * coefficient;
        }

        public static Vector operator / (Vector v, double coefficient)
        {
            Vector result = new Vector (v.Dimension);

            result._x.Divide (v._x, coefficient);

            return result;
        }

        /// <summary>
        /// Скалярное произведение векторов v1 и v2.
        /// </summary>
        /// <exception cref="IncompatibleVectorException">Генерируется, если размерности векторов – v1 и v2 – не совпадают.</exception>
        public static double operator * (Vector v1, Vector v2)
        {
            return v1.DotProduct (v2);
        }

        /// <summary>
        /// Скалярное произведение текущего вектора и вектора other.
        /// </summary>
        /// <exception cref="IncompatibleVectorException">Генерируется, если размерности векторов – текущего и other – не совпадают.</exception>
        public double DotProduct (Vector other)
        {
            if (VectorAlgorithm.AreSuitableForAlgebra (this, other))
            {
                return _x.InnerProduct (other._x);
            }

            else throw new IncompatibleVectorException (this, other);
        }

        /// <summary>
        /// Возвращает квадрат длины вектора.
        /// </summary>
        public virtual double GetNorm2 ()
        {
            return _x.SumOfSquares ();
        }

        /// <summary>
        /// Возвращает длину вектора.
        /// </summary>
        public double GetLength ()
        {
            return Double.Sqrt (GetNorm2 ());
        }
    }
}