using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class VectorTests
    {
        [TestMethod ()]
        public void IndexerTest_Get ()
        {
            Vector v  = new Vector (2, 3, 5, 7);
            int index = 2;

            double expected = 5;

            double actual = v [index];

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IndexerTest_Set ()
        {
            Vector v  = new Vector (2, 3, 5, 7);
            int index = 3;
            int value = 8;

            double expected = 8;

            v [index] = value;
            double actual = v [index];

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void CoordinatesTest ()
        {
            Vector v = new Vector (2, 3, 5, 7);

            double [] expected = new double [] { 2, 3, 5, 7 };

            double [] actual = v.Coordinates;

            Assert.AreEqual (true, expected.Equals<double> (actual));
        }

        [TestMethod ()]
        public void DimensionTest ()
        {
            Vector v = new Vector (2, 3, 5, 7);

            int expected = 4;

            int actual = v.Dimension;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void VectorTest_Dimension_1 ()
        {
            Vector v = new Vector (4);

            int expected = 4;

            int actual = v.Dimension;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void VectorTest_Dimension_2 ()
        {
            Vector v = new Vector (4);

            int expected = 4;

            int actual = v.Coordinates.Length;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void VectorTest_Coordinates_1 ()
        {
            Vector v = new Vector (2, 3, 5, 7);

            Assert.AreEqual (2, v [0]);
            Assert.AreEqual (3, v [1]);
            Assert.AreEqual (5, v [2]);
            Assert.AreEqual (7, v [3]);
        }

        [TestMethod ()]
        public void VectorTest_Coordinates_2 ()
        {
            Vector v = new Vector (2, 3, 5, 7);

            Assert.AreEqual (2, v.Coordinates [0]);
            Assert.AreEqual (3, v.Coordinates [1]);
            Assert.AreEqual (5, v.Coordinates [2]);
            Assert.AreEqual (7, v.Coordinates [3]);
        }

        [TestMethod ()]
        public void VectorTest_Copy_1 ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = new Vector (v1);

            Assert.AreEqual (4, v2.Dimension);
            Assert.AreEqual (2, v2 [0]);
            Assert.AreEqual (3, v2 [1]);
            Assert.AreEqual (5, v2 [2]);
            Assert.AreEqual (7, v2 [3]);
        }

        [TestMethod ()]
        public void VectorTest_Copy_2 ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = new Vector (v1);

            double [] expected = new double [] { 2, 3, 5, 7 };

            double [] actual = v2.Coordinates;

            Assert.AreEqual (true, expected.Equals<double> (actual));
        }

        [TestMethod ()]
        public void CloneTest_1 ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = (Vector)v1.Clone ();

            Assert.AreEqual (4, v2.Dimension);
            Assert.AreEqual (2, v2 [0]);
            Assert.AreEqual (3, v2 [1]);
            Assert.AreEqual (5, v2 [2]);
            Assert.AreEqual (7, v2 [3]);
        }

        [TestMethod ()]
        public void CloneTest_2 ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = (Vector)v1.Clone ();

            double [] expected = new double [] { 2, 3, 5, 7 };

            double [] actual = v2.Coordinates;

            Assert.AreEqual (true, expected.Equals<double> (actual));
        }

        [TestMethod ()]
        public void EqualsTest_DifferentDimension ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = new Vector (2, 3, 5, 7, 11);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualDimension_DifferentCoordinates ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = new Vector (2, 3, 5, 8);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualDimension_EqualCoordinates ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = new Vector (2, 3, 5, 7);

            bool expected = true;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualsTest_True ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = new Vector (2, 3, 5, 7);

            bool expected = true;

            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualsTest_False ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = new Vector (2, 3, 5, 8);

            bool expected = false;

            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualsTest_True ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = new Vector (2, 3, 5, 8);

            bool expected = true;

            bool actual = (v1 != v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualsTest_False ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = new Vector (2, 3, 5, 7);

            bool expected = false;

            bool actual = (v1 != v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Vector v1 = new Vector ( 2,  3,  5,  7);
            Vector v2 = new Vector (11, 13, 19, 23);

            Vector expected = new Vector (13, 16, 24, 30);

            Vector actual = v1 + v2;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opSubtractTest ()
        {
            Vector v1 = new Vector ( 2,  3,  5,  7);
            Vector v2 = new Vector (11, 13, 19, 23);

            Vector expected = new Vector (-9, -10, -14, -16);

            Vector actual = v1 - v2;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opNegateTest ()
        {
            Vector v = new Vector (2, 3, 5, 7);

            Vector expected = new Vector (-2, -3, -5, -7);

            Vector actual = -v;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_VectorByCoefficient ()
        {
            Vector v = new Vector (2, 3, 5, 7);
            double coefficient = 3;

            Vector expected = new Vector (6, 9, 15, 21);

            Vector actual = v * coefficient;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_CoefficientByVector ()
        {
            Vector v = new Vector (2, 3, 5, 7);
            double coefficient = 3;

            Vector expected = new Vector (6, 9, 15, 21);

            Vector actual = coefficient * v;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opDivideTest ()
        {
            Vector v = new Vector (2, 3, 5, 7);
            double coefficient = 2;

            Vector expected = new Vector (1, 1.5, 2.5, 3.5);

            Vector actual = v / coefficient;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_DotProduct ()
        {
            Vector v1 = new Vector ( 2,  3,  5,  7);
            Vector v2 = new Vector (11, 13, 19, 23);

            double expected = 317;

            double actual = v1 * v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetLengthTest ()
        {
            Vector v = new Vector (2, 3, 5, 7);

            double expected = 9.32737905308881505;

            double actual = v.GetLength ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Vector v = new Vector (2, 3, 5, 7);

            double expected = 87;

            double actual = v.GetNorm2 ();

            Assert.AreEqual (expected, actual);
        }
    }
}