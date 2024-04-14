namespace Archimedes
{
    public class Vector3 : Vector, ICloneable, IEquatable<Vector3>
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

        public Vector3 (double x, double y, double z) : base (Size)
        {
            _x [0] = x;
            _x [1] = y;
            _x [2] = z;
        }

        public Vector3 (Vector3 other) : this (other.X, other.Y, other.Z)
        {
        }

        public object Clone ()
        {
            return new Vector3 (this);
        }

        public override bool Equals (object? obj)
        {
            if (obj is Vector3) return Equals (obj as Vector3);

            else return base.Equals (obj);
        }

        public bool Equals (Vector3? other)
        {
            return ((X == other.X) && 
                    (Y == other.Y) && 
                    (Z == other.Z));
        }

        public static bool operator == (Vector3 v1, Vector3 v2)
        {
            return v1.Equals (v2);
        }

        public static bool operator != (Vector3 v1, Vector3 v2)
        {
            return v1.Equals (v2);
        }

        public override double GetNorm2 ()
        {
            return X * X + Y * Y + Z * Z;
        }

        /// <summary>
        /// Поворот вектора <paramref name="v"/> на угол <paramref name="phi"/> вокруг оси OX.
        /// </summary>
        public static Vector3 RotateAroundOX (Vector3 v, double phi)
        {
            (double sin, double cos) = double.SinCos (phi);

            return RotateAroundOX (v, sin, cos);
        }

        /// <summary>
        /// Поворот вектора <paramref name="v"/> вокруг оси OX на угол, заданный своими синусом <paramref name="sin"/> и косинусом 
        /// <paramref name="cos"/>.
        /// </summary>
        public static Vector3 RotateAroundOX (Vector3 v, double sin, double cos)
        {
            double x = v.X;
            double y = v.Y * cos - v.Z * sin;
            double z = v.Y * sin + v.Z * cos;

            return new Vector3 (x, y, z);
        }

        public Polar3 ToPolar ()
        {
            double r     = GetLength ();

            double sinB  = Z / r;
            double cosB  = double.Sqrt (1.0 - sinB * sinB);
            double theta = double.Asin (sinB);

            double oxy   = double.Sqrt (X * X + Y * Y);
            double sinL  = Y / oxy;
            double cosL  = X / oxy;
            double l     = double.Atan2 (Y, X);

            return Polar3.Init (r, theta, l, sinB, cosB, sinL, cosL);
        }
    }
}