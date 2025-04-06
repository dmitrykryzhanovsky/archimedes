using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class MatrixTests
    {
        [TestMethod ()]
        public void IndexerTest_Get ()
        {
            Matrix m = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);

            Assert.AreEqual ( 2, m [0, 0]);
            Assert.AreEqual ( 3, m [0, 1]);
            Assert.AreEqual ( 5, m [0, 2]);
            Assert.AreEqual ( 7, m [1, 0]);
            Assert.AreEqual (11, m [1, 1]);
            Assert.AreEqual (13, m [1, 2]);
        }

        [TestMethod ()]
        public void IndexerTest_Set ()
        {
            Matrix m = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);

            m [1, 0] =  8;
            m [1, 1] = 13;
            m [1, 2] = 21;

            Assert.AreEqual ( 2, m [0, 0]);
            Assert.AreEqual ( 3, m [0, 1]);
            Assert.AreEqual ( 5, m [0, 2]);
            Assert.AreEqual ( 8, m [1, 0]);
            Assert.AreEqual (13, m [1, 1]);
            Assert.AreEqual (21, m [1, 2]);
        }

        [TestMethod ()]
        public void ItemsTest ()
        {
            Matrix m = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);

            double [,] actual = m.Items;

            Assert.AreEqual ( 2, actual [0, 0]);
            Assert.AreEqual ( 3, actual [0, 1]);
            Assert.AreEqual ( 5, actual [0, 2]);
            Assert.AreEqual ( 7, actual [1, 0]);
            Assert.AreEqual (11, actual [1, 1]);
            Assert.AreEqual (13, actual [1, 2]);
        }

        [TestMethod ()]
        public void HeightTest ()
        {
            Matrix m = new Matrix (3, 4, 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37);

            int expected = 3;

            int actual = m.Height;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void WidthTest ()
        {
            double [,] array = new double [,] { { 2, 3, 5 }, { 7, 11, 13 }, { 17, 19, 23 }, { 29, 31, 37 } };
            Matrix     m     = new Matrix (array);

            int expected = 3;

            int actual = m.Width;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MatrixTest_Array1D ()
        {
            Matrix m = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);

            Assert.AreEqual ( 2, m.Height);
            Assert.AreEqual ( 3, m.Width);
            Assert.AreEqual ( 2, m [0, 0]);
            Assert.AreEqual ( 3, m [0, 1]);
            Assert.AreEqual ( 5, m [0, 2]);
            Assert.AreEqual ( 7, m [1, 0]);
            Assert.AreEqual (11, m [1, 1]);
            Assert.AreEqual (13, m [1, 2]);
        }

        [TestMethod ()]
        public void MatrixTest_Array2D ()
        {
            double [,] array = new double [,] { { 2, 3, 5 }, { 7, 11, 13 } };
            Matrix     m     = new Matrix (array);

            Assert.AreEqual ( 2, m.Height);
            Assert.AreEqual ( 3, m.Width);
            Assert.AreEqual ( 2, m [0, 0]);
            Assert.AreEqual ( 3, m [0, 1]);
            Assert.AreEqual ( 5, m [0, 2]);
            Assert.AreEqual ( 7, m [1, 0]);
            Assert.AreEqual (11, m [1, 1]);
            Assert.AreEqual (13, m [1, 2]);
        }

        [TestMethod ()]
        public void MatrixTest_Matrix ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (m1);

            Assert.AreEqual ( 2, m2.Height);
            Assert.AreEqual ( 3, m2.Width);
            Assert.AreEqual ( 2, m2 [0, 0]);
            Assert.AreEqual ( 3, m2 [0, 1]);
            Assert.AreEqual ( 5, m2 [0, 2]);
            Assert.AreEqual ( 7, m2 [1, 0]);
            Assert.AreEqual (11, m2 [1, 1]);
            Assert.AreEqual (13, m2 [1, 2]);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = (Matrix)m1.Clone ();

            Assert.AreEqual ( 2, m2.Height);
            Assert.AreEqual ( 3, m2.Width);
            Assert.AreEqual ( 2, m2 [0, 0]);
            Assert.AreEqual ( 3, m2 [0, 1]);
            Assert.AreEqual ( 5, m2 [0, 2]);
            Assert.AreEqual ( 7, m2 [1, 0]);
            Assert.AreEqual (11, m2 [1, 1]);
            Assert.AreEqual (13, m2 [1, 2]);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqualDimensions_AllDifferent ()
        {
            Matrix m1 = new Matrix (2, 2, 2, 3, 5, 7);
            Matrix m2 = new Matrix (3, 3, 2, 3, 5, 7, 11, 13, 17, 19, 23);

            Assert.IsFalse (m1.Equals (m2));
            Assert.IsFalse (m1 == m2);
            Assert.IsTrue (m1 != m2);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqualDimensions_OneDifferent ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (3, 3, 2, 3, 5, 7, 11, 13, 17, 19, 23);

            Assert.IsFalse (m1.Equals (m2));
            Assert.IsFalse (m1 == m2);
            Assert.IsTrue (m1 != m2);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqualDimensions_Swapped ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (3, 2, 2, 3, 5, 7, 11, 13);

            Assert.IsFalse (m1.Equals (m2));
            Assert.IsFalse (m1 == m2);
            Assert.IsTrue (m1 != m2);
        }

        [TestMethod ()]
        public void EqualsTest_EqualDimensions_NotEqualItems ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (2, 3, 2, 3, 8, 7, 11, 13);

            Assert.IsFalse (m1.Equals (m2));
            Assert.IsFalse (m1 == m2);
            Assert.IsTrue (m1 != m2);
        }

        [TestMethod ()]
        public void EqualsTest_EqualDimensions_EqualItems ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);

            Assert.IsTrue (m1.Equals (m2));
            Assert.IsTrue (m1 == m2);
            Assert.IsFalse (m1 != m2);
        }
    }
}