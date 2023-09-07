using Microsoft.VisualStudio.TestTools.UnitTesting;

using Archimedes;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class MatrixTests
    {
        [TestMethod ()]
        public void ConstructorByDimensionsTest ()
        {
            Matrix m = new Matrix (5, 8);

            int expectedHeight = 5;
            int expectedWidth = 8;

            int actualHeight = m.Height;
            int actualWidth = m.Width;

            Assert.AreEqual (expectedHeight, actualHeight);
            Assert.AreEqual (expectedWidth, actualWidth);
        }
    }
}