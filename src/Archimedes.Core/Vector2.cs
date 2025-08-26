namespace Archimedes
{
    public class Vector2 : Vector, IEquatable<Vector2>
    {
        private const int V2Dimension = 2;

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
            get => V2Dimension;
        }

        public Vector2 (double x, double y) : base (V2Dimension)
        {
            _x [0] = x;
            _x [1] = y;
        }

        public Vector2 (Vector2 other) : this (other.X, other.Y)
        {
        }

        public override object Clone ()
        {
            return new Vector2 (this);
        }

        public bool Equals (Vector2? other)
        {
            throw new NotImplementedException ();
        }

        public override bool Equals (object? obj)
        {
            return base.Equals (obj);
        }

        public static bool operator == (Vector2 v1, Vector2 v2)
        {
            throw new NotImplementedException ();
        }

        public static bool operator != (Vector2 v1, Vector2 v2)
        {
            throw new NotImplementedException ();
        }

        public static Vector2 operator + (Vector2 v1, Vector2 v2)
        {
            throw new NotImplementedException ();
        }

        public static Vector2 operator - (Vector2 v1, Vector2 v2)
        {
            throw new NotImplementedException ();
        }

        public static Vector2 operator - (Vector2 v)
        {
            throw new NotImplementedException ();
        }

        public static Vector2 operator * (Vector2 v, double coefficient)
        {
            throw new NotImplementedException ();
        }

        public static Vector2 operator * (double coefficient, Vector2 v)
        {
            throw new NotImplementedException ();
        }

        public static Vector2 operator / (Vector2 v, double coefficient)
        {
            throw new NotImplementedException ();
        }

        public static double operator * (Vector2 v1, Vector2 v2)
        {
            throw new NotImplementedException ();
        }

        public static double DotProduct (Vector2 v1, Vector2 v2)
        {
            throw new NotImplementedException ();
        }

        public override double GetNorm2 ()
        {
            throw new NotImplementedException ();
        }

        public override double GetLength ()
        {
            throw new NotImplementedException ();
        }
    }
}