namespace Archimedes
{
    /// <summary>
    /// 2-мерный вектор в декартовых координатах.
    /// </summary>
    public class Vector2 : Vector, IEquatable<Vector2>
    {
        private const int Vector2Dimension = 2;

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
            get => Vector2Dimension;
        }

        #region constructors

        public Vector2 (double x, double y) : base (Vector2Dimension)
        {
            _x [0] = x;
            _x [1] = y;
        }

        public Vector2 (Vector2 other) : this (other._x [0], other._x [1])
        {
        }

        public override object Clone ()
        {
            return new Vector2 (this);
        }

        #endregion

        #region comparison
        
        public bool Equals (Vector2? other)
        {
            return ((_x [0] == other._x [0]) && (_x [1] == other._x [1]));
        }

        public static bool operator == (Vector2 v1, Vector2 v2)
        {
            return v1.Equals (v2);
        }

        public static bool operator != (Vector2 v1, Vector2 v2)
        {
            return !v1.Equals (v2);
        }

        #endregion

        public double GetNorm ()
        {
            return _x [0] * _x [0] + _x [1] * _x [1];
        }

        public double GetLength ()
        {
            return double.Hypot (_x [0], _x [1]);
        }
    }
}