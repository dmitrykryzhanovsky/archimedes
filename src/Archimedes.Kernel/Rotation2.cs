namespace Archimedes
{
    public static class Rotation2
    {
        public static Matrix2 GetRotationMatrixForVector (double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            return GetRotationMatrixForVector (sin, cos);
        }

        public static Matrix2 GetRotationMatrixForVector (double sin, double cos)
        {
            return new Matrix2 (cos, -sin, sin, cos);
        }

        public static Matrix2 GetRotationMatrixForSpace (double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            return GetRotationMatrixForSpace (sin, cos);
        }

        public static Matrix2 GetRotationMatrixForSpace (double sin, double cos)
        {
            return new Matrix2 (cos, sin, -sin, cos);
        }

        public static Vector2 RotateSpace (Vector2 v, double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            return RotateSpace (v, sin, cos);
        }

        public static Vector2 RotateSpace (Vector2 v, double sin, double cos)
        {
            return new Vector2 ( v.X * cos + v.Y * sin,
                                -v.X * sin + v.Y * cos);
        }

        public static Vector2 RotateSpace (Vector2 v, Matrix2 rotationMatrix)
        {
            return rotationMatrix * v;
        }
    }
}