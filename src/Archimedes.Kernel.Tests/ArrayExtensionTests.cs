using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class ArrayExtensionTests
    {
        [TestMethod ()]
        public void EqualsTest_1D_NotEqualLength ()
        {
            int [] collection1 = new int [2];
            int [] collection2 = new int [3];

            bool expected = false;

            bool actual = ArrayExtension.Equals (collection1, collection2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_1D_EqualLength_NotEqualItems ()
        {
            int [] collection1 = new int [] { 2, 3, 5 };
            int [] collection2 = new int [] { 2, 3, 6 };

            bool expected = false;

            bool actual = ArrayExtension.Equals (collection1, collection2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_1D_EqualLength_EqualItems ()
        {
            int [] collection1 = new int [] { 2, 3, 5 };
            int [] collection2 = new int [] { 2, 3, 5 };

            bool expected = true;

            bool actual = ArrayExtension.Equals (collection1, collection2);

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
    }
}