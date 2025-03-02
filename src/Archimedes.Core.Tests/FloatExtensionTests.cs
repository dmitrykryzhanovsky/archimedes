using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class FloatExtensionTests
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
        public void FractionTest_PositiveInteger ()
        {
            double x = 7.0;

            double expected = 0.0;

            double actual = x.Fraction ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void FractionTest_PositiveFraction ()
        {
            double x = 7.25;

            double expected = 0.25;

            double actual = x.Fraction ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void FractionTest_NegativeInteger ()
        {
            double x = -7.0;

            double expected = 0.0;

            double actual = x.Fraction ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void FractionTest_NegativeFraction ()
        {
            double x = -7.25;

            double expected = 0.75;

            double actual = x.Fraction ();

            Assert.AreEqual (expected, actual);
        }
    }
}