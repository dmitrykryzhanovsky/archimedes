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
            other._x.CopyTo (_x, 0);
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


    }
}