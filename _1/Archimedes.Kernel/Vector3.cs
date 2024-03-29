﻿namespace Archimedes
{
    /// <summary>
    /// 3-мерный вектор.
    /// </summary>
    public class Vector3 : Vector, IEquatable<Vector>, IEquatable<Vector3>, IDotProductable<Vector3>
    {
        private const int Size = 3;

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

        public double Z
        {
            get => _x [2];
            set => _x [2] = value;
        }

        #region Constructors

        public Vector3 () : base (Size)
        {
        }

        public Vector3 (double x, double y, double z) : this ()
        {
            _x [0] = x;
            _x [1] = y;
            _x [2] = z;
        }

        public Vector3 (Vector3 other) : this (other._x [0], other._x [1], other._x [2])
        {
        }

        public override object Clone ()
        {
            return new Vector3 (this);
        }

        #endregion

        #region Relations

        // <summary>
        /// Возвращает true, если количество элементов в текущем векторе равно 3 и его элементы равны элементам вектора other. 
        /// В противном случае false.
        /// </summary>
        public new bool Equals (Vector3? other)
        {
            return _x.Equals3 (other._x);
        }

        public override bool Equals (object? other)
        {
            if (other is Vector3) return Equals (other as Vector3);

            else if (other is Vector) return Equals (other as Vector);

            else return false;
        }

        public override int GetHashCode ()
        {
            return base.GetHashCode ();
        }

        public static bool operator == (Vector3 v1, Vector3 v2)
        {
            return v1.Equals (v2);
        }

        public static bool operator != (Vector3 v1, Vector3 v2)
        {
            return !v1.Equals (v2);
        }

        #endregion

        public static Vector3 operator + (Vector3 v1, Vector3 v2)
        {
            return new Vector3 (v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector3 operator - (Vector3 v1, Vector3 v2)
        {
            return new Vector3 (v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector3 operator - (Vector3 v)
        {
            return new Vector3 (-v.X, -v.Y, -v.Z);
        }

        public static Vector3 operator * (Vector3 v, double coefficient)
        {
            return new Vector3 (v.X * coefficient, v.Y * coefficient, v.Z * coefficient);
        }

        public static Vector3 operator * (double coefficient, Vector3 v)
        {
            return v * coefficient;
        }

        public static Vector3 operator / (Vector3 v, double coefficient)
        {
            return new Vector3 (v.X / coefficient, v.Y / coefficient, v.Z / coefficient);
        }

        /// <summary>
        /// Скалярное произведение векторов v1 и v2.
        /// </summary>
        public static double operator * (Vector3 v1, Vector3 v2)
        {
            return v1.DotProduct (v2);
        }

        /// <summary>
        /// Скалярное произведение текущего вектора и вектора other.
        /// </summary>
        public double DotProduct (Vector3 other)
        {
            return X * other.X + Y * other.Y + Z * other.Z;
        }

        /// <summary>
        /// Векторное произведение текущего вектора и вектора other.
        /// </summary>
        public Vector3 CrossProduct (Vector3 other)
        {
            return new Vector3 (Y * other.Z - Z * other.Y,
                                Z * other.X - X * other.Z,
                                X * other.Y - Y * other.X);
        }

        public override double GetNorm2 ()
        {
            return X * X + Y * Y + Z * Z;
        }

        /// <summary>
        /// Преобразует вектор в сферические координаты.
        /// </summary>
        public Polar3 CartesianToPolar ()
        {
            double r = GetLength ();

            if (r > 0.0) return new Polar3 (r,
                                            Double.Atan2 (Y, X),
                                            Double.Asin  (Z / r));

            else return new Polar3 (0.0, 0.0, 0.0);
        }
    }
}