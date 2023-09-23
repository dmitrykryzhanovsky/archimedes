using Archimedes;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class MatrixAlgorithmTests
    {
        [TestMethod ()]
        public void AreSuitableForAdditionTest_EqualDimensions ()
        {
            Matrix m1 = new Matrix (2, 3);
            Matrix m2 = new Matrix (2, 3);

            Assert.AreEqual (true, MatrixAlgorithm.AreSuitableForAddition (m1, m2));
        }

        [TestMethod ()]
        public void AreSuitableForAdditionTest_NotEqualHeights ()
        {
            Matrix m1 = new Matrix (2, 3);
            Matrix m2 = new Matrix (5, 3);

            Assert.AreEqual (false, MatrixAlgorithm.AreSuitableForAddition (m1, m2));
        }

        [TestMethod ()]
        public void AreSuitableForAdditionTest_NotEqualWidths ()
        {
            Matrix m1 = new Matrix (2, 3);
            Matrix m2 = new Matrix (2, 5);

            Assert.AreEqual (false, MatrixAlgorithm.AreSuitableForAddition (m1, m2));
        }

        [TestMethod ()]
        public void AreSuitableForAdditionTest_NotEqualDimensions_1 ()
        {
            Matrix m1 = new Matrix (2, 3);
            Matrix m2 = new Matrix (3, 2);

            Assert.AreEqual (false, MatrixAlgorithm.AreSuitableForAddition (m1, m2));
        }

        [TestMethod ()]
        public void AreSuitableForAdditionTest_NotEqualDimensions_2 ()
        {
            Matrix m1 = new Matrix (2, 3);
            Matrix m2 = new Matrix (5, 8);

            Assert.AreEqual (false, MatrixAlgorithm.AreSuitableForAddition (m1, m2));
        }

        [TestMethod ()]
        public void AreSuitableForMultiplicationTest_Compatible ()
        {
            Matrix m1 = new Matrix (2, 3);
            Matrix m2 = new Matrix (3, 5);

            Assert.AreEqual (true, MatrixAlgorithm.AreSuitableForMultiplication (m1, m2));
        }

        [TestMethod ()]
        public void AreSuitableForMultiplicationTest_Imcompatible ()
        {
            Matrix m1 = new Matrix (3, 5);
            Matrix m2 = new Matrix (2, 3);

            Assert.AreEqual (false, MatrixAlgorithm.AreSuitableForMultiplication (m1, m2));
        }

        [TestMethod ()]
        public void StandardMultiplicationTest ()
        {
            int height = 2;
            int innerSize = 3;
            int width = 4;

            double [] C = new double [height * width];
            double [] A = new double [] { 4, 7, 9, 8, 0, 8 };
            double [] B = new double [] { 0, 1, 1, 2, 0, 7, 7, 7, 0, 4, 0, 7 };

            MatrixAlgorithm.StandardMultiplication (C, A, B, height, innerSize, width);

            Assert.AreEqual (8, C.Length);

            Assert.AreEqual (0, C [0]);
            Assert.AreEqual (89, C [1]);
            Assert.AreEqual (53, C [2]);
            Assert.AreEqual (120, C [3]);
            Assert.AreEqual (0, C [4]);
            Assert.AreEqual (40, C [5]);
            Assert.AreEqual (8, C [6]);
            Assert.AreEqual (72, C [7]);
        }
    }
}