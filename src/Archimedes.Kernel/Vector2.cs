namespace Archimedes
{
    public class Vector2 : Vector
    {
        private const int Size = 2;

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
            get => Size;
        }

        public Vector2 (double x, double y) : base (Size)
        {
            _x [0] = x;
            _x [1] = y;
        }

        public Vector2 (double [] x) : this (x [0], x [1])
        {
        }

        public Vector2 (Vector2 other) : this (other._x)
        {
        }

        public override object Clone ()
        {
            return new Vector2 (this);
        }
    }
}