using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class TrigonometryTests
    {
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

            double expected = MathConst.M_PI_2;

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

            double expected = -MathConst.M_PI_2;

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