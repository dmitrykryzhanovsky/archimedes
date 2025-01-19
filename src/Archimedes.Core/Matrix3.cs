namespace Archimedes
{
    public class Matrix3 : Matrix
    {
        private const int Matrix3Dimension = 3;

        public override int Height
        {
            get => Matrix3Dimension;
        }

        public override int Width
        {
            get => Matrix3Dimension;
        }

        #region Constructors

        public Matrix3 (double a00, double a01, double a02,
                        double a10, double a11, double a12,
                        double a20, double a21, double a22) : base (Matrix3Dimension, Matrix3Dimension)
        {
            _x [0, 0] = a00;
            _x [0, 1] = a01;
            _x [0, 2] = a02;

            _x [1, 0] = a10;
            _x [1, 1] = a11;
            _x [1, 2] = a12;

            _x [2, 0] = a20;
            _x [2, 1] = a21;
            _x [2, 2] = a22;
        }

        public Matrix3 (double [] array) : this (array [0], array [1], array [2],
                                                 array [3], array [4], array [5],
                                                 array [6], array [7], array [8])
        {
        }

        public Matrix3 (double [,] array) : this (array [0, 0], array [0, 1], array [0, 2],
                                                  array [1, 0], array [1, 1], array [1, 2],
                                                  array [2, 0], array [2, 1], array [2, 2])
        {
        }

        public Matrix3 (Matrix3 other) : this (other._x)
        {
        }

        public override object Clone ()
        {
            return new Matrix3 (this);
        }

        #endregion

        public static Vector3 operator * (Matrix3 m, Vector3 v)
        {
            return new Vector3 (m [0, 0] * v [0] + m [0, 1] * v [1] + m [0, 2] * v [2],
                                m [1, 0] * v [0] + m [1, 1] * v [1] + m [1, 2] * v [2],
                                m [2, 0] * v [0] + m [2, 1] * v [1] + m [2, 2] * v [2]);
        }

        public static Vector3 operator * (Vector3 v, Matrix3 m)
        {
            return new Vector3 (v [0] * m [0, 0] + v [1] * m [1, 0] + v [2] * m [2, 0],
                                v [0] * m [0, 1] + v [1] * m [1, 1] + v [2] * m [2, 1],
                                v [0] * m [0, 2] + v [1] * m [1, 2] + v [2] * m [2, 2]);
        }

        public static Matrix3 operator * (Matrix3 m1, Matrix3 m2)
        {
            return new Matrix3 (m1 [0, 0] * m2 [0, 0] + m1 [0, 1] * m2 [1, 0] + m1 [0, 2] * m2 [2, 0],
                                m1 [0, 0] * m2 [0, 1] + m1 [0, 1] * m2 [1, 1] + m1 [0, 2] * m2 [2, 1],
                                m1 [0, 0] * m2 [0, 2] + m1 [0, 1] * m2 [1, 2] + m1 [0, 2] * m2 [2, 2],

                                m1 [1, 0] * m2 [0, 0] + m1 [1, 1] * m2 [1, 0] + m1 [1, 2] * m2 [2, 0],
                                m1 [1, 0] * m2 [0, 1] + m1 [1, 1] * m2 [1, 1] + m1 [1, 2] * m2 [2, 1],
                                m1 [1, 0] * m2 [0, 2] + m1 [1, 1] * m2 [1, 2] + m1 [1, 2] * m2 [2, 2],

                                m1 [2, 0] * m2 [0, 0] + m1 [2, 1] * m2 [1, 0] + m1 [2, 2] * m2 [2, 0],
                                m1 [2, 0] * m2 [0, 1] + m1 [2, 1] * m2 [1, 1] + m1 [2, 2] * m2 [2, 1],
                                m1 [2, 0] * m2 [0, 2] + m1 [2, 1] * m2 [1, 2] + m1 [2, 2] * m2 [2, 2]);
        }
    }
}