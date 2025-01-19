using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class ArrayExtensionTests
    {
        [TestMethod ()]
        public void CopyToTest_2DArrayTo2DArray ()
        {
            int [,] source      = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };
            int [,] destination = new int [2, 3];

            ArrayExtension.CopyTo (source, destination);

            Assert.AreEqual ( 2, destination [0, 0]);
            Assert.AreEqual ( 3, destination [0, 1]);
            Assert.AreEqual ( 5, destination [0, 2]);
            Assert.AreEqual ( 7, destination [1, 0]);
            Assert.AreEqual (11, destination [1, 1]);
            Assert.AreEqual (13, destination [1, 2]);
        }

        [TestMethod ()]
        public void EqualsTest_1DArray_Equal ()
        {
            int [] array1 = new int [] { 2, 3, 5, 8 };
            int [] array2 = new int [] { 2, 3, 5, 8 };

            bool expected = true;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_1DArray_NotEqual_DifferentItems ()
        {
            int [] array1 = new int [] { 2, 3, 5, 8 };
            int [] array2 = new int [] { 2, 3, 5, 7 };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_1DArray_NotEqual_DifferentLength ()
        {
            int [] array1 = new int [] { 2, 3, 5, 8 };
            int [] array2 = new int [] { 2, 3, 5, 8, 13 };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_2DArray_Equal ()
        {
            int [,] array1 = new int [,] { { 2, 3, 5 }, { 8, 13, 21 } };
            int [,] array2 = new int [,] { { 2, 3, 5 }, { 8, 13, 21 } };

            bool expected = true;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_2DArray_NotEqual_DifferentItems ()
        {
            int [,] array1 = new int [,] { { 2, 3, 5 }, { 8, 13, 21 } };
            int [,] array2 = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_2DArray_NotEqual_DifferentDimensions ()
        {
            int [,] array1 = new int [,] { { 2, 3 }, { 5, 8 }, { 13, 21 } };
            int [,] array2 = new int [,] { { 2, 3, 5 }, { 8, 13, 21 } };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_2DArray_NotEqual_DifferentLength ()
        {
            int [,] array1 = new int [,] { { 2, 3 }, { 5, 8 }, { 13, 21 }, { 34, 55 } };
            int [,] array2 = new int [,] { { 2, 3, 5 }, { 8, 13, 21 } };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }
    }
}