using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Vector2Tests
    {
        [TestMethod ()]
        public void XTest_Get ()
        {
            Vector2 v = new Vector2 (2, 3);

            double expected = 2;

            double actual = v.X;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void XTest_Set ()
        {
            Vector2 v = new Vector2 (2, 3);
            int value = 8;

            double expected = 8;

            v.X = value;
            double actual = v.X;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void YTest_Get ()
        {
            Vector2 v = new Vector2 (2, 3);

            double expected = 3;

            double actual = v.Y;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void YTest_Set ()
        {
            Vector2 v = new Vector2 (2, 3);
            int value = 8;

            double expected = 8;

            v.Y = value;
            double actual = v.Y;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void DimensionTest ()
        {
            Vector2 v = new Vector2 (2, 3);

            int expected = 2;

            int actual = v.Dimension;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Vector2Test_XY_1 ()
        {
            Vector2 v = new Vector2 (2, 3);

            Assert.AreEqual (2, v [0]);
            Assert.AreEqual (3, v [1]);
        }

        [TestMethod ()]
        public void Vector2Test_XY_2 ()
        {
            Vector2 v = new Vector2 (2, 3);

            Assert.AreEqual (2, v.Coordinates [0]);
            Assert.AreEqual (3, v.Coordinates [1]);
        }

        [TestMethod ()]
        public void Vector2Test_XY_3 ()
        {
            Vector2 v = new Vector2 (2, 3);

            Assert.AreEqual (2, v.X);
            Assert.AreEqual (3, v.Y);
        }

        [TestMethod ()]
        public void Vector2Test_Copy_1 ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = new Vector2 (v1);

            Assert.AreEqual (2, v2.Dimension);
            Assert.AreEqual (2, v2 [0]);
            Assert.AreEqual (3, v2 [1]);
        }

        [TestMethod ()]
        public void Vector2Test_Copy_2 ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = new Vector2 (v1);

            double [] expected = new double [] { 2, 3 };

            double [] actual = v2.Coordinates;

            Assert.AreEqual (true, expected.Equals<double> (actual));
        }

        [TestMethod ()]
        public void CloneTest_1 ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = (Vector2)v1.Clone ();

            Assert.AreEqual (2, v2.Dimension);
            Assert.AreEqual (2, v2 [0]);
            Assert.AreEqual (3, v2 [1]);
        }

        [TestMethod ()]
        public void CloneTest_2 ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = (Vector2)v1.Clone ();

            double [] expected = new double [] { 2, 3 };

            double [] actual = v2.Coordinates;

            Assert.AreEqual (true, expected.Equals<double> (actual));
        }

        [TestMethod ()]
        public void EqualsTest_DifferentCoordinates ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = new Vector2 (2, 5);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualCoordinates ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = new Vector2 (2, 3);

            bool expected = true;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualsTest_True ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = new Vector2 (2, 3);

            bool expected = true;

            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualsTest_False ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = new Vector2 (2, 5);

            bool expected = false;

            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualsTest_True ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = new Vector2 (2, 5);

            bool expected = true;

            bool actual = (v1 != v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualsTest_False ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = new Vector2 (2, 3);

            bool expected = false;

            bool actual = (v1 != v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Vector2 v1 = new Vector2 ( 2,  3);
            Vector2 v2 = new Vector2 (11, 13);

            Vector2 expected = new Vector2 (13, 16);

            Vector2 actual = v1 + v2;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opSubtractTest ()
        {
            Vector2 v1 = new Vector2 ( 2,  3);
            Vector2 v2 = new Vector2 (11, 13);

            Vector2 expected = new Vector2 (-9, -10);

            Vector2 actual = v1 - v2;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opNegateTest ()
        {
            Vector2 v = new Vector2 (2, 3);

            Vector2 expected = new Vector2 (-2, -3);

            Vector2 actual = -v;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_Vector2ByCoefficient ()
        {
            Vector2 v = new Vector2 (2, 3);
            double  coefficient = 3;

            Vector2 expected = new Vector2 (6, 9);

            Vector2 actual = v * coefficient;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_CoefficientByVector2 ()
        {
            Vector2 v = new Vector2 (2, 3);
            double  coefficient = 3;

            Vector2 expected = new Vector2 (6, 9);

            Vector2 actual = coefficient * v;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opDivideTest ()
        {
            Vector2 v = new Vector2 (2, 3);
            double  coefficient = 2;

            Vector2 expected = new Vector2 (1, 1.5);

            Vector2 actual = v / coefficient;

            Assert.AreEqual (true, expected.Equals (actual));
        }

        [TestMethod ()]
        public void opMultiplyTest_DotProduct ()
        {
            Vector2 v1 = new Vector2 ( 2,  3);
            Vector2 v2 = new Vector2 (11, 13);

            double expected = 61;

            double actual = v1 * v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetLengthTest ()
        {
            Vector2 v = new Vector2 (2, 3);

            double expected = 3.60555127546398929;

            double actual = v.GetLength ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Vector2 v = new Vector2 (2, 3);

            double expected = 13;

            double actual = v.GetNorm2 ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ToPolarTest ()
        {
            Vector2 v = new Vector2 (1, 2);
            v.ToPolar ();
        }
    }
}