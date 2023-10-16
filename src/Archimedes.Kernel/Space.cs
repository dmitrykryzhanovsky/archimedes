﻿using System;

namespace Archimedes
{
    public static class Space
    {
        #region Поворот вокруг оси OX

        #region Матрицы поворота

        /// <summary>
        /// Вычисляет матрицу поворота вокруг оси OX на угол phi.
        /// </summary>
        public static Matrix3 GetRotationMatrixAroundOX (double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return GetRotationMatrixAroundOX (sin, cos);
        }

        /// <summary>
        /// Вычисляет матрицу поворота вокруг оси OX на угол, заданный синусом sin и косинусом cos.
        /// </summary>
        /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
        public static Matrix3 GetRotationMatrixAroundOX (double sin, double cos)
        {
            return new Matrix3 (1.0,  0.0, 0.0,
                                0.0,  cos, sin,
                                0.0, -sin, cos);
        }

        /// <summary>
        /// Вычисляет матрицы поворота вокруг оси OX на угол phi и угол -phi (т.е. в противоположном направлении).
        /// </summary>
        public static (Matrix3 direct, Matrix3 backward) GetRotationMatrixAroundOXBoth (double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return GetRotationMatrixAroundOXBoth (sin, cos);
        }

        /// <summary>
        /// Вычисляет матрицы поворота вокруг оси OX на угол, заданный синусом sin и косинусом cos, и равный ему по модулю угол, но в 
        /// противоположном направлении.
        /// </summary>
        /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
        public static (Matrix3 direct, Matrix3 backward) GetRotationMatrixAroundOXBoth (double sin, double cos)
        {
            Matrix3 direct = new Matrix3 (1.0,  0.0, 0.0,
                                          0.0,  cos, sin,
                                          0.0, -sin, cos);

            Matrix3 backward = new Matrix3 (1.0, 0.0,  0.0,
                                            0.0, cos, -sin,
                                            0.0, sin,  cos);

            return (direct, backward);
        }

        #endregion

        #region Поворот вектора

        /// <summary>
        /// Поворот вектора v вокруг оси OX на угол phi.
        /// </summary>
        public static Vector3 RotateVectorAroundOX (Vector3 v, double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return RotateVectorAroundOX (v, sin, cos);
        }

        /// <summary>
        /// Поворот вектора v вокруг оси OX на угол, заданный синусом sin и косинусом cos.
        /// </summary>
        /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
        public static Vector3 RotateVectorAroundOX (Vector3 v, double sin, double cos)
        {
            return new Vector3 (v.X,
                                v.Y * cos - v.Z * sin,
                                v.Y * sin + v.Z * cos);
        }

        #endregion

        #region Поворот системы координат

        /// <summary>
        /// Поворот системы координат вокруг оси OX на угол phi.
        /// </summary>
        /// <param name="v">Вектор, координаты которого нужно вычислить в новой системе координат.</param>
        public static Vector3 RotateReferenceAroundOX (Vector3 v, double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return RotateReferenceAroundOX (v, sin, cos);
        }

        /// <summary>
        /// Поворот системы координат вокруг оси OX на угол, заданный синусом sin и косинусом cos.
        /// </summary>
        /// <param name="v">Вектор, координаты которого нужно вычислить в новой системе координат.</param>
        /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
        public static Vector3 RotateReferenceAroundOX (Vector3 v, double sin, double cos)
        {
            return new Vector3 ( v.X,
                                 v.Y * cos + v.Z * sin,
                                -v.Y * sin + v.Z * cos);
        }

        /// <summary>
        /// Поворот системы координат вокруг оси OX на угол phi.
        /// </summary>
        /// <param name="p">Полярные координаты, которые нужно вычислить в новой системе координат.</param>
        public static Polar3 RotateReferenceAroundOX (Polar3 p, double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return RotateReferenceAroundOX (p, sin, cos);
        }

        /// <summary>
        /// Поворот системы координат вокруг оси OX на угол, заданный синусом sin и косинусом cos.
        /// </summary>
        /// <param name="p">Полярные координаты, которые нужно вычислить в новой системе координат.</param>
        /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
        public static Polar3 RotateReferenceAroundOX (Polar3 p, double sin, double cos)
        {
            (double sinb, double cosb) = Math.SinCos (p.Latitude);
            (double sinl, double cosl) = Math.SinCos (p.Longitude);

            return new Polar3 (p.R,
                               RotateReferenceAroundOXForLongitude (sinb, cosb, sinl, cosl, sin, cos),
                               RotateReferenceAroundOXForLatitude (sinb, cosb, sinl, sin, cos));
        }

        /// <summary>
        /// Поворот системы координат вокруг оси OX на угол phi.
        /// </summary>
        /// <returns>Возвращает значения широты b и долготы l в новой системе координат.</returns>
        public static (double, double) RotateReferenceAroundOX (double b, double l, double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return RotateReferenceAroundOX (b, l, sin, cos);
        }

        /// <summary>
        /// Поворот системы координат вокруг оси OX на угол, заданный синусом sin и косинусом cos.
        /// </summary>
        /// <returns>Возвращает значения широты b и долготы l в новой системе координат.</returns>
        /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
        public static (double, double) RotateReferenceAroundOX (double b, double l, double sin, double cos)
        {
            (double sinb, double cosb) = Math.SinCos (b);
            (double sinl, double cosl) = Math.SinCos (l);

            return (RotateReferenceAroundOXForLatitude (sinb, cosb, sinl, sin, cos),
                    RotateReferenceAroundOXForLongitude (sinb, cosb, sinl, cosl, sin, cos));
        }

        private static double RotateReferenceAroundOXForLongitude (double sinb, double cosb, double sinl, double cosl, double sin, double cos)
        {
            return Math.Atan2 (cosb * sinl * cos + sinb * sin, cosb * cosl);
        }

        private static double RotateReferenceAroundOXForLatitude (double sinb, double cosb, double sinl, double sin, double cos)
        {
            return Math.Asin (-cosb * sinl * sin + sinb * cos);
        }

        #endregion

        #endregion

        #region Поворот вокруг оси OY

        #region Матрицы поворота

        public static Matrix3 GetRotationMatrixAroundOY (double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return GetRotationMatrixAroundOY (sin, cos);
        }

        public static Matrix3 GetRotationMatrixAroundOY (double sin, double cos)
        {
            return new Matrix3 (cos, 0.0, -sin,
                                0.0, 1.0,  0.0,
                                sin, 0.0,  cos);
        }

        public static (Matrix3 direct, Matrix3 backward) GetRotationMatrixAroundOYBoth (double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return GetRotationMatrixAroundOYBoth (sin, cos);
        }

        public static (Matrix3 direct, Matrix3 backward) GetRotationMatrixAroundOYBoth (double sin, double cos)
        {
            Matrix3 direct = new Matrix3 (cos, 0.0, -sin,
                                          0.0, 1.0,  0.0,
                                          sin, 0.0,  cos);

            Matrix3 backward = new Matrix3 ( cos, 0.0, sin,
                                             0.0, 1.0, 0.0,
                                            -sin, 0.0, cos);

            return (direct, backward);
        }

        #endregion

        #region Поворот вектора

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

        #endregion

        #endregion

        #region Поворот вокруг оси OZ

        #region Матрицы поворота

        public static Matrix3 GetRotationMatrixAroundOZ (double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return GetRotationMatrixAroundOZ (sin, cos);
        }

        public static Matrix3 GetRotationMatrixAroundOZ (double sin, double cos)
        {
            return new Matrix3 ( cos, sin, 0.0,
                                -sin, cos, 0.0,
                                 0.0, 0.0, 1.0);
        }

        public static (Matrix3 direct, Matrix3 backward) GetRotationMatrixAroundOZBoth (double phi)
        {
            (double sin, double cos) = Math.SinCos (phi);

            return GetRotationMatrixAroundOZBoth (sin, cos);
        }

        public static (Matrix3 direct, Matrix3 backward) GetRotationMatrixAroundOZBoth (double sin, double cos)
        {
            Matrix3 direct = new Matrix3 ( cos, sin, 0.0,
                                          -sin, cos, 0.0,
                                           0.0, 0.0, 1.0);

            Matrix3 backward = new Matrix3 (cos, -sin, 0.0,
                                            sin,  cos, 0.0,
                                            0.0,  0.0, 1.0);

            return (direct, backward);
        }

        #endregion

        #region Поворот вектора

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

        #endregion

        #endregion

        public static Vector3 RotateVector (Vector3 v, Matrix3 rotationMatrix)
        {
            return rotationMatrix * v;
        }
    }
}