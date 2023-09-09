using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

using Archimedes;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class VectorTests
    {
        [TestMethod ()]
        public void Indexer_GetTest ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            double expected = 8;

            double actual = v [3];

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Indexer_SetTest ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            v [3] = 7;

            double expected = 7;

            double actual = v [3];

            Assert.AreEqual (expected, actual);
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
        public void ComponentsTest ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            double [] expected = new double [] { 2, 3, 5, 8 };

            double [] actual = v.Components;

            Assert.AreEqual (true, expected.Equals<double> (actual));
        }

        [TestMethod ()]
        public void Constructor_ByDimensionTest ()
        {
            Vector v = new Vector (4);

            int expected = 4;

            int actual = v.Dimension;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Constructor_ByArrayTest ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            Assert.AreEqual (4, v.Dimension);
            Assert.AreEqual (2, v [0]);
            Assert.AreEqual (3, v [1]);
            Assert.AreEqual (5, v.Components [2]);
            Assert.AreEqual (8, v.Components [3]);
        }

        [TestMethod ()]
        public void Constructor_CopyTest ()
        {
            Vector expected = new Vector (2, 3, 5, 8);

            Vector actual = new Vector (expected);

            Assert.AreEqual (4, actual.Dimension);
            Assert.AreEqual (2, actual [0]);
            Assert.AreEqual (3, actual [1]);
            Assert.AreEqual (5, actual.Components [2]);
            Assert.AreEqual (8, actual.Components [3]);
            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Vector expected = new Vector (2, 3, 5, 8);

            Vector actual = (Vector)expected.Clone ();

            Assert.AreEqual (4, actual.Dimension);
            Assert.AreEqual (2, actual [0]);
            Assert.AreEqual (3, actual [1]);
            Assert.AreEqual (5, actual.Components [2]);
            Assert.AreEqual (8, actual.Components [3]);
            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Explicit_MatrixTest ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            Matrix expected = new Matrix (new double [,] { { 2 }, { 3 }, { 5 }, { 8 } });

            Matrix actual = (Matrix)v;

            Assert.AreEqual (4, actual.Height);
            Assert.AreEqual (1, actual.Width);
            Assert.AreEqual (2, actual [0, 0]);
            Assert.AreEqual (3, actual [1, 0]);
            Assert.AreEqual (5, actual [2, 0]);
            Assert.AreEqual (8, actual [3, 0]);
            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals_ByVectorTest_EqualDimension_EqualComponents ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = new Vector (2, 3, 5, 7);

            bool expected = true;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals_ByVectorTest_EqualDimension_NotEqualComponents ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = new Vector (2, 3, 5, 8);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals_ByVectorTest_NotEqualDimension ()
        {
            Vector v1 = new Vector (2, 3, 5);
            Vector v2 = new Vector (2, 3, 5, 8);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals_ByObjectTest_VectorEqual ()
        {
            Vector v = new Vector (2, 3, 5, 8);
            object o = new Vector (2, 3, 5, 8);

            bool expected = true;

            bool actual = v.Equals (o);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals_ByObjectTest_VectorNotEqual ()
        {
            Vector v = new Vector (2, 3, 5, 7);
            object o = new Vector (2, 3, 5, 8);

            bool expected = false;

            bool actual = v.Equals (o);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals_ByObjectTest_Vector2Equal ()
        {
            Vector v = new Vector (5, 8);
            object o = new Vector2 (5, 8);

            bool expected = true;

            bool actual = v.Equals (o);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals_ByObjectTest_Vector2NotEqual ()
        {
            Vector v = new Vector (5, 7);
            object o = new Vector2 (5, 8);

            bool expected = false;

            bool actual = v.Equals (o);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals_ByObjectTest_Vector3Equal ()
        {
            Vector v = new Vector (5, 8, 13);
            object o = new Vector3 (5, 8, 13);

            bool expected = true;

            bool actual = v.Equals (o);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals_ByObjectTest_Vector3NotEqual ()
        {
            Vector v = new Vector (5, 8, 13);
            object o = new Vector3 (5, 8, 14);

            bool expected = false;

            bool actual = v.Equals (o);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Equals_ByObjectTest_NoVector ()
        {
            Vector v = new Vector (5, 8, 13);
            object o = "МИРУ МИР";

            bool invalidCastException = false;

            try
            {
                v.Equals (o);
            }

            catch (InvalidCastException)
            {
                invalidCastException = true;
            }

            Assert.AreEqual (true, invalidCastException);
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

        [TestMethod ()]
        public void VectorTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void VectorTest2 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void CloneTest1 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void EqualsTest2 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void EqualsTest3 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetHashCodeTest1 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void DotProductTest1 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetNorm2Test1 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetLengthTest1 ()
        {
            Assert.Fail ();
        }        

        [TestMethod ()]
        public void VectorTest3 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void CloneTest2 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void EqualsTest4 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void EqualsTest5 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetHashCodeTest2 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void DotProductTest2 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetNorm2Test2 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetLengthTest2 ()
        {
            Assert.Fail ();
        }
    }
}