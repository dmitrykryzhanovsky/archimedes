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
            int [] destination = new int [3];

            ArrayExtension.CopyTo (source, destination);

            Assert.AreEqual (destination.Length, 3);
            Assert.AreEqual (destination [0], 2);
            Assert.AreEqual (destination [1], 3);
            Assert.AreEqual (destination [2], 5);
        }

        [TestMethod ()]
        public void CopyToTest_1DTo2D ()
        {
            int []  source      = new int [] { 2, 3, 5, 8, 13, 21 };
            int [,] destination = new int [2, 3];

            ArrayExtension.CopyTo (source, destination);

            Assert.AreEqual (destination.GetLength (0), 2);
            Assert.AreEqual (destination.GetLength (1), 3);
            Assert.AreEqual (destination [0, 0], 2);
            Assert.AreEqual (destination [0, 1], 3);
            Assert.AreEqual (destination [0, 2], 5);
            Assert.AreEqual (destination [1, 0], 8);
            Assert.AreEqual (destination [1, 1], 13);
            Assert.AreEqual (destination [1, 2], 21);
        }

        [TestMethod ()]
        public void CopyToTest_2D ()
        {
            int [,] source      = new int [,] { { 2, 3, 5 }, { 8, 13, 21 } };
            int [,] destination = new int [2, 3];

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

        [TestMethod ()]
        public void AddTest_1D ()
        {
            int [] array1 = new int [] { 4, 7, 9, 6, 6 };
            int [] array2 = new int [] { 8, 7, 3, 6, 4 };

            int [] expected = new int [] { 12, 14, 12, 12, 10 };

            int [] actual = new int [array1.Length];

            ArrayExtension.Add (array1, array2, actual);

            Assert.IsTrue (ArrayExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void AddTest_2D ()
        {
            int [,] array1 = new int [,] { { 4, 7, 9 }, { 6, 6, 1 } };
            int [,] array2 = new int [,] { { 8, 7, 3 }, { 6, 4, 8 } };

            int [,] expected = new int [,] { { 12, 14, 12 }, { 12, 10, 9 } };

            int [,] actual = new int [array1.GetLength (0), array2.GetLength (1)];

            ArrayExtension.Add (array1, array2, actual);

            Assert.IsTrue (ArrayExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void AddToTest_1D ()
        {
            int [] array1 = new int [] { 4, 7, 9, 6, 6 };
            int [] array2 = new int [] { 8, 7, 3, 6, 4 };

            int [] expected = new int [] { 12, 14, 12, 12, 10 };

            ArrayExtension.AddTo (array1, array2);

            Assert.IsTrue (ArrayExtension.Equals (expected, array1));
        }

        [TestMethod ()]
        public void AddToTest_2D ()
        {
            int [,] array1 = new int [,] { { 4, 7, 9 }, { 6, 6, 1 } };
            int [,] array2 = new int [,] { { 8, 7, 3 }, { 6, 4, 8 } };

            int [,] expected = new int [,] { { 12, 14, 12 }, { 12, 10, 9 } };

            ArrayExtension.AddTo (array1, array2);

            Assert.IsTrue (ArrayExtension.Equals (expected, array1));
        }

        [TestMethod ()]
        public void SubtractTest_1D ()
        {
            int [] array1 = new int [] { 4, 7, 9, 6, 6 };
            int [] array2 = new int [] { 8, 7, 3, 6, 4 };

            int [] expected = new int [] { -4, 0, 6, 0, 2 };

            int [] actual = new int [array1.Length];

            ArrayExtension.Subtract (array1, array2, actual);

            Assert.IsTrue (ArrayExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void SubtractTest_2D ()
        {
            int [,] array1 = new int [,] { { 4, 7, 9 }, { 6, 6, 1 } };
            int [,] array2 = new int [,] { { 8, 7, 3 }, { 6, 4, 8 } };

            int [,] expected = new int [,] { { -4, 0, 6 }, { 0, 2, -7} };

            int [,] actual = new int [array1.GetLength (0), array2.GetLength (1)];

            ArrayExtension.Subtract (array1, array2, actual);

            Assert.IsTrue (ArrayExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void SubtractToTest_1D ()
        {
            int [] array1 = new int [] { 4, 7, 9, 6, 6 };
            int [] array2 = new int [] { 8, 7, 3, 6, 4 };

            int [] expected = new int [] { -4, 0, 6, 0, 2 };

            ArrayExtension.SubtractTo (array1, array2);

            Assert.IsTrue (ArrayExtension.Equals (expected, array1));
        }

        [TestMethod ()]
        public void SubtractToTest_2D ()
        {
            int [,] array1 = new int [,] { { 4, 7, 9 }, { 6, 6, 1 } };
            int [,] array2 = new int [,] { { 8, 7, 3 }, { 6, 4, 8 } };

            int [,] expected = new int [,] { { -4, 0, 6 }, { 0, 2, -7 } };

            ArrayExtension.SubtractTo (array1, array2);

            Assert.IsTrue (ArrayExtension.Equals (expected, array1));
        }

        [TestMethod ()]
        public void NegateTest_1D ()
        {
            int [] array = new int [] { 4, 7, 9, 6, 6 };

            int [] expected = new int [] { -4, -7, -9, -6, -6 };

            int [] actual = new int [array.Length];

            ArrayExtension.Negate (array, actual);

            Assert.IsTrue (ArrayExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void NegateTest_2D ()
        {
            int [,] array = new int [,] { { 4, 7, 9 }, { 6, 6, 1 } };

            int [,] expected = new int [,] { { -4, -7, -9 }, { -6, -6, -1 } };

            int [,] actual = new int [array.GetLength (0), array.GetLength (1)];

            ArrayExtension.Negate (array, actual);

            Assert.IsTrue (ArrayExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void NegateToTest_1D ()
        {
            int [] array = new int [] { 4, 7, 9, 6, 6 };

            int [] expected = new int [] { -4, -7, -9, -6, -6 };

            ArrayExtension.NegateTo (array);

            Assert.IsTrue (ArrayExtension.Equals (expected, array));
        }

        [TestMethod ()]
        public void NegateToTest_2D ()
        {
            int [,] array = new int [,] { { 4, 7, 9 }, { 6, 6, 1 } };

            int [,] expected = new int [,] { { -4, -7, -9 }, { -6, -6, -1 } };

            ArrayExtension.NegateTo (array);

            Assert.IsTrue (ArrayExtension.Equals (expected, array));
        }

        [TestMethod ()]
        public void MultiplyTest ()
        {
            int [] array       = new int [] { 4, 7, 9, 6, 6 };
            int    coefficient = 3;

            int [] expected = new int [] { 12, 21, 27, 18, 18 };

            int [] actual = new int [array.Length];

            ArrayExtension.Multiply (array, coefficient, actual);

            Assert.IsTrue (ArrayExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void MultiplyToTest ()
        {
            int [] array       = new int [] { 4, 7, 9, 6, 6 };
            int    coefficient = -3;

            int [] expected = new int [] { -12, -21, -27, -18, -18 };

            ArrayExtension.MultiplyTo (array, coefficient);

            Assert.IsTrue (ArrayExtension.Equals (expected, array));
        }

        [TestMethod ()]
        public void DivideTest ()
        {
            double [] array       = new double [] { 4, 7, 9, 6, 6 };
            double    coefficient = 4.0;

            double [] expected = new double [] { 1.0, 1.75, 2.25, 1.5, 1.5 };

            double [] actual = new double [array.Length];

            ArrayExtension.Divide (array, coefficient, actual);

            Assert.IsTrue (ArrayExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void DivideToTest ()
        {
            double [] array       = new double [] { 4, 7, 9, 6, 6 };
            double    coefficient = -4.0;

            double [] expected = new double [] { -1.0, -1.75, -2.25, -1.5, -1.5 };

            ArrayExtension.DivideTo (array, coefficient);

            Assert.IsTrue (ArrayExtension.Equals (expected, array));
        }
    }
}