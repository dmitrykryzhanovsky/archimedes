using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Space2Tests
    {
        [TestMethod ()]
        public void GetCartesianCoordinatesTest ()
        {
            double r       =  5;
            double heading = -2.2142974355881810;

            double expectedX = -3;
            double expectedY = -4;

            (double x, double y) actual = Space2.GetCartesianCoordinates (r, heading);

            Assert.AreEqual (expectedX, actual.x, 1.0e-14);
            Assert.AreEqual (expectedY, actual.y, 1.0e-14);
        }

        [TestMethod ()]
        public void GetPolarCoordinatesTest ()
        {
            double x = -3;
            double y = -4;

            double expectedR       =  5;
            double expectedHeading = -2.2142974355881810;

            (double r, double heading) actual = Space2.GetPolarCoordinates (x, y);

            Assert.AreEqual (expectedR, actual.r);
            Assert.AreEqual (expectedHeading, actual.heading);
        }
    }
}