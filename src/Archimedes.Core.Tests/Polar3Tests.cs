using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Polar3Tests
    {
        [TestMethod ()]
        public void RTest_Get ()
        {
            Polar3 p = new Polar3 (2, double.Pi / 3.0, double.Pi / 2.0);

            Assert.AreEqual (2, p.R);
        }

        [TestMethod ()]
        public void RTest_Set ()
        {
            Polar3 p = new Polar3 (2, double.Pi / 3.0, double.Pi / 2.0);

            p.R = 3;

            Assert.AreEqual (3, p.R);
        }

        [TestMethod ()]
        public void RTest_Set_Exception_Negative ()
        {
            Polar3 p = new Polar3 (2, double.Pi / 3.0, double.Pi / 2.0);

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
        public void LatTest_Get ()
        {
            Polar3 p = new Polar3 (2, double.Pi / 3.0, double.Pi / 2.0);

            Assert.AreEqual (double.Pi / 3.0, p.Lat);
        }

        [TestMethod ()]
        public void LatTest_Set ()
        {
            Polar3 p = new Polar3 (2, double.Pi / 3.0, double.Pi / 2.0);

            p.Lat = -double.Pi / 6.0;

            Assert.AreEqual (-double.Pi / 6.0, p.Lat);
        }

        [TestMethod ()]
        public void LatTest_Set_Exception_LessThanMinusPI2 ()
        {
            Polar3 p = new Polar3 (2, double.Pi / 3.0, double.Pi / 2.0);

            bool wasException = false;

            try
            {
                p.Lat = -double.Pi / 2.0 - 1.0e-15;
            }

            catch (ArgumentOutOfRangeException)
            {
                wasException = true;
            }

            Assert.IsTrue (wasException);
        }

        [TestMethod ()]
        public void LatTest_Set_Exception_GreaterThanPlusPI2 ()
        {
            Polar3 p = new Polar3 (2, double.Pi / 3.0, double.Pi / 2.0);

            bool wasException = false;

            try
            {
                p.Lat = double.Pi / 2.0 + 1.0e-15;
            }

            catch (ArgumentOutOfRangeException)
            {
                wasException = true;
            }

            Assert.IsTrue (wasException);
        }

        [TestMethod ()]
        public void LongTest_Get ()
        {
            Polar3 p = new Polar3 (2, double.Pi / 3.0, double.Pi / 2.0);

            Assert.AreEqual (double.Pi /2.0, p.Long);
        }

        [TestMethod ()]
        public void LongTest_Set ()
        {
            Polar3 p = new Polar3 (2, double.Pi / 3.0, double.Pi / 2.0);

            p.Long = -2.0 * double.Pi / 3.0;

            Assert.AreEqual (-2.0 * double.Pi / 3.0, p.Long);
        }

        [TestMethod ()]
        public void Polar3Test_Parameters ()
        {
            Polar3 p = new Polar3 (2, double.Pi / 3.0, double.Pi / 2.0);

            Assert.AreEqual (2, p.R);
            Assert.AreEqual (double.Pi / 3.0, p.Lat);
            Assert.AreEqual (double.Pi / 2.0, p.Long);
        }

        [TestMethod ()]
        public void Polar3Test_Polar3 ()
        {
            Polar3 p1 = new Polar3 (2, double.Pi / 3.0, double.Pi / 2.0);
            Polar3 p2 = new Polar3 (p1);

            Assert.AreEqual (2, p2.R);
            Assert.AreEqual (double.Pi / 3.0, p2.Lat);
            Assert.AreEqual (double.Pi / 2.0, p2.Long);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Polar3 p1 = new Polar3 (2, double.Pi / 3.0, double.Pi / 2.0);
            Polar3 p2 = (Polar3)p1.Clone ();

            Assert.AreEqual (2, p2.R);
            Assert.AreEqual (double.Pi / 3.0, p2.Lat);
            Assert.AreEqual (double.Pi / 2.0, p2.Long);
        }
    }
}