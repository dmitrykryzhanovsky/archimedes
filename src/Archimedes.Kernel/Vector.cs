namespace Archimedes
{
    public class Vector
    {
        protected readonly double [] _x;

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
    }
}