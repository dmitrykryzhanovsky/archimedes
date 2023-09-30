using Archimedes;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Matrix3Tests
    {
        [TestMethod ()]
        public void HeightTest ()
        {
            Matrix3 m = new Matrix3 ();

            Assert.AreEqual (3, m.Height);
        }

        [TestMethod ()]
        public void WidthTest ()
        {
            Matrix3 m = new Matrix3 ();

            Assert.AreEqual (3, m.Width);
        }

        [TestMethod ()]
        public void ConstructorTest_NoParams ()
        {
            Matrix3 m = new Matrix3 ();

            Assert.AreEqual (9, m.Items.Length);
            Assert.AreEqual (3, m.Height);
            Assert.AreEqual (3, m.Width);
        }

        [TestMethod ()]
        public void ConstructorTest_NineItems ()
        {
            Matrix3 m = new Matrix3 (2, 3, 5, 8, 13, 21, 34, 55, 89);

            Assert.AreEqual (9, m.Items.Length);
            Assert.AreEqual (3, m.Height);
            Assert.AreEqual (3, m.Width);

            Assert.AreEqual (2, m [0, 0]);
            Assert.AreEqual (3, m [0, 1]);
            Assert.AreEqual (5, m [0, 2]);
            Assert.AreEqual (8, m [1, 0]);
            Assert.AreEqual (13, m [1, 1]);
            Assert.AreEqual (21, m [1, 2]);
            Assert.AreEqual (34, m [2, 0]);
            Assert.AreEqual (55, m [2, 1]);
            Assert.AreEqual (89, m [2, 2]);

            Assert.AreEqual (2, m.Items [0]);
            Assert.AreEqual (3, m.Items [1]);
            Assert.AreEqual (5, m.Items [2]);
            Assert.AreEqual (8, m.Items [3]);
            Assert.AreEqual (13, m.Items [4]);
            Assert.AreEqual (21, m.Items [5]);
            Assert.AreEqual (34, m.Items [6]);
            Assert.AreEqual (55, m.Items [7]);
            Assert.AreEqual (89, m.Items [8]);
        }

        [TestMethod ()]
        public void ConstructorTest_Copying ()
        {
            Matrix3 source = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            Matrix3 copy = new Matrix3 (source);

            Assert.AreEqual (9, copy.Items.Length);
            Assert.AreEqual (3, copy.Height);
            Assert.AreEqual (3, copy.Width);

            Assert.AreEqual (2, copy [0, 0]);
            Assert.AreEqual (3, copy [0, 1]);
            Assert.AreEqual (5, copy [0, 2]);
            Assert.AreEqual (7, copy [1, 0]);
            Assert.AreEqual (11, copy [1, 1]);
            Assert.AreEqual (13, copy [1, 2]);
            Assert.AreEqual (17, copy [2, 0]);
            Assert.AreEqual (19, copy [2, 1]);
            Assert.AreEqual (23, copy [2, 2]);

            Assert.AreEqual (2, copy.Items [0]);
            Assert.AreEqual (3, copy.Items [1]);
            Assert.AreEqual (5, copy.Items [2]);
            Assert.AreEqual (7, copy.Items [3]);
            Assert.AreEqual (11, copy.Items [4]);
            Assert.AreEqual (13, copy.Items [5]);
            Assert.AreEqual (17, copy.Items [6]);
            Assert.AreEqual (19, copy.Items [7]);
            Assert.AreEqual (23, copy.Items [8]);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Matrix3 source = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            Matrix3 clone = (Matrix3)source.Clone ();

            Assert.AreEqual (9, clone.Items.Length);
            Assert.AreEqual (3, clone.Height);
            Assert.AreEqual (3, clone.Width);

            Assert.AreEqual (2, clone [0, 0]);
            Assert.AreEqual (3, clone [0, 1]);
            Assert.AreEqual (5, clone [0, 2]);
            Assert.AreEqual (7, clone [1, 0]);
            Assert.AreEqual (11, clone [1, 1]);
            Assert.AreEqual (13, clone [1, 2]);
            Assert.AreEqual (17, clone [2, 0]);
            Assert.AreEqual (19, clone [2, 1]);
            Assert.AreEqual (23, clone [2, 2]);

            Assert.AreEqual (2, clone.Items [0]);
            Assert.AreEqual (3, clone.Items [1]);
            Assert.AreEqual (5, clone.Items [2]);
            Assert.AreEqual (7, clone.Items [3]);
            Assert.AreEqual (11, clone.Items [4]);
            Assert.AreEqual (13, clone.Items [5]);
            Assert.AreEqual (17, clone.Items [6]);
            Assert.AreEqual (19, clone.Items [7]);
            Assert.AreEqual (23, clone.Items [8]);
        }

        [TestMethod ()]
        public void EqualsTest_Matrix3_EqualItems ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            Matrix3 m2 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);

            Assert.AreEqual (true, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Matrix3_NotEqualItems ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            Matrix3 m2 = new Matrix3 (2, 4, 8, 16, 32, 64, 128, 256, 512);

            Assert.AreEqual (false, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Matrix_EqualItems ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            Matrix m2 = new Matrix (3, 3, 2, 3, 5, 7, 11, 13, 17, 19, 23);

            Assert.AreEqual (true, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Matrix_NotEqualItems ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            Matrix m2 = new Matrix (3, 3, 2, 4, 8, 16, 32, 64, 128, 256, 512);

            Assert.AreEqual (false, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Matrix_NotEqualDimensions ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);

            Assert.AreEqual (false, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Matrix3_EqualItems ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            object m2 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);

            Assert.AreEqual (true, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Matrix3_NotEqualItems ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            object m2 = new Matrix3 (2, 4, 8, 16, 32, 64, 128, 256, 512);

            Assert.AreEqual (false, m1.Equals (m2));
        }              

        [TestMethod ()]
        public void EqualsTest_Object_Matrix_EqualItems ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            object m2 = new Matrix (3, 3, 2, 3, 5, 7, 11, 13, 17, 19, 23);

            Assert.AreEqual (true, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Matrix_NotEqualItems ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            object m2 = new Matrix (3, 3, 2, 4, 8, 16, 32, 64, 128, 256, 512);

            Assert.AreEqual (false, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_Matrix_NotEqualDimensions ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            object m2 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);

            Assert.AreEqual (false, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_Object_NotAMatrix ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            object m2 = 42;

            Assert.AreEqual (false, m1.Equals (m2));
        }

        [TestMethod ()]
        public void opEqualsTest_EqualItems ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            Matrix3 m2 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);

            Assert.AreEqual (true, (m1 == m2));
        }

        [TestMethod ()]
        public void opEqualsTest_NotEqualItems ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            Matrix3 m2 = new Matrix3 (2, 4, 8, 16, 32, 64, 128, 256, 512);

            Assert.AreEqual (false, (m1 == m2));
        }

        [TestMethod ()]
        public void opNotEqualsTest_EqualItems ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            Matrix3 m2 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);

            Assert.AreEqual (false, (m1 != m2));
        }

        [TestMethod ()]
        public void opNotEqualsTest_NotEqualItems ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            Matrix3 m2 = new Matrix3 (2, 4, 8, 16, 32, 64, 128, 256, 512);

            Assert.AreEqual (true, (m1 != m2));
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            Matrix3 m2 = new Matrix3 (29, 31, 37, 41, 43, 47, 53, 59, 61);

            Matrix3 sum = m1 + m2;

            Assert.AreEqual (31, sum [0, 0]);
            Assert.AreEqual (34, sum [0, 1]);
            Assert.AreEqual (42, sum [0, 2]);

            Assert.AreEqual (48, sum [1, 0]);
            Assert.AreEqual (54, sum [1, 1]);
            Assert.AreEqual (60, sum [1, 2]);

            Assert.AreEqual (70, sum [2, 0]);
            Assert.AreEqual (78, sum [2, 1]);
            Assert.AreEqual (84, sum [2, 2]);
        }

        [TestMethod ()]
        public void opSubtractTest ()
        {
            Matrix3 m1 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            Matrix3 m2 = new Matrix3 (29, 31, 37, 41, 43, 47, 53, 59, 61);

            Matrix3 sum = m1 - m2;

            Assert.AreEqual (-27, sum [0, 0]);
            Assert.AreEqual (-28, sum [0, 1]);
            Assert.AreEqual (-32, sum [0, 2]);

            Assert.AreEqual (-34, sum [1, 0]);
            Assert.AreEqual (-32, sum [1, 1]);
            Assert.AreEqual (-34, sum [1, 2]);

            Assert.AreEqual (-36, sum [2, 0]);
            Assert.AreEqual (-40, sum [2, 1]);
            Assert.AreEqual (-38, sum [2, 2]);
        }

        [TestMethod ()]
        public void opNegateTest ()
        {
            Matrix3 m = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);

            Matrix3 negation = -m;

            Assert.AreEqual (-2, negation [0, 0]);
            Assert.AreEqual (-3, negation [0, 1]);
            Assert.AreEqual (-5, negation [0, 2]);

            Assert.AreEqual (-7, negation [1, 0]);
            Assert.AreEqual (-11, negation [1, 1]);
            Assert.AreEqual (-13, negation [1, 2]);

            Assert.AreEqual (-17, negation [2, 0]);
            Assert.AreEqual (-19, negation [2, 1]);
            Assert.AreEqual (-23, negation [2, 2]);
        }

        [TestMethod ()]
        public void opMultiplyTest_MatrixByCoefficient ()
        {
            Matrix3 m = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            double coefficient = 3;

            Matrix3 product = m * coefficient;

            Assert.AreEqual (6, product [0, 0]);
            Assert.AreEqual (9, product [0, 1]);
            Assert.AreEqual (15, product [0, 2]);

            Assert.AreEqual (21, product [1, 0]);
            Assert.AreEqual (33, product [1, 1]);
            Assert.AreEqual (39, product [1, 2]);

            Assert.AreEqual (51, product [2, 0]);
            Assert.AreEqual (57, product [2, 1]);
            Assert.AreEqual (69, product [2, 2]);
        }

        [TestMethod ()]
        public void opMultiplyTest_CoefficientByMatrix ()
        {
            double coefficient = 2;
            Matrix3 m = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            
            Matrix3 product = coefficient * m;

            Assert.AreEqual (4, product [0, 0]);
            Assert.AreEqual (6, product [0, 1]);
            Assert.AreEqual (10, product [0, 2]);

            Assert.AreEqual (14, product [1, 0]);
            Assert.AreEqual (22, product [1, 1]);
            Assert.AreEqual (26, product [1, 2]);

            Assert.AreEqual (34, product [2, 0]);
            Assert.AreEqual (38, product [2, 1]);
            Assert.AreEqual (46, product [2, 2]);
        }

        [TestMethod ()]
        public void opDivideTest ()
        {
            Matrix3 m = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);
            double coefficient = 4;

            Matrix3 quotient = m / coefficient;

            Assert.AreEqual (0.5, quotient [0, 0]);
            Assert.AreEqual (0.75, quotient [0, 1]);
            Assert.AreEqual (1.25, quotient [0, 2]);

            Assert.AreEqual (1.75, quotient [1, 0]);
            Assert.AreEqual (2.75, quotient [1, 1]);
            Assert.AreEqual (3.25, quotient [1, 2]);

            Assert.AreEqual (4.25, quotient [2, 0]);
            Assert.AreEqual (4.75, quotient [2, 1]);
            Assert.AreEqual (5.75, quotient [2, 2]);
        }

        [TestMethod ()]
        public void opMultiplyTest_VectorByMatrix ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Matrix3 m2 = new Matrix3 (7, 11, 13, 5, 8, 9, 3, 1, 0);

            Vector3 product = v1 * m2;

            Assert.AreEqual (44, product [0]);
            Assert.AreEqual (51, product [1]);
            Assert.AreEqual (53, product [2]);
        }

        [TestMethod ()]
        public void opMultiplyTest_MatrixByVector ()
        {
            Matrix3 m1 = new Matrix3 (7, 11, 13, 5, 8, 9, 3, 1, 0);
            Vector3 v2 = new Vector3 (2, 3, 5);
            
            Vector3 product = m1 * v2;

            Assert.AreEqual (112, product [0]);
            Assert.AreEqual (79, product [1]);
            Assert.AreEqual (9, product [2]);
        }

        [TestMethod ()]
        public void opMultiplyTest_MatrixByMatrix ()
        {
            Matrix3 m1 = new Matrix3 (2, 7, 7, 1, 3, 7, 1, 6, 0);
            Matrix3 m2 = new Matrix3 (4, 6, 9, 3, 2, 5, 9, 4, 7);

            Matrix3 product = m1 * m2;

            Assert.AreEqual (92, product [0, 0]);
            Assert.AreEqual (54, product [0, 1]);
            Assert.AreEqual (102, product [0, 2]);

            Assert.AreEqual (76, product [1, 0]);
            Assert.AreEqual (40, product [1, 1]);
            Assert.AreEqual (73, product [1, 2]);

            Assert.AreEqual (22, product [2, 0]);
            Assert.AreEqual (18, product [2, 1]);
            Assert.AreEqual (39, product [2, 2]);
        }
    }
}