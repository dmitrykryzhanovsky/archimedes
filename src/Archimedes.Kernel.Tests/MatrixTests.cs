using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class MatrixTests
    {
        [TestMethod ()]
        public void IndexerTest_Get ()
        {
            Matrix m = new Matrix (2, 3, 5, 7, 11, 13, 19, 23);
            int    row = 1;
            int    column = 0;

            double expected = 13;

            double actual = m [row, column];

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IndexerTest_Set ()
        {
            Matrix m = new Matrix (2, 3, 5, 7, 11, 13, 19, 23);
            int    row = 1;
            int    column = 0;
            int    value = 8;

            double expected = 8;

            m [row, column] = value;
            double actual = m [row, column];

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ItemsTest ()
        {
            Matrix m = new Matrix (2, 3, 5, 7, 11, 13, 19, 23);

            double [,] expected = new double [,] { { 5, 7, 11 }, { 13, 19, 23 } };

            double [,] actual = m.Items;

            Assert.AreEqual (true, expected.Equals<double> (actual));
        }

        [TestMethod ()]
        public void HeightTest ()
        {
            Matrix m = new Matrix (2, 3, 5, 7, 11, 13, 19, 23);

            int expected = 2;

            int actual = m.Height;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void WidthTest ()
        {
            Matrix m = new Matrix (2, 3, 5, 7, 11, 13, 19, 23);

            int expected = 3;

            int actual = m.Width;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MatrixTest_Dimensions_1 ()
        {
            Matrix m = new Matrix (4, 3);

            (int, int) expected = (4, 3);

            (int, int) actual = (m.Height, m.Width);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MatrixTest_Dimensions_2 ()
        {
            Matrix m = new Matrix (4, 3);

            (int, int) expected = (4, 3);

            (int, int) actual = (m.Items.GetLength (0), m.Items.GetLength (1));

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MatrixTest_Array1DToArray2D_1 ()
        {
            Matrix m = new Matrix (2, 3, 5, 7, 11, 13, 19, 23);

            Assert.AreEqual ( 2, m.Height);
            Assert.AreEqual ( 3, m.Width);
            Assert.AreEqual ( 5, m [0, 0]);
            Assert.AreEqual ( 7, m [0, 1]);
            Assert.AreEqual (11, m [0, 2]);
            Assert.AreEqual (13, m [1, 0]);
            Assert.AreEqual (19, m [1, 1]);
            Assert.AreEqual (23, m [1, 2]);
        }

        [TestMethod ()]
        public void MatrixTest_Array1DToArray2D_2 ()
        {
            Matrix m = new Matrix (2, 3, 5, 7, 11, 13, 19, 23);

            Assert.AreEqual ( 2, m.Items.GetLength (0));
            Assert.AreEqual ( 3, m.Items.GetLength (1));
            Assert.AreEqual ( 5, m.Items [0, 0]);
            Assert.AreEqual ( 7, m.Items [0, 1]);
            Assert.AreEqual (11, m.Items [0, 2]);
            Assert.AreEqual (13, m.Items [1, 0]);
            Assert.AreEqual (19, m.Items [1, 1]);
            Assert.AreEqual (23, m.Items [1, 2]);
        }

        [TestMethod ()]
        public void MatrixTest_Array2D_1 ()
        {
            double [,] items = new double [,] { { 5, 7, 11 }, { 13, 19, 23 } };
            Matrix m = new Matrix (items);

            Assert.AreEqual ( 2, m.Height);
            Assert.AreEqual ( 3, m.Width);
            Assert.AreEqual ( 5, m [0, 0]);
            Assert.AreEqual ( 7, m [0, 1]);
            Assert.AreEqual (11, m [0, 2]);
            Assert.AreEqual (13, m [1, 0]);
            Assert.AreEqual (19, m [1, 1]);
            Assert.AreEqual (23, m [1, 2]);
        }

        [TestMethod ()]
        public void MatrixTest_Array2D_2 ()
        {
            double [,] items = new double [,] { { 5, 7, 11 }, { 13, 19, 23 } };
            Matrix m = new Matrix (items);

            Assert.AreEqual ( 2, m.Items.GetLength (0));
            Assert.AreEqual ( 3, m.Items.GetLength (1));
            Assert.AreEqual ( 5, m.Items [0, 0]);
            Assert.AreEqual ( 7, m.Items [0, 1]);
            Assert.AreEqual (11, m.Items [0, 2]);
            Assert.AreEqual (13, m.Items [1, 0]);
            Assert.AreEqual (19, m.Items [1, 1]);
            Assert.AreEqual (23, m.Items [1, 2]);
        }

        [TestMethod ()]
        public void VectorTest_Copy_1 ()
        {
            Matrix m1 = new Matrix (2, 3, 5, 7, 11, 13, 19, 23);
            Matrix m2 = new Matrix (m1);

            Assert.AreEqual ( 2, m2.Height);
            Assert.AreEqual ( 3, m2.Width);
            Assert.AreEqual ( 5, m2 [0, 0]);
            Assert.AreEqual ( 7, m2 [0, 1]);
            Assert.AreEqual (11, m2 [0, 2]);
            Assert.AreEqual (13, m2 [1, 0]);
            Assert.AreEqual (19, m2 [1, 1]);
            Assert.AreEqual (23, m2 [1, 2]);
        }

        [TestMethod ()]
        public void VectorTest_Copy_2 ()
        {
            Matrix m1 = new Matrix (2, 3, 5, 7, 11, 13, 19, 23);
            Matrix m2 = new Matrix (m1);

            double [,] expected = new double [,] { { 5, 7, 11 }, { 13, 19, 23 } };

            double [,] actual = m2.Items;

            Assert.AreEqual (true, expected.Equals<double> (actual));
        }

        [TestMethod ()]
        public void CloneTest_1 ()
        {
            Matrix m1 = new Matrix (2, 3, 5, 7, 11, 13, 19, 23);
            Matrix m2 = (Matrix)m1.Clone ();

            Assert.AreEqual ( 2, m2.Height);
            Assert.AreEqual ( 3, m2.Width);
            Assert.AreEqual ( 5, m2 [0, 0]);
            Assert.AreEqual ( 7, m2 [0, 1]);
            Assert.AreEqual (11, m2 [0, 2]);
            Assert.AreEqual (13, m2 [1, 0]);
            Assert.AreEqual (19, m2 [1, 1]);
            Assert.AreEqual (23, m2 [1, 2]);
        }

        [TestMethod ()]
        public void CloneTest_2 ()
        {
            Matrix m1 = new Matrix (2, 3, 5, 7, 11, 13, 19, 23);
            Matrix m2 = (Matrix)m1.Clone ();

            double [,] expected = new double [,] { { 5, 7, 11 }, { 13, 19, 23 } };

            double [,] actual = m2.Items;

            Assert.AreEqual (true, expected.Equals<double> (actual));
        }

        [TestMethod ()]
        public void EqualsTest_DifferentDimensions ()
        {
            Matrix m1 = new Matrix (2, 2, 2, 3, 5, 7);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);

            bool expected = false;

            bool actual = m1.Equals (m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualDimensions_DifferentItems ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);

            bool expected = false;

            bool actual = m1.Equals (m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualDimensions_EqualItems ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);

            bool expected = true;

            bool actual = m1.Equals (m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualsTest_True ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);

            bool expected = true;

            bool actual = (m1 == m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualsTest_False ()
        {
            Matrix m1 = new Matrix (3, 2, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);

            bool expected = false;

            bool actual = (m1 == m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualsTest_True ()
        {
            Matrix m1 = new Matrix (3, 2, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);

            bool expected = true;

            bool actual = (m1 != m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualsTest_False ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);

            bool expected = false;

            bool actual = (m1 != m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Matrix m1 = new Matrix (2, 3,  2,  3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (2, 3, 21, 13, 8, 5,  3,  2);

            Matrix expected = new Matrix (2, 3, 23, 16, 13, 12, 14, 15);

            Matrix actual = m1 + m2;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opAddTest_IncompatibleDimensions ()
        {
            Matrix m1 = new Matrix (2, 4, 2, 3, 5, 7, 11, 13, 17, 19);
            Matrix m2 = new Matrix (2, 1, 4, 6);

            bool wasException = false;

            try
            {
                Matrix result = m1 + m2;
            }

            catch (ArithmeticException)
            {
                wasException = true;
            }

            Assert.AreEqual (true, wasException);
        }

        [TestMethod ()]
        public void opSubtractTest ()
        {
            Matrix m1 = new Matrix (2, 3,  2,  3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (2, 3, 21, 13, 8, 5,  3,  2);

            Matrix expected = new Matrix (2, 3, -19, -10, -3, 2, 8, 11);

            Matrix actual = m1 - m2;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opSubtractTest_IncompatibleDimensions ()
        {
            Matrix m1 = new Matrix (2, 4, 2, 3, 5, 7, 11, 13, 17, 19);
            Matrix m2 = new Matrix (2, 1, 4, 6);

            bool wasException = false;

            try
            {
                Matrix result = m1 - m2;
            }

            catch (ArithmeticException)
            {
                wasException = true;
            }

            Assert.AreEqual (true, wasException);
        }

        [TestMethod ()]
        public void opNegateTest ()
        {
            Matrix m = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);

            Matrix expected = new Matrix (2, 3, -2, -3, -5, -7, -11, -13);

            Matrix actual = -m;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_MatrixByCoefficient ()
        {
            Matrix m = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            double coefficient = 3;

            Matrix expected = new Matrix (2, 3, 6, 9, 15, 21, 33, 39);

            Matrix actual = m * coefficient;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_CoefficientByMatrix ()
        {
            Matrix m = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            double coefficient = 3;

            Matrix expected = new Matrix (2, 3, 6, 9, 15, 21, 33, 39);

            Matrix actual = coefficient * m;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opDivideTest ()
        {
            Matrix m = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            double coefficient = 2;

            Matrix expected = new Matrix (2, 3, 1, 1.5, 2.5, 3.5, 5.5, 6.5);

            Matrix actual = m / coefficient;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_MatrixByMatrix ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (3, 1, 4, 6, 10);

            Matrix expected = new Matrix (2, 1, 76, 224);

            Matrix actual = m1 * m2;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_MatrixByMatrix_IncompatibleDimensions ()
        {
            Matrix m1 = new Matrix (2, 4, 2, 3, 5, 7, 11, 13, 17, 19);
            Matrix m2 = new Matrix (3, 1, 4, 6, 10);

            bool wasException = false;

            try
            {
                Matrix result = m1 * m2;
            }

            catch (ArithmeticException)
            {
                wasException = true;
            }

            Assert.AreEqual (true, wasException);
        }

        [TestMethod ()]
        public void opMultiplyTest_MatrixByVector ()
        {
            Matrix m = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Vector v = new Vector (4, 6, 10);

            Vector expected = new Vector (76, 224);

            Vector actual = m * v;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_VectorByMatrix ()
        {
            Vector v = new Vector (4, 6, 10);
            Matrix m = new Matrix (3, 2, 2, 3, 5, 7, 11, 13);            

            Vector expected = new Vector (148, 184);

            Vector actual = v * m;

            Assert.AreEqual (true, expected.Equals (actual));
        }
    }
}