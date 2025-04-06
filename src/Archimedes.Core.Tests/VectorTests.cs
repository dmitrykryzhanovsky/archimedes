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
    }
}