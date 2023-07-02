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

        public bool Equals (Vector? other)
        {
            throw new NotImplementedException ();
        }

        public override bool Equals (object? obj)
        {
            if (obj is Vector) return Equals ((Vector)obj);
            else return base.Equals (obj);
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

        /// <summary>
        /// Скалярное произведение текущего вектора на вектор <paramref name="other"/>.
        /// </summary>
        public double DotProduct (Vector other)
        {
            throw new NotImplementedException ();
        }

        /// <summary>
        /// Квадрат длины вектора.
        /// </summary>
        public virtual double GetNorm2 ()
        {
            throw new NotImplementedException ();
        }

        /// <summary>
        /// Длина вектора.
        /// </summary>
        public double GetLength ()
        {
            return Math.Sqrt (GetNorm2 ());
        }
    }
}