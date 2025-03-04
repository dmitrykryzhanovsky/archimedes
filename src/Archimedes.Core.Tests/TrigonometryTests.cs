using Archimedes;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class TrigonometryTests
    {
        [TestMethod ()]
        public void PhaseInDegTest_Zero ()
        {
            double deg = 0.0;

            double expected = 0.0;

            double actual = Trigonometry.PhaseInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInDegTest_Positive_90 ()
        {
            double deg = 90.0;

            double expected = 90.0;

            double actual = Trigonometry.PhaseInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInDegTest_Positive_180 ()
        {
            double deg = 180.0;

            double expected = 180.0;

            double actual = Trigonometry.PhaseInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInDegTest_Positive_270 ()
        {
            double deg = 270.0;

            double expected = 270.0;

            double actual = Trigonometry.PhaseInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInDegTest_Positive_360 ()
        {
            double deg = 360.0;

            double expected = 0.0;

            double actual = Trigonometry.PhaseInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInDegTest_Positive_450 ()
        {
            double deg = 450.0;

            double expected = 90.0;

            double actual = Trigonometry.PhaseInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInDegTest_Positive_540 ()
        {
            double deg = 540.0;

            double expected = 180.0;

            double actual = Trigonometry.PhaseInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInDegTest_Positive_630 ()
        {
            double deg = 630.0;

            double expected = 270.0;

            double actual = Trigonometry.PhaseInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInDegTest_Positive_720 ()
        {
            double deg = 720.0;

            double expected = 0.0;

            double actual = Trigonometry.PhaseInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInDegTest_Negative_90 ()
        {
            double deg = -90.0;

            double expected = 270.0;

            double actual = Trigonometry.PhaseInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInDegTest_Negative_180 ()
        {
            double deg = -180.0;

            double expected = 180.0;

            double actual = Trigonometry.PhaseInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInDegTest_Negative_270 ()
        {
            double deg = -270.0;

            double expected = 90.0;

            double actual = Trigonometry.PhaseInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInDegTest_Negative_360 ()
        {
            double deg = -360.0;

            double expected = 0.0;

            double actual = Trigonometry.PhaseInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInDegTest_Negative_450 ()
        {
            double deg = -450.0;

            double expected = 270.0;

            double actual = Trigonometry.PhaseInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInDegTest_Negative_540 ()
        {
            double deg = -540.0;

            double expected = 180.0;

            double actual = Trigonometry.PhaseInDeg (deg);

            Assert.AreEqual (expected, actual); ;
        }

        [TestMethod ()]
        public void PhaseInDegTest_Negative_630 ()
        {
            double deg = -630.0;

            double expected = 90.0;

            double actual = Trigonometry.PhaseInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInDegTest_Negative_720 ()
        {
            double deg = -720.0;

            double expected = 0.0;

            double actual = Trigonometry.PhaseInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInHourTest_Zero ()
        {
            double hour = 0.0;

            double expected = 0.0;

            double actual = Trigonometry.PhaseInHour (hour);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInHourTest_Positive_90 ()
        {
            double hour = 6.0;

            double expected = 6.0;

            double actual = Trigonometry.PhaseInHour (hour);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInHourTest_Positive_180 ()
        {
            double hour = 12.0;

            double expected = 12.0;

            double actual = Trigonometry.PhaseInHour (hour);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInHourTest_Positive_270 ()
        {
            double hour = 18.0;

            double expected = 18.0;

            double actual = Trigonometry.PhaseInHour (hour);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInHourTest_Positive_360 ()
        {
            double hour = 24.0;

            double expected = 0.0;

            double actual = Trigonometry.PhaseInHour (hour);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInHourTest_Positive_450 ()
        {
            double hour = 30.0;

            double expected = 6.0;

            double actual = Trigonometry.PhaseInHour (hour);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInHourTest_Positive_540 ()
        {
            double hour = 36.0;

            double expected = 12.0;

            double actual = Trigonometry.PhaseInHour (hour);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInHourTest_Positive_630 ()
        {
            double hour = 42.0;

            double expected = 18.0;

            double actual = Trigonometry.PhaseInHour (hour);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInHourTest_Positive_720 ()
        {
            double hour = 48.0;

            double expected = 0.0;

            double actual = Trigonometry.PhaseInHour (hour);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInHourTest_Negative_90 ()
        {
            double hour = -6.0;

            double expected = 18.0;

            double actual = Trigonometry.PhaseInHour (hour);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInHourTest_Negative_180 ()
        {
            double hour = -12.0;

            double expected = 12.0;

            double actual = Trigonometry.PhaseInHour (hour);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInHourTest_Negative_270 ()
        {
            double hour = -18.0;

            double expected = 6.0;

            double actual = Trigonometry.PhaseInHour (hour);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInHourTest_Negative_360 ()
        {
            double hour = -24.0;

            double expected = 0.0;

            double actual = Trigonometry.PhaseInHour (hour);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInHourTest_Negative_450 ()
        {
            double hour = -30.0;

            double expected = 18.0;

            double actual = Trigonometry.PhaseInHour (hour);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInHourTest_Negative_540 ()
        {
            double hour = -36.0;

            double expected = 12.0;

            double actual = Trigonometry.PhaseInHour (hour);

            Assert.AreEqual (expected, actual); ;
        }

        [TestMethod ()]
        public void PhaseInHourTest_Negative_630 ()
        {
            double hour = -42.0;

            double expected = 6.0;

            double actual = Trigonometry.PhaseInHour (hour);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInHourTest_Negative_720 ()
        {
            double hour = -48.0;

            double expected = 0.0;

            double actual = Trigonometry.PhaseInHour (hour);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInRadTest_Zero ()
        {
            double rad = 0.0;

            double expected = 0.0;

            double actual = Trigonometry.PhaseInRad (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInRadTest_Positive_90 ()
        {
            double rad = double.Pi * 0.5;

            double expected = double.Pi * 0.5;

            double actual = Trigonometry.PhaseInRad (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInRadTest_Positive_180 ()
        {
            double rad = double.Pi;

            double expected = double.Pi;

            double actual = Trigonometry.PhaseInRad (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInRadTest_Positive_270 ()
        {
            double rad = double.Pi * 1.5;

            double expected = double.Pi * 1.5;

            double actual = Trigonometry.PhaseInRad (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInRadTest_Positive_360 ()
        {
            double rad = double.Pi * 2.0;

            double expected = 0.0;

            double actual = Trigonometry.PhaseInRad (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInRadTest_Positive_450 ()
        {
            double rad = double.Pi * 2.5;

            double expected = double.Pi * 0.5;

            double actual = Trigonometry.PhaseInRad (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInRadTest_Positive_540 ()
        {
            double rad = double.Pi * 3.0;

            double expected = double.Pi;

            double actual = Trigonometry.PhaseInRad (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInRadTest_Positive_630 ()
        {
            double rad = double.Pi * 3.5;

            double expected = double.Pi * 1.5;

            double actual = Trigonometry.PhaseInRad (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInRadTest_Positive_720 ()
        {
            double rad = double.Pi * 4.0;

            double expected = 0.0;

            double actual = Trigonometry.PhaseInRad (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInRadTest_Negative_90 ()
        {
            double rad = -double.Pi * 0.5;

            double expected = double.Pi * 1.5;

            double actual = Trigonometry.PhaseInRad (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInRadTest_Negative_180 ()
        {
            double rad = -double.Pi;

            double expected = double.Pi;

            double actual = Trigonometry.PhaseInRad (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInRadTest_Negative_270 ()
        {
            double rad = -double.Pi * 1.5;

            double expected = double.Pi * 0.5;

            double actual = Trigonometry.PhaseInRad (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInRadTest_Negative_360 ()
        {
            double rad = -double.Pi * 2.0;

            double expected = 0.0;

            double actual = Trigonometry.PhaseInRad (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInRadTest_Negative_450 ()
        {
            double rad = -double.Pi * 2.5;

            double expected = double.Pi * 1.5;

            double actual = Trigonometry.PhaseInRad (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInRadTest_Negative_540 ()
        {
            double rad = -double.Pi * 3.0;

            double expected = double.Pi;

            double actual = Trigonometry.PhaseInRad (rad);

            Assert.AreEqual (expected, actual); ;
        }

        [TestMethod ()]
        public void PhaseInRadTest_Negative_630 ()
        {
            double rad = -double.Pi * 3.5;

            double expected = double.Pi * 0.5;

            double actual = Trigonometry.PhaseInRad (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInRadTest_Negative_720 ()
        {
            double rad = -double.Pi * 4.0;

            double expected = 0.0;

            double actual = Trigonometry.PhaseInRad (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInOrbitTest_Zero ()
        {
            double orbit = 0.0;

            double expected = 0.0;

            double actual = Trigonometry.PhaseInOrbit (orbit);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInOrbitTest_Positive_90 ()
        {
            double orbit = 0.25;

            double expected = 0.25;

            double actual = Trigonometry.PhaseInOrbit (orbit);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInOrbitTest_Positive_180 ()
        {
            double orbit = 0.5;

            double expected = 0.5;

            double actual = Trigonometry.PhaseInOrbit (orbit);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInOrbitTest_Positive_270 ()
        {
            double orbit = 0.75;

            double expected = 0.75;

            double actual = Trigonometry.PhaseInOrbit (orbit);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInOrbitTest_Positive_360 ()
        {
            double orbit = 1.0;

            double expected = 0.0;

            double actual = Trigonometry.PhaseInOrbit (orbit);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInOrbitTest_Positive_450 ()
        {
            double orbit = 1.25;

            double expected = 0.25;

            double actual = Trigonometry.PhaseInOrbit (orbit);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInOrbitTest_Positive_540 ()
        {
            double orbit = 1.5;

            double expected = 0.5;

            double actual = Trigonometry.PhaseInOrbit (orbit);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInOrbitTest_Positive_630 ()
        {
            double orbit = 1.75;

            double expected = 0.75;

            double actual = Trigonometry.PhaseInOrbit (orbit);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInOrbitTest_Positive_720 ()
        {
            double orbit = 2.0;

            double expected = 0.0;

            double actual = Trigonometry.PhaseInOrbit (orbit);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInOrbitTest_Negative_90 ()
        {
            double orbit = -0.25;

            double expected = 0.75;

            double actual = Trigonometry.PhaseInOrbit (orbit);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInOrbitTest_Negative_180 ()
        {
            double orbit = -0.5;

            double expected = 0.5;

            double actual = Trigonometry.PhaseInOrbit (orbit);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInOrbitTest_Negative_270 ()
        {
            double orbit = -0.75;

            double expected = 0.25;

            double actual = Trigonometry.PhaseInOrbit (orbit);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInOrbitTest_Negative_360 ()
        {
            double orbit = -1.0;

            double expected = 0.0;

            double actual = Trigonometry.PhaseInOrbit (orbit);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInOrbitTest_Negative_450 ()
        {
            double orbit = -1.25;

            double expected = 0.75;

            double actual = Trigonometry.PhaseInOrbit (orbit);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInOrbitTest_Negative_540 ()
        {
            double orbit = -1.5;

            double expected = 0.5;

            double actual = Trigonometry.PhaseInOrbit (orbit);

            Assert.AreEqual (expected, actual); ;
        }

        [TestMethod ()]
        public void PhaseInOrbitTest_Negative_630 ()
        {
            double orbit = -1.75;

            double expected = 0.25;

            double actual = Trigonometry.PhaseInOrbit (orbit);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInOrbitTest_Negative_720 ()
        {
            double orbit = -2.0;

            double expected = 0.0;

            double actual = Trigonometry.PhaseInOrbit (orbit);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeMinusPlusInDegTest_Negative_180 ()
        {
            double deg = -180.0;

            double expected = 180.0;

            double actual = Trigonometry.NormalizeMinusPlusInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeMinusPlusInDegTest_Positive_270 ()
        {
            double deg = 270.0;

            double expected = -90.0;

            double actual = Trigonometry.NormalizeMinusPlusInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeMinusPlusInHourTest_Negative_180 ()
        {
            double hour = -12.0;

            double expected = 12.0;

            double actual = Trigonometry.NormalizeMinusPlusInHour (hour);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeMinusPlusInHourTest_Positive_270 ()
        {
            double hour = 18.0;

            double expected = -6.0;

            double actual = Trigonometry.NormalizeMinusPlusInHour (hour);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeMinusPlusInRadTest_Negative_180 ()
        {
            double rad = -double.Pi;

            double expected = double.Pi;

            double actual = Trigonometry.NormalizeMinusPlusInRad (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeMinusPlusInRadTest_Positive_270 ()
        {
            double rad = double.Pi * 1.5;

            double expected = -double.Pi * 0.5;

            double actual = Trigonometry.NormalizeMinusPlusInRad (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeMinusPlusInOrbitTest_Negative_180 ()
        {
            double orbit = -0.5;

            double expected = 0.5;

            double actual = Trigonometry.NormalizeMinusPlusInOrbit (orbit);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeMinusPlusInOrbitTest_Positive_270 ()
        {
            double orbit = 0.75;

            double expected = -0.25;

            double actual = Trigonometry.NormalizeMinusPlusInOrbit (orbit);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizePositiveInDegTest ()
        {
            double deg = 270.0;

            double expected = 270.0;

            double actual = Trigonometry.NormalizePositiveInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizePositiveInHourTest ()
        {
            double hour = 18.0;

            double expected = 18.0;

            double actual = Trigonometry.NormalizePositiveInHour (hour);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizePositiveInRadTest ()
        {
            double rad = double.Pi * 1.5;

            double expected = double.Pi * 1.5;

            double actual = Trigonometry.NormalizePositiveInRad (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizePositiveInOrbitTest ()
        {
            double orbit = 0.75;

            double expected = 0.75;

            double actual = Trigonometry.NormalizePositiveInOrbit (orbit);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AsinEpsilonTest_Common ()
        {
            double sinValue;

            double expected;

            double actual = Trigonometry.AsinEpsilon (sinValue);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AsinEpsilonTest_PlusKeepPI2 ()
        {
            double sinValue;

            double expected;

            double actual = Trigonometry.AsinEpsilon (sinValue);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AsinEpsilonTest_MinusKeepPI2 ()
        {
            double sinValue;

            double expected;

            double actual = Trigonometry.AsinEpsilon (sinValue);

            Assert.AreEqual (expected, actual);
        }
    }
}