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

        public static Polar2 RotateSpace (Polar2 p, double phi)
        {
            (double sinPhi, double cosPhi) = double.SinCos (phi);

            return RotateSpace (p, sinPhi, cosPhi);
        }

        public static Polar2 RotateSpace (Polar2 p, double sinPhi, double cosPhi)
        {
            (double sinHeading, double cosHeading) = double.SinCos (p.Heading);

            double dx =  cosHeading * cosPhi + sinHeading * sinPhi;
            double dy = -cosHeading * sinPhi + sinHeading * cosPhi;
            
            return Polar2.DirectInit (p.R, Trigonometry.Atan2Small (dx, dy, ComputingSettings.SmallAngleEpsilon));
        }
    }
}