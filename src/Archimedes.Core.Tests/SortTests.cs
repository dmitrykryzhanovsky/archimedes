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
            int [] array = new int [] { 21, 41, 59, 26, 41, 58, 73, 42, 69 };

            int [] expectedArray = new int [] { 21, 41, 26, 41, 42, 58, 59, 73, 69 };

            array.InsertionSort (beginIndex: 2, endIndex: 7);

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }

        [TestMethod ()]
        public void MergeSortTest_Array ()
        {
            int [] array = new int [] { 3, 41, 52, 26, 38, 57, 9, 49 };

            int [] expectedArray = new int [] { 3, 9, 26, 38, 41, 49, 52, 57 };

            array.MergeSort (chunk: 1);

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }

        [TestMethod ()]
        public void MergeSortTest_Subarray ()
        {
            int [] array = new int [] { 45, 67, 3, 41, 52, 26, 38, 57, 9, 49, 11 };

            int [] expectedArray = new int [] { 45, 67, 3, 9, 26, 38, 41, 49, 52, 57, 11 };

            array.MergeSort (beginIndex: 2, endIndex: 9, chunk: 2);

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }
    }
}