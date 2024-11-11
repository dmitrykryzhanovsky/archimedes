using System.Net.Http.Headers;

namespace Archimedes
{
    public static class Rotation3
    {
        ////////////////////////////////////////////////////////////////////////////////
        // Матрицы для единичных вращений векторов в фиксированной системе координат. //
        ////////////////////////////////////////////////////////////////////////////////

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

        public static (Quaternion rotating, Quaternion reciprocal) GetRotationQuaternionsForVector (double angle, Vector3 axis)
        {
            (double sin, double cos) = double.SinCos (angle / 2.0);
            Vector3 u = axis.GetUnit ();

            return GetRotationQuaternionsForVector (sin, cos, u);
        }

        public static (Quaternion rotating, Quaternion reciprocal) GetRotationQuaternionsForVector (double sin, double cos, Vector3 u)
        {
            Quaternion rotating   = new Quaternion (cos,  u [0] * sin,  u [1] * sin,  u [2] * sin);
            Quaternion reciprocal = new Quaternion (cos, -u [0] * sin, -u [1] * sin, -u [2] * sin);

            return (rotating, reciprocal);
        }

        ////////////////////////////////////////////////////////
        // Матрицы для единичных поворотов системы координат. //
        ////////////////////////////////////////////////////////

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

        ////////////////////////////////////////////////////
        // Выполнить единичный поворот системы координат. //
        ////////////////////////////////////////////////////

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
                Trigonometry.Atan2Small (dy, dx, ComputingSettings.SmallAngleEpsilon));
        }

        public static UnitPolar3 RotateSpaceAroundOX (UnitPolar3 p, double phi)
        {
            (double sinPhi, double cosPhi) = double.SinCos (phi);

            return RotateSpaceAroundOX (p, sinPhi, cosPhi);
        }

        public static UnitPolar3 RotateSpaceAroundOX (UnitPolar3 p, double sinPhi, double cosPhi)
        {
            (double sinB, double cosB) = double.SinCos (p.Latitude);
            (double sinL, double cosL) = double.SinCos (p.Longitude);

            double dx = cosB * cosL;
            double dy = cosB * sinL * cosPhi + sinB * sinPhi;
            double sinB1 = -cosB * sinL * sinPhi + sinB * cosPhi;

            return new UnitPolar3 (Trigonometry.AsinSmall (sinB1, ComputingSettings.SmallAngleEpsilon),
                                   Trigonometry.Atan2Small (dy, dx, ComputingSettings.SmallAngleEpsilon));
        }

        public static Polar3 RotateSpaceAroundOY (Polar3 p, double phi)
        {
            (double sinPhi, double cosPhi) = double.SinCos (phi);

            return RotateSpaceAroundOY (p, sinPhi, cosPhi);
        }

        public static Polar3 RotateSpaceAroundOY (Polar3 p, double sinPhi, double cosPhi)
        {
            (double sinB, double cosB) = double.SinCos (p.Latitude);
            (double sinL, double cosL) = double.SinCos (p.Longitude);

            double dx = cosB * sinL * cosPhi - sinB * sinPhi;
            double dy = cosB * cosL;            
            double sinB1 = cosB * cosL * sinPhi + sinB * cosPhi;

            return Polar3.DirectInit (p.R,
                Trigonometry.AsinSmall (sinB1, ComputingSettings.SmallAngleEpsilon),
                Trigonometry.Atan2Small (dy, dx, ComputingSettings.SmallAngleEpsilon));
        }

        public static UnitPolar3 RotateSpaceAroundOY (UnitPolar3 p, double phi)
        {
            (double sinPhi, double cosPhi) = double.SinCos (phi);

            return RotateSpaceAroundOY (p, sinPhi, cosPhi);
        }

        public static UnitPolar3 RotateSpaceAroundOY (UnitPolar3 p, double sinPhi, double cosPhi)
        {
            (double sinB, double cosB) = double.SinCos (p.Latitude);
            (double sinL, double cosL) = double.SinCos (p.Longitude);

            double dx = cosB * sinL * cosPhi - sinB * sinPhi;
            double dy = cosB * cosL;
            double sinB1 = cosB * cosL * sinPhi + sinB * cosPhi;

            return new UnitPolar3 (Trigonometry.AsinSmall (sinB1, ComputingSettings.SmallAngleEpsilon),
                                   Trigonometry.Atan2Small (dy, dx, ComputingSettings.SmallAngleEpsilon));
        }

        public static Polar3 RotateSpaceAroundOZ (Polar3 p, double phi)
        {
            (double sinPhi, double cosPhi) = double.SinCos (phi);

            return RotateSpaceAroundOZ (p, sinPhi, cosPhi);
        }

        public static Polar3 RotateSpaceAroundOZ (Polar3 p, double sinPhi, double cosPhi)
        {
            double cosB = double.Cos (p.Latitude);
            (double sinL, double cosL) = double.SinCos (p.Longitude);

            double dx =  cosB * cosL * cosPhi + cosB * sinL * sinPhi;
            double dy = -cosB * cosL * sinPhi + cosB * sinL * cosPhi;

            return Polar3.DirectInit (p.R, p.Latitude,
                Trigonometry.Atan2Small (dy, dx, ComputingSettings.SmallAngleEpsilon));
        }

        public static UnitPolar3 RotateSpaceAroundOZ (UnitPolar3 p, double phi)
        {
            (double sinPhi, double cosPhi) = double.SinCos (phi);

            return RotateSpaceAroundOZ (p, sinPhi, cosPhi);
        }

        public static UnitPolar3 RotateSpaceAroundOZ (UnitPolar3 p, double sinPhi, double cosPhi)
        {
            double cosB = double.Cos (p.Latitude);
            (double sinL, double cosL) = double.SinCos (p.Longitude);

            double dx =  cosB * cosL * cosPhi + cosB * sinL * sinPhi;
            double dy = -cosB * cosL * sinPhi + cosB * sinL * cosPhi;

            return new UnitPolar3 (p.Latitude, Trigonometry.Atan2Small (dy, dx, ComputingSettings.SmallAngleEpsilon));
        }

        public static Vector3 RotateSpace (Vector3 v, Matrix3 rotationMatrix)
        {
            return rotationMatrix * v;
        }

        //////////////////////////////////////////////////////////////////
        // Комбинированный поворот системы координат через углы Эйлера. //
        //////////////////////////////////////////////////////////////////

        /// <summary>
        /// Возвращает матрицу поворота системы координат, заданного углами Эйлера.
        /// </summary>
        /// <param name="alpha">Угол прецессии – поворот оси OX до линии узлов.</param>
        /// <param name="beta">Угол нутации – наклон оси OZ.</param>
        /// <param name="gamma">Угол собственного вращения – поворот оси OX от линии узлов до её нового положения.</param>
        public static Matrix3 GetRotationMatrixForSpaceByEulerAngles (double alpha, double beta, double gamma)
        {
            (double sinA, double cosA) = double.SinCos (alpha);
            (double sinB, double cosB) = double.SinCos (beta);
            (double sinG, double cosG) = double.SinCos (gamma);

            return GetRotationMatrixForSpaceByEulerAngles (sinA, cosA, sinB, cosB, sinG, cosG);
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
        public static Matrix3 GetRotationMatrixForSpaceByEulerAngles (double sinA, double cosA, double sinB, double cosB, double sinG, double cosG)
        {
            double cosBsinG = cosB * sinG;
            double cosBcosG = cosB * cosG;

            return new Matrix3 (cosA * cosG - sinA * cosBsinG, -cosA * sinG - sinA * cosBcosG,  sinA * sinB,
                                sinA * cosG + cosA * cosBsinG, -sinA * sinG + cosA * cosBcosG, -cosA * sinB,
                                                  sinB * sinG,                    sinB * cosG,         cosB);
        }

        /// <summary>
        /// Возвращает декартовы координаты вектора v в новой системе координат, полученной после поворота старой системы координат, 
        /// заданного углами Эйлера.
        /// </summary>
        /// <param name="alpha">Угол прецессии – поворот оси OX до линии узлов.</param>
        /// <param name="beta">Угол нутации – наклон оси OZ.</param>
        /// <param name="gamma">Угол собственного вращения – поворот оси OX от линии узлов до её нового положения.</param>
        public static Vector3 RotateSpaceByEulerAngles (Vector3 v, double alpha, double beta, double gamma)
        {
            (double sinA, double cosA) = double.SinCos (alpha);
            (double sinB, double cosB) = double.SinCos (beta);
            (double sinG, double cosG) = double.SinCos (gamma);

            return RotateSpaceByEulerAngles (v, sinA, cosA, sinB, cosB, sinG, cosG);
        }

        /// <summary>
        /// Возвращает декартовы координаты вектора v в новой системе координат, полученной после поворота старой системы координат, 
        /// заданного синусами и косинусами углов Эйлера.
        /// </summary>
        /// <remarks><list type="bullet">
        /// <item>sinA, cosA – угол прецессии (поворот оси OX до линии узлов).</item>
        /// <item>sinB, cosB – угол нутации (наклон оси OZ).</item>
        /// <item>sinG, cosG – угол собственного вращения (поворот оси OX от линии узлов до её нового положения).</item>
        /// <item>Проверка на соответствие синусов и косинусов основному тригонометрическому тождеству в методе не производится.</item>
        /// </list></remarks>
        public static Vector3 RotateSpaceByEulerAngles (Vector3 v, double sinA, double cosA, double sinB, double cosB, double sinG, double cosG)
        {
            double cosBsinG = cosB * sinG;
            double cosBcosG = cosB * cosG;

            return new Vector3 (v.X * (cosA * cosG - sinA * cosBsinG) + v.Y * (-cosA * sinG - sinA * cosBcosG) + v.Z * sinA * sinB,
                                v.X * (sinA * cosG + cosA * cosBsinG) + v.Y * (-sinA * sinG + cosA * cosBcosG) - v.Z * cosA * sinB,
                                                    v.X * sinB * sinG +                      v.Y * sinB * cosG +        v.Z * cosB);
        }

        /// <summary>
        /// Возвращает полярные координаты вектора p в новой системе координат, полученной после поворота старой системы координат, 
        /// заданного углами Эйлера.
        /// </summary>
        /// <param name="alpha">Угол прецессии – поворот оси OX до линии узлов.</param>
        /// <param name="beta">Угол нутации – наклон оси OZ.</param>
        /// <param name="gamma">Угол собственного вращения – поворот оси OX от линии узлов до её нового положения.</param>
        public static Polar3 RotateSpaceByEulerAngles (Polar3 p, double alpha, double beta, double gamma)
        {
            (double sinA, double cosA) = double.SinCos (alpha);
            (double sinB, double cosB) = double.SinCos (beta);
            (double sinG, double cosG) = double.SinCos (gamma);

            return RotateSpaceByEulerAngles (p, sinA, cosA, sinB, cosB, sinG, cosG);
        }

        /// <summary>
        /// Возвращает полярные координаты вектора p в новой системе координат, полученной после поворота старой системы координат, 
        /// заданного синусами и косинусами углов Эйлера.
        /// </summary>
        /// <remarks><list type="bullet">
        /// <item>sinA, cosA – угол прецессии (поворот оси OX до линии узлов).</item>
        /// <item>sinB, cosB – угол нутации (наклон оси OZ).</item>
        /// <item>sinG, cosG – угол собственного вращения (поворот оси OX от линии узлов до её нового положения).</item>
        /// <item>Проверка на соответствие синусов и косинусов основному тригонометрическому тождеству в методе не производится.</item>
        /// </list></remarks>
        public static Polar3 RotateSpaceByEulerAngles (Polar3 p, double sinA, double cosA, double sinB, double cosB, double sinG, double cosG)
        {
            (double phi1, double l1) = ComputePolarAnglesForEulerAnglesRotation (p, sinA, cosA, sinB, cosB, sinG, cosG);

            return Polar3.DirectInit (p.R, phi1, l1);
        }

        /// <summary>
        /// Возвращает полярные координаты единичного вектора p в новой системе координат, полученной после поворота старой системы координат, 
        /// заданного углами Эйлера.
        /// </summary>
        /// <param name="alpha">Угол прецессии – поворот оси OX до линии узлов.</param>
        /// <param name="beta">Угол нутации – наклон оси OZ.</param>
        /// <param name="gamma">Угол собственного вращения – поворот оси OX от линии узлов до её нового положения.</param>
        public static UnitPolar3 RotateSpaceByEulerAngles (UnitPolar3 p, double alpha, double beta, double gamma)
        {
            (double sinA, double cosA) = double.SinCos (alpha);
            (double sinB, double cosB) = double.SinCos (beta);
            (double sinG, double cosG) = double.SinCos (gamma);

            return RotateSpaceByEulerAngles (p, sinA, cosA, sinB, cosB, sinG, cosG);
        }

        /// <summary>
        /// Возвращает полярные координаты единичного вектора p в новой системе координат, полученной после поворота старой системы координат, 
        /// заданного синусами и косинусами углов Эйлера.
        /// </summary>
        /// <remarks><list type="bullet">
        /// <item>sinA, cosA – угол прецессии (поворот оси OX до линии узлов).</item>
        /// <item>sinB, cosB – угол нутации (наклон оси OZ).</item>
        /// <item>sinG, cosG – угол собственного вращения (поворот оси OX от линии узлов до её нового положения).</item>
        /// <item>Проверка на соответствие синусов и косинусов основному тригонометрическому тождеству в методе не производится.</item>
        /// </list></remarks>
        public static UnitPolar3 RotateSpaceByEulerAngles (UnitPolar3 p, double sinA, double cosA, double sinB, double cosB, double sinG, double cosG)
        {
            (double phi1, double l1) = ComputePolarAnglesForEulerAnglesRotation (p, sinA, cosA, sinB, cosB, sinG, cosG);

            return new UnitPolar3 (phi1, l1);
        }

        /// <summary>
        /// Метод для расчёта полярных координат – широты и долготы вектора p – в новой системе координат, полученной после поворота 
        /// старой системы координат, заданного синусами и косинусами углов Эйлера.
        /// </summary>
        /// <returns><list type="bullet">
        /// <item>phi1 – широта в новой системе координат.</item>
        /// <item>l1 – долгота в новой системе координат.</item>
        /// </list></returns>
        /// <remarks>Проверка на соответствие синусов и косинусов основному тригонометрическому тождеству в методе не производится.</remarks>
        private static (double phi1, double l1) ComputePolarAnglesForEulerAnglesRotation (Polar3 p, double sinA, double cosA, double sinB, double cosB, double sinG, double cosG)
        {
            (double sinPhi, double cosPhi) = double.SinCos (p.Latitude);
            (double sinL,   double cosL)   = double.SinCos (p.Longitude);

            double cosBsinG   = cosB * sinG;
            double cosBcosG   = cosB * cosG;
            double cosPhicosL = cosPhi * cosL;
            double cosPhisinL = cosPhi * sinL;
            double sinPhisinB = sinPhi * sinB;

            double dx = cosPhicosL * (cosA * cosG - sinA * cosBsinG) + cosPhisinL * (-cosA * sinG - sinA * cosBcosG) + sinPhisinB * sinA;
            double dy = cosPhicosL * (sinA * cosG + cosA * cosBsinG) + cosPhisinL * (-sinA * sinG + cosA * cosBcosG) - sinPhisinB * cosA;
            double sinPhi1 = cosPhicosL * sinB * sinG + cosPhisinL * sinB * cosG + sinPhi * cosB;

            double phi1 = Trigonometry.AsinSmall (sinPhi1, ComputingSettings.SmallAngleEpsilon);
            double l1   = Trigonometry.Atan2Small (dy, dx, ComputingSettings.SmallAngleEpsilon);

            return (phi1, l1);
        }
    }
}