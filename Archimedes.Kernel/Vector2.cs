﻿using System;

namespace Archimedes
{
    /// <summary>
    /// 2-мерный вектор на евклидовой плоскости.
    /// </summary>
    public class Vector2 : Vector, IEquatable<Vector2>, IDotProductable<Vector2>
    {
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

        private Vector2 () : base (2)
        {
        }

        public Vector2 (double x, double y) : this ()
        {
            _x [0] = x;
            _x [1] = y;
        }

        public Vector2 (double [] x) : this (x [0], x [1])
        {
        }

        public Vector2 (Vector2 other) : this (other._x)
        {
        }

        public override object Clone ()
        {
            return new Vector2 (this);
        }

        public static explicit operator Vector2 (Complex z)
        {
            return new Vector2 (z.Re, z.Im);
        }

        public bool Equals (Vector2? other)
        {
            return ((X == other.X) && (Y == other.Y));
        }

        public override bool Equals (object? obj)
        {
            if (obj is Vector2) return Equals ((Vector2)obj);
            else return base.Equals (obj);
        }

        public override int GetHashCode ()
        {
            return base.GetHashCode ();
        }

        public static bool operator == (Vector2 v1, Vector2 v2)
        {
            return v1.Equals (v2);
        }

        public static bool operator != (Vector2 v1, Vector2 v2)
        {
            return !v1.Equals (v2);
        }

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
            return v * coefficient;
        }

        public static Vector2 operator / (Vector2 v, double coefficient)
        {
            return new Vector2 (v.X / coefficient, v.Y / coefficient);
        }

        public static double operator * (Vector2 v1, Vector2 v2)
        {
            return v1.DotProduct (v2);
        }

        /// <summary>
        /// Скалярное произведение текущего вектора на вектор <paramref name="other"/>.
        /// </summary>
        public double DotProduct (Vector2 other)
        {
            return X * other.X + Y * other.Y;
        }

        /// <summary>
        /// Квадрат длины вектора.
        /// </summary>
        public override double GetNorm2 ()
        {
            return X * X + Y * Y;
        }

        /// <summary>
        /// Угол (в радианах), под которым данный вектор направлен к оси OX.
        /// </summary>
        public double GetAngle ()
        {
            return Math.Atan2 (Y, X);
        }
    }
}