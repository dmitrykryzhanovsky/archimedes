using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Space3Tests
    {
        [TestMethod ()]
        public void RotateCoordinateSystemAroundOXTest_Angle ()
        {
            Vector3 v     = new Vector3 (0.0, 0.866025403784438647, 0.5);
            double  angle = -0.523598775598298873;

            double expectedX = 0.0;
            double expectedY = 0.5;
            double expectedZ = 0.866025403784438647;

            Vector3 actual = Space3.RotateCoordinateSystemAroundOX (angle, v);

            Assert.AreEqual (expectedX, actual.X, 1.0e-15);
            Assert.AreEqual (expectedY, actual.Y, 1.0e-15);
            Assert.AreEqual (expectedZ, actual.Z, 1.0e-15);
        }

        [TestMethod ()]
        public void RotateCoordinateSystemAroundOXTest_SinCos ()
        {
            Vector3 v   = new Vector3 (0.0, 0.866025403784438647, 0.5);
            double  sin = -0.5;
            double  cos =  0.866025403784438647;

            double expectedX = 0.0;
            double expectedY = 0.5;
            double expectedZ = 0.866025403784438647;

            Vector3 actual = Space3.RotateCoordinateSystemAroundOX (sin, cos, v);

            Assert.AreEqual (expectedX, actual.X, 1.0e-15);
            Assert.AreEqual (expectedY, actual.Y, 1.0e-15);
            Assert.AreEqual (expectedZ, actual.Z, 1.0e-15);
        }

        [TestMethod ()]
        public void RotateCoordinateSystemAroundOYTest_Angle ()
        {
            Vector3 v     = new Vector3 (0.866025403784438647, 0.0, 0.5);
            double  angle = -0.523598775598298873;

            double expectedX = 0.5;
            double expectedY = 0.0;
            double expectedZ = 0.866025403784438647;

            Vector3 actual = Space3.RotateCoordinateSystemAroundOY (angle, v);

            Assert.AreEqual (expectedX, actual.X, 1.0e-15);
            Assert.AreEqual (expectedY, actual.Y, 1.0e-15);
            Assert.AreEqual (expectedZ, actual.Z, 1.0e-15);
        }

        [TestMethod ()]
        public void RotateCoordinateSystemAroundOYTest_SinCos ()
        {
            Vector3 v   = new Vector3 (0.866025403784438647, 0.0, 0.5);
            double  sin = -0.5;
            double  cos = 0.866025403784438647;

            double expectedX = 0.5;
            double expectedY = 0.0;
            double expectedZ = 0.866025403784438647;

            Vector3 actual = Space3.RotateCoordinateSystemAroundOY (sin, cos, v);

            Assert.AreEqual (expectedX, actual.X, 1.0e-15);
            Assert.AreEqual (expectedY, actual.Y, 1.0e-15);
            Assert.AreEqual (expectedZ, actual.Z, 1.0e-15);
        }

        [TestMethod ()]
        public void RotateCoordinateSystemAroundOZTest_Angle ()
        {
            Vector3 v     = new Vector3 (0.866025403784438647, 0.5, 0.0);
            double  angle = -0.523598775598298873;

            double expectedX = 0.5;
            double expectedY = 0.866025403784438647;
            double expectedZ = 0.0;

            Vector3 actual = Space3.RotateCoordinateSystemAroundOZ (angle, v);

            Assert.AreEqual (expectedX, actual.X, 1.0e-15);
            Assert.AreEqual (expectedY, actual.Y, 1.0e-15);
            Assert.AreEqual (expectedZ, actual.Z, 1.0e-15);
        }

        [TestMethod ()]
        public void RotateCoordinateSystemAroundOZTest_SinCos ()
        {
            Vector3 v   = new Vector3 (0.866025403784438647, 0.5, 0.0);
            double  sin = -0.5;
            double  cos = 0.866025403784438647;

            double expectedX = 0.5;
            double expectedY = 0.866025403784438647;
            double expectedZ = 0.0;

            Vector3 actual = Space3.RotateCoordinateSystemAroundOZ(sin, cos, v);

            Assert.AreEqual (expectedX, actual.X, 1.0e-15);
            Assert.AreEqual (expectedY, actual.Y, 1.0e-15);
            Assert.AreEqual (expectedZ, actual.Z, 1.0e-15);
        }
    }
}