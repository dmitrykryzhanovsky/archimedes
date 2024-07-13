namespace Archimedes
{
    public class Vector2: Vector, IEquatable<Vector2>
    {
        private const int ThisTypeDimension = 2;

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
            get => ThisTypeDimension;
        }

        public Vector2 (double x, double y) : base (ThisTypeDimension)
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

        public override double GetNorm2 ()
        {
            return X * X + Y * Y;
        }

        public void RotateThis (double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            RotateThis (sin, cos);
        }

        public void RotateThis (double sin, double cos)
        {
            (_x [0], _x [1]) = Euclidean2Formulae.RotateVector (sin, cos, _x [0], _x [1]);
        }

        public Vector2 Rotate (double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            return Rotate (sin, cos);
        }

        public Vector2 Rotate (double sin, double cos)
        {
            (double rotatedX, double rotatedY) = Euclidean2Formulae.RotateVector (sin, cos, _x [0], _x [1]);

            return new Vector2 (rotatedX, rotatedY);
        }
    }
}