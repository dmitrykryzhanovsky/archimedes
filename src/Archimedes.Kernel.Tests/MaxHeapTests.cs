using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class MaxHeapTests
    {
        [TestMethod ()]
        public void MaxHeapTest_ConstructorByDefault ()
        {
            MaxHeap<int> heap = new MaxHeap<int> ();

            List<int> expectedList = new List<int> ();

            Assert.AreEqual (true, expectedList.Equals<int> (heap.Items));
            Assert.AreEqual ( 0, heap.HeapSize);
            Assert.AreEqual (-1, heap.FirstLeafIndex);
        }

        [TestMethod ()]
        public void MaxHeapTest_OnlyItem ()
        {
            MaxHeap<int> heap = new MaxHeap<int> (42);

            List<int> expectedList = new List<int> { 42 };

            Assert.AreEqual (true, expectedList.Equals<int> (heap.Items));
            Assert.AreEqual (1, heap.HeapSize);
            Assert.AreEqual (0, heap.FirstLeafIndex);
        }

        [TestMethod ()]
        public void MaxHeapTest_Array ()
        {
            MaxHeap<int> heap = new MaxHeap<int> (5, 3, 17, 10, 84, 19, 6, 22, 9);

            List<int> expectedList = new List<int> { 84, 22, 19, 10, 3, 17, 6, 5, 9 };

            Assert.AreEqual (true, expectedList.Equals<int> (heap.Items));
            Assert.AreEqual (9, heap.HeapSize);
            Assert.AreEqual (4, heap.FirstLeafIndex);
        }

        [TestMethod ()]
        public void MaxHeapTest_List ()
        {
            MaxHeap<int> heap = new MaxHeap<int> (new List<int> { 5, 3, 17, 10, 84, 19, 6, 22, 9 });

            List<int> expectedList = new List<int> { 84, 22, 19, 10, 3, 17, 6, 5, 9 };

            Assert.AreEqual (true, expectedList.Equals<int> (heap.Items));
            Assert.AreEqual (9, heap.HeapSize);
            Assert.AreEqual (4, heap.FirstLeafIndex);
        }
    }
}