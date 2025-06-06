﻿namespace Archimedes
{
    /// <summary>
    /// 3-мерный вектор в декартовых координатах.
    /// </summary>
    public class Vector3 : Vector, IEquatable<Vector3>
    {
        private const int Vector3Dimension = 3;

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

        public override int Dimension
        {
            get => Vector3Dimension;
        }

        #region constructors

        public Vector3 (double x, double y, double z) : base (Vector3Dimension)
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

        #region comparison

        public override bool Equals (object? obj)
        {
            return Equals (obj as Vector3);
        }

        public bool Equals (Vector3? other)
        {
            return ((_x [0] == other._x [0]) && (_x [1] == other._x [1]) && (_x [2] == other._x [2]));
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

        #region operators

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
            return new Vector3 (v.X * coefficient, v.Y * coefficient, v.Z * coefficient);
        }

        public static Vector3 operator / (Vector3 v, double coefficient)
        {
            return new Vector3 (v.X / coefficient, v.Y / coefficient, v.Z / coefficient);
        }

        public static double operator * (Vector3 v1, Vector3 v2)
        {
            return DotProduct (v1, v2);
        }

        #endregion

        /// <summary>
        /// Скалярное произведение векторов v1 и v2.
        /// </summary>
        public static double DotProduct (Vector3 v1, Vector3 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        /// <summary>
        /// Векторное произведение векторов v1 и v2.
        /// </summary>
        public static Vector3 CrossProduct (Vector3 v1, Vector3 v2)
        {
            return new Vector3 (v1.Y * v2.Z - v1.Z * v2.Y,
                                v1.Z * v2.X - v1.X * v2.Z,
                                v1.X * v2.Y - v1.Y * v2.X);
        }

        public override double GetNorm2 ()
        {
            return _x [0] * _x [0] + _x [1] * _x [1] + _x [2] * _x [2];
        }
    }
}