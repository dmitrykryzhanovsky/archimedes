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

            array.InsertionSort (2, 7);

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }
    }
}