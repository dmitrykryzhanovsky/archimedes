using System;

namespace Archimedes
{
    public static class Rotation3
    {
        /// <summary>
        /// Поворот вектора v матрицей поворота rotationMatrix.
        /// </summary>
        public static Vector3 ApplyRotation (Matrix3 rotationMatrix, Vector3 v)
        {
            return rotationMatrix * v;
        }

        /// <summary>
        /// Повороты системы координат.
        /// </summary>
        public static class Reference
        {
            #region Матрицы поворота системы координат

            #region Вокруг оси OX

            /// <summary>
            /// Вычисляет матрицу поворота системы координат вокруг оси OX на угол phi.
            /// </summary>
            public static Matrix3 GetRotationMatrixAroundOX (double phi)
            {
                (double sin, double cos) = Double.SinCos (phi);

                return GetRotationMatrixAroundOX (sin, cos);
            }

            /// <summary>
            /// Вычисляет матрицу поворота системы координат вокруг оси OX на угол, заданный синусом sin и косинусом cos.
            /// </summary>
            /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
            public static Matrix3 GetRotationMatrixAroundOX (double sin, double cos)
            {
                return new Matrix3 (1.0,  0.0, 0.0,
                                    0.0,  cos, sin,
                                    0.0, -sin, cos);
            }

            /// <summary>
            /// Вычисляет матрицы поворота системы координат вокруг оси OX на угол phi и угол -phi (т.е. в противоположном направлении).
            /// </summary>
            public static (Matrix3 direct, Matrix3 backward) GetRotationMatrixAroundOXBoth (double phi)
            {
                (double sin, double cos) = Double.SinCos (phi);

                return GetRotationMatrixAroundOXBoth (sin, cos);
            }

            /// <summary>
            /// Вычисляет матрицы поворота системы координат вокруг оси OX на угол, заданный синусом sin и косинусом cos, и равный ему по 
            /// модулю угол, но в противоположном направлении.
            /// </summary>
            /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
            public static (Matrix3 direct, Matrix3 backward) GetRotationMatrixAroundOXBoth (double sin, double cos)
            {
                Matrix3 direct   = new Matrix3 (1.0,  0.0,  0.0,
                                                0.0,  cos,  sin,
                                                0.0, -sin,  cos);

                Matrix3 backward = new Matrix3 (1.0,  0.0,  0.0,
                                                0.0,  cos, -sin,
                                                0.0,  sin,  cos);

                return (direct, backward);
            }

            #endregion

            #region Вокруг оси OY

            /// <summary>
            /// Вычисляет матрицу поворота системы координат вокруг оси OY на угол phi.
            /// </summary>
            public static Matrix3 GetRotationMatrixAroundOY (double phi)
            {
                (double sin, double cos) = Double.SinCos (phi);

                return GetRotationMatrixAroundOY (sin, cos);
            }

            /// <summary>
            /// Вычисляет матрицу поворота системы координат вокруг оси OY на угол, заданный синусом sin и косинусом cos.
            /// </summary>
            /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
            public static Matrix3 GetRotationMatrixAroundOY (double sin, double cos)
            {
                return new Matrix3 (cos, 0.0, -sin,
                                    0.0, 1.0,  0.0,
                                    sin, 0.0,  cos);
            }

            /// <summary>
            /// Вычисляет матрицы поворота системы координат вокруг оси OY на угол phi и угол -phi (т.е. в противоположном направлении).
            /// </summary>
            public static (Matrix3 direct, Matrix3 backward) GetRotationMatrixAroundOYBoth (double phi)
            {
                (double sin, double cos) = Double.SinCos (phi);

                return GetRotationMatrixAroundOYBoth (sin, cos);
            }

            /// <summary>
            /// Вычисляет матрицы поворота системы координат вокруг оси OY на угол, заданный синусом sin и косинусом cos, и равный ему по 
            /// модулю угол, но в противоположном направлении.
            /// </summary>
            /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
            public static (Matrix3 direct, Matrix3 backward) GetRotationMatrixAroundOYBoth (double sin, double cos)
            {
                Matrix3 direct   = new Matrix3 ( cos, 0.0, -sin,
                                                 0.0, 1.0,  0.0,
                                                 sin, 0.0,  cos);

                Matrix3 backward = new Matrix3 (cos,  0.0,  sin,
                                                 0.0, 1.0,  0.0,
                                                -sin, 0.0,  cos);

                return (direct, backward);
            }

            #endregion

            #region Вокруг оси OZ

            /// <summary>
            /// Вычисляет матрицу поворота системы координат вокруг оси OZ на угол phi.
            /// </summary>
            public static Matrix3 GetRotationMatrixAroundOZ (double phi)
            {
                (double sin, double cos) = Double.SinCos (phi);

                return GetRotationMatrixAroundOZ (sin, cos);
            }

            /// <summary>
            /// Вычисляет матрицу поворота системы координат вокруг оси OZ на угол, заданный синусом sin и косинусом cos.
            /// </summary>
            /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
            public static Matrix3 GetRotationMatrixAroundOZ (double sin, double cos)
            {
                return new Matrix3 ( cos, sin, 0.0,
                                    -sin, cos, 0.0,
                                     0.0, 0.0, 1.0);
            }

            /// <summary>
            /// Вычисляет матрицы поворота системы координат вокруг оси OZ на угол phi и угол -phi (т.е. в противоположном направлении).
            /// </summary>
            public static (Matrix3 direct, Matrix3 backward) GetRotationMatrixAroundOZBoth (double phi)
            {
                (double sin, double cos) = Double.SinCos (phi);

                return GetRotationMatrixAroundOZBoth (sin, cos);
            }

            /// <summary>
            /// Вычисляет матрицы поворота системы координат вокруг оси OZ на угол, заданный синусом sin и косинусом cos, и равный ему по 
            /// модулю угол, но в противоположном направлении.
            /// </summary>
            /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
            public static (Matrix3 direct, Matrix3 backward) GetRotationMatrixAroundOZBoth (double sin, double cos)
            {
                Matrix3 direct   = new Matrix3 ( cos,  sin, 0.0,
                                                -sin,  cos, 0.0,
                                                 0.0,  0.0, 1.0);

                Matrix3 backward = new Matrix3 ( cos, -sin, 0.0,
                                                 sin,  cos, 0.0,
                                                 0.0,  0.0, 1.0);

                return (direct, backward);
            }

            #endregion

            #endregion

            /// <summary>
            /// Поворот системы координат вокруг оси OX на угол phi.
            /// </summary>
            /// <param name="v">Вектор, координаты которого нужно вычислить в новой системе координат.</param>
            public static Vector3 RotateAroundOX (Vector3 v, double phi)
            {
                (double sin, double cos) = Double.SinCos (phi);

                return RotateAroundOX (v, sin, cos);
            }

            /// <summary>
            /// Поворот системы координат вокруг оси OX на угол, заданный синусом sin и косинусом cos.
            /// </summary>
            /// <param name="v">Вектор, координаты которого нужно вычислить в новой системе координат.</param>
            /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
            public static Vector3 RotateAroundOX (Vector3 v, double sin, double cos)
            {
                return new Vector3 ( v.X,
                                     v.Y * cos + v.Z * sin,
                                    -v.Y * sin + v.Z * cos);
            }

            /// <summary>
            /// Поворот системы координат вокруг оси OX на угол phi.
            /// </summary>
            /// <param name="p">Полярные координаты, которые нужно вычислить в новой системе координат.</param>
            /// <seealso href="https://github.com/dmitrykryzhanovsky/archimedes/wiki/Полярные-координаты-при-поворотах"/>
            public static Polar3 RotateAroundOX (Polar3 p, double phi)
            {
                (double sin, double cos) = Double.SinCos (phi);

                return RotateAroundOX (p, sin, cos);
            }

            /// <summary>
            /// Поворот системы координат вокруг оси OX на угол, заданный синусом sin и косинусом cos.
            /// </summary>
            /// <param name="p">Полярные координаты, которые нужно вычислить в новой системе координат.</param>
            /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
            /// <seealso href="https://github.com/dmitrykryzhanovsky/archimedes/wiki/Полярные-координаты-при-поворотах"/>
            public static Polar3 RotateAroundOX (Polar3 p, double sin, double cos)
            {
                (double sinb, double cosb) = Double.SinCos (p.Latitude);
                (double sinl, double cosl) = Double.SinCos (p.Longitude);

                return new Polar3 (p.R,
                                   ComputeLongitudeAfterReferenceRotationAroundOX (sinb, cosb, sinl, cosl, sin, cos),
                                   ComputeLatitudeAfterReferenceRotationAroundOX (sinb, cosb, sinl, sin, cos));
            }

            /// <summary>
            /// Поворот системы координат вокруг оси OX на угол phi.
            /// </summary>
            /// <returns>Возвращает значения широты b и долготы l в новой системе координат.</returns>
            /// <seealso href="https://github.com/dmitrykryzhanovsky/archimedes/wiki/Полярные-координаты-при-поворотах"/>
            public static (double, double) RotateAroundOX (double b, double l, double phi)
            {
                (double sin, double cos) = Double.SinCos (phi);

                return RotateAroundOX (b, l, sin, cos);
            }

            /// <summary>
            /// Поворот системы координат вокруг оси OX на угол, заданный синусом sin и косинусом cos.
            /// </summary>
            /// <returns>Возвращает значения широты b и долготы l в новой системе координат.</returns>
            /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
            /// <seealso href="https://github.com/dmitrykryzhanovsky/archimedes/wiki/Полярные-координаты-при-поворотах"/>
            public static (double, double) RotateAroundOX (double b, double l, double sin, double cos)
            {
                (double sinb, double cosb) = Double.SinCos (b);
                (double sinl, double cosl) = Double.SinCos (l);

                return (ComputeLatitudeAfterReferenceRotationAroundOX (sinb, cosb, sinl, sin, cos),
                        ComputeLongitudeAfterReferenceRotationAroundOX (sinb, cosb, sinl, cosl, sin, cos));
            }

            /// <summary>
            /// Вычисляет долготу в новой системе координат.
            /// </summary>
            /// <remarks>Долгота вычисляется через арктангенс отношения y / x, числитель и знаменатель которого, в свою очередь 
            /// вычисляются через тригонометрические функции широты и долготы в прежней системе координат, а также угла поворота. 
            /// В результате вычислений может оказаться так, что для y или x, которые на самом деле равны 0, будут получены малые 
            /// значения, отличные от 0, и отношение y / x будет равно какому-то числу, значительно большему 0, что даст неверный ответ: 
            /// вместо Atan2 (0, 0) = 0 получится Atan2 >> 0, соответствующий какому-то углу, заметно больше 0.  Чтобы этого избежать, 
            /// внутри метода делается проверка: если y или x меньше некоторого малого числа (например, 1.0e-12), то они принудительно 
            /// приравниваются к строго 0. При этом ситуация, когда малые значения y и x могут действительно соответствовать какому-то 
            /// отношению y / x, заметно отличному от 0, здесь исключается, так как синусы и косинусы всегда заключены на интервале [0; 1] 
            /// по абсолютному значению, и значения y и x в данном методе << 1.0e-10 действительно можно принимать равными 0 вследствие 
            /// ошибок округления.</remarks>
            /// <seealso href="https://github.com/dmitrykryzhanovsky/archimedes/wiki/Полярные-координаты-при-поворотах#0-и-ошибки-округления"/>
            private static double ComputeLongitudeAfterReferenceRotationAroundOX (double sinb, double cosb, double sinl, double cosl, double sin, double cos)
            {
                double y = cosb * sinl * cos + sinb * sin;
                double x = cosb * cosl;

                if ((-ComputingSettings.ZeroAccuracy <= y) && (y <= ComputingSettings.ZeroAccuracy)) y = 0.0;
                if ((-ComputingSettings.ZeroAccuracy <= x) && (x <= ComputingSettings.ZeroAccuracy)) x = 0.0;

                return Double.Atan2 (y, x);
            }

            /// <summary>
            /// Вычисляет широту в новой системе координат.
            /// </summary>
            /// <remarks>В методе происходит принудительное приравнивание аргумента арксинуса z к 0 или ±1 в тех случаях, когда z 
            /// отличается от этих крайних значений на очень небольшое число (например, 1.0e-12). Делается это для того, чтобы в ситуациях, 
            /// когда метод должен вернуть особые значения широты (0°, ±90°) возвращались именно они, а не близкие им значения, но не 
            /// являющиеся особыми.</remarks>
            /// <seealso href="https://github.com/dmitrykryzhanovsky/archimedes/wiki/Полярные-координаты-при-поворотах#0-и-ошибки-округления"/>
            private static double ComputeLatitudeAfterReferenceRotationAroundOX (double sinb, double cosb, double sinl, double sin, double cos)
            {
                double z = -cosb * sinl * sin + sinb * cos;

                if ((-ComputingSettings.ZeroAccuracy <= z) && (z <= ComputingSettings.ZeroAccuracy)) z = 0.0;
                else if ((1.0 - z) <= ComputingSettings.ZeroAccuracy) z = 1.0;
                else if ((z + 1.0) <= ComputingSettings.ZeroAccuracy) z = -1.0;

                return Double.Asin (z);
            }
        }

        /// <summary>
        /// Вращения вектора в неподвижной системе координат.
        /// </summary>
        public static class Vector
        {
            /// <summary>
            /// Поворот вектора v вокруг оси OX на угол phi.
            /// </summary>
            public static Vector3 RotateAroundOX (Vector3 v, double phi)
            {
                (double sin, double cos) = Double.SinCos (phi);

                return RotateAroundOX (v, sin, cos);
            }

            /// <summary>
            /// Поворот вектора v вокруг оси OX на угол, заданный синусом sin и косинусом cos.
            /// </summary>
            /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
            public static Vector3 RotateAroundOX (Vector3 v, double sin, double cos)
            {
                return new Vector3 (v.X,
                                    v.Y * cos - v.Z * sin,
                                    v.Y * sin + v.Z * cos);
            }

            /// <summary>
            /// Поворот вектора v вокруг оси OY на угол phi.
            /// </summary>
            public static Vector3 RotateAroundOY (Vector3 v, double phi)
            {
                (double sin, double cos) = Double.SinCos (phi);

                return RotateAroundOY (v, sin, cos);
            }

            /// <summary>
            /// Поворот вектора v вокруг оси OY на угол, заданный синусом sin и косинусом cos.
            /// </summary>
            /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
            public static Vector3 RotateAroundOY (Vector3 v, double sin, double cos)
            {
                return new Vector3 ( v.X * cos + v.Z * sin,
                                     v.Y,
                                    -v.X * sin + v.Z * cos);
            }

            /// <summary>
            /// Поворот вектора v вокруг оси OZ на угол phi.
            /// </summary>
            public static Vector3 RotateAroundOZ (Vector3 v, double phi)
            {
                (double sin, double cos) = Double.SinCos (phi);

                return RotateAroundOZ (v,sin, cos);
            }

            /// <summary>
            /// Поворот вектора v вокруг оси OZ на угол, заданный синусом sin и косинусом cos.
            /// </summary>
            /// <remarks>Проверка значений sin и cos на соответствие основному тригонометрическому тождеству в методе не производится.</remarks>
            public static Vector3 RotateAroundOZ (Vector3 v, double sin, double cos)
            {
                return new Vector3 (v.X * cos - v.Y * sin,
                                    v.X * sin + v.Y * cos,
                                    v.Z);
            }
        }
    }
}