using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Vector3Tests
    {
        [TestMethod ()]
        public void opMultiplyTest ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (5, 8, 13);

            double expected = 99;

            double actual = v1 * v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void CrossProductTest ()
        {
            Vector3 v1 = new Vector3 (3, 0, 0);
            Vector3 v2 = new Vector3 (2, 2.0 * double.Sqrt (3.0), 0);

            Vector3 expected = new Vector3 (0, 0, 6.0 * double.Sqrt (3.0));

            Vector3 actual = Vector3.CrossProduct (v1, v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Vector3 v = new Vector3 (6, 8, 10);

            double expected = 200;

            double actual = v.GetNorm2 ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ToPolarTest ()
        {
            Vector3 v = new Vector3 (1.0, 1.0, 1.0);

            double expectedR         = double.Sqrt (3.0);
            double expectedLatitude  = double.Asin (double.Sqrt (1.0 / 3.0));
            double expectedLongitude = double.Pi / 4.0;
            
            Polar3 p = v.ToPolar ();

            double actualR         = p.R;
            double actualLatitude  = p.Latitude;
            double actualLongitude = p.Longitude;

            Assert.AreEqual (expectedR, actualR);
            Assert.AreEqual (expectedLatitude, actualLatitude, 1.0e-15);
            Assert.AreEqual (expectedLongitude, actualLongitude);
        }
    }
}