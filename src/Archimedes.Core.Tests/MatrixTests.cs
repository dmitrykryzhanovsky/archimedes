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
        public void EqualsTest_Matrix_SizeNotEqual ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (2, 4, 2, 3, 5, 7, 8, 11, 13, 21, 34);

            bool expected = false;

            bool actual = m1.Equals (m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Matrix_SizeEqual_ItemsNotEqual ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);

            bool expected = false;

            bool actual = m1.Equals (m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Matrix_SizeEqual_ItemsEqual ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);

            bool expected = true;

            bool actual = m1.Equals (m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Matrix2_SizeNotEqual ()
        {
            Matrix  m1 = new Matrix  (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 7);

            bool expected = false;

            bool actual = m1.Equals (m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Matrix2_SizeEqual_ItemsNotEqual ()
        {
            Matrix  m1 = new Matrix  (2, 2, 2, 3, 5, 8);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 7);

            bool expected = false;

            bool actual = m1.Equals (m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Matrix2_SizeEqual_ItemsEqual ()
        {
            Matrix  m1 = new Matrix  (2, 2, 2, 3, 5, 8);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 8);

            bool expected = true;

            bool actual = m1.Equals (m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Matrix3_SizeNotEqual ()
        {
            Matrix  m1 = new Matrix  (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix3 m2 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);

            bool expected = false;

            bool actual = m1.Equals (m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Matrix3_SizeEqual_ItemsNotEqual ()
        {
            Matrix  m1 = new Matrix  (3, 3, 2, 3, 5, 8, 13, 21, 34, 55, 89);
            Matrix3 m2 = new Matrix3 (2, 3, 5, 7, 11, 13, 17, 19, 23);

            bool expected = false;

            bool actual = m1.Equals (m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Matrix3_SizeEqual_ItemsEqual ()
        {
            Matrix  m1 = new Matrix  (3, 3, 2, 3, 5, 8, 13, 21, 34, 55, 89);
            Matrix3 m2 = new Matrix3 (2, 3, 5, 8, 13, 21, 34, 55, 89);

            bool expected = true;

            bool actual = m1.Equals (m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest_SizeNotEqual ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (2, 4, 2, 3, 5, 7, 8, 11, 13, 21, 34);

            bool expected = false;

            bool actual = (m1 == m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest_SizeEqual_ItemsNotEqual ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);

            bool expected = false;

            bool actual = (m1 == m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest_SizeEqual_ItemsEqual ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);

            bool expected = true;

            bool actual = (m1 == m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest_SizeNotEqual ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (2, 4, 2, 3, 5, 7, 8, 11, 13, 21, 34);

            bool expected = true;

            bool actual = (m1 != m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest_SizeEqual_ItemsNotEqual ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);

            bool expected = true;

            bool actual = (m1 != m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest_SizeEqual_ItemsEqual ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);

            bool expected = false;

            bool actual = (m1 != m2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opAddTest ()
        {
            Matrix m1 = new Matrix (2, 3, 2,  3,  5,  7, 11, 13);
            Matrix m2 = new Matrix (2, 3, 8, 13, 21, 34, 55, 89);

            Matrix expected = new Matrix (2, 3, 10, 16, 26, 41, 66, 102);

            Matrix actual = m1 + m2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opAddTest_Exception_SizeNotEqual ()
        {
            Matrix m1 = new Matrix (2, 3,  2,  3,  5, 7, 11, 13);
            Matrix m2 = new Matrix (1, 3, 13, 21, 34);

            bool expected = false;

            try
            {
                Matrix sum = m2 + m1;
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
            Matrix m1 = new Matrix (2, 3, 2,  3,  5,  7, 11, 13);
            Matrix m2 = new Matrix (2, 3, 8, 13, 21, 34, 55, 89);

            Matrix expected = new Matrix (2, 3, -6, -10, -16, -27, -44, -76);

            Matrix actual = m1 - m2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opSubtractTest_Exception_SizeNotEqual ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Matrix m2 = new Matrix (1, 3, 13, 21, 34);

            bool expected = false;

            try
            {
                Matrix difference = m2 - m1;
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
            Matrix m = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);

            Matrix expected = new Matrix (2, 3, -2, -3, -5, -7, -11, -13);

            Matrix actual = -m;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_MatrixByCoefficient ()
        {
            Matrix m           = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            double coefficient = 3;

            Matrix expected = new Matrix (2, 3, 6, 9, 15, 24, 39, 63);

            Matrix actual = m * coefficient;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_CoefficientByMatrix ()
        {
            Matrix m           = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            double coefficient = 3;

            Matrix expected = new Matrix (2, 3, 6, 9, 15, 24, 39, 63);

            Matrix actual = coefficient * m;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opDivideTest ()
        {
            Matrix m           = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            double coefficient = 4.0;

            Matrix expected = new Matrix (2, 3, 0.5, 0.75, 1.25, 2.0, 3.25, 5.25);

            Matrix actual = m / coefficient;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_MatrixVectorProduct ()
        {
            Matrix m1 = new Matrix (new double [,] { {  2,  3,  5,  7, 59 }, 
                                                     { 11, 13, 17, 19, 61 }, 
                                                     { 23, 29, 31, 37, 67 }, 
                                                     { 41, 43, 47, 53, 71 } });
            Vector v2 = new Vector (2, 3, 5, 7, 11);

            Vector expected = new Vector (736, 950, 1284, 1598);

            Vector actual = m1 * v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_MatrixVectorProduct_Exception_SizeNotCompatible ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);
            Vector v2 = new Vector (13, 21);

            bool expected = false;

            try
            {
                Vector product = m1 * v2;
            }

            catch (ArithmeticException)
            {
                expected = true;
            }

            Assert.IsTrue (expected);
        }

        [TestMethod ()]
        public void opMultiplyTest_VectorMatrixProduct ()
        {
            Vector v1 = new Vector (2, 3, 5, 7);
            Matrix m2 = new Matrix (new double [,] { {  2,  3,  5,  7, 59 }, 
                                                     { 11, 13, 17, 19, 61 }, 
                                                     { 23, 29, 31, 37, 67 }, 
                                                     { 41, 43, 47, 53, 71 } });
            
            Vector expected = new Vector (439, 491, 545, 627, 1133);

            Vector actual = v1 * m2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_VectorMatrixProduct_Exception_SizeNotCompatible ()
        {
            Vector v1 = new Vector (13, 21, 34);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);            

            bool expected = false;

            try
            {
                Vector product = v1 * m2;
            }

            catch (ArithmeticException)
            {
                expected = true;
            }

            Assert.IsTrue (expected);
        }

        [TestMethod ()]
        public void opMultiplyTest_MatrixMatrixProduct ()
        {
            Matrix m1 = new Matrix (new double [,] { {  2,  3,  5,  7, 59 }, 
                                                     { 11, 13, 17, 19, 61 }, 
                                                     { 23, 29, 31, 37, 67 }, 
                                                     { 41, 43, 47, 53, 71 } });
            Matrix m2 = new Matrix (new double [,] { {  2,  3,  5,  7 }, 
                                                     { 11, 13, 17, 19 }, 
                                                     { 23, 29, 31, 37 }, 
                                                     { 41, 43, 47, 53 }, 
                                                     { 59, 61, 67, 71 } });

            Matrix expected = new Matrix (new double [,] { { 3920 , 4090 , 4498 ,  4816 },
                                                           { 4934 , 5233 , 5783 ,  6291 },
                                                           { 6548 , 7023 , 7797 ,  8577 },
                                                           { 7998 , 8655 , 9641 , 10693 } });

            Matrix actual = m1 * m2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opMultiplyTest_MatrixMatrixProduct_Exception_SizeNotCompatible ()
        {
            Matrix m1 = new Matrix (2, 3, 2, 3, 5, 8, 13, 21);
            Matrix m2 = new Matrix (2, 3, 2, 3, 5, 7, 11, 13);

            bool expected = false;

            try
            {
                Matrix product = m1 * m2;
            }

            catch (ArithmeticException)
            {
                expected = true;
            }

            Assert.IsTrue (expected);
        }
    }
}