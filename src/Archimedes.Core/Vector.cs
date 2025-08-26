namespace Archimedes
{
    public class Vector : ICloneable, IEquatable<Vector>
    {
        protected readonly double [] _x;

        public double this [int index]
        {
            get => _x [index];

            set => _x [index] = value;
        }

        public virtual int Dimension
        {
            get => _x.Length;
        }

        protected Vector (int dimension)
        {
            _x = new double [dimension];
        }

        public Vector (params double [] x) : this (x.Length)
        {
            x.CopyTo (_x, 0);
        }

        public Vector (Vector other) : this (other._x)
        {            
        }

        public virtual object Clone ()
        {
            return new Vector (this);
        }

        public bool Equals (Vector? other)
        {
            throw new NotImplementedException ();
        }

        public override bool Equals (object? obj)
        {
            return base.Equals (obj);
        }

        public override int GetHashCode ()
        {
            return base.GetHashCode ();
        }

        public static bool operator == (Vector v1, Vector v2)
        {
            throw new NotImplementedException ();
        }

        public static bool operator != (Vector v1, Vector v2)
        {
            throw new NotImplementedException ();
        }

        public static Vector operator+ (Vector v1, Vector v2)
        {
            throw new NotImplementedException ();
        }

        public static Vector operator - (Vector v1, Vector v2)
        {
            throw new NotImplementedException ();
        }

        public static Vector operator - (Vector v)
        {
            throw new NotImplementedException ();
        }

        public static Vector operator * (Vector v, double coefficient)
        {
            throw new NotImplementedException ();
        }

        public static Vector operator * (double coefficient, Vector v)
        {
            throw new NotImplementedException ();
        }

        public static Vector operator / (Vector v, double coefficient)
        {
            throw new NotImplementedException ();
        }

        public static double operator * (Vector v1, Vector v2)
        {
            throw new NotImplementedException ();
        }

        public static double DotProduct (Vector v1, Vector v2)
        {
            throw new NotImplementedException ();
        }

        public virtual double GetNorm2 ()
        {
            throw new NotImplementedException ();
        }

        public virtual double GetLength ()
        {
            throw new NotImplementedException ();
        }
    }
}