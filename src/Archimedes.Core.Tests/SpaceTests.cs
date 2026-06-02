using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class SpaceTests
    {
        [TestMethod ()]
        public void CheckRTest_Negative ()
        {
            double r = -1.0;

            bool wasException = false;

            try
            {
                Space.CheckR (r);
            }

            catch (ArgumentOutOfRangeException)
            {
                wasException = true;
            }

            Assert.IsTrue (wasException);
        }

        [TestMethod ()]
        public void CheckRTest_Zero ()
        {
            double r = 0.0;

            bool wasException = false;

            try
            {
                Space.CheckR (r);
            }

            catch (ArgumentOutOfRangeException)
            {
                wasException = true;
            }

            Assert.IsFalse (wasException);
        }

        [TestMethod ()]
        public void CheckRTest_Positive ()
        {
            double r = 1.0;

            bool wasException = false;

            try
            {
                Space.CheckR (r);
            }

            catch (ArgumentOutOfRangeException)
            {
                wasException = true;
            }

            Assert.IsFalse (wasException);
        }
    }
}