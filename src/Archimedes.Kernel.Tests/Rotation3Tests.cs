using Archimedes;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Rotation3Tests
    {
        [TestMethod ()]
        public void GetRotationMatrixForSpaceByEulerAnglesTest_AnglesDirectly ()
        {
            double alpha = double.Pi / 6.0;
            double beta  = double.Pi / 3.0;
            double gamma = 2.0 * double.Pi / 3.0;

            double root3 = double.Sqrt (3.0);

            Matrix3 expected = new Matrix3 (-0.375 * root3, -0.625,          0.25 * root3,
                                             0.125,         -0.375 * root3, -0.75,
                                             0.75,          -0.25  * root3,  0.5);

            Matrix3 actual = Rotation3.GetRotationMatrixForSpaceByEulerAngles (alpha, beta, gamma);

            Assert.AreEqual (expected [0, 0], actual [0, 0]);
            Assert.AreEqual (expected [0, 1], actual [0, 1], 1.0e-15);
            Assert.AreEqual (expected [0, 2], actual [0, 2], 1.0e-15);

            Assert.AreEqual (expected [1, 0], actual [1, 0], 1.0e-15);
            Assert.AreEqual (expected [1, 1], actual [1, 1]);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);

            Assert.AreEqual (expected [2, 0], actual [2, 0]);
            Assert.AreEqual (expected [2, 1], actual [2, 1], 1.0e-15);
            Assert.AreEqual (expected [2, 2], actual [2, 2], 1.0e-15);
        }

        [TestMethod ()]
        public void GetRotationMatrixForSpaceByEulerAnglesTest_SinCos ()
        {
            double root3 = double.Sqrt (3.0);

            double sinA =  0.5;
            double cosA =  0.5 * root3;
            double sinB =  0.5 * root3;
            double cosB =  0.5;
            double sinG =  0.5 * root3;
            double cosG = -0.5;

            Matrix3 expected = new Matrix3 (-0.375 * root3, -0.625,          0.25 * root3,
                                             0.125,         -0.375 * root3, -0.75,
                                             0.75,          -0.25  * root3,  0.5);

            Matrix3 actual = Rotation3.GetRotationMatrixForSpaceByEulerAngles (sinA, cosA, sinB, cosB, sinG, cosG);

            Assert.AreEqual (expected [0, 0], actual [0, 0]);
            Assert.AreEqual (expected [0, 1], actual [0, 1], 1.0e-15);
            Assert.AreEqual (expected [0, 2], actual [0, 2]);

            Assert.AreEqual (expected [1, 0], actual [1, 0], 1.0e-15);
            Assert.AreEqual (expected [1, 1], actual [1, 1]);
            Assert.AreEqual (expected [1, 2], actual [1, 2], 1.0e-15);

            Assert.AreEqual (expected [2, 0], actual [2, 0], 1.0e-15);
            Assert.AreEqual (expected [2, 1], actual [2, 1]);
            Assert.AreEqual (expected [2, 2], actual [2, 2]);
        }

        [TestMethod ()]
        public void RotateSpaceByEulerAnglesTest_AnglesDirectly ()
        {
            double root3 = double.Sqrt (3.0);

            Vector3 v = new Vector3 (1, 2, 3);

            double alpha = double.Pi / 6.0;
            double beta  = double.Pi / 3.0;
            double gamma = 2.0 * double.Pi / 3.0;

            Vector3 expected = new Vector3 (-1.25  + 0.375 * root3,
                                            -2.125 - 0.75  * root3,
                                             2.25  - 0.5   * root3);

            Vector3 actual = Rotation3.RotateSpaceByEulerAngles (v, alpha, beta, gamma);

            Assert.AreEqual (expected [0], actual [0], 1.0e-14);
            Assert.AreEqual (expected [1], actual [1], 1.0e-14);
            Assert.AreEqual (expected [2], actual [2], 1.0e-14);
        }

        [TestMethod ()]
        public void RotateSpaceByEulerAnglesTest_SinCos ()
        {
            double root3 = double.Sqrt (3.0);

            Vector3 v = new Vector3 (1, 2, 3);

            double sinA =  0.5;
            double cosA =  0.5 * root3;
            double sinB =  0.5 * root3;
            double cosB =  0.5;
            double sinG =  0.5 * root3;
            double cosG = -0.5;

            Vector3 expected = new Vector3 (-1.25  + 0.375 * root3,
                                            -2.125 - 0.75  * root3,
                                             2.25  - 0.5   * root3);

            Vector3 actual = Rotation3.RotateSpaceByEulerAngles (v, sinA, cosA, sinB, cosB, sinG, cosG);

            Assert.AreEqual (expected [0], actual [0], 1.0e-15);
            Assert.AreEqual (expected [1], actual [1]);
            Assert.AreEqual (expected [2], actual [2], 1.0e-15);
        }

        [TestMethod ()]
        public void RotateSpaceByEulerAngles_SinCos ()
        {
            double root3 = double.Sqrt (3.0);

            Polar3 p = new Polar3 (r: 3.74165738677394139, latitude: 0.93027401411547205, longitude: 1.10714871779409050);

            double sinA =  0.5;
            double cosA =  0.5 * root3;
            double sinB =  0.5 * root3;
            double cosB =  0.5;
            double sinG =  0.5 * root3;
            double cosG = -0.5;

            Polar3 expected = new Polar3 (r: 3.74165738677394139, latitude: -1.74440306847075089, longitude: 4.53878223870883559);

            Polar3 actual = Rotation3.RotateSpaceByEulerAngles (p, sinA, cosA, sinB, cosB, sinG, cosG);

            Assert.AreEqual (expected.R, actual.R);
            Assert.AreEqual (expected.Latitude, actual.Latitude);
            Assert.AreEqual (expected.Longitude, actual.Longitude);
        }
    }
}