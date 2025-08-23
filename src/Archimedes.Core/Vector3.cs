namespace Archimedes
{
    public class Vector3 : Vector, IEquatable<Vector3>
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

        public double Z
        {
            get;
            set;
        }

        public override int Dimension => base.Dimension;

        public Vector3 (double x, double y) : base (3)
        {
            throw new NotImplementedException ();
        }

        public Vector3 (Vector3 other)
        {
            throw new NotImplementedException ();
        }

        public override object Clone ()
        {
            return base.Clone ();
        }

        public bool Equals (Vector3? other)
        {
            throw new NotImplementedException ();
        }

        public override bool Equals (object? obj)
        {
            return base.Equals (obj);
        }

        public static bool operator == (Vector3 v1, Vector3 v2)
        {
            throw new NotImplementedException ();
        }

        public static bool operator != (Vector3 v1, Vector3 v2)
        {
            throw new NotImplementedException ();
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