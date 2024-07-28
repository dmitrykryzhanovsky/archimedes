using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Polar3Tests
    {
        [TestMethod ()]
        public void RTest_Get ()
        {
            Polar3 p = new Polar3 (3, 1, 2);

            double expected = 3;

            double actual = p.R;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void RTest_Set_Positive ()
        {
            Polar3 p = new Polar3 (3, 1, 2);

            p.R = 5;

            double expected = 5;

            double actual = p.R;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void RTest_Set_Zero ()
        {
            Polar3 p = new Polar3 (3, 1, 2);

            p.R = 0;

            double expected = 0;

            double actual = p.R;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void RTest_Set_Negative ()
        {
            Polar3 p = new Polar3 (3, 1, 2);

            bool actual = false;

            try
            {
                p.R = -5;
            }

            catch
            {
                actual = true;
            }

            Assert.AreEqual (true, actual);
        }

        [TestMethod ()]
        public void LatitudeTest_Get ()
        {
            Polar3 p = new Polar3 (3, 1, 2);

            double expected = 1;

            double actual = p.Latitude;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void LatitudeTest_Set_Appropriate ()
        {
            Polar3 p = new Polar3 (3, 1, 2);

            p.Latitude = 1.1;

            double expected = 1.1;

            double actual = p.Latitude;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void LatitudeTest_Set_MinusPI2 ()
        {
            Polar3 p = new Polar3 (3, 1, 2);

            p.Latitude = -MathConst.M_PI_2;

            double expected = -1.57079632679489662;

            double actual = p.Latitude;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void LatitudeTest_Set_PlusPI2 ()
        {
            Polar3 p = new Polar3 (3, 1, 2);

            p.Latitude = MathConst.M_PI_2;

            double expected = 1.57079632679489662;

            double actual = p.Latitude;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void LatitudeTest_Set_LessThanMinusPI2 ()
        {
            Polar3 p = new Polar3 (3, 1, 2);

            bool actual = false;

            try
            {
                p.Latitude = -5;
            }

            catch
            {
                actual = true;
            }

            Assert.AreEqual (true, actual);
        }

        [TestMethod ()]
        public void LatitudeTest_Set_GreaterThanPlusPI2 ()
        {
            Polar3 p = new Polar3 (3, 1, 2);

            bool actual = false;

            try
            {
                p.Latitude = 5;
            }

            catch
            {
                actual = true;
            }

            Assert.AreEqual (true, actual);
        }

        [TestMethod ()]
        public void LongitudeTest_Get ()
        {
            Polar3 p = new Polar3 (3, 1, 2);

            double expected = 2;

            double actual = p.Longitude;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void LongitudeTest_Set ()
        {
            Polar3 p = new Polar3 (3, 1, 2);

            p.Longitude = 5;

            double expected = 5;

            double actual = p.Longitude;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Polar3Test_RBL()
        {
            Polar3 p = new Polar3 (3, 1, 2);

            double expectedR = 3;
            double expectedB = 1;
            double expectedL = 2;

            Assert.AreEqual (expectedR, p.R);
            Assert.AreEqual (expectedB, p.Latitude);
            Assert.AreEqual (expectedL, p.Longitude);
        }

        [TestMethod ()]
        public void Polar3Test_Copying ()
        {
            Polar3 other = new Polar3 (3, 1, 2);
            Polar3 p     = new Polar3 (other);

            double expectedR = 3;
            double expectedB = 1;
            double expectedL = 2;

            Assert.AreEqual (expectedR, p.R);
            Assert.AreEqual (expectedB, p.Latitude);
            Assert.AreEqual (expectedL, p.Longitude);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Polar3 other = new Polar3 (3, 1, 2);
            Polar3 p     = (Polar3)other.Clone ();

            double expectedR = 3;
            double expectedB = 1;
            double expectedL = 2;

            Assert.AreEqual (expectedR, p.R);
            Assert.AreEqual (expectedB, p.Latitude);
            Assert.AreEqual (expectedL, p.Longitude);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqualR ()
        {
            Polar3 p1 = new Polar3 (2, 1, 2);
            Polar3 p2 = new Polar3 (3, 1, 2);

            bool expected = false;

            bool actual = p1.Equals (p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualRZero_DifferentAngles ()
        {
            Polar3 p1 = new Polar3 (0,  1, 2);
            Polar3 p2 = new Polar3 (0, -1, 3);

            bool expected = true;

            bool actual = p1.Equals (p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualRPositive_NotEqualLatitude ()
        {
            Polar3 p1 = new Polar3 (3, 1, 2);
            Polar3 p2 = new Polar3 (3, -1, 3);

            bool expected = false;

            bool actual = p1.Equals (p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualRPositive_EqualLatitudeNorthPole_DifferentLongitude ()
        {
            Polar3 p1 = new Polar3 (3, MathConst.M_PI_2, 2);
            Polar3 p2 = new Polar3 (3, MathConst.M_PI_2, 3);

            bool expected = true;

            bool actual = p1.Equals (p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualRPositive_EqualLatitudeSouthPole_DifferentLongitude ()
        {
            Polar3 p1 = new Polar3 (3, -MathConst.M_PI_2, 2);
            Polar3 p2 = new Polar3 (3, -MathConst.M_PI_2, 3);

            bool expected = true;

            bool actual = p1.Equals (p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualRPositive_EqualLatitude_SameLongitude ()
        {
            Polar3 p1 = new Polar3 (3, 0.5,  1.0);
            Polar3 p2 = new Polar3 (3, 0.5,  7.28318530717958648);

            bool expected = true;

            bool actual = p1.Equals (p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualRPositive_EqualLatitude_EqualLongitude ()
        {
            Polar3 p1 = new Polar3 (3, 0.5, 1);
            Polar3 p2 = new Polar3 (3, 0.5, 1);

            bool expected = true;

            bool actual = p1.Equals (p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqualR_EqualLatitudeNorthPole_EqualLongitude ()
        {
            Polar3 p1 = new Polar3 (3, MathConst.M_PI_2, 2);
            Polar3 p2 = new Polar3 (4, MathConst.M_PI_2, 2);

            bool expected = false;

            bool actual = p1.Equals (p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqualR_EqualLatitudeSouthPole_EqualLongitude ()
        {
            Polar3 p1 = new Polar3 (3, -MathConst.M_PI_2, 2);
            Polar3 p2 = new Polar3 (4, -MathConst.M_PI_2, 2);

            bool expected = false;

            bool actual = p1.Equals (p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeTest ()
        {
            Polar3 p = new Polar3 (2, 1, 73);

            double expected = -2.39822368615503772;

            p.Normalize ();

            double actual = p.Longitude;

            Assert.AreEqual (expected, actual, 1.0e-14);
        }

        [TestMethod ()]
        public void ToCartesianTest_Zero ()
        {
            Polar3 p = new Polar3 (0, 1, 73);

            double expectedX = 0.0;
            double expectedY = 0.0;
            double expectedZ = 0.0;

            Vector3 actual = p.ToCartesian ();

            Assert.AreEqual (expectedX, actual.X);
            Assert.AreEqual (expectedY, actual.Y);
            Assert.AreEqual (expectedZ, actual.Z);
        }

        [TestMethod ()]
        public void ToCartesianTest_Equator ()
        {
            Polar3 p = new Polar3 (2, 0.0, 3.66519142918809211);

            double expectedX = -1.73205080756887729;
            double expectedY = -1.0;
            double expectedZ =  0.0;

            Vector3 actual = p.ToCartesian ();

            Assert.AreEqual (expectedX, actual.X, 1.0e-15);
            Assert.AreEqual (expectedY, actual.Y, 1.0e-15);
            Assert.AreEqual (expectedZ, actual.Z);
        }

        [TestMethod ()]
        public void ToCartesianTest_NorthPole ()
        {
            Polar3 p = new Polar3 (2, MathConst.M_PI_2, 2.66519142918809211);

            double expectedX = 0.0;
            double expectedY = 0.0;
            double expectedZ = 2.0;

            Vector3 actual = p.ToCartesian ();

            Assert.AreEqual (expectedX, actual.X, 1.0e-15);
            Assert.AreEqual (expectedY, actual.Y, 1.0e-15);
            Assert.AreEqual (expectedZ, actual.Z, 1.0e-15);
        }

        [TestMethod ()]
        public void ToCartesianTest_NorthernHemisphere_Common ()
        {
            Polar3 p = new Polar3 (2, 1.0, 3.66519142918809211);

            double expectedX = -0.935831045210237947;
            double expectedY = -0.540302305868139716;
            double expectedZ =  1.68294196961579301;

            Vector3 actual = p.ToCartesian ();

            Assert.AreEqual (expectedX, actual.X, 1.0e-15);
            Assert.AreEqual (expectedY, actual.Y, 1.0e-15);
            Assert.AreEqual (expectedZ, actual.Z);
        }

        [TestMethod ()]
        public void ToCartesianTest_SouthPole ()
        {
            Polar3 p = new Polar3 (2, -MathConst.M_PI_2, 1.66519142918809211);

            double expectedX =  0.0;
            double expectedY =  0.0;
            double expectedZ = -2.0;

            Vector3 actual = p.ToCartesian ();

            Assert.AreEqual (expectedX, actual.X, 1.0e-15);
            Assert.AreEqual (expectedY, actual.Y, 1.0e-15);
            Assert.AreEqual (expectedZ, actual.Z, 1.0e-15);
        }

        [TestMethod ()]
        public void ToCartesianTest_SouthernHemisphere_Common ()
        {
            Polar3 p = new Polar3 (2, -1.0, 2.66519142918809211);

            double expectedX = -0.960280385042923718;
            double expectedY =  0.495548089500433239;
            double expectedZ = -1.68294196961579301;

            Vector3 actual = p.ToCartesian ();

            Assert.AreEqual (expectedX, actual.X, 1.0e-15);
            Assert.AreEqual (expectedY, actual.Y, 1.0e-15);
            Assert.AreEqual (expectedZ, actual.Z);
        }
    }
}