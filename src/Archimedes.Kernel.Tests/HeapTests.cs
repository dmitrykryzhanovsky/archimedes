using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class HeapTests
    {
        [TestMethod ()]
        public void MaxHeapifyTest ()
        {
            int [] array = new int [] { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };

            int [] expectedArray = new int [] { 27, 17, 10, 16, 13, 9, 1, 5, 7, 12, 4, 8, 3, 0 };

            array.MaxHeapify (2);

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }
    }
}