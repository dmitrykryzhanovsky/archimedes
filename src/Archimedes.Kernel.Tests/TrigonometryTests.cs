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
    }
}