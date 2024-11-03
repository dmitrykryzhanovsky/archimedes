namespace Archimedes
{
    public class Complex : ICloneable, IEquatable<Complex>
    {
        private double _a;

        private double _b;

        public double Re
        {
            get => _a;
            set => _a = value;
        }

        public double Im
        {
            get => _b;
            set => _b = value;
        }

        public Complex (double re, double im)
        {
            _a = re;
            _b = im;
        }

        public Complex (Complex other) : this (other._a, other._b)
        {
        }

        public object Clone ()
        {
            return new Complex (this);
        }

        public bool Equals (Complex? other)
        {
            return ((_a == other._a) && (_b == other._b));
        }

        public static explicit operator Complex (Vector2 v)
        {
            return new Complex (v [0], v [1]);
        }
    }
}