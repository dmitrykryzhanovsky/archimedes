using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class TrigonometryTests
    {
        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_Same_Zero ()
        {
            double angle1 = 0.0;
            double angle2 = 0.0;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_Same_PlusPI ()
        {
            double angle1 = double.Pi;
            double angle2 = double.Pi;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_Same_Plus2PI ()
        {
            double angle1 = double.Tau;
            double angle2 = double.Tau;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_Same_Positive ()
        {
            double angle1 = double.Pi / 3.0;
            double angle2 = double.Pi / 3.0;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_Same_MinusPI ()
        {
            double angle1 = -double.Pi;
            double angle2 = -double.Pi;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_Same_Minus2PI ()
        {
            double angle1 = -double.Tau;
            double angle2 = -double.Tau;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_Same_Negative ()
        {
            double angle1 = -double.Pi / 3.0;
            double angle2 = -double.Pi / 3.0;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_NotSame_Positive ()
        {
            double angle1 =       double.Pi / 3.0;
            double angle2 = 7.0 * double.Pi / 3.0;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_NotSame_Negative ()
        {
            double angle1 =        -double.Pi / 3.0;
            double angle2 = -13.0 * double.Pi / 3.0;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_NotSame_ChangeSign ()
        {
            double angle1 =        double.Pi / 3.0;
            double angle2 = -5.0 * double.Pi / 3.0;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_Equal_NotSame_PlusMinusPI ()
        {
            double angle1 =  double.Pi;
            double angle2 = -double.Pi;

            bool expected = true;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_NotEqual_Positive ()
        {
            double angle1 =       double.Pi / 3.0 + 1.0e-12;
            double angle2 = 7.0 * double.Pi / 3.0;

            bool expected = false;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_NotEqual_Negative ()
        {
            double angle1 =        -double.Pi / 3.0 + 1.0e-12;
            double angle2 = -13.0 * double.Pi / 3.0;

            bool expected = false;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AreEqualPhaseInRad_NotEqual_ChangeSign ()
        {
            double angle1 =        double.Pi / 3.0 + 1.0e-12;
            double angle2 = -5.0 * double.Pi / 3.0;

            bool expected = false;

            bool actual = Trigonometry.AreEqualPhaseInRad (angle1, angle2);

            Assert.AreEqual (expected, actual);
        }
    }
}