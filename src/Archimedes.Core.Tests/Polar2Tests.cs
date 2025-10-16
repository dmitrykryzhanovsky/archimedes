using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Polar2Tests
    {
        [TestMethod ()]
        public void RTest_Get ()
        {
            Polar2 p = new Polar2 (2, double.Pi);

            Assert.AreEqual (2, p.R);
        }

        [TestMethod ()]
        public void RTest_Set ()
        {
            Polar2 p = new Polar2 (2, double.Pi);

            p.R = 3;

            Assert.AreEqual (3, p.R);
        }

        [TestMethod ()]
        public void RTest_Set_Exception_Negative ()
        {
            Polar2 p = new Polar2 (2, double.Pi);

            bool wasException = false;

            try
            {
                p.R = -3;
            }

            catch (ArgumentOutOfRangeException)
            {
                wasException = true;
            }

            Assert.IsTrue (wasException);
        }

        [TestMethod ()]
        public void HeadingTest_Get ()
        {
            Polar2 p = new Polar2 (2, double.Pi);

            Assert.AreEqual (double.Pi, p.Heading);
        }

        [TestMethod ()]
        public void HeadingTest_Set ()
        {
            Polar2 p = new Polar2 (2, double.Pi);

            p.Heading /= 2.0;

            Assert.AreEqual (double.Pi / 2.0, p.Heading);
        }

        [TestMethod ()]
        public void Polar2Test_Parameters ()
        {
            Polar2 p = new Polar2 (2, double.Pi);

            Assert.AreEqual (2, p.R);
            Assert.AreEqual (double.Pi, p.Heading);
        }

        [TestMethod ()]
        public void Polar2Test_Copying ()
        {
            Polar2 p1 = new Polar2 (2, double.Pi);
            Polar2 p2 = new Polar2 (p1);

            Assert.AreEqual (2, p2.R);
            Assert.AreEqual (double.Pi, p2.Heading);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Polar2 p1 = new Polar2 (2, double.Pi);
            Polar2 p2 = (Polar2)p1.Clone ();

            Assert.AreEqual (2, p2.R);
            Assert.AreEqual (double.Pi, p2.Heading);
        }

        [TestMethod ()]
        public void EqualsTest_Equal_HeadingAtSamePhase ()
        {
            Polar2 p1 = new Polar2 (3, double.Pi / 2.0);
            Polar2 p2 = new Polar2 (3, double.Pi / 2.0);

            Assert.IsTrue (p1.Equals (p2));
            Assert.IsTrue (p1 == p2);
            Assert.IsFalse (p1 != p2);
        }

        [TestMethod ()]
        public void EqualsTest_Equal_HeadingAtEqualPhase ()
        {
            Polar2 p1 = new Polar2 (3,        double.Pi / 2.0);
            Polar2 p2 = new Polar2 (3, -3.0 * double.Pi / 2.0);

            Assert.IsTrue (p1.Equals (p2));
            Assert.IsTrue (p1 == p2);
            Assert.IsFalse (p1 != p2);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqual_R ()
        {
            Polar2 p1 = new Polar2 (3, double.Pi / 2.0);
            Polar2 p2 = new Polar2 (4, double.Pi / 2.0);

            Assert.IsFalse (p1.Equals (p2));
            Assert.IsFalse (p1 == p2);
            Assert.IsTrue (p1 != p2);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqual_Heading ()
        {
            Polar2 p1 = new Polar2 (3, double.Pi / 2.0);
            Polar2 p2 = new Polar2 (3, double.Pi / 3.0);

            Assert.IsFalse (p1.Equals (p2));
            Assert.IsFalse (p1 == p2);
            Assert.IsTrue (p1 != p2);
        }

        [TestMethod ()]
        public void EqualsTest_NotEqual_BothRHeading ()
        {
            Polar2 p1 = new Polar2 (3, double.Pi / 2.0);
            Polar2 p2 = new Polar2 (4, double.Pi / 3.0);

            Assert.IsFalse (p1.Equals (p2));
            Assert.IsFalse (p1 == p2);
            Assert.IsTrue (p1 != p2);
        }

        [TestMethod ()]
        public void GetCartesianTest ()
        {
            Polar2 p = new Polar2 (5, -2.2142974355881810);

            Vector2 expected = new Vector2 (-3, -4);

            Vector2 actual = p.GetCartesian ();

            Assert.AreEqual (expected.X, actual.X, 1.0e-14);
            Assert.AreEqual (expected.Y, actual.Y, 1.0e-14);
        }
    }
}