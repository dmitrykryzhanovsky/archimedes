using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class ArrayExtensionTests
    {
        [TestMethod ()]
        public void CopyToTest_1D2D ()
        {
            int []  sourceArray      = new int [] { 2, 3, 5, 7, 11, 13 };
            int [,] destinationArray = new int [3, 2];

            sourceArray.CopyTo (destinationArray);

            Assert.AreEqual (sourceArray [0], destinationArray [0, 0]);
            Assert.AreEqual (sourceArray [1], destinationArray [0, 1]);
            Assert.AreEqual (sourceArray [2], destinationArray [1, 0]);
            Assert.AreEqual (sourceArray [3], destinationArray [1, 1]);
            Assert.AreEqual (sourceArray [4], destinationArray [2, 0]);
            Assert.AreEqual (sourceArray [5], destinationArray [2, 1]);
        }

        [TestMethod ()]
        public void CopyToTest_2D2D ()
        {
            int [,] sourceArray      = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };
            int [,] destinationArray = new int [2, 3];

            sourceArray.CopyTo (destinationArray);

            Assert.AreEqual (sourceArray [0, 0], destinationArray [0, 0]);
            Assert.AreEqual (sourceArray [0, 1], destinationArray [0, 1]);
            Assert.AreEqual (sourceArray [0, 2], destinationArray [0, 2]);
            Assert.AreEqual (sourceArray [1, 0], destinationArray [1, 0]);
            Assert.AreEqual (sourceArray [1, 1], destinationArray [1, 1]);
            Assert.AreEqual (sourceArray [1, 2], destinationArray [1, 2]);
        }
    }
}