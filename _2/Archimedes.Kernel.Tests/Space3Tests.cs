using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Space3Tests
    {
        [TestMethod ()]
        public void RotateCoordinateSystemAroundOXTest_ByAngle ()
        {
            Vector3 v   = new Vector3 (0, 0.86602540378443865, 0.5);
            double  phi = double.Pi / 12.0;

            Vector3 expected = new Vector3 (0, 0.96592582628906829, 0.25881904510252076);

            Vector3 actual = Space3.RotateCoordinateSystemAroundOX (v, phi);

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y, 1.0e-15);
            Assert.AreEqual (expected.Z, actual.Z, 1.0e-15);
        }

        [TestMethod ()]
        public void RotateCoordinateSystemAroundOXTest_BySinCos ()
        {
            Vector3 v   =  new Vector3 (0.86602540378443865, 0.5, 0);
            double  sin = -1.0;
            double  cos =  0.0;

            Vector3 expected = new Vector3 (0.86602540378443865, 0, 0.5);

            Vector3 actual = Space3.RotateCoordinateSystemAroundOX (v, sin, cos);

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y);
            Assert.AreEqual (expected.Z, actual.Z);
        }
    }
}