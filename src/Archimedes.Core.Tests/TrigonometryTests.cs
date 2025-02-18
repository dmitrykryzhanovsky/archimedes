using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class TrigonometryTests
    {
        [TestMethod ()]
        public void DegToRadTest ()
        {
            double angle = 60.0;

            double expected = 1.04719755119659775;

            double actual = Trigonometry.DegToRad (angle);

            Assert.AreEqual (expected, actual, 1.0e-15);
        }

        [TestMethod ()]
        public void MinToRadTest ()
        {
            double angle = 3600.0;

            double expected = 1.04719755119659775;

            double actual = Trigonometry.MinToRad (angle);

            Assert.AreEqual (expected, actual, 1.0e-15);
        }

        [TestMethod ()]
        public void SecToRadTest ()
        {
            double angle = 216000.0;

            double expected = 1.04719755119659775;

            double actual = Trigonometry.SecToRad (angle);

            Assert.AreEqual (expected, actual, 1.0e-15);
        }

        [TestMethod ()]
        public void HourToRadTest ()
        {
            double angle = 4.0;

            double expected = 1.04719755119659775;

            double actual = Trigonometry.HourToRad (angle);

            Assert.AreEqual (expected, actual, 1.0e-15);
        }

        [TestMethod ()]
        public void HMinToRadTest ()
        {
            double angle = 240.0;

            double expected = 1.04719755119659775;

            double actual = Trigonometry.HMinToRad (angle);

            Assert.AreEqual (expected, actual, 1.0e-15);
        }

        [TestMethod ()]
        public void HSecToRadTest ()
        {
            double angle = 14400.0;

            double expected = 1.04719755119659775;

            double actual = Trigonometry.HSecToRad (angle);

            Assert.AreEqual (expected, actual, 1.0e-15);
        }

        [TestMethod ()]
        public void RadToDegTest ()
        {
            double rad = 1.0;

            double expected = 57.2957795130823209;

            double actual = Trigonometry.RadToDeg (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void RadToMinTest ()
        {
            double rad = 1.0;

            double expected = 3437.74677078493925;

            double actual = Trigonometry.RadToMin (rad);

            Assert.AreEqual (expected, actual, 1.0e-12);
        }

        [TestMethod ()]
        public void RadToSecTest ()
        {
            double rad = 1.0;

            double expected = 206264.806247096355;

            double actual = Trigonometry.RadToSec (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void HourToDegTest ()
        {
            double rad = 1.0;

            double expected = 3.81971863420548806;

            double actual = Trigonometry.RadToHour (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void RadToHMinTest ()
        {
            double rad = 1.0;

            double expected = 229.183118052329284;

            double actual = Trigonometry.RadToHMin (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void RadToHSecTest ()
        {
            double rad = 1.0;

            double expected = 13750.9870831397570;

            double actual = Trigonometry.RadToHSec (rad);

            Assert.AreEqual (expected, actual, 1.0e-11);
        }

        [TestMethod ()]
        public void RotationFractionTest_0 ()
        {
            double x = 3.0;

            double expected = 0.0;

            double actual = Trigonometry.RotationFraction (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void RotationFractionTest_025 ()
        {
            double x = 3.25;

            double expected = MathConst.PI_2;

            double actual = Trigonometry.RotationFraction (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void RotationFractionTest_05 ()
        {
            double x = -4.5;

            double expected = double.Pi;

            double actual = Trigonometry.RotationFraction (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void RotationFractionTest_075 ()
        {
            double x = -4.25;

            double expected = MathConst._3_PI_2;

            double actual = Trigonometry.RotationFraction (x);

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

            double expected = MathConst.PI_2;

            double actual = Trigonometry.AsinSmall (sinValue, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AsinSmallTest_MinusPi2 ()
        {
            double sinValue = -0.9999999999995;
            double epsilon  =  1.0e-12;

            double expected = -MathConst.PI_2;

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
            double dx = 5.0e-13;
            double dy = 5.0e-13;
            double epsilon = 1.0e-12;

            double expected = 0.0;

            double actual = Trigonometry.Atan2Small (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2SmallTest_DXSmall_DYPositive ()
        {
            double dx = 5.0e-13;
            double dy = 1.0;
            double epsilon = 1.0e-12;

            double expected = MathConst.PI_2;

            double actual = Trigonometry.Atan2Small (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2SmallTest_DXSmall_DY0 ()
        {
            double dx = 5.0e-13;
            double dy = 0.0;
            double epsilon = 1.0e-12;

            double expected = 0.0;

            double actual = Trigonometry.Atan2Small (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2SmallTest_DXSmall_DYNegative ()
        {
            double dx =  5.0e-13;
            double dy = -1.0;
            double epsilon = 1.0e-12;

            double expected = -MathConst.PI_2;

            double actual = Trigonometry.Atan2Small (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2SmallTest_DXPositive_DYSmall ()
        {
            double dx = 1.0;
            double dy = 5.0e-13;
            double epsilon = 1.0e-12;

            double expected = 0.0;

            double actual = Trigonometry.Atan2Small (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2SmallTest_DX0_DYSmall ()
        {
            double dx = 0.0;
            double dy = 5.0e-13;
            double epsilon = 1.0e-12;

            double expected = 0.0;

            double actual = Trigonometry.Atan2Small (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2SmallTest_DXNegative_DYSmall ()
        {
            double dx = -1.0;
            double dy =  5.0e-13;
            double epsilon = 1.0e-12;

            double expected = double.Pi;

            double actual = Trigonometry.Atan2Small (dy, dx, epsilon);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Atan2SmallTest_Common ()
        {
            double dx = -1.0;
            double dy = -double.Sqrt (3.0);
            double epsilon = 1.0e-12;

            double expected = -2.0 * double.Pi / 3.0;

            double actual = Trigonometry.Atan2Small (dy, dx, epsilon);

            Assert.AreEqual (expected, actual, 1.0e-15);
        }
    }
}