namespace Archimedes
{
    public class Vector3 : Vector
    {
        private const int Size = 3;

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
            get => Size;
        }

        public Vector3 (double x, double y, double z) : base (Size)
        {
            _x [0] = x;
            _x [1] = y;
            _x [2] = z;
        }

        public Vector3 (double [] x) : this (x [0], x [1], x [2])
        {
        }

        public Vector3 (Vector3 other) : this (other._x)
        {
        }

        public override object Clone ()
        {
            return new Vector3 (this);
        }
    }
}