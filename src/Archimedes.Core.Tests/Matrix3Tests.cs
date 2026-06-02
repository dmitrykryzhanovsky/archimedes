using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Matrix3Tests
    {
        [TestMethod ()]
        public void HeightTest ()
        {
            Matrix3 m = new Matrix3 ( 2,  3,  5, 
                                      7, 11, 13, 
                                     17, 19, 23);

            Assert.AreEqual (3, m.Height);
        }

        [TestMethod ()]
        public void WidthTest ()
        {
            Matrix3 m = new Matrix3 ( 2,  3,  5,
                                      7, 11, 13,
                                     17, 19, 23);

            Assert.AreEqual (3, m.Width);
        }

        [TestMethod ()]
        public void Matrix3Test_Items ()
        {
            Matrix3 m = new Matrix3 ( 2,  3,  5,
                                      7, 11, 13,
                                     17, 19, 23);

            Assert.AreEqual ( 3, m.Height);
            Assert.AreEqual ( 3, m.Width);
            Assert.AreEqual ( 2, m [0, 0]);
            Assert.AreEqual ( 5, m [0, 2]);
            Assert.AreEqual (11, m [1, 1]);
            Assert.AreEqual (17, m [2, 0]);
            Assert.AreEqual (23, m [2, 2]);
        }

        [TestMethod ()]
        public void Matrix3Test_Copying ()
        {
            Matrix3 m1 = new Matrix3 ( 2,  3,  5,
                                       7, 11, 13,
                                      17, 19, 23);
            Matrix3 m2 = new Matrix3 (m1);

            Assert.AreEqual ( 3, m2.Height);
            Assert.AreEqual ( 3, m2.Width);
            Assert.AreEqual ( 2, m2 [0, 0]);
            Assert.AreEqual ( 5, m2 [0, 2]);
            Assert.AreEqual (11, m2 [1, 1]);
            Assert.AreEqual (17, m2 [2, 0]);
            Assert.AreEqual (23, m2 [2, 2]);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Matrix3 m1 = new Matrix3 ( 2,  3,  5,
                                       7, 11, 13,
                                      17, 19, 23);
            Matrix3 m2 = (Matrix3)m1.Clone ();

            Assert.AreEqual ( 3, m2.Height);
            Assert.AreEqual ( 3, m2.Width);
            Assert.AreEqual ( 2, m2 [0, 0]);
            Assert.AreEqual ( 5, m2 [0, 2]);
            Assert.AreEqual (11, m2 [1, 1]);
            Assert.AreEqual (17, m2 [2, 0]);
            Assert.AreEqual (23, m2 [2, 2]);
        }

        [TestMethod ()]
        public void EqualsTest_Matrix3_ItemsNotEqual ()
        {
            Matrix3 m1 = new Matrix3 ( 2,  3,  5,
                                       7, 11, 13,
                                      17, 19, 23);
            Matrix3 m2 = new Matrix3 ( 2,  3,  5, 
                                       8, 13, 21, 
                                      34, 55, 89);

            bool expected = false;

            bool actual = m1.Equals (m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Matrix3_ItemsEqual ()
        {
            Matrix3 m1 = new Matrix3 ( 2,  3,  5,
                                       7, 11, 13,
                                      17, 19, 23);
            Matrix3 m2 = new Matrix3 ( 2,  3,  5,
                                       7, 11, 13,
                                      17, 19, 23);

            bool expected = true;

            bool actual = m1.Equals (m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Matrix_SizeNotEqual ()
        {
            Matrix3 m1 = new Matrix3 ( 2,  3,  5,
                                       7, 11, 13,
                                      17, 19, 23);
            Matrix  m2 = new Matrix  (2, 3, 2, 3, 5, 7, 11, 13);            

            bool expected = false;

            bool actual = m2.Equals (m1);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Matrix_SizeEqual_ItemsNotEqual ()
        {
            Matrix3 m1 = new Matrix3 ( 2,  3,  5,
                                       7, 11, 13,
                                      17, 19, 23);
            Matrix  m2 = new Matrix  (3, 3, 
                                       2, 3, 5,
                                       8, 13, 21,
                                      34, 55, 89);

            bool expected = false;

            bool actual = m2.Equals (m1);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Matrix_SizeEqual_ItemsEqual ()
        {
            Matrix3 m1 = new Matrix3 ( 2,  3,  5,
                                       7, 11, 13,
                                      17, 19, 23);
            Matrix  m2 = new Matrix  (3, 3, 
                                       2,  3,  5,
                                       7, 11, 13,
                                      17, 19, 23);

            bool expected = true;

            bool actual = m2.Equals (m1);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest_ItemsNotEqual ()
        {
            Matrix3 m1 = new Matrix3 ( 2,  3,  5,
                                       7, 11, 13,
                                      17, 19, 23);
            Matrix3 m2 = new Matrix3 ( 2,  3,  5,
                                       8, 13, 21,
                                      34, 55, 89);

            bool expected = false;

            bool actual = (m1 == m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest_ItemsEqual ()
        {
            Matrix3 m1 = new Matrix3 ( 2,  3,  5,
                                       7, 11, 13,
                                      17, 19, 23);
            Matrix3 m2 = new Matrix3 ( 2,  3,  5,
                                       7, 11, 13,
                                      17, 19, 23);

            bool expected = true;

            bool actual = (m1 == m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest_ItemsNotEqual ()
        {
            Matrix3 m1 = new Matrix3 ( 2,  3,  5,
                                       7, 11, 13,
                                      17, 19, 23);
            Matrix3 m2 = new Matrix3 ( 2,  3,  5,
                                       8, 13, 21,
                                      34, 55, 89);

            bool expected = true;

            bool actual = (m1 != m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest_ItemsEqual ()
        {
            Matrix3 m1 = new Matrix3 ( 2,  3,  5,
                                       7, 11, 13,
                                      17, 19, 23);
            Matrix3 m2 = new Matrix3 ( 2,  3,  5,
                                       7, 11, 13,
                                      17, 19, 23);

            bool expected = false;

            bool actual = (m1 != m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Matrix3 m1 = new Matrix3 ( 2,  3,  5,
                                       7, 11, 13,
                                      17, 19, 23);
            Matrix3 m2 = new Matrix3 ( 2,  3,  5,
                                       8, 13, 21,
                                      34, 55, 89);

            Matrix3 expected = new Matrix3 ( 4,  6,  10, 
                                            15, 24,  34, 
                                            51, 74, 112);

            Matrix actual = m1 + m2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opSubtractTest ()
        {
            Matrix3 m1 = new Matrix3 ( 2,  3,  5,
                                       7, 11, 13,
                                      17, 19, 23);
            Matrix3 m2 = new Matrix3 ( 2,  3,  5,
                                       8, 13, 21,
                                      34, 55, 89);

            Matrix3 expected = new Matrix3 (  0,   0,   0, 
                                             -1,  -2,  -8, 
                                            -17, -36, -66);

            Matrix actual = m1 - m2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNegateTest ()
        {
            Matrix3 m = new Matrix3 ( 2,  3,  5,
                                      7, 11, 13,
                                     17, 19, 23);

            Matrix3 expected = new Matrix3 ( -2,  -3,  -5,
                                             -7, -11, -13,
                                            -17, -19, -23);

            Matrix3 actual = -m;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_Matrix3ByCoefficient ()
        {
            Matrix3 m           = new Matrix3 ( 2, 3, 5,
                                                7, 11, 13,
                                               17, 19, 23);
            double  coefficient = 3;

            Matrix3 expected = new Matrix3 ( 6,  9, 15, 
                                            21, 33, 39, 
                                            51, 57, 69);

            Matrix3 actual = m * coefficient;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_CoefficientByMatrix3 ()
        {
            Matrix3 m           = new Matrix3 ( 2,  3,  5,
                                                7, 11, 13,
                                               17, 19, 23);
            double  coefficient = 3;

            Matrix3 expected = new Matrix3 ( 6,  9, 15,
                                            21, 33, 39,
                                            51, 57, 69);

            Matrix3 actual = coefficient * m;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opDivideTest ()
        {
            Matrix3 m           = new Matrix3 ( 2,  3,  5,
                                                7, 11, 13,
                                               17, 19, 23);
            double  coefficient = 4.0;

            Matrix3 expected = new Matrix3 (0.5,  0.75, 1.25, 
                                            1.75, 2.75, 3.25, 
                                            4.25, 4.75, 5.75);

            Matrix3 actual = m / coefficient;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_Matrix3Vector2Product ()
        {
            Matrix3 m1 = new Matrix3 ( 2,  3,  5,
                                       7, 11, 13,
                                      17, 19, 23);
            Vector3 v2 = new Vector3 (13, 21, 34);

            Vector3 expected = new Vector3 (259, 764, 1402);

            Vector3 actual = m1 * v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_Vector2Matrix3Product ()
        {
            Vector3 v1 = new Vector3 (13, 21, 34);
            Matrix3 m2 = new Matrix3 ( 2,  3,  5,
                                       7, 11, 13,
                                      17, 19, 23);
            
            Vector3 expected = new Vector3 (751, 916, 1120);

            Vector3 actual = v1 * m2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_Matrix3Matrix3Product ()
        {
            Matrix3 m1 = new Matrix3 ( 2,  3,  5,
                                       7, 11, 13,
                                      17, 19, 23);
            Matrix3 m2 = new Matrix3 ( 2,  3,  5,
                                       8, 13, 21,
                                      34, 55, 89);

            Matrix3 expected = new Matrix3 (198,  320,  518, 
                                            544,  879, 1423, 
                                            968, 1563, 2531);

            Matrix3 actual = m1 * m2;

            Assert.AreEqual (expected, actual);
        }
    }
}