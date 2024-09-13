using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class ArrayExtensionTests
    {
        [TestMethod ()]
        public void InnerProductTest ()
        {
            int [] array1 = new int [] { 2, 3, 5, 7, 11 };
            int [] array2 = new int [] { 2, 3, 5, 8, 13 };

            int expected = 237;

            int actual = array1.InnerProduct (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SumTest ()
        {
            int [] array = new int [] { 2, 3, 5, 7, 11 };

            int expected = 28;

            int actual = array.Sum ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SumOfSquaresTest ()
        {
            int [] array = new int [] { 2, 3, 5, 7, 11 };

            int expected = 208;

            int actual = array.SumOfSquares ();

            Assert.AreEqual (expected, actual);
        }
    }
}