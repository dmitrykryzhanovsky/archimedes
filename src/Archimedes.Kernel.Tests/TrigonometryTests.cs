using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class TrigonometryTests
    { 
        [TestMethod ()]
        public void AreEqualAnglesTest_EqualExactly ()
        {
            double x = 42;
            double y = 42;

            bool expected = true;

            bool actual = Trigonometry.AreEqualAngles (x, y);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualAnglesTest_Arg1PiGreater ()
        {
            double x = 42 + double.Pi;
            double y = 42;

            bool expected = false;

            bool actual = Trigonometry.AreEqualAngles (x, y);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualAnglesTest_Arg12PiGreater ()
        {
            double x = 42 + double.Tau;
            double y = 42;

            bool expected = true;

            bool actual = Trigonometry.AreEqualAngles (x, y);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualAnglesTest_Arg13PiGreater ()
        {
            double x = 42 + double.Pi * 3.0;
            double y = 42;

            bool expected = false;

            bool actual = Trigonometry.AreEqualAngles (x, y);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualAnglesTest_Arg14PiGreater ()
        {
            double x = 42 + double.Tau * 2.0;
            double y = 42;

            bool expected = true;

            bool actual = Trigonometry.AreEqualAngles (x, y);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualAnglesTest_Arg1PiLess ()
        {
            double x = 42 - double.Pi;
            double y = 42;

            bool expected = false;

            bool actual = Trigonometry.AreEqualAngles (x, y);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualAnglesTest_Arg12PiLess ()
        {
            double x = 42 - double.Tau;
            double y = 42;

            bool expected = true;

            bool actual = Trigonometry.AreEqualAngles (x, y);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualAnglesTest_Arg13PiLess ()
        {
            double x = 42 - double.Pi * 3.0;
            double y = 42;

            bool expected = false;

            bool actual = Trigonometry.AreEqualAngles (x, y);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualAnglesTest_Arg14PiLess ()
        {
            double x = 42 - double.Tau * 2.0;
            double y = 42;

            bool expected = true;

            bool actual = Trigonometry.AreEqualAngles (x, y);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void DegToRadTest ()
        {
            double x = 60;

            double expected = double.Pi / 3.0;

            double actual = Trigonometry.DegToRad (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MinToRadTest ()
        {
            double x = 60;

            double expected = double.Pi / 180.0;

            double actual = Trigonometry.MinToRad (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SecToRadTest ()
        {
            double x = 60;

            double expected = double.Pi / 10800.0;

            double actual = Trigonometry.SecToRad (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void RadToDegTest ()
        {
            double x = 1.0;

            double expected = 180.0 / double.Pi;

            double actual = Trigonometry.RadToDeg (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngleTest_Minus2Pi ()
        {
            double x = -double.Tau;

            double expected = 0.0;

            double actual = Trigonometry.NormalizeAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngleTest_MinusPi ()
        {
            double x = -double.Pi;

            double expected = -double.Pi;

            double actual = Trigonometry.NormalizeAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngleTest_Pi ()
        {
            double x = double.Pi;

            double expected = double.Pi;

            double actual = Trigonometry.NormalizeAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngleTest_2Pi ()
        {
            double x = double.Tau;

            double expected = 0.0;

            double actual = Trigonometry.NormalizeAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngleTest_3Pi ()
        {
            double x = 3.0 * double.Pi;

            double expected = -double.Pi;

            double actual = Trigonometry.NormalizeAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngle2PITest_Minus2Pi ()
        {
            double x = -double.Tau;

            double expected = 0.0;

            double actual = Trigonometry.NormalizeAngle2PI (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngle2PITest_MinusPi ()
        {
            double x = -double.Pi;

            double expected = double.Pi;

            double actual = Trigonometry.NormalizeAngle2PI (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngle2PITest_Pi ()
        {
            double x = double.Pi;

            double expected = double.Pi;

            double actual = Trigonometry.NormalizeAngle2PI (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngle2PITest_2Pi ()
        {
            double x = double.Tau;

            double expected = 0.0;

            double actual = Trigonometry.NormalizeAngle2PI (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeAngle2PITest_3Pi ()
        {
            double x = 3.0 * double.Pi;

            double expected = double.Pi;

            double actual = Trigonometry.NormalizeAngle2PI (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AsinSmallTest_0 ()
        {
            double sinValue = 5.0e-13;
            double epsilon  = 1.0e-12;

            double expected = 0.0;

            double actual = Trigonometry.AsinSmall (sinValue, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AsinSmallTest_Epsilon ()
        {
            double sinValue = 1.0e-12;
            double epsilon  = 1.0e-12;

            double expected = double.Asin (1.0e-12);

            double actual = Trigonometry.AsinSmall (sinValue, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AsinSmallTest_PlusPi2 ()
        {
            double sinValue = 0.9999999999995;
            double epsilon  = 1.0e-12;

            double expected = MathConst.M_PI_2;

            double actual = Trigonometry.AsinSmall (sinValue, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AsinSmallTest_MinusPi2 ()
        {
            double sinValue = -0.9999999999995;
            double epsilon  =  1.0e-12;

            double expected = -MathConst.M_PI_2;

            double actual = Trigonometry.AsinSmall (sinValue, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AsinSmallTest_Common ()
        {
            double sinValue = 0.5;
            double epsilon  = 1.0e-12;

            double expected = double.Pi / 6.0;

            double actual = Trigonometry.AsinSmall (sinValue, epsilon);

            Assert.AreEqual (expected, actual, 1.0e-15);
        }

        [TestMethod ()]
        public void Atan2SmallTest_DXSmall_DYSmall ()
        {
            double dx      = 5.0e-13;
            double dy      = 5.0e-13;
            double epsilon = 1.0e-12;

            double expected = 0.0;

            double actual = Trigonometry.Atan2Small (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2SmallTest_DXSmall_DYPositive ()
        {
            double dx      = 5.0e-13;
            double dy      = 1.0;
            double epsilon = 1.0e-12;

            double expected = MathConst.M_PI_2;

            double actual = Trigonometry.Atan2Small (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2SmallTest_DXSmall_DY0 ()
        {
            double dx      = 5.0e-13;
            double dy      = 0.0;
            double epsilon = 1.0e-12;

            double expected = 0.0;

            double actual = Trigonometry.Atan2Small (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2SmallTest_DXSmall_DYNegative ()
        {
            double dx      =  5.0e-13;
            double dy      = -1.0;
            double epsilon =  1.0e-12;

            double expected = -MathConst.M_PI_2;

            double actual = Trigonometry.Atan2Small (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2SmallTest_DXPositive_DYSmall ()
        {
            double dx      = 1.0;
            double dy      = 5.0e-13;
            double epsilon = 1.0e-12;

            double expected = 0.0;

            double actual = Trigonometry.Atan2Small (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2SmallTest_DX0_DYSmall ()
        {
            double dx      = 0.0;
            double dy      = 5.0e-13;
            double epsilon = 1.0e-12;

            double expected = 0.0;

            double actual = Trigonometry.Atan2Small (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2SmallTest_DXNegative_DYSmall ()
        {
            double dx      = -1.0;
            double dy      =  5.0e-13;
            double epsilon =  1.0e-12;

            double expected = double.Pi;

            double actual = Trigonometry.Atan2Small (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2SmallTest_Common ()
        {
            double dx      = -1.0;
            double dy      = -double.Sqrt (3.0);
            double epsilon =  1.0e-12;

            double expected = -2.0 * double.Pi / 3.0;

            double actual = Trigonometry.Atan2Small (dy, dx, epsilon);

            Assert.AreEqual (expected, actual, 1.0e-15);
        }
    }
}