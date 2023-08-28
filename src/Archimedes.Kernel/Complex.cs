using System;

namespace Archimedes
{
    public class Complex : ICloneable, IEquatable<Complex>
    {
        private double _re;
        private double _im;
        private double _r;
        private double _arg;

        private bool _isAlgebraicActual;
        private bool _isPolarActual;

        public double Re
        {
            get => _re;
            set => _re = value;
        }

        public double Im
        {
            get => _im;
            set => _im = value;
        }

        public double Magnitude
        {
            get => _r;
            set => throw new NotImplementedException ();
        }

        public double Arg
        {
            get => _arg;
            set => throw new NotImplementedException ();
        }

        private Complex ()
        {
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

        public static Complex CreateInPolar (double magnitude, double arg)
        {
            throw new NotImplementedException ();
        }

        public static implicit operator Complex (double re)
        {
            throw new NotImplementedException ();
        }

        public static explicit operator Vector2 (Complex z)
        {
            throw new NotImplementedException ();
        }

        public bool Equals (double other)
        {
            throw new NotImplementedException ();
        }

        public bool Equals (Complex? other)
        {
            throw new NotImplementedException ();
        }

        public override bool Equals (object? other)
        {
            if (other is Complex) return Equals (other as Complex);
            else if (other is double) return Equals ((double)other);
            else throw new InvalidCastException ();
        }

        public override int GetHashCode ()
        {
            return base.GetHashCode ();
        }

        public static bool operator == (Complex z1, double re2)
        {
            return z1.Equals (re2);
        }

        public static bool operator != (Complex z1, double re2)
        {
            return !z1.Equals (re2);
        }

        public static bool operator == (double re1, Complex z2)
        {
            return z2.Equals (re1);
        }

        public static bool operator != (double re1, Complex z2)
        {
            return !z2.Equals (re1);
        }

        public static bool operator == (Complex z1, Complex z2)
        {
            return z1.Equals (z2);
        }

        public static bool operator != (Complex z1, Complex z2)
        {
            return !z1.Equals (z2);
        }

        public static Complex operator + (Complex z1, double re2)
        {
            throw new NotImplementedException ();
        }

        public static Complex operator + (double re1, Complex z2)
        {
            throw new NotImplementedException ();
        }

        public static Complex operator + (Complex z1, Complex z2)
        {
            throw new NotImplementedException ();
        }

        public static Complex operator - (Complex z1, double re2)
        {
            throw new NotImplementedException ();
        }

        public static Complex operator - (double re1, Complex z2)
        {
            throw new NotImplementedException ();
        }

        public static Complex operator - (Complex z1, Complex z2)
        {
            throw new NotImplementedException ();
        }

        public static Complex operator - (Complex z)
        {
            throw new NotImplementedException ();
        }

        public static Complex operator * (Complex z, double re)
        {
            throw new NotImplementedException ();
        }

        public static Complex operator * (double re, Complex z)
        {
            throw new NotImplementedException ();
        }

        public static double operator * (Complex z1, Complex z2)
        {
            throw new NotImplementedException ();
        }

        public static Complex operator / (Complex z, double re)
        {
            throw new NotImplementedException ();
        }

        public static Complex operator / (double re, Complex z)
        {
            throw new NotImplementedException ();
        }

        public static double operator / (Complex z1, Complex z2)
        {
            throw new NotImplementedException ();
        }

        public Complex Conjugate ()
        {
            throw new NotImplementedException ();
        }
    }
}