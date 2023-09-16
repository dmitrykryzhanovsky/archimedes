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
                    result [i] = v1 [i] + v2 [i];
                }

                return result;
            }

            else throw new IncompatibleVectorException ();
        }

        public static Vector operator - (Vector v1, Vector v2)
        {
            if (v1.Dimension == v2.Dimension)
            {
                Vector result = new Vector (v1.Dimension);

                for (int i = 0; i < v1.Dimension; i++)
                {
                    result [i] = v1 [i] - v2 [i];
                }

                return result;
            }

            else throw new IncompatibleVectorException ();
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
            return v1.DotProduct (v2);
        }

        public double DotProduct (Vector other)
        {
            if (Dimension == other.Dimension) return ComputeDotProduct (other);

            else throw new IncompatibleVectorException ();
        }

        private double ComputeDotProduct (Vector other)
        {
            double result = 0.0;

            for (int i = 0; i < Dimension; i++)
            {
                result += this [i] * other [i];
            }

            return result;
        }

        public virtual double GetNorm2 ()
        {
            return ComputeDotProduct (this);
        }

        public double GetLength ()
        {
            return Math.Sqrt (GetNorm2 ());
        }
    }
}