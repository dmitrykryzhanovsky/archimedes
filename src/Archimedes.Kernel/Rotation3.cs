namespace Archimedes
{
    public static class Rotation3
    {
        public static Matrix3 GetRotationMatrixForVectorAroundOX (double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            return GetRotationMatrixForVectorAroundOX (sin, cos);
        }

        public static Matrix3 GetRotationMatrixForVectorAroundOX (double sin, double cos)
        {
            return new Matrix3 (1,   0,    0,
                                0, cos, -sin,
                                0, sin,  cos);
        }

        public static Matrix3 GetRotationMatrixForVectorAroundOY (double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            return GetRotationMatrixForVectorAroundOY (sin, cos);
        }

        public static Matrix3 GetRotationMatrixForVectorAroundOY (double sin, double cos)
        {
            return new Matrix3 ( cos, 0, sin,
                                   0, 1,   0,
                                -sin, 0, cos);
        }

        public static Matrix3 GetRotationMatrixForVectorAroundOZ (double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            return GetRotationMatrixForVectorAroundOZ (sin, cos);
        }

        public static Matrix3 GetRotationMatrixForVectorAroundOZ (double sin, double cos)
        {
            return new Matrix3 (cos, -sin, 0,
                                sin,  cos, 0,
                                  0,    0, 1);
        }

        public static Matrix3 GetRotationMatrixForSpaceAroundOX (double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            return GetRotationMatrixForSpaceAroundOX (sin, cos);
        }

        public static Matrix3 GetRotationMatrixForSpaceAroundOX (double sin, double cos)
        {
            return new Matrix3 (1,    0,   0,
                                0,  cos, sin,
                                0, -sin, cos);
        }

        public static Matrix3 GetRotationMatrixForSpaceAroundOY (double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            return GetRotationMatrixForSpaceAroundOY (sin, cos);
        }

        public static Matrix3 GetRotationMatrixForSpaceAroundOY (double sin, double cos)
        {
            return new Matrix3 (cos, 0, -sin,
                                  0, 1,    0,
                                sin, 0,  cos);
        }

        public static Matrix3 GetRotationMatrixForSpaceAroundOZ (double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            return GetRotationMatrixForSpaceAroundOZ (sin, cos);
        }

        public static Matrix3 GetRotationMatrixForSpaceAroundOZ (double sin, double cos)
        {
            return new Matrix3 ( cos, sin, 0,
                                -sin, cos, 0,
                                   0,   0, 1);
        }

        public static Vector3 RotateSpaceAroundOX (Vector3 v, double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            return RotateSpaceAroundOX (v, sin, cos);
        }

        public static Vector3 RotateSpaceAroundOX (Vector3 v, double sin, double cos)
        {
            return new Vector3 ( v.X, 
                                 v.Y * cos + v.Z * sin, 
                                -v.Y * sin + v.Z * cos);
        }

        public static Vector3 RotateSpaceAroundOY (Vector3 v, double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            return RotateSpaceAroundOY (v, sin, cos);
        }

        public static Vector3 RotateSpaceAroundOY (Vector3 v, double sin, double cos)
        {
            return new Vector3 (v.X * cos - v.Z * sin,
                                v.Y,
                                v.X * sin + v.Z * cos);
        }

        public static Vector3 RotateSpaceAroundOZ (Vector3 v, double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            return RotateSpaceAroundOZ (v, sin, cos);
        }

        public static Vector3 RotateSpaceAroundOZ (Vector3 v, double sin, double cos)
        {
            return new Vector3 ( v.X * cos + v.Y * sin,
                                -v.X * sin + v.Y * cos, 
                                 v.Z);
        }

        public static Vector3 RotateSpace (Vector3 v, Matrix3 rotationMatrix)
        {
            return rotationMatrix * v;
        }

        public static Polar3 RotateSpaceAroundOX (Polar3 p, double phi)
        {
            (double sinPhi, double cosPhi) = double.SinCos (phi);

            return RotateSpaceAroundOX (p, sinPhi, cosPhi);
        }

        public static Polar3 RotateSpaceAroundOX (Polar3 p, double sinPhi, double cosPhi)
        {
            (double sinB, double cosB) = double.SinCos (p.Latitude);
            (double sinL, double cosL) = double.SinCos (p.Longitude);

            double dx = cosB * cosL;
            double dy = cosB * sinL * cosPhi + sinB * sinPhi;
            double sinB1 = -cosB * sinL * sinPhi + sinB * cosPhi;

            return Polar3.DirectInit (p.R, 
                Trigonometry.AsinSmall (sinB1, ComputingSettings.SmallAngleEpsilon), 
                Trigonometry.Atan2Small (dx, dy, ComputingSettings.SmallAngleEpsilon));
        }
    }
}