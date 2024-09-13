namespace Archimedes
{
    public class Vector3 : Vector, IEquatable<Vector3>
    {
        private const int Vector3Dimension = 3;

        #region Constructors

        public Vector3 (double x, double y, double z) : base (Vector3Dimension)
        {
            _x [0] = x;
            _x [1] = y;
            _x [2] = z;
        }

        public Vector3 (double [] array) : base (array [0], array [1], array [2])
        {
        }

        public Vector3 (Vector3 other) : this (other._x)
        {
        }

        public override object Clone ()
        {
            return new Vector3 (this);
        }

        #endregion
    }
}