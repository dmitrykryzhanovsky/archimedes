using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class MatrixTests
    {
        [TestMethod ()]
        public void IndexerTest_Get ()
        {
            Matrix m = new Matrix (4, 5,
                                    2,  3,  5,  7, 11,
                                   13, 17, 19, 23, 29,
                                   31, 37, 41, 43, 47,
                                   53, 59, 61, 67, 71);

            Assert.AreEqual ( 2, m [0, 0]);
            Assert.AreEqual (11, m [0, 4]);
            Assert.AreEqual (41, m [2, 2]);
            Assert.AreEqual (53, m [3, 0]);
            Assert.AreEqual (71, m [3, 4]);
        }

        [TestMethod ()]
        public void IndexerTest_Set ()
        {
            Matrix m = new Matrix (4, 5,
                                    2,  3,  5,  7, 11,
                                   13, 17, 19, 23, 29,
                                   31, 37, 41, 43, 47,
                                   53, 59, 61, 67, 71);

            m [0, 0] =  8;
            m [0, 4] = 13;
            m [3, 0] = 21;

            Assert.AreEqual ( 8, m [0, 0]);
            Assert.AreEqual (13, m [0, 4]);
            Assert.AreEqual (41, m [2, 2]);
            Assert.AreEqual (21, m [3, 0]);
            Assert.AreEqual (71, m [3, 4]);
        }

        [TestMethod ()]
        public void ItemsTest ()
        {
            Matrix m = new Matrix (4, 5,
                                    2,  3,  5,  7, 11,
                                   13, 17, 19, 23, 29,
                                   31, 37, 41, 43, 47,
                                   53, 59, 61, 67, 71);

            Assert.AreEqual ( 4, m.Items.GetLength (0));
            Assert.AreEqual ( 5, m.Items.GetLength (1));
            Assert.AreEqual ( 2, m.Items [0, 0]);
            Assert.AreEqual (11, m.Items [0, 4]);
            Assert.AreEqual (41, m.Items [2, 2]);
            Assert.AreEqual (53, m.Items [3, 0]);
            Assert.AreEqual (71, m.Items [3, 4]);
        }

        [TestMethod ()]
        public void HeightTest ()
        {
            Matrix m = new Matrix (4, 5,
                                    2,  3,  5,  7, 11,
                                   13, 17, 19, 23, 29,
                                   31, 37, 41, 43, 47,
                                   53, 59, 61, 67, 71);

            Assert.AreEqual (4, m.Height);
        }

        [TestMethod ()]
        public void WidthTest ()
        {
            Matrix m = new Matrix (4, 5,
                                    2,  3,  5,  7, 11,
                                   13, 17, 19, 23, 29,
                                   31, 37, 41, 43, 47,
                                   53, 59, 61, 67, 71);

            Assert.AreEqual (5, m.Width);
        }

        [TestMethod ()]
        public void MatrixTest_ArrayParams ()
        {
            Matrix m = new Matrix (4, 5,
                                    2,  3,  5,  7, 11,
                                   13, 17, 19, 23, 29,
                                   31, 37, 41, 43, 47,
                                   53, 59, 61, 67, 71);

            Assert.AreEqual ( 4, m.Height);
            Assert.AreEqual ( 5, m.Width);
            Assert.AreEqual ( 2, m [0, 0]);
            Assert.AreEqual (11, m [0, 4]);
            Assert.AreEqual (41, m [2, 2]);
            Assert.AreEqual (53, m [3, 0]);
            Assert.AreEqual (71, m [3, 4]);
        }

        [TestMethod ()]
        public void MatrixTest_Array2D ()
        {
            Matrix m = new Matrix (new double [,] { {  2,  3,  5,  7, 11 },
                                                    { 13, 17, 19, 23, 29 },
                                                    { 31, 37, 41, 43, 47 },
                                                    { 53, 59, 61, 67, 71 } });

            Assert.AreEqual ( 4, m.Height);
            Assert.AreEqual ( 5, m.Width);
            Assert.AreEqual ( 2, m [0, 0]);
            Assert.AreEqual (11, m [0, 4]);
            Assert.AreEqual (41, m [2, 2]);
            Assert.AreEqual (53, m [3, 0]);
            Assert.AreEqual (71, m [3, 4]);
        }

        [TestMethod ()]
        public void MatrixTest_Copying ()
        {
            Matrix m1 = new Matrix (4, 5,
                                     2,  3,  5,  7, 11,
                                    13, 17, 19, 23, 29,
                                    31, 37, 41, 43, 47,
                                    53, 59, 61, 67, 71);
            Matrix m2 = new Matrix (m1);

            Assert.AreEqual ( 4, m2.Height);
            Assert.AreEqual ( 5, m2.Width);
            Assert.AreEqual ( 2, m2 [0, 0]);
            Assert.AreEqual (11, m2 [0, 4]);
            Assert.AreEqual (41, m2 [2, 2]);
            Assert.AreEqual (53, m2 [3, 0]);
            Assert.AreEqual (71, m2 [3, 4]);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Matrix m1 = new Matrix (4, 5,
                                     2,  3,  5,  7, 11,
                                    13, 17, 19, 23, 29,
                                    31, 37, 41, 43, 47,
                                    53, 59, 61, 67, 71);
            Matrix m2 = (Matrix)m1.Clone ();

            Assert.AreEqual ( 4, m2.Height);
            Assert.AreEqual ( 5, m2.Width);
            Assert.AreEqual ( 2, m2 [0, 0]);
            Assert.AreEqual (11, m2 [0, 4]);
            Assert.AreEqual (41, m2 [2, 2]);
            Assert.AreEqual (53, m2 [3, 0]);
            Assert.AreEqual (71, m2 [3, 4]);
        }

        [TestMethod ()]
        public void EqualsTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void EqualsTest1 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetHashCodeTest ()
        {
            Assert.Fail ();
        }
    }
}