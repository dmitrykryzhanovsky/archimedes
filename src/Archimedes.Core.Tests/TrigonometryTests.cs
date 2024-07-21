using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class TrigonometryTests
    {
        [TestMethod ()]
        public void AreEqualAnglesTest_SameAngles ()
        {
            double angle1 = 1.0; 
            double angle2 = 1.0;

            bool expected = true;

            bool actual = Trigonometry.AreEqualAngles (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualAnglesTest_PlusPIMinusPI ()
        {
            double angle1 =  double.Pi;
            double angle2 = -double.Pi;

            bool expected = true;

            bool actual = Trigonometry.AreEqualAngles (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualAnglesTest_MinusPIPlusPI ()
        {
            double angle1 = -double.Pi;
            double angle2 =  double.Pi;

            bool expected = true;

            bool actual = Trigonometry.AreEqualAngles (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualAnglesTest_0Plus2PI ()
        {
            double angle1 = 0.0;
            double angle2 = double.Tau;

            bool expected = true;

            bool actual = Trigonometry.AreEqualAngles (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualAnglesTest_Plus2PIPlus4PI ()
        {
            double angle1 = double.Tau;
            double angle2 = double.Tau * 2.0;

            bool expected = true;

            bool actual = Trigonometry.AreEqualAngles (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualAnglesTest_0Minus2PI ()
        {
            double angle1 =  0.0;
            double angle2 = -double.Tau;

            bool expected = true;

            bool actual = Trigonometry.AreEqualAngles (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualAnglesTest_Minus2PIMinus4PI ()
        {
            double angle1 = -double.Tau;
            double angle2 = -double.Tau * 2.0;

            bool expected = true;

            bool actual = Trigonometry.AreEqualAngles (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualAnglesTest_Equal ()
        {
            double angle1 = 2.0;
            double angle2 = 2.0 - double.Tau * 2.0;

            bool expected = true;

            bool actual = Trigonometry.AreEqualAngles (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualAnglesTest_NotEqual ()
        {
            double angle1 = 2.0;
            double angle2 = 2.0 - double.Pi;

            bool expected = false;

            bool actual = Trigonometry.AreEqualAngles (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngleTest_0 ()
        {
            double x = 0.0;

            double expected = 0.0;

            double actual = Trigonometry.NormalizeAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngleTest_PlusPI2 ()
        {
            double x = double.Pi * 0.5;

            double expected = double.Pi * 0.5;

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
        public void NormalizeAngleTest_Plus3PI2 ()
        {
            double x = double.Pi * 1.5;

            double expected = -double.Pi * 0.5;

            double actual = Trigonometry.NormalizeAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngleTest_Plus2PI ()
        {
            double x = double.Pi * 2.0;

            double expected = 0.0;

            double actual = Trigonometry.NormalizeAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngleTest_Plus5PI2 ()
        {
            double x = double.Pi * 2.5;

            double expected = double.Pi * 0.5;

            double actual = Trigonometry.NormalizeAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngleTest_Plus3PI ()
        {
            double x = double.Pi * 3.0;

            double expected = -double.Pi;

            double actual = Trigonometry.NormalizeAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngleTest_MinusPI2 ()
        {
            double x = -double.Pi * 0.5;

            double expected = -double.Pi * 0.5;

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
        public void NormalizeAngleTest_Minus3PI2 ()
        {
            double x = -double.Pi * 1.5;

            double expected = double.Pi * 0.5;

            double actual = Trigonometry.NormalizeAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngleTest_Minus2PI ()
        {
            double x = -double.Pi * 2.0;

            double expected = 0.0;

            double actual = Trigonometry.NormalizeAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngleTest_Minus5PI2 ()
        {
            double x = -double.Pi * 2.5;

            double expected = -double.Pi * 0.5;

            double actual = Trigonometry.NormalizeAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngleTest_Minus3PI ()
        {
            double x = -double.Pi * 3.0;

            double expected = double.Pi;

            double actual = Trigonometry.NormalizeAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void DegToRadTest ()
        {
            double x = 60.0;

            double expected = 1.04719755119659775;

            double actual = Trigonometry.DegToRad (x);

            Assert.AreEqual (expected, actual, 1.0e-15);
        }

        [TestMethod ()]
        public void MinToRadTest ()
        {
            double x = 60.0;

            double expected = 0.0174532925199432958;

            double actual = Trigonometry.MinToRad (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SecToRadTest ()
        {
            double x = 60.0;

            double expected = 2.90888208665721596e-4;

            double actual = Trigonometry.SecToRad (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void RadToDegTest ()
        {
            double x = 1.0;

            double expected = 57.295779513082320878;

            double actual = Trigonometry.RadToDeg (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void RadToMinTest ()
        {
            double x = 1.0;

            double expected = 3437.74677078493925;

            double actual = Trigonometry.RadToMin (x);

            Assert.AreEqual (expected, actual, 1.0e-12);
        }

        [TestMethod ()]
        public void RadToSecTest ()
        {
            double x = 1.0;

            double expected = 206264.806247096355;

            double actual = Trigonometry.RadToSec (x);

            Assert.AreEqual (expected, actual);
        }
    }
}