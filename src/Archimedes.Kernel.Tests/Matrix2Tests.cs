using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Matrix2Tests
    {
        [TestMethod ()]
        public void HeightTest ()
        {
            Matrix2 m = new Matrix2 (2, 3, 5, 7);

            int expected = 2;

            int actual = m.Height;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void WidthTest ()
        {
            Matrix2 m = new Matrix2 (2, 3, 5, 7);

            int expected = 2;

            int actual = m.Width;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Matrix2Test_SeparateItems_1 ()
        {
            Matrix2 m = new Matrix2 (2, 3, 5, 7);

            Assert.AreEqual (2, m.Height);
            Assert.AreEqual (2, m.Width);
            Assert.AreEqual (2, m [0, 0]);
            Assert.AreEqual (3, m [0, 1]);            
            Assert.AreEqual (5, m [1, 0]);
            Assert.AreEqual (7, m [1, 1]);
        }

        [TestMethod ()]
        public void Matrix2Test_SeparateItems_2 ()
        {
            Matrix2 m = new Matrix2 (2, 3, 5, 7);

            Assert.AreEqual (2, m.Items.GetLength (0));
            Assert.AreEqual (2, m.Items.GetLength (1));
            Assert.AreEqual (2, m.Items [0, 0]);
            Assert.AreEqual (3, m.Items [0, 1]);
            Assert.AreEqual (5, m.Items [1, 0]);
            Assert.AreEqual (7, m.Items [1, 1]);
        }

        [TestMethod ()]
        public void Matrix2Test_Array1D_1 ()
        {
            double [] items = new double [] { 2, 3, 5, 7 };
            Matrix2 m = new Matrix2 (items);

            Assert.AreEqual (2, m.Height);
            Assert.AreEqual (2, m.Width);
            Assert.AreEqual (2, m [0, 0]);
            Assert.AreEqual (3, m [0, 1]);
            Assert.AreEqual (5, m [1, 0]);
            Assert.AreEqual (7, m [1, 1]);
        }

        [TestMethod ()]
        public void Matrix2Test_Array1_2 ()
        {
            double [] items = new double [] { 2, 3, 5, 7 };
            Matrix2 m = new Matrix2 (items);

            Assert.AreEqual (2, m.Items.GetLength (0));
            Assert.AreEqual (2, m.Items.GetLength (1));
            Assert.AreEqual (2, m.Items [0, 0]);
            Assert.AreEqual (3, m.Items [0, 1]);
            Assert.AreEqual (5, m.Items [1, 0]);
            Assert.AreEqual (7, m.Items [1, 1]);
        }

        [TestMethod ()]
        public void Matrix2Test_Array2D_1 ()
        {
            double [,] items = new double [,] { { 2, 3 }, { 5, 7 } };
            Matrix2 m = new Matrix2 (items);

            Assert.AreEqual (2, m.Height);
            Assert.AreEqual (2, m.Width);
            Assert.AreEqual (2, m [0, 0]);
            Assert.AreEqual (3, m [0, 1]);
            Assert.AreEqual (5, m [1, 0]);
            Assert.AreEqual (7, m [1, 1]);
        }

        [TestMethod ()]
        public void Matrix2Test_Array2D_2 ()
        {
            double [,] items = new double [,] { { 2, 3 }, { 5, 7 } };
            Matrix2 m = new Matrix2 (items);

            Assert.AreEqual (2, m.Items.GetLength (0));
            Assert.AreEqual (2, m.Items.GetLength (1));
            Assert.AreEqual (2, m.Items [0, 0]);
            Assert.AreEqual (3, m.Items [0, 1]);
            Assert.AreEqual (5, m.Items [1, 0]);
            Assert.AreEqual (7, m.Items [1, 1]);
        }

        [TestMethod ()]
        public void VectorTest_Copy_1 ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 7);
            Matrix2 m2 = new Matrix2 (m1);

            Assert.AreEqual (2, m2.Height);
            Assert.AreEqual (2, m2.Width);
            Assert.AreEqual (2, m2 [0, 0]);
            Assert.AreEqual (3, m2 [0, 1]);
            Assert.AreEqual (5, m2 [1, 0]);
            Assert.AreEqual (7, m2 [1, 1]);
        }

        [TestMethod ()]
        public void VectorTest_Copy_2 ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 7);
            Matrix2 m2 = new Matrix2 (m1);

            double [,] expected = new double [,] { { 2, 3 }, { 5, 7 } };

            double [,] actual = m2.Items;

            Assert.AreEqual (true, expected.Equals<double> (actual));
        }

        [TestMethod ()]
        public void CloneTest_1 ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 7);
            Matrix2 m2 = (Matrix2)m1.Clone ();

            Assert.AreEqual (2, m2.Height);
            Assert.AreEqual (2, m2.Width);
            Assert.AreEqual (2, m2 [0, 0]);
            Assert.AreEqual (3, m2 [0, 1]);
            Assert.AreEqual (5, m2 [1, 0]);
            Assert.AreEqual (7, m2 [1, 1]);
        }

        [TestMethod ()]
        public void CloneTest_2 ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 7);
            Matrix2 m2 = (Matrix2)m1.Clone ();

            double [,] expected = new double [,] { { 2, 3 }, { 5, 7 } };

            double [,] actual = m2.Items;

            Assert.AreEqual (true, expected.Equals<double> (actual));
        }

        [TestMethod ()]
        public void EqualsTest_DifferentItems ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 7);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 8);

            bool expected = false;

            bool actual = m1.Equals (m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualItems ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 7);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 7);

            bool expected = true;

            bool actual = m1.Equals (m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualsTest_True ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 7);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 7);

            bool expected = true;

            bool actual = (m1 == m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualsTest_False ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 7);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 8);

            bool expected = false;

            bool actual = (m1 == m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualsTest_True ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 7);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 8);

            bool expected = true;

            bool actual = (m1 != m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualsTest_False ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 7);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 7);

            bool expected = false;

            bool actual = (m1 != m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Matrix2 m1 = new Matrix2 ( 2,  3, 5, 7);
            Matrix2 m2 = new Matrix2 (21, 13, 8, 5);

            Matrix2 expected = new Matrix2 (23, 16, 13, 12);

            Matrix2 actual = m1 + m2;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opSubtractTest ()
        {
            Matrix2 m1 = new Matrix2 ( 2,  3, 5, 7);
            Matrix2 m2 = new Matrix2 (21, 13, 8, 5);

            Matrix2 expected = new Matrix2 (-19, -10, -3, 2);

            Matrix2 actual = m1 - m2;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opNegateTest ()
        {
            Matrix2 m = new Matrix2 (2, 3, 5, 7);

            Matrix2 expected = new Matrix2 (-2, -3, -5, -7);

            Matrix2 actual = -m;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_Matrix2ByCoefficient ()
        {
            Matrix2 m = new Matrix2 (2, 3, 5, 7);
            double coefficient = 3;

            Matrix2 expected = new Matrix2 (6, 9, 15, 21);

            Matrix2 actual = m * coefficient;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_CoefficientByMatrix2 ()
        {
            Matrix2 m = new Matrix2 (2, 3, 5, 7);
            double coefficient = 3;

            Matrix2 expected = new Matrix2 (6, 9, 15, 21);

            Matrix2 actual = coefficient * m;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opDivideTest ()
        {
            Matrix2 m = new Matrix2 (2, 3, 5, 7);
            double coefficient = 2;

            Matrix2 expected = new Matrix2 (1, 1.5, 2.5, 3.5);

            Matrix2 actual = m / coefficient;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_Matrix2ByMatrix2 ()
        {
            Matrix2 m1 = new Matrix2 ( 2,  3,  5 , 7);
            Matrix2 m2 = new Matrix2 (11, 13, 19, 23);

            Matrix2 expected = new Matrix2 (79, 95, 188, 226);

            Matrix2 actual = m1 * m2;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_Matrix2ByVector2 ()
        {
            Matrix2 m = new Matrix2 (2, 3, 5, 7);
            Vector2 v = new Vector2 (11, 19);

            Vector2 expected = new Vector2 (79, 188);

            Vector2 actual = m * v;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_Vector2ByMatrix2 ()
        {
            Vector2 v = new Vector2 (2, 3);
            Matrix2 m = new Matrix2 (11, 13, 19, 23);

            Vector2 expected = new Vector2 (79, 95);

            Vector2 actual = v * m;

            Assert.AreEqual (true, expected.Equals (actual));
        }
    }
}