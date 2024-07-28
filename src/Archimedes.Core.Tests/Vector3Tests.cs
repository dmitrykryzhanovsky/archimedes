using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Vector3Tests
    {
        [TestMethod ()]
        public void IndexerTest_Get ()
        {
            Vector3 v = new Vector3 (2, 3, 5);

            double expected = 2;

            double actual = v [0];

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IndexerTest_Set ()
        {
            Vector3 v = new Vector3 (2, 3, 5);

            v [1] = 5;

            double expected = 5;

            double actual = v [1];

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void CoordinatesTest ()
        {
            Vector3 v = new Vector3 (2, 3, 5);

            double [] expected = new double [] { 2, 3, 5 };

            double [] actual = v.Coordinates;

            Assert.AreEqual (true, expected.Equals<double> (actual));
        }

        [TestMethod ()]
        public void XTest_Get ()
        {
            Vector3 v = new Vector3 (2, 3, 7);

            double expected = 2;

            double actual = v.X;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void XTest_Set ()
        {
            Vector3 v = new Vector3 (2, 3, 7);
            
            v.X = 5;

            double expected = 5;

            double actual = v.X;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void YTest_Get ()
        {
            Vector3 v = new Vector3 (2, 3, 7);

            double expected = 3;

            double actual = v.Y;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void YTest_Set ()
        {
            Vector3 v = new Vector3 (2, 3, 7);

            v.Y = 5;

            double expected = 5;

            double actual = v.Y;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ZTest_Get ()
        {
            Vector3 v = new Vector3 (2, 3, 7);

            double expected = 7;

            double actual = v.Z;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ZTest_Set ()
        {
            Vector3 v = new Vector3 (2, 3, 7);

            v.Z = 5;

            double expected = 5;

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
        public void Vector3Test_XYZ ()
        {
            Vector3 v = new Vector3 (2, 3, 5);

            double expectedX = 2;
            double expectedY = 3;
            double expectedZ = 5;

            double actualX = v.X;
            double actualY = v.Y;
            double actualZ = v.Z;

            Assert.AreEqual (expectedX, actualX);
            Assert.AreEqual (expectedY, actualY);
            Assert.AreEqual (expectedZ, actualZ);
        }

        [TestMethod ()]
        public void Vector3Test_Copying ()
        {
            Vector3 other = new Vector3 (2, 3, 5);
            Vector3 v     = new Vector3 (other);

            double expectedX = 2;
            double expectedY = 3;
            double expectedZ = 5;

            double actualX = v.X;
            double actualY = v.Y;
            double actualZ = v.Z;

            Assert.AreEqual (expectedX, actualX);
            Assert.AreEqual (expectedY, actualY);
            Assert.AreEqual (expectedZ, actualZ);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Vector3 other = new Vector3 (2, 3, 5);
            Vector3 v     = (Vector3)other.Clone ();

            double expectedX = 2;
            double expectedY = 3;
            double expectedZ = 5;

            double actualX = v.X;
            double actualY = v.Y;
            double actualZ = v.Z;

            Assert.AreEqual (expectedX, actualX);
            Assert.AreEqual (expectedY, actualY);
            Assert.AreEqual (expectedZ, actualZ);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqualComponents ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (5, 7, 11);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_OneEqualComponent ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (2, 7, 11);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_TwoEqualComponents ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (2, 3, 11);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ThreeEqualComponents ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (2, 3, 5);

            bool expected = true;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (2, 3, 5);

            bool expected = true;

            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (2, 3, 5);

            bool expected = false;

            bool actual = (v1 != v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetLengthTest ()
        {
            Vector3 v = new Vector3 (3, 4, 12);

            double expected = 13;

            double actual = v.GetLength ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Vector3 v = new Vector3 (3, 4, 12);

            double expected = 169;

            double actual = v.GetNorm2 ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ToPolarTest_Zero ()
        {
            Vector3 v = new Vector3 (0.0, 0.0, 0.0);

            double expectedR = 0.0;
            double expectedB = 0.0;
            double expectedL = 0.0;

            Polar3 actual = v.ToPolar ();

            Assert.AreEqual (expectedR, actual.R);
            Assert.AreEqual (expectedB, actual.Latitude);
            Assert.AreEqual (expectedL, actual.Longitude);
        }

        [TestMethod ()]
        public void ToPolarTest_Heading0 ()
        {
            Vector3 v = new Vector3 (2.0, 0.0, 0.0);

            double expectedR = 2.0;
            double expectedB = 0.0;
            double expectedL = 0.0;

            Polar3 actual = v.ToPolar ();

            Assert.AreEqual (expectedR, actual.R);
            Assert.AreEqual (expectedB, actual.Latitude);
            Assert.AreEqual (expectedL, actual.Longitude);
        }

        [TestMethod ()]
        public void ToPolarTest_HeadingPlusPI2 ()
        {
            Vector3 v = new Vector3 (0.0, 2.0, 0.0);

            double expectedR = 2.0;
            double expectedB = 0.0;
            double expectedL = 1.57079632679489662;

            Polar3 actual = v.ToPolar ();

            Assert.AreEqual (expectedR, actual.R);
            Assert.AreEqual (expectedB, actual.Latitude);
            Assert.AreEqual (expectedL, actual.Longitude);
        }

        [TestMethod ()]
        public void ToPolarTest_HeadingPI ()
        {
            Vector3 v = new Vector3 (-2.0, 0.0, 0.0);

            double expectedR = 2.0;
            double expectedB = 0.0;
            double expectedL = 3.14159265358979324;

            Polar3 actual = v.ToPolar ();

            Assert.AreEqual (expectedR, actual.R);
            Assert.AreEqual (expectedB, actual.Latitude);
            Assert.AreEqual (expectedL, actual.Longitude);
        }

        [TestMethod ()]
        public void ToPolarTest_HeadingMInusPI2 ()
        {
            Vector3 v = new Vector3 (0.0, -2.0, 0.0);

            double expectedR =  2.0;
            double expectedB =  0.0;
            double expectedL = -1.57079632679489662;

            Polar3 actual = v.ToPolar ();

            Assert.AreEqual (expectedR, actual.R);
            Assert.AreEqual (expectedB, actual.Latitude);
            Assert.AreEqual (expectedL, actual.Longitude);
        }

        [TestMethod ()]
        public void ToPolarTest_NorthPole ()
        {
            Vector3 v = new Vector3 (0.0, 0.0, 2.0);

            double expectedR = 2.0;
            double expectedB = 1.57079632679489662;
            double expectedL = 0.0;

            Polar3 actual = v.ToPolar ();

            Assert.AreEqual (expectedR, actual.R);
            Assert.AreEqual (expectedB, actual.Latitude);
            Assert.AreEqual (expectedL, actual.Longitude);
        }

        [TestMethod ()]
        public void ToPolarTest_SouthPole ()
        {
            Vector3 v = new Vector3 (0.0, 0.0, -2.0);

            double expectedR =  2.0;
            double expectedB = -1.57079632679489662;
            double expectedL =  0.0;

            Polar3 actual = v.ToPolar ();

            Assert.AreEqual (expectedR, actual.R);
            Assert.AreEqual (expectedB, actual.Latitude);
            Assert.AreEqual (expectedL, actual.Longitude);
        }

        [TestMethod ()]
        public void ToPolarTest_Common ()
        {
            Vector3 v = new Vector3 (2.0, -2.0, 2.0);

            double expectedR =  3.46410161513775459;
            double expectedB =  0.615479708670387341;
            double expectedL = -0.785398163397448310;

            Polar3 actual = v.ToPolar ();

            Assert.AreEqual (expectedR, actual.R);
            Assert.AreEqual (expectedB, actual.Latitude, 1.0e-15);
            Assert.AreEqual (expectedL, actual.Longitude);
        }

        ///// <summary>
        ///// Исходный вектор наклонён под углом +30°. Его поворачивают на +30° (30° против часовой стрелки), и он должен стать наклонённым 
        ///// на +60°.
        ///// </summary>
        //[TestMethod ()]
        //public void RotateThisTest_Angle ()
        //{
        //    Vector3 v     = new Vector3 (0.866025403784438647, 0.5);
        //    double  angle = 0.523598775598298873;

        //    double expectedX = 0.5;
        //    double expectedY = 0.866025403784438647;

        //    v.RotateThis (angle);

        //    Assert.AreEqual (expectedX, v.X, 1.0e-15);
        //    Assert.AreEqual (expectedY, v.Y, 1.0e-15);
        //}

        ///// <summary>
        ///// Исходный вектор наклонён под углом +30°. Его поворачивают на −30° (30° по часовой стрелке), и он должен перейти в ось OX.
        ///// </summary>
        //[TestMethod ()]
        //public void RotateThisTest_SinCos ()
        //{
        //    Vector3 v   = new Vector3 (0.866025403784438647, 0.5);
        //    double  sin = -0.5;
        //    double  cos =  0.866025403784438647;

        //    double expectedX = 1.0;
        //    double expectedY = 0.0;

        //    v.RotateThis (sin, cos);

        //    Assert.AreEqual (expectedX, v.X, 1.0e-15);
        //    Assert.AreEqual (expectedY, v.Y, 1.0e-15);
        //}

        ///// <summary>
        ///// Исходный вектор наклонён под углом +30°. Его поворачивают на +30° (30° против часовой стрелки), и он должен стать наклонённым 
        ///// на +60°.
        ///// </summary>
        //[TestMethod ()]
        //public void RotateTest_Angle ()
        //{
        //    Vector3 v     = new Vector3 (0.866025403784438647, 0.5);
        //    double  angle = 0.523598775598298873;

        //    double expectedX = 0.5;
        //    double expectedY = 0.866025403784438647;

        //    Vector3 actual = v.Rotate (angle);

        //    Assert.AreEqual (expectedX, actual.X, 1.0e-15);
        //    Assert.AreEqual (expectedY, actual.Y, 1.0e-15);
        //}

        ///// <summary>
        ///// Исходный вектор наклонён под углом +30°. Его поворачивают на −30° (30° по часовой стрелке), и он должен перейти в ось OX.
        ///// </summary>
        //[TestMethod ()]
        //public void RotateTest_SinCos ()
        //{
        //    Vector3 v   = new Vector3 (0.866025403784438647, 0.5);
        //    double  sin = -0.5;
        //    double  cos =  0.866025403784438647;

        //    double expectedX = 1.0;
        //    double expectedY = 0.0;

        //    Vector3 actual = v.Rotate (sin, cos);

        //    Assert.AreEqual (expectedX, actual.X, 1.0e-15);
        //    Assert.AreEqual (expectedY, actual.Y, 1.0e-15);
        //}
    }
}