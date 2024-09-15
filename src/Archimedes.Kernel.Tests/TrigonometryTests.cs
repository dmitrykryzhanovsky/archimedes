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
    }
}