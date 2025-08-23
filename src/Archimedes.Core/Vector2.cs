namespace Archimedes
{
    public class Vector2 : Vector, IEquatable<Vector2>
    {
        public double X
        {
            get;
            set;
        }

        public double Y
        {
            get;
            set;
        }

        public override int Dimension => base.Dimension;

        public Vector2 (double x, double y) : base (2)
        {
            throw new NotImplementedException ();
        }

        public Vector2 (Vector2 other)
        {
            throw new NotImplementedException ();
        }

        public override object Clone ()
        {
            return base.Clone ();
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