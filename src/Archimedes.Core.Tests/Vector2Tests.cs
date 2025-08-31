using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Vector2Tests
    {
        [TestMethod ()]
        public void XTest_Get ()
        {
            Vector2 v = new Vector2 (5, 8);

            Assert.AreEqual (5, v.X);
        }

        [TestMethod ()]
        public void XTest_Set ()
        {
            Vector2 v = new Vector2 (5, 8);

            v.X = 13;

            Assert.AreEqual (13, v.X);
        }

        [TestMethod ()]
        public void YTest_Get ()
        {
            Vector2 v = new Vector2 (5, 8);

            Assert.AreEqual (8, v.Y);
        }

        [TestMethod ()]
        public void YTest_Set ()
        {
            Vector2 v = new Vector2 (5, 8);

            v.Y = 21;

            Assert.AreEqual (21, v.Y);
        }

        [TestMethod ()]
        public void DimensionTest ()
        {
            Vector2 v = new Vector2 (5, 8);

            Assert.AreEqual (2, v.Dimension);
        }

        [TestMethod ()]
        public void Vector2Test_XY ()
        {
            Vector2 v = new Vector2 (5, 8);

            Assert.AreEqual (2, v.Dimension);
            Assert.AreEqual (5, v [0]);
            Assert.AreEqual (8, v [1]);
            Assert.AreEqual (5, v.X);
            Assert.AreEqual (8, v.Y);
        }

        [TestMethod ()]
        public void Vector2Test_Copying ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            Vector2 v2 = new Vector2 (v1);

            Assert.AreEqual (2, v2.Dimension);
            Assert.AreEqual (5, v2 [0]);
            Assert.AreEqual (8, v2 [1]);
            Assert.AreEqual (5, v2.X);
            Assert.AreEqual (8, v2.Y);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            Vector2 v2 = (Vector2)v1.Clone ();

            Assert.AreEqual (2, v2.Dimension);
            Assert.AreEqual (5, v2 [0]);
            Assert.AreEqual (8, v2 [1]);
            Assert.AreEqual (5, v2.X);
            Assert.AreEqual (8, v2.Y);
        }

        [TestMethod ()]
        public void EqualsTest_Vector2_CoordinatesNotEqual ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = new Vector2 (5, 8);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector2_CoordinatesEqual ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            Vector2 v2 = new Vector2 (5, 8);

            bool expected = true;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector_DimensionNotEqual ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            Vector  v2 = new Vector  (2, 3, 5);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector_DimensionEqual_CoordinatesNotEqual ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            Vector  v2 = new Vector  (2, 3);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector_CoordinatesEqual ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            Vector  v2 = new Vector  (5, 8);

            bool expected = true;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest_CoordinatesNotEqual ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            Vector2 v2 = new Vector2 (13, 21);

            bool expected = false;

            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest_CoordinatesEqual ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            Vector2 v2 = new Vector2 (5, 8);

            bool expected = true;

            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest_CoordinatesNotEqual ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            Vector2 v2 = new Vector2 (13, 21);

            bool expected = true;

            bool actual = (v1 != v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest_CoordinatesEqual ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            Vector2 v2 = new Vector2 (5, 8);

            bool expected = false;

            bool actual = (v1 != v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = new Vector2 (13, 21);

            Vector2 expected = new Vector2 (15, 24);

            Vector2 actual = v1 + v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opSubtractTest ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = new Vector2 (13, 21);

            Vector2 expected = new Vector2 (-11, -18);

            Vector2 actual = v1 - v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNegateTest ()
        {
            Vector2 v = new Vector2 (2, 3);

            Vector2 expected = new Vector2 (-2, -3);

            Vector2 actual = -v;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_Vector2ByCoefficient ()
        {
            Vector2 v           = new Vector2 (2, 3);
            double  coefficient = 3;

            Vector2 expected = new Vector2 (6, 9);

            Vector2 actual = v * coefficient;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_CoefficientByVector2 ()
        {
            Vector2 v           = new Vector2 (2, 3);
            double  coefficient = 3;

            Vector2 expected = new Vector2 (6, 9);

            Vector2 actual = coefficient * v;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opDivideTest ()
        {
            Vector2 v           = new Vector2 (2.0, 3.0);
            double  coefficient = 4.0;

            Vector2 expected = new Vector2 (0.5, 0.75);

            Vector2 actual = v / coefficient;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_DotProduct ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = new Vector2 (13, 21);

            double expected = 89;

            double actual = v1 * v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void DotProductTest ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = new Vector2 (13, 21);

            double expected = 89;

            double actual = Vector2.DotProduct (v1, v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Vector2 v = new Vector2 (3, 4);

            double exected = 25;

            double actual = v.GetNorm2 ();

            Assert.AreEqual (exected, actual);
        }

        [TestMethod ()]
        public void GetLengthTest ()
        {
            Vector2 v = new Vector2 (3, 4);

            double exected = 5;

            double actual = v.GetLength ();

            Assert.AreEqual (exected, actual);
        }
    }
}