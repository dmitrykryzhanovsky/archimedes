namespace Archimedes
{
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

        #region Comparisons

        public bool Equals (Vector2? other)
        {
            return ((X == other.X) && (Y == other.Y));
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

        public static double operator * (Vector2 v1, Vector2 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        public override double GetNorm2 ()
        {
            return X * X + Y * Y;
        }

        public override double GetLength ()
        {
            return double.Hypot (X, Y);
        }
    }
}