using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Matrix3Tests
    {
        [TestMethod ()]
        public void HeightTest ()
        {
            Matrix3 m = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);

            int expected = 3;

            int actual = m.Height;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void WidthTest ()
        {
            Matrix3 m = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);

            int expected = 3;

            int actual = m.Width;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Matrix3Test_NineItems ()
        {
            Matrix3 m = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);

            Assert.AreEqual ( 3, m.Height);
            Assert.AreEqual ( 3, m.Width);
            Assert.AreEqual ( 2, m [0, 0]);
            Assert.AreEqual ( 3, m [0, 1]);
            Assert.AreEqual ( 5, m [0, 2]);
            Assert.AreEqual ( 7, m [1, 0]);
            Assert.AreEqual (11, m [1, 1]);
            Assert.AreEqual (13, m [1, 2]);
            Assert.AreEqual (17, m [2, 0]);
            Assert.AreEqual (19, m [2, 1]);
            Assert.AreEqual (23, m [2, 2]);
        }

        [TestMethod ()]
        public void Matrix3Test_Array1D ()
        {
            double [] array = new double [] { 2, 3, 5, 7, 11, 13, 17, 19, 23 };
            Matrix3   m     = new Matrix3 (array);

            Assert.AreEqual ( 3, m.Height);
            Assert.AreEqual ( 3, m.Width);
            Assert.AreEqual ( 2, m [0, 0]);
            Assert.AreEqual ( 3, m [0, 1]);
            Assert.AreEqual ( 5, m [0, 2]);
            Assert.AreEqual ( 7, m [1, 0]);
            Assert.AreEqual (11, m [1, 1]);
            Assert.AreEqual (13, m [1, 2]);
            Assert.AreEqual (17, m [2, 0]);
            Assert.AreEqual (19, m [2, 1]);
            Assert.AreEqual (23, m [2, 2]);
        }

        [TestMethod ()]
        public void Matrix3Test_Array2D ()
        {
            double [,] array = new double [,] { { 2, 3, 5 }, { 7, 11, 13 }, {17, 19, 23 } };
            Matrix3    m     = new Matrix3 (array);

            Assert.AreEqual ( 3, m.Height);
            Assert.AreEqual ( 3, m.Width);
            Assert.AreEqual ( 2, m [0, 0]);
            Assert.AreEqual ( 3, m [0, 1]);
            Assert.AreEqual ( 5, m [0, 2]);
            Assert.AreEqual ( 7, m [1, 0]);
            Assert.AreEqual (11, m [1, 1]);
            Assert.AreEqual (13, m [1, 2]);
            Assert.AreEqual (17, m [2, 0]);
            Assert.AreEqual (19, m [2, 1]);
            Assert.AreEqual (23, m [2, 2]);
        }

        [TestMethod ()]
        public void Matrix3Test_Matrix3 ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            Matrix3 m2 = new Matrix3 (m1);

            Assert.AreEqual ( 3, m2.Height);
            Assert.AreEqual ( 3, m2.Width);
            Assert.AreEqual ( 2, m2 [0, 0]);
            Assert.AreEqual ( 3, m2 [0, 1]);
            Assert.AreEqual ( 5, m2 [0, 2]);
            Assert.AreEqual ( 7, m2 [1, 0]);
            Assert.AreEqual (11, m2 [1, 1]);
            Assert.AreEqual (13, m2 [1, 2]);
            Assert.AreEqual (17, m2 [2, 0]);
            Assert.AreEqual (19, m2 [2, 1]);
            Assert.AreEqual (23, m2 [2, 2]);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            Matrix3 m2 = (Matrix3)m1.Clone ();

            Assert.AreEqual ( 3, m2.Height);
            Assert.AreEqual ( 3, m2.Width);
            Assert.AreEqual ( 2, m2 [0, 0]);
            Assert.AreEqual ( 3, m2 [0, 1]);
            Assert.AreEqual ( 5, m2 [0, 2]);
            Assert.AreEqual ( 7, m2 [1, 0]);
            Assert.AreEqual (11, m2 [1, 1]);
            Assert.AreEqual (13, m2 [1, 2]);
            Assert.AreEqual (17, m2 [2, 0]);
            Assert.AreEqual (19, m2 [2, 1]);
            Assert.AreEqual (23, m2 [2, 2]);
        }

        [TestMethod ()]
        public void EqualsTest_Equal ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            Matrix3 m2 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);

            Assert.IsTrue (m1.Equals (m2));
            Assert.IsTrue (m1 == m2);
            Assert.IsFalse (m1 != m2);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqual_ExceptOneItemMatches ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            Matrix3 m2 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 29);

            Assert.IsFalse (m1.Equals (m2));
            Assert.IsFalse (m1 == m2);
            Assert.IsTrue (m1 != m2);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqual_NoItemMatches ()
        {
            Matrix3 m1 = new Matrix3 (2,  3,  5,  7, 11, 13,  17,  19,  23);
            Matrix3 m2 = new Matrix3 (8, 13, 21, 34, 55, 89, 144, 233, 377);

            Assert.IsFalse (m1.Equals (m2));
            Assert.IsFalse (m1 == m2);
            Assert.IsTrue (m1 != m2);
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Matrix3 m1 = new Matrix3 (68, 40, 98, 22, 64, 80, 22, 83, 60);
            Matrix3 m2 = new Matrix3 ( 8, 37, 23, 26, 14, 61, 98, 10, 43);

            Matrix3 expected = new Matrix3 (76, 77, 121, 48, 78, 141, 120, 93, 103);

            Matrix3 actual = m1 + m2;

            Assert.AreEqual (expected [0, 0], actual [0, 0]);
            Assert.AreEqual (expected [0, 1], actual [0, 1]);
            Assert.AreEqual (expected [0, 2], actual [0, 2]);
            Assert.AreEqual (expected [1, 0], actual [1, 0]);
            Assert.AreEqual (expected [1, 1], actual [1, 1]);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);
            Assert.AreEqual (expected [2, 0], actual [2, 0]);
            Assert.AreEqual (expected [2, 1], actual [2, 1]);
            Assert.AreEqual (expected [2, 2], actual [2, 2]);
        }

        [TestMethod ()]
        public void opSubTest ()
        {
            Matrix3 m1 = new Matrix3 (68, 40, 98, 22, 64, 80, 22, 83, 60);
            Matrix3 m2 = new Matrix3 ( 8, 37, 23, 26, 14, 61, 98, 10, 43);

            Matrix3 expected = new Matrix3 (60, 3, 75, -4, 50, 19, -76, 73, 17);

            Matrix3 actual = m1 - m2;

            Assert.AreEqual (expected [0, 0], actual [0, 0]);
            Assert.AreEqual (expected [0, 1], actual [0, 1]);
            Assert.AreEqual (expected [0, 2], actual [0, 2]);
            Assert.AreEqual (expected [1, 0], actual [1, 0]);
            Assert.AreEqual (expected [1, 1], actual [1, 1]);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);
            Assert.AreEqual (expected [2, 0], actual [2, 0]);
            Assert.AreEqual (expected [2, 1], actual [2, 1]);
            Assert.AreEqual (expected [2, 2], actual [2, 2]);
        }

        [TestMethod ()]
        public void opNegTest ()
        {
            Matrix3 m = new Matrix3 (68, 40, 98, 22, 64, 80, 22, 83, 60);

            Matrix3 expected = new Matrix3 (-68, -40, -98, -22, -64, -80, -22, -83, -60);

            Matrix3 actual = -m;

            Assert.AreEqual (expected [0, 0], actual [0, 0]);
            Assert.AreEqual (expected [0, 1], actual [0, 1]);
            Assert.AreEqual (expected [0, 2], actual [0, 2]);
            Assert.AreEqual (expected [1, 0], actual [1, 0]);
            Assert.AreEqual (expected [1, 1], actual [1, 1]);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);
            Assert.AreEqual (expected [2, 0], actual [2, 0]);
            Assert.AreEqual (expected [2, 1], actual [2, 1]);
            Assert.AreEqual (expected [2, 2], actual [2, 2]);
        }

        [TestMethod ()]
        public void opMulTest_MatrixScalar ()
        {
            Matrix3 m = new Matrix3 (68, 40, 98, 22, 64, 80, 22, 83, 60);
            double  coefficient = 4;

            Matrix3 expected = new Matrix3 (272, 160, 392, 88, 256, 320, 88, 332, 240);

            Matrix3 actual = m * coefficient;

            Assert.AreEqual (expected [0, 0], actual [0, 0]);
            Assert.AreEqual (expected [0, 1], actual [0, 1]);
            Assert.AreEqual (expected [0, 2], actual [0, 2]);
            Assert.AreEqual (expected [1, 0], actual [1, 0]);
            Assert.AreEqual (expected [1, 1], actual [1, 1]);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);
            Assert.AreEqual (expected [2, 0], actual [2, 0]);
            Assert.AreEqual (expected [2, 1], actual [2, 1]);
            Assert.AreEqual (expected [2, 2], actual [2, 2]);
        }

        [TestMethod ()]
        public void opMulTest_ScalarMatrix ()
        {
            Matrix3 m = new Matrix3 (68, 40, 98, 22, 64, 80, 22, 83, 60);
            double  coefficient = -5;

            Matrix3 expected = new Matrix3 (-340, -200, -490, -110, -320, -400, -110, -415, -300);

            Matrix3 actual = coefficient * m;

            Assert.AreEqual (expected [0, 0], actual [0, 0]);
            Assert.AreEqual (expected [0, 1], actual [0, 1]);
            Assert.AreEqual (expected [0, 2], actual [0, 2]);
            Assert.AreEqual (expected [1, 0], actual [1, 0]);
            Assert.AreEqual (expected [1, 1], actual [1, 1]);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);
            Assert.AreEqual (expected [2, 0], actual [2, 0]);
            Assert.AreEqual (expected [2, 1], actual [2, 1]);
            Assert.AreEqual (expected [2, 2], actual [2, 2]);
        }

        [TestMethod ()]
        public void opDivTest ()
        {
            Matrix3 m = new Matrix3 (68, 40, 98, 22, 64, 80, 22, 83, 60);
            double  coefficient = 8;

            Matrix3 expected = new Matrix3 (8.5, 5, 12.25, 2.75, 8, 10, 2.75, 10.375, 7.5);

            Matrix3 actual = m / coefficient;

            Assert.AreEqual (expected [0, 0], actual [0, 0]);
            Assert.AreEqual (expected [0, 1], actual [0, 1]);
            Assert.AreEqual (expected [0, 2], actual [0, 2]);
            Assert.AreEqual (expected [1, 0], actual [1, 0]);
            Assert.AreEqual (expected [1, 1], actual [1, 1]);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);
            Assert.AreEqual (expected [2, 0], actual [2, 0]);
            Assert.AreEqual (expected [2, 1], actual [2, 1]);
            Assert.AreEqual (expected [2, 2], actual [2, 2]);
        }

        [TestMethod ()]
        public void opMulTest_MatrixVector ()
        {
            Matrix3 m = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            Vector3 v = new Vector3 (8, 13, 21);

            Vector expected = new Vector (160, 472, 866);

            Vector actual = m * v;

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1]);
            Assert.AreEqual (expected [2], actual [2]);
        }

        [TestMethod ()]
        public void opMulTest_VectorMatrix ()
        {
            Vector3 v = new Vector3 (8, 13, 21);
            Matrix3 m = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            
            Vector expected = new Vector (464, 566, 692);

            Vector actual = v * m;

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1]);
            Assert.AreEqual (expected [2], actual [2]);
        }

        [TestMethod ()]
        public void opMulTest_MatrixMatrix ()
        {
            Matrix3 m1 = new Matrix3 (0, 4, 6, 9, 3, 2, 5, 9, 0);
            Matrix3 m2 = new Matrix3 (1, 8, 0, 3, 5, 4, 3, 5, 0);

            Matrix3 expected = new Matrix3 (30, 50, 16, 24, 97, 12, 32, 85, 36);

            Matrix3 actual = m1 * m2;

            Assert.AreEqual (expected [0, 0], actual [0, 0]);
            Assert.AreEqual (expected [0, 1], actual [0, 1]);
            Assert.AreEqual (expected [0, 2], actual [0, 2]);
            Assert.AreEqual (expected [1, 0], actual [1, 0]);
            Assert.AreEqual (expected [1, 1], actual [1, 1]);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);
            Assert.AreEqual (expected [2, 0], actual [2, 0]);
            Assert.AreEqual (expected [2, 1], actual [2, 1]);
            Assert.AreEqual (expected [2, 2], actual [2, 2]);
        }
    }
}