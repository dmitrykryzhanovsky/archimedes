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

            v [0] = 13;
            v [1] = 21;
            v [2] = 34;
            v [3] = 55;

            Assert.AreEqual (13, v [0]);
            Assert.AreEqual (21, v [1]);
            Assert.AreEqual (34, v [2]);
            Assert.AreEqual (55, v [3]);
        }

        [TestMethod ()]
        public void CoordinatesTest ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            Assert.AreEqual (4, v.Coordinates.Length);
            Assert.AreEqual (2, v.Coordinates [0]);
            Assert.AreEqual (3, v.Coordinates [1]);
            Assert.AreEqual (5, v.Coordinates [2]);
            Assert.AreEqual (8, v.Coordinates [3]);
        }

        [TestMethod ()]
        public void DimensionTest ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            Assert.AreEqual (4, v.Dimension);
        }

        [TestMethod ()]
        public void VectorTest_ArrayParams ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            Assert.AreEqual (4, v.Dimension);
            Assert.AreEqual (2, v [0]);
            Assert.AreEqual (3, v [1]);
            Assert.AreEqual (5, v [2]);
            Assert.AreEqual (8, v [3]);
        }

        [TestMethod ()]
        public void VectorTest_ArrayArray ()
        {
            Vector v = new Vector (new double [] { 2, 3, 5, 8 });

            Assert.AreEqual (4, v.Dimension);
            Assert.AreEqual (2, v [0]);
            Assert.AreEqual (3, v [1]);
            Assert.AreEqual (5, v [2]);
            Assert.AreEqual (8, v [3]);
        }

        [TestMethod ()]
        public void VectorTest_Copying ()
        {
            Vector v = new Vector (2, 3, 5, 8);
            Vector u = new Vector (v);

            Assert.AreEqual (4, u.Dimension);
            Assert.AreEqual (2, u [0]);
            Assert.AreEqual (3, u [1]);
            Assert.AreEqual (5, u [2]);
            Assert.AreEqual (8, u [3]);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Vector v = new Vector (2, 3, 5, 8);
            Vector u = (Vector)v.Clone ();

            Assert.AreEqual (4, u.Dimension);
            Assert.AreEqual (2, u [0]);
            Assert.AreEqual (3, u [1]);
            Assert.AreEqual (5, u [2]);
            Assert.AreEqual (8, u [3]);
        }

        [TestMethod ()]
        public void EqualsTest_Vector_DimensionNotEqual ()
        {
            Vector v = new Vector ( 2, 3, 5 );
            Vector u = new Vector ( 2, 3, 5, 7 );

            bool expected = false;

            bool actual = v.Equals (u);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector_DimensionEqual_CoordinatesNotEqual ()
        {
            Vector v = new Vector (2, 3, 5, 8);
            Vector u = new Vector (2, 3, 5, 7);

            bool expected = false;

            bool actual = v.Equals (u);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector_CoordinatesEqual ()
        {
            Vector v = new Vector (2, 3, 5, 8);
            Vector u = new Vector (2, 3, 5, 8);

            bool expected = true;

            bool actual = v.Equals (u);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector2_DimensionNotEqual ()
        {
            Vector  v = new Vector  (2, 3, 5);
            Vector2 u = new Vector2 (2, 3);

            bool expected = false;

            bool actual = v.Equals (u);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector2_DimensionEqual_CoordinatesNotEqual ()
        {
            Vector  v = new Vector  (2, 3);
            Vector2 u = new Vector2 (5, 7);

            bool expected = false;

            bool actual = v.Equals (u);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector2_CoordinatesEqual ()
        {
            Vector  v = new Vector  (5, 8);
            Vector2 u = new Vector2 (5, 8);

            bool expected = true;

            bool actual = v.Equals (u);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector3_DimensionNotEqual ()
        {
            Vector  v = new Vector  (2, 3, 5, 7);
            Vector3 u = new Vector3 (2, 3, 5);

            bool expected = false;

            bool actual = v.Equals (u);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector3_DimensionEqual_CoordinatesNotEqual ()
        {
            Vector  v = new Vector  (2, 3, 5);
            Vector3 u = new Vector3 (5, 7, 11);

            bool expected = false;

            bool actual = v.Equals (u);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector3_CoordinatesEqual ()
        {
            Vector  v = new Vector  (5, 8, 13);
            Vector3 u = new Vector3 (5, 8, 13);

            bool expected = true;

            bool actual = v.Equals (u);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest_DimensionNotEqual ()
        {
            Vector v = new Vector (2, 3, 5);
            Vector u = new Vector (2, 3, 5, 7);

            bool expected = false;

            bool actual = (v == u);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest_DimensionEqual_CoordinatesNotEqual ()
        {
            Vector v = new Vector (2, 3, 5, 8);
            Vector u = new Vector (2, 3, 5, 7);

            bool expected = false;

            bool actual = (v == u);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest_CoordinatesEqual ()
        {
            Vector v = new Vector (2, 3, 5, 8);
            Vector u = new Vector (2, 3, 5, 8);

            bool expected = true;

            bool actual = (v == u);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest_DimensionNotEqual ()
        {
            Vector v = new Vector (2, 3, 5);
            Vector u = new Vector (2, 3, 5, 7);

            bool expected = true;

            bool actual = (v != u);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest_DimensionEqual_CoordinatesNotEqual ()
        {
            Vector v = new Vector (2, 3, 5, 8);
            Vector u = new Vector (2, 3, 5, 7);

            bool expected = true;

            bool actual = (v != u);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest_CoordinatesEqual ()
        {
            Vector v = new Vector (2, 3, 5, 8);
            Vector u = new Vector (2, 3, 5, 8);

            bool expected = false;

            bool actual = (v != u);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void DotProductTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetLengthTest ()
        {
            Assert.Fail ();
        }
    }
}