﻿namespace Archimedes
{
    public class Vector : ICloneable, IEquatable<Vector>
    {
        protected double [] _x;

        public double this [int index]
        {
            get => _x [index];

            set => _x [index] = value;
        }

        public double [] Components
        {
            get => _x;
        }

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

        public static double operator * (Vector v1, Vector v2)
        {
            if (v1.Dimension == v2.Dimension)
            {
                return v1.Components.InnerProduct (v2.Components);
            }

            else throw new ArithmeticException ();
        }

        public virtual double GetNorm2 ()
        {
            return _x.SumOfSquares ();
        }

        public virtual double GetLength ()
        {
            return double.Sqrt (GetNorm2 ());
        }
    }
}