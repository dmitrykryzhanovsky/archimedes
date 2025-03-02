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
        public void PhaseInDegTest_Positive_HalfTurn_1 ()
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

            double expected = -180.0;

            double actual = Trigonometry.PhaseInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInDegTest_Positive_HalfTurn_2 ()
        {
            double deg = 270.0;

            double expected = -90.0;

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
        public void PhaseInDegTest_Positive_HalfTurn_3 ()
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

            double expected = -180.0;

            double actual = Trigonometry.PhaseInDeg (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void PhaseInDegTest_Positive_HalfTurn_4 ()
        {
            double deg = 630.0;

            double expected = -90.0;

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
        public void PhaseInDegTest_Negative_HalfTurn_1 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void PhaseInDegTest_Negative_180 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void PhaseInDegTest_Negative_HalfTurn_2 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void PhaseInDegTest_Negative_360 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void PhaseInDegTest_Negative_HalfTurn_3 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void PhaseInDegTest_Negative_540 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void PhaseInDegTest_Negative_HalfTurn_4 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void PhaseInDegTest_Negative_720 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void PhaseInHourTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void PhaseInRadTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void PhaseInOrbitTest ()
        {
            Assert.Fail ();
        }
    }
}