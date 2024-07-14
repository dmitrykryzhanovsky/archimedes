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

            double expected = 2;

            double actual = v [0];

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IndexerTest_Set ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            v [1] = 5;

            double expected = 5;

            double actual = v [1];

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void CoordinatesTest ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            double [] expected = new double [] { 2, 3, 5, 8 };

            double [] actual = v.Coordinates;

            Assert.AreEqual (true, expected.Equals<double> (actual));
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
        public void VectorTest_Coordinates ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            Assert.AreEqual (2, v [0]);
            Assert.AreEqual (3, v [1]);
            Assert.AreEqual (5, v [2]);
            Assert.AreEqual (8, v [3]);
        }

        [TestMethod ()]
        public void VectorTest_Copying ()
        {
            Vector other = new Vector (2, 3, 5, 8);
            Vector v     = new Vector (other);

            Assert.AreEqual (2, v [0]);
            Assert.AreEqual (3, v [1]);
            Assert.AreEqual (5, v [2]);
            Assert.AreEqual (8, v [3]);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Vector other = new Vector (2, 3, 5, 8);
            Vector v     = (Vector)other.Clone ();

            Assert.AreEqual (2, v [0]);
            Assert.AreEqual (3, v [1]);
            Assert.AreEqual (5, v [2]);
            Assert.AreEqual (8, v [3]);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqualDimension ()
        {
            Vector v1 = new Vector (2, 3, 5);
            Vector v2 = new Vector (2, 3, 5, 8);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqualComponents ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = new Vector (2, 3, 5, 8);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualComponents ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            Vector v2 = new Vector (2, 3, 5, 8);

            bool expected = true;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            Vector v2 = new Vector (2, 3, 5, 8);

            bool expected = true;

            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            Vector v2 = new Vector (2, 3, 5, 8);

            bool expected = false;

            bool actual = (v1 != v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetLengthTest ()
        {
            Vector v = new Vector (3, 4, 5, 6);

            double expected = 9.27361849549570375;

            double actual = v.GetLength ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Vector v = new Vector (3, 4, 5, 6);

            double expected = 86;

            double actual = v.GetNorm2 ();

            Assert.AreEqual (expected, actual);
        }
    }
}