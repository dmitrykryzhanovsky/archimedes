using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Matrix2Tests
    {
        [TestMethod ()]
        public void HeightTest ()
        {
            Matrix2 m = new Matrix2 ();

            Assert.AreEqual (2, m.Height);
        }

        [TestMethod ()]
        public void WidthTest ()
        {
            Matrix2 m = new Matrix2 ();

            Assert.AreEqual (2, m.Width);
        }

        [TestMethod ()]
        public void ConstructorTest_NoParams ()
        {
            Matrix2 m = new Matrix2 ();

            Assert.AreEqual (4, m.Items.Length);
            Assert.AreEqual (2, m.Height);
            Assert.AreEqual (2, m.Width);
        }

        [TestMethod ()]
        public void ConstructorTest_FourItems ()
        {
            Matrix2 m = new Matrix2 (2, 3, 5, 8);

            Assert.AreEqual (4, m.Items.Length);
            Assert.AreEqual (2, m.Height);
            Assert.AreEqual (2, m.Width);

            Assert.AreEqual (2, m [0, 0]);
            Assert.AreEqual (3, m [0, 1]);
            Assert.AreEqual (5, m [1, 0]);
            Assert.AreEqual (8, m [1, 1]);

            Assert.AreEqual (2, m.Items [0]);
            Assert.AreEqual (3, m.Items [1]);
            Assert.AreEqual (5, m.Items [2]);
            Assert.AreEqual (8, m.Items [3]);
        }

        [TestMethod ()]
        public void ConstructorTest_Copying ()
        {
            Matrix2 source = new Matrix2 (2, 3, 5, 8);
            Matrix2 copy = new Matrix2 (source);

            Assert.AreEqual (4, copy.Items.Length);
            Assert.AreEqual (2, copy.Height);
            Assert.AreEqual (2, copy.Width);

            Assert.AreEqual (2, copy [0, 0]);
            Assert.AreEqual (3, copy [0, 1]);
            Assert.AreEqual (5, copy [1, 0]);
            Assert.AreEqual (8, copy [1, 1]);

            Assert.AreEqual (2, copy.Items [0]);
            Assert.AreEqual (3, copy.Items [1]);
            Assert.AreEqual (5, copy.Items [2]);
            Assert.AreEqual (8, copy.Items [3]);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Matrix2 source = new Matrix2 (2, 3, 5, 8);
            Matrix2 clone = (Matrix2)source.Clone ();

            Assert.AreEqual (4, clone.Items.Length);
            Assert.AreEqual (2, clone.Height);
            Assert.AreEqual (2, clone.Width);

            Assert.AreEqual (2, clone [0, 0]);
            Assert.AreEqual (3, clone [0, 1]);
            Assert.AreEqual (5, clone [1, 0]);
            Assert.AreEqual (8, clone [1, 1]);

            Assert.AreEqual (2, clone.Items [0]);
            Assert.AreEqual (3, clone.Items [1]);
            Assert.AreEqual (5, clone.Items [2]);
            Assert.AreEqual (8, clone.Items [3]);
        }

        [TestMethod ()]
        public void EqualsTest_Matrix2_EqualItems ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 8);

            Assert.AreEqual (true, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Matrix2_NotEqualItems ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            Matrix2 m2 = new Matrix2 (2, 4, 8, 16);

            Assert.AreEqual (false, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Matrix_EqualItems ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            Matrix m2 = new Matrix (2, 2, 2, 3, 5, 8);

            Assert.AreEqual (true, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Matrix_NotEqualItems ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            Matrix m2 = new Matrix (2, 2, 2, 4, 8, 16);

            Assert.AreEqual (false, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Matrix_NotEqualDimensions ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);

            Assert.AreEqual (false, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Matrix2_EqualItems ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            object m2 = new Matrix2 (2, 3, 5, 8);

            Assert.AreEqual (true, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Matrix2_NotEqualItems ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            object m2 = new Matrix2 (2, 4, 8, 16);

            Assert.AreEqual (false, m1.Equals (m2));
        }              

        [TestMethod ()]
        public void EqualsTest_Object_Matrix_EqualItems ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            object m2 = new Matrix (2, 2, 2, 3, 5, 8);

            Assert.AreEqual (true, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Matrix_NotEqualItems ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            object m2 = new Matrix (2, 2, 2, 4, 8, 16);

            Assert.AreEqual (false, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Matrix_NotEqualDimensions ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            object m2 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);

            Assert.AreEqual (false, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_NotAMatrix ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            object m2 = 42;

            Assert.AreEqual (false, m1.Equals (m2));
        }

        [TestMethod ()]
        public void opEqualsTest_EqualItems ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 8);

            Assert.AreEqual (true, (m1 == m2));
        }

        [TestMethod ()]
        public void opEqualsTest_NotEqualItems ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            Matrix2 m2 = new Matrix2 (2, 4, 8, 16);

            Assert.AreEqual (false, (m1 == m2));
        }

        [TestMethod ()]
        public void opNotEqualsTest_EqualItems ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 8);

            Assert.AreEqual (false, (m1 != m2));
        }

        [TestMethod ()]
        public void opNotEqualsTest_NotEqualItems ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            Matrix2 m2 = new Matrix2 (2, 4, 8, 16);

            Assert.AreEqual (true, (m1 != m2));
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            Matrix2 m2 = new Matrix2 (2, 4, 8, 16);

            Matrix2 sum = m1 + m2;

            Assert.AreEqual (4, sum [0, 0]);
            Assert.AreEqual (7, sum [0, 1]);
            Assert.AreEqual (13, sum [1, 0]);
            Assert.AreEqual (24, sum [1, 1]);
        }

        [TestMethod ()]
        public void opSubtractTest ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            Matrix2 m2 = new Matrix2 (2, 4, 8, 16);

            Matrix2 difference = m1 - m2;

            Assert.AreEqual (0, difference [0, 0]);
            Assert.AreEqual (-1, difference [0, 1]);
            Assert.AreEqual (-3, difference [1, 0]);
            Assert.AreEqual (-8, difference [1, 1]);
        }

        [TestMethod ()]
        public void opNegateTest ()
        {
            Matrix2 m = new Matrix2 (2, 3, 5, 8);

            Matrix2 negation = -m;

            Assert.AreEqual (-2, negation [0, 0]);
            Assert.AreEqual (-3, negation [0, 1]);
            Assert.AreEqual (-5, negation [1, 0]);
            Assert.AreEqual (-8, negation [1, 1]);
        }

        [TestMethod ()]
        public void opMultiplyTest_MatrixByCoefficient ()
        {
            Matrix2 m = new Matrix2 (2, 3, 5, 8);
            double coefficient = 42;

            Matrix2 product = m * coefficient;

            Assert.AreEqual (84, product [0, 0]);
            Assert.AreEqual (126, product [0, 1]);
            Assert.AreEqual (210, product [1, 0]);
            Assert.AreEqual (336, product [1, 1]);
        }

        [TestMethod ()]
        public void opMultiplyTest_CoefficientByMatrix ()
        {
            double coefficient = 42;
            Matrix2 m = new Matrix2 (2, 3, 5, 8);
            
            Matrix2 product = coefficient * m;

            Assert.AreEqual (84, product [0, 0]);
            Assert.AreEqual (126, product [0, 1]);
            Assert.AreEqual (210, product [1, 0]);
            Assert.AreEqual (336, product [1, 1]);
        }

        [TestMethod ()]
        public void opDivideTest ()
        {
            Matrix2 m = new Matrix2 (2, 3, 5, 8);
            double coefficient = 60;

            Matrix2 quotient = m / coefficient;

            Assert.AreEqual (0.03333333333333333, quotient [0, 0]);
            Assert.AreEqual (0.05, quotient [0, 1]);
            Assert.AreEqual (0.08333333333333333, quotient [1, 0]);
            Assert.AreEqual (0.13333333333333333, quotient [1, 1]);
        }

        [TestMethod ()]
        public void opMultiplyTest_VectorByMatrix ()
        {
            Vector2 v1 = new Vector2 (2, 3);
            Matrix2 m2 = new Matrix2 (5, 7, 11, 13);

            Vector2 product = v1 * m2;

            Assert.AreEqual (43, product [0]);
            Assert.AreEqual (53, product [1]);
        }

        [TestMethod ()]
        public void opMultiplyTest_MatrixByVector ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 7);
            Vector2 v2 = new Vector2 (11, 13);

            Vector2 product = m1 * v2;

            Assert.AreEqual (61, product [0]);
            Assert.AreEqual (146, product [1]);
        }

        [TestMethod ()]
        public void opMultiplyTest_MatrixByMatrix ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            Matrix2 m2 = new Matrix2 (2, 4, 8, 16);

            Matrix2 product = m1 * m2;

            Assert.AreEqual (28, product [0, 0]);
            Assert.AreEqual (56, product [0, 1]);
            Assert.AreEqual (74, product [1, 0]);
            Assert.AreEqual (148, product [1, 1]);
        }
    }
}