namespace Archimedes
{
    public class Vector3: Vector, IEquatable<Vector3>
    {
        private const int ThisTypeDimension = 3;

        public double X
        {
            get => _x [0];

            set => _x [0] = value;
        }

        public double Y
        {
            get => _x [1];

            set => _x [1] = value;
        }

        public double Z
        {
            get => _x [2];

            set => _x [2] = value;
        }

        public override int Dimension
        {
            get => ThisTypeDimension;
        }

        #region Constructors

        public Vector3 (double x, double y, double z) : base (ThisTypeDimension)
        {
            _x [0] = x;
            _x [1] = y;
            _x [2] = z;
        }

        public Vector3 (Vector3 other) : this (other.X, other.Y, other.Z)
        {
        }

        public override object Clone ()
        {
            return new Vector3 (this);
        }

        #endregion

        #region Comparison

        public bool Equals (Vector3? other)
        {
            return ((X == other.X) && (Y == other.Y) && (Z == other.Z));
        }

        public static bool operator == (Vector3 v1, Vector3 v2)
        {
            return v1.Equals (v2);
        }

        public static bool operator != (Vector3 v1, Vector3 v2)
        {
            return !v1.Equals (v2);
        }

        #endregion

        public override double GetNorm2 ()
        {
            return X * X + Y * Y + Z * Z;
        }

        /// <summary>
        /// Преобразует текущий вектор к полярным координатам.
        /// </summary>
        public Polar3 ToPolar ()
        {
            double xoy = double.Hypot (X, Y);

            return Polar3.DirectInit (r: GetLength (),
               latitude: double.Atan2 (Z, xoy),
               longitude: double.Atan2 (Y, X));
        }

        /// <summary>
        /// Поворот текущего вектора вокруг оси OX на угол <paramref name="angle"/>. Координаты после поворота записываются в текущий 
        /// объект.
        /// </summary>
        public void RotateThisAroundOX (double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            RotateThisAroundOX (sin, cos);
        }

        /// <summary>
        /// Поворот текущего вектора вокруг оси OX на угол, заданный синусом <paramref name="sin"/> и косинусом <paramref name="cos"/>. 
        /// Координаты после поворота записываются в текущий объект.
        /// </summary>
        /// <remarks>В методе не производится проверка на соответствие синуса <paramref name="sin"/> и косинуса <paramref name="cos"/> 
        /// основному тригонометрическому тождеству.</remarks>
        public void RotateThisAroundOX (double sin, double cos)
        {
            (_x [0], _x [1], _x [2]) = Euclidean3Formulae.RotateVectorAroundOX (sin, cos, _x [0], _x [1], _x [2]);
        }

        /// <summary>
        /// Поворот вектора вокруг оси OX на угол <paramref name="angle"/>. Координаты после поворота записываются в возвращаемый 
        /// объект.
        /// </summary>
        public Vector3 RotateAroundOX (double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            return RotateAroundOX (sin, cos);
        }

        /// <summary>
        /// Поворот вектора вокруг оси OX на угол, заданный синусом <paramref name="sin"/> и косинусом <paramref name="cos"/>. 
        /// Координаты после поворота записываются в возвращаемый объект.
        /// </summary>
        /// <remarks>В методе не производится проверка на соответствие синуса <paramref name="sin"/> и косинуса <paramref name="cos"/> 
        /// основному тригонометрическому тождеству.</remarks>
        public Vector3 RotateAroundOX (double sin, double cos)
        {
            (double rotatedX, double rotatedY, double rotatedZ) = Euclidean3Formulae.RotateVectorAroundOX (sin, cos, _x [0], _x [1], _x [2]);

            return new Vector3 (rotatedX, rotatedY, rotatedZ);
        }

        /// <summary>
        /// Поворот текущего вектора вокруг оси OY на угол <paramref name="angle"/>. Координаты после поворота записываются в текущий 
        /// объект.
        /// </summary>
        public void RotateThisAroundOY (double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            RotateThisAroundOY (sin, cos);
        }

        /// <summary>
        /// Поворот текущего вектора вокруг оси OY на угол, заданный синусом <paramref name="sin"/> и косинусом <paramref name="cos"/>. 
        /// Координаты после поворота записываются в текущий объект.
        /// </summary>
        /// <remarks>В методе не производится проверка на соответствие синуса <paramref name="sin"/> и косинуса <paramref name="cos"/> 
        /// основному тригонометрическому тождеству.</remarks>
        public void RotateThisAroundOY (double sin, double cos)
        {
            (_x [0], _x [1], _x [2]) = Euclidean3Formulae.RotateVectorAroundOY (sin, cos, _x [0], _x [1], _x [2]);
        }

        /// <summary>
        /// Поворот вектора вокруг оси OY на угол <paramref name="angle"/>. Координаты после поворота записываются в возвращаемый 
        /// объект.
        /// </summary>
        public Vector3 RotateAroundOY (double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            return RotateAroundOY (sin, cos);
        }

        /// <summary>
        /// Поворот вектора вокруг оси OY на угол, заданный синусом <paramref name="sin"/> и косинусом <paramref name="cos"/>. 
        /// Координаты после поворота записываются в возвращаемый объект.
        /// </summary>
        /// <remarks>В методе не производится проверка на соответствие синуса <paramref name="sin"/> и косинуса <paramref name="cos"/> 
        /// основному тригонометрическому тождеству.</remarks>
        public Vector3 RotateAroundOY (double sin, double cos)
        {
            (double rotatedX, double rotatedY, double rotatedZ) = Euclidean3Formulae.RotateVectorAroundOY (sin, cos, _x [0], _x [1], _x [2]);

            return new Vector3 (rotatedX, rotatedY, rotatedZ);
        }

        /// <summary>
        /// Поворот текущего вектора вокруг оси OZ на угол <paramref name="angle"/>. Координаты после поворота записываются в текущий 
        /// объект.
        /// </summary>
        public void RotateThisAroundOZ (double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            RotateThisAroundOZ (sin, cos);
        }

        /// <summary>
        /// Поворот текущего вектора вокруг оси OZ на угол, заданный синусом <paramref name="sin"/> и косинусом <paramref name="cos"/>. 
        /// Координаты после поворота записываются в текущий объект.
        /// </summary>
        /// <remarks>В методе не производится проверка на соответствие синуса <paramref name="sin"/> и косинуса <paramref name="cos"/> 
        /// основному тригонометрическому тождеству.</remarks>
        public void RotateThisAroundOZ (double sin, double cos)
        {
            (_x [0], _x [1], _x [2]) = Euclidean3Formulae.RotateVectorAroundOZ (sin, cos, _x [0], _x [1], _x [2]);
        }

        /// <summary>
        /// Поворот вектора вокруг оси OZ на угол <paramref name="angle"/>. Координаты после поворота записываются в возвращаемый 
        /// объект.
        /// </summary>
        public Vector3 RotateAroundOZ (double angle)
        {
            (double sin, double cos) = double.SinCos (angle);

            return RotateAroundOZ (sin, cos);
        }

        /// <summary>
        /// Поворот вектора вокруг оси OZ на угол, заданный синусом <paramref name="sin"/> и косинусом <paramref name="cos"/>. 
        /// Координаты после поворота записываются в возвращаемый объект.
        /// </summary>
        /// <remarks>В методе не производится проверка на соответствие синуса <paramref name="sin"/> и косинуса <paramref name="cos"/> 
        /// основному тригонометрическому тождеству.</remarks>
        public Vector3 RotateAroundOZ (double sin, double cos)
        {
            (double rotatedX, double rotatedY, double rotatedZ) = Euclidean3Formulae.RotateVectorAroundOZ (sin, cos, _x [0], _x [1], _x [2]);

            return new Vector3 (rotatedX, rotatedY, rotatedZ);
        }
    }
}