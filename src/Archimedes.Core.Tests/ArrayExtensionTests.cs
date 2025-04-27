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

        [TestMethod ()]
        public void EqualsTest_1D_NotEqualLength ()
        {
            int [] array1 = new int [2];
            int [] array2 = new int [3];

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_1D_EqualLength_NotEqualItems ()
        {
            int [] array1 = new int [] { 2, 3, 5 };
            int [] array2 = new int [] { 2, 3, 7 };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_1D_EqualLength_EqualItems ()
        {
            int [] array1 = new int [] { 2, 3, 5 };
            int [] array2 = new int [] { 2, 3, 5 };

            bool expected = true;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_2D_NotEqualLengths_AllDifferent ()
        {
            int [,] collection1 = new int [2, 3];
            int [,] collection2 = new int [5, 7];

            bool expected = false;

            bool actual = ArrayExtension.Equals (collection1, collection2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_2D_NotEqualLengths_OneDifferent ()
        {
            int [,] collection1 = new int [2, 3];
            int [,] collection2 = new int [2, 7];

            bool expected = false;

            bool actual = ArrayExtension.Equals (collection1, collection2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_2D_NotEqualLengths_Swapped ()
        {
            int [,] collection1 = new int [2, 3];
            int [,] collection2 = new int [3, 2];

            bool expected = false;

            bool actual = ArrayExtension.Equals (collection1, collection2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_2D_EqualLengths_NotEqualItems ()
        {
            int [,] collection1 = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };
            int [,] collection2 = new int [,] { { 2, 3, 8 }, { 7, 11, 13 } };

            bool expected = false;

            bool actual = ArrayExtension.Equals (collection1, collection2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_2D_EqualLengths_EqualItems ()
        {
            int [,] collection1 = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };
            int [,] collection2 = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };

            bool expected = true;

            bool actual = ArrayExtension.Equals (collection1, collection2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SumOfSquaresTest ()
        {
            int [] array = new int [] { 2, 3, 5, 7, 11, 13 };

            int expected = 377;

            int actual = array.SumOfSquares ();

            Assert.AreEqual (expected, actual);
        }
    }
}