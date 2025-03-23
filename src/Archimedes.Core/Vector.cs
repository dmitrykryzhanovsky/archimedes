namespace Archimedes
{
    public class Vector : ICloneable
    {
        protected readonly double [] _x;

        public double this [int index]
        {
            get => _x [index];

            set => _x [index] = value;
        }

        public double [] Coordinates
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

        public object Clone ()
        {
            return new Vector (this);
        }
    }
}