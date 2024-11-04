namespace Archimedes
{
    /// <summary>
    /// Кватернион.
    /// </summary>
    public class Quaternion : ICloneable, IEquatable<Quaternion>
    {
        public static readonly Quaternion I = new Quaternion (0, 1, 0, 0);

        public static readonly Quaternion J = new Quaternion (0, 0, 1, 0);

        public static readonly Quaternion K = new Quaternion (0, 0, 0, 1);

        private double _a;

        private double _b;

        private double _c;

        private double _d;

        public double A
        {
            get => _a;
            set => _a = value;
        }

        public double B
        {
            get => _b;
            set => _b = value;
        }

        public double C
        {
            get => _c;
            set => _c = value;
        }

        public double D
        {
            get => _d;
            set => _d = value;
        }

        public Vector3 U
        {
            get => new Vector3 (_b, _c, _d);
        }

        public bool IsScalar
        {
            get => ((_b == 0.0) && (_c == 0.0) && (_d == 0.0));
        }

        public bool IsComplex
        {
            get => ((_c == 0.0) && (_d == 0.0));
        }

        public bool IsVector
        {
            get => (_a == 0.0);
        }

        #region Constructors

        public Quaternion (double a, double b, double c, double d)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }

        public Quaternion (double scalar) : this (scalar, 0, 0, 0)
        {
        }

        public Quaternion (Complex complex) : this (complex.Re, complex.Im, 0, 0)
        {
        }

        public Quaternion (Complex z1, Complex z2) : this (z1.Re, z1.Im, z2.Re, z2.Im)
        {
        }

        public Quaternion (double scalar, Vector3 vector) : this (scalar, vector [0], vector [1], vector [2])
        {
        }

        public Quaternion (Vector3 vector) : this (0, vector)
        {
        }

        public Quaternion (Quaternion other) : this (other._a, other._b, other._c, other._d)
        {
        }

        public object Clone ()
        {
            return new Quaternion (this);
        }

        #endregion

        public bool Equals (Quaternion? other)
        {
            return ((_a == other._a) && (_b == other._b) && (_c == other._c) && (_d == other._d));
        }

        public static bool operator == (Quaternion q1, Quaternion q2)
        {
            return q1.Equals (q2);
        }

        public static bool operator != (Quaternion q1, Quaternion q2)
        {
            return !q1.Equals (q2);
        }

        public override bool Equals (object? obj)
        {
            if (obj is Quaternion) return Equals (obj as Quaternion);

            else if (obj is Vector)
            {
                if (_a == 0.0)
                {
                    Vector other = (Vector)obj;

                    return ((other.Dimension == 3) && (_b == other [0]) && (_c == other [1]) && (_d == other [2]));
                }

                else return false;
            }

            else if (obj is Vector3)
            {
                if (_a == 0.0)
                {
                    Vector3 other = (Vector3)obj;

                    return ((_b == other [0]) && (_c == other [1]) && (_d == other [2]));
                }

                else return false;
            }

            else if (obj is Complex)
            {
                if ((_c == 0.0) && (_d == 0.0))
                {
                    Complex other = (Complex)obj;

                    return ((_a == other.Re) && (_b == other.Im));
                }

                else return false;
            }

            else
            {
                if ((_b == 0.0) && (_c == 0.0) && (_d == 0.0))
                {
                    if (obj is double) return (_a == (double)obj);
                    else if (obj is int) return (_a == (int)obj);
                    else if (obj is uint) return (_a == (uint)obj);
                    else return false;
                }

                else return false;
            }
        }

        public static implicit operator Quaternion (double scalar)
        {
            return new Quaternion (scalar);
        }

        public static implicit operator Quaternion (Complex complex)
        {
            return new Quaternion (complex);
        }

        public static implicit operator Quaternion (Vector3 vector)
        {
            return new Quaternion (vector);
        }

        public static Quaternion operator + (Quaternion q1, Quaternion q2)
        {
            return new Quaternion (q1._a + q2._a, q1._b + q2._b, q1._c + q2._c, q1._d + q2._d);
        }

        public static Quaternion operator + (Quaternion q, Complex z)
        {
            return new Quaternion (q._a + z.Re, q._b + z.Im, q._c, q._d);
        }

        public static Quaternion operator + (Complex z, Quaternion q)
        {
            return new Quaternion (z.Re + q._a, z.Im + q._b, q._c, q._d);
        }

        public static Quaternion operator + (Quaternion q, double r)
        {
            return new Quaternion (q._a + r, q._b, q._c, q._d);
        }

        public static Quaternion operator + (double r, Quaternion q)
        {
            return new Quaternion (r + q._a, q._b, q._c, q._d);
        }

        public static Quaternion operator - (Quaternion q1, Quaternion q2)
        {
            return new Quaternion (q1._a - q2._a, q1._b - q2._b, q1._c - q2._c, q1._d - q2._d);
        }

        public static Quaternion operator - (Quaternion q, Complex z)
        {
            return new Quaternion (q._a - z.Re, q._b - z.Im, q._c, q._d);
        }

        public static Quaternion operator - (Complex z, Quaternion q)
        {
            return new Quaternion (z.Re - q._a, z.Im - q._b, -q._c, -q._d);
        }

        public static Quaternion operator - (Quaternion q, double r)
        {
            return new Quaternion (q._a - r, q._b, q._c, q._d);
        }

        public static Quaternion operator - (double r, Quaternion q)
        {
            return new Quaternion (r - q._a, -q._b, -q._c, -q._d);
        }

        public static Quaternion operator - (Quaternion q)
        {
            return new Quaternion (-q._a, -q._b, -q._c, -q._d);
        }

        public static Quaternion operator * (Quaternion q1, Quaternion q2)
        {
            return new Quaternion (q1._a * q2._a - q1._b * q2._b - q1._c * q2._c - q1._d * q2._d, 
                                   q1._a * q2._b + q1._b * q2._a + q1._c * q2._d - q1._d * q2._c,
                                   q1._a * q2._c + q1._c * q2._a + q1._d * q2._b - q1._b * q2._d,
                                   q1._a * q2._d + q1._d * q2._a + q1._b * q2._c - q1._c * q2._b);
        }

        public static Quaternion operator * (Quaternion q, Complex z)
        {
            return new Quaternion (q._a * z.Re - q._b * z.Im,
                                   q._b * z.Re + q._a * z.Im,
                                   q._c * z.Re + q._d * z.Im,
                                   q._d * z.Re - q._c * z.Im);
        }

        public static Quaternion operator * (Complex z, Quaternion q)
        {
            return new Quaternion (z.Re * q._a - z.Im * q._b,
                                   z.Re * q._b + z.Im * q._a,
                                   z.Re * q._c - z.Im * q._d,
                                   z.Re * q._d + z.Im * q._c);
        }

        public static Quaternion operator * (Quaternion q, double r)
        {
            return new Quaternion (q._a * r, q._b * r, q._c * r, q._d * r);
        }

        public static Quaternion operator * (double r, Quaternion q)
        {
            return new Quaternion (r * q._a, r * q._b, r * q._c, r * q._d);
        }

        public static Quaternion operator * (Quaternion q, Vector3 v)
        {
            return new Quaternion (-q._b * v [0] - q._c * v [1] - q._d * v [2],
                                    q._a * v [0] + q._c * v [2] - q._d * v [1],
                                    q._a * v [1] + q._d * v [0] - q._b * v [2],
                                    q._a * v [2] + q._b * v [1] - q._c * v [0]);
        }

        public static Quaternion operator * (Vector3 v, Quaternion q)
        {
            return new Quaternion (-v [0] * q._b - v [1] * q._c - v [2] * q._d,
                                    v [0] * q._a + v [1] * q._d - v [2] * q._c,
                                    v [1] * q._a + v [2] * q._b - v [0] * q._d,
                                    v [2] * q._a + v [0] * q._c - v [1] * q._b);
        }

        public static Quaternion Conjugate (Quaternion q)
        {
            return new Quaternion (q._a, -q._b, -q._c, -q._d);
        }

        public static Quaternion Reciprocal (Quaternion q)
        {
            double denominator = q.GetNorm2 ();

            return new Quaternion (q._a / denominator, -q._b / denominator, -q._c / denominator, -q._d / denominator);
        }

        public static Quaternion EuclideanProduct (Quaternion q1, Quaternion q2)
        {
            return new Quaternion (q1._a * q2._a + q1._b * q2._b + q1._c * q2._c + q1._d * q2._d,
                                   q1._a * q2._b - q1._b * q2._a - q1._c * q2._d + q1._d * q2._c,
                                   q1._a * q2._c - q1._c * q2._a - q1._d * q2._b + q1._b * q2._d,
                                   q1._a * q2._d - q1._d * q2._a - q1._b * q2._c + q1._c * q2._b);
        }

        public static double ScalarProduct (Quaternion q1, Quaternion q2)
        {
            return q1._a * q2._a + q1._b * q2._b + q1._c * q2._c + q1._d * q2._d;
        }

        public static Vector3 OuterProduct (Quaternion q1, Quaternion q2)
        {
            return new Vector3 (q1._a * q2._b - q1._b * q2._a - q1._c * q2._d + q1._d * q2._c,
                                q1._a * q2._c - q1._c * q2._a - q1._d * q2._b + q1._b * q2._d,
                                q1._a * q2._d - q1._d * q2._a - q1._b * q2._c + q1._c * q2._b);
        }

        public static Vector3 CrossProduct (Quaternion q1, Quaternion q2)
        {
            return new Vector3 (q1._c * q2._d - q1._d * q2._c,
                                q1._d * q2._b - q1._b * q2._d,
                                q1._b * q2._c - q1._c * q2._b);
        }

        public double GetNorm2 ()
        {
            return _a * _a + _b * _b + _c * _c + _d * _d;
        }

        public double GetNorm ()
        {
            return double.Sqrt (GetNorm2 ());
        }

        public bool IsInteger ()
        {
            double alpha = 2.0 * _a;
            double beta  = 2.0 * _b;
            double gamma = 2.0 * _c;
            double delta = 2.0 * _d;

            if (double.IsInteger (alpha) && double.IsInteger (beta) && double.IsInteger (gamma) && double.IsInteger (delta))
            {
                int a2 = (int)alpha;
                int b2 = (int)beta;
                int c2 = (int)gamma;
                int d2 = (int)delta;

                int oddity = a2 & 0x01;

                return (((b2 & 0x01) == oddity) && ((c2 & 0x01) == oddity) && ((d2 & 0x01) == oddity));
            }

            else return false;
        }
    }
}