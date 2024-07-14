using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Vector2Tests
    {
        [TestMethod ()]
        public void IndexerTest_Get ()
        {
            Vector2 v = new Vector2 (2, 3);

            double expected = 2;

            double actual = v [0];

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IndexerTest_Set ()
        {
            Vector2 v = new Vector2 (2, 3);

            v [1] = 5;

            double expected = 5;

            double actual = v [1];

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void CoordinatesTest ()
        {
            Vector2 v = new Vector2 (2, 3);

            double [] expected = new double [] { 2, 3 };

            double [] actual = v.Coordinates;

            Assert.AreEqual (true, expected.Equals<double> (actual));
        }

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
            
            v.X = 5;

            double expected = 5;

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

            v.Y = 5;

            double expected = 5;

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
        public void Vector2Test_XY ()
        {
            Vector2 v = new Vector2 (2, 3);

            double expectedX = 2;
            double expectedY = 3;

            double actualX = v.X;
            double actualY = v.Y;

            Assert.AreEqual (expectedX, actualX);
            Assert.AreEqual (expectedY, actualY);
        }

        [TestMethod ()]
        public void Vector2Test_Copying ()
        {
            Vector2 other = new Vector2 (2, 3);
            Vector2 v     = new Vector2 (other);

            double expectedX = 2;
            double expectedY = 3;

            double actualX = v.X;
            double actualY = v.Y;

            Assert.AreEqual (expectedX, actualX);
            Assert.AreEqual (expectedY, actualY);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Vector2 other = new Vector2 (2, 3);
            Vector2 v     = (Vector2)other.Clone ();

            double expectedX = 2;
            double expectedY = 3;

            double actualX = v.X;
            double actualY = v.Y;

            Assert.AreEqual (expectedX, actualX);
            Assert.AreEqual (expectedY, actualY);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqualComponents ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = new Vector2 (5, 7);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_OneEqualComponent ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = new Vector2 (2, 7);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_TwoEqualComponents ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = new Vector2 (2, 3);

            bool expected = true;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = new Vector2 (2, 3);

            bool expected = true;

            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = new Vector2 (2, 3);

            bool expected = false;

            bool actual = (v1 != v2);

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

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Vector2 v = new Vector2 (3, 4);

            double expected = 25;

            double actual = v.GetNorm2 ();

            Assert.AreEqual (expected, actual);
        }

        /// <summary>
        /// Исходный вектор наклонён под углом +30°. Его поворачивают на +30° (30° против часовой стрелки), и он должен стать наклонённым 
        /// на +60°.
        /// </summary>
        [TestMethod ()]
        public void RotateThisTest_Angle ()
        {
            Vector2 v     = new Vector2 (0.866025403784438647, 0.5);
            double  angle = 0.523598775598298873;

            double expectedX = 0.5;
            double expectedY = 0.866025403784438647;

            v.RotateThis (angle);

            Assert.AreEqual (expectedX, v.X, 1.0e-15);
            Assert.AreEqual (expectedY, v.Y, 1.0e-15);
        }

        /// <summary>
        /// Исходный вектор наклонён под углом +30°. Его поворачивают на −30° (30° по часовой стрелке), и он должен перейти в ось OX.
        /// </summary>
        [TestMethod ()]
        public void RotateThisTest_SinCos ()
        {
            Vector2 v   = new Vector2 (0.866025403784438647, 0.5);
            double  sin = -0.5;
            double  cos =  0.866025403784438647;

            double expectedX = 1.0;
            double expectedY = 0.0;

            v.RotateThis (sin, cos);

            Assert.AreEqual (expectedX, v.X, 1.0e-15);
            Assert.AreEqual (expectedY, v.Y, 1.0e-15);
        }

        /// <summary>
        /// Исходный вектор наклонён под углом +30°. Его поворачивают на +30° (30° против часовой стрелки), и он должен стать наклонённым 
        /// на +60°.
        /// </summary>
        [TestMethod ()]
        public void RotateTest_Angle ()
        {
            Vector2 v     = new Vector2 (0.866025403784438647, 0.5);
            double  angle = 0.523598775598298873;

            double expectedX = 0.5;
            double expectedY = 0.866025403784438647;

            Vector2 actual = v.Rotate (angle);

            Assert.AreEqual (expectedX, actual.X, 1.0e-15);
            Assert.AreEqual (expectedY, actual.Y, 1.0e-15);
        }

        /// <summary>
        /// Исходный вектор наклонён под углом +30°. Его поворачивают на −30° (30° по часовой стрелке), и он должен перейти в ось OX.
        /// </summary>
        [TestMethod ()]
        public void RotateTest_SinCos ()
        {
            Vector2 v   = new Vector2 (0.866025403784438647, 0.5);
            double  sin = -0.5;
            double  cos =  0.866025403784438647;

            double expectedX = 1.0;
            double expectedY = 0.0;

            Vector2 actual = v.Rotate (sin, cos);

            Assert.AreEqual (expectedX, actual.X, 1.0e-15);
            Assert.AreEqual (expectedY, actual.Y, 1.0e-15);
        }
    }
}