using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class TrigonometryTests
    {
        [TestMethod ()]
        public void AreEqualAnglesTest_EqualLiterally ()
        {
            double x = 1.0;
            double y = 1.0;

            bool expected = true;

            bool actual = Trigonometry.AreEqualAngles (x, y);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualAnglesTest_EqualIn2PI_XGreaterY ()
        {
            double x =  double.Pi;
            double y = -double.Pi;

            bool expected = true;

            bool actual = Trigonometry.AreEqualAngles (x, y);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualAnglesTest_EqualIn2PI_XLessY ()
        {
            double x = -double.Pi;
            double y =  double.Pi;

            bool expected = true;

            bool actual = Trigonometry.AreEqualAngles (x, y);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualAnglesTest_NotEqual ()
        {
            double x = double.Pi;
            double y = double.Tau;

            bool expected = false;

            bool actual = Trigonometry.AreEqualAngles (x, y);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngleTest_BetweenMinusPIPlusPI ()
        {
            double x = 1.0;

            double expected = 1.0;

            double actual = Trigonometry.NormalizeAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngleTest_PlusPI ()
        {
            double x = double.Pi;

            double expected = double.Pi;

            double actual = Trigonometry.NormalizeAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngleTest_PlusPIALittleBitGreater ()
        {
            double x = double.Pi + 1.0e-12;

            double expected = -double.Pi + 1.0e-12;

            double actual = Trigonometry.NormalizeAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngleTest_2PI ()
        {
            double x = double.Tau;

            double expected = 0.0;

            double actual = Trigonometry.NormalizeAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngleTest_MinusPI ()
        {
            double x = -double.Pi;

            double expected = -double.Pi;

            double actual = Trigonometry.NormalizeAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngleTest_MinusPIALittleBitLess ()
        {
            double x = -double.Pi - 1.0e-12;

            double expected = double.Pi - 1.0e-12;

            double actual = Trigonometry.NormalizeAngle (x);

            Assert.AreEqual (expected, actual);
        }
    }
}