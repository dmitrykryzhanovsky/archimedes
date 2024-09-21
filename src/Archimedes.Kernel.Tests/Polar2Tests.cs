using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Polar2Tests
    {
        [TestMethod ()]
        public void ToCartesianTest ()
        {
            Polar2 p = new Polar2 (4.2, 5.0 * double.Pi / 6.0);

            double expectedX = -2.1 * double.Sqrt (3.0);
            double expectedY = 2.1;

            Vector2 v = p.ToCartesian ();

            double actualX = v.X;
            double actualY = v.Y;

            Assert.AreEqual (expectedX, actualX, 1.0e-14);
            Assert.AreEqual (expectedY, actualY, 1.0e-15);
        }
    }
}