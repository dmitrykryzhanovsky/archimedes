using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class KitTests
    {
        [TestMethod ()]
        public void SwapTest ()
        {
            int a = 42;
            int b = 73;

            int expectedA = 73;
            int expectedB = 42;

            Kit.Swap (ref a, ref b);

            Assert.AreEqual (expectedA, a);
            Assert.AreEqual (expectedB, b);
        }

        [TestMethod ()]
        public void SwapTest_ArrayItems ()
        {
            int [] array  = new int [] { 2, 3, 5, 8, 13, 21 };
            int    index1 = 2;
            int    index2 = 4;

            int [] expectedArray = new int [] { 2, 3, 13, 8, 5, 21 };

            array.Swap (index1, index2);

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }

        [TestMethod ()]
        public void SwapTest_ListItems ()
        {
            List<int> list   = new List<int> { 2, 3, 5, 8, 13, 21 };
            int       index1 = 2;
            int       index2 = 4;

            List<int> expecteList = new List<int> { 2, 3, 13, 8, 5, 21 };

            list.Swap (index1, index2);

            Assert.AreEqual (true, expecteList.Equals<int> (list));
        }
    }
}