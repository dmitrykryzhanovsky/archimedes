using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Vector3Tests
    {
        [TestMethod ()]
        public void XTest_Get ()
        {
            Vector3 v = new Vector3 (2, 3, 5);

            double expected = 2;

            double actual = v.X;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void XTest_Set ()
        {
            Vector3 v = new Vector3 (2, 3, 5);
            int value = 8;

            double expected = 8;

            v.X = value;
            double actual = v.X;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void YTest_Get ()
        {
            Vector3 v = new Vector3 (2, 3, 5);

            double expected = 3;

            double actual = v.Y;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void YTest_Set ()
        {
            Vector3 v = new Vector3 (2, 3, 5);
            int value = 8;

            double expected = 8;

            v.Y = value;
            double actual = v.Y;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ZTest_Get ()
        {
            Vector3 v = new Vector3 (2, 3, 5);

            double expected = 5;

            double actual = v.Z;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ZTest_Set ()
        {
            Vector3 v = new Vector3 (2, 3, 5);
            int value = 8;

            double expected = 8;

            v.Z = value;
            double actual = v.Z;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void DimensionTest ()
        {
            Vector3 v = new Vector3 (2, 3, 5);

            int expected = 3;

            int actual = v.Dimension;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Vector3Test_XYZ_1 ()
        {
            Vector3 v = new Vector3 (2, 3, 5);

            Assert.AreEqual (2, v [0]);
            Assert.AreEqual (3, v [1]);
            Assert.AreEqual (5, v [2]);
        }

        [TestMethod ()]
        public void Vector3Test_XYZ_2 ()
        {
            Vector3 v = new Vector3 (2, 3, 5);

            Assert.AreEqual (2, v.Coordinates [0]);
            Assert.AreEqual (3, v.Coordinates [1]);
            Assert.AreEqual (5, v.Coordinates [2]);
        }

        [TestMethod ()]
        public void Vector3Test_XYZ_3 ()
        {
            Vector3 v = new Vector3 (2, 3, 5);

            Assert.AreEqual (2, v.X);
            Assert.AreEqual (3, v.Y);
            Assert.AreEqual (5, v.Z);
        }

        [TestMethod ()]
        public void Vector3Test_Copy_1 ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (v1);

            Assert.AreEqual (3, v2.Dimension);
            Assert.AreEqual (2, v2 [0]);
            Assert.AreEqual (3, v2 [1]);
            Assert.AreEqual (5, v2 [2]);
        }

        [TestMethod ()]
        public void Vector3Test_Copy_2 ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (v1);

            double [] expected = new double [] { 2, 3, 5 };

            double [] actual = v2.Coordinates;

            Assert.AreEqual (true, expected.Equals<double> (actual));
        }

        [TestMethod ()]
        public void CloneTest_1 ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = (Vector3)v1.Clone ();

            Assert.AreEqual (3, v2.Dimension);
            Assert.AreEqual (2, v2 [0]);
            Assert.AreEqual (3, v2 [1]);
            Assert.AreEqual (5, v2 [2]);
        }

        [TestMethod ()]
        public void CloneTest_2 ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = (Vector3)v1.Clone ();

            double [] expected = new double [] { 2, 3, 5 };

            double [] actual = v2.Coordinates;

            Assert.AreEqual (true, expected.Equals<double> (actual));
        }

        [TestMethod ()]
        public void EqualsTest_DifferentCoordinates ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (2, 5, 3);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualCoordinates ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (2, 3, 5);

            bool expected = true;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualsTest_True ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (2, 3, 5);

            bool expected = true;

            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualsTest_False ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (3, 2, 5);

            bool expected = false;

            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualsTest_True ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (2, 5, 3);

            bool expected = true;

            bool actual = (v1 != v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualsTest_False ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (2, 3, 5);

            bool expected = false;

            bool actual = (v1 != v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Vector3 v1 = new Vector3 ( 2,  3,  5);
            Vector3 v2 = new Vector3 (11, 13, 17);

            Vector3 expected = new Vector3 (13, 16, 22);

            Vector3 actual = v1 + v2;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opSubtractTest ()
        {
            Vector3 v1 = new Vector3 ( 2,  3,  5);
            Vector3 v2 = new Vector3 (11, 13, 17);

            Vector3 expected = new Vector3 (-9, -10, -12);

            Vector3 actual = v1 - v2;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opNegateTest ()
        {
            Vector3 v = new Vector3 (2, 3, 5);

            Vector3 expected = new Vector3 (-2, -3, -5);

            Vector3 actual = -v;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_Vector3ByCoefficient ()
        {
            Vector3 v = new Vector3 (2, 3, 5);
            double  coefficient = 3;

            Vector3 expected = new Vector3 (6, 9, 15);

            Vector3 actual = v * coefficient;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_CoefficientByVector3 ()
        {
            Vector3 v = new Vector3 (2, 3, 5);
            double  coefficient = 3;

            Vector3 expected = new Vector3 (6, 9, 15);

            Vector3 actual = coefficient * v;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opDivideTest ()
        {
            Vector3 v = new Vector3 (2, 3, 5);
            double  coefficient = 2;

            Vector3 expected = new Vector3 (1, 1.5, 2.5);

            Vector3 actual = v / coefficient;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_DotProduct ()
        {
            Vector3 v1 = new Vector3 ( 2,  3,  5);
            Vector3 v2 = new Vector3 (11, 13, 17);

            double expected = 146;

            double actual = v1 * v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Vector3 v = new Vector3 (2, 3, 5);

            double expected = 38;

            double actual = v.GetNorm2 ();

            Assert.AreEqual (expected, actual);
        }
    }
}