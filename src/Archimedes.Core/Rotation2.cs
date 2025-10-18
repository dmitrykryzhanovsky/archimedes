namespace Archimedes
{
    /// <summary>
    /// Вращения на плоскости.
    /// </summary>
    public static class Rotation2
    {
        /// <summary>
        /// Вычисления матриц поворота.
        /// </summary>
        public static class GetRotationMatrix
        {
            /// <summary>
            /// Активные повороты (векторов на заданные углы).
            /// </summary>
            public static class Active
            {
                public static Matrix2 GetMatrix (double angle)
                {
                    (double sin, double cos) = double.SinCos (angle);

                    return GetMatrix (sin, cos);
                }

                public static Matrix2 GetMatrix (double sin, double cos)
                {
                    return new Matrix2 (cos, -sin,
                                        sin,  cos);
                }
            }

            /// <summary>
            /// Пассивные повороты (пространства, т.е. всей плоскости, на заданные углы).
            /// </summary>
            public static class Passive
            {
                public static Matrix2 GetMatrix (double angle)
                {
                    (double sin, double cos) = double.SinCos (angle);

                    return GetMatrix (sin, cos);
                }

                public static Matrix2 GetMatrix (double sin, double cos)
                {
                    return new Matrix2 ( cos, sin,
                                        -sin, cos);
                }
            }
        }

        /// <summary>
        /// Осуществление поворотов.
        /// </summary>
        public static class Apply
        {
            /// <summary>
            /// Поворот вектора v в соответствии с заданной матрицей поворота rotationMatrix.
            /// </summary>
            public static Vector2 Rotate (Vector2 v, Matrix2 rotationMatrix)
            {
                return rotationMatrix * v;
            }

            /// <summary>
            /// Пассивные повороты (пространства, т.е. всей плоскости, на заданные углы).
            /// </summary>
            public static class Passive
            {
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

                public static Polar2 RotateSpace (Polar2 p, double angle)
                {
                    (double sin, double cos) = double.SinCos (angle);

                    return RotateSpace (p, sin, cos);
                }

                public static Polar2 RotateSpace (Polar2 p, double sinAngle, double cosAngle)
                {
                    (double sinHeading, double cosHeading) = double.SinCos (p.Heading);

                    double dx =  cosHeading * cosAngle + sinHeading * sinAngle;
                    double dy = -cosHeading * sinAngle + sinHeading * cosAngle;

                    return Polar2.CreateUnsafe (p.R, Trigonometry.Atan2Epsilon (dy, dx, ComputingSettings.ZeroAngleEpsilon));
                }
            }
        }
    }
}