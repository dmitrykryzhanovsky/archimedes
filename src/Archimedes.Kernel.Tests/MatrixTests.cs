using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class MatrixTests
    {
        [TestMethod ()]
        public void IndexerTest_Get ()
        {
            Matrix m = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);

            Assert.AreEqual (13, m [1, 1]);
        }

        [TestMethod ()]
        public void IndexerTest_Set ()
        {
            Matrix m = new Matrix (3, 2, 2, 3, 5, 8, 13, 21);

            m [2, 1] = 31;

            Assert.AreEqual (31, m [2, 1]);
        }

        [TestMethod ()]
        public void HeightTest ()
        {
            Matrix m = new Matrix (2, 3);

            Assert.AreEqual (2, m.Height);
        }

        [TestMethod ()]
        public void WidthTest ()
        {
            Matrix m = new Matrix (2, 3);

            Assert.AreEqual (3, m.Width);
        }
    }
}