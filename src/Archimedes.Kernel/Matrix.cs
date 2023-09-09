﻿using System;

namespace Archimedes
{
    public class Matrix : ICloneable, IEquatable<Matrix>
    {
        protected double [,] _x;

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

        public double [,] Items
        {
            get => _x;
        }

        /// <summary>
        /// Создаёт матрицу размера height x width, не инициализируя её элементы.
        /// </summary>
        public Matrix (int height, int width)
        {
            _x = new double [height, width];
        }

        public Matrix (double [,] x) : this (x.GetLength (0), x.GetLength (1))
        {
            x.CopyTo (_x);
        }

        /// <summary>
        /// Создаёт матрицу высоты height, последовательно записывая в неё элементы массива x.
        /// </summary>
        /// <remarks>Ширина матрицы вычисляется автоматически как длина массива x / height.</remarks>
        public Matrix (int height, params double [] x) : this (height, x.Length / height)
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

        public bool Equals (Matrix? other)
        {
            return _x.Equals<double> (other._x);
        }

        public override bool Equals (object? other)
        {
            if (other is Matrix) return Equals (other as Matrix);
            else throw new InvalidCastException ();
        }

        public override int GetHashCode ()
        {
            return _x.GetHashCode ();
        }

        public static bool operator == (Matrix m1, Matrix m2)
        {
            return m1.Equals (m2);
        }

        public static bool operator != (Matrix m1, Matrix m2)
        {
            return !m1.Equals (m2);
        }

        public static Matrix operator + (Matrix m1, Matrix m2)
        {
            throw new NotImplementedException ();
        }

        public static Matrix operator - (Matrix m1, Matrix m2)
        {
            throw new NotImplementedException ();
        }

        public static Matrix operator - (Matrix m)
        {
            throw new NotImplementedException ();
        }

        public static Matrix operator * (Matrix m, double coefficient)
        {
            throw new NotImplementedException ();
        }

        public static Matrix operator * (double coefficient, Matrix m)
        {
            throw new NotImplementedException ();
        }

        public static Matrix operator / (Matrix m, double coefficient)
        {
            throw new NotImplementedException ();
        }

        public static Matrix operator * (Matrix m1, Matrix m2)
        {
            throw new NotImplementedException ();
        }        
    }
}