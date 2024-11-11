namespace Archimedes
{
    /// <summary>
    /// Кватернион.
    /// </summary>
    public class Quaternion : ICloneable, IEquatable<Quaternion>
    {
        /// <summary>
        /// Кватернион = 1.
        /// </summary>
        public static readonly Quaternion One = new Quaternion (1, 0, 0, 0);

        /// <summary>
        /// Кватернион = i (мнимая единица по оси OX).
        /// </summary>
        public static readonly Quaternion I = new Quaternion (0, 1, 0, 0);

        /// <summary>
        /// Кватернион = j (мнимая единица по оси OY).
        /// </summary>
        public static readonly Quaternion J = new Quaternion (0, 0, 1, 0);

        /// <summary>
        /// Кватернион = k (мнимая единица по оси OZ).
        /// </summary>
        public static readonly Quaternion K = new Quaternion (0, 0, 0, 1);

        private double _a;

        private Vector3 _u;

        public double A
        {
            get => _a;
            set => _a = value;
        }

        public double B
        {
            get => _u [0];
            set => _u [0] = value;
        }

        public double C
        {
            get => _u [1];
            set => _u [1] = value;
        }

        public double D
        {
            get => _u [2];
            set => _u [2] = value;
        }

        /// <summary>
        /// Возвращает векторную компоненту кватерниона.
        /// </summary>
        public Vector3 U
        {
            get => _u;
        }

        /// <summary>
        /// Возвращает TRUE, если кватернион является скаляром (то есть действительным числом). В противном случае – FALSE.
        /// </summary>
        public bool IsScalar
        {
            get => ((_u [0] == 0.0) && (_u [1] == 0.0) && (_u [2] == 0.0));
        }

        /// <summary>
        /// Возвращает TRUE, если кватернион является комплексным числом. В противном случае – FALSE.
        /// </summary>
        public bool IsComplex
        {
            get => ((_u [1] == 0.0) && (_u [2] == 0.0));
        }

        /// <summary>
        /// Возвращает TRUE, если кватернион является 3-мерным вектором. В противном случае – FALSE.
        /// </summary>
        public bool IsVector
        {
            get => (_a == 0.0);
        }

        #region Constructors

        public Quaternion (double a, double b, double c, double d)
        {
            _a = a;
            _u = new Vector3 (b, c, d);
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

        public Quaternion (Quaternion other) : this (other._a, other._u [0], other._u [1], other._u [2])
        {
        }

        public object Clone ()
        {
            return new Quaternion (this);
        }

        #endregion

        #region Comparisons

        public bool Equals (Quaternion? other)
        {
            return ((_a == other._a) && (_u == other._u));
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
                return (IsVector) ? (_u == obj as Vector) : false;
            }

            else if (obj is Vector3)
            {
                return (IsVector) ? (_u == obj as Vector3) : false;
            }

            else if (obj is Complex)
            {
                if (IsComplex)
                {
                    Complex other = (Complex)obj;

                    return ((_a == other.Re) && (_u [0] == other.Im));
                }

                else return false;
            }

            else
            {
                if (IsScalar)
                {
                    if (obj is double) return (_a == (double)obj);
                    else if (obj is int) return (_a == (int)obj);
                    else if (obj is uint) return (_a == (uint)obj);
                    else return false;
                }

                else return false;
            }
        }

        #endregion

        #region Conversions

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

        public static implicit operator Quaternion (Vector vector)
        {
            if (vector.Dimension == 3)
            {
                return new Quaternion (0, vector [0], vector [1], vector [2]);
            }

            else throw new InvalidCastException ();
        }

        #endregion

        public static Quaternion operator + (Quaternion q1, Quaternion q2)
        {
            return new Quaternion (q1._a + q2._a, q1._u [0] + q2._u [0], q1._u [1] + q2._u [1], q1._u [2] + q2._u [2]);
        }

        public static Quaternion operator + (Quaternion q, Complex z)
        {
            return new Quaternion (q._a + z.Re, q._u [0] + z.Im, q._u [1], q._u [2]);
        }

        public static Quaternion operator + (Complex z, Quaternion q)
        {
            return new Quaternion (z.Re + q._a, z.Im + q._u [0], q._u [1], q._u [2]);
        }

        public static Quaternion operator + (Quaternion q, double r)
        {
            return new Quaternion (q._a + r, q._u [0], q._u [1], q._u [2]);
        }

        public static Quaternion operator + (double r, Quaternion q)
        {
            return new Quaternion (r + q._a, q._u [0], q._u [1], q._u [2]);
        }

        public static Quaternion operator - (Quaternion q1, Quaternion q2)
        {
            return new Quaternion (q1._a - q2._a, q1._u [0] - q2._u [0], q1._u [1] - q2._u [1], q1._u [2] - q2._u [2]);
        }

        public static Quaternion operator - (Quaternion q, Complex z)
        {
            return new Quaternion (q._a - z.Re, q._u [0] - z.Im, q._u [1], q._u [2]);
        }

        public static Quaternion operator - (Complex z, Quaternion q)
        {
            return new Quaternion (z.Re - q._a, z.Im - q._u [0], -q._u [1], -q._u [2]);
        }

        public static Quaternion operator - (Quaternion q, double r)
        {
            return new Quaternion (q._a - r, q._u [0], q._u [1], q._u [2]);
        }

        public static Quaternion operator - (double r, Quaternion q)
        {
            return new Quaternion (r - q._a, -q._u [0], -q._u [1], -q._u [2]);
        }

        public static Quaternion operator - (Quaternion q)
        {
            return new Quaternion (-q._a, -q._u [0], -q._u [1], -q._u [2]);
        }

        public static Quaternion operator * (Quaternion q1, Quaternion q2)
        {
            return new Quaternion (q1._a * q2._a - q1._u * q2._u, 
                                   q1._a * q2._u + q2._a * q1._u + Vector3.CrossProduct (q1._u, q2._u));
        }

        public static Quaternion operator * (Quaternion q, Complex z)
        {
            return new Quaternion (q._a * z.Re     - q._u [0] * z.Im,
                                   q._u [0] * z.Re + q._a * z.Im,
                                   q._u [1] * z.Re + q._u [2] * z.Im,
                                   q._u [2] * z.Re - q._u [1] * z.Im);
        }

        public static Quaternion operator * (Complex z, Quaternion q)
        {
            return new Quaternion (z.Re * q._a     - z.Im * q._u [0],
                                   z.Re * q._u [0] + z.Im * q._a,
                                   z.Re * q._u [1] - z.Im * q._u [2],
                                   z.Re * q._u [2] + z.Im * q._u [1]);
        }

        public static Quaternion operator * (Quaternion q, double r)
        {
            return new Quaternion (q._a * r, q._u [0] * r, q._u [1] * r, q._u [2] * r);
        }

        public static Quaternion operator * (double r, Quaternion q)
        {
            return new Quaternion (r * q._a, r * q._u [0], r * q._u [1], r * q._u [2]);
        }

        public static Quaternion operator * (Quaternion q, Vector3 v)
        {
            return new Quaternion (-q._u * v, 
                                    q._a * v + Vector3.CrossProduct (q._u , v));
        }

        public static Quaternion operator * (Vector3 v, Quaternion q)
        {
            return new Quaternion (-v * q._u,
                                    q._a * v + Vector3.CrossProduct (v, q._u));
        }

        /// <summary>
        /// Возвращает кватернион, сопряжённый q.
        /// </summary>
        public static Quaternion Conjugate (Quaternion q)
        {
            return new Quaternion (q._a, -q._u [0], -q._u [1], -q._u [2]);
        }

        /// <summary>
        /// Возвращает кватернион, обратный q.
        /// </summary>
        public static Quaternion Reciprocal (Quaternion q)
        {
            double denominator = q.GetNorm2 ();

            return new Quaternion (q._a / denominator, -q._u [0] / denominator, -q._u [1] / denominator, -q._u [2] / denominator);
        }

        /// <summary>
        /// Возвращает евклидово произведение кватернионов q1 и q2.
        /// </summary>
        public static Quaternion EuclideanProduct (Quaternion q1, Quaternion q2)
        {
            return new Quaternion (q1._a * q2._a     + q1._u [0] * q2._u [0] + q1._u [1] * q2._u [1] + q1._u [2] * q2._u [2],
                                   q1._a * q2._u [0] - q1._u [0] * q2._a     - q1._u [1] * q2._u [2] + q1._u [2] * q2._u [1],
                                   q1._a * q2._u [1] - q1._u [1] * q2._a     - q1._u [2] * q2._u [0] + q1._u [0] * q2._u [2],
                                   q1._a * q2._u [2] - q1._u [2] * q2._a     - q1._u [0] * q2._u [1] + q1._u [1] * q2._u [0]);
        }

        /// <summary>
        /// Возвращает скалярное произведение кватернионов q1 и q2.
        /// </summary>
        public static double ScalarProduct (Quaternion q1, Quaternion q2)
        {
            return q1._a * q2._a + q1._u * q2._u;
        }

        /// <summary>
        /// Возвращает внешнее произведение кватернионов q1 и q2.
        /// </summary>
        public static Vector3 OuterProduct (Quaternion q1, Quaternion q2)
        {
            return new Vector3 (q1._a * q2._u [0] - q1._u [0] * q2._a - q1._u [1] * q2._u [2] + q1._u [2] * q2._u [1],
                                q1._a * q2._u [1] - q1._u [1] * q2._a - q1._u [2] * q2._u [0] + q1._u [0] * q2._u [2],
                                q1._a * q2._u [2] - q1._u [2] * q2._a - q1._u [0] * q2._u [1] + q1._u [1] * q2._u [0]);
        }

        /// <summary>
        /// Возвращает векторное произведение кватернионов q1 и q2.
        /// </summary>
        public static Vector3 CrossProduct (Quaternion q1, Quaternion q2)
        {
            return Vector3.CrossProduct (q1._u, q2._u);
        }

        /// <summary>
        /// Возвращает квадрат нормы – квадрат модуля – кватерниона q.
        /// </summary>
        public double GetNorm2 ()
        {
            return _a * _a + _u.GetNorm2 ();
        }

        /// <summary>
        /// Возвращает норму – модуль – кватерниона q.
        /// </summary>
        public double GetNorm ()
        {
            return double.Sqrt (GetNorm2 ());
        }

        public bool IsInteger ()
        {
            double alpha = 2.0 * _a;
            double beta  = 2.0 * _u [0];
            double gamma = 2.0 * _u [1];
            double delta = 2.0 * _u [2];

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