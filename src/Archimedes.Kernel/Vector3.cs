﻿namespace Archimedes
{
    public class Vector3 : Vector, IEquatable<Vector3>
    {
        private const int Vector3Dimension = 3;

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
            get => Vector3Dimension;
        }

        #region Constructors

        public Vector3 (double x, double y, double z) : base (Vector3Dimension)
        {
            _x [0] = x;
            _x [1] = y;
            _x [2] = z;
        }

        public Vector3 (double [] array) : base (array [0], array [1], array [2])
        {
        }

        public Vector3 (Vector3 other) : this (other._x)
        {
        }

        public override object Clone ()
        {
            return new Vector3 (this);
        }

        #endregion

        public static double operator * (Vector3 v1, Vector3 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        public override double GetNorm2 ()
        {
            return X * X + Y * Y + Z * Z;
        }
    }
}