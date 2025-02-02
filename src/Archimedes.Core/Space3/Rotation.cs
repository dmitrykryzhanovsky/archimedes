namespace Archimedes.Space3
{
    public static class Rotation
    {
        public static class GetRotationMatrix
        {
            public static class Active
            {
                public static class AroundOX
                {
                    public static Matrix3 GetMatrix (double angle)
                    {
                        (double sin, double cos) = double.SinCos (angle);

                        return GetMatrix (sin, cos);
                    }

                    public static Matrix3 GetMatrix (double sin, double cos)
                    {
                        return new Matrix3 (1,   0,    0,
                                            0, cos, -sin,
                                            0, sin,  cos);
                    }
                }

                public static class AroundOY
                {
                    public static Matrix3 GetMatrix (double angle)
                    {
                        (double sin, double cos) = double.SinCos (angle);

                        return GetMatrix (sin, cos);
                    }

                    public static Matrix3 GetMatrix (double sin, double cos)
                    {
                        return new Matrix3 ( cos, 0, sin,
                                               0, 1,   0,
                                            -sin, 0, cos);
                    }
                }

                public static class AroundOZ
                {
                    public static Matrix3 GetMatrix (double angle)
                    {
                        (double sin, double cos) = double.SinCos (angle);

                        return GetMatrix (sin, cos);
                    }

                    public static Matrix3 GetMatrix (double sin, double cos)
                    {
                        return new Matrix3 (cos, -sin, 0,
                                            sin,  cos, 0,
                                              0,    0, 1);
                    }
                }
            }

            public static class Passive
            {
                public static class AroundOX
                {
                    public static Matrix3 GetMatrix (double angle)
                    {
                        (double sin, double cos) = double.SinCos (angle);

                        return GetMatrix (sin, cos);
                    }

                    public static Matrix3 GetMatrix (double sin, double cos)
                    {
                        return new Matrix3 (1,    0,   0,
                                            0,  cos, sin,
                                            0, -sin, cos);
                    }
                }

                public static class AroundOY
                {
                    public static Matrix3 GetMatrix (double angle)
                    {
                        (double sin, double cos) = double.SinCos (angle);

                        return GetMatrix (sin, cos);
                    }

                    public static Matrix3 GetMatrix (double sin, double cos)
                    {
                        return new Matrix3 (cos, 0, -sin,
                                              0, 1,    0,
                                            sin, 0,  cos);
                    }
                }

                public static class AroundOZ
                {
                    public static Matrix3 GetMatrix (double angle)
                    {
                        (double sin, double cos) = double.SinCos (angle);

                        return GetMatrix (sin, cos);
                    }

                    public static Matrix3 GetMatrix (double sin, double cos)
                    {
                        return new Matrix3 ( cos, sin, 0,
                                            -sin, cos, 0,
                                               0,   0, 1);
                    }
                }

                public static class EulerAngles
                {
                    /// <summary>
                    /// Возвращает матрицу поворота системы координат, заданного углами Эйлера.
                    /// </summary>
                    /// <param name="alpha">Угол прецессии – поворот оси OX до линии узлов.</param>
                    /// <param name="beta">Угол нутации – наклон оси OZ.</param>
                    /// <param name="gamma">Угол собственного вращения – поворот оси OX от линии узлов до её нового положения.</param>
                    public static Matrix3 GetMatrix (double alpha, double beta, double gamma)
                    {
                        (double sinA, double cosA) = double.SinCos (alpha);
                        (double sinB, double cosB) = double.SinCos (beta);
                        (double sinG, double cosG) = double.SinCos (gamma);

                        return GetMatrix (sinA, cosA, sinB, cosB, sinG, cosG);
                    }

                    /// <summary>
                    /// Возвращает матрицу поворота системы координат, заданного синусами и косинусами углов Эйлера.
                    /// </summary>
                    /// <remarks><list type="bullet">
                    /// <item>sinA, cosA – угол прецессии (поворот оси OX до линии узлов).</item>
                    /// <item>sinB, cosB – угол нутации (наклон оси OZ).</item>
                    /// <item>sinG, cosG – угол собственного вращения (поворот оси OX от линии узлов до её нового положения).</item>
                    /// <item>Проверка на соответствие синусов и косинусов основному тригонометрическому тождеству в методе не производится.</item>
                    /// </list></remarks>
                    public static Matrix3 GetMatrix (double sinA, double cosA, double sinB, double cosB, double sinG, double cosG)
                    {
                        double cosBsinA = cosB * sinA;
                        double cosBcosA = cosB * cosA;

                        return new Matrix3 ( cosG * cosA - sinG * cosBsinA,  cosG * sinA + sinG * cosBcosA, sinG * sinB,
                                            -sinG * cosA - cosG * cosBsinA, -sinG * sinA + cosG * cosBcosA, cosG * sinB,
                                                               sinB * sinA,                   -sinB * cosA,        cosB);
                    }
                }
            }
        }

        public static class Apply
        {
            public static Vector3 Rotate (Vector3 v, Matrix3 rotationMatrix)
            {
                return rotationMatrix * v;
            }

            public static class Passive
            {
                public static class AroundOX
                {
                    public static Vector3 RotateSpace (Vector3 v, double angle)
                    {
                        (double sin, double cos) = double.SinCos (angle);

                        return RotateSpace (v, sin, cos);
                    }

                    public static Vector3 RotateSpace (Vector3 v, double sin, double cos)
                    {
                        return new Vector3 ( v.X,
                                             v.Y * cos + v.Z * sin,
                                            -v.Y * sin + v.Z * cos);
                    }

                    public static Polar3 RotateSpace (Polar3 p, double angle)
                    {
                        (double sinAngle, double cosAngle) = double.SinCos (angle);

                        return RotateSpace (p, sinAngle, cosAngle);
                    }

                    public static Polar3 RotateSpace (Polar3 p, double sinAngle, double cosAngle)
                    {
                        (double latitude, double longitude) = ComputeNewAngles (p, sinAngle, cosAngle);

                        return Polar3.InitDirect (p.R, latitude, longitude);
                    }

                    public static UnitPolar3 RotateSpace (UnitPolar3 p, double angle)
                    {
                        (double sinAngle, double cosAngle) = double.SinCos (angle);

                        return RotateSpace (p, sinAngle, cosAngle);
                    }

                    public static UnitPolar3 RotateSpace (UnitPolar3 p, double sinAngle, double cosAngle)
                    {
                        (double latitude, double longitude) = ComputeNewAngles (p, sinAngle, cosAngle);

                        return UnitPolar3.InitDirect (latitude, longitude);
                    }

                    private static (double latitude, double longitude) ComputeNewAngles (Polar3 p, double sinAngle, double cosAngle)
                    {
                        (double sinB, double cosB) = double.SinCos (p.Latitude);
                        (double sinL, double cosL) = double.SinCos (p.Longitude);

                        double dx = cosB * cosL;
                        double dy = cosB * sinL * cosAngle + sinB * sinAngle;
                        double sinB1 = -cosB * sinL * sinAngle + sinB * cosAngle;

                        return (latitude: Trigonometry.AsinSmall (sinB1, ComputingSettings.SmallAngleEpsilon),
                                longitude: Trigonometry.Atan2Small (dy, dx, ComputingSettings.SmallAngleEpsilon));
                    }
                }

                public static class AroundOY
                {
                    public static Vector3 RotateSpace (Vector3 v, double angle)
                    {
                        (double sin, double cos) = double.SinCos (angle);

                        return RotateSpace (v, sin, cos);
                    }

                    public static Vector3 RotateSpace (Vector3 v, double sin, double cos)
                    {
                        return new Vector3 (v.X * cos - v.Z * sin,
                                            v.Y,
                                            v.X * sin + v.Z * cos);
                    }

                    public static Polar3 RotateSpace (Polar3 p, double angle)
                    {
                        (double sinAngle, double cosAngle) = double.SinCos (angle);

                        return RotateSpace (p, sinAngle, cosAngle);
                    }

                    public static Polar3 RotateSpace (Polar3 p, double sinAngle, double cosAngle)
                    {
                        (double latitude, double longitude) = ComputeNewAngles (p, sinAngle, cosAngle);

                        return Polar3.InitDirect (p.R, latitude, longitude);
                    }

                    public static UnitPolar3 RotateSpace (UnitPolar3 p, double angle)
                    {
                        (double sinAngle, double cosAngle) = double.SinCos (angle);

                        return RotateSpace (p, sinAngle, cosAngle);
                    }

                    public static UnitPolar3 RotateSpace (UnitPolar3 p, double sinAngle, double cosAngle)
                    {
                        (double latitude, double longitude) = ComputeNewAngles (p, sinAngle, cosAngle);

                        return UnitPolar3.InitDirect (latitude, longitude);
                    }

                    private static (double latitude, double longitude) ComputeNewAngles (Polar3 p, double sinAngle, double cosAngle)
                    {
                        (double sinB, double cosB) = double.SinCos (p.Latitude);
                        (double sinL, double cosL) = double.SinCos (p.Longitude);

                        double dx = cosB * sinL * cosAngle - sinB * sinAngle;
                        double dy = cosB * cosL;
                        double sinB1 = cosB * cosL * sinAngle + sinB * cosAngle;

                        return (latitude: Trigonometry.AsinSmall (sinB1, ComputingSettings.SmallAngleEpsilon),
                                longitude: Trigonometry.Atan2Small (dy, dx, ComputingSettings.SmallAngleEpsilon));
                    }
                }

                public static class AroundOZ
                {
                    public static Vector3 RotateSpace (Vector3 v, double angle)
                    {
                        (double sin, double cos) = double.SinCos (angle);

                        return RotateSpace (v, sin, cos);
                    }

                    public static Vector3 RotateSpace (Vector3 v, double sin, double cos)
                    {
                        return new Vector3 ( v.X * cos + v.Y * sin,
                                            -v.X * sin + v.Y * cos,
                                             v.Z);
                    }

                    public static Polar3 RotateSpace (Polar3 p, double angle)
                    {
                        (double sinAngle, double cosAngle) = double.SinCos (angle);

                        return RotateSpace (p, sinAngle, cosAngle);
                    }

                    public static Polar3 RotateSpace (Polar3 p, double sinAngle, double cosAngle)
                    {
                        return Polar3.InitDirect (p.R, p.Latitude, ComputeNewAngles (p, sinAngle, cosAngle));
                    }

                    public static UnitPolar3 RotateSpace (UnitPolar3 p, double angle)
                    {
                        (double sinAngle, double cosAngle) = double.SinCos (angle);

                        return RotateSpace (p, sinAngle, cosAngle);
                    }

                    public static UnitPolar3 RotateSpace (UnitPolar3 p, double sinAngle, double cosAngle)
                    {
                        return UnitPolar3.InitDirect (p.Latitude, ComputeNewAngles (p, sinAngle, cosAngle));
                    }

                    private static double ComputeNewAngles (Polar3 p, double sinAngle, double cosAngle)
                    {
                        double cosB = double.Cos (p.Latitude);
                        (double sinL, double cosL) = double.SinCos (p.Longitude);

                        double dx =  cosB * cosL * cosAngle + cosB * sinL * sinAngle;
                        double dy = -cosB * cosL * sinAngle + cosB * sinL * cosAngle;

                        return Trigonometry.Atan2Small (dy, dx, ComputingSettings.SmallAngleEpsilon);
                    }
                }

                public static class EulerAngles
                {
                    /// <summary>
                    /// Возвращает декартовы координаты вектора v в новой системе координат, полученной после поворота старой системы координат, 
                    /// заданного углами Эйлера.
                    /// </summary>
                    /// <param name="alpha">Угол прецессии – поворот оси OX до линии узлов.</param>
                    /// <param name="beta">Угол нутации – наклон оси OZ.</param>
                    /// <param name="gamma">Угол собственного вращения – поворот оси OX от линии узлов до её нового положения.</param>
                    public static Vector3 RotateSpace (Vector3 v, double alpha, double beta, double gamma)
                    {
                        (double sinA, double cosA) = double.SinCos (alpha);
                        (double sinB, double cosB) = double.SinCos (beta);
                        (double sinG, double cosG) = double.SinCos (gamma);

                        return RotateSpace (v, sinA, cosA, sinB, cosB, sinG, cosG);
                    }

                    /// <summary>
                    /// Возвращает декартовы координаты вектора v в новой системе координат, полученной после поворота старой системы 
                    /// координат, заданного синусами и косинусами углов Эйлера.
                    /// </summary>
                    /// <remarks><list type="bullet">
                    /// <item>sinA, cosA – угол прецессии (поворот оси OX до линии узлов).</item>
                    /// <item>sinB, cosB – угол нутации (наклон оси OZ).</item>
                    /// <item>sinG, cosG – угол собственного вращения (поворот оси OX от линии узлов до её нового положения).</item>
                    /// <item>Проверка на соответствие синусов и косинусов основному тригонометрическому тождеству в методе не 
                    /// производится.</item>
                    /// </list></remarks>
                    public static Vector3 RotateSpace (Vector3 v, double sinA, double cosA, double sinB, double cosB, double sinG, double cosG)
                    {
                        double cosBsinA = cosB * sinA;
                        double cosBcosA = cosB * cosA;

                        return new Vector3 (v.X * ( cosG * cosA - sinG * cosBsinA) + v.Y * ( cosG * sinA + sinG * cosBcosA) + v.Z * sinG * sinB,
                                            v.X * (-sinG * cosA - cosG * cosBsinA) + v.Y * (-sinG * sinA + cosG * cosBcosA) + v.Z * cosG * sinB,
                                                                 v.X * sinB * sinA                       -v.Y * sinB * cosA + v.Z *        cosB);
                    }

                    /// <summary>
                    /// Возвращает полярные координаты вектора p в новой системе координат, полученной после поворота старой системы координат, 
                    /// заданного углами Эйлера.
                    /// </summary>
                    /// <param name="alpha">Угол прецессии – поворот оси OX до линии узлов.</param>
                    /// <param name="beta">Угол нутации – наклон оси OZ.</param>
                    /// <param name="gamma">Угол собственного вращения – поворот оси OX от линии узлов до её нового положения.</param>
                    public static Polar3 RotateSpace (Polar3 p, double alpha, double beta, double gamma)
                    {
                        (double sinA, double cosA) = double.SinCos (alpha);
                        (double sinB, double cosB) = double.SinCos (beta);
                        (double sinG, double cosG) = double.SinCos (gamma);

                        return RotateSpace (p, sinA, cosA, sinB, cosB, sinG, cosG);
                    }

                    /// <summary>
                    /// Возвращает полярные координаты вектора p в новой системе координат, полученной после поворота старой системы 
                    /// координат, заданного синусами и косинусами углов Эйлера.
                    /// </summary>
                    /// <remarks><list type="bullet">
                    /// <item>sinA, cosA – угол прецессии (поворот оси OX до линии узлов).</item>
                    /// <item>sinB, cosB – угол нутации (наклон оси OZ).</item>
                    /// <item>sinG, cosG – угол собственного вращения (поворот оси OX от линии узлов до её нового положения).</item>
                    /// <item>Проверка на соответствие синусов и косинусов основному тригонометрическому тождеству в методе не 
                    /// производится.</item>
                    /// </list></remarks>
                    public static Polar3 RotateSpace (Polar3 p, double sinA, double cosA, double sinB, double cosB, double sinG, double cosG)
                    {
                        (double latitude, double longitude) = ComputeNewAngles (p, sinA, cosA, sinB, cosB, sinG, cosG);

                        return Polar3.InitDirect (p.R, latitude, longitude);
                    }

                    /// <summary>
                    /// Возвращает полярные координаты единичного вектора p в новой системе координат, полученной после поворота старой 
                    /// системы координат, заданного углами Эйлера.
                    /// </summary>
                    /// <param name="alpha">Угол прецессии – поворот оси OX до линии узлов.</param>
                    /// <param name="beta">Угол нутации – наклон оси OZ.</param>
                    /// <param name="gamma">Угол собственного вращения – поворот оси OX от линии узлов до её нового положения.</param>
                    public static UnitPolar3 RotateSpace (UnitPolar3 p, double alpha, double beta, double gamma)
                    {
                        (double sinA, double cosA) = double.SinCos (alpha);
                        (double sinB, double cosB) = double.SinCos (beta);
                        (double sinG, double cosG) = double.SinCos (gamma);

                        return RotateSpace (p, sinA, cosA, sinB, cosB, sinG, cosG);
                    }

                    /// <summary>
                    /// Возвращает полярные координаты единичного вектора p в новой системе координат, полученной после поворота старой 
                    /// системы координат, заданного синусами и косинусами углов Эйлера.
                    /// </summary>
                    /// <remarks><list type="bullet">
                    /// <item>sinA, cosA – угол прецессии (поворот оси OX до линии узлов).</item>
                    /// <item>sinB, cosB – угол нутации (наклон оси OZ).</item>
                    /// <item>sinG, cosG – угол собственного вращения (поворот оси OX от линии узлов до её нового положения).</item>
                    /// <item>Проверка на соответствие синусов и косинусов основному тригонометрическому тождеству в методе не 
                    /// производится.</item>
                    /// </list></remarks>
                    public static UnitPolar3 RotateSpace (UnitPolar3 p, double sinA, double cosA, double sinB, double cosB, double sinG, double cosG)
                    {
                        (double latitude, double longitude) = ComputeNewAngles (p, sinA, cosA, sinB, cosB, sinG, cosG);

                        return UnitPolar3.InitDirect (latitude, longitude);
                    }

                    /// <summary>
                    /// Метод для расчёта полярных координат – широты и долготы вектора p – в новой системе координат, полученной после 
                    /// поворота старой системы координат, заданного синусами и косинусами углов Эйлера.
                    /// </summary>
                    /// <returns><list type="bullet">
                    /// <item>latitude – широта в новой системе координат.</item>
                    /// <item>longitude – долгота в новой системе координат.</item>
                    /// </list></returns>
                    /// <remarks>Проверка на соответствие синусов и косинусов основному тригонометрическому тождеству в методе не 
                    /// производится.</remarks>
                    private static (double latitude, double longitude) ComputeNewAngles (Polar3 p, double sinA, double cosA, double sinB, double cosB, double sinG, double cosG)
                    {
                        (double sinPhi, double cosPhi) = double.SinCos (p.Latitude);
                        (double sinL, double cosL) = double.SinCos (p.Longitude);

                        double cosBsinA   = cosB * sinA;
                        double cosBcosA   = cosB * cosA;
                        double cosPhicosL = cosPhi * cosL;
                        double cosPhisinL = cosPhi * sinL;
                        double sinPhisinB = sinPhi * sinB;

                        double dx = cosPhicosL * ( cosG * cosA - sinG * cosBsinA) + cosPhisinL * ( cosG * sinA + sinG * cosBcosA) + sinPhisinB * sinG;
                        double dy = cosPhicosL * (-sinG * cosA - cosG * cosBsinA) + cosPhisinL * (-sinG * sinA + cosG * cosBcosA) + sinPhisinB * cosG;
                        double sinPhi1 = cosPhicosL * sinB * sinA - cosPhisinL * sinB * cosA + sinPhi * cosB;

                        return (latitude: Trigonometry.AsinSmall (sinPhi1, ComputingSettings.SmallAngleEpsilon),
                                longitude: Trigonometry.Atan2Small (dy, dx, ComputingSettings.SmallAngleEpsilon));
                    }
                }
            }
        }
    }
}