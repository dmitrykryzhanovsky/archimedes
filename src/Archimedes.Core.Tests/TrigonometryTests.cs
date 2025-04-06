using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class TrigonometryTests
    {
        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_Same_Zero ()
        {
            double angle1 = 0.0;
            double angle2 = 0.0;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_Same_PlusPI ()
        {
            double angle1 = double.Pi;
            double angle2 = double.Pi;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_Same_Plus2PI ()
        {
            double angle1 = double.Tau;
            double angle2 = double.Tau;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_Same_Positive ()
        {
            double angle1 = double.Pi / 3.0;
            double angle2 = double.Pi / 3.0;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_Same_MinusPI ()
        {
            double angle1 = -double.Pi;
            double angle2 = -double.Pi;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_Same_Minus2PI ()
        {
            double angle1 = -double.Tau;
            double angle2 = -double.Tau;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_Same_Negative ()
        {
            double angle1 = -double.Pi / 3.0;
            double angle2 = -double.Pi / 3.0;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_Positive ()
        {
            double angle1 =       double.Pi / 3.0;
            double angle2 = 7.0 * double.Pi / 3.0;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_ChangeSign ()
        {
            double angle1 =        double.Pi / 3.0;
            double angle2 = -5.0 * double.Pi / 3.0;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_Negative ()
        {
            double angle1 =        -double.Pi / 3.0;
            double angle2 = -13.0 * double.Pi / 3.0;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_PlusMinusPI()
        {
            double angle1 =  double.Pi;
            double angle2 = -double.Pi;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_NotEqual_Positive ()
        {
            double angle1 =       double.Pi / 3.0 + 1.0e-12;
            double angle2 = 7.0 * double.Pi / 3.0;

            bool expected = false;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_NotEqual_ChangeSign ()
        {
            double angle1 =        double.Pi / 3.0 + 1.0e-12;
            double angle2 = -5.0 * double.Pi / 3.0;

            bool expected = false;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_NotEqual_Negative ()
        {
            double angle1 =        -double.Pi / 3.0 + 1.0e-12;
            double angle2 = -13.0 * double.Pi / 3.0;

            bool expected = false;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

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
            double sinValue = 0.5;

            double expected = double.Pi / 6.0;

            double actual = Trigonometry.AsinEpsilon (sinValue);

            Assert.AreEqual (expected, actual, 1.0e-15);
        }

        [TestMethod ()]
        public void AsinEpsilonTest_PlusKeep0 ()
        {
            double sinValue = 0.0;

            double expected = 0.0;

            double actual = Trigonometry.AsinEpsilon (sinValue);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AsinEpsilonTest_PlusKeep0Positive ()
        {
            double sinValue = 0.099;
            double epsilon  = 0.1;

            double expected = 0.0;

            double actual = Trigonometry.AsinEpsilon (sinValue, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AsinEpsilonTest_PlusKeep0Negative ()
        {
            double sinValue = -0.099;
            double epsilon  =  0.1;

            double expected = 0.0; ;

            double actual = Trigonometry.AsinEpsilon (sinValue, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AsinEpsilonTest_KeepPlusPI2 ()
        {
            double sinValue = 0.901;
            double epsilon  = 0.1;

            double expected = double.Pi / 2.0;

            double actual = Trigonometry.AsinEpsilon (sinValue, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AsinEpsilonTest_KeepMinusPI2 ()
        {
            double sinValue = -0.901;
            double epsilon  =  0.1;

            double expected = -double.Pi / 2.0;

            double actual = Trigonometry.AsinEpsilon (sinValue, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2EpsilonTest_Common ()
        {
            double dy = 1.0;
            double dx = 1.0;

            double expected = double.Pi / 4.0;

            double actual = Trigonometry.Atan2Epsilon (dy, dx);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2EpsilonTest_AbsDYLessEpsilon_0_DXPositive ()
        {
            double dy      =  0.0;
            double dx      = 42.0;
            double epsilon =  0.1;

            double expected = 0.0;

            double actual = Trigonometry.Atan2Epsilon (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2EpsilonTest_AbsDYLessEpsilon_0_DX0 ()
        {
            double dy      = 0.0;
            double dx      = 0.0;
            double epsilon = 0.1;

            double expected = 0.0;

            double actual = Trigonometry.Atan2Epsilon (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2EpsilonTest_AbsDYLessEpsilon_0_DXNegative ()
        {
            double dy      =   0.0;
            double dx      = -42.0;
            double epsilon =   0.1;

            double expected = double.Pi;

            double actual = Trigonometry.Atan2Epsilon (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2EpsilonTest_AbsDYLessEpsilon_Positive_DXPositive ()
        {
            double dy      =  0.099;
            double dx      = 42.0;
            double epsilon =  0.1;

            double expected = 0.0;

            double actual = Trigonometry.Atan2Epsilon (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2EpsilonTest_AbsDYLessEpsilon_Positive_DX0 ()
        {
            double dy      = 0.099;
            double dx      = 0.0;
            double epsilon = 0.1;

            double expected = 0.0;

            double actual = Trigonometry.Atan2Epsilon (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2EpsilonTest_AbsDYLessEpsilon_Positive_DXNegative ()
        {
            double dy      =   0.099;
            double dx      = -42.0;
            double epsilon =   0.1;

            double expected = double.Pi;

            double actual = Trigonometry.Atan2Epsilon (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2EpsilonTest_AbsDYLessEpsilon_Negative_DXPositive ()
        {
            double dy      = -0.099;
            double dx      = 42.0;
            double epsilon =  0.1;

            double expected = 0.0;

            double actual = Trigonometry.Atan2Epsilon (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2EpsilonTest_AbsDYLessEpsilon_Negative_DX0 ()
        {
            double dy      = -0.099;
            double dx      =  0.0;
            double epsilon =  0.1;

            double expected = 0.0;

            double actual = Trigonometry.Atan2Epsilon (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2EpsilonTest_AbsDYLessEpsilon_Negative_DXNegative ()
        {
            double dy      =  -0.099;
            double dx      = -42.0;
            double epsilon =   0.1;

            double expected = double.Pi;

            double actual = Trigonometry.Atan2Epsilon (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2EpsilonTest_AbsDXLessEpsilon_0_DYPositive ()
        {
            double dy      = 42.0;
            double dx      =  0.0;
            double epsilon =  0.1;

            double expected = double.Pi / 2.0;

            double actual = Trigonometry.Atan2Epsilon (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2EpsilonTest_AbsDXLessEpsilon_0_DY0 ()
        {
            double dy      = 0.0;
            double dx      = 0.0;
            double epsilon = 0.1;

            double expected = 0.0;

            double actual = Trigonometry.Atan2Epsilon (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2EpsilonTest_AbsDXLessEpsilon_0_DYNegative ()
        {
            double dy      = -42.0;
            double dx      =   0.0;
            double epsilon =   0.1;

            double expected = -double.Pi / 2.0;

            double actual = Trigonometry.Atan2Epsilon (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2EpsilonTest_AbsDXLessEpsilon_Positive_DYPositive ()
        {
            double dy      = 42.0;
            double dx      =  0.099;
            double epsilon =  0.1;

            double expected = double.Pi / 2.0;

            double actual = Trigonometry.Atan2Epsilon (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2EpsilonTest_AbsDXLessEpsilon_Positive_DY0 ()
        {
            double dy      = 0.0;
            double dx      = 0.099;
            double epsilon = 0.1;

            double expected = 0.0;

            double actual = Trigonometry.Atan2Epsilon (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2EpsilonTest_AbsDXLessEpsilon_Positive_DYNegative ()
        {
            double dy      = -42.0;
            double dx      =   0.099;
            double epsilon =   0.1;

            double expected = -double.Pi / 2.0;

            double actual = Trigonometry.Atan2Epsilon (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2EpsilonTest_AbsDXLessEpsilon_Negative_DYPositive ()
        {
            double dy      = 42.0;
            double dx      = -0.099;
            double epsilon =  0.1;

            double expected = double.Pi / 2.0;

            double actual = Trigonometry.Atan2Epsilon (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2EpsilonTest_AbsDXLessEpsilon_Negative_DY0 ()
        {
            double dy      =  0.0;
            double dx      = -0.099;
            double epsilon =  0.1;

            double expected = 0.0;

            double actual = Trigonometry.Atan2Epsilon (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2EpsilonTest_AbsDXLessEpsilon_Negative_DYNegative ()
        {
            double dy      = -42.0;
            double dx      =  -0.099;
            double epsilon =   0.1;

            double expected = -double.Pi / 2.0;

            double actual = Trigonometry.Atan2Epsilon (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }
    }
}