using Archimedes;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class SpaceTests
    {
        [TestMethod ()]
        public void GetRotationMatrixAroundOXTest_Angle ()
        {
            double phi = Math.PI / 3.0;

            Matrix3 expected = new Matrix3 (1.0, 0.0, 0.0,
                                            0.0, 0.5, Math.Sqrt (3.0) / 2.0,
                                            0.0, -Math.Sqrt (3.0) / 2.0, 0.5);

            Matrix3 actual = Space.GetRotationMatrixAroundOX (phi);

            Assert.AreEqual (expected [0, 0], actual [0, 0]);
            Assert.AreEqual (expected [0, 1], actual [0, 1]);
            Assert.AreEqual (expected [0, 2], actual [0, 2]);

            Assert.AreEqual (expected [1, 0], actual [1, 0]);
            Assert.AreEqual (expected [1, 1], actual [1, 1], 1.0e-15);
            Assert.AreEqual (expected [1, 2], actual [1, 2], 1.0e-15);

            Assert.AreEqual (expected [2, 0], actual [2, 0]);
            Assert.AreEqual (expected [2, 1], actual [2, 1], 1.0e-15);
            Assert.AreEqual (expected [2, 2], actual [2, 2], 1.0e-15);
        }

        [TestMethod ()]
        public void GetRotationMatrixAroundOXTest_SineCosine ()
        {
            double sin = 0.86602540378443865;
            double cos = 0.5;

            Matrix3 expected = new Matrix3 (1.0, 0.0, 0.0,
                                            0.0, 0.5, Math.Sqrt (3.0) / 2.0,
                                            0.0, -Math.Sqrt (3.0) / 2.0, 0.5);

            Matrix3 actual = Space.GetRotationMatrixAroundOX (sin, cos);

            Assert.AreEqual (expected [0, 0], actual [0, 0]);
            Assert.AreEqual (expected [0, 1], actual [0, 1]);
            Assert.AreEqual (expected [0, 2], actual [0, 2]);

            Assert.AreEqual (expected [1, 0], actual [1, 0]);
            Assert.AreEqual (expected [1, 1], actual [1, 1], 1.0e-15);
            Assert.AreEqual (expected [1, 2], actual [1, 2], 1.0e-15);

            Assert.AreEqual (expected [2, 0], actual [2, 0]);
            Assert.AreEqual (expected [2, 1], actual [2, 1], 1.0e-15);
            Assert.AreEqual (expected [2, 2], actual [2, 2], 1.0e-15);
        }

        [TestMethod ()]
        public void GetRotationMatrixAroundOXBothTest_Angle ()
        {
            double phi = Math.PI / 3.0;

            Matrix3 expectedDirect = new Matrix3 (1.0, 0.0, 0.0,
                                                  0.0, 0.5, Math.Sqrt (3.0) / 2.0,
                                                  0.0, -Math.Sqrt (3.0) / 2.0, 0.5);

            Matrix3 expectedBackward = new Matrix3 (1.0, 0.0, 0.0,
                                                    0.0, 0.5, -Math.Sqrt (3.0) / 2.0,
                                                    0.0, Math.Sqrt (3.0) / 2.0, 0.5);

            (Matrix3 actualDirect, Matrix3 actualBackward) = Space.GetRotationMatrixAroundOXBoth (phi);

            Assert.AreEqual (expectedDirect [0, 0], actualDirect [0, 0]);
            Assert.AreEqual (expectedDirect [0, 1], actualDirect [0, 1]);
            Assert.AreEqual (expectedDirect [0, 2], actualDirect [0, 2]);

            Assert.AreEqual (expectedDirect [1, 0], actualDirect [1, 0]);
            Assert.AreEqual (expectedDirect [1, 1], actualDirect [1, 1], 1.0e-15);
            Assert.AreEqual (expectedDirect [1, 2], actualDirect [1, 2], 1.0e-15);

            Assert.AreEqual (expectedDirect [2, 0], actualDirect [2, 0]);
            Assert.AreEqual (expectedDirect [2, 1], actualDirect [2, 1], 1.0e-15);
            Assert.AreEqual (expectedDirect [2, 2], actualDirect [2, 2], 1.0e-15);

            Assert.AreEqual (expectedBackward [0, 0], actualBackward [0, 0]);
            Assert.AreEqual (expectedBackward [0, 1], actualBackward [0, 1]);
            Assert.AreEqual (expectedBackward [0, 2], actualBackward [0, 2]);

            Assert.AreEqual (expectedBackward [1, 0], actualBackward [1, 0]);
            Assert.AreEqual (expectedBackward [1, 1], actualBackward [1, 1], 1.0e-15);
            Assert.AreEqual (expectedBackward [1, 2], actualBackward [1, 2], 1.0e-15);

            Assert.AreEqual (expectedBackward [2, 0], actualBackward [2, 0]);
            Assert.AreEqual (expectedBackward [2, 1], actualBackward [2, 1], 1.0e-15);
            Assert.AreEqual (expectedBackward [2, 2], actualBackward [2, 2], 1.0e-15);
        }

        [TestMethod ()]
        public void GetRotationMatrixAroundOXBothTest_SineCosine ()
        {
            double sin = 0.86602540378443865;
            double cos = 0.5;

            Matrix3 expectedDirect = new Matrix3 (1.0, 0.0, 0.0,
                                                  0.0, 0.5, Math.Sqrt (3.0) / 2.0,
                                                  0.0, -Math.Sqrt (3.0) / 2.0, 0.5);

            Matrix3 expectedBackward = new Matrix3 (1.0, 0.0, 0.0,
                                                    0.0, 0.5, -Math.Sqrt (3.0) / 2.0,
                                                    0.0, Math.Sqrt (3.0) / 2.0, 0.5);

            (Matrix3 actualDirect, Matrix3 actualBackward) = Space.GetRotationMatrixAroundOXBoth (sin, cos);

            Assert.AreEqual (expectedDirect [0, 0], actualDirect [0, 0]);
            Assert.AreEqual (expectedDirect [0, 1], actualDirect [0, 1]);
            Assert.AreEqual (expectedDirect [0, 2], actualDirect [0, 2]);

            Assert.AreEqual (expectedDirect [1, 0], actualDirect [1, 0]);
            Assert.AreEqual (expectedDirect [1, 1], actualDirect [1, 1], 1.0e-15);
            Assert.AreEqual (expectedDirect [1, 2], actualDirect [1, 2], 1.0e-15);

            Assert.AreEqual (expectedDirect [2, 0], actualDirect [2, 0]);
            Assert.AreEqual (expectedDirect [2, 1], actualDirect [2, 1], 1.0e-15);
            Assert.AreEqual (expectedDirect [2, 2], actualDirect [2, 2], 1.0e-15);

            Assert.AreEqual (expectedBackward [0, 0], actualBackward [0, 0]);
            Assert.AreEqual (expectedBackward [0, 1], actualBackward [0, 1]);
            Assert.AreEqual (expectedBackward [0, 2], actualBackward [0, 2]);

            Assert.AreEqual (expectedBackward [1, 0], actualBackward [1, 0]);
            Assert.AreEqual (expectedBackward [1, 1], actualBackward [1, 1], 1.0e-15);
            Assert.AreEqual (expectedBackward [1, 2], actualBackward [1, 2], 1.0e-15);

            Assert.AreEqual (expectedBackward [2, 0], actualBackward [2, 0]);
            Assert.AreEqual (expectedBackward [2, 1], actualBackward [2, 1], 1.0e-15);
            Assert.AreEqual (expectedBackward [2, 2], actualBackward [2, 2], 1.0e-15);
        }

        [TestMethod ()]
        public void RotateVectorAroundOXTest_Angle ()
        {
            Vector3 v = new Vector3 (0, 1, 1.7320508075688773);
            double phi = -0.52359877559829887;

            Vector3 expected = new Vector3 (0, 1.7320508075688773, 1);

            Vector3 actual = Space.RotateVectorAroundOX (v, phi);

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y);
            Assert.AreEqual (expected.Z, actual.Z, 1.0e-15);
        }

        [TestMethod ()]
        public void RotateVectorAroundOXTest_SineCosine ()
        {
            Vector3 v = new Vector3 (0, 1, 1.7320508075688773);
            double sin = 0.5;
            double cos = 0.86602540378443865;

            Vector3 expected = new Vector3 (0, 0, 2);

            Vector3 actual = Space.RotateVectorAroundOX (v, sin, cos);

            Assert.AreEqual (expected.X, actual.X);
            Assert.AreEqual (expected.Y, actual.Y);
            Assert.AreEqual (expected.Z, actual.Z, 1.0e-15);
        }

        [TestMethod ()]
        public void RotateReferenceAroundOXTest_Vector3_Angle ()
        {
            Vector3 v = new Vector3 (0, 1, 1.7320508075688773);
            double phi = -0.52359877559829887;

            Vector3 expected = new Vector3 (0, 0, 2);

            Vector3 actual = Space.RotateReferenceAroundOX (v, phi);

            Assert.AreEqual (expected.X, actual.X, 1.0e-16);
            Assert.AreEqual (expected.Y, actual.Y, 1.0e-15);
            Assert.AreEqual (expected.Z, actual.Z, 1.0e-15);
        }

        [TestMethod ()]
        public void RotateReferenceAroundOXTest_Vector3_SineCosine ()
        {
            Vector3 v = new Vector3 (0, 1, 1.7320508075688773);
            double sin = 0.5;
            double cos = 0.86602540378443865;

            Vector3 expected = new Vector3 (0, 1.7320508075688773, 1);

            Vector3 actual = Space.RotateReferenceAroundOX (v, sin, cos);

            Assert.AreEqual (expected.X, actual.X, 1.0e-16);
            Assert.AreEqual (expected.Y, actual.Y, 1.0e-15);
            Assert.AreEqual (expected.Z, actual.Z, 1.0e-15);
        }

        [TestMethod ()]
        public void RotateReferenceAroundOXTest_Polar3_Angle ()
        {
            Polar3 p = new Polar3 (3, 1.5707963267948966, 1.0471975511965977);
            double phi = 0.52359877559829887;

            Polar3 expected = new Polar3 (3, 1.5707963267948966, 0.52359877559829887);

            Polar3 actual = Space.RotateReferenceAroundOX (p, phi);

            Assert.AreEqual (expected.R, actual.R);
            Assert.AreEqual (expected.Longitude, actual.Longitude);
            Assert.AreEqual (expected.Latitude, actual.Latitude);
        }

        [TestMethod ()]
        public void RotateReferenceAroundOXTest_Polar3_SineCosine ()
        {
            Polar3 p = new Polar3 (3, 1.5707963267948966, 1.0471975511965977);
            double sin = -0.25881904510252076;
            double cos = 0.96592582628906829;

            Polar3 expected = new Polar3 (3, 1.5707963267948966, 1.3089969389957472);

            Polar3 actual = Space.RotateReferenceAroundOX (p, sin, cos);

            Assert.AreEqual (expected.R, actual.R);
            Assert.AreEqual (expected.Longitude, actual.Longitude, 1.0e-15);
            Assert.AreEqual (expected.Latitude, actual.Latitude, 1.0e-15);
        }

        [TestMethod ()]
        public void RotateReferenceAroundOXTest_Angles_Angle ()
        {
            double b = 1.0471975511965977;
            double l = 1.5707963267948966;
            double phi = 0.52359877559829887;

            (double b, double l) expected = (0.52359877559829887, 1.5707963267948966);

            (double b, double l) actual = Space.RotateReferenceAroundOX (b, l, phi);

            Assert.AreEqual (expected.b, actual.b);
            Assert.AreEqual (expected.l, actual.l);
        }

        [TestMethod ()]
        public void RotateReferenceAroundOXTest_Angles_SineCosine ()
        {
            double b = 1.0471975511965977;
            double l = 1.5707963267948966;
            double sin = -0.25881904510252076;
            double cos = 0.96592582628906829;

            (double b, double l) expected = (1.3089969389957472, 1.5707963267948966);

            (double b, double l) actual = Space.RotateReferenceAroundOX (b, l, sin, cos);

            Assert.AreEqual (expected.b, actual.b, 1.0e-15);
            Assert.AreEqual (expected.l, actual.l, 1.0e-15);
        }
    }
}