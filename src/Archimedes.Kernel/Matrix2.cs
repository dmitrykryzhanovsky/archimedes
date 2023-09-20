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
            return ((_x [0] == other._x [0]) && 
                    (_x [1] == other._x [1]) && 
                    (_x [2] == other._x [2]) && 
                    (_x [3] == other._x [3])) ;
        }

        public override bool Equals (object? other)
        {
            if (other is Matrix2) return Equals (other as Matrix2);
            else throw new InvalidCastException ();

            // ? А что если Matrix имеет размер 2х2?
        }

        public override int GetHashCode ()
        {
            return base.GetHashCode ();
        }

        #endregion
    }
}