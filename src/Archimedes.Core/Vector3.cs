namespace Archimedes
{
    /// <summary>
    /// 3-мерный вектор в декартовых координатах.
    /// </summary>
    public class Vector3 : Vector, IEquatable<Vector3>
    {
        private const int Vector3Dimension = 3;

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
            get => Vector3Dimension;
        }

        #region constructors

        public Vector3 (double x, double y, double z) : base (Vector3Dimension)
        {
            _x [0] = x;
            _x [1] = y;
            _x [2] = z;
        }

        public Vector3 (Vector3 other) : this (other._x [0], other._x [1], other._x [2])
        {
        }

        public override object Clone ()
        {
            return new Vector3 (this);
        }

        #endregion

        #region comparison

        public bool Equals (Vector3? other)
        {
            return ((_x [0] == other._x [0]) && (_x [1] == other._x [1]) && (_x [2] == other._x [2]));
        }

        public static bool operator == (Vector3 v1, Vector3 v2)
        {
            return v1.Equals (v2);
        }

        public static bool operator != (Vector3 v1, Vector3 v2)
        {
            return !v1.Equals (v2);
        }

        #endregion
    }
}