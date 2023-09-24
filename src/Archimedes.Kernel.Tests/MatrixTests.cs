using Archimedes;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class MatrixTests
    {
        [TestMethod ()]
        public void IndexerTest_Get ()
        {
            Matrix m = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);

            Assert.AreEqual (13, m [1, 1]);
        }

        [TestMethod ()]
        public void IndexerTest_Set ()
        {
            Matrix m = new Matrix (3, 2, 2, 3, 5, 8, 13, 21);

            m [2, 1] = 31;

            Assert.AreEqual (31, m [2, 1]);
        }

        [TestMethod ()]
        public void HeightTest ()
        {
            Matrix m = new Matrix (2, 3);

            Assert.AreEqual (2, m.Height);
        }

        [TestMethod ()]
        public void WidthTest ()
        {
            Matrix m = new Matrix (2, 3);

            Assert.AreEqual (3, m.Width);
        }

        [TestMethod ()]
        public void ItemsTest ()
        {
            Matrix m = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);

            Assert.AreEqual (6, m.Items.Length);
            Assert.AreEqual (2, m.Items [0]);
            Assert.AreEqual (3, m.Items [1]);
            Assert.AreEqual (5, m.Items [2]);
            Assert.AreEqual (8, m.Items [3]);
            Assert.AreEqual (13, m.Items [4]);
            Assert.AreEqual (21, m.Items [5]);
        }

        [TestMethod ()]
        public void ConstructorTest_Dimensions ()
        {
            Matrix m = new Matrix (2, 3);

            Assert.AreEqual (6, m.Items.Length);
            Assert.AreEqual (2, m.Height);
            Assert.AreEqual (3, m.Width);
        }

        [TestMethod ()]
        public void ConstructorTest_Array1D ()
        {
            Matrix m = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);

            Assert.AreEqual (6, m.Items.Length);
            Assert.AreEqual (2, m.Height);
            Assert.AreEqual (3, m.Width);

            Assert.AreEqual (2, m [0, 0]);
            Assert.AreEqual (3, m [0, 1]);
            Assert.AreEqual (5, m [0, 2]);
            Assert.AreEqual (8, m [1, 0]);
            Assert.AreEqual (13, m [1, 1]);
            Assert.AreEqual (21, m [1, 2]);

            Assert.AreEqual (2, m.Items [0]);
            Assert.AreEqual (3, m.Items [1]);
            Assert.AreEqual (5, m.Items [2]);
            Assert.AreEqual (8, m.Items [3]);
            Assert.AreEqual (13, m.Items [4]);
            Assert.AreEqual (21, m.Items [5]);
        }

        [TestMethod ()]
        public void ConstructorTest_Array2D ()
        {
            Matrix m = new Matrix (new double [,] { { 2, 3, 5 }, { 8, 13, 21 } });

            Assert.AreEqual (6, m.Items.Length);
            Assert.AreEqual (2, m.Height);
            Assert.AreEqual (3, m.Width);

            Assert.AreEqual (2, m [0, 0]);
            Assert.AreEqual (3, m [0, 1]);
            Assert.AreEqual (5, m [0, 2]);
            Assert.AreEqual (8, m [1, 0]);
            Assert.AreEqual (13, m [1, 1]);
            Assert.AreEqual (21, m [1, 2]);

            Assert.AreEqual (2, m.Items [0]);
            Assert.AreEqual (3, m.Items [1]);
            Assert.AreEqual (5, m.Items [2]);
            Assert.AreEqual (8, m.Items [3]);
            Assert.AreEqual (13, m.Items [4]);
            Assert.AreEqual (21, m.Items [5]);
        }

        [TestMethod ()]
        public void ConstructorTest_Copying ()
        {
            Matrix source = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            Matrix copy = new Matrix (source);

            Assert.AreEqual (6, copy.Items.Length);
            Assert.AreEqual (2, copy.Height);
            Assert.AreEqual (3, copy.Width);

            Assert.AreEqual (2, copy [0, 0]);
            Assert.AreEqual (3, copy [0, 1]);
            Assert.AreEqual (5, copy [0, 2]);
            Assert.AreEqual (8, copy [1, 0]);
            Assert.AreEqual (13, copy [1, 1]);
            Assert.AreEqual (21, copy [1, 2]);

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
            Matrix source = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            Matrix clone = new Matrix (source);

            Assert.AreEqual (6, clone.Items.Length);
            Assert.AreEqual (2, clone.Height);
            Assert.AreEqual (3, clone.Width);

            Assert.AreEqual (2, clone [0, 0]);
            Assert.AreEqual (3, clone [0, 1]);
            Assert.AreEqual (5, clone [0, 2]);
            Assert.AreEqual (8, clone [1, 0]);
            Assert.AreEqual (13, clone [1, 1]);
            Assert.AreEqual (21, clone [1, 2]);

            Assert.AreEqual (2, clone.Items [0]);
            Assert.AreEqual (3, clone.Items [1]);
            Assert.AreEqual (5, clone.Items [2]);
            Assert.AreEqual (8, clone.Items [3]);
            Assert.AreEqual (13, clone.Items [4]);
            Assert.AreEqual (21, clone.Items [5]);
        }

        [TestMethod ()]
        public void EqualsTest_Matrix2_EqualItems ()
        {
            Matrix m1 = new Matrix (2, 2, 2, 3, 5, 8);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 8);

            Assert.AreEqual (true, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Matrix2_NotEqualItems ()
        {
            Matrix m1 = new Matrix (2, 2, 2, 4, 8, 16);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 8);

            Assert.AreEqual (false, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Matrix2_NotEqualDimensions ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 8);

            Assert.AreEqual (false, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Matrix_EqualItems ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);

            Assert.AreEqual (true, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Matrix_NotEqualItems ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            Matrix m2 = new Matrix (2, 3, 2, 4, 8, 16, 32, 64);

            Assert.AreEqual (false, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Matrix_NotEqualDimensions ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            Matrix m2 = new Matrix (3, 2, 2, 3, 5, 8, 13, 21);

            Assert.AreEqual (false, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Matrix2_EqualItems ()
        {
            Matrix m1 = new Matrix (2, 2, 2, 3, 5, 8);
            object m2 = new Matrix2 (2, 3, 5, 8);

            Assert.AreEqual (true, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Matrix2_NotEqualItems ()
        {
            Matrix m1 = new Matrix (2, 2, 2, 3, 5, 8);
            object m2 = new Matrix2 (2, 4, 8, 16);

            Assert.AreEqual (false, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Matrix_EqualItems ()
        {
            Matrix m1 = new Matrix (2, 2, 2, 3, 5, 8);
            object m2 = new Matrix (2, 2, 2, 3, 5, 8);

            Assert.AreEqual (true, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Matrix_NotEqualItems ()
        {
            Matrix m1 = new Matrix (2, 2, 2, 3, 5, 8);
            object m2 = new Matrix (2, 2, 2, 4, 8, 16);

            Assert.AreEqual (false, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Matrix_NotEqualDimensions ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            object m2 = new Matrix (3, 2, 2, 3, 5, 8, 13, 21);

            Assert.AreEqual (false, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_NotAMatrix ()
        {
            Matrix m1 = new Matrix (2, 2, 2, 3, 5, 8);
            object m2 = 42;

            Assert.AreEqual (false, m1.Equals (m2));
        }

        [TestMethod ()]
        public void opEqualsTest_EqualItems ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);

            Assert.AreEqual (true, (m1 == m2));
        }

        [TestMethod ()]
        public void opEqualsTest_NotEqualItems ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            Matrix m2 = new Matrix (2, 3, 2, 4, 8, 16, 32, 64);

            Assert.AreEqual (false, (m1 == m2));
        }

        [TestMethod ()]
        public void opEqualsTest_NotEqualDimensions ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            Matrix m2 = new Matrix (3, 2, 2, 3, 5, 8, 13, 21);

            Assert.AreEqual (false, (m1 == m2));
        }

        [TestMethod ()]
        public void opNotEqualsTest_EqualItems ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);

            Assert.AreEqual (false, (m1 != m2));
        }

        [TestMethod ()]
        public void opNotEqualsTest_NotEqualItems ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            Matrix m2 = new Matrix (2, 3, 2, 4, 8, 16, 32, 64);

            Assert.AreEqual (true, (m1 != m2));
        }

        [TestMethod ()]
        public void opNotEqualsTest_NotEqualDimensions ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            Matrix m2 = new Matrix (3, 2, 2, 3, 5, 8, 13, 21);

            Assert.AreEqual (true, (m1 != m2));
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 7, 11, 19);

            Matrix sum = m1 + m2;

            Assert.AreEqual (6, sum.Items.Length);
            Assert.AreEqual (2, sum.Height);
            Assert.AreEqual (3, sum.Width);

            Assert.AreEqual (4, sum [0, 0]);
            Assert.AreEqual (6, sum [0, 1]);
            Assert.AreEqual (10, sum [0, 2]);
            Assert.AreEqual (15, sum [1, 0]);
            Assert.AreEqual (24, sum [1, 1]);
            Assert.AreEqual (40, sum [1, 2]);

            Assert.AreEqual (4, sum.Items [0]);
            Assert.AreEqual (6, sum.Items [1]);
            Assert.AreEqual (10, sum.Items [2]);
            Assert.AreEqual (15, sum.Items [3]);
            Assert.AreEqual (24, sum.Items [4]);
            Assert.AreEqual (40, sum.Items [5]);
        }

        [TestMethod ()]
        public void opAddTest_IncompatibleHeight ()
        {
            Matrix m1 = new Matrix (2, 3);
            Matrix m2 = new Matrix (5, 3);

            bool incompatibleMatrixAdditionException = false;

            try
            {
                object x = m1 + m2;
            }

            catch (IncompatibleMatrixAdditionException)
            {
                incompatibleMatrixAdditionException = true;
            }

            Assert.AreEqual (true, incompatibleMatrixAdditionException);
        }

        [TestMethod ()]
        public void opAddTest_IncompatibleWidth ()
        {
            Matrix m1 = new Matrix (2, 3);
            Matrix m2 = new Matrix (2, 5);

            bool incompatibleMatrixAdditionException = false;

            try
            {
                object x = m1 + m2;
            }

            catch (IncompatibleMatrixAdditionException)
            {
                incompatibleMatrixAdditionException = true;
            }

            Assert.AreEqual (true, incompatibleMatrixAdditionException);
        }

        [TestMethod ()]
        public void opAddTest_IncompatibleDimensions_1 ()
        {
            Matrix m1 = new Matrix (2, 3);
            Matrix m2 = new Matrix (3, 2);

            bool incompatibleMatrixAdditionException = false;

            try
            {
                object x = m1 + m2;
            }

            catch (IncompatibleMatrixAdditionException)
            {
                incompatibleMatrixAdditionException = true;
            }

            Assert.AreEqual (true, incompatibleMatrixAdditionException);
        }

        [TestMethod ()]
        public void opAddTest_IncompatibleDimensions_2 ()
        {
            Matrix m1 = new Matrix (2, 3);
            Matrix m2 = new Matrix (5, 7);

            bool incompatibleMatrixAdditionException = false;

            try
            {
                object x = m1 + m2;
            }

            catch (IncompatibleMatrixAdditionException)
            {
                incompatibleMatrixAdditionException = true;
            }

            Assert.AreEqual (true, incompatibleMatrixAdditionException);
        }

        [TestMethod ()]
        public void opSubtractTest ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 7, 11, 19);

            Matrix difference = m1 - m2;

            Assert.AreEqual (6, difference.Items.Length);
            Assert.AreEqual (2, difference.Height);
            Assert.AreEqual (3, difference.Width);

            Assert.AreEqual (0, difference [0, 0]);
            Assert.AreEqual (0, difference [0, 1]);
            Assert.AreEqual (0, difference [0, 2]);
            Assert.AreEqual (1, difference [1, 0]);
            Assert.AreEqual (2, difference [1, 1]);
            Assert.AreEqual (2, difference [1, 2]);

            Assert.AreEqual (0, difference.Items [0]);
            Assert.AreEqual (0, difference.Items [1]);
            Assert.AreEqual (0, difference.Items [2]);
            Assert.AreEqual (1, difference.Items [3]);
            Assert.AreEqual (2, difference.Items [4]);
            Assert.AreEqual (2, difference.Items [5]);
        }

        [TestMethod ()]
        public void opSubtractTest_IncompatibleHeight ()
        {
            Matrix m1 = new Matrix (2, 3);
            Matrix m2 = new Matrix (5, 3);

            bool incompatibleMatrixAdditionException = false;

            try
            {
                object x = m1 - m2;
            }

            catch (IncompatibleMatrixAdditionException)
            {
                incompatibleMatrixAdditionException = true;
            }

            Assert.AreEqual (true, incompatibleMatrixAdditionException);
        }

        [TestMethod ()]
        public void opSubtractTest_IncompatibleWidth ()
        {
            Matrix m1 = new Matrix (2, 3);
            Matrix m2 = new Matrix (2, 5);

            bool incompatibleMatrixAdditionException = false;

            try
            {
                object x = m1 - m2;
            }

            catch (IncompatibleMatrixAdditionException)
            {
                incompatibleMatrixAdditionException = true;
            }

            Assert.AreEqual (true, incompatibleMatrixAdditionException);
        }

        [TestMethod ()]
        public void opSubtractTest_IncompatibleDimensions_1 ()
        {
            Matrix m1 = new Matrix (2, 3);
            Matrix m2 = new Matrix (3, 2);

            bool incompatibleMatrixAdditionException = false;

            try
            {
                object x = m1 - m2;
            }

            catch (IncompatibleMatrixAdditionException)
            {
                incompatibleMatrixAdditionException = true;
            }

            Assert.AreEqual (true, incompatibleMatrixAdditionException);
        }

        [TestMethod ()]
        public void opSubtractTest_IncompatibleDimensions_2 ()
        {
            Matrix m1 = new Matrix (2, 3);
            Matrix m2 = new Matrix (5, 7);

            bool incompatibleMatrixAdditionException = false;

            try
            {
                object x = m1 - m2;
            }

            catch (IncompatibleMatrixAdditionException)
            {
                incompatibleMatrixAdditionException = true;
            }

            Assert.AreEqual (true, incompatibleMatrixAdditionException);
        }

        [TestMethod ()]
        public void opNegateTest ()
        {
            Matrix m = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);

            Matrix negation = -m;

            Assert.AreEqual (6, negation.Items.Length);
            Assert.AreEqual (2, negation.Height);
            Assert.AreEqual (3, negation.Width);

            Assert.AreEqual (-2, negation [0, 0]);
            Assert.AreEqual (-3, negation [0, 1]);
            Assert.AreEqual (-5, negation [0, 2]);
            Assert.AreEqual (-8, negation [1, 0]);
            Assert.AreEqual (-13, negation [1, 1]);
            Assert.AreEqual (-21, negation [1, 2]);

            Assert.AreEqual (-2, negation.Items [0]);
            Assert.AreEqual (-3, negation.Items [1]);
            Assert.AreEqual (-5, negation.Items [2]);
            Assert.AreEqual (-8, negation.Items [3]);
            Assert.AreEqual (-13, negation.Items [4]);
            Assert.AreEqual (-21, negation.Items [5]);
        }

        [TestMethod ()]
        public void opMultiplyTest_MatrixByCoefficient ()
        {
            Matrix m = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            double coefficient = 5;

            Matrix product = m * coefficient;

            Assert.AreEqual (6, product.Items.Length);
            Assert.AreEqual (2, product.Height);
            Assert.AreEqual (3, product.Width);

            Assert.AreEqual (10, product [0, 0]);
            Assert.AreEqual (15, product [0, 1]);
            Assert.AreEqual (25, product [0, 2]);
            Assert.AreEqual (40, product [1, 0]);
            Assert.AreEqual (65, product [1, 1]);
            Assert.AreEqual (105, product [1, 2]);

            Assert.AreEqual (10, product.Items [0]);
            Assert.AreEqual (15, product.Items [1]);
            Assert.AreEqual (25, product.Items [2]);
            Assert.AreEqual (40, product.Items [3]);
            Assert.AreEqual (65, product.Items [4]);
            Assert.AreEqual (105, product.Items [5]);
        }

        [TestMethod ()]
        public void opMultiplyTest_CoefficientByMatrix ()
        {
            double coefficient = 5;
            Matrix m = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            
            Matrix product = coefficient * m;

            Assert.AreEqual (6, product.Items.Length);
            Assert.AreEqual (2, product.Height);
            Assert.AreEqual (3, product.Width);

            Assert.AreEqual (10, product [0, 0]);
            Assert.AreEqual (15, product [0, 1]);
            Assert.AreEqual (25, product [0, 2]);
            Assert.AreEqual (40, product [1, 0]);
            Assert.AreEqual (65, product [1, 1]);
            Assert.AreEqual (105, product [1, 2]);

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
            Matrix m = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            double coefficient = 8;

            Matrix quotient = m / coefficient;

            Assert.AreEqual (6, quotient.Items.Length);
            Assert.AreEqual (2, quotient.Height);
            Assert.AreEqual (3, quotient.Width);

            Assert.AreEqual (0.25, quotient [0, 0]);
            Assert.AreEqual (0.375, quotient [0, 1]);
            Assert.AreEqual (0.625, quotient [0, 2]);
            Assert.AreEqual (1.0, quotient [1, 0]);
            Assert.AreEqual (1.625, quotient [1, 1]);
            Assert.AreEqual (2.625, quotient [1, 2]);

            Assert.AreEqual (0.25, quotient.Items [0]);
            Assert.AreEqual (0.375, quotient.Items [1]);
            Assert.AreEqual (0.625, quotient.Items [2]);
            Assert.AreEqual (1.0, quotient.Items [3]);
            Assert.AreEqual (1.625, quotient.Items [4]);
            Assert.AreEqual (2.625, quotient.Items [5]);
        }

        [TestMethod ()]
        public void opMultiplyTest_MatrixByMatrix ()
        {
            Matrix m1 = new Matrix (2, 3, 4, 7, 9, 8, 0, 8);
            Matrix m2 = new Matrix (3, 4, 0, 1, 1, 2, 0, 7, 7, 7, 0, 4, 0, 7);

            Matrix product = m1 * m2;

            Assert.AreEqual (8, product.Items.Length);
            Assert.AreEqual (2, product.Height);
            Assert.AreEqual (4, product.Width);

            Assert.AreEqual (0, product [0, 0]);
            Assert.AreEqual (89, product [0, 1]);
            Assert.AreEqual (53, product [0, 2]);
            Assert.AreEqual (120, product [0, 3]);
            Assert.AreEqual (0, product [1, 0]);
            Assert.AreEqual (40, product [1, 1]);
            Assert.AreEqual (8, product [1, 2]);
            Assert.AreEqual (72, product [1, 3]);

            Assert.AreEqual (0, product.Items [0]);
            Assert.AreEqual (89, product.Items [1]);
            Assert.AreEqual (53, product.Items [2]);
            Assert.AreEqual (120, product.Items [3]);
            Assert.AreEqual (0, product.Items [4]);
            Assert.AreEqual (40, product.Items [5]);
            Assert.AreEqual (8, product.Items [6]);
            Assert.AreEqual (72, product.Items [7]);
        }
    }
}