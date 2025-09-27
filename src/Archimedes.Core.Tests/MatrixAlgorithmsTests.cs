using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class MatrixAlgorithmsTests
    {
        [TestMethod ()]
        public void MatrixVectorMultiplicationTest ()
        {
            double [,] m1     = new double [,] { { 2, 3, 5, 7, 59 }, { 11, 13, 17, 19, 61 }, { 23, 29, 31, 37, 67 }, { 41, 43, 47, 53, 71 } };
            double []  v2     = new double []  { 2, 3, 5, 7, 11 };
            double []  actual = new double [4];

            int height1       = 4;
            int width1Length2 = 5;

            double [] expected = new double [] { 736, 950, 1284, 1598 };

            MatrixAlgorithms.MatrixVectorMultiplication (m1, v2, actual, height1, width1Length2);

            Assert.IsTrue (ArrayExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void VectorMatrixMultiplicationTest ()
        {
            double []  v1      = new double []  { 2, 3, 5, 7 };
            double [,] m2      = new double [,] { { 2, 3, 5, 7, 59 }, { 11, 13, 17, 19, 61 }, { 23, 29, 31, 37, 67 }, { 41, 43, 47, 53, 71 } };
            double []  actual  = new double [5];

            int length1Height2 = 4;
            int width2         = 5;

            double [] expected = new double [] { 439, 491, 545, 627, 1133 };

            MatrixAlgorithms.VectorMatrixMultiplication (v1, m2, actual, length1Height2, width2);

            Assert.IsTrue (ArrayExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void CommonMultiplicationTest ()
        {
            double [,] m1       = new double [,] { { 2, 3, 5, 7, 59 }, { 11, 13, 17, 19, 61 }, { 23, 29, 31, 37, 67 }, { 41, 43, 47, 53, 71 } };
            double [,] m2       = new double [,] { { 2, 3, 5, 7 }, { 11, 13, 17, 19 }, { 23, 29, 31, 37 }, { 41, 43, 47, 53 }, { 59, 61, 67, 71 } };
            double [,] actual   = new double [4, 4];

            int height1         = 4;
            int width1Height2   = 5;
            int width2          = 4;

            double [,] expected = new double [,] { { 3920 , 4090 , 4498 , 4816 }, 
                                                   { 4934 , 5233 , 5783 , 6291 }, 
                                                   { 6548 , 7023 , 7797 , 8577 },
                                                   { 7998 , 8655 , 9641 , 10693 } };

            MatrixAlgorithms.CommonMultiplication (m1, m2, actual, height1, width1Height2, width2);

            Assert.IsTrue (ArrayExtension.Equals (expected, actual));
        }
    }
}