namespace Archimedes
{
    public class Vector3 : Vector, IEquatable<Vector3>
    {
        private const int V3Dimension = 3;

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
            get => V3Dimension;
        }

        public Vector3 (double x, double y, double z) : base (V3Dimension)
        {
            _x [0] = x;
            _x [1] = y;
            _x [2] = z;
        }

        public Vector3 (Vector3 other) : this (other.X, other.Y, other.Z)
        {
        }

        public override object Clone ()
        {
            return new Vector3 (this);
        }

        public bool Equals (Vector3? other)
        {
            return ((X == other.X) && (Y == other.Y) && (Z == other.Z));
        }

        public override bool Equals (object? obj)
        {
            return (obj is Vector3) ? Equals (obj as Vector3) :
                   (obj is Vector)  ? Equals (obj as Vector)  : base.Equals (obj);
        }

        public static bool operator == (Vector3 v1, Vector3 v2)
        {
            return v1.Equals (v2);
        }

        public static bool operator != (Vector3 v1, Vector3 v2)
        {
            return !v1.Equals (v2);
        }

        public static Vector3 operator + (Vector3 v1, Vector3 v2)
        {
            throw new NotImplementedException ();
        }

        public static Vector3 operator - (Vector3 v1, Vector3 v2)
        {
            throw new NotImplementedException ();
        }

        public static Vector3 operator - (Vector3 v)
        {
            throw new NotImplementedException ();
        }

        public static Vector3 operator * (Vector3 v, double coefficient)
        {
            throw new NotImplementedException ();
        }

        public static Vector3 operator * (double coefficient, Vector3 v)
        {
            throw new NotImplementedException ();
        }

        public static Vector3 operator / (Vector3 v, double coefficient)
        {
            throw new NotImplementedException ();
        }

        public static double operator * (Vector3 v1, Vector3 v2)
        {
            throw new NotImplementedException ();
        }

        public static double DotProduct (Vector3 v1, Vector3 v2)
        {
            throw new NotImplementedException ();
        }

        public static Vector3 CrossProduct (Vector3 v1, Vector3 v2)
        {
            throw new NotImplementedException ();
        }

        public override double GetNorm2 ()
        {
            throw new NotImplementedException ();
        }
    }
}