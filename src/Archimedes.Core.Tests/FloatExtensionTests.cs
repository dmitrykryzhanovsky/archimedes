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

        [TestMethod ()]
        public void PhaseTest_Zero ()
        {
            double dividend = 0.0;
            double divisor  = 2.0;

            double expected = 0.0;

            double actual = dividend.Phase (divisor);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseTest_LoopPlusOne ()
        {
            double dividend = 1.5;
            double divisor  = 2.0;

            double expected = 1.5;

            double actual = dividend.Phase (divisor);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseTest_2 ()
        {
            double dividend = 2.0;
            double divisor  = 2.0;

            double expected = 0.0;

            double actual = dividend.Phase (divisor);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseTest_LoopPlusTwo ()
        {
            double dividend = 3.5;
            double divisor  = 2.0;

            double expected = 1.5;

            double actual = dividend.Phase (divisor);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseTest_4 ()
        {
            double dividend = 4.0;
            double divisor  = 2.0;

            double expected = 0.0;

            double actual = dividend.Phase (divisor);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseTest_LoopMinusOne ()
        {
            double dividend = -1.5;
            double divisor  =  2.0;

            double expected = 0.5;

            double actual = dividend.Phase (divisor);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseTest_Minus2 ()
        {
            double dividend = -2.0;
            double divisor  =  2.0;

            double expected = 0.0;

            double actual = dividend.Phase (divisor);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseTest_LoopMinusTwo ()
        {
            double dividend = -3.5;
            double divisor  =  2.0;

            double expected = 0.5;

            double actual = dividend.Phase (divisor);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseTest_Minus4 ()
        {
            double dividend = -4.0;
            double divisor  =  2.0;

            double expected = 0.0;

            double actual = dividend.Phase (divisor);

            Assert.AreEqual (expected, actual);
        }
    }
}