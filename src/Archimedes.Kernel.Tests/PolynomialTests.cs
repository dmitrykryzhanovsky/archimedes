using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class PolynomialTests
    {
        [TestMethod ()]
        public void ComputeTest ()
        {
            double [] a = new double [] { 2, -3, 5, 8, -13 };
            double    x = 2;

            double expected = -128.0;

            double actual = Polynomial.Compute (a, x);

            Assert.AreEqual (expected, actual);
        }
    }
}