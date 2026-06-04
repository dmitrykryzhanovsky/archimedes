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
            double alpha = Trigonometry.DegToRad (10.0);
            double beta  = Trigonometry.DegToRad (20.0);
            double gamma = Trigonometry.DegToRad (40.0);

            Matrix3 expected = new Matrix3 ( 0.649519052838329,  0.727868531952443, 0.219846310392954,
                                            -0.758022221559489,  0.597291330403264, 0.262002630229385,
                                             0.059391174613885, -0.336824088833465, 0.939692620785908);

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
            double sinA = 0.17364817766693035;
            double cosA = 0.98480775301220806;
            double sinB = 0.34202014332566873;
            double cosB = 0.93969262078590838;
            double sinG = 0.64278760968653933;
            double cosG = 0.76604444311897804;

            Matrix3 expected = new Matrix3 ( 0.649519052838329,  0.727868531952443, 0.219846310392954,
                                            -0.758022221559489,  0.597291330403264, 0.262002630229385,
                                             0.059391174613885, -0.336824088833465, 0.939692620785908);

            Matrix3 actual = Rotation3.GetRotationMatrix.Passive.EulerAngles.GetMatrix (sinA, cosA, sinB, cosB, sinG, cosG);

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
            Polar3 p     = new Polar3 (6.16441400296897645, 0.94604245802985349, 0.98279372324732907);
            double angle = 1.2217304763960307;

            Polar3 expected = new Polar3 (6.16441400296897645, 0.621544513503543, 2.49981829641005);

            Polar3 actual = Rotation3.Apply.Passive.AroundOY.RotateSpace (p, angle);

            Assert.AreEqual (expected.R, actual.R);
            Assert.AreEqual (expected.Lat, actual.Lat, 1.0e-15);
            Assert.AreEqual (expected.Long, actual.Long, 1.0e-14);
        }

        [TestMethod ()]
        public void Apply_Passive_AroundOY_RotateSpaceTest_Polar_SinCos ()
        {
            Polar3 p   = new Polar3 (6.16441400296897645, 0.94604245802985349, 0.98279372324732907);
            double sin = 0.9396926207859084;
            double cos = 0.3420201433256687;

            Polar3 expected = new Polar3 (6.16441400296897645, 0.621544513503543, 2.49981829641005);

            Polar3 actual = Rotation3.Apply.Passive.AroundOY.RotateSpace (p, sin, cos);

            Assert.AreEqual (expected.R, actual.R);
            Assert.AreEqual (expected.Lat, actual.Lat, 1.0e-15);
            Assert.AreEqual (expected.Long, actual.Long, 1.0e-14);
        }

        #endregion

        #region AroundOZ

        [TestMethod ()]
        public void Apply_Passive_AroundOZ_RotateSpaceTest_Cartesian_AnglesDirectly ()
        {
            Vector3 v     = new Vector3 (2, 3, 5);
            double  angle = 1.2217304763960307;

            Vector3 expected = new Vector3 (3.503118149009060, -0.853324811594808, 5.0);

            Vector3 actual = Rotation3.Apply.Passive.AroundOZ.RotateSpace (v, angle);

            Assert.AreEqual (expected [0], actual [0], 1.0e-14);
            Assert.AreEqual (expected [1], actual [1], 1.0e-14);
            Assert.AreEqual (expected [2], actual [2], 1.0e-14);
        }

        [TestMethod ()]
        public void Apply_Passive_AroundOZ_RotateSpaceTest_Cartesian_SinCos ()
        {
            Vector3 v   = new Vector3 (2, 3, 5);
            double  sin = 0.9396926207859084;
            double  cos = 0.3420201433256687;

            Vector3 expected = new Vector3 (3.503118149009060, -0.853324811594808, 5.0);

            Vector3 actual = Rotation3.Apply.Passive.AroundOZ.RotateSpace (v, sin, cos);

            Assert.AreEqual (expected [0], actual [0], 1.0e-14);
            Assert.AreEqual (expected [1], actual [1], 1.0e-14);
            Assert.AreEqual (expected [2], actual [2], 1.0e-14);
        }

        [TestMethod ()]
        public void Apply_Passive_AroundOZ_RotateSpaceTest_Polar_AnglesDirectly ()
        {
            Polar3 p     = new Polar3 (6.16441400296897645, 0.94604245802985349, 0.98279372324732907);
            double angle = 1.2217304763960307;

            Polar3 expected = new Polar3 (6.16441400296897645, 0.94604245802985349, -0.238936753148701);

            Polar3 actual = Rotation3.Apply.Passive.AroundOZ.RotateSpace (p, angle);

            Assert.AreEqual (expected.R, actual.R);
            Assert.AreEqual (expected.Lat, actual.Lat, 1.0e-15);
            Assert.AreEqual (expected.Long, actual.Long, 1.0e-14);
        }

        [TestMethod ()]
        public void Apply_Passive_AroundOZ_RotateSpaceTest_Polar_SinCos ()
        {
            Polar3 p   = new Polar3 (6.16441400296897645, 0.94604245802985349, 0.98279372324732907);
            double sin = 0.9396926207859084;
            double cos = 0.3420201433256687;

            Polar3 expected = new Polar3 (6.16441400296897645, 0.94604245802985349, -0.238936753148701);

            Polar3 actual = Rotation3.Apply.Passive.AroundOZ.RotateSpace (p, sin, cos);

            Assert.AreEqual (expected.R, actual.R);
            Assert.AreEqual (expected.Lat, actual.Lat, 1.0e-15);
            Assert.AreEqual (expected.Long, actual.Long, 1.0e-14);
        }

        #endregion

        #region EulerAngles

        [TestMethod ()]
        public void Apply_Passive_EulerAngles_RotateSpaceTest_Cartesian_AnglesDirectly ()
        {
            Vector3 v = new Vector3 (2, 3, 5);

            double alpha = Trigonometry.DegToRad (10.0);
            double beta  = Trigonometry.DegToRad (20.0);
            double gamma = Trigonometry.DegToRad (40.0);

            Vector3 expected = new Vector3 (4.58187525349876, 1.58584269923774, 3.80677318665692);

            Vector3 actual = Rotation3.Apply.Passive.EulerAngles.RotateSpace (v, alpha, beta, gamma);

            Assert.AreEqual (expected [0], actual [0], 1.0e-14);
            Assert.AreEqual (expected [1], actual [1], 1.0e-14);
            Assert.AreEqual (expected [2], actual [2], 1.0e-14);
        }

        [TestMethod ()]
        public void Apply_Passive_EulerAngles_RotateSpaceTest_Cartesian_SinCos ()
        {
            Vector3 v = new Vector3 (2, 3, 5);

            double sinA = 0.17364817766693035;
            double cosA = 0.98480775301220806;
            double sinB = 0.34202014332566873;
            double cosB = 0.93969262078590838;
            double sinG = 0.64278760968653933;
            double cosG = 0.76604444311897804;

            Vector3 expected = new Vector3 (4.58187525349876, 1.58584269923774, 3.80677318665692);

            Vector3 actual = Rotation3.Apply.Passive.EulerAngles.RotateSpace (v, sinA, cosA, sinB, cosB, sinG, cosG);

            Assert.AreEqual (expected [0], actual [0], 1.0e-14);
            Assert.AreEqual (expected [1], actual [1], 1.0e-14);
            Assert.AreEqual (expected [2], actual [2], 1.0e-14);
        }

        [TestMethod ()]
        public void Apply_Passive_EulerAngles_RotateSpaceTest_Polar_AnglesDirectly ()
        {
            Polar3 p = new Polar3 (r: 6.16441400296898, latitude: 0.946042458029854, longitude: 0.982793723247329);

            double alpha = Trigonometry.DegToRad (10.0);
            double beta  = Trigonometry.DegToRad (20.0);
            double gamma = Trigonometry.DegToRad (40.0);

            Polar3 expected = new Polar3 (r: 6.16441400296898, latitude: 0.665611422850539, longitude: 0.333207066843468);

            Polar3 actual = Rotation3.Apply.Passive.EulerAngles.RotateSpace (p, alpha, beta, gamma);

            Assert.AreEqual (expected.R, actual.R);
            Assert.AreEqual (expected.Lat, actual.Lat, 1.0e-15);
            Assert.AreEqual (expected.Long, actual.Long, 1.0e-15);
        }

        [TestMethod ()]
        public void Apply_Passive_EulerAngles_RotateSpaceTest_Polar_SinCos ()
        {
            Polar3 p = new Polar3 (r: 6.16441400296898, latitude: 0.946042458029854, longitude: 0.982793723247329);

            double sinA = 0.17364817766693035;
            double cosA = 0.98480775301220806;
            double sinB = 0.34202014332566873;
            double cosB = 0.93969262078590838;
            double sinG = 0.64278760968653933;
            double cosG = 0.76604444311897804;

            Polar3 expected = new Polar3 (r: 6.16441400296898, latitude: 0.665611422850539, longitude: 0.333207066843468);

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