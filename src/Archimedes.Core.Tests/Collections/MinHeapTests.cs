using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class MinHeapTests
    {
        [TestMethod ()]
        public void MinHeapTest_TwoLists ()
        {
            List<int> keyList   = new List<int> { 68, 43, 98, 22, 64, 80, 22, 83, 60, 24 };
            List<int> valueList = new List<int> {  2,  3,  5,  7, 11, 13, 17, 19, 23, 29 };

            MinHeap<int, int> heap = new MinHeap<int, int> (keyList, valueList);

            Assert.AreEqual ((22,  7), heap [0]);
            Assert.AreEqual ((24, 29), heap [1]);
            Assert.AreEqual ((22, 17), heap [2]);
            Assert.AreEqual ((43,  3), heap [3]);
            Assert.AreEqual ((64, 11), heap [4]);
            Assert.AreEqual ((80, 13), heap [5]);
            Assert.AreEqual ((98,  5), heap [6]);
            Assert.AreEqual ((83, 19), heap [7]);
            Assert.AreEqual ((60, 23), heap [8]);
            Assert.AreEqual ((68,  2), heap [9]);
        }

        [TestMethod ()]
        public void MinHeapTest_TupleArray ()
        {
            MinHeap<int, int> heap = new MinHeap<int, int> ((68, 2), (43, 3), (98, 5), (22, 7), (64, 11), (80, 13), (22, 17), (83, 19), 
                (60, 23), (24, 29));

            Assert.AreEqual ((22,  7), heap [0]);
            Assert.AreEqual ((24, 29), heap [1]);
            Assert.AreEqual ((22, 17), heap [2]);
            Assert.AreEqual ((43,  3), heap [3]);
            Assert.AreEqual ((64, 11), heap [4]);
            Assert.AreEqual ((80, 13), heap [5]);
            Assert.AreEqual ((98,  5), heap [6]);
            Assert.AreEqual ((83, 19), heap [7]);
            Assert.AreEqual ((60, 23), heap [8]);
            Assert.AreEqual ((68,  2), heap [9]);
        }
    }
}