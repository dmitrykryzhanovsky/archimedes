﻿namespace Archimedes
{
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

        #region Constructors

        public Vector2 (double x, double y) : base (Vector2Dimension)
        {
            _x [0] = x;
            _x [1] = y;
        }

        public Vector2 (double [] array) : base (array [0], array [1])
        {
        }

        public Vector2 (Vector2 other) : this (other._x)
        {
        }

        public override object Clone ()
        {
            return new Vector2 (this);
        }

        #endregion

        #region Comparisons

        public bool Equals (Vector2? other)
        {
            return ((X == other.X) && (Y == other.Y));
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

        #region Conversions

        public static explicit operator Vector2 (Complex z)
        {
            return new Vector2 (z.Re, z.Im);
        }

        #endregion

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

        /// <summary>
        /// Возвращает скалярное произведение векторов.
        /// </summary>
        public static double operator * (Vector2 v1, Vector2 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        /// <summary>
        /// Возвращает квадрат нормы вектора.
        /// </summary>
        public override double GetNorm2 ()
        {
            return X * X + Y * Y;
        }

        /// <summary>
        /// Возвращает длину вектора.
        /// </summary>
        public override double GetLength ()
        {
            return double.Hypot (X, Y);
        }

        /// <summary>
        /// Возвращает единичный вектор, сонаправленный данному.
        /// </summary>
        public new Vector2 GetUnit ()
        {
            double length = GetLength ();

            return this / length;
        }

        public Vector2 Rotate (double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            return Rotate (sin, cos);
        }

        public Vector2 Rotate (double sin, double cos)
        {
            return new Vector2 (X * cos - Y * sin, 
                                X * sin + Y * cos);
        }

        public Vector2 Rotate (Matrix2 rotationMatrix)
        {
            return rotationMatrix * this;
        }

        /// <summary>
        /// Преобразование из декартовых координат в полярные.
        /// </summary>
        public Polar2 ToPolar ()
        {
            return Polar2.DirectInit (r: GetLength (), 
                heading: double.Atan2 (Y, X));
        }
    }
}