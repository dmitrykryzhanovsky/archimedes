namespace Archimedes
{
    /// <summary>
    /// Матрица размера 2 х 2.
    /// </summary>
    public class Matrix2 : Matrix, IEquatable<Matrix>, IEquatable<Matrix2>
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

        public Matrix2 (Matrix2 other) : this (other._x [0], other._x [1], other._x [2], other._x [3])
        {
        }

        public override object Clone ()
        {
            return new Matrix2 (this);
        }

        #endregion

        #region Relations

        public new bool Equals (Matrix2? other)
        {
            return _x.EqualsFourItems (other._x);
        }

        /// <summary>
        /// Возвращает true, если количество строк и столбцов в other равно 2 (то есть фактически объект other является матрицей 2 х 2), 
        /// и его элементы равны элементам текущей матрицы. В противном случае false.
        /// </summary>
        public new bool Equals (Matrix? other)
        {
            return other.Equals (this);
        }

        public override bool Equals (object? other)
        {
            if (other is Matrix2) return Equals (other as Matrix2);

            else if (other is Matrix) return Equals (other as Matrix);

            else return false;
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

        public static Vector2 operator * (Vector2 v1, Matrix2 m2)
        {
            Vector2 result = new Vector2 ();

            result [0] = v1 [0] * m2._x [0] + v1 [1] * m2._x [2];
            result [1] = v1 [0] * m2._x [1] + v1 [1] * m2._x [3];

            return result;
        }

        public static Vector2 operator * (Matrix2 m1, Vector2 v2)
        {
            Vector2 result = new Vector2 ();

            result [0] = m1._x [0] * v2 [0] + m1._x [1] * v2 [1];
            result [1] = m1._x [2] * v2 [0] + m1._x [3] * v2 [1];

            return result;
        }

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