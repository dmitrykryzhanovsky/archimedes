using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Plane2Tests
    {
        /// <summary>
        /// Исходный вектор наклонён под углом +30°. Система координат делает поворот на +30° (30° против часовой стрелки). Вектор должен 
        /// перейти в ось OX.
        /// </summary>
        [TestMethod ()]
        public void RotateCoordinateSystemTest_Angle_PlusPI6 ()
        {
            Vector2 v     = new Vector2 (0.866025403784438647, 0.5);
            double  angle = 0.523598775598298873;

            Vector2 expected = new Vector2 (1.0, 0.0);

            Vector2 actual = Plane2.RotateCoordinateSystem (angle, v);

            Assert.AreEqual (expected.X, actual.X, 1.0e-15);
            Assert.AreEqual (expected.Y, actual.Y, 1.0e-15);
        }

        /// <summary>
        /// Исходный вектор наклонён под углом +30°. Система координат делает поворот на −30° (30° по часовой стрелке). Вектор должен 
        /// стать наклонённым на +60°.
        /// </summary>
        [TestMethod ()]
        public void RotateCoordinateSystemTest_Angle_MinusPI6 ()
        {
            Vector2 v     = new Vector2 (0.866025403784438647, 0.5);
            double  angle = -0.523598775598298873;

            Vector2 expected = new Vector2 (0.5, 0.866025403784438647);

            Vector2 actual = Plane2.RotateCoordinateSystem (angle, v);

            Assert.AreEqual (expected.X, actual.X, 1.0e-15);
            Assert.AreEqual (expected.Y, actual.Y, 1.0e-15);
        }

        /// <summary>
        /// Исходный вектор наклонён под углом +30°. Система координат делает поворот на +30° (30° против часовой стрелки). Вектор должен 
        /// перейти в ось OX.
        /// </summary>
        [TestMethod ()]
        public void RotateCoordinateSystemTest_SinCos_PlusPI6 ()
        {
            Vector2 v   = new Vector2 (0.866025403784438647, 0.5);
            double  sin = 0.5;
            double  cos = 0.866025403784438647;

            Vector2 expected = new Vector2 (1.0, 0.0);

            Vector2 actual = Plane2.RotateCoordinateSystem (sin, cos, v);

            Assert.AreEqual (expected.X, actual.X, 1.0e-15);
            Assert.AreEqual (expected.Y, actual.Y, 1.0e-15);
        }

        /// <summary>
        /// Исходный вектор наклонён под углом +30°. Система координат делает поворот на −30° (30° по часовой стрелке). Вектор должен 
        /// стать наклонённым на +60°.
        /// </summary>
        [TestMethod ()]
        public void RotateCoordinateSystemTest_SinCos_MinusPI6 ()
        {
            Vector2 v   = new Vector2 (0.866025403784438647, 0.5);
            double  sin = -0.5;
            double  cos =  0.866025403784438647;

            Vector2 expected = new Vector2 (0.5, 0.866025403784438647);

            Vector2 actual = Plane2.RotateCoordinateSystem (sin, cos, v);

            Assert.AreEqual (expected.X, actual.X, 1.0e-15);
            Assert.AreEqual (expected.Y, actual.Y, 1.0e-15);
        }
    }
}