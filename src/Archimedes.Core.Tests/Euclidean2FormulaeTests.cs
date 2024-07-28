using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Euclidean2FormulaeTests
    {
        /// <summary>
        /// Исходный вектор наклонён под углом +30°. Его поворачивают на +30° (30° против часовой стрелки), и он должен стать наклонённым 
        /// на +60°.
        /// </summary>
        [TestMethod ()]
        public void RotateVectorTest_PlusPI6 ()
        {
            double x1  = 0.866025403784438647;
            double y1  = 0.5;
            double sin = 0.5;
            double cos = 0.866025403784438647;
            
            (double x2, double y2) expected = (0.5, 0.866025403784438647);

            (double x2, double y2) actual = Euclidean2Formulae.RotateVector (sin, cos, x1, y1);

            Assert.AreEqual (expected.x2, actual.x2, 1.0e-15);
            Assert.AreEqual (expected.y2, actual.y2, 1.0e-15);
        }

        /// <summary>
        /// Исходный вектор наклонён под углом +30°. Его поворачивают на −30° (30° по часовой стрелке), и он должен перейти в ось OX.
        /// </summary>
        [TestMethod ()]
        public void RotateVectorTest_MinusPI6 ()
        {
            double x1  =  0.866025403784438647;
            double y1  =  0.5;
            double sin = -0.5;
            double cos =  0.866025403784438647;

            (double x2, double y2) expected = (1.0, 0.0);

            (double x2, double y2) actual = Euclidean2Formulae.RotateVector (sin, cos, x1, y1);

            Assert.AreEqual (expected.x2, actual.x2, 1.0e-15);
            Assert.AreEqual (expected.y2, actual.y2, 1.0e-15);
        }
    }
}