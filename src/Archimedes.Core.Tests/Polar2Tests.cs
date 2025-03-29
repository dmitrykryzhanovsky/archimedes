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
        public void Polar2Test_Polar2 ()
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
    }
}