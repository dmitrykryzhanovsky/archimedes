using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class ArrayExtensionTests
    {
        [TestMethod ()]
        public void CopyToTest_Array1DToArray2D ()
        {
            int []  source = new int [] { 2, 3, 5, 7, 11, 13 };
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

        [TestMethod ()]
        public void EqualsTest_Array2D_DifferentLength ()
        {
            int [,] array1 = new int [,] { { 2, 3 }, { 5, 7 } };
            int [,] array2 = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Array2D_EqualLength_DifferentItems ()
        {
            int [,] array1 = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };
            int [,] array2 = new int [,] { { 2, 3, 5 }, { 8, 13, 21 } };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Array2D_EqualLength_EqualItems ()
        {
            int [,] array1 = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };
            int [,] array2 = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };

            bool expected = true;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AddTest_Array1D ()
        {
            int [] array1 = new int [] { 2, 3, 5, 7 };
            int [] array2 = new int [] { 8, 5, 3, 2 };
            int [] actual = new int [4];

            int [] expected = new int [] { 10, 8, 8, 9 };

            array1.Add (array2, actual);

            Assert.AreEqual (true, expected.Equals<int> (actual));
        }

        [TestMethod ()]
        public void AddTest_Array2D ()
        {
            int [,] array1 = new int [,] { {  2,  3, 5 }, { 7, 11, 13 } };
            int [,] array2 = new int [,] { { 21, 13, 8 }, { 5,  3,  2 } };
            int [,] actual = new int [2, 3];

            int [,] expected = new int [,] { { 23, 16, 13 }, { 12, 14, 15 } };

            array1.Add (array2, actual);

            Assert.AreEqual (true, expected.Equals<int> (actual));
        }

        [TestMethod ()]
        public void AddToTest_Array1D ()
        {
            int [] array1 = new int [] { 2, 3, 5, 7 };
            int [] array2 = new int [] { 8, 5, 3, 2 };

            int [] expected = new int [] { 10, 8, 8, 9 };

            array1.AddTo (array2);

            Assert.AreEqual (true, expected.Equals<int> (array1));
        }

        [TestMethod ()]
        public void AddToTest_Array2D ()
        {
            int [,] array1 = new int [,] { {  2,  3, 5 }, { 7, 11, 13 } };
            int [,] array2 = new int [,] { { 21, 13, 8 }, { 5,  3,  2 } };

            int [,] expected = new int [,] { { 23, 16, 13 }, { 12, 14, 15 } };

            array1.AddTo (array2);

            Assert.AreEqual (true, expected.Equals<int> (array1));
        }

        [TestMethod ()]
        public void SubtractTest_Array1D ()
        {
            int [] array1 = new int [] { 2, 3, 5, 7 };
            int [] array2 = new int [] { 8, 5, 3, 2 };
            int [] actual = new int [4];

            int [] expected = new int [] { -6, -2, 2, 5 };

            array1.Subtract (array2, actual);

            Assert.AreEqual (true, expected.Equals<int> (actual));
        }

        [TestMethod ()]
        public void SubtractTest_Array2D ()
        {
            int [,] array1 = new int [,] { {  2,  3, 5 }, { 7, 11, 13 } };
            int [,] array2 = new int [,] { { 21, 13, 8 }, { 5,  3,  2 } };
            int [,] actual = new int [2, 3];

            int [,] expected = new int [,] { { -19, -10, -3 }, { 2, 8, 11 } };

            array1.Subtract (array2, actual);

            Assert.AreEqual (true, expected.Equals<int> (actual));
        }

        [TestMethod ()]
        public void SubtractToTest_Array1D ()
        {
            int [] array1 = new int [] { 2, 3, 5, 7 };
            int [] array2 = new int [] { 8, 5, 3, 2 };

            int [] expected = new int [] { -6, -2, 2, 5 };

            array1.SubtractTo (array2);

            Assert.AreEqual (true, expected.Equals<int> (array1));
        }

        [TestMethod ()]
        public void SubtractToTest_Array2D ()
        {
            int [,] array1 = new int [,] { {  2,  3, 5 }, { 7, 11, 13 } };
            int [,] array2 = new int [,] { { 21, 13, 8 }, { 5,  3,  2 } };

            int [,] expected = new int [,] { { -19, -10, -3 }, { 2, 8, 11 } };

            array1.SubtractTo (array2);

            Assert.AreEqual (true, expected.Equals<int> (array1));
        }

        [TestMethod ()]
        public void NegateTest_Array1D ()
        {
            int [] array  = new int [] { 2, 3, 5, 7 };
            int [] actual = new int [4];

            int [] expected = new int [] { -2, -3, -5, -7 };

            array.Negate (actual);

            Assert.AreEqual (true, expected.Equals<int> (actual));
        }

        [TestMethod ()]
        public void NegateTest_Array2D ()
        {
            int [,] array  = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };
            int [,] actual = new int [2, 3];

            int [,] expected = new int [,] { { -2, -3, -5 }, { -7, -11, -13 } };

            array.Negate (actual);

            Assert.AreEqual (true, expected.Equals<int> (actual));
        }

        [TestMethod ()]
        public void NegateTest_This_Array1D ()
        {
            int [] array = new int [] { 2, 3, 5, 7 };

            int [] expected = new int [] { -2, -3, -5, -7 };

            array.Negate ();

            Assert.AreEqual (true, expected.Equals<int> (array));
        }

        [TestMethod ()]
        public void NegateTest_This_Array2D ()
        {
            int [,] array = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };

            int [,] expected = new int [,] { { -2, -3, -5 }, { -7, -11, -13 } };

            array.Negate ();

            Assert.AreEqual (true, expected.Equals<int> (array));
        }

        [TestMethod ()]
        public void MultiplyTest_Array1D ()
        {
            int [] array       = new int [] { 2, 3, 5, 7 };
            int    coefficient = 3;
            int [] actual      = new int [4];

            int [] expected = new int [] { 6, 9, 15, 21 };

            array.Multiply (coefficient, actual);

            Assert.AreEqual (true, expected.Equals<int> (actual));
        }

        [TestMethod ()]
        public void MultiplyTest_Array2D ()
        {
            int [,] array       = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };
            int     coefficient = 3;
            int [,] actual      = new int [2, 3];

            int [,] expected = new int [,] { { 6, 9, 15 }, { 21, 33, 39 } };

            array.Multiply (coefficient, actual);

            Assert.AreEqual (true, expected.Equals<int> (actual));
        }

        [TestMethod ()]
        public void MultiplyToTest_Array1D ()
        {
            int [] array       = new int [] { 2, 3, 5, 7 };
            int    coefficient = 3;

            int [] expected = new int [] { 6, 9, 15, 21 };

            array.MultiplyTo (coefficient);

            Assert.AreEqual (true, expected.Equals<int> (array));
        }

        [TestMethod ()]
        public void MultiplyToTest_Array2D ()
        {
            int [,] array       = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };
            int     coefficient = 3;

            int [,] expected = new int [,] { { 6, 9, 15 }, { 21, 33, 39 } };

            array.MultiplyTo (coefficient);

            Assert.AreEqual (true, expected.Equals<int> (array));
        }

        [TestMethod ()]
        public void DivideTest_Array1D ()
        {
            int [] array       = new int [] { 2, 3, 5, 7 };
            int    coefficient = 3;
            int [] actual      = new int [4];

            int [] expected = new int [] { 0, 1, 1, 2 };

            array.Divide (coefficient, actual);

            Assert.AreEqual (true, expected.Equals<int> (actual));
        }

        [TestMethod ()]
        public void DivideTest_Array2D ()
        {
            int [,] array       = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };
            int     coefficient = 3;
            int [,] actual      = new int [2, 3];

            int [,] expected = new int [,] { { 0, 1, 1 }, { 2, 3, 4 } };

            array.Divide (coefficient, actual);

            Assert.AreEqual (true, expected.Equals<int> (actual));
        }

        [TestMethod ()]
        public void DivideToTest_Array1D ()
        {
            int [] array       = new int [] { 2, 3, 5, 7 };
            int    coefficient = 3;

            int [] expected = new int [] { 0, 1, 1, 2 };

            array.DivideTo (coefficient);

            Assert.AreEqual (true, expected.Equals<int> (array));
        }

        [TestMethod ()]
        public void DivideToTest_Array2D ()
        {
            int [,] array       = new int [,] { { 2, 3, 5 }, { 7, 11, 13 } };
            int     coefficient = 3;

            int [,] expected = new int [,] { { 0, 1, 1 }, { 2, 3, 4 } };

            array.DivideTo (coefficient);

            Assert.AreEqual (true, expected.Equals<int> (array));
        }

        [TestMethod ()]
        public void InnerProductTest ()
        {
            int [] array1 = new int [] { 2, 3, 5, 7 };
            int [] array2 = new int [] { 8, 5, 3, 2 };

            int expected = 60;

            int actual = array1.InnerProduct<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SumOfSquaresTest ()
        {
            int [] array = new int [] { 2, 3, 5, 7 };

            int expected = 87;

            int actual = array.SumOfSquares<int> ();

            Assert.AreEqual (expected, actual);
        }
    }
}