using System;

namespace Archimedes
{
    /// <summary>
    /// Матрица произвольного размера.
    /// </summary>
    public class Matrix : ICloneable, IEquatable<Matrix>, IEquatable<Matrix2>
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

        /// <summary>
        /// Возвращает одномерный массив элементов матрицы.
        /// </summary>
        /// <remarks>Внутри объекта типа Matrix элементы хранятся в виде одномерного массива (сначала 0-я строка, потом 1-я и т.д.), так 
        /// как это позволяет более оптимально организовать вычисления.</remarks>
        public double [] Items
        {
            get => _x;
        }

        #region Constructors

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

        #endregion

        public bool Equals (Matrix? other)
        {
            return ((_height == other._height) &&
                    (_width  == other._width)  &&
                    (_x.EqualsByItems (other._x)));
        }

        public bool Equals (Matrix2? other)
        {
            return ((_height == 2) &&
                    (_width  == 2) &&
                    (_x.EqualsFourItems (other._x)));
        }

        // TODO: vector x matrix
        // TODO: matrix x vector
    }
}