using Archimedes;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Polar2Tests
    {
        [TestMethod ()]
        public void RTest ()
        {
            Polar2 p = new Polar2 (5, 8);

            Assert.AreEqual (5, p.R);
        }

        [TestMethod ()]
        public void HeadingTest ()
        {
            Polar2 p = new Polar2 (5, 8);

            Assert.AreEqual (8, p.Heading);
        }

        [TestMethod ()]
        public void CheckValidityTest ()
        {
            double r = 5.0;
            double heading 
        }

        [TestMethod ()]
        public void ConstructorTest_RHeading ()
        {
            Polar2 p = new Polar2 (5, 8);

            Assert.AreEqual (5, p.R);
            Assert.AreEqual (8, p.Heading);
        }

        [TestMethod ()]
        public void ConstructorTest_Copying ()
        {
            Polar2 p1 = new Polar2 (5, 8);
            Polar2 p2 = new Polar2 (p1);

            Assert.AreEqual (5, p2.R);
            Assert.AreEqual (8, p2.Heading);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Polar2 p1 = new Polar2 (5, 8);
            Polar2 p2 = (Polar2)p1.Clone ();

            Assert.AreEqual (5, p2.R);
            Assert.AreEqual (8, p2.Heading);
        }

        [TestMethod ()]
        public void PolarToCartesianTest ()
        {
            Polar2 p = new Polar2 (2.0, Math.PI / 3.0);

            Vector2 v = p.PolarToCartesian ();

            Assert.AreEqual (1.0, v.X, 1.0e-15);
            Assert.AreEqual (1.7320508075688773, v.Y, 1.0e-15);
        }        
    }
}