namespace Archimedes
{
    public class Vector2 : Vector, IEquatable<Vector2>
    {
        private const int Vector2Dimension = 2;

        #region Constructors

        public Vector2 (double x, double y) : base (Vector2Dimension)
        {
            _x [0] = x;
            _x [1] = y;
        }

        public Vector2 (double [] array) : base (array [0], array [1])
        {
        }

        public Vector2 (Vector2 other) : this (other._x)
        {
        }

        public override object Clone ()
        {
            return new Vector2 (this);
        }

        #endregion
    }
}