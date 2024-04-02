using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class TrigonometryTests
    {
        [TestMethod ()]
        public void DegToRadTest ()
        {
            double x = 42.0;

            double expected = 0.73303828583761842;

            double actual = Trigonometry.DegToRad (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MinToRadTest ()
        {
            double x = 42.0;

            double expected = 0.012217304763960307;

            double actual = Trigonometry.MinToRad (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SecToRadTest ()
        {
            double x = 42.0;

            double expected = 0.00020362174606600512;

            double actual = Trigonometry.SecToRad (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreNormalizedAnglesEqualTest_LiterallyEqual ()
        {
            double x = 1.0;
            double y = 1.0;

            bool actual = true;

            bool exected = Trigonometry.AreNormalizedAnglesEqual (x, y);

            Assert.AreEqual (exected, actual);
        }

        [TestMethod ()]
        public void AreNormalizedAnglesEqualTest_Equal_plus2PI ()
        {
            double x = 1.0;
            double y = 7.2831853071795865;

            bool actual = true;

            bool exected = Trigonometry.AreNormalizedAnglesEqual (x, y);

            Assert.AreEqual (exected, actual);
        }

        [TestMethod ()]
        public void AreNormalizedAnglesEqualTest_Equal_plus4PI ()
        {
            double x = 1.0;
            double y = 13.566370614359173;

            bool actual = true;

            bool exected = Trigonometry.AreNormalizedAnglesEqual (x, y);

            Assert.AreEqual (exected, actual);
        }

        [TestMethod ()]
        public void AreNormalizedAnglesEqualTest_Equal_minus2PI ()
        {
            double x =  1.0;
            double y = -5.2831853071795865;

            bool actual = true;

            bool exected = Trigonometry.AreNormalizedAnglesEqual (x, y);

            Assert.AreEqual (exected, actual);
        }

        [TestMethod ()]
        public void AreNormalizedAnglesEqualTest_Equal_minus4PI ()
        {
            double x =   1.0;
            double y = -11.566370614359173;

            bool actual = true;

            bool exected = Trigonometry.AreNormalizedAnglesEqual (x, y);

            Assert.AreEqual (exected, actual);
        }

        [TestMethod ()]
        public void AreNormalizedAnglesEqualTest_NotEqual_plusPI ()
        {
            double x = 1.0;
            double y = 4.1415926535897932;

            bool actual = false;

            bool exected = Trigonometry.AreNormalizedAnglesEqual (x, y);

            Assert.AreEqual (exected, actual);
        }

        [TestMethod ()]
        public void AreNormalizedAnglesEqualTest_NotEqual_minusPI ()
        {
            double x =  1.0;
            double y = -2.1415926535897932;

            bool actual = false;

            bool exected = Trigonometry.AreNormalizedAnglesEqual (x, y);

            Assert.AreEqual (exected, actual);
        }
    }
}