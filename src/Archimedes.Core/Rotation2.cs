namespace Archimedes
{
    /// <summary>
    /// Вращения на плоскости.
    /// </summary>
    /// <remarks>В методах, где вместо угла передаются его синус и косинус, их проверка на соответствие основному тригонометрическому 
    /// тождеству не производится.</remarks>
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
            /// Поворот в соответствии с заданной матрицей поворота rotationMatrix.
            /// </summary>
            public static Vector2 Rotate (Matrix2 rotationMatrix, Vector2 v)
            {
                return rotationMatrix * v;
            }

            /// <summary>
            /// Активные повороты (векторов на заданные углы).
            /// </summary>
            public static class Active
            {
                public static Vector2 RotateVector (Vector2 v, double angle)
                {
                    (double sin, double cos) = double.SinCos (angle);

                    return RotateVector (v, sin, cos);
                }

                public static Vector2 RotateVector (Vector2 v, double sin, double cos)
                {
                    return new Vector2 (v.X * cos - v.Y * sin,
                                        v.X * sin + v.Y * cos);
                }

                public static Polar2 RotateVector (Polar2 p, double angle)
                {
                    return Polar2.CreateUnsafe (p.R, p.Heading + angle);
                }

                public static Polar2 RotateVector (Polar2 p, double sinAngle, double cosAngle)
                {
                    double angle = Trigonometry.Atan2Epsilon (sinAngle, cosAngle, ComputingSettings.ZeroAngleEpsilon);

                    return RotateVector (p, angle);
                }
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
                    return Polar2.CreateUnsafe (p.R, p.Heading - angle);
                }

                public static Polar2 RotateSpace (Polar2 p, double sinAngle, double cosAngle)
                {
                    double angle = Trigonometry.Atan2Epsilon (sinAngle, cosAngle, ComputingSettings.ZeroAngleEpsilon);

                    return RotateSpace (p, angle);
                }
            }
        }
    }
}