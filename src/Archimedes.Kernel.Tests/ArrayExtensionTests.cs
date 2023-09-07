using Microsoft.VisualStudio.TestTools.UnitTesting;

using Archimedes;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class ArrayExtensionTests
    {
        [TestMethod ()]
        public void CopyTo1To2Test ()
        {
            int [] array1 = new int [] { 2, 3, 5, 8, 13, 21 };
            int [,] array2 = new int [3, 2];


        }

        [TestMethod ()]
        public void Equals1DTest_EqualLength_EqualItems ()
        {
            int [] array1 = new int [] { 2, 3, 5, 7 };
            int [] array2 = new int [] { 2, 3, 5, 7 };

            bool expected = true;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals1DTest_EqualLength_NotEqualItems ()
        {
            int [] array1 = new int [] { 2, 3, 5, 7 };
            int [] array2 = new int [] { 2, 3, 5, 8 };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals1DTest_NotEqualLength ()
        {
            int [] array1 = new int [] { 2, 3, 5 };
            int [] array2 = new int [] { 2, 3, 5, 8 };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals2DTest_EqualLength_EqualItems ()
        {
            int [,] array1 = new int [,] { { 2, 3, 5 }, { 8, 13, 21 } };
            int [,] array2 = new int [,] { { 2, 3, 5 }, { 8, 13, 21 } };

            bool expected = true;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals2DTest_EqualLength_NotEqualItems ()
        {
            int [,] array1 = new int [,] { { 2, 3, 5 }, { 8, 13, 21 } };
            int [,] array2 = new int [,] { { 2, 3, 7 }, { 8, 13, 21 } };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals2DTest_EqualHeight_NotEqualWidth ()
        {
            int [,] array1 = new int [,] { { 2, 3 }, { 8, 13 } };
            int [,] array2 = new int [,] { { 2, 3, 7 }, { 8, 13, 21 } };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals2DTest_NotEqualHeight_EqualWidth ()
        {
            int [,] array1 = new int [,] { { 2, 3 }, { 8, 13 }, { 5, 21 } };
            int [,] array2 = new int [,] { { 2, 3 }, { 8, 13 } };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals2DTest_NotEqualDimensions ()
        {
            int [,] array1 = new int [,] { { 2, 3 }, { 8, 13 }, { 5, 21 } };
            int [,] array2 = new int [,] { { 2, 3, 8 }, { 13, 5, 21 } };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }
    }
}