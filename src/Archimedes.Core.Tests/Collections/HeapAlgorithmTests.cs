using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Core.Tests
{
    [TestClass()]
    public class HeapAlgorithmTests
    {
        [TestMethod ()]
        public void GetFirstLeafIndexIndexTest_Length_1 ()
        {
            int length = 1;

            int actual = 0;

            int expected = HeapAlgorithm.GetFirstLeafIndex (length);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetFirstLeafIndexIndexTest_Length_2 ()
        {
            int length = 2;

            int actual = 1;

            int expected = HeapAlgorithm.GetFirstLeafIndex (length);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetFirstLeafIndexIndexTest_Length_3 ()
        {
            int length = 3;

            int actual = 1;

            int expected = HeapAlgorithm.GetFirstLeafIndex (length);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetFirstLeafIndexIndexTest_Length_Even ()
        {
            int length = 6;

            int actual = 3;

            int expected = HeapAlgorithm.GetFirstLeafIndex (length);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetFirstLeafIndexIndexTest_Length_Odd ()
        {
            int length = 7;

            int actual = 3;

            int expected = HeapAlgorithm.GetFirstLeafIndex (length);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetParentIndexTest_Odd ()
        {
            int index = 7;

            int expected = 3;

            int actual = HeapAlgorithm.GetParentIndex (index);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetParentIndexTest_Even ()
        {
            int index = 8;

            int expected = 3;

            int actual = HeapAlgorithm.GetParentIndex (index);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetLeftChildIndexTest()
        {
            int index = 3;

            int expected = 7;

            int actual = HeapAlgorithm.GetLeftChildIndex (index);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxHeapifyTest ()
        {
            int [] array = new int [] { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };

            int subtreeRootIndex =  2;
            int firstLeafIndex   =  7;
            int lastLeafIndex    = 13;

            int [] expectedArray = new int [] { 27, 17, 10, 16, 13, 9, 1, 5, 7, 12, 4, 8, 3, 0 };

            array.MaxHeapify (subtreeRootIndex, firstLeafIndex, lastLeafIndex);

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }

        [TestMethod ()]
        public void MinHeapifyTest ()
        {
            int [] array = new int [] { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };

            int subtreeRootIndex =  2;
            int firstLeafIndex   =  7;
            int lastLeafIndex    = 13;

            int [] expectedArray = new int [] { 27, 17, 1, 16, 13, 10, 0, 5, 7, 12, 4, 8, 9, 3 };

            array.MinHeapify (subtreeRootIndex, firstLeafIndex, lastLeafIndex);

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }

        [TestMethod ()]
        public void BuildMaxHeapTest ()
        {
            int [] array = new int [] { 5, 3, 17, 10, 84, 19, 6, 22, 9 };

            int firstLeafIndex = 4;
            int lastLeafIndex  = 8;

            int [] expectedArray = new int [] { 84, 22, 19, 10, 3, 17, 6, 5, 9 };

            array.BuildMaxHeap (firstLeafIndex, lastLeafIndex);

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }

        [TestMethod ()]
        public void BuildMinHeapTest ()
        {
            int [] array = new int [] { 5, 3, 17, 10, 84, 19, 6, 22, 9 };

            int firstLeafIndex = 4;
            int lastLeafIndex  = 8;

            int [] expectedArray = new int [] { 3, 5, 6, 9, 84, 19, 17, 22, 10 };

            array.BuildMinHeap (firstLeafIndex, lastLeafIndex);

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }
    }
}