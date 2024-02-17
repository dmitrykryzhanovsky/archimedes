using Archimedes;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class ArrayExtensionTests
    {
        [TestMethod ()]
        public void EqualsTest_NotEqualLength ()
        {
            int [] array1 = new int [] { 2, 3, 5 };
            int [] array2 = new int [] { 2, 3, 5, 7 };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualLength_NotEqualItems ()
        {
            int [] array1 = new int [] { 2, 3, 5, 7 };
            int [] array2 = new int [] { 2, 3, 4, 7 };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualLength_EqualItems ()
        {
            int [] array1 = new int [] { 2, 3, 5, 7 };
            int [] array2 = new int [] { 2, 3, 5, 7 };

            bool expected = true;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void FindMinIndexTest ()
        {
            int [] array = new int [] { 14, 27, 60, 10, 10, 37 };
            int beginIndex = 0;
            int endIndex = 2;

            int expected = 0;

            int actual = array.FindMinIndex (beginIndex, endIndex);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndex2Test_AA ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void MaxIndex2Test_AB ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void MaxIndex2Test_BA ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void MaxIndex3Test_AAA ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void MaxIndex3Test_ABB ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void MaxIndex3Test_BAA ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void MaxIndex3Test_AAB ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void MaxIndex3Test_BBA ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void MaxIndex3Test_ABA ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void MaxIndex3Test_BAB ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void MaxIndex3Test_ABC ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void MaxIndex3Test_ACB ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void MaxIndex3Test_BAC ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void MaxIndex3Test_BCA ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void MaxIndex3Test_CAB ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void MaxIndex3Test_CBA ()
        {
            Assert.Fail ();
        }
    }
}