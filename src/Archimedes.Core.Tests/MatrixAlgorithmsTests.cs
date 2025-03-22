using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class MatrixAlgorithmsTests
    {
        [TestMethod ()]
        public void StandardMultiplicationTest ()
        {
            double [,] a = new double [,] { { 2, 3, 5, 8 }, { 13, 21, 34, 55 } };
            double [,] b = new double [,] { { 2, 3, 5 }, { 7, 11, 13 }, { 17, 19, 23 }, { 29, 31, 37 } };
            
            int height     = 2;
            int commonSize = 4;
            int width      = 3;

            double [,] expected = new double [,] { { 342, 382, 460 }, { 2346, 2621, 3155 } };

            double [,] actual = MatrixAlgorithms.StandardMultiplication (a, b, height, commonSize, width);

            Assert.AreEqual (expected [0, 0], actual [0, 0]);
            Assert.AreEqual (expected [0, 1], actual [0, 1]);
            Assert.AreEqual (expected [0, 2], actual [0, 2]);

            Assert.AreEqual (expected [1, 0], actual [1, 0]);
            Assert.AreEqual (expected [1, 1], actual [1, 1]);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);
        }
    }
}