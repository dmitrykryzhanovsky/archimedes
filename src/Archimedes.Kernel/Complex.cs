namespace Archimedes
{
    public class Complex : ICloneable, IEquatable<Complex>
    {
        public double Re
        {
            get => throw new NotImplementedException();
        }

        public double Im
        {
            get => throw new NotImplementedException ();
        }

        public Complex (double re, double im)
        {
            throw new NotImplementedException ();
        }

        public Complex (Complex other)
        {
            throw new NotImplementedException ();
        }

        public object Clone ()
        {
            return new Complex (this);
        }

        public bool Equals (Complex? other)
        {
            throw new NotImplementedException ();
        }

        public static bool operator == (Complex z1, Complex z2)
        {
            return z1.Equals (z2);
        }

        public static bool operator != (Complex z1, Complex z2)
        {
            return !z1.Equals (z2);
        }

        public static implicit operator Vector2 (Complex z)
        {
            return new Vector2 (z.Re, z.Im);
        }
    }
}