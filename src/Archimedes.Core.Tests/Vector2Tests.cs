using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Vector2Tests
    {
        [TestMethod ()]
        public void XTest_Get ()
        {
            Vector2 v = new Vector2 (3, 4);

            Assert.AreEqual (3, v.X);
        }

        [TestMethod ()]
        public void XTest_Set ()
        {
            Vector2 v = new Vector2 (3, 4);

            v.X = 5;

            Assert.AreEqual (5, v [0]);
            Assert.AreEqual (5, v.X);
        }

        [TestMethod ()]
        public void YTest_Get ()
        {
            Vector2 v = new Vector2 (3, 4);

            Assert.AreEqual (4, v.Y);
        }

        [TestMethod ()]
        public void YTest_Set ()
        {
            Vector2 v = new Vector2 (3, 4);

            v.Y = 5;

            Assert.AreEqual (5, v [1]);
            Assert.AreEqual (5, v.Y);
        }

        [TestMethod ()]
        public void DimensionTest ()
        {
            Vector2 v = new Vector2 (3, 4);

            int expected = 2;

            int actual = v.Dimension;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Vector2Test_Array ()
        {
            Vector2 v = new Vector2 (3, 4);

            Assert.AreEqual (2, v.Dimension);
            Assert.AreEqual (3, v [0]);
            Assert.AreEqual (4, v [1]);
        }

        [TestMethod ()]
        public void Vector2Test_Vector2 ()
        {
            Vector2 v1 = new Vector2 (3, 4);
            Vector2 v2 = new Vector2 (v1);

            Assert.AreEqual (2, v2.Dimension);
            Assert.AreEqual (3, v2.X);
            Assert.AreEqual (4, v2.Y);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Vector2 v1 = new Vector2 (3, 4);
            Vector2 v2 = (Vector2)v1.Clone ();

            Assert.AreEqual (2, v2.Dimension);
            Assert.AreEqual (3, v2.X);
            Assert.AreEqual (4, v2.Y);
        }

        [TestMethod ()]
        public void EqualsTest_Equal ()
        {
            Vector2 v1 = new Vector2 (3, 4);
            Vector2 v2 = new Vector2 (3, 4);

            Assert.IsTrue (v1.Equals (v2));
            Assert.IsTrue (v1 == v2);
            Assert.IsFalse (v1 != v2);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqual_X ()
        {
            Vector2 v1 = new Vector2 (3, 4);
            Vector2 v2 = new Vector2 (5, 4);

            Assert.IsFalse (v1.Equals (v2));
            Assert.IsFalse (v1 == v2);
            Assert.IsTrue (v1 != v2);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqual_Y ()
        {
            Vector2 v1 = new Vector2 (3, 4);
            Vector2 v2 = new Vector2 (3, 5);

            Assert.IsFalse (v1.Equals (v2));
            Assert.IsFalse (v1 == v2);
            Assert.IsTrue (v1 != v2);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqual_XY ()
        {
            Vector2 v1 = new Vector2 (3, 4);
            Vector2 v2 = new Vector2 (5, 6);

            Assert.IsFalse (v1.Equals (v2));
            Assert.IsFalse (v1 == v2);
            Assert.IsTrue (v1 != v2);
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Vector2 v1 = new Vector2 (2,  3);
            Vector2 v2 = new Vector2 (7, 11);

            Vector2 expected = new Vector2 (9, 14);

            Vector2 actual = v1 + v2;

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y);
        }

        [TestMethod ()]
        public void opSubTest ()
        {
            Vector2 v1 = new Vector2 (2,  3);
            Vector2 v2 = new Vector2 (7, 11);

            Vector2 expected = new Vector2 (-5, -8);

            Vector2 actual = v1 - v2;

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y);
        }

        [TestMethod ()]
        public void opNegTest ()
        {
            Vector2 v = new Vector2 (2, 3);

            Vector2 expected = new Vector2 (-2, -3);

            Vector2 actual = -v;

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y);
        }

        [TestMethod ()]
        public void opMulTest_VectorScalar ()
        {
            Vector2 v = new Vector2 (2, 3);
            double  coefficient = 4;

            Vector2 expected = new Vector2 (8, 12);

            Vector2 actual = v * coefficient;

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y);
        }

        [TestMethod ()]
        public void opMulTest_ScalarVector ()
        {
            Vector2 v = new Vector2 (2, 3);
            double  coefficient = 4;

            Vector2 expected = new Vector2 (8, 12);

            Vector2 actual = coefficient * v;

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y);
        }

        [TestMethod ()]
        public void opDivTest ()
        {
            Vector2 v = new Vector2 (2, 3);
            double  coefficient = 4;

            Vector2 expected = new Vector2 (0.5, 0.75);

            Vector2 actual = v / coefficient;

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y);
        }

        [TestMethod ()]
        public void opMulTest_DotProduct ()
        {
            Vector2 v1 = new Vector2 (2,  3);
            Vector2 v2 = new Vector2 (7, 11);

            double expected = 47;

            double actual = v1 * v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void DotProductTest ()
        {
            Vector2 v1 = new Vector2 (2,  3);
            Vector2 v2 = new Vector2 (7, 11);

            double expected = 47;

            double actual = Vector.DotProduct (v1, v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Vector2 v = new Vector2 (3, 4);

            double expected = 25;

            double actual = v.GetNorm2 ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetLengthTest ()
        {
            Vector2 v = new Vector2 (3, 4);

            double expected = 5;

            double actual = v.GetLength ();

            Assert.AreEqual (expected, actual);
        }
    }
}