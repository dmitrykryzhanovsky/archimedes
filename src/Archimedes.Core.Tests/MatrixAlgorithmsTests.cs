using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class MatrixAlgorithmsTests
    {
        [TestMethod ()]
        public void MatrixVectorMultiplicationTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void VectorMatrixMultiplicationTest ()
        {
            double []  v1      = new double []  { 2, 3, 5, 7 };
            double [,] m2      = new double [,] { { 2, 3, 5, 7, 59 }, { 11, 13, 17, 19, 61 }, { 23, 29, 31, 37, 67 }, { 41, 43, 47, 53, 71 } };
            double []  actual  = new double [5];

            int length1height2 = 4;
            int width2         = 5;

            double [] expected = new double [] { 439, 491, 545, 627, 1133 };

            MatrixAlgorithms.VectorMatrixMultiplication (v1, m2, actual, length1height2, width2);

            Assert.IsTrue (ArrayExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void CommonMultiplicationTest ()
        {
            Assert.Fail ();
        }
    }
}