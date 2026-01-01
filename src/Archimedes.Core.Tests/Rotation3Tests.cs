using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Rotation3Tests
    {
        #region GetRotationMatrix

        #region Active

        #region AroundOX

        [TestMethod ()]
        public void GetRotationMatrix_Active_AroundOX_GetMatrixTest_AnglesDirectly ()
        {
            double angle = 1.2217304763960307;

            Matrix3 expected = new Matrix3 (1, 0, 0,
                                            0, 0.3420201433256687, -0.9396926207859084,
                                            0, 0.9396926207859084,  0.3420201433256687);

            Matrix3 actual = Rotation3.GetRotationMatrix.Active.AroundOX.GetMatrix (angle);

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
        public void GetRotationMatrix_Active_AroundOX_GetMatrixTest_SinCos ()
        {
            double sin = 0.9396926207859084;
            double cos = 0.3420201433256687;

            Matrix3 expected = new Matrix3 (1, 0, 0,
                                            0, 0.3420201433256687, -0.9396926207859084,
                                            0, 0.9396926207859084,  0.3420201433256687);

            Matrix3 actual = Rotation3.GetRotationMatrix.Active.AroundOX.GetMatrix (sin, cos);

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

        #endregion

        #region AroundOY

        [TestMethod ()]
        public void GetRotationMatrix_Active_AroundOY_GetMatrixTest_AnglesDirectly ()
        {
            double angle = 1.2217304763960307;

            Matrix3 expected = new Matrix3 ( 0.3420201433256687, 0, 0.9396926207859084,
                                             0, 1, 0, 
                                            -0.9396926207859084, 0, 0.3420201433256687);

            Matrix3 actual = Rotation3.GetRotationMatrix.Active.AroundOY.GetMatrix (angle);

            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 1], actual [0, 1]);
            Assert.AreEqual (expected [0, 2], actual [0, 2], 1.0e-15);

            Assert.AreEqual (expected [1, 0], actual [1, 0]);
            Assert.AreEqual (expected [1, 1], actual [1, 1]);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);

            Assert.AreEqual (expected [2, 0], actual [2, 0], 1.0e-15);
            Assert.AreEqual (expected [2, 1], actual [2, 1]);
            Assert.AreEqual (expected [2, 2], actual [2, 2], 1.0e-15);
        }

        [TestMethod ()]
        public void GetRotationMatrix_Active_AroundOY_GetMatrixTest_SinCos ()
        {
            double sin = 0.9396926207859084;
            double cos = 0.3420201433256687;

            Matrix3 expected = new Matrix3 ( 0.3420201433256687, 0, 0.9396926207859084,
                                             0, 1, 0,
                                            -0.9396926207859084, 0, 0.3420201433256687);

            Matrix3 actual = Rotation3.GetRotationMatrix.Active.AroundOY.GetMatrix (sin, cos);

            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 1], actual [0, 1]);
            Assert.AreEqual (expected [0, 2], actual [0, 2], 1.0e-15);

            Assert.AreEqual (expected [1, 0], actual [1, 0]);
            Assert.AreEqual (expected [1, 1], actual [1, 1]);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);

            Assert.AreEqual (expected [2, 0], actual [2, 0], 1.0e-15);
            Assert.AreEqual (expected [2, 1], actual [2, 1]);
            Assert.AreEqual (expected [2, 2], actual [2, 2], 1.0e-15);
        }

        #endregion

        #region AroundOZ

        [TestMethod ()]
        public void GetRotationMatrix_Active_AroundOZ_GetMatrixTest_AnglesDirectly ()
        {
            double angle = 1.2217304763960307;

            Matrix3 expected = new Matrix3 (0.3420201433256687, -0.9396926207859084, 0,
                                            0.9396926207859084,  0.3420201433256687, 0,
                                            0, 0, 1);

            Matrix3 actual = Rotation3.GetRotationMatrix.Active.AroundOZ.GetMatrix (angle);

            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 1], actual [0, 1], 1.0e-15);
            Assert.AreEqual (expected [0, 2], actual [0, 2]);

            Assert.AreEqual (expected [1, 0], actual [1, 0], 1.0e-15);
            Assert.AreEqual (expected [1, 1], actual [1, 1], 1.0e-15);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);

            Assert.AreEqual (expected [2, 0], actual [2, 0]);
            Assert.AreEqual (expected [2, 1], actual [2, 1]);
            Assert.AreEqual (expected [2, 2], actual [2, 2]);
        }

        [TestMethod ()]
        public void GetRotationMatrix_Active_AroundOZ_GetMatrixTest_SinCos ()
        {
            double sin = 0.9396926207859084;
            double cos = 0.3420201433256687;

            Matrix3 expected = new Matrix3 (0.3420201433256687, -0.9396926207859084, 0,
                                            0.9396926207859084,  0.3420201433256687, 0,
                                            0, 0, 1);

            Matrix3 actual = Rotation3.GetRotationMatrix.Active.AroundOZ.GetMatrix (sin, cos);

            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 1], actual [0, 1], 1.0e-15);
            Assert.AreEqual (expected [0, 2], actual [0, 2]);

            Assert.AreEqual (expected [1, 0], actual [1, 0], 1.0e-15);
            Assert.AreEqual (expected [1, 1], actual [1, 1], 1.0e-15);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);

            Assert.AreEqual (expected [2, 0], actual [2, 0]);
            Assert.AreEqual (expected [2, 1], actual [2, 1]);
            Assert.AreEqual (expected [2, 2], actual [2, 2]);
        }

        #endregion

        #endregion

        #region Passive

        #region AroundOX

        [TestMethod ()]
        public void GetRotationMatrix_Passive_AroundOX_GetMatrixTest_AnglesDirectly ()
        {
            double angle = 1.2217304763960307;

            Matrix3 expected = new Matrix3 (1,  0, 0,
                                            0,  0.3420201433256687, 0.9396926207859084,
                                            0, -0.9396926207859084, 0.3420201433256687);

            Matrix3 actual = Rotation3.GetRotationMatrix.Passive.AroundOX.GetMatrix (angle);

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
        public void GetRotationMatrix_Passive_AroundOX_GetMatrixTest_SinCos ()
        {
            double sin = 0.9396926207859084;
            double cos = 0.3420201433256687;

            Matrix3 expected = new Matrix3 (1,  0, 0,
                                            0,  0.3420201433256687, 0.9396926207859084,
                                            0, -0.9396926207859084, 0.3420201433256687);

            Matrix3 actual = Rotation3.GetRotationMatrix.Passive.AroundOX.GetMatrix (sin, cos);

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

        #endregion

        #region AroundOY

        [TestMethod ()]
        public void GetRotationMatrix_Passive_AroundOY_GetMatrixTest_AnglesDirectly ()
        {
            double angle = 1.2217304763960307;

            Matrix3 expected = new Matrix3 (0.3420201433256687, 0, -0.9396926207859084,
                                            0, 1, 0,
                                            0.9396926207859084, 0,  0.3420201433256687);

            Matrix3 actual = Rotation3.GetRotationMatrix.Passive.AroundOY.GetMatrix (angle);

            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 1], actual [0, 1]);
            Assert.AreEqual (expected [0, 2], actual [0, 2], 1.0e-15);

            Assert.AreEqual (expected [1, 0], actual [1, 0]);
            Assert.AreEqual (expected [1, 1], actual [1, 1]);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);

            Assert.AreEqual (expected [2, 0], actual [2, 0], 1.0e-15);
            Assert.AreEqual (expected [2, 1], actual [2, 1]);
            Assert.AreEqual (expected [2, 2], actual [2, 2], 1.0e-15);
        }

        [TestMethod ()]
        public void GetRotationMatrix_Passive_AroundOY_GetMatrixTest_SinCos ()
        {
            double sin = 0.9396926207859084;
            double cos = 0.3420201433256687;

            Matrix3 expected = new Matrix3 (0.3420201433256687, 0, -0.9396926207859084,
                                            0, 1, 0,
                                            0.9396926207859084, 0,  0.3420201433256687);

            Matrix3 actual = Rotation3.GetRotationMatrix.Passive.AroundOY.GetMatrix (sin, cos);

            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 1], actual [0, 1]);
            Assert.AreEqual (expected [0, 2], actual [0, 2], 1.0e-15);

            Assert.AreEqual (expected [1, 0], actual [1, 0]);
            Assert.AreEqual (expected [1, 1], actual [1, 1]);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);

            Assert.AreEqual (expected [2, 0], actual [2, 0], 1.0e-15);
            Assert.AreEqual (expected [2, 1], actual [2, 1]);
            Assert.AreEqual (expected [2, 2], actual [2, 2], 1.0e-15);
        }

        #endregion

        #region AroundOZ

        [TestMethod ()]
        public void GetRotationMatrix_Passive_AroundOZ_GetMatrixTest_AnglesDirectly ()
        {
            double angle = 1.2217304763960307;

            Matrix3 expected = new Matrix3 ( 0.3420201433256687, 0.9396926207859084, 0,
                                            -0.9396926207859084, 0.3420201433256687, 0,
                                             0, 0, 1);

            Matrix3 actual = Rotation3.GetRotationMatrix.Passive.AroundOZ.GetMatrix (angle);

            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 1], actual [0, 1], 1.0e-15);
            Assert.AreEqual (expected [0, 2], actual [0, 2]);

            Assert.AreEqual (expected [1, 0], actual [1, 0], 1.0e-15);
            Assert.AreEqual (expected [1, 1], actual [1, 1], 1.0e-15);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);

            Assert.AreEqual (expected [2, 0], actual [2, 0]);
            Assert.AreEqual (expected [2, 1], actual [2, 1]);
            Assert.AreEqual (expected [2, 2], actual [2, 2]);
        }

        [TestMethod ()]
        public void GetRotationMatrix_Passive_AroundOZ_GetMatrixTest_SinCos ()
        {
            double sin = 0.9396926207859084;
            double cos = 0.3420201433256687;

            Matrix3 expected = new Matrix3 ( 0.3420201433256687, 0.9396926207859084, 0,
                                            -0.9396926207859084, 0.3420201433256687, 0,
                                             0, 0, 1);

            Matrix3 actual = Rotation3.GetRotationMatrix.Passive.AroundOZ.GetMatrix (sin, cos);

            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 1], actual [0, 1], 1.0e-15);
            Assert.AreEqual (expected [0, 2], actual [0, 2]);

            Assert.AreEqual (expected [1, 0], actual [1, 0], 1.0e-15);
            Assert.AreEqual (expected [1, 1], actual [1, 1], 1.0e-15);
            Assert.AreEqual (expected [1, 2], actual [1, 2]);

            Assert.AreEqual (expected [2, 0], actual [2, 0]);
            Assert.AreEqual (expected [2, 1], actual [2, 1]);
            Assert.AreEqual (expected [2, 2], actual [2, 2]);
        }

        #endregion

        #region EulerAngles

        [TestMethod ()]
        public void GetRotationMatrix_Passive_EulerAngles_GetMatrixTest_AnglesDirectly ()
        {
            double alpha =       double.Pi / 6.0;
            double beta  =       double.Pi / 3.0;
            double gamma = 2.0 * double.Pi / 3.0;

            double t = double.Sqrt (3.0);

            Matrix3 expected = new Matrix3 (-0.375 * t,  0.625,     0.25 * t, 
                                            -0.125,     -0.375 * t, 0.75, 
                                             0.75,       0.25 * t,  0.5);

            Matrix3 actual = Rotation3.GetRotationMatrix.Passive.EulerAngles.GetMatrix (alpha, beta, gamma);

            Assert.AreEqual (expected [0, 0], actual [0, 0], 1.0e-15);
            Assert.AreEqual (expected [0, 1], actual [0, 1], 1.0e-15);
            Assert.AreEqual (expected [0, 2], actual [0, 2], 1.0e-15);

            Assert.AreEqual (expected [1, 0], actual [1, 0], 1.0e-15);
            Assert.AreEqual (expected [1, 1], actual [1, 1], 1.0e-15);
            Assert.AreEqual (expected [1, 2], actual [1, 2], 1.0e-15);

            Assert.AreEqual (expected [2, 0], actual [2, 0], 1.0e-15);
            Assert.AreEqual (expected [2, 1], actual [2, 1], 1.0e-15);
            Assert.AreEqual (expected [2, 2], actual [2, 2], 1.0e-15);
        }

        [TestMethod ()]
        public void GetRotationMatrix_Passive_EulerAngles_GetMatrixTest_SinCos ()
        {
            double t = double.Sqrt (3.0);

            double sinA =  0.5;
            double cosA =  0.5 * t;
            double sinB =  0.5 * t;
            double cosB =  0.5;
            double sinG =  0.5 * t;
            double cosG = -0.5;

            Matrix3 expected = new Matrix3 (-0.375 * t,  0.625,     0.25 * t,
                                            -0.125,     -0.375 * t, 0.75,
                                             0.75,       0.25 * t,  0.5);

            Matrix3 actual = Rotation3.GetRotationMatrix.Passive.EulerAngles.GetMatrix (sinA, cosA, sinB, cosB, sinG, cosG);

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

        #endregion

        #endregion

        #endregion

        #region Apply
        
        [TestMethod ()]
        public void Apply_RotateTest ()
        {
            Vector3 v = new Vector3 (2, 3, 5);
            Matrix3 rotationMatrix = new Matrix3 (0.866, -0.433, -0.25, 
                                                  0.5,    0.433,  0.75, 
                                                  0.0,    0.866,  0.5);

            Vector3 expected = new Vector3 (-0.817, 6.049, 5.098);

            Vector3 actual = Rotation3.Apply.Rotate (rotationMatrix, v);

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1], 1.0e-15);
            Assert.AreEqual (expected [2], actual [2]);
        }

        #region Passive

        #region AroundOX

        [TestMethod ()]
        public void Apply_Passive_AroundOX_RotateSpaceTest_Cartesian_AnglesDirectly ()
        {
            Vector3 v     = new Vector3 (2, 3, 5);
            double  angle = 1.2217304763960307;

            Vector3 expected = new Vector3 (2, 5.7245235339065481, -1.1089771457293817);

            Vector3 actual = Rotation3.Apply.Passive.AroundOX.RotateSpace (v, angle);

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1], 1.0e-14);
            Assert.AreEqual (expected [2], actual [2], 1.0e-14);
        }

        [TestMethod ()]
        public void Apply_Passive_AroundOX_RotateSpaceTest_Cartesian_SinCos ()
        {
            Vector3 v   = new Vector3 (2, 3, 5);
            double  sin = 0.9396926207859084;
            double  cos = 0.3420201433256687;

            Vector3 expected = new Vector3 (2, 5.7245235339065481, -1.1089771457293817);

            Vector3 actual = Rotation3.Apply.Passive.AroundOX.RotateSpace (v, sin, cos);

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1], 1.0e-14);
            Assert.AreEqual (expected [2], actual [2], 1.0e-14);
        }

        [TestMethod ()]
        public void Apply_Passive_AroundOX_RotateSpaceTest_Polar_AnglesDirectly ()
        {
            Polar3 p     = new Polar3 (6.16441400296897645, 0.94604245802985349, 0.98279372324732907);
            double angle = 1.2217304763960307;

            Polar3 expected = new Polar3 (6.16441400296897645, -0.18088463780239837, 1.23467925094772151);

            Polar3 actual = Rotation3.Apply.Passive.AroundOX.RotateSpace (p, angle);

            Assert.AreEqual (expected.R, actual.R);
            Assert.AreEqual (expected.Lat, actual.Lat, 1.0e-15);
            Assert.AreEqual (expected.Long, actual.Long);
        }

        [TestMethod ()]
        public void Apply_Passive_AroundOX_RotateSpaceTest_Polar_SinCos ()
        {
            Polar3 p   = new Polar3 (6.16441400296897645, 0.94604245802985349, 0.98279372324732907);
            double sin = 0.9396926207859084;
            double cos = 0.3420201433256687;

            Polar3 expected = new Polar3 (6.16441400296897645, -0.18088463780239837, 1.23467925094772151);

            Polar3 actual = Rotation3.Apply.Passive.AroundOX.RotateSpace (p, sin, cos);

            Assert.AreEqual (expected.R, actual.R);
            Assert.AreEqual (expected.Lat, actual.Lat, 1.0e-15);
            Assert.AreEqual (expected.Long, actual.Long);
        }

        #endregion

        #region AroundOY

        [TestMethod ()]
        public void Apply_Passive_AroundOY_RotateSpaceTest_Cartesian_AnglesDirectly ()
        {
            Vector3 v     = new Vector3 (2, 3, 5);
            double  angle = 1.2217304763960307;

            Vector3 expected = new Vector3 (-4.01442281727820, 3, 3.58948595820016);

            Vector3 actual = Rotation3.Apply.Passive.AroundOY.RotateSpace (v, angle);

            Assert.AreEqual (expected [0], actual [0], 1.0e-14);
            Assert.AreEqual (expected [1], actual [1]);
            Assert.AreEqual (expected [2], actual [2], 1.0e-14);
        }

        [TestMethod ()]
        public void Apply_Passive_AroundOY_RotateSpaceTest_Cartesian_SinCos ()
        {
            Vector3 v   = new Vector3 (2, 3, 5);
            double  sin = 0.9396926207859084;
            double  cos = 0.3420201433256687;

            Vector3 expected = new Vector3 (-4.01442281727820, 3, 3.58948595820016);

            Vector3 actual = Rotation3.Apply.Passive.AroundOY.RotateSpace (v, sin, cos);

            Assert.AreEqual (expected [0], actual [0], 1.0e-14);
            Assert.AreEqual (expected [1], actual [1]);
            Assert.AreEqual (expected [2], actual [2], 1.0e-14);
        }

        [TestMethod ()]
        public void Apply_Passive_AroundOY_RotateSpaceTest_Polar_AnglesDirectly ()
        {

        }

        [TestMethod ()]
        public void Apply_Passive_AroundOY_RotateSpaceTest_Polar_SinCos ()
        {

        }

        #endregion

        #region AroundOZ

        [TestMethod ()]
        public void Apply_Passive_AroundOZ_RotateSpaceTest_Cartesian_AnglesDirectly ()
        {

        }

        [TestMethod ()]
        public void Apply_Passive_AroundOZ_RotateSpaceTest_Cartesian_SinCos ()
        {

        }

        [TestMethod ()]
        public void Apply_Passive_AroundOZ_RotateSpaceTest_Polar_AnglesDirectly ()
        {

        }

        [TestMethod ()]
        public void Apply_Passive_AroundOZ_RotateSpaceTest_Polar_SinCos ()
        {

        }

        #endregion

        #region EulerAngles

        [TestMethod ()]
        public void Apply_Passive_EulerAngles_RotateSpaceTest_Cartesian_AnglesDirectly ()
        {
            double t = double.Sqrt (6.0);

            Vector3 v = new Vector3 (0.25 * t, 0.25 * t, 0.5);

            double alpha =  double.Pi / 4.0;
            double beta  =  double.Pi / 6.0;
            double gamma = -double.Pi / 4.0;

            Vector3 expected = new Vector3 (0.25 * t, -0.25 * t, -0.5);

            Vector3 actual = Rotation3.Apply.Passive.EulerAngles.RotateSpace (v, alpha, beta, gamma);

            Assert.AreEqual (expected [0], actual [0], 1.0e-14);
            Assert.AreEqual (expected [1], actual [1], 1.0e-14);
            Assert.AreEqual (expected [2], actual [2], 1.0e-14);
        }

        [TestMethod ()]
        public void Apply_Passive_EulerAngles_RotateSpaceTest_Cartesian_AnglesDirectly_2 ()
        {
            double root3 = double.Sqrt (3.0);

            Vector3 v = new Vector3 (1, 0, 0);

            double alpha =  double.Pi / 3.0;
            double beta  =  0.0;
            double gamma = -double.Pi / 6.0;

            Vector3 expected = new Vector3 (-1.25 + 0.375 * root3,
                                            -2.125 - 0.75 * root3,
                                             2.25 - 0.5 * root3);

            Vector3 actual = Rotation3.Apply.Passive.EulerAngles.RotateSpace (v, alpha, beta, gamma);

            Assert.AreEqual (expected [0], actual [0], 1.0e-14);
            Assert.AreEqual (expected [1], actual [1], 1.0e-14);
            Assert.AreEqual (expected [2], actual [2], 1.0e-14);
        }

        [TestMethod ()]
        public void Apply_Passive_EulerAngles_RotateSpaceTest_Cartesian_SinCos ()
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

            Vector3 actual = Rotation3.Apply.Passive.EulerAngles.RotateSpace (v, sinA, cosA, sinB, cosB, sinG, cosG);

            Assert.AreEqual (expected [0], actual [0], 1.0e-15);
            Assert.AreEqual (expected [1], actual [1]);
            Assert.AreEqual (expected [2], actual [2], 1.0e-15);
        }

        [TestMethod ()]
        public void Apply_Passive_EulerAngles_RotateSpaceTest_Polar_AnglesDirectly ()
        {
            Polar3 p = new Polar3 (r: 3.74165738677394139, latitude: 0.93027401411547205, longitude: 1.10714871779409050);

            double alpha = double.Pi / 6.0;
            double beta  = double.Pi / 3.0;
            double gamma = 2.0 * double.Pi / 3.0;

            Polar3 expected = new Polar3 (r: 3.74165738677394139, latitude: 0.37888283803921850, longitude: -1.74440306847075089);

            Polar3 actual = Rotation3.Apply.Passive.EulerAngles.RotateSpace (p, alpha, beta, gamma);

            Assert.AreEqual (expected.R, actual.R);
            Assert.AreEqual (expected.Lat, actual.Lat, 1.0e-15);
            Assert.AreEqual (expected.Long, actual.Long, 1.0e-15);
        }

        [TestMethod ()]
        public void Apply_Passive_EulerAngles_RotateSpaceTest_Polar_SinCos ()
        {
            double root3 = double.Sqrt (3.0);

            Polar3 p = new Polar3 (r: 3.74165738677394139, latitude: 0.93027401411547205, longitude: 1.10714871779409050);

            double sinA =  0.5;
            double cosA =  0.5 * root3;
            double sinB =  0.5 * root3;
            double cosB =  0.5;
            double sinG =  0.5 * root3;
            double cosG = -0.5;

            Polar3 expected = new Polar3 (r: 3.74165738677394139, latitude: 0.37888283803921850, longitude: -1.74440306847075089);

            Polar3 actual = Rotation3.Apply.Passive.EulerAngles.RotateSpace (p, sinA, cosA, sinB, cosB, sinG, cosG);

            Assert.AreEqual (expected.R, actual.R);
            Assert.AreEqual (expected.Lat, actual.Lat, 1.0e-15);
            Assert.AreEqual (expected.Long, actual.Long, 1.0e-15);
        }

        #endregion

        #endregion

        #endregion
    }
}