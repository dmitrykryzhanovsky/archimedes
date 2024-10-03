using Archimedes;

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
            double epsilon  = 1.0e-12;

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
    }
}