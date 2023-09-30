using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class VectorAlgorithmTests
    {
        [TestMethod ()]
        public void AreSuitableForAlgebraTest_EqualDimensions ()
        {
            Vector v1 = new Vector (5);
            Vector v2 = new Vector (5);

            Assert.AreEqual (true, VectorAlgorithm.AreSuitableForAlgebra (v1, v2));
        }

        [TestMethod ()]
        public void AreSuitableForAlgebraTest_NotEqualDimensions ()
        {
            Vector v1 = new Vector (5);
            Vector v2 = new Vector (8);

            Assert.AreEqual (false, VectorAlgorithm.AreSuitableForAlgebra (v1, v2));
        }
    }
}