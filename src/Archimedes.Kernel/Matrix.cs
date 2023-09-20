using System;

namespace Archimedes
{
    /// <summary>
    /// Матрица произвольного размера.
    /// </summary>
    public class Matrix : ICloneable
    {
        protected readonly double [] _x;

        private readonly int _height;
        private readonly int _width;

        public double this [int row, int column]
        {
            get => _x [_width * row + column];
            set => _x [_width * row + column] = value;
        }

        public virtual int Height
        {
            get => _height;
        }

        public virtual int Width
        {
            get => _width;
        }

        public double [] Items
        {
            get => _x;
        }

        public Matrix (int height, int width)
        {
            _x = new double [height * width];

            _height = height;
            _width  = width;
        }

        public Matrix (int height, int width, params double [] x) : this (height, width)
        {
            x.CopyTo (_x, 0);
        }

        public Matrix (double [,] x) : this (x.GetLength (0), x.GetLength (1))
        {
            int iterator = 0;

            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    _x [iterator++] = x [i, j];
                }
            }
        }

        public Matrix (Matrix other) : this (other._height, other._width, other._x)
        {
        }

        public virtual object Clone ()
        {
            return new Matrix (this);
        }
    }
}