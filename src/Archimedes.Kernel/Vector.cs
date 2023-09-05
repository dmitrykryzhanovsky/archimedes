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

        public static explicit operator Matrix (Vector v)
        {
            return new Matrix (v.Dimension, v.Components);
        }

        public bool Equals (Vector? other)
        {
            throw new NotImplementedException ();
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
            throw new NotImplementedException ();
        }

        public static Vector operator - (Vector v1, Vector v2)
        {
            throw new NotImplementedException ();
        }

        public static Vector operator - (Vector v)
        {
            throw new NotImplementedException ();
        }

        public static Vector operator * (Vector v, double coefficient)
        {
            throw new NotImplementedException ();
        }

        public static Vector operator * (double coefficient, Vector v)
        {
            throw new NotImplementedException ();
        }

        public static Vector operator / (Vector v, double coefficient)
        {
            throw new NotImplementedException ();
        }

        public static double operator * (Vector v1, Vector v2)
        {
            return v1.DotProduct (v2);
        }

        public static Vector operator * (Matrix m1, Vector v2)
        {
            throw new NotImplementedException ();
        }
        public static Vector operator * (Vector v1, Matrix m2)
        {
            throw new NotImplementedException ();
        }

        public double DotProduct (Vector other)
        {
            throw new NotImplementedException ();
        }

        public virtual double GetNorm2 ()
        {
            throw new NotImplementedException ();
        }

        public double GetLength ()
        {
            return Math.Sqrt (GetNorm2 ());
        }
    }
}