using System;

namespace Archimedes
{
    public class Vector2 : ICloneable, IEquatable<Vector2>
    {
        private double [] _x;

        public double this [int index]
        {
            get => _x [index];
            set => _x [index] = value;
        }

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

        private Vector2 ()
        {
            _x = new double [2];
        }

        public Vector2 (double x, double y) : this ()
        {
            _x [0] = x;
            _x [1] = y;
        }

        public Vector2 (double [] x) : this (x [0], x [1])
        {
        }

        public Vector2 (Vector2 other) : this (other.X, other.Y)
        {
        }

        public object Clone ()
        {
            return new Vector2 (this);
        }

        public static explicit operator Vector2 (Complex z)
        {
            return new Vector2 (z.Re, z.Im);
        }

        public bool Equals (Vector2? other)
        {
            throw new NotImplementedException ();
        }

        public override bool Equals (object? obj)
        {
            return base.Equals (obj);
        }

        public override int GetHashCode ()
        {
            return base.GetHashCode ();
        }
    }
}