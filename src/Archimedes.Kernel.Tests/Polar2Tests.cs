using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Polar2Tests
    {
        [TestMethod ()]
        public void RTest_Get ()
        {
            Polar2 p = new Polar2 (73, 42);

            double expected = 73;

            double actual = p.R;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void RTest_Set_Positive ()
        {
            Polar2 p = new Polar2 (73, 42);
            double value = 43;

            double expected = 43;

            p.R = value;
            double actual = p.R;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void RTest_Set_Zero ()
        {
            Polar2 p = new Polar2 (73, 42);
            double value = 0;

            double expected = 0;

            p.R = value;
            double actual = p.R;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void RTest_Set_Negative ()
        {
            Polar2 p = new Polar2 (73, 42);
            double value = -43;

            bool wasException = false;

            try
            {
                p.R = value;
            }

            catch (ArgumentOutOfRangeException)
            {
                wasException = true;
            }

            Assert.AreEqual (true, wasException);
        }

        [TestMethod ()]
        public void HeadingTest_Get ()
        {
            Polar2 p = new Polar2 (73, 42);

            double expected = 42;

            double actual = p.Heading;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void HeadingTest_Set ()
        {
            Polar2 p = new Polar2 (73, 42);
            double value = 43;

            double expected = 43;

            p.Heading = value;
            double actual = p.Heading;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Polar2_RHeading_RPositive ()
        {
            Polar2 p = new Polar2 (73, 42);

            Assert.AreEqual (73, p.R);
            Assert.AreEqual (42, p.Heading);
        }

        [TestMethod ()]
        public void Polar2_RHeading_RNegative ()
        {
            bool wasException = false;

            try
            {
                Polar2 p = new Polar2 (-73, 42);
            }

            catch (ArgumentOutOfRangeException)
            {
                wasException = true;
            }

            Assert.AreEqual (true, wasException);
        }

        [TestMethod ()]
        public void Polar2Test_Copy ()
        {
            Polar2 p1 = new Polar2 (73, 42);
            Polar2 p2 = new Polar2 (p1);

            Assert.AreEqual (73, p2.R);
            Assert.AreEqual (42, p2.Heading);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Polar2 p1 = new Polar2 (73, 42);
            Polar2 p2 = (Polar2)p1.Clone ();

            Assert.AreEqual (73, p2.R);
            Assert.AreEqual (42, p2.Heading);
        }

        [TestMethod ()]
        public void CreateDirectTest ()
        {
            Polar2 p = Polar2.CreateDirect (73, 42);

            Assert.AreEqual (73, p.R);
            Assert.AreEqual (42, p.Heading);
        }

        [TestMethod ()]
        public void EqualsTest_RZeroHeadingDifferent ()
        {
            Polar2 p1 = new Polar2 (0, 42);
            Polar2 p2 = new Polar2 (0, 73);

            bool expected = true;

            bool actual = p1.Equals (p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_REqualHeadingEqualIn2PI ()
        {
            Polar2 p1 = new Polar2 (73, 42);
            Polar2 p2 = new Polar2 (73, 42 + double.Tau);

            bool expected = true;

            bool actual = p1.Equals (p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_REqualHeadingDifferent ()
        {
            Polar2 p1 = new Polar2 (73, 42);
            Polar2 p2 = new Polar2 (73, 42 + double.Pi);

            bool expected = false;

            bool actual = p1.Equals (p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_RDifferent ()
        {
            Polar2 p1 = new Polar2 (73, 42);
            Polar2 p2 = new Polar2 (89, 42);

            bool expected = false;

            bool actual = p1.Equals (p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualsTest_True ()
        {
            Polar2 p1 = new Polar2 (73, 42);
            Polar2 p2 = new Polar2 (73, 42 + double.Tau);

            bool expected = true;

            bool actual = (p1 == p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualsTest_False ()
        {
            Polar2 p1 = new Polar2 (73, 42);
            Polar2 p2 = new Polar2 (73, 42 + double.Pi);

            bool expected = false;

            bool actual = (p1 == p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualsTest_True ()
        {
            Polar2 p1 = new Polar2 (73, 42);
            Polar2 p2 = new Polar2 (73, 42 + double.Pi);

            bool expected = true;

            bool actual = (p1 != p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualsTest_False ()
        {
            Polar2 p1 = new Polar2 (73, 42);
            Polar2 p2 = new Polar2 (73, 42 + double.Tau);

            bool expected = false;

            bool actual = (p1 != p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeTest_RPositive ()
        {
            Polar2 p = new Polar2 (2, double.Pi + 2);

            p.Normalize ();

            Assert.AreEqual (2, p.R);
            Assert.AreEqual (-double.Pi + 2, p.Heading);
        }

        [TestMethod ()]
        public void NormalizeTest_RZero ()
        {
            Polar2 p = new Polar2 (0, double.Pi + 2);

            p.Normalize ();

            Assert.AreEqual (0, p.R);
            Assert.AreEqual (0, p.Heading);
        }

        [TestMethod ()]
        public void ToCartesianTest_Origin ()
        {
            Polar2 p = new Polar2 (0, 73);

            Vector2 actual = p.ToCartesian ();

            Assert.AreEqual (0, actual.X);
            Assert.AreEqual (0, actual.Y);
        }

        [TestMethod ()]
        public void ToCartesianTest_HeadingZero()
        {
            Polar2 p = new Polar2 (42, 0);

            Vector2 actual = p.ToCartesian ();

            Assert.AreEqual (42, actual.X);
            Assert.AreEqual (0, actual.Y);
        }

        [TestMethod ()]
        public void ToCartesianTest_HeadingPlusPI2 ()
        {
            Polar2 p = new Polar2 (42, MathConst.M_PI_2);

            Vector2 actual = p.ToCartesian ();

            Assert.AreEqual (0, actual.X);
            Assert.AreEqual (42, actual.Y);
        }

        [TestMethod ()]
        public void ToCartesianTest_HeadingPlusPI ()
        {
            Polar2 p = new Polar2 (42, double.Pi);

            Vector2 actual = p.ToCartesian ();

            Assert.AreEqual (-42, actual.X);
            Assert.AreEqual (0, actual.Y);
        }

        [TestMethod ()]
        public void ToCartesianTest_HeadingPlus3PI2 ()
        {
            Polar2 p = new Polar2 (42, 3.0 * MathConst.M_PI_2);

            Vector2 actual = p.ToCartesian ();

            Assert.AreEqual (0, actual.X);
            Assert.AreEqual (-42, actual.Y);
        }

        [TestMethod ()]
        public void ToCartesianTest_HeadingPlus2PI ()
        {
            Polar2 p = new Polar2 (42, double.Tau);

            Vector2 actual = p.ToCartesian ();

            Assert.AreEqual (42, actual.X);
            Assert.AreEqual (0, actual.Y);
        }

        [TestMethod ()]
        public void ToCartesianTest_HeadingMinusPI2 ()
        {
            Polar2 p = new Polar2 (42, -MathConst.M_PI_2);

            Vector2 actual = p.ToCartesian ();

            Assert.AreEqual (0, actual.X);
            Assert.AreEqual (-42, actual.Y);
        }

        [TestMethod ()]
        public void ToCartesianTest_HeadingMinusPI ()
        {
            Polar2 p = new Polar2 (42, -double.Pi);

            Vector2 actual = p.ToCartesian ();

            Assert.AreEqual (-42, actual.X);
            Assert.AreEqual (0, actual.Y);
        }

        [TestMethod ()]
        public void ToCartesianTest_Common ()
        {
            Polar2 p = new Polar2 (42, 7.0 * double.Pi / 6.0);

            Vector2 actual = p.ToCartesian ();

            Assert.AreEqual (-21.0 * double.Sqrt (3.0), actual.X, 1.0e-13);
            Assert.AreEqual (-21.0, actual.Y, 1.0e-13);
        }
    }
}