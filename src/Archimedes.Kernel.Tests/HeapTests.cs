using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class HeapTests
    {
        [TestMethod ()]
        public void MaxHeapifyTest_Array ()
        {
            int [] array     = new int [] { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };
            int    firstLeaf = array.Length / 2;
            int    lastLeaf  = array.Length - 1;

            int [] expectedArray = new int [] { 27, 17, 10, 16, 13, 9, 1, 5, 7, 12, 4, 8, 3, 0 };

            array.MaxHeapify (2, firstLeaf, lastLeaf);

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }

        [TestMethod ()]
        public void MaxHeapifyTest_List ()
        {
            List<int> list      = new List<int> { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };
            int       firstLeaf = list.Count / 2;
            int       lastLeaf  = list.Count - 1;

            List<int> expectedList = new List<int> { 27, 17, 10, 16, 13, 9, 1, 5, 7, 12, 4, 8, 3, 0 };

            list.MaxHeapify (2, firstLeaf, lastLeaf);

            Assert.AreEqual (true, expectedList.Equals<int> (list));
        }

        [TestMethod ()]
        public void BuildMaxHeapTest ()
        {
            int [] array = new int [] { 5, 3, 17, 10, 84, 19, 6, 22, 9 };

            int [] expectedArray = new int [] { 84, 22, 19, 10, 3, 17, 6, 5, 9 };

            array.BuildMaxHeap ();

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }

        [TestMethod ()]
        public void GetFirstLeafTest_Length_1 ()
        {
            int length = 1;

            int actual = 0;

            int expected = Heap.GetFirstLeaf (length);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetFirstLeafTest_Length_2 ()
        {
            int length = 2;

            int actual = 1;

            int expected = Heap.GetFirstLeaf (length);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetFirstLeafTest_Length_3 ()
        {
            int length = 3;

            int actual = 1;

            int expected = Heap.GetFirstLeaf (length);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetFirstLeafTest_Length_Even ()
        {
            int length = 6;

            int actual = 3;

            int expected = Heap.GetFirstLeaf (length);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetFirstLeafTest_Length_Odd ()
        {
            int length = 7;

            int actual = 3;

            int expected = Heap.GetFirstLeaf (length);

            Assert.AreEqual (expected, actual);
        }
    }
}