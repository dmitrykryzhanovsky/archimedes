﻿namespace Archimedes
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
        public int Dimension
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

        public object Clone ()
        {
            return new Vector (this);
        }

        #endregion

        #region Comparison

        public bool Equals (Vector? other)
        {
            return _x.Equals<double> (other._x);
        }

        public static bool operator== (Vector v1, Vector v2)
        {
            return v1.Equals (v2);
        }

        public static bool operator != (Vector v1, Vector v2)
        {
            return !v1.Equals (v2);
        }

        #endregion
    }
}