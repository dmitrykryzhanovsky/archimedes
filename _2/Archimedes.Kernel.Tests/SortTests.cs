using Archimedes;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class SortTests
    {
        [TestMethod ()]
        public void SelectionSortTest ()
        {
            int [] array = new int [] { 25, 53, 62, 33, 82, 40 };

            int [] expectedArray = new int [] { 25, 33, 40, 53, 62, 82 };

            array.SelectionSort ();

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }

        [TestMethod ()]
        public void InsertionSortTest ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 41, 58 };

            int [] expectedArray = new int [] { 21, 26, 41, 41, 58, 59 };

            array.InsertionSort ();

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }

        [TestMethod ()]
        public void MergeSortTest ()
        {
            int [] array = new int [] { 3, 41, 52, 26, 38, 57, 9, 49 };

            int [] expectedArray = new int [] { 3, 9, 26, 38, 41, 49, 52, 57 };

            array.MergeSort ();

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