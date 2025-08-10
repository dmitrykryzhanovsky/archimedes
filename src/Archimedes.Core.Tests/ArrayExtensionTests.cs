using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class ArrayExtensionTests
    {
        [TestMethod ()]
        public void EqualsTest_LengthNotEqual ()
        {
            int [] array1 = new int [] { 2, 3, 5 };
            int [] array2 = new int [] { 2, 3, 5, 7 };

            bool expected = false;

            bool actual = ArrayExtension.Equals (array1, array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_LengthEqual_ItemsNotEqual ()
        {
            int [] array1 = new int [] { 2, 3, 5, 8 };
            int [] array2 = new int [] { 2, 3, 5, 7 };

            bool expected = false;

            bool actual = ArrayExtension.Equals (array1, array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_LengthEqual_ItemsEqual ()
        {
            int [] array1 = new int [] { 2, 3, 5, 8 };
            int [] array2 = new int [] { 2, 3, 5, 8 };

            bool expected = true;

            bool actual = ArrayExtension.Equals (array1, array2);

            Assert.AreEqual (expected, actual);
        }
    }
}