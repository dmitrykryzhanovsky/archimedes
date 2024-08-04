using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Matrix3Tests
    {
        [TestMethod ()]
        public void HeightTest ()
        {
            Matrix3 m = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);

            int expected = 3;

            int actual = m.Height;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void WidthTest ()
        {
            Matrix3 m = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);

            int expected = 3;

            int actual = m.Width;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Matrix3Test_SeparateItems_1 ()
        {
            Matrix3 m = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);

            Assert.AreEqual ( 3, m.Height);
            Assert.AreEqual ( 3, m.Width);
            Assert.AreEqual ( 2, m [0, 0]);
            Assert.AreEqual ( 3, m [0, 1]);            
            Assert.AreEqual ( 5, m [0, 2]);
            Assert.AreEqual ( 7, m [1, 0]);
            Assert.AreEqual (11, m [1, 1]);
            Assert.AreEqual (13, m [1, 2]);
            Assert.AreEqual (19, m [2, 0]);
            Assert.AreEqual (23, m [2, 1]);
            Assert.AreEqual (29, m [2, 2]);
        }

        [TestMethod ()]
        public void Matrix3Test_SeparateItems_2 ()
        {
            Matrix3 m = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);

            Assert.AreEqual ( 3, m.Items.GetLength (0));
            Assert.AreEqual ( 3, m.Items.GetLength (1));
            Assert.AreEqual ( 2, m.Items [0, 0]);
            Assert.AreEqual ( 3, m.Items [0, 1]);
            Assert.AreEqual ( 5, m.Items [0, 2]);
            Assert.AreEqual ( 7, m.Items [1, 0]);
            Assert.AreEqual (11, m.Items [1, 1]);
            Assert.AreEqual (13, m.Items [1, 2]);
            Assert.AreEqual (19, m.Items [2, 0]);
            Assert.AreEqual (23, m.Items [2, 1]);
            Assert.AreEqual (29, m.Items [2, 2]);
        }

        [TestMethod ()]
        public void Matrix3Test_Array1D_1 ()
        {
            double [] items = new double [] { 2, 3, 5, 7, 11, 13, 19, 23, 29 };
            Matrix3 m = new Matrix3 (items);

            Assert.AreEqual ( 3, m.Height);
            Assert.AreEqual ( 3, m.Width);
            Assert.AreEqual ( 2, m [0, 0]);
            Assert.AreEqual ( 3, m [0, 1]);
            Assert.AreEqual ( 5, m [0, 2]);
            Assert.AreEqual ( 7, m [1, 0]);
            Assert.AreEqual (11, m [1, 1]);
            Assert.AreEqual (13, m [1, 2]);
            Assert.AreEqual (19, m [2, 0]);
            Assert.AreEqual (23, m [2, 1]);
            Assert.AreEqual (29, m [2, 2]);
        }

        [TestMethod ()]
        public void Matrix3Test_Array1_2 ()
        {
            double [] items = new double [] { 2, 3, 5, 7, 11, 13, 19, 23, 29 };
            Matrix3 m = new Matrix3 (items);

            Assert.AreEqual ( 3, m.Items.GetLength (0));
            Assert.AreEqual ( 3, m.Items.GetLength (1));
            Assert.AreEqual ( 2, m.Items [0, 0]);
            Assert.AreEqual ( 3, m.Items [0, 1]);
            Assert.AreEqual ( 5, m.Items [0, 2]);
            Assert.AreEqual ( 7, m.Items [1, 0]);
            Assert.AreEqual (11, m.Items [1, 1]);
            Assert.AreEqual (13, m.Items [1, 2]);
            Assert.AreEqual (19, m.Items [2, 0]);
            Assert.AreEqual (23, m.Items [2, 1]);
            Assert.AreEqual (29, m.Items [2, 2]);
        }

        [TestMethod ()]
        public void Matrix3Test_Array2D_1 ()
        {
            double [,] items = new double [,] { { 2, 3, 5 }, { 7, 11, 13 }, { 19, 23, 29 } };
            Matrix3 m = new Matrix3 (items);

            Assert.AreEqual ( 3, m.Height);
            Assert.AreEqual ( 3, m.Width);
            Assert.AreEqual ( 2, m [0, 0]);
            Assert.AreEqual ( 3, m [0, 1]);
            Assert.AreEqual ( 5, m [0, 2]);
            Assert.AreEqual ( 7, m [1, 0]);
            Assert.AreEqual (11, m [1, 1]);
            Assert.AreEqual (13, m [1, 2]);
            Assert.AreEqual (19, m [2, 0]);
            Assert.AreEqual (23, m [2, 1]);
            Assert.AreEqual (29, m [2, 2]);
        }

        [TestMethod ()]
        public void Matrix3Test_Array2D_2 ()
        {
            double [,] items = new double [,] { { 2, 3, 5 }, { 7, 11, 13 }, { 19, 23, 29 } };
            Matrix3 m = new Matrix3 (items);

            Assert.AreEqual ( 3, m.Items.GetLength (0));
            Assert.AreEqual ( 3, m.Items.GetLength (1));
            Assert.AreEqual ( 2, m.Items [0, 0]);
            Assert.AreEqual ( 3, m.Items [0, 1]);
            Assert.AreEqual ( 5, m.Items [0, 2]);
            Assert.AreEqual ( 7, m.Items [1, 0]);
            Assert.AreEqual (11, m.Items [1, 1]);
            Assert.AreEqual (13, m.Items [1, 2]);
            Assert.AreEqual (19, m.Items [2, 0]);
            Assert.AreEqual (23, m.Items [2, 1]);
            Assert.AreEqual (29, m.Items [2, 2]);
        }

        [TestMethod ()]
        public void VectorTest_Copy_1 ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);
            Matrix3 m2 = new Matrix3 (m1);

            Assert.AreEqual ( 3, m2.Height);
            Assert.AreEqual ( 3, m2.Width);
            Assert.AreEqual ( 2, m2 [0, 0]);
            Assert.AreEqual ( 3, m2 [0, 1]);
            Assert.AreEqual ( 5, m2 [0, 2]);
            Assert.AreEqual ( 7, m2 [1, 0]);
            Assert.AreEqual (11, m2 [1, 1]);
            Assert.AreEqual (13, m2 [1, 2]);
            Assert.AreEqual (19, m2 [2, 0]);
            Assert.AreEqual (23, m2 [2, 1]);
            Assert.AreEqual (29, m2 [2, 2]);
        }

        [TestMethod ()]
        public void VectorTest_Copy_2 ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);
            Matrix3 m2 = new Matrix3 (m1);

            double [,] expected = new double [,] { { 2, 3, 5 }, { 7, 11, 13 }, { 19, 23, 29 } };

            double [,] actual = m2.Items;

            Assert.AreEqual (true, expected.Equals<double> (actual));
        }

        [TestMethod ()]
        public void CloneTest_1 ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);
            Matrix3 m2 = (Matrix3)m1.Clone ();

            Assert.AreEqual ( 3, m2.Height);
            Assert.AreEqual ( 3, m2.Width);
            Assert.AreEqual ( 2, m2 [0, 0]);
            Assert.AreEqual ( 3, m2 [0, 1]);
            Assert.AreEqual ( 5, m2 [0, 2]);
            Assert.AreEqual ( 7, m2 [1, 0]);
            Assert.AreEqual (11, m2 [1, 1]);
            Assert.AreEqual (13, m2 [1, 2]);
            Assert.AreEqual (19, m2 [2, 0]);
            Assert.AreEqual (23, m2 [2, 1]);
            Assert.AreEqual (29, m2 [2, 2]);
        }

        [TestMethod ()]
        public void CloneTest_2 ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);
            Matrix3 m2 = (Matrix3)m1.Clone ();

            double [,] expected = new double [,] { { 2, 3, 5 }, { 7, 11, 13 }, { 19, 23, 29 } };

            double [,] actual = m2.Items;

            Assert.AreEqual (true, expected.Equals<double> (actual));
        }

        [TestMethod ()]
        public void EqualsTest_DifferentItems ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);
            Matrix3 m2 = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 31);

            bool expected = false;

            bool actual = m1.Equals (m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualItems ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);
            Matrix3 m2 = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);

            bool expected = true;

            bool actual = m1.Equals (m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualsTest_True ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);
            Matrix3 m2 = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);

            bool expected = true;

            bool actual = (m1 == m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualsTest_False ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);
            Matrix3 m2 = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 31);

            bool expected = false;

            bool actual = (m1 == m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualsTest_True ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);
            Matrix3 m2 = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 31);

            bool expected = true;

            bool actual = (m1 != m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualsTest_False ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);
            Matrix3 m2 = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);

            bool expected = false;

            bool actual = (m1 != m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Matrix3 m1 = new Matrix3 ( 2,  3,  5,  7, 11, 13, 19, 23, 29);
            Matrix3 m2 = new Matrix3 (89, 55, 34, 21, 13,  8,  5,  3,  2);

            Matrix3 expected = new Matrix3 (91, 58, 39, 28, 24, 21, 24, 26, 31);

            Matrix3 actual = m1 + m2;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opSubtractTest ()
        {
            Matrix3 m1 = new Matrix3 ( 2,  3,  5,  7, 11, 13, 19, 23, 29);
            Matrix3 m2 = new Matrix3 (89, 55, 34, 21, 13,  8,  5,  3,  2);

            Matrix3 expected = new Matrix3 (-87, -52, -29, -14, -2, 5, 14, 20, 27);

            Matrix3 actual = m1 - m2;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opNegateTest ()
        {
            Matrix3 m = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);

            Matrix3 expected = new Matrix3 (-2, -3, -5, -7, -11, -13, -19, -23, -29);

            Matrix3 actual = -m;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_Matrix3ByCoefficient ()
        {
            Matrix3 m = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);
            double coefficient = 3;

            Matrix3 expected = new Matrix3 (6, 9, 15, 21, 33, 39, 57, 69, 87);

            Matrix3 actual = m * coefficient;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_CoefficientByMatrix3 ()
        {
            Matrix3 m = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);
            double coefficient = 3;

            Matrix3 expected = new Matrix3 (6, 9, 15, 21, 33, 39, 57, 69, 87);

            Matrix3 actual = coefficient * m;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opDivideTest ()
        {
            Matrix3 m = new Matrix3 (2, 3, 5, 7, 11, 13, 19, 23, 29);
            double coefficient = 2;

            Matrix3 expected = new Matrix3 (1, 1.5, 2.5, 3.5, 5.5, 6.5, 9.5, 11.5, 14.5);

            Matrix3 actual = m / coefficient;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_Matrix3ByMatrix3 ()
        {
            Matrix3 m1 = new Matrix3 (0, 1, 0, 2, 3, 5, 4, 7, 6);
            Matrix3 m2 = new Matrix3 (0, 2, 3, 5, 1, 7, 9, 8, 4);

            Matrix3 expected = new Matrix3 (5, 1, 7, 60, 47, 47, 89, 63, 85);

            Matrix3 actual = m1 * m2;

            Assert.AreEqual (true, expected.Equals (actual));
        }
    }
}