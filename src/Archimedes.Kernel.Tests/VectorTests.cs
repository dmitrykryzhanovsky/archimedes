using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class VectorTests
    {
        [TestMethod ()]
        public void IndexerTest_Get ()
        {
            Vector v = new Vector (2, 3, 5, 8, 13, 21);

            Assert.AreEqual (13, v [4]);
        }

        [TestMethod ()]
        public void IndexerTest_Set ()
        {
            Vector v = new Vector (2, 3, 5, 8, 13, 21);

            v [4] = 31;

            Assert.AreEqual (31, v [4]);
        }

        [TestMethod ()]
        public void DimensionTest ()
        {
            Vector v = new Vector (5);

            Assert.AreEqual (5, v.Dimension);
        }

        [TestMethod ()]
        public void ItemsTest ()
        {
            Vector v = new Vector (2, 3, 5, 8, 13);

            Assert.AreEqual (5, v.Items.Length);
            Assert.AreEqual (2, v.Items [0]);
            Assert.AreEqual (3, v.Items [1]);
            Assert.AreEqual (5, v.Items [2]);
            Assert.AreEqual (8, v.Items [3]);
            Assert.AreEqual (13, v.Items [4]);
        }

        [TestMethod ()]
        public void ConstructorTest_Dimensions ()
        {
            Vector v = new Vector (5);

            Assert.AreEqual (5, v.Items.Length);
            Assert.AreEqual (5, v.Dimension);
        }

        [TestMethod ()]
        public void ConstructorTest_Array ()
        {
            Vector v = new Vector (2, 3, 5, 8, 13, 21);

            Assert.AreEqual (6, v.Items.Length);
            Assert.AreEqual (6, v.Dimension);

            Assert.AreEqual (2, v [0]);
            Assert.AreEqual (3, v [1]);
            Assert.AreEqual (5, v [2]);
            Assert.AreEqual (8, v [3]);
            Assert.AreEqual (13, v [4]);
            Assert.AreEqual (21, v [5]);

            Assert.AreEqual (2, v.Items [0]);
            Assert.AreEqual (3, v.Items [1]);
            Assert.AreEqual (5, v.Items [2]);
            Assert.AreEqual (8, v.Items [3]);
            Assert.AreEqual (13, v.Items [4]);
            Assert.AreEqual (21, v.Items [5]);
        }

        [TestMethod ()]
        public void ConstructorTest_Copying ()
        {
            Vector source = new Vector (2, 3, 5, 8, 13, 21);
            Vector copy = new Vector (source);

            Assert.AreEqual (6, copy.Items.Length);
            Assert.AreEqual (6, copy.Dimension);

            Assert.AreEqual (2, copy [0]);
            Assert.AreEqual (3, copy [1]);
            Assert.AreEqual (5, copy [2]);
            Assert.AreEqual (8, copy [3]);
            Assert.AreEqual (13, copy [4]);
            Assert.AreEqual (21, copy [5]);

            Assert.AreEqual (2, copy.Items [0]);
            Assert.AreEqual (3, copy.Items [1]);
            Assert.AreEqual (5, copy.Items [2]);
            Assert.AreEqual (8, copy.Items [3]);
            Assert.AreEqual (13, copy.Items [4]);
            Assert.AreEqual (21, copy.Items [5]);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Vector source = new Vector (2, 3, 5, 8, 13, 21);
            Vector clone = (Vector)source.Clone ();

            Assert.AreEqual (6, clone.Items.Length);
            Assert.AreEqual (6, clone.Dimension);

            Assert.AreEqual (2, clone [0]);
            Assert.AreEqual (3, clone [1]);
            Assert.AreEqual (5, clone [2]);
            Assert.AreEqual (8, clone [3]);
            Assert.AreEqual (13, clone [4]);
            Assert.AreEqual (21, clone [5]);

            Assert.AreEqual (2, clone.Items [0]);
            Assert.AreEqual (3, clone.Items [1]);
            Assert.AreEqual (5, clone.Items [2]);
            Assert.AreEqual (8, clone.Items [3]);
            Assert.AreEqual (13, clone.Items [4]);
            Assert.AreEqual (21, clone.Items [5]);
        }

        [TestMethod ()]
        public void EqualsTest_Vector2_EqualItems ()
        {
            Vector v1 = new Vector (3, 5);
            Vector2 v2 = new Vector2 (3, 5);

            Assert.AreEqual (true, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Vector2_NotEqualItems ()
        {
            Vector v1 = new Vector (3, 8);
            Vector2 v2 = new Vector2 (3, 5);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Vector2_NotEqualDimensions ()
        {
            Vector v1 = new Vector (3, 5, 8);
            Vector2 v2 = new Vector2 (3, 5);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Vector3_EqualItems ()
        {
            Vector v1 = new Vector (2, 3, 5);
            Vector3 v2 = new Vector3 (2, 3, 5);

            Assert.AreEqual (true, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Vector3_NotEqualItems ()
        {
            Vector v1 = new Vector (2, 3, 5);
            Vector3 v2 = new Vector3 (8, 13, 21);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Vector3_NotEqualDimensions ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            Vector3 v2 = new Vector3 (2, 3, 5);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Vector_EqualItems ()
        {
            Vector v1 = new Vector (2, 3, 5, 8, 13, 21);
            Vector v2 = new Vector (2, 3, 5, 8, 13, 21);

            Assert.AreEqual (true, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Vector_NotEqualItems ()
        {
            Vector v1 = new Vector (2, 3, 5, 8, 13, 21);
            Vector v2 = new Vector (2, 4, 8, 16, 32, 64);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Vector_NotEqualDimensions ()
        {
            Vector v1 = new Vector (2, 3, 5, 8, 13, 21);
            Vector v2 = new Vector (2, 3, 5, 8, 13);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Vector2_EqualItems ()
        {
            Vector v1 = new Vector (3, 5);
            object v2 = new Vector2 (3, 5);

            Assert.AreEqual (true, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Vector2_NotEqualItems ()
        {
            Vector v1 = new Vector (3, 8);
            object v2 = new Vector2 (3, 5);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Vector3_EqualItems ()
        {
            Vector v1 = new Vector (3, 5, 8);
            object v2 = new Vector3 (3, 5, 8);

            Assert.AreEqual (true, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Vector3_NotEqualItems ()
        {
            Vector v1 = new Vector (3, 8, 21);
            object v2 = new Vector3 (3, 5, 8);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Vector_EqualItems ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            object v2 = new Vector (2, 3, 5, 8);

            Assert.AreEqual (true, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Vector_NotEqualItems ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            object v2 = new Vector (2, 4, 8, 16);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Vector_NotEqualDimensions ()
        {
            Vector v1 = new Vector (2, 3, 5, 8, 13, 21);
            object v2 = new Vector (2, 3, 5, 8, 13);

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_NotAVector ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            object v2 = 42;

            Assert.AreEqual (false, v1.Equals (v2));
        }

        [TestMethod ()]
        public void opEqualsTest_EqualItems ()
        {
            Vector v1 = new Vector (2, 3, 5, 8, 13, 21);
            Vector v2 = new Vector (2, 3, 5, 8, 13, 21);

            Assert.AreEqual (true, (v1 == v2));
        }

        [TestMethod ()]
        public void opEqualsTest_NotEqualItems ()
        {
            Vector v1 = new Vector (2, 3, 5, 8, 13, 21);
            Vector v2 = new Vector (2, 4, 8, 16, 32, 64);

            Assert.AreEqual (false, (v1 == v2));
        }

        [TestMethod ()]
        public void opEqualsTest_NotEqualDimensions ()
        {
            Vector v1 = new Vector (2, 3, 5, 8, 13, 21);
            Vector v2 = new Vector (2, 3, 5, 8, 13);

            Assert.AreEqual (false, (v1 == v2));
        }

        [TestMethod ()]
        public void opNotEqualsTest_EqualItems ()
        {
            Vector v1 = new Vector (2, 3, 5, 8, 13, 21);
            Vector v2 = new Vector (2, 3, 5, 8, 13, 21);

            Assert.AreEqual (false, (v1 != v2));
        }

        [TestMethod ()]
        public void opNotEqualsTest_NotEqualItems ()
        {
            Vector v1 = new Vector (2, 3, 5, 8, 13, 21);
            Vector v2 = new Vector (2, 4, 8, 16, 32, 64);

            Assert.AreEqual (true, (v1 != v2));
        }

        [TestMethod ()]
        public void opNotEqualsTest_NotEqualDimensions ()
        {
            Vector v1 = new Vector (2, 3, 5, 8, 13, 21);
            Vector v2 = new Vector (2, 3, 5, 8, 13);

            Assert.AreEqual (true, (v1 != v2));
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Vector v1 = new Vector (2, 3, 5, 8, 13, 21);
            Vector v2 = new Vector (2, 3, 5, 7, 11, 19);

            Vector sum = v1 + v2;

            Assert.AreEqual (6, sum.Items.Length);
            Assert.AreEqual (6, sum.Dimension);

            Assert.AreEqual (4, sum [0]);
            Assert.AreEqual (6, sum [1]);
            Assert.AreEqual (10, sum [2]);
            Assert.AreEqual (15, sum [3]);
            Assert.AreEqual (24, sum [4]);
            Assert.AreEqual (40, sum [5]);

            Assert.AreEqual (4, sum.Items [0]);
            Assert.AreEqual (6, sum.Items [1]);
            Assert.AreEqual (10, sum.Items [2]);
            Assert.AreEqual (15, sum.Items [3]);
            Assert.AreEqual (24, sum.Items [4]);
            Assert.AreEqual (40, sum.Items [5]);
        }

        [TestMethod ()]
        public void opAddTest_IncompatibleDimension ()
        {
            Vector v1 = new Vector (2, 3);
            Vector v2 = new Vector (5, 3, 2);

            bool incompatibleVectorException = false;

            try
            {
                object x = v1 + v2;
            }

            catch (IncompatibleVectorException)
            {
                incompatibleVectorException = true;
            }

            Assert.AreEqual (true, incompatibleVectorException);
        }

        [TestMethod ()]
        public void opSubtractTest ()
        {
            Vector v1 = new Vector (2, 3, 5, 8, 13, 21);
            Vector v2 = new Vector (2, 3, 5, 7, 11, 19);

            Vector difference = v1 - v2;

            Assert.AreEqual (6, difference.Items.Length);
            Assert.AreEqual (6, difference.Dimension);

            Assert.AreEqual (0, difference [0]);
            Assert.AreEqual (0, difference [1]);
            Assert.AreEqual (0, difference [2]);
            Assert.AreEqual (1, difference [3]);
            Assert.AreEqual (2, difference [4]);
            Assert.AreEqual (2, difference [5]);

            Assert.AreEqual (0, difference.Items [0]);
            Assert.AreEqual (0, difference.Items [1]);
            Assert.AreEqual (0, difference.Items [2]);
            Assert.AreEqual (1, difference.Items [3]);
            Assert.AreEqual (2, difference.Items [4]);
            Assert.AreEqual (2, difference.Items [5]);
        }

        [TestMethod ()]
        public void opSubtractTest_IncompatibleDimension ()
        {
            Vector v1 = new Vector (2, 3, 5);
            Vector v2 = new Vector (5, 3);

            bool incompatibleVectorException = false;

            try
            {
                object x = v1 - v2;
            }

            catch (IncompatibleVectorException)
            {
                incompatibleVectorException = true;
            }

            Assert.AreEqual (true, incompatibleVectorException);
        }

        [TestMethod ()]
        public void opNegateTest ()
        {
            Vector v = new Vector (2, 3, 5, 8, 13, 21);

            Vector negation = -v;

            Assert.AreEqual (6, negation.Items.Length);
            Assert.AreEqual (6, negation.Dimension);

            Assert.AreEqual (-2, negation [0]);
            Assert.AreEqual (-3, negation [1]);
            Assert.AreEqual (-5, negation [2]);
            Assert.AreEqual (-8, negation [3]);
            Assert.AreEqual (-13, negation [4]);
            Assert.AreEqual (-21, negation [5]);

            Assert.AreEqual (-2, negation.Items [0]);
            Assert.AreEqual (-3, negation.Items [1]);
            Assert.AreEqual (-5, negation.Items [2]);
            Assert.AreEqual (-8, negation.Items [3]);
            Assert.AreEqual (-13, negation.Items [4]);
            Assert.AreEqual (-21, negation.Items [5]);
        }

        [TestMethod ()]
        public void opMultiplyTest_VectorByCoefficient ()
        {
            Vector v = new Vector (2, 3, 5, 8, 13, 21);
            double coefficient = 5;

            Vector product = v * coefficient;

            Assert.AreEqual (6, product.Items.Length);
            Assert.AreEqual (6, product.Dimension);

            Assert.AreEqual (10, product [0]);
            Assert.AreEqual (15, product [1]);
            Assert.AreEqual (25, product [2]);
            Assert.AreEqual (40, product [3]);
            Assert.AreEqual (65, product [4]);
            Assert.AreEqual (105, product [5]);

            Assert.AreEqual (10, product.Items [0]);
            Assert.AreEqual (15, product.Items [1]);
            Assert.AreEqual (25, product.Items [2]);
            Assert.AreEqual (40, product.Items [3]);
            Assert.AreEqual (65, product.Items [4]);
            Assert.AreEqual (105, product.Items [5]);
        }

        [TestMethod ()]
        public void opMultiplyTest_CoefficientByVector ()
        {
            double coefficient = 5;
            Vector v = new Vector (2, 3, 5, 8, 13, 21);

            Vector product = coefficient * v;

            Assert.AreEqual (6, product.Items.Length);
            Assert.AreEqual (6, product.Dimension);

            Assert.AreEqual (10, product [0]);
            Assert.AreEqual (15, product [1]);
            Assert.AreEqual (25, product [2]);
            Assert.AreEqual (40, product [3]);
            Assert.AreEqual (65, product [4]);
            Assert.AreEqual (105, product [5]);

            Assert.AreEqual (10, product.Items [0]);
            Assert.AreEqual (15, product.Items [1]);
            Assert.AreEqual (25, product.Items [2]);
            Assert.AreEqual (40, product.Items [3]);
            Assert.AreEqual (65, product.Items [4]);
            Assert.AreEqual (105, product.Items [5]);
        }

        [TestMethod ()]
        public void opDivideTest ()
        {
            Vector v = new Vector (2, 3, 5, 8, 13, 21);
            double coefficient = 8;

            Vector quotient = v / coefficient;

            Assert.AreEqual (6, quotient.Items.Length);
            Assert.AreEqual (6, quotient.Dimension);

            Assert.AreEqual (0.25, quotient [0]);
            Assert.AreEqual (0.375, quotient [1]);
            Assert.AreEqual (0.625, quotient [2]);
            Assert.AreEqual (1.0, quotient [3]);
            Assert.AreEqual (1.625, quotient [4]);
            Assert.AreEqual (2.625, quotient [5]);

            Assert.AreEqual (0.25, quotient.Items [0]);
            Assert.AreEqual (0.375, quotient.Items [1]);
            Assert.AreEqual (0.625, quotient.Items [2]);
            Assert.AreEqual (1.0, quotient.Items [3]);
            Assert.AreEqual (1.625, quotient.Items [4]);
            Assert.AreEqual (2.625, quotient.Items [5]);
        }

        [TestMethod ()]
        public void opMultiplyTest_VectorByVector ()
        {
            Vector v1 = new Vector (2, 3, 5, 7, 11);
            Vector v2 = new Vector (2, 3, 5, 8, 13);

            Assert.AreEqual (237, v1 * v2);
        }

        [TestMethod ()]
        public void opMultiplyTest_VectorByVector_IncompatibleDimension ()
        {
            Vector v1 = new Vector (2, 3, 5, 7, 11);
            Vector v2 = new Vector (2, 3, 5, 8, 13, 21);

            bool incompatibleVectorException = false;

            try
            {
                object x = v1 * v2;
            }

            catch (IncompatibleVectorException)
            {
                incompatibleVectorException = true;
            }

            Assert.AreEqual (true, incompatibleVectorException);
        }

        [TestMethod ()]
        public void DotProductTest ()
        {
            Vector v1 = new Vector (2, 3, 5, 7, 11);
            Vector v2 = new Vector (2, 3, 5, 8, 13);

            Assert.AreEqual (237, v1.DotProduct (v2));
        }

        [TestMethod ()]
        public void DotProductTest_IncompatibleDimension ()
        {
            Vector v1 = new Vector (2, 3, 5, 7, 11);
            Vector v2 = new Vector (2, 3, 5, 8, 13, 21);

            bool incompatibleVectorException = false;

            try
            {
                object x = v1.DotProduct (v2);
            }

            catch (IncompatibleVectorException)
            {
                incompatibleVectorException = true;
            }

            Assert.AreEqual (true, incompatibleVectorException);
        }

        [TestMethod ()]
        public void GetNorm2Test_Common ()
        {
            Vector v = new Vector (6, 8, 20, 11.1803398874989485);

            Assert.AreEqual (625, v.GetNorm2 ());
        }

        [TestMethod ()]
        public void GetNorm2Test_Dimension1 ()
        {
            Vector v = new Vector (42.0);

            Assert.AreEqual (1764, v.GetNorm2 ());
        }

        [TestMethod ()]
        public void GetLengthTest_Common ()
        {
            Vector v = new Vector (6, 8, 20, 11.1803398874989485);

            Assert.AreEqual (25, v.GetLength ());
        }

        [TestMethod ()]
        public void GetLengthTest_Dimension1 ()
        {
            Vector v = new Vector (42.0);

            Assert.AreEqual (42, v.GetLength ());
        }
    }
}