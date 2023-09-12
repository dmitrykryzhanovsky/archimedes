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
        public void opEqualsTest_Equal ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = new Vector (2, 3, 5, 7);

            bool expected = true;

            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualsTest_NotEqual ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = new Vector (2, 3, 5, 8);

            bool expected = false;

            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualsTest_Equal ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = new Vector (2, 3, 5, 7);

            bool expected = false;

            bool actual = (v1 != v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualsTest_NotEqual ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = new Vector (2, 3, 5);

            bool expected = true;

            bool actual = (v1 != v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opAddTest_Common ()
        {
            Vector v1 = new Vector (2, 3, 5, 8, 13);
            Vector v2 = new Vector (19, 23, 29, 31, 37);

            Vector expected = new Vector (21, 26, 34, 39, 50);

            Vector actual = v1 + v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opAddTest_NotCompatible ()
        {
            Vector v1 = new Vector (2, 3, 5, 8, 13);
            Vector v2 = new Vector (19, 23, 29, 31);

            bool vectorNotCompatibleException = false;

            try
            {
                _ = v1 + v2;
            }

            catch (VectorNotCompatibleException)
            {
                vectorNotCompatibleException = true;
            }

            Assert.AreEqual (true, vectorNotCompatibleException);
        }

        [TestMethod ()]
        public void DotProductTest_Common ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = new Vector (11, 13, 19, 23);

            double expected = 317;

            double actual = v1.DotProduct (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void DotProductTest_Dimension1 ()
        {
            Vector v1 = new Vector (2.0);
            Vector v2 = new Vector (11.0);

            double expected = 22.0;

            double actual = v1.DotProduct (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void DotProductTest_Dimension0 ()
        {
            Vector v1 = new Vector (0);
            Vector v2 = new Vector (0);

            double expected = 0.0;

            double actual = v1.DotProduct (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void DotProductTest_IncompatibleDimensions ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Vector v2 = new Vector (11, 13, 19, 23, 29);

            bool vectorNotCompatibleException = false;

            try
            {
                v1.DotProduct (v2);
            }

            catch (VectorNotCompatibleException)
            {
                vectorNotCompatibleException = true;
            }

            Assert.AreEqual (true, vectorNotCompatibleException);
        }

        [TestMethod ()]
        public void GetNorm2Test_Common ()
        {
            Vector v = new Vector (8, 6, 10, 5);

            double expected = 225;

            double actual = v.GetNorm2 ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetNorm2Test_Dimension1 ()
        {
            Vector v = new Vector (8.0);

            double expected = 64.0;

            double actual = v.GetNorm2 ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetNorm2Test_Dimension0 ()
        {
            Vector v = new Vector (0);

            double expected = 0.0;

            double actual = v.GetNorm2 ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetLengthTest_Common ()
        {
            Vector v = new Vector (8, 6, 10, 5);

            double expected = 15;

            double actual = v.GetLength ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetLengthTest_Dimension1 ()
        {
            Vector v = new Vector (8.0);

            double expected = 8.0;

            double actual = v.GetLength ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetLengthTest_Dimension0 ()
        {
            Vector v = new Vector (0);

            double expected = 0.0;

            double actual = v.GetLength ();

            Assert.AreEqual (expected, actual);
        }
    }
}