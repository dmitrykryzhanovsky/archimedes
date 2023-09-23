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
    }
}