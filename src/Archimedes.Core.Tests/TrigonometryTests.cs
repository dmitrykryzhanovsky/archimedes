using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class TrigonometryTests
    {
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
    }
}