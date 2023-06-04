using System;

namespace Archimedes
{
    public class Complex : ICloneable, IEquatable<Complex>
    {
        public object Clone ()
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