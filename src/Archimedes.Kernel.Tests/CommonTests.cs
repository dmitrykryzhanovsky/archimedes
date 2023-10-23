using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class CommonTests
    {
        [TestMethod ()]
        public void PairMinMaxTest_MinMax ()
        {
            int a = 42, b = 73;

            (int min, int max) expected = (42, 73);

            (int min, int max) actual = Common.PairMinMax (a, b);

            Assert.AreEqual (expected.min, actual.min);
            Assert.AreEqual (expected.max, actual.max);
        }

        [TestMethod ()]
        public void PairMinMaxTest_MaxMin ()
        {
            int a = 73, b = 42;

            (int min, int max) expected = (42, 73);

            (int min, int max) actual = Common.PairMinMax (a, b);

            Assert.AreEqual (expected.min, actual.min);
            Assert.AreEqual (expected.max, actual.max);
        }

        [TestMethod ()]
        public void PairMinMaxTest_Equal ()
        {
            int a = 42, b = 42;

            (int min, int max) expected = (42, 42);

            (int min, int max) actual = Common.PairMinMax (a, b);

            Assert.AreEqual (expected.min, actual.min);
            Assert.AreEqual (expected.max, actual.max);
        }
    }
}