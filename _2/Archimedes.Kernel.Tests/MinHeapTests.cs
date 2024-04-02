using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class MinHeapTests
    {
        [TestMethod ()]
        public void MinHeapTest_ConstructorByDefault ()
        {
            MinHeap<int> heap = new MinHeap<int> ();

            List<int> expectedList = new List<int> ();

            Assert.AreEqual (true, expectedList.Equals<int> (heap.Items));
            Assert.AreEqual ( 0, heap.HeapSize);
            Assert.AreEqual (-1, heap.FirstLeafIndex);
        }

        [TestMethod ()]
        public void MinHeapTest_OnlyItem ()
        {
            MinHeap<int> heap = new MinHeap<int> (42);

            List<int> expectedList = new List<int> { 42 };

            Assert.AreEqual (true, expectedList.Equals<int> (heap.Items));
            Assert.AreEqual (1, heap.HeapSize);
            Assert.AreEqual (0, heap.FirstLeafIndex);
        }

        [TestMethod ()]
        public void MinHeapTest_Array ()
        {
            MinHeap<int> heap = new MinHeap<int> (5, 3, 17, 10, 84, 19, 6, 22, 9);

            List<int> expectedList = new List<int> { 3, 5, 6, 9, 84, 19, 17, 22, 10 };

            Assert.AreEqual (true, expectedList.Equals<int> (heap.Items));
            Assert.AreEqual (9, heap.HeapSize);
            Assert.AreEqual (4, heap.FirstLeafIndex);
        }

        [TestMethod ()]
        public void MinHeapTestt_List ()
        {
            MinHeap<int> heap = new MinHeap<int> (new List<int> { 5, 3, 17, 10, 84, 19, 6, 22, 9 });

            List<int> expectedList = new List<int> { 3, 5, 6, 9, 84, 19, 17, 22, 10 };

            Assert.AreEqual (true, expectedList.Equals<int> (heap.Items));
            Assert.AreEqual (9, heap.HeapSize);
            Assert.AreEqual (4, heap.FirstLeafIndex);
        }
    }
}