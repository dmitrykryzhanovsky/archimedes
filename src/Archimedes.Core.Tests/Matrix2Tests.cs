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

            Assert.AreEqual (2, m.Height);
        }

        [TestMethod ()]
        public void WidthTest ()
        {
            Matrix2 m = new Matrix2 (2, 3, 5, 7);

            Assert.AreEqual (2, m.Width);
        }

        [TestMethod ()]
        public void Matrix2Test_Items ()
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
        public void Matrix2Test_Copying ()
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
        public void CloneTest ()
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
        public void EqualsTest_Matrix2_ItemsNotEqual ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 7);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 8);

            bool expected = false;

            bool actual = m1.Equals (m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Matrix2_ItemsEqual ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 7);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 7);

            bool expected = true;

            bool actual = m1.Equals (m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Matrix_SizeNotEqual ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 7);
            Matrix  m2 = new Matrix  (2, 3, 2, 3, 5, 7, 11, 13);            

            bool expected = false;

            bool actual = m2.Equals (m1);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Matrix_SizeEqual_ItemsNotEqual ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 7);
            Matrix  m2 = new Matrix  (2, 2, 2, 3, 5, 8);

            bool expected = false;

            bool actual = m2.Equals (m1);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Matrix_SizeEqual_ItemsEqual ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 7);
            Matrix  m2 = new Matrix  (2, 2, 2, 3, 5, 7);

            bool expected = true;

            bool actual = m2.Equals (m1);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest_ItemsNotEqual ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 7);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 8);

            bool expected = false;

            bool actual = (m1 == m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest_ItemsEqual ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 7);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 7);

            bool expected = true;

            bool actual = (m1 == m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest_ItemsNotEqual ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 7);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 8);

            bool expected = true;

            bool actual = (m1 != m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest_ItemsEqual ()
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
            Matrix2 m1 = new Matrix2 (2,  3,  5,  7);
            Matrix2 m2 = new Matrix2 (8, 13, 21, 34);

            Matrix2 expected = new Matrix2 (10, 16, 26, 41);

            Matrix actual = m1 + m2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opSubtractTest ()
        {
            Matrix2 m1 = new Matrix2 (2,  3,  5,  7);
            Matrix2 m2 = new Matrix2 (8, 13, 21, 34);

            Matrix2 expected = new Matrix2 (-6, -10, -16, -27);

            Matrix actual = m1 - m2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNegateTest ()
        {
            Matrix2 m = new Matrix2 (2, 3, 5, 7);

            Matrix2 expected = new Matrix2 (-2, -3, -5, -7);

            Matrix2 actual = -m;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_Matrix2ByCoefficient ()
        {
            Matrix2 m           = new Matrix2 (2, 3, 5, 7);
            double  coefficient = 3;

            Matrix2 expected = new Matrix2 (6, 9, 15, 21);

            Matrix2 actual = m * coefficient;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_CoefficientByMatrix2 ()
        {
            Matrix2 m           = new Matrix2 (2, 3, 5, 7);
            double  coefficient = 3;

            Matrix2 expected = new Matrix2 (6, 9, 15, 21);

            Matrix2 actual = coefficient * m;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opDivideTest ()
        {
            Matrix2 m           = new Matrix2 (2.0, 3.0, 5.0, 7.0);
            double  coefficient = 4.0;

            Matrix2 expected = new Matrix2 (0.5, 0.75, 1.25, 1.75);

            Matrix2 actual = m / coefficient;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_Matrix2Vector2Product ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            Vector2 v2 = new Vector2 (13, 21);

            Vector2 expected = new Vector2 (89, 233);

            Vector2 actual = m1 * v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_Vector2Matrix2Product ()
        {
            Vector2 v1 = new Vector2 (13, 21);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 8);
            
            Vector2 expected = new Vector2 (131, 207);

            Vector2 actual = v1 * m2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_Matrix2Matrix2Product ()
        {
            Matrix2 m1 = new Matrix2 (4, 7, 5, 1);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 8);

            Matrix2 expected = new Matrix2 (43, 68, 15, 23);

            Matrix2 actual = m1 * m2;

            Assert.AreEqual (expected, actual);
        }
    }
}