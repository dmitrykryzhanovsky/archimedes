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
        public void AddTest_1D ()
        {
            int [] array1 = new int [] { 2, 3, 5, 7, 11, 13 };
            int [] array2 = new int [] { 2, 3, 5, 8, 13, 21 };

            int [] expected = new int [] { 4, 6, 10, 15, 24, 34 };

            int [] actual = new int [6];

            ArrayExtension.Add (array1, array2, actual);

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1]);
            Assert.AreEqual (expected [2], actual [2]);
            Assert.AreEqual (expected [3], actual [3]);
            Assert.AreEqual (expected [4], actual [4]);
            Assert.AreEqual (expected [5], actual [5]);
        }

        [TestMethod ()]
        public void AddTest_2D ()
        {
            int [,] array1 = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };
            int [,] array2 = new int [,] { { 2, 3, 5 }, { 8, 13, 21 } };

            int [,] expected = new int [,] { { 4, 6, 10 }, { 15, 24, 34 } };

            int [,] actual = new int [2, 3];

            ArrayExtension.Add (array1, array2, actual, 2, 3);

            Assert.AreEqual (expected [0, 0], actual [0, 0]);
            Assert.AreEqual (expected [0, 1], actual [0, 1]);
            Assert.AreEqual (expected [0, 2], actual [0, 2]);
            Assert.AreEqual (expected [1, 0], actual [1, 0]);
            Assert.AreEqual (expected [1, 1], actual [1, 1]);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);
        }

        [TestMethod ()]
        public void SubtractTest_1D ()
        {
            int [] array1 = new int [] { 2, 3, 5, 7, 11, 13 };
            int [] array2 = new int [] { 2, 3, 5, 8, 13, 21 };

            int [] expected = new int [] { 0, 0, 0, -1, -2, -8 };

            int [] actual = new int [6];

            ArrayExtension.Subtract (array1, array2, actual);

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1]);
            Assert.AreEqual (expected [2], actual [2]);
            Assert.AreEqual (expected [3], actual [3]);
            Assert.AreEqual (expected [4], actual [4]);
            Assert.AreEqual (expected [5], actual [5]);
        }

        [TestMethod ()]
        public void SubtractTest_2D ()
        {
            int [,] array1 = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };
            int [,] array2 = new int [,] { { 2, 3, 5 }, { 8, 13, 21 } };

            int [,] expected = new int [,] { { 0, 0, 0 }, { -1, -2, -8 } };

            int [,] actual = new int [2, 3];

            ArrayExtension.Subtract (array1, array2, actual, 2, 3);

            Assert.AreEqual (expected [0, 0], actual [0, 0]);
            Assert.AreEqual (expected [0, 1], actual [0, 1]);
            Assert.AreEqual (expected [0, 2], actual [0, 2]);
            Assert.AreEqual (expected [1, 0], actual [1, 0]);
            Assert.AreEqual (expected [1, 1], actual [1, 1]);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);
        }

        [TestMethod ()]
        public void NegateTest_1D ()
        {
            int [] array = new int [] { 2, 3, 5, 7, 11, 13 };

            int [] expected = new int [] { -2, -3, -5, -7, -11, -13 };

            int [] actual = new int [6];

            ArrayExtension.Negate (array, actual);

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1]);
            Assert.AreEqual (expected [2], actual [2]);
            Assert.AreEqual (expected [3], actual [3]);
            Assert.AreEqual (expected [4], actual [4]);
            Assert.AreEqual (expected [5], actual [5]);
        }

        [TestMethod ()]
        public void NegateTest_2D ()
        {
            int [,] array = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };

            int [,] expected = new int [,] { { -2, -3, -5 }, { -7, -11, -13 } };

            int [,] actual = new int [2, 3];

            ArrayExtension.Negate (array, actual, 2, 3);

            Assert.AreEqual (expected [0, 0], actual [0, 0]);
            Assert.AreEqual (expected [0, 1], actual [0, 1]);
            Assert.AreEqual (expected [0, 2], actual [0, 2]);
            Assert.AreEqual (expected [1, 0], actual [1, 0]);
            Assert.AreEqual (expected [1, 1], actual [1, 1]);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);
        }

        [TestMethod ()]
        public void MultiplyTest_1D ()
        {
            int [] array = new int [] { 2, 3, 5, 7, 11, 13 };
            int    coefficient = 5;

            int [] expected = new int [] { 10, 15, 25, 35, 55, 65 };

            int [] actual = new int [6];

            ArrayExtension.Multiply (array, coefficient, actual);

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1]);
            Assert.AreEqual (expected [2], actual [2]);
            Assert.AreEqual (expected [3], actual [3]);
            Assert.AreEqual (expected [4], actual [4]);
            Assert.AreEqual (expected [5], actual [5]);
        }

        [TestMethod ()]
        public void MultiplyTest_2D ()
        {
            int [,] array = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };
            int     coefficient = -5;

            int [,] expected = new int [,] { { -10, -15, -25 }, { -35, -55, -65 } };

            int [,] actual = new int [2, 3];

            ArrayExtension.Multiply (array, coefficient, actual, 2, 3);

            Assert.AreEqual (expected [0, 0], actual [0, 0]);
            Assert.AreEqual (expected [0, 1], actual [0, 1]);
            Assert.AreEqual (expected [0, 2], actual [0, 2]);
            Assert.AreEqual (expected [1, 0], actual [1, 0]);
            Assert.AreEqual (expected [1, 1], actual [1, 1]);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);
        }

        [TestMethod ()]
        public void DivideTest_1D ()
        {
            int [] array = new int [] { 2, 3, 5, 7, 11, 13 };
            int    coefficient = 8;

            int [] expected = new int [] { 0, 0, 0, 0, 1, 1 };

            int [] actual = new int [6];

            ArrayExtension.Divide (array, coefficient, actual);

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1]);
            Assert.AreEqual (expected [2], actual [2]);
            Assert.AreEqual (expected [3], actual [3]);
            Assert.AreEqual (expected [4], actual [4]);
            Assert.AreEqual (expected [5], actual [5]);
        }

        [TestMethod ()]
        public void DivideTest_2D ()
        {
            double [,] array = new double [,] { { 2, 3, 5 }, { 7, 11, 13 } };
            double     coefficient = -8;

            double [,] expected = new double [,] { { -0.25, -0.375, -0.625 }, { -0.875, -1.375, -1.625 } };

            double [,] actual = new double [2, 3];

            ArrayExtension.Divide (array, coefficient, actual, 2, 3);

            Assert.AreEqual (expected [0, 0], actual [0, 0]);
            Assert.AreEqual (expected [0, 1], actual [0, 1]);
            Assert.AreEqual (expected [0, 2], actual [0, 2]);
            Assert.AreEqual (expected [1, 0], actual [1, 0]);
            Assert.AreEqual (expected [1, 1], actual [1, 1]);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);
        }

        [TestMethod ()]
        public void OuterProductTest_MatrixVector ()
        {
            int [,] matrix = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };
            int []  vector = new int []  { 5, 8, 2 };

            int [] expected = new int [] { 44, 149 };

            int [] actual = new int [2];

            ArrayExtension.OuterProduct (matrix, vector, actual);

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1]);
        }

        [TestMethod ()]
        public void OuterProductTest_VectorMatrix ()
        {
            int []  vector = new int []  { 5, 8, 2 };
            int [,] matrix = new int [,] { { 2, 7 }, { 3, 11 }, { 5, 13 } };
            
            int [] expected = new int [] { 44, 149 };

            int [] actual = new int [2];

            ArrayExtension.OuterProduct (vector, matrix, actual);

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1]);
        }

        [TestMethod ()]
        public void InnerProductTest ()
        {
            int [] array1 = new int [] { 2, 3, 5, 7, 11, 13 };
            int [] array2 = new int [] { 2, 3, 5, 8, 13, 21 };

            int expected = 510;

            int actual = array1.InnerProduct (array2);

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