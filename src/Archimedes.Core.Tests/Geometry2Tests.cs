using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Geometry2Tests
    {
        [TestMethod ()]
        public void Ellipse_LengthTest ()
        {
            double a        = 10.0;
            double b        =  8.0;
            double sqrt1me2 =  0.8;

            double expected = 56.7233357779486;

            double actual = Geometry2.Ellipse.Length (a, b, sqrt1me2);

            Assert.AreEqual (expected, actual, 1.0e-14);
        }
    }
}