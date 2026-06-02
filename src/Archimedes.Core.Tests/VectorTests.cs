using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class VectorTests
    {
        [TestMethod ()]
        public void IndexerTest_Get ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            Assert.AreEqual (2, v [0]);
            Assert.AreEqual (3, v [1]);
            Assert.AreEqual (5, v [2]);
            Assert.AreEqual (8, v [3]);
        }

        [TestMethod ()]
        public void IndexerTest_Set ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            v [0] = 13;
            v [1] = 21;
            v [2] = 34;
            v [3] = 55;

            Assert.AreEqual (13, v [0]);
            Assert.AreEqual (21, v [1]);
            Assert.AreEqual (34, v [2]);
            Assert.AreEqual (55, v [3]);
        }

        [TestMethod ()]
        public void CoordinatesTest ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            Assert.AreEqual (4, v.Coordinates.Length);
            Assert.AreEqual (2, v.Coordinates [0]);
            Assert.AreEqual (3, v.Coordinates [1]);
            Assert.AreEqual (5, v.Coordinates [2]);
            Assert.AreEqual (8, v.Coordinates [3]);
        }

        [TestMethod ()]
        public void DimensionTest ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            Assert.AreEqual (4, v.Dimension);
        }

        [TestMethod ()]
        public void VectorTest_Dimension ()
        {
            Vector v = new Vector (2);

            Assert.AreEqual (2, v.Dimension);
        }

        [TestMethod ()]
        public void VectorTest_ArrayParams ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            Assert.AreEqual (4, v.Dimension);
            Assert.AreEqual (2, v [0]);
            Assert.AreEqual (3, v [1]);
            Assert.AreEqual (5, v [2]);
            Assert.AreEqual (8, v [3]);
        }

        [TestMethod ()]
        public void VectorTest_Array ()
        {
            Vector v = new Vector (new double [] { 2, 3, 5, 8 });

            Assert.AreEqual (4, v.Dimension);
            Assert.AreEqual (2, v [0]);
            Assert.AreEqual (3, v [1]);
            Assert.AreEqual (5, v [2]);
            Assert.AreEqual (8, v [3]);
        }

        [TestMethod ()]
        public void VectorTest_Copying ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            Vector v2 = new Vector (v1);

            Assert.AreEqual (4, v2.Dimension);
            Assert.AreEqual (2, v2 [0]);
            Assert.AreEqual (3, v2 [1]);
            Assert.AreEqual (5, v2 [2]);
            Assert.AreEqual (8, v2 [3]);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            Vector v2 = (Vector)v1.Clone ();

            Assert.AreEqual (4, v2.Dimension);
            Assert.AreEqual (2, v2 [0]);
            Assert.AreEqual (3, v2 [1]);
            Assert.AreEqual (5, v2 [2]);
            Assert.AreEqual (8, v2 [3]);
        }

        [TestMethod ()]
        public void EqualsTest_Vector_DimensionNotEqual ()
        {
            Vector v1 = new Vector ( 2, 3, 5 );
            Vector v2 = new Vector ( 2, 3, 5, 7 );

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector_DimensionEqual_CoordinatesNotEqual ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            Vector v2 = new Vector (2, 3, 5, 7);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector_CoordinatesEqual ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            Vector v2 = new Vector (2, 3, 5, 8);

            bool expected = true;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector2_DimensionNotEqual ()
        {
            Vector  v1 = new Vector  (2, 3, 5);
            Vector2 v2 = new Vector2 (2, 3);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector2_DimensionEqual_CoordinatesNotEqual ()
        {
            Vector  v1 = new Vector  (2, 3);
            Vector2 v2 = new Vector2 (5, 7);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector2_CoordinatesEqual ()
        {
            Vector  v1 = new Vector  (5, 8);
            Vector2 v2 = new Vector2 (5, 8);

            bool expected = true;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector3_DimensionNotEqual ()
        {
            Vector  v1 = new Vector  (2, 3, 5, 7);
            Vector3 v2 = new Vector3 (2, 3, 5);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector3_DimensionEqual_CoordinatesNotEqual ()
        {
            Vector  v1 = new Vector  (2, 3, 5);
            Vector3 v2 = new Vector3 (5, 7, 11);

            bool expected = false;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Vector3_CoordinatesEqual ()
        {
            Vector  v1 = new Vector  (5, 8, 13);
            Vector3 v2 = new Vector3 (5, 8, 13);

            bool expected = true;

            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest_DimensionNotEqual ()
        {
            Vector v1 = new Vector (2, 3, 5);
            Vector v2 = new Vector (2, 3, 5, 7);

            bool expected = false;

            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest_DimensionEqual_CoordinatesNotEqual ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            Vector v2 = new Vector (2, 3, 5, 7);

            bool expected = false;

            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest_CoordinatesEqual ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            Vector v2 = new Vector (2, 3, 5, 8);

            bool expected = true;

            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest_DimensionNotEqual ()
        {
            Vector v1 = new Vector (2, 3, 5);
            Vector v2 = new Vector (2, 3, 5, 7);

            bool expected = true;

            bool actual = (v1 != v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest_DimensionEqual_CoordinatesNotEqual ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            Vector v2 = new Vector (2, 3, 5, 7);

            bool expected = true;

            bool actual = (v1 != v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest_CoordinatesEqual ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            Vector v2 = new Vector (2, 3, 5, 8);

            bool expected = false;

            bool actual = (v1 != v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            Vector v2 = new Vector (13, 21, 34, 55);

            Vector expected = new Vector (15, 24, 39, 63);

            Vector actual = v1 + v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opAddTest_Exception_DimensionNotEqual ()
        {
            Vector v1 = new Vector (2, 3, 5);
            Vector v2 = new Vector (13, 21, 34, 55);

            bool expected = false;

            try
            {
                Vector sum = v2 + v1;
            }

            catch (ArithmeticException)
            {
                expected = true;
            }

            Assert.IsTrue (expected);
        }

        [TestMethod ()]
        public void opSubtractTest ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            Vector v2 = new Vector (13, 21, 34, 55);

            Vector expected = new Vector (-11, -18, -29, -47);

            Vector actual = v1 - v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opSubtractTest_Exception_DimensionNotEqual ()
        {
            Vector v1 = new Vector (2, 3, 5);
            Vector v2 = new Vector (13, 21, 34, 55);

            bool expected = false;

            try
            {
                Vector difference = v2 - v1;
            }

            catch (ArithmeticException)
            {
                expected = true;
            }

            Assert.IsTrue (expected);
        }

        [TestMethod ()]
        public void opNegateTest ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            Vector expected = new Vector (-2, -3, -5, -8);

            Vector actual = -v;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_VectorByCoefficient ()
        {
            Vector v           = new Vector (2, 3, 5, 8);
            double coefficient = 3;

            Vector expected = new Vector (6, 9, 15, 24);

            Vector actual = v * coefficient;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_CoefficientByVector ()
        {
            Vector v           = new Vector (2, 3, 5, 8);
            double coefficient = 3;

            Vector expected = new Vector (6, 9, 15, 24);

            Vector actual = coefficient * v;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opDivideTest ()
        {
            Vector v           = new Vector (2.0, 3.0, 5.0, 8.0);
            double coefficient = 4.0;

            Vector expected = new Vector (0.5, 0.75, 1.25, 2.0);

            Vector actual = v / coefficient;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_DotProduct ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            Vector v2 = new Vector (13, 21, 34, 55);

            double expected = 699;

            double actual = v1 * v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_DotProduct_Exception_DimensionNotEqual ()
        {
            Vector v1 = new Vector (2, 3, 5);
            Vector v2 = new Vector (13, 21, 34, 55);

            bool expected = false;

            try
            {
                double dotProduct = v1 * v2;
            }

            catch (ArithmeticException)
            {
                expected = true;
            }

            Assert.IsTrue (expected);
        }

        [TestMethod ()]
        public void DotProductTest ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            Vector v2 = new Vector (13, 21, 34, 55);

            double expected = 699;

            double actual = Vector.DotProduct (v1, v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Vector v = new Vector (3, 4, 12, 13);

            double exected = 338;

            double actual = v.GetNorm2 ();

            Assert.AreEqual (exected, actual);
        }

        [TestMethod ()]
        public void GetLengthTest ()
        {
            Vector v = new Vector (3, 4, 12, 13);

            double exected = 18.3847763108502356;

            double actual = v.GetLength ();

            Assert.AreEqual (exected, actual);
        }
    }
}