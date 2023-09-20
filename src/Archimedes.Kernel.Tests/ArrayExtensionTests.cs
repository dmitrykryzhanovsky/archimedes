using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class ArrayExtensionTests
    {
        [TestMethod ()]
        public void EqualsFourItemsTest_EqualItems ()
        {
            double [] array1 = new double [] { 2, 3, 5, 8 };
            double [] array2 = new double [] { 2, 3, 5, 8 };

            Assert.AreEqual (true, array1.EqualsFourItems (array2));
        }

        [TestMethod ()]
        public void EqualsFourItemsTest_NotEqualItems ()
        {
            double [] array1 = new double [] { 2, 3, 5, 8 };
            double [] array2 = new double [] { 2, 4, 8, 16 };

            Assert.AreEqual (false, array1.EqualsFourItems (array2));
        }
    }
}