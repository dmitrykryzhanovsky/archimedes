using Microsoft.VisualStudio.TestTools.UnitTesting;

using Archimedes;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class ArrayExtensionTests
    {
        [TestMethod ()]
        public void CopyTo_1DTo2DTest ()
        {
            int [] source = new int [] { 2, 3, 5, 8, 13, 21 };

            int [,] expected = new int [,] { { 2, 3, 5 }, { 8, 13, 21 } };

            int [,] actual = new int [2, 3];

            source.CopyTo<int> (actual);

            Assert.AreEqual (true, expected.Equals<int> (actual));
        }

        [TestMethod ()]
        public void CopyTo_2DTo2DTest ()
        {
            int [,] source = new int [,] { { 2, 3, 5 }, { 8, 13, 21 } };

            int [,] expected = new int [,] { { 2, 3, 5 }, { 8, 13, 21 } };

            int [,] actual = new int [2, 3];

            source.CopyTo<int> (actual);

            Assert.AreEqual (true, expected.Equals<int> (actual));
        }

        [TestMethod ()]
        public void Equals_1DTest_EqualLength_EqualItems ()
        {
            int [] array1 = new int [] { 2, 3, 5, 7 };
            int [] array2 = new int [] { 2, 3, 5, 7 };

            bool expected = true;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals_1DTest_EqualLength_NotEqualItems ()
        {
            int [] array1 = new int [] { 2, 3, 5, 7 };
            int [] array2 = new int [] { 2, 3, 5, 8 };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals_1DTest_NotEqualLength ()
        {
            int [] array1 = new int [] { 2, 3, 5 };
            int [] array2 = new int [] { 2, 3, 5, 8 };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals_2DTest_EqualLength_EqualItems ()
        {
            int [,] array1 = new int [,] { { 2, 3, 5 }, { 8, 13, 21 } };
            int [,] array2 = new int [,] { { 2, 3, 5 }, { 8, 13, 21 } };

            bool expected = true;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals_2DTest_EqualLength_NotEqualItems ()
        {
            int [,] array1 = new int [,] { { 2, 3, 5 }, { 8, 13, 21 } };
            int [,] array2 = new int [,] { { 2, 3, 7 }, { 8, 13, 21 } };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals_2DTest_EqualHeight_NotEqualWidth ()
        {
            int [,] array1 = new int [,] { { 2, 3 }, { 8, 13 } };
            int [,] array2 = new int [,] { { 2, 3, 7 }, { 8, 13, 21 } };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals_2DTest_NotEqualHeight_EqualWidth ()
        {
            int [,] array1 = new int [,] { { 2, 3 }, { 8, 13 }, { 5, 21 } };
            int [,] array2 = new int [,] { { 2, 3 }, { 8, 13 } };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals_2DTest_NotEqualDimensions ()
        {
            int [,] array1 = new int [,] { { 2, 3 }, { 8, 13 }, { 5, 21 } };
            int [,] array2 = new int [,] { { 2, 3, 8 }, { 13, 5, 21 } };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void DotProductTest_Common ()
        {
            double [] array1 = new double [] { 2, 3, 5, 8, 13 };
            double [] array2 = new double [] { 3, 4, 6, 8, 12 };

            double expected = 268;

            double actual = array1.DotProduct (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void DotProductTest_Length1 ()
        {
            double [] array1 = new double [] { 2 };
            double [] array2 = new double [] { 3 };

            double expected = 6;

            double actual = array1.DotProduct (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void DotProductTest_Length0 ()
        {
            double [] array1 = new double [] {};
            double [] array2 = new double [] {};

            double expected = 0;

            double actual = array1.DotProduct (array2);

            Assert.AreEqual (expected, actual);
        }
    }
}