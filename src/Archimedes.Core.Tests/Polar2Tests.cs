using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Polar2Tests
    {
        [TestMethod ()]
        public void RTest_Get ()
        {
            Polar2 p = new Polar2 (3, 1);

            double expected = 3;

            double actual = p.R;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void RTest_Set_Positive ()
        {
            Polar2 p = new Polar2 (3, 1);

            p.R = 5;

            double expected = 5;

            double actual = p.R;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void RTest_Set_Zero ()
        {
            Polar2 p = new Polar2 (3, 1);

            p.R = 0;

            double expected = 0;

            double actual = p.R;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void RTest_Set_Negative ()
        {
            Polar2 p = new Polar2 (3, 1);

            bool actual = false;

            try
            {
                p.R = -5;
            }

            catch
            {
                actual = true;
            }

            Assert.AreEqual (true, actual);
        }

        [TestMethod ()]
        public void HeadingTest_Get ()
        {
            Polar2 p = new Polar2 (3, 1);

            double expected = 1;

            double actual = p.Heading;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void HeadingTest_Set ()
        {
            Polar2 p = new Polar2 (3, 1);

            p.Heading = 5;

            double expected = 5;

            double actual = p.Heading;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Polar2Test_RHeading ()
        {
            Polar2 p = new Polar2 (3, 1);

            double expectedR       = 3;
            double expectedHeading = 1;

            double actualR       = p.R;
            double actualHeading = p.Heading;

            Assert.AreEqual (expectedR, actualR);
            Assert.AreEqual (expectedHeading, actualHeading);
        }

        [TestMethod ()]
        public void Polar2Test_Copying ()
        {
            Polar2 other = new Polar2 (3, 1);
            Polar2 p     = new Polar2 (other);

            double expectedR       = 3;
            double expectedHeading = 1;

            double actualR       = p.R;
            double actualHeading = p.Heading;

            Assert.AreEqual (expectedR, actualR);
            Assert.AreEqual (expectedHeading, actualHeading);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Polar2 other = new Polar2 (3, 1);
            Polar2 p     = (Polar2)other.Clone ();

            double expectedR       = 3;
            double expectedHeading = 1;

            double actualR       = p.R;
            double actualHeading = p.Heading;

            Assert.AreEqual (expectedR, actualR);
            Assert.AreEqual (expectedHeading, actualHeading);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqualR ()
        {
            Polar2 p1 = new Polar2 (2, 1);
            Polar2 p2 = new Polar2 (3, 2);

            bool expected = false;

            bool actual = p1.Equals (p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualRZero_DifferentHeading ()
        {
            Polar2 p1 = new Polar2 (0, 1);
            Polar2 p2 = new Polar2 (0, 2);

            bool expected = true;

            bool actual = p1.Equals (p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualRPositive_DifferentHeading ()
        {
            Polar2 p1 = new Polar2 (3, 1);
            Polar2 p2 = new Polar2 (3, 2);

            bool expected = false;

            bool actual = p1.Equals (p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualRPositive_SameHeading ()
        {
            Polar2 p1 = new Polar2 (3, 1.0);
            Polar2 p2 = new Polar2 (3, 7.28318530717958648);

            bool expected = true;

            bool actual = p1.Equals (p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualRPositive_EqualHeading ()
        {
            Polar2 p1 = new Polar2 (3, 1);
            Polar2 p2 = new Polar2 (3, 1);

            bool expected = true;

            bool actual = p1.Equals (p2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizeTest ()
        {
            Polar2 p = new Polar2 (0, 73);

            double expected = -2.39822368615503772;

            p.Normalize ();

            double actual = p.Heading;

            Assert.AreEqual (expected, actual, 1.0e-14);
        }

        [TestMethod ()]
        public void ToCartesianTest_Zero ()
        {
            Polar2 p = new Polar2 (0, 73);

            double expectedX = 0.0;
            double expectedY = 0.0;

            Vector2 actual = p.ToCartesian ();

            Assert.AreEqual (expectedX, actual.X);
            Assert.AreEqual (expectedY, actual.Y);
        }

        [TestMethod ()]
        public void ToCartesianTest_Common ()
        {
            Polar2 p = new Polar2 (2, 3.66519142918809211);

            double expectedX = -1.73205080756887729;
            double expectedY = -1.0;

            Vector2 actual = p.ToCartesian ();

            Assert.AreEqual (expectedX, actual.X, 1.0e-15);
            Assert.AreEqual (expectedY, actual.Y, 1.0e-15);
        }
    }
}