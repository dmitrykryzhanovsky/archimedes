using System;

namespace Archimedes
{
    /// <summary>
    /// Матрица размера 3 х 3.
    /// </summary>
    public class Matrix3 : Matrix, IEquatable<Matrix>, IEquatable<Matrix3>
    {
        private const int Size = 3;

        public override int Height
        {
            get => Size;
        }

        public override int Width
        {
            get => Size;
        }

        #region Constructors

        public Matrix3 () : base (Size, Size)
        {
        }

        public Matrix3 (double x00, double x01, double x02,
                        double x10, double x11, double x12, 
                        double x20, double x21, double x22) : this ()
        {
            _x [0] = x00;
            _x [1] = x01;
            _x [2] = x02;

            _x [3] = x10;
            _x [4] = x11;
            _x [5] = x12;

            _x [6] = x20;
            _x [7] = x21;
            _x [8] = x22;
        }

        public Matrix3 (Matrix3 other) : this ()
        {
            _x [0] = other._x [0];
            _x [1] = other._x [1];
            _x [2] = other._x [2];

            _x [3] = other._x [3];
            _x [4] = other._x [4];
            _x [5] = other._x [5];

            _x [6] = other._x [6];
            _x [7] = other._x [7];
            _x [8] = other._x [8];
        }

        public override object Clone ()
        {
            return new Matrix3 (this);
        }

        #endregion

        #region Relations

        public bool Equals (Matrix3? other)
        {
            return _x.EqualsNineItems (other._x);
        }

        /// <summary>
        /// Возвращает true, если количество строк и столбцов в other равно 2 (то есть фактически объект other является матрицей 2 х 2), 
        /// и его элементы равны элементам текущей матрицы. В противном случае false.
        /// </summary>
        public bool Equals (Matrix? other)
        {
            return other.Equals (this);
        }

        public override bool Equals (object? other)
        {
            if (other is Matrix3) return Equals (other as Matrix3);

            else if (other is Matrix) return Equals (other as Matrix);

            else return false;
        }        

        public override int GetHashCode ()
        {
            return base.GetHashCode ();
        }

        public static bool operator == (Matrix3 m1, Matrix3 m2)
        {
            return m1.Equals (m2);
        }

        public static bool operator != (Matrix3 m1, Matrix3 m2)
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