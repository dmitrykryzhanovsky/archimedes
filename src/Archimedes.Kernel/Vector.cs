using System;

namespace Archimedes
{
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

        public bool Equals (Vector2? other)
        {
            return ((Dimension == 2) &&
                    (_x.EqualsTwoItems (other._x)));
        }

        public bool Equals (Vector3? other)
        {
            return ((Dimension == 3) &&
                    (_x.EqualsThreeItems (other._x)));
        }

        public bool Equals (Vector? other)
        {
            return ((Dimension == other.Dimension) &&
                    (ArrayExtension.Equals (_x, other._x)));
        }

        public override bool Equals (object? other)
        {
            if (other is Vector) return Equals (other as Vector);

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

        public static double operator * (Vector v1, Vector v2)
        {
            return v1.DotProduct (v2);
        }

        public double DotProduct (Vector other)
        {
            if (VectorAlgorithm.AreSuitableForAlgebra (this, other))
            {
                return _x.InnerProduct (other._x);
            }

            else throw new IncompatibleVectorException (this, other);
        }

        public virtual double GetNorm2 ()
        {
            return _x.SumOfSquares ();
        }

        public double GetLength ()
        {
            return Math.Sqrt (GetNorm2 ());
        }
    }
}