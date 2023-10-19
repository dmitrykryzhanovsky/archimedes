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
        public void CheckRadiusTest_Positive ()
        {
            double r = 42;

            Assert.AreEqual (EValid.Valid, Polar2.CheckRadius (r));
        }

        [TestMethod ()]
        public void CheckRadiusTest_Zero ()
        {
            double r = 0;

            Assert.AreEqual (EValid.Valid, Polar2.CheckRadius (r));
        }

        [TestMethod ()]
        public void CheckRadiusTest_Negative ()
        {
            double r = -42;

            Assert.AreEqual (EValid.Invalid, Polar2.CheckRadius (r));
        }

        [TestMethod ()]
        public void CheckHeadingTest_LessThanMinusPI ()
        {
            double heading = -4.0;

            Assert.AreEqual (EAngleValid.NotNormalized, Polar2.CheckHeading (heading));
        }

        [TestMethod ()]
        public void CheckHeadingTest_MinusPI ()
        {
            double heading = -Double.Pi;

            Assert.AreEqual (EAngleValid.NotNormalized, Polar2.CheckHeading (heading));
        }

        [TestMethod ()]
        public void CheckHeadingTest_Normalized ()
        {
            double heading = 0.0;

            Assert.AreEqual (EAngleValid.Normalized, Polar2.CheckHeading (heading));
        }

        [TestMethod ()]
        public void CheckHeadingTest_PlusPI ()
        {
            double heading = Double.Pi;

            Assert.AreEqual (EAngleValid.Normalized, Polar2.CheckHeading (heading));
        }

        [TestMethod ()]
        public void CheckHeadingTest_GreaterThanPlusPI ()
        {
            double heading = 4.0;

            Assert.AreEqual (EAngleValid.NotNormalized, Polar2.CheckHeading (heading));
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
            Polar2 p = new Polar2 (2.0, Double.Pi / 3.0);

            Vector2 v = p.PolarToCartesian ();

            Assert.AreEqual (1.0, v.X, 1.0e-15);
            Assert.AreEqual (1.7320508075688773, v.Y, 1.0e-15);
        }        
    }
}