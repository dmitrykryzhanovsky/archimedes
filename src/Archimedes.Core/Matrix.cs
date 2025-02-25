﻿namespace Archimedes
{
    public class Matrix : ICloneable
    {
        protected readonly double [,] _x;

        public double this [int row, int column]
        {
            get => _x [row, column];

            set => _x [row, column] = value;
        }

        public virtual int Height
        {
            get => _x.GetLength (0);
        }

        public virtual int Width
        {
            get => _x.GetLength (1);
        }

        #region Constructors

        protected Matrix (int height, int width)
        {
            _x = new double [height, width];
        }

        public Matrix (double [,] x) : this (x.GetLength (0), x.GetLength (1))
        {
            x.CopyTo (_x);
        }

        public Matrix (Matrix other) : this (other._x)
        {
        }

        public virtual object Clone ()
        {
            return new Matrix (this);
        }

        #endregion
    }
}