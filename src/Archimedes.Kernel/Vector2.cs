using System;

namespace Archimedes
{
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

        public static double operator * (Vector2 v1, Vector2 v2)
        {
            return v1.DotProduct (v2);
        }

        public double DotProduct (Vector2 other)
        {
            return X * other.X + Y * other.Y;
        }

        // TODO: векторное произведение

        public override double GetNorm2 ()
        {
            return X * X + Y * Y;
        }

        public double GetHeading ()
        {
            return Math.Atan2 (Y, X);
        }
    }
}