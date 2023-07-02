namespace Archimedes
{
    public class Matrix : ICloneable, IEquatable<Matrix>
    {
        protected double [,] _x;

        public double this [int row, int column]
        {
            get => _x [row, column];
            set => _x [row, column] = value;
        }

        protected Matrix (int height, int width)
        {
            _x = new double [height, width];
        }

        public Matrix (double [,] x) : this (x.GetLength (0), x.GetLength (1))
        {
            throw new NotImplementedException ();
        }

        public Matrix (int height, int width, params double [] x) : this (height, width)
        {
            throw new NotImplementedException ();
        }

        public Matrix (Matrix other) : this (other._x)
        {
        }

        public virtual object Clone ()
        {
            return new Matrix (this);
        }

        public bool Equals (Matrix? other)
        {
            throw new NotImplementedException ();
        }

        public override bool Equals (object? obj)
        {
            if (obj is Matrix) return Equals ((Matrix)obj);
            else return base.Equals (obj);
        }

        public override int GetHashCode ()
        {
            return base.GetHashCode ();
        }

        public static bool operator == (Matrix m1, Matrix m2)
        {
            return m1.Equals (m2);
        }

        public static bool operator != (Matrix m1, Matrix m2)
        {
            return !m1.Equals (m2);
        }
    }
}