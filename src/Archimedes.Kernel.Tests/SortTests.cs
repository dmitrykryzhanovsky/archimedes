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
    }
}