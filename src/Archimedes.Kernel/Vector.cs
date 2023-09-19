using System;

namespace Archimedes
{
    public class Vector : ICloneable, IEquatable<Vector>, IDotProductable<Vector>
    {
        protected double [] _x;

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

        public Matrix ConvertToColumnMatrix ()
        {
            return new Matrix (Dimension, 1, _x);
        }

        public Matrix ConvertToRowMatrix ()
        {
            return new Matrix (1, Dimension, _x);
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

                v1._x.Add (v2._x, result._x);

                return result;
            }

            else throw new IncompatibleVectorException ();
        }

        public static Vector operator - (Vector v1, Vector v2)
        {
            if (v1.Dimension == v2.Dimension)
            {
                Vector result = new Vector (v1.Dimension);

                v1._x.Subtract (v2._x, result._x);

                return result;
            }

            else throw new IncompatibleVectorException ();
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
            return v * coefficient;
        }

        public static Vector operator / (Vector v, double coefficient)
        {
            Vector result = new Vector (v.Dimension);

            v._x.Divide (coefficient, result._x);

            return result;
        }

        public static double operator * (Vector v1, Vector v2)
        {
            return v1.DotProduct (v2);
        }

        public double DotProduct (Vector other)
        {
            if (Dimension == other.Dimension) return _x.InnerProduct (other._x);

            else throw new IncompatibleVectorException ();
        }

        public virtual double GetNorm2 ()
        {
            return _x.InnerProduct (_x);
        }

        public double GetLength ()
        {
            return Math.Sqrt (GetNorm2 ());
        }
    }
}