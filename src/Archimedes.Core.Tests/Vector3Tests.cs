using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Vector3Tests
    {
        [TestMethod ()]
        public void XTest_Get ()
        {
            Vector3 v = new Vector3 (5, 8, 34);

            Assert.AreEqual (5, v.X);
        }

        [TestMethod ()]
        public void XTest_Set ()
        {
            Vector3 v = new Vector3 (5, 8, 34);

            v.X = 13;

            Assert.AreEqual (13, v.X);
        }

        [TestMethod ()]
        public void YTest_Get ()
        {
            Vector3 v = new Vector3 (5, 8, 34);

            Assert.AreEqual (8, v.Y);
        }

        [TestMethod ()]
        public void YTest_Set ()
        {
            Vector3 v = new Vector3 (5, 8, 34);

            v.Y = 21;

            Assert.AreEqual (21, v.Y);
        }

        [TestMethod ()]
        public void ZTest_Get ()
        {
            Vector3 v = new Vector3 (5, 8, 34);

            Assert.AreEqual (34, v.Z);
        }

        [TestMethod ()]
        public void ZTest_Set ()
        {
            Vector3 v = new Vector3 (5, 8, 34);

            v.Z = 55;

            Assert.AreEqual (55, v.Z);
        }

        [TestMethod ()]
        public void DimensionTest ()
        {
            Vector3 v = new Vector3 (5, 8, 34);

            Assert.AreEqual (3, v.Dimension);
        }

        [TestMethod ()]
        public void Vector3Test_XY ()
        {
            Vector3 v = new Vector3 (5, 8, 13);

            Assert.AreEqual (3, v.Dimension);
            Assert.AreEqual (5, v [0]);
            Assert.AreEqual (8, v [1]);
            Assert.AreEqual (13, v [2]);
            Assert.AreEqual (5, v.X);
            Assert.AreEqual (8, v.Y);
            Assert.AreEqual (13, v.Z);
        }

        [TestMethod ()]
        public void Vector3Test_Copying ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            Vector3 v2 = new Vector3 (v1);

            Assert.AreEqual (3, v2.Dimension);
            Assert.AreEqual (5, v2 [0]);
            Assert.AreEqual (8, v2 [1]);
            Assert.AreEqual (13, v2 [2]);
            Assert.AreEqual (5, v2.X);
            Assert.AreEqual (8, v2.Y);
            Assert.AreEqual (13, v2.Z);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            Vector3 v2 = (Vector3)v1.Clone ();

            Assert.AreEqual (3, v2.Dimension);
            Assert.AreEqual (5, v2 [0]);
            Assert.AreEqual (8, v2 [1]);
            Assert.AreEqual (13, v2 [2]);
            Assert.AreEqual (5, v2.X);
            Assert.AreEqual (8, v2.Y);
            Assert.AreEqual (13, v2.Z);
        }

        [TestMethod ()]
        public void EqualsTest_Vector3_CoordinatesNotEqual ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (8, 13, 21);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector3_CoordinatesEqual ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            Vector3 v2 = new Vector3 (5, 8, 13);

            bool expected = true;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector_DimensionNotEqual ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            Vector  v2 = new Vector  (2, 3, 5, 8);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector_DimensionEqual_CoordinatesNotEqual ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            Vector  v2 = new Vector  (2, 3, 5);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector_CoordinatesEqual ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            Vector  v2 = new Vector  (5, 8, 13);

            bool expected = true;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest_CoordinatesNotEqual ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            Vector3 v2 = new Vector3 (13, 21, 34);

            bool expected = false;

            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest_CoordinatesEqual ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            Vector3 v2 = new Vector3 (5, 8, 13);

            bool expected = true;

            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest_CoordinatesNotEqual ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            Vector3 v2 = new Vector3 (13, 21, 34);

            bool expected = true;

            bool actual = (v1 != v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest_CoordinatesEqual ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            Vector3 v2 = new Vector3 (5, 8, 13);

            bool expected = false;

            bool actual = (v1 != v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (13, 21, 34);

            Vector3 expected = new Vector3 (15, 24, 39);

            Vector3 actual = v1 + v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opSubtractTest ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (13, 21, 34);

            Vector3 expected = new Vector3 (-11, -18, -29);

            Vector3 actual = v1 - v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNegateTest ()
        {
            Vector3 v = new Vector3 (2, 3, 5);

            Vector3 expected = new Vector3 (-2, -3, -5);

            Vector3 actual = -v;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_Vector3ByCoefficient ()
        {
            Vector3 v           = new Vector3 (2, 3, 5);
            double  coefficient = 3;

            Vector3 expected = new Vector3 (6, 9, 15);

            Vector3 actual = v * coefficient;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_CoefficientByVector3 ()
        {
            Vector3 v           = new Vector3 (2, 3, 5);
            double  coefficient = 3;

            Vector3 expected = new Vector3 (6, 9, 15);

            Vector3 actual = coefficient * v;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opDivideTest ()
        {
            Vector3 v           = new Vector3 (2.0, 3.0, 5.0);
            double  coefficient = 4.0;

            Vector3 expected = new Vector3 (0.5, 0.75, 1.25);

            Vector3 actual = v / coefficient;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_DotProduct ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (13, 21, 34);

            double expected = 259;

            double actual = v1 * v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void DotProductTest ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (13, 21, 34);

            double expected = 259;

            double actual = Vector3.DotProduct (v1, v2);

            Assert.AreEqual (expected, actual);
        }

        /// <summary>
        /// Рассчитано вручную.
        /// </summary>
        [TestMethod ()]
        public void CrossProductTest_Simple ()
        {
            Vector3 v1 = new Vector3 (2, 0, 0);
            Vector3 v2 = new Vector3 (2.59807621135331594, 1.5, 0);

            Vector3 expected = new Vector3 (0, 0, 3);

            Vector3 actual = Vector3.CrossProduct (v1, v2);

            Assert.AreEqual (expected, actual);
        }

        /// <summary>
        /// Рассчитано в https://www.wolframalpha.com.
        /// </summary>
        [TestMethod ()]
        public void CrossProductTest_Common ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (8, 13, 21);

            Vector3 expected = new Vector3 (-2, -2, 2);

            Vector3 actual = Vector3.CrossProduct (v1, v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Vector3 v = new Vector3 (3, 4, 12);

            double exected = 169;

            double actual = v.GetNorm2 ();

            Assert.AreEqual (exected, actual);
        }

        [TestMethod ()]
        public void GetPolarTest ()
        {
            //Vector2 v = new Vector2 (-3, -4);

            //Polar2 expected = new Polar2 (5, -2.2142974355881810);

            //Polar2 actual = v.GetPolar ();

            //Assert.AreEqual (expected.R, actual.R);
            //Assert.AreEqual (expected.Heading, actual.Heading);
        }
    }
}