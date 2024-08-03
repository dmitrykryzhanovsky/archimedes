using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class ArrayExtensionTests
    {
        [TestMethod ()]
        public void CopyToTest_Array2D ()
        {
            int [,] source = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };
            int [,] destination = new int [2, 3];

            source.CopyTo<int> (destination);

            Assert.AreEqual ( 2, destination.GetLength (0));
            Assert.AreEqual ( 3, destination.GetLength (1));
            Assert.AreEqual ( 2, destination [0, 0]);
            Assert.AreEqual ( 3, destination [0, 1]);
            Assert.AreEqual ( 5, destination [0, 2]);
            Assert.AreEqual ( 7, destination [1, 0]);
            Assert.AreEqual (11, destination [1, 1]);
            Assert.AreEqual (13, destination [1, 2]);
        }

        [TestMethod ()]
        public void EqualsTest_Array1D_DifferentLength ()
        {
            int [] array1 = new int [] { 2, 3 };
            int [] array2 = new int [] { 2, 3, 5 };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Array1D_EqualLength_DifferentItems ()
        {
            int [] array1 = new int [] { 2, 3, 5 };
            int [] array2 = new int [] { 2, 7, 5 };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Array1D_EqualLength_EqualItems ()
        {
            int [] array1 = new int [] { 2, 3, 5 };
            int [] array2 = new int [] { 2, 3, 5 };

            bool expected = true;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }
    }
}