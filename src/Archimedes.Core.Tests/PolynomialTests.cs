using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class PolynomialTests
    {
        [TestMethod ()]
        public void ComputeTest ()
        {
            double    x = -2;
            double [] a = new double [] { 3, -5, 8, -13, 21 };

            double expected = 485;

            double actual = Polynomial.Compute (x, a);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComputeSquareTest ()
        {
            double    x = -2;
            double [] a = new double [] { 3, -5, 8 };

            double expected = 45;

            double actual = Polynomial.ComputeSquare (x, a);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComputeCubeTest ()
        {
            double    x = -2;
            double [] a = new double [] { 3, -5, 8, -13 };

            double expected = 149;

            double actual = Polynomial.ComputeCube (x, a);

            Assert.AreEqual (expected, actual);
        }
    }
}