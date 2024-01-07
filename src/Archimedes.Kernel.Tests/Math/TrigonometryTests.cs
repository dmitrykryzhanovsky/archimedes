using Archimedes;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class TrigonometryTests
    {
        [TestMethod ()]
        public void DegToRadTest ()
        {
            double deg = 60.0;

            Assert.AreEqual (Double.Pi / 3.0, Trigonometry.DegToRad (deg));
        }

        [TestMethod ()]
        public void SecToRadTest ()
        {
            double sec = 216000.0;

            Assert.AreEqual (Double.Pi / 3.0, Trigonometry.SecToRad (sec));
        }

        [TestMethod ()]
        public void NormalizeTest_Angle0 ()
        {
            double angle = 0.0;

            double expected = 0.0;

            double actual = Trigonometry.Normalize (angle);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeTest_AnglePositiveLessPI ()
        {
            double angle = 3.0;

            double expected = 3.0;

            double actual = Trigonometry.Normalize (angle);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeTest_AngleNearPILeft ()
        {
            double angle = double.Pi - 1.0e-15;

            double expected = double.Pi - 1.0e-15;

            double actual = Trigonometry.Normalize (angle);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeTest_AngleAlmostPILeft ()
        {
            double angle = double.Pi - double.Epsilon;

            double expected = double.Pi;

            double actual = Trigonometry.Normalize (angle);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeTest_AnglePI ()
        {
            double angle = double.Pi;

            double expected = double.Pi;

            double actual = Trigonometry.Normalize (angle);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeTest_AngleAlmostPIRight ()
        {
            double angle = double.Pi + double.Epsilon;

            double expected = double.Pi;

            double actual = Trigonometry.Normalize (angle);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeTest_AngleNearPIRight ()
        {
            double angle = double.Pi + 1.0e-15;

            double expected = -double.Pi + 1.0e-15;

            double actual = Trigonometry.Normalize (angle);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeTest_AnglePositiveGreterPI ()
        {
            double angle = 6.0;

            double expected = 6.0 - double.Tau;

            double actual = Trigonometry.Normalize (angle);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeTest_AngleNegativeGreaterPI ()
        {
            double angle = -3.0;

            double expected = -3.0;

            double actual = Trigonometry.Normalize (angle);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeTest_AngleNearMinusPIRight ()
        {
            double angle = -double.Pi + 1.0e-15;

            double expected = -double.Pi + 1.0e-15;

            double actual = Trigonometry.Normalize (angle);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeTest_AngleAlmostMinusPIRight ()
        {
            double angle = -double.Pi + double.Epsilon;

            double expected = -double.Pi;

            double actual = Trigonometry.Normalize (angle);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeTest_AngleMinusPI ()
        {
            double angle = -double.Pi;

            double expected = -double.Pi;

            double actual = Trigonometry.Normalize (angle);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeTest_AngleAlmostMinusPILeft ()
        {
            double angle = -double.Pi - double.Epsilon;

            double expected = -double.Pi;

            double actual = Trigonometry.Normalize (angle);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeTest_AngleNearMinusPILeft ()
        {
            double angle = -double.Pi - 1.0e-15;

            double expected = double.Pi - 1.0e-15;

            double actual = Trigonometry.Normalize (angle);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeTest_AngleNegativeLessPI ()
        {
            double angle = -6.0;

            double expected = -6.0 + double.Tau;

            double actual = Trigonometry.Normalize (angle);

            Assert.AreEqual (expected, actual);
        }
    }
}