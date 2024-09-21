using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Polar3Tests
    {
        [TestMethod ()]
        public void ToCartesianTest ()
        {
            Polar3 p = new Polar3 (2.0, double.Pi / 4.0, double.Pi / 4.0);

            double expectedX = 1.0;
            double expectedY = 1.0;
            double expectedZ = double.Sqrt (2.0);

            Vector3 v = p.ToCartesian ();

            double actualX = v.X;
            double actualY = v.Y;
            double actualZ = v.Z;

            Assert.AreEqual (expectedX, actualX, 1.0e-15);
            Assert.AreEqual (expectedY, actualY, 1.0e-15);
            Assert.AreEqual (expectedZ, actualZ);
        }
    }
}