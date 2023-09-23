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
    }
}