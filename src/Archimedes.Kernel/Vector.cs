namespace Archimedes
{
    public class Vector : ICloneable, IEquatable<Vector>
    {
        protected double [] _x;

        public double this [int index]
        {
            get => _x [index];
            set => _x [index] = value;
        }

        public double [] Components
        {
            get => _x;
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
            return _x.Equals<double> (other._x);
        }

        public static bool operator == (Vector v1, Vector v2)
        {
            return v1.Equals (v2);
        }

        public static bool operator != (Vector v1, Vector v2)
        {
            return !v1.Equals (v2);
        }

        public static Vector operator + (Vector v1, Vector v2)
        {
            return new Vector (v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector operator - (Vector v1, Vector v2)
        {
            return new Vector (v1.X - v2.X, v1.Y - v2.Y);
        }

        public static Vector operator - (Vector v)
        {
            return new Vector (-v.X, -v.Y);
        }

        public static Vector operator * (Vector v, double coefficient)
        {
            return new Vector (v.X * coefficient, v.Y * coefficient);
        }

        public static Vector operator * (double coefficient, Vector v)
        {
            return v * coefficient;
        }

        public static Vector operator / (Vector v, double coefficient)
        {
            return new Vector (v.X / coefficient, v.Y / coefficient);
        }
    }
}