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
        public void CloneTest ()
        {
            Assert.Fail ();
        }
    }
}