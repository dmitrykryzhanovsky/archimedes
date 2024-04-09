namespace Archimedes
{
    public class Vector : ICloneable, IEquatable<Vector>
    {
        protected double [] _x;

        public double this [int index]
        {
            get => _x [index];
            set => _x [index] = value;
        }

        public double [] Components
        {
            get => _x;
        }

        public virtual int Dimension
        {
            get => _x.Length;
        }

        protected Vector (int dimension)
        {
            _x = new double [dimension];
        }

        public Vector (params double [] x) : this (x.Length)
        {
            x.CopyTo (_x, 0);
        }

        public Vector (Vector other) : this (other._x)
        {
        }

        public virtual object Clone ()
        {
            return new Vector (this);
        }

        public bool Equals (Vector? other)
        {
            return _x.Equals<double> (other._x);
        }

        public static bool operator == (Vector v1, Vector v2)
        {
            return v1.Equals (v2);
        }

        public static bool operator != (Vector v1, Vector v2)
        {
            return !v1.Equals (v2);
        }

        private static bool AreSuitableForAddition (Vector v1, Vector v2)
        {
            return (v1.Dimension == v2.Dimension);
        }

        private static bool AreSuitableForDotProduct (Vector v1, Vector v2)
        {
            return (v1.Dimension == v2.Dimension);
        }

        public static Vector operator + (Vector v1, Vector v2)
        {
            if (AreSuitableForAddition (v1, v2))
            {
                Vector result = new Vector (v1.Dimension);

                result._x = v1._x.Add (v2._x);

                return result;
            }

            else throw new VectorsAreNotSuitableForAdditionException ();
        }

        public static Vector operator - (Vector v1, Vector v2)
        {
            if (AreSuitableForAddition (v1, v2))
            {
                Vector result = new Vector (v1.Dimension);

                result._x = v1._x.Subtract (v2._x);

                return result;
            }

            else throw new VectorsAreNotSuitableForAdditionException ();
        }

        public static Vector operator - (Vector v)
        {
            Vector result = new Vector (v.Dimension);

            result._x = v._x.Negate ();

            return result;
        }

        public static Vector operator * (Vector v, double coefficient)
        {
            Vector result = new Vector (v.Dimension);

            result._x = v._x.Multiply (coefficient);

            return result;
        }

        public static Vector operator * (double coefficient, Vector v)
        {
            return v * coefficient;
        }

        public static Vector operator / (Vector v, double coefficient)
        {
            Vector result = new Vector (v.Dimension);

            result._x = v._x.Divide (coefficient);

            return result;
        }

        public static double operator * (Vector v1, Vector v2)
        {
            if (AreSuitableForDotProduct (v1, v2))
            {
                return v1._x.InnerProduct (v2._x);
            }

            else throw new VectorsAreNotSuitableForDotProductException ();
        }

        public virtual double GetNorm2 ()
        {
            return _x.InnerProduct (_x);
        }

        public double GetLength ()
        {
            return double.Sqrt (GetNorm2 ());
        }
    }
}