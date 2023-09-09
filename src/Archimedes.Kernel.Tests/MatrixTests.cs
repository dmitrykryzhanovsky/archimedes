using Microsoft.VisualStudio.TestTools.UnitTesting;

using Archimedes;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class MatrixTests
    {
        [TestMethod ()]
        public void Constructor_ByDimensionsTest ()
        {
            Matrix m = new Matrix (5, 8);

            int expectedHeight = 5;
            int expectedWidth = 8;

            int actualHeight = m.Height;
            int actualWidth = m.Width;

            Assert.AreEqual (expectedHeight, actualHeight);
            Assert.AreEqual (expectedWidth, actualWidth);
        }

        [TestMethod ()]
        public void Constructor_ByArray2DTest ()
        {
            double [,] array = new double [,] { { 2, 3, 5 }, { 8, 13, 21 } };

            Matrix m = new Matrix (array);

            Assert.AreEqual (2, m.Height);
            Assert.AreEqual (3, m.Width);
            Assert.AreEqual (2, m [0, 0]);
            Assert.AreEqual (3, m [0, 1]);
            Assert.AreEqual (5, m [0, 2]);
            Assert.AreEqual (8, m.Items [1, 0]);
            Assert.AreEqual (13, m.Items [1, 1]);
            Assert.AreEqual (21, m.Items [1, 2]);
        }

        [TestMethod ()]
        public void Constructor_ByArray1DTest ()
        {
            Matrix m = new Matrix (2, 2, 3, 5, 8, 13, 21);

            Assert.AreEqual (2, m.Height);
            Assert.AreEqual (3, m.Width);
            Assert.AreEqual (2, m [0, 0]);
            Assert.AreEqual (3, m [0, 1]);
            Assert.AreEqual (5, m [0, 2]);
            Assert.AreEqual (8, m.Items [1, 0]);
            Assert.AreEqual (13, m.Items [1, 1]);
            Assert.AreEqual (21, m.Items [1, 2]);
        }
    }
}