using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class SortTests
    {
        [TestMethod ()]
        public void InsertionSortTest_Array ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 41, 58 };

            int [] expectedArray = new int [] { 21, 26, 41, 41, 58, 59 };

            array.InsertionSort ();

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }

        [TestMethod ()]
        public void InsertionSortTest_Subarray ()
        {
            int [] array      = new int [] { 21, 41, 59, 26, 41, 58, 73, 42, 69 };
            int    beginIndex = 2;
            int    endIndex   = 7;

            int [] expectedArray = new int [] { 21, 41, 26, 41, 42, 58, 59, 73, 69 };

            array.InsertionSort (beginIndex, endIndex);

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }

        [TestMethod ()]
        public void MergeSortTest_Array ()
        {
            int [] array = new int [] { 3, 41, 52, 26, 38, 57, 9, 49 };
            int    chunk = 1;

            int [] expectedArray = new int [] { 3, 9, 26, 38, 41, 49, 52, 57 };

            array.MergeSort (chunk);

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }

        [TestMethod ()]
        public void MergeSortTest_Subarray ()
        {
            int [] array      = new int [] { 45, 67, 3, 41, 52, 26, 38, 57, 9, 49, 11 };
            int    beginIndex = 2;
            int    endIndex   = 9;
            int    chunk      = 2;

            int [] expectedArray = new int [] { 45, 67, 3, 9, 26, 38, 41, 49, 52, 57, 11 };

            array.MergeSort (beginIndex, endIndex, chunk);

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }

        [TestMethod ()]
        public void HeapSortTest ()
        {
            int [] array = new int [] { 5, 13, 2, 25, 7, 17, 20, 8, 4 };

            int [] expectedArray = new int [] { 2, 4, 5, 7, 8, 13, 17, 20, 25 };

            array.HeapSort ();

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }
    }
}