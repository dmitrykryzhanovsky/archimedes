using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Vector3Tests
    {
        [TestMethod ()]
        public void XTest_Get ()
        {
            Vector3 v = new Vector3 (3, 4, 7);

            Assert.AreEqual (3, v.X);
        }

        [TestMethod ()]
        public void XTest_Set ()
        {
            Vector3 v = new Vector3 (3, 4, 7);

            v.X = 5;

            Assert.AreEqual (5, v [0]);
            Assert.AreEqual (5, v.X);
        }

        [TestMethod ()]
        public void YTest_Get ()
        {
            Vector3 v = new Vector3 (3, 4, 7);

            Assert.AreEqual (4, v.Y);
        }

        [TestMethod ()]
        public void YTest_Set ()
        {
            Vector3 v = new Vector3 (3, 4, 7);

            v.Y = 5;

            Assert.AreEqual (5, v [1]);
            Assert.AreEqual (5, v.Y);
        }

        [TestMethod ()]
        public void ZTest_Get ()
        {
            Vector3 v = new Vector3 (3, 4, 7);

            Assert.AreEqual (7, v.Z);
        }

        [TestMethod ()]
        public void ZTest_Set ()
        {
            Vector3 v = new Vector3 (3, 4, 7);

            v.Z = 8;

            Assert.AreEqual (8, v [2]);
            Assert.AreEqual (8, v.Z);
        }

        [TestMethod ()]
        public void DimensionTest ()
        {
            Vector3 v = new Vector3 (3, 4, 7);

            int expected = 3;

            int actual = v.Dimension;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Vector3Test_Array ()
        {
            Vector3 v = new Vector3 (3, 4, 7);

            Assert.AreEqual (3, v.Dimension);
            Assert.AreEqual (3, v [0]);
            Assert.AreEqual (4, v [1]);
            Assert.AreEqual (7, v [2]);
        }

        [TestMethod ()]
        public void Vector3Test_Vector3 ()
        {
            Vector3 v1 = new Vector3 (3, 4, 7);
            Vector3 v2 = new Vector3 (v1);

            Assert.AreEqual (3, v2.Dimension);
            Assert.AreEqual (3, v2.X);
            Assert.AreEqual (4, v2.Y);
            Assert.AreEqual (7, v2.Z);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Vector3 v1 = new Vector3 (3, 4, 7);
            Vector3 v2 = (Vector3)v1.Clone ();

            Assert.AreEqual (3, v2.Dimension);
            Assert.AreEqual (3, v2.X);
            Assert.AreEqual (4, v2.Y);
            Assert.AreEqual (7, v2.Z);
        }

        [TestMethod ()]
        public void EqualsTest_Equal ()
        {
            Vector3 v1 = new Vector3 (3, 4, 5);
            Vector3 v2 = new Vector3 (3, 4, 5);

            Assert.IsTrue (v1.Equals (v2));
            Assert.IsTrue (v1 == v2);
            Assert.IsFalse (v1 != v2);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqual_OneItemMatches ()
        {
            Vector3 v1 = new Vector3 (3, 4, 5);
            Vector3 v2 = new Vector3 (3, 7, 8);

            Assert.IsFalse (v1.Equals (v2));
            Assert.IsFalse (v1 == v2);
            Assert.IsTrue (v1 != v2);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqual_NoItemMatches ()
        {
            Vector3 v1 = new Vector3 (3, 4, 5);
            Vector3 v2 = new Vector3 (6, 7, 8);

            Assert.IsFalse (v1.Equals (v2));
            Assert.IsFalse (v1 == v2);
            Assert.IsTrue (v1 != v2);
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (7, 11, 13);

            Vector3 expected = new Vector3 (9, 14, 18);

            Vector3 actual = v1 + v2;

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y);
            Assert.AreEqual (expected.Z, actual.Z);
        }

        [TestMethod ()]
        public void opSubTest ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (7, 11, 13);

            Vector3 expected = new Vector3 (-5, -8, -8);

            Vector3 actual = v1 - v2;

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y);
            Assert.AreEqual (expected.Z, actual.Z);
        }

        [TestMethod ()]
        public void opNegTest ()
        {
            Vector3 v = new Vector3 (2, 3, 5);

            Vector3 expected = new Vector3 (-2, -3, -5);

            Vector3 actual = -v;

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y);
            Assert.AreEqual (expected.Z, actual.Z);
        }

        [TestMethod ()]
        public void opMulTest_VectorScalar ()
        {
            Vector3 v = new Vector3 (2, 3, 5);
            double  coefficient = 4;

            Vector3 expected = new Vector3 (8, 12, 20);

            Vector3 actual = v * coefficient;

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y);
            Assert.AreEqual (expected.Z, actual.Z);
        }

        [TestMethod ()]
        public void opMulTest_ScalarVector ()
        {
            Vector3 v = new Vector3 (2, 3, 5);
            double  coefficient = 4;

            Vector3 expected = new Vector3 (8, 12, 20);

            Vector3 actual = coefficient * v;

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y);
            Assert.AreEqual (expected.Z, actual.Z);
        }

        [TestMethod ()]
        public void opDivTest ()
        {
            Vector3 v = new Vector3 (2, 3, 5);
            double  coefficient = 4;

            Vector3 expected = new Vector3 (0.5, 0.75, 1.25);

            Vector3 actual = v / coefficient;

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y);
            Assert.AreEqual (expected.Z, actual.Z);
        }

        [TestMethod ()]
        public void opMulTest_DotProduct ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (7, 11, 13);

            double expected = 112;

            double actual = v1 * v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void DotProductTest ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (7, 11, 13);

            double expected = 112;

            double actual = Vector.DotProduct (v1, v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void CrossProductTest_100_010 ()
        {
            Vector3 v1 = new Vector3 (1, 0, 0);
            Vector3 v2 = new Vector3 (0, 1, 0);

            Vector3 expected = new Vector3 (0, 0, 1);

            Vector3 actual = Vector3.CrossProduct (v1, v2);

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y);
            Assert.AreEqual (expected.Z, actual.Z);
        }

        [TestMethod ()]
        public void CrossProductTest_VectorsInOXY ()
        {
            Vector3 v1 = new Vector3 (1, 0, 0);
            Vector3 v2 = new Vector3 (1.5 * double.Sqrt (3.0), 1.5, 0);

            Vector3 expected = new Vector3 (0, 0, 1.5);

            Vector3 actual = Vector3.CrossProduct (v1, v2);

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y);
            Assert.AreEqual (expected.Z, actual.Z);
        }

        [TestMethod ()]
        public void CrossProductTest_Common ()
        {
            Vector3 v1 = new Vector3 (1, 2, 3);
            Vector3 v2 = new Vector3 (4, 5, 6);

            Vector3 expected = new Vector3 (-3, 6, -3);

            Vector3 actual = Vector3.CrossProduct (v1, v2);

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y);
            Assert.AreEqual (expected.Z, actual.Z);
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Vector3 v = new Vector3 (3, 4, 5);

            double expected = 50;

            double actual = v.GetNorm2 ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetLengthTest ()
        {
            Vector3 v = new Vector3 (3, 4, 5);

            double expected = 7.07106781186547524;

            double actual = v.GetLength ();

            Assert.AreEqual (expected, actual);
        }
    }
}