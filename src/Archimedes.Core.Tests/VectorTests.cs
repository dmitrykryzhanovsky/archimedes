using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class VectorTests
    {
        [TestMethod ()]
        public void IndexerTest_Get ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            Assert.AreEqual (2, v [0]);
            Assert.AreEqual (3, v [1]);
            Assert.AreEqual (5, v [2]);
            Assert.AreEqual (8, v [3]);
        }

        [TestMethod ()]
        public void IndexerTest_Set ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            v [2] = 13;

            Assert.AreEqual ( 2, v [0]);
            Assert.AreEqual ( 3, v [1]);
            Assert.AreEqual (13, v [2]);
            Assert.AreEqual ( 8, v [3]);
        }

        [TestMethod ()]
        public void CoordinatesTest ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            double [] actual = v.Coordinates;

            Assert.AreEqual (2, actual [0]);
            Assert.AreEqual (3, actual [1]);
            Assert.AreEqual (5, actual [2]);
            Assert.AreEqual (8, actual [3]);
        }

        [TestMethod ()]
        public void DimensionTest ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            int expected = 4;

            int actual = v.Dimension;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void VectorTest_Array ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            Assert.AreEqual (4, v.Dimension);
            Assert.AreEqual (2, v [0]);
            Assert.AreEqual (3, v [1]);
            Assert.AreEqual (5, v [2]);
            Assert.AreEqual (8, v [3]);
        }

        [TestMethod ()]
        public void VectorTest_Vector ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            Vector v2 = new Vector (v1);

            Assert.AreEqual (4, v2.Dimension);
            Assert.AreEqual (2, v2 [0]);
            Assert.AreEqual (3, v2 [1]);
            Assert.AreEqual (5, v2 [2]);
            Assert.AreEqual (8, v2 [3]);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            Vector v2 = (Vector)v1.Clone ();

            Assert.AreEqual (4, v2.Dimension);
            Assert.AreEqual (2, v2 [0]);
            Assert.AreEqual (3, v2 [1]);
            Assert.AreEqual (5, v2 [2]);
            Assert.AreEqual (8, v2 [3]);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqualDimension ()
        {
            Vector v1 = new Vector (2);
            Vector v2 = new Vector (3, 4);

            Assert.IsFalse (v1.Equals (v2));
            Assert.IsFalse (v1 == v2);
            Assert.IsTrue (v1 != v2);
        }

        [TestMethod ()]
        public void EqualsTest_EqualDimension_NotEqualCoordinates ()
        {
            Vector v1 = new Vector (2, 3, 5);
            Vector v2 = new Vector (2, 3, 7);

            Assert.IsFalse (v1.Equals (v2));
            Assert.IsFalse (v1 == v2);
            Assert.IsTrue (v1 != v2);
        }

        [TestMethod ()]
        public void EqualsTest_EqualDimension_EqualCoordinates ()
        {
            Vector v1 = new Vector (2, 3, 5);
            Vector v2 = new Vector (2, 3, 5);

            Assert.IsTrue (v1.Equals (v2));
            Assert.IsTrue (v1 == v2);
            Assert.IsFalse (v1 != v2);
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Vector v1 = new Vector (2, 3, 5);
            Vector v2 = new Vector (7, 11, 13);

            Vector expected = new Vector (9, 14, 18);

            Vector actual = v1 + v2;

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1]);
            Assert.AreEqual (expected [2], actual [2]);
        }

        [TestMethod ()]
        public void opAddTest_Exception_NotCompatibleDimension ()
        {
            Vector v1 = new Vector (2, 3, 5);
            Vector v2 = new Vector (7, 11, 13, 17);

            bool wasException = false;

            try
            {
                Vector actual = v1 + v2;
            }

            catch (VectorVectorNotCompatibleDimensionException)
            {
                wasException = true;
            }

            Assert.IsTrue (wasException);
        }

        [TestMethod ()]
        public void opSubTest ()
        {
            Vector v1 = new Vector (2, 3, 5);
            Vector v2 = new Vector (7, 11, 13);

            Vector expected = new Vector (-5, -8, -8);

            Vector actual = v1 - v2;

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1]);
            Assert.AreEqual (expected [2], actual [2]);
        }

        [TestMethod ()]
        public void opSubTest_Exception_NotCompatibleDimension ()
        {
            Vector v1 = new Vector (2, 3, 5);
            Vector v2 = new Vector (7, 11, 13, 17);

            bool wasException = false;

            try
            {
                Vector actual = v1 - v2;
            }

            catch (VectorVectorNotCompatibleDimensionException)
            {
                wasException = true;
            }

            Assert.IsTrue (wasException);
        }

        [TestMethod ()]
        public void opNegTest ()
        {
            Vector v = new Vector (2, 3, 5);

            Vector expected = new Vector (-2, -3, -5);

            Vector actual = -v;

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1]);
            Assert.AreEqual (expected [2], actual [2]);
        }

        [TestMethod ()]
        public void opMulTest_VectorScalar ()
        {
            Vector v = new Vector (2, 3, 5);
            double coefficient = 4;

            Vector expected = new Vector (8, 12, 20);

            Vector actual = v * coefficient;

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1]);
            Assert.AreEqual (expected [2], actual [2]);
        }

        [TestMethod ()]
        public void opMulTest_ScalarVector ()
        {
            Vector v = new Vector (2, 3, 5);
            double coefficient = 4;

            Vector expected = new Vector (8, 12, 20);

            Vector actual = coefficient * v;

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1]);
            Assert.AreEqual (expected [2], actual [2]);
        }

        [TestMethod ()]
        public void opDivTest ()
        {
            Vector v = new Vector (2, 3, 5);
            double coefficient = 4;

            Vector expected = new Vector (0.5, 0.75, 1.25);

            Vector actual = v / coefficient;

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1]);
            Assert.AreEqual (expected [2], actual [2]);
        }

        [TestMethod ()]
        public void opMulTest_DotProduct ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = new Vector (11, 13, 17, 19);

            double expected = 279;

            double actual = v1 * v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMulTest_DotProduct_NotCompatibleDimension ()
        {
            Vector v1 = new Vector (2, 3, 5);
            Vector v2 = new Vector (11, 13, 17, 19);

            bool wasException = false;

            try
            {
                double actual = v1 * v2;
            }

            catch (VectorVectorNotCompatibleDimensionException)
            {
                wasException = true;
            }

            Assert.IsTrue (wasException);
        }

        [TestMethod ()]
        public void DotProductTest ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = new Vector (11, 13, 17, 19);

            double expected = 279;

            double actual = Vector.DotProduct (v1, v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void DotProductTest_NotCompatibleDimension ()
        {
            Vector v1 = new Vector (2, 3, 5);
            Vector v2 = new Vector (11, 13, 17, 19);

            bool wasException = false;

            try
            {
                double actual = Vector.DotProduct (v1, v2);
            }

            catch (VectorVectorNotCompatibleDimensionException)
            {
                wasException = true;
            }

            Assert.IsTrue (wasException);
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Vector v = new Vector (3, 4, 5, 7);

            double expected = 99;

            double actual = v.GetNorm2 ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetLengthTest ()
        {
            Vector v = new Vector (3, 4, 5, 7);

            double expected = 9.94987437106619955;

            double actual = v.GetLength ();

            Assert.AreEqual (expected, actual);
        }
    }
}