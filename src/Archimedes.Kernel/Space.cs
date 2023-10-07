using System;

namespace Archimedes
{
    public static class Space
    {
        /// <summary>
        /// Вычисляет матрицу поворота вокруг оси OX на угол phi.
        /// </summary>
        public static Matrix3 RotationAroundOX (double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return RotationAroundOX (sin, cos);
        }

        /// <summary>
        /// Вычисляет матрицу поворота вокруг оси OX на угол, заданный синусом sin и косинусом cos.
        /// </summary>
        /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
        public static Matrix3 RotationAroundOX (double sin, double cos)
        {
            return new Matrix3 (1.0,  0.0, 0.0,
                                0.0,  cos, sin,
                                0.0, -sin, cos);
        }

        /// <summary>
        /// Вычисляет матрицы поворота вокруг оси OX на угол phi и угол -phi (т.е. в противоположном направлении).
        /// </summary>
        public static (Matrix3 direct, Matrix3 backward) RotationAroundOXBoth (double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return RotationAroundOXBoth (sin, cos);
        }

        /// <summary>
        /// Вычисляет матрицы поворота вокруг оси OX на угол, заданный синусом sin и косинусом cos, и равный ему по модулю угол, но в 
        /// противоположном направлении.
        /// </summary>
        /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
        public static (Matrix3 direct, Matrix3 backward) RotationAroundOXBoth (double sin, double cos)
        {
            Matrix3 direct = new Matrix3 (1.0,  0.0, 0.0,
                                          0.0,  cos, sin,
                                          0.0, -sin, cos);

            Matrix3 backward = new Matrix3 (1.0, 0.0,  0.0,
                                            0.0, cos, -sin,
                                            0.0, sin,  cos);

            return (direct, backward);
        }

        /// <summary>
        /// Поворот вектора v вокруг оси OX на угол phi.
        /// </summary>
        public static Vector3 RotateVectorAroundOX (Vector3 v, double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return RotateVectorAroundOX (v, sin, cos);
        }

        /// <summary>
        /// Поворот вектора v вокруг оси OX на угол phi, заданный синусом sin и косинусом cos.
        /// </summary>
        /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
        public static Vector3 RotateVectorAroundOX (Vector3 v, double sin, double cos)
        {
            return new Vector3 (v.X,
                                v.Y * cos - v.Z * sin,
                                v.Y * sin + v.Z * cos);
        }

        public static Vector3 RotateReferenceAroundOX (Vector3 v, double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return RotateReferenceAroundOX (v, sin, cos);
        }

        public static Vector3 RotateReferenceAroundOX (Vector3 v, double sin, double cos)
        {
            return new Vector3 ( v.X,
                                 v.Y * cos + v.Z * sin,
                                -v.Y * sin + v.Z * cos);
        }

        public static Polar3 RotateReferenceAroundOX (Polar3 p, double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return RotateReferenceAroundOX (p, sin, cos);
        }

        public static Polar3 RotateReferenceAroundOX (Polar3 p, double sin, double cos)
        {
            (double sinb, double cosb) = Math.SinCos (p.Latitude);
            (double sinl, double cosl) = Math.SinCos (p.Longitude);

            return new Polar3 (p.R,
                               Math.Atan2 (cosb * sinl * cos + sinb * sin, cosb * cosl),
                               Math.Asin (-cosb * sinl * sin + sinb * cos));
        }

        public static (double phi2, double l2) RotateReferenceAroundOX (double phi1, double l1, double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return RotateReferenceAroundOX (phi1, l1, sin, cos);
        }

        public static (double phi2, double l2) RotateReferenceAroundOX (double phi1, double l1, double sin, double cos)
        {
            (double sinb, double cosb) = Math.SinCos (phi1);
            (double sinl, double cosl) = Math.SinCos (l1);

            return (Math.Asin (-cosb * sinl * sin + sinb * cos),
                    Math.Atan2 (cosb * sinl * cos + sinb * sin, cosb * cosl));
        }

        public static Matrix3 RotationAroundOY (double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return RotationAroundOY (sin, cos);
        }

        public static Matrix3 RotationAroundOY (double sin, double cos)
        {
            return new Matrix3 (cos, 0.0, -sin,
                                0.0, 1.0,  0.0,
                                sin, 0.0,  cos);
        }

        public static (Matrix3 direct, Matrix3 backward) RotationAroundOYBoth (double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return RotationAroundOYBoth (sin, cos);
        }

        public static (Matrix3 direct, Matrix3 backward) RotationAroundOYBoth (double sin, double cos)
        {
            Matrix3 direct = new Matrix3 (cos, 0.0, -sin,
                                          0.0, 1.0,  0.0,
                                          sin, 0.0,  cos);

            Matrix3 backward = new Matrix3 ( cos, 0.0, sin,
                                             0.0, 1.0, 0.0,
                                            -sin, 0.0, cos);

            return (direct, backward);
        }

        public static Vector3 RotateVectorAroundOY (Vector3 v, double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return RotateVectorAroundOY (v, sin, cos);
        }

        public static Vector3 RotateVectorAroundOY (Vector3 v, double sin, double cos)
        {
            return new Vector3 ( v.X * cos + v.Z * sin, 
                                 v.Y, 
                                -v.X * sin + v.Z * cos);
        }

        public static Matrix3 RotationAroundOZ (double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return RotationAroundOZ (sin, cos);
        }

        public static Matrix3 RotationAroundOZ (double sin, double cos)
        {
            return new Matrix3 ( cos, sin, 0.0,
                                -sin, cos, 0.0,
                                 0.0, 0.0, 1.0);
        }

        public static (Matrix3 direct, Matrix3 backward) RotationAroundOZBoth (double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return RotationAroundOZBoth (sin, cos);
        }

        public static (Matrix3 direct, Matrix3 backward) RotationAroundOZBoth (double sin, double cos)
        {
            Matrix3 direct = new Matrix3 ( cos, sin, 0.0,
                                          -sin, cos, 0.0,
                                           0.0, 0.0, 1.0);

            Matrix3 backward = new Matrix3 (cos, -sin, 0.0,
                                            sin,  cos, 0.0,
                                            0.0,  0.0, 1.0);

            return (direct, backward);
        }

        public static Vector3 RotateVectorAroundOZ (Vector3 v, double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return RotateVectorAroundOZ (v, sin, cos);
        }

        public static Vector3 RotateVectorAroundOZ (Vector3 v, double sin, double cos)
        {
            return new Vector3 (v.X * cos - v.Y * sin,
                                v.X * sin + v.Y * cos,
                                v.Z);
        }

        public static Vector3 RotateVector (Vector3 v, Matrix3 rotationMatrix)
        {
            return rotationMatrix * v;
        }
    }
}