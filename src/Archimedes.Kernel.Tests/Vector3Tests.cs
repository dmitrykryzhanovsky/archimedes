using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Vector3Tests
    {
        [TestMethod ()]
        public void RotateAroundOXTest_ByAngle ()
        {
            Vector3 v   = new Vector3 (0, 0.86602540378443865, 0.5);
            double  phi = double.Pi / 12.0;

            Vector3 expected = new Vector3 (0, 0.70710678118654752, 0.70710678118654752);

            Vector3 actual = Vector3.RotateAroundOX (v, phi);

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y, 1.0e-15);
            Assert.AreEqual (expected.Z, actual.Z, 1.0e-15);
        }

        [TestMethod ()]
        public void RotateAroundOXTest_BySinCos ()
        {
            Vector3 v   =  new Vector3 (0.86602540378443865, 0.5, 0);
            double  sin = -1.0;
            double  cos =  0.0;

            Vector3 expected = new Vector3 (0.86602540378443865, 0, -0.5);

            Vector3 actual = Vector3.RotateAroundOX (v, sin, cos);

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y);
            Assert.AreEqual (expected.Z, actual.Z);
        }
    }
}