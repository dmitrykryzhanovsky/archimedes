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
            Matrix3 v1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            Matrix3 v2 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);

            Assert.IsTrue (v1.Equals (v2));
            Assert.IsTrue (v1 == v2);
            Assert.IsFalse (v1 != v2);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqual_ExceptOneItemMatches ()
        {
            Matrix3 v1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            Matrix3 v2 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 29);

            Assert.IsFalse (v1.Equals (v2));
            Assert.IsFalse (v1 == v2);
            Assert.IsTrue (v1 != v2);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqual_NoItemMatches ()
        {
            Matrix3 v1 = new Matrix3 (2,  3,  5,  7, 11, 13,  17,  19,  23);
            Matrix3 v2 = new Matrix3 (8, 13, 21, 34, 55, 89, 144, 233, 377);

            Assert.IsFalse (v1.Equals (v2));
            Assert.IsFalse (v1 == v2);
            Assert.IsTrue (v1 != v2);
        }
    }
}