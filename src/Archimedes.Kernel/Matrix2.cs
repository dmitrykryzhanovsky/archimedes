using System;

namespace Archimedes
{
    /// <summary>
    /// Матрица размера 2 х 2.
    /// </summary>
    public class Matrix2 : Matrix, IEquatable<Matrix2>
    {
        private const int Size = 2;

        public override int Height
        {
            get => Size;
        }

        public override int Width
        {
            get => Size;
        }

        #region Constructors

        public Matrix2 () : base (Size, Size)
        {
        }

        public Matrix2 (double x00, double x01, double x10, double x11) : this ()
        {
            _x [0] = x00;
            _x [1] = x01;
            _x [2] = x10;
            _x [3] = x11;
        }

        public Matrix2 (Matrix2 other) : this ()
        {
            _x [0] = other._x [0];
            _x [1] = other._x [1];
            _x [2] = other._x [2];
            _x [3] = other._x [3];
        }

        public override object Clone ()
        {
            return new Matrix2 (this);
        }

        #endregion

        #region Relations

        public bool Equals (Matrix2? other)
        {
            return _x.EqualsFourItems (other._x);
        }

        public override bool Equals (object? other)
        {
            // Если объект other является объектом типа Matrix2 или производного от него.
            if (other is Matrix2) return Equals (other as Matrix2);

            // Если объект other является объектом типа Matrix или производного от него, и при этом количество строк и столбцов в other
            // равно 2 (то есть фактически объект other является матрицей 2 х 2).
            else if ((other is Matrix m) && 
                     (m.Height == Size)  && 
                     (m.Width  == Size))
            {
                return _x.EqualsFourItems (m.Items);
            }

            else throw new InvalidCastException ();
        }        

        public override int GetHashCode ()
        {
            return base.GetHashCode ();
        }

        public static bool operator == (Matrix2 m1, Matrix2 m2)
        {
            return m1.Equals (m2);
        }

        public static bool operator != (Matrix2 m1, Matrix2 m2)
        {
            return !m1.Equals (m2);
        }

        #endregion

        public static Matrix2 operator + (Matrix2 m1, Matrix2 m2)
        {
            Matrix2 result = new Matrix2 ();

            result._x [0] = m1._x [0] + m2._x [0];
            result._x [1] = m1._x [1] + m2._x [1];
            result._x [2] = m1._x [2] + m2._x [2];
            result._x [3] = m1._x [3] + m2._x [3];

            return result;
        }

        public static Matrix2 operator - (Matrix2 m1, Matrix2 m2)
        {
            Matrix2 result = new Matrix2 ();

            result._x [0] = m1._x [0] - m2._x [0];
            result._x [1] = m1._x [1] - m2._x [1];
            result._x [2] = m1._x [2] - m2._x [2];
            result._x [3] = m1._x [3] - m2._x [3];

            return result;
        }

        public static Matrix2 operator - (Matrix2 m)
        {
            Matrix2 result = new Matrix2 ();

            result._x [0] = -m._x [0];
            result._x [1] = -m._x [1];
            result._x [2] = -m._x [2];
            result._x [3] = -m._x [3];

            return result;
        }

        public static Matrix2 operator * (Matrix2 m, double coefficient)
        {
            Matrix2 result = new Matrix2 ();

            result._x [0] = m._x [0] * coefficient;
            result._x [1] = m._x [1] * coefficient;
            result._x [2] = m._x [2] * coefficient;
            result._x [3] = m._x [3] * coefficient;

            return result;
        }

        public static Matrix2 operator * (double coefficient, Matrix2 m)
        {
            return m * coefficient;
        }

        public static Matrix2 operator / (Matrix2 m, double coefficient)
        {
            Matrix2 result = new Matrix2 ();

            result._x [0] = m._x [0] / coefficient;
            result._x [1] = m._x [1] / coefficient;
            result._x [2] = m._x [2] / coefficient;
            result._x [3] = m._x [3] / coefficient;

            return result;
        }

        // TODO: vector x matrix
        // TODO: matrix x vector

        public static Matrix2 operator * (Matrix2 m1, Matrix2 m2)
        {
            Matrix2 result = new Matrix2 ();

            result._x [0] = m1._x [0] * m2._x [0] + m1._x [1] * m2._x [2];
            result._x [1] = m1._x [0] * m2._x [1] + m1._x [1] * m2._x [3];
            result._x [2] = m1._x [2] * m2._x [0] + m1._x [3] * m2._x [2];
            result._x [3] = m1._x [2] * m2._x [1] + m1._x [3] * m2._x [3];

            return result;
        }
    }
}