using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Rotation2Tests
    {
        #region GetRotationMatrix

        #region Active

        [TestMethod ()]
        public void GetMatrixTest_Active_Angle ()
        {
            double angle = double.Pi / 6.0;

            Matrix2 expected = new Matrix2 (0.5 * double.Sqrt (3.0), -0.5, 
                                            0.5, 0.5 * double.Sqrt (3.0));

            Matrix2 actual = Rotation2.GetRotationMatrix.Active.GetMatrix (angle);

            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
        }

        [TestMethod ()]
        public void GetMatrixTest_Active_SinCos ()
        {
            double sin = 0.5;
            double cos = 0.5 * double.Sqrt (3.0);

            Matrix2 expected = new Matrix2 (0.5 * double.Sqrt (3.0), -0.5,
                                            0.5, 0.5 * double.Sqrt (3.0));

            Matrix2 actual = Rotation2.GetRotationMatrix.Active.GetMatrix (sin, cos);

            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
        }

        #endregion

        #region Passive

        [TestMethod ()]
        public void GetMatrixTest_Passive_Angle ()
        {
            double angle = double.Pi / 6.0;

            Matrix2 expected = new Matrix2 ( 0.5 * double.Sqrt (3.0), 0.5,
                                            -0.5, 0.5 * double.Sqrt (3.0));

            Matrix2 actual = Rotation2.GetRotationMatrix.Passive.GetMatrix (angle);

            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
        }

        [TestMethod ()]
        public void GetMatrixTest_Passive_SinCos ()
        {
            double sin = 0.5;
            double cos = 0.5 * double.Sqrt (3.0);

            Matrix2 expected = new Matrix2 ( 0.5 * double.Sqrt (3.0), 0.5,
                                            -0.5, 0.5 * double.Sqrt (3.0));

            Matrix2 actual = Rotation2.GetRotationMatrix.Passive.GetMatrix (sin, cos);

            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
        }

        #endregion

        #endregion

        #region Apply

        [TestMethod ()]
        public void RotateTest_CCW ()
        {
            Vector2 v = new Vector2 (double.Sqrt (3.0), 1.0);
            Matrix2 rotationMatrix = new Matrix2 (0.5 * double.Sqrt (3.0), -0.5, 
                                                  0.5, 0.5 * double.Sqrt (3.0));

            Vector2 expected = new Vector2 (1.0, double.Sqrt (3.0));

            Vector2 actual = Rotation2.Apply.Rotate (rotationMatrix, v);

            Assert.AreEqual (expected [0], actual [0], 1.0e-15);
            Assert.AreEqual (expected [1], actual [1], 1.0e-15);
        }

        [TestMethod ()]
        public void RotateTest_CW ()
        {
            Vector2 v = new Vector2 (double.Sqrt (3.0), 1.0);
            Matrix2 rotationMatrix = new Matrix2 ( 0.5 * double.Sqrt (3.0), 0.5,
                                                  -0.5, 0.5 * double.Sqrt (3.0));

            Vector2 expected = new Vector2 (2.0, 0.0);

            Vector2 actual = Rotation2.Apply.Rotate (rotationMatrix, v);

            Assert.AreEqual (expected [0], actual [0], 1.0e-15);
            Assert.AreEqual (expected [1], actual [1], 1.0e-15);
        }

        #region Active

        [TestMethod ()]
        public void RotateVectorTest_Active_Cartesian_Angle ()
        {
            Vector2 v     = new Vector2 (double.Sqrt (3.0), 1.0);
            double  angle = double.Pi / 6.0;

            Vector2 expected = new Vector2 (1.0, double.Sqrt (3.0));

            Vector2 actual = Rotation2.Apply.Active.RotateVector (v, angle);

            Assert.AreEqual (expected [0], actual [0], 1.0e-15);
            Assert.AreEqual (expected [1], actual [1], 1.0e-15);
        }

        [TestMethod ()]
        public void RotateVectorTest_Active_Cartesian_SinCos ()
        {
            Vector2 v   =  new Vector2 (double.Sqrt (3.0), 1.0);
            double  sin = -0.5;
            double  cos =  double.Sqrt (3.0) / 2.0;

            Vector2 expected = new Vector2 (2.0, 0.0);

            Vector2 actual = Rotation2.Apply.Active.RotateVector (v, sin, cos);

            Assert.AreEqual (expected [0], actual [0], 1.0e-15);
            Assert.AreEqual (expected [1], actual [1], 1.0e-15);
        }

        [TestMethod ()]
        public void RotateVectorTest_Active_Polar_Angle ()
        {
            Polar2 p     = new Polar2 (2.0, double.Pi / 6.0);
            double angle = double.Pi / 6.0;

            Polar2 expected = new Polar2 (2.0, double.Pi / 3.0);

            Polar2 actual = Rotation2.Apply.Active.RotateVector (p, angle);

            Assert.AreEqual (expected.R, actual.R, 1.0e-15);
            Assert.AreEqual (expected.Heading, actual.Heading, 1.0e-15);
        }

        [TestMethod ()]
        public void RotateVectorTest_Active_Polar_SinCos ()
        {
            Polar2 p   =  new Polar2 (2.0, double.Pi / 6.0);
            double sin = -0.5;
            double cos =  double.Sqrt (3.0) / 2.0;

            Polar2 expected = new Polar2 (2.0, 0.0);

            Polar2 actual = Rotation2.Apply.Active.RotateVector (p, sin, cos);

            Assert.AreEqual (expected.R, actual.R, 1.0e-15);
            Assert.AreEqual (expected.Heading, actual.Heading, 1.0e-15);
        }

        #endregion

        #region Passive

        [TestMethod ()]
        public void RotateSpaceTest_Passive_Cartesian_Angle ()
        {
            Vector2 v     = new Vector2 (double.Sqrt (3.0), 1.0);
            double  angle = double.Pi / 6.0;

            Vector2 expected = new Vector2 (2.0, 0.0);

            Vector2 actual = Rotation2.Apply.Passive.RotateSpace (v, angle);

            Assert.AreEqual (expected [0], actual [0], 1.0e-15);
            Assert.AreEqual (expected [1], actual [1], 1.0e-15);
        }

        [TestMethod ()]
        public void RotateSpaceTest_Passive_Cartesian_SinCos ()
        {
            Vector2 v   =  new Vector2 (double.Sqrt (3.0), 1.0);
            double  sin = -0.5;
            double  cos =  double.Sqrt (3.0) / 2.0;

            Vector2 expected = new Vector2 (1.0, double.Sqrt (3.0));

            Vector2 actual = Rotation2.Apply.Passive.RotateSpace (v, sin, cos);

            Assert.AreEqual (expected [0], actual [0], 1.0e-15);
            Assert.AreEqual (expected [1], actual [1], 1.0e-15);
        }

        [TestMethod ()]
        public void RotateSpaceTest_Passive_Polar_Angle ()
        {
            Polar2 p     = new Polar2 (2.0, double.Pi / 6.0);
            double angle = double.Pi / 6.0;

            Polar2 expected = new Polar2 (2.0, 0.0);

            Polar2 actual = Rotation2.Apply.Passive.RotateSpace (p, angle);

            Assert.AreEqual (expected.R, actual.R, 1.0e-15);
            Assert.AreEqual (expected.Heading, actual.Heading, 1.0e-15);
        }

        [TestMethod ()]
        public void RotateSpaceTest_Passive_Polar_SinCos ()
        {
            Polar2 p   =  new Polar2 (2.0, double.Pi / 6.0);
            double sin = -0.5;
            double cos = double.Sqrt (3.0) / 2.0;

            Polar2 expected = new Polar2 (2.0, double.Pi / 3.0);

            Polar2 actual = Rotation2.Apply.Passive.RotateSpace (p, sin, cos);

            Assert.AreEqual (expected.R, actual.R, 1.0e-15);
            Assert.AreEqual (expected.Heading, actual.Heading, 1.0e-15);
        }

        #endregion

        #endregion
    }
}