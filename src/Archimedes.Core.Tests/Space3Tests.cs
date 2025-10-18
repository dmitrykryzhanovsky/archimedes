using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Space3Tests
    {
        [TestMethod ()]
        public void GetCartesianCoordinatesTest ()
        {
            double r         =  5;
            double latitude  = -double.Pi / 3.0;
            double longitude =  double.Pi / 6.0;

            double expectedX =  2.16506350946109662;
            double expectedY =  1.25;
            double expectedZ = -4.33012701892219323;

            (double x, double y, double z) actual = Space3.GetCartesianCoordinates (r, latitude, longitude);

            Assert.AreEqual (expectedX, actual.x, 1.0e-14);
            Assert.AreEqual (expectedY, actual.y, 1.0e-14);
            Assert.AreEqual (expectedZ, actual.z, 1.0e-14);
        }

        [TestMethod ()]
        public void GetPolarCoordinatesTest ()
        {
            double x =  1.25 * double.Sqrt (3.0);
            double y =  1.25;
            double z = -2.5 * double.Sqrt (3.0);

            double expectedR         =  5;
            double expectedLatitude  = -double.Pi / 3.0;
            double expectedLongitude =  double.Pi / 6.0;

            (double r, double latitude, double longitude) actual = Space3.GetPolarCoordinates (x, y, z);

            Assert.AreEqual (expectedR, actual.r);
            Assert.AreEqual (expectedLatitude, actual.latitude);
            Assert.AreEqual (expectedLongitude, actual.longitude, 1.0e-15);
        }

        [TestMethod ()]
        public void CheckLatitudeTest_LessThanMinusPI2 ()
        {
            double latitude = -MathConst.M_PI_2 - 1.0e-15;

            bool wasException = false;

            try
            {
                Space3.CheckLatitude (latitude);
            }

            catch (ArgumentOutOfRangeException)
            {
                wasException = true;
            }

            Assert.IsTrue (wasException);
        }

        [TestMethod ()]
        public void CheckLatitudeTest_MinusPI2 ()
        {
            double latitude = -MathConst.M_PI_2;

            bool wasException = false;

            try
            {
                Space3.CheckLatitude (latitude);
            }

            catch (ArgumentOutOfRangeException)
            {
                wasException = true;
            }

            Assert.IsFalse (wasException);
        }

        [TestMethod ()]
        public void CheckLatitudeTest_InInterval ()
        {
            double latitude = 0.42;

            bool wasException = false;

            try
            {
                Space3.CheckLatitude (latitude);
            }

            catch (ArgumentOutOfRangeException)
            {
                wasException = true;
            }

            Assert.IsFalse (wasException);
        }

        [TestMethod ()]
        public void CheckLatitudeTest_Plus2 ()
        {
            double latitude = MathConst.M_PI_2;

            bool wasException = false;

            try
            {
                Space3.CheckLatitude (latitude);
            }

            catch (ArgumentOutOfRangeException)
            {
                wasException = true;
            }

            Assert.IsFalse (wasException);
        }

        [TestMethod ()]
        public void CheckLatitudeTest_GreaterThanPlusPI2 ()
        {
            double latitude = MathConst.M_PI_2 + 1.0e-15;

            bool wasException = false;

            try
            {
                Space3.CheckLatitude (latitude);
            }

            catch (ArgumentOutOfRangeException)
            {
                wasException = true;
            }

            Assert.IsTrue (wasException);
        }
    }
}