using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class FloatExtensionTests
    {
        [TestMethod ()]
        public void IntFractionComponentsTest_PositiveInteger ()
        {
            double x = 42.0;

            (int integer, double fraction) = x.IntFractionComponents ();

            Assert.AreEqual (42, integer);
            Assert.AreEqual (0.0, fraction);
        }

        [TestMethod ()]
        public void IntFractionComponentsTest_PositiveReal ()
        {
            double x = 42.73;

            (int integer, double fraction) = x.IntFractionComponents ();

            Assert.AreEqual (42, integer);
            Assert.AreEqual (0.73, fraction, 1.0e-14);
        }

        [TestMethod ()]
        public void IntFractionComponentsTest_Zero ()
        {
            double x = 0.0;

            (int integer, double fraction) = x.IntFractionComponents ();

            Assert.AreEqual (0, integer);
            Assert.AreEqual (0.0, fraction);
        }

        [TestMethod ()]
        public void IntFractionComponentsTest_NegativeInteger ()
        {
            double x = -42.0;

            (int integer, double fraction) = x.IntFractionComponents ();

            Assert.AreEqual (-42, integer);
            Assert.AreEqual (0.0, fraction);
        }

        [TestMethod ()]
        public void IntFractionComponentsTest_NegativeReal ()
        {
            double x = -42.73;

            (int integer, double fraction) = x.IntFractionComponents ();

            Assert.AreEqual (-43, integer);
            Assert.AreEqual (0.27, fraction, 1.0e-14);
        }

        [TestMethod ()]
        public void FractionTest_PositiveInteger ()
        {
            double x = 42.0;

            Assert.AreEqual (0.0, x.Fraction ());
        }

        [TestMethod ()]
        public void FractionTest_PositiveReal ()
        {
            double x = 42.73;

            Assert.AreEqual (0.73, x.Fraction (), 1.0e-14);
        }

        [TestMethod ()]
        public void FractionTest_Zero ()
        {
            double x = 0.0;

            Assert.AreEqual (0.0, x.Fraction ());
        }

        [TestMethod ()]
        public void FractionTest_NegativeInteger ()
        {
            double x = -42.0;

            Assert.AreEqual (0.0, x.Fraction ());
        }

        [TestMethod ()]
        public void FractionTest_NegativeReal ()
        {
            double x = -42.73;

            Assert.AreEqual (0.27, x.Fraction (), 1.0e-14);
        }
    }
}