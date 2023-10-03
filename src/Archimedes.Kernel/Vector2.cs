using System;

namespace Archimedes
{
    /// <summary>
    /// 2-мерный вектор.
    /// </summary>
    public class Vector2 : Vector, IEquatable<Vector>, IEquatable<Vector2>, IDotProductable<Vector2>
    {
        private const int Size = 2;

        public override int Dimension
        {
            get => Size;
        }

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

        #region Constructors

        public Vector2 () : base (Size)
        {
        }

        public Vector2 (double x, double y) : this ()
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

        #region Relations

        /// <summary>
        /// Возвращает true, если количество элементов в текущем векторе равно 2 и его элементы равны элементам вектора other. 
        /// В противном случае false.
        /// </summary>
        public new bool Equals (Vector2? other)
        {
            return _x.EqualsTwoItems (other._x);
        }

        public new bool Equals (Vector? other)
        {
            return other.Equals (this);
        }

        public override bool Equals (object? other)
        {
            if (other is Vector2) return Equals (other as Vector2);

            else if (other is Vector) return Equals (other as Vector);

            else return false;
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
        /// Скалярное произведение векторов v1 и v2.
        /// </summary>
        public static double operator * (Vector2 v1, Vector2 v2)
        {
            return v1.DotProduct (v2);
        }

        /// <summary>
        /// Скалярное произведение текущего вектора и вектора other.
        /// </summary>
        public double DotProduct (Vector2 other)
        {
            return X * other.X + Y * other.Y;
        }

        /// <summary>
        /// Векторное произведение текущего вектора и вектора other.
        /// </summary>
        public Vector3 CrossProduct (Vector2 other)
        {
            return new Vector3 (0.0,
                                0.0,
                                X * other.Y - Y * other.X);
        }

        public override double GetNorm2 ()
        {
            return X * X + Y * Y;
        }

        /// <summary>
        /// Возвращает угол, под которым данный вектор направлен к оси OX.
        /// </summary>
        public double GetHeading ()
        {
            return Math.Atan2 (Y, X);
        }

        public Polar2 CartesianToPolar ()
        {
            return new Polar2 (GetLength (), 
                               GetHeading ());
        }
    }
}