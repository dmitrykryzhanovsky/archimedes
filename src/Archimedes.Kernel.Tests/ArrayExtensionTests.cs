using Archimedes;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class ArrayExtensionTests
    {
        [TestMethod ()]
        public void CopyToTest_1Dto2D ()
        {
            int [] source = new int [] { 2, 3, 5, 7, 11, 13 };
            int [,] destination = new int [2, 3];

            int [,] expected = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };

            source.CopyTo (destination);

            Assert.AreEqual (true, ArrayExtension.Equals (expected, destination));
        }

        [TestMethod ()]
        public void CopyToTest_2Dto2D ()
        {
            int [,] source = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };
            int [,] destination = new int [2, 3];

            int [,] expected = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };

            source.CopyTo (destination);

            Assert.AreEqual (true, ArrayExtension.Equals (expected, destination));
        }

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

        [TestMethod ()]
        public void AddTest_1D ()
        {
            int [] collection1 = new int [] { 2, 3,  5,  8, 13,  21 };
            int [] collection2 = new int [] { 4, 7, 10, 15, 52, 102 };

            int [] expected = new int [] { 6, 10, 15, 23, 65, 123 };

            int [] actual = collection1.Add (collection2);

            Assert.AreEqual (true, ArrayExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void AddTest_2D ()
        {
            int [,] collection1 = new int [,] { { 2, 3,  5 }, {  8, 13,  21 } };
            int [,] collection2 = new int [,] { { 4, 7, 10 }, { 15, 52, 102 } };

            int [,] expected = new int [,] { { 6, 10, 15 }, { 23, 65, 123 } };

            int [,] actual = collection1.Add (collection2);

            Assert.AreEqual (true, ArrayExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void SubtractTest_1D ()
        {
            int [] collection1 = new int [] { 2, 3,  5,  8, 13,  21 };
            int [] collection2 = new int [] { 4, 7, 10, 15, 52, 102 };

            int [] expected = new int [] { -2, -4, -5, -7, -39, -81 };

            int [] actual = collection1.Subtract (collection2);

            Assert.AreEqual (true, ArrayExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void SubtractTest_2D ()
        {
            int [,] collection1 = new int [,] { { 2, 3,  5 }, {  8, 13,  21 } };
            int [,] collection2 = new int [,] { { 4, 7, 10 }, { 15, 52, 102 } };

            int [,] expected = new int [,] { { -2, -4, -5 }, { -7, -39, -81 } };

            int [,] actual = collection1.Subtract (collection2);

            Assert.AreEqual (true, ArrayExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void NegateTest_1D ()
        {
            int [] collection = new int [] { 2, 3, 5, 8, 13, 21 };

            int [] expected = new int [] { -2, -3, -5, -8, -13, -21 };

            int [] actual = collection.Negate ();

            Assert.AreEqual (true, ArrayExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void NegateTest_2D ()
        {
            int [,] collection = new int [,] { { 2, 3, 5 }, { 8, 13, 21 } };

            int [,] expected = new int [,] { { -2, -3, -5 }, { -8, -13, -21 } };

            int [,] actual = collection.Negate ();

            Assert.AreEqual (true, ArrayExtension.Equals (expected, actual));
        }
    }
}