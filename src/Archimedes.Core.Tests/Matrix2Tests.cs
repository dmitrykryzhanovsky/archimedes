using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Matrix2Tests
    {
        [TestMethod ()]
        public void HeightTest ()
        {
            Matrix2 m = new Matrix2 (3, 4, 5, 8);

            int expected = 2;

            int actual = m.Height;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void WidthTest ()
        {
            Matrix2 m = new Matrix2 (3, 4, 5, 8);

            int expected = 2;

            int actual = m.Width;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Matrix2Test_FourItems ()
        {
            Matrix2 m = new Matrix2 (3, 4, 5, 8);

            Assert.AreEqual (2, m.Height);
            Assert.AreEqual (2, m.Width);
            Assert.AreEqual (3, m [0, 0]);
            Assert.AreEqual (4, m [0, 1]);
            Assert.AreEqual (5, m [1, 0]);
            Assert.AreEqual (8, m [1, 1]);
        }

        [TestMethod ()]
        public void Matrix2Test_Array1D ()
        {
            double [] array = new double [] { 3, 4, 5, 8 };
            Matrix2   m     = new Matrix2 (array);

            Assert.AreEqual (2, m.Height);
            Assert.AreEqual (2, m.Width);
            Assert.AreEqual (3, m [0, 0]);
            Assert.AreEqual (4, m [0, 1]);
            Assert.AreEqual (5, m [1, 0]);
            Assert.AreEqual (8, m [1, 1]);
        }

        [TestMethod ()]
        public void Matrix2Test_Array2D ()
        {
            double [,] array = new double [,] { { 3, 4 }, { 5, 8 } };
            Matrix2    m     = new Matrix2 (array);

            Assert.AreEqual (2, m.Height);
            Assert.AreEqual (2, m.Width);
            Assert.AreEqual (3, m [0, 0]);
            Assert.AreEqual (4, m [0, 1]);
            Assert.AreEqual (5, m [1, 0]);
            Assert.AreEqual (8, m [1, 1]);
        }

        [TestMethod ()]
        public void Matrix2Test_Matrix2 ()
        {
            Matrix2 m1 = new Matrix2 (3, 4, 5, 8);
            Matrix2 m2 = new Matrix2 (m1);

            Assert.AreEqual (2, m2.Height);
            Assert.AreEqual (2, m2.Width);
            Assert.AreEqual (3, m2 [0, 0]);
            Assert.AreEqual (4, m2 [0, 1]);
            Assert.AreEqual (5, m2 [1, 0]);
            Assert.AreEqual (8, m2 [1, 1]);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Matrix2 m1 = new Matrix2 (3, 4, 5, 8);
            Matrix2 m2 = (Matrix2)m1.Clone ();

            Assert.AreEqual (2, m2.Height);
            Assert.AreEqual (2, m2.Width);
            Assert.AreEqual (3, m2 [0, 0]);
            Assert.AreEqual (4, m2 [0, 1]);
            Assert.AreEqual (5, m2 [1, 0]);
            Assert.AreEqual (8, m2 [1, 1]);
        }

        [TestMethod ()]
        public void EqualsTest_Equal ()
        {
            Matrix2 m1 = new Matrix2 (3, 4, 5, 6);
            Matrix2 m2 = new Matrix2 (3, 4, 5, 6);

            Assert.IsTrue (m1.Equals (m2));
            Assert.IsTrue (m1 == m2);
            Assert.IsFalse (m1 != m2);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqual_OneItemMatches ()
        {
            Matrix2 m1 = new Matrix2 (3, 4, 5, 6);
            Matrix2 m2 = new Matrix2 (3, 7, 8, 9);

            Assert.IsFalse (m1.Equals (m2));
            Assert.IsFalse (m1 == m2);
            Assert.IsTrue (m1 != m2);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqual_NoItemMatches ()
        {
            Matrix2 m1 = new Matrix2 (3, 4, 5,  6);
            Matrix2 m2 = new Matrix2 (7, 8, 9, 10);

            Assert.IsFalse (m1.Equals (m2));
            Assert.IsFalse (m1 == m2);
            Assert.IsTrue (m1 != m2);
        }
    }
}