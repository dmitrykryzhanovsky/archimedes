using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class PolynomialAlgorithmTests
    {
        [TestMethod ()]
        public void ComputeTest ()
        {
            double    x = -2;
            double [] a = new double [] { 3, -5, 8, -13, 21 };

            double expected = 485;

            double actual = PolynomialAlgorithm.Compute (x, a);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void HornerTest ()
        {
            double    x = -2;
            double [] a = new double [] { 3, -5, 8, -13, 21 };

            double expected = 485;

            double actual = PolynomialAlgorithm.Horner (x, a);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComputeSquareTest ()
        {
            double    x = -2;
            double [] a = new double [] { 3, -5, 8 };

            double expected = 45;

            double actual = PolynomialAlgorithm.ComputeSquare (x, a);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComputeCubeTest ()
        {
            double    x = -2;
            double [] a = new double [] { 3, -5, 8, -13 };

            double expected = 149;

            double actual = PolynomialAlgorithm.ComputeCube (x, a);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComputeNoConstantTermTest ()
        {
            double    x = -2;
            double [] a = new double [] { 3, -5, 8, -13, 21 };

            double expected = 482;

            double actual = PolynomialAlgorithm.ComputeNoConstantTerm (x, a);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void HornerNoConstantTermTest ()
        {
            double    x = -2;
            double [] a = new double [] { 3, -5, 8, -13, 21 };

            double expected = 482;

            double actual = PolynomialAlgorithm.HornerNoConstantTerm (x, a);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComputeSquareNoConstantTermTest ()
        {
            double    x = -2;
            double [] a = new double [] { 3, -5, 8 };

            double expected = 42;

            double actual = PolynomialAlgorithm.ComputeSquareNoConstantTerm (x, a);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComputeCubeNoConstantTermTest ()
        {
            double    x = -2;
            double [] a = new double [] { 3, -5, 8, -13 };

            double expected = 146;

            double actual = PolynomialAlgorithm.ComputeCubeNoConstantTerm (x, a);

            Assert.AreEqual (expected, actual);
        }
    }
}