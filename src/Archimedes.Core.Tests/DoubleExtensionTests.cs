using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class DoubleExtensionTests
    {
        [TestMethod ()]
        public void FractionTest_Zero ()
        {
            double x = 0.0;

            double expected = 0.0;

            double actual = x.Fraction ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void FractionTest_PositiveFraction ()
        {
            double x = 7.3;

            double expected = 0.3;

            double actual = x.Fraction ();

            Assert.AreEqual (expected, actual, 1.0e-15);
        }

        [TestMethod ()]
        public void FractionTest_PositiveInteger ()
        {
            double x = 8.0;

            double expected = 0.0;

            double actual = x.Fraction ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void FractionTest_NegativeFraction ()
        {
            double x = -7.3;

            double expected = 0.7;

            double actual = x.Fraction ();

            Assert.AreEqual (expected, actual, 1.0e-15);
        }

        [TestMethod ()]
        public void FractionTest_NegativeInteger ()
        {
            double x = -8.0;

            double expected = 0.0;

            double actual = x.Fraction ();

            Assert.AreEqual (expected, actual);
        }
    }
}