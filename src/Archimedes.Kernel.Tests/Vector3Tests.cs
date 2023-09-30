﻿using Archimedes;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Vector3Tests
    {
        [TestMethod ()]
        public void DimensionTest ()
        {
            Vector3 v = new Vector3 ();

            Assert.AreEqual (3, v.Dimension);
        }

        [TestMethod ()]
        public void XTest_Get ()
        {
            Vector3 v = new Vector3 (13, 21, 34);

            Assert.AreEqual (13, v.X);
        }

        [TestMethod ()]
        public void XTest_Set ()
        {
            Vector3 v = new Vector3 (13, 21, 34);

            v.X = 31;

            Assert.AreEqual (31, v.X);
        }

        [TestMethod ()]
        public void YTest_Get ()
        {
            Vector3 v = new Vector3 (13, 21, 34);

            Assert.AreEqual (21, v.Y);
        }

        [TestMethod ()]
        public void YTest_Set ()
        {
            Vector3 v = new Vector3 (13, 21, 34);

            v.Y = 12;

            Assert.AreEqual (12, v.Y);
        }

        [TestMethod ()]
        public void ZTest_Get ()
        {
            Vector3 v = new Vector3 (13, 21, 34);

            Assert.AreEqual (34, v.Z);
        }

        [TestMethod ()]
        public void ZTest_Set ()
        {
            Vector3 v = new Vector3 (13, 21, 34);

            v.Z = 43;

            Assert.AreEqual (43, v.Z);
        }

        [TestMethod ()]
        public void ConstructorTest_NoParams ()
        {
            Vector3 v = new Vector3 ();

            Assert.AreEqual (3, v.Items.Length);
            Assert.AreEqual (3, v.Dimension);
        }

        [TestMethod ()]
        public void ConstructorTest_TwoItems ()
        {
            Vector3 v = new Vector3 (5, 8, 13);

            Assert.AreEqual (3, v.Items.Length);
            Assert.AreEqual (3, v.Dimension);

            Assert.AreEqual (5, v [0]);
            Assert.AreEqual (8, v [1]);
            Assert.AreEqual (13, v [2]);

            Assert.AreEqual (5, v.Items [0]);
            Assert.AreEqual (8, v.Items [1]);
            Assert.AreEqual (13, v.Items [2]);

            Assert.AreEqual (5, v.X);
            Assert.AreEqual (8, v.Y);
            Assert.AreEqual (13, v.Z);
        }

        [TestMethod ()]
        public void ConstructorTest_Copying ()
        {
            Vector3 source = new Vector3 (5, 8, 13);
            Vector3 copy = new Vector3 (source);

            Assert.AreEqual (3, copy.Items.Length);
            Assert.AreEqual (3, copy.Dimension);

            Assert.AreEqual (5, copy [0]);
            Assert.AreEqual (8, copy [1]);
            Assert.AreEqual (13, copy [2]);

            Assert.AreEqual (5, copy.Items [0]);
            Assert.AreEqual (8, copy.Items [1]);
            Assert.AreEqual (13, copy.Items [2]);

            Assert.AreEqual (5, copy.X);
            Assert.AreEqual (8, copy.Y);
            Assert.AreEqual (13, copy.Z);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Vector3 source = new Vector3 (5, 8, 13);
            Vector3 clone = (Vector3)source.Clone ();

            Assert.AreEqual (3, clone.Items.Length);
            Assert.AreEqual (3, clone.Dimension);

            Assert.AreEqual (5, clone [0]);
            Assert.AreEqual (8, clone [1]);
            Assert.AreEqual (13, clone [2]);

            Assert.AreEqual (5, clone.Items [0]);
            Assert.AreEqual (8, clone.Items [1]);
            Assert.AreEqual (13, clone.Items [2]);

            Assert.AreEqual (5, clone.X);
            Assert.AreEqual (8, clone.Y);
            Assert.AreEqual (13, clone.Z);
        }

        [TestMethod ()]
        public void EqualsTest_Vector3_EqualItems ()
        {
            Vector3 v1 = new Vector3 (3, 5, 13);
            Vector3 v2 = new Vector3 (3, 5, 13);

            Assert.AreEqual (true, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Vector3_NotEqualItems ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            Vector3 v2 = new Vector3 (8, 16, 32);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Vector_EqualItems ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            Vector v2 = new Vector (5, 8, 13);

            Assert.AreEqual (true, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Vector_NotEqualItems ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            Vector v2 = new Vector (8, 16, 32);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Vector_NotEqualDimensions ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            Vector v2 = new Vector (8, 13, 21, 34);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Vector3_EqualItems ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            object v2 = new Vector3 (5, 8, 13);

            Assert.AreEqual (true, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Vector3_NotEqualItems ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            object v2 = new Vector3 (8, 16, 32);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Vector_EqualItems ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            object v2 = new Vector (5, 8, 13);

            Assert.AreEqual (true, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Vector_NotEqualItems ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            object v2 = new Vector (8, 16, 32);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Vector_NotEqualDimensions ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            object v2 = new Vector (5, 8, 13, 21);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_NotAVector ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            object v2 = 42;

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void opEqualsTest_EqualItems ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            Vector3 v2 = new Vector3 (5, 8, 13);

            Assert.AreEqual (true, (v1 == v2));
        }

        [TestMethod ()]
        public void opEqualsTest_NotEqualItems ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            Vector3 v2 = new Vector3 (8, 16, 32);

            Assert.AreEqual (false, (v1 == v2));
        }

        [TestMethod ()]
        public void opNotEqualsTest_EqualItems ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            Vector3 v2 = new Vector3 (5, 8, 13);

            Assert.AreEqual (false, (v1 != v2));
        }

        [TestMethod ()]
        public void opNotEqualsTest_NotEqualItems ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            Vector3 v2 = new Vector3 (8, 16, 32);

            Assert.AreEqual (true, (v1 != v2));
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            Vector3 v2 = new Vector3 (8, 16, 32);

            Vector3 sum = v1 + v2;

            Assert.AreEqual (13, sum [0]);
            Assert.AreEqual (24, sum [1]);
            Assert.AreEqual (45, sum [2]);
        }

        [TestMethod ()]
        public void opSubtractTest ()
        {
            Vector3 v1 = new Vector3 (5, 8, 13);
            Vector3 v2 = new Vector3 (8, 16, 32);

            Vector3 difference = v1 - v2;

            Assert.AreEqual (-3, difference [0]);
            Assert.AreEqual (-8, difference [1]);
            Assert.AreEqual (-19, difference [2]);
        }

        [TestMethod ()]
        public void opNegateTest ()
        {
            Vector3 v = new Vector3 (5, 8, 13);

            Vector3 negation = -v;

            Assert.AreEqual (-5, negation [0]);
            Assert.AreEqual (-8, negation [1]);
            Assert.AreEqual (-13, negation [2]);
        }

        [TestMethod ()]
        public void opMultiplyTest_VectorByCoefficient ()
        {
            Vector3 v = new Vector3 (5, 8, 13);
            double coefficient = 42;

            Vector3 product = v * coefficient;

            Assert.AreEqual (210, product [0]);
            Assert.AreEqual (336, product [1]);
            Assert.AreEqual (546, product [2]);
        }

        [TestMethod ()]
        public void opMultiplyTest_CoefficientByVector ()
        {
            double coefficient = 42;
            Vector3 v = new Vector3 (5, 8, 13);

            Vector3 product = coefficient * v;

            Assert.AreEqual (210, product [0]);
            Assert.AreEqual (336, product [1]);
            Assert.AreEqual (546, product [2]);
        }

        [TestMethod ()]
        public void opDivideTest ()
        {
            Vector3 v = new Vector3 (5, 8, 12);
            double coefficient = 60;

            Vector3 quotient = v / coefficient;

            Assert.AreEqual (0.08333333333333333, quotient [0]);
            Assert.AreEqual (0.13333333333333333, quotient [1]);
            Assert.AreEqual (0.2, quotient [2]);
        }

        [TestMethod ()]
        public void opMultiplyTest_VectorByVector ()
        {
            Vector3 v1 = new Vector3 (7, 11, 13);
            Vector3 v2 = new Vector3 (8, 13, 21);

            Assert.AreEqual (472, v1 * v2);
        }

        [TestMethod ()]
        public void DotProductTest ()
        {
            Vector3 v1 = new Vector3 (7, 11, 13);
            Vector3 v2 = new Vector3 (8, 13, 21);

            Assert.AreEqual (472, v1.DotProduct (v2));
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Vector3 v = new Vector3 (6, 8, 10);

            Assert.AreEqual (200, v.GetNorm2 ());
        }
    }
}