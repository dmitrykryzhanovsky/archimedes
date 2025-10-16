namespace Archimedes
{
    public class Vector2 : Vector, IEquatable<Vector2>
    {
        private const int V2Dimension = 2;

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
            get => V2Dimension;
        }

        #region Constructors

        public Vector2 (double x, double y) : base (V2Dimension)
        {
            _x [0] = x;
            _x [1] = y;
        }

        public Vector2 (Vector2 other) : this (other.X, other.Y)
        {
        }

        public override object Clone ()
        {
            return new Vector2 (this);
        }

        #endregion

        #region Comparison

        public bool Equals (Vector2? other)
        {
            return ((X == other.X) && (Y == other.Y));
        }

        public override bool Equals (object? obj)
        {
            return (obj is Vector2) ? Equals (obj as Vector2) : 
                   (obj is Vector)  ? Equals (obj as Vector)  : base.Equals (obj);
        }

        public override int GetHashCode ()
        {
            return base.GetHashCode ();
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

        #region Operators

        public static Vector2 operator + (Vector2 v1, Vector2 v2)
        {
            return new Vector2 (v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector2 operator - (Vector2 v1, Vector2 v2)
        {
            return new Vector2 (v1.X - v2.X, v1.Y - v2.Y);
        }

        public static Vector2 operator - (Vector2 v)
        {
            return new Vector2 (-v.X, -v.Y);
        }

        public static Vector2 operator * (Vector2 v, double coefficient)
        {
            return new Vector2 (v.X * coefficient, v.Y * coefficient);
        }

        public static Vector2 operator * (double coefficient, Vector2 v)
        {
            return v * coefficient;
        }

        public static Vector2 operator / (Vector2 v, double coefficient)
        {
            return new Vector2 (v.X / coefficient, v.Y / coefficient);
        }

        public static double operator * (Vector2 v1, Vector2 v2)
        {
            return DotProduct (v1, v2);
        }

        #endregion

        public static double DotProduct (Vector2 v1, Vector2 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        public override double GetNorm2 ()
        {
            return DotProduct (this, this);
        }

        public override double GetLength ()
        {
            return double.Hypot (X, Y);
        }

        /// <summary>
        /// Возвращает полярные координаты, соответствующие данному вектору декартовых координат.
        /// </summary>
        public Polar2 GetPolar ()
        {
            (double r, double heading) = Space2.GetPolarCoordinates (X, Y);

            return Polar2.CreateUnsafe (r, heading);
        }
    }
}