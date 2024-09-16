using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Vector2Tests
    {
        [TestMethod ()]
        public void opMultiplyTest ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Vector2 v2 = new Vector2 (5, 8);

            double expected = 34;

            double actual = v1 * v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Vector2 v = new Vector2 (6, 8);

            double expected = 100;

            double actual = v.GetNorm2 ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetLengthTest ()
        {
            Vector2 v = new Vector2 (6, 8);

            double expected = 10;

            double actual = v.GetLength ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ToPolarTest ()
        {
            Vector2 v = new Vector2 (6.0, 6.0 * double.Sqrt (3.0));

            double expectedR       = 12;
            double expectedHeading = double.Pi / 3.0;

            Polar2 p = v.ToPolar ();

            double actualR       = p.R;
            double actualHeading = p.Heading;

            Assert.AreEqual (expectedR, actualR);
            Assert.AreEqual (expectedHeading, actualHeading, 1.0e-15);
        }
    }
}