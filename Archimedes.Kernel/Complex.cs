using System;

namespace Archimedes
{
    public class Complex : ICloneable, IEquatable<Complex>
    {
        public double Re
        {
            get => throw new NotImplementedException ();
        }

        public double Im
        {
            get => throw new NotImplementedException ();
        }

        public object Clone ()
        {
            throw new NotImplementedException ();
        }

        public static explicit operator Complex (Vector2 v)
        {
            throw new NotImplementedException ();
        }

        public bool Equals (Complex? other)
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