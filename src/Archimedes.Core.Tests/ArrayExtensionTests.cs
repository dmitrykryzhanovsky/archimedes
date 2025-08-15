using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class ArrayExtensionTests
    {
        [TestMethod ()]
        public void CopyToTest_1D ()
        {
            int [] source      = new int [] { 2, 3, 5 };
            int [] destination = new int [source.Length];

            ArrayExtension.CopyTo (source, destination);

            Assert.AreEqual (destination.Length, 3);
            Assert.AreEqual (destination [0], 2);
            Assert.AreEqual (destination [1], 3);
            Assert.AreEqual (destination [2], 5);
        }

        [TestMethod ()]
        public void CopyToTest_2D ()
        {
            int [,] source      = new int [,] { { 2, 3, 5 }, { 8, 13, 21 } };
            int [,] destination = new int [source.GetLength (0), source.GetLength (1)];

            ArrayExtension.CopyTo (source, destination);

            Assert.AreEqual (destination.GetLength (0), 2);
            Assert.AreEqual (destination.GetLength (1), 3);
            Assert.AreEqual (destination [0, 0],  2);
            Assert.AreEqual (destination [0, 1],  3);
            Assert.AreEqual (destination [0, 2],  5);
            Assert.AreEqual (destination [1, 0],  8);
            Assert.AreEqual (destination [1, 1], 13);
            Assert.AreEqual (destination [1, 2], 21);
        }

        [TestMethod ()]
        public void EqualsTest_1D_LengthNotEqual ()
        {
            int [] array1 = new int [] { 2, 3, 5 };
            int [] array2 = new int [] { 2, 3, 5, 7 };

            bool expected = false;

            bool actual = ArrayExtension.Equals (array1, array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_1D_LengthEqual_ItemsNotEqual ()
        {
            int [] array1 = new int [] { 2, 3, 5, 8 };
            int [] array2 = new int [] { 2, 3, 5, 7 };

            bool expected = false;

            bool actual = ArrayExtension.Equals (array1, array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_1D_LengthEqual_ItemsEqual ()
        {
            int [] array1 = new int [] { 2, 3, 5, 8 };
            int [] array2 = new int [] { 2, 3, 5, 8 };

            bool expected = true;

            bool actual = ArrayExtension.Equals (array1, array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_2D_SizeNotEqual ()
        {
            int [,] array1 = new int [,] { { 2, 3, 5 }, { 13, 21, 34 } };
            int [,] array2 = new int [,] { { 2, 3, 5, 7 }, { 11, 13, 17, 19 } };

            bool expected = false;

            bool actual = ArrayExtension.Equals (array1, array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_2D_SizeEqual_ItemsNotEqual ()
        {
            int [,] array1 = new int [,] { { 2, 3, 5, 8 }, { 13, 21, 34, 55 } };
            int [,] array2 = new int [,] { { 2, 3, 5, 7 }, { 11, 13, 17, 19 } };

            bool expected = false;

            bool actual = ArrayExtension.Equals (array1, array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_2D_SizeEqual_ItemsEqual ()
        {
            int [,] array1 = new int [,] { { 2, 3, 5, 8 }, { 13, 21, 34, 55 } };
            int [,] array2 = new int [,] { { 2, 3, 5, 8 }, { 13, 21, 34, 55 } };

            bool expected = true;

            bool actual = ArrayExtension.Equals (array1, array2);

            Assert.AreEqual (expected, actual);
        }
    }
}