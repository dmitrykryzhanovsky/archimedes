using Archimedes;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Vector2Tests
    {
        [TestMethod ()]
        public void DimensionTest ()
        {
            Vector2 v = new Vector2 ();

            Assert.AreEqual (2, v.Dimension);
        }

        [TestMethod ()]
        public void XTest_Get ()
        {
            Vector2 v = new Vector2 (13, 21);

            Assert.AreEqual (13, v.X);
        }

        [TestMethod ()]
        public void XTest_Set ()
        {
            Vector2 v = new Vector2 (13, 21);

            v.X = 31;

            Assert.AreEqual (31, v.X);
        }

        [TestMethod ()]
        public void YTest_Get ()
        {
            Vector2 v = new Vector2 (13, 21);

            Assert.AreEqual (21, v.Y);
        }

        [TestMethod ()]
        public void YTest_Set ()
        {
            Vector2 v = new Vector2 (13, 21);

            v.Y = 12;

            Assert.AreEqual (12, v.Y);
        }

        [TestMethod ()]
        public void ConstructorTest_NoParams ()
        {
            Vector2 v = new Vector2 ();

            Assert.AreEqual (2, v.Items.Length);
            Assert.AreEqual (2, v.Dimension);
        }

        [TestMethod ()]
        public void ConstructorTest_TwoItems ()
        {
            Vector2 v = new Vector2 (5, 8);

            Assert.AreEqual (2, v.Items.Length);
            Assert.AreEqual (2, v.Dimension);

            Assert.AreEqual (5, v [0]);
            Assert.AreEqual (8, v [1]);

            Assert.AreEqual (5, v.Items [0]);
            Assert.AreEqual (8, v.Items [1]);

            Assert.AreEqual (5, v.X);
            Assert.AreEqual (8, v.Y);
        }

        [TestMethod ()]
        public void ConstructorTest_Copying ()
        {
            Vector2 source = new Vector2 (5, 8);
            Vector2 copy = new Vector2 (source);

            Assert.AreEqual (2, copy.Items.Length);
            Assert.AreEqual (2, copy.Dimension);

            Assert.AreEqual (5, copy [0]);
            Assert.AreEqual (8, copy [1]);

            Assert.AreEqual (5, copy.Items [0]);
            Assert.AreEqual (8, copy.Items [1]);

            Assert.AreEqual (5, copy.X);
            Assert.AreEqual (8, copy.Y);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Vector2 source = new Vector2 (5, 8);
            Vector2 clone = (Vector2)source.Clone ();

            Assert.AreEqual (2, clone.Items.Length);
            Assert.AreEqual (2, clone.Dimension);

            Assert.AreEqual (5, clone [0]);
            Assert.AreEqual (8, clone [1]);

            Assert.AreEqual (5, clone.Items [0]);
            Assert.AreEqual (8, clone.Items [1]);

            Assert.AreEqual (5, clone.X);
            Assert.AreEqual (8, clone.Y);
        }

        [TestMethod ()]
        public void EqualsTest_Vector2_EqualItems ()
        {
            Vector2 v1 = new Vector2 (3, 5);
            Vector2 v2 = new Vector2 (3, 5);

            Assert.AreEqual (true, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Vector2_NotEqualItems ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            Vector2 v2 = new Vector2 (8, 16);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Vector_EqualItems ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            Vector v2 = new Vector (5, 8);

            Assert.AreEqual (true, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Vector_NotEqualItems ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            Vector v2 = new Vector (8, 16);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Vector_NotEqualDimensions ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            Vector v2 = new Vector (8, 13, 21);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Vector2_EqualItems ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            object v2 = new Vector2 (5, 8);

            Assert.AreEqual (true, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Vector2_NotEqualItems ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            object v2 = new Vector2 (8, 16);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Vector_EqualItems ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            object v2 = new Vector (5, 8);

            Assert.AreEqual (true, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Vector_NotEqualItems ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            object v2 = new Vector (8, 16);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Vector_NotEqualDimensions ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            object v2 = new Vector (5, 8, 13);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_NotAVector ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            object v2 = 42;

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void opEqualsTest_EqualItems ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            Vector2 v2 = new Vector2 (5, 8);

            Assert.AreEqual (true, (v1 == v2));
        }

        [TestMethod ()]
        public void opEqualsTest_NotEqualItems ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            Vector2 v2 = new Vector2 (8, 16);

            Assert.AreEqual (false, (v1 == v2));
        }

        [TestMethod ()]
        public void opNotEqualsTest_EqualItems ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            Vector2 v2 = new Vector2 (5, 8);

            Assert.AreEqual (false, (v1 != v2));
        }

        [TestMethod ()]
        public void opNotEqualsTest_NotEqualItems ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            Vector2 v2 = new Vector2 (8, 16);

            Assert.AreEqual (true, (v1 != v2));
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            Vector2 v2 = new Vector2 (8, 16);

            Vector2 sum = v1 + v2;

            Assert.AreEqual (13, sum [0]);
            Assert.AreEqual (24, sum [1]);
        }

        [TestMethod ()]
        public void opSubtractTest ()
        {
            Vector2 v1 = new Vector2 (5, 8);
            Vector2 v2 = new Vector2 (8, 16);

            Vector2 difference = v1 - v2;

            Assert.AreEqual (-3, difference [0]);
            Assert.AreEqual (-8, difference [1]);
        }

        [TestMethod ()]
        public void opNegateTest ()
        {
            Vector2 v = new Vector2 (5, 8);

            Vector2 negation = -v;

            Assert.AreEqual (-5, negation [0]);
            Assert.AreEqual (-8, negation [1]);
        }

        [TestMethod ()]
        public void opMultiplyTest_VectorByCoefficient ()
        {
            Vector2 v = new Vector2 (5, 8);
            double coefficient = 42;

            Vector2 product = v * coefficient;

            Assert.AreEqual (210, product [0]);
            Assert.AreEqual (336, product [1]);
        }

        [TestMethod ()]
        public void opMultiplyTest_CoefficientByVector ()
        {
            double coefficient = 42;
            Vector2 v = new Vector2 (5, 8);

            Vector2 product = coefficient * v;

            Assert.AreEqual (210, product [0]);
            Assert.AreEqual (336, product [1]);
        }

        [TestMethod ()]
        public void opDivideTest ()
        {
            Vector2 v = new Vector2 (5, 8);
            double coefficient = 60;

            Vector2 quotient = v / coefficient;

            Assert.AreEqual (0.08333333333333333, quotient [0]);
            Assert.AreEqual (0.13333333333333333, quotient [1]);
        }

        [TestMethod ()]
        public void opMultiplyTest_VectorByVector ()
        {
            Vector2 v1 = new Vector2 (7, 11);
            Vector2 v2 = new Vector2 (8, 13);

            Assert.AreEqual (199, v1 * v2);
        }

        [TestMethod ()]
        public void DotProductTest ()
        {
            Vector2 v1 = new Vector2 (7, 11);
            Vector2 v2 = new Vector2 (8, 13);

            Assert.AreEqual (199, v1.DotProduct (v2));
        }

        [TestMethod ()]
        public void CrossProductTest_1 ()
        {
            Vector2 v1 = new Vector2 (1, 0);
            Vector2 v2 = new Vector2 (0, 1);

            Vector3 expected = new Vector3 (0, 0, 1);

            Vector3 actual = v1.CrossProduct (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void CrossProductTest_2 ()
        {
            Vector2 v1 = new Vector2 (1, 0);
            Vector2 v2 = new Vector2 (0.70710678118654752, 0.70710678118654752);

            Vector3 expected = new Vector3 (0, 0, 0.70710678118654752);

            Vector3 actual = v1.CrossProduct (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Vector2 v = new Vector2 (6, 8);

            Assert.AreEqual (100, v.GetNorm2 ());
        }

        [TestMethod ()]
        public void GetHeadingTest ()
        {
            Vector2 v = new Vector2 (-3.0, -1.7320508075688773);

            Assert.AreEqual (-5.0 * Double.Pi / 6.0, v.GetHeading ());
        }

        [TestMethod ()]
        public void CartesianToPolarTest_Common ()
        {
            Vector2 v = new Vector2 (3, 1.7320508075688773);

            Polar2 p = v.CartesianToPolar ();

            Assert.AreEqual (3.4641016151377546, p.R);
            Assert.AreEqual (Double.Pi / 6.0, p.Heading);
        }

        [TestMethod ()]
        public void CartesianToPolarTest_0 ()
        {
            Vector2 v = new Vector2 (2, 0);

            Polar2 p = v.CartesianToPolar ();

            Assert.AreEqual (2.0, p.R);
            Assert.AreEqual (0.0, p.Heading);
        }

        [TestMethod ()]
        public void CartesianToPolarTest_90 ()
        {
            Vector2 v = new Vector2 (0, 2);

            Polar2 p = v.CartesianToPolar ();

            Assert.AreEqual (2.0, p.R);
            Assert.AreEqual (Double.Pi / 2.0, p.Heading);
        }

        [TestMethod ()]
        public void CartesianToPolarTest_180 ()
        {
            Vector2 v = new Vector2 (-2, 0);

            Polar2 p = v.CartesianToPolar ();

            Assert.AreEqual (2.0, p.R);
            Assert.AreEqual (Double.Pi, p.Heading);
        }

        [TestMethod ()]
        public void CartesianToPolarTest_270 ()
        {
            Vector2 v = new Vector2 (0, -2);

            Polar2 p = v.CartesianToPolar ();

            Assert.AreEqual (2.0, p.R);
            Assert.AreEqual (-Double.Pi / 2.0, p.Heading);
        }

        [TestMethod ()]
        public void CartesianToPolarTest_Length0 ()
        {
            Vector2 v = new Vector2 (0, 0);

            Polar2 p = v.CartesianToPolar ();

            Assert.AreEqual (0.0, p.R);
            Assert.AreEqual (0.0, p.Heading);
        }
    }
}