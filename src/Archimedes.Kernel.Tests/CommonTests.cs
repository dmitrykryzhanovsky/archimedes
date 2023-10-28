using Archimedes;

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

        [TestMethod ()]
        public void SwapTest_TwoValues ()
        {
            int x = 42, y = 73;

            Common.Swap (ref x, ref y);

            Assert.AreEqual (73, x);
            Assert.AreEqual (42, y);
        }

        [TestMethod ()]
        public void SwapTest_ItemsInArray ()
        {
            int [] array = new int [] { 2, 3, 5, 8, 13 };

            int index1 = 1, index2 = 3;

            array.Swap (index1, index2);

            Assert.AreEqual (2, array [0]);
            Assert.AreEqual (8, array [1]);
            Assert.AreEqual (5, array [2]);
            Assert.AreEqual (3, array [3]);
            Assert.AreEqual (13, array [4]);
        }
    }
}