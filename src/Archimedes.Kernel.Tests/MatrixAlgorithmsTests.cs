using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class MatrixAlgorithmsTests
    {
        [TestMethod ()]
        public void O3MultiplicationTest ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (3, 1, 4, 6, 10);

            Matrix expected = new Matrix (2, 1, 76, 224);

            Matrix actual = MatrixAlgorithms.O3Multiplication (m1, m2);

            Assert.AreEqual (true, expected.Equals (actual));
        }
    }
}