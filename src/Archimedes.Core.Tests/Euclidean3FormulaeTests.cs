using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Euclidean3FormulaeTests
    {
        /// <summary>
        /// Исходный вектор наклонён под углом +30° в плоскости OYZ. Его поворачивают на −30° (30° по часовой стрелке) вокруг оси OX, 
        /// и он должен перейти в ось OY.
        /// </summary>
        [TestMethod ()]
        public void RotateVectorAroundOXTest ()
        {
            double x1  =  0.0;
            double y1  =  0.866025403784438647;
            double z1  =  0.5;
            double sin = -0.5;
            double cos =  0.866025403784438647;

            (double x2, double y2, double z2) expected = (0.0, 1.0, 0.0);

            (double x2, double y2, double z2) actual = Euclidean3Formulae.RotateVectorAroundOX (sin, cos, x1, y1, z1);

            Assert.AreEqual (expected.x2, actual.x2, 1.0e-15);
            Assert.AreEqual (expected.y2, actual.y2, 1.0e-15);
            Assert.AreEqual (expected.z2, actual.z2, 1.0e-15);
        }

        /// <summary>
        /// Исходный вектор наклонён под углом +30° в плоскости OXZ. Его поворачивают на −30° (30° по часовой стрелке) вокруг оси OY, 
        /// и он должен перейти в ось OX.
        /// </summary>
        [TestMethod ()]
        public void RotateVectorAroundOYTest ()
        {
            double x1  =  0.866025403784438647;
            double y1  =  0.0;
            double z1  =  0.5;
            double sin = -0.5;
            double cos =  0.866025403784438647;

            (double x2, double y2, double z2) expected = (1.0, 0.0, 0.0);

            (double x2, double y2, double z2) actual = Euclidean3Formulae.RotateVectorAroundOY (sin, cos, x1, y1, z1);

            Assert.AreEqual (expected.x2, actual.x2, 1.0e-15);
            Assert.AreEqual (expected.y2, actual.y2, 1.0e-15);
            Assert.AreEqual (expected.z2, actual.z2, 1.0e-15);
        }

        /// <summary>
        /// Исходный вектор наклонён под углом +30° в плоскости OXY. Его поворачивают на −30° (30° по часовой стрелке) вокруг оси OZ, 
        /// и он должен перейти в ось OX.
        /// </summary>
        [TestMethod ()]
        public void RotateVectorAroundOZTest ()
        {
            double x1  =  0.866025403784438647;
            double y1  =  0.5;
            double z1  =  0.0;
            double sin = -0.5;
            double cos =  0.866025403784438647;

            (double x2, double y2, double z2) expected = (1.0, 0.0, 0.0);

            (double x2, double y2, double z2) actual = Euclidean3Formulae.RotateVectorAroundOZ (sin, cos, x1, y1, z1);

            Assert.AreEqual (expected.x2, actual.x2, 1.0e-15);
            Assert.AreEqual (expected.y2, actual.y2, 1.0e-15);
            Assert.AreEqual (expected.z2, actual.z2, 1.0e-15);
        }
    }
}