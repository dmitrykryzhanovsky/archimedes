﻿namespace Archimedes
{
    /// <summary>
    /// 2-мерный вектор в декартовых координатах.
    /// </summary>
    public class Vector2 : Vector, IEquatable<Vector2>
    {
        private const int Vector2Dimension = 2;

        public double X
        {
            get => _x [0];

            set => _x [0] = value;
        }

        public double Y
        {
            get => _x [1];

            set => _x [1] = value;
        }

        public override int Dimension
        {
            get => Vector2Dimension;
        }

        #region constructors

        public Vector2 (double x, double y) : base (Vector2Dimension)
        {
            _x [0] = x;
            _x [1] = y;
        }

        public Vector2 (Vector2 other) : this (other._x [0], other._x [1])
        {
        }

        public override object Clone ()
        {
            return new Vector2 (this);
        }

        #endregion

        #region comparison

        public override bool Equals (object? obj)
        {
            return Equals (obj as Vector2);
        }

        public bool Equals (Vector2? other)
        {
            return ((_x [0] == other._x [0]) && (_x [1] == other._x [1]));
        }

        public static bool operator == (Vector2 v1, Vector2 v2)
        {
            return v1.Equals (v2);
        }

        public static bool operator != (Vector2 v1, Vector2 v2)
        {
            return !v1.Equals (v2);
        }

        #endregion

        #region operators

        public static Vector2 operator + (Vector2 v1, Vector2 v2)
        {
            return new Vector2 (v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector2 operator - (Vector2 v1, Vector2 v2)
        {
            return new Vector2 (v1.X - v2.X, v1.Y - v2.Y);
        }

        public static Vector2 operator - (Vector2 v)
        {
            return new Vector2 (-v.X, -v.Y);
        }

        public static Vector2 operator * (Vector2 v, double coefficient)
        {
            return new Vector2 (v.X * coefficient, v.Y * coefficient);
        }

        public static Vector2 operator * (double coefficient, Vector2 v)
        {
            return new Vector2 (v.X * coefficient, v.Y * coefficient);
        }

        public static Vector2 operator / (Vector2 v, double coefficient)
        {
            return new Vector2 (v.X / coefficient, v.Y / coefficient);
        }

        public static double operator * (Vector2 v1, Vector2 v2)
        {
            return DotProduct (v1, v2);
        }

        #endregion

        /// <summary>
        /// Скалярное произведение векторов v1 и v2.
        /// </summary>
        public static double DotProduct (Vector2 v1, Vector2 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        public override double GetNorm2 ()
        {
            return _x [0] * _x [0] + _x [1] * _x [1];
        }

        public override double GetLength ()
        {
            return double.Hypot (_x [0], _x [1]);
        }
    }
}