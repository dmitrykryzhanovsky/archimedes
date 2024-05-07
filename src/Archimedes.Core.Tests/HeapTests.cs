using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class HeapTests
    {
        [TestMethod ()]
        public void Indexer_Get ()
        {
            List<int> list = new List<int> { 60, 37, 27, 20, 14, 10 };

            MaxHeap<int> heap = new MaxHeap<int> (list);

            Assert.AreEqual (20, heap [3]);
        }

        [TestMethod ()]
        public void InsertTest_MaxHeap ()
        {
            MaxHeap<int> heap = new MaxHeap<int> (72, 7, 27, 61, 83, 47, 1);

            heap.Insert (73);

            Assert.AreEqual (83, heap [0]);
            Assert.AreEqual (73, heap [1]);
            Assert.AreEqual (47, heap [2]);
            Assert.AreEqual (72, heap [3]);
            Assert.AreEqual ( 7, heap [4]);
            Assert.AreEqual (27, heap [5]);
            Assert.AreEqual ( 1, heap [6]);
            Assert.AreEqual (61, heap [7]);
        }

        [TestMethod ()]
        public void InsertTest_MinHeap ()
        {
            MinHeap<int> heap = new MinHeap<int> (72, 7, 27, 61, 83, 47, 1);

            heap.Insert (36);

            Assert.AreEqual ( 1, heap [0]);
            Assert.AreEqual ( 7, heap [1]);
            Assert.AreEqual (27, heap [2]);
            Assert.AreEqual (36, heap [3]);
            Assert.AreEqual (83, heap [4]);
            Assert.AreEqual (47, heap [5]);
            Assert.AreEqual (72, heap [6]);
            Assert.AreEqual (61, heap [7]);
        }
    }
}