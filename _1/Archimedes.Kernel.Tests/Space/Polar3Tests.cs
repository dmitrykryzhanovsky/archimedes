using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Polar3Tests
    {
        [TestMethod ()]
        public void RTest ()
        {
            Polar3 p = new Polar3 (5, 8, 1);

            Assert.AreEqual (5, p.R);
        }

        [TestMethod ()]
        public void LongitudeTest ()
        {
            Polar3 p = new Polar3 (5, 8, 1);

            Assert.AreEqual (8, p.Longitude);
        }

        [TestMethod ()]
        public void LatitudeTest ()
        {
            Polar3 p = new Polar3 (5, 8, 1);

            Assert.AreEqual (1, p.Latitude);
        }

        [TestMethod ()]
        public void CheckRadiusTest_Positive ()
        {
            double r = 42;

            Assert.AreEqual (EValid.Valid, Polar3.CheckRadius (r));
        }

        [TestMethod ()]
        public void CheckRadiusTest_Zero ()
        {
            double r = 0;

            Assert.AreEqual (EValid.Valid, Polar3.CheckRadius (r));
        }

        [TestMethod ()]
        public void CheckRadiusTest_Negative ()
        {
            double r = -42;

            Assert.AreEqual (EValid.Invalid, Polar3.CheckRadius (r));
        }

        [TestMethod ()]
        public void CheckLongitudeTest_LessThanMinusPI ()
        {
            double heading = -4.0;

            Assert.AreEqual (EAngleValid.NotNormalized, Polar3.CheckLongitude (heading));
        }

        [TestMethod ()]
        public void CheckLongitudeTest_MinusPI ()
        {
            double heading = -Double.Pi;

            Assert.AreEqual (EAngleValid.NotNormalized, Polar3.CheckLongitude (heading));
        }

        [TestMethod ()]
        public void CheckLongitudeTest_Normalized ()
        {
            double heading = 0.0;

            Assert.AreEqual (EAngleValid.Normalized, Polar3.CheckLongitude (heading));
        }

        [TestMethod ()]
        public void CheckLongitudeTest_PlusPI ()
        {
            double heading = Double.Pi;

            Assert.AreEqual (EAngleValid.Normalized, Polar3.CheckLongitude (heading));
        }

        [TestMethod ()]
        public void CheckLongitudeTest_GreaterThanPlusPI ()
        {
            double heading = 4.0;

            Assert.AreEqual (EAngleValid.NotNormalized, Polar3.CheckLongitude (heading));
        }

        [TestMethod ()]
        public void CheckLatitudeTest_LessThanMinusPI_2 ()
        {
            double latitide = -4.0;

            Assert.AreEqual (EAngleValid.Invalid, Polar3.CheckLatitude (latitide));
        }

        [TestMethod ()]
        public void CheckLatitudeTest_MinusPI_2 ()
        {
            double latitide = -MathConst.M_PI_2;

            Assert.AreEqual (EAngleValid.Normalized, Polar3.CheckLatitude (latitide));
        }

        [TestMethod ()]
        public void CheckLatitudeeTest_Normalized ()
        {
            double latitide = 0.0;

            Assert.AreEqual (EAngleValid.Normalized, Polar3.CheckLongitude (latitide));
        }

        [TestMethod ()]
        public void CheckLatitudeTest_PlusPI_2 ()
        {
            double latitide = MathConst.M_PI_2;

            Assert.AreEqual (EAngleValid.Normalized, Polar3.CheckLatitude (latitide));
        }

        [TestMethod ()]
        public void CheckLatitudeTest_GreaterThanPlusPI_2 ()
        {
            double latitide = 4.0;

            Assert.AreEqual (EAngleValid.Invalid, Polar3.CheckLatitude (latitide));
        }

        [TestMethod ()]
        public void ConstructorTest_RLongitudeLatitude ()
        {
            Polar3 p = new Polar3 (5, 8, 1);

            Assert.AreEqual (5, p.R);
            Assert.AreEqual (8, p.Longitude);
            Assert.AreEqual (1, p.Latitude);
        }

        [TestMethod ()]
        public void ConstructorTest_Copying ()
        {
            Polar3 p1 = new Polar3 (5, 8, 1);
            Polar3 p2 = new Polar3 (p1);

            Assert.AreEqual (5, p2.R);
            Assert.AreEqual (8, p2.Longitude);
            Assert.AreEqual (1, p2.Latitude);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Polar3 p1 = new Polar3 (5, 8, 1);
            Polar3 p2 = (Polar3)p1.Clone ();

            Assert.AreEqual (5, p2.R);
            Assert.AreEqual (8, p2.Longitude);
            Assert.AreEqual (1, p2.Latitude);
        }

        [TestMethod ()]
        public void PolarToCartesianTest ()
        {
            Polar3 p = new Polar3 (2.0, Double.Pi / 3.0, Double.Pi / 6.0);

            Vector3 v = p.PolarToCartesian ();

            Assert.AreEqual (0.86602540378443865, v.X, 1.0e-15);
            Assert.AreEqual (1.5, v.Y);
            Assert.AreEqual (1.0, v.Z, 1.0e-15);
        }        
    }
}